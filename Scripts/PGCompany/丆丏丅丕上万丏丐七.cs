using UnityEngine;

namespace PGCompany
{
    public class 丆丏丅丕上万丏丐七 : JsonConverter
    {
        // Properties
        public override bool 与丐下丂丂上业丕业 { get; }
        public override bool 下一且丄丗三丌丄丘 { get; }
        
        // Methods
        public override bool get_CanRead()
        {
            return true;
        }
        public override bool get_CanWrite()
        {
            return true;
        }
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            if((且丛三下万丂专专业 != 7) && (且丛三下万丂专专业 != 8))
            {
                    if(且丛三下万丂专专业 != 9)
            {
                    return (object)new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid}));
            }
            
            }
            
            decimal val_2 = System.Convert.ToDecimal(value:  且丛三下万丂专专业, provider:  new System.Globalization.CultureInfo(name:  "en-US"));
            return (object)new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid}));
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_8;
            var val_9;
            val_8 = 丙业与丙丗丝不丈东;
            val_9 = 业专丘专七丕丟丅与;
            val_8 = ???;
            val_9 = ???;
            goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_278;
        }
        public 丆丏丅丕上万丏丐七()
        {
        
        }
    
    }

}
