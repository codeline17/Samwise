using XMLSoccerCOM;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System;

namespace Samwise
{
    public static class ExMthds
    {
        private static readonly string cString = System.Configuration.ConfigurationManager.ConnectionStrings["Samwise.Properties.Settings.SamwiseConnectionString"].ConnectionString;
        public static void Insert(this League league)
        {
            try
            {
                using (var conn = new SqlConnection(cString))
                {
                    using (var command = new SqlCommand("FeedLeagueInsert", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@Id", SqlDbType.BigInt).Value = league.Id;
                        command.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = league.Name.UppercaseWords();
                        command.Parameters.Add("@Country", SqlDbType.VarChar, 100).Value = league.Country.UppercaseWords();
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }                
            }
            catch (System.Exception)
            {
                
            }            
        }

        public static void Insert(this Team team)
        {
            try
            {
                using (var conn = new SqlConnection(cString))
                {
                    using (var command = new SqlCommand("FeedTeamInsert", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@Id", SqlDbType.BigInt).Value = team.Team_Id;
                        command.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = team.Name.UppercaseWords();
                        command.Parameters.Add("@Country", SqlDbType.VarChar, 100).Value = team.Country.UppercaseWords();
                        command.Parameters.Add("@Stadium", SqlDbType.VarChar, 100).Value = team.Stadium != null ? team.Stadium.UppercaseWords() : "" ;
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception)
            {
                
            }
        }

        public static void Insert(this Match match)
        {
            try
            {
                using (var conn = new SqlConnection(cString))
                {
                    using (var command = new SqlCommand("FeedFixtureInsert", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        var league = frmMain.LeaguesList.FirstOrDefault(x=> x.Name == match.League);
                        if (league == null)
                        {
                            var newLeague = new League {Id = frmMain.LeaguesList.Max(x => x.Id) + 1, Name = match.League, Country = "NoCountry"};
                            newLeague.Insert();
                            league = newLeague;
                        }
                        command.Parameters.Add("@league_id", SqlDbType.BigInt).Value = league.Id;
                        command.Parameters.Add("@home_id", SqlDbType.BigInt).Value = match.HomeTeam_Id;
                        command.Parameters.Add("@away_id", SqlDbType.BigInt).Value = match.AwayTeam_Id;
                        command.Parameters.Add("@startdate", SqlDbType.DateTime).Value = match.Date;
                        command.Parameters.Add("@status", SqlDbType.VarChar, 50).Value = match.Time ?? "NoStatus";
                        command.Parameters.Add("@Feed_Id", SqlDbType.BigInt).Value = match.FixtureMatch_Id;
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex)
            {
                Debug.Print("Exeption " + ex.Message);
            }
        }

        public static void FillLeagueList(this List<League> listLeague)
        {
            try
            {
                using (var conn = new SqlConnection(cString))
                {
                    using (var command = new SqlCommand("FeedLeaguesGet", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var league = new League
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Country = reader["Country"].ToString()
                            };
                            listLeague.Add(league);
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                
            }
        }

        public static string UppercaseWords(this string value)
        {
            value = value.ToLower();

            var array = value.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}
