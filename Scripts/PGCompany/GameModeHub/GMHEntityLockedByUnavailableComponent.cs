using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class GMHEntityLockedByUnavailableComponent : ViewComponentGMHEntityBase
    {
        // Methods
        public override void Setup(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世)
        {
            mem[1152921560510448616] = 不丕三丌万丈丟丆世;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_5;
            if(this == 0)
            {
                    return;
            }
            
            if((UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 128.丕丌丈三上丌专丙丆(丆万一不丌且东丐丐:  "locked")) == 1)
            {
                    val_5 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 128 + 128.丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  "locked.sub-entities.not-available", 丟且丒专下丈七丗丕:  4);
            }
            else
            {
                    val_5 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  val_5 & 1);
        }
        public GMHEntityLockedByUnavailableComponent()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
