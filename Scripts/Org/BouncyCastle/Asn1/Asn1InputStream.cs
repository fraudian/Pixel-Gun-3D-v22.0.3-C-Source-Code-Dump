using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class Asn1InputStream : FilterStream
    {
        // Fields
        private readonly int limit;
        private readonly byte[][] tmpBuffers;
        
        // Methods
        internal static int FindLimit(System.IO.Stream input)
        {
            return 2147483647;
        }
        public Asn1InputStream(System.IO.Stream inputStream)
        {
            int val_1 = Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  inputStream);
        }
        public Asn1InputStream(System.IO.Stream inputStream, int limit)
        {
            this.limit = limit;
            this.tmpBuffers = new System.Byte[][16];
        }
        public Asn1InputStream(byte[] input)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  input, writable:  false);
            if(input != null)
            {
                    return;
            }
        
        }
        private Org.BouncyCastle.Asn1.Asn1Object BuildObject(int tag, int tagNo, int length)
        {
            int val_1 = tag & 32;
            Org.BouncyCastle.Asn1.DefiniteLengthInputStream val_2 = new Org.BouncyCastle.Asn1.DefiniteLengthInputStream(inStream:  X24, length:  length);
            if((tag & 64) != 0)
            {
                goto label_1;
            }
            
            if((tag & 128) != 0)
            {
                goto label_2;
            }
            
            if(val_1 == 0)
            {
                    return Org.BouncyCastle.Asn1.Asn1InputStream.CreatePrimitiveDerObject(tagNo:  tagNo, defIn:  val_2, tmpBuffers:  this.tmpBuffers);
            }
            
            if(tagNo <= 8)
            {
                goto label_4;
            }
            
            if(tagNo == 16)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerApplicationSpecific();
            }
            
            if(tagNo != 17)
            {
                goto label_11;
            }
            
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerApplicationSpecific();
            label_1:
            .tag = tagNo;
            .isConstructed = val_1 >> 5;
            .octets = val_2.ToArray();
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerApplicationSpecific();
            label_2:
            new Org.BouncyCastle.Asn1.Asn1StreamParser() = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  val_2, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  val_2));
            return new Org.BouncyCastle.Asn1.Asn1StreamParser().ReadTaggedObject(constructed:  (val_1 != 0) ? 1 : 0, tag:  tagNo);
            label_4:
            if(tagNo == 4)
            {
                goto label_10;
            }
            
            if(tagNo != 8)
            {
                goto label_11;
            }
            
            Org.BouncyCastle.Asn1.DerExternal val_9 = new Org.BouncyCastle.Asn1.DerExternal(vector:  this);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerApplicationSpecific();
            label_10:
            new Org.BouncyCastle.Asn1.BerOctetString() = new Org.BouncyCastle.Asn1.Asn1OctetString(str:  Org.BouncyCastle.Asn1.BerOctetString.ToBytes(octs:  this));
            .octs = this;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerApplicationSpecific();
            label_11:
            System.IO.IOException val_13 = new System.IO.IOException(message:  "unknown tag " + tagNo + " encountered");
        }
        internal Org.BouncyCastle.Asn1.Asn1EncodableVector BuildEncodableVector()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_6;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            val_6 = this.ReadObject();
            if(val_6 == null)
            {
                    return val_2;
            }
            
            do
            {
                Org.BouncyCastle.Asn1.Asn1Encodable[] val_4 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_4[0] = val_6;
                val_2.Add(objs:  val_4);
                val_6 = this.ReadObject();
            }
            while(val_6 != null);
            
            return val_2;
        }
        internal virtual Org.BouncyCastle.Asn1.Asn1EncodableVector BuildDerEncodableVector(Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
        {
            new Org.BouncyCastle.Asn1.Asn1InputStream() = new Org.BouncyCastle.Asn1.Asn1InputStream(inputStream:  dIn, limit:  Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input:  dIn));
            if(new Org.BouncyCastle.Asn1.Asn1InputStream() != null)
            {
                    return new Org.BouncyCastle.Asn1.Asn1InputStream().BuildEncodableVector();
            }
            
            return new Org.BouncyCastle.Asn1.Asn1InputStream().BuildEncodableVector();
        }
        internal virtual Org.BouncyCastle.Asn1.DerSequence CreateDerSequence(Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
        {
            return Org.BouncyCastle.Asn1.DerSequence.FromVector(v:  this);
        }
        internal virtual Org.BouncyCastle.Asn1.DerSet CreateDerSet(Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
        {
            return Org.BouncyCastle.Asn1.DerSet.FromVector(v:  this, needsSorting:  false);
        }
        public Org.BouncyCastle.Asn1.Asn1Object ReadObject()
        {
            int val_23;
            var val_24;
            int val_25;
            Org.BouncyCastle.Asn1.Asn1StreamParser val_26;
            string val_28;
            int val_1 = this.ReadByte();
            val_23 = val_1;
            if(val_23 <= 0)
            {
                goto label_1;
            }
            
            int val_2 = Org.BouncyCastle.Asn1.Asn1InputStream.ReadTagNumber(s:  val_1, tag:  val_23);
            int val_3 = Org.BouncyCastle.Asn1.Asn1InputStream.ReadLength(s:  1152921505540603904, limit:  this.limit);
            if((val_3 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            Org.BouncyCastle.Asn1.Asn1Object val_4 = this.BuildObject(tag:  val_23, tagNo:  val_2, length:  val_3);
            return (Org.BouncyCastle.Asn1.Asn1Object)val_24;
            label_1:
            if(val_23 == 0)
            {
                goto label_4;
            }
            
            val_24 = 0;
            return (Org.BouncyCastle.Asn1.Asn1Object)val_24;
            label_2:
            if((val_23 & 32) == 0)
            {
                goto label_5;
            }
            
            val_25 = this.limit;
            Org.BouncyCastle.Asn1.Asn1StreamParser val_6 = null;
            val_26 = val_6;
            val_6 = new Org.BouncyCastle.Asn1.Asn1StreamParser(inStream:  new Org.BouncyCastle.Asn1.IndefiniteLengthInputStream(inStream:  X22, limit:  val_25), limit:  this.limit);
            if((val_23 & 64) != 0)
            {
                goto label_6;
            }
            
            if((val_23 & 128) != 0)
            {
                goto label_7;
            }
            
            if(val_2 <= 8)
            {
                goto label_8;
            }
            
            if(val_2 == 16)
            {
                goto label_9;
            }
            
            if(val_2 != 17)
            {
                goto label_20;
            }
            
            Org.BouncyCastle.Asn1.BerSetParser val_7 = new Org.BouncyCastle.Asn1.BerSetParser();
            ._parser = val_26;
            if(val_7 != null)
            {
                    return val_7.ToAsn1Object();
            }
            
            return val_7.ToAsn1Object();
            label_6:
            Org.BouncyCastle.Asn1.BerApplicationSpecificParser val_8 = new Org.BouncyCastle.Asn1.BerApplicationSpecificParser();
            .tag = val_2;
            .parser = val_26;
            if(val_8 != null)
            {
                    return val_8.ToAsn1Object();
            }
            
            return val_8.ToAsn1Object();
            label_7:
            Org.BouncyCastle.Asn1.BerTaggedObjectParser val_9 = new Org.BouncyCastle.Asn1.BerTaggedObjectParser();
            ._tagNumber = val_2;
            ._constructed = true;
            ._parser = val_26;
            if(val_9 != null)
            {
                    return val_9.ToAsn1Object();
            }
            
            return val_9.ToAsn1Object();
            label_8:
            if(val_2 == 4)
            {
                goto label_14;
            }
            
            if(val_2 != 8)
            {
                goto label_20;
            }
            
            Org.BouncyCastle.Asn1.DerExternalParser val_10 = new Org.BouncyCastle.Asn1.DerExternalParser();
            ._parser = val_26;
            val_26 = ???;
            val_23 = ???;
            val_25 = ???;
            goto typeof(Org.BouncyCastle.Asn1.DerExternalParser).__il2cppRuntimeField_178;
            label_9:
            Org.BouncyCastle.Asn1.BerSequenceParser val_11 = new Org.BouncyCastle.Asn1.BerSequenceParser();
            ._parser = val_26;
            if(val_11 != null)
            {
                    return val_11.ToAsn1Object();
            }
            
            return val_11.ToAsn1Object();
            label_14:
            Org.BouncyCastle.Asn1.BerOctetStringParser val_20 = new Org.BouncyCastle.Asn1.BerOctetStringParser();
            ._parser = val_26;
            if(val_20 != null)
            {
                    return val_20.ToAsn1Object();
            }
            
            return val_20.ToAsn1Object();
            label_4:
            val_28 = "unexpected end-of-contents marker";
            goto label_20;
            label_5:
            val_28 = "indefinite length primitive encoding encountered";
            label_20:
            null = new System.IO.IOException(message:  val_28);
            goto label_20;
        }
        internal static int ReadTagNumber(System.IO.Stream s, int tag)
        {
            var val_6;
            var val_7;
            val_6 = s;
            val_7 = tag & 31;
            if(val_7 != 31)
            {
                    return (int)val_7;
            }
            
            if((val_6 & 127) == null)
            {
                goto label_3;
            }
            
            if((val_6 & 2147483648) == 0)
            {
                    var val_5 = 0;
                do
            {
                val_7 = val_5 | (val_6 & 127);
                if((val_6 & 128) == 0)
            {
                    return (int)val_7;
            }
            
                val_5 = val_7 << 7;
            }
            while((val_6 & 2147483648) == 0);
            
            }
            
            System.IO.EndOfStreamException val_3 = null;
            val_6 = val_3;
            val_3 = new System.IO.EndOfStreamException(message:  "EOF found inside tag value.");
            label_7:
            val_7 = 1152921553393540416;
            return (int)val_7;
            label_3:
            System.IO.IOException val_4 = new System.IO.IOException(message:  "Corrupted stream - invalid high tag number found");
            goto label_7;
        }
        internal static int ReadLength(System.IO.Stream s, int limit)
        {
            var val_6;
            string val_8;
            if((s & 2147483648) != 0)
            {
                goto label_12;
            }
            
            if(s == 128)
            {
                    val_6 = 0;
                return 1152921504642469888;
            }
            
            if(s < 128)
            {
                    return 1152921504642469888;
            }
            
            System.IO.Stream val_1 = s & 127;
            if(val_1 > 4)
            {
                goto label_6;
            }
            
            val_6 = 0;
            if(val_1 == null)
            {
                goto label_7;
            }
            
            var val_6 = 0;
            label_9:
            if((s & 2147483648) != 0)
            {
                goto label_8;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < val_1)
            {
                goto label_9;
            }
            
            if((null & 2147483648) != 0)
            {
                goto label_10;
            }
            
            label_7:
            if(null >= limit)
            {
                goto label_11;
            }
            
            return 1152921504642469888;
            label_8:
            label_12:
            null = new System.IO.EndOfStreamException(message:  "EOF found reading length");
            goto label_12;
            label_6:
            System.IO.IOException val_4 = new System.IO.IOException(message:  "DER length more than 4 bytes: "("DER length more than 4 bytes: ") + val_1);
            goto label_12;
            label_11:
            val_8 = "Corrupted stream - out of bounds length found";
            goto label_14;
            label_10:
            val_8 = "Corrupted stream - negative length found";
            label_14:
            null = new System.IO.IOException(message:  val_8);
            goto label_12;
        }
        internal static byte[] GetBuffer(Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
        {
            System.Byte[] val_2;
            if(defIn >= tmpBuffers.Length)
            {
                    return defIn.ToArray();
            }
            
            val_2 = tmpBuffers[(long)defIn];
            if(val_2 == null)
            {
                    byte[] val_1 = new byte[0];
                val_2 = val_1;
                mem2[0] = val_2;
            }
            
            defIn.ReadAllIntoByteArray(buf:  val_1);
            return val_2;
        }
        internal static Org.BouncyCastle.Asn1.Asn1Object CreatePrimitiveDerObject(int tagNo, Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
        {
            if(tagNo == 10)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)Org.BouncyCastle.Asn1.DerEnumerated.FromOctetString(enc:  Org.BouncyCastle.Asn1.Asn1InputStream.GetBuffer(defIn:  defIn, tmpBuffers:  tmpBuffers));
            }
            
            if(tagNo == 6)
            {
                goto label_2;
            }
            
            if(tagNo != 1)
            {
                goto label_3;
            }
            
            Org.BouncyCastle.Asn1.DerBoolean val_2 = Org.BouncyCastle.Asn1.DerBoolean.FromOctetString(value:  Org.BouncyCastle.Asn1.Asn1InputStream.GetBuffer(defIn:  defIn, tmpBuffers:  tmpBuffers));
            return (Org.BouncyCastle.Asn1.Asn1Object)Org.BouncyCastle.Asn1.DerEnumerated.FromOctetString(enc:  Org.BouncyCastle.Asn1.Asn1InputStream.GetBuffer(defIn:  defIn, tmpBuffers:  tmpBuffers));
            label_2:
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_4 = Org.BouncyCastle.Asn1.DerObjectIdentifier.FromOctetString(enc:  Org.BouncyCastle.Asn1.Asn1InputStream.GetBuffer(defIn:  defIn, tmpBuffers:  tmpBuffers));
            return (Org.BouncyCastle.Asn1.Asn1Object)Org.BouncyCastle.Asn1.DerEnumerated.FromOctetString(enc:  Org.BouncyCastle.Asn1.Asn1InputStream.GetBuffer(defIn:  defIn, tmpBuffers:  tmpBuffers));
            label_3:
            System.Byte[] val_7 = defIn.ToArray();
            if((tagNo - 2) <= 28)
            {
                    var val_33 = 106040992 + ((tagNo - 2)) << 2;
                val_33 = val_33 + 106040992;
            }
            else
            {
                    System.IO.IOException val_32 = new System.IO.IOException(message:  "unknown tag " + tagNo + " encountered");
            }
        
        }
    
    }

}
