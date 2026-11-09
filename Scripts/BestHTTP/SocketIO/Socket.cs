using UnityEngine;

namespace BestHTTP.SocketIO
{
    public sealed class Socket : ISocket
    {
        // Fields
        private BestHTTP.SocketIO.SocketManager <Manager>k__BackingField;
        private string <Namespace>k__BackingField;
        private string <Id>k__BackingField;
        private bool <IsOpen>k__BackingField;
        private bool <AutoDecodePayload>k__BackingField;
        private System.Collections.Generic.Dictionary<int, BestHTTP.SocketIO.Events.SocketIOAckCallback> AckCallbacks;
        private BestHTTP.SocketIO.Events.EventTable EventCallbacks;
        private System.Collections.Generic.List<object> arguments;
        
        // Properties
        public BestHTTP.SocketIO.SocketManager Manager { get; set; }
        public string Namespace { get; set; }
        public string Id { get; set; }
        public bool IsOpen { get; set; }
        public bool AutoDecodePayload { get; set; }
        
        // Methods
        public BestHTTP.SocketIO.SocketManager get_Manager()
        {
            return (BestHTTP.SocketIO.SocketManager)this.<Manager>k__BackingField;
        }
        private void set_Manager(BestHTTP.SocketIO.SocketManager value)
        {
            this.<Manager>k__BackingField = value;
        }
        public string get_Namespace()
        {
            return (string)this.<Namespace>k__BackingField;
        }
        private void set_Namespace(string value)
        {
            this.<Namespace>k__BackingField = value;
        }
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        private void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
        public bool get_IsOpen()
        {
            return (bool)this.<IsOpen>k__BackingField;
        }
        private void set_IsOpen(bool value)
        {
            this.<IsOpen>k__BackingField = value;
        }
        public bool get_AutoDecodePayload()
        {
            return (bool)this.<AutoDecodePayload>k__BackingField;
        }
        public void set_AutoDecodePayload(bool value)
        {
            this.<AutoDecodePayload>k__BackingField = value;
        }
        internal Socket(string nsp, BestHTTP.SocketIO.SocketManager manager)
        {
            this.arguments = new System.Collections.Generic.List<System.Object>();
            val_2 = new System.Object();
            this.<Manager>k__BackingField = val_2;
            this.<Namespace>k__BackingField = nsp;
            this.<IsOpen>k__BackingField = true;
            this.<AutoDecodePayload>k__BackingField = true;
            this.EventCallbacks = new BestHTTP.SocketIO.Events.EventTable(socket:  this);
        }
        private void BestHTTP.SocketIO.ISocket.Open()
        {
            States val_5;
            if((this.<Manager>k__BackingField) != null)
            {
                    val_5 = this.<Manager>k__BackingField.state;
                BestHTTP.SocketIO.Socket val_1 = this.<Manager>k__BackingField.GetSocket();
            }
            else
            {
                    val_5 = this.<Manager>k__BackingField;
            }
            
            if((this.<Manager>k__BackingField.state) == 3)
            {
                    T[] val_3 = System.Array.Empty<System.Object>();
                this.OnTransportOpen(socket:  null, packet:  null, args:  null);
                return;
            }
            
            mem[1152921553703822624] = this;
            mem[1152921553703822632] = System.Void BestHTTP.SocketIO.Socket::OnTransportOpen(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args);
            mem[1152921553703822608] = System.Void BestHTTP.SocketIO.Socket::OnTransportOpen(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args);
            val_5.GetSocket().Off(eventName:  "connect", callback:  new BestHTTP.SocketIO.Events.SocketIOCallback());
            mem[1152921553703834912] = this;
            mem[1152921553703834920] = System.Void BestHTTP.SocketIO.Socket::OnTransportOpen(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args);
            mem[1152921553703834896] = System.Void BestHTTP.SocketIO.Socket::OnTransportOpen(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args);
            this.<Manager>k__BackingField.GetSocket().On(eventName:  "connect", callback:  new BestHTTP.SocketIO.Events.SocketIOCallback());
            if((this.<Manager>k__BackingField.<Options>k__BackingField.<AutoConnect>k__BackingField) == false)
            {
                    return;
            }
            
            if((this.<Manager>k__BackingField.state) != 0)
            {
                    return;
            }
            
            this.<Manager>k__BackingField.Open();
        }
        public void Disconnect()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.Disconnect(remove:  true);
        }
        private void BestHTTP.SocketIO.ISocket.Disconnect(bool remove)
        {
            BestHTTP.SocketIO.Packet val_5;
            var val_7;
            var val_9;
            if((this.<IsOpen>k__BackingField) != false)
            {
                    BestHTTP.SocketIO.Packet val_1 = null;
                val_5 = val_1;
                val_1 = new BestHTTP.SocketIO.Packet();
                .<Namespace>k__BackingField = this.<Namespace>k__BackingField;
                .<Payload>k__BackingField = System.String.alignConst;
                .<TransportEvent>k__BackingField = ;
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_7 = public System.Void BestHTTP.SocketIO.IManager::SendPacket(BestHTTP.SocketIO.Packet packet);
                this.<Manager>k__BackingField.SendPacket(packet:  val_1);
                this.<IsOpen>k__BackingField = false;
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_7 = 2;
                val_9 = public System.Void BestHTTP.SocketIO.ISocket::OnPacket(BestHTTP.SocketIO.Packet packet);
                this.OnPacket(packet:  val_1);
            }
            
            if(this.AckCallbacks != null)
            {
                    this.AckCallbacks.Clear();
            }
            
            if(remove == false)
            {
                    return;
            }
            
            this.EventCallbacks.Clear();
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_9 = 0;
            this.<Manager>k__BackingField.Remove(socket:  this);
        }
        public BestHTTP.SocketIO.Socket Emit(string eventName, object[] args)
        {
            return this.Emit(eventName:  eventName, callback:  0, args:  args);
        }
        public BestHTTP.SocketIO.Socket Emit(string eventName, BestHTTP.SocketIO.Events.SocketIOAckCallback callback, object[] args)
        {
            var val_34;
            string val_35;
            var val_36;
            object val_37;
            System.Collections.Generic.List<System.Byte[]> val_38;
            object val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            BestHTTP.SocketIO.Events.SocketIOAckCallback val_45;
            System.Collections.Generic.Dictionary<TKey, TValue> val_46;
            int val_47;
            string val_48;
            System.Collections.Generic.IEnumerable<TSource> val_49;
            var val_50;
            System.Func<System.Object, System.Boolean> val_52;
            var val_53;
            var val_54;
            string val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            val_34 = args;
            val_35 = eventName;
            if((BestHTTP.SocketIO.Events.EventNames.IsBlacklisted(eventName:  val_35)) == true)
            {
                goto label_3;
            }
            
            val_36 = 1152921531110706768;
            mem[1152921553704644928].Clear();
            if(val_34 == null)
            {
                goto label_5;
            }
            
            val_37 = 0;
            if((args.Length == 0) || (args.Length < 1))
            {
                goto label_20;
            }
            
            val_38 = 0;
            val_37 = 0;
            do
            {
                object val_33 = val_34[0];
                if(val_33 != null)
            {
                    if(val_38 == 0)
            {
                    System.Collections.Generic.List<System.Byte[]> val_2 = null;
                val_38 = val_2;
                val_2 = new System.Collections.Generic.List<System.Byte[]>();
            }
            
                System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  2);
                val_3.Add(key:  "_placeholder", value:  true);
                val_3.Add(key:  "num", value:  val_37);
                val_37 = val_37 + 1;
                mem[1152921553704644928].Add(item:  val_3);
                val_39 = val_33;
                val_40 = public System.Void System.Collections.Generic.List<System.Byte[]>::Add(System.Byte[] item);
            }
            else
            {
                    val_40 = public System.Void System.Collections.Generic.List<System.Object>::Add(System.Object item);
                val_39 = args[0x0] + 32;
            }
            
                mem[1152921553704644928].Add(item:  val_39);
            }
            while((0 + 1) < args.Length);
            
