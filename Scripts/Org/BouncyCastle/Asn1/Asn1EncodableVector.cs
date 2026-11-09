using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class Asn1EncodableVector : IEnumerable
    {
        // Fields
        private System.Collections.IList v;
        
        // Properties
        public Org.BouncyCastle.Asn1.Asn1Encodable Item { get; }
        public int Size { get; }
        public int Count { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Asn1EncodableVector FromEnumerable(System.Collections.IEnumerable e)
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_13;
            var val_14;
            var val_15;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.IEnumerator val_4 = e.GetEnumerator();
            label_25:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = val_4.Current;
            if(val_13 != null)
            {
                    val_13 = 0;
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_11 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_11[0] = val_13;
            val_2.Add(objs:  val_11);
            goto label_25;
            label_11:
            val_14 = 0;
            val_15 = 0;
            if(val_4 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_4.Dispose();
            }
            
            if( != 1)
            {
                    return val_2;
            }
            
            if( == false)
            {
                    return val_2;
            }
            
            return val_2;
        }
        public Asn1EncodableVector(Org.BouncyCastle.Asn1.Asn1Encodable[] v)
        {
            this.v = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            this.Add(objs:  v);
        }
        public void Add(Org.BouncyCastle.Asn1.Asn1Encodable[] objs)
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_2;
            var val_3;
            var val_4;
            val_3 = 0;
            goto label_1;
            label_9:
            if(val_3 >= true)
            {
                    val_4 = 0;
            }
            
            val_2 = objs[0];
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = 2;
            int val_2 = this.v.Add(value:  val_2);
            val_3 = 1;
            label_1:
            if(val_3 < objs.Length)
            {
                goto label_9;
            }
        
        }
        public void AddOptional(Org.BouncyCastle.Asn1.Asn1Encodable[] objs)
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_2;
            var val_3;
            if(objs == null)
            {
                    return;
            }
            
            if(objs.Length < 1)
            {
                    return;
            }
            
            do
            {
                if(0 >= objs.Length)
            {
                    val_3 = 0;
            }
            
                val_2 = objs[0];
                if(val_2 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_3 = 2;
                int val_2 = this.v.Add(value:  val_2);
            }
            
            }
            while((0 + 1) < objs.Length);
        
        }
        public Org.BouncyCastle.Asn1.Asn1Encodable get_Item(int index)
        {
            var val_5;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this.v;
            if(val_5.Item[index] == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Encodable)val_5;
            }
            
            val_5 = 0;
            return (Org.BouncyCastle.Asn1.Asn1Encodable)val_5;
        }
        public Org.BouncyCastle.Asn1.Asn1Encodable Get(int index)
        {
            return this.Item[index];
        }
        public int get_Size()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.v.Count;
        }
        public int get_Count()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.v.Count;
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.v.GetEnumerator();
        }
    
    }

}
