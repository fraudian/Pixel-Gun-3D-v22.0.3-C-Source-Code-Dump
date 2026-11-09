using UnityEngine;

namespace Prime31
{
    public class TwitterEventListener : MonoBehaviour
    {
        // Methods
        private void OnEnable()
        {
            Prime31.TwitterManager.add_twitterInitializedEvent(value:  new System.Action(object:  this, method:  System.Void Prime31.TwitterEventListener::twitterInitializedEvent()));
            Prime31.TwitterManager.add_loginSucceededEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void Prime31.TwitterEventListener::loginSucceeded(string username)));
            Prime31.TwitterManager.add_loginFailedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void Prime31.TwitterEventListener::loginFailed(string error)));
            Prime31.TwitterManager.add_requestDidFinishEvent(value:  new System.Action<System.Object>(object:  this, method:  System.Void Prime31.TwitterEventListener::requestDidFinishEvent(object result)));
            Prime31.TwitterManager.add_requestDidFailEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void Prime31.TwitterEventListener::requestDidFailEvent(string error)));
            Prime31.TwitterManager.add_tweetSheetCompletedEvent(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Prime31.TwitterEventListener::tweetSheetCompletedEvent(bool didSucceed)));
        }
        private void OnDisable()
        {
            Prime31.TwitterManager.remove_twitterInitializedEvent(value:  new System.Action(object:  this, method:  System.Void Prime31.TwitterEventListener::twitterInitializedEvent()));
            Prime31.TwitterManager.remove_loginSucceededEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void Prime31.TwitterEventListener::loginSucceeded(string username)));
            Prime31.TwitterManager.remove_loginFailedEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void Prime31.TwitterEventListener::loginFailed(string error)));
            Prime31.TwitterManager.remove_requestDidFinishEvent(value:  new System.Action<System.Object>(object:  this, method:  System.Void Prime31.TwitterEventListener::requestDidFinishEvent(object result)));
            Prime31.TwitterManager.remove_requestDidFailEvent(value:  new System.Action<System.String>(object:  this, method:  System.Void Prime31.TwitterEventListener::requestDidFailEvent(string error)));
            Prime31.TwitterManager.remove_tweetSheetCompletedEvent(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Prime31.TwitterEventListener::tweetSheetCompletedEvent(bool didSucceed)));
        }
        private void twitterInitializedEvent()
        {
            UnityEngine.Debug.Log(message:  "twitterInitializedEvent");
        }
        private void loginSucceeded(string username)
        {
        
        }
        private void loginFailed(string error)
        {
        
        }
        private void requestDidFailEvent(string error)
        {
        
        }
        private void requestDidFinishEvent(object result)
        {
            if(result == null)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "requestDidFinishEvent");
            Prime31.Utils.logObject(obj:  result);
        }
        private void tweetSheetCompletedEvent(bool didSucceed)
        {
        
        }
        public TwitterEventListener()
        {
        
        }
    
    }

}
