using UnityEngine;

namespace BestHTTP.SocketIO.Transports
{
    internal sealed class WebSocketTransport : ITransport
    {
        // Fields
        private BestHTTP.SocketIO.Transports.TransportStates <State>k__BackingField;
        private BestHTTP.SocketIO.SocketManager <Manager>k__BackingField;
        private BestHTTP.WebSocket.WebSocket <Implementation>k__BackingField;
        private BestHTTP.SocketIO.Packet PacketWithAttachment;
        private byte[] Buffer;
        
        // Properties
        public BestHTTP.SocketIO.Transports.TransportTypes Type { get; }
        public BestHTTP.SocketIO.Transports.TransportStates State { get; set; }
        public BestHTTP.SocketIO.SocketManager Manager { get; set; }
        public bool IsRequestInProgress { get; }
        public bool IsPollingInProgress { get; }
        public BestHTTP.WebSocket.WebSocket Implementation { get; set; }
        
        // Methods
        public BestHTTP.SocketIO.Transports.TransportTypes get_Type()
        {
            return 1;
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
            return false;
        }
        public bool get_IsPollingInProgress()
        {
            return false;
        }
        public BestHTTP.WebSocket.WebSocket get_Implementation()
        {
            return (BestHTTP.WebSocket.WebSocket)this.<Implementation>k__BackingField;
        }
        private void set_Implementation(BestHTTP.WebSocket.WebSocket value)
        {
            this.<Implementation>k__BackingField = value;
        }
        public WebSocketTransport(BestHTTP.SocketIO.SocketManager manager)
        {
            this.<State>k__BackingField = 3;
            this.<Manager>k__BackingField = manager;
        }
        public void Open()
        {
            string val_20;
            var val_21;
            string val_22;
            int val_23;
            if((this.<State>k__BackingField) != 3)
            {
                    return;
            }
            
            val_20 = "{0}?EIO={1}&transport=websocket{3}";
            if((this.<Manager>k__BackingField.<Handshake>k__BackingField) != null)
            {
                    val_20 = val_20 + "&sid={2}"("&sid={2}");
            }
            
            if((this.<Manager>k__BackingField.<Options>k__BackingField.<QueryParamsOnlyForHandshake>k__BackingField) == false)
            {
                goto label_16;
            }
            
            if((this.<Manager>k__BackingField.<Options>k__BackingField.<QueryParamsOnlyForHandshake>k__BackingField) == false)
            {
                goto label_19;
            }
            
            var val_9 = ((this.<Manager>k__BackingField.<Handshake>k__BackingField) == 0) ? 1 : 0;
            goto label_22;
            label_16:
            val_21 = 1;
            goto label_22;
            label_19:
            val_21 = 0;
            label_22:
            object[] val_10 = new object[4];
            val_10[0] = new System.UriBuilder(scheme:  ((BestHTTP.HTTPProtocolFactory.IsSecureProtocol(uri:  this.<Manager>k__BackingField.<Uri>k__BackingField)) != true) ? "wss" : "ws", host:  this.<Manager>k__BackingField.<Uri>k__BackingField.Host, port:  this.<Manager>k__BackingField.<Uri>k__BackingField.Port, pathValue:  BestHTTP.Extensions.Extensions.GetRequestPathAndQueryURL(uri:  this.<Manager>k__BackingField.<Uri>k__BackingField)).Uri;
            val_10[1] = 4;
            if((this.<Manager>k__BackingField.<Handshake>k__BackingField) != null)
            {
                    val_22 = this.<Manager>k__BackingField.<Handshake>k__BackingField.<Sid>k__BackingField;
            }
            
            val_10[2] = System.String.__il2cppRuntimeField_static_fields;
            if(val_21 == 0)
            {
                goto label_38;
            }
            
            val_23 = this.<Manager>k__BackingField.<Options>k__BackingField.BuildQueryParams();
            if(val_23 != null)
            {
                goto label_41;
            }
            
            goto label_44;
            label_38:
            val_23 = System.String.alignConst;
            if(val_23 == 0)
            {
                goto label_44;
            }
            
            label_41:
            label_44:
            val_10[3] = val_23;
            this.<Implementation>k__BackingField = new BestHTTP.WebSocket.WebSocket(uri:  new System.Uri(uriString:  System.String.Format(format:  val_20, args:  val_10)));
            .OnOpen = new BestHTTP.WebSocket.OnWebSocketOpenDelegate(object:  this, method:  System.Void BestHTTP.SocketIO.Transports.WebSocketTransport::OnOpen(BestHTTP.WebSocket.WebSocket ws));
            this.<Implementation>k__BackingField.OnMessage = new BestHTTP.WebSocket.OnWebSocketMessageDelegate(object:  this, method:  System.Void BestHTTP.SocketIO.Transports.WebSocketTransport::OnMessage(BestHTTP.WebSocket.WebSocket ws, string message));
            this.<Implementation>k__BackingField.OnBinary = new BestHTTP.WebSocket.OnWebSocketBinaryDelegate(object:  this, method:  System.Void BestHTTP.SocketIO.Transports.WebSocketTransport::OnBinary(BestHTTP.WebSocket.WebSocket ws, byte[] data));
            this.<Implementation>k__BackingField.OnError = new BestHTTP.WebSocket.OnWebSocketErrorDelegate(object:  this, method:  System.Void BestHTTP.SocketIO.Transports.WebSocketTransport::OnError(BestHTTP.WebSocket.WebSocket ws, System.Exception ex));
            this.<Implementation>k__BackingField.OnClosed = new BestHTTP.WebSocket.OnWebSocketClosedDelegate(object:  this, method:  System.Void BestHTTP.SocketIO.Transports.WebSocketTransport::OnClosed(BestHTTP.WebSocket.WebSocket ws, ushort code, string message));
            this.<Implementation>k__BackingField.Open();
            this.<State>k__BackingField = 0;
        }
        public void Close()
        {
            if((this.<State>k__BackingField) == 3)
            {
                    return;
            }
            
            this.<State>k__BackingField = 3;
            if((this.<Implementation>k__BackingField) != null)
            {
                    this.<Implementation>k__BackingField.Close();
            }
            else
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                BestHTTP.HTTPManager.Logger.Warning(division:  "WebSocketTransport", warn:  "Close - WebSocket Implementation already null!");
            }
            
