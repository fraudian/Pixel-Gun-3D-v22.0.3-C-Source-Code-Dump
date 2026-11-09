using UnityEngine;

namespace PGCompany.EventHub
{
    internal class 丆丙丟丅下万与丂下 : 丁七丑丝丂丄丅丏丑
    {
        // Methods
        internal 丆丙丟丅下万与丂下(PGCompany.EventHub.丄丟丐丂丌丆万丁丅 不丐专不丒丒上丒业)
        {
        
        }
        internal override UnityEngine.Texture 丞丄与不且丑丂丑丕()
        {
            int val_3;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_3 = 0;
            if(val_3 != 0)
            {
                goto label_2;
            }
            
            label_1:
            val_3 = System.String.alignConst;
            label_2:
            UnityEngine.Texture val_1 = PGCompany.BattlePass.丕一丅且七上丐丘三.Load<UnityEngine.Texture>(丒丘丏上丙丟丑丕丈:  "bp_robot", 丏东丆丆丛丄丕丈丞:  val_3, 丗业三丝丁三丘一丟:  false);
            if(val_1 != 0)
            {
                    return val_1;
            }
            
            return PGCompany.BattlePass.丕一丅且七上丐丘三.Load<UnityEngine.Texture>(丒丘丏上丙丟丑丕丈:  "bp_robot", 丏东丆丆丛丄丕丈丞:  "icon_hub_default", 丗业三丝丁三丘一丟:  false);
        }
        internal override UnityEngine.Material 丂丐丟与与七丅万丏()
        {
            UnityEngine.Object val_4;
            if(true != 0)
            {
                    val_4 = PGCompany.BattlePass.丕一丅且七上丐丘三.Load<UnityEngine.Material>(丒丘丏上丙丟丑丕丈:  "bp_main_bg", 丏东丆丆丛丄丕丈丞:  0, 丗业三丝丁三丘一丟:  false);
                if(val_4 != 0)
            {
                    return (UnityEngine.Material)val_4;
            }
            
                val_4 = PGCompany.BattlePass.丕一丅且七上丐丘三.Load<UnityEngine.Material>(丒丘丏上丙丟丑丕丈:  "bp_bg", 丏东丆丆丛丄丕丈丞:  "hub_default", 丗业三丝丁三丘一丟:  false);
                return (UnityEngine.Material)val_4;
            }
            
            val_4 = 0;
            return (UnityEngine.Material)val_4;
        }
        internal override PGCompany.丕万丅丗丏三丙丈丁 丕不丝东一且与东丂()
        {
            .Type = 20;
            return PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌());
        }
        internal override bool 丁丗上丙下三三丐丞()
        {
            var val_16;
            var val_17;
            if((true == 0) || (PixelTime.丝业丁丌丘东丏世与() == false))
            {
                goto label_20;
            }
            
            val_16 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_16 == null)
            {
                goto label_22;
            }
            
            if((System.String.op_Inequality(a:  val_16.万上丁一丞业业万东().ToString(), b:  X21 + 24)) != true)
            {
                    if(val_16.专丁丟丏丁丏不丗三() != false)
            {
                    if(val_16.丌丈一丘上丕丏东丛() == false)
            {
                goto label_10;
            }
            
            }
            
            }
            
            label_20:
            val_17 = 0;
            label_22:
            val_17 = val_17 & 1;
            return (bool)val_17;
            label_10:
            if(val_16.丗丄上丑丑丅丐丒丌() != false)
            {
                    if(val_16.丌丈一丘上丕丏东丛() == false)
            {
                goto label_20;
            }
            
            }
            
            if((PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == true) || (PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() > 2))
            {
                goto label_22;
            }
            
            if((val_16.丗丄上丑丑丅丐丒丌() == false) || (val_16.丌丈一丘上丕丏东丛() == true))
            {
                goto label_20;
            }
            
            bool val_15 = val_16.丄专世丈丄业专与业();
            goto label_22;
        }
        internal override string 不丟丐丛万丕丘七丗()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9852");
        }
        internal override string 上丆丙丅不丟丗丌丑()
        {
            string val_2;
            if(true != 0)
            {
                    val_2 = 0;
                return System.IO.Path.Combine(path1:  "EventContentPresentation", path2:  "ContentPres_Prefabs", path3:  "BattlePass", path4:  "battlepass_" + val_2 + "_presentation");
            }
            
            val_2 = 0;
            return System.IO.Path.Combine(path1:  "EventContentPresentation", path2:  "ContentPres_Prefabs", path3:  "BattlePass", path4:  "battlepass_" + val_2 + "_presentation");
        }
        internal override int 丒与丆三丟三丈丄丄()
        {
            return 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.battlepass");
        }
    
    }

}
