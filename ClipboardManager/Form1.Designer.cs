namespace ClipboardManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPasteText = new System.Windows.Forms.Button();
            this.txtClipboard = new System.Windows.Forms.TextBox();
            this.btnCopyText = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picClipboard = new System.Windows.Forms.PictureBox();
            this.btnPasteImage = new System.Windows.Forms.Button();
            this.btnCopyImage = new System.Windows.Forms.Button();
            this.opnImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picClipboard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPasteText
            // 
            this.btnPasteText.Location = new System.Drawing.Point(144, 133);
            this.btnPasteText.Name = "btnPasteText";
            this.btnPasteText.Size = new System.Drawing.Size(136, 23);
            this.btnPasteText.TabIndex = 0;
            this.btnPasteText.Text = "Paste Text";
            this.btnPasteText.UseVisualStyleBackColor = true;
            this.btnPasteText.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // txtClipboard
            // 
            this.txtClipboard.Location = new System.Drawing.Point(12, 12);
            this.txtClipboard.Multiline = true;
            this.txtClipboard.Name = "txtClipboard";
            this.txtClipboard.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtClipboard.Size = new System.Drawing.Size(268, 115);
            this.txtClipboard.TabIndex = 1;
            // 
            // btnCopyText
            // 
            this.btnCopyText.Location = new System.Drawing.Point(12, 133);
            this.btnCopyText.Name = "btnCopyText";
            this.btnCopyText.Size = new System.Drawing.Size(126, 23);
            this.btnCopyText.TabIndex = 2;
            this.btnCopyText.Text = "Copy Text";
            this.btnCopyText.UseVisualStyleBackColor = true;
            this.btnCopyText.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(144, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Clipboard";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picClipboard
            // 
            this.picClipboard.Location = new System.Drawing.Point(12, 177);
            this.picClipboard.Name = "picClipboard";
            this.picClipboard.Size = new System.Drawing.Size(268, 120);
            this.picClipboard.TabIndex = 4;
            this.picClipboard.TabStop = false;
            // 
            // btnPasteImage
            // 
            this.btnPasteImage.Location = new System.Drawing.Point(154, 303);
            this.btnPasteImage.Name = "btnPasteImage";
            this.btnPasteImage.Size = new System.Drawing.Size(126, 23);
            this.btnPasteImage.TabIndex = 5;
            this.btnPasteImage.Text = "Paste Image";
            this.btnPasteImage.UseVisualStyleBackColor = true;
            this.btnPasteImage.Click += new System.EventHandler(this.btnPasteImage_Click);
            // 
            // btnCopyImage
            // 
            this.btnCopyImage.Location = new System.Drawing.Point(12, 303);
            this.btnCopyImage.Name = "btnCopyImage";
            this.btnCopyImage.Size = new System.Drawing.Size(136, 23);
            this.btnCopyImage.TabIndex = 6;
            this.btnCopyImage.Text = "Copy Image";
            this.btnCopyImage.UseVisualStyleBackColor = true;
            this.btnCopyImage.Click += new System.EventHandler(this.btnCopyImage_Click);
            // 
            // opnImage
            // 
            this.opnImage.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 394);
            this.Controls.Add(this.btnCopyImage);
            this.Controls.Add(this.btnPasteImage);
            this.Controls.Add(this.picClipboard);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopyText);
            this.Controls.Add(this.txtClipboard);
            this.Controls.Add(this.btnPasteText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clipboard Manager";
            ((System.ComponentModel.ISupportInitialize)(this.picClipboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasteText;
        private System.Windows.Forms.TextBox txtClipboard;
        private System.Windows.Forms.Button btnCopyText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picClipboard;
        private System.Windows.Forms.Button btnPasteImage;
        private System.Windows.Forms.Button btnCopyImage;
        private System.Windows.Forms.OpenFileDialog opnImage;
    }
}

