using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EDM_Builder.MyControls.Dialog
{
    public partial class Dialog_InputImage : UserControl
    {
        public string imgPath { get; set; }

        public Dialog_InputImage()
        {
            InitializeComponent();
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "图片格式|*.jpg;*.jpeg;*.png;*.bmp";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                imgPath = openFileDialog1.FileName;
                textBox_Local.Text = imgPath;
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            imgPath = imgPath;
            this.Hide();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            imgPath = string.Empty;
            this.Hide();
        }

        private void textBox_Url_TextChanged(object sender, EventArgs e)
        {
            imgPath = textBox_Url.Text.Trim();
        }
    }
}
