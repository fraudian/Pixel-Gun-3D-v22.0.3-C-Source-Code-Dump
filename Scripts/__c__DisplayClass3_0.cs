using UnityEngine;
private sealed class AndroidSavedGameClient.<>c__DisplayClass3_0
{
    // Fields
    public GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy;
    public System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback;
    
    // Methods
    public AndroidSavedGameClient.<>c__DisplayClass3_0()
    {
    
    }
    internal void <OpenWithAutomaticConflictResolution>b__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData)
    {
        var val_8;
        var val_9;
        var val_12;
        var val_13;
        var val_15;
        var val_17;
        var val_18;
        var val_20;
        var val_22;
        if(this.resolutionStrategy == 0)
        {
            goto label_1;
        }
        
        if(this.resolutionStrategy == 2)
        {
            goto label_2;
        }
        
        if(this.resolutionStrategy != 1)
        {
            goto label_3;
        }
        
        val_8 = null;
        var val_9 = 0;
        val_9 = 1152921505393995784;
        val_9 = val_9 + 1;
        goto label_31;
        label_1:
        var val_10 = 0;
        val_10 = val_10 + 1;
        goto label_13;
        label_2:
        val_12 = null;
        var val_11 = 0;
        val_13 = 1152921505393995784;
        val_11 = val_11 + 1;
        goto label_35;
        label_3:
        GooglePlayGames.OurUtils.Logger.e(msg:  "Unhandled strategy " + this.resolutionStrategy);
        this.completedCallback.Invoke(arg1:  -2, arg2:  0);
        return;
        label_13:
        System.TimeSpan val_3 = original.TotalTimePlayed;
        var val_12 = 0;
        val_12 = val_12 + 1;
        System.TimeSpan val_5 = unmerged.TotalTimePlayed;
        val_15 = 0;
        val_17 = null;
        if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_3._ticks}, t2:  new System.TimeSpan() {_ticks = val_5._ticks})) == false)
        {
            goto label_30;
        }
        
        var val_13 = 0;
        val_9 = 1152921505393995784;
        val_13 = val_13 + 1;
        label_31:
        val_18 = 0;
        goto label_34;
        label_30:
        var val_14 = 0;
        val_13 = 1152921505393995784;
        val_14 = val_14 + 1;
        label_35:
        val_20 = 0;
        goto label_38;
        label_34:
        val_22 = public System.Void GooglePlayGames.BasicApi.SavedGame.IConflictResolver::ChooseMetadata(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata);
        goto label_39;
        label_38:
        val_22 = public System.Void GooglePlayGames.BasicApi.SavedGame.IConflictResolver::ChooseMetadata(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata);
        label_39:
        resolver.ChooseMetadata(chosenMetadata:  unmerged);
    }

}
