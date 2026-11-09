using UnityEngine;

namespace BestHTTP.Logger
{
    public interface ILogger
    {
        // Properties
        public abstract BestHTTP.Logger.Loglevels Level { get; set; }
        public abstract string FormatVerbose { get; set; }
        public abstract string FormatInfo { get; set; }
        public abstract string FormatWarn { get; set; }
        public abstract string FormatErr { get; set; }
        public abstract string FormatEx { get; set; }
        
        // Methods
        public abstract BestHTTP.Logger.Loglevels get_Level(); // 0
        public abstract void set_Level(BestHTTP.Logger.Loglevels value); // 0
        public abstract string get_FormatVerbose(); // 0
        public abstract void set_FormatVerbose(string value); // 0
        public abstract string get_FormatInfo(); // 0
        public abstract void set_FormatInfo(string value); // 0
        public abstract string get_FormatWarn(); // 0
        public abstract void set_FormatWarn(string value); // 0
        public abstract string get_FormatErr(); // 0
        public abstract void set_FormatErr(string value); // 0
        public abstract string get_FormatEx(); // 0
        public abstract void set_FormatEx(string value); // 0
        public abstract void Verbose(string division, string verb); // 0
        public abstract void Information(string division, string info); // 0
        public abstract void Warning(string division, string warn); // 0
        public abstract void Error(string division, string err); // 0
        public abstract void Exception(string division, string msg, System.Exception ex); // 0
    
    }

}
