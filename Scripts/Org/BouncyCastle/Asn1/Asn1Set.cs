using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class Asn1Set : Asn1Object, IEnumerable
    {
        // Fields
        private readonly System.Collections.IList _set;
        
        // Properties
        public virtual Org.BouncyCastle.Asn1.Asn1Encodable Item { get; }
        public int Size { get; }
        public virtual int Count { get; }
        public Org.BouncyCastle.Asn1.Asn1SetParser Parser { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.Asn1Set GetInstance(object obj)
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
                    return (Org.BouncyCastle.Asn1.Asn1Set)val_10;
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
            return (Org.BouncyCastle.Asn1.Asn1Set)val_10;
            label_8:
            val_12 = val_12 + (((mem[282584257676847] + 8)) << 4);
            val_13 = val_12 + 296;
            label_10:
            val_10 = val_12.ToAsn1Object();
            return (Org.BouncyCastle.Asn1.Asn1Set)val_10;
            label_11:
            System.ArgumentException val_7 = null;
            val_15 = val_7;
            val_7 = new System.ArgumentException(message:  "Unknown object in GetInstance: "("Unknown object in GetInstance: ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_10)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_10)), paramName:  "obj");
            mem[8] = null;
            val_17 = 8;
        }
        public static Org.BouncyCastle.Asn1.Asn1Set GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            var val_19;
            object val_20;
            Org.BouncyCastle.Asn1.Asn1Encodable val_21;
            var val_22;
            var val_23;
            var val_24;
            Org.BouncyCastle.Asn1.Asn1Encodable val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_19 = explicitly;
            val_20 = obj;
            if(obj.obj != null)
            {
                    val_21 = obj.obj;
            }
            else
            {
                    val_21 = 0;
            }
            
            if(val_19 == false)
            {
                goto label_4;
            }
            
            if(obj.explicitly == false)
            {
                goto label_5;
            }
            
            if(val_21 == 0)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Set)val_21;
            }
            
            val_21 = 0;
            return (Org.BouncyCastle.Asn1.Asn1Set)val_21;
            label_4:
            if(obj.explicitly != false)
            {
                    Org.BouncyCastle.Asn1.DerSet val_3 = null;
                val_20 = val_3;
                val_3 = new Org.BouncyCastle.Asn1.DerSet(obj:  val_21);
                val_21 = val_20;
                return (Org.BouncyCastle.Asn1.Asn1Set)val_21;
            }
            
            if(val_21 == 0)
            {
                goto label_16;
            }
            
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_6 = null;
            val_20 = val_6;
            val_6 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            val_22 = null;
            val_22 = 0;
            label_40:
            var val_21 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_25;
            }
            
            var val_19 = mem[282584257676847];
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_24:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < mem[282584257676957])
            {
                goto label_24;
            }
            
            goto label_25;
            label_23:
            val_21 = val_21 + (((mem[282584257676847] + 8)) << 4);
            val_23 = val_21 + 296;
            label_25:
            if(0.MoveNext() == false)
            {
                goto label_26;
            }
            
            var val_25 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_31;
            }
            
            var val_22 = mem[282584257676847];
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_30:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_29;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < mem[282584257676957])
            {
                goto label_30;
            }
            
            goto label_31;
            label_29:
            var val_24 = val_22;
            val_24 = val_24 + 1;
            val_25 = val_25 + val_24;
            val_24 = val_25 + 296;
            label_31:
            val_25 = 0.Current;
            if(val_25 != null)
            {
                    val_25 = 0;
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_12 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_12[0] = val_25;
            val_6.Add(objs:  val_12);
            goto label_40;
            label_26:
            val_26 = 0;
            val_19 = 0;
            goto label_41;
            label_5:
            val_27 = 1152921553400683552;
            val_28 = new System.ArgumentException(message:  "object implicit - explicit expected.");
            goto label_45;
            label_16:
            string val_15 = "Unknown object in GetInstance: "("Unknown object in GetInstance: ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_20)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_20));
            System.ArgumentException val_16 = new System.ArgumentException(message:  val_15, paramName:  "obj");
            val_27 = 1152921553400683552;
            val_28 = val_16;
            label_45:
            val_29 = val_28;
            goto label_57;
            label_41:
            if(val_16 != null)
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_16.Dispose();
            }
            
            Org.BouncyCastle.Asn1.DerSet val_18 = null;
            val_21 = val_18;
            val_18 = new Org.BouncyCastle.Asn1.DerSet(v:  val_15, needsSorting:  false);
            return (Org.BouncyCastle.Asn1.Asn1Set)val_21;
            label_57:
        }
        protected internal Asn1Set(int capacity)
        {
            this = new System.Object();
            this._set = Org.BouncyCastle.Utilities.Platform.CreateArrayList(capacity:  capacity);
        }
        public virtual System.Collections.IEnumerator GetEnumerator()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this._set.GetEnumerator();
        }
        public System.Collections.IEnumerator GetObjects()
        {
            goto typeof(Org.BouncyCastle.Asn1.Asn1Set).__il2cppRuntimeField_1C8;
        }
        public virtual Org.BouncyCastle.Asn1.Asn1Encodable get_Item(int index)
        {
            var val_5;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this._set;
            if(val_5.Item[index] == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Encodable)val_5;
            }
            
            val_5 = 0;
            return (Org.BouncyCastle.Asn1.Asn1Encodable)val_5;
        }
        public Org.BouncyCastle.Asn1.Asn1Encodable GetObjectAt(int index)
        {
            goto typeof(Org.BouncyCastle.Asn1.Asn1Set).__il2cppRuntimeField_1D8;
        }
        public int get_Size()
        {
            goto typeof(Org.BouncyCastle.Asn1.Asn1Set).__il2cppRuntimeField_1E8;
        }
        public virtual int get_Count()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this._set.Count;
        }
        public virtual Org.BouncyCastle.Asn1.Asn1Encodable[] ToArray()
        {
            var val_2;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[1550252704];
            if(this < 1)
            {
                    return val_1;
            }
            
            var val_2 = 0;
            label_8:
            val_2 = val_2;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(this != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(this == null)
            {
                goto label_6;
            }
            
            label_3:
            if(this == null)
            {
                    val_2 = 0;
            }
            
            label_6:
            if(val_2 >= val_1.Length)
            {
                    val_2 = 0;
            }
            
            val_1[0] = this;
            val_2 = val_2 + 1;
            if(val_2 < this)
            {
                goto label_8;
            }
            
            return val_1;
        }
        public Org.BouncyCastle.Asn1.Asn1SetParser get_Parser()
        {
            return (Org.BouncyCastle.Asn1.Asn1SetParser)new Asn1Set.Asn1SetParserImpl(outer:  this);
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
            
            val_6 = val_8.GetHashCode() ^ 1152921556734895072;
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
                    System.Collections.IEnumerator val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.Asn1Set.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
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
        protected internal void Sort()
        {
            var val_17;
            Org.BouncyCastle.Asn1.Asn1Encodable val_19;
            System.Collections.IList val_20;
            var val_22;
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(this._set.Count < 2)
            {
                    return;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            int val_4 = this._set.Count;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_5 = new Org.BouncyCastle.Asn1.Asn1Encodable[0];
            var val_22 = 0;
            val_22 = val_22 + 1;
            int val_7 = this._set.Count;
            System.Byte[][] val_8 = new System.Byte[][0];
            val_17 = 0;
            goto label_17;
            label_44:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_19 = this._set.Item[0];
            if(val_19 != null)
            {
                    val_19 = 0;
            }
            
            if(val_5 == null)
            {
                goto label_26;
            }
            
            if(val_19 != 0)
            {
                goto label_27;
            }
            
            goto label_30;
            label_26:
            if(val_19 == 0)
            {
                goto label_30;
            }
            
            label_27:
            label_30:
            val_5[0] = val_19;
            System.Byte[] val_13 = val_19.GetEncoded(encoding:  "DER");
            if(val_8 == null)
            {
                goto label_33;
            }
            
            if(val_13 != null)
            {
                goto label_34;
            }
            
            goto label_37;
            label_33:
            if(val_13 == null)
            {
                goto label_37;
            }
            
            label_34:
            label_37:
            val_8[0] = val_13;
            val_17 = 1;
            label_17:
            val_20 = this._set;
            var val_24 = 0;
            val_24 = val_24 + 1;
            if(val_17 < val_20.Count)
            {
                goto label_44;
            }
            
            System.Array.Sort(keys:  val_8, items:  val_5, comparer:  new Asn1Set.DerComparer());
            val_22 = 0;
            goto label_45;
            label_58:
            val_20 = val_5[0];
            var val_25 = 0;
            val_25 = val_25 + 1;
            this._set.set_Item(index:  0, value:  val_20);
            val_22 = 1;
            label_45:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_22 < this._set.Count)
            {
                goto label_58;
            }
        
        }
        protected internal void AddObject(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            int val_2 = this._set.Add(value:  obj);
        }
        public override string ToString()
        {
            return Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ToString(c:  this._set);
        }
    
    }

}
