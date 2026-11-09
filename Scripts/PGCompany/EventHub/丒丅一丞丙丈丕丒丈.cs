using UnityEngine;

namespace PGCompany.EventHub
{
    internal class 丒丅一丞丙丈丕丒丈 : 丁七丑丝丂丄丅丏丑
    {
        // Methods
        internal 丒丅一丞丙丈丕丒丈(PGCompany.EventHub.丄丟丐丂丌丆万丁丅 不丐专不丒丒上丒业)
        {
        
        }
        internal override UnityEngine.Texture 丞丄与不且丑丂丑丕()
        {
            int val_4;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_4 = 111576;
            if(val_4 != 0)
            {
                goto label_2;
            }
            
            label_1:
            val_4 = System.String.alignConst;
            label_2:
            UnityEngine.Texture val_2 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/car_event_"("OfferIcons/car_event_") + val_4);
            if(val_2 != 0)
            {
                    return val_2;
            }
            
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/car_event_icon_hub_default");
        }
        internal override UnityEngine.Material 丂丐丟与与七丅万丏()
        {
            UnityEngine.Object val_3;
            if(true != 0)
            {
                    val_3 = GameEventsHalper.丄丑与一丁丝丌丁东(丟丟丄专上丟丁丐丝:  111576, 丒丘丏上丙丟丑丕丈:  "bg");
                if(val_3 != 0)
            {
                    return (UnityEngine.Material)val_3;
            }
            
                return GameEventsHalper.丄丑与一丁丝丌丁东(丟丟丄专上丟丁丐丝:  "default_car_event_hub", 丒丘丏上丙丟丑丕丈:  "bg");
            }
            
            val_3 = 0;
            return (UnityEngine.Material)val_3;
        }
        internal override PGCompany.丕万丅丗丏三丙丈丁 丕不丝东一且与东丂()
        {
            .Type = 19;
            return PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌());
        }
        internal override bool 丁丗上丙下三三丐丞()
        {
            string val_7;
            var val_8;
            val_7 = this;
            if(true != 0)
            {
                    val_7 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().不丒七丘丏丆丛上丕(世七七丟丑丁丂与丞:  40);
                bool val_5 = System.String.op_Equality(a:  val_7, b:  val_3.专七东一专丞业丈世);
                val_8 = (Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40)) & val_5;
            }
            
            val_5 = val_8;
            return (bool)val_5;
        }
        internal override string 不丟丐丛万丕丘七丗()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9855");
        }
        internal override string 上丆丙丅不丟丗丌丑()
        {
            string val_2;
            if(true != 0)
            {
                    val_2 = 111576;
                return System.IO.Path.Combine(path1:  "EventContentPresentation", path2:  "ContentPres_Prefabs", path3:  "TempEvent", path4:  "tempevent_" + val_2 + "_presentation");
            }
            
            val_2 = 0;
            return System.IO.Path.Combine(path1:  "EventContentPresentation", path2:  "ContentPres_Prefabs", path3:  "TempEvent", path4:  "tempevent_" + val_2 + "_presentation");
        }
        internal override int 丒与丆三丟三丈丄丄()
        {
            丏一丄丐专丟丂丟丏 val_5;
            var val_6;
            Rilisoft.业丙丘丆东丈丕丂丄 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  Rilisoft.丗下丙丅且丐丞丙世.__il2cppRuntimeField_cctor_finished + 24);
            if((val_2 == null) || (val_2.丁专丗万三上丟三丆() == null))
            {
                goto label_6;
            }
            
            val_5 = val_3.丁丑丅丐丌不世丁下;
            if(val_5 == null)
            {
                goto label_8;
            }
            
            val_5 = 0;
            goto label_8;
            label_6:
            val_5 = 0;
            label_8:
            if(((-677695960) & 1) != 0)
            {
                    int val_4 = val_5.丙东专丂世丈丏丁丂();
                return (int)val_6;
            }
            
            val_6 = 2147483647;
            return (int)val_6;
        }
    
    }

}
