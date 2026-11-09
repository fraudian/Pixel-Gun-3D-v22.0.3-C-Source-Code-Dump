using UnityEngine;

namespace BestHTTP.SocketIO.Events
{
    internal sealed class EventTable
    {
        // Fields
        private BestHTTP.SocketIO.Socket <Socket>k__BackingField;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor>> Table;
        
        // Properties
        private BestHTTP.SocketIO.Socket Socket { get; set; }
        
        // Methods
        private BestHTTP.SocketIO.Socket get_Socket()
        {
            return (BestHTTP.SocketIO.Socket)this.<Socket>k__BackingField;
        }
        private void set_Socket(BestHTTP.SocketIO.Socket value)
        {
            this.<Socket>k__BackingField = value;
        }
        public EventTable(BestHTTP.SocketIO.Socket socket)
        {
            this.Table = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor>>();
            this.<Socket>k__BackingField = socket;
        }
        public void Register(string eventName, BestHTTP.SocketIO.Events.SocketIOCallback callback, bool onlyOnce, bool autoDecodePayload)
        {
            bool val_11;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor>> val_12;
            System.Collections.Generic.List<T> val_13;
            var val_14;
            BestHTTP.SocketIO.Events.EventDescriptor val_15;
            EventTable.<>c__DisplayClass6_0 val_1 = new EventTable.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    val_11 = val_1;
                .onlyOnce = onlyOnce;
            }
            else
            {
                    val_11 = true;
                mem[16] = onlyOnce;
            }
            
            .autoDecodePayload = autoDecodePayload;
            val_12 = this.Table;
            if((val_12.TryGetValue(key:  eventName, value: out  0)) != true)
            {
                    System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor> val_7 = null;
                val_12 = val_7;
                val_7 = new System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor>(capacity:  1);
                this.Table.Add(key:  eventName, value:  val_7);
            }
            
            val_13 = val_12;
            if((val_7.Find(match:  new System.Predicate<BestHTTP.SocketIO.Events.EventDescriptor>(object:  val_1, method:  System.Boolean EventTable.<>c__DisplayClass6_0::<Register>b__0(BestHTTP.SocketIO.Events.EventDescriptor d)))) != null)
            {
                    val_14 = 1152921553731883104;
                val_15 = callback;
            }
            else
            {
                    val_13 = val_12;
                BestHTTP.SocketIO.Events.EventDescriptor val_10 = new BestHTTP.SocketIO.Events.EventDescriptor(onlyOnce:  val_11, autoDecodePayload:  (EventTable.<>c__DisplayClass6_0)[1152921553733477824].autoDecodePayload, callback:  callback);
                val_14 = 1152921553733412608;
                val_15 = val_10;
            }
            
