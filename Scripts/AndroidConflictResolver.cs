using UnityEngine;
private class AndroidSavedGameClient.AndroidConflictResolver : IConflictResolver
{
    // Fields
    private readonly UnityEngine.AndroidJavaObject mSnapshotsClient;
    private readonly UnityEngine.AndroidJavaObject mConflict;
    private readonly GooglePlayGames.Android.AndroidSnapshotMetadata mOriginal;
    private readonly GooglePlayGames.Android.AndroidSnapshotMetadata mUnmerged;
    private readonly System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> mCompleteCallback;
    private readonly System.Action mRetryFileOpen;
    
    // Methods
    internal AndroidSavedGameClient.AndroidConflictResolver(UnityEngine.AndroidJavaObject snapshotClient, UnityEngine.AndroidJavaObject conflict, GooglePlayGames.Android.AndroidSnapshotMetadata original, GooglePlayGames.Android.AndroidSnapshotMetadata unmerged, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completeCallback, System.Action retryOpen)
    {
        val_1 = new System.Object();
        this.mSnapshotsClient = GooglePlayGames.OurUtils.Misc.CheckNotNull<UnityEngine.AndroidJavaObject>(value:  snapshotClient);
        this.mConflict = GooglePlayGames.OurUtils.Misc.CheckNotNull<UnityEngine.AndroidJavaObject>(value:  UnityEngine.AndroidJavaObject val_1 = conflict);
        this.mOriginal = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.Android.AndroidSnapshotMetadata>(value:  original);
        this.mUnmerged = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.Android.AndroidSnapshotMetadata>(value:  unmerged);
        this.mCompleteCallback = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(value:  completeCallback);
        this.mRetryFileOpen = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action>(value:  retryOpen);
    }
    public void ResolveConflict(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate metadataUpdate, byte[] updatedData)
    {
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_18 = 0;
        if(( != this.mOriginal) && ( != this.mUnmerged))
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  "Caller attempted to choose a version of the metadata that was not part of the conflict");
            this.mCompleteCallback.Invoke(arg1:  -4, arg2:  0);
            return;
        }
        
        UnityEngine.AndroidJavaObject val_3 = this.mConflict.Call<UnityEngine.AndroidJavaObject>(methodName:  "getResolutionSnapshotContents", args:  System.Array.Empty<System.Object>());
        object[] val_4 = new object[1];
        val_4[0] = updatedData;
        if((val_3.Call<System.Boolean>(methodName:  "writeBytes", args:  val_4)) != true)
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  "Can\'t update snapshot contents during conflict resolution.");
            this.mCompleteCallback.Invoke(arg1:  -4, arg2:  0);
        }
        
        UnityEngine.AndroidJavaObject val_6 = GooglePlayGames.Android.AndroidSavedGameClient.AsMetadataChange(update:  new GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate() {mDescriptionUpdated = metadataUpdate.mDescriptionUpdated, mCoverImageUpdated = metadataUpdate.mCoverImageUpdated, mNewPlayedTime = new System.Nullable<System.TimeSpan>() {HasValue = metadataUpdate.mNewPlayedTime.HasValue}});
        object[] val_7 = new object[4];
        val_7[0] = this.mConflict.Call<System.String>(methodName:  "getConflictId", args:  System.Array.Empty<System.Object>());
        val_7[1] = (GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata.__il2cppRuntimeField_typeHierarchy + (GooglePlayGames.Android.AndroidSnapshotMetadata.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? chosenMetadata : 0 + 24.Call<System.String>(methodName:  "getSnapshotId", args:  System.Array.Empty<System.Object>());
        val_7[2] = val_6;
        val_7[3] = val_3;
        UnityEngine.AndroidJavaObject val_12 = this.mSnapshotsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "resolveConflict", args:  val_7);
        System.Action<UnityEngine.AndroidJavaObject> val_13 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidSavedGameClient.AndroidConflictResolver::<ResolveConflict>b__7_0(UnityEngine.AndroidJavaObject dataOrConflict));
        GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_12, callback:  null);
        System.Action<UnityEngine.AndroidJavaObject> val_14 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidSavedGameClient.AndroidConflictResolver::<ResolveConflict>b__7_1(UnityEngine.AndroidJavaObject exception));
        GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_12, callback:  null);
        val_19 = 0;
        val_20 = 0;
        if(val_12 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_12.Dispose();
        }
        
        if(val_19 == 1)
        {
            goto label_43;
        }
        
        val_22 = val_20;
        if(val_6 != null)
        {
            goto label_44;
        }
        
        goto label_47;
        label_43:
        if(val_20 != 0)
        {
                val_20 = 0;
        }
        
        val_22 = 0;
        val_19 = 0;
        if(val_6 == null)
        {
            goto label_47;
        }
        
        label_44:
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_6.Dispose();
        label_47:
        if(val_19 == 1)
        {
            goto label_52;
        }
        
        if(val_3 == null)
        {
            goto label_93;
        }
        
        label_92:
        var val_20 = 0;
        val_20 = val_20 + 1;
        goto label_57;
        label_52:
        if(val_22 == 0)
        {
            goto label_58;
        }
        
        val_20 = 0;
        val_22 = 0;
        val_19 = 0;
        if(val_3 != null)
        {
            goto label_92;
        }
        
        goto label_93;
        label_57:
        val_3.Dispose();
        label_93:
        if(val_19 != 1)
        {
                return;
        }
        
        if(val_22 == 0)
        {
                return;
        }
        
        return;
        label_58:
        if(val_3 != null)
        {
            goto label_92;
        }
        
        goto label_93;
    }
    public void ChooseMetadata(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata)
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_17 = 0;
        if(( != this.mOriginal) && ( != this.mUnmerged))
        {
                GooglePlayGames.OurUtils.Logger.e(msg:  "Caller attempted to choose a version of the metadata that was not part of the conflict");
            this.mCompleteCallback.Invoke(arg1:  -4, arg2:  0);
            return;
        }
        
        object[] val_2 = new object[2];
        val_2[0] = this.mConflict.Call<System.String>(methodName:  "getConflictId", args:  System.Array.Empty<System.Object>());
        val_2[1] = (GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata.__il2cppRuntimeField_typeHierarchy + (GooglePlayGames.Android.AndroidSnapshotMetadata.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? chosenMetadata : 0 + 16;
        UnityEngine.AndroidJavaObject val_5 = this.mSnapshotsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "resolveConflict", args:  val_2);
        val_18 = 1152921516947610496;
        System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidSavedGameClient.AndroidConflictResolver::<ChooseMetadata>b__8_0(UnityEngine.AndroidJavaObject dataOrConflict));
        GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_5, callback:  null);
        System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidSavedGameClient.AndroidConflictResolver::<ChooseMetadata>b__8_1(UnityEngine.AndroidJavaObject exception));
        GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_5, callback:  null);
        val_19 = 0;
        val_20 = 0;
        if(val_5 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_5.Dispose();
        }
        
        if(val_19 != 1)
        {
                return;
        }
        
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = ???;
        val_19 = ???;
        val_18 = ???;
    }
    private void <ResolveConflict>b__7_0(UnityEngine.AndroidJavaObject dataOrConflict)
    {
        this.mRetryFileOpen.Invoke();
    }
    private void <ResolveConflict>b__7_1(UnityEngine.AndroidJavaObject exception)
    {
        this.mCompleteCallback.Invoke(arg1:  -2, arg2:  0);
    }
    private void <ChooseMetadata>b__8_0(UnityEngine.AndroidJavaObject dataOrConflict)
    {
        this.mRetryFileOpen.Invoke();
    }
    private void <ChooseMetadata>b__8_1(UnityEngine.AndroidJavaObject exception)
    {
        this.mCompleteCallback.Invoke(arg1:  -2, arg2:  0);
    }

}
