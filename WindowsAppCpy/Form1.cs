using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections;



namespace WindowsAppCpy
{
    public partial class Form1 : Form
    {
        string appPath = "";
        private string[] pdfFiles;
        string fileSelection = "";
        string newFolder = "";

        private void initialize() {
            fileSelection = "";
            appPath = "";
            newFolder = "";
            this.lstFileList.Items.Clear();
            this.lstFldrBox.Items.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            appPath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        private void btnCopyPaste_Click(object sender, EventArgs e)
        {
            if (this.txtBxSourceFileText.Text == "")
            {
                this.lblErrorIndication.Text = "입력된 파일명에 맞는 파일이 없습니다.";
            }
            else
            {
                fileSelection = "*" + this.txtBxSourceFileText.Text + "*.jpg";
            }
            GetDirectories();
        }

        private void GetDirectories()
        {

            
            string [] fileArray = Directory.GetDirectories(appPath);
            for (int i = 0; i < fileArray.Length; i++)
            {
                
                this.lstFldrBox.Items.Add(fileArray[i]);
                GetFileNames(fileArray[i], fileSelection);
            }

            void GetFileNames(string path, string filter)
            {
                string[] files = Directory.GetFiles(path, filter);
                for (int i = 0; i < files.Length; i++)
                {
                    this.lstFileList.Items.Add(files[i]);
                    files[i] = Path.GetFileName(files[i]);
                    
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files;
            string tempFileName = "";
            string destFileNameFoler = "";
            if (this.txtBxFolderName.Text == "")
                this.lblErrorIndication.Text = "Target 폴더명이 없습니다.";
            else {
                newFolder = appPath + "\\" + this.txtBxFolderName.Text;
                Directory.CreateDirectory(newFolder);
                copyfiles(newFolder);
                initialize();
            }

            void copyfiles(string newFolder)
            {
                files = new string[this.lstFileList.Items.Count];
                tempFileName = "";
                destFileNameFoler = "";
                for (int i = 0; i < this.lstFileList.Items.Count; i++)
                {
                    files[i] = this.lstFileList.Items[i].ToString();
                    tempFileName = Path.GetFileName(files[i]);
                    destFileNameFoler = Path.Combine(newFolder, tempFileName);
                    File.Copy(this.lstFileList.Items[i].ToString(), destFileNameFoler, true);
                }
                this.lblErrorIndication.Text = "파일복사 완료";
            }




        }
    }
}
