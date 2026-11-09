using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsDeflateCompression : TlsCompression
    {
        // Fields
        public const int LEVEL_NONE = 0;
        public const int LEVEL_FASTEST = 1;
        public const int LEVEL_SMALLEST = 9;
        public const int LEVEL_DEFAULT = -1;
        protected readonly Org.BouncyCastle.Utilities.Zlib.ZStream zIn;
        protected readonly Org.BouncyCastle.Utilities.Zlib.ZStream zOut;
        
        // Methods
        public TlsDeflateCompression()
        {
        
        }
        public TlsDeflateCompression(int level)
        {
            Org.BouncyCastle.Utilities.Zlib.ZStream val_1 = new Org.BouncyCastle.Utilities.Zlib.ZStream();
            this.zIn = val_1;
            int val_2 = val_1.inflateInit();
            Org.BouncyCastle.Utilities.Zlib.ZStream val_3 = new Org.BouncyCastle.Utilities.Zlib.ZStream();
            this.zOut = val_3;
            int val_4 = val_3.deflateInit(level:  level);
        }
        public virtual System.IO.Stream Compress(System.IO.Stream output)
        {
            TlsDeflateCompression.DeflateOutputStream val_1 = new TlsDeflateCompression.DeflateOutputStream(output:  output, z:  this.zOut);
            mem[1152921547527628504] = 1;
            val_1.FlushMode = 2;
            return (System.IO.Stream)val_1;
        }
        public virtual System.IO.Stream Decompress(System.IO.Stream output)
        {
            TlsDeflateCompression.DeflateOutputStream val_1 = new TlsDeflateCompression.DeflateOutputStream(output:  output, z:  this.zIn);
            mem[1152921547527765080] = 0;
            val_1.FlushMode = 2;
            return (System.IO.Stream)val_1;
        }
    
    }

}
