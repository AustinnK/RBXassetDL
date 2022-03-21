namespace rbxassetDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getassetsbutton = new System.Windows.Forms.Button();
            this.URLStextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filepathbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getassetsbutton
            // 
            this.getassetsbutton.Location = new System.Drawing.Point(628, 420);
            this.getassetsbutton.Name = "getassetsbutton";
            this.getassetsbutton.Size = new System.Drawing.Size(147, 27);
            this.getassetsbutton.TabIndex = 0;
            this.getassetsbutton.Text = "Download";
            this.getassetsbutton.UseVisualStyleBackColor = true;
            this.getassetsbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // URLStextBox
            // 
            this.URLStextBox.AccessibleDescription = "";
            this.URLStextBox.Location = new System.Drawing.Point(12, 29);
            this.URLStextBox.Multiline = true;
            this.URLStextBox.Name = "URLStextBox";
            this.URLStextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.URLStextBox.Size = new System.Drawing.Size(764, 162);
            this.URLStextBox.TabIndex = 1;
            this.URLStextBox.WordWrap = false;
            this.URLStextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 204);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(763, 183);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paste audio assetIDs in the field below. Seperate multiple assetIDs with a new li" +
    "ne.";
            // 
            // filepathbox
            // 
            this.filepathbox.Location = new System.Drawing.Point(65, 394);
            this.filepathbox.Name = "filepathbox";
            this.filepathbox.ReadOnly = true;
            this.filepathbox.Size = new System.Drawing.Size(710, 20);
            this.filepathbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "file path:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filepathbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.URLStextBox);
            this.Controls.Add(this.getassetsbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Roblox Asset Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getassetsbutton;
        private System.Windows.Forms.TextBox URLStextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filepathbox;
        private System.Windows.Forms.Label label2;
    }
}

