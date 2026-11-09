using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal class TlsStream : Stream
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Tls.TlsProtocol handler;
        
        // Properties
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        internal TlsStream(Org.BouncyCastle.Crypto.Tls.TlsProtocol handler)
        {
            this.handler = handler;
        }
        public override bool get_CanRead()
        {
            Org.BouncyCastle.Crypto.Tls.TlsProtocol val_1 = this.handler;
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override bool get_CanSeek()
        {
            return false;
        }
        public override bool get_CanWrite()
        {
            Org.BouncyCastle.Crypto.Tls.TlsProtocol val_1 = this.handler;
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override void Close()
        {
            this.Close();
        }
        public override void Flush()
        {
            if(this.handler == null)
            {
                
            }
        
        }
        public override long get_Length()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override long get_Position()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override void set_Position(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override int Read(byte[] buf, int off, int len)
        {
            if(this.handler == null)
            {
                
            }
        
        }
        public override int ReadByte()
        {
            byte val_2;
            if(this >= 1)
            {
                    val_2 = new byte[1][0];
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override void SetLength(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override void Write(byte[] buf, int off, int len)
        {
            if(this.handler == null)
            {
                
            }
        
        }
        public override void WriteByte(byte b)
        {
            new byte[1][0] = b;
            if(this.handler == null)
            {
                
            }
        
        }
    
    }

}
