
namespace Quest2_Sideloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.BTNCheckCon = new System.Windows.Forms.Button();
            this.cbConnected = new System.Windows.Forms.CheckBox();
            this.RTBDebug = new System.Windows.Forms.RichTextBox();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.BTNFastboot = new System.Windows.Forms.Button();
            this.cbBootloader = new System.Windows.Forms.CheckBox();
            this.cbSideload = new System.Windows.Forms.CheckBox();
            this.BTNSideload = new System.Windows.Forms.Button();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.cbFlashed = new System.Windows.Forms.CheckBox();
            this.BTNFlash = new System.Windows.Forms.Button();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(6, 9);
            this.lblInfo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(346, 13);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Step 1: Disconnect all android devices (except your quest2) from the PC";
            // 
            // BTNCheckCon
            // 
            this.BTNCheckCon.Location = new System.Drawing.Point(6, 33);
            this.BTNCheckCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNCheckCon.Name = "BTNCheckCon";
            this.BTNCheckCon.Size = new System.Drawing.Size(256, 23);
            this.BTNCheckCon.TabIndex = 1;
            this.BTNCheckCon.Text = "Check Quest 2 connection";
            this.BTNCheckCon.UseVisualStyleBackColor = true;
            this.BTNCheckCon.Click += new System.EventHandler(this.BTNCheckCon_Click);
            // 
            // cbConnected
            // 
            this.cbConnected.AutoCheck = false;
            this.cbConnected.AutoSize = true;
            this.cbConnected.Location = new System.Drawing.Point(288, 37);
            this.cbConnected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbConnected.Name = "cbConnected";
            this.cbConnected.Size = new System.Drawing.Size(78, 17);
            this.cbConnected.TabIndex = 2;
            this.cbConnected.Text = "Connected";
            this.cbConnected.UseVisualStyleBackColor = true;
            // 
            // RTBDebug
            // 
            this.RTBDebug.Location = new System.Drawing.Point(6, 242);
            this.RTBDebug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBDebug.Name = "RTBDebug";
            this.RTBDebug.ReadOnly = true;
            this.RTBDebug.Size = new System.Drawing.Size(411, 186);
            this.RTBDebug.TabIndex = 3;
            this.RTBDebug.Text = "";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(6, 64);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(195, 13);
            this.lblInfo2.TabIndex = 4;
            this.lblInfo2.Text = "Step 2: Reboot quest2 in fastboot mode";
            // 
            // BTNFastboot
            // 
            this.BTNFastboot.Location = new System.Drawing.Point(6, 86);
            this.BTNFastboot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNFastboot.Name = "BTNFastboot";
            this.BTNFastboot.Size = new System.Drawing.Size(256, 22);
            this.BTNFastboot.TabIndex = 5;
            this.BTNFastboot.Text = "Enter Bootloader Mode";
            this.BTNFastboot.UseVisualStyleBackColor = true;
            this.BTNFastboot.Click += new System.EventHandler(this.BTNFastboot_Click);
            // 
            // cbBootloader
            // 
            this.cbBootloader.AutoCheck = false;
            this.cbBootloader.AutoSize = true;
            this.cbBootloader.Location = new System.Drawing.Point(288, 89);
            this.cbBootloader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBootloader.Name = "cbBootloader";
            this.cbBootloader.Size = new System.Drawing.Size(127, 17);
            this.cbBootloader.TabIndex = 6;
            this.cbBootloader.Text = "Is in bootloader mode";
            this.cbBootloader.UseVisualStyleBackColor = true;
            // 
            // cbSideload
            // 
            this.cbSideload.AutoCheck = false;
            this.cbSideload.AutoSize = true;
            this.cbSideload.Location = new System.Drawing.Point(289, 143);
            this.cbSideload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSideload.Name = "cbSideload";
            this.cbSideload.Size = new System.Drawing.Size(116, 17);
            this.cbSideload.TabIndex = 9;
            this.cbSideload.Text = "Is in sideload mode";
            this.cbSideload.UseVisualStyleBackColor = true;
            // 
            // BTNSideload
            // 
            this.BTNSideload.Location = new System.Drawing.Point(7, 139);
            this.BTNSideload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNSideload.Name = "BTNSideload";
            this.BTNSideload.Size = new System.Drawing.Size(255, 22);
            this.BTNSideload.TabIndex = 8;
            this.BTNSideload.Text = "Enter Sideload Mode";
            this.BTNSideload.UseVisualStyleBackColor = true;
            this.BTNSideload.Click += new System.EventHandler(this.BTNSideload_Click);
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Location = new System.Drawing.Point(7, 118);
            this.lblInfo3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(139, 13);
            this.lblInfo3.TabIndex = 7;
            this.lblInfo3.Text = "Step 3: enter sideload mode";
            // 
            // cbFlashed
            // 
            this.cbFlashed.AutoCheck = false;
            this.cbFlashed.AutoSize = true;
            this.cbFlashed.Location = new System.Drawing.Point(289, 197);
            this.cbFlashed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFlashed.Name = "cbFlashed";
            this.cbFlashed.Size = new System.Drawing.Size(71, 17);
            this.cbFlashed.TabIndex = 12;
            this.cbFlashed.Text = "Is flashed";
            this.cbFlashed.UseVisualStyleBackColor = true;
            // 
            // BTNFlash
            // 
            this.BTNFlash.Location = new System.Drawing.Point(7, 193);
            this.BTNFlash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNFlash.Name = "BTNFlash";
            this.BTNFlash.Size = new System.Drawing.Size(255, 22);
            this.BTNFlash.TabIndex = 11;
            this.BTNFlash.Text = "Flash Update";
            this.BTNFlash.UseVisualStyleBackColor = true;
            this.BTNFlash.Click += new System.EventHandler(this.BTNFlash_Click);
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Location = new System.Drawing.Point(7, 172);
            this.lblInfo4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(102, 13);
            this.lblInfo4.TabIndex = 10;
            this.lblInfo4.Text = "Step 4: flash update";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(6, 228);
            this.lblDebug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(93, 13);
            this.lblDebug.TabIndex = 13;
            this.lblDebug.Text = "DEBUG OUTPUT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 444);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.cbFlashed);
            this.Controls.Add(this.BTNFlash);
            this.Controls.Add(this.lblInfo4);
            this.Controls.Add(this.cbSideload);
            this.Controls.Add(this.BTNSideload);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.cbBootloader);
            this.Controls.Add(this.BTNFastboot);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.RTBDebug);
            this.Controls.Add(this.cbConnected);
            this.Controls.Add(this.BTNCheckCon);
            this.Controls.Add(this.lblInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quest 2 sideload tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Button BTNCheckCon;
        private System.Windows.Forms.CheckBox cbConnected;
        private System.Windows.Forms.RichTextBox RTBDebug;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Button BTNFastboot;
        private System.Windows.Forms.CheckBox cbBootloader;
        private System.Windows.Forms.CheckBox cbSideload;
        private System.Windows.Forms.Button BTNSideload;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.CheckBox cbFlashed;
        private System.Windows.Forms.Button BTNFlash;
        private System.Windows.Forms.Label lblInfo4;
        private System.Windows.Forms.Label lblDebug;
    }
}

