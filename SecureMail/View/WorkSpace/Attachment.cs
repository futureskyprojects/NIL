using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using System.IO;

namespace SecureMail.WorkSpace
{
    public partial class Attachment : UserControl
    {
        string FileNameX = string.Empty;
        string AttachmentId = string.Empty;
        public bool IsEncrypted = false;
        public Attachment(string _FileName, string _AttId, bool _IsEncrypted)
        {
            FileNameX = _FileName;
            AttachmentId = _AttId;
            IsEncrypted = _IsEncrypted;
            InitializeComponent();
        }

        private void Attachment_Load(object sender, EventArgs e)
        {
            FileName.Text = FileNameX;
        }

        private void FileName_Click(object sender, EventArgs e)
        {
            CallLoadingIcon();
            System.Threading.Thread ThreadCall = new System.Threading.Thread(
                new System.Threading.ThreadStart(DownloadNow));
            ThreadCall.Start();
        }

        private void FileName_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LimeGreen;
        }

        private void FileName_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
        private void CallLoadingIcon()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CallLoadingIcon));
                return;
            }
            //
            Icon.Image = Properties.Resources._2Sdtwfj;
        }
        private void CallDefaultIcon()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CallDefaultIcon));
                return;
            }
            //
            Icon.Image = Properties.Resources._004_download_button;
        }
        private void DownloadNow()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(DownloadNow));
                return;
            }
            DialogResult A = MessageBox.Show("Download '" + FileNameX + "'?", "DOWLOAD?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (A == DialogResult.No)
            {
                CallDefaultIcon();
                return;
            }
            // OpenDialog to select local
            FolderBrowserDialog Folder = new FolderBrowserDialog();
            Folder.ShowNewFolderButton = true;
            Folder.Description = "Select folder to save this file!";
            Folder.ShowDialog();
            if (String.IsNullOrEmpty(Folder.SelectedPath))
            {
                MessageBox.Show("No path selected!", "EMPTY!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CallDefaultIcon();
                return;
            }
            // Finish all pre then download
            Attachments DownloadAtt = new Attachments();
            string[] TempData = DownloadAtt.Download(AttachmentId);
            if (IsEncrypted == true)
            {
                DialogResult ask = MessageBox.Show("This file is encrypted! Do you want decrypt it now?", "DECRYPT THIS FILE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    // Check key
                    EnterKey KeyIn = new EnterKey();
                    while (true)
                    {
                        Operations.Content.Message.CurrentPassword = string.Empty;
                        KeyIn.ShowDialog();
                        if (Operations.Content.Message.CurrentPassword == string.Empty)
                        {
                            MessageBox.Show("This content is WhiteSpace or Empty!",
                                "NO CONTENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                        #region For Decrypt
                        byte[] Temp;
                        switch (Operations.GlobalVarriable.KindOfCrypt)
                        {
                            case 0:
                                {
                                    Temp = Operations.AES.DecryptFile(TempData[0], Operations.Content.Message.CurrentPassword);
                                    break;
                                }
                            case 1:
                                {
                                    Temp = Operations.DES.DecryptFile(TempData[0], Operations.Content.Message.CurrentPassword);
                                    break;
                                }
                            case 2:
                                {
                                    Temp = Operations.TwoFish.DecryptFile(TempData[0], Operations.Content.Message.CurrentPassword);
                                    break;
                                }
                            case 3:
                                {
                                    Temp = Operations.BlowFish.DecryptFile(TempData[0], Operations.Content.Message.CurrentPassword);
                                    break;
                                }
                            default:
                                Temp = Operations.AES.DecryptFile(TempData[0], Operations.Content.Message.CurrentPassword);
                                break;
                        }
                        #endregion
                        if (Temp == null)
                        {
                            DialogResult C = MessageBox.Show("Wrong password! Do you want to try again?", "TRY AGAIN?", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                            if (C == DialogResult.No)
                            {
                                DialogResult D = MessageBox.Show("Try to download without decrypt?", "TRY TO DOWNLOAD?",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (DialogResult.No == D)
                                {
                                    CallDefaultIcon();
                                    return;
                                }
                                else
                                {
                                    Operations.Content.Message.CurrentPassword = string.Empty;
                                    break;
                                }
                            }
                            else
                                continue;
                        }
                        else
                        {
                            try
                            {
                                string SavePath = Path.Combine(Folder.SelectedPath, FileNameX);
                                while (File.Exists(SavePath))
                                {
                                    System.Security.Cryptography.MD5 Hash = System.Security.Cryptography.MD5.Create();
                                    SavePath = Folder.SelectedPath + "\\" +
                                        Path.GetFileNameWithoutExtension(FileNameX) +
                                        "_" + BitConverter.ToString(Hash.ComputeHash(
                                        Encoding.UTF8.GetBytes(DateTime.Now.ToString()))).Replace("-", "") +
                                        Path.GetExtension(FileNameX);
                                }
                                File.WriteAllBytes(SavePath, Temp);
                                SuccessBox.Show("Successfully decrypted!");
                                Temp = null;
                                TempData = null;
                                DownloadAtt = null;
                                CallDefaultIcon();
                                return;
                            }
                            catch (Exception ee)
                            {
                                MessageBox.Show("Can not save '" + FileNameX + "', Try run this program with administration and try again!",
                                    "CAN NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                CallDefaultIcon();
                                MessageBox.Show(ee.ToString());
                                return;
                            }
                        }
                    }
                }
            }
            // No encrypt
            try
            {
                string SavePath = Path.Combine(Folder.SelectedPath, FileNameX);
                while (File.Exists(SavePath))
                {
                    System.Security.Cryptography.MD5 Hash = System.Security.Cryptography.MD5.Create();
                    SavePath = Folder.SelectedPath + "\\" +
                        Path.GetFileNameWithoutExtension(FileNameX) +
                        "_" + BitConverter.ToString(Hash.ComputeHash(
                        Encoding.UTF8.GetBytes(DateTime.Now.ToString()))).Replace("-", "") +
                        Path.GetExtension(FileNameX);
                }
                File.WriteAllBytes(SavePath, Convert.FromBase64String(TempData[0]));
                SuccessBox.Show("Successfully saved!");
                TempData = null;
                DownloadAtt = null;
                CallDefaultIcon();
                return;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Can not save '" + FileNameX + "', Try run this program with administration and try again!",
                    "CAN NOT SAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CallDefaultIcon();
                MessageBox.Show(ee.ToString());
                return;
            }
        }
    }
    public class Attachments
    {
        public string[] Download(string AttId)
        {
            MessagePartBody Attachment = Operations.Gmail.Connect.service.Users.Messages.Attachments.Get("me", Operations.Content.Message.ID, AttId).Execute();
            // Converting from RFC 4648 base64 to base64url encoding
            string[] Result = new string[2];
            Result[0] = Attachment.Data.Replace('-', '+').Replace('_', '/');
            Result[1] = Attachment.Size.ToString();
            return Result;
        }
    }
}
