using UnityEngine;
public class GameCircleManager : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        this.gameObject.name = this.GetType();
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    public void serviceReady(string empty)
    {
        AGSClient.Log(message:  "GameCircleManager - serviceReady");
        AGSClient.ServiceReady(empty:  empty);
    }
    public void serviceNotReady(string param)
    {
        AGSClient.Log(message:  "GameCircleManager - serviceNotReady");
        AGSClient.ServiceNotReady(param:  param);
    }
    public void playerReceived(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - playerReceived");
        AGSPlayerClient.PlayerReceived(json:  json);
    }
    public void playerFailed(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - playerFailed");
        AGSPlayerClient.PlayerFailed(json:  json);
    }
    public void localPlayerFriendRequestComplete(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - localPlayerFriendRequestComplete");
        AGSPlayerClient.LocalPlayerFriendsComplete(json:  json);
    }
    public void batchFriendsRequestComplete(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - batchFriendsRequestComplete");
        AGSPlayerClient.BatchFriendsRequestComplete(json:  json);
    }
    public void onSignedInStateChange(string isSignedIn)
    {
        AGSClient.Log(message:  "GameCircleManager - onSignedInStateChange");
        AGSPlayerClient.OnSignedInStateChanged(isSignedIn:  System.Boolean.Parse(value:  isSignedIn));
    }
    public void submitScoreFailed(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - submitScoreFailed");
        AGSLeaderboardsClient.SubmitScoreFailed(json:  json);
    }
    public void submitScoreSucceeded(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - submitScoreSucceeded");
        AGSLeaderboardsClient.SubmitScoreSucceeded(json:  json);
    }
    public void requestLeaderboardsFailed(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestLeaderboardsFailed");
        AGSLeaderboardsClient.RequestLeaderboardsFailed(json:  json);
    }
    public void requestLeaderboardsSucceeded(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestLeaderboardsSucceeded");
        AGSLeaderboardsClient.RequestLeaderboardsSucceeded(json:  json);
    }
    public void requestLocalPlayerScoreFailed(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestLocalPlayerScoreFailed");
        AGSLeaderboardsClient.RequestLocalPlayerScoreFailed(json:  json);
    }
    public void requestLocalPlayerScoreSucceeded(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestLocalPlayerScoreSucceeded");
        AGSLeaderboardsClient.RequestLocalPlayerScoreSucceeded(json:  json);
    }
    public void requestPlayerScoreCompleted(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestPlayerScoreCompleted");
        AGSLeaderboardsClient.RequestScoreForPlayerComplete(json:  json);
    }
    public void requestScoresSucceeded(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestScoresSucceeded:");
        AGSLeaderboardsClient.RequestScoresSucceeded(json:  json);
    }
    public void requestScoresFailed(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestScoresFailed");
        AGSLeaderboardsClient.RequestScoresFailed(json:  json);
    }
    public void requestPercentileRanksSucceeded(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestPercentileRanksSucceeded");
        AGSLeaderboardsClient.RequestPercentileRanksSucceeded(json:  json);
    }
    public void requestPercentileRanksFailed(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestPercentileRanksFailed");
        AGSLeaderboardsClient.RequestPercentileRanksFailed(json:  json);
    }
    public void requestPercentileRanksForPlayerSucceeded(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestPercentileRanksForPlayerSucceeded");
        AGSLeaderboardsClient.RequestPercentileRanksForPlayerComplete(json:  json);
    }
    public void updateAchievementSucceeded(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - updateAchievementSucceeded");
        AGSAchievementsClient.UpdateAchievementSucceeded(json:  json);
    }
    public void updateAchievementFailed(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - updateAchievementsFailed");
        AGSAchievementsClient.UpdateAchievementFailed(json:  json);
    }
    public void requestAchievementsSucceeded(string json)
    {
        AGSClient.Log(message:  "GameCircleManager - requestAchievementsSucceeded");
        AGSAchievementsClient.RequestAchievementsSucceeded(json:  json);
    }
    public void requestAchievementsFailed(string json)
    {
        AGSClient.Log(message:  "GameCircleManager -  requestAchievementsFailed");
        AGSAchievementsClient.RequestAchievementsFailed(json:  json);
    }
    public void requestAchievementsForPlayerCompleted(string json)
    {
        AGSClient.Log(message:  "GameCircleManager -  requestAchievementsForPlayerCompleted");
        AGSAchievementsClient.RequestAchievementsForPlayerComplete(json:  json);
    }
    public void onNewCloudData(string empty)
    {
        AGSWhispersyncClient.OnNewCloudData();
    }
    public void onDataUploadedToCloud(string empty)
    {
        AGSWhispersyncClient.OnDataUploadedToCloud();
    }
    public void onThrottled(string empty)
    {
        AGSWhispersyncClient.OnThrottled();
    }
    public void onDiskWriteComplete(string empty)
    {
        AGSWhispersyncClient.OnDiskWriteComplete();
    }
    public void onFirstSynchronize(string empty)
    {
        AGSWhispersyncClient.OnFirstSynchronize();
    }
    public void onAlreadySynchronized(string empty)
    {
        AGSWhispersyncClient.OnAlreadySynchronized();
    }
    public void onSyncFailed(string failReason)
    {
        AGSWhispersyncClient.OnSyncFailed(failReason:  failReason);
    }
    public void OnApplicationFocus(bool focusStatus)
    {
        null = null;
        if(AGSClient.ReinitializeOnFocus == false)
        {
                return;
        }
        
        if(focusStatus != false)
        {
                AGSClient.Init();
            return;
        }
        
        AGSClient.release();
    }
    public void OnAppplicationQuit()
    {
        AGSClient.Log(message:  "GameCircleManager - OnApplicationQuit");
        AGSClient.Shutdown();
    }
    public GameCircleManager()
    {
    
    }

}
