using UnityEngine;

namespace BestHTTP.Forms
{
    public sealed class RawJsonForm : HTTPFormBase
    {
        // Fields
        private byte[] CachedData;
        
        // Methods
        public override void PrepareRequest(BestHTTP.HTTPRequest request)
        {
            request.SetHeader(name:  "Content-Type", value:  "application/json");
        }
        public override byte[] GetData()
        {
            System.Byte[] val_6;
            var val_7;
            System.Func<BestHTTP.Forms.HTTPFieldData, System.String> val_9;
            System.Func<BestHTTP.Forms.HTTPFieldData, System.String> val_11;
            val_6 = this.CachedData;
            if(val_6 != null)
            {
                    if(true == 0)
            {
                    return val_6;
            }
            
            }
            
            val_7 = null;
            val_7 = null;
            val_9 = RawJsonForm.<>c.<>9__2_0;
            if(val_9 == null)
            {
                    System.Func<BestHTTP.Forms.HTTPFieldData, System.String> val_1 = null;
                val_9 = val_1;
                val_1 = new System.Func<BestHTTP.Forms.HTTPFieldData, System.String>(object:  RawJsonForm.<>c.__il2cppRuntimeField_static_fields, method:  System.String RawJsonForm.<>c::<GetData>b__2_0(BestHTTP.Forms.HTTPFieldData x));
                val_7 = null;
                RawJsonForm.<>c.<>9__2_0 = val_9;
            }
            
            val_7 = null;
            val_11 = RawJsonForm.<>c.<>9__2_1;
            if(val_11 == null)
            {
                    System.Func<BestHTTP.Forms.HTTPFieldData, System.String> val_2 = null;
                val_11 = val_2;
                val_2 = new System.Func<BestHTTP.Forms.HTTPFieldData, System.String>(object:  RawJsonForm.<>c.__il2cppRuntimeField_static_fields, method:  System.String RawJsonForm.<>c::<GetData>b__2_1(BestHTTP.Forms.HTTPFieldData x));
                RawJsonForm.<>c.<>9__2_1 = val_11;
            }
            
            string val_4 = BestHTTP.JSON.Json.Encode(json:  System.Linq.Enumerable.ToDictionary<BestHTTP.Forms.HTTPFieldData, System.String, System.String>(source:  137146368, keySelector:  val_1, elementSelector:  val_2));
            mem[1152921553765341928] = 0;
            val_6 = System.Text.Encoding.UTF8;
            this.CachedData = val_6;
            return val_6;
        }
        public RawJsonForm()
        {
            val_1 = new System.Object();
        }
    
    }

}
