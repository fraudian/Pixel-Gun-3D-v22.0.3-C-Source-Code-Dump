using UnityEngine;

namespace BestHTTP.SocketIO.Transports
{
    internal sealed class PollingTransport : ITransport
    {
        // Fields
        private BestHTTP.SocketIO.Transports.TransportStates <State>k__BackingField;
        private BestHTTP.SocketIO.SocketManager <Manager>k__BackingField;
        private BestHTTP.HTTPRequest LastRequest;
        private BestHTTP.HTTPRequest PollRequest;
        private BestHTTP.SocketIO.Packet PacketWithAttachment;
        private System.Collections.Generic.List<BestHTTP.SocketIO.Packet> lonelyPacketList;
        
        // Properties
        public BestHTTP.SocketIO.Transports.TransportTypes Type { get; }
        public BestHTTP.SocketIO.Transports.TransportStates State { get; set; }
        public BestHTTP.SocketIO.SocketManager Manager { get; set; }
        public bool IsRequestInProgress { get; }
        public bool IsPollingInProgress { get; }
        
        // Methods
        public BestHTTP.SocketIO.Transports.TransportTypes get_Type()
        {
            return 0;
        }
        public BestHTTP.SocketIO.Transports.TransportStates get_State()
        {
            return (BestHTTP.SocketIO.Transports.TransportStates)this.<State>k__BackingField;
        }
        private void set_State(BestHTTP.SocketIO.Transports.TransportStates value)
        {
            this.<State>k__BackingField = value;
        }
        public BestHTTP.SocketIO.SocketManager get_Manager()
        {
            return (BestHTTP.SocketIO.SocketManager)this.<Manager>k__BackingField;
        }
        private void set_Manager(BestHTTP.SocketIO.SocketManager value)
        {
            this.<Manager>k__BackingField = value;
        }
        public bool get_IsRequestInProgress()
        {
            return (bool)(this.LastRequest != 0) ? 1 : 0;
        }
        public bool get_IsPollingInProgress()
        {
            return (bool)(this.PollRequest != 0) ? 1 : 0;
        }
        public PollingTransport(BestHTTP.SocketIO.SocketManager manager)
        {
            this.lonelyPacketList = new System.Collections.Generic.List<BestHTTP.SocketIO.Packet>(capacity:  1);
            this.<Manager>k__BackingField = manager;
        }
        public void Open()
        {
            string val_12;
            var val_13;
            var val_14;
            BestHTTP.SocketIO.SocketManager val_15;
            ulong val_16;
            string val_17;
            int val_18;
            val_12 = "{0}?EIO={1}&transport=polling&t={2}-{3}{5}";
            if((this.<Manager>k__BackingField.<Handshake>k__BackingField) != null)
            {
                    val_12 = val_12 + "&sid={4}"("&sid={4}");
            }
            
            if((this.<Manager>k__BackingField.<Options>k__BackingField.<QueryParamsOnlyForHandshake>k__BackingField) == false)
            {
                goto label_5;
            }
            
            if((this.<Manager>k__BackingField.<Options>k__BackingField.<QueryParamsOnlyForHandshake>k__BackingField) == false)
            {
                goto label_8;
            }
            
            var val_2 = ((this.<Manager>k__BackingField.<Handshake>k__BackingField) == 0) ? 1 : 0;
            goto label_11;
            label_5:
            val_13 = 1;
            goto label_11;
            label_8:
            val_13 = 0;
            label_11:
            object[] val_3 = new object[6];
            val_3[0] = this.<Manager>k__BackingField.<Uri>k__BackingField;
            if(4 != 0)
            {
                    val_14 = 4;
            }
            
            val_3[1] = 4;
            if((this.<Manager>k__BackingField) == null)
            {
                    val_14 = 0;
            }
            
            val_3[2] = val_14.Timestamp.ToString();
            val_15 = this.<Manager>k__BackingField;
            if(val_15 != null)
            {
                    val_16 = this.<Manager>k__BackingField.<RequestCounter>k__BackingField;
            }
            else
            {
                    val_15 = 64;
                val_16 = 1;
            }
            
            mem[64] = 21474836482;
            val_3[3] = val_16.ToString();
            if((this.<Manager>k__BackingField.<Handshake>k__BackingField) != null)
            {
                    val_17 = this.<Manager>k__BackingField.<Handshake>k__BackingField.<Sid>k__BackingField;
            }
            
            val_3[4] = System.String.__il2cppRuntimeField_static_fields;
            if(val_13 == 0)
            {
                goto label_38;
            }
            
            val_18 = this.<Manager>k__BackingField.<Options>k__BackingField.BuildQueryParams();
            if(val_18 != null)
            {
                goto label_41;
            }
            
            goto label_44;
            label_38:
            val_18 = System.String.alignConst;
            if(val_18 == 0)
            {
                goto label_44;
            }
            
            label_41:
            label_44:
            val_3[5] = val_18;
            mem[1152921553720890112] = this;
            mem[1152921553720890120] = System.Void BestHTTP.SocketIO.Transports.PollingTransport::OnRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp);
            mem[1152921553720890096] = System.Void BestHTTP.SocketIO.Transports.PollingTransport::OnRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp);
            BestHTTP.HTTPRequest val_10 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  System.String.Format(format:  val_12, args:  val_3)), callback:  new BestHTTP.OnRequestFinishedDelegate());
            if(val_10 != null)
            {
                    val_10.DisableCache = true;
                val_10.DisableRetry = true;
            }
            else
            {
                    val_10.DisableCache = true;
                val_10.DisableRetry = true;
            }
            
            BestHTTP.HTTPRequest val_11 = val_10.Send();
            this.<State>k__BackingField = 1;
        }
        public void Close()
        {
            if((this.<State>k__BackingField) == 3)
            {
                    return;
            }
            
            this.<State>k__BackingField = 3;
        }
        public void Send(BestHTTP.SocketIO.Packet packet)
        {
            System.Collections.Generic.List<BestHTTP.SocketIO.Packet> val_6;
            this.lonelyPacketList.Add(item:  packet);
            this.Send(packets:  this.lonelyPacketList);
            val_6 = this.lonelyPacketList;
            val_6.Clear();
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_6 = ???;
        }
        public void Send(System.Collections.Generic.List<BestHTTP.SocketIO.Packet> packets)
        {
            System.Byte[] val_21;
            BestHTTP.SocketIO.Transports.PollingTransport val_22;
            var val_23;
            var val_24;
            BestHTTP.SocketIO.SocketManager val_25;
            ulong val_26;
            int val_27;
            var val_28;
            val_22 = this;
            BestHTTP.SocketIO.Transports.TransportStates val_21 = this.<State>k__BackingField;
            val_21 = val_21 - 1;
            if(val_21 > 1)
            {
                    return;
            }
            
            if(this.LastRequest != null)
            {
                goto label_60;
            }
            
            System.Byte[] val_6 = packets.Item[0].EncodeBinary();
            val_23 = 1;
            goto label_5;
            label_12:
            System.Array.Resize<System.Byte>(array: ref  val_6, newSize:  val_4.Length + (val_2 + 24));
            System.Array.Copy(sourceArray:  packets.Item[1].EncodeBinary(), sourceIndex:  0, destinationArray:  val_6, destinationIndex:  (val_2 + 24) - val_4.Length, length:  val_4.Length);
            val_23 = 2;
            label_5:
            if(val_23 < packets.Count)
            {
                goto label_12;
            }
            
            packets.Clear();
            object[] val_9 = new object[6];
            val_9[0] = this.<Manager>k__BackingField.<Uri>k__BackingField;
            if(4 != 0)
            {
                    val_24 = 4;
            }
            
            val_9[1] = 4;
            if((this.<Manager>k__BackingField) == null)
            {
                    val_24 = 0;
            }
            
            val_9[2] = val_24.Timestamp.ToString();
            val_25 = this.<Manager>k__BackingField;
            if(val_25 != null)
            {
                    val_26 = this.<Manager>k__BackingField.<RequestCounter>k__BackingField;
            }
            else
            {
                    val_25 = 64;
                val_26 = 1;
            }
            
            mem[64] = 21474836482;
            val_9[3] = val_26.ToString();
            val_9[4] = this.<Manager>k__BackingField.<Handshake>k__BackingField.<Sid>k__BackingField;
            if((this.<Manager>k__BackingField.<Options>k__BackingField.<QueryParamsOnlyForHandshake>k__BackingField) == false)
            {
                goto label_39;
            }
            
            val_27 = System.String.alignConst;
            if(val_27 != 0)
            {
                goto label_40;
            }
            
            goto label_45;
            label_39:
            val_27 = this.<Manager>k__BackingField.<Options>k__BackingField.BuildQueryParams();
            if(val_27 == null)
            {
                goto label_45;
            }
            
            label_40:
            label_45:
            val_9[5] = val_27;
            mem[1152921553721654576] = val_22;
            mem[1152921553721654584] = System.Void BestHTTP.SocketIO.Transports.PollingTransport::OnRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp);
            mem[1152921553721654560] = System.Void BestHTTP.SocketIO.Transports.PollingTransport::OnRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp);
            BestHTTP.HTTPRequest val_16 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  System.String.Format(format:  "{0}?EIO={1}&transport=polling&t={2}-{3}&sid={4}{5}", args:  val_9)), methodType:  2, callback:  new BestHTTP.OnRequestFinishedDelegate());
            this.LastRequest = val_16;
            val_16.DisableCache = true;
            this.LastRequest.SetHeader(name:  "Content-Type", value:  "application/octet-stream");
            val_21 = val_6;
            this.LastRequest.RawData = val_21;
            val_22 = this.LastRequest;
            BestHTTP.HTTPRequest val_17 = val_22.Send();
            return;
            label_60:
            val_28 = new System.Exception(message:  "Sending packets are still in progress!");
            if(0 == 1)
            {
                    if((null & 1) != 0)
            {
                    val_22 = (System.Exception)[1152921553721679120]._message;
                val_21 = 1152921504619732992;
                var val_22 = 0;
                val_22 = val_22 + 1;
                val_22.EmitError(errCode:  4, msg:  val_21 + " " + 1152921504619732992);
                return;
            }
            
                mem[8] = null;
                val_28 = 8;
            }
        
        }
        private void OnRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp)
        {
            string val_29;
            string val_36;
            val_29 = resp;
            this.LastRequest = 0;
            if((this.<State>k__BackingField) == 3)
            {
                    return;
            }
            
            if((req.State - 3) <= 4)
            {
                    var val_30 = 106066672 + ((val_1 - 3)) << 2;
                val_30 = val_30 + 106066672;
            }
            else
            {
                    val_36 = 0;
                if((System.String.IsNullOrEmpty(value:  val_36)) == true)
            {
                    return;
            }
            
                val_29 = this.<Manager>k__BackingField;
                var val_33 = 0;
                val_33 = val_33 + 1;
                val_29.OnTransportError(trans:  this, err:  val_36);
            }
        
        }
        public void Poll()
        {
            BestHTTP.SocketIO.Transports.PollingTransport val_10;
            var val_11;
            BestHTTP.SocketIO.SocketManager val_12;
            ulong val_13;
            int val_14;
            val_10 = this;
            if(this.PollRequest != null)
            {
                    return;
            }
            
            if((this.<State>k__BackingField) == 4)
            {
                    return;
            }
            
            object[] val_1 = new object[6];
            val_1[0] = this.<Manager>k__BackingField.<Uri>k__BackingField;
            if(4 != 0)
            {
                    val_11 = 4;
            }
            
            val_1[1] = 4;
            if((this.<Manager>k__BackingField) == null)
            {
                    val_11 = 0;
            }
            
            val_1[2] = val_11.Timestamp.ToString();
            val_12 = this.<Manager>k__BackingField;
            if(val_12 != null)
            {
                    val_13 = this.<Manager>k__BackingField.<RequestCounter>k__BackingField;
            }
            else
            {
                    val_12 = 64;
                val_13 = 1;
            }
            
            mem[64] = 21474836482;
            val_1[3] = val_13.ToString();
            val_1[4] = this.<Manager>k__BackingField.<Handshake>k__BackingField.<Sid>k__BackingField;
            if((this.<Manager>k__BackingField.<Options>k__BackingField.<QueryParamsOnlyForHandshake>k__BackingField) == false)
            {
                goto label_28;
            }
            
            val_14 = System.String.alignConst;
            if(val_14 != 0)
            {
                goto label_29;
            }
            
            goto label_34;
            label_28:
            val_14 = this.<Manager>k__BackingField.<Options>k__BackingField.BuildQueryParams();
            if(val_14 == null)
            {
                goto label_34;
            }
            
            label_29:
            label_34:
            val_1[5] = val_14;
            mem[1152921553722302864] = val_10;
            mem[1152921553722302872] = System.Void BestHTTP.SocketIO.Transports.PollingTransport::OnPollRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp);
            mem[1152921553722302848] = System.Void BestHTTP.SocketIO.Transports.PollingTransport::OnPollRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp);
            BestHTTP.HTTPRequest val_8 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  System.String.Format(format:  "{0}?EIO={1}&transport=polling&t={2}-{3}&sid={4}{5}", args:  val_1)), methodType:  0, callback:  new BestHTTP.OnRequestFinishedDelegate());
            this.PollRequest = val_8;
            val_8.DisableCache = true;
            this.PollRequest.DisableRetry = true;
            val_10 = this.PollRequest;
            BestHTTP.HTTPRequest val_9 = val_10.Send();
        }
        private void OnPollRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp)
        {
            string val_27;
            string val_34;
            val_27 = resp;
            this.PollRequest = 0;
            if((this.<State>k__BackingField) == 3)
            {
                    return;
            }
            
            if((req.State - 3) <= 4)
            {
                    var val_28 = 106066692 + ((val_1 - 3)) << 2;
                val_28 = val_28 + 106066692;
            }
            else
            {
                    val_34 = 0;
                if((System.String.IsNullOrEmpty(value:  val_34)) == true)
            {
                    return;
            }
            
                val_27 = this.<Manager>k__BackingField;
                var val_31 = 0;
                val_31 = val_31 + 1;
                val_27.OnTransportError(trans:  this, err:  val_34);
            }
        
        }
        private void OnPacket(BestHTTP.SocketIO.Packet packet)
        {
            var val_7;
            string val_9;
            if((packet.<AttachmentCount>k__BackingField) != 0)
            {
                    if(packet.HasAllAttachment == false)
            {
                goto label_3;
            }
            
            }
            
            if((packet.<TransportEvent>k__BackingField) == 4)
            {
                goto label_4;
            }
            
            if((packet.<TransportEvent>k__BackingField) != 0)
            {
                goto label_18;
            }
            
            if((this.<State>k__BackingField) == 1)
            {
                goto label_6;
            }
            
            val_7 = BestHTTP.HTTPManager.Logger;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_15;
            label_3:
            this.PacketWithAttachment = packet;
            return;
            label_4:
            if((packet.<SocketIOEvent>k__BackingField) != 0)
            {
                goto label_18;
            }
            
            label_6:
            this.<State>k__BackingField = 2;
            goto label_18;
            label_15:
            val_9 = "Received \'Open\' packet while state is \'" + this.<State>k__BackingField.ToString()(this.<State>k__BackingField.ToString()) + "\'";
            val_7.Warning(division:  "PollingTransport", warn:  val_9);
            label_18:
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = 7;
            this.<Manager>k__BackingField.OnPacket(packet:  packet);
        }
        private void ParseResponse(BestHTTP.HTTPResponse resp)
        {
            var val_26;
            var val_27;
            int val_28;
            int val_29;
            var val_31;
            var val_36;
            var val_37;
            if(resp == null)
            {
                    return;
            }
            
            if(resp.Data == null)
            {
                    return;
            }
            
            val_26 = resp.Data;
            if(val_2.Length < 1)
            {
                    return;
            }
            
            val_27 = 1152921505555779584;
            label_29:
            val_26 = resp.Data;
            if(0 >= val_3.Length)
            {
                    return;
            }
            
            if(resp.Data[0] <= 47)
            {
                goto label_9;
            }
            
            byte val_26 = resp.Data[0];
            val_28 = 0 + 1;
            val_29 = 0;
            if(val_26 == 58)
            {
                goto label_16;
            }
            
            do
            {
                var val_7 = val_29 * 10;
                val_7 = val_7 + val_26;
                val_29 = val_7 - 48;
                val_28 = val_28 + 1;
            }
            while(resp.Data[(long)val_28] != 58);
            
            goto label_16;
            label_9:
            byte val_28 = resp.Data[0];
            byte val_29 = resp.Data[(long)0 + 1];
            val_28 = 0 + 2;
            val_29 = 0;
            if(val_29 != 255)
            {
                    do
            {
                val_29 = (val_29 * 10) + val_29;
                val_28 = val_28 + 1;
            }
            while(resp.Data[(long)val_28] != 255);
            
            }
            
            if(val_28 == 1)
            {
                goto label_25;
            }
            
            val_27 = 1152921505555779584;
            if(val_28 != 0)
            {
                goto label_52;
            }
            
            label_16:
            System.Byte[] val_14 = resp.Data;
            new BestHTTP.SocketIO.Packet() = new System.Object();
            new BestHTTP.SocketIO.Packet().Parse(from:  System.Text.Encoding.UTF8);
            if(new BestHTTP.SocketIO.Packet() == null)
            {
                goto label_52;
            }
            
            label_34:
            this.OnPacket(packet:  new BestHTTP.SocketIO.Packet());
            label_52:
            val_28 = val_29 + val_28;
            goto label_29;
            label_25:
            if(this.PacketWithAttachment == null)
            {
                goto label_52;
            }
            
            val_29 = val_29 - 1;
            byte[] val_16 = new byte[0];
            val_28 = val_28 + 1;
            System.Array.Copy(sourceArray:  resp.Data, sourceIndex:  val_28, destinationArray:  val_16, destinationIndex:  0, length:  val_29);
            this.PacketWithAttachment.AddAttachmentFromServer(data:  val_16, copyFull:  true);
            if(this.PacketWithAttachment.HasAllAttachment == false)
            {
                goto label_52;
            }
            
            this.PacketWithAttachment = 0;
            if(this.PacketWithAttachment != null)
            {
                goto label_34;
            }
            
            goto label_52;
            label_50:
            if(((mem[1152921553723357224] + 176 + 8) + -8) == null)
            {
                goto label_49;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[1152921553723357224] + 286))
            {
                goto label_50;
            }
            
            goto label_51;
            label_49:
            var val_34 = ;
            val_34 = val_34 + 10;
             =  + val_34;
            val_31 =  + 296;
            label_51:
            mem[1152921553723357224].EmitError(errCode:  4, msg:  null);
            goto label_52;
            label_101:
            if(((mem[1152921553723357224] + 176 + 8) + -8) == null)
            {
                goto label_100;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[1152921553723357224] + 286))
            {
                goto label_101;
            }
            
            goto label_102;
            label_100:
            var val_38 = ;
            val_38 = val_38 + 10;
             =  + val_38;
            val_37 =  + 296;
            label_102:
            mem[1152921553723357224].EmitError(errCode:  4, msg:   + " " +);
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_36 = ???;
            BestHTTP.HTTPManager.Logger.Exception(division:  "PollingTransport", msg:  "ParseResponse", ex:  null);
        }
    
    }

}
