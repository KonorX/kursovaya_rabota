namespace game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выберитеУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.первыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.второйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диалогСЛягухойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.третийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выберитеУровеньToolStripMenuItem});
            this.главнаяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.главнаяToolStripMenuItem.Text = "главная";
            // 
            // выберитеУровеньToolStripMenuItem
            // 
            this.выберитеУровеньToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.первыйToolStripMenuItem,
            this.второйToolStripMenuItem,
            this.диалогСЛягухойToolStripMenuItem,
            this.третийToolStripMenuItem});
            this.выберитеУровеньToolStripMenuItem.Name = "выберитеУровеньToolStripMenuItem";
            this.выберитеУровеньToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выберитеУровеньToolStripMenuItem.Text = "выберите уровень";
            // 
            // первыйToolStripMenuItem
            // 
            this.первыйToolStripMenuItem.Name = "первыйToolStripMenuItem";
            this.первыйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.первыйToolStripMenuItem.Text = "первый";
            this.первыйToolStripMenuItem.Click += new System.EventHandler(this.первыйToolStripMenuItem_Click);
            // 
            // второйToolStripMenuItem
            // 
            this.второйToolStripMenuItem.Name = "второйToolStripMenuItem";
            this.второйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.второйToolStripMenuItem.Text = "битва с медведем";
            this.второйToolStripMenuItem.Click += new System.EventHandler(this.второйToolStripMenuItem_Click);
            // 
            // диалогСЛягухойToolStripMenuItem
            // 
            this.диалогСЛягухойToolStripMenuItem.Name = "диалогСЛягухойToolStripMenuItem";
            this.диалогСЛягухойToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.диалогСЛягухойToolStripMenuItem.Text = "диалог с лягухой";
            this.диалогСЛягухойToolStripMenuItem.Click += new System.EventHandler(this.диалогСЛягухойToolStripMenuItem_Click);
            // 
            // третийToolStripMenuItem
            // 
            this.третийToolStripMenuItem.Name = "третийToolStripMenuItem";
            this.третийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.третийToolStripMenuItem.Text = "второй";
            this.третийToolStripMenuItem.Click += new System.EventHandler(this.третийToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(367, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Legend of Kod";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(94, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(790, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tutorial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 515);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выберитеУровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem первыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem второйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem третийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem диалогСЛягухойToolStripMenuItem;
    }
}

