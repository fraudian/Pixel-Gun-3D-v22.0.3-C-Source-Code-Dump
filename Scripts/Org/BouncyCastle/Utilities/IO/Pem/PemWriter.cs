using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemWriter
    {
        // Fields
        private const int LineLength = 64;
        private readonly System.IO.TextWriter writer;
        private readonly int nlLength;
        private char[] buf;
        
        // Properties
        public System.IO.TextWriter Writer { get; }
        
        // Methods
        public PemWriter(System.IO.TextWriter writer)
        {
            var val_4;
            this.buf = new char[64];
            if(writer != null)
            {
                    this.writer = writer;
                val_4 = null;
                val_4 = null;
                this.nlLength = Org.BouncyCastle.Utilities.Platform.NewLine.Length;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "writer");
        }
        public System.IO.TextWriter get_Writer()
        {
            return (System.IO.TextWriter)this.writer;
        }
        public int GetOutputSize(Org.BouncyCastle.Utilities.IO.Pem.PemObject obj)
        {
            System.Collections.IList val_19;
            var val_20;
            var val_24;
            var val_25;
            var val_26;
            var val_28;
            var val_29;
            var val_33;
            int val_22 = this.nlLength;
            val_19 = obj.headers;
            val_22 = obj.type.Length + val_22;
            val_20 = (val_22 << 1) + 30;
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(val_19.Count < 1)
            {
                goto label_8;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            System.Collections.IEnumerator val_6 = obj.headers.GetEnumerator();
            goto label_27;
            label_34:
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_24 = public System.Object System.Collections.IEnumerator::get_Current();
            if(val_6.Current != null)
            {
                    val_24 = 0;
            }
            
            val_25 = ": ";
            if((": ") == null)
            {
                    val_25 = ": ";
            }
            
            int val_14 = 0.Length + val_20;
            val_14 = val_14 + Length;
            val_14 = val_14 + 0.Length;
            val_26 = val_14 + this.nlLength;
            label_27:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_6.MoveNext() == true)
            {
                goto label_34;
            }
            
            val_28 = 0;
            val_29 = 0;
            val_19 = val_6;
            if(val_19 != null)
            {
                    var val_27 = 0;
                val_27 = val_27 + 1;
                val_19.Dispose();
            }
            
            val_33 = this.nlLength + val_20;
            label_8:
            int val_28 = obj.content.Length;
            val_28 = val_28 + 2;
            int val_18 = val_28 >> 63;
            val_28 = val_28 >> 32;
            val_28 = val_28 + val_18;
            val_18 = val_28 << 2;
            int val_19 = val_18 + 63;
            val_18 = val_18 + 126;
            val_28 = val_33 + (val_28 << 2);
            var val_20 = (val_19 < 0) ? (val_18) : (val_19);
            val_20 = val_20 >> 6;
            return (int)val_28 + (val_20 * this.nlLength);
        }
        public void WriteObject(Org.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator objGen)
        {
            string val_10;
            System.Collections.IList val_11;
            var val_15;
            var val_17;
            var val_18;
            var val_14 = 0;
            val_14 = val_14 + 1;
            Org.BouncyCastle.Utilities.IO.Pem.PemObject val_2 = objGen.Generate();
            if(val_2 != null)
            {
                    val_10 = val_2;
                this.WritePreEncapsulationBoundary(type:  val_2.type);
            }
            else
            {
                    val_10 = 16;
                this.WritePreEncapsulationBoundary(type:  11993091);
            }
            
            val_11 = val_2.headers;
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_11.Count < 1)
            {
                goto label_13;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.IEnumerator val_6 = val_2.headers.GetEnumerator();
            goto label_32;
            label_39:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_15 = public System.Object System.Collections.IEnumerator::get_Current();
            if(val_6.Current != null)
            {
                    val_15 = 0;
            }
            
            label_32:
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(val_6.MoveNext() == true)
            {
                goto label_39;
            }
            
            val_17 = 0;
            val_18 = 0;
            if(val_6 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_6.Dispose();
            }
            
            val_11 = this.writer;
            label_13:
            if(val_2 != null)
            {
                    this.WriteEncoded(bytes:  val_2.content);
            }
            else
            {
                    this.WriteEncoded(bytes:  64);
            }
            
            this.WritePostEncapsulationBoundary(type:  val_10);
        }
        private void WriteEncoded(byte[] bytes)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            goto label_0;
            label_11:
            val_3 = 0;
            goto label_1;
            label_7:
            val_3 = 1;
            this.buf[0] = Org.BouncyCastle.Utilities.Encoders.Base64.Encode(data:  bytes)[(long)(long)(int)(W9)];
            label_1:
            if(val_3 != this.buf.Length)
            {
                    if((val_2 + val_3) < val_1.Length)
            {
                goto label_7;
            }
            
            }
            
            val_2 = val_2 + this.buf.Length;
            label_0:
            if(val_2 < val_1.Length)
            {
                goto label_11;
            }
        
        }
        private void WritePreEncapsulationBoundary(string type)
        {
            string val_1 = "-----BEGIN "("-----BEGIN ") + type + "-----"("-----");
            if(this.writer == null)
            {
                
            }
        
        }
        private void WritePostEncapsulationBoundary(string type)
        {
            string val_1 = "-----END "("-----END ") + type + "-----"("-----");
            if(this.writer == null)
            {
                
            }
        
        }
    
    }

}
