using UnityEngine;

namespace PGCompany
{
    public class 丈专万丞丏丗丏丞丌 : JsonConverter
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
            string val_3;
            var val_4;
            val_3 = 且丛三下万丂专专业;
            if(val_3 == 9)
            {
                    val_3 = val_3;
                if(val_3 != null)
            {
                    if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
                丈丞丕丘丕丗与上一 val_2 = 丈丞丕丘丕丗与上一.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  val_3);
                return (object)val_4;
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = 丙业与丙丗丝不丈东;
            val_8 = 业专丘专七丕丟丅与;
            if(val_7 == null)
            {
                goto label_1;
            }
            
            val_9 = null;
            if(null == val_9)
            {
                goto label_2;
            }
            
            label_1:
            val_7 = ???;
            val_8 = ???;
            goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_278;
            label_2:
            string val_1 = val_7.ToString();
            if(val_8 != 0)
            {
                    return;
            }
        
        }
        public 丈专万丞丏丗丏丞丌()
        {
        
        }
    
    }

}
