using UnityEngine;

namespace BestHTTP.Logger
{
    public class DefaultLogger : ILogger
    {
        // Fields
        private BestHTTP.Logger.Loglevels <Level>k__BackingField;
        private string <FormatVerbose>k__BackingField;
        private string <FormatInfo>k__BackingField;
        private string <FormatWarn>k__BackingField;
        private string <FormatErr>k__BackingField;
        private string <FormatEx>k__BackingField;
        
        // Properties
        public BestHTTP.Logger.Loglevels Level { get; set; }
        public string FormatVerbose { get; set; }
        public string FormatInfo { get; set; }
        public string FormatWarn { get; set; }
        public string FormatErr { get; set; }
        public string FormatEx { get; set; }
        
        // Methods
        public BestHTTP.Logger.Loglevels get_Level()
        {
            return (BestHTTP.Logger.Loglevels)this.<Level>k__BackingField;
        }
        public void set_Level(BestHTTP.Logger.Loglevels value)
        {
            this.<Level>k__BackingField = value;
        }
        public string get_FormatVerbose()
        {
            return (string)this.<FormatVerbose>k__BackingField;
        }
        public void set_FormatVerbose(string value)
        {
            this.<FormatVerbose>k__BackingField = value;
        }
        public string get_FormatInfo()
        {
            return (string)this.<FormatInfo>k__BackingField;
        }
        public void set_FormatInfo(string value)
        {
            this.<FormatInfo>k__BackingField = value;
        }
        public string get_FormatWarn()
        {
            return (string)this.<FormatWarn>k__BackingField;
        }
        public void set_FormatWarn(string value)
        {
            this.<FormatWarn>k__BackingField = value;
        }
        public string get_FormatErr()
        {
            return (string)this.<FormatErr>k__BackingField;
        }
        public void set_FormatErr(string value)
        {
            this.<FormatErr>k__BackingField = value;
        }
        public string get_FormatEx()
        {
            return (string)this.<FormatEx>k__BackingField;
        }
        public void set_FormatEx(string value)
        {
            this.<FormatEx>k__BackingField = value;
        }
        public DefaultLogger()
        {
            this.<FormatVerbose>k__BackingField = "BestHTTP: [{0}] D [{1}]: {2}";
            this.<FormatInfo>k__BackingField = "BestHTTP: [{0}] I [{1}]: {2}";
            this.<FormatWarn>k__BackingField = "BestHTTP: [{0}] W [{1}]: {2}";
            this.<FormatErr>k__BackingField = "BestHTTP: [{0}] Err [{1}]: {2}";
            this.<FormatEx>k__BackingField = "BestHTTP: [{0}] Ex [{1}]: {2} - Message: {3}  StackTrace: {4}";
            this.<Level>k__BackingField = ((UnityEngine.Debug.isDebugBuild & true) != 0) ? (2 + 1) : 2;
        }
        public void Verbose(string division, string verb)
        {
            object val_3;
            string val_4;
            val_3 = verb;
            val_4 = this;
            if((this.<Level>k__BackingField) != 0)
            {
                    return;
            }
            
            val_4 = this.<FormatVerbose>k__BackingField;
            val_3 = System.String.Format(format:  val_4, arg0:  this.GetFormattedTime(), arg1:  division, arg2:  val_3);
            UnityEngine.Debug.Log(message:  val_3);
        }
        public void Information(string division, string info)
        {
            object val_3;
            string val_4;
            val_3 = info;
            val_4 = this;
            if((this.<Level>k__BackingField) > 1)
            {
                    return;
            }
            
            val_4 = this.<FormatInfo>k__BackingField;
            val_3 = System.String.Format(format:  val_4, arg0:  this.GetFormattedTime(), arg1:  division, arg2:  val_3);
            UnityEngine.Debug.Log(message:  val_3);
        }
        public void Warning(string division, string warn)
        {
            object val_3;
            string val_4;
            val_3 = warn;
            val_4 = this;
            if((this.<Level>k__BackingField) > 2)
            {
                    return;
            }
            
            val_4 = this.<FormatWarn>k__BackingField;
            val_3 = System.String.Format(format:  val_4, arg0:  this.GetFormattedTime(), arg1:  division, arg2:  val_3);
            UnityEngine.Debug.LogWarning(message:  val_3);
        }
        public void Error(string division, string err)
        {
            object val_3;
            string val_4;
            val_3 = err;
            val_4 = this;
            if((this.<Level>k__BackingField) > 3)
            {
                    return;
            }
            
            val_4 = this.<FormatErr>k__BackingField;
            val_3 = System.String.Format(format:  val_4, arg0:  this.GetFormattedTime(), arg1:  division, arg2:  val_3);
            UnityEngine.Debug.LogError(message:  val_3);
        }
        public void Exception(string division, string msg, System.Exception ex)
        {
            object val_9;
            string val_10;
            var val_11;
            object val_12;
            val_9 = ex;
            val_10 = this;
            if((this.<Level>k__BackingField) > 4)
            {
                    return;
            }
            
            if(val_9 == null)
            {
                goto label_2;
            }
            
            new System.Text.StringBuilder() = new System.Text.StringBuilder();
            var val_9 = 1;
            label_6:
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder().AppendFormat(format:  "{0}: {1} {2}", arg0:  val_9.ToString(), arg1:  val_9, arg2:  val_9);
            if(val_9.InnerException == null)
            {
                goto label_4;
            }
            
            val_9 = val_9 + 1;
            System.Text.StringBuilder val_5 = new System.Text.StringBuilder().AppendLine();
            goto label_6;
            label_2:
            label_30:
            val_10 = this.<FormatEx>k__BackingField;
            val_11 = 5;
            object[] val_6 = new object[5];
            string val_7 = val_6.GetFormattedTime();
            if((val_7 != null) && (val_7 == null))
            {
                    val_11 = 0;
            }
            
            if(val_6.Length == 0)
            {
                    val_11 = 0;
            }
            
            val_6[0] = val_7;
            if((division != null) && (division == null))
            {
                    val_11 = 0;
            }
            
            if(val_6.Length <= 1)
            {
                    val_11 = 0;
            }
            
            val_6[1] = division;
            if((msg != null) && (msg == null))
            {
                    val_11 = 0;
            }
            
            if(val_6.Length <= 2)
            {
                    val_11 = 0;
            }
            
            val_6[2] = msg;
            if("null" == null)
            {
                    val_11 = 0;
            }
            
            if(val_6.Length <= 3)
            {
                    val_11 = 0;
            }
            
            val_6[3] = "null";
            if(val_9 == null)
            {
                goto label_20;
            }
            
            val_12 = val_9;
            if(val_12 != null)
            {
                goto label_21;
            }
            
            goto label_24;
            label_20:
            val_12 = "null";
            label_21:
            label_24:
            val_6[4] = val_12;
            val_9 = System.String.Format(format:  val_10, args:  val_6);
            UnityEngine.Debug.LogError(message:  val_9);
            return;
            label_4:
            if(new System.Text.StringBuilder() != null)
            {
                goto label_30;
            }
            
            goto label_30;
        }
        private string GetFormattedTime()
        {
            System.DateTime val_1 = System.DateTime.Now;
            return 1904150712;
        }
    
    }

}
