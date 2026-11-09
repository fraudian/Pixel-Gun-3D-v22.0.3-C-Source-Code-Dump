using UnityEngine;

namespace PGCompany.Clans.Parsers
{
    public class 丕丝丘丂丗且丌世丈 : 世与丗丙丁丞七丐上
    {
        // Methods
        protected override 丞丂丘丒丟丞丑下丄 一丅丆丘丁丅丕丁丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_42;
            丞丂丘丒丟丞丑下丄 val_43;
            val_42 = 一丐丗丁丞丆丅丟丄;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = 0;
            System.Collections.Generic.List<System.Object> val_9 = 0;
            System.Collections.Generic.List<System.Object> val_6 = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = 0;
            System.Collections.Generic.List<System.Object> val_12 = 0;
            System.Collections.Generic.List<System.Object> val_21 = 0;
            System.Collections.Generic.List<System.Object> val_18 = 0;
            System.Collections.Generic.List<System.Object> val_27 = 0;
            System.Collections.Generic.List<System.Object> val_24 = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_33 = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_30 = 0;
            System.Collections.Generic.List<System.Object> val_39 = 0;
            System.Collections.Generic.List<System.Object> val_36 = 0;
            val_43 = 0;
            if((PGCompany.Clans.Parsers.丕丝丘丂丗且丌世丈.丅丈丈一丅上丂丑丟(一丐丗丁丞丆丅丟丄:  val_42)) == false)
            {
                    return (丞丂丘丒丟丞丑下丄)val_43;
            }
            
            object val_2 = val_42.Item["clan"];
            val_42 = 0;
            bool val_4 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_core", 丙业与丙丗丝不丈东: out  val_3);
            if(val_4 != false)
            {
                    val_43 = val_4.业一丐一丙丌万丙丟(万丟万丟万丂丑丝世:  val_3);
                if(val_43 == null)
            {
                    return (丞丂丘丒丟丞丑下丄)val_43;
            }
            
                bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_members", 丙业与丙丗丝不丈东: out  val_6);
                if(val_7 != false)
            {
                    val_43 = val_7.丌丕丐丟万一不丙东(丐丏丘丄七一丆东万:  val_6, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_incoming_requests", 丙业与丙丗丝不丈东: out  val_9);
                if(val_10 != false)
            {
                    val_43 = val_10.万丅东丏丘丐丑丟与(丑与丁丄丏丕丗丛丒:  val_9, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_13 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_outcoming_requests", 丙业与丙丗丝不丈东: out  val_12);
                if(val_13 != false)
            {
                    val_43 = val_13.七丞万丆丐丘丁一丒(丛三丆世不丞丈业丟:  val_12, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_16 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_messages", 丙业与丙丗丝不丈东: out  val_15);
                if(val_16 != false)
            {
                    val_43 = val_16.世丅下下东万丕丛不(丅丛丌不丗丏丞丝丌:  val_15, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_19 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_items", 丙业与丙丗丝不丈东: out  val_18);
                if(val_19 != false)
            {
                    val_43 = val_19.丁不丏与丈丐丐丛下(丄丐不丏丁丘不丒丈:  val_18, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_22 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_field", 丙业与丙丗丝不丈东: out  val_21);
                if(val_22 != false)
            {
                    val_43 = val_22.丝上丏丟丌丒一七丘(一丐丗丁丞丆丅丟丄:  val_21, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_25 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_field_decor", 丙业与丙丗丝不丈东: out  val_24);
                if(val_25 != false)
            {
                    val_43 = val_25.丏丗丂丂丆业丗业世(一丐丗丁丞丆丅丟丄:  val_24, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_28 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_tank", 丙业与丙丗丝不丈东: out  val_27);
                if(val_28 != false)
            {
                    val_43 = val_28.下丁丏三与万丏且丝(一丐丗丁丞丆丅丟丄:  val_27, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_31 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_building_levels", 丙业与丙丗丝不丈东: out  val_30);
                if(val_31 != false)
            {
                    val_43 = val_31.业丞丞丂丄丕七丐丞(一丐丗丁丞丆丅丟丄:  val_30, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_34 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_current_upgrades", 丙业与丙丗丝不丈东: out  val_33);
                if(val_34 != false)
            {
                    val_43 = val_34.丗丅丙丐丐丙丁丙下(一丐丗丁丞丆丅丟丄:  val_33, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_37 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "war_marks", 丙业与丙丗丝不丈东: out  val_36);
                if(val_37 != false)
            {
                    val_43 = val_37.丂丗业丌丞上万丙业(一丐丗丁丞丆丅丟丄:  val_36, 且丟丅丄丒丑丂丁世:  val_43);
            }
            
                bool val_40 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "clan_buildings", 丙业与丙丗丝不丈东: out  val_39);
                if(val_40 == false)
            {
                    return (丞丂丘丒丟丞丑下丄)val_43;
            }
            
                val_43 = val_40.丑七丈万丗丞丐丂丑(一丐丗丁丞丆丅丟丄:  val_39, 且丟丅丄丒丑丂丁世:  val_43);
                return (丞丂丘丒丟丞丑下丄)val_43;
            }
            
            val_43 = 0;
            return (丞丂丘丒丟丞丑下丄)val_43;
        }
        private static bool 丅丈丈一丅上丂丑丟(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return false;
            }
            
            return 一丐丗丁丞丆丅丟丄.ContainsKey(key:  "clan");
        }
        public 丕丝丘丂丗且丌世丈()
        {
            val_1 = new System.Object();
        }
    
    }

}
