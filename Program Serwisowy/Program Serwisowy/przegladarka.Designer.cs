
namespace Program_Serwisowy
{
    partial class przegladarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(przegladarka));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.reflesh = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.szukaj = new System.Windows.Forms.Button();
            this.znak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1030, 546);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.pl", System.UriKind.Absolute);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(951, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zakończ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back.ImageKey = "(brak)";
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "<--";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reflesh
            // 
            this.reflesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reflesh.Location = new System.Drawing.Point(93, 12);
            this.reflesh.Name = "reflesh";
            this.reflesh.Size = new System.Drawing.Size(75, 23);
            this.reflesh.TabIndex = 4;
            this.reflesh.Text = "Odśwież";
            this.reflesh.UseVisualStyleBackColor = true;
            this.reflesh.Click += new System.EventHandler(this.reflesh_Click);
            // 
            // next
            // 
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Location = new System.Drawing.Point(174, 12);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 5;
            this.next.Text = "-->";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // szukaj
            // 
            this.szukaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.szukaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.szukaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.szukaj.Location = new System.Drawing.Point(631, 14);
            this.szukaj.Name = "szukaj";
            this.szukaj.Size = new System.Drawing.Size(75, 23);
            this.szukaj.TabIndex = 9;
            this.szukaj.Text = "Szukaj";
            this.szukaj.UseVisualStyleBackColor = true;
            this.szukaj.Click += new System.EventHandler(this.szukaj_Click);
            // 
            // znak
            // 
            this.znak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.znak.Location = new System.Drawing.Point(712, 14);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(75, 23);
            this.znak.TabIndex = 10;
            this.znak.Text = "ZNAK.PL";
            this.znak.UseVisualStyleBackColor = true;
            this.znak.Click += new System.EventHandler(this.znak_Click);
            // 
            // przegladarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 640);
            this.Controls.Add(this.znak);
            this.Controls.Add(this.szukaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.reflesh);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "przegladarka";
            this.Text = "ArisaWeb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reflesh;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button szukaj;
        private System.Windows.Forms.Button znak;
    }
}