using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class DistributionPoint : Asn1Encodable
    {
        // Fields
        internal readonly Org.BouncyCastle.Asn1.X509.DistributionPointName distributionPoint;
        internal readonly Org.BouncyCastle.Asn1.X509.ReasonFlags reasons;
        internal readonly Org.BouncyCastle.Asn1.X509.GeneralNames cRLIssuer;
        
        // Properties
        public Org.BouncyCastle.Asn1.X509.DistributionPointName DistributionPointName { get; }
        public Org.BouncyCastle.Asn1.X509.ReasonFlags Reasons { get; }
        public Org.BouncyCastle.Asn1.X509.GeneralNames CrlIssuer { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.DistributionPoint GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.DistributionPoint.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.DistributionPoint GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.DistributionPoint)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X509.DistributionPoint() = new Org.BouncyCastle.Asn1.X509.DistributionPoint(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.X509.DistributionPoint();
            return (Org.BouncyCastle.Asn1.X509.DistributionPoint)val_10;
        }
        private DistributionPoint(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.DerBitString val_9;
            var val_10;
            val_9 = 0;
            val_10 = 0;
            goto label_1;
            label_11:
            Org.BouncyCastle.Asn1.Asn1TaggedObject val_1 = Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj:  seq);
            val_9 = 0;
            int val_2 = val_1.TagNo;
            if(val_2 == 2)
            {
                goto label_3;
            }
            
            if(val_2 == 1)
            {
                goto label_4;
            }
            
            if(val_2 != 0)
            {
                goto label_9;
            }
            
            val_9 = 1;
            this.distributionPoint = Org.BouncyCastle.Asn1.X509.DistributionPointName.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj:  val_1, explicitly:  true));
            goto label_9;
            label_4:
            Org.BouncyCastle.Asn1.X509.ReasonFlags val_6 = null;
            val_9 = Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj:  val_1, isExplicit:  false);
            val_6 = new Org.BouncyCastle.Asn1.X509.ReasonFlags(reasons:  val_9);
            this.reasons = val_6;
            goto label_9;
            label_3:
            val_9 = 0;
            this.cRLIssuer = Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_1, explicitly:  false));
            label_9:
            val_10 = 1;
            label_1:
            if(val_10 != seq)
            {
                goto label_11;
            }
        
        }
        public DistributionPoint(Org.BouncyCastle.Asn1.X509.DistributionPointName distributionPointName, Org.BouncyCastle.Asn1.X509.ReasonFlags reasons, Org.BouncyCastle.Asn1.X509.GeneralNames crlIssuer)
        {
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.distributionPoint = distributionPointName;
            this.reasons = reasons;
            this.cRLIssuer = val_1;
        }
        public Org.BouncyCastle.Asn1.X509.DistributionPointName get_DistributionPointName()
        {
            return (Org.BouncyCastle.Asn1.X509.DistributionPointName)this.distributionPoint;
        }
        public Org.BouncyCastle.Asn1.X509.ReasonFlags get_Reasons()
        {
            return (Org.BouncyCastle.Asn1.X509.ReasonFlags)this.reasons;
        }
        public Org.BouncyCastle.Asn1.X509.GeneralNames get_CrlIssuer()
        {
            return (Org.BouncyCastle.Asn1.X509.GeneralNames)this.cRLIssuer;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            T[] val_10 = System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>();
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_10 = System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            if(this.distributionPoint != null)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_10 = val_3;
                val_10[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(tagNo:  0, obj:  this.distributionPoint);
                val_2.Add(objs:  val_3);
            }
            
            if(this.reasons != null)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_5 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_10 = val_5;
                val_10[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  1, obj:  this.reasons);
                val_2.Add(objs:  val_5);
            }
            
            if(this.cRLIssuer == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_7 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            Org.BouncyCastle.Asn1.DerTaggedObject val_8 = null;
            val_10 = val_8;
            val_8 = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  2, obj:  this.cRLIssuer);
            val_7[0] = val_10;
            val_2.Add(objs:  val_7);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
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
                    System.Text.StringBuilder val_2 = val_1.Append(value:  "DistributionPoint: [");
            }
            else
            {
                    System.Text.StringBuilder val_3 = val_1.Append(value:  "DistributionPoint: [");
            }
            
            val_11 = Org.BouncyCastle.Utilities.Platform.NewLine;
            System.Text.StringBuilder val_4 = val_1.Append(value:  val_11);
            if(this.distributionPoint != null)
            {
                    val_11 = val_1;
                this.distributionPoint.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "distributionPoint", val:  this.distributionPoint);
            }
            
            if(this.reasons != null)
            {
                    string val_5 = this.reasons.ToString();
                val_11 = val_1;
                val_5.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "reasons", val:  val_5);
            }
            
            if(this.cRLIssuer != null)
            {
                    this.cRLIssuer.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "cRLIssuer", val:  this.cRLIssuer);
            }
            
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
