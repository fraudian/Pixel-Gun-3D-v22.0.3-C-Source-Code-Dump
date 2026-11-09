using UnityEngine;

namespace Org.BouncyCastle.Crypto.Operators
{
    internal class SignerBucket : Stream
    {
        // Fields
        protected readonly Org.BouncyCastle.Crypto.ISigner signer;
        
        // Properties
        public override bool CanRead { get; }
        public override bool CanWrite { get; }
        public override bool CanSeek { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        public SignerBucket(Org.BouncyCastle.Crypto.ISigner signer)
        {
            this.signer = signer;
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override int ReadByte()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override void Write(byte[] buffer, int offset, int count)
        {
            if(count < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.signer.BlockUpdate(input:  buffer, inOff:  offset, length:  count);
        }
        public override void WriteByte(byte b)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.signer.Update(input:  b);
        }
        public override bool get_CanRead()
        {
            return false;
        }
        public override bool get_CanWrite()
        {
            return true;
        }
        public override bool get_CanSeek()
        {
            return false;
        }
        public override long get_Length()
        {
            return 0;
        }
        public override long get_Position()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override void set_Position(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override void Flush()
        {
        
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override void SetLength(long length)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
    
    }

}
