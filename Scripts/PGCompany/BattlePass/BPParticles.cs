using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPParticles : MonoBehaviour
    {
        // Fields
        private PGCompany.BattlePass.BPParticles.丒三丝一上丙专丗丒 _type;
        private UnityEngine.Coroutine 丐丁丆丈丁世丁上丙;
        private ParticleAtraktor 丐丟业丕且且三且丁;
        private UnityEngine.GameObject 丘下且世业三丄丒三;
        
        // Methods
        private System.Collections.IEnumerator Start()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BPParticles.丝下丐三且丗丏丛丅();
        }
        internal void 丌丄丏下七丁专丂世()
        {
            if(this.丐丁丆丈丁世丁上丙 != null)
            {
                    this.StopCoroutine(routine:  this.丐丁丆丈丁世丁上丙);
                this.丐丁丆丈丁世丁上丙 = 0;
            }
            
            if(this.丘下且世业三丄丒三 == 0)
            {
                    return;
            }
            
            if(this.丘下且世业三丄丒三.activeSelf == false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丘下且世业三丄丒三, 丏业丟一东丂东丘丛:  false);
        }
        internal void 三且世三丂七丐一丟(UnityEngine.Vector3 丈万丏丈上丑不丅上, UnityEngine.Transform 丞下万上三丘上与专, int 丄万不且丂丛丘业丐)
        {
            UnityEngine.Transform val_5 = 丞下万上三丘上与专;
            if(this.丐丟业丕且且三且丁 == 0)
            {
                    return;
            }
            
            this.丌丄丏下七丁专丂世();
            this.丐丟业丕且且三且丁.target = val_5;
            val_5 = this.丘下且世业三丄丒三.transform;
            val_5.position = new UnityEngine.Vector3() {x = 丈万丏丈上丑不丅上.x, y = 丈万丏丈上丑不丅上.y, z = 丈万丏丈上丑不丅上.z};
            this.丐丁丆丈丁世丁上丙 = this.StartCoroutine(routine:  this.东七万一丞丗丁且下(丂丁东一丕与下丟不:  丄万不且丂丛丘业丐));
        }
        private System.Collections.IEnumerator 东七万一丞丗丁且下(int 丂丁东一丕与下丟不)
        {
            BPParticles.丝丗与不丁丘丙下丗 val_1 = new BPParticles.丝丗与不丁丘丙下丗();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丂丁东一丕与下丟不 = 丂丁东一丕与下丟不;
            return (System.Collections.IEnumerator)val_1;
        }
        private void OnDisable()
        {
            this.丌丄丏下七丁专丂世();
        }
        public BPParticles()
        {
        
        }
    
    }

}
