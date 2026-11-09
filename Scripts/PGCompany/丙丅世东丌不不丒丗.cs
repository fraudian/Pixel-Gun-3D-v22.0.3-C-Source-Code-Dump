using UnityEngine;

namespace PGCompany
{
    internal class 丙丅世东丌不不丒丗 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Player_move_c.丒丟不与丞三且丝丆(丙业与丙丗丝不丈东:  new System.Action<PetInfo>(object:  this, method:  System.Void PGCompany.丙丅世东丌不不丒丗::丑且业七上下丁东业(PetInfo 丆万丂专丂且专三丅)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Player_move_c.业丑万丈丈业丕丕丑(丙业与丙丗丝不丈东:  new System.Action<PetInfo>(object:  this, method:  System.Void PGCompany.丙丅世东丌不不丒丗::丑且业七上下丁东业(PetInfo 丆万丂专丂且专三丅)));
        }
        internal override bool 专下丒丘丞下丟不下(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 丞丁丑丏丄丏七丂不)
        {
            return this.下丄丈万世丁丕丄丌(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不);
        }
        private void 丑且业七上下丁东业(PetInfo 丆万丂专丂且专三丅)
        {
            if(丆万丂专丂且专三丅 == null)
            {
                    return;
            }
            
            if(丆万丂专丂且专三丅.CurrentLevel < (X21 + 56))
            {
                    return;
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
        }
        public 丙丅世东丌不不丒丗()
        {
        
        }
    
    }

}
