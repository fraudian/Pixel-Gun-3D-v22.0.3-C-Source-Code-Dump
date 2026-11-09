using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidRealTimeMultiplayerClient : IRealTimeMultiplayerClient
    {
        // Fields
        private readonly object mSessionLock;
        private int mMinPlayersToStart;
        private GooglePlayGames.Android.AndroidClient mAndroidClient;
        private UnityEngine.AndroidJavaObject mRtmpClient;
        private UnityEngine.AndroidJavaObject mInvitationsClient;
        private UnityEngine.AndroidJavaObject mRoom;
        private UnityEngine.AndroidJavaObject mRoomConfig;
        private GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;
        private GooglePlayGames.BasicApi.Multiplayer.Invitation mInvitation;
        
        // Methods
        public AndroidRealTimeMultiplayerClient(GooglePlayGames.Android.AndroidClient androidClient, UnityEngine.AndroidJavaObject account)
        {
            var val_20;
            var val_21;
            var val_22;
            this.mSessionLock = new System.Object();
            val_2 = new System.Object();
            this.mAndroidClient = androidClient;
            UnityEngine.AndroidJavaClass val_3 = null;
            val_20 = val_3;
            val_3 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.games.Games");
            object[] val_4 = new object[2];
            val_4[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_4[1] = val_2;
            this.mRtmpClient = val_3.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getRealTimeMultiplayerClient", args:  val_4);
            object[] val_7 = new object[2];
            val_7[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_7[1] = val_2;
            val_21 = 0;
            val_22 = 0;
            this.mInvitationsClient = val_3.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInvitationsClient", args:  val_7);
            if(val_20 != null)
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                val_3.Dispose();
            }
            
            if(val_21 != 1)
            {
                    return;
            }
            
            if(val_22 == 0)
            {
                    return;
            }
            
            val_20 = ???;
            val_22 = ???;
            val_21 = ???;
        }
        public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            this.CreateQuickGame(minOpponents:  minOpponents, maxOpponents:  maxOpponents, variant:  variant, exclusiveBitMask:  0, listener:  listener);
        }
        public void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            uint val_42;
            GooglePlayGames.Android.AndroidRealTimeMultiplayerClient val_43;
            object val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_50;
            var val_52;
            var val_55;
            var val_58;
            val_42 = minOpponents;
            val_43 = this;
            .<>4__this = val_43;
            .listenerOnGameThread = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener(listener:  listener);
            val_44 = this.mSessionLock;
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_44, lockTaken: ref  val_3);
            if(this.GetRoomStatus() != 3)
            {
                goto label_3;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  "Received attempt to create a new room without cleaning up the old one.");
            (AndroidRealTimeMultiplayerClient.<>c__DisplayClass12_0)[1152921541793842496].listenerOnGameThread.OnRoomConnected(success:  false);
            val_45 = -1467758432;
            val_46 = 0;
            val_47 = 0;
            val_48 = 0;
            goto label_245;
            label_3:
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.games.multiplayer.realtime.RoomConfig");
            object[] val_6 = new object[1];
            new AndroidRealTimeMultiplayerClient.RoomUpdateCallbackProxy() = new AndroidRealTimeMultiplayerClient.RoomUpdateCallbackProxy(parent:  this, listener:  (AndroidRealTimeMultiplayerClient.<>c__DisplayClass12_0)[1152921541793842496].listenerOnGameThread);
            val_6[0] = new AndroidRealTimeMultiplayerClient.RoomUpdateCallbackProxy();
            new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.RoomUpdateCallbackProxy", args:  val_6);
            object[] val_9 = new object[1];
            val_9[0] = new UnityEngine.AndroidJavaObject();
            UnityEngine.AndroidJavaObject val_10 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "builder", args:  val_9);
            if(variant != 0)
            {
                    object[] val_11 = new object[1];
                val_11[0] = variant;
                UnityEngine.AndroidJavaObject val_12 = val_10.Call<UnityEngine.AndroidJavaObject>(methodName:  "setVariant", args:  val_11);
            }
            
            object[] val_13 = new object[3];
            val_13[0] = val_42;
            val_13[1] = maxOpponents;
            val_13[2] = exclusiveBitMask;
            UnityEngine.AndroidJavaObject val_14 = new UnityEngine.AndroidJavaClass().CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createAutoMatchCriteria", args:  val_13);
            object[] val_15 = new object[1];
            val_15[0] = val_14;
            UnityEngine.AndroidJavaObject val_16 = val_10.Call<UnityEngine.AndroidJavaObject>(methodName:  "setAutoMatchCriteria", args:  val_15);
            if(val_16 != null)
            {
                    var val_41 = 0;
                val_41 = val_41 + 1;
                val_16.Dispose();
            }
            
            val_50 = 0;
            val_47 = 0;
            if(val_14 != null)
            {
                    var val_42 = 0;
                val_42 = val_42 + 1;
                val_14.Dispose();
            }
            
            if((val_50 != 1) && (277 == 277))
            {
                    val_50 = 0;
            }
            else
            {
                    if(val_47 != 0)
            {
                    val_47 = 0;
            }
            
            }
            
            object[] val_19 = new object[1];
            new AndroidRealTimeMultiplayerClient.MessageReceivedListenerProxy() = new AndroidRealTimeMultiplayerClient.MessageReceivedListenerProxy(listener:  (AndroidRealTimeMultiplayerClient.<>c__DisplayClass12_0)[1152921541793842496].listenerOnGameThread);
            val_19[0] = new AndroidRealTimeMultiplayerClient.MessageReceivedListenerProxy();
            new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.RealTimeMessageReceivedListenerProxy", args:  val_19);
            object[] val_22 = new object[1];
            val_22[0] = new UnityEngine.AndroidJavaObject();
            UnityEngine.AndroidJavaObject val_23 = val_10.Call<UnityEngine.AndroidJavaObject>(methodName:  "setOnMessageReceivedListener", args:  val_22);
            val_52 = 1;
            if(val_23 != null)
            {
                    var val_43 = 0;
                val_43 = val_43 + 1;
                val_23.Dispose();
            }
            
            if(val_52 == 1)
            {
                goto label_68;
            }
            
            val_48 = val_47;
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                goto label_69;
            }
            
            goto label_72;
            label_68:
            if(val_47 != 0)
            {
                    val_47 = 0;
            }
            
            val_48 = 0;
            val_52 = 0;
            if(new UnityEngine.AndroidJavaObject() == null)
            {
                goto label_72;
            }
            
            label_69:
            var val_44 = 0;
            val_44 = val_44 + 1;
            new UnityEngine.AndroidJavaObject().Dispose();
            label_72:
            if((val_52 != 1) && (277 == 360))
            {
                    var val_45 = 0;
                val_45 = val_45 ^ 0;
                val_52 = val_52 + val_45;
            }
            else
            {
                    if(val_48 != 0)
            {
                    val_47 = 0;
                val_48 = 0;
            }
            else
            {
                    val_47 = 0;
            }
            
            }
            
            object[] val_26 = new object[1];
            new AndroidRealTimeMultiplayerClient.RoomStatusUpdateCallbackProxy() = new AndroidRealTimeMultiplayerClient.RoomStatusUpdateCallbackProxy(parent:  this, listener:  (AndroidRealTimeMultiplayerClient.<>c__DisplayClass12_0)[1152921541793842496].listenerOnGameThread);
            val_26[0] = new AndroidRealTimeMultiplayerClient.RoomStatusUpdateCallbackProxy();
            val_45 = -1467758432;
            new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.RoomStatusUpdateCallbackProxy", args:  val_26);
            object[] val_29 = new object[1];
            val_29[0] = new UnityEngine.AndroidJavaObject();
            UnityEngine.AndroidJavaObject val_30 = val_10.Call<UnityEngine.AndroidJavaObject>(methodName:  "setRoomStatusUpdateCallback", args:  val_29);
            val_55 = val_52 + 1;
            mem2[0] = 444;
            if(val_30 != null)
            {
                    var val_46 = 0;
                val_46 = val_46 + 1;
                val_30.Dispose();
            }
            
            if(val_55 == 1)
            {
                goto label_97;
            }
            
            if(new UnityEngine.AndroidJavaObject() == null)
            {
                goto label_224;
            }
            
            label_223:
            var val_47 = 0;
            val_47 = val_47 + 1;
            goto label_102;
            label_97:
            if(val_48 == 0)
            {
                goto label_103;
            }
            
            val_47 = 0;
            val_48 = 0;
            val_55 = 0;
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                goto label_223;
            }
            
            goto label_224;
            label_102:
            new UnityEngine.AndroidJavaObject().Dispose();
            label_224:
            if((val_55 != 1) && ((val_45 + ((val_52 + 1)) << 2) == 444))
            {
                    var val_48 = 0;
                val_48 = val_48 ^ (val_55 >> 31);
                val_55 = val_55 + val_48;
            }
            else
            {
                    if(val_48 != 0)
            {
                    val_47 = 0;
                val_48 = 0;
            }
            else
            {
                    val_47 = 0;
            }
            
            }
            
            this.mRoomConfig = val_10.Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            val_58 = val_55 + 1;
            this.mListener = (AndroidRealTimeMultiplayerClient.<>c__DisplayClass12_0)[1152921541793842496].listenerOnGameThread;
            mem2[0] = 515;
            if(val_10 != null)
            {
                    var val_49 = 0;
                val_49 = val_49 + 1;
                val_10.Dispose();
            }
            
            if(val_58 == 1)
            {
                goto label_118;
            }
            
            val_44 = val_44;
            if(val_48 == 0)
            {
                goto label_238;
            }
            
            if((val_45 + (((val_52 + 1) + 1)) << 2) != 515)
            {
                goto label_120;
            }
            
            goto label_238;
            label_118:
            val_44 = val_44;
            if(val_48 == 0)
            {
                goto label_122;
            }
            
            label_120:
            val_47 = 0;
            val_48 = 0;
            goto label_238;
            label_122:
            val_47 = 0;
            val_58 = 0;
            label_238:
            if(new UnityEngine.AndroidJavaObject() != 0)
            {
                    UnityEngine.AndroidJavaObject val_51 = new UnityEngine.AndroidJavaObject();
                var val_50 = 0;
                val_50 = val_50 + 1;
                new UnityEngine.AndroidJavaObject().Dispose();
            }
            
            if(val_58 == 1)
            {
                goto label_129;
            }
            
            if(val_48 != 0)
            {
                    if(277 != 515)
            {
                goto label_131;
            }
            
            }
            
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                goto label_242;
            }
            
            goto label_243;
            label_129:
            if(val_48 == 0)
            {
                goto label_134;
            }
            
            label_131:
            val_47 = 0;
            val_48 = 0;
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                goto label_242;
            }
            
            goto label_243;
            label_134:
            val_47 = 0;
            val_58 = 0;
            if(new UnityEngine.AndroidJavaClass() == null)
            {
                goto label_243;
            }
            
            label_242:
            var val_52 = 0;
            val_52 = val_52 + 1;
            new UnityEngine.AndroidJavaClass().Dispose();
            label_243:
            if((val_58 != 1) && (277 == 515))
            {
                    var val_53 = 0;
                val_53 = val_53 ^ 0;
                val_58 = val_58 + val_53;
            }
            else
            {
                    if(val_48 != 0)
            {
                    val_47 = 0;
                val_48 = 0;
            }
            else
            {
                    val_47 = 0;
            }
            
            }
            
            uint val_54 = val_42;
            val_54 = val_54 + 1;
            this.mMinPlayersToStart = val_54;
            object[] val_37 = new object[1];
            val_42 = val_37;
            val_42[0] = this.mRoomConfig;
            val_43 = this.mRtmpClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "create", args:  val_37);
            System.Action<UnityEngine.AndroidJavaObject> val_39 = new System.Action<UnityEngine.AndroidJavaObject>(object:  new AndroidRealTimeMultiplayerClient.<>c__DisplayClass12_0(), method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass12_0::<CreateQuickGame>b__0(UnityEngine.AndroidJavaObject e));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_43, callback:  null);
            val_46 = val_58 + 1;
            mem2[0] = 602;
            if(val_43 != null)
            {
                    var val_55 = 0;
                val_55 = val_55 + 1;
                val_43.Dispose();
            }
            
            if(val_46 == 1)
            {
                goto label_157;
            }
            
            if(val_48 == 0)
            {
                goto label_245;
            }
            
            if((val_45 + ((val_58 + 1)) << 2) != 602)
            {
                goto label_159;
            }
            
            goto label_245;
            label_157:
            if(val_48 == 0)
            {
                goto label_161;
            }
            
            label_159:
            val_47 = 0;
            val_48 = 0;
            goto label_245;
            label_161:
            val_47 = 0;
            val_46 = 0;
            label_245:
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_44);
            }
            
            if(val_46 != 1)
            {
                    if(val_48 == 0)
            {
                    return;
            }
            
                if(val_45 == 602)
            {
                    return;
            }
            
                return;
            }
            
            if(val_48 != 0)
            {
                    return;
            }
            
            return;
            label_103:
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                goto label_223;
            }
            
            goto label_224;
        }
        public void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            GooglePlayGames.Android.AndroidRealTimeMultiplayerClient val_6 = this;
            AndroidRealTimeMultiplayerClient.<>c__DisplayClass13_0 val_1 = new AndroidRealTimeMultiplayerClient.<>c__DisplayClass13_0();
            if(val_1 != null)
            {
                    .<>4__this = val_6;
            }
            else
            {
                    mem[16] = val_6;
            }
            
            .variant = variant;
            .listenerOnGameThread = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener(listener:  listener);
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  this.mSessionLock, lockTaken: ref  val_3);
            if(this.GetRoomStatus() == 3)
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "Received attempt to create a new room without cleaning up the old one.");
                (AndroidRealTimeMultiplayerClient.<>c__DisplayClass13_0)[1152921541794194448].listenerOnGameThread.OnRoomConnected(success:  false);
            }
            else
            {
                    val_6 = null;
                val_6 = new System.Action<GooglePlayGames.BasicApi.UIStatus, InvitationResultHolder>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass13_0::<CreateWithInvitationScreen>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder result));
                GooglePlayGames.Android.AndroidHelperFragment.ShowRtmpSelectOpponentsUI(minOpponents:  minOpponents, maxOpponents:  maxOpponents, cb:  null);
            }
            
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.mSessionLock);
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(114 == 114)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        private float GetPercentComplete()
        {
            float val_4 = (float)System.Math.Max(val1:  1, val2:  this.GetConnectedParticipants().Count);
            val_4 = val_4 * 100f;
            float val_5 = (float)this.mMinPlayersToStart;
            val_5 = val_4 / val_5;
            return System.Math.Min(val1:  val_5, val2:  100f);
        }
        public void ShowWaitingRoomUI()
        {
            if(this.GetRoomStatus() > 2)
            {
                    return;
            }
            
            GooglePlayGames.Android.AndroidHelperFragment.ShowWaitingRoomUI(room:  this.mRoom, minParticipantsToStart:  this.mMinPlayersToStart, cb:  new System.Action<WaitingRoomUIStatus, UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void GooglePlayGames.Android.AndroidRealTimeMultiplayerClient::<ShowWaitingRoomUI>b__15_0(GooglePlayGames.Android.AndroidHelperFragment.WaitingRoomUIStatus response, UnityEngine.AndroidJavaObject room)));
        }
        public void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback)
        {
            var val_16;
            System.Action<T> val_17;
            UnityEngine.AndroidJavaObject val_18;
            var val_19;
            AndroidRealTimeMultiplayerClient.<>c__DisplayClass16_0 val_1 = new AndroidRealTimeMultiplayerClient.<>c__DisplayClass16_0();
            if(val_1 != null)
            {
                    val_16 = val_1;
                .callback = callback;
                val_17 = GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.Multiplayer.Invitation[]>(toConvert:  callback);
            }
            else
            {
                    val_16 = 16;
                mem[16] = callback;
                val_17 = GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.ToOnGameThread<GooglePlayGames.BasicApi.Multiplayer.Invitation[]>(toConvert:  mem[16]);
            }
            
            mem[16] = val_17;
            val_18 = this.mInvitationsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadInvitations", args:  System.Array.Empty<System.Object>());
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass16_0::<GetAllInvitations>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_18, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass16_0::<GetAllInvitations>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_18, callback:  null);
            val_19 = 0;
            if(val_18 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_18.Dispose();
            }
            
            if(val_19 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_18 = ???;
            val_19 = ???;
        }
        public void AcceptFromInbox(GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener val_6 = listener;
            AndroidRealTimeMultiplayerClient.<>c__DisplayClass17_0 val_1 = new AndroidRealTimeMultiplayerClient.<>c__DisplayClass17_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .listener = val_6;
            }
            else
            {
                    mem[16] = this;
                mem[32] = val_6;
                val_6 = mem[32];
            }
            
            .listenerOnGameThread = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener(listener:  val_6);
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  this.mSessionLock, lockTaken: ref  val_3);
            if(this.GetRoomStatus() == 3)
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "Received attempt to accept invitation without cleaning up active session.");
                (AndroidRealTimeMultiplayerClient.<>c__DisplayClass17_0)[1152921541794880384].listenerOnGameThread.OnRoomConnected(success:  false);
            }
            else
            {
                    System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.Invitation> val_5 = new System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.Invitation>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass17_0::<AcceptFromInbox>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.Invitation invitation));
                GooglePlayGames.Android.AndroidHelperFragment.ShowInvitationInboxUI(cb:  null);
            }
            
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.mSessionLock);
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(116 == 116)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        public void AcceptInvitation(string invitationId, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
        {
            AndroidRealTimeMultiplayerClient.<>c__DisplayClass18_0 val_1 = new AndroidRealTimeMultiplayerClient.<>c__DisplayClass18_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[24] = this;
            }
            
            .invitationId = invitationId;
            .listenerOnGameThread = new AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener(listener:  listener);
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  this.mSessionLock, lockTaken: ref  val_3);
            if(this.GetRoomStatus() == 3)
            {
                    GooglePlayGames.OurUtils.Logger.e(msg:  "Received attempt to accept invitation without cleaning up active session.");
                (AndroidRealTimeMultiplayerClient.<>c__DisplayClass18_0)[1152921541795069184].listenerOnGameThread.OnRoomConnected(success:  false);
            }
            else
            {
                    System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass18_0::<AcceptInvitation>b__0(bool fail));
                System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> val_6 = new System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass18_0::<AcceptInvitation>b__1(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation));
                this.FindInvitation(invitationId:  (AndroidRealTimeMultiplayerClient.<>c__DisplayClass18_0)[1152921541795069184].invitationId, fail:  null, callback:  null);
            }
            
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.mSessionLock);
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(130 == 130)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        public void SendMessageToAll(bool reliable, byte[] data)
        {
            System.Byte[] val_12;
            System.Object[] val_13;
            val_12 = data;
            val_13 = reliable;
            if(val_13 == false)
            {
                goto label_1;
            }
            
            val_13 = this.GetConnectedParticipants();
            List.Enumerator<T> val_2 = val_13.GetEnumerator();
            label_5:
            if(((-1466267672) & 1) == 0)
            {
                goto label_3;
            }
            
            this.SendMessage(reliable:  true, participantId:  0.丐丏七丌丕丗业且上().ParticipantId, data:  val_12);
            goto label_5;
            label_1:
            if((this.GetRoomStatus() & 4294967294) != 2)
            {
                goto label_6;
            }
            
            object[] val_9 = new object[2];
            val_13 = val_9;
            val_13[0] = val_12;
            val_13[1] = this.mRoom.Call<System.String>(methodName:  "getRoomId", args:  System.Array.Empty<System.Object>());
            val_12 = this.mRtmpClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "sendUnreliableMessageToOthers", args:  val_9);
            if(val_12 == null)
            {
                    return;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_20;
            label_6:
            GooglePlayGames.OurUtils.Logger.d(msg:  "Sending message is not allowed in this state.");
            return;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return;
            label_20:
            val_12.Dispose();
        }
        public void SendMessageToAll(bool reliable, byte[] data, int offset, int length)
        {
            this.SendMessageToAll(reliable:  reliable, data:  GooglePlayGames.OurUtils.Misc.GetSubsetBytes(array:  data, offset:  offset, length:  length));
        }
        public void SendMessage(bool reliable, string participantId, byte[] data)
        {
            System.Object[] val_12;
            var val_13;
            var val_15;
            var val_16;
            if((this.GetRoomStatus() & 4294967294) != 2)
            {
                goto label_1;
            }
            
            if((this.GetParticipant(participantId:  participantId)) == null)
            {
                goto label_2;
            }
            
            string val_5 = this.mRoom.Call<System.String>(methodName:  "getRoomId", args:  System.Array.Empty<System.Object>());
            if(reliable == false)
            {
                goto label_4;
            }
            
            object[] val_6 = new object[4];
            val_12 = val_6;
            val_12[0] = data;
            val_12[1] = val_5;
            val_12[2] = participantId;
            val_13 = this.mRtmpClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "sendReliableMessage", args:  val_6);
            if(val_13 == null)
            {
                    return;
            }
            
            val_15 = null;
            var val_12 = 0;
            val_16 = 1152921504829939720;
            val_12 = val_12 + 1;
            goto label_40;
            label_1:
            GooglePlayGames.OurUtils.Logger.d(msg:  "Sending message is not allowed in this state.");
            return;
            label_2:
            GooglePlayGames.OurUtils.Logger.e(msg:  "Attempted to send message to unknown participant " + participantId);
            return;
            label_4:
            object[] val_9 = new object[3];
            val_12 = val_9;
            val_12[0] = data;
            val_12[1] = val_5;
            val_12[2] = participantId;
            val_13 = this.mRtmpClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "sendUnreliableMessage", args:  val_9);
            if(val_13 == null)
            {
                    return;
            }
            
            val_15 = null;
            var val_13 = 0;
            val_16 = 1152921504829939720;
            val_13 = val_13 + 1;
            label_40:
            val_13.Dispose();
        }
        public void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length)
        {
            this.SendMessage(reliable:  reliable, participantId:  participantId, data:  GooglePlayGames.OurUtils.Misc.GetSubsetBytes(array:  data, offset:  offset, length:  length));
        }
        public System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetConnectedParticipants()
        {
            System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> val_1 = new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
            List.Enumerator<T> val_3 = this.GetParticipantList().GetEnumerator();
            label_6:
            if(((-1465155528) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            if(val_4.IsConnectedToRoom == false)
            {
                goto label_6;
            }
            
            val_1.Add(item:  val_4);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        private System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetParticipantList()
        {
            UnityEngine.AndroidJavaObject val_11;
            var val_12;
            var val_13;
            var val_14;
            val_11 = this.mRoom;
            if(val_11 == null)
            {
                    return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
            }
            
            UnityEngine.AndroidJavaObject val_3 = this.mRoom.Call<UnityEngine.AndroidJavaObject>(methodName:  "getParticipants", args:  System.Array.Empty<System.Object>());
            if((val_3.Call<System.Int32>(methodName:  "size", args:  System.Array.Empty<System.Object>())) >= 1)
            {
                    object val_14 = 0;
                val_12 = 0;
                var val_11 = 0;
            }
            else
            {
                    val_11 = 0;
                val_13 = 0;
                val_14 = 1;
                if(val_3 == null)
            {
                
            }
            else
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_3.Dispose();
            }
            
                if(val_11 != 1)
            {
                    if( == null)
            {
                    return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
            }
            
                if((1152921541796628016 + ((0 + 1)) << 2) == 138)
            {
                    return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
            }
            
                return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
            }
            
                if( != null)
            {
                    return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
            }
            
                return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
            }
        
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant GetSelf()
        {
            var val_4;
            var val_11;
            var val_12;
            val_11 = this;
            List.Enumerator<T> val_2 = this.GetParticipantList().GetEnumerator();
            label_9:
            if(((-1464677376) & 1) == 0)
            {
                goto label_2;
            }
            
            val_12 = val_4.丐丏七丌丕丗业且上();
            if((val_12.Player == null) || ((val_12.Player.id.Equals(value:  this.mAndroidClient.GetUserId())) == false))
            {
                goto label_9;
            }
            
            goto label_10;
            label_2:
            val_12 = 0;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_12;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId)
        {
            object val_6;
            var val_7;
            val_6 = participantId;
            if(this.GetRoomStatus() == 3)
            {
                    object[] val_2 = new object[1];
                val_2[0] = val_6;
                val_6 = this.mRoom.Call<UnityEngine.AndroidJavaObject>(methodName:  "getParticipant", args:  val_2);
                val_7 = GooglePlayGames.Android.AndroidJavaConverter.ToParticipant(participant:  val_6);
                if(val_6 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_6.Dispose();
            }
            
                if(0 != 1)
            {
                    if(63 == 63)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_7;
            }
            
            }
            
                if(0 != 0)
            {
                    val_7 = 0;
                return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_7;
            }
            
            }
            
            val_7 = 0;
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_7;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Invitation GetInvitation()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.Invitation)this.mInvitation;
        }
        public void LeaveRoom()
        {
            if(this.GetRoomStatus() == 1)
            {
                    return;
            }
            
            object[] val_2 = new object[2];
            val_2[0] = this.mRoomConfig;
            val_2[1] = this.mRoom.Call<System.String>(methodName:  "getRoomId", args:  System.Array.Empty<System.Object>());
            UnityEngine.AndroidJavaObject val_5 = this.mRtmpClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "leave", args:  val_2);
            if(val_5 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_5.Dispose();
            }
            
            if(this.mListener != null)
            {
                    this.mListener.OnRoomConnected(success:  false);
            }
            
            this.CleanSession();
        }
        public bool IsRoomConnected()
        {
            return (bool)(this.GetRoomStatus() == 3) ? 1 : 0;
        }
        private GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.RoomStatus GetRoomStatus()
        {
            if(this.mRoom == null)
            {
                    return 0;
            }
            
            return this.mRoom.Call<System.Int32>(methodName:  "getStatus", args:  System.Array.Empty<System.Object>());
        }
        public void DeclineInvitation(string invitationId)
        {
            string val_4;
            var val_5;
            System.Action<System.Boolean> val_7;
            val_4 = invitationId;
            AndroidRealTimeMultiplayerClient.<>c__DisplayClass31_0 val_1 = new AndroidRealTimeMultiplayerClient.<>c__DisplayClass31_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .invitationId = val_4;
            }
            else
            {
                    mem[16] = this;
                mem[24] = val_4;
                val_4 = mem[24];
            }
            
            val_5 = null;
            val_5 = null;
            val_7 = AndroidRealTimeMultiplayerClient.<>c.<>9__31_0;
            if(val_7 == null)
            {
                    System.Action<System.Boolean> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Action<System.Boolean>(object:  AndroidRealTimeMultiplayerClient.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AndroidRealTimeMultiplayerClient.<>c::<DeclineInvitation>b__31_0(bool fail));
                AndroidRealTimeMultiplayerClient.<>c.<>9__31_0 = val_7;
            }
            
            this.FindInvitation(invitationId:  val_4, fail:  val_2, callback:  new System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass31_0::<DeclineInvitation>b__1(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation)));
        }
        private void FindInvitation(string invitationId, System.Action<bool> fail, System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> callback)
        {
            UnityEngine.AndroidJavaObject val_14;
            var val_15;
            AndroidRealTimeMultiplayerClient.<>c__DisplayClass32_0 val_1 = new AndroidRealTimeMultiplayerClient.<>c__DisplayClass32_0();
            if(val_1 != null)
            {
                    .invitationId = invitationId;
                .callback = callback;
            }
            else
            {
                    mem[16] = invitationId;
                mem[24] = callback;
            }
            
            .fail = fail;
            val_14 = this.mInvitationsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadInvitations", args:  System.Array.Empty<System.Object>());
            System.Action<UnityEngine.AndroidJavaObject> val_4 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass32_0::<FindInvitation>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_14, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_5 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidRealTimeMultiplayerClient.<>c__DisplayClass32_0::<FindInvitation>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_14, callback:  null);
            val_15 = 0;
            if(val_14 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_14.Dispose();
            }
            
            if(val_15 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_14 = ???;
            val_15 = ???;
        }
        private void CleanSession()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.mSessionLock, lockTaken: ref  val_1);
            this.mMinPlayersToStart = 0;
            this.mListener = 0;
            this.mRoom = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.mSessionLock);
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
        private static System.Action<T> ToOnGameThread<T>(System.Action<T> toConvert)
        {
            mem2[0] = toConvert;
            if(((__RuntimeMethodHiddenParam + 48 + 24 + 294) & 1) != 0)
            {
                    return (System.Action<T>)__RuntimeMethodHiddenParam + 48 + 24;
            }
            
            return (System.Action<T>)__RuntimeMethodHiddenParam + 48 + 24;
        }
        private void <ShowWaitingRoomUI>b__15_0(GooglePlayGames.Android.AndroidHelperFragment.WaitingRoomUIStatus response, UnityEngine.AndroidJavaObject room)
        {
            if(response == 3)
            {
                goto label_0;
            }
            
            if(response != 1)
            {
                goto label_1;
            }
            
            this.mRoom = room;
            if(this.GetRoomStatus() != 3)
            {
                    return;
            }
            
            this.mListener.OnRoomConnected(success:  true);
            return;
            label_0:
            this.LeaveRoom();
            return;
            label_1:
            this.mListener.OnRoomSetupProgress(percent:  this.GetPercentComplete());
        }
    
    }

}
