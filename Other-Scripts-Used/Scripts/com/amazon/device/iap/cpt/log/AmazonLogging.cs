using UnityEngine;

namespace com.amazon.device.iap.cpt.log
{
    public class AmazonLogging
    {
        // Fields
        private const string errorMessage = "{0} error: {1}";
        private const string warningMessage = "{0} warning: {1}";
        private const string logMessage = "{0}: {1}";
        
        // Methods
        public static void LogError(com.amazon.device.iap.cpt.log.AmazonLogging.AmazonLoggingLevel reportLevel, string service, string message)
        {
            string val_4 = message;
            if(reportLevel == 0)
            {
                    return;
            }
            
            val_4 = System.String.Format(format:  "{0} error: {1}", arg0:  service, arg1:  val_4 = message);
            if(((reportLevel - 3) < 3) || (reportLevel == 1))
            {
                goto label_3;
            }
            
            if(reportLevel == 2)
            {
                goto label_4;
            }
            
            return;
            label_3:
            UnityEngine.Debug.LogError(message:  val_4);
            return;
            label_4:
            System.Exception val_3 = new System.Exception(message:  val_4);
        }
        public static void LogWarning(com.amazon.device.iap.cpt.log.AmazonLogging.AmazonLoggingLevel reportLevel, string service, string message)
        {
            if(reportLevel < 4)
            {
                    return;
            }
            
            if((reportLevel & 4294967294) != 4)
            {
                    return;
            }
            
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "{0} warning: {1}", arg0:  service, arg1:  message));
        }
        public static void Log(com.amazon.device.iap.cpt.log.AmazonLogging.AmazonLoggingLevel reportLevel, string service, string message)
        {
            if(reportLevel != 5)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "{0}: {1}", arg0:  service, arg1:  message));
        }
        public static com.amazon.device.iap.cpt.log.AmazonLogging.SDKLoggingLevel pluginToSDKLoggingLevel(com.amazon.device.iap.cpt.log.AmazonLogging.AmazonLoggingLevel pluginLoggingLevel)
        {
            if(pluginLoggingLevel > 5)
            {
                    return 3;
            }
            
            return (SDKLoggingLevel)100654208 + (pluginLoggingLevel) << 2;
        }
        public AmazonLogging()
        {
        
        }
    
    }

}
