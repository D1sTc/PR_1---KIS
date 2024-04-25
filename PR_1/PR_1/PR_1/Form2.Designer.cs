namespace PR_1
{
    partial class Form2
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.label_channel = new System.Windows.Forms.Label();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.labelWhoDeveloped = new System.Windows.Forms.Label();
            this.labelProgram = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.Location = new System.Drawing.Point(400, 185);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 38);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Назад ✔️";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Link.Location = new System.Drawing.Point(140, 129);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(49, 17);
            this.Link.TabIndex = 23;
            this.Link.TabStop = true;
            this.Link.Text = "D1sTc";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_channel
            // 
            this.label_channel.AutoSize = true;
            this.label_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_channel.Location = new System.Drawing.Point(13, 129);
            this.label_channel.Name = "label_channel";
            this.label_channel.Size = new System.Drawing.Size(121, 17);
            this.label_channel.TabIndex = 22;
            this.label_channel.Text = "Youtube Channel:";
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecialization.Location = new System.Drawing.Point(12, 91);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(443, 17);
            this.labelSpecialization.TabIndex = 21;
            this.labelSpecialization.Text = "Специальность: Информационные Системы и Программирование";
            // 
            // labelWhoDeveloped
            // 
            this.labelWhoDeveloped.AutoSize = true;
            this.labelWhoDeveloped.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhoDeveloped.Location = new System.Drawing.Point(13, 55);
            this.labelWhoDeveloped.Name = "labelWhoDeveloped";
            this.labelWhoDeveloped.Size = new System.Drawing.Size(311, 17);
            this.labelWhoDeveloped.TabIndex = 20;
            this.labelWhoDeveloped.Text = "Разработал: Филиппов Александр Сергеевич";
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgram.Location = new System.Drawing.Point(12, 9);
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(391, 24);
            this.labelProgram.TabIndex = 19;
            this.labelProgram.Text = "Программа \"Практическая работа №1\"";
            // 
            // picture
            // 
            this.picture.Image = global::PR_1.Properties.Resources.aplodismenty_na_belom_fone_1__1_;
            this.picture.Location = new System.Drawing.Point(-13, 75);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(348, 326);
            this.picture.TabIndex = 25;
            this.picture.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 234);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label_channel);
            this.Controls.Add(this.labelSpecialization);
            this.Controls.Add(this.labelWhoDeveloped);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.picture);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.Label label_channel;
        private System.Windows.Forms.Label labelSpecialization;
        private System.Windows.Forms.Label labelWhoDeveloped;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.PictureBox picture;
    }
}