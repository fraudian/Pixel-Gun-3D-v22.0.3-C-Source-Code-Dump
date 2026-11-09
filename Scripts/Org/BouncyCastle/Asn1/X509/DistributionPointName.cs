using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class DistributionPointName : Asn1Encodable, IAsn1Choice
    {
        // Fields
        internal readonly Org.BouncyCastle.Asn1.Asn1Encodable name;
        internal readonly int type;
        public const int FullName = 0;
        public const int NameRelativeToCrlIssuer = 1;
        
        // Properties
        public int PointType { get; }
        public Org.BouncyCastle.Asn1.Asn1Encodable Name { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.DistributionPointName GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.DistributionPointName.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj:  obj, explicitly:  true));
        }
        public static Org.BouncyCastle.Asn1.X509.DistributionPointName GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1TaggedObject val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.DistributionPointName)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X509.DistributionPointName() = new Org.BouncyCastle.Asn1.X509.DistributionPointName(obj:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.X509.DistributionPointName();
            return (Org.BouncyCastle.Asn1.X509.DistributionPointName)val_10;
        }
        public DistributionPointName(int type, Org.BouncyCastle.Asn1.Asn1Encodable name)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.type = type;
            this.name = val_1;
        }
        public DistributionPointName(Org.BouncyCastle.Asn1.X509.GeneralNames name)
        {
            this.type = 0;
            this.name = name;
        }
        public int get_PointType()
        {
            return (int)this.type;
        }
        public Org.BouncyCastle.Asn1.Asn1Encodable get_Name()
        {
            return (Org.BouncyCastle.Asn1.Asn1Encodable)this.name;
        }
        public DistributionPointName(Org.BouncyCastle.Asn1.Asn1TaggedObject obj)
        {
            int val_1 = obj.TagNo;
            this.type = val_1;
            if(val_1 != 0)
            {
                    Org.BouncyCastle.Asn1.Asn1Set val_2 = Org.BouncyCastle.Asn1.Asn1Set.GetInstance(obj:  obj, explicitly:  false);
            }
            
            this.name = Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  false));
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  this.type, obj:  this.name);
        }
        public override string ToString()
        {
            var val_10;
            string val_11;
            string val_12;
            val_10 = null;
            val_10 = null;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_2 = val_1.Append(value:  "DistributionPointName: [");
            }
            else
            {
                    System.Text.StringBuilder val_3 = val_1.Append(value:  "DistributionPointName: [");
            }
            
            System.Text.StringBuilder val_4 = val_1.Append(value:  Org.BouncyCastle.Utilities.Platform.NewLine);
            string val_5 = this.name.ToString();
            if(this.type != 0)
            {
                    val_11 = "nameRelativeToCRLIssuer";
            }
            else
            {
                    val_11 = "fullName";
            }
            
            val_5.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  val_11, val:  val_5);
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_6 = val_1.Append(value:  "]");
                val_12 = Org.BouncyCastle.Utilities.Platform.NewLine;
                System.Text.StringBuilder val_7 = val_1.Append(value:  val_12);
            }
            else
            {
                    System.Text.StringBuilder val_8 = val_1.Append(value:  "]");
                val_12 = Org.BouncyCastle.Utilities.Platform.NewLine;
                System.Text.StringBuilder val_9 = val_1.Append(value:  val_12);
            }
        
        }
        private void appendObject(System.Text.StringBuilder buf, string sep, string name, string val)
        {
            if(buf != null)
            {
                    System.Text.StringBuilder val_1 = buf.Append(value:  "    ");
                System.Text.StringBuilder val_2 = buf.Append(value:  name);
                System.Text.StringBuilder val_3 = buf.Append(value:  ":");
                System.Text.StringBuilder val_4 = buf.Append(value:  sep);
                System.Text.StringBuilder val_5 = buf.Append(value:  "    ");
                System.Text.StringBuilder val_6 = buf.Append(value:  "    ");
                System.Text.StringBuilder val_7 = buf.Append(value:  val);
            }
            else
            {
                    System.Text.StringBuilder val_8 = 0.Append(value:  "    ");
                System.Text.StringBuilder val_9 = 0.Append(value:  name);
                System.Text.StringBuilder val_10 = 0.Append(value:  ":");
                System.Text.StringBuilder val_11 = 0.Append(value:  sep);
                System.Text.StringBuilder val_12 = 0.Append(value:  "    ");
                System.Text.StringBuilder val_13 = 0.Append(value:  "    ");
                System.Text.StringBuilder val_14 = 0.Append(value:  val);
            }
            
            System.Text.StringBuilder val_15 = buf.Append(value:  sep);
        }
    
    }

}
