using UnityEngine;

namespace PGCompany
{
    internal class 丂世丑且丟丌与业下 : JsonConverter
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
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            string val_8;
            var val_9;
            var val_10;
            val_8 = 且丛三下万丂专专业;
            int val_5 = 0;
            if(val_8 != 9)
            {
                goto label_10;
            }
            
            val_9 = val_8;
            char[] val_1 = new char[1];
            val_1[0] = ':';
            if(val_9 == null)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                goto label_8;
            }
            
            val_9 = 0;
            goto label_8;
            label_5:
            label_8:
            val_8 = val_9.Split(separator:  val_1);
            if(val_3.Length >= 2)
            {
                    System.Nullable<T> val_4 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<上七丑业丙丒丙东丏>(下业七不丑丂丏丟东:  val_8[0], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
                val_10 = 0;
                if((7270760 & 1) == 0)
            {
                    return (object)val_10;
            }
            
                val_8 = val_8[1];
                val_10 = 0;
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_8, 丙业与丙丗丝不丈东: out  val_5)) == false)
            {
                    return (object)val_10;
            }
            
                val_8 = val_5;
                PGCompany.三丏不丆丈且丐东与 val_7 = null;
                val_10 = val_7;
                val_7 = new PGCompany.三丏不丆丈且丐东与(三丅丘上丞一丙丑业:  val_4.HasValue, 丙业与丙丗丝不丈东:  0);
                return (object)val_10;
            }
            
            label_10:
            val_10 = 0;
            return (object)val_10;
        }
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public 丂世丑且丟丌与业下()
        {
        
        }
    
    }

}
