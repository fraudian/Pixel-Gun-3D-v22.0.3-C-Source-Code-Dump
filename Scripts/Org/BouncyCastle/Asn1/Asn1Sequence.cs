using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class Asn1Sequence : Asn1Object, IEnumerable
    {
        // Fields
        private readonly System.Collections.IList seq;
        
        // Properties
        public virtual Org.BouncyCastle.Asn1.Asn1SequenceParser Parser { get; }
        public virtual Org.BouncyCastle.Asn1.Asn1Encodable Item { get; }
        public int Size { get; }
        public virtual int Count { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Asn1Sequence GetInstance(object obj)
        {
            object val_10;
            var val_11;
            var val_12;
            var val_13;
            System.Byte[] val_14;
            string val_15;
            string val_17;
            val_10 = obj;
            if(val_10 == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Sequence)val_10;
            }
            
            if(val_10 == null)
            {
                goto label_4;
            }
            
            val_11 = null;
            val_12 = val_10;
            if(val_12 == null)
            {
                    val_11 = 0;
                val_12 = 0;
            }
            
            if(mem[282584257676957] == 0)
            {
                goto label_7;
            }
            
            var val_10 = mem[282584257676847];
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_9:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < mem[282584257676957])
            {
                goto label_9;
            }
            
            label_7:
            val_11 = null;
            goto label_10;
            label_4:
            val_12 = 1152921505721910208;
            if(val_10 == null)
            {
                goto label_11;
            }
            
            val_14 = val_10;
            if(val_14 == null)
            {
                    val_14 = 0;
            }
            
            val_10 = Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  val_14);
            return (Org.BouncyCastle.Asn1.Asn1Sequence)val_10;
            label_8:
            val_12 = val_12 + (((mem[282584257676847] + 8)) << 4);
            val_13 = val_12 + 296;
            label_10:
            val_10 = val_12.ToAsn1Object();
            return (Org.BouncyCastle.Asn1.Asn1Sequence)val_10;
            label_11:
            System.ArgumentException val_7 = null;
            val_15 = val_7;
            val_7 = new System.ArgumentException(message:  "Unknown object in GetInstance: "("Unknown object in GetInstance: ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_10)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_10)), paramName:  "obj");
            mem[8] = null;
            val_17 = 8;
        }
        public static Org.BouncyCastle.Asn1.Asn1Sequence GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_9;
            var val_10;
            var val_11;
            var val_12;
            if(obj.obj != null)
            {
                    val_9 = obj.obj;
            }
            else
            {
                    val_9 = 0;
            }
            
            if(explicitly == false)
            {
                goto label_4;
            }
            
            if(obj.explicitly == false)
            {
                goto label_5;
            }
            
            val_10 = 0;
            return (Org.BouncyCastle.Asn1.Asn1Sequence);
            label_4:
            if(obj.explicitly != false)
            {
                    Org.BouncyCastle.Asn1.DerSequence val_3 = null;
                val_10 = val_3;
                val_3 = new Org.BouncyCastle.Asn1.DerSequence(obj:  val_9);
                return (Org.BouncyCastle.Asn1.Asn1Sequence);
            }
            
            if(val_9 != 0)
            {
                    val_10 = val_9;
            }
            
            val_11 = 1152921553398353520;
            val_12 = new System.ArgumentException(message:  "Unknown object in GetInstance: "("Unknown object in GetInstance: ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  obj)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  obj)), paramName:  "obj");
            goto label_21;
            label_5:
            val_11 = 1152921553398353520;
            val_12 = new System.ArgumentException(message:  "object implicit - explicit expected.");
            label_21:
        }
        protected internal Asn1Sequence(int capacity)
        {
            this = new System.Object();
            this.seq = Org.BouncyCastle.Utilities.Platform.CreateArrayList(capacity:  capacity);
        }
        public virtual System.Collections.IEnumerator GetEnumerator()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.seq.GetEnumerator();
        }
        public System.Collections.IEnumerator GetObjects()
        {
            goto typeof(Org.BouncyCastle.Asn1.Asn1Sequence).__il2cppRuntimeField_1C8;
        }
        public virtual Org.BouncyCastle.Asn1.Asn1SequenceParser get_Parser()
        {
            return (Org.BouncyCastle.Asn1.Asn1SequenceParser)new Asn1Sequence.Asn1SequenceParserImpl(outer:  this);
        }
        public virtual Org.BouncyCastle.Asn1.Asn1Encodable get_Item(int index)
        {
            var val_5;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this.seq;
            if(val_5.Item[index] == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Encodable)val_5;
            }
            
            val_5 = 0;
            return (Org.BouncyCastle.Asn1.Asn1Encodable)val_5;
        }
        public Org.BouncyCastle.Asn1.Asn1Encodable GetObjectAt(int index)
        {
            goto typeof(Org.BouncyCastle.Asn1.Asn1Sequence).__il2cppRuntimeField_1E8;
        }
        public int get_Size()
        {
            goto typeof(Org.BouncyCastle.Asn1.Asn1Sequence).__il2cppRuntimeField_1F8;
        }
        public virtual int get_Count()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.seq.Count;
        }
        protected override int Asn1GetHashCode()
        {
            var val_6;
            var val_8;
            var val_9;
            var val_11;
            var val_12;
            val_6 = this;
            goto label_1;
            label_17:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_8 = this;
            if(this.Current != null)
            {
                
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                val_8 = Org.BouncyCastle.Asn1.DerNull.Instance;
            }
            
            val_6 = val_8.GetHashCode() ^ 1152921556692406224;
            label_1:
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(this.MoveNext() == true)
            {
                goto label_17;
            }
            
            val_11 = 0;
            val_12 = 0;
            if(this != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                this.Dispose();
            }
            
            if( != 1)
            {
                    return (int)val_6;
            }
            
            if( == false)
            {
                    return (int)val_6;
            }
            
            return (int)val_6;
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            var val_7;
            System.Collections.IEnumerator val_8;
            var val_9;
            var val_12;
            val_8 = this;
            if(asn1Object != null)
            {
                    System.Collections.IEnumerator val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.Asn1Sequence.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
                val_7 = val_8;
                if(val_7 == val_1)
            {
                    val_8 = val_8;
                do
            {
                var val_8 = 0;
                val_8 = val_8 + 1;
                val_9 = 0;
                if(this.MoveNext() == false)
            {
                    return (bool)val_12;
            }
            
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_9 = 0;
                bool val_5 = val_1.MoveNext();
                if(val_5 == false)
            {
                    return (bool)val_12;
            }
            
                Org.BouncyCastle.Asn1.Asn1Encodable val_6 = val_5.GetCurrent(e:  this);
                val_7 = val_6;
                Org.BouncyCastle.Asn1.Asn1Encodable val_7 = val_6.GetCurrent(e:  val_1);
                val_12 = 0;
            }
            while((val_7 & 1) != 0);
            
                return (bool)val_12;
            }
            
            }
            
            val_12 = 0;
            return (bool)val_12;
        }
        private Org.BouncyCastle.Asn1.Asn1Encodable GetCurrent(System.Collections.IEnumerator e)
        {
            var val_4;
            Org.BouncyCastle.Asn1.DerNull val_6;
            var val_7;
            val_4 = e;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = val_4;
            object val_2 = val_6.Current;
            val_4 = 1152921505543159808;
            val_7 = null;
            val_7 = null;
            val_6 = Org.BouncyCastle.Asn1.DerNull.Instance;
            return (Org.BouncyCastle.Asn1.Asn1Encodable)val_6;
        }
        protected internal void AddObject(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            int val_2 = this.seq.Add(value:  obj);
        }
        public override string ToString()
        {
            return Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ToString(c:  this.seq);
        }
    
    }

}
