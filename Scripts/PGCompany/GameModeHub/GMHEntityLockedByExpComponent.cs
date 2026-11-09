using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class GMHEntityLockedByExpComponent : ViewComponentGMHEntityBase
    {
        // Fields
        private lockedOnProgressUI _progressUI;
        
        // Methods
        public override void Setup(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世)
        {
            mem[1152921560510038888] = 不丕三丌万丈丟丆世;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            UnityEngine.Object val_10;
            var val_11;
            var val_12;
            var val_13;
            UnityEngine.GameObject val_14;
            var val_15;
            val_10 = this;
            val_11 = 1152921504848912384;
            if(this == 0)
            {
                    return;
            }
            
            string val_9 = "locked.exp";
            val_9 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 128.丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  val_9, 丟且丒专下丈七丗丕:  4);
            val_12 = 0;
            if((68753804 & 1) != 0)
            {
                    val_13 = GetValueOrDefault() ^ 1;
            }
            else
            {
                    val_13 = 1;
            }
            
            UnityEngine.GameObject val_4 = this.gameObject;
            if((val_13 & 1) != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
                if(this._progressUI == 0)
            {
                    return;
            }
            
                if(this._progressUI == null)
            {
                    return;
            }
            
                val_10 = this._progressUI.gameObject;
                val_14 = val_10;
                val_15 = 0;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
                if(this._progressUI == 0)
            {
                    return;
            }
            
                this._progressUI.丈且东丑丂且万丒丅(上丕丈丞丌丘丅不与:  1152921504848912384.__il2cppRuntimeField_64);
                val_10 = this._progressUI.gameObject;
                val_15 = 1;
                val_14 = val_10;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  true);
        }
        public GMHEntityLockedByExpComponent()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
