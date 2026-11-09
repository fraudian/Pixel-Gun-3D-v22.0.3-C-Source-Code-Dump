using UnityEngine;

namespace GooglePlayGames.Android
{
    public class AndroidNearbyConnectionClient : INearbyConnectionClient
    {
        // Fields
        private UnityEngine.AndroidJavaObject mClient;
        private static readonly long NearbyClientId;
        private static readonly int ApplicationInfoFlags;
        private static readonly string ServiceId;
        protected GooglePlayGames.BasicApi.Nearby.IMessageListener mAdvertisingMessageListener;
        
        // Methods
        public AndroidNearbyConnectionClient()
        {
            var val_13;
            var val_14;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.CreateObject();
            GooglePlayGames.OurUtils.NearbyHelperObject.CreateObject(client:  this);
            UnityEngine.AndroidJavaClass val_1 = null;
            val_13 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.nearby.Nearby");
            object[] val_2 = new object[1];
            val_2[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_14 = 0;
            this.mClient = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getConnectionsClient", args:  val_2);
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
        public int MaxUnreliableMessagePayloadLength()
        {
            return 1168;
        }
        public int MaxReliableMessagePayloadLength()
        {
            return 4096;
        }
        public void SendReliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            this.InternalSend(recipientEndpointIds:  recipientEndpointIds, payload:  payload);
        }
        public void SendUnreliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            this.InternalSend(recipientEndpointIds:  recipientEndpointIds, payload:  payload);
        }
        private void InternalSend(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            var val_20;
            System.Object[] val_21;
            var val_22;
            var val_24;
            var val_26;
            System.Collections.Generic.List<System.String> val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Collections.Generic.List<System.String>>(value:  recipientEndpointIds);
            System.Byte[] val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Byte[]>(value:  payload);
            UnityEngine.AndroidJavaClass val_3 = null;
            val_20 = val_3;
            val_3 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.nearby.connection.Payload");
            object[] val_4 = new object[1];
            val_4[0] = payload;
            UnityEngine.AndroidJavaObject val_5 = val_3.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "fromBytes", args:  val_4);
            object[] val_6 = new object[2];
            val_21 = val_6;
            val_21[0] = GooglePlayGames.Android.AndroidJavaConverter.ToJavaStringList(list:  recipientEndpointIds);
            val_21[1] = val_5;
            val_22 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "sendPayload", args:  val_6);
            if(val_22 == null)
            {
                goto label_14;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_18;
            label_14:
            val_24 = 0;
            if(val_5 != null)
            {
                goto label_19;
            }
            
            goto label_21;
            label_18:
            val_22.Dispose();
            val_24 = 0;
            val_22 = 0;
            if(val_5 == null)
            {
                goto label_21;
            }
            
            label_19:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_5.Dispose();
            label_21:
            if(val_24 == 1)
            {
                goto label_26;
            }
            
            val_26 = val_22;
            if(val_20 != null)
            {
                goto label_27;
            }
            
            goto label_30;
            label_26:
            if(val_22 != 0)
            {
                    val_22 = 0;
            }
            
            val_26 = 0;
            val_24 = 0;
            if(val_20 == null)
            {
                goto label_30;
            }
            
            label_27:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_3.Dispose();
            label_30:
            if(val_24 != 1)
            {
                    return;
            }
            
            if(val_26 == 0)
            {
                    return;
            }
            
            val_20 = ???;
            val_22 = ???;
            val_21 = ???;
        }
        public void StartAdvertising(string name, System.Collections.Generic.List<string> appIdentifiers, System.Nullable<System.TimeSpan> advertisingDuration, System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback)
        {
            var val_19;
            var val_20;
            var val_22;
            var val_25;
            var val_26;
            .advertisingDuration = advertisingDuration;
            mem[1152921541783317912] = resultCallback;
            System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult>>(value:  connectionRequestCallback, paramName:  "resultCallback");
            System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest>>(value:  X6, paramName:  "connectionRequestCallback");
            if((1152921541783317904 & 1) != 0)
            {
                    if(((1152921541783317904.System.IConvertible.ToInt64(provider:  0)) & 9223372036854775808) != 0)
            {
                goto label_5;
            }
            
            }
            
            object[] val_8 = new object[1];
            val_8[0] = new AndroidNearbyConnectionClient.AdvertisingConnectionLifecycleCallbackProxy(resultCallback:  GooglePlayGames.Android.AndroidNearbyConnectionClient.ToOnGameThread<GooglePlayGames.BasicApi.Nearby.AdvertisingResult>(toConvert:  connectionRequestCallback), connectionRequestCallback:  GooglePlayGames.Android.AndroidNearbyConnectionClient.ToOnGameThread<GooglePlayGames.BasicApi.Nearby.ConnectionRequest>(toConvert:  X6), client:  this);
            UnityEngine.AndroidJavaObject val_9 = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.ConnectionLifecycleCallbackProxy", args:  val_8);
            UnityEngine.AndroidJavaObject val_10 = val_9.CreateAdvertisingOptions();
            object[] val_11 = new object[4];
            val_11[0] = name;
            val_11[1] = name.GetServiceId();
            val_11[2] = val_9;
            val_11[3] = val_10;
            UnityEngine.AndroidJavaObject val_13 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "startAdvertising", args:  val_11);
            System.Action<UnityEngine.AndroidJavaObject> val_14 = new System.Action<UnityEngine.AndroidJavaObject>(object:  new AndroidNearbyConnectionClient.<>c__DisplayClass11_0(), method:  System.Void AndroidNearbyConnectionClient.<>c__DisplayClass11_0::<StartAdvertising>b__0(UnityEngine.AndroidJavaObject v));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_13, callback:  null);
            val_19 = 0;
            val_20 = 0;
            if(val_13 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_13.Dispose();
            }
            
            if(val_19 == 1)
            {
                goto label_31;
            }
            
            label_68:
            val_22 = val_20;
            if(val_10 != null)
            {
                goto label_32;
            }
            
            goto label_35;
            label_31:
            if(val_20 != 0)
            {
                    val_20 = 0;
            }
            
            val_22 = 0;
            val_19 = 0;
            if(val_10 == null)
            {
                goto label_35;
            }
            
            label_32:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_10.Dispose();
            label_35:
            if(val_19 == 1)
            {
                goto label_40;
            }
            
            if(val_9 == null)
            {
                goto label_71;
            }
            
            label_70:
            var val_21 = 0;
            val_21 = val_21 + 1;
            goto label_45;
            label_40:
            if(val_22 == 0)
            {
                goto label_46;
            }
            
            val_20 = 0;
            val_22 = 0;
            val_19 = 0;
            if(val_9 != null)
            {
                goto label_70;
            }
            
            goto label_71;
            label_45:
            val_9.Dispose();
            label_71:
            if(val_19 != 1)
            {
                    return;
            }
            
            if(val_22 == 0)
            {
                    return;
            }
            
            return;
            label_46:
            if(val_9 != null)
            {
                goto label_70;
            }
            
            goto label_71;
            label_5:
            System.InvalidOperationException val_18 = new System.InvalidOperationException(message:  "advertisingDuration must be positive");
            val_25 = 0;
            val_26 = val_18;
            if(val_25 != 1)
            {
                goto label_67;
            }
            
            goto label_68;
            label_67:
            if( != 1)
            {
                goto label_69;
            }
            
            if(val_18 != null)
            {
                goto label_70;
            }
            
            goto label_71;
            label_69:
        }
        private UnityEngine.AndroidJavaObject CreateAdvertisingOptions()
        {
            var val_12;
            var val_13;
            var val_15;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.nearby.connection.Strategy").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "P2P_CLUSTER");
            new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "com.google.android.gms.nearby.connection.AdvertisingOptions$Builder", args:  System.Array.Empty<System.Object>());
            object[] val_5 = new object[1];
            val_5[0] = val_2;
            UnityEngine.AndroidJavaObject val_6 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "setStrategy", args:  val_5);
            val_12 = 0;
            val_13 = 0;
            if(val_6 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_6.Dispose();
            }
            
            if(val_12 == 1)
            {
                goto label_13;
            }
            
            val_15 = val_13;
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(val_13 != 0)
            {
                    val_13 = 0;
            }
            
            val_15 = 0;
            val_12 = 0;
            if(new UnityEngine.AndroidJavaObject() == null)
            {
                goto label_17;
            }
            
            label_14:
            var val_13 = 0;
            val_13 = val_13 + 1;
            new UnityEngine.AndroidJavaObject().Dispose();
            label_17:
            if(val_12 == 1)
            {
                goto label_22;
            }
            
            if(val_2 == null)
            {
                goto label_51;
            }
            
            label_50:
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_27;
            label_22:
            if(val_15 == 0)
            {
                goto label_28;
            }
            
            val_13 = 0;
            val_15 = 0;
            val_12 = 0;
            if(val_2 != null)
            {
                goto label_50;
            }
            
            goto label_51;
            label_27:
            val_2.Dispose();
            label_51:
            if(val_12 != 1)
            {
                    return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            if(val_15 == 0)
            {
                    return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            label_28:
            if(val_2 != null)
            {
                goto label_50;
            }
            
            goto label_51;
        }
        public void StopAdvertising()
        {
            this.mClient.Call(methodName:  "stopAdvertising", args:  System.Array.Empty<System.Object>());
            this.mAdvertisingMessageListener = 0;
        }
        public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            object val_19;
            System.Object[] val_20;
            var val_21;
            var val_23;
            GooglePlayGames.BasicApi.Nearby.IMessageListener val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IMessageListener>(value:  listener, paramName:  "listener");
            object[] val_4 = new object[1];
            val_4[0] = new AndroidNearbyConnectionClient.DiscoveringConnectionLifecycleCallback(responseCallback:  responseCallback, listener:  new AndroidNearbyConnectionClient.OnGameThreadMessageListener(listener:  listener), client:  this.mClient);
            UnityEngine.AndroidJavaObject val_5 = null;
            val_19 = val_5;
            val_5 = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.ConnectionLifecycleCallbackProxy", args:  val_4);
            object[] val_6 = new object[3];
            val_20 = val_6;
            val_20[0] = name;
            val_20[1] = remoteEndpointId;
            val_20[2] = val_19;
            val_21 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "requestConnection", args:  val_6);
            if(val_21 == null)
            {
                goto label_16;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            goto label_20;
            label_16:
            val_23 = 0;
            if(val_19 != null)
            {
                goto label_35;
            }
            
            goto label_36;
            label_20:
            val_21.Dispose();
            val_23 = 0;
            val_21 = 0;
            if(val_19 == null)
            {
                goto label_36;
            }
            
            label_35:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_5.Dispose();
            label_36:
            if(val_23 != 1)
            {
                    return;
            }
            
            if(val_21 == 0)
            {
                    return;
            }
            
            val_19 = ???;
            val_23 = ???;
            val_20 = ???;
        }
        public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            object val_18;
            object val_19;
            var val_20;
            var val_22;
            GooglePlayGames.BasicApi.Nearby.IMessageListener val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IMessageListener>(value:  listener, paramName:  "listener");
            this.mAdvertisingMessageListener = new AndroidNearbyConnectionClient.OnGameThreadMessageListener(listener:  listener);
            object[] val_3 = new object[1];
            AndroidNearbyConnectionClient.PayloadCallback val_4 = null;
            val_18 = val_4;
            val_4 = new AndroidNearbyConnectionClient.PayloadCallback(listener:  listener);
            val_3[0] = val_18;
            UnityEngine.AndroidJavaObject val_5 = null;
            val_19 = val_5;
            val_5 = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.PayloadCallbackProxy", args:  val_3);
            object[] val_6 = new object[2];
            val_6[0] = remoteEndpointId;
            val_6[1] = val_19;
            val_20 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "acceptConnection", args:  val_6);
            if(val_20 == null)
            {
                goto label_13;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_17;
            label_13:
            val_22 = 0;
            if(val_19 != null)
            {
                goto label_31;
            }
            
            goto label_32;
            label_17:
            val_20.Dispose();
            val_22 = 0;
            val_20 = 0;
            if(val_19 == null)
            {
                goto label_32;
            }
            
            label_31:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_5.Dispose();
            label_32:
            if(val_22 != 1)
            {
                    return;
            }
            
            if(val_20 == 0)
            {
                    return;
            }
            
            val_19 = ???;
            val_22 = ???;
            val_18 = ???;
        }
        public void StartDiscovery(string serviceId, System.Nullable<System.TimeSpan> advertisingDuration, GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
        {
            var val_17;
            var val_18;
            var val_20;
            var val_23;
            var val_24;
            .advertisingDuration = advertisingDuration;
            mem[1152921541784630648] = listener;
            string val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.String>(value:  serviceId, paramName:  "serviceId");
            GooglePlayGames.BasicApi.Nearby.IDiscoveryListener val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.Nearby.IDiscoveryListener>(value:  X4, paramName:  "listener");
            .mListener = X4;
            if((1152921541784630640 & 1) != 0)
            {
                    if(((1152921541784630640.System.IConvertible.ToInt64(provider:  0)) & 9223372036854775808) != 0)
            {
                goto label_5;
            }
            
            }
            
            object[] val_6 = new object[1];
            val_6[0] = new AndroidNearbyConnectionClient.EndpointDiscoveryCallback(listener:  new AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener());
            UnityEngine.AndroidJavaObject val_8 = new UnityEngine.AndroidJavaObject(className:  "com.google.games.bridge.EndpointDiscoveryCallbackProxy", args:  val_6);
            UnityEngine.AndroidJavaObject val_9 = val_8.CreateDiscoveryOptions();
            object[] val_10 = new object[3];
            val_10[0] = serviceId;
            val_10[1] = val_8;
            val_10[2] = val_9;
            UnityEngine.AndroidJavaObject val_11 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "startDiscovery", args:  val_10);
            System.Action<UnityEngine.AndroidJavaObject> val_12 = new System.Action<UnityEngine.AndroidJavaObject>(object:  new AndroidNearbyConnectionClient.<>c__DisplayClass18_0(), method:  System.Void AndroidNearbyConnectionClient.<>c__DisplayClass18_0::<StartDiscovery>b__0(UnityEngine.AndroidJavaObject v));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_11, callback:  null);
            val_17 = 0;
            val_18 = 0;
            if(val_11 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_11.Dispose();
            }
            
            if(val_17 == 1)
            {
                goto label_26;
            }
            
            label_61:
            val_20 = val_18;
            if(val_9 != null)
            {
                goto label_27;
            }
            
            goto label_30;
            label_26:
            if(val_18 != 0)
            {
                    val_18 = 0;
            }
            
            val_20 = 0;
            val_17 = 0;
            if(val_9 == null)
            {
                goto label_30;
            }
            
            label_27:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_9.Dispose();
            label_30:
            if(val_17 == 1)
            {
                goto label_35;
            }
            
            if(val_8 == null)
            {
                goto label_64;
            }
            
            label_63:
            var val_19 = 0;
            val_19 = val_19 + 1;
            goto label_40;
            label_35:
            if(val_20 == 0)
            {
                goto label_41;
            }
            
            val_18 = 0;
            val_20 = 0;
            val_17 = 0;
            if(val_8 != null)
            {
                goto label_63;
            }
            
            goto label_64;
            label_40:
            val_8.Dispose();
            label_64:
            if(val_17 != 1)
            {
                    return;
            }
            
            if(val_20 == 0)
            {
                    return;
            }
            
            return;
            label_41:
            if(val_8 != null)
            {
                goto label_63;
            }
            
            goto label_64;
            label_5:
            System.InvalidOperationException val_16 = new System.InvalidOperationException(message:  "advertisingDuration must be positive");
            val_23 = 0;
            val_24 = val_16;
            if(val_23 != 1)
            {
                goto label_60;
            }
            
            goto label_61;
            label_60:
            if( != 1)
            {
                goto label_62;
            }
            
            if(val_16 != null)
            {
                goto label_63;
            }
            
            goto label_64;
            label_62:
        }
        private UnityEngine.AndroidJavaObject CreateDiscoveryOptions()
        {
            var val_12;
            var val_13;
            var val_15;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.nearby.connection.Strategy").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "P2P_CLUSTER");
            new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "com.google.android.gms.nearby.connection.DiscoveryOptions$Builder", args:  System.Array.Empty<System.Object>());
            object[] val_5 = new object[1];
            val_5[0] = val_2;
            UnityEngine.AndroidJavaObject val_6 = new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "setStrategy", args:  val_5);
            val_12 = 0;
            val_13 = 0;
            if(val_6 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_6.Dispose();
            }
            
            if(val_12 == 1)
            {
                goto label_13;
            }
            
            val_15 = val_13;
            if(new UnityEngine.AndroidJavaObject() != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(val_13 != 0)
            {
                    val_13 = 0;
            }
            
            val_15 = 0;
            val_12 = 0;
            if(new UnityEngine.AndroidJavaObject() == null)
            {
                goto label_17;
            }
            
            label_14:
            var val_13 = 0;
            val_13 = val_13 + 1;
            new UnityEngine.AndroidJavaObject().Dispose();
            label_17:
            if(val_12 == 1)
            {
                goto label_22;
            }
            
            if(val_2 == null)
            {
                goto label_51;
            }
            
            label_50:
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_27;
            label_22:
            if(val_15 == 0)
            {
                goto label_28;
            }
            
            val_13 = 0;
            val_15 = 0;
            val_12 = 0;
            if(val_2 != null)
            {
                goto label_50;
            }
            
            goto label_51;
            label_27:
            val_2.Dispose();
            label_51:
            if(val_12 != 1)
            {
                    return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            if(val_15 == 0)
            {
                    return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject().Call<UnityEngine.AndroidJavaObject>(methodName:  "build", args:  System.Array.Empty<System.Object>());
            label_28:
            if(val_2 != null)
            {
                goto label_50;
            }
            
            goto label_51;
        }
        public void StopDiscovery(string serviceId)
        {
            this.mClient.Call(methodName:  "stopDiscovery", args:  System.Array.Empty<System.Object>());
        }
        public void RejectConnectionRequest(string requestingEndpointId)
        {
            string val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<System.String>(value:  requestingEndpointId, paramName:  "requestingEndpointId");
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(requestingEndpointId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(requestingEndpointId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = requestingEndpointId;
            UnityEngine.AndroidJavaObject val_3 = this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "rejectConnection", args:  val_2);
            if(val_3 == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3.Dispose();
        }
        public void DisconnectFromEndpoint(string remoteEndpointId)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(remoteEndpointId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(remoteEndpointId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = remoteEndpointId;
            this.mClient.Call(methodName:  "disconnectFromEndpoint", args:  val_1);
        }
        public void StopAllConnections()
        {
            this.mClient.Call(methodName:  "stopAllEndpoints", args:  System.Array.Empty<System.Object>());
            this.mAdvertisingMessageListener = 0;
        }
        public string GetAppBundleId()
        {
            UnityEngine.AndroidJavaObject val_1 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return (string)val_1.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
            }
            
            if(0 == 0)
            {
                    return (string)val_1.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
            }
            
            return (string)val_1.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
        }
        public string GetServiceId()
        {
            null = null;
            return (string)GooglePlayGames.Android.AndroidNearbyConnectionClient.ServiceId;
        }
        private static string ReadServiceId()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            var val_24;
            var val_25;
            UnityEngine.AndroidJavaObject val_1 = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            UnityEngine.AndroidJavaObject val_5 = val_1.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
            object[] val_6 = new object[2];
            val_6[0] = val_1.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.Object>());
            val_16 = null;
            val_16 = null;
            val_6[1] = GooglePlayGames.Android.AndroidNearbyConnectionClient.ApplicationInfoFlags;
            UnityEngine.AndroidJavaObject val_7 = val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "getApplicationInfo", args:  val_6);
            UnityEngine.AndroidJavaObject val_8 = val_7.Get<UnityEngine.AndroidJavaObject>(fieldName:  "metaData");
            object[] val_9 = new object[1];
            val_9[0] = "com.google.android.gms.nearby.connection.SERVICE_ID";
            string val_10 = val_8.Call<System.String>(methodName:  "getString", args:  val_9);
            UnityEngine.Debug.Log(message:  "SystemId from Manifest: "("SystemId from Manifest: ") + val_10);
            val_17 = 0;
            val_18 = 0;
            if(val_8 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_8.Dispose();
            }
            
            if(val_17 == 1)
            {
                goto label_26;
            }
            
            val_20 = val_18;
            if(val_7 != null)
            {
                goto label_27;
            }
            
            goto label_30;
            label_26:
            if(val_18 != 0)
            {
                    val_18 = 0;
            }
            
            val_20 = 0;
            val_17 = 0;
            if(val_7 == null)
            {
                goto label_30;
            }
            
            label_27:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_7.Dispose();
            label_30:
            if(val_17 == 1)
            {
                goto label_35;
            }
            
            if(val_5 != null)
            {
                goto label_83;
            }
            
            goto label_84;
            label_35:
            if(val_20 != 0)
            {
                    val_18 = 0;
                val_20 = 0;
            }
            else
            {
                    val_18 = 0;
            }
            
            val_17 = 0;
            if(val_5 == null)
            {
                goto label_84;
            }
            
            label_83:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_5.Dispose();
            label_84:
            if(val_17 == 1)
            {
                goto label_45;
            }
            
            if(val_1 == null)
            {
                goto label_87;
            }
            
            label_86:
            var val_19 = 0;
            val_19 = val_19 + 1;
            goto label_50;
            label_45:
            if(val_20 == 0)
            {
                goto label_51;
            }
            
            val_18 = 0;
            val_20 = 0;
            val_17 = 0;
            if(val_1 != null)
            {
                goto label_86;
            }
            
            goto label_87;
            label_50:
            val_1.Dispose();
            label_87:
            if(val_17 != 1)
            {
                    return val_10;
            }
            
            if(val_20 == 0)
            {
                    return val_10;
            }
            
            return val_10;
            label_51:
            if(val_1 != null)
            {
                goto label_86;
            }
            
            goto label_87;
            label_88:
            val_24 = public System.Void System.IDisposable::Dispose();
            val_25 = val_5;
            if(val_24 != 1)
            {
                goto label_82;
            }
            
            if(val_5 != null)
            {
                goto label_83;
            }
            
            goto label_84;
            label_82:
            if( != 1)
            {
                goto label_88;
            }
            
            if(val_1 != null)
            {
                goto label_86;
            }
            
            goto label_87;
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
        private static AndroidNearbyConnectionClient()
        {
            GooglePlayGames.Android.AndroidNearbyConnectionClient.NearbyClientId = 0;
            GooglePlayGames.Android.AndroidNearbyConnectionClient.ApplicationInfoFlags = 128;
            GooglePlayGames.Android.AndroidNearbyConnectionClient.ServiceId = GooglePlayGames.Android.AndroidNearbyConnectionClient.ReadServiceId();
        }
    
    }

}
