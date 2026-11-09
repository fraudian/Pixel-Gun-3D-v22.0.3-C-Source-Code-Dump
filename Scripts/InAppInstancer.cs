using UnityEngine;
internal sealed class InAppInstancer : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject inAppGameObjectPrefab;
    private bool _amazonGamecircleManagerInitialized;
    private bool _amazonIapManagerInitialized;
    private string _leaderboardId;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InAppInstancer.<Start>d__1();
    }
    private System.Collections.IEnumerator InitializeAmazonGamecircleManager()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new InAppInstancer.<InitializeAmazonGamecircleManager>d__2();
    }
    private void HandleAmazonGamecircleServiceReady()
    {
        AGSClient.remove_ServiceReadyEvent(value:  new System.Action(object:  this, method:  System.Void InAppInstancer::HandleAmazonGamecircleServiceReady()));
        AGSClient.remove_ServiceNotReadyEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void InAppInstancer::HandleAmazonGamecircleServiceNotReady(string message)));
        UnityEngine.Debug.Log(message:  "Amazon GameCircle service is initialized.");
        AGSAchievementsClient.add_UpdateAchievementCompleted(value:  new System.Action<AGSUpdateAchievementResponse>(object:  this, method:  System.Void InAppInstancer::HandleUpdateAchievementCompleted(AGSUpdateAchievementResponse response)));
        AGSLeaderboardsClient.add_SubmitScoreSucceededEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void InAppInstancer::HandleSubmitScoreSucceeded(string leaderbordId)));
        AGSLeaderboardsClient.add_SubmitScoreFailedEvent(value:  new System.Action<System.String, System.String>(object:  this, method:  System.Void InAppInstancer::HandleSubmitScoreFailed(string leaderbordId, string error)));
        AGSLeaderboardsClient.SubmitScore(leaderboardId:  this._leaderboardId, score:  (long)UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.七丘丗万丞与丄丒丏(), defaultValue:  0), userData:  0);
    }
    private void HandleAmazonPotentialProgressConflicts()
    {
        UnityEngine.Debug.Log(message:  "HandleAmazonPotentialProgressConflicts()");
    }
    private void HandleAmazonSyncFailed()
    {
        null = null;
        UnityEngine.Debug.LogWarning(message:  "HandleAmazonSyncFailed(): "("HandleAmazonSyncFailed(): ") + AGSWhispersyncClient.failReason);
    }
    private void HandleAmazonThrottled()
    {
        UnityEngine.Debug.LogWarning(message:  "HandleAmazonThrottled().");
    }
    private void HandleAmazonGamecircleServiceNotReady(string message)
    {
        UnityEngine.Debug.LogError(message:  "Amazon GameCircle service is not ready:\n"("Amazon GameCircle service is not ready:\n") + message);
    }
    private void HandleUpdateAchievementCompleted(AGSUpdateAchievementResponse response)
    {
        object val_5;
        object val_6;
        val_5 = response;
        if(val_5 == null)
        {
            goto label_1;
        }
        
        val_6 = mem[response + 16 + 16];
        val_6 = response + 16 + 16;
        if((System.String.IsNullOrEmpty(value:  43814)) == true)
        {
            goto label_2;
        }
        
        goto label_3;
        label_1:
        val_6 = 64;
        if((System.String.IsNullOrEmpty(value:  11993091)) == false)
        {
            goto label_4;
        }
        
        label_2:
        string val_3 = System.String.Format(format:  "Achievement {0} succeeded.", arg0:  val_6);
        goto label_5;
        label_4:
        val_5 = 16;
        label_3:
        label_5:
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Achievement {0} failed. {1}", arg0:  val_6, arg1:  val_5));
    }
    private void HandleSubmitScoreSucceeded(string leaderbordId)
    {
        AGSLeaderboardsClient.remove_SubmitScoreSucceededEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void InAppInstancer::HandleSubmitScoreSucceeded(string leaderbordId)));
        AGSLeaderboardsClient.remove_SubmitScoreFailedEvent(value:  new System.Action<System.String, System.String>(object:  this, method:  System.Void InAppInstancer::HandleSubmitScoreFailed(string leaderbordId, string error)));
        if(UnityEngine.Debug.isDebugBuild == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Submit score succeeded for leaderboard " + leaderbordId);
    }
    private void HandleSubmitScoreFailed(string leaderbordId, string error)
    {
        AGSLeaderboardsClient.remove_SubmitScoreSucceededEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void InAppInstancer::HandleSubmitScoreSucceeded(string leaderbordId)));
        AGSLeaderboardsClient.remove_SubmitScoreFailedEvent(value:  new System.Action<System.String, System.String>(object:  this, method:  System.Void InAppInstancer::HandleSubmitScoreFailed(string leaderbordId, string error)));
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Submit score failed for leaderboard {0}:\n{1}", arg0:  leaderbordId, arg1:  error));
    }
    public InAppInstancer()
    {
        this._leaderboardId = System.String.alignConst;
    }

}
