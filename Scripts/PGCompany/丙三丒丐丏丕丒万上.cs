using UnityEngine;

namespace PGCompany
{
    public class 丙三丒丐丏丕丒万上 : JsonConverter
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
            string val_6;
            PGCompany.专丟专世丅丂丁且专 val_7;
            PGCompany.专丟专世丅丂丁且专 val_3 = 0;
            string val_2 = 0;
            val_6 = 且丛三下万丂专专业;
            if((val_6 != null) && (null != null))
            {
                    val_6 = 0;
            }
            
            bool val_4 = PGCompany.丂丑业与上丄丂且下.丂东专丙丒丏且丛丁(丞丕丒专一下丙业上:  val_6, 丗不丁丐下世上丙专: out  val_2, 一丗与一专丙丙丅丄: out  val_3);
            PGCompany.丘不七不丅丄丏七丆 val_5 = new PGCompany.丘不七不丅丄丏七丆();
            if(val_5 != null)
            {
                    .TypeName = val_2;
                val_7 = val_3;
            }
            else
            {
                    mem[16] = val_2;
                val_7 = val_3;
            }
            
            .丂丐丌丄上丞上丏丁 = val_7;
            return (object)val_5;
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_7;
            var val_8;
            val_7 = 丙业与丙丗丝不丈东;
            val_8 = 业专丘专七丕丟丅与;
            val_7 = ???;
            val_8 = ???;
            goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_278;
        }
        public 丙三丒丐丏丕丒万上()
        {
        
        }
    
    }

}
