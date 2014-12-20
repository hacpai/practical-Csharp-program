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

namespace MyNotepad
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存原始内容
        /// </summary>
        private String OriginalContent = "";
        /// <summary>
        /// 打开的文件名
        /// </summary>
        private String _FileName = "";
        public String FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
                //在赋值时同步更新窗体标题
                Text = Path.GetFileName(value) + "-我的记事本";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            lblTimer.Text = "";
            lblInfo.Text = "";
            Text = "无标题-我的记事本";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Open();

        }

        private void Open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                try
                {
                    OriginalContent = File.ReadAllText(FileName);
                    txtEditor.Text = OriginalContent;
                }
                catch (Exception)
                {
                    lblInfo.Text = "无法打开文件";
                }

            }
        }

        /// <summary>
        /// 保存到文件
        /// </summary>
        private void Save()
        {
            //当内容己更改时，此标记为True，
            bool ShouldSave = false;
            //如果文件名不为空，表明当前是文本框中的内容是来自于文件
            if (FileName != "")
            {
                //如果内容己更改
                if (txtEditor.Text != OriginalContent
                    && MessageBox.Show("文件己修改，保存吗？",
                    "保存文件",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ShouldSave = true;
                }
            }
            else
            {
                //如果用户输入了内容，并且指定了一个文件名
                if (txtEditor.Text != "" && saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                    ShouldSave = true;
                }
            }

            if (ShouldSave)
            {
                try
                {
                    File.WriteAllText(FileName, txtEditor.Text);
                    OriginalContent = txtEditor.Text;
                    lblInfo.Text = "文件己保存";
                }
                catch (Exception)
                {
                    lblInfo.Text = "文件保存失败";
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

    }
}
