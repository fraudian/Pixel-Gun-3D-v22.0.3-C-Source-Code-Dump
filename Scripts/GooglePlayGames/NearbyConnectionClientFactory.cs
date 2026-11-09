using UnityEngine;

namespace GooglePlayGames
{
    public static class NearbyConnectionClientFactory
    {
        // Methods
        public static void Create(System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback)
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  "Creating INearbyConnection in editor, using DummyClient.");
                callback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.DummyNearbyConnectionClient());
            }
            
            callback.Invoke(obj:  new GooglePlayGames.Android.AndroidNearbyConnectionClient());
        }
    
    }

}
