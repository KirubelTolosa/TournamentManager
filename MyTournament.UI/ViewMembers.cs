using MyTournament.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MyTournament.UI
{
    public partial class ViewMembers : Form
    {
        

        public ViewMembers()
        {
            InitializeComponent();
            LoadMembers();
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
            LoadMembers();
        }

       

        private void ListViewMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;  
            var selectedItem = listView.SelectedItems[0];           
            lblSelectionStatus.Text = "You have selected an " + selectedItem.Text;
        }
       


        private void LoadMembers()
        {
            var
            var memberDADtos = MemberBLService.GetAllMembers();
            List<Member> Members = new List<Member>();
            foreach(var blDto in memberDADtos)
            {
                Members.Add(new Member()
                {
                    Id = blDto.Id,
                    Name = blDto.Name,
                    Position = blDto.Position,
                    Team_ID = blDto.Team_Id
                });
            }

           /* listViewMembers.Items.Clear();
            foreach (var current in Members)
            {
                listViewMembers.Items.Add(current.Id + "-" + current.Name);
            }*/

            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("Member_ID", typeof(string)));
            dt.Columns.Add(new DataColumn("MemberName", typeof(string)));
            dt.Columns.Add(new DataColumn("Position", typeof(string)));
            dt.Columns.Add(new DataColumn("Team_ID", typeof(string)));

            foreach (var member in Members)
            {
                var row = dt.NewRow();
                row["Member_ID"] = member.Id;
                row["MemberName"] = member.Name;
                row["Position"] = member.Position;
                row["Team_ID"] = member.Team_ID;
                dt.Rows.Add(row);
            }
            
            gridViewMembers.DataSource = dt;
        }

        private void GridViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    } 
}
