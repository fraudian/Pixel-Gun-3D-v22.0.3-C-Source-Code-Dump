using UnityEngine;

namespace PGCompany
{
    internal abstract class 丟丟丈丙万丂上与不 : 上与上一万丌丆丝世
    {
        // Fields
        protected static readonly string 世丒业丂一上丆一东;
        protected System.Func<ConnectScene> 专业丕丙丟一丗丂丏;
        protected bool 业丁世与丘丗三丅专;
        private UnityEngine.GameObject 丂丂七丂丝丆丂丈丘;
        private UnityEngine.Coroutine 丅下丈丝丐且丐丐且;
        private static readonly int 一且丘七业丘东下丄;
        private bool <丌丄一且且业丘不三>k__BackingField;
        
        // Properties
        internal bool 丅丂丟丅丆专丐丞东 { get; set; }
        
        // Methods
        internal bool 丂丒丌不不丛丞丁一()
        {
            return (bool)this.<丌丄一且且业丘不三>k__BackingField;
        }
        private void 专上丑东丏丘丈丒丏(bool 丙业与丙丗丝不丈东)
        {
            this.<丌丄一且且业丘不三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected 丟丟丈丙万丂上与不(string 丏万且丈丙丁丁且世, string 丛丄业丕且丗下一万)
        {
        
        }
        protected abstract UnityEngine.Transform 丟七丏丕丆七下专与(); // 0
        protected abstract UnityEngine.Transform 丄七丙丅专丈不丈东(); // 0
        protected virtual UnityEngine.Vector3 世一万丗世丈丈丂丘()
        {
            return UnityEngine.Vector3.zero;
        }
        protected virtual UnityEngine.Vector3 丁东丗丂丐丅丈业丄()
        {
            return UnityEngine.Vector3.zero;
        }
        protected override void 下与丞三丅丛丄七丕(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            UnityEngine.GameObject val_3 = 0;
            this.下与丞三丅丛丄七丕(丛丑业万丗丝丒三丗:  丛丑业万丗丝丒三丗);
            bool val_4 = TryGetValue(key:  丛丑业万丗丝丒三丗.gameObject.GetInstanceID(), value: out  val_3);
            this.丂丂七丂丝丆丂丈丘 = val_3;
            if(val_3 == 0)
            {
                    return;
            }
            
            this.丅下丈丝丐且丐丐且 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丒丛丂丕丞丑丁丂且());
        }
        protected override void 丆世与丑丆丅丐万且(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            this.丆世与丑丆丅丐万且(丛丑业万丗丝丒三丗:  丛丑业万丗丝丒三丗);
            if(this.丅下丈丝丐且丐丐且 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丅下丈丝丐且丐丐且);
            this.丅下丈丝丐且丐丐且 = 0;
        }
        private System.Collections.IEnumerator 丒丛丂丕丞丑丁丂且()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丟丟丈丙万丂上与不.丅丑丑三丄与丘丐丙();
        }
        private static 丟丟丈丙万丂上与不()
        {
            null = null;
            PGCompany.丟丟丈丙万丂上与不.世丒业丂一上丆一东 = System.IO.Path.Combine(path1:  PGCompany.丈丌上丑丌上丅七东.且专三丁丐世丞丅丕, path2:  PGCompany.丈丌上丑丌上丅七东.丕且丈与丑丆上丞丐);
            PGCompany.丟丟丈丙万丂上与不.一且丘七业丘东下丄 = UnityEngine.Animator.StringToHash(name:  "touch");
        }
    
    }

}
