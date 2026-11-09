using UnityEngine;

namespace PGCompany.Clans.Parsers
{
    public class 丁丈丂与丈丄业丑丗 : 世与丗丙丁丞七丐上
    {
        // Methods
        protected override 丞丂丘丒丟丞丑下丄 一丅丆丘丁丅丕丁丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            丞丂丘丒丟丞丑下丄 val_20;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = 0;
            System.Collections.Generic.List<System.Object> val_8 = 0;
            System.Collections.Generic.List<System.Object> val_5 = 0;
            System.Collections.Generic.List<System.Object> val_14 = 0;
            System.Collections.Generic.List<System.Object> val_11 = 0;
            System.Collections.Generic.List<System.Object> val_17 = 0;
            val_20 = 0;
            if((PGCompany.Clans.Parsers.丁丈丂与丈丄业丑丗.丅丈丈一丅上丂丑丟(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄)) == false)
            {
                    return (丞丂丘丒丟丞丑下丄)val_20;
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "clan_core", 丙业与丙丗丝不丈东: out  val_2)) != false)
            {
                    val_20 = this.业一丐一丙丌万丙丟(万丟万丟万丂丑丝世:  val_2);
            }
            else
            {
                    val_20 = 0;
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "clan_members", 丙业与丙丗丝不丈东: out  val_5)) != false)
            {
                    val_20 = this.丌丕丐丟万一不丙东(丐丏丘丄七一丆东万:  val_5, 且丟丅丄丒丑丂丁世:  val_20);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "clan_items", 丙业与丙丗丝不丈东: out  val_8)) != false)
            {
                    val_20 = this.丁不丏与丈丐丐丛下(丄丐不丏丁丘不丒丈:  val_8, 且丟丅丄丒丑丂丁世:  val_20);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "clan_field", 丙业与丙丗丝不丈东: out  val_11)) != false)
            {
                    val_20 = this.丝上丏丟丌丒一七丘(一丐丗丁丞丆丅丟丄:  val_11, 且丟丅丄丒丑丂丁世:  val_20);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "clan_field_decor", 丙业与丙丗丝不丈东: out  val_14)) != false)
            {
                    val_20 = this.丏丗丂丂丆业丗业世(一丐丗丁丞丆丅丟丄:  val_14, 且丟丅丄丒丑丂丁世:  val_20);
            }
            
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "clan_tank", 丙业与丙丗丝不丈东: out  val_17)) == false)
            {
                    return (丞丂丘丒丟丞丑下丄)val_20;
            }
            
            val_20 = this.下丁丏三与万丏且丝(一丐丗丁丞丆丅丟丄:  val_17, 且丟丅丄丒丑丂丁世:  val_20);
            return (丞丂丘丒丟丞丑下丄)val_20;
        }
        private static bool 丅丈丈一丅上丂丑丟(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return false;
            }
            
            return 一丐丗丁丞丆丅丟丄.ContainsKey(key:  "clan_core");
        }
        public 丁丈丂与丈丄业丑丗()
        {
        
        }
    
    }

}
