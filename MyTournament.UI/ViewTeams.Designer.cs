namespace MyTournament.UI
{
    partial class frmViewTeams
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
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTeams = new System.Windows.Forms.ListView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridViewTeams = new System.Windows.Forms.DataGridView();
            this.clmnTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(588, 58);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // listViewTeams
            // 
            this.listViewTeams.HideSelection = false;
            this.listViewTeams.Location = new System.Drawing.Point(93, 128);
            this.listViewTeams.Name = "listViewTeams";
            this.listViewTeams.Size = new System.Drawing.Size(188, 310);
            this.listViewTeams.TabIndex = 2;
            this.listViewTeams.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(102, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridViewTeams
            // 
            this.gridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTeamName,
            this.clmnTeamID});
            this.gridViewTeams.Location = new System.Drawing.Point(316, 128);
            this.gridViewTeams.Name = "gridViewTeams";
            this.gridViewTeams.Size = new System.Drawing.Size(472, 260);
            this.gridViewTeams.TabIndex = 4;
            // 
            // clmnTeamName
            // 
            this.clmnTeamName.HeaderText = "Team Name";
            this.clmnTeamName.Name = "clmnTeamName";
            this.clmnTeamName.ReadOnly = true;
            this.clmnTeamName.Visible = false;
            // 
            // clmnTeamID
            // 
            this.clmnTeamID.HeaderText = "Team ID";
            this.clmnTeamID.Name = "clmnTeamID";
            this.clmnTeamID.ReadOnly = true;
            this.clmnTeamID.Visible = false;
            // 
            // frmViewTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewTeams);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listViewTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTeam);
            this.Name = "frmViewTeams";
            this.Text = "View Teams";
            this.Load += new System.EventHandler(this.ViewTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTeams;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gridViewTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTeamID;
    }
}