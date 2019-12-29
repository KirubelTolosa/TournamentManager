using MyTournament.BLL;
using MyTournament.BLL.DataModel;
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
            var teamIds = TeamBLService.GetTeamIds();
            
            // 1st attempt = setting data source to dropdown             
            // txtteam_IdDrop.DataSource = teamIds;

            // 2nd attempt = adding items to dropdown list  
            foreach (var ids in teamIds)
            {
                
                txtteam_IdDrop.Items.Add(ids);
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            if (this.txtmember_Id.Text != "" && this.txtmember_Id.Text != null)
                {
                var selectedId = txtteam_IdDrop.SelectedItem;
                var model = new MemberBLDto(this.txtmember_Id.Text, this.txtmemberName.Text, this.txtposition.Text, selectedId.ToString());
                MemberBLService.AddMember(model);

                


                //MemberBLService.AddMember(this.txtmember_Id.Text, this.txtmemberName.Text, this.txtposition.Text, this.txtteam_Id.Text);
                lblNumberOfMembers.ForeColor = Color.Green;
                lblNumberOfMembers.Text = "Your entered values are success";
                
                }
            else
                {
                lblNumberOfMembers.ForeColor = Color.Red;
                lblNumberOfMembers.Text = "You Entered an Invalid value for ID!";
                }
        }

        private void LblId_Click(object sender, EventArgs e)
        {
            
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void LblPosition_Click(object sender, EventArgs e)
        {

        }

        private void Textteam_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtteam_IdDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
