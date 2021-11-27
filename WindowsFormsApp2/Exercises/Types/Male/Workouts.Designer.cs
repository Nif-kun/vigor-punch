
namespace WindowsFormsApp2
{
    partial class frmManWorkout
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
            this.btnManChestStart = new System.Windows.Forms.Button();
            this.btnManBackStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManChestStart
            // 
            this.btnManChestStart.Font = new System.Drawing.Font("Kudos Black SSi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManChestStart.Location = new System.Drawing.Point(101, 162);
            this.btnManChestStart.Name = "btnManChestStart";
            this.btnManChestStart.Size = new System.Drawing.Size(150, 50);
            this.btnManChestStart.TabIndex = 0;
            this.btnManChestStart.Text = "START";
            this.btnManChestStart.UseVisualStyleBackColor = true;
            this.btnManChestStart.Click += new System.EventHandler(this.btnManChestStart_Click);
            // 
            // btnManBackStart
            // 
            this.btnManBackStart.Font = new System.Drawing.Font("Kudos Black SSi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManBackStart.Location = new System.Drawing.Point(101, 432);
            this.btnManBackStart.Name = "btnManBackStart";
            this.btnManBackStart.Size = new System.Drawing.Size(150, 50);
            this.btnManBackStart.TabIndex = 1;
            this.btnManBackStart.Text = "START";
            this.btnManBackStart.UseVisualStyleBackColor = true;
            this.btnManBackStart.Click += new System.EventHandler(this.btnManBackStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "insert photo (CHEST EXERCISE)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "insert photo (BACK EXERCISE)";
            // 
            // frmManWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManBackStart);
            this.Controls.Add(this.btnManChestStart);
            this.Name = "frmManWorkout";
            this.Text = "Man\'s Workout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManChestStart;
        private System.Windows.Forms.Button btnManBackStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}