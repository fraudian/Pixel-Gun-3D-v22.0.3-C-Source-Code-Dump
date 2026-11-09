using UnityEngine;

namespace BestHTTP.WebSocket.Extensions
{
    public sealed class PerMessageCompression : IExtension
    {
        // Fields
        private static readonly byte[] Trailer;
        private bool <ClientNoContextTakeover>k__BackingField;
        private bool <ServerNoContextTakeover>k__BackingField;
        private int <ClientMaxWindowBits>k__BackingField;
        private int <ServerMaxWindowBits>k__BackingField;
        private BestHTTP.Decompression.Zlib.CompressionLevel <Level>k__BackingField;
        private int <MinimumDataLegthToCompress>k__BackingField;
        private System.IO.MemoryStream compressorOutputStream;
        private BestHTTP.Decompression.Zlib.DeflateStream compressorDeflateStream;
        private System.IO.MemoryStream decompressorInputStream;
        private System.IO.MemoryStream decompressorOutputStream;
        private BestHTTP.Decompression.Zlib.DeflateStream decompressorDeflateStream;
        private byte[] copyBuffer;
        
        // Properties
        public bool ClientNoContextTakeover { get; set; }
        public bool ServerNoContextTakeover { get; set; }
        public int ClientMaxWindowBits { get; set; }
        public int ServerMaxWindowBits { get; set; }
        public BestHTTP.Decompression.Zlib.CompressionLevel Level { get; set; }
        public int MinimumDataLegthToCompress { get; set; }
        
