namespace ImageProcessing
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputImgBox = new System.Windows.Forms.PictureBox();
            this.SourceImgBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RectXTextBox = new System.Windows.Forms.TextBox();
            this.RectYTextBox = new System.Windows.Forms.TextBox();
            this.RectHTextBox = new System.Windows.Forms.TextBox();
            this.RectWTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputImgBox
            // 
            this.OutputImgBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OutputImgBox.Location = new System.Drawing.Point(419, 12);
            this.OutputImgBox.Name = "OutputImgBox";
            this.OutputImgBox.Size = new System.Drawing.Size(370, 340);
            this.OutputImgBox.TabIndex = 0;
            this.OutputImgBox.TabStop = false;
            // 
            // SourceImgBox
            // 
            this.SourceImgBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SourceImgBox.Location = new System.Drawing.Point(12, 12);
            this.SourceImgBox.Name = "SourceImgBox";
            this.SourceImgBox.Size = new System.Drawing.Size(370, 340);
            this.SourceImgBox.TabIndex = 1;
            this.SourceImgBox.TabStop = false;
            this.SourceImgBox.Click += new System.EventHandler(this.SourceImgBox_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open Dialog";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SelectInputFileDialog
            // 
            this.SelectInputFileDialog.FileName = "openFileDialog1";
            // 
            // RectXTextBox
            // 
            this.RectXTextBox.BackColor = System.Drawing.Color.YellowGreen;
            this.RectXTextBox.Location = new System.Drawing.Point(136, 361);
            this.RectXTextBox.Name = "RectXTextBox";
            this.RectXTextBox.Size = new System.Drawing.Size(57, 23);
            this.RectXTextBox.TabIndex = 3;
            this.RectXTextBox.Text = "233";
            this.RectXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RectYTextBox
            // 
            this.RectYTextBox.BackColor = System.Drawing.Color.YellowGreen;
            this.RectYTextBox.Location = new System.Drawing.Point(199, 361);
            this.RectYTextBox.Name = "RectYTextBox";
            this.RectYTextBox.Size = new System.Drawing.Size(57, 23);
            this.RectYTextBox.TabIndex = 4;
            this.RectYTextBox.Text = "270";
            this.RectYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RectHTextBox
            // 
            this.RectHTextBox.BackColor = System.Drawing.Color.Yellow;
            this.RectHTextBox.Location = new System.Drawing.Point(325, 361);
            this.RectHTextBox.Name = "RectHTextBox";
            this.RectHTextBox.Size = new System.Drawing.Size(57, 23);
            this.RectHTextBox.TabIndex = 6;
            this.RectHTextBox.Text = "310";
            this.RectHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RectWTextBox
            // 
            this.RectWTextBox.BackColor = System.Drawing.Color.Yellow;
            this.RectWTextBox.Location = new System.Drawing.Point(262, 361);
            this.RectWTextBox.Name = "RectWTextBox";
            this.RectWTextBox.Size = new System.Drawing.Size(57, 23);
            this.RectWTextBox.TabIndex = 5;
            this.RectWTextBox.Text = "464";
            this.RectWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(705, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Process";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ProcessImageButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(615, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Draw Lines";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.DrawLines_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RectHTextBox);
            this.Controls.Add(this.RectWTextBox);
            this.Controls.Add(this.RectYTextBox);
            this.Controls.Add(this.RectXTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SourceImgBox);
            this.Controls.Add(this.OutputImgBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 432);
            this.MinimumSize = new System.Drawing.Size(816, 432);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox OutputImgBox;
        private PictureBox SourceImgBox;
        private Button button1;
        private OpenFileDialog SelectInputFileDialog;
        private TextBox RectXTextBox;
        private TextBox RectYTextBox;
        private TextBox RectHTextBox;
        private TextBox RectWTextBox;
        private Button button2;
        private Button button3;
    }
}