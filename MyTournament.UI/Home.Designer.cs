namespace MyTournament.UI
{
    partial class Home
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewTeams = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnViewMembers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(208, 112);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(397, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to My Kirubel Tournament";
            // 
            // btnViewTeams
            // 
            this.btnViewTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTeams.Location = new System.Drawing.Point(174, 207);
            this.btnViewTeams.Name = "btnViewTeams";
            this.btnViewTeams.Size = new System.Drawing.Size(138, 37);
            this.btnViewTeams.TabIndex = 1;
            this.btnViewTeams.Text = "View Teams";
            this.btnViewTeams.UseVisualStyleBackColor = true;
            this.btnViewTeams.Click += new System.EventHandler(this.btnViewTeams_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(237, 322);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // btnViewMembers
            // 
            this.btnViewMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMembers.Location = new System.Drawing.Point(407, 207);
            this.btnViewMembers.Name = "btnViewMembers";
            this.btnViewMembers.Size = new System.Drawing.Size(138, 37);
            this.btnViewMembers.TabIndex = 3;
            this.btnViewMembers.Text = "View Members";
            this.btnViewMembers.UseVisualStyleBackColor = true;
            this.btnViewMembers.Click += new System.EventHandler(this.btnViewMembers_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewMembers);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnViewTeams);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewTeams;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnViewMembers;
    }
}