
namespace Тетрис
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelAut = new System.Windows.Forms.LinkLabel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelLog = new System.Windows.Forms.Label();
            this.ButtonReg = new System.Windows.Forms.Button();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.CheckBoxCoditions = new System.Windows.Forms.CheckBox();
            this.TextBoxPassReplay = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.LabelPass = new System.Windows.Forms.Label();
            this.LabelPassReplay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ButtonClose);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Controls.Add(this.LabelLog);
            this.panel1.Controls.Add(this.ButtonReg);
            this.panel1.Controls.Add(this.TextBoxLog);
            this.panel1.Controls.Add(this.CheckBoxCoditions);
            this.panel1.Controls.Add(this.TextBoxPassReplay);
            this.panel1.Controls.Add(this.TextBoxPass);
            this.panel1.Controls.Add(this.LabelPass);
            this.panel1.Controls.Add(this.LabelPassReplay);
            this.panel1.Location = new System.Drawing.Point(221, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 420);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.LabelAut);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 74);
            this.panel2.TabIndex = 22;
            // 
            // LabelAut
            // 
            this.LabelAut.AutoSize = true;
            this.LabelAut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAut.LinkColor = System.Drawing.Color.White;
            this.LabelAut.Location = new System.Drawing.Point(120, 28);
            this.LabelAut.Name = "LabelAut";
            this.LabelAut.Size = new System.Drawing.Size(123, 22);
            this.LabelAut.TabIndex = 0;
            this.LabelAut.TabStop = true;
            this.LabelAut.Text = "Авторизация";
            this.LabelAut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelAut_LinkClicked);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.Location = new System.Drawing.Point(187, 360);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(157, 43);
            this.ButtonClose.TabIndex = 20;
            this.ButtonClose.Text = "Выход";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxName.Location = new System.Drawing.Point(16, 103);
            this.TextBoxName.Multiline = true;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(328, 32);
            this.TextBoxName.TabIndex = 10;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(27, 83);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(197, 17);
            this.LabelName.TabIndex = 9;
            this.LabelName.Text = "Введите имя пользователя";
            // 
            // LabelLog
            // 
            this.LabelLog.AutoSize = true;
            this.LabelLog.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLog.Location = new System.Drawing.Point(27, 143);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(113, 17);
            this.LabelLog.TabIndex = 15;
            this.LabelLog.Text = "Введите логин";
            // 
            // ButtonReg
            // 
            this.ButtonReg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReg.Location = new System.Drawing.Point(16, 360);
            this.ButtonReg.Name = "ButtonReg";
            this.ButtonReg.Size = new System.Drawing.Size(157, 43);
            this.ButtonReg.TabIndex = 19;
            this.ButtonReg.Text = "Зарегистрироваться";
            this.ButtonReg.UseVisualStyleBackColor = true;
            this.ButtonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLog.Location = new System.Drawing.Point(16, 163);
            this.TextBoxLog.Multiline = true;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(328, 32);
            this.TextBoxLog.TabIndex = 17;
            this.TextBoxLog.TextChanged += new System.EventHandler(this.TextBoxLog_TextChanged);
            // 
            // CheckBoxCoditions
            // 
            this.CheckBoxCoditions.AutoSize = true;
            this.CheckBoxCoditions.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxCoditions.Location = new System.Drawing.Point(30, 325);
            this.CheckBoxCoditions.Name = "CheckBoxCoditions";
            this.CheckBoxCoditions.Size = new System.Drawing.Size(285, 19);
            this.CheckBoxCoditions.TabIndex = 13;
            this.CheckBoxCoditions.Text = "Я согласен на обрабоку персональных данных";
            this.CheckBoxCoditions.UseVisualStyleBackColor = true;
            this.CheckBoxCoditions.CheckedChanged += new System.EventHandler(this.CheckBoxCoditions_CheckedChanged);
            // 
            // TextBoxPassReplay
            // 
            this.TextBoxPassReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassReplay.Location = new System.Drawing.Point(16, 287);
            this.TextBoxPassReplay.Multiline = true;
            this.TextBoxPassReplay.Name = "TextBoxPassReplay";
            this.TextBoxPassReplay.PasswordChar = '*';
            this.TextBoxPassReplay.Size = new System.Drawing.Size(328, 32);
            this.TextBoxPassReplay.TabIndex = 14;
            this.TextBoxPassReplay.TextChanged += new System.EventHandler(this.TextBoxPassReplay_TextChanged);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPass.Location = new System.Drawing.Point(16, 224);
            this.TextBoxPass.Multiline = true;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(328, 32);
            this.TextBoxPass.TabIndex = 18;
            this.TextBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelPass.Location = new System.Drawing.Point(27, 204);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(120, 17);
            this.LabelPass.TabIndex = 16;
            this.LabelPass.Text = "Введите пароль";
            // 
            // LabelPassReplay
            // 
            this.LabelPassReplay.AutoSize = true;
            this.LabelPassReplay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.LabelPassReplay.Location = new System.Drawing.Point(27, 267);
            this.LabelPassReplay.Name = "LabelPassReplay";
            this.LabelPassReplay.Size = new System.Drawing.Size(137, 17);
            this.LabelPassReplay.TabIndex = 12;
            this.LabelPassReplay.Text = "Повторите пароль";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel LabelAut;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.Button ButtonReg;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.CheckBox CheckBoxCoditions;
        private System.Windows.Forms.TextBox TextBoxPassReplay;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Label LabelPassReplay;
    }
}