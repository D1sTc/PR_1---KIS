namespace PR_1
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаБольшеНаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Task = new System.Windows.Forms.GroupBox();
            this.pictureTask = new System.Windows.Forms.PictureBox();
            this.EnteringValues = new System.Windows.Forms.GroupBox();
            this.textBoxMars = new System.Windows.Forms.TextBox();
            this.textBoxEarth = new System.Windows.Forms.TextBox();
            this.TextEarth = new System.Windows.Forms.Label();
            this.TextMars = new System.Windows.Forms.Label();
            this.OutputDifference = new System.Windows.Forms.GroupBox();
            this.textBoxDifference = new System.Windows.Forms.TextBox();
            this.OutputLarger = new System.Windows.Forms.GroupBox();
            this.TextEarthOutput2 = new System.Windows.Forms.Label();
            this.TextEarthOutput1 = new System.Windows.Forms.Label();
            this.textBoxMoreThan = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Difference = new System.Windows.Forms.Button();
            this.MoreThan = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.errorProviderSymbolEarth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNullEarth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSymbolMars = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNullMars = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureEarth = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu.SuspendLayout();
            this.Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTask)).BeginInit();
            this.EnteringValues.SuspendLayout();
            this.OutputDifference.SuspendLayout();
            this.OutputLarger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSymbolEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNullEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSymbolMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNullMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(687, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonsToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // buttonsToolStripMenuItem
            // 
            this.buttonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.программаБольшеНаToolStripMenuItem});
            this.buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            this.buttonsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buttonsToolStripMenuItem.Text = "buttons";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.программаToolStripMenuItem.Text = "программа \"Разница\"";
            this.программаToolStripMenuItem.Click += new System.EventHandler(this.программаToolStripMenuItem_Click);
            // 
            // программаБольшеНаToolStripMenuItem
            // 
            this.программаБольшеНаToolStripMenuItem.Name = "программаБольшеНаToolStripMenuItem";
            this.программаБольшеНаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.программаБольшеНаToolStripMenuItem.Text = "программа \"Больше на...\"";
            this.программаБольшеНаToolStripMenuItem.Click += new System.EventHandler(this.программаБольшеНаToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.справкаToolStripMenuItem.Text = "справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Task
            // 
            this.Task.Controls.Add(this.pictureTask);
            this.Task.Location = new System.Drawing.Point(12, 27);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(658, 85);
            this.Task.TabIndex = 1;
            this.Task.TabStop = false;
            this.Task.Text = "Задание";
            // 
            // pictureTask
            // 
            this.pictureTask.Image = global::PR_1.Properties.Resources.Task;
            this.pictureTask.Location = new System.Drawing.Point(6, 19);
            this.pictureTask.Name = "pictureTask";
            this.pictureTask.Size = new System.Drawing.Size(646, 58);
            this.pictureTask.TabIndex = 0;
            this.pictureTask.TabStop = false;
            // 
            // EnteringValues
            // 
            this.EnteringValues.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.EnteringValues.Controls.Add(this.textBoxMars);
            this.EnteringValues.Controls.Add(this.textBoxEarth);
            this.EnteringValues.Controls.Add(this.TextEarth);
            this.EnteringValues.Controls.Add(this.TextMars);
            this.EnteringValues.Location = new System.Drawing.Point(18, 118);
            this.EnteringValues.Name = "EnteringValues";
            this.EnteringValues.Size = new System.Drawing.Size(377, 122);
            this.EnteringValues.TabIndex = 2;
            this.EnteringValues.TabStop = false;
            this.EnteringValues.Text = "Ввод диаметра планет:";
            // 
            // textBoxMars
            // 
            this.textBoxMars.Location = new System.Drawing.Point(234, 80);
            this.textBoxMars.Name = "textBoxMars";
            this.textBoxMars.Size = new System.Drawing.Size(100, 20);
            this.textBoxMars.TabIndex = 5;
            this.textBoxMars.TextChanged += new System.EventHandler(this.textBoxMars_TextChanged);
            // 
            // textBoxEarth
            // 
            this.textBoxEarth.Location = new System.Drawing.Point(234, 38);
            this.textBoxEarth.Name = "textBoxEarth";
            this.textBoxEarth.Size = new System.Drawing.Size(100, 20);
            this.textBoxEarth.TabIndex = 4;
            this.textBoxEarth.TextChanged += new System.EventHandler(this.textBoxEarth_TextChanged);
            // 
            // TextEarth
            // 
            this.TextEarth.AutoSize = true;
            this.TextEarth.Location = new System.Drawing.Point(16, 41);
            this.TextEarth.Name = "TextEarth";
            this.TextEarth.Size = new System.Drawing.Size(212, 13);
            this.TextEarth.TabIndex = 2;
            this.TextEarth.Text = "Введите диаметр планеты Земля (в км):";
            // 
            // TextMars
            // 
            this.TextMars.AutoSize = true;
            this.TextMars.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TextMars.Location = new System.Drawing.Point(16, 83);
            this.TextMars.Name = "TextMars";
            this.TextMars.Size = new System.Drawing.Size(206, 13);
            this.TextMars.TabIndex = 1;
            this.TextMars.Text = "Введите диаметр планеты Марс (в км):";
            // 
            // OutputDifference
            // 
            this.OutputDifference.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OutputDifference.Controls.Add(this.textBoxDifference);
            this.OutputDifference.Location = new System.Drawing.Point(401, 118);
            this.OutputDifference.Name = "OutputDifference";
            this.OutputDifference.Size = new System.Drawing.Size(145, 58);
            this.OutputDifference.TabIndex = 3;
            this.OutputDifference.TabStop = false;
            this.OutputDifference.Text = "Вывод разницы (в км):";
            // 
            // textBoxDifference
            // 
            this.textBoxDifference.Location = new System.Drawing.Point(9, 19);
            this.textBoxDifference.Name = "textBoxDifference";
            this.textBoxDifference.ReadOnly = true;
            this.textBoxDifference.Size = new System.Drawing.Size(130, 20);
            this.textBoxDifference.TabIndex = 0;
            // 
            // OutputLarger
            // 
            this.OutputLarger.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OutputLarger.Controls.Add(this.TextEarthOutput2);
            this.OutputLarger.Controls.Add(this.TextEarthOutput1);
            this.OutputLarger.Controls.Add(this.textBoxMoreThan);
            this.OutputLarger.Location = new System.Drawing.Point(401, 182);
            this.OutputLarger.Name = "OutputLarger";
            this.OutputLarger.Size = new System.Drawing.Size(274, 58);
            this.OutputLarger.TabIndex = 4;
            this.OutputLarger.TabStop = false;
            this.OutputLarger.Text = "Вывод диаметра большей планеты:";
            // 
            // TextEarthOutput2
            // 
            this.TextEarthOutput2.AutoSize = true;
            this.TextEarthOutput2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TextEarthOutput2.Location = new System.Drawing.Point(203, 23);
            this.TextEarthOutput2.Name = "TextEarthOutput2";
            this.TextEarthOutput2.Size = new System.Drawing.Size(36, 13);
            this.TextEarthOutput2.TabIndex = 7;
            this.TextEarthOutput2.Text = "(в км)";
            // 
            // TextEarthOutput1
            // 
            this.TextEarthOutput1.AutoSize = true;
            this.TextEarthOutput1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TextEarthOutput1.Location = new System.Drawing.Point(6, 22);
            this.TextEarthOutput1.Name = "TextEarthOutput1";
            this.TextEarthOutput1.Size = new System.Drawing.Size(112, 13);
            this.TextEarthOutput1.TabIndex = 6;
            this.TextEarthOutput1.Text = "Земли, с диаметром";
            // 
            // textBoxMoreThan
            // 
            this.textBoxMoreThan.Location = new System.Drawing.Point(123, 19);
            this.textBoxMoreThan.Name = "textBoxMoreThan";
            this.textBoxMoreThan.Size = new System.Drawing.Size(74, 20);
            this.textBoxMoreThan.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Exit.Location = new System.Drawing.Point(556, 253);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 46);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выход ✘";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Difference
            // 
            this.Difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Difference.Location = new System.Drawing.Point(37, 246);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(119, 60);
            this.Difference.TabIndex = 6;
            this.Difference.Text = "Разница 🔗";
            this.Difference.UseVisualStyleBackColor = true;
            this.Difference.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoreThan
            // 
            this.MoreThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.MoreThan.Location = new System.Drawing.Point(174, 246);
            this.MoreThan.Name = "MoreThan";
            this.MoreThan.Size = new System.Drawing.Size(150, 60);
            this.MoreThan.TabIndex = 7;
            this.MoreThan.Text = "Км большей ⚖️";
            this.MoreThan.UseVisualStyleBackColor = true;
            this.MoreThan.Click += new System.EventHandler(this.button3_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Clear.Location = new System.Drawing.Point(416, 253);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(124, 46);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Очистить 🗑️";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorProviderSymbolEarth
            // 
            this.errorProviderSymbolEarth.ContainerControl = this;
            // 
            // errorProviderNullEarth
            // 
            this.errorProviderNullEarth.ContainerControl = this;
            // 
            // errorProviderSymbolMars
            // 
            this.errorProviderSymbolMars.ContainerControl = this;
            // 
            // errorProviderNullMars
            // 
            this.errorProviderNullMars.ContainerControl = this;
            // 
            // pictureEarth
            // 
            this.pictureEarth.Image = global::PR_1.Properties.Resources.pngwing_com__2_;
            this.pictureEarth.Location = new System.Drawing.Point(567, 122);
            this.pictureEarth.Name = "pictureEarth";
            this.pictureEarth.Size = new System.Drawing.Size(71, 54);
            this.pictureEarth.TabIndex = 10;
            this.pictureEarth.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR_1.Properties.Resources.pngwing_com__1_;
            this.pictureBox1.Location = new System.Drawing.Point(644, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 318);
            this.Controls.Add(this.pictureEarth);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.MoreThan);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OutputLarger);
            this.Controls.Add(this.OutputDifference);
            this.Controls.Add(this.EnteringValues);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Практическая работа №1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTask)).EndInit();
            this.EnteringValues.ResumeLayout(false);
            this.EnteringValues.PerformLayout();
            this.OutputDifference.ResumeLayout(false);
            this.OutputDifference.PerformLayout();
            this.OutputLarger.ResumeLayout(false);
            this.OutputLarger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSymbolEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNullEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSymbolMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNullMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаБольшеНаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.PictureBox pictureTask;
        private System.Windows.Forms.GroupBox EnteringValues;
        private System.Windows.Forms.TextBox textBoxMars;
        private System.Windows.Forms.TextBox textBoxEarth;
        private System.Windows.Forms.Label TextEarth;
        private System.Windows.Forms.Label TextMars;
        private System.Windows.Forms.GroupBox OutputDifference;
        private System.Windows.Forms.TextBox textBoxDifference;
        private System.Windows.Forms.GroupBox OutputLarger;
        private System.Windows.Forms.TextBox textBoxMoreThan;
        private System.Windows.Forms.Label TextEarthOutput1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label TextEarthOutput2;
        private System.Windows.Forms.Button Difference;
        private System.Windows.Forms.Button MoreThan;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProviderSymbolEarth;
        private System.Windows.Forms.ErrorProvider errorProviderNullEarth;
        private System.Windows.Forms.ErrorProvider errorProviderSymbolMars;
        private System.Windows.Forms.ErrorProvider errorProviderNullMars;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureEarth;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

