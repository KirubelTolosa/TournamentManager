using MyTournament.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyTournament.DAL
{
    public class TeamDataRepository
    {
        public static void AddTeam(string teamId, string teamName)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=KIRUBELTOLOSA\SQLEXPRESS;Initial Catalog=tournament;Integrated Security=SSPI");

            SqlCommand sqlCommand = new SqlCommand("insert into team(team_id, teamName) values ( @tId ,@tName)", sqlConnection);
            SqlParameter tId = new SqlParameter("tId", System.Data.SqlDbType.NVarChar);
            tId.Value = teamId;

            SqlParameter tName = new SqlParameter("tName", System.Data.SqlDbType.NVarChar);
            tName.Value = teamName;

            sqlCommand.Parameters.Add(tId);
            sqlCommand.Parameters.Add(tName);

            try
            {
                sqlConnection.Open();   

                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /*public static void AddTeam(string teamId, string teamName)
        {
            throw new NotImplementedException();
        }*/

        public static List<TeamDADto> GetAllTeams()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=KIRUBELTOLOSA\SQLEXPRESS;Initial Catalog=tournament;Integrated Security=SSPI");
            SqlCommand sqlCommand = new SqlCommand("select Team_ID, TeamName from team", sqlConnection);
            List<TeamDADto> teams = new List<TeamDADto>();
            try
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    var teamDto = new TeamDADto();
                    teamDto.Id = (string)reader["Team_ID"];
                    teamDto.Name = (string)reader["TeamName"];
                    teams.Add(teamDto);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally {
                sqlConnection.Close();
            }          
            return teams;           

        }

        public static int CountTeams()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=KIRUBELTOLOSA\SQLEXPRESS;Initial Catalog=tournament;Integrated Security=SSPI");
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM TEAM", sqlConnection);
            int teamCount;
            try
            {
                sqlConnection.Open();
                teamCount = (Int32)sqlCommand.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
            return teamCount;

        }

        public static List<string> GetTeamIds()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=KIRUBELTOLOSA\SQLEXPRESS;Initial Catalog=tournament;Integrated Security=SSPI");
            SqlCommand sqlCommand = new SqlCommand("select team.team_ID from team", sqlConnection);
            List<string> teamIds = new List<string>();
            try
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                
                              
               while (reader.Read())
                {
                    string teamId = (string)reader["team_ID"];
                    teamIds.Add(teamId);
                }               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
            return teamIds;

        }
    }
}
