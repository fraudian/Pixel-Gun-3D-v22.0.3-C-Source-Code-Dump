using UnityEngine;

namespace BestHTTP.WebSocket.Frames
{
    public sealed class WebSocketFrameReader
    {
        // Fields
        private byte <Header>k__BackingField;
        private bool <IsFinal>k__BackingField;
        private BestHTTP.WebSocket.Frames.WebSocketFrameTypes <Type>k__BackingField;
        private bool <HasMask>k__BackingField;
        private ulong <Length>k__BackingField;
        private byte[] <Mask>k__BackingField;
        private byte[] <Data>k__BackingField;
        private string <DataAsText>k__BackingField;
        
        // Properties
        public byte Header { get; set; }
        public bool IsFinal { get; set; }
        public BestHTTP.WebSocket.Frames.WebSocketFrameTypes Type { get; set; }
        public bool HasMask { get; set; }
        public ulong Length { get; set; }
        public byte[] Mask { get; set; }
        public byte[] Data { get; set; }
        public string DataAsText { get; set; }
        
        // Methods
        public byte get_Header()
        {
            return (byte)this.<Header>k__BackingField;
        }
        private void set_Header(byte value)
        {
            this.<Header>k__BackingField = value;
        }
        public bool get_IsFinal()
        {
            return (bool)this.<IsFinal>k__BackingField;
        }
        private void set_IsFinal(bool value)
        {
            this.<IsFinal>k__BackingField = value;
        }
        public BestHTTP.WebSocket.Frames.WebSocketFrameTypes get_Type()
        {
            return (BestHTTP.WebSocket.Frames.WebSocketFrameTypes)this.<Type>k__BackingField;
        }
        private void set_Type(BestHTTP.WebSocket.Frames.WebSocketFrameTypes value)
        {
            this.<Type>k__BackingField = value;
        }
        public bool get_HasMask()
        {
            return (bool)this.<HasMask>k__BackingField;
        }
        private void set_HasMask(bool value)
        {
            this.<HasMask>k__BackingField = value;
        }
        public ulong get_Length()
        {
            return (ulong)this.<Length>k__BackingField;
        }
        private void set_Length(ulong value)
        {
            this.<Length>k__BackingField = value;
        }
        public byte[] get_Mask()
        {
            return (System.Byte[])this.<Mask>k__BackingField;
        }
        private void set_Mask(byte[] value)
        {
            this.<Mask>k__BackingField = value;
        }
        public byte[] get_Data()
        {
            return (System.Byte[])this.<Data>k__BackingField;
        }
        private void set_Data(byte[] value)
        {
            this.<Data>k__BackingField = value;
        }
        public string get_DataAsText()
        {
            return (string)this.<DataAsText>k__BackingField;
        }
        private void set_DataAsText(string value)
        {
            this.<DataAsText>k__BackingField = value;
        }
        internal void Read(System.IO.Stream stream)
        {
            bool val_14;
            System.Byte[] val_15;
            var val_16;
            ulong val_17;
            var val_18;
            System.Byte[] val_19;
            var val_20;
            byte val_1 = this.ReadByte(stream:  stream);
            this.<Header>k__BackingField = val_1;
            this.<IsFinal>k__BackingField = (uint)(val_1 >> 7) & 1;
            this.<Type>k__BackingField = val_1 & 15;
            byte val_3 = val_1.ReadByte(stream:  stream);
            var val_14 = val_3;
            val_14 = (uint)(val_14 >> 7) & 1;
            val_3 = val_14 & 127;
            val_14 = val_14 & 127;
            this.<HasMask>k__BackingField = val_14;
            this.<Length>k__BackingField = val_3;
            if(val_14 == 127)
            {
                goto label_1;
            }
            
            if(val_14 != 126)
            {
                goto label_2;
            }
            
            byte[] val_4 = new byte[2];
            val_15 = val_4;
            BestHTTP.Extensions.Extensions.ReadBuffer(stream:  stream, buffer:  val_4);
            val_16 = null;
            val_16 = null;
            if(System.BitConverter.IsLittleEndian != false)
            {
                    System.Array.Reverse(array:  val_4, index:  0, length:  val_4.Length);
                val_16 = null;
            }
            
            val_17 = (System.BitConverter.ToUInt16(value:  val_4, startIndex:  0)) & 65535;
            goto label_11;
            label_1:
            byte[] val_6 = new byte[8];
            val_15 = val_6;
            BestHTTP.Extensions.Extensions.ReadBuffer(stream:  stream, buffer:  val_6);
            val_18 = null;
            val_18 = null;
            if(System.BitConverter.IsLittleEndian != false)
            {
                    System.Array.Reverse(array:  val_6, index:  0, length:  val_6.Length);
                val_18 = null;
            }
            
            label_11:
            val_14 = this.<HasMask>k__BackingField;
            this.<Length>k__BackingField = System.BitConverter.ToUInt64(value:  val_6, startIndex:  0);
            label_2:
            if(val_14 == false)
            {
                goto label_20;
            }
            
            this.<Mask>k__BackingField = new byte[4];
            val_15 = stream;
            if(val_15 < (this.<Mask>k__BackingField.Length))
            {
                goto label_32;
            }
            
            val_17 = this.<Length>k__BackingField;
            label_20:
            if((val_17 & 9223372036854775808) != 0)
            {
                    goto label_44;
            }
            
            ulong val_9 = val_17 & 4294967295;
            val_19 = new byte[0];
            this.<Data>k__BackingField = val_19;
            if((this.<Length>k__BackingField) == 0)
            {
                    return;
            }
            
            goto label_27;
            label_34:
            val_19 = this.<Data>k__BackingField;
            goto label_27;
            label_30:
            if(stream != null)
            {
                goto label_29;
            }
            
            goto label_29;
            label_27:
            if(val_19 == null)
            {
                goto label_30;
            }
            
            label_29:
            int val_11 = val_10.Length - 0;
            if(stream <= 0)
            {
                goto label_32;
            }
            
            if(null < (this.<Data>k__BackingField.Length))
            {
                goto label_34;
            }
            
            if((this.<HasMask>k__BackingField) == false)
            {
                    return;
            }
            
            val_20 = 0;
            goto label_36;
            label_43:
            System.Byte[] val_17 = this.<Data>k__BackingField;
            var val_12 = (val_20 < 0) ? 3 : (val_20);
            val_12 = val_12 & 4294967292;
            val_12 = val_20 - val_12;
            val_17 = (this.<Mask>k__BackingField[(long)val_12]) ^ val_17[0];
            val_20 = 1;
            mem2[0] = val_17;
            label_36:
            val_15 = this.<Data>k__BackingField;
            if(val_20 < (this.<Data>k__BackingField.Length))
            {
                goto label_43;
            }
            
            return;
            label_32:
            System.Exception val_13 = BestHTTP.Extensions.ExceptionHelper.ServerClosedTCPStream();
            label_44:
            goto label_44;
        }
        private byte ReadByte(System.IO.Stream stream)
        {
            if((stream & 2147483648) == 0)
            {
                    return (byte)stream;
            }
            
            System.Exception val_1 = BestHTTP.Extensions.ExceptionHelper.ServerClosedTCPStream();
        }
        public void Assemble(System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader> fragments)
        {
            var val_12;
            ulong val_13;
            var val_14;
            var val_15;
            var val_16;
            fragments.Add(item:  this);
            val_12 = 0;
            val_13 = 0;
            goto label_2;
            label_6:
            BestHTTP.WebSocket.Frames.WebSocketFrameReader val_1 = fragments.Item[0];
            val_12 = 1;
            val_13 = (val_1.<Length>k__BackingField) + val_13;
            label_2:
            if(val_12 < fragments.Count)
            {
                goto label_6;
            }
            
            if((val_13 & 9223372036854775808) != 0)
            {
                goto label_7;
            }
            
            ulong val_3 = val_13 & 4294967295;
            byte[] val_4 = new byte[0];
            val_14 = 0;
            val_15 = 0;
            goto label_8;
            label_15:
            val_16 = public BestHTTP.WebSocket.Frames.WebSocketFrameReader System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader>::get_Item(int index);
            if(val_14 >= fragments.Count)
            {
                goto label_9;
            }
            
            label_16:
            BestHTTP.WebSocket.Frames.WebSocketFrameReader val_6 = fragments.Item[0];
            BestHTTP.WebSocket.Frames.WebSocketFrameReader val_7 = fragments.Item[0];
            System.Array.Copy(sourceArray:  val_6.<Data>k__BackingField, sourceIndex:  0, destinationArray:  val_4, destinationIndex:  0, length:  val_7.<Length>k__BackingField);
            BestHTTP.WebSocket.Frames.WebSocketFrameReader val_8 = fragments.Item[0];
            val_14 = 1;
            val_15 = (val_8.<Length>k__BackingField) + val_15;
            label_8:
            if(fragments == null)
            {
                goto label_15;
            }
            
            val_16 = public BestHTTP.WebSocket.Frames.WebSocketFrameReader System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader>::get_Item(int index);
            if(val_14 < fragments.Count)
            {
                goto label_16;
            }
            
            label_9:
            BestHTTP.WebSocket.Frames.WebSocketFrameReader val_10 = fragments.Item[0];
            this.<Type>k__BackingField = val_10.<Type>k__BackingField;
            BestHTTP.WebSocket.Frames.WebSocketFrameReader val_11 = fragments.Item[0];
            this.<Length>k__BackingField = val_13;
            this.<Data>k__BackingField = val_4;
            this.<Header>k__BackingField = val_11.<Header>k__BackingField;
            return;
            label_7:
        }
        public void DecodeWithExtensions(BestHTTP.WebSocket.WebSocket webSocket)
        {
            BestHTTP.WebSocket.Extensions.IExtension[] val_3;
            var val_4;
            if((webSocket.<Extensions>k__BackingField) == null)
            {
                goto label_2;
            }
            
            val_4 = 0;
            goto label_3;
            label_13:
            BestHTTP.WebSocket.Extensions.IExtension val_4 = webSocket.<Extensions>k__BackingField[0];
            if(val_4 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.<Data>k__BackingField = val_4.Decode(header:  this.<Header>k__BackingField, data:  this.<Data>k__BackingField);
            }
            
            val_4 = 1;
            label_3:
            val_3 = webSocket.<Extensions>k__BackingField;
            if(val_4 < (webSocket.<Extensions>k__BackingField.Length))
            {
                goto label_13;
            }
            
            label_2:
            if((this.<Type>k__BackingField) != 1)
            {
                    return;
            }
            
            if((this.<Data>k__BackingField) == null)
            {
                    return;
            }
            
            val_3 = System.Text.Encoding.UTF8;
            if((this.<Data>k__BackingField) == null)
            {
                goto label_16;
            }
            
            label_19:
            this.<DataAsText>k__BackingField = val_3;
            return;
            label_16:
            if(val_3 != null)
            {
                goto label_19;
            }
            
            goto label_19;
        }
        public WebSocketFrameReader()
        {
        
        }
    
    }

}
