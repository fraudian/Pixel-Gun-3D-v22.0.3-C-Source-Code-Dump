using UnityEngine;

namespace BestHTTP.SocketIO
{
    public sealed class Packet
    {
        // Fields
        private readonly Rilisoft.丂世丈丅丝丙丘丌丟 _extra;
        public const string Placeholder = "_placeholder";
        private BestHTTP.SocketIO.TransportEventTypes <TransportEvent>k__BackingField;
        private BestHTTP.SocketIO.SocketIOEventTypes <SocketIOEvent>k__BackingField;
        private int <AttachmentCount>k__BackingField;
        private int <Id>k__BackingField;
        private string <Namespace>k__BackingField;
        private string <Payload>k__BackingField;
        private string <EventName>k__BackingField;
        private System.Collections.Generic.List<byte[]> attachments;
        private bool <IsDecoded>k__BackingField;
        private object[] <DecodedArgs>k__BackingField;
        private string <OriginalPayload>k__BackingField;
        private string <OriginalEventName>k__BackingField;
        
        // Properties
        public BestHTTP.SocketIO.TransportEventTypes TransportEvent { get; set; }
        public BestHTTP.SocketIO.SocketIOEventTypes SocketIOEvent { get; set; }
        public int AttachmentCount { get; set; }
        public int Id { get; set; }
        public string Namespace { get; set; }
        public string Payload { get; set; }
        public string EventName { get; set; }
        public System.Collections.Generic.List<byte[]> Attachments { get; set; }
        public bool HasAllAttachment { get; }
        public bool IsDecoded { get; set; }
        public object[] DecodedArgs { get; set; }
        public string OriginalPayload { get; set; }
        public string OriginalEventName { get; set; }
        
