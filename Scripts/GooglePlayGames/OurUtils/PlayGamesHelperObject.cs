using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public class PlayGamesHelperObject : MonoBehaviour
    {
        // Fields
        private static GooglePlayGames.OurUtils.PlayGamesHelperObject instance;
        private static bool sIsDummy;
        private static System.Collections.Generic.List<System.Action> sQueue;
        private System.Collections.Generic.List<System.Action> localQueue;
        private static bool sQueueEmpty;
        private static System.Collections.Generic.List<System.Action<bool>> sPauseCallbackList;
        private static System.Collections.Generic.List<System.Action<bool>> sFocusCallbackList;
        
        // Methods
        public static void CreateObject()
        {
            var val_6;
            GooglePlayGames.OurUtils.PlayGamesHelperObject val_7;
            var val_8;
            var val_9;
            val_6 = null;
            val_6 = null;
            val_7 = GooglePlayGames.OurUtils.PlayGamesHelperObject.instance;
            if(val_7 != 0)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "PlayGames_QueueRunner");
                UnityEngine.Object.DontDestroyOnLoad(target:  val_3);
                val_8 = null;
                val_7 = val_3.AddComponent<GooglePlayGames.OurUtils.PlayGamesHelperObject>();
                val_8 = null;
                GooglePlayGames.OurUtils.PlayGamesHelperObject.instance = val_7;
                return;
            }
            
            GooglePlayGames.OurUtils.PlayGamesHelperObject val_5 = null;
            val_7 = val_5;
            val_5 = new GooglePlayGames.OurUtils.PlayGamesHelperObject();
            val_9 = null;
            val_9 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.instance = val_7;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sIsDummy = true;
        }
        public void Awake()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        public void OnDisable()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.instance != this)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.instance = 0;
        }
        public static void RunCoroutine(System.Collections.IEnumerator action)
        {
            var val_4;
            .action = action;
            val_4 = null;
            val_4 = null;
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.instance == 0)
            {
                    return;
            }
            
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  new PlayGamesHelperObject.<>c__DisplayClass10_0(), method:  System.Void PlayGamesHelperObject.<>c__DisplayClass10_0::<RunCoroutine>b__0()));
        }
        public static void RunOnGameThread(System.Action action)
        {
            System.Collections.Generic.List<System.Action> val_3;
            var val_4;
            var val_6;
            if(action == null)
            {
                goto label_1;
            }
            
            val_4 = null;
            val_4 = null;
            bool val_3 = GooglePlayGames.OurUtils.PlayGamesHelperObject.sIsDummy;
            val_3 = val_3 + 7;
            var val_4 = ~val_3;
            val_4 = val_4 & 7;
            if(val_4 != 0)
            {
                    return;
            }
            
            val_3 = GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  val_3, lockTaken: ref  val_1);
            val_6 = null;
            val_6 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue.Add(item:  action);
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueueEmpty = false;
            label_15:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_3);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            return;
            label_1:
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "action");
            if(0 != 1)
            {
                goto label_14;
            }
            
            goto label_15;
            label_14:
        }
        public void Update()
        {
            var val_5;
            var val_6;
            var val_8;
            var val_9;
            var val_10;
            val_5 = 1152921505392095232;
            val_6 = null;
            val_6 = null;
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.sIsDummy == true)
            {
                    return;
            }
            
            var val_5 = ~(GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueueEmpty + 7);
            val_5 = val_5 & 7;
            if(val_5 != 0)
            {
                    return;
            }
            
            this.localQueue.Clear();
            val_8 = null;
            val_8 = null;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue, lockTaken: ref  val_2);
            val_9 = null;
            val_9 = null;
            this.localQueue.AddRange(collection:  GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue);
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue.Clear();
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueueEmpty = true;
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue);
            }
            
            val_5 = 1152921516621076256;
            val_10 = 0;
            goto label_17;
            label_21:
            this.localQueue.Item[0].Invoke();
            val_10 = 1;
            label_17:
            if(val_10 < this.localQueue.Count)
            {
                goto label_21;
            }
        
        }
        public void OnApplicationFocus(bool focused)
        {
            var val_3;
            var val_7;
            bool val_8;
            val_7 = null;
            val_7 = null;
            List.Enumerator<T> val_1 = GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.GetEnumerator();
            val_8 = focused;
            label_12:
            if(((-1404863456) & 1) == 0)
            {
                goto label_4;
            }
            
            val_3.丐丏七丌丕丗业且上().Invoke(obj:  val_8);
            goto label_12;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public void OnApplicationPause(bool paused)
        {
            var val_3;
            var val_7;
            bool val_8;
            val_7 = null;
            val_7 = null;
            List.Enumerator<T> val_1 = GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.GetEnumerator();
            val_8 = paused;
            label_12:
            if(((-1404734928) & 1) == 0)
            {
                goto label_4;
            }
            
            val_3.丐丏七丌丕丗业且上().Invoke(obj:  val_8);
            goto label_12;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public static void AddFocusCallback(System.Action<bool> callback)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.Contains(item:  callback)) != false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.Add(item:  callback);
        }
        public static bool RemoveFocusCallback(System.Action<bool> callback)
        {
            null = null;
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList != null)
            {
                    return GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.Remove(item:  callback);
            }
            
            return GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.Remove(item:  callback);
        }
        public static void AddPauseCallback(System.Action<bool> callback)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.Contains(item:  callback)) != false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.Add(item:  callback);
        }
        public static bool RemovePauseCallback(System.Action<bool> callback)
        {
            null = null;
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList != null)
            {
                    return GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.Remove(item:  callback);
            }
            
            return GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.Remove(item:  callback);
        }
        public PlayGamesHelperObject()
        {
            this.localQueue = new System.Collections.Generic.List<System.Action>();
        }
        private static PlayGamesHelperObject()
        {
            GooglePlayGames.OurUtils.PlayGamesHelperObject.instance = 0;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sIsDummy = false;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue = new System.Collections.Generic.List<System.Action>();
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueueEmpty = true;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList = new System.Collections.Generic.List<System.Action<System.Boolean>>();
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList = new System.Collections.Generic.List<System.Action<System.Boolean>>();
        }
    
    }

}
