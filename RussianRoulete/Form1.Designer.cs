namespace RussianRoulete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBurn = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook6 = new System.Windows.Forms.Button();
            this.btnBook5 = new System.Windows.Forms.Button();
            this.btnBook4 = new System.Windows.Forms.Button();
            this.btnBook3 = new System.Windows.Forms.Button();
            this.btnBook2 = new System.Windows.Forms.Button();
            this.btnBook1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RussianRoulete.Properties.Resources.CursedBook;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnBurn);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBook6);
            this.panel1.Controls.Add(this.btnBook5);
            this.panel1.Controls.Add(this.btnBook4);
            this.panel1.Controls.Add(this.btnBook3);
            this.panel1.Controls.Add(this.btnBook2);
            this.panel1.Controls.Add(this.btnBook1);
            this.panel1.Location = new System.Drawing.Point(46, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 586);
            this.panel1.TabIndex = 0;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.ForeColor = System.Drawing.Color.Red;
            this.btnRestart.Location = new System.Drawing.Point(373, 108);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(90, 45);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 264);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 69);
            this.label2.TabIndex = 11;
            this.label2.Text = "\r\nWelcome to The Cursed Book, this game is very similar\r\nto Russian Roulette\r\n";
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpen.Location = new System.Drawing.Point(266, 516);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 45);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBurn
            // 
            this.btnBurn.BackColor = System.Drawing.Color.Black;
            this.btnBurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBurn.Location = new System.Drawing.Point(373, 518);
            this.btnBurn.Name = "btnBurn";
            this.btnBurn.Size = new System.Drawing.Size(90, 43);
            this.btnBurn.TabIndex = 9;
            this.btnBurn.Text = "Burn";
            this.btnBurn.UseVisualStyleBackColor = false;
            this.btnBurn.Click += new System.EventHandler(this.btnBurn_Click);
            // 
            // btnGo
            // 
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGo.Location = new System.Drawing.Point(266, 108);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(90, 45);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Curse";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("SimSun", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(130, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Cursed Book";
            // 
            // btnBook6
            // 
            this.btnBook6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook6.Image = global::RussianRoulete.Properties.Resources.book1;
            this.btnBook6.Location = new System.Drawing.Point(373, 395);
            this.btnBook6.Name = "btnBook6";
            this.btnBook6.Size = new System.Drawing.Size(123, 99);
            this.btnBook6.TabIndex = 5;
            this.btnBook6.Text = "6";
            this.btnBook6.UseVisualStyleBackColor = false;
            this.btnBook6.Click += new System.EventHandler(this.BtnAllBook_Click);
            // 
            // btnBook5
            // 
            this.btnBook5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook5.Image = global::RussianRoulete.Properties.Resources.book1;
            this.btnBook5.Location = new System.Drawing.Point(234, 395);
            this.btnBook5.Name = "btnBook5";
            this.btnBook5.Size = new System.Drawing.Size(122, 99);
            this.btnBook5.TabIndex = 4;
            this.btnBook5.Text = "5";
            this.btnBook5.UseVisualStyleBackColor = false;
            this.btnBook5.Click += new System.EventHandler(this.BtnAllBook_Click);
            // 
            // btnBook4
            // 
            this.btnBook4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook4.Image = global::RussianRoulete.Properties.Resources.book1;
            this.btnBook4.Location = new System.Drawing.Point(373, 279);
            this.btnBook4.Name = "btnBook4";
            this.btnBook4.Size = new System.Drawing.Size(123, 99);
            this.btnBook4.TabIndex = 3;
            this.btnBook4.Text = "4";
            this.btnBook4.UseVisualStyleBackColor = false;
            this.btnBook4.Click += new System.EventHandler(this.BtnAllBook_Click);
            // 
            // btnBook3
            // 
            this.btnBook3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook3.Image = global::RussianRoulete.Properties.Resources.book1;
            this.btnBook3.Location = new System.Drawing.Point(234, 279);
            this.btnBook3.Name = "btnBook3";
            this.btnBook3.Size = new System.Drawing.Size(122, 99);
            this.btnBook3.TabIndex = 2;
            this.btnBook3.Text = "3";
            this.btnBook3.UseVisualStyleBackColor = false;
            this.btnBook3.Click += new System.EventHandler(this.BtnAllBook_Click);
            // 
            // btnBook2
            // 
            this.btnBook2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook2.Image = global::RussianRoulete.Properties.Resources.book1;
            this.btnBook2.Location = new System.Drawing.Point(373, 165);
            this.btnBook2.Name = "btnBook2";
            this.btnBook2.Size = new System.Drawing.Size(123, 99);
            this.btnBook2.TabIndex = 1;
            this.btnBook2.Text = "2";
            this.btnBook2.UseVisualStyleBackColor = false;
            this.btnBook2.Click += new System.EventHandler(this.BtnAllBook_Click);
            // 
            // btnBook1
            // 
            this.btnBook1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook1.Image = global::RussianRoulete.Properties.Resources.book1;
            this.btnBook1.Location = new System.Drawing.Point(234, 165);
            this.btnBook1.Name = "btnBook1";
            this.btnBook1.Size = new System.Drawing.Size(122, 99);
            this.btnBook1.TabIndex = 0;
            this.btnBook1.Text = "1";
            this.btnBook1.UseVisualStyleBackColor = false;
            this.btnBook1.Click += new System.EventHandler(this.BtnAllBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(664, 628);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBook1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook6;
        private System.Windows.Forms.Button btnBook5;
        private System.Windows.Forms.Button btnBook4;
        private System.Windows.Forms.Button btnBook3;
        private System.Windows.Forms.Button btnBook2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.Button btnGo;
        public System.Windows.Forms.Button btnRestart;
        public System.Windows.Forms.Button btnBurn;
    }
}

