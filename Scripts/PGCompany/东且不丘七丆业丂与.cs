using UnityEngine;

namespace PGCompany
{
    internal class 东且不丘七丆业丂与 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            if((this & 1) != 0)
            {
                    this.万丏丛东下丝下丟丕();
                return;
            }
            
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().业丏世丕丕丆丂丒丄(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丁丑三业业丙丐丞丌>(object:  this, method:  System.Void PGCompany.东且不丘七丆业丂与::丌丌万丄丆丄丝世丒(object 不丟丗丏丛丕不丁丌, Rilisoft.丁丑三业业丙丐丞丌 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丛丗一丐丄上丟与丝(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丁丑三业业丙丐丞丌>(object:  this, method:  System.Void PGCompany.东且不丘七丆业丂与::丌丌万丄丆丄丝世丒(object 不丟丗丏丛丕不丁丌, Rilisoft.丁丑三业业丙丐丞丌 丗丛不丁丑专专丂且)));
        }
        private void 丌丌万丄丆丄丝世丒(object 不丟丗丏丛丕不丁丌, Rilisoft.丁丑三业业丙丐丞丌 丗丛不丁丑专专丂且)
        {
            if((X21 + 56.Equals(other:  new UnityEngine.PhysicsScene2D())) != true)
            {
                    if(丗丛不丁丑专专丂且.丈一下下丞世三丑丄() < (X21 + 56))
            {
                    return;
            }
            
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        internal override bool 丑上上丟丂丈丛丏丑()
        {
            var val_8;
            var val_9;
            val_8 = this;
            val_9 = 0;
            if((137130040.Equals(other:  new UnityEngine.PhysicsScene2D())) == true)
            {
                    return (bool)(val_8 >= val_5.丈丈万丐丏与世下丒) ? 1 : 0;
            }
            
            if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null)
            {
                    return (bool)(val_8 >= val_5.丈丈万丐丏与世下丒) ? 1 : 0;
            }
            
            val_8 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().业丈丅丂且丁与丄丂();
            return (bool)(val_8 >= val_5.丈丈万丐丏与世下丒) ? 1 : 0;
        }
        public 东且不丘七丆业丂与()
        {
        
        }
    
    }

}