        // Methods
        public bool get_ClientNoContextTakeover()
        {
            return (bool)this.<ClientNoContextTakeover>k__BackingField;
        }
        private void set_ClientNoContextTakeover(bool value)
        {
            this.<ClientNoContextTakeover>k__BackingField = value;
        }
        public bool get_ServerNoContextTakeover()
        {
            return (bool)this.<ServerNoContextTakeover>k__BackingField;
        }
        private void set_ServerNoContextTakeover(bool value)
        {
            this.<ServerNoContextTakeover>k__BackingField = value;
        }
        public int get_ClientMaxWindowBits()
        {
            return (int)this.<ClientMaxWindowBits>k__BackingField;
        }
        private void set_ClientMaxWindowBits(int value)
        {
            this.<ClientMaxWindowBits>k__BackingField = value;
        }
        public int get_ServerMaxWindowBits()
        {
            return (int)this.<ServerMaxWindowBits>k__BackingField;
        }
        private void set_ServerMaxWindowBits(int value)
        {
            this.<ServerMaxWindowBits>k__BackingField = value;
        }
        public BestHTTP.Decompression.Zlib.CompressionLevel get_Level()
        {
            return (BestHTTP.Decompression.Zlib.CompressionLevel)this.<Level>k__BackingField;
        }
        private void set_Level(BestHTTP.Decompression.Zlib.CompressionLevel value)
        {
            this.<Level>k__BackingField = value;
        }
        public int get_MinimumDataLegthToCompress()
        {
            return (int)this.<MinimumDataLegthToCompress>k__BackingField;
        }
        public void set_MinimumDataLegthToCompress(int value)
        {
            this.<MinimumDataLegthToCompress>k__BackingField = value;
        }
        public PerMessageCompression()
        {
        
        }
        public PerMessageCompression(BestHTTP.Decompression.Zlib.CompressionLevel level, bool clientNoContextTakeover, bool serverNoContextTakeover, int desiredClientMaxWindowBits, int desiredServerMaxWindowBits, int minDatalengthToCompress)
        {
            this.copyBuffer = new byte[1024];
            this.<ClientMaxWindowBits>k__BackingField = desiredClientMaxWindowBits;
            this.<ServerMaxWindowBits>k__BackingField = desiredServerMaxWindowBits;
            this.<ClientNoContextTakeover>k__BackingField = clientNoContextTakeover;
            this.<Level>k__BackingField = level;
            this.<MinimumDataLegthToCompress>k__BackingField = minDatalengthToCompress;
        }
        public void AddNegotiation(BestHTTP.HTTPRequest request)
        {
            string val_8;
            string val_9;
            val_8 = "permessage-deflate";
            if((this.<ServerNoContextTakeover>k__BackingField) != false)
            {
                    val_8 = val_8 + "; server_no_context_takeover";
            }
            
            if((this.<ClientNoContextTakeover>k__BackingField) != false)
            {
                    val_8 = val_8 + "; client_no_context_takeover";
            }
            
            if((this.<ServerMaxWindowBits>k__BackingField) == 15)
            {
                    this.<ServerMaxWindowBits>k__BackingField = this.<ServerMaxWindowBits>k__BackingField;
            }
            else
            {
                    val_8 = val_8 + "; server_max_window_bits="("; server_max_window_bits=") + this.<ServerMaxWindowBits>k__BackingField.ToString()(this.<ServerMaxWindowBits>k__BackingField.ToString());
            }
            
            if((this.<ClientMaxWindowBits>k__BackingField) != 15)
            {
                goto label_5;
            }
            
            val_9 = val_8 + "; client_max_window_bits";
            this.<ClientMaxWindowBits>k__BackingField = 15;
            if(request != null)
            {
                goto label_8;
            }
            
            goto label_7;
            label_5:
            val_9 = val_8 + "; client_max_window_bits="("; client_max_window_bits=") + this.<ClientMaxWindowBits>k__BackingField.ToString()(this.<ClientMaxWindowBits>k__BackingField.ToString());
            if(request != null)
            {
                goto label_8;
            }
            
            label_7:
            label_8:
            request.AddHeader(name:  "Sec-WebSocket-Extensions", value:  val_9);
        }
        public bool ParseNegotiation(BestHTTP.WebSocket.WebSocketResponse resp)
        {
            BestHTTP.WebSocket.Extensions.PerMessageCompression val_30;
            var val_31;
            string val_32;
            var val_33;
            var val_34;
            int val_24 = 0;
            BestHTTP.Extensions.HeaderValue val_18 = 0;
            val_32 = resp.GetHeaderValues(name:  "Sec-WebSocket-Extensions");
            if(val_32 == null)
            {
                    return (bool)val_31;
            }
            
            if(val_32.Count < 1)
            {
                goto label_3;
            }
            
            val_30 = 1152921553690582976;
            var val_30 = 0;
            label_15:
            BestHTTP.Extensions.HeaderParser val_4 = null;
            val_33 = val_4;
            val_4 = new BestHTTP.Extensions.HeaderParser(headerStr:  val_32.Item[0]);
            val_34 = 0;
            goto label_4;
            label_14:
            BestHTTP.Extensions.HeaderValue val_6 = val_4.Values.Item[0];
            if((System.String.IsNullOrEmpty(value:  val_6.Key)) != true)
            {
                    if((val_6.Key.StartsWith(value:  "permessage-deflate", comparisonType:  5)) == true)
            {
                goto label_11;
            }
            
            }
            
            val_34 = 1;
            label_4:
            if(val_34 < val_4.Values.Count)
            {
                goto label_14;
            }
            
            val_30 = val_30 + 1;
            if(val_30 < val_32.Count)
            {
                goto label_15;
            }
            
            label_3:
            val_31 = 0;
            return (bool)val_31;
            label_11:
            val_33 = BestHTTP.HTTPManager.Logger;
            val_32 = "Enabled with header: "("Enabled with header: ") + val_32.Item[0];
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_33.Information(division:  "PerMessageCompression", info:  val_32);
            val_30 = this;
            if((val_6.TryGetOption(key:  "client_no_context_takeover", option: out  val_18)) != false)
            {
                    mem[1152921553690657888] = 1;
            }
            
            if((val_6.TryGetOption(key:  "server_no_context_takeover", option: out  val_18)) != false)
            {
                    mem[1152921553690657889] = 1;
            }
            
            if((val_6.TryGetOption(key:  "client_max_window_bits", option: out  val_18)) != false)
            {
                    val_32 = val_18;
                if(val_32.HasValue != false)
            {
                    val_32 = val_18;
                if((System.Int32.TryParse(s:  val_32.Value, result: out  val_24)) != false)
            {
                    mem[1152921553690657892] = 0;
            }
            
            }
            
            }
            
            if(((val_6.TryGetOption(key:  "server_max_window_bits", option: out  val_18)) != false) && (val_18.HasValue != false))
            {
                    if((System.Int32.TryParse(s:  val_18.Value, result: out  val_24)) != false)
            {
                    mem[1152921553690657896] = 0;
            }
            
            }
            
            val_31 = 1;
            return (bool)val_31;
        }
        public byte GetFrameHeader(BestHTTP.WebSocket.Frames.WebSocketFrame writer, byte inFlag)
        {
            var val_3;
            BestHTTP.WebSocket.Frames.WebSocketFrameTypes val_3 = writer.<Type>k__BackingField;
            val_3 = val_3 - 1;
            if((val_3 <= 1) && ((writer.<Data>k__BackingField) != null))
            {
                    var val_2 = ((this.<MinimumDataLegthToCompress>k__BackingField) <= (writer.<Data>k__BackingField.Length)) ? (inFlag | 64) : inFlag;
                return (byte)val_3;
            }
            
            val_3 = inFlag;
            return (byte)val_3;
        }
        public byte[] Encode(BestHTTP.WebSocket.Frames.WebSocketFrame writer)
        {
            var val_1;
            System.Byte[] val_2;
            var val_3;
            val_1 = writer;
            val_2 = writer.<Data>k__BackingField;
            if(val_2 != null)
            {
                    if(((writer.<Header>k__BackingField) & 64) == 0)
            {
                    return val_2;
            }
            
                return this.Compress(data:  val_2);
            }
            
            val_1 = 1152921505555034112;
            val_3 = null;
            val_3 = null;
            val_2 = BestHTTP.WebSocket.Frames.WebSocketFrame.NoData;
            return val_2;
        }
        public byte[] Decode(byte header, byte[] data)
        {
            if((header & 64) != 0)
            {
                    return this.Decompress(data:  data);
            }
            
            return (System.Byte[])data;
        }
        private byte[] Compress(byte[] data)
        {
            System.IO.MemoryStream val_4;
            BestHTTP.Decompression.Zlib.DeflateStream val_5;
            val_4 = this.compressorOutputStream;
            if(val_4 == null)
            {
                    System.IO.MemoryStream val_1 = null;
                val_4 = val_1;
                val_1 = new System.IO.MemoryStream();
                this.compressorOutputStream = val_4;
                if(val_4 == null)
            {
                goto label_21;
            }
            
            }
            
            val_5 = this.compressorDeflateStream;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            if(data != null)
            {
                goto label_7;
            }
            
            goto label_5;
            label_3:
            this.compressorDeflateStream = new BestHTTP.Decompression.Zlib.DeflateStream(stream:  this.compressorOutputStream, mode:  0, level:  this.<Level>k__BackingField, leaveOpen:  true, windowBits:  this.<ClientMaxWindowBits>k__BackingField);
            val_5 = this.compressorDeflateStream;
            if(data != null)
            {
                goto label_7;
            }
            
            label_5:
            label_7:
            System.IO.MemoryStream val_3 = this.compressorOutputStream - 4;
            label_23:
            if((this.<ClientNoContextTakeover>k__BackingField) != false)
            {
                    this.compressorDeflateStream.Dispose();
                this.compressorDeflateStream = 0;
            }
            
            if(0 != 1)
            {
                    return (System.Byte[])this.compressorOutputStream;
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])this.compressorOutputStream;
            }
            
