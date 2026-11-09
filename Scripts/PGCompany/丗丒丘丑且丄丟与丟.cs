using UnityEngine;

namespace PGCompany
{
    public class 丗丒丘丑且丄丟与丟 : JsonConverter
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
            object val_6;
            string val_7;
            val_6 = 丄不丅丒不丁丁丌丘;
            if(且丛三下万丂专专业 == 9)
            {
                    val_7 = 且丛三下万丂专专业;
                if((val_7 != null) && (null != null))
            {
                    val_7 = 0;
            }
            
                System.ValueTuple<PGCompany.Attributes.丒丏丆且丕三丘丘丐, System.Boolean> val_2 = PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丗丘万业丆丐丞业丄(丞丕丒专一下丙业上:  val_7);
                val_6 = val_2.Item2;
                if((0 & 255) != 0)
            {
                    return val_6;
            }
            
                val_6 = 0;
                return val_6;
            }
            
            if(val_6 == null)
            {
                goto label_7;
            }
            
            label_18:
            与且丂丅丁专丙业丙.Populate(reader:  且丛三下万丂专专业, target:  val_6);
            return val_6;
            label_7:
            var val_8 = 0;
            val_8 = val_8 + 1;
            object val_7 = 与且丂丅丁专丙业丙.ResolveContract(type:  与丐与不丁丗丂一东).DefaultCreator.Invoke();
            if(与且丂丅丁专丙业丙 != null)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            PGCompany.Attributes.丒丏丆且丕三丘丘丐 val_7;
            var val_8;
            val_7 = 丙业与丙丗丝不丈东;
            val_8 = 业专丘专七丕丟丅与;
            if(val_7 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_7 = ???;
            val_8 = ???;
            goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_278;
            label_2:
            string val_1 = PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_7);
            if(val_8 != 0)
            {
                    return;
            }
        
        }
        public 丗丒丘丑且丄丟与丟()
        {
        
        }
    
    }

}
