using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerSet : Asn1Set
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerSet Empty;
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerSet FromVector(Org.BouncyCastle.Asn1.Asn1EncodableVector v)
        {
            var val_3;
            Org.BouncyCastle.Asn1.DerSet val_4;
            val_3 = null;
            if(v.Count >= 1)
            {
                    Org.BouncyCastle.Asn1.DerSet val_2 = null;
                val_4 = val_2;
                val_2 = new Org.BouncyCastle.Asn1.DerSet(v:  v, needsSorting:  true);
                return val_4;
            }
            
            val_3 = null;
            val_4 = Org.BouncyCastle.Asn1.DerSet.Empty;
            return val_4;
        }
        internal static Org.BouncyCastle.Asn1.DerSet FromVector(Org.BouncyCastle.Asn1.Asn1EncodableVector v, bool needsSorting)
        {
            var val_4;
            Org.BouncyCastle.Asn1.DerSet val_5;
            val_4 = null;
            if(v.Count >= 1)
            {
                    Org.BouncyCastle.Asn1.DerSet val_3 = null;
                val_5 = val_3;
                val_3 = new Org.BouncyCastle.Asn1.DerSet(v:  v, needsSorting:  needsSorting);
                return val_5;
            }
            
            val_4 = null;
            val_5 = Org.BouncyCastle.Asn1.DerSet.Empty;
            return val_5;
        }
        public DerSet()
        {
        
        }
        public DerSet(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            this.AddObject(obj:  obj);
        }
        public DerSet(Org.BouncyCastle.Asn1.Asn1Encodable[] v)
        {
            if(v.Length >= 1)
            {
                    do
            {
                this.AddObject(obj:  v[0]);
            }
            while((0 + 1) < v.Length);
            
            }
            
            this.Sort();
        }
        public DerSet(Org.BouncyCastle.Asn1.Asn1EncodableVector v)
        {
        
        }
        internal DerSet(Org.BouncyCastle.Asn1.Asn1EncodableVector v, bool needsSorting)
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_10;
            var val_11;
            var val_12;
            int val_1 = v.Count;
            System.Collections.IEnumerator val_2 = v.GetEnumerator();
            label_17:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_10 = val_2.Current;
            if(val_10 != null)
            {
                    val_10 = 0;
            }
            
            this.AddObject(obj:  val_10);
            goto label_17;
            label_8:
            val_11 = 0;
            val_12 = 0;
            if(val_2 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_2.Dispose();
            }
            
            if(needsSorting == false)
            {
                    return;
            }
            
            this.Sort();
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            var val_11;
            var val_12;
            var val_13;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            Org.BouncyCastle.Asn1.DerOutputStream val_2 = new Org.BouncyCastle.Asn1.DerOutputStream(os:  val_1);
            System.Collections.IEnumerator val_3 = this.GetEnumerator();
            label_16:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_6;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_11 = val_3.Current;
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            if(val_2 != null)
            {
                goto label_16;
            }
            
            goto label_16;
            label_6:
            val_12 = 0;
            val_13 = 0;
            if(val_3 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_3.Dispose();
            }
            
            Org.BouncyCastle.Utilities.Platform.Dispose(s:  val_2);
            derOut.WriteEncoded(tag:  49, bytes:  val_1);
        }
        private static DerSet()
        {
            Org.BouncyCastle.Asn1.DerSet.Empty = new Org.BouncyCastle.Asn1.DerSet(capacity:  0);
        }
    
    }

}
