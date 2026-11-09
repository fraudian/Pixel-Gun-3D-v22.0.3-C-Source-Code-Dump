using UnityEngine;

namespace PGCompany
{
    internal sealed class 丄丆丗丞世丘丆与专 : 丑与一丄丒东丝丏丏
    {
        // Methods
        internal override bool 丌丆不不东丅丟万东(int 丆专且丕专丗与一丏)
        {
            var val_14;
            var val_15;
            丄丆丗丞世丘丆与专.丞上丕丈丒丘丆三丈 val_1 = new 丄丆丗丞世丘丆与专.丞上丕丈丒丘丆三丈();
            .丆专且丕专丗与一丏 = 丆专且丕专丗与一丏;
            if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丈万丙东东丒丏丆丝() == false)
            {
                goto label_3;
            }
            
            PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_5 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            val_14 = val_5.丆丒丗丝丂东丈丏丒();
            if((val_14.Exists(match:  new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  val_1, method:  System.Boolean 丄丆丗丞世丘丆与专.丞上丕丈丒丘丆三丈::与东丙丗丞业丏丑七(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七)))) == true)
            {
                goto label_7;
            }
            
            val_14 = val_5.丒东丒上世丘一丗丈();
            if((val_14.Exists(match:  new System.Predicate<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  val_1, method:  System.Boolean 丄丆丗丞世丘丆与专.丞上丕丈丒丘丆三丈::丕丞丕丞万丁丌丈七(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘)))) == false)
            {
                goto label_10;
            }
            
            label_7:
            val_15 = 1;
            return (bool)val_15;
            label_3:
            val_15 = 0;
            return (bool)val_15;
            label_10:
            System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_12 = val_5.与丑丛下且专七万丄();
            if(val_12 != null)
            {
                    return val_12.Exists(match:  new System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  val_1, method:  System.Boolean 丄丆丗丞世丘丆与专.丞上丕丈丒丘丆三丈::丕丟丂与丅丗丄丁上(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)));
            }
            
            return val_12.Exists(match:  new System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  val_1, method:  System.Boolean 丄丆丗丞世丘丆与专.丞上丕丈丒丘丆三丈::丕丟丂与丅丗丄丁上(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)));
        }
        public 丄丆丗丞世丘丆与专()
        {
        
        }
    
    }

}
