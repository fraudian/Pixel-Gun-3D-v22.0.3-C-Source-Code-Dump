using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidTurnBasedMultiplayerClient : ITurnBasedMultiplayerClient
    {
        // Fields
        private UnityEngine.AndroidJavaObject mClient;
        private GooglePlayGames.Android.AndroidClient mAndroidClient;
        private System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> mMatchDelegate;
        
        // Properties
        public System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> MatchDelegate { get; }
        
        // Methods
        public AndroidTurnBasedMultiplayerClient(GooglePlayGames.Android.AndroidClient androidClient, UnityEngine.AndroidJavaObject account)
        {
            var val_14;
            var val_15;
            val_1 = new System.Object();
            this.mAndroidClient = androidClient;
            UnityEngine.AndroidJavaClass val_2 = null;
            val_14 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.games.Games");
            object[] val_3 = new object[2];
            val_3[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_3[1] = val_1;
            val_15 = 0;
            this.mClient = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getTurnBasedMultiplayerClient", args:  val_3);
            if(val_14 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_2.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(val_15 == 0)
            {
                    return;
            }
            
            val_14 = ???;
            val_15 = ???;
        }
        public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            this.CreateQuickMatch(minOpponents:  minOpponents, maxOpponents:  maxOpponents, variant:  variant, exclusiveBitmask:  0, callback:  callback);
        }
        public void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            var val_24;
            System.Action<T1, T2> val_25;
            var val_26;
            var val_27;
            var val_29;
            var val_34;
            var val_35;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass5_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass5_0();
            if(val_1 != null)
            {
                    val_24 = val_1;
                .callback = callback;
                val_25 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  callback);
            }
            else
            {
                    val_24 = 16;
                mem[16] = callback;
                val_25 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  mem[16]);
            }
            
            mem[16] = val_25;
            UnityEngine.AndroidJavaClass val_4 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.games.multiplayer.turnbased.TurnBasedMatchConfig");
            UnityEngine.AndroidJavaObject val_6 = val_4.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "builder", args:  System.Array.Empty<System.Object>());
            object[] val_7 = new object[3];
            val_7[0] = minOpponents;
            val_7[1] = maxOpponents;
            val_7[2] = exclusiveBitmask;
            UnityEngine.AndroidJavaObject val_8 = val_4.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createAutoMatchCriteria", args:  val_7);
            object[] val_9 = new object[1];
            val_9[0] = val_8;
            UnityEngine.AndroidJavaObject val_10 = val_6.Call<UnityEngine.AndroidJavaObject>(methodName:  "setAutoMatchCriteria", args:  val_9);
            if(variant != 0)
            {
                    object[] val_11 = new object[1];
                val_11[0] = variant;
                UnityEngine.AndroidJavaObject val_12 = val_6.Call<UnityEngine.AndroidJavaObject>(methodName:  "setVariant", args:  val_11);
            }
            
            UnityEngine.AndroidJavaObject val_14 = val_6.Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            object[] val_15 = new object[1];
            val_15[0] = val_14;
            UnityEngine.AndroidJavaObject val_16 = mem[1152921541827778608].Call<UnityEngine.AndroidJavaObject>(methodName:  "createMatch", args:  val_15);
            System.Action<UnityEngine.AndroidJavaObject> val_17 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass5_0::<CreateQuickMatch>b__0(UnityEngine.AndroidJavaObject turnBasedMatch));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_16, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_18 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass5_0::<CreateQuickMatch>b__1(UnityEngine.AndroidJavaObject e));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_16, callback:  null);
            val_26 = 0;
            val_27 = 0;
            if(val_16 != null)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_16.Dispose();
            }
            
            if(val_26 == 1)
            {
                goto label_37;
            }
            
            val_29 = val_27;
            if(val_14 != null)
            {
                goto label_38;
            }
            
            goto label_41;
            label_37:
            if(val_27 != 0)
            {
                    val_27 = 0;
            }
            
            val_29 = 0;
            val_26 = 0;
            if(val_14 == null)
            {
                goto label_41;
            }
            
            label_38:
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_14.Dispose();
            label_41:
            if(val_26 == 1)
            {
                goto label_46;
            }
            
            if(val_8 != null)
            {
                goto label_114;
            }
            
            goto label_115;
            label_46:
            if(val_29 != 0)
            {
                    val_27 = 0;
                val_29 = 0;
            }
            else
            {
                    val_27 = 0;
            }
            
            val_26 = 0;
            if(val_8 == null)
            {
                goto label_115;
            }
            
            label_114:
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_8.Dispose();
            label_115:
            if(val_26 == 1)
            {
                goto label_56;
            }
            
            if(val_6 != null)
            {
                goto label_117;
            }
            
            goto label_118;
            label_56:
            if(val_29 != 0)
            {
                    val_27 = 0;
                val_29 = 0;
            }
            else
            {
                    val_27 = 0;
            }
            
            val_26 = 0;
            if(val_6 == null)
            {
                goto label_118;
            }
            
            label_117:
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_6.Dispose();
            label_118:
            if(val_26 == 1)
            {
                goto label_66;
            }
            
            if(val_4 == null)
            {
                goto label_121;
            }
            
            label_120:
            var val_28 = 0;
            val_28 = val_28 + 1;
            goto label_71;
            label_66:
            if(val_29 == 0)
            {
                goto label_72;
            }
            
            val_27 = 0;
            val_29 = 0;
            val_26 = 0;
            if(val_4 != null)
            {
                goto label_120;
            }
            
            goto label_121;
            label_71:
            val_4.Dispose();
            label_121:
            if(val_26 != 1)
            {
                    return;
            }
            
            if(val_29 == 0)
            {
                    return;
            }
            
            return;
            label_72:
            if(val_4 != null)
            {
                goto label_120;
            }
            
            goto label_121;
            label_122:
            val_34 = public System.Void System.IDisposable::Dispose();
            val_35 = val_6;
            if(val_34 != 1)
            {
                goto label_116;
            }
            
            if(val_6 != null)
            {
                goto label_117;
            }
            
            goto label_118;
            label_116:
            if( != 1)
            {
                goto label_122;
            }
            
            if(val_4 != null)
            {
                goto label_120;
            }
            
            goto label_121;
        }
        public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            .callback = callback;
            this.CreateWithInvitationScreen(minOpponents:  minOpponents, maxOpponents:  maxOpponents, variant:  variant, callback:  new System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass6_0(), method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass6_0::<CreateWithInvitationScreen>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)));
        }
        public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            var val_5;
            System.Action<T1, T2> val_6;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass7_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass7_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .callback = callback;
                mem[1152921541828247760] = this;
                mem[1152921541828247776] = variant;
                val_6 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  callback);
            }
            else
            {
                    mem[16] = this;
                val_5 = 24;
                mem[24] = callback;
                mem[32] = variant;
                val_6 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  mem[24]);
            }
            
            mem[24] = val_6;
            GooglePlayGames.Android.AndroidHelperFragment.ShowTbmpSelectOpponentsUI(minOpponents:  minOpponents, maxOpponents:  maxOpponents, cb:  new System.Action<GooglePlayGames.BasicApi.UIStatus, InvitationResultHolder>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass7_0::<CreateWithInvitationScreen>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder result)));
        }
        private UnityEngine.AndroidJavaObject StringListToAndroidJavaObject(System.Collections.Generic.List<string> list)
        {
            var val_7;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.ArrayList", args:  System.Array.Empty<System.Object>());
            val_7 = 0;
            goto label_1;
            label_11:
            object[] val_3 = new object[1];
            string val_4 = list.Item[0];
            if(val_3 == null)
            {
                goto label_3;
            }
            
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_4 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_3[0] = val_4;
            bool val_5 = val_2.Call<System.Boolean>(methodName:  "add", args:  val_3);
            val_7 = 1;
            label_1:
            if(val_7 < list.Count)
            {
                goto label_11;
            }
            
            return val_2;
        }
        public void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback)
        {
            var val_17;
            System.Action<T> val_18;
            var val_19;
            var val_20;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass9_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass9_0();
            if(val_1 != null)
            {
                    val_17 = val_1;
                .callback = callback;
                val_18 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.Multiplayer.Invitation[]>(toConvert:  callback);
            }
            else
            {
                    val_17 = 16;
                mem[16] = callback;
                val_18 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.Multiplayer.Invitation[]>(toConvert:  mem[16]);
            }
            
            mem[16] = val_18;
            object[] val_4 = new object[1];
            val_4[0] = new int[4] {0, 1, 2, 3};
            UnityEngine.AndroidJavaObject val_6 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadMatchesByStatus", args:  val_4);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass9_0::<GetAllInvitations>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_6, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass9_0::<GetAllInvitations>b__1(UnityEngine.AndroidJavaObject e));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_6, callback:  null);
            val_19 = 0;
            val_20 = 0;
            if(val_6 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_6.Dispose();
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
        }
        public void GetAllMatches(System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback)
        {
            var val_17;
            System.Action<T> val_18;
            var val_19;
            var val_20;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass10_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass10_0();
            if(val_1 != null)
            {
                    val_17 = val_1;
                .callback = callback;
                mem[1152921541828840096] = this;
                val_18 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]>(toConvert:  callback);
            }
            else
            {
                    mem[16] = this;
                val_17 = 24;
                mem[24] = callback;
                val_18 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]>(toConvert:  mem[24]);
            }
            
            mem[24] = val_18;
            object[] val_4 = new object[1];
            val_4[0] = new int[4] {0, 1, 2, 3};
            UnityEngine.AndroidJavaObject val_6 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadMatchesByStatus", args:  val_4);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass10_0::<GetAllMatches>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_6, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass10_0::<GetAllMatches>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_6, callback:  null);
            val_19 = 0;
            val_20 = 0;
            if(val_6 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_6.Dispose();
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
        }
        public void GetMatch(string matchId, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            object val_16;
            var val_17;
            System.Action<T1, T2> val_18;
            var val_19;
            var val_20;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass11_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass11_0();
            if(val_1 != null)
            {
                    val_16 = val_1;
                .matchId = matchId;
                val_17 = 1152921541829040352;
                mem[1152921541829040360] = callback;
                val_18 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  callback);
            }
            else
            {
                    val_16 = 16;
                mem[16] = matchId;
                val_17 = 24;
                mem[24] = callback;
                val_18 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  mem[24]);
            }
            
            mem[24] = val_18;
            object[] val_4 = new object[1];
            val_4[0] = val_16;
            UnityEngine.AndroidJavaObject val_5 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadMatch", args:  val_4);
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass11_0::<GetMatch>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_5, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass11_0::<GetMatch>b__1(UnityEngine.AndroidJavaObject e));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_5, callback:  null);
            val_19 = 0;
            val_20 = 0;
            if(val_5 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
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
        }
        private void GetMatchAndroidJavaObject(string matchId, System.Action<bool, UnityEngine.AndroidJavaObject> callback)
        {
            object val_14;
            UnityEngine.AndroidJavaObject val_15;
            var val_16;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass12_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass12_0();
            if(val_1 != null)
            {
                    val_14 = val_1;
                .matchId = matchId;
            }
            else
            {
                    val_14 = 16;
                mem[16] = matchId;
            }
            
            .callback = callback;
            object[] val_2 = new object[1];
            val_2[0] = val_14;
            val_15 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadMatch", args:  val_2);
            System.Action<UnityEngine.AndroidJavaObject> val_4 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass12_0::<GetMatchAndroidJavaObject>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_15, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_5 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass12_0::<GetMatchAndroidJavaObject>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_15, callback:  null);
            val_16 = 0;
            if(val_15 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_15.Dispose();
            }
            
            if(val_16 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_15 = ???;
            val_16 = ???;
        }
        public void AcceptFromInbox(System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            var val_5;
            System.Action<T1, T2> val_6;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass13_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass13_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .callback = callback;
                mem[1152921541829390400] = this;
                val_6 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  callback);
            }
            else
            {
                    mem[16] = this;
                val_5 = 24;
                mem[24] = callback;
                val_6 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  mem[24]);
            }
            
            mem[24] = val_6;
            GooglePlayGames.Android.AndroidHelperFragment.ShowInboxUI(cb:  new System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass13_0::<AcceptFromInbox>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch turnBasedMatch)));
        }
        public void AcceptInvitation(string invitationId, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            string val_5;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass14_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass14_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .invitationId = invitationId;
                mem[1152921541829552584] = callback;
                mem[1152921541829552592] = this;
                mem[1152921541829552584] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  callback);
            }
            else
            {
                    val_5 = 16;
                mem[16] = invitationId;
                mem[24] = callback;
                mem[32] = this;
                mem[24] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  mem[24]);
            }
            
            this.FindInvitationWithId(invitationId:  val_5, callback:  new System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass14_0::<AcceptInvitation>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation)));
        }
        public void RegisterMatchDelegate(GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del)
        {
            var val_10;
            object val_11;
            val_10 = this;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass15_0 val_1 = null;
            val_11 = val_1;
            val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass15_0();
            if(val_11 == null)
            {
                goto label_1;
            }
            
            .del = del;
            if(del == null)
            {
                goto label_2;
            }
            
            label_17:
            System.Action<T1, T2> val_3 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, System.Boolean>(toConvert:  new System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, System.Boolean>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass15_0::<RegisterMatchDelegate>b__0(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch turnBasedMatch, bool autoAccept)));
            this.mMatchDelegate = val_3;
            object[] val_5 = new object[1];
            val_5[0] = new AndroidTurnBasedMultiplayerClient.TurnBasedMatchUpdateCallbackProxy(matchDelegate:  val_3);
            object[] val_7 = new object[1];
            val_11 = val_7;
            val_11[0] = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.TurnBasedMatchUpdateCallbackProxy", args:  val_5);
            val_10 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "registerTurnBasedMatchUpdateCallback", args:  val_7);
            if(val_10 == null)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_16;
            label_1:
            mem[16] = del;
            if(mem[16] != 0)
            {
                goto label_17;
            }
            
            label_2:
            this.mMatchDelegate = 0;
            return;
            label_16:
            val_10.Dispose();
        }
        public System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> get_MatchDelegate()
        {
            return (System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, System.Boolean>)this.mMatchDelegate;
        }
        public void TakeTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, string pendingParticipantId, System.Action<bool> callback)
        {
            string val_5;
            System.Action<System.Boolean> val_6;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass18_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass18_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .data = data;
                .pendingParticipantId = pendingParticipantId;
                .callback = callback;
                val_5 = (AndroidTurnBasedMultiplayerClient.<>c__DisplayClass18_0)[1152921541830120416].pendingParticipantId;
                val_6 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  callback);
                .callback = val_6;
            }
            else
            {
                    mem[16] = this;
                mem[24] = data;
                mem[32] = pendingParticipantId;
                mem[40] = callback;
                mem[40] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  mem[40]);
                val_5 = mem[32];
                val_6 = mem[40];
            }
            
            this.FindEqualVersionMatchWithParticipant(match:  match, participantId:  val_5, onFailure:  val_6, onFoundParticipantAndMatch:  new System.Action<GooglePlayGames.BasicApi.Multiplayer.Participant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass18_0::<TakeTurn>b__0(GooglePlayGames.BasicApi.Multiplayer.Participant pendingParticipant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
        }
        public int GetMaxMatchDataSize()
        {
            return 134217728;
        }
        public void Finish(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome outcome, System.Action<bool> callback)
        {
            var val_6;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass20_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass20_0();
            if(val_1 != null)
            {
                    val_6 = val_1;
                .match = match;
                mem[1152921541830485744] = callback;
                mem[1152921541830485752] = outcome;
                mem[1152921541830485760] = this;
                mem[1152921541830485776] = data;
                mem[1152921541830485744] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  callback);
            }
            else
            {
                    mem[16] = callback;
                mem[24] = outcome;
                mem[32] = this;
                val_6 = 40;
                mem[40] = match;
                mem[48] = data;
                mem[16] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  mem[16]);
            }
            
            this.GetMatchAndroidJavaObject(matchId:  mem[40].MatchId, callback:  new System.Action<System.Boolean, UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass20_0::<Finish>b__0(bool status, UnityEngine.AndroidJavaObject foundMatch)));
        }
        public void AcknowledgeFinished(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback)
        {
            var val_5;
            System.Action<T> val_6;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass21_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass21_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .callback = callback;
                mem[1152921541830653048] = this;
                val_6 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  callback);
            }
            else
            {
                    val_5 = 16;
                mem[16] = callback;
                mem[24] = this;
                val_6 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  mem[16]);
            }
            
            mem[16] = val_6;
            this.FindEqualVersionMatch(match:  match, callback:  new System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass21_0::<AcknowledgeFinished>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
        }
        public void Leave(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_5;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass22_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass22_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .match = match;
                mem[1152921541830815216] = callback;
                mem[1152921541830815224] = this;
                mem[1152921541830815216] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  callback);
            }
            else
            {
                    mem[16] = callback;
                mem[24] = this;
                val_5 = 32;
                mem[32] = match;
                mem[16] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  mem[16]);
            }
            
            this.FindEqualVersionMatch(match:  val_5, callback:  new System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass22_0::<Leave>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
        }
        public void LeaveDuringTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string pendingParticipantId, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_5;
            string val_6;
            System.Action<System.Boolean> val_7;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass23_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass23_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .match = match;
                .pendingParticipantId = pendingParticipantId;
                .callback = callback;
                val_5 = (AndroidTurnBasedMultiplayerClient.<>c__DisplayClass23_0)[1152921541830993760].match;
                val_6 = (AndroidTurnBasedMultiplayerClient.<>c__DisplayClass23_0)[1152921541830993760].pendingParticipantId;
                val_7 = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  callback);
                .callback = val_7;
            }
            else
            {
                    mem[16] = this;
                mem[24] = match;
                mem[32] = pendingParticipantId;
                mem[40] = callback;
                mem[40] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  mem[40]);
                val_5 = mem[24];
                val_6 = mem[32];
                val_7 = mem[40];
            }
            
            this.FindEqualVersionMatchWithParticipant(match:  val_5, participantId:  val_6, onFailure:  val_7, onFoundParticipantAndMatch:  new System.Action<GooglePlayGames.BasicApi.Multiplayer.Participant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass23_0::<LeaveDuringTurn>b__0(GooglePlayGames.BasicApi.Multiplayer.Participant pendingParticipant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
        }
        public void Cancel(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback)
        {
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_5;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass24_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass24_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .match = match;
                mem[1152921541831164144] = callback;
                mem[1152921541831164152] = this;
                mem[1152921541831164144] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  callback);
            }
            else
            {
                    mem[16] = callback;
                mem[24] = this;
                val_5 = 32;
                mem[32] = match;
                mem[16] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean>(toConvert:  mem[16]);
            }
            
            this.FindEqualVersionMatch(match:  val_5, callback:  new System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass24_0::<Cancel>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
        }
        public void Dismiss(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match)
        {
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_3 = match;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass25_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass25_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .match = val_3;
            }
            else
            {
                    mem[16] = this;
                mem[24] = val_3;
                val_3 = mem[24];
            }
            
            this.FindEqualVersionMatch(match:  val_3, callback:  new System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass25_0::<Dismiss>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
        }
        public void Rematch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_5;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass26_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass26_0();
            if(val_1 != null)
            {
                    val_5 = val_1;
                .match = match;
                mem[1152921541831463920] = callback;
                mem[1152921541831463928] = this;
                mem[1152921541831463920] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  callback);
            }
            else
            {
                    mem[16] = callback;
                mem[24] = this;
                val_5 = 32;
                mem[32] = match;
                mem[16] = GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.ToOnGameThread<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(toConvert:  mem[16]);
            }
            
            this.FindEqualVersionMatch(match:  val_5, callback:  new System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass26_0::<Rematch>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
        }
        public void DeclineInvitation(string invitationId)
        {
            string val_3 = invitationId;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass27_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass27_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .invitationId = val_3;
            }
            else
            {
                    mem[16] = this;
                mem[24] = val_3;
                val_3 = mem[24];
            }
            
            this.FindInvitationWithId(invitationId:  val_3, callback:  new System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass27_0::<DeclineInvitation>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation)));
        }
        private void FindInvitationWithId(string invitationId, System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> callback)
        {
            UnityEngine.AndroidJavaObject val_15;
            var val_16;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass28_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass28_0();
            if(val_1 != null)
            {
                    .invitationId = invitationId;
            }
            else
            {
                    mem[16] = invitationId;
            }
            
            .callback = callback;
            object[] val_2 = new object[1];
            val_2[0] = new int[4] {0, 1, 2, 3};
            val_15 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadMatchesByStatus", args:  val_2);
            System.Action<UnityEngine.AndroidJavaObject> val_5 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass28_0::<FindInvitationWithId>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_15, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass28_0::<FindInvitationWithId>b__1(UnityEngine.AndroidJavaObject e));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_15, callback:  null);
            val_16 = 0;
            if(val_15 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_15.Dispose();
            }
            
            if(val_16 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_15 = ???;
            val_16 = ???;
        }
        private void FindEqualVersionMatch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback)
        {
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass29_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass29_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .callback = callback;
            .match = match;
            if(match != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            this.GetMatch(matchId:  match.MatchId, callback:  new System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass29_0::<FindEqualVersionMatch>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
            return;
            label_1:
            mem[16] = callback;
            mem[24] = match;
            if(mem[24] != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        private void FindEqualVersionMatchWithParticipant(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string participantId, System.Action<bool> onFailure, System.Action<GooglePlayGames.BasicApi.Multiplayer.Participant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> onFoundParticipantAndMatch)
        {
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_3 = match;
            AndroidTurnBasedMultiplayerClient.<>c__DisplayClass30_0 val_1 = new AndroidTurnBasedMultiplayerClient.<>c__DisplayClass30_0();
            if(val_1 != null)
            {
                    .onFailure = onFailure;
                .participantId = participantId;
                .onFoundParticipantAndMatch = onFoundParticipantAndMatch;
                .<>4__this = this;
                .match = val_3;
            }
            else
            {
                    mem[16] = onFailure;
                mem[24] = participantId;
                mem[32] = onFoundParticipantAndMatch;
                mem[40] = this;
                mem[48] = val_3;
                val_3 = mem[48];
            }
            
            this.FindEqualVersionMatch(match:  val_3, callback:  new System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>(object:  val_1, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass30_0::<FindEqualVersionMatchWithParticipant>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)));
        }
        private GooglePlayGames.BasicApi.Multiplayer.Participant CreateAutomatchingSentinel()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)new GooglePlayGames.BasicApi.Multiplayer.Participant(displayName:  "", participantId:  "", status:  0, player:  new GooglePlayGames.BasicApi.Multiplayer.Player(displayName:  "", playerId:  "", avatarUrl:  ""), connectedToRoom:  false);
        }
        private System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> CreateTurnBasedMatchList(UnityEngine.AndroidJavaObject turnBasedMatchBuffer)
        {
            System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> val_1 = new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch>();
            int val_3 = turnBasedMatchBuffer.Call<System.Int32>(methodName:  "getCount", args:  System.Array.Empty<System.Object>());
            if(val_3 < 1)
            {
                    return val_1;
            }
            
            object val_7 = 0;
            label_11:
            object[] val_4 = new object[1];
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(val_7 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_7 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_4[0] = val_7;
            val_1.Add(item:  GooglePlayGames.Android.AndroidJavaConverter.ToTurnBasedMatch(turnBasedMatch:  turnBasedMatchBuffer.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_4)));
            val_7 = val_7 + 1;
            if(val_3 != val_7)
            {
                goto label_11;
            }
            
            return val_1;
        }
        private static System.Action<T> ToOnGameThread<T>(System.Action<T> toConvert)
        {
            mem2[0] = toConvert;
            if(((__RuntimeMethodHiddenParam + 48 + 24 + 294) & 1) != 0)
            {
                    return (System.Action<T>)__RuntimeMethodHiddenParam + 48 + 24;
            }
            
            return (System.Action<T>)__RuntimeMethodHiddenParam + 48 + 24;
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
    
    }

}
