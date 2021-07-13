namespace WT
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Add = new System.Windows.Forms.Button();
            this.Testing = new System.Windows.Forms.Button();
            this.Repeat = new System.Windows.Forms.Button();
            this.Minimise = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Words = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(26)))));
            this.Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Add.Location = new System.Drawing.Point(12, 38);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(204, 35);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add new";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Testing
            // 
            this.Testing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(26)))));
            this.Testing.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.Testing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Testing.Location = new System.Drawing.Point(12, 79);
            this.Testing.Name = "Testing";
            this.Testing.Size = new System.Drawing.Size(204, 35);
            this.Testing.TabIndex = 1;
            this.Testing.Text = "Testing";
            this.Testing.UseVisualStyleBackColor = false;
            this.Testing.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Repeat
            // 
            this.Repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(26)))));
            this.Repeat.Enabled = false;
            this.Repeat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.Repeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Repeat.Location = new System.Drawing.Point(12, 120);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(204, 35);
            this.Repeat.TabIndex = 4;
            this.Repeat.Text = "Repeat";
            this.Repeat.UseVisualStyleBackColor = false;
            this.Repeat.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Minimise
            // 
            this.Minimise.BackgroundImage = global::WT.Properties.Resources.свернуть;
            this.Minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimise.Location = new System.Drawing.Point(170, 12);
            this.Minimise.Name = "Minimise";
            this.Minimise.Size = new System.Drawing.Size(20, 20);
            this.Minimise.TabIndex = 6;
            this.Minimise.TabStop = false;
            this.Minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // Close
            // 
            this.Close.BackgroundImage = global::WT.Properties.Resources.закрыть;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.InitialImage = null;
            this.Close.Location = new System.Drawing.Point(196, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 20);
            this.Close.TabIndex = 5;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Words
            // 
            this.Words.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(26)))));
            this.Words.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.Words.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Words.Location = new System.Drawing.Point(12, 161);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(204, 35);
            this.Words.TabIndex = 7;
            this.Words.Text = "Show all words";
            this.Words.UseVisualStyleBackColor = false;
            this.Words.Click += new System.EventHandler(this.WearyWords_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(26)))));
            this.Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Delete.Location = new System.Drawing.Point(12, 202);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(204, 35);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(228, 250);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.Minimise);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Repeat);
            this.Controls.Add(this.Testing);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Testing;
        private System.Windows.Forms.Button Repeat;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimise;
        private System.Windows.Forms.Button Words;
        private System.Windows.Forms.Button Delete;
    }
}

