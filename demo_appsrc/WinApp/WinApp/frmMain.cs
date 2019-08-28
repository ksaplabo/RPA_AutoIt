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

namespace WinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // フォーム初期化
            this.initForm();
        }

        private void CmdFileSelect_Click(object sender, EventArgs e)
        {
            dlgFileSelect.FileName = "";
            dlgFileSelect.Filter = "テキスト ファイル (*.txt)|*.txt";
            dlgFileSelect.Title = "編集するファイルを選択してください。";
            dlgFileSelect.ShowDialog();

            txtFilePath.Text = dlgFileSelect.FileName;
            TxtFilePath_Validated(sender ,e);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            // フォーム初期化
            this.initForm();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            // ファイル保存
            File.WriteAllText(txtFilePath.Text, txtFileData.Text);
        }

        private void CmdEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtFilePath_Validated(object sender, EventArgs e)
        {
            // ファイル名不足(拡張子含め5文字以上)
            if (txtFilePath.TextLength < 5) return;

            // ファイルがテキストではない
            if (txtFilePath.Text.Substring(txtFilePath.Text.Length - 3, 3).ToUpper() != "TXT") return;

            // ファイル未存在
            if (File.Exists(txtFilePath.Text) != true) return;

            // ファイル内容を表示
            txtFileData.Text = File.ReadAllText(txtFilePath.Text ,Encoding.GetEncoding("SHIFT_JIS"));

            // コントロール制御(Edit)
            SetControlsEnable(true);
        }

        private void initForm()
        {
            // 編集領域を初期化
            txtFileData.Text = "";

            // コントロール制御(init)
            this.SetControlsEnable(false);
        }

        private void SetControlsEnable(Boolean isEdit)
        {
            if (isEdit)
            {
                txtFilePath.Enabled = false;
                cmdFileSelect.Enabled = false;
                cmdCancel.Enabled = true;
                cmdSave.Enabled = true;
            }
            else
            {
                txtFilePath.Enabled = true;
                cmdFileSelect.Enabled = true;
                cmdCancel.Enabled = false;
                cmdSave.Enabled = false;
            }
        }

    }
}
