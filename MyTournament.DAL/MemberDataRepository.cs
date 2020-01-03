using MyTournament.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.DAL
{
    public class MemberDataRepository 
    {
        public static bool errorOccured = false;
        public static List<MemberDADto> GetAllMembers()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=KIRUBELTOLOSA\SQLEXPRESS;Initial Catalog=tournament;Integrated Security=SSPI");
            SqlCommand sqlCommand = new SqlCommand("select Member_ID, MemberName, Position, Team_Id from Member", sqlConnection);
            List<MemberDADto> Members = new List<MemberDADto>();
            try
            {
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    var memberDto = new MemberDADto();
                    memberDto.Id = (string)reader["Member_ID"];
                    memberDto.Name = (string)reader["MemberName"];
                    memberDto.Position = (string)reader["Position"];
                    memberDto.Team_ID = (string)reader["Team_Id"];
                    Members.Add(memberDto);
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
            return Members;

        }

        public static void AddMember(MemberDADto memberDADto)
        {
            AddMember(memberDADto.Id, memberDADto.Name, memberDADto.Position, memberDADto.Team_ID);
        }

        public static void AddMember(string member_Id, string memberName, string position, string team_Id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=KIRUBELTOLOSA\SQLEXPRESS;Initial Catalog=tournament;Integrated Security=SSPI");

            SqlCommand sqlCommand = new SqlCommand("insert into Member(Member_ID, MemberName, Position, Team_ID) values ( @mId ,@mName, @pos, @tID)", sqlConnection);
            SqlParameter mId = new SqlParameter("mId", System.Data.SqlDbType.NVarChar);
            mId.Value = member_Id;

            SqlParameter mName = new SqlParameter("mName", System.Data.SqlDbType.NVarChar);
            mName.Value = memberName;

            SqlParameter tID = new SqlParameter("tID", System.Data.SqlDbType.NVarChar);
            tID.Value = team_Id;

            SqlParameter pos = new SqlParameter("pos", System.Data.SqlDbType.NVarChar);
            pos.Value = position;

            sqlCommand.Parameters.Add(mId);
            sqlCommand.Parameters.Add(mName);
            sqlCommand.Parameters.Add(tID);
            sqlCommand.Parameters.Add(pos);
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

       public static int CountMembers()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=KIRUBELTOLOSA\SQLEXPRESS;Initial Catalog=tournament;Integrated Security=SSPI");
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM MEMBER", sqlConnection);
            int memberCount;
            try
            {
                sqlConnection.Open();
                memberCount = (Int32)sqlCommand.ExecuteScalar();                
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
            return memberCount;

        }

        public static int CountMembersInTeam(string Team_Id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=KIRUBELTOLOSA\SQLEXPRESS;Initial Catalog=tournament;Integrated Security=SSPI");
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM MEMBER WHERE Team_ID = @tID", sqlConnection);
            SqlParameter tId = new SqlParameter("tID", System.Data.SqlDbType.NVarChar);
            tId.Value = Team_Id;
            int teamMemberCount;
            sqlCommand.Parameters.Add(tId);
            try
            {
                sqlConnection.Open();
                teamMemberCount = (Int32)sqlCommand.ExecuteScalar();
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
            return teamMemberCount;

        }
    }
}
