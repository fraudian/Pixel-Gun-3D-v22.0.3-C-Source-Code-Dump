using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidSavedGameClient : ISavedGameClient
    {
        // Fields
        private static readonly System.Text.RegularExpressions.Regex ValidFilenameRegex;
        private UnityEngine.AndroidJavaObject mSnapshotsClient;
        
        // Methods
        public AndroidSavedGameClient(UnityEngine.AndroidJavaObject account)
        {
            var val_13;
            var val_14;
            UnityEngine.AndroidJavaClass val_1 = null;
            val_13 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.games.Games");
            object[] val_2 = new object[2];
            val_2[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_2[1] = account;
            val_14 = 0;
            this.mSnapshotsClient = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getSnapshotsClient", args:  val_2);
            if(val_13 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
            
            val_13 = ???;
            val_14 = ???;
        }
        public void OpenWithAutomaticConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
            GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy val_10;
            AndroidSavedGameClient.<>c__DisplayClass3_0 val_1 = new AndroidSavedGameClient.<>c__DisplayClass3_0();
            if(val_1 != null)
            {
                    val_10 = val_1;
                .resolutionStrategy = resolutionStrategy;
            }
            else
            {
                    val_10 = 16;
                mem[16] = resolutionStrategy;
            }
            
            .completedCallback = completedCallback;
            string val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.String>(value:  filename);
            if(val_1 != null)
            {
                    System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(value:  (AndroidSavedGameClient.<>c__DisplayClass3_0)[1152921541810683728].completedCallback);
            }
            else
            {
                    System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(value:  (AndroidSavedGameClient.<>c__DisplayClass3_0)[1152921541810683728].completedCallback);
            }
            
            .completedCallback = GooglePlayGames.Android.AndroidSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(toConvert:  (AndroidSavedGameClient.<>c__DisplayClass3_0)[1152921541810683728].completedCallback);
            GooglePlayGames.BasicApi.SavedGame.ConflictCallback val_6 = new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(object:  val_1, method:  System.Void AndroidSavedGameClient.<>c__DisplayClass3_0::<OpenWithAutomaticConflictResolution>b__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData));
            if((GooglePlayGames.Android.AndroidSavedGameClient.IsValidFilename(filename:  filename)) != false)
            {
                    this.InternalOpen(filename:  filename, source:  source, resolutionStrategy:  val_10, prefetchDataOnConflict:  false, conflictCallback:  val_6.ToOnGameThread(conflictCallback:  val_6), completedCallback:  (AndroidSavedGameClient.<>c__DisplayClass3_0)[1152921541810683728].completedCallback);
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  "Received invalid filename: "("Received invalid filename: ") + filename);
            (AndroidSavedGameClient.<>c__DisplayClass3_0)[1152921541810683728].completedCallback.Invoke(arg1:  -4, arg2:  0);
        }
        public void OpenWithManualConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
            string val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.String>(value:  filename);
            GooglePlayGames.BasicApi.SavedGame.ConflictCallback val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.SavedGame.ConflictCallback>(value:  conflictCallback);
            System.Action<T1, T2> val_5 = GooglePlayGames.Android.AndroidSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(toConvert:  completedCallback);
            if((GooglePlayGames.Android.AndroidSavedGameClient.IsValidFilename(filename:  filename)) != false)
            {
                    this.InternalOpen(filename:  filename, source:  source, resolutionStrategy:  3, prefetchDataOnConflict:  prefetchDataOnConflict, conflictCallback:  GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(value:  completedCallback).ToOnGameThread(conflictCallback:  conflictCallback), completedCallback:  val_5);
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  "Received invalid filename: "("Received invalid filename: ") + filename);
            val_5.Invoke(arg1:  -4, arg2:  0);
        }
        private void InternalOpen(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
            GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy val_9;
            object val_10;
            object val_11;
            val_9 = resolutionStrategy;
            AndroidSavedGameClient.<>c__DisplayClass5_0 val_1 = new AndroidSavedGameClient.<>c__DisplayClass5_0();
            if(val_1 != null)
            {
                    val_10 = val_1;
                .filename = filename;
                mem[1152921541811124880] = this;
                mem[1152921541811124888] = completedCallback;
                mem[1152921541811124904] = source;
                mem[1152921541811124908] = val_9;
                mem[1152921541811124912] = prefetchDataOnConflict;
                mem[1152921541811124920] = conflictCallback;
            }
            else
            {
                    mem[16] = this;
                mem[24] = completedCallback;
                val_10 = 32;
                mem[32] = filename;
                mem[40] = source;
                .resolutionStrategy = val_9;
                mem[48] = prefetchDataOnConflict;
                mem[56] = conflictCallback;
                val_9 = (AndroidSavedGameClient.<>c__DisplayClass5_0)[1152921541811124864].resolutionStrategy;
            }
            
            if(val_9 <= 4)
            {
                    val_11 = mem[106049200 + ((AndroidSavedGameClient.<>c__DisplayClass5_0)[1152921541811124864].resolutionStrategy) << 2];
                val_11 = 106049200 + ((AndroidSavedGameClient.<>c__DisplayClass5_0)[1152921541811124864].resolutionStrategy) << 2;
            }
            else
            {
                    val_11 = 3;
            }
            
            object[] val_4 = new object[3];
            val_4[0] = val_10;
            val_4[1] = true;
            val_4[2] = val_11;
            UnityEngine.AndroidJavaObject val_5 = this.mSnapshotsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "open", args:  val_4);
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidSavedGameClient.<>c__DisplayClass5_0::<InternalOpen>b__0(UnityEngine.AndroidJavaObject dataOrConflict));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_5, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidSavedGameClient.<>c__DisplayClass5_0::<InternalOpen>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_5, callback:  null);
            if(val_5 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_5.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void ReadBinaryData(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, byte[]> completedCallback)
        {
            GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(value:  metadata);
            System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Byte[]> val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Byte[]>>(value:  completedCallback);
            GooglePlayGames.OurUtils.Logger.e(msg:  "Encountered metadata that was not generated by this ISavedGameClient");
            GooglePlayGames.Android.AndroidSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Byte[]>(toConvert:  completedCallback).Invoke(arg1:  -4, arg2:  0);
        }
        public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            string val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.String>(value:  uiTitle);
            System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(value:  callback);
            System.Action<T1, T2> val_3 = GooglePlayGames.Android.AndroidSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(toConvert:  callback);
            if(maxDisplayedSavedGames != 0)
            {
                    GooglePlayGames.Android.AndroidHelperFragment.ShowSelectSnapshotUI(showCreateSaveUI:  showCreateSaveUI, showDeleteSaveUI:  showDeleteSaveUI, maxDisplayedSavedGames:  maxDisplayedSavedGames, uiTitle:  uiTitle, cb:  val_3);
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  "maxDisplayedSavedGames must be greater than 0");
            val_3.Invoke(arg1:  -4, arg2:  0);
        }
        public void CommitUpdate(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            .callback = callback;
            GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(value:  metadata);
            System.Byte[] val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Byte[]>(value:  updatedBinaryData);
            if((new AndroidSavedGameClient.<>c__DisplayClass8_0()) != null)
            {
                    System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(value:  (AndroidSavedGameClient.<>c__DisplayClass8_0)[1152921541812024976].callback);
            }
            else
            {
                    System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_5 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(value:  (AndroidSavedGameClient.<>c__DisplayClass8_0)[1152921541812024976].callback);
            }
            
            .callback = GooglePlayGames.Android.AndroidSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(toConvert:  (AndroidSavedGameClient.<>c__DisplayClass8_0)[1152921541812024976].callback);
            GooglePlayGames.OurUtils.Logger.e(msg:  "Encountered metadata that was not generated by this ISavedGameClient");
            (AndroidSavedGameClient.<>c__DisplayClass8_0)[1152921541812024976].callback.Invoke(arg1:  -4, arg2:  0);
        }
        public void FetchAllSavedGames(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback)
        {
            System.Action<T1, T2> val_11;
            AndroidSavedGameClient.<>c__DisplayClass9_0 val_1 = new AndroidSavedGameClient.<>c__DisplayClass9_0();
            if(val_1 != null)
            {
                    val_11 = val_1;
                .callback = callback;
                System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>>(value:  callback);
            }
            else
            {
                    val_11 = 16;
                mem[16] = callback;
                System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>>(value:  mem[16]);
            }
            
            mem[16] = GooglePlayGames.Android.AndroidSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(toConvert:  val_11);
            object[] val_5 = new object[1];
            val_5[0] = (source == 1) ? 1 : 0;
            UnityEngine.AndroidJavaObject val_7 = this.mSnapshotsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "load", args:  val_5);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidSavedGameClient.<>c__DisplayClass9_0::<FetchAllSavedGames>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_7, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_9 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidSavedGameClient.<>c__DisplayClass9_0::<FetchAllSavedGames>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_7, callback:  null);
            if(val_7 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_7.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void Delete(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata)
        {
            var val_6 = 0;
            GooglePlayGames.Android.AndroidSnapshotMetadata val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.Android.AndroidSnapshotMetadata>(value:  null);
            object[] val_3 = new object[1];
            if(val_3 != null)
            {
                
            }
            
            val_3[0] = (GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata.__il2cppRuntimeField_typeHierarchy + (GooglePlayGames.Android.AndroidSnapshotMetadata.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? metadata : 0 + 24;
            UnityEngine.AndroidJavaObject val_4 = this.mSnapshotsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "delete", args:  val_3);
            if(val_4 == null)
            {
                    return;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_4.Dispose();
        }
        private GooglePlayGames.BasicApi.SavedGame.ConflictCallback ToOnGameThread(GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback)
        {
            .conflictCallback = conflictCallback;
            return (GooglePlayGames.BasicApi.SavedGame.ConflictCallback)new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(object:  new AndroidSavedGameClient.<>c__DisplayClass11_0(), method:  System.Void AndroidSavedGameClient.<>c__DisplayClass11_0::<ToOnGameThread>b__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData));
        }
        internal static bool IsValidFilename(string filename)
        {
            var val_1;
            if(filename == null)
            {
                    return false;
            }
            
            val_1 = null;
            val_1 = null;
            if(GooglePlayGames.Android.AndroidSavedGameClient.ValidFilenameRegex != null)
            {
                    return GooglePlayGames.Android.AndroidSavedGameClient.ValidFilenameRegex.IsMatch(input:  filename);
            }
            
            return GooglePlayGames.Android.AndroidSavedGameClient.ValidFilenameRegex.IsMatch(input:  filename);
        }
        private static UnityEngine.AndroidJavaObject AsMetadataChange(GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate update)
        {
            UnityEngine.AndroidJavaClass val_27;
            object val_28;
            var val_30;
            var val_31;
            var val_32;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "com.google.android.gms.games.snapshot.SnapshotMetadataChange$Builder", args:  System.Array.Empty<System.Object>());
            if(update.mDescriptionUpdated.下丕且丝丐丙丏丛上() == false)
            {
                goto label_1;
            }
            
            val_27 = new UnityEngine.AndroidJavaClass();
            val_27 = new UnityEngine.AndroidJavaClass(className:  "android.graphics.BitmapFactory");
            val_28 = 1152921505719563712;
            object[] val_5 = new object[3];
            val_5[0] = update.mDescriptionUpdated.丘一一丆业丂丘丒世();
            val_5[1] = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = update.mDescriptionUpdated.丘一一丆业丂丘丒世();
            val_5[2] = val_5.Length;
            UnityEngine.AndroidJavaObject val_8 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "decodeByteArray", args:  val_5);
            object[] val_9 = new object[1];
            val_9[0] = val_8;
            UnityEngine.AndroidJavaObject val_10 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "setCoverImage", args:  val_9);
            if(val_10 == null)
            {
                goto label_19;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            goto label_23;
            label_1:
            val_30 = 0;
            val_31 = 0;
            val_32 = 0;
            goto label_47;
            label_23:
            val_10.Dispose();
            label_19:
            val_32 = 0;
            val_30 = 0;
            if(val_8 != null)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_8.Dispose();
            }
            
            if(val_32 == 1)
            {
                goto label_30;
            }
            
            if(val_30 != 0)
            {
                    if(144 != 144)
            {
                goto label_32;
            }
            
            }
            
            val_31 = val_30;
            if(val_27 != null)
            {
                goto label_36;
            }
            
            goto label_38;
            label_30:
            if(val_30 == 0)
            {
                goto label_35;
            }
            
            label_32:
            val_30 = 0;
            val_31 = 0;
            if(val_27 != null)
            {
                goto label_36;
            }
            
            goto label_38;
            label_35:
            val_31 = 0;
            val_32 = 0;
            if(val_27 == null)
            {
                goto label_38;
            }
            
            label_36:
            var val_29 = 0;
            val_29 = val_29 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
            label_38:
            if((val_32 != 1) && (144 == 144))
            {
                    val_32 = val_32 + val_32;
            }
            else
            {
                    if(val_31 != 0)
            {
                    val_30 = 0;
                val_31 = 0;
            }
            else
            {
                    val_30 = 0;
            }
            
            }
            
            label_47:
            if(update.mDescriptionUpdated.下丕且丝丐丙丏丛上() != false)
            {
                    object[] val_15 = new object[1];
                val_28 = 1152921541813055040;
                val_15[0] = val_28;
                val_27 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "setDescription", args:  val_15);
                var val_17 = val_32 + 1;
                mem2[0] = 193;
                if(val_27 != null)
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_27.Dispose();
            }
            
                if(val_17 != 1)
            {
                    val_32 = (val_17 >= 0) ? (val_32) : (val_17);
            }
            else
            {
                    if(val_31 != 0)
            {
                    val_30 = 0;
                val_31 = 0;
            }
            else
            {
                    val_30 = 0;
            }
            
                val_32 = 0;
            }
            
            }
            
            if((1152921541813055040 & 1) != 0)
            {
                    object[] val_19 = new object[1];
                val_27 = val_19;
                System.ArraySegment<System.Byte> val_20 = update.mDescriptionUpdated.GetBufferReference();
                val_27[0] = (long)D0;
                UnityEngine.AndroidJavaObject val_21 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "setPlayedTimeMillis", args:  val_19);
                var val_22 = val_32 + 1;
                mem2[0] = 266;
                if(val_21 != null)
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_21.Dispose();
            }
            
                if(val_22 != 1)
            {
                    val_32 = (val_22 >= 0) ? (val_32) : (val_22);
            }
            else
            {
                    if(val_31 != 0)
            {
                    val_30 = 0;
                val_31 = 0;
            }
            else
            {
                    val_30 = 0;
            }
            
                val_32 = 0;
            }
            
            }
            
            val_32 = val_32 + 1;
            mem2[0] = 295;
            if(val_2 != null)
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                val_2.Dispose();
            }
            
            if(val_32 != 1)
            {
                    if(val_31 == 0)
            {
                    return (UnityEngine.AndroidJavaObject)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
                if((1152921541813010880 + ((val_32 + 1)) << 2) == 295)
            {
                    return (UnityEngine.AndroidJavaObject)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
                return (UnityEngine.AndroidJavaObject)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            if(val_31 != 0)
            {
                    return (UnityEngine.AndroidJavaObject)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            return (UnityEngine.AndroidJavaObject)val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
        }
        private static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert)
        {
            mem2[0] = toConvert;
            if(((__RuntimeMethodHiddenParam + 48 + 24 + 294) & 1) != 0)
            {
                    return (System.Action<T1, T2>)__RuntimeMethodHiddenParam + 48 + 24;
            }
            
            return (System.Action<T1, T2>)__RuntimeMethodHiddenParam + 48 + 24;
        }
        private static AndroidSavedGameClient()
        {
            GooglePlayGames.Android.AndroidSavedGameClient.ValidFilenameRegex = new System.Text.RegularExpressions.Regex(pattern:  "\\A[a-zA-Z0-9-._~]{1,100}\\Z");
        }
    
    }

}
