# Requirements
* ADB / Fastboot drivers (should be already installed with the oculus software)
* .NET Framework 4.8 (already installed on Win 10 / the system will prompt you to install it if needed)
* Developer mode enabled on the Quest 2

# Notes
* adb and fastboot executables are already included in the release package, no need to manually install them beforehand
* the tool automatically selects only quest 2 devices and ignores any other android device

# How to use
1. Download the compiled package from the Release section
2. Uncompress it into a folder of your choice
3. Put the Quest 2 update zip file in the same folder of this program and rename it as "update.zip"
4. Power on your Quest 2 and connect it to your PC
5. Run the program Quest2-sideload-Wrapper and follow the instruction

# Troubleshooting
* If you run into any problem copy the debug log that the program automatically creates in its folder and send it to someone knowledgeable.

# Compiling
If you want to compile this from the source code, you'll need Visual Studio 2019 and .NET Framework 4.8.
You'll also need to manually put adb.exe, fastboot.exe, AdbWinApi.dll and AdbWinUsbApi.dll in a folder named "platformTools" placed in the same folder that the executable is in.
