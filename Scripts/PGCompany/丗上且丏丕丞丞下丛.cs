using UnityEngine;

namespace PGCompany
{
    internal class 丗上且丏丕丞丞下丛 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            if((this & 1) != 0)
            {
                    this.万丏丛东下丝下丟丕();
                return;
            }
            
            PGCompany.Clans.Network.东一丟丁丄丛丞与世.丄丄专丑丝专万丌丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丗上且丏丕丞丞下丛::不丑丂丟且丗丒丐世()));
            PGCompany.Clans.Network.丂丏万丙丟世与丄丟.丛丗三业下丑丑丈与(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, System.String>(object:  this, method:  System.Void PGCompany.丗上且丏丕丞丞下丛::丕丑丒丛业下丝世丒(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            PGCompany.Clans.Network.东一丟丁丄丛丞与世.丅业丏上丆上丐丄与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丗上且丏丕丞丞下丛::不丑丂丟且丗丒丐世()));
            PGCompany.Clans.Network.丂丏万丙丟世与丄丟.不专丑丛丌丕一丘丏(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, System.String>(object:  this, method:  System.Void PGCompany.丗上且丏丕丞丞下丛::丕丑丒丛业下丝世丒(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)));
        }
        internal override bool 丑上上丟丂丈丛丏丑()
        {
            UnityEngine.Object val_6;
            var val_7;
            val_6 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_6 != 0)
            {
                    val_6 = Rilisoft.Singleton<ClansController>.Instance;
                var val_5 = (val_6.丞丗丑丈一丅丗丌丟() != 0) ? 1 : 0;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        private void 不丑丂丟且丗丒丐世()
        {
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        private void 丕丑丒丛业下丝世丒(string 丄丒下业一不丈丝丘, string 专下不丘丘丝丅七三, string 丅丈丛丅丝东七丂且)
        {
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        public 丗上且丏丕丞丞下丛()
        {
        
        }
    
    }

}
