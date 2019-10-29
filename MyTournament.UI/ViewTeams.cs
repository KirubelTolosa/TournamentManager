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
            var len = Program.teamDirectory.Length;

            for (int i = 0; i < Program.Counter; i++)
            {
                listView1.Items.Add(Program.teamDirectory[i].Id +"-" + Program.teamDirectory[i].Name);
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.Counter; i++)
            {

                listView1.Items.Add(Program.teamDirectory[i].Id + "-" + Program.teamDirectory[i].Name);
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            var frmAddTeam = new AddTeam();
            frmAddTeam.Show();
        }

      
    }
}
