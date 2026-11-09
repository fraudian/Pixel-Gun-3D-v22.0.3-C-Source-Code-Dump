using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerOutputStream : FilterStream
    {
        // Methods
        public DerOutputStream(System.IO.Stream os)
        {
        
        }
        private void WriteLength(int length)
        {
            if(length < 128)
            {
                    this.WriteByte(value:  length);
                return;
            }
            
            var val_6 = 0;
            var val_5 = -8;
            int val_4 = length;
            do
            {
                val_4 = val_4 >> 8;
                val_5 = val_5 + 8;
                val_6 = val_6 + 1;
            }
            while(val_4 != 0);
            
            this.WriteByte(value:  val_6 | 128);
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                this.WriteByte(value:  length >> (val_5 & 24));
                val_5 = val_5 - 8;
            }
            while((val_5 & 2147483648) == 0);
        
        }
        internal void WriteEncoded(int tag, byte[] bytes)
        {
            this.WriteByte(value:  tag);
            this.WriteLength(length:  bytes.Length);
            this.Write(buffer:  bytes, offset:  0, count:  bytes.Length);
        }
        internal void WriteEncoded(int tag, byte first, byte[] bytes)
        {
            this.WriteByte(value:  tag);
            this.WriteLength(length:  bytes.Length + 1);
            this.WriteByte(value:  first);
            this.Write(buffer:  bytes, offset:  0, count:  bytes.Length);
        }
        internal void WriteEncoded(int tag, byte[] bytes, int offset, int length)
        {
            this.WriteByte(value:  tag);
            this.WriteLength(length:  length);
            this.Write(buffer:  bytes, offset:  offset, count:  length);
        }
        internal void WriteTag(int flags, int tagNo)
        {
            var val_4;
            int val_5;
            var val_6;
            byte val_8;
            int val_5 = tagNo;
            if(val_5 <= 30)
            {
                goto label_1;
            }
            
            flags = flags | 31;
            this.WriteByte(value:  flags);
            if(val_5 <= 127)
            {
                goto label_2;
            }
            
            byte[] val_1 = new byte[5];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_4 = val_1;
            val_5 = val_1.Length;
            val_6 = val_5;
            goto label_4;
            label_1:
            val_8 = val_5 | flags;
            goto label_5;
            label_2:
            val_8 = val_5;
            label_5:
            this.WriteByte(value:  val_8);
            return;
            label_3:
            val_4 = 24;
            val_6 = 28563616;
            val_5 = 28563616;
            label_4:
            var val_6 = 28563615;
            val_1[28563615] = val_5 & 127;
            do
            {
                val_5 = val_5 >> 7;
                val_6 = val_6 - 1;
                val_1[(long)val_6] = val_5 | 128;
            }
            while(val_5 > 127);
            
            this.Write(buffer:  val_1, offset:  (long)val_6, count:  28563616 - (long)val_6);
        }
        internal void WriteEncoded(int flags, int tagNo, byte[] bytes)
        {
            this.WriteTag(flags:  flags, tagNo:  tagNo);
            this.WriteLength(length:  bytes.Length);
            this.Write(buffer:  bytes, offset:  0, count:  bytes.Length);
        }
        protected void WriteNull()
        {
            this.WriteByte(value:  5);
            this.WriteByte(value:  0);
        }
        public virtual void WriteObject(object obj)
        {
            object val_3 = obj;
            if(val_3 != null)
            {
                    val_3 = val_3;
                return;
            }
            
            this.WriteByte(value:  5);
            this.WriteByte(value:  0);
        }
        public virtual void WriteObject(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            if(obj != null)
            {
                    this = ???;
            }
        
        }
        public virtual void WriteObject(Org.BouncyCastle.Asn1.Asn1Object obj)
        {
            if(obj != null)
            {
                    this = ???;
            }
        
        }
    
    }

}
