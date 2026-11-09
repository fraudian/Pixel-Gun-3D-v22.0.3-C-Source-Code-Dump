using UnityEngine;

namespace PGCompany
{
    internal class 业丕丐万下丏丘下丕 : 东上丛丂丅下丄七丝
    {
        // Fields
        private UnityEngine.Coroutine 丟丆丞丟丙丐丅丁丄;
        
        // Methods
        internal override bool 丑上上丟丂丈丛丏丑()
        {
            MainMenuController val_5;
            var val_6;
            var val_7;
            var val_8;
            if(ConnectScene.丈丘丂丙不丛业丟三() != false)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_5 != 0)
            {
                    val_7 = null;
                val_7 = null;
                val_5 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 304];
                val_5 = MainMenuController.丄丞丁丈与业上丞丟.stubLoading;
                val_8 = activeInHierarchy ^ 1;
                return (bool)val_8 & 1;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8 & 1;
        }
        internal override void 下丌业业丐丘丐丘三()
        {
            if(this.丟丆丞丟丙丐丅丁丄 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丟丆丞丟丙丐丅丁丄);
            }
            
            this.丟丆丞丟丙丐丅丁丄 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丅丘丐三七丕业丒一());
        }
        internal override void 不与丞下业丑丒丙万()
        {
            if(this.丟丆丞丟丙丐丅丁丄 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丟丆丞丟丙丐丅丁丄);
        }
        private System.Collections.IEnumerator 丅丘丐三七丕业丒一()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 业丕丐万下丏丘下丕.丝业丏丑不一丄三下();
        }
        public 业丕丐万下丏丘下丕()
        {
            val_1 = new System.Object();
        }
    
    }

}
