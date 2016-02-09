using System.Windows.Forms;
using System.Configuration;
using XMLSoccerCOM;
using System.Collections.Generic;
using System;
using System.Threading;

namespace Samwise
{
    public partial class frmMain : Form
    {
        private static readonly string apikey = ConfigurationManager.AppSettings["apikey"];
        private static Requester requester = new Requester(apikey, true);
        public static List<League> LeaguesList = new List<League>();
        public static List<Match> MatchList = new List<Match>();

        public frmMain()
        {
            DoTheTwist();
            InitializeComponent();
            mainTmr.Interval = Convert.ToInt32(new TimeSpan(1, 10, 0).TotalMilliseconds);
            mainTmr.Start();
        }

        private static void DoTheTwist()
        {
            GetLeagues();
            LeaguesList.FillLeagueList();
            GetTeams();
            GetFixtures();
        }
        private static void GetLeagues()
        {
            var leagues = requester.GetAllLeagues();
            foreach (League item in leagues)
            {
                item.Insert();
            }
        }

        private static void GetFixtures()
        {
            var fixtures = requester.GetFixturesByDateInterval(DateTime.Now,DateTime.Now.AddDays(10));
            foreach (Match item in fixtures)
            {
                item.Insert();
            }
        }

        private static void GetTeams()
        {
            var teams = requester.GetAllTeams();
            foreach (Team item in teams)
            {
                item.Insert();
            }
        }

        private static void GetLiveScore()
        {
                     
        }

        public void WriteInTxtDebug(string text)
        {
            if (txtDebug.Lines.Length > 50)
            {
                txtDebug.Text = "";
            }

            txtDebug.Text += Environment.NewLine + text;
        }

        private void mainTmr_Tick(object sender, EventArgs e)
        {
            try
            {
                DoTheTwist();
            }
            catch (Exception)
            {
                mainTmr.Stop();
                WriteInTxtDebug("Stopped nga DoTheTwistError");
            }
        }
    }
}
