using UnityEngine;

namespace BestHTTP.Forms
{
    public sealed class HTTPUrlEncodedForm : HTTPFormBase
    {
        // Fields
        private const int EscapeTreshold = 256;
        private byte[] CachedData;
        
        // Methods
        public override void PrepareRequest(BestHTTP.HTTPRequest request)
        {
            request.SetHeader(name:  "Content-Type", value:  "application/x-www-form-urlencoded");
        }
        public override byte[] GetData()
        {
            System.Byte[] val_14;
            var val_15;
            string val_16;
            string val_17;
            val_14 = this.CachedData;
            if(val_14 != null)
            {
                    if(true == 0)
            {
                    return val_14;
            }
            
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_15 = 0;
            goto label_16;
            label_20:
            BestHTTP.Forms.HTTPFieldData val_2 = X22.Item[0];
            if(val_15 >= 1)
            {
                    System.Text.StringBuilder val_3 = val_1.Append(value:  "&");
            }
            
            val_16 = BestHTTP.Forms.HTTPUrlEncodedForm.EscapeString(originalString:  val_2.<Name>k__BackingField);
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_5 = val_1.Append(value:  val_16);
            }
            else
            {
                    System.Text.StringBuilder val_6 = val_1.Append(value:  val_16);
            }
            
            System.Text.StringBuilder val_7 = val_1.Append(value:  "=");
            if(((System.String.IsNullOrEmpty(value:  val_2.<Text>k__BackingField)) == false) || ((val_2.<Binary>k__BackingField) == null))
            {
                goto label_11;
            }
            
            val_16 = System.Text.Encoding.UTF8;
            if((val_2.<Binary>k__BackingField) == null)
            {
                goto label_12;
            }
            
            label_18:
            val_17 = val_16;
            goto label_14;
            label_11:
            val_17 = val_2.<Text>k__BackingField;
            label_14:
            System.Text.StringBuilder val_11 = val_1.Append(value:  BestHTTP.Forms.HTTPUrlEncodedForm.EscapeString(originalString:  val_17));
            val_15 = 1;
            goto label_16;
            label_12:
            if(val_16 != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_16:
            if(val_15 < X22.Count)
            {
                goto label_20;
            }
            
            mem[1152921553764607096] = 0;
            val_14 = System.Text.Encoding.UTF8;
            this.CachedData = val_14;
            return val_14;
        }
        public static string EscapeString(string originalString)
        {
            string val_22;
            int val_23;
            val_22 = originalString;
            if(val_22.Length <= 255)
            {
                    return System.Uri.EscapeDataString(stringToEscape:  val_22 = ???);
            }
            
            int val_2 = val_22.Length;
            int val_5 = ((val_2 < 0) ? (val_2 + 255) : (val_2)) >> 8;
            System.Text.StringBuilder val_6 = null;
            val_23 = val_5;
            val_6 = new System.Text.StringBuilder(capacity:  val_23);
            if(val_2 >= 255)
            {
                    var val_23 = 0;
                var val_22 = 0;
                do
            {
                if(val_22 < val_5)
            {
                    string val_8 = val_22.Substring(startIndex:  0, length:  256);
            }
            
                val_23 = System.Uri.EscapeDataString(stringToEscape:  val_22.Substring(startIndex:  0));
                System.Text.StringBuilder val_11 = val_6.Append(value:  val_23);
                val_22 = val_22 + 1;
                val_23 = val_23 + 256;
            }
            while((val_5 + 1) != val_22);
            
            }
            
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
        public HTTPUrlEncodedForm()
        {
            val_1 = new System.Object();
        }
    
    }

}
