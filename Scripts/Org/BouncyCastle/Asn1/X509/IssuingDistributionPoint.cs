using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class IssuingDistributionPoint : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.X509.DistributionPointName _distributionPoint;
        private readonly bool _onlyContainsUserCerts;
        private readonly bool _onlyContainsCACerts;
        private readonly Org.BouncyCastle.Asn1.X509.ReasonFlags _onlySomeReasons;
        private readonly bool _indirectCRL;
        private readonly bool _onlyContainsAttributeCerts;
        private readonly Org.BouncyCastle.Asn1.Asn1Sequence seq;
        
        // Properties
        public bool OnlyContainsUserCerts { get; }
        public bool OnlyContainsCACerts { get; }
        public bool IsIndirectCrl { get; }
        public bool OnlyContainsAttributeCerts { get; }
        public Org.BouncyCastle.Asn1.X509.DistributionPointName DistributionPoint { get; }
        public Org.BouncyCastle.Asn1.X509.ReasonFlags OnlySomeReasons { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint() = new Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint();
            return (Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint)val_10;
        }
        public IssuingDistributionPoint(Org.BouncyCastle.Asn1.X509.DistributionPointName distributionPoint, bool onlyContainsUserCerts, bool onlyContainsCACerts, Org.BouncyCastle.Asn1.X509.ReasonFlags onlySomeReasons, bool indirectCRL, bool onlyContainsAttributeCerts)
        {
            Org.BouncyCastle.Asn1.X509.ReasonFlags val_20;
            bool val_21;
            Org.BouncyCastle.Asn1.X509.DistributionPointName val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            val_20 = onlySomeReasons;
            val_21 = onlyContainsUserCerts;
            val_22 = distributionPoint;
            this._distributionPoint = val_22;
            this._onlySomeReasons = val_20;
            this._indirectCRL = indirectCRL;
            this._onlyContainsAttributeCerts = onlyContainsAttributeCerts;
            this._onlyContainsCACerts = onlyContainsCACerts;
            this._onlyContainsUserCerts = val_21;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_6 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            if(val_22 != null)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_7 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_7[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  true, tagNo:  0, obj:  val_22);
                val_6.Add(objs:  val_7);
            }
            
            if(val_21 == true)
            {
                goto label_7;
            }
            
            if(onlyContainsCACerts == true)
            {
                goto label_8;
            }
            
            label_20:
            if(val_20 != null)
            {
                goto label_9;
            }
            
            label_28:
            if(indirectCRL == true)
            {
                goto label_10;
            }
            
            label_34:
            if(onlyContainsAttributeCerts == true)
            {
                goto label_11;
            }
            
            goto label_42;
            label_7:
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_9 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_23 = null;
            val_23 = null;
            val_22 = Org.BouncyCastle.Asn1.DerBoolean.True;
            val_9[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  1, obj:  val_22);
            val_6.Add(objs:  val_9);
            if(onlyContainsCACerts == false)
            {
                goto label_20;
            }
            
            label_8:
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_11 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_24 = null;
            val_24 = null;
            val_11[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  2, obj:  Org.BouncyCastle.Asn1.DerBoolean.True);
            val_6.Add(objs:  val_11);
            if(val_20 == null)
            {
                goto label_28;
            }
            
            label_9:
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_13 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            Org.BouncyCastle.Asn1.DerTaggedObject val_14 = null;
            val_21 = val_14;
            val_14 = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  3, obj:  val_20);
            val_13[0] = val_21;
            val_6.Add(objs:  val_13);
            if(indirectCRL == false)
            {
                goto label_34;
            }
            
            label_10:
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_15 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_25 = null;
            val_25 = null;
            Org.BouncyCastle.Asn1.DerTaggedObject val_16 = null;
            val_20 = val_16;
            val_16 = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  4, obj:  Org.BouncyCastle.Asn1.DerBoolean.True);
            val_15[0] = val_20;
            val_6.Add(objs:  val_15);
            if(onlyContainsAttributeCerts == false)
            {
                goto label_42;
            }
            
            label_11:
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_17 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_26 = null;
            val_26 = null;
            val_20 = Org.BouncyCastle.Asn1.DerBoolean.True;
            val_17[0] = new Org.BouncyCastle.Asn1.DerTaggedObject(explicitly:  false, tagNo:  5, obj:  val_20);
            val_6.Add(objs:  val_17);
            label_42:
            this.seq = new Org.BouncyCastle.Asn1.DerSequence(v:  val_6);
        }
        private IssuingDistributionPoint(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Asn1.DerBitString val_20;
            var val_21;
            val_20 = 0;
            this.seq = seq;
            val_21 = 0;
            goto label_1;
            label_24:
            if((Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj:  seq).TagNo) > 5)
            {
                goto label_3;
            }
            
            var val_20 = 106068324 + (val_2) << 2;
            val_20 = val_20 + 106068324;
            goto (106068324 + (val_2) << 2 + 106068324);
            label_1:
            if( != seq)
            {
                goto label_24;
            }
            
            return;
            label_3:
            System.ArgumentException val_19 = new System.ArgumentException(message:  "unknown tag in IssuingDistributionPoint");
        }
        public bool get_OnlyContainsUserCerts()
        {
            return (bool)this._onlyContainsUserCerts;
        }
        public bool get_OnlyContainsCACerts()
        {
            return (bool)this._onlyContainsCACerts;
        }
        public bool get_IsIndirectCrl()
        {
            return (bool)this._indirectCRL;
        }
        public bool get_OnlyContainsAttributeCerts()
        {
            return (bool)this._onlyContainsAttributeCerts;
        }
        public Org.BouncyCastle.Asn1.X509.DistributionPointName get_DistributionPoint()
        {
            return (Org.BouncyCastle.Asn1.X509.DistributionPointName)this._distributionPoint;
        }
        public Org.BouncyCastle.Asn1.X509.ReasonFlags get_OnlySomeReasons()
        {
            return (Org.BouncyCastle.Asn1.X509.ReasonFlags)this._onlySomeReasons;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.seq;
        }
        public override string ToString()
        {
            var val_14;
            string val_15;
            string val_16;
            val_14 = null;
            val_14 = null;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_2 = val_1.Append(value:  "IssuingDistributionPoint: [");
            }
            else
            {
                    System.Text.StringBuilder val_3 = val_1.Append(value:  "IssuingDistributionPoint: [");
            }
            
            val_15 = Org.BouncyCastle.Utilities.Platform.NewLine;
            System.Text.StringBuilder val_4 = val_1.Append(value:  val_15);
            if(this._distributionPoint != null)
            {
                    val_15 = val_1;
                this._distributionPoint.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "distributionPoint", val:  this._distributionPoint);
            }
            
            if(this._onlyContainsUserCerts != false)
            {
                    string val_5 = 1.ToString();
                val_15 = val_1;
                val_5.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "onlyContainsUserCerts", val:  val_5);
            }
            
            if(this._onlyContainsCACerts != false)
            {
                    string val_6 = 1.ToString();
                val_15 = val_1;
                val_6.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "onlyContainsCACerts", val:  val_6);
            }
            
            if(this._onlySomeReasons != null)
            {
                    string val_7 = this._onlySomeReasons.ToString();
                val_7.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "onlySomeReasons", val:  val_7);
            }
            
            if(this._onlyContainsAttributeCerts != false)
            {
                    string val_8 = 1.ToString();
                val_8.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "onlyContainsAttributeCerts", val:  val_8);
            }
            
            if(this._indirectCRL != false)
            {
                    string val_9 = 1.ToString();
                val_9.appendObject(buf:  val_1, sep:  Org.BouncyCastle.Utilities.Platform.NewLine, name:  "indirectCRL", val:  val_9);
            }
            
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_10 = val_1.Append(value:  "]");
                val_16 = Org.BouncyCastle.Utilities.Platform.NewLine;
                System.Text.StringBuilder val_11 = val_1.Append(value:  val_16);
                return (string)val_1;
            }
            
            System.Text.StringBuilder val_12 = val_1.Append(value:  "]");
            val_16 = Org.BouncyCastle.Utilities.Platform.NewLine;
            System.Text.StringBuilder val_13 = val_1.Append(value:  val_16);
            return (string)val_1;
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
