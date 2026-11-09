using UnityEngine;

namespace FlurrySDKInternal
{
    public abstract class FlurryAgent : IDisposable
    {
        // Methods
        public abstract void SetAge(int age); // 0
        public abstract void SetGender(FlurrySDK.Flurry.Gender gender); // 0
        public abstract void SetReportLocation(bool reportLocation); // 0
        public abstract void SetSessionOrigin(string originName, string deepLink); // 0
        public abstract void SetUserId(string userId); // 0
        public abstract void SetVersionName(string versionName); // 0
        public abstract void AddOrigin(string originName, string originVersion); // 0
        public abstract void AddOrigin(string originName, string originVersion, System.Collections.Generic.IDictionary<string, string> originParameters); // 0
        public abstract void AddSessionProperty(string name, string value); // 0
        public abstract int GetAgentVersion(); // 0
        public abstract string GetReleaseVersion(); // 0
        public abstract string GetSessionId(); // 0
        public abstract int LogEvent(string eventId); // 0
        public abstract int LogEvent(string eventId, bool timed); // 0
        public abstract int LogEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters); // 0
        public abstract int LogEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters, bool timed); // 0
        public abstract void EndTimedEvent(string eventId); // 0
        public abstract void EndTimedEvent(string eventId, System.Collections.Generic.IDictionary<string, string> parameters); // 0
        public abstract void OnPageView(); // 0
        public abstract void OnError(string errorId, string message, string errorClass); // 0
        public abstract void OnError(string errorId, string message, string errorClass, System.Collections.Generic.IDictionary<string, string> parameters); // 0
        public abstract void LogBreadcrumb(string crashBreadcrumb); // 0
        public abstract int LogPayment(string productName, string productId, int quantity, double price, string currency, string transactionId, System.Collections.Generic.IDictionary<string, string> parameters); // 0
        public abstract void SetIAPReportingEnabled(bool enableIAP); // 0
        public abstract void Dispose(); // 0
        protected FlurryAgent()
        {
        
        }
    
    }

}
