using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace Quest2_Sideloader
{
    public partial class Form1 : Form
    {
        public static string appPath = Application.StartupPath;
        public static string adbPath = appPath + "\\platformTools\\adb.exe";
        public static string fastbootPath = appPath + "\\platformTools\\fastboot.exe";
        public string questID = "";

        public Form1()
        {
            InitializeComponent();
            BTNFastboot.Enabled = false;
            BTNSideload.Enabled = false;
            BTNFlash.Enabled = false;
            RTBDebug.HideSelection = false;

            if (!(File.Exists(adbPath) && File.Exists(fastbootPath)))
            {
                MessageBox.Show("Platform tools (adb and/or fastboot) are missing, please delete this folder and extract this tool again!");
                System.Environment.Exit(1);
            }
        }

        private string RunCommand(string exec, string args)
        {
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = exec;
            p.StartInfo.Arguments = args;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }

        private void SaveLogToFile()
        {
            string logPath = appPath + "\\LogFile_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";
            using (File.Create(logPath)) ;
            RTBDebug.SaveFile(logPath, RichTextBoxStreamType.PlainText);
        }

        private void BTNCheckCon_Click(object sender, EventArgs e)
        {
            string adb_devices = RunCommand(adbPath, "devices");
            RTBDebug.AppendText(adb_devices + "\n");

            if (Regex.IsMatch(adb_devices, @"\bunauthorized\b"))
            {
                //A device is connected but not authorized, let's tell the user
                MessageBox.Show("Put on your headset and authorize usb debug, then try again");
            }
            else if (Regex.IsMatch(adb_devices, @"\bdevice\b") && Regex.IsMatch(adb_devices, @"\b1WMHH\S*"))
            {
                //A device is connected and authorized, we're good!
                //Grab the quest serial for use in the following commands
                if (!(Regex.Matches(adb_devices, @"\b1WMHH\S*").Count > 1))
                {
                    questID = Regex.Matches(adb_devices, @"\b1WMHH\S*")[0].Value;

                    cbConnected.Checked = true;
                    BTNFastboot.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Seems like you have more than 1 quest 2 device connected to your PC. Please only connect 1 device and try again!");
                }
            }
            else
            {
                //No device connected
                MessageBox.Show("Device not found, make sure that your quest is connected and is recognized as an ADB Device in device manager");
            }
        }

        private void BTNFastboot_Click(object sender, EventArgs e)
        {
            string reboot_fastboot = RunCommand(adbPath, "-s " + questID +  " reboot bootloader");
            RTBDebug.AppendText(reboot_fastboot + "\n");
            bool gotFastBoot = false;

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(5000);
                string check_fastboot = RunCommand(fastbootPath, "devices");
                RTBDebug.AppendText(check_fastboot + "\n");

                if (Regex.IsMatch(check_fastboot, @"\bfastboot\b"))
                {
                    //the quest is in fastboot mode, we can exit the loop and go to the next step
                    cbBootloader.Checked = true;
                    BTNSideload.Enabled = true;
                    gotFastBoot = true;
                    break;
                }
            }

            if (!gotFastBoot)
            {
                MessageBox.Show("No device in fastboot mode found, make sure that your quest is recognized as a Fastboot Device in device manager");
            }
        }

        private void BTNSideload_Click(object sender, EventArgs e)
        {
            string reboot_sideload = RunCommand(fastbootPath, "oem reboot-sideload");
            RTBDebug.AppendText(reboot_sideload + "\n");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(5000);
                string check_sideload = RunCommand(adbPath, "devices");
                RTBDebug.AppendText(check_sideload + "\n");

                if (Regex.IsMatch(check_sideload, @"\bsideload\b"))
                {
                    //the quest is in fastboot mode, we can exit the loop and go to the next step
                    cbSideload.Checked = true;
                    BTNFlash.Enabled = true;
                    break;
                }
            }
        }

        private void BTNFlash_Click(object sender, EventArgs e)
        {
            if (File.Exists("update.zip"))
            {
                MessageBox.Show("This process WILL take a while to execute (2 to 10 minutes). Do NOT close any windows or disconnect the quest 2 until the update is finished!");
                string sideload = RunCommand(adbPath, "sideload -s " + appPath + "\\update.zip");
                RTBDebug.AppendText(sideload + "\n");
                cbFlashed.Checked = true;
                BTNFlash.Enabled = false;
                MessageBox.Show("Sideloading DONE! WAIT FOR YOUR QUEST 2 TO REBOOT ITSELF, THEN REBOOT IT MANUALLY AGAIN!\n If you still have the old software version there might have been some problem with the sideloading. Please send the log file to someone knowledgeable.");
                SaveLogToFile();
            }
            else
            {
                MessageBox.Show("No update.zip found! Copy the update.zip in the same folder as this program!");
            }
        }
    }
}
