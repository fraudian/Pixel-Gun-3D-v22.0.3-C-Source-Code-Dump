using UnityEngine;
public class GameCircleSocial : ISocialPlatform
{
    // Fields
    private AGSSocialLocalUser gameCircleLocalUser;
    private int requestID;
    private System.Action<bool> authenticationCallback;
    private System.Collections.Generic.Dictionary<int, System.Action<bool>> simpleCallbacks;
    private System.Collections.Generic.Dictionary<int, System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>> loadAchievementDescriptionsCallbacks;
    private System.Collections.Generic.Dictionary<int, System.Action<UnityEngine.SocialPlatforms.IAchievement[]>> loadAchievementsCallbacks;
    private System.Collections.Generic.Dictionary<int, AGSSocialLeaderboard> leaderboardForRequest;
    private System.Collections.Generic.Dictionary<int, System.Action<UnityEngine.SocialPlatforms.IScore[]>> loadScoresCallbacks;
    private static GameCircleSocial socialInstance;
    
    // Properties
    public static GameCircleSocial Instance { get; }
    public UnityEngine.SocialPlatforms.ILocalUser localUser { get; }
    
    // Methods
    private GameCircleSocial()
    {
        this.gameCircleLocalUser = new AGSSocialLocalUser();
        this.requestID = 1;
        this.simpleCallbacks = new System.Collections.Generic.Dictionary<System.Int32, System.Action<System.Boolean>>();
        this.loadAchievementDescriptionsCallbacks = new System.Collections.Generic.Dictionary<System.Int32, System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]>>();
        this.loadAchievementsCallbacks = new System.Collections.Generic.Dictionary<System.Int32, System.Action<UnityEngine.SocialPlatforms.IAchievement[]>>();
        this.leaderboardForRequest = new System.Collections.Generic.Dictionary<System.Int32, AGSSocialLeaderboard>();
        this.loadScoresCallbacks = new System.Collections.Generic.Dictionary<System.Int32, System.Action<UnityEngine.SocialPlatforms.IScore[]>>();
        AGSClient.add_ServiceReadyEvent(value:  new System.Action(object:  this, method:  System.Void GameCircleSocial::OnServiceReady()));
        AGSClient.add_ServiceNotReadyEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void GameCircleSocial::OnServiceNotReady(string error)));
        AGSAchievementsClient.add_UpdateAchievementCompleted(value:  new System.Action<AGSUpdateAchievementResponse>(object:  this, method:  System.Void GameCircleSocial::OnUpdateAchievementCompleted(AGSUpdateAchievementResponse response)));
        AGSAchievementsClient.add_RequestAchievementsCompleted(value:  new System.Action<AGSRequestAchievementsResponse>(object:  this, method:  System.Void GameCircleSocial::OnRequestAchievementsCompleted(AGSRequestAchievementsResponse response)));
        AGSLeaderboardsClient.add_SubmitScoreCompleted(value:  new System.Action<AGSSubmitScoreResponse>(object:  this, method:  System.Void GameCircleSocial::OnSubmitScoreCompleted(AGSSubmitScoreResponse response)));
        AGSLeaderboardsClient.add_RequestScoresCompleted(value:  new System.Action<AGSRequestScoresResponse>(object:  this, method:  System.Void GameCircleSocial::OnRequestScoresCompleted(AGSRequestScoresResponse response)));
        AGSLeaderboardsClient.add_RequestLocalPlayerScoreCompleted(value:  new System.Action<AGSRequestScoreResponse>(object:  this, method:  System.Void GameCircleSocial::OnRequestLocalPlayerScoreCompleted(AGSRequestScoreResponse response)));
        AGSPlayerClient.add_RequestLocalPlayerCompleted(value:  new System.Action<AGSRequestPlayerResponse>(object:  this, method:  System.Void GameCircleSocial::OnRequestPlayerCompleted(AGSRequestPlayerResponse response)));
        AGSPlayerClient.add_RequestFriendIdsCompleted(value:  new System.Action<AGSRequestFriendIdsResponse>(object:  this, method:  System.Void GameCircleSocial::OnRequestFriendIdsCompleted(AGSRequestFriendIdsResponse response)));
        AGSPlayerClient.add_RequestBatchFriendsCompleted(value:  new System.Action<AGSRequestBatchFriendsResponse>(object:  this, method:  System.Void GameCircleSocial::OnRequestBatchFriendsCompleted(AGSRequestBatchFriendsResponse response)));
    }
    public static GameCircleSocial get_Instance()
    {
        null = null;
        return (GameCircleSocial)GameCircleSocial.socialInstance;
    }
    public UnityEngine.SocialPlatforms.ILocalUser get_localUser()
    {
        return (UnityEngine.SocialPlatforms.ILocalUser)this.gameCircleLocalUser;
    }
    public void LoadUsers(string[] userIDs, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
    {
        AGSClient.LogGameCircleError(errorMessage:  "ISocialPlatform.LoadUsers is not available for GameCircle");
    }
    public void ReportProgress(string achievementID, double progress, System.Action<bool> callback)
    {
        this.simpleCallbacks.Add(key:  this.requestID, value:  callback);
        this.requestID = this.requestID + 1;
        AGSAchievementsClient.UpdateAchievementProgress(achievementId:  achievementID, progress:  (float)progress, userData:  this.requestID);
    }
    public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback)
    {
        if(callback != null)
        {
                this.loadAchievementDescriptionsCallbacks.Add(key:  this.requestID, value:  callback);
            this.requestID = this.requestID + 1;
            AGSAchievementsClient.RequestAchievements(userData:  this.requestID);
            return;
        }
        
        AGSClient.LogGameCircleError(errorMessage:  "LoadAchievementDescriptions \"callback\" argument should not be null");
    }
    public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback)
    {
        if(callback != null)
        {
                this.loadAchievementsCallbacks.Add(key:  this.requestID, value:  callback);
            this.requestID = this.requestID + 1;
            AGSAchievementsClient.RequestAchievements(userData:  this.requestID);
            return;
        }
        
        AGSClient.LogGameCircleError(errorMessage:  "LoadAchievements \"callback\" argument should not be null");
    }
    public UnityEngine.SocialPlatforms.IAchievement CreateAchievement()
    {
        return (UnityEngine.SocialPlatforms.IAchievement)new AGSSocialAchievement();
    }
    public void ReportScore(long score, string board, System.Action<bool> callback)
    {
        this.simpleCallbacks.Add(key:  this.requestID, value:  callback);
        this.requestID = this.requestID + 1;
        AGSLeaderboardsClient.SubmitScore(leaderboardId:  board, score:  score, userData:  this.requestID);
    }
    public void LoadScores(string leaderboardID, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback)
    {
        this.loadScoresCallbacks.Add(key:  this.requestID, value:  callback);
        this.requestID = this.requestID + 1;
        AGSLeaderboardsClient.RequestLeaderboards(userData:  this.requestID);
    }
    public UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard()
    {
        return (UnityEngine.SocialPlatforms.ILeaderboard)new AGSSocialLeaderboard();
    }
    public void ShowAchievementsUI()
    {
        AGSAchievementsClient.ShowAchievementsOverlay();
    }
    public void ShowLeaderboardUI()
    {
        AGSLeaderboardsClient.ShowLeaderboardsOverlay();
    }
    public void Authenticate(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback)
    {
        this.authenticationCallback = callback;
        UnityEngine.Debug.Log(message:  "[Rilisoft] GameCircleSocial.Authenticate(user, callback) > AGSClient.Init(true, true, true).");
        AGSClient.Init(supportsLeaderboards:  true, supportsAchievements:  true, supportsWhispersync:  true);
    }
    public void Authenticate(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool, string> callback)
    {
        GameCircleSocial.<>c__DisplayClass25_0 val_1 = new GameCircleSocial.<>c__DisplayClass25_0();
        .callback = callback;
        this.Authenticate(user:  val_1, callback:  new System.Action<System.Boolean>(object:  val_1, method:  System.Void GameCircleSocial.<>c__DisplayClass25_0::<Authenticate>b__0(bool success)));
    }
    public void LoadFriends(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback)
    {
        if(user != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
        }
        else
        {
                AGSClient.LogGameCircleError(errorMessage:  "LoadFriends \"user\" argument should not be null");
            return;
        }
        
        user.LoadFriends(callback:  callback);
    }
    public void LoadScores(UnityEngine.SocialPlatforms.ILeaderboard board, System.Action<bool> callback)
    {
        if(board != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
        }
        else
        {
                AGSClient.LogGameCircleError(errorMessage:  "LoadScores \"board\" argument should not be null");
            return;
        }
        
        board.LoadScores(callback:  callback);
    }
    public bool GetLoading(UnityEngine.SocialPlatforms.ILeaderboard board)
    {
        if(board != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            return board.loading;
        }
        
        AGSClient.LogGameCircleError(errorMessage:  "GetLoading \"board\" argument should not be null");
        return false;
    }
    public void RequestScores(AGSSocialLeaderboard leaderboard, System.Action<bool> callback)
    {
        string val_6;
        this.leaderboardForRequest.Add(key:  this.requestID, value:  leaderboard);
        this.simpleCallbacks.Add(key:  this.requestID, value:  callback);
        if(leaderboard != null)
        {
                val_6 = leaderboard.id;
        }
        else
        {
                val_6 = 0.id;
        }
        
        UnityEngine.SocialPlatforms.TimeScope val_3 = leaderboard.timeScope;
        var val_6 = 2;
        val_6 = val_6 - val_3;
        this.requestID = this.requestID + 1;
        AGSLeaderboardsClient.RequestScores(leaderboardId:  val_6, scope:  (val_3 < 3) ? (val_6) : 0, userData:  this.requestID);
    }
    public void RequestLocalUserScore(AGSSocialLeaderboard leaderboard)
    {
        string val_6;
        this.leaderboardForRequest.Add(key:  this.requestID, value:  leaderboard);
        if(leaderboard != null)
        {
                val_6 = leaderboard.id;
        }
        else
        {
                val_6 = 0.id;
        }
        
        UnityEngine.SocialPlatforms.TimeScope val_3 = leaderboard.timeScope;
        var val_6 = 2;
        val_6 = val_6 - val_3;
        this.requestID = this.requestID + 1;
        AGSLeaderboardsClient.RequestScores(leaderboardId:  val_6, scope:  (val_3 < 3) ? (val_6) : 0, userData:  this.requestID);
    }
    public void RequestLocalPlayer(System.Action<bool> callback)
    {
        this.simpleCallbacks.Add(key:  this.requestID, value:  callback);
        this.requestID = this.requestID + 1;
        AGSPlayerClient.RequestLocalPlayer(userData:  this.requestID);
    }
    public void RequestFriends(System.Action<bool> callback)
    {
        this.simpleCallbacks.Add(key:  this.requestID, value:  callback);
        this.requestID = this.requestID + 1;
        AGSPlayerClient.RequestFriendIds(userData:  this.requestID);
    }
    private void OnServiceReady()
    {
        if(this.authenticationCallback == null)
        {
                return;
        }
        
        this.authenticationCallback.Invoke(obj:  true);
    }
    private void OnServiceNotReady(string error)
    {
        if(this.authenticationCallback == null)
        {
                return;
        }
        
        this.authenticationCallback.Invoke(obj:  false);
    }
    private void OnUpdateAchievementCompleted(AGSUpdateAchievementResponse response)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Action<System.Boolean>> val_6 = this.simpleCallbacks;
        if((val_6.ContainsKey(key:  W22)) != false)
        {
                val_6 = this.simpleCallbacks.Item[W22];
            if(val_6 != null)
        {
                val_6.Invoke(obj:  (~response.IsError()) & 1);
        }
        
        }
        
        bool val_5 = this.simpleCallbacks.Remove(key:  response);
    }
    private void OnRequestAchievementsCompleted(AGSRequestAchievementsResponse response)
    {
        var val_18;
        var val_19;
        var val_20;
        System.Collections.Generic.Dictionary<System.Int32, System.Action<UnityEngine.SocialPlatforms.IAchievement[]>> val_21;
        var val_22;
        if(((this.loadAchievementDescriptionsCallbacks.ContainsKey(key:  W22)) == false) || ((this.loadAchievementDescriptionsCallbacks.ContainsKey(key:  W22)) == false))
        {
            goto label_7;
        }
        
        System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> val_3 = this.loadAchievementDescriptionsCallbacks.Item[W22];
        if(val_3 == null)
        {
            goto label_7;
        }
        
        int val_4 = response.achievements.Count;
        AGSSocialAchievement[] val_5 = new AGSSocialAchievement[0];
        val_18 = 1152921524069497664;
        val_19 = 0;
        goto label_9;
        label_18:
        AGSSocialAchievement val_7 = new AGSSocialAchievement(achievement:  response.achievements.Item[0]);
        if(val_5 == null)
        {
            goto label_11;
        }
        
        if(val_7 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_7 == null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        val_20 = 0;
        val_19 = 1;
        val_5[val_20] = val_7;
        label_9:
        if(val_19 < response.achievements.Count)
        {
            goto label_18;
        }
        
        val_3.Invoke(obj:  val_5);
        label_7:
        val_21 = this.loadAchievementsCallbacks;
        val_22 = 1152921524069520192;
        if((val_21.ContainsKey(key:  -2012037632)) == false)
        {
            goto label_24;
        }
        
        val_21 = this.loadAchievementsCallbacks;
        if((val_21.ContainsKey(key:  -2012037632)) == false)
        {
            goto label_24;
        }
        
        val_21 = this.loadAchievementsCallbacks.Item[-2012037632];
        if(val_21 == null)
        {
            goto label_24;
        }
        
        int val_12 = response.achievements.Count;
        AGSSocialAchievement[] val_13 = new AGSSocialAchievement[0];
        val_18 = 1152921524069497664;
        val_22 = 0;
        goto label_26;
        label_35:
        AGSSocialAchievement val_15 = new AGSSocialAchievement(achievement:  response.achievements.Item[0]);
        if(val_13 == null)
        {
            goto label_28;
        }
        
        if(val_15 != null)
        {
            goto label_29;
        }
        
        goto label_32;
        label_28:
        if(val_15 == null)
        {
            goto label_32;
        }
        
        label_29:
        label_32:
        val_20 = 0;
        val_22 = 1;
        val_13[val_20] = val_15;
        label_26:
        if(val_22 < response.achievements.Count)
        {
            goto label_35;
        }
        
        val_21.Invoke(obj:  val_13);
        label_24:
        bool val_17 = this.loadAchievementDescriptionsCallbacks.Remove(key:  response);
    }
    private void OnSubmitScoreCompleted(AGSSubmitScoreResponse response)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Action<System.Boolean>> val_6 = this.simpleCallbacks;
        if((val_6.ContainsKey(key:  W22)) != false)
        {
                val_6 = this.simpleCallbacks.Item[W22];
            if(val_6 != null)
        {
                val_6.Invoke(obj:  (~response.IsError()) & 1);
        }
        
        }
        
        bool val_5 = this.simpleCallbacks.Remove(key:  response);
    }
    private void OnRequestScoresCompleted(AGSRequestScoresResponse response)
    {
        var val_23;
        var val_24;
        var val_25;
        System.Collections.Generic.List<AGSScore> val_26;
        GameCircleSocial val_27;
        if((this.leaderboardForRequest.ContainsKey(key:  -2011616256)) == false)
        {
            goto label_6;
        }
        
        AGSSocialLeaderboard val_2 = this.leaderboardForRequest.Item[-2011616256];
        if((val_2 == null) || (response.IsError() == true))
        {
            goto label_6;
        }
        
        val_23 = 1152921524069938752;
        int val_4 = response.scores.Count;
        val_2.scores = new UnityEngine.SocialPlatforms.IScore[0];
        val_24 = 0;
        goto label_8;
        label_17:
        UnityEngine.SocialPlatforms.IScore[] val_6 = val_2.scores;
        AGSSocialLeaderboardScore val_8 = new AGSSocialLeaderboardScore(score:  response.scores.Item[0], leaderboard:  response.leaderboard);
        if(val_6 == null)
        {
            goto label_10;
        }
        
        if(val_8 != null)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(val_8 == null)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        val_25 = 0;
        val_24 = 1;
        val_6[val_25] = val_8;
        label_8:
        val_26 = response.scores;
        if(val_24 < val_26.Count)
        {
            goto label_17;
        }
        
        label_6:
        val_27 = this;
        if((mem[1152921524070067240].ContainsKey(key:  1)) != false)
        {
                System.Action<System.Boolean> val_11 = mem[1152921524070067240].Item[1];
            if(val_11 != null)
        {
                val_11.Invoke(obj:  (~response.IsError()) & 1);
        }
        
        }
        
        if((mem[1152921524070067272].ContainsKey(key:  1)) == false)
        {
            goto label_25;
        }
        
        System.Action<UnityEngine.SocialPlatforms.IScore[]> val_15 = mem[1152921524070067272].Item[1];
        if(val_15 == null)
        {
            goto label_25;
        }
        
        val_23 = 1152921524069938752;
        int val_16 = response.scores.Count;
        UnityEngine.SocialPlatforms.IScore[] val_17 = new UnityEngine.SocialPlatforms.IScore[0];
        val_26 = 0;
        goto label_27;
        label_36:
        AGSSocialLeaderboardScore val_19 = new AGSSocialLeaderboardScore(score:  response.scores.Item[0], leaderboard:  response.leaderboard);
        if(val_17 == null)
        {
            goto label_29;
        }
        
        if(val_19 != null)
        {
            goto label_30;
        }
        
        goto label_33;
        label_29:
        if(val_19 == null)
        {
            goto label_33;
        }
        
        label_30:
        label_33:
        val_25 = 0;
        val_26 = 1;
        val_17[val_25] = val_19;
        label_27:
        if(val_26 < response.scores.Count)
        {
            goto label_36;
        }
        
        val_15.Invoke(obj:  val_17);
        val_27 = this;
        label_25:
        bool val_21 = this.leaderboardForRequest.Remove(key:  -2011494144);
        bool val_22 = mem[1152921524070067240].Remove(key:  response);
    }
    private void OnRequestLocalPlayerScoreCompleted(AGSRequestScoreResponse response)
    {
        System.Collections.Generic.Dictionary<System.Int32, AGSSocialLeaderboard> val_4 = this.leaderboardForRequest;
        if((val_4.ContainsKey(key:  W22)) != false)
        {
                val_4 = this.leaderboardForRequest;
            if(val_4.Item[W22] != null)
        {
                val_2.localPlayerScore = response.score;
            val_2.localPlayerRank = response.rank;
        }
        
        }
        
        bool val_3 = this.leaderboardForRequest.Remove(key:  response);
    }
    private void OnRequestPlayerCompleted(AGSRequestPlayerResponse response)
    {
        var val_6;
        System.Collections.Generic.Dictionary<System.Int32, System.Action<System.Boolean>> val_7;
        val_6 = null;
        val_6 = null;
        AGSSocialLocalUser.player = response.player;
        val_7 = this.simpleCallbacks;
        if((val_7.ContainsKey(key:  1152921505016111104)) != false)
        {
                val_7 = this.simpleCallbacks.Item[1152921505016111104];
            if(val_7 != null)
        {
                val_7.Invoke(obj:  (~response.IsError()) & 1);
        }
        
        }
        
        bool val_5 = this.simpleCallbacks.Remove(key:  response);
    }
    private void OnRequestFriendIdsCompleted(AGSRequestFriendIdsResponse response)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Action<System.Boolean>> val_5;
        System.Collections.Generic.List<System.String> val_6;
        if(response.IsError() != false)
        {
                val_5 = this.simpleCallbacks;
            if((val_5.ContainsKey(key:  W22)) != false)
        {
                val_5 = this.simpleCallbacks;
            System.Action<System.Boolean> val_3 = val_5.Item[W22];
            if(val_3 != null)
        {
                val_3.Invoke(obj:  false);
        }
        
        }
        
            bool val_4 = this.simpleCallbacks.Remove(key:  response);
            return;
        }
        
        if(response != null)
        {
                val_6 = response.friendIds;
        }
        else
        {
                val_6 = 64;
        }
        
        AGSPlayerClient.RequestBatchFriends(friendIds:  val_6, userData:  response);
    }
    private void OnRequestBatchFriendsCompleted(AGSRequestBatchFriendsResponse response)
    {
        var val_5;
        var val_14;
        var val_15;
        System.Collections.Generic.Dictionary<System.Int32, System.Action<System.Boolean>> val_16;
        if(response.IsError() == true)
        {
            goto label_17;
        }
        
        System.Collections.Generic.List<AGSSocialUser> val_2 = new System.Collections.Generic.List<AGSSocialUser>();
        val_14 = null;
        val_14 = null;
        AGSSocialLocalUser.friendList = val_2;
        List.Enumerator<T> val_3 = response.friends.GetEnumerator();
        label_11:
        if(((-2010884448) & 1) == 0)
        {
            goto label_7;
        }
        
        val_15 = null;
        val_15 = null;
        new AGSSocialUser() = new AGSSocialUser(player:  val_5.丐丏七丌丕丗业且上());
        val_2.Add(item:  new AGSSocialUser());
        goto label_11;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_17:
        val_16 = this.simpleCallbacks;
        if((val_16.ContainsKey(key:  W22)) != false)
        {
                val_16 = this.simpleCallbacks.Item[W22];
            if(val_16 != null)
        {
                val_16.Invoke(obj:  (~response.IsError()) & 1);
        }
        
        }
        
        bool val_12 = this.simpleCallbacks.Remove(key:  response);
    }
    private LeaderboardScope fromTimeScope(UnityEngine.SocialPlatforms.TimeScope scope)
    {
        if(scope > 2)
        {
                return 0;
        }
        
        return (LeaderboardScope)2 - scope;
    }
    private static GameCircleSocial()
    {
        GameCircleSocial.socialInstance = new GameCircleSocial();
    }

}
