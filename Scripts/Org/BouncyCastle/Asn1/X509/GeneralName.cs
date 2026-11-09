using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class GeneralName : Asn1Encodable, IAsn1Choice
    {
        // Fields
        public const int OtherName = 0;
        public const int Rfc822Name = 1;
        public const int DnsName = 2;
        public const int X400Address = 3;
        public const int DirectoryName = 4;
        public const int EdiPartyName = 5;
        public const int UniformResourceIdentifier = 6;
        public const int IPAddress = 7;
        public const int RegisteredID = 8;
        internal readonly Org.BouncyCastle.Asn1.Asn1Encodable obj;
        internal readonly int tag;
        
        // Properties
        public int TagNo { get; }
        public Org.BouncyCastle.Asn1.Asn1Encodable Name { get; }
        
        // Methods
        public GeneralName(Org.BouncyCastle.Asn1.X509.X509Name directoryName)
        {
            this.obj = directoryName;
            this.tag = 4;
        }
        public GeneralName(Org.BouncyCastle.Asn1.Asn1Object name, int tag)
        {
            this.obj = name;
            this.tag = tag;
        }
        public GeneralName(int tag, Org.BouncyCastle.Asn1.Asn1Encodable name)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.obj = val_1;
            this.tag = tag;
        }
        public GeneralName(int tag, string name)
        {
            this.tag = tag;
            if((tag - 1) > 7)
            {
                goto label_1;
            }
            
            var val_10 = 106068256 + ((tag - 1)) << 2;
            val_10 = val_10 + 106068256;
            goto (106068256 + ((tag - 1)) << 2 + 106068256);
            label_1:
            System.ArgumentException val_8 = new System.ArgumentException(message:  "can\'t process string for tag: "("can\'t process string for tag: ") + tag, paramName:  "tag");
            label_6:
            System.ArgumentException val_9 = new System.ArgumentException(message:  "IP Address is invalid", paramName:  "name");
            goto label_6;
        }
        public static Org.BouncyCastle.Asn1.X509.GeneralName GetInstance(object obj)
        {
            Org.BouncyCastle.Asn1.Asn1TaggedObject val_27;
            System.Byte[] val_28;
            string val_32;
            var val_33;
            var val_34;
            var val_36;
            val_27 = obj;
            if(val_27 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.GeneralName)val_27;
            }
            
            if(val_27 != null)
            {
                    val_28 = val_27;
                if(val_28 == null)
            {
                    val_28 = 0;
            }
            
                val_27 = Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  val_28);
                return (Org.BouncyCastle.Asn1.X509.GeneralName)val_27;
            }
            
            val_32 = "unknown object in GetInstance: "("unknown object in GetInstance: ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_27)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  val_27));
            val_33 = 1152921553507349120;
            val_34 = new System.ArgumentException(message:  val_32, paramName:  "obj");
            mem[8] = null;
            val_36 = 8;
        }
        public static Org.BouncyCastle.Asn1.X509.GeneralName GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject tagObj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj:  tagObj, explicitly:  true));
        }
        public int get_TagNo()
        {
            return (int)this.tag;
        }
        public Org.BouncyCastle.Asn1.Asn1Encodable get_Name()
        {
            return (Org.BouncyCastle.Asn1.Asn1Encodable)this.obj;
        }
        public override string ToString()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable val_10;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_2 = val_1.Append(value:  this.tag);
            }
            else
            {
                    System.Text.StringBuilder val_3 = val_1.Append(value:  this.tag);
            }
            
            System.Text.StringBuilder val_4 = val_1.Append(value:  ": ");
            if((this.tag - 1) < 2)
            {
                goto label_3;
            }
            
            if(this.tag == 4)
            {
                goto label_4;
            }
            
            if(this.tag != 6)
            {
                goto label_5;
            }
            
            label_3:
            val_10 = Org.BouncyCastle.Asn1.DerIA5String.GetInstance(obj:  this.obj);
            if(val_10 != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_4:
            val_10 = Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj:  this.obj);
            if(val_10 != null)
            {
                goto label_12;
            }
            
            goto label_11;
            label_5:
            val_10 = this.obj;
            if(val_10 != null)
            {
                goto label_12;
            }
            
            label_11:
            label_12:
            label_7:
            System.Text.StringBuilder val_9 = val_1.Append(value:  val_10.ToString());
            if(val_1 == null)
            {
                
            }
        
        }
        private byte[] toGeneralNameEncoding(string ip)
        {
            string val_26;
            System.Byte[] val_27;
            string val_29;
            System.Byte[] val_30;
            var val_31;
            val_26 = ip;
            if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6WithNetmask(address:  val_26)) != true)
            {
                    if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(address:  val_26)) == false)
            {
                goto label_2;
            }
            
            }
            
            int val_3 = val_26.IndexOf(value:  '/');
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            byte[] val_4 = new byte[32];
            val_27 = val_4;
            if(val_26 == null)
            {
                goto label_5;
            }
            
            string val_5 = val_26.Substring(startIndex:  0, length:  val_3);
            System.Int32[] val_6 = val_5.parseIPv6(ip:  val_5);
            val_6.copyInts(parsedIp:  val_6, addr:  val_4, offSet:  0);
            goto label_6;
            label_4:
            byte[] val_7 = new byte[16];
            val_27 = val_7;
            System.Int32[] val_8 = val_7.parseIPv6(ip:  val_26);
            val_8.copyInts(parsedIp:  val_8, addr:  val_7, offSet:  0);
            return val_27;
            label_2:
            if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4WithNetmask(address:  val_26)) != true)
            {
                    val_27 = 0;
                if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(address:  val_26)) == false)
            {
                    return val_27;
            }
            
            }
            
            int val_11 = val_26.IndexOf(value:  '/');
            if((val_11 & 2147483648) != 0)
            {
                goto label_11;
            }
            
            byte[] val_12 = new byte[8];
            val_27 = val_12;
            if(val_26 == null)
            {
                goto label_12;
            }
            
            string val_13 = val_26.Substring(startIndex:  0, length:  val_11);
            val_13.parseIPv4(ip:  val_13, addr:  val_12, offset:  0);
            goto label_13;
            label_5:
            string val_14 = 0.Substring(startIndex:  0, length:  val_3);
            System.Int32[] val_15 = val_14.parseIPv6(ip:  val_14);
            val_15.copyInts(parsedIp:  val_15, addr:  val_4, offSet:  0);
            label_6:
            val_26 = val_26.Substring(startIndex:  val_3 + 1);
            int val_18 = val_26.IndexOf(value:  ':');
            if(val_18 >= 1)
            {
                    System.Int32[] val_19 = val_18.parseIPv6(ip:  val_26);
            }
            else
            {
                    System.Int32[] val_20 = val_18.parseMask(mask:  val_26);
            }
            
            val_20.copyInts(parsedIp:  val_20, addr:  val_4, offSet:  16);
            return val_27;
            label_11:
            val_27 = new byte[4];
            val_29 = val_26;
            val_30 = val_27;
            val_31 = 0;
            goto label_18;
            label_12:
            string val_22 = 0.Substring(startIndex:  0, length:  val_11);
            val_22.parseIPv4(ip:  val_22, addr:  val_12, offset:  0);
            label_13:
            val_26 = val_26.Substring(startIndex:  val_11 + 1);
            int val_25 = val_26.IndexOf(value:  '.');
            val_31 = 4;
            val_29 = val_26;
            val_30 = val_27;
            if(val_25 < 1)
            {
                goto label_20;
            }
            
            label_18:
            val_25.parseIPv4(ip:  val_29, addr:  val_12, offset:  4);
            return val_27;
            label_20:
            val_25.parseIPv4Mask(mask:  val_29, addr:  val_12, offset:  4);
            return val_27;
        }
        private void parseIPv4Mask(string mask, byte[] addr, int offset)
        {
            int val_1 = System.Int32.Parse(s:  mask);
            if(val_1 == 0)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                var val_2 = val_6 + 7;
                var val_3 = (val_6 < 0) ? (val_2) : (val_6);
                val_3 = offset + (val_3 >> 3);
                var val_4 = (val_6 < 0) ? (val_2) : (val_6);
                byte val_5 = addr[(long)val_3];
                val_4 = val_4 & 24;
                val_4 = val_6 - val_4;
                val_4 = val_4 & 31;
                val_6 = val_6 + 1;
                val_4 = 1 << val_4;
                val_5 = val_4 | val_5;
                addr[(long)val_3] = val_5;
            }
            while(val_1 != val_6);
        
        }
        private void parseIPv4(string ip, byte[] addr, int offset)
        {
            int val_5;
            var val_6;
            char[] val_1 = new char[2];
            val_5 = val_1.Length;
            if(val_5 == 0)
            {
                    val_5 = val_1.Length;
            }
            
            val_1[0] = '.';
            val_1[0] = '/';
            val_6 = 0;
            goto label_5;
            label_10:
            val_6 = 1;
            addr[(long)offset + val_6] = System.Int32.Parse(s:  ip.Split(separator:  val_1)[0]);
            label_5:
            if(val_6 < val_2.Length)
            {
                goto label_10;
            }
        
        }
        private int[] parseMask(string mask)
        {
            int[] val_1 = new int[8];
            int val_2 = System.Int32.Parse(s:  mask);
            if(val_2 == 0)
            {
                    return (System.Int32[])val_1;
            }
            
            var val_8 = 0;
            do
            {
                var val_3 = val_8 + 15;
                var val_5 = ((val_8 < 0) ? (val_3) : (val_8)) >> 4;
                var val_6 = (val_8 < 0) ? (val_3) : (val_8);
                int val_7 = val_1[((long)((0 < 0x0 ? (0 + 15) : 0>>4) & 0xFFFFFFF)) << 2];
                val_6 = val_6 & 16;
                val_6 = val_8 - val_6;
                val_6 = val_6 & 31;
                val_8 = val_8 + 1;
                val_6 = 1 << val_6;
                val_7 = val_7 | val_6;
                val_1[((long)((0 < 0x0 ? (0 + 15) : 0>>4) & 0xFFFFFFF)) << 2] = val_7;
            }
            while(val_2 != val_8);
            
            return (System.Int32[])val_1;
        }
        private void copyInts(int[] parsedIp, byte[] addr, int offSet)
        {
            var val_3;
            var val_4;
            val_3 = offSet;
            val_4 = 0;
            goto label_0;
            label_7:
            addr[(long)val_3] = parsedIp[0] >> 8;
            val_4 = 1;
            val_3 = val_3 + 2;
            addr[(long)val_3 + 1] = parsedIp[0x0] + 32;
            label_0:
            if(val_4 != parsedIp.Length)
            {
                goto label_7;
            }
        
        }
        private int[] parseIPv6(string ip)
        {
            string val_26;
            var val_28;
            int val_29;
            var val_30;
            var val_31;
            string val_33;
            var val_34;
            var val_35;
            int val_37;
            val_26 = ip;
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_26, prefix:  "::")) == false)
            {
                goto label_3;
            }
            
            string val_2 = val_26.Substring(startIndex:  1);
            goto label_5;
            label_3:
            if((Org.BouncyCastle.Utilities.Platform.EndsWith(source:  val_26, suffix:  "::")) == false)
            {
                goto label_8;
            }
            
            if(val_26 != null)
            {
                    val_28 = val_26.Length;
            }
            else
            {
                    val_28 = 0.Length;
            }
            
            label_5:
            val_26 = val_26.Substring(startIndex:  0, length:  val_28 - 1);
            label_8:
            char[] val_8 = new char[1];
            val_8[0] = ':';
            val_29 = val_26.Split(separator:  val_8).GetEnumerator();
            int[] val_11 = new int[8];
            val_30 = 0;
            val_31 = 0;
            goto label_38;
            label_49:
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_33 = val_29.Current;
            if(val_33 != null)
            {
                    if(null == null)
            {
                goto label_22;
            }
            
            }
            
            val_33 = 0;
            val_34 = 1;
            goto label_23;
            label_22:
            val_34 = 0;
            label_23:
            if(val_33.Length == 0)
            {
                goto label_24;
            }
            
            if(((val_33.IndexOf(value:  '.')) & 2147483648) != 0)
            {
                goto label_26;
            }
            
            char[] val_17 = new char[1];
            val_17[0] = '.';
            System.String[] val_34 = val_33.Split(separator:  val_17);
            int val_31 = System.Int32.Parse(s:  val_34[0]);
            val_31 = (System.Int32.Parse(s:  val_34[1])) | (val_31 << 8);
            val_11[0] = val_31;
            val_35 = System.Int32.Parse(s:  val_34[2]);
            val_34 = (System.Int32.Parse(s:  val_34[3])) | (val_35 << 8);
            if(1 < val_11.Length)
            {
                goto label_41;
            }
            
            label_40:
            label_41:
            val_30 = 2;
            val_11[4] = val_34;
            goto label_38;
            label_26:
            int val_23 = System.Int32.Parse(s:  val_33, style:  512);
            if(val_30 >= val_11.Length)
            {
                goto label_40;
            }
            
            goto label_41;
            label_24:
            val_35 = 0;
            val_11[0] = 0;
            val_31 = val_30;
            val_30 = 1;
            label_38:
            var val_35 = 0;
            val_35 = val_35 + 1;
            if(val_29.MoveNext() == true)
            {
                goto label_49;
            }
            
            if(val_30 == val_11.Length)
            {
                    return (System.Int32[])val_11;
            }
            
            val_29 = val_30 - val_31;
            System.Array.Copy(sourceArray:  val_11, sourceIndex:  0, destinationArray:  val_11, destinationIndex:  val_11.Length - val_29, length:  val_29);
            val_37 = val_11.Length;
            goto label_52;
            label_54:
            val_11[0] = 0;
            val_37 = val_11.Length;
            val_31 = 0 + 1;
            label_52:
            if(val_31 != (val_37 - val_29))
            {
                goto label_54;
            }
            
            return (System.Int32[])val_11;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  (this.tag == 4) ? 1 : 0, tagNo:  this.tag, obj:  this.obj);
        }
    
    }

}
