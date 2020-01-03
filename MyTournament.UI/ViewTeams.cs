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
    public partial class ViewTeams : Form
    {
      
        public ViewTeams()
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

            //call the business logic service 
            TeamBLService item = new TeamBLService();
            var teamBlDtos = item.GetAllTeams();

            List<Team> teams = new List<Team>();
            foreach(var blDto in teamBlDtos)
            {
                teams.Add(new Team()
                {
                    Id = blDto.Id, Name = blDto.Name
                });
            }


            //load it to listViews
            /*listViewTeams.Items.Clear();
            foreach (var curr in teams)
            {
                listViewTeams.Items.Add(curr.Id + "-" + curr.Name);
            }

            //Grid view binding option 1*/
            //load it to the grid view

            var dt = new DataTable();
           dt.Columns.Add(new DataColumn("Team Id", typeof(int)));
           dt.Columns.Add(new DataColumn("Team Name", typeof(string)));

            foreach(Team team in teams)
            {
                var row = dt.NewRow();
                row["Team Name"] = team.Name;
                row["Team Id"] = team.Id;
                dt.Rows.Add(row);
            }

            gridViewTeams.DataSource = dt;

            

           
       
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            var frmAddTeam = new AddTeam();
            frmAddTeam.Show();
        }

        
        private void BtnDeleteTeam_Click(object sender, EventArgs e)
        {
           string team_Id = gridViewTeams.SelectedCells[0].Value.ToString();  
           try
            {
                TeamBLService team = new TeamBLService();

                team.DeleteTeam(team_Id);

            }
            catch (TeamBLService.DeleteTeamException ex)
            {
                throw ex;
            }
            finally
            {
                lblDeletedTeamStatus.Text = "You deleted a team";
            }
           
        }        
    }
}