        // Methods
        public BestHTTP.SocketIO.TransportEventTypes get_TransportEvent()
        {
            return (BestHTTP.SocketIO.TransportEventTypes)this.<TransportEvent>k__BackingField;
        }
        private void set_TransportEvent(BestHTTP.SocketIO.TransportEventTypes value)
        {
            this.<TransportEvent>k__BackingField = value;
        }
        public BestHTTP.SocketIO.SocketIOEventTypes get_SocketIOEvent()
        {
            return (BestHTTP.SocketIO.SocketIOEventTypes)this.<SocketIOEvent>k__BackingField;
        }
        private void set_SocketIOEvent(BestHTTP.SocketIO.SocketIOEventTypes value)
        {
            this.<SocketIOEvent>k__BackingField = value;
        }
        public int get_AttachmentCount()
        {
            return (int)this.<AttachmentCount>k__BackingField;
        }
        private void set_AttachmentCount(int value)
        {
            this.<AttachmentCount>k__BackingField = value;
        }
        public int get_Id()
        {
            return (int)this.<Id>k__BackingField;
        }
        private void set_Id(int value)
        {
            this.<Id>k__BackingField = value;
        }
        public string get_Namespace()
        {
            return (string)this.<Namespace>k__BackingField;
        }
        private void set_Namespace(string value)
        {
            this.<Namespace>k__BackingField = value;
        }
        public string get_Payload()
        {
            return (string)this.<Payload>k__BackingField;
        }
        private void set_Payload(string value)
        {
            this.<Payload>k__BackingField = value;
        }
        public string get_EventName()
        {
            return (string)this.<EventName>k__BackingField;
        }
        private void set_EventName(string value)
        {
            this.<EventName>k__BackingField = value;
        }
        public System.Collections.Generic.List<byte[]> get_Attachments()
        {
            return (System.Collections.Generic.List<System.Byte[]>)this.attachments;
        }
        public void set_Attachments(System.Collections.Generic.List<byte[]> value)
        {
            int val_2;
            this.attachments = value;
            if(value != null)
            {
                    val_2 = value;
                int val_1 = val_2.Count;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.<AttachmentCount>k__BackingField = val_2;
        }
        public bool get_HasAllAttachment()
        {
            if(this.attachments == null)
            {
                    return (bool)(this.attachments.Count == (this.<AttachmentCount>k__BackingField)) ? 1 : 0;
            }
            
            return (bool)(this.attachments.Count == (this.<AttachmentCount>k__BackingField)) ? 1 : 0;
        }
        public bool get_IsDecoded()
        {
            return (bool)this.<IsDecoded>k__BackingField;
        }
        private void set_IsDecoded(bool value)
        {
            this.<IsDecoded>k__BackingField = value;
        }
        public object[] get_DecodedArgs()
        {
            return (System.Object[])this.<DecodedArgs>k__BackingField;
        }
        private void set_DecodedArgs(object[] value)
        {
            this.<DecodedArgs>k__BackingField = value;
        }
        public string get_OriginalPayload()
        {
            return (string)this.<OriginalPayload>k__BackingField;
        }
        public void set_OriginalPayload(string value)
        {
            this.<OriginalPayload>k__BackingField = value;
        }
        public string get_OriginalEventName()
        {
            return (string)this.<OriginalEventName>k__BackingField;
        }
        public void set_OriginalEventName(string value)
        {
            this.<OriginalEventName>k__BackingField = value;
        }
        internal Packet()
        {
            this.<TransportEvent>k__BackingField = 0;
            this.<Payload>k__BackingField = System.String.alignConst;
        }
        internal Packet(string from)
        {
            this.Parse(from:  from);
        }
        public Packet(BestHTTP.SocketIO.TransportEventTypes transportEvent, BestHTTP.SocketIO.SocketIOEventTypes packetType, string nsp, string payload, int attachment = 0, int id = 0)
        {
            val_1 = new System.Object();
            this.<TransportEvent>k__BackingField = transportEvent;
            this.<SocketIOEvent>k__BackingField = packetType;
            this.<Namespace>k__BackingField = val_1;
            this.<Payload>k__BackingField = payload;
            this.<AttachmentCount>k__BackingField = attachment;
            this.<Id>k__BackingField = id;
        }
        public object[] Decode(BestHTTP.SocketIO.JsonEncoders.IJsonEncoder encoder)
        {
            if(encoder == null)
            {
                    return (System.Object[])this.<DecodedArgs>k__BackingField;
            }
            
            if((this.<IsDecoded>k__BackingField) == true)
            {
                    return (System.Object[])this.<DecodedArgs>k__BackingField;
            }
            
            this.<IsDecoded>k__BackingField = true;
            if((System.String.IsNullOrEmpty(value:  this.<Payload>k__BackingField)) == true)
            {
                    return (System.Object[])this.<DecodedArgs>k__BackingField;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            System.Collections.Generic.List<System.Object> val_3 = encoder.Decode(json:  this.<Payload>k__BackingField);
            if(val_3 == null)
            {
                    return (System.Object[])this.<DecodedArgs>k__BackingField;
            }
            
            if(val_3.Count < 1)
            {
                    return (System.Object[])this.<DecodedArgs>k__BackingField;
            }
            
            if(((this.<SocketIOEvent>k__BackingField) != 6) && ((this.<SocketIOEvent>k__BackingField) != 3))
            {
                    val_3.RemoveAt(index:  0);
            }
            
            this.<DecodedArgs>k__BackingField = val_3.ToArray();
            return (System.Object[])this.<DecodedArgs>k__BackingField;
        }
        public string DecodeEventName()
        {
            var val_18;
            var val_19;
            var val_20;
            string val_21;
            if((System.String.IsNullOrEmpty(value:  this.<EventName>k__BackingField)) == false)
            {
                goto label_1;
            }
            
            if(((System.String.IsNullOrEmpty(value:  this.<Payload>k__BackingField)) == true) || (((this.<Payload>k__BackingField.Chars[0]) & 65535) != '['))
            {
                goto label_22;
            }
            
            val_18 = 2;
            goto label_5;
            label_11:
            if((((this.<Payload>k__BackingField.Chars[W21]) & 65535) == '"') || (((this.<Payload>k__BackingField.Chars[W21]) & 65535) == '''))
            {
                goto label_9;
            }
            
            val_18 = 3;
            label_5:
            val_19 = val_18 - 1;
            if((this.<Payload>k__BackingField.Length) > val_19)
            {
                goto label_11;
            }
            
            label_9:
            if((this.<Payload>k__BackingField.Length) <= val_19)
            {
                goto label_22;
            }
            
            val_19 = 0;
            val_20 = val_18;
            goto label_14;
            label_20:
            if((((this.<Payload>k__BackingField.Chars[3]) & 65535) == '"') || (((this.<Payload>k__BackingField.Chars[3]) & 65535) == '''))
            {
                goto label_18;
            }
            
            val_20 = 4;
            val_19 = 1;
            label_14:
            if((this.<Payload>k__BackingField.Length) > val_20)
            {
                goto label_20;
            }
            
            label_18:
            if((this.<Payload>k__BackingField.Length) <= val_20)
            {
                goto label_22;
            }
            
            this.<EventName>k__BackingField = this.<Payload>k__BackingField.Substring(startIndex:  3, length:  1);
            return (string)val_21;
            label_1:
            val_21 = this.<EventName>k__BackingField;
            return (string)val_21;
            label_22:
            val_21 = System.String.alignConst;
            return (string)val_21;
        }
        public string RemoveEventName(bool removeArrayMarks)
        {
            string val_20;
            var val_21;
            var val_22;
            int val_23;
            var val_24;
            if((System.String.IsNullOrEmpty(value:  this.<Payload>k__BackingField)) == true)
            {
                goto label_21;
            }
            
            val_20 = this.<Payload>k__BackingField;
            if((val_20.Chars[0] & 65535) != '[')
            {
                goto label_21;
            }
            
            val_21 = 2;
            goto label_4;
            label_10:
            if((((this.<Payload>k__BackingField.Chars[val_20]) & 65535) == '"') || (((this.<Payload>k__BackingField.Chars[val_20]) & 65535) == '''))
            {
                goto label_8;
            }
            
            val_21 = 3;
            label_4:
            val_20 = val_21 - 1;
            if((this.<Payload>k__BackingField.Length) > val_20)
            {
                goto label_10;
            }
            
            label_8:
            if((this.<Payload>k__BackingField.Length) <= val_20)
            {
                goto label_21;
            }
            
            val_22 = 1;
            goto label_13;
            label_19:
            if((((this.<Payload>k__BackingField.Chars[W23]) & 65535) == ',') || (((this.<Payload>k__BackingField.Chars[W23]) & 65535) == ']'))
            {
                goto label_17;
            }
            
            val_21 = 4;
            val_22 = 2;
            label_13:
            if((this.<Payload>k__BackingField.Length) > (val_21 - 1))
            {
                goto label_19;
            }
            
            label_17:
            if((this.<Payload>k__BackingField.Length) <= val_21)
            {
                goto label_21;
            }
            
            val_23 = this.<Payload>k__BackingField.Remove(startIndex:  val_20, count:  2);
            if(removeArrayMarks == false)
            {
                    return (string)val_23;
            }
            
            if(val_23 == null)
            {
                goto label_24;
            }
            
            val_24 = val_23.Length;
            return val_23.Substring(startIndex:  1, length:  val_24 - 2);
            label_21:
            val_23 = System.String.alignConst;
            return (string)val_23;
            label_24:
            val_24 = 0.Length;
            return val_23.Substring(startIndex:  1, length:  val_24 - 2);
        }
        public bool ReconstructAttachmentAsIndex()
        {
            return this.PlaceholderReplacer(onFound:  new System.Action<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  this, method:  System.Void BestHTTP.SocketIO.Packet::<ReconstructAttachmentAsIndex>b__59_0(string json, System.Collections.Generic.Dictionary<string, object> obj)), exitOnFound:  false);
        }
        public bool ReplacePlaceholderWithNumber(int number, string switch)
        {
            Packet.<>c__DisplayClass60_0 val_1 = new Packet.<>c__DisplayClass60_0();
            if(val_1 != null)
            {
                    .number = number;
                .<>4__this = this;
            }
            else
            {
                    mem[16] = number;
                mem[24] = this;
            }
            
            .switch = switch;
            return this.PlaceholderReplacer(onFound:  new System.Action<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  val_1, method:  System.Void Packet.<>c__DisplayClass60_0::<ReplacePlaceholderWithNumber>b__0(string json, System.Collections.Generic.Dictionary<string, object> obj)), exitOnFound:  true);
        }
        public bool ReconstructAttachmentAsBase64()
        {
            if(this.HasAllAttachment == false)
            {
                    return false;
            }
            
            return this.PlaceholderReplacer(onFound:  new System.Action<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  this, method:  System.Void BestHTTP.SocketIO.Packet::<ReconstructAttachmentAsBase64>b__61_0(string json, System.Collections.Generic.Dictionary<string, object> obj)), exitOnFound:  false);
        }
        private void Parse(string from)
        {
            var val_36;
            int val_37;
            int val_38;
            if(from != null)
            {
                    char val_1 = from.Chars[0];
                this.<TransportEvent>k__BackingField = val_1.ToInt(ch:  val_1);
            }
            else
            {
                    char val_3 = 0.Chars[0];
                this.<TransportEvent>k__BackingField = val_3.ToInt(ch:  val_3);
            }
            
            if(from.Length < 2)
            {
                goto label_5;
            }
            
            char val_6 = from.Chars[1];
            if(((val_6.ToInt(ch:  val_6)) & 2147483648) != 0)
            {
                goto label_5;
            }
            
            char val_8 = from.Chars[1];
            int val_9 = val_8.ToInt(ch:  val_8);
            this.<SocketIOEvent>k__BackingField = val_9;
            if((val_9 - 5) > 1)
            {
                goto label_7;
            }
            
            val_36 = from.IndexOf(value:  '-', startIndex:  2);
            if(val_36 == 1)
            {
                    val_36 = from.Length;
            }
            
            bool val_16 = System.Int32.TryParse(s:  from.Substring(startIndex:  2, length:  val_36 - 2), result: out  0);
            val_37 = val_36 + 1;
            this.<AttachmentCount>k__BackingField = 0;
            if(from != null)
            {
                goto label_36;
            }
            
            goto label_37;
            label_5:
            this.<SocketIOEvent>k__BackingField = 0;
            val_37 = 1;
            if(from != null)
            {
                goto label_36;
            }
            
            label_37:
            label_36:
            if((from.Length <= val_37) || ((from.Chars[1] & 65535) != ('/')))
            {
                goto label_17;
            }
            
            int val_20 = from.IndexOf(value:  ',', startIndex:  1);
            if(val_20 == 1)
            {
                goto label_19;
            }
            
            if(from != null)
            {
                goto label_39;
            }
            
            label_40:
            label_39:
            this.<Namespace>k__BackingField = from.Substring(startIndex:  1, length:  val_20 - val_37);
            val_37 = val_20 + 1;
            if(from != null)
            {
                goto label_23;
            }
            
            goto label_22;
            label_17:
            this.<Namespace>k__BackingField = "/";
            if(from != null)
            {
                goto label_23;
            }
            
            label_22:
            label_23:
            if(from.Length <= val_37)
            {
                goto label_26;
            }
            
            char val_24 = from.Chars[1];
            if(((val_24.ToInt(ch:  val_24)) & 2147483648) != 0)
            {
                goto label_26;
            }
            
            var val_37 = 1;
            label_30:
            int val_26 = val_37 + val_37;
            if(from.Length <= val_26)
            {
                goto label_28;
            }
            
            char val_28 = from.Chars[val_26];
            val_37 = val_37 + 1;
            if(((val_28.ToInt(ch:  val_28)) & 2147483648) == 0)
            {
                goto label_30;
            }
            
            label_28:
            bool val_33 = System.Int32.TryParse(s:  from.Substring(startIndex:  1, length:  1), result: out  0);
            val_37 = val_37 + val_37;
            this.<Id>k__BackingField = 0;
            label_26:
            if(from.Length > val_37)
            {
                    string val_35 = from.Substring(startIndex:  val_37);
            }
            else
            {
                    val_38 = System.String.alignConst;
            }
            
            this.<Payload>k__BackingField = val_38;
            return;
            label_7:
            if(from != null)
            {
                goto label_36;
            }
            
            goto label_37;
            label_19:
            int val_36 = from.Length;
            if(from != null)
            {
                goto label_39;
            }
            
            goto label_40;
        }
        private int ToInt(char ch)
        {
            var val_3;
            int val_1 = System.Convert.ToInt32(value:  ch);
            int val_2 = val_1 - 48;
            if((val_2 & 2147483648) == 0)
            {
                    val_1 = (val_2 < 10) ? (val_2) : (!0);
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        internal string Encode()
        {
            BestHTTP.SocketIO.TransportEventTypes val_18;
            BestHTTP.SocketIO.SocketIOEventTypes val_19;
            var val_20;
            int val_21;
            string val_22;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_18 = this.<TransportEvent>k__BackingField;
            if(val_18 != 1)
            {
                goto label_1;
            }
            
            if((this.<AttachmentCount>k__BackingField) < 1)
            {
                goto label_2;
            }
            
            val_18 = 4;
            this.<TransportEvent>k__BackingField = val_18;
            label_1:
            System.Text.StringBuilder val_3 = val_1.Append(value:  val_18.ToString());
            label_2:
            val_19 = this.<SocketIOEvent>k__BackingField;
            if(val_19 != 1)
            {
                goto label_4;
            }
            
            if((this.<AttachmentCount>k__BackingField) < 1)
            {
                goto label_7;
            }
            
            val_19 = 5;
            this.<SocketIOEvent>k__BackingField = 5;
            label_4:
            System.Text.StringBuilder val_5 = val_1.Append(value:  5.ToString());
            BestHTTP.SocketIO.SocketIOEventTypes val_18 = this.<SocketIOEvent>k__BackingField;
            val_18 = val_18 - 5;
            if(val_18 <= 1)
            {
                    string val_6 = this.<AttachmentCount>k__BackingField.ToString();
                if(val_1 != null)
            {
                    System.Text.StringBuilder val_7 = val_1.Append(value:  val_6);
            }
            else
            {
                    System.Text.StringBuilder val_8 = val_1.Append(value:  val_6);
            }
            
                System.Text.StringBuilder val_9 = val_1.Append(value:  "-");
            }
            
            label_7:
            if((System.String.op_Inequality(a:  this.<Namespace>k__BackingField, b:  "/")) != false)
            {
                    System.Text.StringBuilder val_11 = val_1.Append(value:  this.<Namespace>k__BackingField);
                val_20 = 1;
            }
            else
            {
                    val_20 = 0;
            }
            
            val_21 = this.<Id>k__BackingField;
            if(val_21 != 0)
            {
                    if(val_20 != 0)
            {
                    System.Text.StringBuilder val_12 = val_1.Append(value:  ",");
                val_21 = this.<Id>k__BackingField;
            }
            
                System.Text.StringBuilder val_14 = val_1.Append(value:  val_21.ToString());
                val_20 = 0;
            }
            
            val_22 = 0;
            if((System.String.IsNullOrEmpty(value:  this.<Payload>k__BackingField)) != true)
            {
                    if(val_20 != 0)
            {
                    System.Text.StringBuilder val_16 = val_1.Append(value:  ",");
            }
            
                val_22 = this.<Payload>k__BackingField;
                System.Text.StringBuilder val_17 = val_1.Append(value:  val_22);
            }
            
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
        internal byte[] EncodeBinary()
        {
            System.Byte[] val_14;
            System.Byte[] val_15;
            int val_16;
            var val_17;
            string val_19;
            if((this.<AttachmentCount>k__BackingField) == 0)
            {
                goto label_1;
            }
            
            label_16:
            if(this.attachments == null)
            {
                goto label_2;
            }
            
            if((this.<AttachmentCount>k__BackingField) != this.attachments.Count)
            {
                goto label_3;
            }
            
            label_17:
            string val_2 = this.Encode();
            val_14 = System.Text.Encoding.UTF8;
            val_15 = val_14.EncodeData(data:  val_14, type:  0, afterHeaderData:  0);
            System.Byte[] val_11 = val_15;
            val_16 = this.<AttachmentCount>k__BackingField;
            if(val_16 == 0)
            {
                    return val_11;
            }
            
            if(val_15 == null)
            {
                    val_16 = this.<AttachmentCount>k__BackingField;
            }
            
            int val_16 = val_4.Length;
            System.Collections.Generic.List<System.Byte[]> val_5 = null;
            val_14 = val_5;
            val_5 = new System.Collections.Generic.List<System.Byte[]>(capacity:  val_16);
            if((this.<AttachmentCount>k__BackingField) < 1)
            {
                goto label_7;
            }
            
            var val_14 = 0;
            do
            {
                byte[] val_7 = new byte[1];
                val_7[0] = 4;
                val_16 = val_7.EncodeData(data:  this.attachments.Item[0], type:  1, afterHeaderData:  val_7);
                val_5.Add(item:  val_16);
                val_14 = val_14 + 1;
                val_17 = 0 + val_8.Length;
            }
            while(val_14 < (this.<AttachmentCount>k__BackingField));
            
            val_15 = val_11;
            if(val_15 != 0)
            {
                goto label_14;
            }
            
            label_1:
            if(this.attachments == null)
            {
                goto label_17;
            }
            
            if(this.attachments.Count != 0)
            {
                goto label_16;
            }
            
            goto label_17;
            label_7:
            val_17 = 0;
            label_14:
            System.Array.Resize<System.Byte>(array: ref  val_11, newSize:  val_17 + val_4.Length);
            if((this.<AttachmentCount>k__BackingField) < 1)
            {
                    return val_11;
            }
            
            val_17 = 1152921518979102736;
            var val_15 = 0;
            do
            {
                val_16 = val_5.Item[0];
                System.Array.Copy(sourceArray:  val_16, sourceIndex:  0, destinationArray:  val_11, destinationIndex:  val_16, length:  val_12.Length);
                val_15 = val_15 + 1;
                val_16 = val_16 + val_12.Length;
            }
            while(val_15 < (this.<AttachmentCount>k__BackingField));
            
            return val_11;
            label_2:
            val_19 = "packet.Attachments are null!";
            goto label_23;
            label_3:
            val_19 = "packet.AttachmentCount != packet.Attachments.Count. Use the packet.AddAttachment function to add data to a packet!";
            label_23:
            null = new System.ArgumentException(message:  val_19);
        }
        internal void AddAttachmentFromServer(byte[] data, bool copyFull)
        {
            System.Array val_5;
            System.Array val_6;
            var val_7;
            System.Byte[] val_8;
            val_5 = copyFull;
            val_6 = data;
            if(val_6 == null)
            {
                    return;
            }
            
            if(data.Length == 0)
            {
                    return;
            }
            
            if(this.attachments == null)
            {
                goto label_3;
            }
            
            if(val_5 == false)
            {
                goto label_4;
            }
            
            label_7:
            val_7 = 1152921518978753168;
            val_8 = val_6;
            goto label_6;
            label_3:
            this.attachments = new System.Collections.Generic.List<System.Byte[]>(capacity:  this.<AttachmentCount>k__BackingField);
            if(val_5 == true)
            {
                goto label_7;
            }
            
            label_4:
            int val_2 = data.Length - 1;
            byte[] val_3 = new byte[0];
            val_5 = val_3;
            System.Array.Copy(sourceArray:  val_6, sourceIndex:  1, destinationArray:  val_3, destinationIndex:  0, length:  data.Length - 1);
            val_6 = this.attachments;
            val_7 = 1152921518978753168;
            val_8 = val_5;
            label_6:
            val_6.Add(item:  val_3);
        }
        private byte[] EncodeData(byte[] data, BestHTTP.SocketIO.Packet.PayloadTypes type, byte[] afterHeaderData)
        {
            var val_11;
            var val_12;
            int val_13;
            int val_14;
            if(afterHeaderData == null)
            {
                goto label_1;
            }
            
            if(data != null)
            {
                goto label_24;
            }
            
            label_25:
            label_24:
            int val_10 = data.Length;
            val_10 = afterHeaderData.Length + val_10;
            string val_1 = val_10.ToString();
            int val_2 = val_1.Length;
            byte[] val_3 = new byte[0];
            val_11 = 0;
            goto label_4;
            label_11:
            val_12 = 0;
            val_11 = 1;
            val_3[val_12] = (int)System.Char.GetNumericValue(c:  val_1.Chars[0]);
            label_4:
            if(val_11 < val_1.Length)
            {
                goto label_11;
            }
            
            if(data == null)
            {
                goto label_12;
            }
            
            label_27:
            int val_11 = data.Length;
            val_11 = afterHeaderData.Length + val_11;
            val_11 = val_11 + val_3.Length;
            int val_7 = val_11 + 2;
            byte[] val_8 = new byte[0];
            val_8[0] = type;
            val_13 = val_3.Length;
            if(val_13 >= 1)
            {
                    do
            {
                long val_13 = 0;
                val_13 = val_13 + 1;
                val_12 = (long)val_13;
                val_8[val_12] = val_3[val_13];
                val_13 = val_3.Length;
            }
            while(val_13 < val_13);
            
            }
            
            val_14 = val_13 + 2;
            val_8[(long)val_13 + 1] = 255;
            if((afterHeaderData != null) && (afterHeaderData.Length != 0))
            {
                    System.Array.Copy(sourceArray:  afterHeaderData, sourceIndex:  0, destinationArray:  val_8, destinationIndex:  val_14, length:  afterHeaderData.Length);
                val_14 = val_14 + afterHeaderData.Length;
            }
            
            System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_8, destinationIndex:  val_14, length:  data.Length);
            return (System.Byte[])val_8;
            label_1:
            if(data != null)
            {
                goto label_24;
            }
            
            goto label_25;
            label_12:
            if(val_3 != null)
            {
                goto label_27;
            }
            
            goto label_27;
        }
        private bool PlaceholderReplacer(System.Action<string, System.Collections.Generic.Dictionary<string, object>> onFound, bool exitOnFound)
        {
            var val_17;
            int val_18;
            var val_19;
            object val_14 = 0;
            val_17 = 0;
            if((System.String.IsNullOrEmpty(value:  this.<Payload>k__BackingField)) == true)
            {
                    return (bool)val_17;
            }
            
            val_18 = this.<Payload>k__BackingField.IndexOf(value:  "_placeholder");
            if((val_18 & 2147483648) != 0)
            {
                goto label_24;
            }
            
            label_26:
            int val_18 = val_18;
            do
            {
                val_19 = 1;
                val_18 = val_18 - 1;
                var val_5 = val_19 + 1;
            }
            while(((this.<Payload>k__BackingField.Chars[val_18]) & 65535) != '{');
            
            goto label_6;
            label_10:
            val_18 = val_18 + 1;
            val_19 = 2;
            label_6:
            if((this.<Payload>k__BackingField.Length) > val_18)
            {
                    if(((this.<Payload>k__BackingField.Chars[val_18]) & 65535) != '}')
            {
                goto label_10;
            }
            
            }
            
            if((this.<Payload>k__BackingField.Length) <= val_18)
            {
                goto label_22;
            }
            
            string val_10 = this.<Payload>k__BackingField.Substring(startIndex:  val_18, length:  2);
            bool val_11 = false;
            object val_12 = BestHTTP.JSON.Json.Decode(json:  val_10, success: ref  val_11);
            val_19 = 0;
            if(val_11 == 0)
            {
                goto label_22;
            }
            
            if(((TryGetValue(key:  "_placeholder", value: out  val_14)) == false) || (127 == 0))
            {
                goto label_22;
            }
            
            if((TryGetValue(key:  "num", value: out  val_14)) == false)
            {
                goto label_22;
            }
            
            onFound.Invoke(arg1:  val_10, arg2:  null);
            if(exitOnFound != true)
            {
                    if(((this.<Payload>k__BackingField.IndexOf(value:  "_placeholder")) & 2147483648) == 0)
            {
                goto label_26;
            }
            
            }
            
            label_24:
            val_17 = 1;
            return (bool)val_17;
            label_22:
            val_17 = 0;
            return (bool)val_17;
        }
        public override string ToString()
        {
            return (string)this.<Payload>k__BackingField;
        }
        internal BestHTTP.SocketIO.Packet Clone()
        {
            string val_2;
            string val_3;
            BestHTTP.SocketIO.Packet val_1 = new BestHTTP.SocketIO.Packet();
            .<TransportEvent>k__BackingField = this.<TransportEvent>k__BackingField;
            .<SocketIOEvent>k__BackingField = this.<SocketIOEvent>k__BackingField;
            .<Namespace>k__BackingField = this.<Namespace>k__BackingField;
            .<Payload>k__BackingField = this.<Payload>k__BackingField;
            .<AttachmentCount>k__BackingField = 0;
            .<Id>k__BackingField = this.<Id>k__BackingField;
            val_2 = this.<EventName>k__BackingField;
            if(val_1 != null)
            {
                    .<EventName>k__BackingField = val_2;
                .<AttachmentCount>k__BackingField = this.<AttachmentCount>k__BackingField;
                .attachments = this.attachments;
                .<OriginalPayload>k__BackingField = this.<OriginalPayload>k__BackingField;
                val_3 = this.<OriginalEventName>k__BackingField;
            }
            else
            {
                    mem[56] = val_2;
                .<AttachmentCount>k__BackingField = this.<AttachmentCount>k__BackingField;
                mem[64] = this.attachments;
                val_2 = this.<OriginalPayload>k__BackingField;
                mem[88] = val_2;
                val_3 = this.<OriginalEventName>k__BackingField;
            }
            
            .<OriginalEventName>k__BackingField = val_3;
            return val_1;
        }
        private void <ReconstructAttachmentAsIndex>b__59_0(string json, System.Collections.Generic.Dictionary<string, object> obj)
        {
            this.<Payload>k__BackingField = this.<Payload>k__BackingField.Replace(oldValue:  json, newValue:  System.Convert.ToInt32(value:  obj.Item["num"]).ToString());
            this.<IsDecoded>k__BackingField = false;
        }
        private void <ReconstructAttachmentAsBase64>b__61_0(string json, System.Collections.Generic.Dictionary<string, object> obj)
        {
            this.<Payload>k__BackingField = this.<Payload>k__BackingField.Replace(oldValue:  json, newValue:  System.String.Format(format:  "\"{0}\"", arg0:  System.Convert.ToBase64String(inArray:  this.attachments.Item[System.Convert.ToInt32(value:  obj.Item["num"])])));
            this.<IsDecoded>k__BackingField = false;
        }
    
    }

}
