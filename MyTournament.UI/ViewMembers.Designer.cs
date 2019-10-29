
namespace MyTournament.UI
{
    partial class ViewMembers
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
            this.listViewMembers = new System.Windows.Forms.ListView();
            this.lblMembersInTournament = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSelectionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewMembers
            // 
            this.listViewMembers.HideSelection = false;
            this.listViewMembers.Location = new System.Drawing.Point(243, 69);
            this.listViewMembers.Name = "listViewMembers";
            this.listViewMembers.Size = new System.Drawing.Size(291, 314);
            this.listViewMembers.TabIndex = 0;
            this.listViewMembers.UseCompatibleStateImageBehavior = false;
            this.listViewMembers.SelectedIndexChanged += new System.EventHandler(this.ListViewMembers_SelectedIndexChanged);
            // 
            // lblMembersInTournament
            // 
            this.lblMembersInTournament.AutoSize = true;
            this.lblMembersInTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersInTournament.Location = new System.Drawing.Point(254, 37);
            this.lblMembersInTournament.Name = "lblMembersInTournament";
            this.lblMembersInTournament.Size = new System.Drawing.Size(265, 18);
            this.lblMembersInTournament.TabIndex = 1;
            this.lblMembersInTournament.Text = "All members in the the tournament";
            this.lblMembersInTournament.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddMember.Location = new System.Drawing.Point(55, 83);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(136, 32);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "AddMember";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefresh.Location = new System.Drawing.Point(55, 174);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblSelectionStatus
            // 
            this.lblSelectionStatus.AutoSize = true;
            this.lblSelectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionStatus.Location = new System.Drawing.Point(240, 401);
            this.lblSelectionStatus.Name = "lblSelectionStatus";
            this.lblSelectionStatus.Size = new System.Drawing.Size(120, 17);
            this.lblSelectionStatus.TabIndex = 4;
            this.lblSelectionStatus.Text = "Selection status...";
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 449);
            this.Controls.Add(this.lblSelectionStatus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.lblMembersInTournament);
            this.Controls.Add(this.listViewMembers);
            this.Name = "ViewMembers";
            this.Text = "ViewMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public  void LoadItems()
        {
            listViewMembers.Items.Clear();

            for (int i = 0; i < Program.memberCounter; i++)
            {
                listViewMembers.Items.Add(Program.memberDirectory[i].firstName + "-" + Program.memberDirectory[i].lastName);
            }
        }

        #endregion

        private System.Windows.Forms.ListView listViewMembers;
        private System.Windows.Forms.Label lblMembersInTournament;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSelectionStatus;
    }
}