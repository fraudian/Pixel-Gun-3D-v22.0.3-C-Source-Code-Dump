using UnityEngine;

namespace RilisoftBot
{
    internal class FiringShotBot : BaseShootingBot, 上丅丑丞丏丒丕下丙, 丟一丘丛丟丑一且丞, 丙七丟丞丝丅丛丝丝
    {
        // Fields
        private bool 丛业丗丏下丌丏丗丗;
        public float chanceMakeDamage;
        public float timeShowFireEffect;
        public bool checkCanDamagePlayer;
        
        // Properties
        public float 不东不丞丕丑七丙业 { get; set; }
        
        // Methods
        public float get_p_chanceMakeDamage()
        {
            return (float)this.chanceMakeDamage;
        }
        public void set_p_chanceMakeDamage(float 丙业与丙丗丝不丈东)
        {
            this.chanceMakeDamage = 丙业与丙丗丝不丈东;
        }
        private void OnEnable()
        {
            goto label_1;
            label_7:
            mem[137105440].GetComponent<UnityEngine.ParticleSystem>().Stop();
            0 = 1;
            label_1:
            if(0 < 137105408)
            {
                goto label_7;
            }
        
        }
        protected override void 七丌与丂专丈世东丌(int 上七丘丅上丁丅一丅)
        {
            var val_6;
            this.七丌与丂专丈世东丌(上七丘丅上丁丅一丅:  上七丘丅上丁丅一丅);
            if((上七丘丅上丁丅一丅 + 24) == 1)
            {
                    if((上七丘丅上丁丅一丅 + 24) != 0)
            {
                goto label_5;
            }
            
            }
            
            label_5:
            val_6 = 0;
            goto label_6;
            label_22:
            UnityEngine.Transform val_2 = mem[137105440].transform;
            val_2.parent = this.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            val_2.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
            UnityEngine.Transform.__il2cppRuntimeField_byval_arg.GetComponent<UnityEngine.ParticleSystem>().Stop();
            val_6 = 1;
            label_6:
            if(val_6 < null)
            {
                goto label_22;
            }
        
        }
        private UnityEngine.ParticleSystem 丂丘丙万东专丐丕万()
        {
            UnityEngine.GameObject val_1 = this.丝下丘丟丆东丞下丙();
            if(val_1 != null)
            {
                    return val_1.GetComponent<UnityEngine.ParticleSystem>();
            }
            
            return val_1.GetComponent<UnityEngine.ParticleSystem>();
        }
        private System.Collections.IEnumerator 下丆丝世丅世与丁七(UnityEngine.GameObject 丏不丂丆且三丞丆丏)
        {
            FiringShotBot.丒丗不丕业丄丌丌业 val_1 = new FiringShotBot.丒丗不丕业丄丌丌业();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丏不丂丆且三丞丆丏 = 丏不丂丆且三丞丆丏;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 下丆丝世丅世与丁七(UnityEngine.ParticleSystem 丏不丂丆且三丞丆丏)
        {
            FiringShotBot.丟业丄丆丟业丟三三 val_1 = new FiringShotBot.丟业丄丆丟业丟三三();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丏不丂丆且三丞丆丏 = 丏不丂丆且三丞丆丏;
            return (System.Collections.IEnumerator)val_1;
        }
        protected override void 丘丝万三与丂上丆丘()
        {
            if(this.photonView != 0)
            {
                    if(this.photonView.isMine == false)
            {
                goto label_5;
            }
            
            }
            
            this.丘丝万三与丂上丆丘();
            return;
            label_5:
            if((X21 + 24) != 1)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.下丆丝世丅世与丁七(丏不丂丆且三丞丆丏:  this.丂丘丙万东专丐丕万()));
        }
        protected override void 且丝丑丄丝不东丅丗(UnityEngine.Transform 丂丁丟世丗东丙丐丐, UnityEngine.GameObject 丞下万上三丘上与专)
        {
            this.且丝丑丄丝不东丅丗(丂丁丟世丗东丙丐丐:  丂丁丟世丗东丙丐丐, 丞下万上三丘上与专:  丞下万上三丘上与专);
            UnityEngine.ParticleSystem val_1 = this.丂丘丙万东专丐丕万();
            if((X23 + 24) == 1)
            {
                    System.Collections.IEnumerator val_2 = this.下丆丝世丅世与丁七(丏不丂丆且三丞丆丏:  val_1);
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.下丆丝世丅世与丁七(丂丁丟世丗东丙丐丐:  丂丁丟世丗东丙丐丐 = 丂丁丟世丗东丙丐丐, 丏不丂丆且三丞丆丏:  val_1));
            if(this.chanceMakeDamage < UnityEngine.Random.value)
            {
                    return;
            }
            
            if(this.checkCanDamagePlayer != false)
            {
                    if(丂丁丟世丗东丙丐丐.丁不丐丐丄丙万丗丆() == false)
            {
                    return;
            }
            
            }
            
            this.MakeDamage(丞下万上三丘上与专:  丞下万上三丘上与专.transform);
        }
        private System.Collections.IEnumerator 下丆丝世丅世与丁七(UnityEngine.Transform 丂丁丟世丗东丙丐丐, UnityEngine.ParticleSystem 丏不丂丆且三丞丆丏)
        {
            FiringShotBot.丈七丁且丟丘丏丂丅 val_1 = new FiringShotBot.丈七丁且丟丘丏丂丅();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丂丁丟世丗东丙丐丐 = 丂丁丟世丗东丙丐丐;
            }
            else
            {
                    mem[32] = this;
                mem[48] = 丂丁丟世丗东丙丐丐;
            }
            
            .丏不丂丆且三丞丆丏 = 丏不丂丆且三丞丆丏;
            return (System.Collections.IEnumerator)val_1;
        }
        public FiringShotBot()
        {
            mem2[0] = 2139095040;
        }
    
    }

}
