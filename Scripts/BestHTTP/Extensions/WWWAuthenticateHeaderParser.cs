using UnityEngine;

namespace BestHTTP.Extensions
{
    public sealed class WWWAuthenticateHeaderParser : KeyValuePairList
    {
        // Methods
        public WWWAuthenticateHeaderParser(string headerValue)
        {
            val_1 = new System.Object();
            mem[1152921553783887440] = val_1.ParseQuotedHeader(str:  headerValue);
        }
        private System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> ParseQuotedHeader(string str)
        {
            var val_12;
            System.Func<System.Char, System.Boolean> val_14;
            BestHTTP.Extensions.HeaderValue val_15;
            System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> val_1 = new System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue>();
            if(str == null)
            {
                    return val_1;
            }
            
            int val_3 = 0;
            val_12 = null;
            val_12 = null;
            val_14 = WWWAuthenticateHeaderParser.<>c.<>9__1_0;
            if(val_14 == null)
            {
                    System.Func<System.Char, System.Boolean> val_2 = null;
                val_14 = val_2;
                val_2 = new System.Func<System.Char, System.Boolean>(object:  WWWAuthenticateHeaderParser.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WWWAuthenticateHeaderParser.<>c::<ParseQuotedHeader>b__1_0(char ch));
                WWWAuthenticateHeaderParser.<>c.<>9__1_0 = val_14;
            }
            
            BestHTTP.Extensions.HeaderValue val_6 = null;
            val_15 = val_6;
            val_6 = new BestHTTP.Extensions.HeaderValue();
            .<Key>k__BackingField = BestHTTP.Extensions.Extensions.TrimAndLower(str:  BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  val_3, block:  val_2, needResult:  true));
            if(val_1 != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_15:
            BestHTTP.Extensions.HeaderValue val_9 = null;
            val_15 = val_9;
            val_9 = new BestHTTP.Extensions.HeaderValue();
            .<Key>k__BackingField = BestHTTP.Extensions.Extensions.TrimAndLower(str:  BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  val_3, block:  '=', needResult:  true));
            BestHTTP.Extensions.Extensions.SkipWhiteSpace(str:  str, pos: ref  val_3);
            .<Value>k__BackingField = BestHTTP.Extensions.Extensions.ReadPossibleQuotedText(str:  str, pos: ref  val_3);
            label_14:
            val_1.Add(item:  val_9);
            if(0 < str.Length)
            {
                goto label_15;
            }
            
            return val_1;
        }
    
    }

}
