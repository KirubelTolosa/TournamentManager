
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
            this.lblMembersInTournament = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSelectionStatus = new System.Windows.Forms.Label();
            this.gridViewMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMembersInTournament
            // 
            this.lblMembersInTournament.AutoSize = true;
            this.lblMembersInTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersInTournament.Location = new System.Drawing.Point(51, 41);
            this.lblMembersInTournament.Name = "lblMembersInTournament";
            this.lblMembersInTournament.Size = new System.Drawing.Size(265, 18);
            this.lblMembersInTournament.TabIndex = 1;
            this.lblMembersInTournament.Text = "All members in the the tournament";
            this.lblMembersInTournament.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddMember.Location = new System.Drawing.Point(730, 74);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnRefresh.Location = new System.Drawing.Point(730, 166);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblSelectionStatus.Location = new System.Drawing.Point(31, 510);
            this.lblSelectionStatus.Name = "lblSelectionStatus";
            this.lblSelectionStatus.Size = new System.Drawing.Size(120, 17);
            this.lblSelectionStatus.TabIndex = 4;
            this.lblSelectionStatus.Text = "Selection status...";
            // 
            // gridViewMembers
            // 
            this.gridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMembers.Location = new System.Drawing.Point(34, 74);
            this.gridViewMembers.Name = "gridViewMembers";
            this.gridViewMembers.RowHeadersWidth = 51;
            this.gridViewMembers.RowTemplate.Height = 24;
            this.gridViewMembers.Size = new System.Drawing.Size(656, 421);
            this.gridViewMembers.TabIndex = 5;
            this.gridViewMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMembers_CellContentClick);
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 536);
            this.Controls.Add(this.gridViewMembers);
            this.Controls.Add(this.lblSelectionStatus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.lblMembersInTournament);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewMembers";
            this.Text = "ViewMembers";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       /* public  void LoadItems()
        {
            listViewMembers.Items.Clear();

            for (int i = 0; i < Program.memberDirectory.Count; i++)
            {
                listViewMembers.Items.Add(Program.memberDirectory[i].firstName + "-" + Program.memberDirectory[i].lastName);
            }
        } */

        #endregion
        private System.Windows.Forms.Label lblMembersInTournament;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSelectionStatus;
        private System.Windows.Forms.DataGridView gridViewMembers;
    }
}