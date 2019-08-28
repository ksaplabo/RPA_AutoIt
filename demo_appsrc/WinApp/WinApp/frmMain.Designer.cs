namespace WinApp
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdEnd = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.dlgFileSelect = new System.Windows.Forms.OpenFileDialog();
            this.cmdFileSelect = new System.Windows.Forms.Button();
            this.txtFileData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdEnd
            // 
            this.cmdEnd.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdEnd.Location = new System.Drawing.Point(342, 275);
            this.cmdEnd.Name = "cmdEnd";
            this.cmdEnd.Size = new System.Drawing.Size(83, 44);
            this.cmdEnd.TabIndex = 0;
            this.cmdEnd.Text = "終了";
            this.cmdEnd.UseVisualStyleBackColor = true;
            this.cmdEnd.Click += new System.EventHandler(this.CmdEnd_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdSave.Location = new System.Drawing.Point(253, 275);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(83, 44);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "保存";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFilePath.Location = new System.Drawing.Point(105, 55);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(264, 23);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Validated += new System.EventHandler(this.TxtFilePath_Validated);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPath.Location = new System.Drawing.Point(27, 56);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(72, 15);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "ファイルパス：";
            // 
            // dlgFileSelect
            // 
            this.dlgFileSelect.FileName = "openFileDialog1";
            // 
            // cmdFileSelect
            // 
            this.cmdFileSelect.Location = new System.Drawing.Point(379, 55);
            this.cmdFileSelect.Name = "cmdFileSelect";
            this.cmdFileSelect.Size = new System.Drawing.Size(23, 23);
            this.cmdFileSelect.TabIndex = 4;
            this.cmdFileSelect.Text = "…";
            this.cmdFileSelect.UseVisualStyleBackColor = true;
            this.cmdFileSelect.Click += new System.EventHandler(this.CmdFileSelect_Click);
            // 
            // txtFileData
            // 
            this.txtFileData.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFileData.Location = new System.Drawing.Point(105, 90);
            this.txtFileData.Multiline = true;
            this.txtFileData.Name = "txtFileData";
            this.txtFileData.Size = new System.Drawing.Size(263, 179);
            this.txtFileData.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ファイル内容：";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Meiryo UI", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(10, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 28);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "ファイル編集";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdCancel.Location = new System.Drawing.Point(164, 275);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(83, 44);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "取消";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 331);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileData);
            this.Controls.Add(this.cmdFileSelect);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "メイン画面";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEnd;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog dlgFileSelect;
        private System.Windows.Forms.Button cmdFileSelect;
        private System.Windows.Forms.TextBox txtFileData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdCancel;
    }
}

