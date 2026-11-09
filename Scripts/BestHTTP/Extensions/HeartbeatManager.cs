using UnityEngine;

namespace BestHTTP.Extensions
{
    public sealed class HeartbeatManager
    {
        // Fields
        private System.Collections.Generic.List<BestHTTP.Extensions.IHeartbeat> Heartbeats;
        private BestHTTP.Extensions.IHeartbeat[] UpdateArray;
        private System.DateTime LastUpdate;
        
        // Methods
        public void Subscribe(BestHTTP.Extensions.IHeartbeat heartbeat)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.Heartbeats, lockTaken: ref  val_1);
            if((this.Heartbeats.Contains(item:  heartbeat)) != true)
            {
                    this.Heartbeats.Add(item:  heartbeat);
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.Heartbeats);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void Unsubscribe(BestHTTP.Extensions.IHeartbeat heartbeat)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.Heartbeats, lockTaken: ref  val_1);
            bool val_2 = this.Heartbeats.Remove(item:  heartbeat);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.Heartbeats);
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void Update()
        {
            var val_13;
            System.Collections.Generic.List<BestHTTP.Extensions.IHeartbeat> val_14;
            var val_15;
            T[] val_16;
            var val_17;
            val_14 = 1152921504618614784;
            val_15 = null;
            val_15 = null;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.LastUpdate}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
            {
                    System.DateTime val_2 = System.DateTime.UtcNow;
                this.LastUpdate = val_2;
                return;
            }
            
            System.DateTime val_3 = System.DateTime.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_3.dateData}, d2:  new System.DateTime() {dateData = this.LastUpdate});
            System.DateTime val_5 = System.DateTime.UtcNow;
            val_14 = this.Heartbeats;
            this.LastUpdate = val_5;
            bool val_6 = false;
            System.Threading.Monitor.Enter(obj:  val_14, lockTaken: ref  val_6);
            BestHTTP.Extensions.IHeartbeat[] val_9 = this.UpdateArray;
            if(val_9 != null)
            {
                    if(this.Heartbeats.Count <= this.UpdateArray.Length)
            {
                goto label_11;
            }
            
            }
            
            System.Array.Resize<BestHTTP.Extensions.IHeartbeat>(array: ref  val_9, newSize:  this.Heartbeats.Count);
            label_11:
            val_16 = this.UpdateArray;
            this.Heartbeats.CopyTo(index:  0, array:  val_16, arrayIndex:  0, count:  this.Heartbeats.Count);
            val_17 = 0;
            if(val_6 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_14);
            }
            
            if(0 == 1)
            {
                goto label_17;
            }
            
            if((val_17 == 0) || (182 == 182))
            {
                goto label_23;
            }
            
            label_22:
            val_16 = 0;
            label_23:
            if(this.Heartbeats.Count < 1)
            {
                    return;
            }
            
            val_13 = 1152921505559080960;
            goto label_44;
            label_17:
            if(val_17 != 0)
            {
                goto label_22;
            }
            
            goto label_23;
        }
        public HeartbeatManager()
        {
            var val_2;
            this.Heartbeats = new System.Collections.Generic.List<BestHTTP.Extensions.IHeartbeat>();
            val_2 = null;
            val_2 = null;
            this.LastUpdate = System.DateTime.MinValue;
        }
    
    }

}
