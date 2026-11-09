using UnityEngine;

namespace BestHTTP.ServerSentEvents
{
    public sealed class Message
    {
        // Fields
        private string <Id>k__BackingField;
        private string <Event>k__BackingField;
        private string <Data>k__BackingField;
        private System.TimeSpan <Retry>k__BackingField;
        
        // Properties
        public string Id { get; set; }
        public string Event { get; set; }
        public string Data { get; set; }
        public System.TimeSpan Retry { get; set; }
        
        // Methods
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        internal void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
        public string get_Event()
        {
            return (string)this.<Event>k__BackingField;
        }
        internal void set_Event(string value)
        {
            this.<Event>k__BackingField = value;
        }
        public string get_Data()
        {
            return (string)this.<Data>k__BackingField;
        }
        internal void set_Data(string value)
        {
            this.<Data>k__BackingField = value;
        }
        public System.TimeSpan get_Retry()
        {
            return (System.TimeSpan)this.<Retry>k__BackingField;
        }
        internal void set_Retry(System.TimeSpan value)
        {
            this.<Retry>k__BackingField = value;
        }
        public override string ToString()
        {
            return System.String.Format(format:  "\"{0}\": \"{1}\"", arg0:  this.<Event>k__BackingField, arg1:  this.<Data>k__BackingField);
        }
        public Message()
        {
        
        }
    
    }

}
