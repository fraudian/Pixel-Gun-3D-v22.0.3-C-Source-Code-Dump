using UnityEngine;

namespace Prime31
{
    public class AndroidNotificationConfiguration
    {
        // Fields
        public long secondsFromNow;
        public string title;
        public string subtitle;
        public string tickerText;
        public string extraData;
        public string smallIcon;
        public string largeIcon;
        public int requestCode;
        public string groupKey;
        public int color;
        public bool isGroupSummary;
        public int cancelsNotificationId;
        public bool sound;
        public bool vibrate;
        public bool useExactTiming;
        
        // Methods
        public AndroidNotificationConfiguration(long secondsFromNow, string title, string subtitle, string tickerText)
        {
            this.title = System.String.alignConst;
            this.subtitle = System.String.alignConst;
            this.tickerText = System.String.alignConst;
            this.extraData = System.String.alignConst;
            this.smallIcon = System.String.alignConst;
            this.largeIcon = System.String.alignConst;
            this.requestCode = 0;
            this.color = 0;
            this.cancelsNotificationId = 0;
            this.groupKey = System.String.alignConst;
            this.sound = true;
            this.vibrate = true;
            val_1 = new System.Object();
            this.secondsFromNow = secondsFromNow;
            this.title = val_1;
            this.subtitle = subtitle;
            this.tickerText = tickerText;
        }
        public Prime31.AndroidNotificationConfiguration build()
        {
            if(this.requestCode != 1)
            {
                    return (Prime31.AndroidNotificationConfiguration)this;
            }
            
            this.requestCode = UnityEngine.Random.Range(min:  0, max:  2147483647);
            return (Prime31.AndroidNotificationConfiguration)this;
        }
    
    }

}
