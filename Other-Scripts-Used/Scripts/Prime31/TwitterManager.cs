using UnityEngine;

namespace Prime31
{
    public class TwitterManager : MonoBehaviour
    {
        // Fields
        private static System.Action<string> loginSucceededEvent;
        private static System.Action<string> loginFailedEvent;
        private static System.Action<object> requestDidFinishEvent;
        private static System.Action<string> requestDidFailEvent;
        private static System.Action<bool> tweetSheetCompletedEvent;
        private static System.Action twitterInitializedEvent;
        
        // Methods
        public static void add_loginSucceededEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Prime31.TwitterManager.loginSucceededEvent, b:  value);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        public static void remove_loginSucceededEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Prime31.TwitterManager.loginSucceededEvent, value:  value);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        public static void add_loginFailedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.TwitterManager.loginFailedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.loginFailedEvent != 1152921505023250440);
        
        }
        public static void remove_loginFailedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.TwitterManager.loginFailedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.loginFailedEvent != 1152921505023250440);
        
        }
        public static void add_requestDidFinishEvent(System.Action<object> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.TwitterManager.requestDidFinishEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.requestDidFinishEvent != 1152921505023250448);
        
        }
        public static void remove_requestDidFinishEvent(System.Action<object> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.TwitterManager.requestDidFinishEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.requestDidFinishEvent != 1152921505023250448);
        
        }
        public static void add_requestDidFailEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.TwitterManager.requestDidFailEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.requestDidFailEvent != 1152921505023250456);
        
        }
        public static void remove_requestDidFailEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.TwitterManager.requestDidFailEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.requestDidFailEvent != 1152921505023250456);
        
        }
        public static void add_tweetSheetCompletedEvent(System.Action<bool> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.TwitterManager.tweetSheetCompletedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.tweetSheetCompletedEvent != 1152921505023250464);
        
        }
        public static void remove_tweetSheetCompletedEvent(System.Action<bool> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.TwitterManager.tweetSheetCompletedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.tweetSheetCompletedEvent != 1152921505023250464);
        
        }
        public static void add_twitterInitializedEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.TwitterManager.twitterInitializedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.twitterInitializedEvent != 1152921505023250472);
        
        }
        public static void remove_twitterInitializedEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.TwitterManager.twitterInitializedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.TwitterManager.twitterInitializedEvent != 1152921505023250472);
        
        }
        private static TwitterManager()
        {
            Prime31.AbstractManager.initialize(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public static void noop()
        {
        
        }
        public void loginSucceeded(string screenname)
        {
            var val_1;
            System.Action<System.String> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.TwitterManager.loginSucceededEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.TwitterManager.loginSucceededEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  screenname);
        }
        public void loginFailed(string error)
        {
            var val_1;
            System.Action<System.String> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.TwitterManager.loginFailedEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.TwitterManager.loginFailedEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  error);
        }
        public void requestSucceeded(string results)
        {
            var val_2;
            System.Action<System.Object> val_3;
            val_2 = null;
            val_2 = null;
            val_3 = Prime31.TwitterManager.requestDidFinishEvent;
            if(val_3 == null)
            {
                    return;
            }
            
            val_3 = Prime31.TwitterManager.requestDidFinishEvent;
            val_3.Invoke(obj:  Prime31.Json.decode(json:  results));
        }
        public void requestFailed(string error)
        {
            var val_1;
            System.Action<System.String> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.TwitterManager.requestDidFailEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.TwitterManager.requestDidFailEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  error);
        }
        public void tweetSheetCompleted(string oneOrZero)
        {
            null = null;
            if(Prime31.TwitterManager.tweetSheetCompletedEvent == null)
            {
                    return;
            }
            
            string val_3 = "1";
            val_3 = System.String.op_Equality(a:  oneOrZero, b:  val_3);
            Prime31.TwitterManager.tweetSheetCompletedEvent.Invoke(obj:  val_3);
        }
        public void twitterInitialized()
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.TwitterManager.twitterInitializedEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.TwitterManager.twitterInitializedEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public TwitterManager()
        {
        
        }
    
    }

}
