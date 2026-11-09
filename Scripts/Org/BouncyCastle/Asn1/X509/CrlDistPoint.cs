using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class CrlDistPoint : Asn1Encodable
    {
        // Fields
        internal readonly Org.BouncyCastle.Asn1.Asn1Sequence seq;
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.CrlDistPoint GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.CrlDistPoint GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.CrlDistPoint)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X509.CrlDistPoint() = new Org.BouncyCastle.Asn1.Asn1Encodable();
            .seq = val_9;
            val_10 = new Org.BouncyCastle.Asn1.X509.CrlDistPoint();
            return (Org.BouncyCastle.Asn1.X509.CrlDistPoint)val_10;
        }
        private CrlDistPoint(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            this.seq = seq;
        }
        public CrlDistPoint(Org.BouncyCastle.Asn1.X509.DistributionPoint[] points)
        {
            this.seq = new Org.BouncyCastle.Asn1.DerSequence(v:  points);
        }
        public Org.BouncyCastle.Asn1.X509.DistributionPoint[] GetDistributionPoints()
        {
            var val_3;
            var val_4;
            val_3 = this.seq;
            Org.BouncyCastle.Asn1.X509.DistributionPoint[] val_1 = new Org.BouncyCastle.Asn1.X509.DistributionPoint[0];
            val_4 = 0;
            goto label_2;
            label_11:
            val_3 = val_4;
            Org.BouncyCastle.Asn1.X509.DistributionPoint val_2 = Org.BouncyCastle.Asn1.X509.DistributionPoint.GetInstance(obj:  this.seq);
            if(val_1 == null)
            {
                goto label_4;
            }
            
            if(val_2 != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_2 == null)
            {
                goto label_8;
            }
            
            label_5:
            if(val_2 == null)
            {
                    val_3 = 0;
            }
            
            label_8:
            if(val_4 >= val_1.Length)
            {
                    val_3 = 0;
            }
            
            val_4 = 1;
            val_1[0] = val_2;
            label_2:
            if(val_4 != this.seq)
            {
                goto label_11;
            }
            
            return val_1;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.seq;
        }
        public override string ToString()
        {
            var val_10;
            string val_11;
            var val_12;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_10 = null;
            val_10 = null;
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_2 = val_1.Append(value:  "CRLDistPoint:");
            }
            else
            {
                    System.Text.StringBuilder val_3 = val_1.Append(value:  "CRLDistPoint:");
            }
            
            val_11 = Org.BouncyCastle.Utilities.Platform.NewLine;
            System.Text.StringBuilder val_4 = val_1.Append(value:  val_11);
            val_12 = 0;
            goto label_5;
            label_11:
            System.Text.StringBuilder val_6 = val_1.Append(value:  "    ");
            Org.BouncyCastle.Asn1.X509.DistributionPoint val_10 = this.GetDistributionPoints()[0];
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_7 = val_1.Append(value:  val_10);
            }
            else
            {
                    System.Text.StringBuilder val_8 = val_1.Append(value:  val_10);
            }
            
            val_11 = Org.BouncyCastle.Utilities.Platform.NewLine;
            System.Text.StringBuilder val_9 = val_1.Append(value:  val_11);
            val_12 = 1;
            label_5:
            if(val_12 != val_5.Length)
            {
                goto label_11;
            }
            
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
    
    }

}
