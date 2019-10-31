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
    public partial class listViewTeams : Form
    {
        public listViewTeams()
        {
            InitializeComponent();
        }

        private void ViewTeams_Load(object sender, EventArgs e)
        {
            LoadTeams();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeams();
        }

        private void LoadTeams()
        {
            listViewTeams.Items.Clear();
            foreach (var curr in Program.teamDirectory)
            {
                listViewTeams.Items.Add(curr.Id + "-" + curr.Name);
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            var frmAddTeam = new AddTeam();
            frmAddTeam.Show();
        }

      
    }
}