            return (System.Byte[])this.compressorOutputStream;
            label_21:
            if(0 != 1)
            {
                goto label_22;
            }
            
            goto label_23;
            label_22:
        }
        private byte[] Decompress(byte[] data)
        {
            System.IO.MemoryStream val_5;
            var val_6;
            System.IO.MemoryStream val_7;
            BestHTTP.Decompression.Zlib.DeflateStream val_8;
            val_5 = this.decompressorInputStream;
            if(val_5 == null)
            {
                goto label_1;
            }
            
            if(data != null)
            {
                goto label_3;
            }
            
            goto label_3;
            label_1:
            System.IO.MemoryStream val_2 = null;
            val_5 = val_2;
            val_2 = new System.IO.MemoryStream(capacity:  data.Length + 4);
            this.decompressorInputStream = val_5;
            if(val_5 == null)
            {
                goto label_14;
            }
            
            label_3:
            val_6 = null;
            val_6 = null;
            if(BestHTTP.WebSocket.Extensions.PerMessageCompression.Trailer == null)
            {
                goto label_8;
            }
            
            label_28:
            if(this.decompressorDeflateStream == null)
            {
                    this.decompressorDeflateStream = new BestHTTP.Decompression.Zlib.DeflateStream(stream:  this.decompressorInputStream, mode:  1, level:  6, leaveOpen:  true, windowBits:  this.<ServerMaxWindowBits>k__BackingField);
            }
            
            val_7 = this.decompressorOutputStream;
            if(val_7 != null)
            {
                goto label_17;
            }
            
            System.IO.MemoryStream val_4 = null;
            val_7 = val_4;
            val_4 = new System.IO.MemoryStream();
            this.decompressorOutputStream = val_7;
            if(val_7 == null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_22:
            if(this.decompressorOutputStream != null)
            {
                goto label_17;
            }
            
            goto label_17;
            label_20:
            if(this.decompressorOutputStream != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_17:
            val_8 = this.decompressorDeflateStream;
            if(this.copyBuffer == null)
            {
                goto label_20;
            }
            
            label_19:
            if(val_8 != null)
            {
                goto label_22;
            }
            
            if((this.<ServerNoContextTakeover>k__BackingField) == false)
            {
                    return (System.Byte[])this.decompressorOutputStream;
            }
            
            val_8 = this.decompressorDeflateStream;
            val_8.Dispose();
            this.decompressorDeflateStream = 0;
            return (System.Byte[])this.decompressorOutputStream;
            label_8:
            if(this.decompressorInputStream != null)
            {
                goto label_28;
            }
            
            goto label_28;
            label_14:
        }
        private static PerMessageCompression()
        {
            int val_2;
            byte[] val_1 = new byte[4];
            val_2 = val_1.Length;
            if(val_2 <= 2)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[0] = 255;
            val_1[0] = 255;
            BestHTTP.WebSocket.Extensions.PerMessageCompression.Trailer = val_1;
        }
    
    }

}
