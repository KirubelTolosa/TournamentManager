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
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
            LoadItems();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var frmAddMember = new AddMember();
            frmAddMember.Show(); 
        }

      

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void ListViewMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;


           
            var selectedItem = listView.SelectedItems[0];
             
            lblSelectionStatus.Text = "You have selected an " + selectedItem.Text;
        }

       
    }
}
