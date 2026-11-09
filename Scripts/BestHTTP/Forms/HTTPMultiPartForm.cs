using UnityEngine;

namespace BestHTTP.Forms
{
    public sealed class HTTPMultiPartForm : HTTPFormBase
    {
        // Fields
        private string Boundary;
        private byte[] CachedData;
        
        // Methods
        public HTTPMultiPartForm()
        {
            this = new System.Object();
            this.Boundary = "BestHTTP_HTTPMultiPartForm_" + this.GetHashCode().ToString(format:  "X")(this.GetHashCode().ToString(format:  "X"));
        }
        public override void PrepareRequest(BestHTTP.HTTPRequest request)
        {
            request.SetHeader(name:  "Content-Type", value:  "multipart/form-data; boundary=\""("multipart/form-data; boundary=\"") + this.Boundary + "\"");
        }
        public override byte[] GetData()
        {
            System.Byte[] val_17;
            string val_18;
            var val_19;
            string val_20;
            int val_21;
            var val_22;
            var val_23;
            val_17 = this.CachedData;
            if(val_17 != null)
            {
                    return val_17;
            }
            
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            val_18 = "--";
            val_19 = 1152921505558708224;
            goto label_24;
            label_27:
            BestHTTP.Forms.HTTPFieldData val_2 = X22.Item[val_17];
            BestHTTP.Extensions.Extensions.WriteLine(ms:  val_1, str:  "--"("--") + this.Boundary);
            if(val_2 != null)
            {
                    val_20 = val_2.<Name>k__BackingField;
            }
            else
            {
                    val_20 = 11993091;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_2.<FileName>k__BackingField)) != false)
            {
                    val_21 = System.String.alignConst;
            }
            else
            {
                    val_21 = "; filename=\""("; filename=\"") + val_2.<FileName>k__BackingField(val_2.<FileName>k__BackingField) + "\"";
            }
            
            val_19 = val_19;
            BestHTTP.Extensions.Extensions.WriteLine(ms:  val_1, str:  "Content-Disposition: form-data; name=\""("Content-Disposition: form-data; name=\"") + val_20 + "\"" + val_21);
            if((System.String.IsNullOrEmpty(value:  val_2.<MimeType>k__BackingField)) != true)
            {
                    BestHTTP.Extensions.Extensions.WriteLine(ms:  val_1, str:  "Content-Type: "("Content-Type: ") + val_2.<MimeType>k__BackingField(val_2.<MimeType>k__BackingField));
            }
            
            System.Byte[] val_9 = val_2.Payload;
            BestHTTP.Extensions.Extensions.WriteLine(ms:  val_1, str:  "Content-Length: "("Content-Length: ") + val_9.Length.ToString());
            BestHTTP.Extensions.Extensions.WriteLine(ms:  val_1);
            System.Byte[] val_12 = val_2.Payload;
            System.Byte[] val_13 = val_2.Payload;
            val_18 = val_18;
            val_17 = val_17 + 1;
            label_24:
            if(val_17 < X22.Count)
            {
                goto label_27;
            }
            
            BestHTTP.Extensions.Extensions.WriteLine(ms:  val_1, str:  val_18 + this.Boundary + val_18);
            mem[1152921553763993816] = 0;
            val_22 = 0;
            val_23 = 0;
            this.CachedData = val_1;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_1.Dispose();
            if( != 1)
            {
                    return val_17;
            }
            
            if(null == null)
            {
                    return val_17;
            }
            
            return val_17;
        }
    
    }

}
