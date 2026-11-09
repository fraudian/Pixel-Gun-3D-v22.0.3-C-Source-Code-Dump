using UnityEngine;

namespace BestHTTP.WebSocket.Frames
{
    public sealed class WebSocketFrame
    {
        // Fields
        public static readonly byte[] NoData;
        private BestHTTP.WebSocket.Frames.WebSocketFrameTypes <Type>k__BackingField;
        private bool <IsFinal>k__BackingField;
        private byte <Header>k__BackingField;
        private byte[] <Data>k__BackingField;
        private bool <UseExtensions>k__BackingField;
        
        // Properties
        public BestHTTP.WebSocket.Frames.WebSocketFrameTypes Type { get; set; }
        public bool IsFinal { get; set; }
        public byte Header { get; set; }
        public byte[] Data { get; set; }
        public bool UseExtensions { get; set; }
        
        // Methods
        public BestHTTP.WebSocket.Frames.WebSocketFrameTypes get_Type()
        {
            return (BestHTTP.WebSocket.Frames.WebSocketFrameTypes)this.<Type>k__BackingField;
        }
        private void set_Type(BestHTTP.WebSocket.Frames.WebSocketFrameTypes value)
        {
            this.<Type>k__BackingField = value;
        }
        public bool get_IsFinal()
        {
            return (bool)this.<IsFinal>k__BackingField;
        }
        private void set_IsFinal(bool value)
        {
            this.<IsFinal>k__BackingField = value;
        }
        public byte get_Header()
        {
            return (byte)this.<Header>k__BackingField;
        }
        private void set_Header(byte value)
        {
            this.<Header>k__BackingField = value;
        }
        public byte[] get_Data()
        {
            return (System.Byte[])this.<Data>k__BackingField;
        }
        private void set_Data(byte[] value)
        {
            this.<Data>k__BackingField = value;
        }
        public bool get_UseExtensions()
        {
            return (bool)this.<UseExtensions>k__BackingField;
        }
        private void set_UseExtensions(bool value)
        {
            this.<UseExtensions>k__BackingField = value;
        }
        public WebSocketFrame(BestHTTP.WebSocket.WebSocket webSocket, BestHTTP.WebSocket.Frames.WebSocketFrameTypes type, byte[] data)
        {
        
        }
        public WebSocketFrame(BestHTTP.WebSocket.WebSocket webSocket, BestHTTP.WebSocket.Frames.WebSocketFrameTypes type, byte[] data, bool useExtensions)
        {
            if(data == null)
            {
                goto label_0;
            }
            
            if(this != null)
            {
                goto label_2;
            }
            
            label_3:
            label_2:
            bool val_1 = useExtensions;
            return;
            label_0:
            if(this != null)
            {
                goto label_2;
            }
            
            goto label_3;
        }
        public WebSocketFrame(BestHTTP.WebSocket.WebSocket webSocket, BestHTTP.WebSocket.Frames.WebSocketFrameTypes type, byte[] data, bool isFinal, bool useExtensions)
        {
            if(data == null)
            {
                goto label_0;
            }
            
            if(this != null)
            {
                goto label_2;
            }
            
            label_3:
            label_2:
            bool val_1 = isFinal;
            bool val_2 = useExtensions;
            return;
            label_0:
            if(this != null)
            {
                goto label_2;
            }
            
            goto label_3;
        }
        public WebSocketFrame(BestHTTP.WebSocket.WebSocket webSocket, BestHTTP.WebSocket.Frames.WebSocketFrameTypes type, byte[] data, ulong pos, ulong length, bool isFinal, bool useExtensions)
        {
            int val_8;
            System.Array val_9;
            byte val_11;
            val_8 = length;
            val_9 = data;
            this.<Type>k__BackingField = type;
            this.<IsFinal>k__BackingField = isFinal;
            this.<UseExtensions>k__BackingField = useExtensions;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            if((val_8 & 9223372036854775808) != 0)
            {
                goto label_2;
            }
            
            ulong val_3 = val_8 & 4294967295;
            byte[] val_4 = new byte[0];
            this.<Data>k__BackingField = val_4;
            System.Array.Copy(sourceArray:  val_9, sourceIndex:  pos, destinationArray:  val_4, destinationIndex:  0, length:  val_8);
            goto label_5;
            label_1:
            label_5:
            BestHTTP.WebSocket.Frames.WebSocketFrameTypes val_10 = this.<Type>k__BackingField;
            val_10 = val_10 | ((this.<IsFinal>k__BackingField) << 7);
            this.<Header>k__BackingField = val_10;
            if(webSocket == null)
            {
                    return;
            }
            
            if((this.<UseExtensions>k__BackingField) == false)
            {
                    return;
            }
            
            val_8 = webSocket.<Extensions>k__BackingField;
            if(val_8 == null)
            {
                    return;
            }
            
            val_9 = 0;
            goto label_9;
            label_22:
            BestHTTP.WebSocket.Extensions.IExtension val_11 = webSocket.<Extensions>k__BackingField[0];
            if(val_11 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_11 = this.<Header>k__BackingField;
                this.<Header>k__BackingField = (val_11.GetFrameHeader(writer:  this, inFlag:  val_11)) | (this.<Header>k__BackingField);
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_11 = 3;
                this.<Data>k__BackingField = val_11.Encode(writer:  this);
            }
            
            val_8 = webSocket.<Extensions>k__BackingField;
            val_9 = 1;
            label_9:
            if(val_9 < (webSocket.<Extensions>k__BackingField.Length))
            {
                goto label_22;
            }
            
            return;
            label_2:
        }
        public byte[] Get()
        {
            System.Byte[] val_13;
            var val_14;
            System.Byte[] val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_13 = this.<Data>k__BackingField;
            if(val_13 == null)
            {
                    val_14 = null;
                val_14 = null;
                val_13 = BestHTTP.WebSocket.Frames.WebSocketFrame.NoData;
                this.<Data>k__BackingField = val_13;
            }
            
            System.IO.MemoryStream val_2 = new System.IO.MemoryStream(capacity:  BestHTTP.WebSocket.Frames.WebSocketFrame.NoData.Length + 9);
            val_15 = this.<Data>k__BackingField;
            if((this.<Data>k__BackingField) == null)
            {
                    val_15 = this.<Data>k__BackingField;
            }
            
            if((this.<Data>k__BackingField.Length) <= 125)
            {
                goto label_7;
            }
            
            if((this.<Data>k__BackingField.Length) <= 65534)
            {
                goto label_9;
            }
            
            System.Byte[] val_3 = System.BitConverter.GetBytes(value:  this.<Data>k__BackingField.Length);
            if(System.BitConverter.IsLittleEndian == false)
            {
                goto label_13;
            }
            
            System.Array.Reverse(array:  val_3, index:  0, length:  val_3.Length);
            goto label_24;
            label_7:
            val_16 = (this.<Data>k__BackingField.Length) | 128;
            goto label_25;
            label_9:
            System.Byte[] val_4 = System.BitConverter.GetBytes(value:  this.<Data>k__BackingField.Length);
            if(System.BitConverter.IsLittleEndian == false)
            {
                goto label_21;
            }
            
            System.Array.Reverse(array:  val_4, index:  0, length:  val_4.Length);
            goto label_26;
            label_13:
            label_24:
            val_16 = val_3;
            goto label_25;
            label_21:
            label_26:
            val_16 = val_4;
            label_25:
            val_17 = 0;
            goto label_30;
            label_35:
            byte val_10 = (System.BitConverter.GetBytes(value:  this.GetHashCode())[(long)val_17 - (((val_17 < 0) ? 3 : (val_17)) & 4294967292)]) ^ (this.<Data>k__BackingField[0]);
            val_17 = 1;
            label_30:
            if(val_17 < (this.<Data>k__BackingField.Length))
            {
                goto label_35;
            }
            
            val_18 = val_2;
            val_19 = 0;
            val_20 = 0;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_2.Dispose();
            if( != 1)
            {
                    return (System.Byte[]);
            }
            
            if(null == null)
            {
                    return (System.Byte[]);
            }
            
            return (System.Byte[]);
        }
        public BestHTTP.WebSocket.Frames.WebSocketFrame[] Fragment(ushort maxFragmentSize)
        {
            ulong val_12;
            var val_13;
            ulong val_14;
            if((this.<Data>k__BackingField) == null)
            {
                goto label_3;
            }
            
            BestHTTP.WebSocket.Frames.WebSocketFrameTypes val_11 = this.<Type>k__BackingField;
            val_11 = val_11 - 1;
            if((val_11 > 1) || ((this.<Data>k__BackingField.Length) <= maxFragmentSize))
            {
                goto label_3;
            }
            
            byte val_12 = this.<Header>k__BackingField;
            this.<IsFinal>k__BackingField = false;
            val_12 = maxFragmentSize & 65535;
            val_12 = val_12 & 127;
            this.<Header>k__BackingField = val_12;
            int val_13 = this.<Data>k__BackingField.Length;
            int val_1 = val_13 / val_12;
            val_13 = val_13 - (val_1 * val_12);
            val_13 = new BestHTTP.WebSocket.Frames.WebSocketFrame[0];
            var val_15 = -(val_1 - ((val_13 == 0) ? 1 : 0));
            val_14 = val_12;
            goto label_4;
            label_17:
            ulong val_6 = System.Math.Min(val1:  val_12, val2:  (this.<Data>k__BackingField.Length) - val_14);
            BestHTTP.WebSocket.Frames.WebSocketFrame val_9 = null;
            ulong val_7 = val_6 + val_14;
            val_9 = new BestHTTP.WebSocket.Frames.WebSocketFrame(webSocket:  0, type:  0, data:  this.<Data>k__BackingField, pos:  val_14, length:  val_6, isFinal:  (val_7 >= (this.<Data>k__BackingField.Length)) ? 1 : 0, useExtensions:  false);
            if(val_13 == null)
            {
                goto label_10;
            }
            
            if(val_9 != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_9 == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            int val_14 = val_4.Length;
            val_14 = val_15 + val_14;
            val_15 = val_15 + 1;
            val_14 = val_7;
            val_13[(long)val_14] = val_9;
            label_4:
            if(val_14 < (this.<Data>k__BackingField.Length))
            {
                goto label_17;
            }
            
            byte[] val_10 = new byte[0];
            System.Array.Copy(sourceArray:  this.<Data>k__BackingField, sourceIndex:  0, destinationArray:  val_10, destinationIndex:  0, length:  val_12);
            this.<Data>k__BackingField = val_10;
            return (BestHTTP.WebSocket.Frames.WebSocketFrame[])val_13;
            label_3:
            val_13 = 0;
            return (BestHTTP.WebSocket.Frames.WebSocketFrame[])val_13;
        }
        private static WebSocketFrame()
        {
            BestHTTP.WebSocket.Frames.WebSocketFrame.NoData = new byte[0];
        }
    
    }

}
