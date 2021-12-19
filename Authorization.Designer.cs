
namespace Тетрис
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelReg = new System.Windows.Forms.LinkLabel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonAut = new System.Windows.Forms.Button();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.LabelLog = new System.Windows.Forms.Label();
            this.LabelPass = new System.Windows.Forms.Label();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ButtonClose);
            this.panel1.Controls.Add(this.ButtonAut);
            this.panel1.Controls.Add(this.TextBoxLog);
            this.panel1.Controls.Add(this.LabelLog);
            this.panel1.Controls.Add(this.LabelPass);
            this.panel1.Controls.Add(this.TextBoxPass);
            this.panel1.Location = new System.Drawing.Point(220, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 317);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.LabelReg);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 72);
            this.panel2.TabIndex = 0;
            // 
            // LabelReg
            // 
            this.LabelReg.ActiveLinkColor = System.Drawing.Color.White;
            this.LabelReg.AutoSize = true;
            this.LabelReg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelReg.DisabledLinkColor = System.Drawing.Color.White;
            this.LabelReg.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelReg.LinkColor = System.Drawing.Color.White;
            this.LabelReg.Location = new System.Drawing.Point(113, 26);
            this.LabelReg.Name = "LabelReg";
            this.LabelReg.Size = new System.Drawing.Size(133, 24);
            this.LabelReg.TabIndex = 2;
            this.LabelReg.TabStop = true;
            this.LabelReg.Text = "Регистрация";
            this.LabelReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelReg_LinkClicked);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.SystemColors.Info;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.Location = new System.Drawing.Point(206, 255);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(132, 48);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "Выход";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonAut
            // 
            this.ButtonAut.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonAut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAut.Location = new System.Drawing.Point(18, 255);
            this.ButtonAut.Name = "ButtonAut";
            this.ButtonAut.Size = new System.Drawing.Size(132, 48);
            this.ButtonAut.TabIndex = 0;
            this.ButtonAut.Text = "Авторизация";
            this.ButtonAut.UseVisualStyleBackColor = false;
            this.ButtonAut.Click += new System.EventHandler(this.ButtonAut_Click);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLog.Location = new System.Drawing.Point(18, 100);
            this.TextBoxLog.Multiline = true;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(320, 49);
            this.TextBoxLog.TabIndex = 9;
            this.TextBoxLog.TextChanged += new System.EventHandler(this.TextBoxLog_TextChanged);
            // 
            // LabelLog
            // 
            this.LabelLog.AutoSize = true;
            this.LabelLog.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelLog.Location = new System.Drawing.Point(25, 79);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(113, 17);
            this.LabelLog.TabIndex = 4;
            this.LabelLog.Text = "Введите логин";
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPass.Location = new System.Drawing.Point(25, 156);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(120, 17);
            this.LabelPass.TabIndex = 5;
            this.LabelPass.Text = "Введите пароль";
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPass.Location = new System.Drawing.Point(18, 177);
            this.TextBoxPass.Multiline = true;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(320, 49);
            this.TextBoxPass.TabIndex = 10;
            this.TextBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel LabelReg;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonAut;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.TextBox TextBoxPass;
    }
}