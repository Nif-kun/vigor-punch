
namespace WindowsFormsApp2.Start
{
    partial class Signup
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.usernameTxBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailTxBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewChoosePass = new System.Windows.Forms.Label();
            this.choosePassTxBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.viewConfirmPass = new System.Windows.Forms.Label();
            this.confirmPassTxBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passNotif = new System.Windows.Forms.Label();
            this.emptyNotif = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.usernameNotif = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.submitBtn.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(103, 523);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(184, 40);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usernameTxBox);
            this.panel1.Location = new System.Drawing.Point(46, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 45);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(65, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(64, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.emailTxBox);
            this.panel2.Location = new System.Drawing.Point(45, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 45);
            this.panel2.TabIndex = 16;
            // 
            // emailTxBox
            // 
            this.emailTxBox.BackColor = System.Drawing.SystemColors.Control;
            this.emailTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxBox.Location = new System.Drawing.Point(11, 12);
            this.emailTxBox.Name = "emailTxBox";
            this.emailTxBox.Size = new System.Drawing.Size(291, 21);
            this.emailTxBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(64, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choose password:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.viewChoosePass);
            this.panel3.Controls.Add(this.choosePassTxBox);
            this.panel3.Location = new System.Drawing.Point(45, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 45);
            this.panel3.TabIndex = 18;
            // 
            // viewChoosePass
            // 
            this.viewChoosePass.AutoSize = true;
            this.viewChoosePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewChoosePass.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewChoosePass.Location = new System.Drawing.Point(275, 10);
            this.viewChoosePass.Name = "viewChoosePass";
            this.viewChoosePass.Size = new System.Drawing.Size(33, 23);
            this.viewChoosePass.TabIndex = 21;
            this.viewChoosePass.Text = "👁";
            this.viewChoosePass.Click += new System.EventHandler(this.viewChoosePass_Click);
            // 
            // choosePassTxBox
            // 
            this.choosePassTxBox.BackColor = System.Drawing.SystemColors.Control;
            this.choosePassTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.choosePassTxBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePassTxBox.Location = new System.Drawing.Point(11, 12);
            this.choosePassTxBox.Name = "choosePassTxBox";
            this.choosePassTxBox.Size = new System.Drawing.Size(273, 21);
            this.choosePassTxBox.TabIndex = 12;
            this.choosePassTxBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(64, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Confirm password:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.viewConfirmPass);
            this.panel4.Controls.Add(this.confirmPassTxBox);
            this.panel4.Location = new System.Drawing.Point(45, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 45);
            this.panel4.TabIndex = 20;
            // 
            // viewConfirmPass
            // 
            this.viewConfirmPass.AutoSize = true;
            this.viewConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewConfirmPass.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewConfirmPass.Location = new System.Drawing.Point(274, 10);
            this.viewConfirmPass.Name = "viewConfirmPass";
            this.viewConfirmPass.Size = new System.Drawing.Size(33, 23);
            this.viewConfirmPass.TabIndex = 22;
            this.viewConfirmPass.Text = "👁";
            this.viewConfirmPass.Click += new System.EventHandler(this.viewConfirmPass_Click);
            // 
            // confirmPassTxBox
            // 
            this.confirmPassTxBox.BackColor = System.Drawing.SystemColors.Control;
            this.confirmPassTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassTxBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassTxBox.Location = new System.Drawing.Point(11, 12);
            this.confirmPassTxBox.Name = "confirmPassTxBox";
            this.confirmPassTxBox.Size = new System.Drawing.Size(273, 21);
            this.confirmPassTxBox.TabIndex = 12;
            this.confirmPassTxBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(49, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "You\'re one step away!";
            // 
            // passNotif
            // 
            this.passNotif.AutoSize = true;
            this.passNotif.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passNotif.ForeColor = System.Drawing.Color.Crimson;
            this.passNotif.Location = new System.Drawing.Point(50, 449);
            this.passNotif.Name = "passNotif";
            this.passNotif.Size = new System.Drawing.Size(150, 25);
            this.passNotif.TabIndex = 22;
            this.passNotif.Text = "*incorrect password.";
            this.passNotif.Visible = false;
            // 
            // emptyNotif
            // 
            this.emptyNotif.AutoSize = true;
            this.emptyNotif.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyNotif.ForeColor = System.Drawing.Color.Crimson;
            this.emptyNotif.Location = new System.Drawing.Point(50, 469);
            this.emptyNotif.Name = "emptyNotif";
            this.emptyNotif.Size = new System.Drawing.Size(170, 25);
            this.emptyNotif.TabIndex = 23;
            this.emptyNotif.Text = "*can\'t pass empty value";
            this.emptyNotif.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.backBtn.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Location = new System.Drawing.Point(19, 20);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 32);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "< BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // usernameNotif
            // 
            this.usernameNotif.AutoSize = true;
            this.usernameNotif.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameNotif.ForeColor = System.Drawing.Color.Crimson;
            this.usernameNotif.Location = new System.Drawing.Point(50, 489);
            this.usernameNotif.Name = "usernameNotif";
            this.usernameNotif.Size = new System.Drawing.Size(138, 25);
            this.usernameNotif.TabIndex = 25;
            this.usernameNotif.Text = "*username is taken";
            this.usernameNotif.Visible = false;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 658);
            this.Controls.Add(this.usernameNotif);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.emptyNotif);
            this.Controls.Add(this.passNotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox usernameTxBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailTxBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox choosePassTxBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox confirmPassTxBox;
        private System.Windows.Forms.Label viewChoosePass;
        private System.Windows.Forms.Label viewConfirmPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label passNotif;
        private System.Windows.Forms.Label emptyNotif;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label usernameNotif;
    }
}