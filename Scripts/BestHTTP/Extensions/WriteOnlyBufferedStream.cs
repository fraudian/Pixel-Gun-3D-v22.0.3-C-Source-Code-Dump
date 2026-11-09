using UnityEngine;

namespace BestHTTP.Extensions
{
    public sealed class WriteOnlyBufferedStream : Stream
    {
        // Fields
        private int _position;
        private byte[] buffer;
        private System.IO.Stream stream;
        
        // Properties
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        public override bool get_CanRead()
        {
            return false;
        }
        public override bool get_CanSeek()
        {
            return false;
        }
        public override bool get_CanWrite()
        {
            return true;
        }
        public override long get_Length()
        {
            if(this.buffer != null)
            {
                    return (long)this.buffer.Length;
            }
            
            return (long)this.buffer.Length;
        }
        public override long get_Position()
        {
            return (long)this._position;
        }
        public override void set_Position(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  "Position set");
        }
        public WriteOnlyBufferedStream(System.IO.Stream stream, int bufferSize)
        {
            this.stream = stream;
            this.buffer = new byte[0];
            this._position = 0;
        }
        public override void Flush()
        {
            string val_7;
            if(this._position < 1)
            {
                    return;
            }
            
            val_7 = 1152921505557803008;
            var val_8 = 0;
            val_8 = val_8 + 1;
            if((BestHTTP.HTTPManager.Logger.Level & 255) == 0)
            {
                    val_7 = "BufferStream";
                var val_9 = 0;
                val_9 = val_9 + 1;
                BestHTTP.HTTPManager.Logger.Information(division:  val_7, info:  System.String.Format(format:  "Flushing {0:N0} bytes", arg0:  this._position));
            }
            
            this._position = 0;
        }
        public override void Write(byte[] bufferFrom, int offset, int count)
        {
            int val_3;
            int val_4 = count;
            int val_4 = offset;
            if(val_4 < 1)
            {
                    return;
            }
            
            do
            {
                int val_3 = this._position;
                val_3 = System.Math.Min(val1:  val_4 = count, val2:  this.buffer.Length - val_3);
                System.Array.Copy(sourceArray:  bufferFrom, sourceIndex:  val_4, destinationArray:  this.buffer, destinationIndex:  this._position, length:  val_3);
                val_3 = this._position + val_3;
                this._position = val_3;
                val_4 = val_3 + val_4;
                val_4 = val_4 - val_3;
            }
            while(val_4 > 0);
        
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            return 0;
        }
        public override void SetLength(long value)
        {
        
        }
    
    }

}
