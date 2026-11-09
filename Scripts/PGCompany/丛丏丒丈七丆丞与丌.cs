using UnityEngine;

namespace PGCompany
{
    internal class 丛丏丒丈七丆丞与丌 : 东上丛丂丅下丄七丝
    {
        // Fields
        private UnityEngine.Coroutine 丒丅与丕万丄上世一;
        
        // Methods
        internal override bool 丑上上丟丂丈丛丏丑()
        {
            var val_5;
            MainMenuController val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = null;
            val_5 = null;
            val_6 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_6 != 0)
            {
                    val_7 = null;
                val_7 = null;
                val_6 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_6 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    val_8 = null;
                val_8 = null;
                val_6 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 304];
                val_6 = MainMenuController.丄丞丁丈与业上丞丟.stubLoading;
                val_9 = activeInHierarchy ^ 1;
                return (bool)val_9 & 1;
            }
            
            }
            
            val_9 = 0;
            return (bool)val_9 & 1;
        }
        internal override void 下丌业业丐丘丐丘三()
        {
            MainMenuController.丗丝丗丗丒一丝丑丘(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.丛丏丒丈七丆丞与丌::丟丂丒丑丆丁丛丆丝(bool 东丝丁下丁东且丑业)));
            MainMenuController.三丟丗七三丛丅丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丛丏丒丈七丆丞与丌::丝三丝丆专东丅丞丅()));
            if(this.丒丅与丕万丄上世一 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丒丅与丕万丄上世一);
            }
            
            this.丒丅与丕万丄上世一 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.下一东丒一丟丈七丑());
        }
        internal override void 不与丞下业丑丒丙万()
        {
            MainMenuController.与专业七与丁世一世(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.丛丏丒丈七丆丞与丌::丟丂丒丑丆丁丛丆丝(bool 东丝丁下丁东且丑业)));
            MainMenuController.丙七业丞丁丂丄丏丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丛丏丒丈七丆丞与丌::丝三丝丆专东丅丞丅()));
            if(this.丒丅与丕万丄上世一 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丒丅与丕万丄上世一);
        }
        private System.Collections.IEnumerator 下一东丒一丟丈七丑()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丛丏丒丈七丆丞与丌.丂世业丛下丄丟丙不();
        }
        private void 丝三丝丆专东丅丞丅()
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
        private void 丟丂丒丑丆丁丛丆丝(bool 东丝丁下丁东且丑业)
        {
            if(东丝丁下丁东且丑业 == false)
            {
                    return;
            }
            
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
        public 丛丏丒丈七丆丞与丌()
        {
            val_1 = new System.Object();
        }
    
    }

}
