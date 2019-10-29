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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Program.AddMember(this.txtFirstName.Text, this.txtLastName.Text);
            var a = Program.memberCounter;
            lblNumberOfMembers.Text = "You have entered" + a + "members";
        }

        private void LblNumberOfMembers_Click(object sender, EventArgs e)
        {
            
        }
    }
}
