using UnityEngine;

namespace PGCompany
{
    internal class 丑丂丆丘丞丛丟业丅 : 东上丛丂丅下丄七丝
    {
        // Fields
        private UnityEngine.Coroutine 丙丆下丂且不三三丟;
        
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            if(this.丙丆下丂且不三三丟 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丙丆下丂且不三三丟);
            }
            
            this.丙丆下丂且不三三丟 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.东三上世专一业丟丘(丟且丅上丛丁丙丏丈:  0));
        }
        private System.Collections.IEnumerator 东三上世专一业丟丘(PGCompany.丟丟丈丙万丂上与不 丟且丅上丛丁丙丏丈)
        {
            丑丂丆丘丞丛丟业丅.丅东丙丙且上丞丁一 val_1 = new 丑丂丆丘丞丛丟业丅.丅东丙丙且上丞丁一();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丟且丅上丛丁丙丏丈 = 丟且丅上丛丁丙丏丈;
            return (System.Collections.IEnumerator)val_1;
        }
        internal override void 不与丞下业丑丒丙万()
        {
            if(this.丙丆下丂且不三三丟 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丙丆下丂且不三三丟);
            this.丙丆下丂且不三三丟 = 0;
        }
        public 丑丂丆丘丞丛丟业丅()
        {
        
        }
    
    }

}
