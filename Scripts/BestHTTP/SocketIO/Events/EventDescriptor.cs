using UnityEngine;

namespace BestHTTP.SocketIO.Events
{
    internal sealed class EventDescriptor
    {
        // Fields
        private System.Collections.Generic.List<BestHTTP.SocketIO.Events.SocketIOCallback> <Callbacks>k__BackingField;
        private bool <OnlyOnce>k__BackingField;
        private bool <AutoDecodePayload>k__BackingField;
        private BestHTTP.SocketIO.Events.SocketIOCallback[] CallbackArray;
        
        // Properties
        public System.Collections.Generic.List<BestHTTP.SocketIO.Events.SocketIOCallback> Callbacks { get; set; }
        public bool OnlyOnce { get; set; }
        public bool AutoDecodePayload { get; set; }
        
        // Methods
        public System.Collections.Generic.List<BestHTTP.SocketIO.Events.SocketIOCallback> get_Callbacks()
        {
            return (System.Collections.Generic.List<BestHTTP.SocketIO.Events.SocketIOCallback>)this.<Callbacks>k__BackingField;
        }
        private void set_Callbacks(System.Collections.Generic.List<BestHTTP.SocketIO.Events.SocketIOCallback> value)
        {
            this.<Callbacks>k__BackingField = value;
        }
        public bool get_OnlyOnce()
        {
            return (bool)this.<OnlyOnce>k__BackingField;
        }
        private void set_OnlyOnce(bool value)
        {
            this.<OnlyOnce>k__BackingField = value;
        }
        public bool get_AutoDecodePayload()
        {
            return (bool)this.<AutoDecodePayload>k__BackingField;
        }
        private void set_AutoDecodePayload(bool value)
        {
            this.<AutoDecodePayload>k__BackingField = value;
        }
        public EventDescriptor(bool onlyOnce, bool autoDecodePayload, BestHTTP.SocketIO.Events.SocketIOCallback callback)
        {
            this.<OnlyOnce>k__BackingField = onlyOnce;
            this.<AutoDecodePayload>k__BackingField = autoDecodePayload;
            System.Collections.Generic.List<BestHTTP.SocketIO.Events.SocketIOCallback> val_3 = new System.Collections.Generic.List<BestHTTP.SocketIO.Events.SocketIOCallback>(capacity:  1);
            this.<Callbacks>k__BackingField = val_3;
            if(callback == null)
            {
                    return;
            }
            
            val_3.Add(item:  callback);
        }
        public void Call(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)
        {
            BestHTTP.SocketIO.Events.SocketIOCallback[] val_9;
            var val_10;
            BestHTTP.SocketIO.Events.SocketIOCallback[] val_3 = this.CallbackArray;
            if(val_3 != null)
            {
                    if((this.<Callbacks>k__BackingField.Count) <= this.CallbackArray.Length)
            {
                goto label_3;
            }
            
            }
            
            System.Array.Resize<BestHTTP.SocketIO.Events.SocketIOCallback>(array: ref  val_3, newSize:  this.<Callbacks>k__BackingField.Count);
            label_3:
            val_9 = this.CallbackArray;
            this.<Callbacks>k__BackingField.CopyTo(array:  val_9);
            val_10 = 0;
            goto label_16;
            label_39:
            BestHTTP.SocketIO.Events.SocketIOCallback val_9 = val_3[0];
            if(val_9 != null)
            {
                    val_9.Invoke(socket:  socket, packet:  packet, args:  args);
            }
            
            if((this.<OnlyOnce>k__BackingField) != false)
            {
                    bool val_4 = this.<Callbacks>k__BackingField.Remove(item:  this.CallbackArray[0]);
            }
            
            val_9 = 0;
            val_10 = 1;
            val_3[val_9] = 0;
            label_16:
            if(val_10 < this.CallbackArray.Length)
            {
                goto label_39;
            }
        
        }
    
    }

}
