
namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.научнаяСтатьяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.научнаяРаботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местоРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.научнаяСтепеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издательствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уДКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.научнаяСтатьяToolStripMenuItem,
            this.авторToolStripMenuItem,
            this.научнаяРаботаToolStripMenuItem,
            this.местоРаботыToolStripMenuItem,
            this.научнаяСтепеньToolStripMenuItem,
            this.издательствоToolStripMenuItem,
            this.уДКToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1448, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.главнаяToolStripMenuItem.Text = "Главная";
            this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.главнаяToolStripMenuItem_Click);
            // 
            // научнаяСтатьяToolStripMenuItem
            // 
            this.научнаяСтатьяToolStripMenuItem.Name = "научнаяСтатьяToolStripMenuItem";
            this.научнаяСтатьяToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.научнаяСтатьяToolStripMenuItem.Text = "Научная статья";
            this.научнаяСтатьяToolStripMenuItem.Click += new System.EventHandler(this.научнаяСтатьяToolStripMenuItem_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // научнаяРаботаToolStripMenuItem
            // 
            this.научнаяРаботаToolStripMenuItem.Name = "научнаяРаботаToolStripMenuItem";
            this.научнаяРаботаToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.научнаяРаботаToolStripMenuItem.Text = "Научная работа";
            this.научнаяРаботаToolStripMenuItem.Click += new System.EventHandler(this.научнаяРаботаToolStripMenuItem_Click);
            // 
            // местоРаботыToolStripMenuItem
            // 
            this.местоРаботыToolStripMenuItem.Name = "местоРаботыToolStripMenuItem";
            this.местоРаботыToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.местоРаботыToolStripMenuItem.Text = "Место работы";
            this.местоРаботыToolStripMenuItem.Click += new System.EventHandler(this.местоРаботыToolStripMenuItem_Click);
            // 
            // научнаяСтепеньToolStripMenuItem
            // 
            this.научнаяСтепеньToolStripMenuItem.Name = "научнаяСтепеньToolStripMenuItem";
            this.научнаяСтепеньToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.научнаяСтепеньToolStripMenuItem.Text = "Научная степень";
            this.научнаяСтепеньToolStripMenuItem.Click += new System.EventHandler(this.научнаяСтепеньToolStripMenuItem_Click);
            // 
            // издательствоToolStripMenuItem
            // 
            this.издательствоToolStripMenuItem.Name = "издательствоToolStripMenuItem";
            this.издательствоToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.издательствоToolStripMenuItem.Text = "Издательство";
            this.издательствоToolStripMenuItem.Click += new System.EventHandler(this.издательствоToolStripMenuItem_Click);
            // 
            // уДКToolStripMenuItem
            // 
            this.уДКToolStripMenuItem.Name = "уДКToolStripMenuItem";
            this.уДКToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.уДКToolStripMenuItem.Text = "УДК";
            this.уДКToolStripMenuItem.Click += new System.EventHandler(this.уДКToolStripMenuItem_Click);
            // 
            // mainTable
            // 
            this.mainTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
            this.mainTable.Location = new System.Drawing.Point(0, 42);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowHeadersWidth = 51;
            this.mainTable.RowTemplate.Height = 24;
            this.mainTable.Size = new System.Drawing.Size(1437, 360);
            this.mainTable.TabIndex = 1;
            this.mainTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Научная статья";
            this.Column1.MinimumWidth = 2;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Автор";
            this.Column2.MinimumWidth = 2;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Место работы";
            this.Column4.MinimumWidth = 2;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Научная работа";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Научная степень";
            this.Column5.MinimumWidth = 2;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Издательство";
            this.Column6.MinimumWidth = 2;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "УДК";
            this.Column7.MinimumWidth = 2;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить работу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1448, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem научнаяСтатьяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem научнаяРаботаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местоРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem научнаяСтепеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem издательствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уДКToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

