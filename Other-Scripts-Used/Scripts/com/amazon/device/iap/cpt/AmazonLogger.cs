using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public class AmazonLogger
    {
        // Fields
        private readonly string tag;
        
        // Methods
        public AmazonLogger(string tag)
        {
            this.tag = tag;
        }
        public void Debug(string msg)
        {
            AmazonLogging.Log(reportLevel:  5, service:  this.tag, message:  msg);
        }
        public string getTag()
        {
            return (string)this.tag;
        }
    
    }

}
