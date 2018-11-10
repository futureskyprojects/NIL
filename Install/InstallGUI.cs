using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Threading;
using System.Diagnostics;
using IWshRuntimeLibrary;

namespace Install
{
    public partial class InstallGUI : Form
    {
        public InstallGUI()
        {
            InitializeComponent();
        }

        private void closeWD_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Program is installing, Do you want to stop it and close?", "STOP INSTALL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.No)
                return;
            else
            {
                Close();
            }
        }
        void ForDev()
        {
            #region For Dev
            // Compress the source file
            string SourcePath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath)))) + @"\SecureMail\bin\Release";
            if (Directory.Exists(SourcePath))
            {
                try
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(SourcePath, Path.GetDirectoryName(Application.ExecutablePath) + @"\NIL");
                    MessageBox.Show("Coppy completed!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot coppy! Please delete before update!");
                }
            }
            else
            {
                MessageBox.Show("Sorry! The path not avilble!");
                Application.Exit();
                return;
            }
            // Compress file
            try
            {
                ZipFile.CreateFromDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\NIL", "NIL.tnsoft");
                MessageBox.Show("Compress complete!");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not compress!");
            }
            #endregion
        }
        string ProgramFilesx86()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }
        private void InstallGUI_Load(object sender, EventArgs e)
        {
            localX.Text = ProgramFilesx86() + "\\IATT & NGHIA\\NIL Info Mail";
            //ForDev();
            return;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ChangeX = new FolderBrowserDialog();
            ChangeX.ShowNewFolderButton = true;
            ChangeX.Description = "Select destiantion install";
            ChangeX.ShowDialog();
            if (String.IsNullOrEmpty(ChangeX.SelectedPath))
                localX.Text = ProgramFilesx86() + "\\IATT & NGHIA\\NIL Info Mail";
            else
                localX.Text = ChangeX.SelectedPath;
        }
        void _Run1()
        {
            _1.ForeColor = Color.Black;
            for (progress.Value = 0; progress.Value < 100; progress.Value++)
            {
                Thread.Sleep(1);
            }
        }
        void _Run2()
        {
            _1.ForeColor = Color.White;
            _2.ForeColor = Color.Black;
            for (progress.Value = 0; progress.Value < 100; progress.Value++)
            {
                Thread.Sleep(1);
            }
        }
        void _Run3()
        {
            _2.ForeColor = Color.White;
            _3.ForeColor = Color.Black;
            for (progress.Value = 0; progress.Value < 100; progress.Value++)
            {
                Thread.Sleep(1);
            }
        }
        void _Run4()
        {
            _3.ForeColor = Color.White;
            _4.ForeColor = Color.Black;
            for (progress.Value = 0; progress.Value < 100; progress.Value++)
            {
                Thread.Sleep(1);
            }
        }
        void Effect()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(Effect));
                return;
            }
            //_Run1();
            //_Run2();
            //_Run3();
            _Run4();
            //        DialogResult a = MessageBox.Show("Do you want open NIL Info Mail now?", "OPEN NOW?",
            //MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (a == DialogResult.No)
            //            Close();
            //        else
            //            try
            //            {
            //                Process.Start(localX.Text + @"\SecureMail.exe");
            //            }
            //            catch (Exception)
            //            {
            //                MessageBox.Show("Can not open it now!");
            //            }
            #region create shortcut
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\NIL Info Mail.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Shortcut of NIL Info Mail";
            shortcut.Hotkey = "Ctrl+Alt+N";
            shortcut.TargetPath = localX.Text + @"\SecureMail.exe";
            shortcut.RelativePath = localX.Text;
            shortcut.WorkingDirectory = localX.Text;
            shortcut.Save();
            #endregion
            MessageBox.Show("Install success!","DONE!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
        void RunIT()
        {
            Effect();
        }
        private void install_Click(object sender, EventArgs e)
        {
            // Lock change folder install and show path box
            localX.Enabled = false;
            Change.Enabled = false;
            progress._Value = 0;
            statusbox.Text = string.Empty;
            // Step 1. Extract
            try
            {
                System.IO.File.WriteAllBytes("NIL.tnsoft", Properties.Resources.NIL);
                if (Directory.Exists(localX.Text))
                {
                    DialogResult x = MessageBox.Show("This path is exists! Do you want remove to install?","CLEAN LOCATION",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (x == DialogResult.No)
                    {
                        localX.Enabled = !false;
                        Change.Enabled = !false;
                        progress._Value = 0;
                        statusbox.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        Directory.Delete(localX.Text,true);
                    }
                }
                ZipFile.ExtractToDirectory("NIL.tnsoft", localX.Text);
                System.IO.File.Delete("NIL.tnsoft");
                RunIT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not extract file!", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
                localX.Enabled = true;

                Change.Enabled = !false;
                return;
            }
        }

        private void InstallGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.IsDisposed)
                Dispose();
        }
    }
}
