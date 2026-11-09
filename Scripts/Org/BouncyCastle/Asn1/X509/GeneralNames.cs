using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class GeneralNames : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.X509.GeneralName[] names;
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.GeneralNames GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.GeneralNames)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.X509.GeneralNames() = new Org.BouncyCastle.Asn1.X509.GeneralNames(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.X509.GeneralNames();
            return (Org.BouncyCastle.Asn1.X509.GeneralNames)val_10;
        }
        public static Org.BouncyCastle.Asn1.X509.GeneralNames GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public GeneralNames(Org.BouncyCastle.Asn1.X509.GeneralName name)
        {
            Org.BouncyCastle.Asn1.X509.GeneralName[] val_1 = new Org.BouncyCastle.Asn1.X509.GeneralName[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(name != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(name == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = name;
            this.names = val_1;
        }
        public GeneralNames(Org.BouncyCastle.Asn1.X509.GeneralName[] names)
        {
            Org.BouncyCastle.Asn1.X509.GeneralName[] val_3;
            object val_1 = names.Clone();
            if(val_1 != null)
            {
                    val_3 = val_1;
                if(val_3 == null)
            {
                    val_3 = 0;
            }
            
            }
            
            this.names = val_3;
        }
        private GeneralNames(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            var val_3;
            var val_4;
            this.names = new Org.BouncyCastle.Asn1.X509.GeneralName[0];
            if(seq == null)
            {
                    return;
            }
            
            label_9:
            val_4 = 0;
            Org.BouncyCastle.Asn1.X509.GeneralName val_2 = Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(obj:  seq);
            if(this.names == null)
            {
                goto label_3;
            }
            
            if(val_2 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_2 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(val_2 == null)
            {
                    val_4 = 0;
            }
            
            label_7:
            if(0 >= this.names.Length)
            {
                    val_4 = 0;
            }
            
            this.names[0] = val_2;
            val_3 = 0 + 1;
            if(val_3 != seq)
            {
                goto label_9;
            }
        
        }
        public Org.BouncyCastle.Asn1.X509.GeneralName[] GetNames()
        {
            Org.BouncyCastle.Asn1.X509.GeneralName[] val_3;
            var val_4;
            val_3 = this.names;
            object val_1 = val_3.Clone();
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.GeneralName[])val_4;
            }
            
            val_4 = val_1;
            val_3 = null;
            if(val_4 != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.GeneralName[])val_4;
            }
            
            val_4 = 0;
            return (Org.BouncyCastle.Asn1.X509.GeneralName[])val_4;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  this.names);
        }
        public override string ToString()
        {
            Org.BouncyCastle.Asn1.X509.GeneralName val_10;
            var val_11;
            string val_12;
            var val_13;
            val_10 = this;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_11 = null;
            val_11 = null;
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_2 = val_1.Append(value:  "GeneralNames:");
            }
            else
            {
                    System.Text.StringBuilder val_3 = val_1.Append(value:  "GeneralNames:");
            }
            
            val_12 = Org.BouncyCastle.Utilities.Platform.NewLine;
            System.Text.StringBuilder val_4 = val_1.Append(value:  val_12);
            val_13 = 0;
            goto label_5;
            label_10:
            val_10 = this.names[0];
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_5 = val_1.Append(value:  "    ");
                System.Text.StringBuilder val_6 = val_1.Append(value:  val_10);
            }
            else
            {
                    System.Text.StringBuilder val_7 = val_1.Append(value:  "    ");
                System.Text.StringBuilder val_8 = val_1.Append(value:  val_10);
            }
            
            val_12 = Org.BouncyCastle.Utilities.Platform.NewLine;
            System.Text.StringBuilder val_9 = val_1.Append(value:  val_12);
            val_13 = 1;
            label_5:
            if(val_13 < this.names.Length)
            {
                goto label_10;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
    
    }

}
