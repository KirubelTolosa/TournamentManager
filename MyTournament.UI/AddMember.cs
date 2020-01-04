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
using Autofac;
using MyTournament.BLL.DataModel.Exceptions;

namespace MyTournament.UI
{
    public partial class AddMember : Form
    {

    private ITeamBLService teamBLService = new TeamBLService();

     public AddMember()
        {
            InitializeComponent();
            var teamIds = teamBLService.GetTeamIds();
            
            // 1st attempt = setting data source to dropdown             
            // txtteam_IdDrop.DataSource = teamIds;

            // 2nd attempt = adding items to dropdown list  
            foreach (var id in teamIds)
            {
                
                txtteam_IdDrop.Items.Add(id);
            }
        }

    public AddMember(ITeamBLService teamBLService) : this()
    {
      this.teamBLService = teamBLService;
    }
    



        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {           
            if (this.txtmember_Id.Text != "" && this.txtmember_Id.Text != null)
                {
                    var selectedId = txtteam_IdDrop.SelectedItem;
                    var model = new MemberBLDto(this.txtmember_Id.Text, this.txtmemberName.Text, this.txtposition.Text, selectedId.ToString());
                    var blService = new MemberBLService();
                    blService.AddMember(model); 
                


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
            catch (AddMemberException ex)
            {
                lblActionStatus.Text = "Team is Full!!";
                throw ex;
            }
            
        }

       
    }
}
