using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class X509NameTokenizer
    {
        // Fields
        private string value;
        private int index;
        private char separator;
        private System.Text.StringBuilder buffer;
        
        // Methods
        public X509NameTokenizer(string oid)
        {
        
        }
        public X509NameTokenizer(string oid, char separator)
        {
            this.buffer = new System.Text.StringBuilder();
            this.value = oid;
            this.index = 0;
            this.separator = separator;
        }
        public bool HasMoreTokens()
        {
            return (bool)(this.index != this.value.Length) ? 1 : 0;
        }
        public string NextToken()
        {
            int val_18;
            char val_19;
            var val_20;
            if(this.index == this.value.Length)
            {
                    return 0;
            }
            
            int val_19 = this.index;
            if(this.buffer != null)
            {
                    val_18 = this.buffer.Length;
            }
            else
            {
                    val_18 = 0.Length;
            }
            
            System.Text.StringBuilder val_4 = this.buffer.Remove(startIndex:  0, length:  val_18);
            goto label_4;
            label_12:
            if(W8 == this.separator)
            {
                goto label_8;
            }
            
            System.Text.StringBuilder val_6 = this.buffer.Append(value:  this.buffer);
            label_4:
            val_19 = val_19 + 1;
            if(val_19 == this.value.Length)
            {
                goto label_8;
            }
            
            char val_8 = this.value.Chars[val_19];
            if((val_8 & 65535) == '"')
            {
                goto label_10;
            }
            
            if(((0 | 0) & 1) != 0)
            {
                goto label_11;
            }
            
            if((val_8 & 65535) != '\')
            {
                goto label_12;
            }
            
            goto label_4;
            label_10:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            val_19 = 34;
            goto label_16;
            label_11:
            char val_11 = val_8 & 65535;
            if(val_11 == ('+'))
            {
                goto label_17;
            }
            
            if(val_11 != '#')
            {
                goto label_23;
            }
            
            if(this.buffer == null)
            {
                goto label_19;
            }
            
            val_20 = this.buffer.Length;
            goto label_20;
            label_17:
            if(this.separator != ('+'))
            {
                goto label_21;
            }
            
            goto label_23;
            label_19:
            val_20 = 0.Length;
            label_20:
            if(((this.buffer.Chars[val_20 - 1]) & 65535) != ('='))
            {
                goto label_23;
            }
            
            label_21:
            System.Text.StringBuilder val_17 = this.buffer.Append(value:  '\');
            label_23:
            val_19 = val_8;
            label_16:
            System.Text.StringBuilder val_18 = this.buffer.Append(value:  val_19);
            goto label_4;
            label_8:
            this.index = val_19;
            if(this.buffer != null)
            {
                    return this.buffer.Trim();
            }
            
            return this.buffer.Trim();
        }
    
    }

}
