namespace MyTournament.UI
{
    partial class AddMember
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.member_Id = new System.Windows.Forms.Label();
            this.memberName = new System.Windows.Forms.Label();
            this.txtmember_Id = new System.Windows.Forms.TextBox();
            this.txtmemberName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfMembers = new System.Windows.Forms.Label();
            this.team_Id = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtteam_IdDrop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(228, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 24);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // member_Id
            // 
            this.member_Id.AutoSize = true;
            this.member_Id.Location = new System.Drawing.Point(38, 103);
            this.member_Id.Name = "member_Id";
            this.member_Id.Size = new System.Drawing.Size(19, 17);
            this.member_Id.TabIndex = 1;
            this.member_Id.Text = "Id";
            
            // 
            // memberName
            // 
            this.memberName.AutoSize = true;
            this.memberName.Location = new System.Drawing.Point(38, 143);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(45, 17);
            this.memberName.TabIndex = 2;
            this.memberName.Text = "Name";
            // 
            // txtmember_Id
            // 
            this.txtmember_Id.Location = new System.Drawing.Point(137, 103);
            this.txtmember_Id.Name = "txtmember_Id";
            this.txtmember_Id.Size = new System.Drawing.Size(166, 22);
            this.txtmember_Id.TabIndex = 3;
            // 
            // txtmemberName
            // 
            this.txtmemberName.Location = new System.Drawing.Point(137, 140);
            this.txtmemberName.Name = "txtmemberName";
            this.txtmemberName.Size = new System.Drawing.Size(166, 22);
            this.txtmemberName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Member";
            // 
            // lblNumberOfMembers
            // 
            this.lblNumberOfMembers.AutoSize = true;
            this.lblNumberOfMembers.Location = new System.Drawing.Point(134, 331);
            this.lblNumberOfMembers.Name = "lblNumberOfMembers";
            this.lblNumberOfMembers.Size = new System.Drawing.Size(0, 17);
            this.lblNumberOfMembers.TabIndex = 7;
            // 
            // team_Id
            // 
            this.team_Id.AutoSize = true;
            this.team_Id.Location = new System.Drawing.Point(38, 227);
            this.team_Id.Name = "team_Id";
            this.team_Id.Size = new System.Drawing.Size(58, 17);
            this.team_Id.TabIndex = 8;
            this.team_Id.Text = "team_Id";
            
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(137, 184);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(166, 22);
            this.txtposition.TabIndex = 11;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Position";
            
            // 
            // txtteam_IdDrop
            // 
            this.txtteam_IdDrop.FormattingEnabled = true;
            this.txtteam_IdDrop.Location = new System.Drawing.Point(137, 220);
            this.txtteam_IdDrop.Name = "txtteam_IdDrop";
            this.txtteam_IdDrop.Size = new System.Drawing.Size(166, 24);
            this.txtteam_IdDrop.TabIndex = 12;
            
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 406);
            this.Controls.Add(this.txtteam_IdDrop);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.team_Id);
            this.Controls.Add(this.lblNumberOfMembers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmemberName);
            this.Controls.Add(this.txtmember_Id);
            this.Controls.Add(this.memberName);
            this.Controls.Add(this.member_Id);
            this.Controls.Add(this.btnSubmit);
            this.Name = "AddMember";
            this.Text = "AddMember";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label member_Id;
        private System.Windows.Forms.Label memberName;
        private System.Windows.Forms.TextBox txtmember_Id;
        private System.Windows.Forms.TextBox txtmemberName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfMembers;
        private System.Windows.Forms.Label team_Id;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtteam_IdDrop;
    }
}