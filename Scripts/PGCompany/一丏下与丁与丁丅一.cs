using UnityEngine;

namespace PGCompany
{
    internal class 一丏下与丁与丁丅一 : 东上丛丂丅下丄七丝
    {
        // Fields
        private UnityEngine.Coroutine 不丂丂丘且东丙不丒;
        
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            if(this.不丂丂丘且东丙不丒 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.不丂丂丘且东丙不丒);
                this.不丂丂丘且东丙不丒 = 0;
            }
            
            this.不丂丂丘且东丙不丒 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.东丄丛且丄丐下专丗());
        }
        private System.Collections.IEnumerator 东丄丛且丄丐下专丗()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 一丏下与丁与丁丅一.与与丈三丅丏三丛世();
        }
        internal override void 不与丞下业丑丒丙万()
        {
            if(this.不丂丂丘且东丙不丒 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.不丂丂丘且东丙不丒);
            this.不丂丂丘且东丙不丒 = 0;
        }
        public 一丏下与丁与丁丅一()
        {
        
        }
    
    }

}
