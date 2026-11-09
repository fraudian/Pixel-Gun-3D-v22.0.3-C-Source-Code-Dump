using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class ByteQueue
    {
        // Fields
        private const int DefaultCapacity = 1024;
        private byte[] databuf;
        private int skipped;
        private int available;
        
        // Properties
        public int Available { get; }
        
        // Methods
        public static int NextTwoPow(int i)
        {
            int val_1 = i | (i >> 1);
            val_1 = val_1 | (val_1 >> 2);
            val_1 = val_1 | (val_1 >> 4);
            val_1 = val_1 | (val_1 >> 8);
            val_1 = val_1 | (val_1 >> 16);
            i = val_1 + 1;
            return (int)i;
        }
        public ByteQueue()
        {
        
        }
        public ByteQueue(int capacity)
        {
            this.databuf = new byte[0];
        }
        public void Read(byte[] buf, int offset, int len, int skip)
        {
            var val_6;
            var val_7;
            int val_6 = buf.Length;
            val_6 = val_6 - offset;
            if(val_6 < len)
            {
                goto label_2;
            }
            
            int val_7 = this.available;
            val_7 = val_7 - skip;
            if(val_7 < len)
            {
                goto label_3;
            }
            
            System.Array.Copy(sourceArray:  this.databuf, sourceIndex:  this.skipped + skip, destinationArray:  buf, destinationIndex:  offset, length:  len);
            return;
            label_2:
            val_6 = 1152921547469563104;
            val_7 = new System.ArgumentException(message:  +new object[5]);
            goto label_4;
            label_3:
            val_6 = 1152921547469563104;
            val_7 = new System.InvalidOperationException(message:  "Not enough data to read");
            label_4:
        }
        public void AddData(byte[] data, int offset, int len)
        {
            System.Byte[] val_5;
            int val_6;
            val_5 = this.databuf;
            int val_1 = this.skipped + len;
            val_1 = val_1 + this.available;
            if(val_1 <= this.databuf.Length)
            {
                goto label_2;
            }
            
            int val_4 = this.available;
            val_4 = val_4 + len;
            val_4 = val_4 | (val_4 >> 1);
            val_4 = val_4 | (val_4 >> 2);
            val_4 = val_4 | (val_4 >> 4);
            val_4 = val_4 | (val_4 >> 8);
            val_4 = val_4 | (val_4 >> 16);
            val_5 = val_4 + 1;
            if(val_5 <= this.databuf.Length)
            {
                goto label_4;
            }
            
            byte[] val_2 = new byte[0];
            val_5 = val_2;
            System.Array.Copy(sourceArray:  this.databuf, sourceIndex:  this.skipped, destinationArray:  val_2, destinationIndex:  0, length:  this.available);
            this.databuf = val_5;
            goto label_5;
            label_2:
            val_6 = this.skipped;
            goto label_6;
            label_4:
            System.Array.Copy(sourceArray:  this.databuf, sourceIndex:  this.skipped, destinationArray:  this.databuf, destinationIndex:  0, length:  this.available);
            label_5:
            val_6 = 0;
            this.skipped = 0;
            label_6:
            System.Array.Copy(sourceArray:  data, sourceIndex:  offset, destinationArray:  this.databuf, destinationIndex:  this.available + val_6, length:  len);
            int val_5 = this.available;
            val_5 = val_5 + len;
            this.available = val_5;
        }
        public void RemoveData(int i)
        {
            int val_5 = this.available;
            val_5 = val_5 - i;
            if()
            {
                    this.available = val_5;
                this.skipped = this.skipped + i;
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  +new object[4]);
        }
        public void RemoveData(byte[] buf, int off, int len, int skip)
        {
            this.Read(buf:  buf, offset:  off, len:  len, skip:  skip);
            this.RemoveData(i:  skip + len);
        }
        public byte[] RemoveData(int len, int skip)
        {
            byte[] val_1 = new byte[0];
            this.Read(buf:  val_1, offset:  0, len:  len, skip:  skip);
            this.RemoveData(i:  skip + len);
            return (System.Byte[])val_1;
        }
        public int get_Available()
        {
            return (int)this.available;
        }
    
    }

}
