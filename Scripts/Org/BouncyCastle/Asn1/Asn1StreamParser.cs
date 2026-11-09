using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class Asn1StreamParser
    {
        // Fields
        private readonly System.IO.Stream _in;
        private readonly int _limit;
        private readonly byte[][] tmpBuffers;
        
        // Methods
        public Asn1StreamParser(System.IO.Stream inStream)
        {
            int val_1 = Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  inStream);
        }
        public Asn1StreamParser(System.IO.Stream inStream, int limit)
        {
            if((inStream & 1) != 0)
            {
                    this._in = inStream;
                this._limit = limit;
                this.tmpBuffers = new System.Byte[][16];
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Expected stream to be readable", paramName:  "inStream");
        }
        public Asn1StreamParser(byte[] encoding)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  encoding, writable:  false);
            if(encoding != null)
            {
                    return;
            }
        
        }
        internal Org.BouncyCastle.Asn1.IAsn1Convertible ReadIndef(int tagValue)
        {
            var val_5;
            if(tagValue > 8)
            {
                goto label_1;
            }
            
            if(tagValue == 4)
            {
                goto label_2;
            }
            
            if(tagValue != 8)
            {
                goto label_6;
            }
            
            val_5 = 1152921505542787072;
            goto label_8;
            label_1:
            if(tagValue == 16)
            {
                goto label_5;
            }
            
            if(tagValue != 17)
            {
                goto label_6;
            }
            
            val_5 = 1152921505542201344;
            goto label_8;
            label_2:
            val_5 = 1152921505541828608;
            goto label_8;
            label_5:
            val_5 = 1152921505542041600;
            label_8:
            ._parser = this;
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)new Org.BouncyCastle.Asn1.BerSequenceParser();
            label_6:
            Org.BouncyCastle.Asn1.Asn1Exception val_4 = new Org.BouncyCastle.Asn1.Asn1Exception(message:  "unknown BER object encountered: 0x"("unknown BER object encountered: 0x") + tagValue.ToString(format:  "X")(tagValue.ToString(format:  "X")));
        }
        internal Org.BouncyCastle.Asn1.IAsn1Convertible ReadImplicit(bool constructed, int tag)
        {
            System.IO.Stream val_8;
            object val_9;
            string val_11;
            val_8 = this._in;
            if(constructed == false)
            {
                goto label_4;
            }
            
            if(tag == 4)
            {
                goto label_5;
            }
            
            if(tag == 16)
            {
                goto label_6;
            }
            
            if(tag != 17)
            {
                goto label_17;
            }
            
            Org.BouncyCastle.Asn1.DerSetParser val_1 = null;
            val_9 = val_1;
            val_1 = new Org.BouncyCastle.Asn1.DerSetParser(parser:  this);
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_9;
            label_4:
            if(tag != 4)
            {
                goto label_9;
            }
            
            val_9 = new Org.BouncyCastle.Asn1.DerOctetStringParser();
            if(val_8 != null)
            {
                    val_8 = 0;
            }
            
            val_9 = new System.Object();
            .stream = val_8;
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_9;
            label_5:
            Org.BouncyCastle.Asn1.BerOctetStringParser val_5 = null;
            val_9 = val_5;
            val_5 = new Org.BouncyCastle.Asn1.BerOctetStringParser();
            ._parser = this;
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_9;
            label_6:
            Org.BouncyCastle.Asn1.DerSequenceParser val_6 = null;
            val_9 = val_6;
            val_6 = new Org.BouncyCastle.Asn1.DerSequenceParser(parser:  this);
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_9;
            label_9:
            if(tag == 16)
            {
                goto label_16;
            }
            
            if(tag != 17)
            {
                goto label_17;
            }
            
            val_11 = "sequences must use constructed encoding (see X.690 8.9.1/8.10.1)";
            goto label_20;
            label_17:
            val_11 = "implicit tagging not implemented";
            goto label_20;
            label_16:
            val_11 = "sets must use constructed encoding (see X.690 8.11.1/8.12.1)";
            label_20:
            null = new System.IO.IOException(message:  null);
        }
        internal Org.BouncyCastle.Asn1.Asn1Object ReadTaggedObject(bool constructed, int tag)
        {
            var val_14;
            Org.BouncyCastle.Asn1.Asn1Encodable val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            if(constructed == false)
            {
                goto label_1;
            }
            
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_1 = this.ReadVector();
            int val_2 = val_1.Count;
            if((1 & 1) == 0)
            {
                goto label_5;
            }
            
            if(val_2 != 1)
            {
                goto label_6;
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable val_3 = val_1.Item[0];
            val_14 = 1152921505543905280;
            goto label_8;
            label_1:
            Org.BouncyCastle.Asn1.DerOctetString val_7 = null;
            val_15 = val_7;
            val_7 = new Org.BouncyCastle.Asn1.DerOctetString(str:  0.ToArray());
            val_16 = null;
            goto label_12;
            label_5:
            if(val_2 != 1)
            {
                goto label_13;
            }
            
            val_14 = 1152921505542254592;
            label_8:
            val_15 = val_1.Item[0];
            val_17 = new Org.BouncyCastle.Asn1.BerTaggedObject();
            val_18 = 1;
            goto label_15;
            label_6:
            Org.BouncyCastle.Asn1.DerSequence val_10 = Org.BouncyCastle.Asn1.DerSequence.FromVector(v:  val_1);
            val_20 = 1152921505543905280;
            goto label_20;
            label_13:
            val_20 = 1152921505542254592;
            label_20:
            val_15 = Org.BouncyCastle.Asn1.BerSequence.FromVector(v:  val_1);
            val_16 = val_20;
            label_12:
            Org.BouncyCastle.Asn1.BerTaggedObject val_12 = null;
            val_17 = val_12;
            val_18 = 0;
            label_15:
            val_12 = new Org.BouncyCastle.Asn1.BerTaggedObject(explicitly:  false, tagNo:  tag, obj:  val_15);
            return (Org.BouncyCastle.Asn1.Asn1Object)val_17;
        }
        public virtual Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
        {
            System.IO.Stream val_33;
            int val_34;
            int val_35;
            var val_36;
            Org.BouncyCastle.Asn1.Asn1StreamParser val_37;
            bool val_38;
            Org.BouncyCastle.Asn1.Asn1StreamParser val_39;
            var val_40;
            System.IO.IOException val_41;
            val_33 = this._in;
            if(val_33 == 1)
            {
                goto label_2;
            }
            
            this.Set00Check(enabled:  false);
            val_34 = Org.BouncyCastle.Asn1.Asn1InputStream.ReadTagNumber(s:  this._in, tag:  val_33);
            System.IO.Stream val_2 = val_33 & 32;
            val_35 = Org.BouncyCastle.Asn1.Asn1InputStream.ReadLength(s:  this._in, limit:  this._limit);
            if((val_35 & 2147483648) != 0)
            {
                goto label_3;
            }
            
            Org.BouncyCastle.Asn1.DefiniteLengthInputStream val_4 = new Org.BouncyCastle.Asn1.DefiniteLengthInputStream(inStream:  this._in, length:  val_35);
            if((val_33 & 64) != 0)
            {
                goto label_4;
            }
            
            if((val_33 & 128) != 0)
            {
                goto label_5;
            }
            
            if(val_2 == null)
            {
                goto label_6;
            }
            
            if(val_34 <= 8)
            {
                goto label_7;
            }
            
            if(val_34 == 16)
            {
                goto label_8;
            }
            
            if(val_34 != 17)
            {
                goto label_23;
            }
            
            val_33 = new Org.BouncyCastle.Asn1.Asn1StreamParser();
            val_33 = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  val_4, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  val_4));
            Org.BouncyCastle.Asn1.DerSetParser val_7 = null;
            val_36 = val_7;
            val_7 = new Org.BouncyCastle.Asn1.DerSetParser(parser:  new Org.BouncyCastle.Asn1.Asn1StreamParser());
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_36;
            label_2:
            val_36 = 0;
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_36;
            label_3:
            if(val_2 == null)
            {
                goto label_12;
            }
            
            val_35 = this._limit;
            Org.BouncyCastle.Asn1.Asn1StreamParser val_9 = null;
            val_37 = val_9;
            val_9 = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  new Org.BouncyCastle.Asn1.IndefiniteLengthInputStream(inStream:  this._in, limit:  val_35), limit:  this._limit);
            if((val_33 & 64) != 0)
            {
                goto label_13;
            }
            
            if((val_33 & 128) != 0)
            {
                goto label_14;
            }
            
            if(val_37 != null)
            {
                    return val_9.ReadIndef(tagValue:  val_34);
            }
            
            return val_9.ReadIndef(tagValue:  val_34);
            label_4:
            val_37 = val_4.ToArray();
            Org.BouncyCastle.Asn1.DerApplicationSpecific val_11 = null;
            val_36 = val_11;
            val_11 = new Org.BouncyCastle.Asn1.DerApplicationSpecific();
            val_38 = val_2 >> 5;
            goto label_17;
            label_13:
            Org.BouncyCastle.Asn1.BerApplicationSpecificParser val_12 = null;
            val_36 = val_12;
            val_12 = new Org.BouncyCastle.Asn1.BerApplicationSpecificParser();
            .tag = val_34;
            goto label_18;
            label_5:
            new Org.BouncyCastle.Asn1.Asn1StreamParser() = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  val_4, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  val_4));
            Org.BouncyCastle.Asn1.BerTaggedObjectParser val_15 = null;
            val_36 = val_15;
            val_15 = new Org.BouncyCastle.Asn1.BerTaggedObjectParser();
            ._tagNumber = val_34;
            ._constructed = val_2 >> 5;
            ._parser = new Org.BouncyCastle.Asn1.Asn1StreamParser();
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_36;
            label_14:
            Org.BouncyCastle.Asn1.BerTaggedObjectParser val_17 = null;
            val_36 = val_17;
            val_17 = new Org.BouncyCastle.Asn1.BerTaggedObjectParser();
            val_38 = true;
            label_17:
            ._tagNumber = val_34;
            ._constructed = val_38;
            label_18:
            ._parser = val_37;
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_36;
            label_6:
            if(val_34 != 4)
            {
                goto label_20;
            }
            
            Org.BouncyCastle.Asn1.DerOctetStringParser val_18 = new Org.BouncyCastle.Asn1.DerOctetStringParser();
            .stream = val_4;
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_36;
            label_7:
            if(val_34 == 4)
            {
                goto label_22;
            }
            
            if(val_34 != 8)
            {
                goto label_23;
            }
            
            val_39 = new Org.BouncyCastle.Asn1.Asn1StreamParser();
            val_39 = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  val_4, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  val_4));
            val_40 = 1152921505542787072;
            goto label_24;
            label_20:
            Org.BouncyCastle.Asn1.Asn1Object val_21 = Org.BouncyCastle.Asn1.Asn1InputStream.CreatePrimitiveDerObject(tagNo:  val_34, defIn:  val_4, tmpBuffers:  this.tmpBuffers);
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_36;
            label_8:
            new Org.BouncyCastle.Asn1.Asn1StreamParser() = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  val_4, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  val_4));
            Org.BouncyCastle.Asn1.DerSequenceParser val_24 = new Org.BouncyCastle.Asn1.DerSequenceParser(parser:  new Org.BouncyCastle.Asn1.Asn1StreamParser());
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_36;
            label_22:
            val_39 = new Org.BouncyCastle.Asn1.Asn1StreamParser();
            val_39 = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  val_4, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  val_4));
            val_40 = 1152921505541828608;
            label_24:
            Org.BouncyCastle.Asn1.BerOctetStringParser val_27 = new Org.BouncyCastle.Asn1.BerOctetStringParser();
            ._parser = val_39;
            return (Org.BouncyCastle.Asn1.IAsn1Convertible)val_36;
            label_12:
            System.IO.IOException val_28 = null;
            val_41 = val_28;
            val_28 = new System.IO.IOException(message:  "indefinite length primitive encoding encountered");
            label_28:
            label_23:
            System.IO.IOException val_30 = new System.IO.IOException(message:  "unknown tag " + val_41 + " encountered");
            goto label_28;
        }
        private void Set00Check(bool enabled)
        {
            if(this._in == null)
            {
                    return;
            }
            
            enabled = enabled;
            this._in.SetEofOn00(eofOn00:  enabled);
        }
        internal Org.BouncyCastle.Asn1.Asn1EncodableVector ReadVector()
        {
            T[] val_5 = System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>();
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_5 = System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            if(this == null)
            {
                    return val_2;
            }
            
            label_13:
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_5 = val_3;
            var val_6 = 0;
            val_6 = val_6 + 1;
            Org.BouncyCastle.Asn1.Asn1Object val_5 = this.ToAsn1Object();
            if(val_5 == null)
            {
                goto label_6;
            }
            
            if(val_5 != null)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_5 == null)
            {
                goto label_10;
            }
            
            label_7:
            label_10:
            val_5[0] = val_5;
            val_2.Add(objs:  val_3);
            if(this != null)
            {
                goto label_13;
            }
            
            return val_2;
        }
    
    }

}
