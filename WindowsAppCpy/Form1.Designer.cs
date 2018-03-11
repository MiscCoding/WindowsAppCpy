namespace WindowsAppCpy
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxSourceFileText = new System.Windows.Forms.TextBox();
            this.txtBxFolderName = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorIndication = new System.Windows.Forms.Label();
            this.btnCopyPaste = new System.Windows.Forms.Button();
            this.lstFldrBox = new System.Windows.Forms.ListBox();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.btnCopytoTarget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxSourceFileText
            // 
            this.txtBxSourceFileText.Location = new System.Drawing.Point(68, 49);
            this.txtBxSourceFileText.Name = "txtBxSourceFileText";
            this.txtBxSourceFileText.Size = new System.Drawing.Size(113, 25);
            this.txtBxSourceFileText.TabIndex = 0;
            // 
            // txtBxFolderName
            // 
            this.txtBxFolderName.Location = new System.Drawing.Point(417, 49);
            this.txtBxFolderName.Name = "txtBxFolderName";
            this.txtBxFolderName.Size = new System.Drawing.Size(134, 25);
            this.txtBxFolderName.TabIndex = 1;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(78, 22);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(88, 15);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Source Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Target Folder";
            // 
            // lblErrorIndication
            // 
            this.lblErrorIndication.AutoSize = true;
            this.lblErrorIndication.Location = new System.Drawing.Point(242, 84);
            this.lblErrorIndication.Name = "lblErrorIndication";
            this.lblErrorIndication.Size = new System.Drawing.Size(116, 15);
            this.lblErrorIndication.TabIndex = 4;
            this.lblErrorIndication.Text = "Status Indication";
            // 
            // btnCopyPaste
            // 
            this.btnCopyPaste.Location = new System.Drawing.Point(68, 98);
            this.btnCopyPaste.Name = "btnCopyPaste";
            this.btnCopyPaste.Size = new System.Drawing.Size(113, 50);
            this.btnCopyPaste.TabIndex = 5;
            this.btnCopyPaste.Text = "Read folders";
            this.btnCopyPaste.UseVisualStyleBackColor = true;
            this.btnCopyPaste.Click += new System.EventHandler(this.btnCopyPaste_Click);
            // 
            // lstFldrBox
            // 
            this.lstFldrBox.FormattingEnabled = true;
            this.lstFldrBox.HorizontalScrollbar = true;
            this.lstFldrBox.ItemHeight = 15;
            this.lstFldrBox.Location = new System.Drawing.Point(12, 154);
            this.lstFldrBox.Name = "lstFldrBox";
            this.lstFldrBox.Size = new System.Drawing.Size(211, 94);
            this.lstFldrBox.TabIndex = 6;
            // 
            // lstFileList
            // 
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.HorizontalScrollbar = true;
            this.lstFileList.ItemHeight = 15;
            this.lstFileList.Location = new System.Drawing.Point(379, 154);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.Size = new System.Drawing.Size(211, 94);
            this.lstFileList.TabIndex = 7;
            // 
            // btnCopytoTarget
            // 
            this.btnCopytoTarget.Location = new System.Drawing.Point(417, 98);
            this.btnCopytoTarget.Name = "btnCopytoTarget";
            this.btnCopytoTarget.Size = new System.Drawing.Size(134, 50);
            this.btnCopytoTarget.TabIndex = 8;
            this.btnCopytoTarget.Text = "Copy files to target";
            this.btnCopytoTarget.UseVisualStyleBackColor = true;
            this.btnCopytoTarget.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 275);
            this.Controls.Add(this.btnCopytoTarget);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.lstFldrBox);
            this.Controls.Add(this.btnCopyPaste);
            this.Controls.Add(this.lblErrorIndication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtBxFolderName);
            this.Controls.Add(this.txtBxSourceFileText);
            this.Name = "Form1";
            this.Text = "File Copy & Paste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxSourceFileText;
        private System.Windows.Forms.TextBox txtBxFolderName;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorIndication;
        private System.Windows.Forms.Button btnCopyPaste;
        private System.Windows.Forms.ListBox lstFldrBox;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.Button btnCopytoTarget;
    }
}

