using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidEventsClient : IEventsClient
    {
        // Fields
        private UnityEngine.AndroidJavaObject mEventsClient;
        
        // Methods
        public AndroidEventsClient(UnityEngine.AndroidJavaObject account)
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
            this.mEventsClient = val_1.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getEventsClient", args:  val_2);
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
        public void FetchAllEvents(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>> callback)
        {
            var val_10;
            System.Action<T1, T2> val_11;
            AndroidEventsClient.<>c__DisplayClass2_0 val_1 = new AndroidEventsClient.<>c__DisplayClass2_0();
            if(val_1 != null)
            {
                    val_10 = val_1;
                .callback = callback;
                val_11 = GooglePlayGames.Android.AndroidEventsClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>>(toConvert:  callback);
            }
            else
            {
                    val_10 = 16;
                mem[16] = callback;
                val_11 = GooglePlayGames.Android.AndroidEventsClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>>(toConvert:  mem[16]);
            }
            
            mem[16] = val_11;
            object[] val_4 = new object[1];
            var val_5 = (source == 1) ? 1 : 0;
            val_4[0] = ;
            UnityEngine.AndroidJavaObject val_6 = this.mEventsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "load", args:  val_4);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidEventsClient.<>c__DisplayClass2_0::<FetchAllEvents>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_6, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidEventsClient.<>c__DisplayClass2_0::<FetchAllEvents>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_6, callback:  null);
            if(val_6 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_6.Dispose();
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
        public void FetchEvent(GooglePlayGames.BasicApi.DataSource source, string eventId, System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent> callback)
        {
            var val_11;
            System.Action<T1, T2> val_12;
            AndroidEventsClient.<>c__DisplayClass3_0 val_1 = new AndroidEventsClient.<>c__DisplayClass3_0();
            if(val_1 != null)
            {
                    val_11 = val_1;
                .callback = callback;
                val_12 = GooglePlayGames.Android.AndroidEventsClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent>(toConvert:  callback);
            }
            else
            {
                    val_11 = 16;
                mem[16] = callback;
                val_12 = GooglePlayGames.Android.AndroidEventsClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent>(toConvert:  mem[16]);
            }
            
            mem[16] = val_12;
            string[] val_4 = new string[1];
            val_4[0] = eventId;
            object[] val_5 = new object[2];
            val_5[0] = (source == 1) ? 1 : 0;
            val_5[1] = val_4;
            UnityEngine.AndroidJavaObject val_7 = this.mEventsClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "loadByIds", args:  val_5);
            System.Action<UnityEngine.AndroidJavaObject> val_8 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidEventsClient.<>c__DisplayClass3_0::<FetchEvent>b__0(UnityEngine.AndroidJavaObject annotatedData));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_7, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_9 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidEventsClient.<>c__DisplayClass3_0::<FetchEvent>b__1(UnityEngine.AndroidJavaObject exception));
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
        public void IncrementEvent(string eventId, uint stepsToIncrement)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(eventId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(eventId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = eventId;
            val_1[1] = stepsToIncrement;
            this.mEventsClient.Call(methodName:  "increment", args:  val_1);
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
        private static GooglePlayGames.BasicApi.Events.Event CreateEvent(UnityEngine.AndroidJavaObject eventJava)
        {
            return (GooglePlayGames.BasicApi.Events.Event)new GooglePlayGames.BasicApi.Events.Event(id:  eventJava.Call<System.String>(methodName:  "getEventId", args:  System.Array.Empty<System.Object>()), name:  eventJava.Call<System.String>(methodName:  "getName", args:  System.Array.Empty<System.Object>()), description:  eventJava.Call<System.String>(methodName:  "getDescription", args:  System.Array.Empty<System.Object>()), imageUrl:  eventJava.Call<System.String>(methodName:  "getIconImageUrl", args:  System.Array.Empty<System.Object>()), currentCount:  eventJava.Call<System.Int64>(methodName:  "getValue", args:  System.Array.Empty<System.Object>()), visibility:  ((eventJava.Call<System.Boolean>(methodName:  "isVisible", args:  System.Array.Empty<System.Object>())) != true) ? (1 + 1) : 1);
        }
    
    }

}
