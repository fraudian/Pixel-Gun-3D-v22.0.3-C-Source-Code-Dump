using UnityEngine;

namespace Org.BouncyCastle.Utilities.Zlib
{
    internal sealed class Inflate
    {
        // Fields
        private const int MAX_WBITS = 15;
        private const int PRESET_DICT = 32;
        internal const int Z_NO_FLUSH = 0;
        internal const int Z_PARTIAL_FLUSH = 1;
        internal const int Z_SYNC_FLUSH = 2;
        internal const int Z_FULL_FLUSH = 3;
        internal const int Z_FINISH = 4;
        private const int Z_DEFLATED = 8;
        private const int Z_OK = 0;
        private const int Z_STREAM_END = 1;
        private const int Z_NEED_DICT = 2;
        private const int Z_ERRNO = -1;
        private const int Z_STREAM_ERROR = -2;
        private const int Z_DATA_ERROR = -3;
        private const int Z_MEM_ERROR = -4;
        private const int Z_BUF_ERROR = -5;
        private const int Z_VERSION_ERROR = -6;
        private const int METHOD = 0;
        private const int FLAG = 1;
        private const int DICT4 = 2;
        private const int DICT3 = 3;
        private const int DICT2 = 4;
        private const int DICT1 = 5;
        private const int DICT0 = 6;
        private const int BLOCKS = 7;
        private const int CHECK4 = 8;
        private const int CHECK3 = 9;
        private const int CHECK2 = 10;
        private const int CHECK1 = 11;
        private const int DONE = 12;
        private const int BAD = 13;
        internal int mode;
        internal int method;
        internal long[] was;
        internal long need;
        internal int marker;
        internal int nowrap;
        internal int wbits;
        internal Org.BouncyCastle.Utilities.Zlib.InfBlocks blocks;
        private static readonly byte[] mark;
        
