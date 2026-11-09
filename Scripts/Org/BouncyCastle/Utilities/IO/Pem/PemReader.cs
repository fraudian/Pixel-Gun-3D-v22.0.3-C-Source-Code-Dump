using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemReader
    {
        // Fields
        private const string BeginString = "-----BEGIN ";
        private const string EndString = "-----END ";
        private readonly System.IO.TextReader reader;
        
        // Properties
        public System.IO.TextReader Reader { get; }
        
        // Methods
        public PemReader(System.IO.TextReader reader)
        {
            if(reader != null)
            {
                    this.reader = reader;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "reader");
        }
        public System.IO.TextReader get_Reader()
        {
            return (System.IO.TextReader)this.reader;
        }
        public Org.BouncyCastle.Utilities.IO.Pem.PemObject ReadPemObject()
        {
            var val_7;
            int val_8;
            if(this.reader == null)
            {
                    return 0;
            }
            
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  this.reader, prefix:  "-----BEGIN ")) == false)
            {
                    return 0;
            }
            
            val_7 = "-----BEGIN ";
            if(("-----BEGIN ") == null)
            {
                    val_7 = "-----BEGIN ";
            }
            
            string val_3 = this.reader.Substring(startIndex:  Length);
            if(val_3 != null)
            {
                    val_8 = val_3.IndexOf(value:  '-');
            }
            else
            {
                    val_8 = 0.IndexOf(value:  '-');
            }
            
            if(val_8 < 1)
            {
                    return 0;
            }
            
            return this.LoadObject(type:  val_3.Substring(startIndex:  0, length:  val_8));
        }
        private Org.BouncyCastle.Utilities.IO.Pem.PemObject LoadObject(string type)
        {
            int val_24;
            string val_25;
            var val_26;
            string val_1 = "-----END "("-----END ") + type;
            System.Collections.IList val_2 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
            goto label_17;
            label_22:
            val_24 = X24.IndexOf(value:  ':');
            if(val_24 == 1)
            {
                goto label_4;
            }
            
            val_25 = X24.Substring(startIndex:  0, length:  val_24).Trim();
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_25, prefix:  "X-")) != false)
            {
                    val_25 = val_25.Substring(startIndex:  2);
            }
            
            val_26 = 0;
            val_24 = X24.Substring(startIndex:  val_24 + 1).Trim();
            .name = val_25;
            .val = val_24;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_26 = 2;
            goto label_15;
            label_4:
            System.Text.StringBuilder val_14 = val_3.Append(value:  X24.Trim());
            goto label_17;
            label_15:
            int val_16 = val_2.Add(value:  new Org.BouncyCastle.Utilities.IO.Pem.PemHeader());
            label_17:
            if(this.reader == null)
            {
                goto label_19;
            }
            
            if((Org.BouncyCastle.Utilities.Platform.IndexOf(source:  this.reader, value:  val_1)) == 1)
            {
                goto label_22;
            }
            
            if((val_3.Length & 3) != 0)
            {
                goto label_24;
            }
            
            return (Org.BouncyCastle.Utilities.IO.Pem.PemObject)new Org.BouncyCastle.Utilities.IO.Pem.PemObject(type:  type, headers:  val_2, content:  Org.BouncyCastle.Utilities.Encoders.Base64.Decode(data:  val_3));
            label_19:
            System.IO.IOException val_23 = new System.IO.IOException(message:  val_1 + " not found");
            label_26:
            label_24:
            System.IO.IOException val_24 = new System.IO.IOException(message:  "base64 data appears to be truncated");
            goto label_26;
        }
    
    }

}
