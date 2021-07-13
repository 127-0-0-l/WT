namespace WT
{
    partial class Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show));
            this.Minimise = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.studied = new System.Windows.Forms.Label();
            this.studying = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimise
            // 
            this.Minimise.BackgroundImage = global::WT.Properties.Resources.свернуть;
            this.Minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimise.Location = new System.Drawing.Point(694, 12);
            this.Minimise.Name = "Minimise";
            this.Minimise.Size = new System.Drawing.Size(20, 20);
            this.Minimise.TabIndex = 8;
            this.Minimise.TabStop = false;
            this.Minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // Close
            // 
            this.Close.BackgroundImage = global::WT.Properties.Resources.закрыть;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.InitialImage = null;
            this.Close.Location = new System.Drawing.Point(720, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 20);
            this.Close.TabIndex = 7;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(12, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 287);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox2.Location = new System.Drawing.Point(390, 44);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(350, 287);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // studied
            // 
            this.studied.AutoSize = true;
            this.studied.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.studied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.studied.Location = new System.Drawing.Point(114, 19);
            this.studied.Name = "studied";
            this.studied.Size = new System.Drawing.Size(119, 22);
            this.studied.TabIndex = 11;
            this.studied.Text = "On studying";
            // 
            // studying
            // 
            this.studying.AutoSize = true;
            this.studying.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.studying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.studying.Location = new System.Drawing.Point(530, 19);
            this.studying.Name = "studying";
            this.studying.Size = new System.Drawing.Size(81, 22);
            this.studying.TabIndex = 12;
            this.studying.Text = "Studied";
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(752, 347);
            this.Controls.Add(this.studying);
            this.Controls.Add(this.studied);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Minimise);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show";
            ((System.ComponentModel.ISupportInitialize)(this.Minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Minimise;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label studied;
        private System.Windows.Forms.Label studying;
    }
}