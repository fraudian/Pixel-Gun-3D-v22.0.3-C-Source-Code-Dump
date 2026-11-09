using UnityEngine;

namespace BestHTTP.Extensions
{
    public sealed class HeaderParser : KeyValuePairList
    {
        // Methods
        public HeaderParser(string headerStr)
        {
            val_1 = new System.Object();
            mem[1152921553778299376] = val_1.Parse(headerStr:  headerStr);
        }
        private System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> Parse(string headerStr)
        {
            System.Exception val_7;
            System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> val_1 = new System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue>();
            int val_3 = 0;
            val_7 = 0;
            goto label_1;
            label_5:
            new BestHTTP.Extensions.HeaderValue() = new System.Object();
            new BestHTTP.Extensions.HeaderValue().ParseImplementation(headerStr:  headerStr, pos: ref  val_3, isOptionIsAnOption:  true);
            val_1.Add(item:  new BestHTTP.Extensions.HeaderValue());
            val_7 = val_3;
            label_1:
            if(0 < headerStr.Length)
            {
                goto label_5;
            }
            
            return val_1;
        }
    
    }

}
