using UnityEngine;

namespace PGCompany
{
    internal sealed class 丒丛丑丐丈丛不丅丝 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丁丛丟丁一与上丈丆(丙业与丙丗丝不丈东:  new System.EventHandler<ItemRarity>(object:  this, method:  System.Void PGCompany.丒丛丑丐丈丛不丅丝::丘东且业丆丕世丁丘(object 不丟丗丏丛丕不丁丌, ItemRarity 丈下丑丆上丏丗丈专)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().不丄丛丏丂丛丞丕丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丛上三丌丄三下丅>(object:  this, method:  System.Void PGCompany.丒丛丑丐丈丛不丅丝::丐下与丞丟丑且丅丂(object 不丟丗丏丛丕不丁丌, Rilisoft.与丛上三丌丄三下丅 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().东丝三东丄丞丑且丒(丙业与丙丗丝不丈东:  new System.EventHandler<ItemRarity>(object:  this, method:  System.Void PGCompany.丒丛丑丐丈丛不丅丝::丘东且业丆丕世丁丘(object 不丟丗丏丛丕不丁丌, ItemRarity 丈下丑丆上丏丗丈专)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丆丅丘丝三丘七不丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丛上三丌丄三下丅>(object:  this, method:  System.Void PGCompany.丒丛丑丐丈丛不丅丝::丐下与丞丟丑且丅丂(object 不丟丗丏丛丕不丁丌, Rilisoft.与丛上三丌丄三下丅 丗丛不丁丑专专丂且)));
        }
        private void 丐下与丞丟丑且丅丂(object 不丟丗丏丛丕不丁丌, Rilisoft.与丛上三丌丄三下丅 丗丛不丁丑专专丂且)
        {
            var val_9;
            if(PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世() == null)
            {
                    return;
            }
            
            val_9 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世();
            if((val_9.丆与与七丛丁七业丛(丁丅丈丌丟世丗丗丟:  2, 下丅丙一丂丗丅丝七:  丗丛不丁丑专专丂且.业上丙丞丐丄丆丅七())) == false)
            {
                    return;
            }
            
            if((val_9 + 80.Equals(other:  new UnityEngine.PhysicsScene2D())) != true)
            {
                    if(丗丛不丁丑专专丂且.七东与丄丕丁丛世三() < (val_9 + 80))
            {
                    return;
            }
            
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        private void 丘东且业丆丕世丁丘(object 不丟丗丏丛丕不丁丌, ItemRarity 丈下丑丆上丏丗丈专)
        {
            if((X21 + 80.Equals(other:  new UnityEngine.PhysicsScene2D())) != true)
            {
                    if((X21 + 80) > 丈下丑丆上丏丗丈专)
            {
                    return;
            }
            
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        public 丒丛丑丐丈丛不丅丝()
        {
        
        }
    
    }

}
