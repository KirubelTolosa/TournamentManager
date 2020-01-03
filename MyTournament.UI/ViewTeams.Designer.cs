using System;
using System.Windows.Forms;

namespace MyTournament.UI
{
    partial class ViewTeams
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridViewTeams = new System.Windows.Forms.DataGridView();
            this.clmnTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.lblDeletedTeamStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(576, 47);
            this.btnAddTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(100, 28);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(47, 47);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
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
            this.gridViewTeams.Location = new System.Drawing.Point(47, 98);
            this.gridViewTeams.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewTeams.Name = "gridViewTeams";
            this.gridViewTeams.RowHeadersWidth = 51;
            this.gridViewTeams.Size = new System.Drawing.Size(629, 320);
            this.gridViewTeams.TabIndex = 4;
            this.gridViewTeams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewTeams_CellContentClick);
            // 
            // clmnTeamName
            // 
            this.clmnTeamName.HeaderText = "Team Name";
            this.clmnTeamName.MinimumWidth = 6;
            this.clmnTeamName.Name = "clmnTeamName";
            this.clmnTeamName.ReadOnly = true;
            this.clmnTeamName.Visible = false;
            this.clmnTeamName.Width = 125;
            // 
            // clmnTeamID
            // 
            this.clmnTeamID.HeaderText = "Team ID";
            this.clmnTeamID.MinimumWidth = 6;
            this.clmnTeamID.Name = "clmnTeamID";
            this.clmnTeamID.ReadOnly = true;
            this.clmnTeamID.Visible = false;
            this.clmnTeamID.Width = 125;
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(576, 441);
            this.btnDeleteTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteTeam.TabIndex = 5;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.BtnDeleteTeam_Click);
            // 
            // lblDeletedTeamStatus
            // 
            this.lblDeletedTeamStatus.AutoSize = true;
            this.lblDeletedTeamStatus.Location = new System.Drawing.Point(45, 435);
            this.lblDeletedTeamStatus.Name = "lblDeletedTeamStatus";
            this.lblDeletedTeamStatus.Size = new System.Drawing.Size(0, 21);
            this.lblDeletedTeamStatus.TabIndex = 6;
            // 
            // ViewTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.lblDeletedTeamStatus);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.gridViewTeams);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTeam);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewTeams";
            this.Text = "View Teams";
            this.Load += new System.EventHandler(this.ViewTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GridViewTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gridViewTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTeamID;
        private Button btnDeleteTeam;
        private Label lblDeletedTeamStatus;
    }
}