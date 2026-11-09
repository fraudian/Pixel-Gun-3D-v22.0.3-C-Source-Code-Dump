using UnityEngine;

namespace BestHTTP
{
    public sealed class StreamList : Stream
    {
        // Fields
        private System.IO.Stream[] Streams;
        private int CurrentIdx;
        
        // Properties
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        public StreamList(System.IO.Stream[] streams)
        {
            this.Streams = streams;
            this.CurrentIdx = 0;
        }
        public override bool get_CanRead()
        {
            if(this.CurrentIdx >= this.Streams.Length)
            {
                    return false;
            }
            
            System.IO.Stream val_6 = this.Streams[this.CurrentIdx];
            this = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_198;
        }
        public override bool get_CanSeek()
        {
            return false;
        }
        public override bool get_CanWrite()
        {
            if(this.CurrentIdx >= this.Streams.Length)
            {
                    return false;
            }
            
            System.IO.Stream val_6 = this.Streams[this.CurrentIdx];
            this = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_1C8;
        }
        public override void Flush()
        {
            if(this.CurrentIdx >= this.Streams.Length)
            {
                    return;
            }
            
            if((this.CurrentIdx & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                System.IO.Stream val_1 = this.Streams[0];
                this.Streams = 0 + 1;
            }
            while(this.Streams <= this.CurrentIdx);
        
        }
        public override long get_Length()
        {
            System.IO.Stream[] val_1;
            var val_2;
            var val_3;
            val_1 = this.Streams;
            if(this.CurrentIdx >= this.Streams.Length)
            {
                goto label_1;
            }
            
            val_2 = 0;
            val_3 = 0;
            goto label_2;
            label_7:
            System.IO.Stream val_1 = this.Streams[0];
            val_2 = 1;
            label_2:
            val_1 = this.Streams;
            if(val_2 < this.Streams.Length)
            {
                goto label_7;
            }
            
            return (long)val_3;
            label_1:
            val_3 = 0;
            return (long)val_3;
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            var val_4;
            if(this.CurrentIdx >= this.Streams.Length)
            {
                goto label_1;
            }
            
            val_4 = this.Streams[this.CurrentIdx];
            goto label_5;
            label_11:
            this.CurrentIdx = this.CurrentIdx + 1;
            if(this.CurrentIdx >= this.Streams.Length)
            {
                    return (int)val_4;
            }
            
            System.IO.Stream val_2 = val_4 + offset;
            int val_3 = count - val_4;
            val_4 = this.Streams[this.CurrentIdx] + val_4;
            label_5:
            if(val_4 < count)
            {
                goto label_11;
            }
            
            return (int)val_4;
            label_1:
            val_4 = 0;
            return (int)val_4;
        }
        public override void Write(byte[] buffer, int offset, int count)
        {
            int val_9;
            var val_10;
            var val_11;
            val_9 = this.CurrentIdx;
            val_10 = count;
            val_11 = buffer;
            if(val_9 >= this.Streams.Length)
            {
                    return;
            }
            
            System.IO.Stream val_9 = this.Streams[this.CurrentIdx];
            val_10 = ???;
            val_11 = ???;
            val_9 = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_328;
        }
        public void Write(string str)
        {
            if((BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  str)) == null)
            {
                
            }
        
        }
        protected override void Dispose(bool disposing)
        {
            var val_3 = 0;
            goto label_5;
            label_19:
            this.Streams[0].Dispose();
            val_3 = 1;
            label_5:
            if(val_3 < this.Streams.Length)
            {
                goto label_19;
            }
        
        }
        public override long get_Position()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  "Position get");
        }
        public override void set_Position(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  "Position set");
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            var val_8;
            var val_9;
            val_8 = this;
            val_9 = origin;
            if(this.CurrentIdx >= this.Streams.Length)
            {
                    return 0;
            }
            
            System.IO.Stream val_8 = this.Streams[this.CurrentIdx];
            val_9 = ???;
            val_8 = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_2E8;
        }
        public override void SetLength(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  "SetLength");
        }
    
    }

}
