using MyTournament.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyTournament.UI
{
    public partial class Home : Form
    {
        public IMemberBLService memberBLService = new MemberBLService();
        public ITeamBLService teamBLService = new TeamBLService();

        public Home()
        {
            try
            { 
            InitializeComponent();
            var countMembers = this.memberBLService.CountMembers();
            lblNumberOfMembers.Text = countMembers + "  Members in Tournament!";
            var teamcount = this.teamBLService.CountTeams();
            lblNumberOfTeams.Text = teamcount + "  teams in Tournament!";
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Text = "ERROR OCCURED!!";               
            }
            finally
            {
                
            }            
        }
        
        private void btnViewTeams_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = " you clicked View teams!";
            ViewTeams frmViewTeams = new ViewTeams();
            frmViewTeams.Show();
        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = " you clicked View members!";
            var frmAddMembers = new ViewMembers();
            frmAddMembers.Show(); 
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "You selected to add team";
            var frmAddTeam = new AddTeam();
            frmAddTeam.Show(); 
        }

        private void BtnAddMembers_Click(object sender, EventArgs e)
        {
            var frmAddMembers = new AddMember();
            frmAddMembers.Show(); 
        }

        private void LblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void LblMessage_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfMembers_Click(object sender, EventArgs e)
        {

        }
    }
}
