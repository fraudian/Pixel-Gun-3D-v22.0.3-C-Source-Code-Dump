using UnityEngine;

namespace PGCompany
{
    public class 丑上业丟丙专世下下 : JsonConverter
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
            var val_7;
            if(且丛三下万丂专专业 != 7)
            {
                    if(且丛三下万丂专专业 == 9)
            {
                    val_6 = 且丛三下万丂专专业;
                if(val_6 != null)
            {
                    if(null != null)
            {
                    val_6 = 0;
            }
            
            }
            
                Rilisoft.OfferItem val_2 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_6);
                if(val_2 != null)
            {
                    val_7 = val_2.ItemParams;
                return (object)val_7;
            }
            
            }
            
                val_7 = 0;
                return (object)val_7;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_5 = null;
            val_7 = val_5;
            val_5 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  System.Convert.ToInt32(value:  且丛三下万丂专专业));
            return (object)val_7;
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            PGCompany.三东丏不丗世丅丌丄 val_7;
            var val_8;
            val_7 = 丙业与丙丗丝不丈东;
            val_8 = 业专丘专七丕丟丅与;
            val_7 = ???;
            val_8 = ???;
            goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_278;
        }
        public 丑上业丟丙专世下下()
        {
        
        }
    
    }

}