            val_36 = 1152921531110706768;
            val_35 = val_35;
            if(val_38 != 0)
            {
                goto label_19;
            }
            
            goto label_20;
            label_5:
            val_37 = 0;
            label_20:
            System.Collections.Generic.List<System.Byte[]> val_5 = null;
            val_38 = val_5;
            val_5 = new System.Collections.Generic.List<System.Byte[]>();
            label_19:
            val_41 = 0;
            System.Byte[] val_8 = mem[1152921553704644880].Extras.三丙业业世丙丏丝丝(下丟丗丛丅丗丒与丙:  System.Text.Encoding.UTF8);
            var val_37 = mem[1152921553704644880] + 80;
            if((mem[1152921553704644880] + 80 + 286) == 0)
            {
                goto label_26;
            }
            
            var val_34 = mem[1152921553704644880] + 80 + 176;
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_28:
            if(((mem[1152921553704644880] + 80 + 176 + 8) + -8) == null)
            {
                goto label_27;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (mem[1152921553704644880] + 80 + 286))
            {
                goto label_28;
            }
            
            label_26:
            val_41 = 2;
            goto label_29;
            label_27:
            var val_36 = val_34;
            val_36 = val_36 + 2;
            val_37 = val_37 + val_36;
            val_42 = val_37 + 296;
            label_29:
            string val_9 = mem[1152921553704644880] + 80.EncodeNoSquareBraces(obj:  mem[1152921553704644928]);
            mem[1152921553704644928].Clear();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  2);
            val_13.Add(key:  "_placeholder", value:  true);
            val_13.Add(key:  "num", value:  val_37);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  2);
            val_15.Add(key:  "_placeholder", value:  true);
            val_15.Add(key:  "num", value:  val_37 + 1);
            mem[1152921553704644928].Add(item:  val_13);
            mem[1152921553704644928].Add(item:  val_15);
            if(val_38 != null)
            {
                    val_5.Add(item:  val_8);
            }
            else
            {
                    0.Add(item:  val_8);
            }
            
            val_43 = public System.Void System.Collections.Generic.List<System.Byte[]>::Add(System.Byte[] item);
            0.Add(item:  mem[1152921553704644880].Extras.三丙业业世丙丏丝丝(下丟丗丛丅丗丒与丙:  System.Text.Encoding.UTF8));
            var val_41 = mem[1152921553704644880] + 80;
            if((mem[1152921553704644880] + 80 + 286) == 0)
            {
                goto label_44;
            }
            
            var val_38 = mem[1152921553704644880] + 80 + 176;
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_46:
            if(((mem[1152921553704644880] + 80 + 176 + 8) + -8) == null)
            {
                goto label_45;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < (mem[1152921553704644880] + 80 + 286))
            {
                goto label_46;
            }
            
            label_44:
            val_43 = 1;
            goto label_47;
            label_45:
            var val_40 = val_38;
            val_40 = val_40 + 1;
            val_41 = val_41 + val_40;
            val_44 = val_41 + 296;
            label_47:
            val_45 = public System.String BestHTTP.SocketIO.JsonEncoders.IJsonEncoder::Encode(System.Collections.Generic.List<object> obj);
            string val_16 = mem[1152921553704644880] + 80.Encode(obj:  mem[1152921553704644928]);
            mem[1152921553704644928].Clear();
            if(val_16 == null)
            {
                goto label_49;
            }
            
            if(callback != 0)
            {
                    val_46 = mem[1152921553704644912];
                val_47 = System.Threading.Interlocked.Increment(location: ref  mem[1152921553704644880] + 88);
                if(val_46 == 0)
            {
                    System.Collections.Generic.Dictionary<System.Int32, BestHTTP.SocketIO.Events.SocketIOAckCallback> val_19 = null;
                val_46 = val_19;
                val_19 = new System.Collections.Generic.Dictionary<System.Int32, BestHTTP.SocketIO.Events.SocketIOAckCallback>();
                mem[1152921553704644912] = val_46;
            }
            
                val_45 = callback;
                val_19.set_Item(key:  val_47, value:  val_45);
            }
            else
            {
                    val_47 = 0;
            }
            
            val_48 = mem[1152921553704644888];
            BestHTTP.SocketIO.Packet val_21 = new BestHTTP.SocketIO.Packet();
            .<Namespace>k__BackingField = val_48;
            .<Payload>k__BackingField = val_16;
            .<TransportEvent>k__BackingField = 4;
            .<SocketIOEvent>k__BackingField = (val_38 != 0) ? 5 : 2;
            .<AttachmentCount>k__BackingField = 0;
            .<Id>k__BackingField = val_47;
            if(val_38 != null)
            {
                    val_21.Attachments = val_5;
            }
            
            if(LogController.AnyLogEnabled == false)
            {
                goto label_59;
            }
            
            val_38 = mem[mem[1152921553704644880] + 80];
            val_38 = mem[1152921553704644880] + 80;
            if(val_34 == null)
            {
                    object[] val_23 = new object[0];
                val_49 = val_23;
            }
            
            val_48 = 1152921505555992576;
            val_50 = null;
            val_50 = null;
            val_52 = Socket.<>c.<>9__28_0;
            if(val_52 == null)
            {
                    System.Func<System.Object, System.Boolean> val_24 = null;
                val_52 = val_24;
                val_24 = new System.Func<System.Object, System.Boolean>(object:  Socket.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Socket.<>c::<Emit>b__28_0(object x));
                Socket.<>c.<>9__28_0 = val_52;
            }
            
            val_53 = public static System.Collections.Generic.IEnumerable<TSource> System.Linq.Enumerable::Where<System.Object>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            var val_45 = val_38;
            if((mem[1152921553704644880] + 80 + 286) == 0)
            {
                goto label_68;
            }
            
            var val_42 = mem[1152921553704644880] + 80 + 176;
            var val_43 = 0;
            val_42 = val_42 + 8;
            label_70:
            if(((mem[1152921553704644880] + 80 + 176 + 8) + -8) == null)
            {
                goto label_69;
            }
            
            val_43 = val_43 + 1;
            val_42 = val_42 + 16;
            if(val_43 < (mem[1152921553704644880] + 80 + 286))
            {
                goto label_70;
            }
            
            label_68:
            val_53 = 1;
            goto label_71;
            label_69:
            var val_44 = val_42;
            val_44 = val_44 + 1;
            val_45 = val_45 + val_44;
            val_54 = val_45 + 296;
            label_71:
            val_45 = public System.String BestHTTP.SocketIO.JsonEncoders.IJsonEncoder::Encode(System.Collections.Generic.List<object> obj);
            val_55 = val_38.Encode(obj:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Where<System.Object>(source:  val_23, predicate:  val_24)));
            if(val_21 != null)
            {
                    .<OriginalPayload>k__BackingField = val_55;
            }
            else
            {
                    .<OriginalPayload>k__BackingField = val_55;
            }
            
            .<OriginalEventName>k__BackingField = val_35;
            label_59:
            var val_49 = mem[1152921553704644880];
            if((mem[1152921553704644880] + 286) == 0)
            {
                goto label_75;
            }
            
            var val_46 = mem[1152921553704644880] + 176;
            var val_47 = 0;
            val_46 = val_46 + 8;
            label_77:
            if(((mem[1152921553704644880] + 176 + 8) + -8) == null)
            {
                goto label_76;
            }
            
            val_47 = val_47 + 1;
            val_46 = val_46 + 16;
            if(val_47 < (mem[1152921553704644880] + 286))
            {
                goto label_77;
            }
            
            label_75:
            val_45 = 6;
            goto label_78;
            label_76:
            var val_48 = val_46;
            val_48 = val_48 + 6;
            val_49 = val_49 + val_48;
            val_56 = val_49 + 296;
            label_78:
            mem[1152921553704644880].SendPacket(packet:  val_21);
            return (BestHTTP.SocketIO.Socket)this;
            label_3:
            val_57 = 1152921553704607088;
            val_58 = new System.ArgumentException(message:  "Blacklisted event: "("Blacklisted event: ") + val_35);
            goto label_80;
            label_49:
            val_57 = 1152921553704607088;
            val_58 = new System.ArgumentException(message:  "Encoding the arguments to JSON failed!");
            label_80:
            val_59 = val_58;
            if(0 != 1)
            {
                goto label_100;
            }
            
            if((null & 1) == 0)
            {
                goto label_87;
            }
            
            UnityEngine.Debug.LogException(exception:  1152921504616964096);
            BestHTTP.SocketIO.Socket val_52 = this;
            var val_50 = 0;
            val_38 = val_38 + 8;
            label_94:
            if((((mem[1152921553704644880] + 80 + 176 + 8) + 8) + -8) == null)
            {
                goto label_93;
            }
            
            val_50 = val_50 + 1;
            val_38 = val_38 + 16;
            if(val_50 < " ")
            {
                goto label_94;
            }
            
            goto label_95;
            label_93:
            var val_51 = val_38;
            val_51 = val_51 + 5;
            val_52 = val_52 + val_51;
            val_60 = val_52 + 296;
            label_95:
            this.EmitError(errCode:  4, msg:  "Error while encoding payload: "("Error while encoding payload: ") + 1152921504616964096 + " " + 1152921504616964096);
            val_61 = mem[1152921553704644928];
            val_62 = public System.Void System.Collections.Generic.List<System.Object>::Clear();
            goto label_97;
            label_87:
            val_63 = 8;
            mem[8] = null;
            goto label_98;
            label_108:
            if((((mem[1152921553704644880] + 80 + 176 + 8) + 8) + -8) == null)
            {
                goto label_107;
            }
            
             =  + 1;
             =  + 16;
            if( < " ")
            {
                goto label_108;
            }
            
            goto label_109;
            label_107:
            var val_54 = ;
            val_54 = val_54 + 5;
             =  + val_54;
            val_64 =  + 296;
            label_109:
            this.EmitError(errCode:  4, msg:  "Error while encoding payload to encrypt: "("Error while encoding payload to encrypt: ") + 1152921504616964096 + " " + 1152921504616964096);
            val_61 = mem[1152921553704644928];
            val_62 = public System.Void System.Collections.Generic.List<System.Object>::Clear();
            label_97:
            val_61.Clear();
            return (BestHTTP.SocketIO.Socket)this;
            label_98:
            val_59 = ;
            label_100:
        }
        public BestHTTP.SocketIO.Socket EmitAck(BestHTTP.SocketIO.Packet originalPacket, object[] args)
        {
            var val_9;
            var val_11;
            var val_13;
            string val_15;
            var val_16;
            if(originalPacket == null)
            {
                goto label_1;
            }
            
            if((originalPacket.<SocketIOEvent>k__BackingField) != 2)
            {
                    if((originalPacket.<SocketIOEvent>k__BackingField) != 5)
            {
                goto label_3;
            }
            
            }
            
            this.arguments.Clear();
            if((args != null) && (args.Length != 0))
            {
                    val_9 = public System.Void System.Collections.Generic.List<System.Object>::AddRange(System.Collections.Generic.IEnumerable<T> collection);
                this.arguments.AddRange(collection:  args);
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_9 = 1;
            val_11 = public System.String BestHTTP.SocketIO.JsonEncoders.IJsonEncoder::Encode(System.Collections.Generic.List<object> obj);
            string val_2 = this.<Manager>k__BackingField.<Encoder>k__BackingField.Encode(obj:  this.arguments);
            if(val_2 == null)
            {
                goto label_14;
            }
            
            .<Namespace>k__BackingField = this.<Namespace>k__BackingField;
            .<Payload>k__BackingField = val_2;
            .<TransportEvent>k__BackingField = 4;
            .<SocketIOEvent>k__BackingField = ((originalPacket.<SocketIOEvent>k__BackingField) == 2) ? 3 : 6;
            .<AttachmentCount>k__BackingField = 0;
            .<Id>k__BackingField = originalPacket.<Id>k__BackingField;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = 6;
            this.<Manager>k__BackingField.SendPacket(packet:  new BestHTTP.SocketIO.Packet());
            return (BestHTTP.SocketIO.Socket)this;
            label_1:
            System.ArgumentNullException val_6 = null;
            val_13 = val_6;
            val_6 = new System.ArgumentNullException(paramName:  "originalPacket == null!");
            goto label_22;
            label_3:
            val_15 = "Wrong packet - you can\'t send an Ack for a packet with id == 0 and SocketIOEvent != Event or SocketIOEvent != BinaryEvent!";
            goto label_21;
            label_14:
            System.ArgumentException val_7 = null;
            val_15 = "Encoding the arguments to JSON failed!";
            label_21:
            val_13 = val_7;
            val_7 = new System.ArgumentException(message:  val_15);
            label_22:
            val_16 = val_13;
            if(0 == 1)
            {
                    if((null & 1) != 0)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_7.EmitError(errCode:  4, msg:  "Error while encoding payload: "("Error while encoding payload: ") + 1152921504616964096 + " " + 1152921504616964096);
                return (BestHTTP.SocketIO.Socket)this;
            }
            
                mem[8] = null;
                val_16 = 8;
            }
        
        }
        public void On(string eventName, BestHTTP.SocketIO.Events.SocketIOCallback callback)
        {
            this.EventCallbacks.Register(eventName:  eventName, callback:  callback, onlyOnce:  false, autoDecodePayload:  ((this.<AutoDecodePayload>k__BackingField) == true) ? 1 : 0);
        }
        public void On(BestHTTP.SocketIO.SocketIOEventTypes type, BestHTTP.SocketIO.Events.SocketIOCallback callback)
        {
            this.EventCallbacks.Register(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  type), callback:  callback, onlyOnce:  false, autoDecodePayload:  ((this.<AutoDecodePayload>k__BackingField) == true) ? 1 : 0);
        }
        public void On(string eventName, BestHTTP.SocketIO.Events.SocketIOCallback callback, bool autoDecodePayload)
        {
            this.EventCallbacks.Register(eventName:  eventName, callback:  callback, onlyOnce:  false, autoDecodePayload:  autoDecodePayload);
        }
        public void On(BestHTTP.SocketIO.SocketIOEventTypes type, BestHTTP.SocketIO.Events.SocketIOCallback callback, bool autoDecodePayload)
        {
            this.EventCallbacks.Register(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  type), callback:  callback, onlyOnce:  false, autoDecodePayload:  autoDecodePayload);
        }
        public void Once(string eventName, BestHTTP.SocketIO.Events.SocketIOCallback callback)
        {
            this.EventCallbacks.Register(eventName:  eventName, callback:  callback, onlyOnce:  true, autoDecodePayload:  ((this.<AutoDecodePayload>k__BackingField) == true) ? 1 : 0);
        }
        public void Once(BestHTTP.SocketIO.SocketIOEventTypes type, BestHTTP.SocketIO.Events.SocketIOCallback callback)
        {
            this.EventCallbacks.Register(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  type), callback:  callback, onlyOnce:  true, autoDecodePayload:  ((this.<AutoDecodePayload>k__BackingField) == true) ? 1 : 0);
        }
        public void Once(string eventName, BestHTTP.SocketIO.Events.SocketIOCallback callback, bool autoDecodePayload)
        {
            this.EventCallbacks.Register(eventName:  eventName, callback:  callback, onlyOnce:  true, autoDecodePayload:  autoDecodePayload);
        }
        public void Once(BestHTTP.SocketIO.SocketIOEventTypes type, BestHTTP.SocketIO.Events.SocketIOCallback callback, bool autoDecodePayload)
        {
            this.EventCallbacks.Register(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  type), callback:  callback, onlyOnce:  true, autoDecodePayload:  autoDecodePayload);
        }
        public void Off()
        {
            this.EventCallbacks.Clear();
        }
        public void Off(string eventName)
        {
            this.EventCallbacks.Unregister(eventName:  eventName);
        }
        public void Off(BestHTTP.SocketIO.SocketIOEventTypes type)
        {
            this.Off(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  type));
        }
        public void Off(string eventName, BestHTTP.SocketIO.Events.SocketIOCallback callback)
        {
            this.EventCallbacks.Unregister(eventName:  eventName, callback:  callback);
        }
        public void Off(BestHTTP.SocketIO.SocketIOEventTypes type, BestHTTP.SocketIO.Events.SocketIOCallback callback)
        {
            this.EventCallbacks.Unregister(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  type), callback:  callback);
        }
        private void BestHTTP.SocketIO.ISocket.OnPacket(BestHTTP.SocketIO.Packet packet)
        {
            BestHTTP.SocketIO.Packet val_20;
            string val_21;
            System.Object[] val_22;
            BestHTTP.SocketIO.SocketIOErrors val_23;
            string val_24;
            object val_25;
            System.Object[] val_26;
            val_20 = packet;
            if((packet.<SocketIOEvent>k__BackingField) == 4)
            {
                goto label_2;
            }
            
            if((packet.<SocketIOEvent>k__BackingField) == 1)
            {
                goto label_3;
            }
            
            if((packet.<SocketIOEvent>k__BackingField) != 0)
            {
                goto label_14;
            }
            
            if((System.String.op_Inequality(a:  this.<Namespace>k__BackingField, b:  "/")) == false)
            {
                goto label_5;
            }
            
            string val_2 = this.<Namespace>k__BackingField(this.<Namespace>k__BackingField) + "#" + this.<Manager>k__BackingField.<Handshake>k__BackingField.<Sid>k__BackingField(this.<Manager>k__BackingField.<Handshake>k__BackingField.<Sid>k__BackingField);
            goto label_8;
            label_3:
            if((this.<IsOpen>k__BackingField) == false)
            {
                goto label_14;
            }
            
            this.<IsOpen>k__BackingField = false;
            val_22 = System.Array.Empty<System.Object>();
            this.EventCallbacks.Call(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  1), packet:  val_20, args:  val_22);
            this.Disconnect();
            goto label_14;
            label_2:
            bool val_5 = false;
            object val_6 = BestHTTP.JSON.Json.Decode(json:  packet.<Payload>k__BackingField, success: ref  val_5);
            if(val_5 == 0)
            {
                goto label_14;
            }
            
            if((val_6 != null) && ((val_6.ContainsKey(key:  "code")) != false))
            {
                    val_23 = System.Convert.ToInt32(value:  val_6.Item["code"]);
                val_24 = val_6.Item["message"];
                val_25 = new BestHTTP.SocketIO.Error();
                if(val_24 != null)
            {
                    var val_11 = (null == null) ? (val_24) : 0;
            }
            
                val_25 = new System.Object();
            }
            else
            {
                    val_24 = packet.<Payload>k__BackingField;
                BestHTTP.SocketIO.Error val_13 = null;
                val_25 = val_13;
                val_13 = new BestHTTP.SocketIO.Error();
                val_23 = 6;
            }
            
            .<Code>k__BackingField = val_23;
            .<Message>k__BackingField = val_24;
            object[] val_15 = new object[1];
            val_22 = val_15;
            val_22[0] = val_25;
            this.EventCallbacks.Call(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  4), packet:  val_20, args:  val_15);
            return;
            label_5:
            val_21 = this.<Manager>k__BackingField.<Handshake>k__BackingField.<Sid>k__BackingField;
            label_8:
            this.<Id>k__BackingField = val_21;
            label_14:
            val_25 = this.EventCallbacks;
            val_25.Call(packet:  val_20);
            if((packet.<SocketIOEvent>k__BackingField) != 6)
            {
                    if((packet.<SocketIOEvent>k__BackingField) != 3)
            {
                    return;
            }
            
            }
            
            if(this.AckCallbacks == null)
            {
                    return;
            }
            
            BestHTTP.SocketIO.Events.SocketIOAckCallback val_16 = 0;
            val_25 = val_16;
            if((val_25 != 0) && ((this.AckCallbacks.TryGetValue(key:  packet.<Id>k__BackingField, value: out  val_16)) != false))
            {
                    if((this.<AutoDecodePayload>k__BackingField) != false)
            {
                    val_26 = val_20.Decode(encoder:  this.<Manager>k__BackingField.<Encoder>k__BackingField);
            }
            else
            {
                    val_26 = 0;
            }
            
                val_25.Invoke(socket:  this, packet:  val_20, args:  val_26);
            }
            
            val_20 = packet.<Id>k__BackingField;
            bool val_19 = this.AckCallbacks.Remove(key:  val_20);
        }
        private void BestHTTP.SocketIO.ISocket.EmitEvent(BestHTTP.SocketIO.SocketIOEventTypes type, object[] args)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.EmitEvent(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  type), args:  args);
        }
        private void BestHTTP.SocketIO.ISocket.EmitEvent(string eventName, object[] args)
        {
            if((System.String.IsNullOrEmpty(value:  eventName)) != false)
            {
                    return;
            }
            
            this.EventCallbacks.Call(eventName:  eventName, packet:  0, args:  args);
        }
        private void BestHTTP.SocketIO.ISocket.EmitError(BestHTTP.SocketIO.SocketIOErrors errCode, string msg)
        {
            object[] val_1 = new object[1];
            BestHTTP.SocketIO.Error val_2 = new BestHTTP.SocketIO.Error();
            .<Code>k__BackingField = errCode;
            .<Message>k__BackingField = msg;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.EmitEvent(type:  4, args:  val_1);
        }
        private void OnTransportOpen(BestHTTP.SocketIO.Socket socket, BestHTTP.SocketIO.Packet packet, object[] args)
        {
            if((System.String.op_Inequality(a:  this.<Namespace>k__BackingField, b:  "/")) != false)
            {
                    .<Namespace>k__BackingField = this.<Namespace>k__BackingField;
                .<Payload>k__BackingField = System.String.alignConst;
                .<TransportEvent>k__BackingField = ;
                var val_4 = 0;
                val_4 = val_4 + 1;
                0 = 6;
                this.<Manager>k__BackingField.SendPacket(packet:  new BestHTTP.SocketIO.Packet());
            }
            
            this.<IsOpen>k__BackingField = true;
        }
    
    }

}
