using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClipboardManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtClipboard.Text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtClipboard.Text = Clipboard.GetText();
        }

        private void btnCopyImage_Click(object sender, EventArgs e)
        {
            if (opnImage.ShowDialog() == DialogResult.OK)
            {
                Image imgToCopy = Image.FromFile(opnImage.FileName);
                Clipboard.SetImage(imgToCopy);
            }
        }

        private void btnPasteImage_Click(object sender, EventArgs e)
        {
            picClipboard.Image = Clipboard.GetImage();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}