using UnityEngine;

namespace PGCompany.EventHub
{
    internal class 丐丗东丂丈不专不一 : 丁七丑丝丂丄丅丏丑
    {
        // Methods
        internal 丐丗东丂丈不专不一(PGCompany.EventHub.丄丟丐丂丌丆万丁丅 不丐专不丒丒上丒业)
        {
        
        }
        internal override UnityEngine.Texture 丞丄与不且丑丂丑丕()
        {
            UnityEngine.Object val_7;
            var val_8;
            val_7 = this;
            if(true != 0)
            {
                    val_7 = 下下丈一业上万丏丕.三丒且世下丛三丅丆(七丆丒与丗丌丄且丂:  "PixelPass", 丒丑丞丁世丌专不丈:  0);
                if(val_7 == 0)
            {
                    val_7 = 下下丈一业上万丏丕.三丒且世下丛三丅丆(七丆丒与丗丌丄且丂:  "PixelPass", 丒丑丞丁世丌专不丈:  "default");
            }
            
                val_8 = 0;
                if(val_7 == 0)
            {
                    return (UnityEngine.Texture)val_8;
            }
            
                UnityEngine.Texture val_6 = 下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.Texture>(东丄丐丞丙不丒东丈:  val_7.万世丆丘丗丅丏万不(丒丘丏上丙丟丑丕丈:  "pixelpass_endseason_robot"));
                return (UnityEngine.Texture)val_8;
            }
            
            val_8 = 0;
            return (UnityEngine.Texture)val_8;
        }
        internal override UnityEngine.Material 丂丐丟与与七丅万丏()
        {
            UnityEngine.Object val_7;
            var val_8;
            val_7 = this;
            if(true != 0)
            {
                    val_7 = 下下丈一业上万丏丕.三丒且世下丛三丅丆(七丆丒与丗丌丄且丂:  "PixelPass", 丒丑丞丁世丌专不丈:  0);
                if(val_7 == 0)
            {
                    val_7 = 下下丈一业上万丏丕.三丒且世下丛三丅丆(七丆丒与丗丌丄且丂:  "PixelPass", 丒丑丞丁世丌专不丈:  "default");
            }
            
                val_8 = 0;
                if(val_7 == 0)
            {
                    return (UnityEngine.Material)val_8;
            }
            
                UnityEngine.Material val_6 = 下下丈一业上万丏丕.丄丙丏万丑且下专丕<UnityEngine.Material>(东丄丐丞丙不丒东丈:  val_7.东业东丗业丞丄专丅(丒丘丏上丙丟丑丕丈:  "pixelpass_main_bg"));
                return (UnityEngine.Material)val_8;
            }
            
            val_8 = 0;
            return (UnityEngine.Material)val_8;
        }
        internal override PGCompany.丕万丅丗丏三丙丈丁 丕不丝东一且与东丂()
        {
            .Type = 22;
            return PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌());
        }
        internal override bool 丁丗上丙下三三丐丞()
        {
            string val_16;
            var val_17;
            val_16 = this;
            if((true == 0) || (PixelTime.丝业丁丌丘东丏世与() == false))
            {
                goto label_15;
            }
            
            PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_3 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            if(val_3 == null)
            {
                goto label_17;
            }
            
            val_16 = val_3.万上丁一丞业业万东().ToString();
            if(((System.String.op_Inequality(a:  val_16, b:  X21 + 24)) != true) && (val_3.丞一丞上丞丞且丐丅() != false))
            {
                    if(val_3.不丆丑与七下一丛丅() != false)
            {
                    if(val_3.丙丛丁世丞丏且丙业() == false)
            {
                goto label_11;
            }
            
            }
            
            }
            
            label_15:
            val_17 = 0;
            label_17:
            val_17 = val_17 & 1;
            return (bool)val_17;
            label_11:
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_11 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_11 != null)
            {
                    if(val_11.丗丄上丑丑丅丐丒丌() != false)
            {
                    if(val_11.丌丈一丘上丕丏东丛() == false)
            {
                goto label_15;
            }
            
            }
            
            }
            
            bool val_15 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  252);
            goto label_17;
        }
        internal override string 不丟丐丛万丕丘七丗()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11700");
        }
        internal override string 上丆丙丅不丟丗丌丑()
        {
            if(X8 == 0)
            {
                    return PGCompany.EventHub.丗且丅丕丒丑丞一丙.业专丈丐丂丟丏丕丂(丗丒下丝专丏丗丆丄:  0);
            }
            
            return PGCompany.EventHub.丗且丅丕丒丑丞一丙.业专丈丐丂丟丏丕丂(丗丒下丝专丏丗丆丄:  X8 + 32);
        }
        internal override int 丒与丆三丟三丈丄丄()
        {
            return 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.pixelpass");
        }
        internal override bool 不世专七丞丘丑一丗()
        {
            var val_6;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                goto label_2;
            }
            
            if(val_2.丗丄上丑丑丅丐丒丌() != false)
            {
                    if(val_2.丌丈一丘上丕丏东丛() == false)
            {
                goto label_5;
            }
            
            }
            
            if(val_2.丗丄上丑丑丅丐丒丌() == false)
            {
                goto label_5;
            }
            
            label_2:
            val_6 = 0;
            return (bool)val_6;
            label_5:
            val_6 = 1;
            return (bool)val_6;
        }
    
    }

}
