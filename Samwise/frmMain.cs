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
            InitializeComponent();
            mainTmr.Interval = Convert.ToInt32(new TimeSpan(1, 10, 0).TotalMilliseconds);
            mainTmr.Start();
            tmrLiveScore.Interval = Convert.ToInt32(new TimeSpan(0, 1, 0).TotalMilliseconds);
            tmrLiveScore.Tick += TmrLiveScore_Tick;
            tmrLiveScore.Start();
        }

        private void TmrLiveScore_Tick(object sender, EventArgs e)
        {
            try
            {
                GetLiveScore();
            }
            catch (Exception ex)
            {
                WriteInTxtDebug("LiveScore Exception");
                WriteInTxtDebug(ex.Message);
                Thread.Sleep(60000);
            }
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
            foreach (var item in leagues)
            {
                item.Insert();
            }
        }

        private static void GetFixtures()
        {
            var fixtures = requester.GetFixturesByDateInterval(DateTime.Now,DateTime.Now.AddDays(10));
            foreach (var item in fixtures)
            {
                item.Insert();
            }
        }

        private static void GetTeams()
        {
            var teams = requester.GetAllTeams();
            foreach (var item in teams)
            {
                item.Insert();
            }
        }

        private static void GetLiveScore()
        {
            var fixtures = requester.GetLiveScore();
            foreach (var match in fixtures)
            {
                match.Update();
            }
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
            catch (Exception ex)
            {
                WriteInTxtDebug("Main Timer Exception");
                WriteInTxtDebug(ex.Message);
                Thread.Sleep(60000);
            }
        }
    }
}