        // Methods
        internal int inflateReset(Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
            var val_2;
            if((z != null) && (z.istate != null))
            {
                    z.total_in = 0;
                z.total_out = 0;
                z.msg = 0;
                z.istate.mode = (z.istate.nowrap == 0) ? 0 : 7;
                z.istate.blocks.reset(z:  z, c:  0);
                val_2 = 0;
                return (int)val_2;
            }
            
            val_2 = -2;
            return (int)val_2;
        }
        internal int inflateEnd(Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
            if(this.blocks != null)
            {
                    this.blocks.reset(z:  z, c:  0);
                this.blocks.hufts = 0;
                this.blocks.window = 0;
            }
            
            this.blocks = 0;
            return 0;
        }
        internal int inflateInit(Org.BouncyCastle.Utilities.Zlib.ZStream z, int w)
        {
            var val_9;
            var val_10;
            val_9 = w;
            int val_1 = (val_9 < 0) ? (-val_9) : (val_9);
            z.msg = 0;
            this.blocks = 0;
            this.nowrap = val_9 >> 31;
            if((val_1 & 4294967288) == 8)
            {
                    this.wbits = val_1;
                Org.BouncyCastle.Utilities.Zlib.InfBlocks val_7 = new Org.BouncyCastle.Utilities.Zlib.InfBlocks(z:  z, checkfn:  (z.istate.nowrap == 0) ? (this) : 0, w:  1 << (val_1 & 31));
                z.istate.blocks = val_7;
                int val_8 = this.inflateReset(z:  z);
                val_10 = 0;
                return (int)val_10;
            }
            
            this.blocks = 0;
            val_10 = -2;
            return (int)val_10;
        }
        internal int inflate(Org.BouncyCastle.Utilities.Zlib.ZStream z, int f)
        {
            Org.BouncyCastle.Utilities.Zlib.Inflate val_31;
            var val_32;
            var val_36;
            if(z == null)
            {
                goto label_18;
            }
            
            val_31 = z.istate;
            if((val_31 == null) || (z.next_in == null))
            {
                goto label_18;
            }
            
            val_32 = -5;
            if(z.istate.mode > 13)
            {
                goto label_18;
            }
            
            var val_4 = (106047720 + (z.istate.mode) << 2) + 106047720;
            goto (106047720 + (z.istate.mode) << 2 + 106047720);
            label_18:
            val_36 = -2;
            return (int)val_36;
        }
        internal int inflateSetDictionary(Org.BouncyCastle.Utilities.Zlib.ZStream z, byte[] dictionary, int dictLength)
        {
            int val_3;
            int val_4;
            val_3 = dictLength;
            if(((z == null) || (z.istate == null)) || (z.istate.mode != 6))
            {
                    return -2;
            }
            
            if((0.adler32(adler:  1, buf:  dictionary, index:  0, len:  val_3)) != z.adler)
            {
                    return -2;
            }
            
            z.adler = 1;
            int val_2 = z.istate.wbits;
            val_2 = val_2 & 31;
            val_2 = 1 << val_2;
            if(val_2 > val_3)
            {
                    val_4 = 0;
            }
            else
            {
                    int val_3 = z.istate.wbits;
                val_3 = val_3 & 31;
                val_3 = 1 << val_3;
                val_3 = val_3 - 1;
                val_4 = val_3 - val_3;
                val_3 = val_3;
            }
            
            System.Array.Copy(sourceArray:  dictionary, sourceIndex:  val_4, destinationArray:  z.istate.blocks.window, destinationIndex:  0, length:  val_3);
            z.istate.blocks.read = val_3;
            z.istate.blocks.write = val_3;
            z.istate.mode = 7;
            return -2;
        }
        internal int inflateSync(Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
            int val_5;
            int val_6;
            int val_7;
            var val_8;
            if((z == null) || (z.istate == null))
            {
                    return -2;
            }
            
            if(z.istate.mode != 13)
            {
                    z.istate.mode = 13;
                z.istate.marker = 0;
            }
            
            if(z.avail_in == 0)
            {
                    return -2;
            }
            
            val_5 = z.next_in_index;
            val_6 = z.istate.marker;
            if(val_6 <= 3)
            {
                goto label_7;
            }
            
            val_7 = z.avail_in;
            goto label_20;
            label_7:
            label_21:
            val_8 = null;
            val_8 = null;
            System.Byte[] val_1 = Org.BouncyCastle.Utilities.Zlib.Inflate.mark + (long)val_6;
            if(z.next_in[(long)val_5] == ((Org.BouncyCastle.Utilities.Zlib.Inflate.mark + (long)(int)(z.istate.marker)) + 32))
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    val_6 = (z.next_in[(long)val_5] == 0) ? (4 - val_6) : 0;
            }
            
            val_5 = val_5 + 1;
            val_7 = z.avail_in - 1;
            if(val_6 <= 3)
            {
                    if(z.avail_in != 1)
            {
                goto label_21;
            }
            
            }
            
            label_20:
            int val_6 = z.next_in_index;
            z.next_in_index = val_5;
            z.avail_in = val_7;
            val_6 = val_5 - val_6;
            val_6 = z.total_in + (val_6 << );
            z.total_in = val_6;
            z.istate.marker = val_6;
            if(val_6 != 4)
            {
                    return -2;
            }
            
            int val_3 = this.inflateReset(z:  z);
            z.total_in = z.total_in;
            z.total_out = z.total_out;
            z.istate.mode = 7;
            return -2;
        }
        internal int inflateSyncPoint(Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
            if(z == null)
            {
                    return -2;
            }
            
            if(z.istate == null)
            {
                    return -2;
            }
            
            if(z.istate.blocks == null)
            {
                    return -2;
            }
            
            return (int)(z.istate.blocks.mode == 1) ? 1 : 0;
        }
        public Inflate()
        {
            this.was = new long[1];
        }
        private static Inflate()
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
            Org.BouncyCastle.Utilities.Zlib.Inflate.mark = val_1;
        }
    
    }

}
