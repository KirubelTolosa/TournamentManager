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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnViewTeams_Click(object sender, EventArgs e)
        {
            lblMessage.Text = " you clicked View teams!";
            listViewTeams frmViewTeams = new listViewTeams();
            frmViewTeams.Show();
        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            lblMessage.Text = " you clicked View members!";
            var frmAddMembers = new ViewMembers();
            frmAddMembers.Show(); 
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "You selected to add team";
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
    }
}