            val_7.Add(item:  val_10);
        }
        public void Unregister(string eventName)
        {
            bool val_1 = this.Table.Remove(key:  eventName);
        }
        public void Unregister(string eventName, BestHTTP.SocketIO.Events.SocketIOCallback callback)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor>> val_6;
            var val_7;
            System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor> val_1 = 0;
            val_6 = this.Table;
            if((val_6.TryGetValue(key:  eventName, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_7 = 0;
            goto label_3;
            label_8:
            BestHTTP.SocketIO.Events.EventDescriptor val_3 = val_1.Item[0];
            bool val_4 = val_3.<Callbacks>k__BackingField.Remove(item:  callback);
            val_7 = 1;
            label_3:
            val_6 = val_1;
            if(val_7 < val_6.Count)
            {
                goto label_8;
            }
        
        }
        public void Call(string eventName, BestHTTP.SocketIO.Packet packet, object[] args)
        {
            string val_11;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor>> val_14;
            var val_15;
            System.Collections.Generic.List<BestHTTP.SocketIO.Events.EventDescriptor> val_8 = 0;
            val_11 = 1152921505557803008;
            var val_12 = 0;
            val_12 = val_12 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    val_11 = "EventTable";
                var val_13 = 0;
                val_13 = val_13 + 1;
                BestHTTP.HTTPManager.Logger.Verbose(division:  val_11, verb:  "Call - "("Call - ") + eventName);
            }
            
            val_14 = this.Table;
            if((val_14.TryGetValue(key:  eventName, value: out  val_8)) == false)
            {
                    return;
            }
            
            val_11 = 1152921553733708288;
            val_15 = 0;
            goto label_18;
            label_22:
            val_8.Item[0].Call(socket:  this.<Socket>k__BackingField, packet:  packet, args:  args);
            val_15 = 1;
            label_18:
            val_14 = val_8;
            if(val_15 < val_14.Count)
            {
                goto label_22;
            }
        
        }
        public void Call(BestHTTP.SocketIO.Packet packet)
        {
            var val_13;
            BestHTTP.SocketIO.SocketIOEventTypes val_14;
            string val_15;
            System.Object[] val_17;
            if(packet == null)
            {
                goto label_1;
            }
            
            val_13 = packet;
            val_14 = packet.<SocketIOEvent>k__BackingField;
            val_15 = packet.DecodeEventName();
            if(val_14 != 1)
            {
                goto label_2;
            }
            
            goto label_4;
            label_1:
            val_15 = 0.DecodeEventName();
            val_13 = 28;
            if(0 == 1)
            {
                goto label_4;
            }
            
            val_13 = 28;
            val_14 = 0;
            label_2:
            string val_3 = BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  val_14);
            goto label_7;
            label_4:
            string val_4 = BestHTTP.SocketIO.Events.EventNames.GetNameFor(transEvent:  packet.<TransportEvent>k__BackingField);
            label_7:
            if((this.HasSubsciber(eventName:  val_15)) != true)
            {
                    if((this.HasSubsciber(eventName:  val_4)) == false)
            {
                    return;
            }
            
            }
            
            if((packet.<TransportEvent>k__BackingField) != 4)
            {
                goto label_16;
            }
            
            if((packet + 28) != 5)
            {
                    if((packet + 28) != 2)
            {
                goto label_16;
            }
            
            }
            
            if((this.ShouldDecodePayload(eventName:  val_15)) == false)
            {
                goto label_16;
            }
            
            val_17 = packet.Decode(encoder:  this.<Socket>k__BackingField.<Manager>k__BackingField.<Encoder>k__BackingField);
            goto label_19;
            label_16:
            val_17 = 0;
            label_19:
            if((System.String.IsNullOrEmpty(value:  val_15)) != true)
            {
                    this.Call(eventName:  val_15, packet:  packet, args:  val_17);
            }
            
            if((packet.<IsDecoded>k__BackingField) != true)
            {
                    if((this.ShouldDecodePayload(eventName:  val_4)) != false)
            {
                    val_15 = this.<Socket>k__BackingField.<Manager>k__BackingField;
                val_17 = packet.Decode(encoder:  this.<Socket>k__BackingField.<Manager>k__BackingField.<Encoder>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    return;
            }
            
            this.Call(eventName:  val_4, packet:  packet, args:  val_17);
        }
        public void Clear()
        {
            this.Table.Clear();
        }
        private bool ShouldDecodePayload(string eventName)
        {
            var val_7;
            string val_8;
            var val_9;
            val_8 = eventName;
            if((this.Table.TryGetValue(key:  val_8, value: out  0)) == false)
            {
                goto label_2;
            }
            
            val_7 = 1152921553733708288;
            val_8 = 0;
            goto label_3;
            label_12:
            BestHTTP.SocketIO.Events.EventDescriptor val_3 = val_1.Item[0];
            if((val_3.<AutoDecodePayload>k__BackingField) == false)
            {
                goto label_6;
            }
            
            BestHTTP.SocketIO.Events.EventDescriptor val_4 = val_1.Item[0];
            if((val_4.<Callbacks>k__BackingField.Count) > 0)
            {
                goto label_10;
            }
            
            label_6:
            val_8 = 1;
            label_3:
            if(val_8 < val_1.Count)
            {
                goto label_12;
            }
            
            label_2:
            val_9 = 0;
            return (bool)val_9;
            label_10:
            val_9 = 1;
            return (bool)val_9;
        }
        private bool HasSubsciber(string eventName)
        {
            if(this.Table != null)
            {
                    return this.Table.ContainsKey(key:  eventName);
            }
            
            return this.Table.ContainsKey(key:  eventName);
        }
    
    }

}
