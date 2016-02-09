﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Samwise.SamwiseSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xmlsoccer.com/", ConfigurationName="SamwiseSvc.FootballDataDemoSoap")]
    public interface FootballDataDemoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByTeamAndDateInterval", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetHistoricMatchesByTeamAndDateInterval(string ApiKey, string teamId, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByTeamAndDateInterval", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByTeamAndDateIntervalAsync(string ApiKey, string teamId, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetHistoricMatchesByID(string ApiKey, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByID", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByIDAsync(string ApiKey, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixtureMatchByID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetFixtureMatchByID(string ApiKey, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixtureMatchByID", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixtureMatchByIDAsync(string ApiKey, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetTopScorersByLeagueAndSeason", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetTopScorersByLeagueAndSeason(string ApiKey, string league, string seasonDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetTopScorersByLeagueAndSeason", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetTopScorersByLeagueAndSeasonAsync(string ApiKey, string league, string seasonDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetTopScorersByGroupId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetTopScorersByGroupId(string ApiKey, int groupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetTopScorersByGroupId", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetTopScorersByGroupIdAsync(string ApiKey, int groupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByFixtureMatchID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetHistoricMatchesByFixtureMatchID(string ApiKey, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByFixtureMatchID", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByFixtureMatchIDAsync(string ApiKey, int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByLeagueAndDateInterval", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetHistoricMatchesByLeagueAndDateInterval(string ApiKey, string league, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByLeagueAndDateInterval", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByLeagueAndDateIntervalAsync(string ApiKey, string league, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByLeagueAndSeason", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetHistoricMatchesByLeagueAndSeason(string ApiKey, string league, string seasonDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByLeagueAndSeason", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByLeagueAndSeasonAsync(string ApiKey, string league, string seasonDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByTeamsAndDateInterval", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetHistoricMatchesByTeamsAndDateInterval(string ApiKey, string team1Id, string team2Id, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetHistoricMatchesByTeamsAndDateInterval", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByTeamsAndDateIntervalAsync(string ApiKey, string team1Id, string team2Id, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetAllOddsByFixtureMatchId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetAllOddsByFixtureMatchId(string ApiKey, int fixtureMatch_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetAllOddsByFixtureMatchId", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetAllOddsByFixtureMatchIdAsync(string ApiKey, int fixtureMatch_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixturesByDateInterval", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetFixturesByDateInterval(string ApiKey, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixturesByDateInterval", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixturesByDateIntervalAsync(string ApiKey, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixturesByDateIntervalAndLeague", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetFixturesByDateIntervalAndLeague(string league, string ApiKey, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixturesByDateIntervalAndLeague", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixturesByDateIntervalAndLeagueAsync(string league, string ApiKey, string startDateString, string endDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixturesByDateIntervalAndTeam", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetFixturesByDateIntervalAndTeam(string ApiKey, string startDateString, string endDateString, string teamId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixturesByDateIntervalAndTeam", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixturesByDateIntervalAndTeamAsync(string ApiKey, string startDateString, string endDateString, string teamId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetAllTeams", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetAllTeams(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetAllTeams", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetAllTeamsAsync(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetAllLeagues", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetAllLeagues(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetAllLeagues", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetAllLeaguesAsync(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixturesByLeagueAndSeason", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetFixturesByLeagueAndSeason(string ApiKey, string seasonDateString, string league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetFixturesByLeagueAndSeason", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixturesByLeagueAndSeasonAsync(string ApiKey, string seasonDateString, string league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetLeagueStandingsBySeason", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetLeagueStandingsBySeason(string ApiKey, string league, string seasonDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetLeagueStandingsBySeason", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetLeagueStandingsBySeasonAsync(string ApiKey, string league, string seasonDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetAllTeamsByLeagueAndSeason", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetAllTeamsByLeagueAndSeason(string ApiKey, string league, string seasonDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetAllTeamsByLeagueAndSeason", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetAllTeamsByLeagueAndSeasonAsync(string ApiKey, string league, string seasonDateString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetEarliestMatchDatePerLeague", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetEarliestMatchDatePerLeague(string ApiKey, string league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetEarliestMatchDatePerLeague", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetEarliestMatchDatePerLeagueAsync(string ApiKey, string league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetLiveScore", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetLiveScore(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetLiveScore", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetLiveScoreAsync(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetLiveScoreByLeague", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetLiveScoreByLeague(string ApiKey, string league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetLiveScoreByLeague", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetLiveScoreByLeagueAsync(string ApiKey, string league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetPlayersByTeam", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetPlayersByTeam(string ApiKey, string teamId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetPlayersByTeam", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetPlayersByTeamAsync(string ApiKey, string teamId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetPlayerById", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetPlayerById(string ApiKey, int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetPlayerById", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetPlayerByIdAsync(string ApiKey, int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetTeam", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetTeam(string ApiKey, string teamName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetTeam", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetTeamAsync(string ApiKey, string teamName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetOddsByFixtureMatchId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetOddsByFixtureMatchId(string ApiKey, string fixtureMatch_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetOddsByFixtureMatchId", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetOddsByFixtureMatchIdAsync(string ApiKey, string fixtureMatch_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetOddsByFixtureMatchId2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetOddsByFixtureMatchId2(string ApiKey, string fixtureMatch_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetOddsByFixtureMatchId2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetOddsByFixtureMatchId2Async(string ApiKey, string fixtureMatch_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetNextMatchOddsByLeague", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode GetNextMatchOddsByLeague(string ApiKey, string league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/GetNextMatchOddsByLeague", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> GetNextMatchOddsByLeagueAsync(string ApiKey, string league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/IsMyApiKeyPutOnSpammersList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string IsMyApiKeyPutOnSpammersList(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/IsMyApiKeyPutOnSpammersList", ReplyAction="*")]
        System.Threading.Tasks.Task<string> IsMyApiKeyPutOnSpammersListAsync(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/CheckApiKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CheckApiKey(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xmlsoccer.com/CheckApiKey", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CheckApiKeyAsync(string ApiKey);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FootballDataDemoSoapChannel : Samwise.SamwiseSvc.FootballDataDemoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FootballDataDemoSoapClient : System.ServiceModel.ClientBase<Samwise.SamwiseSvc.FootballDataDemoSoap>, Samwise.SamwiseSvc.FootballDataDemoSoap {
        
        public FootballDataDemoSoapClient() {
        }
        
        public FootballDataDemoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FootballDataDemoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FootballDataDemoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FootballDataDemoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Xml.XmlNode GetHistoricMatchesByTeamAndDateInterval(string ApiKey, string teamId, string startDateString, string endDateString) {
            return base.Channel.GetHistoricMatchesByTeamAndDateInterval(ApiKey, teamId, startDateString, endDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByTeamAndDateIntervalAsync(string ApiKey, string teamId, string startDateString, string endDateString) {
            return base.Channel.GetHistoricMatchesByTeamAndDateIntervalAsync(ApiKey, teamId, startDateString, endDateString);
        }
        
        public System.Xml.XmlNode GetHistoricMatchesByID(string ApiKey, int Id) {
            return base.Channel.GetHistoricMatchesByID(ApiKey, Id);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByIDAsync(string ApiKey, int Id) {
            return base.Channel.GetHistoricMatchesByIDAsync(ApiKey, Id);
        }
        
        public System.Xml.XmlNode GetFixtureMatchByID(string ApiKey, int Id) {
            return base.Channel.GetFixtureMatchByID(ApiKey, Id);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixtureMatchByIDAsync(string ApiKey, int Id) {
            return base.Channel.GetFixtureMatchByIDAsync(ApiKey, Id);
        }
        
        public System.Xml.XmlNode GetTopScorersByLeagueAndSeason(string ApiKey, string league, string seasonDateString) {
            return base.Channel.GetTopScorersByLeagueAndSeason(ApiKey, league, seasonDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetTopScorersByLeagueAndSeasonAsync(string ApiKey, string league, string seasonDateString) {
            return base.Channel.GetTopScorersByLeagueAndSeasonAsync(ApiKey, league, seasonDateString);
        }
        
        public System.Xml.XmlNode GetTopScorersByGroupId(string ApiKey, int groupId) {
            return base.Channel.GetTopScorersByGroupId(ApiKey, groupId);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetTopScorersByGroupIdAsync(string ApiKey, int groupId) {
            return base.Channel.GetTopScorersByGroupIdAsync(ApiKey, groupId);
        }
        
        public System.Xml.XmlNode GetHistoricMatchesByFixtureMatchID(string ApiKey, int Id) {
            return base.Channel.GetHistoricMatchesByFixtureMatchID(ApiKey, Id);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByFixtureMatchIDAsync(string ApiKey, int Id) {
            return base.Channel.GetHistoricMatchesByFixtureMatchIDAsync(ApiKey, Id);
        }
        
        public System.Xml.XmlNode GetHistoricMatchesByLeagueAndDateInterval(string ApiKey, string league, string startDateString, string endDateString) {
            return base.Channel.GetHistoricMatchesByLeagueAndDateInterval(ApiKey, league, startDateString, endDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByLeagueAndDateIntervalAsync(string ApiKey, string league, string startDateString, string endDateString) {
            return base.Channel.GetHistoricMatchesByLeagueAndDateIntervalAsync(ApiKey, league, startDateString, endDateString);
        }
        
        public System.Xml.XmlNode GetHistoricMatchesByLeagueAndSeason(string ApiKey, string league, string seasonDateString) {
            return base.Channel.GetHistoricMatchesByLeagueAndSeason(ApiKey, league, seasonDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByLeagueAndSeasonAsync(string ApiKey, string league, string seasonDateString) {
            return base.Channel.GetHistoricMatchesByLeagueAndSeasonAsync(ApiKey, league, seasonDateString);
        }
        
        public System.Xml.XmlNode GetHistoricMatchesByTeamsAndDateInterval(string ApiKey, string team1Id, string team2Id, string startDateString, string endDateString) {
            return base.Channel.GetHistoricMatchesByTeamsAndDateInterval(ApiKey, team1Id, team2Id, startDateString, endDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetHistoricMatchesByTeamsAndDateIntervalAsync(string ApiKey, string team1Id, string team2Id, string startDateString, string endDateString) {
            return base.Channel.GetHistoricMatchesByTeamsAndDateIntervalAsync(ApiKey, team1Id, team2Id, startDateString, endDateString);
        }
        
        public System.Xml.XmlNode GetAllOddsByFixtureMatchId(string ApiKey, int fixtureMatch_Id) {
            return base.Channel.GetAllOddsByFixtureMatchId(ApiKey, fixtureMatch_Id);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetAllOddsByFixtureMatchIdAsync(string ApiKey, int fixtureMatch_Id) {
            return base.Channel.GetAllOddsByFixtureMatchIdAsync(ApiKey, fixtureMatch_Id);
        }
        
        public System.Xml.XmlNode GetFixturesByDateInterval(string ApiKey, string startDateString, string endDateString) {
            return base.Channel.GetFixturesByDateInterval(ApiKey, startDateString, endDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixturesByDateIntervalAsync(string ApiKey, string startDateString, string endDateString) {
            return base.Channel.GetFixturesByDateIntervalAsync(ApiKey, startDateString, endDateString);
        }
        
        public System.Xml.XmlNode GetFixturesByDateIntervalAndLeague(string league, string ApiKey, string startDateString, string endDateString) {
            return base.Channel.GetFixturesByDateIntervalAndLeague(league, ApiKey, startDateString, endDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixturesByDateIntervalAndLeagueAsync(string league, string ApiKey, string startDateString, string endDateString) {
            return base.Channel.GetFixturesByDateIntervalAndLeagueAsync(league, ApiKey, startDateString, endDateString);
        }
        
        public System.Xml.XmlNode GetFixturesByDateIntervalAndTeam(string ApiKey, string startDateString, string endDateString, string teamId) {
            return base.Channel.GetFixturesByDateIntervalAndTeam(ApiKey, startDateString, endDateString, teamId);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixturesByDateIntervalAndTeamAsync(string ApiKey, string startDateString, string endDateString, string teamId) {
            return base.Channel.GetFixturesByDateIntervalAndTeamAsync(ApiKey, startDateString, endDateString, teamId);
        }
        
        public System.Xml.XmlNode GetAllTeams(string ApiKey) {
            return base.Channel.GetAllTeams(ApiKey);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetAllTeamsAsync(string ApiKey) {
            return base.Channel.GetAllTeamsAsync(ApiKey);
        }
        
        public System.Xml.XmlNode GetAllLeagues(string ApiKey) {
            return base.Channel.GetAllLeagues(ApiKey);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetAllLeaguesAsync(string ApiKey) {
            return base.Channel.GetAllLeaguesAsync(ApiKey);
        }
        
        public System.Xml.XmlNode GetFixturesByLeagueAndSeason(string ApiKey, string seasonDateString, string league) {
            return base.Channel.GetFixturesByLeagueAndSeason(ApiKey, seasonDateString, league);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetFixturesByLeagueAndSeasonAsync(string ApiKey, string seasonDateString, string league) {
            return base.Channel.GetFixturesByLeagueAndSeasonAsync(ApiKey, seasonDateString, league);
        }
        
        public System.Xml.XmlNode GetLeagueStandingsBySeason(string ApiKey, string league, string seasonDateString) {
            return base.Channel.GetLeagueStandingsBySeason(ApiKey, league, seasonDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetLeagueStandingsBySeasonAsync(string ApiKey, string league, string seasonDateString) {
            return base.Channel.GetLeagueStandingsBySeasonAsync(ApiKey, league, seasonDateString);
        }
        
        public System.Xml.XmlNode GetAllTeamsByLeagueAndSeason(string ApiKey, string league, string seasonDateString) {
            return base.Channel.GetAllTeamsByLeagueAndSeason(ApiKey, league, seasonDateString);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetAllTeamsByLeagueAndSeasonAsync(string ApiKey, string league, string seasonDateString) {
            return base.Channel.GetAllTeamsByLeagueAndSeasonAsync(ApiKey, league, seasonDateString);
        }
        
        public System.Xml.XmlNode GetEarliestMatchDatePerLeague(string ApiKey, string league) {
            return base.Channel.GetEarliestMatchDatePerLeague(ApiKey, league);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetEarliestMatchDatePerLeagueAsync(string ApiKey, string league) {
            return base.Channel.GetEarliestMatchDatePerLeagueAsync(ApiKey, league);
        }
        
        public System.Xml.XmlNode GetLiveScore(string ApiKey) {
            return base.Channel.GetLiveScore(ApiKey);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetLiveScoreAsync(string ApiKey) {
            return base.Channel.GetLiveScoreAsync(ApiKey);
        }
        
        public System.Xml.XmlNode GetLiveScoreByLeague(string ApiKey, string league) {
            return base.Channel.GetLiveScoreByLeague(ApiKey, league);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetLiveScoreByLeagueAsync(string ApiKey, string league) {
            return base.Channel.GetLiveScoreByLeagueAsync(ApiKey, league);
        }
        
        public System.Xml.XmlNode GetPlayersByTeam(string ApiKey, string teamId) {
            return base.Channel.GetPlayersByTeam(ApiKey, teamId);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetPlayersByTeamAsync(string ApiKey, string teamId) {
            return base.Channel.GetPlayersByTeamAsync(ApiKey, teamId);
        }
        
        public System.Xml.XmlNode GetPlayerById(string ApiKey, int playerId) {
            return base.Channel.GetPlayerById(ApiKey, playerId);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetPlayerByIdAsync(string ApiKey, int playerId) {
            return base.Channel.GetPlayerByIdAsync(ApiKey, playerId);
        }
        
        public System.Xml.XmlNode GetTeam(string ApiKey, string teamName) {
            return base.Channel.GetTeam(ApiKey, teamName);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetTeamAsync(string ApiKey, string teamName) {
            return base.Channel.GetTeamAsync(ApiKey, teamName);
        }
        
        public System.Xml.XmlNode GetOddsByFixtureMatchId(string ApiKey, string fixtureMatch_Id) {
            return base.Channel.GetOddsByFixtureMatchId(ApiKey, fixtureMatch_Id);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetOddsByFixtureMatchIdAsync(string ApiKey, string fixtureMatch_Id) {
            return base.Channel.GetOddsByFixtureMatchIdAsync(ApiKey, fixtureMatch_Id);
        }
        
        public System.Xml.XmlNode GetOddsByFixtureMatchId2(string ApiKey, string fixtureMatch_Id) {
            return base.Channel.GetOddsByFixtureMatchId2(ApiKey, fixtureMatch_Id);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetOddsByFixtureMatchId2Async(string ApiKey, string fixtureMatch_Id) {
            return base.Channel.GetOddsByFixtureMatchId2Async(ApiKey, fixtureMatch_Id);
        }
        
        public System.Xml.XmlNode GetNextMatchOddsByLeague(string ApiKey, string league) {
            return base.Channel.GetNextMatchOddsByLeague(ApiKey, league);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> GetNextMatchOddsByLeagueAsync(string ApiKey, string league) {
            return base.Channel.GetNextMatchOddsByLeagueAsync(ApiKey, league);
        }
        
        public string IsMyApiKeyPutOnSpammersList(string ApiKey) {
            return base.Channel.IsMyApiKeyPutOnSpammersList(ApiKey);
        }
        
        public System.Threading.Tasks.Task<string> IsMyApiKeyPutOnSpammersListAsync(string ApiKey) {
            return base.Channel.IsMyApiKeyPutOnSpammersListAsync(ApiKey);
        }
        
        public string CheckApiKey(string ApiKey) {
            return base.Channel.CheckApiKey(ApiKey);
        }
        
        public System.Threading.Tasks.Task<string> CheckApiKeyAsync(string ApiKey) {
            return base.Channel.CheckApiKeyAsync(ApiKey);
        }
    }
}