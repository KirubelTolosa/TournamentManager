using MyTournament.BLL;
using MyTournament.BLL.DataModel.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTournament.UI
{
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Program.AddTeams(this.txtTeamName.Text, this.txtTeamId.Text);

            try
            {
                TeamBLService team = new TeamBLService();
                team.AddTeam(this.txtTeamId.Text, this.txtTeamName.Text);
            }
            catch (AddTeamException)
            {
                lblTeamsStatus.Text = "Tournament is full. Delete a team";
                btnDeleteTeam.Visible = true;
                // I didn't bubble the exception here. I think we'll add a logging feature here
                // I will propmpt the user to delete a team (added a delete team option in view teams)
                // throw ex;
            }
        }
        private void TxtTeamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDeleteTeam_Click(object sender, EventArgs e)
        {
            ViewTeams frmViewTeams = new ViewTeams();
            frmViewTeams.Show();
        }
    }
}
