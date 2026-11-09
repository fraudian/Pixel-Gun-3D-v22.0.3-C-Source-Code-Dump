using UnityEngine;

namespace GooglePlayGames
{
    public static class GameInfo
    {
        // Fields
        private const string UnescapedApplicationId = "APP_ID";
        private const string UnescapedIosClientId = "IOS_CLIENTID";
        private const string UnescapedWebClientId = "WEB_CLIENTID";
        private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";
        public const string ApplicationId = "339873998127";
        public const string IosClientId = "";
        public const string WebClientId = "";
        public const string NearbyConnectionServiceId = "com.pixel.gun3d";
        
        // Methods
        public static bool ApplicationIdInitialized()
        {
            string val_5;
            var val_6;
            var val_7;
            if((System.String.IsNullOrEmpty(value:  "339873998127")) != false)
            {
                    val_6 = 0;
            }
            else
            {
                    val_7 = "339873998127";
                val_5 = GooglePlayGames.GameInfo.ToEscapedToken(token:  "APP_ID");
                if("339873998127" == null)
            {
                    val_7 = "339873998127";
            }
            
                bool val_3 = Equals(value:  val_5);
                val_6 = val_3 ^ 1;
            }
            
            val_3 = val_6;
            return (bool)val_3;
        }
        public static bool IosClientIdInitialized()
        {
            string val_5;
            var val_6;
            var val_7;
            if((System.String.IsNullOrEmpty(value:  "")) != false)
            {
                    val_6 = 0;
            }
            else
            {
                    val_7 = "";
                val_5 = GooglePlayGames.GameInfo.ToEscapedToken(token:  "IOS_CLIENTID");
                if("" == null)
            {
                    val_7 = "";
            }
            
                bool val_3 = Equals(value:  val_5);
                val_6 = val_3 ^ 1;
            }
            
            val_3 = val_6;
            return (bool)val_3;
        }
        public static bool WebClientIdInitialized()
        {
            string val_5;
            var val_6;
            var val_7;
            if((System.String.IsNullOrEmpty(value:  "")) != false)
            {
                    val_6 = 0;
            }
            else
            {
                    val_7 = "";
                val_5 = GooglePlayGames.GameInfo.ToEscapedToken(token:  "WEB_CLIENTID");
                if("" == null)
            {
                    val_7 = "";
            }
            
                bool val_3 = Equals(value:  val_5);
                val_6 = val_3 ^ 1;
            }
            
            val_3 = val_6;
            return (bool)val_3;
        }
        public static bool NearbyConnectionsInitialized()
        {
            string val_5;
            var val_6;
            var val_7;
            if((System.String.IsNullOrEmpty(value:  "com.pixel.gun3d")) != false)
            {
                    val_6 = 0;
            }
            else
            {
                    val_7 = "com.pixel.gun3d";
                val_5 = GooglePlayGames.GameInfo.ToEscapedToken(token:  "NEARBY_SERVICE_ID");
                if("com.pixel.gun3d" == null)
            {
                    val_7 = "com.pixel.gun3d";
            }
            
                bool val_3 = Equals(value:  val_5);
                val_6 = val_3 ^ 1;
            }
            
            val_3 = val_6;
            return (bool)val_3;
        }
        private static string ToEscapedToken(string token)
        {
            return System.String.Format(format:  "__{0}__", arg0:  token);
        }
    
    }

}
