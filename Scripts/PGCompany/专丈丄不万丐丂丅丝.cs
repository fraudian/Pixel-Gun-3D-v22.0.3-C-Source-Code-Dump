using UnityEngine;

namespace PGCompany
{
    internal class 专丈丄不万丐丂丅丝 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丟丐一丝三业三上专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丑三丌丘丅丄三下>(object:  this, method:  System.Void PGCompany.专丈丄不万丐丂丅丝::丛万丑业万丌世丞与(object 不丟丗丏丛丕不丁丌, Rilisoft.下丑三丌丘丅丄三下 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙丈万丟丑三丙业一(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丑三丌丘丅丄三下>(object:  this, method:  System.Void PGCompany.专丈丄不万丐丂丅丝::丛万丑业万丌世丞与(object 不丟丗丏丛丕不丁丌, Rilisoft.下丑三丌丘丅丄三下 丗丛不丁丑专专丂且)));
        }
        private void 丛万丑业万丌世丞与(object 不丟丗丏丛丕不丁丌, Rilisoft.下丑三丌丘丅丄三下 丗丛不丁丑专专丂且)
        {
            var val_10;
            var val_11;
            if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
            if(mem[137134216] != 100)
            {
                    if(mem[137134216] != GameConnect.丑丌丛丈丅丅与不业())
            {
                    return;
            }
            
            }
            
            if((mem[137134216] + 600) < 1)
            {
                goto label_9;
            }
            
            val_10 = 丗丛不丁丑专专丂且.三丏丟不丆丅丞不丛();
            val_11 = mem[137134216] + 600;
            goto label_11;
            label_9:
            if((mem[137134216] + 616) < 1)
            {
                goto label_13;
            }
            
            val_10 = 丗丛不丁丑专专丂且.丑丙丐丟丙丒七与丕();
            val_11 = mem[137134216] + 616;
            label_11:
            if(val_10 >= val_11)
            {
                goto label_17;
            }
            
            return;
            label_13:
            if(mem[137134216].InSquad != false)
            {
                    if(丗丛不丁丑专专丂且.丆世一丄丞专丗不东() == false)
            {
                    return;
            }
            
            }
            
            label_17:
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        public 专丈丄不万丐丂丅丝()
        {
        
        }
    
    }

}
