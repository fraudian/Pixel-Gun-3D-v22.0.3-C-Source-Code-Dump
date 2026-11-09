using UnityEngine;

namespace PGCompany
{
    internal class 丁丞三丘丒丄丝世七 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丛丙与世上与业丙东(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丁三下一与丘丈且丗>(object:  this, method:  System.Void PGCompany.丁丞三丘丒丄丝世七::东与丒丘东丐三丆丟(object 不丟丗丏丛丕不丁丌, Rilisoft.丁三下一与丘丈且丗 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().专丕东三丞且七上丌(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.三丈三丂七丝丁丟且>(object:  this, method:  System.Void PGCompany.丁丞三丘丒丄丝世七::七东丕世不丏丆一丗(object 不丟丗丏丛丕不丁丌, Rilisoft.三丈三丂七丝丁丟且 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丘丌丞丙不丝丘丕丄(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丁三下一与丘丈且丗>(object:  this, method:  System.Void PGCompany.丁丞三丘丒丄丝世七::东与丒丘东丐三丆丟(object 不丟丗丏丛丕不丁丌, Rilisoft.丁三下一与丘丈且丗 丗丛不丁丑专专丂且)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丅丐丄丁丕丌丕丘一(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.三丈三丂七丝丁丟且>(object:  this, method:  System.Void PGCompany.丁丞三丘丒丄丝世七::七东丕世不丏丆一丗(object 不丟丗丏丛丕不丁丌, Rilisoft.三丈三丂七丝丁丟且 丗丛不丁丑专专丂且)));
        }
        private void 七东丕世不丏丆一丗(object 不丟丗丏丛丕不丁丌, Rilisoft.三丈三丂七丝丁丟且 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
            Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
            if(static_value_082C2088.InSquad != false)
            {
                    if(丗丛不丁丑专专丂且.丆世一丄丞专丗不东() == false)
            {
                    return;
            }
            
            }
            
            if(丗丛不丁丑专专丂且.PickupSecret == false)
            {
                    return;
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        private void 东与丒丘东丐三丆丟(object 不丟丗丏丛丕不丁丌, Rilisoft.丁三下一与丘丈且丗 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
            Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
            if(static_value_082C2088.InSquad != false)
            {
                    if(丗丛不丁丑专专丂且.丆世一丄丞专丗不东() == false)
            {
                    return;
            }
            
            }
            
            if(static_value_082C2088.PickupAmmo != false)
            {
                    if(丗丛不丁丑专专丂且.世专丟不丅下丐丂丝() > 0f)
            {
                goto label_16;
            }
            
            }
            
            if(static_value_082C2088.PickupHealth != false)
            {
                    if(丗丛不丁丑专专丂且.三丏丟不丆丅丞不丛() > 0f)
            {
                goto label_16;
            }
            
            }
            
            if(static_value_082C2088.PickupArmor == false)
            {
                    return;
            }
            
            if(丗丛不丁丑专专丂且.丑丙丐丟丙丒七与丕() <= 0f)
            {
                    return;
            }
            
            label_16:
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        public 丁丞三丘丒丄丝世七()
        {
        
        }
    
    }

}
