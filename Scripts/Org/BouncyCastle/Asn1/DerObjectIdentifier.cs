using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerObjectIdentifier : Asn1Object
    {
        // Fields
        private readonly string identifier;
        private byte[] body;
        private const long LONG_LIMIT = 72057594037927808;
        private static readonly Org.BouncyCastle.Asn1.DerObjectIdentifier[] cache;
        
        // Properties
        public string Id { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetInstance(object obj)
        {
            object val_6;
            System.Byte[] val_7;
            val_6 = obj;
            if(val_6 == null)
            {
                    return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_6;
            }
            
            if(val_6 != null)
            {
                    val_7 = val_6;
                if(val_7 == null)
            {
                    val_7 = 0;
            }
            
                val_6 = Org.BouncyCastle.Asn1.DerObjectIdentifier.FromOctetString(enc:  val_7);
                return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_6;
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "illegal object in GetInstance: "("illegal object in GetInstance: ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_6)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_6)), paramName:  "obj");
        }
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            object val_1;
            if(obj.obj != null)
            {
                    val_1 = obj.obj;
                return Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj:  val_1 = 0);
            }
            
            return Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj:  val_1);
        }
        public DerObjectIdentifier(string identifier)
        {
            var val_6;
            var val_7;
            this = new System.Object();
            if(identifier == null)
            {
                goto label_1;
            }
            
            if((Org.BouncyCastle.Asn1.DerObjectIdentifier.IsValidIdentifier(identifier:  identifier)) == false)
            {
                goto label_4;
            }
            
            this.identifier = identifier;
            return;
            label_1:
            val_6 = 1152921553443980448;
            val_7 = new System.ArgumentNullException(paramName:  "identifier");
            goto label_5;
            label_4:
            val_6 = 1152921553443980448;
            val_7 = new System.FormatException(message:  "string " + identifier + " not an OID");
            label_5:
        }
        internal DerObjectIdentifier(Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string branchID)
        {
            val_1 = new System.Object();
            if((Org.BouncyCastle.Asn1.DerObjectIdentifier.IsValidBranchID(branchID:  string val_1 = branchID, start:  0)) != false)
            {
                    this.identifier = oid.identifier + "." + val_1;
                return;
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "string " + val_1 + " not a valid OID branch", paramName:  "branchID");
        }
        public string get_Id()
        {
            return (string)this.identifier;
        }
        public virtual Org.BouncyCastle.Asn1.DerObjectIdentifier Branch(string branchID)
        {
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)new Org.BouncyCastle.Asn1.DerObjectIdentifier(oid:  this, branchID:  branchID);
        }
        public virtual bool On(Org.BouncyCastle.Asn1.DerObjectIdentifier stem)
        {
            if(this.identifier.Length <= stem.identifier.Length)
            {
                    return false;
            }
            
            if((this.identifier.Chars[stem.identifier.Length] & 65535) != '.')
            {
                    return false;
            }
            
            return Org.BouncyCastle.Utilities.Platform.StartsWith(source:  this.identifier, prefix:  stem.identifier);
        }
        internal DerObjectIdentifier(byte[] bytes)
        {
            this = new System.Object();
            this.identifier = Org.BouncyCastle.Asn1.DerObjectIdentifier.MakeOidStringFromBytes(bytes:  bytes);
            this.body = Org.BouncyCastle.Utilities.Arrays.Clone(data:  bytes);
        }
        private void WriteField(System.IO.Stream outputStream, long fieldValue)
        {
            var val_4;
            long val_5 = fieldValue;
            byte[] val_1 = new byte[9];
            val_1[1] = val_5 & 127;
            val_4 = 8;
            if(val_5 >= 128)
            {
                    do
            {
                val_5 = val_5 >> 7;
                val_4 = val_4 - 1;
                val_1[(long)val_4] = val_5 | 128;
            }
            while(val_5 >= 128);
            
            }
            
            var val_4 = 9 - val_4;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_328;
        }
        private void WriteField(System.IO.Stream outputStream, Org.BouncyCastle.Math.BigInteger fieldValue)
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            val_23 = fieldValue;
            val_24 = outputStream;
            int val_1 = val_23.BitLength;
            if((val_1 + 12) <= 12)
            {
                goto label_2;
            }
            
            int val_3 = val_1 + 6;
            var val_22 = 0;
            val_22 = val_22 + val_3;
            val_25 = (val_22 >> 2) + (val_22 >> 31);
            val_26 = new byte[0];
            if(val_3 >= 7)
            {
                goto label_3;
            }
            
            if(val_26 != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_2:
            val_23 = ???;
            val_24 = ???;
            val_26 = ???;
            val_25 = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_338;
            label_3:
            var val_6 = val_25 - 1;
            var val_8 = (val_26 + (val_6 << )) + 32;
            do
            {
                int val_23 = val_23.IntValue;
                val_23 = val_23 | 128;
                mem2[0] = val_23;
                Org.BouncyCastle.Math.BigInteger val_10 = val_23.ShiftRight(n:  7);
                val_6 = val_6 - 1;
                val_8 = val_8 - 1;
            }
            while((val_6 & 2147483648) == 0);
            
            label_5:
            var val_12 = val_26 + ((long)val_25 - 1);
            var val_24 = (val_26 + ((long)(int)() - 1)) + 32;
            val_24 = val_24 & 127;
            mem2[0] = val_24;
            if(val_24 == 0)
            {
                
            }
        
        }
        private void DoOutput(System.IO.MemoryStream bOut)
        {
            System.IO.Stream val_17;
            Org.BouncyCastle.Math.BigInteger val_18;
            Org.BouncyCastle.Asn1.OidTokenizer val_1 = new Org.BouncyCastle.Asn1.OidTokenizer(oid:  this.identifier);
            int val_17 = System.Int32.Parse(s:  val_1.NextToken());
            val_17 = val_17 + (val_17 << 2);
            string val_4 = val_1.NextToken();
            int val_5 = val_17 << 3;
            if(val_4.Length <= 18)
            {
                goto label_4;
            }
            
            val_17 = bOut;
            val_18 = new Org.BouncyCastle.Math.BigInteger(value:  val_4).Add(value:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  (long)val_5));
            goto label_8;
            label_4:
            long val_10 = System.Int64.Parse(s:  val_4);
            val_10.WriteField(outputStream:  bOut, fieldValue:  val_10 + (val_5 << ));
            goto label_15;
            label_14:
            long val_12 = System.Int64.Parse(s:  val_17);
            val_12.WriteField(outputStream:  bOut, fieldValue:  val_12);
            label_15:
            if(val_1.HasMoreTokens == false)
            {
                    return;
            }
            
            string val_14 = val_1.NextToken();
            if(val_14.Length <= 18)
            {
                goto label_14;
            }
            
            Org.BouncyCastle.Math.BigInteger val_16 = new Org.BouncyCastle.Math.BigInteger(value:  val_14);
            val_17 = bOut;
            val_18 = val_16;
            label_8:
            val_16.WriteField(outputStream:  val_17, fieldValue:  val_16);
            goto label_15;
        }
        internal byte[] GetBody()
        {
            var val_3;
            var val_4;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            if(this.body != null)
            {
                    val_3 = 0;
                val_4 = 0;
            }
            else
            {
                    new System.IO.MemoryStream() = new System.IO.MemoryStream();
                this.DoOutput(bOut:  new System.IO.MemoryStream());
                val_3 = 0;
                val_4 = 0;
                this.body = new System.IO.MemoryStream();
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(val_3 != 1)
            {
                    return (System.Byte[])this.body;
            }
            
            if(val_4 == 0)
            {
                    return (System.Byte[])this.body;
            }
            
            return (System.Byte[])this.body;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  6, bytes:  this.GetBody());
        }
        protected override int Asn1GetHashCode()
        {
            if(this.identifier == null)
            {
                
            }
        
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerObjectIdentifier.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        public override string ToString()
        {
            return (string)this.identifier;
        }
        private static bool IsValidBranchID(string branchID, int start)
        {
            int val_7;
            var val_8;
            val_7 = branchID.Length - 1;
            if(val_7 < start)
            {
                    val_8 = 0;
                return (bool)val_8;
            }
            
            label_7:
            char val_2 = branchID.Chars[val_7];
            char val_3 = val_2 - 48;
            val_3 = val_3 & 65535;
            if(val_3 <= '	')
            {
                goto label_4;
            }
            
            var val_5 = ((val_2 & 65535) == '.') ? 1 : 0;
            val_5 = 0 & val_5;
            val_8 = 0;
            if((val_5 & 1) != 0)
            {
                goto label_5;
            }
            
            return (bool)val_8;
            label_4:
            val_8 = 1;
            label_5:
            val_7 = val_7 - 1;
            if(val_7 >= start)
            {
                goto label_7;
            }
            
            return (bool)val_8;
        }
        private static bool IsValidIdentifier(string identifier)
        {
            if(identifier.Length < 3)
            {
                    return false;
            }
            
            if((identifier.Chars[1] & 65535) != '.')
            {
                    return false;
            }
            
            char val_5 = identifier.Chars[0] - 48;
            val_5 = val_5 & 65535;
            if(val_5 > '')
            {
                    return false;
            }
            
            return Org.BouncyCastle.Asn1.DerObjectIdentifier.IsValidBranchID(branchID:  identifier, start:  2);
        }
        private static string MakeOidStringFromBytes(byte[] bytes)
        {
            object val_19;
            var val_20;
            var val_21;
            var val_22;
            Org.BouncyCastle.Math.BigInteger val_23;
            object val_24;
            long val_25;
            System.Text.StringBuilder val_1 = null;
            val_19 = 0;
            val_1 = new System.Text.StringBuilder();
            val_20 = 0;
            val_21 = 0;
            val_22 = 1;
            goto label_31;
            label_35:
            val_23 = 0;
            if(val_20 >= 1152921504632991744)
            {
                    val_19 = 0;
            }
            
            byte val_19 = bytes[val_23];
            if(0 <= 72057594037927808)
            {
                goto label_3;
            }
            
            val_23 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  val_19 & 127);
            val_24 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  0).Or(value:  val_23);
            if((val_19 & 128) != 0)
            {
                goto label_10;
            }
            
            if((val_22 & 1) != 0)
            {
                    System.Text.StringBuilder val_6 = val_1.Append(value:  '2');
                val_24 = val_24.Subtract(n:  Org.BouncyCastle.Math.BigInteger.ValueOf(value:  80));
            }
            
            if(val_1 == null)
            {
                goto label_16;
            }
            
            System.Text.StringBuilder val_9 = val_1.Append(value:  '.');
            goto label_17;
            label_3:
            bytes[val_23] = val_19 & 127;
            val_25 = 0 + bytes[val_23];
            if((val_19 & 128) != 0)
            {
                goto label_18;
            }
            
            if((val_22 & 1) == 0)
            {
                goto label_19;
            }
            
            if(val_25 <= 39)
            {
                goto label_20;
            }
            
            if(val_25 <= 79)
            {
                goto label_22;
            }
            
            System.Text.StringBuilder val_10 = val_1.Append(value:  '2');
            val_25 = val_25 - 80;
            label_19:
            if(val_1 == null)
            {
                goto label_33;
            }
            
            label_32:
            System.Text.StringBuilder val_11 = val_1.Append(value:  '.');
            goto label_24;
            label_10:
            val_19 = 7;
            val_21 = val_24.ShiftLeft(n:  7);
            goto label_27;
            label_18:
            val_25 = val_25 << 7;
            goto label_27;
            label_16:
            System.Text.StringBuilder val_13 = val_1.Append(value:  '.');
            label_17:
            val_19 = val_24;
            System.Text.StringBuilder val_14 = val_1.Append(value:  val_19);
            val_22 = 0;
            val_21 = 0;
            goto label_28;
            label_20:
            System.Text.StringBuilder val_15 = val_1.Append(value:  '0');
            if(val_1 != null)
            {
                goto label_32;
            }
            
            label_33:
            System.Text.StringBuilder val_16 = val_1.Append(value:  '.');
            label_24:
            val_19 = val_25;
            System.Text.StringBuilder val_17 = val_1.Append(value:  val_19);
            val_22 = 0;
            label_28:
            label_27:
            val_20 = 1;
            goto label_31;
            label_22:
            System.Text.StringBuilder val_18 = val_1.Append(value:  '1');
            val_25 = val_25 - 40;
            if(val_1 != null)
            {
                goto label_32;
            }
            
            goto label_33;
            label_31:
            if(val_20 != bytes.Length)
            {
                goto label_35;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        internal static Org.BouncyCastle.Asn1.DerObjectIdentifier FromOctetString(byte[] enc)
        {
            var val_9;
            var val_10;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_11;
            var val_12;
            var val_13;
            var val_14;
            val_9 = null;
            val_9 = null;
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  Org.BouncyCastle.Asn1.DerObjectIdentifier.cache, lockTaken: ref  val_2);
            val_10 = null;
            val_10 = null;
            int val_3 = (Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  enc)) & 1023;
            Org.BouncyCastle.Asn1.DerObjectIdentifier[] val_4 = Org.BouncyCastle.Asn1.DerObjectIdentifier.cache + (((val_1 & 1023)) << 3);
            val_11 = mem[(Org.BouncyCastle.Asn1.DerObjectIdentifier.cache + ((val_1 & 1023)) << 3) + 32];
            val_11 = (Org.BouncyCastle.Asn1.DerObjectIdentifier.cache + ((val_1 & 1023)) << 3) + 32;
            if((val_11 != 0) && ((Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  enc, b:  val_11.GetBody())) != false))
            {
                    val_12 = 0;
                val_13 = 0;
            }
            else
            {
                    val_14 = null;
                val_14 = null;
                val_11 = new Org.BouncyCastle.Asn1.DerObjectIdentifier();
                val_11 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(bytes:  enc);
                Org.BouncyCastle.Asn1.DerObjectIdentifier[] val_8 = Org.BouncyCastle.Asn1.DerObjectIdentifier.cache + (((val_1 & 1023)) << 3);
                val_12 = 0;
                val_13 = 0;
                (Org.BouncyCastle.Asn1.DerObjectIdentifier.cache + ((val_1 & 1023)) << 3).__unknownFiledOffset_20 = val_11;
            }
            
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Org.BouncyCastle.Asn1.DerObjectIdentifier.cache);
            }
            
            if(val_12 != 1)
            {
                    if(val_13 == 0)
            {
                    return val_11;
            }
            
                if(91 == 91)
            {
                    return val_11;
            }
            
                return val_11;
            }
            
            if(val_13 != 0)
            {
                    return val_11;
            }
            
            return val_11;
        }
        private static DerObjectIdentifier()
        {
            Org.BouncyCastle.Asn1.DerObjectIdentifier.cache = new Org.BouncyCastle.Asn1.DerObjectIdentifier[1024];
        }
    
    }

}
