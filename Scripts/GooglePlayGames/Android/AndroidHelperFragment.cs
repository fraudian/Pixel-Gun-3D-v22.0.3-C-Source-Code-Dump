using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidHelperFragment
    {
        // Fields
        private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";
        
        // Methods
        public static UnityEngine.AndroidJavaObject GetActivity()
        {
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            if(val_1 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return (UnityEngine.AndroidJavaObject)val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            }
            
            if(0 == 0)
            {
                    return (UnityEngine.AndroidJavaObject)val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            }
            
            return (UnityEngine.AndroidJavaObject)val_1.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        }
        public static UnityEngine.AndroidJavaObject GetDefaultPopupView()
        {
            var val_7;
            var val_8;
            var val_10;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            UnityEngine.AndroidJavaObject val_2 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            object[] val_3 = new object[1];
            val_3[0] = val_2;
            val_7 = 0;
            val_8 = 0;
            if(val_2 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_2.Dispose();
            }
            
            if(val_7 == 1)
            {
                goto label_11;
            }
            
            val_10 = val_8;
            if(val_1 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_8 != 0)
            {
                    val_8 = 0;
            }
            
            val_10 = 0;
            val_7 = 0;
            if(val_1 == null)
            {
                goto label_15;
            }
            
            label_12:
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_1.Dispose();
            label_15:
            if(val_7 != 1)
            {
                    return (UnityEngine.AndroidJavaObject)val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getDecorView", args:  val_3);
            }
            
            if(val_10 == 0)
            {
                    return (UnityEngine.AndroidJavaObject)val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getDecorView", args:  val_3);
            }
            
            return (UnityEngine.AndroidJavaObject)val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getDecorView", args:  val_3);
        }
        public static void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> cb)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            AndroidHelperFragment.<>c__DisplayClass3_0 val_1 = new AndroidHelperFragment.<>c__DisplayClass3_0();
            .cb = cb;
            UnityEngine.AndroidJavaClass val_2 = null;
            val_16 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_3 = new object[1];
            val_3[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            UnityEngine.AndroidJavaObject val_5 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "showAchievementUi", args:  val_3);
            System.Action<System.Int32> val_6 = new System.Action<System.Int32>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass3_0::<ShowAchievementsUI>b__0(int uiCode));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<System.Int32>(task:  val_5, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass3_0::<ShowAchievementsUI>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_5, callback:  null);
            val_17 = 0;
            val_18 = 0;
            if(val_5 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_5.Dispose();
            }
            
            if(val_17 == 1)
            {
                goto label_12;
            }
            
            val_20 = val_18;
            if(val_16 != null)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            if(val_18 != 0)
            {
                    val_18 = 0;
            }
            
            val_20 = 0;
            val_17 = 0;
            if(val_16 == null)
            {
                goto label_16;
            }
            
            label_13:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_2.Dispose();
            label_16:
            if(val_17 != 1)
            {
                    return;
            }
            
            if(val_20 == 0)
            {
                    return;
            }
            
            val_16 = ???;
            val_20 = ???;
        }
        public static void ShowCaptureOverlayUI()
        {
            var val_10;
            UnityEngine.AndroidJavaClass val_1 = null;
            val_10 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_2 = new object[1];
            val_2[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_1.CallStatic(methodName:  "showCaptureOverlayUi", args:  val_2);
            if(val_10 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_10 = ???;
        }
        public static void ShowAllLeaderboardsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> cb)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            AndroidHelperFragment.<>c__DisplayClass5_0 val_1 = new AndroidHelperFragment.<>c__DisplayClass5_0();
            .cb = cb;
            UnityEngine.AndroidJavaClass val_2 = null;
            val_16 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_3 = new object[1];
            val_3[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            UnityEngine.AndroidJavaObject val_5 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "showAllLeaderboardsUi", args:  val_3);
            System.Action<System.Int32> val_6 = new System.Action<System.Int32>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass5_0::<ShowAllLeaderboardsUI>b__0(int uiCode));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<System.Int32>(task:  val_5, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass5_0::<ShowAllLeaderboardsUI>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_5, callback:  null);
            val_17 = 0;
            val_18 = 0;
            if(val_5 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_5.Dispose();
            }
            
            if(val_17 == 1)
            {
                goto label_12;
            }
            
            val_20 = val_18;
            if(val_16 != null)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            if(val_18 != 0)
            {
                    val_18 = 0;
            }
            
            val_20 = 0;
            val_17 = 0;
            if(val_16 == null)
            {
                goto label_16;
            }
            
            label_13:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_2.Dispose();
            label_16:
            if(val_17 != 1)
            {
                    return;
            }
            
            if(val_20 == 0)
            {
                    return;
            }
            
            val_16 = ???;
            val_20 = ???;
        }
        public static void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.UIStatus> cb)
        {
            var val_11;
            var val_12;
            var val_14;
            AndroidHelperFragment.<>c__DisplayClass6_0 val_1 = new AndroidHelperFragment.<>c__DisplayClass6_0();
            .cb = cb;
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_3 = new object[3];
            val_3[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_3[1] = leaderboardId;
            val_3[2] = GooglePlayGames.Android.AndroidJavaConverter.ToLeaderboardVariantTimeSpan(span:  timeSpan);
            UnityEngine.AndroidJavaObject val_6 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "showLeaderboardUi", args:  val_3);
            System.Action<System.Int32> val_7 = new System.Action<System.Int32>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass6_0::<ShowLeaderboardUI>b__0(int uiCode));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<System.Int32>(task:  val_6, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass6_0::<ShowLeaderboardUI>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_6, callback:  null);
            val_11 = 0;
            val_12 = 0;
            if(val_6 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_6.Dispose();
            }
            
            if(val_11 == 1)
            {
                goto label_18;
            }
            
            val_14 = val_12;
            if(val_2 != null)
            {
                goto label_19;
            }
            
            goto label_22;
            label_18:
            if(val_12 != 0)
            {
                    val_12 = 0;
            }
            
            val_14 = 0;
            val_11 = 0;
            if(val_2 == null)
            {
                goto label_22;
            }
            
            label_19:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_2.Dispose();
            label_22:
            if(val_11 != 1)
            {
                    return;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
        
        }
        public static void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> cb)
        {
            var val_12;
            var val_13;
            var val_15;
            AndroidHelperFragment.<>c__DisplayClass7_0 val_1 = new AndroidHelperFragment.<>c__DisplayClass7_0();
            .cb = cb;
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_3 = new object[5];
            val_3[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_3[1] = uiTitle;
            val_3[2] = showCreateSaveUI;
            val_3[3] = showDeleteSaveUI;
            val_3[4] = maxDisplayedSavedGames;
            UnityEngine.AndroidJavaObject val_7 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "showSelectSnapshotUi", args:  val_3);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass7_0::<ShowSelectSnapshotUI>b__0(UnityEngine.AndroidJavaObject result));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_7, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_9 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass7_0::<ShowSelectSnapshotUI>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_7, callback:  null);
            val_12 = 0;
            val_13 = 0;
            if(val_7 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_7.Dispose();
            }
            
            if(val_12 == 1)
            {
                goto label_24;
            }
            
            val_15 = val_13;
            if(val_2 != null)
            {
                goto label_25;
            }
            
            goto label_28;
            label_24:
            if(val_13 != 0)
            {
                    val_13 = 0;
            }
            
            val_15 = 0;
            val_12 = 0;
            if(val_2 == null)
            {
                goto label_28;
            }
            
            label_25:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_2.Dispose();
            label_28:
            if(val_12 != 1)
            {
                    return;
            }
            
            if(val_15 == 0)
            {
                    return;
            }
        
        }
        public static void ShowRtmpSelectOpponentsUI(uint minOpponents, uint maxOpponents, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder> cb)
        {
            GooglePlayGames.Android.AndroidHelperFragment.ShowSelectOpponentsUI(minOpponents:  minOpponents, maxOpponents:  maxOpponents, isRealTime:  true, cb:  cb);
        }
        public static void ShowTbmpSelectOpponentsUI(uint minOpponents, uint maxOpponents, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder> cb)
        {
            GooglePlayGames.Android.AndroidHelperFragment.ShowSelectOpponentsUI(minOpponents:  minOpponents, maxOpponents:  maxOpponents, isRealTime:  false, cb:  cb);
        }
        private static void ShowSelectOpponentsUI(uint minOpponents, uint maxOpponents, bool isRealTime, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder> cb)
        {
            var val_11;
            var val_12;
            var val_14;
            AndroidHelperFragment.<>c__DisplayClass10_0 val_1 = new AndroidHelperFragment.<>c__DisplayClass10_0();
            .cb = cb;
            UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_4 = new object[3];
            val_4[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_4[1] = minOpponents;
            val_4[2] = maxOpponents;
            UnityEngine.AndroidJavaObject val_6 = val_3.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  (isRealTime != true) ? "showRtmpSelectOpponentsUi" : "showTbmpSelectOpponentsUi", args:  val_4);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass10_0::<ShowSelectOpponentsUI>b__0(UnityEngine.AndroidJavaObject result));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_6, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass10_0::<ShowSelectOpponentsUI>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_6, callback:  null);
            val_11 = 0;
            val_12 = 0;
            if(val_6 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_6.Dispose();
            }
            
            if(val_11 == 1)
            {
                goto label_18;
            }
            
            val_14 = val_12;
            if(val_3 != null)
            {
                goto label_19;
            }
            
            goto label_22;
            label_18:
            if(val_12 != 0)
            {
                    val_12 = 0;
            }
            
            val_14 = 0;
            val_11 = 0;
            if(val_3 == null)
            {
                goto label_22;
            }
            
            label_19:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_3.Dispose();
            label_22:
            if(val_11 != 1)
            {
                    return;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
        
        }
        public static void ShowWaitingRoomUI(UnityEngine.AndroidJavaObject room, int minParticipantsToStart, System.Action<GooglePlayGames.Android.AndroidHelperFragment.WaitingRoomUIStatus, UnityEngine.AndroidJavaObject> cb)
        {
            var val_10;
            var val_11;
            var val_13;
            AndroidHelperFragment.<>c__DisplayClass12_0 val_1 = new AndroidHelperFragment.<>c__DisplayClass12_0();
            .cb = cb;
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_3 = new object[3];
            val_3[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_3[1] = room;
            val_3[2] = minParticipantsToStart;
            UnityEngine.AndroidJavaObject val_5 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "showWaitingRoomUI", args:  val_3);
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass12_0::<ShowWaitingRoomUI>b__0(UnityEngine.AndroidJavaObject result));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_5, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass12_0::<ShowWaitingRoomUI>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_5, callback:  null);
            val_10 = 0;
            val_11 = 0;
            if(val_5 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_5.Dispose();
            }
            
            if(val_10 == 1)
            {
                goto label_18;
            }
            
            val_13 = val_11;
            if(val_2 != null)
            {
                goto label_19;
            }
            
            goto label_22;
            label_18:
            if(val_11 != 0)
            {
                    val_11 = 0;
            }
            
            val_13 = 0;
            val_10 = 0;
            if(val_2 == null)
            {
                goto label_22;
            }
            
            label_19:
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_2.Dispose();
            label_22:
            if(val_10 != 1)
            {
                    return;
            }
            
            if(val_13 == 0)
            {
                    return;
            }
        
        }
        public static void ShowInboxUI(System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> cb)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_23;
            AndroidHelperFragment.<>c__DisplayClass13_0 val_1 = new AndroidHelperFragment.<>c__DisplayClass13_0();
            .cb = cb;
            UnityEngine.AndroidJavaClass val_2 = null;
            val_18 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_3 = new object[1];
            val_3[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            UnityEngine.AndroidJavaObject val_5 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "showInboxUi", args:  val_3);
            val_19 = 1152921504615686144;
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass13_0::<ShowInboxUI>b__0(UnityEngine.AndroidJavaObject result));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_5, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass13_0::<ShowInboxUI>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_5, callback:  null);
            val_20 = 0;
            val_21 = 0;
            if(val_5 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_5.Dispose();
            }
            
            if(val_20 == 1)
            {
                goto label_12;
            }
            
            val_23 = val_21;
            if(val_18 != null)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            if(val_21 != 0)
            {
                    val_21 = 0;
            }
            
            val_23 = 0;
            val_20 = 0;
            if(val_18 == null)
            {
                goto label_16;
            }
            
            label_13:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_2.Dispose();
            label_16:
            if(val_20 != 1)
            {
                    return;
            }
            
            if(val_23 == 0)
            {
                    return;
            }
            
            val_18 = ???;
            val_23 = ???;
            val_19 = ???;
        }
        public static void ShowInvitationInboxUI(System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.Invitation> cb)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_23;
            AndroidHelperFragment.<>c__DisplayClass14_0 val_1 = new AndroidHelperFragment.<>c__DisplayClass14_0();
            .cb = cb;
            UnityEngine.AndroidJavaClass val_2 = null;
            val_18 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.games.bridge.HelperFragment");
            object[] val_3 = new object[1];
            val_3[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            UnityEngine.AndroidJavaObject val_5 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "showInvitationInboxUI", args:  val_3);
            val_19 = 1152921504615686144;
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass14_0::<ShowInvitationInboxUI>b__0(UnityEngine.AndroidJavaObject result));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_5, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidHelperFragment.<>c__DisplayClass14_0::<ShowInvitationInboxUI>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_5, callback:  null);
            val_20 = 0;
            val_21 = 0;
            if(val_5 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_5.Dispose();
            }
            
            if(val_20 == 1)
            {
                goto label_12;
            }
            
            val_23 = val_21;
            if(val_18 != null)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            if(val_21 != 0)
            {
                    val_21 = 0;
            }
            
            val_23 = 0;
            val_20 = 0;
            if(val_18 == null)
            {
                goto label_16;
            }
            
            label_13:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_2.Dispose();
            label_16:
            if(val_20 != 1)
            {
                    return;
            }
            
            if(val_23 == 0)
            {
                    return;
            }
            
            val_18 = ???;
            val_23 = ???;
            val_19 = ???;
        }
        private static System.Collections.Generic.List<string> CreatePlayerIdsToInvite(UnityEngine.AndroidJavaObject playerIdsObject)
        {
            int val_2 = playerIdsObject.Call<System.Int32>(methodName:  "size", args:  System.Array.Empty<System.Object>());
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            if(val_2 < 1)
            {
                    return val_3;
            }
            
            object val_6 = 0;
            label_11:
            object[] val_4 = new object[1];
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(val_6 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_6 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_4[0] = val_6;
            val_3.Add(item:  playerIdsObject.Call<System.String>(methodName:  "get", args:  val_4));
            val_6 = val_6 + 1;
            if(val_2 != val_6)
            {
                goto label_11;
            }
            
            return val_3;
        }
        public AndroidHelperFragment()
        {
        
        }
    
    }

}
