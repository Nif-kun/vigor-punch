
namespace WindowsFormsApp2.Start
{
    partial class Login
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameTxBox = new System.Windows.Forms.TextBox();
            this.viewPass = new System.Windows.Forms.Label();
            this.credNotif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passTxBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.backBtn.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Location = new System.Drawing.Point(19, 20);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 32);
            this.backBtn.TabIndex = 25;
            this.backBtn.Text = "< BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(39, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 34);
            this.label5.TabIndex = 31;
            this.label5.Text = "Let\'s get fit once again!";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(65, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usernameTxBox);
            this.panel1.Location = new System.Drawing.Point(46, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 45);
            this.panel1.TabIndex = 28;
            // 
            // usernameTxBox
            // 
            this.usernameTxBox.BackColor = System.Drawing.SystemColors.Control;
            this.usernameTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxBox.Location = new System.Drawing.Point(11, 12);
            this.usernameTxBox.Name = "usernameTxBox";
            this.usernameTxBox.Size = new System.Drawing.Size(291, 21);
            this.usernameTxBox.TabIndex = 12;
            // 
            // viewPass
            // 
            this.viewPass.AutoSize = true;
            this.viewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPass.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPass.Location = new System.Drawing.Point(275, 10);
            this.viewPass.Name = "viewPass";
            this.viewPass.Size = new System.Drawing.Size(33, 23);
            this.viewPass.TabIndex = 21;
            this.viewPass.Text = "👁";
            this.viewPass.Click += new System.EventHandler(this.viewPass_Click);
            // 
            // credNotif
            // 
            this.credNotif.AutoSize = true;
            this.credNotif.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credNotif.ForeColor = System.Drawing.Color.Crimson;
            this.credNotif.Location = new System.Drawing.Point(50, 400);
            this.credNotif.Name = "credNotif";
            this.credNotif.Size = new System.Drawing.Size(142, 25);
            this.credNotif.TabIndex = 32;
            this.credNotif.Text = "*wrong credentials.";
            this.credNotif.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(65, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.viewPass);
            this.panel3.Controls.Add(this.passTxBox);
            this.panel3.Location = new System.Drawing.Point(46, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 45);
            this.panel3.TabIndex = 30;
            // 
            // passTxBox
            // 
            this.passTxBox.BackColor = System.Drawing.SystemColors.Control;
            this.passTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTxBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxBox.Location = new System.Drawing.Point(11, 12);
            this.passTxBox.Name = "passTxBox";
            this.passTxBox.Size = new System.Drawing.Size(273, 21);
            this.passTxBox.TabIndex = 12;
            this.passTxBox.UseSystemPasswordChar = true;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.submitBtn.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(103, 445);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(184, 40);
            this.submitBtn.TabIndex = 26;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.credNotif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernameTxBox;
        private System.Windows.Forms.Label viewPass;
        private System.Windows.Forms.Label credNotif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passTxBox;
        private System.Windows.Forms.Button submitBtn;
    }
}