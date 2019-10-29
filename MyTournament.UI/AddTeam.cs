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
              Program.AddTeams(this.txtTeamName.Text, this.txtTeamId.Text);
        }

        private void TxtTeamName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
