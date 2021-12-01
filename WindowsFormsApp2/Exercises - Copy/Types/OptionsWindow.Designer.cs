
namespace WindowsFormsApp2.Exercises.Types
{
    partial class OptionsWindow
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mensBtn = new System.Windows.Forms.Button();
            this.womensBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.logoutBtn.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Location = new System.Drawing.Point(19, 20);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(104, 32);
            this.logoutBtn.TabIndex = 26;
            this.logoutBtn.Text = "< LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(34, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 34);
            this.label5.TabIndex = 27;
            this.label5.Text = "Choose your preference:";
            // 
            // mensBtn
            // 
            this.mensBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mensBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensBtn.ForeColor = System.Drawing.Color.Transparent;
            this.mensBtn.Location = new System.Drawing.Point(40, 201);
            this.mensBtn.Name = "mensBtn";
            this.mensBtn.Size = new System.Drawing.Size(318, 142);
            this.mensBtn.TabIndex = 28;
            this.mensBtn.Text = "Men\'s Workout";
            this.mensBtn.UseVisualStyleBackColor = false;
            this.mensBtn.Click += new System.EventHandler(this.mensBtn_Click);
            // 
            // womensBtn
            // 
            this.womensBtn.BackColor = System.Drawing.Color.HotPink;
            this.womensBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.womensBtn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.womensBtn.Location = new System.Drawing.Point(40, 389);
            this.womensBtn.Name = "womensBtn";
            this.womensBtn.Size = new System.Drawing.Size(318, 142);
            this.womensBtn.TabIndex = 29;
            this.womensBtn.Text = "Women\'s Workout";
            this.womensBtn.UseVisualStyleBackColor = false;
            this.womensBtn.Click += new System.EventHandler(this.womensBtn_Click);
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 658);
            this.Controls.Add(this.womensBtn);
            this.Controls.Add(this.mensBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logoutBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mensBtn;
        private System.Windows.Forms.Button womensBtn;
    }
}