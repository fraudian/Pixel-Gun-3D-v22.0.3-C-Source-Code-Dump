using UnityEngine;

namespace BestHTTP.SocketIO
{
    public sealed class Error
    {
        // Fields
        private BestHTTP.SocketIO.SocketIOErrors <Code>k__BackingField;
        private string <Message>k__BackingField;
        
        // Properties
        public BestHTTP.SocketIO.SocketIOErrors Code { get; set; }
        public string Message { get; set; }
        
        // Methods
        public BestHTTP.SocketIO.SocketIOErrors get_Code()
        {
            return (BestHTTP.SocketIO.SocketIOErrors)this.<Code>k__BackingField;
        }
        private void set_Code(BestHTTP.SocketIO.SocketIOErrors value)
        {
            this.<Code>k__BackingField = value;
        }
        public string get_Message()
        {
            return (string)this.<Message>k__BackingField;
        }
        private void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
        public Error(BestHTTP.SocketIO.SocketIOErrors code, string msg)
        {
            val_1 = new System.Object();
            this.<Code>k__BackingField = code;
            this.<Message>k__BackingField = val_1;
        }
        public override string ToString()
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)System.String.Format(format:  "Code: {0} Message: \"{1}\"", arg0:  this.<Code>k__BackingField.ToString(), arg1:  this.<Message>k__BackingField);
        }
    
    }

}