            this.<Implementation>k__BackingField = 0;
        }
        public void Poll()
        {
        
        }
        private void OnOpen(BestHTTP.WebSocket.WebSocket ws)
        {
            string val_4;
            if((this.<Implementation>k__BackingField) != ws)
            {
                    return;
            }
            
            val_4 = "WebSocketTransport";
            var val_4 = 0;
            val_4 = val_4 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  val_4, info:  "OnOpen");
            this.<State>k__BackingField = 1;
            if((this.<Manager>k__BackingField.<UpgradingTransport>k__BackingField) != this)
            {
                    return;
            }
            
            .<Namespace>k__BackingField = "/";
            .<Payload>k__BackingField = "probe";
            .<TransportEvent>k__BackingField = ;
            this.Send(packet:  new BestHTTP.SocketIO.Packet());
        }
        private void OnMessage(BestHTTP.WebSocket.WebSocket ws, string message)
        {
            string val_25;
            System.Exception val_27;
            BestHTTP.SocketIO.Transports.WebSocketTransport val_32;
            if((this.<Implementation>k__BackingField) != ws)
            {
                    return;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    val_25 = "WebSocketTransport";
                var val_17 = 0;
                val_17 = val_17 + 1;
                val_27 = public System.Void BestHTTP.Logger.ILogger::Verbose(string division, string verb);
                BestHTTP.HTTPManager.Logger.Verbose(division:  val_25, verb:  "OnMessage: "("OnMessage: ") + message);
            }
            
            new BestHTTP.SocketIO.Packet() = new System.Object();
            new BestHTTP.SocketIO.Packet().Parse(from:  message);
            if(new BestHTTP.SocketIO.Packet() != null)
            {
                    if(((BestHTTP.SocketIO.Packet)[1152921553726095568].<AttachmentCount>k__BackingField) != 0)
            {
                    this.PacketWithAttachment = new BestHTTP.SocketIO.Packet();
                return;
            }
            
                this.OnPacket(packet:  new BestHTTP.SocketIO.Packet());
                return;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_32 = ???;
            BestHTTP.HTTPManager.Logger.Error(division:  "WebSocketTransport", err:  "Message parsing failed. Message: "("Message parsing failed. Message: ") + 1152921505556471808);
        }
        private void OnBinary(BestHTTP.WebSocket.WebSocket ws, byte[] data)
        {
            string val_32;
            BestHTTP.SocketIO.Packet val_33;
            System.Collections.Generic.List<System.Byte[]> val_34;
            BestHTTP.SocketIO.Packet val_35;
            System.Collections.Generic.List<System.Byte[]> val_36;
            if((this.<Implementation>k__BackingField) != ws)
            {
                    return;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                BestHTTP.HTTPManager.Logger.Verbose(division:  "WebSocketTransport", verb:  "OnBinary");
            }
            
            if(this.PacketWithAttachment == null)
            {
                    return;
            }
            
            this.PacketWithAttachment.AddAttachmentFromServer(data:  data, copyFull:  false);
            if(this.PacketWithAttachment.HasAllAttachment == false)
            {
                    return;
            }
            
            if(this.PacketWithAttachment != null)
            {
                    val_32 = this.PacketWithAttachment.<Payload>k__BackingField;
            }
            else
            {
                    val_32 = 0;
            }
            
            this.PacketWithAttachment.<OriginalPayload>k__BackingField = val_32;
            val_33 = this.PacketWithAttachment;
            if(val_33 != null)
            {
                    val_34 = this.PacketWithAttachment.attachments;
            }
            else
            {
                    val_34 = this.PacketWithAttachment.attachments;
                if(this.PacketWithAttachment != null)
            {
                    val_33 = this.PacketWithAttachment;
            }
            else
            {
                    val_33 = 0;
            }
            
            }
            
            System.Byte[] val_13 = this.<Manager>k__BackingField.Extras.丘丞丕丏一丌三丟丅(丕丑丏世上丄丐且丑:  val_34.Item[1.Count - 2]);
            bool val_16 = this.PacketWithAttachment.ReplacePlaceholderWithNumber(number:  this.PacketWithAttachment.attachments.Count - 2, switch:  System.Text.Encoding.UTF8);
            val_35 = this.PacketWithAttachment;
            if(val_35 != null)
            {
                    val_36 = this.PacketWithAttachment.attachments;
            }
            else
            {
                    val_36 = this.PacketWithAttachment.attachments;
                if(this.PacketWithAttachment != null)
            {
                    val_35 = this.PacketWithAttachment;
            }
            else
            {
                    val_35 = 0;
            }
            
            }
            
            System.Byte[] val_22 = this.<Manager>k__BackingField.Extras.丘丞丕丏一丌三丟丅(丕丑丏世上丄丐且丑:  val_36.Item[1.Count - 1]);
            bool val_25 = this.PacketWithAttachment.ReplacePlaceholderWithNumber(number:  this.PacketWithAttachment.attachments.Count - 1, switch:  System.Text.Encoding.UTF8);
            this.OnPacket(packet:  this.PacketWithAttachment);
            this.PacketWithAttachment = 0;
        }
        private void OnError(BestHTTP.WebSocket.WebSocket ws, System.Exception ex)
        {
            string val_37;
            var val_38;
            BestHTTP.SocketIO.SocketManager val_40;
            var val_41;
            val_37 = ex;
            if((this.<Implementation>k__BackingField) != ws)
            {
                    return;
            }
            
            if(val_37 == null)
            {
                goto label_2;
            }
            
            val_38 = 0;
            val_37 = val_37 + " " + val_37;
            goto label_54;
            label_2:
            val_37 = System.String.alignConst;
            if((ws.InternalRequest.State - 3) > 4)
            {
                goto label_54;
            }
            
            var val_36 = 106066712 + ((val_3 - 3)) << 2;
            val_36 = val_36 + 106066712;
            goto (106066712 + ((val_3 - 3)) << 2 + 106066712);
            label_54:
            val_40 = this.<Manager>k__BackingField;
            if(val_40 == null)
            {
                goto label_35;
            }
            
            if((this.<Manager>k__BackingField.<UpgradingTransport>k__BackingField) != this)
            {
                goto label_39;
            }
            
            goto label_37;
            label_35:
            if((this.<Manager>k__BackingField) == null)
            {
                goto label_38;
            }
            
            val_40 = this.<Manager>k__BackingField;
            if((this.<Manager>k__BackingField.<UpgradingTransport>k__BackingField) != this)
            {
                goto label_39;
            }
            
            label_37:
            this.<Manager>k__BackingField.<UpgradingTransport>k__BackingField = 0;
            return;
            label_38:
            val_40 = 0;
            label_39:
            if(mem[282584257676957] == 0)
            {
                goto label_44;
            }
            
            var val_37 = mem[282584257676847];
            var val_38 = 0;
            val_37 = val_37 + 8;
            label_43:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_38 = val_38 + 1;
            val_37 = val_37 + 16;
            if(val_38 < mem[282584257676957])
            {
                goto label_43;
            }
            
            goto label_44;
            label_42:
            var val_39 = val_37;
            val_39 = val_39 + 4;
            val_40 = val_40 + val_39;
            val_41 = val_40 + 296;
            label_44:
            val_40.OnTransportError(trans:  this, err:  System.String.__il2cppRuntimeField_static_fields);
        }
        private void OnClosed(BestHTTP.WebSocket.WebSocket ws, ushort code, string message)
        {
            BestHTTP.SocketIO.SocketManager val_5;
            var val_6;
            if((this.<Implementation>k__BackingField) != ws)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "WebSocketTransport", info:  "OnClosed");
            this.Close();
            val_5 = this.<Manager>k__BackingField;
            if(val_5 == null)
            {
                goto label_9;
            }
            
            if((this.<Manager>k__BackingField.<UpgradingTransport>k__BackingField) != this)
            {
                goto label_13;
            }
            
            goto label_11;
            label_9:
            if((this.<Manager>k__BackingField) == null)
            {
                goto label_12;
            }
            
            val_5 = this.<Manager>k__BackingField;
            if((this.<Manager>k__BackingField.<UpgradingTransport>k__BackingField) != this)
            {
                goto label_13;
            }
            
            label_11:
            this.<Manager>k__BackingField.<UpgradingTransport>k__BackingField = 0;
            return;
            label_12:
            val_5 = 0;
            label_13:
            if(mem[282584257676957] == 0)
            {
                goto label_18;
            }
            
            var val_4 = mem[282584257676847];
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_17:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_16;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < mem[282584257676957])
            {
                goto label_17;
            }
            
            goto label_18;
            label_16:
            var val_6 = val_4;
            val_6 = val_6 + 2;
            val_5 = val_5 + val_6;
            val_6 = val_5 + 296;
            label_18:
            val_5.TryToReconnect();
        }
        public void Send(BestHTTP.SocketIO.Packet packet)
        {
            string val_27;
            int val_28;
            string val_30;
            var val_31;
            var val_33;
            string val_35;
            BestHTTP.SocketIO.Transports.TransportStates val_26 = this.<State>k__BackingField;
            val_26 = val_26 - 3;
            if(val_26 < 2)
            {
                    return;
            }
            
            val_28 = 1152921505553330176;
            val_27 = packet.Encode();
            var val_27 = 0;
            val_27 = val_27 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                goto label_10;
            }
            
            label_64:
            if((packet.<AttachmentCount>k__BackingField) == 0)
            {
                goto label_12;
            }
            
            label_30:
            if(packet.attachments == null)
            {
                goto label_13;
            }
            
            if((packet.<AttachmentCount>k__BackingField) != packet.attachments.Count)
            {
                goto label_14;
            }
            
            label_31:
            this.<Implementation>k__BackingField.Send(message:  val_27);
            if(LogController.AnyLogEnabled == false)
            {
                goto label_18;
            }
            
            if((packet.<SocketIOEvent>k__BackingField) != 5)
            {
                    if((packet.<SocketIOEvent>k__BackingField) != 2)
            {
                goto label_20;
            }
            
            }
            
            val_30 = packet.<OriginalPayload>k__BackingField;
            val_31 = 102738428;
            goto label_21;
            label_10:
            var val_28 = 0;
            val_28 = val_28 + 1;
            goto label_28;
            label_12:
            if(packet.attachments == null)
            {
                goto label_31;
            }
            
            if(packet.attachments.Count != 0)
            {
                goto label_30;
            }
            
            goto label_31;
            label_20:
            val_30 = packet.Encode();
            val_31 = null;
            label_21:
            label_18:
            if((packet.<AttachmentCount>k__BackingField) == 0)
            {
                goto label_45;
            }
            
            System.Byte[] val_13 = packet.attachments.Item[0];
            val_27 = 1152921518979101712;
            val_33 = 1;
            val_28 = val_13.Length + 1;
            goto label_35;
            label_42:
            System.Byte[] val_14 = packet.attachments.Item[1];
            int val_29 = val_14.Length;
            val_29 = val_29 + 1;
            if(val_29 > val_28)
            {
                    System.Byte[] val_15 = packet.attachments.Item[1];
                val_28 = val_15.Length + 1;
            }
            
            val_33 = 2;
            label_35:
            if(val_33 < packet.attachments.Count)
            {
                goto label_42;
            }
            
            System.Byte[] val_17 = this.Buffer;
            if(val_17 != null)
            {
                    if(val_28 <= this.Buffer.Length)
            {
                goto label_44;
            }
            
            }
            
            System.Array.Resize<System.Byte>(array: ref  val_17, newSize:  val_28);
            label_44:
            if((packet.<AttachmentCount>k__BackingField) < 1)
            {
                goto label_45;
            }
            
            val_27 = 4;
            goto label_59;
            label_55:
            if(packet.attachments != null)
            {
                goto label_48;
            }
            
            goto label_48;
            label_59:
            val_17[0] = val_27;
            System.Byte[] val_19 = packet.attachments.Item[0];
            System.Array.Copy(sourceArray:  packet.attachments.Item[0], sourceIndex:  0, destinationArray:  val_17, destinationIndex:  1, length:  val_19.Length);
            if(packet.attachments.Item[0] == null)
            {
                goto label_55;
            }
            
            label_48:
            this.<Implementation>k__BackingField.Send(buffer:  this.Buffer, offset:  0, count:  val_20.Length + 1);
            bool val_22 = LogController.AnyLogEnabled;
            val_28 = 0 + 1;
            if(val_28 < (packet.<AttachmentCount>k__BackingField))
            {
                goto label_59;
            }
            
            label_45:
            if(LogController.AnyLogEnabled == false)
            {
                    return;
            }
            
            this.LogSend(packet:  packet, sendLog:  new System.Text.StringBuilder(value:  val_30));
            return;
            label_28:
            BestHTTP.HTTPManager.Logger.Verbose(division:  "WebSocketTransport", verb:  "Send: "("Send: ") + val_27);
            if(packet != null)
            {
                goto label_64;
            }
            
            goto label_64;
            label_13:
            val_35 = "packet.Attachments are null!";
            goto label_65;
            label_14:
            val_35 = "packet.AttachmentCount != packet.Attachments.Count. Use the packet.AddAttachment function to add data to a packet!";
            label_65:
            null = new System.ArgumentException(message:  val_35);
        }
        private void LogSend(BestHTTP.SocketIO.Packet packet, System.Text.StringBuilder sendLog)
        {
            string val_9;
            string val_10;
            var val_11;
            string val_12;
            string val_13;
            var val_14;
            var val_15;
            val_9 = sendLog;
            if((packet.<TransportEvent>k__BackingField) == 2)
            {
                    return;
            }
            
            val_10 = packet.<OriginalEventName>k__BackingField;
            if((packet.<SocketIOEvent>k__BackingField) != 5)
            {
                    if((packet.<SocketIOEvent>k__BackingField) != 2)
            {
                goto label_4;
            }
            
            }
            
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                goto label_5;
            }
            
            val_11 = "<color=yellow>SEND</color> ";
            val_10 = LogController.ColorEvent(丝丏业丅丈东业丝丒:  val_10);
            goto label_8;
            label_4:
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                goto label_9;
            }
            
            val_12 = "<color=yellow>SEND</color> ";
            val_10 = LogController.ColorEvent(丝丏业丅丈东业丝丒:  val_10);
            goto label_12;
            label_5:
            val_11 = "SEND ";
            label_8:
            val_13 = System.Environment.NewLine;
            val_14 = val_11;
            goto label_13;
            label_9:
            val_12 = "SEND ";
            label_12:
            val_13 = " ";
            label_13:
            string val_6 = val_12 + val_10 + val_13;
            val_15 = 2;
            string[] val_8 = new string[2];
            if((val_6 != null) && (val_6 == null))
            {
                    val_15 = 0;
            }
            
            if(val_8.Length == 0)
            {
                    val_15 = 0;
            }
            
            val_8[0] = val_6;
            if(val_9 != null)
            {
                    val_9 = val_9;
            }
            
            val_8[1] = val_9;
            LogController.Instance.AddMessage(丝东丗丕丛丞丝且丕:  this.<Manager>k__BackingField, 丛专丛丕一与丅丝丁:  val_8);
        }
        public void Send(System.Collections.Generic.List<BestHTTP.SocketIO.Packet> packets)
        {
            var val_4 = 0;
            goto label_1;
            label_3:
            if(val_4 >= packets.Count)
            {
                goto label_2;
            }
            
            label_4:
            this.Send(packet:  packets.Item[0]);
            val_4 = 1;
            label_1:
            if(packets == null)
            {
                goto label_3;
            }
            
            if(val_4 < packets.Count)
            {
                goto label_4;
            }
            
            label_2:
            packets.Clear();
        }
        private void OnPacket(BestHTTP.SocketIO.Packet packet)
        {
            var val_9;
            var val_10;
            string val_13;
            if(LogController.AnyLogEnabled != false)
            {
                    this.LogRecieve(packet:  packet);
            }
            
            if((packet.<TransportEvent>k__BackingField) == 3)
            {
                goto label_5;
            }
            
            if((packet.<TransportEvent>k__BackingField) != 0)
            {
                goto label_24;
            }
            
            if((this.<State>k__BackingField) != 1)
            {
                goto label_7;
            }
            
            this.<State>k__BackingField = 2;
            goto label_24;
            label_5:
            val_9 = 0;
            if((System.String.op_Equality(a:  packet.<Payload>k__BackingField, b:  "probe")) == false)
            {
                goto label_24;
            }
            
            this.<State>k__BackingField = 2;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = 5;
            goto label_14;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_23;
            label_14:
            val_13 = public System.Void BestHTTP.SocketIO.IManager::OnTransportProbed(BestHTTP.SocketIO.Transports.ITransport trans);
            this.<Manager>k__BackingField.OnTransportProbed(trans:  this);
            goto label_24;
            label_23:
            val_13 = "Received \'Open\' packet while state is \'" + this.<State>k__BackingField.ToString()(this.<State>k__BackingField.ToString()) + "\'";
            BestHTTP.HTTPManager.Logger.Warning(division:  "WebSocketTransport", warn:  val_13);
            label_24:
            if((this.<Manager>k__BackingField.<UpgradingTransport>k__BackingField) == this)
            {
                    return;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = 7;
            this.<Manager>k__BackingField.OnPacket(packet:  packet);
        }
        private void LogRecieve(BestHTTP.SocketIO.Packet packet)
        {
            var val_17;
            string val_18;
            System.Collections.Generic.List<System.Byte[]> val_19;
            string val_20;
            var val_21;
            string val_22;
            string val_23;
            var val_24;
            var val_25;
            val_18 = packet;
            if((packet.<TransportEvent>k__BackingField) == 3)
            {
                    return;
            }
            
            BestHTTP.SocketIO.Packet val_1 = val_18.Clone();
            var val_17 = 0;
            label_8:
            val_19 = val_1.attachments;
            if(val_19 != null)
            {
                    int val_5 = (val_19 == 0) ? 0 : (val_19).Count;
                val_19 = 0;
            }
            
            if(val_17 >= val_19.丙东专丂世丈丏丁丂())
            {
                goto label_7;
            }
            
            val_17 = val_17 + 1;
            if((1877590600 & 1) != 0)
            {
                goto label_8;
            }
            
            label_7:
            val_20 = val_1.Clone().DecodeEventName();
            if((val_1.<SocketIOEvent>k__BackingField) != 5)
            {
                    if((val_1.<SocketIOEvent>k__BackingField) != 2)
            {
                goto label_11;
            }
            
            }
            
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                goto label_12;
            }
            
            val_21 = "<color=cyan>RECEIVE</color> ";
            val_20 = LogController.ColorEvent(丝丏业丅丈东业丝丒:  val_20);
            goto label_15;
            label_11:
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                goto label_16;
            }
            
            val_22 = "<color=cyan>RECEIVE</color> ";
            val_20 = LogController.ColorEvent(丝丏业丅丈东业丝丒:  val_20);
            goto label_19;
            label_12:
            val_21 = "RECEIVE ";
            label_15:
            val_23 = System.Environment.NewLine;
            val_24 = val_21;
            goto label_20;
            label_16:
            val_22 = "RECEIVE ";
            label_19:
            val_23 = " ";
            label_20:
            string val_14 = val_22 + val_20 + val_23;
            val_17 = LogController.Instance;
            val_25 = 2;
            string[] val_16 = new string[2];
            if((val_14 != null) && (val_14 == null))
            {
                    val_25 = 0;
            }
            
            if(val_16.Length == 0)
            {
                    val_25 = 0;
            }
            
            val_16[0] = val_14;
            val_18 = new System.Text.StringBuilder(value:  val_1.Encode());
            val_16[1] = val_18;
            val_17.AddMessage(丝东丗丕丛丞丝且丕:  this.<Manager>k__BackingField, 丛专丛丕一与丅丝丁:  val_16);
        }
    
    }

}
