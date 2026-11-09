using UnityEngine;

namespace Rilisoft
{
    public class PetEffectHandler : PGBehaviour
    {
        // Fields
        private UnityEngine.Transform 专专丏下丐丂丂丅东;
        private float 丏一上东丗丘三丂世;
        public UnityEngine.Events.UnityEvent OnEffectCompleted;
        public float WaitTime;
        
        // Properties
        internal bool 丑丄业丁且丅丘且世 { get; }
        
        // Methods
        internal bool 东专东一东七与且丆()
        {
            UnityEngine.GameObject val_1 = this.丅与丌专丟一丝业三();
            if(val_1 != null)
            {
                    return val_1.activeInHierarchy;
            }
            
            return val_1.activeInHierarchy;
        }
        private void OnEnable()
        {
            this.专专丏下丐丂丂丅东 = this.transform;
            this.丏一上东丗丘三丂世 = 0f;
        }
        private void OnDisable()
        {
            this.OnEffectCompleted.Invoke();
        }
        private void Update()
        {
            UnityEngine.Quaternion val_1 = this.专专丏下丐丂丂丅东.rotation;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.专专丏下丐丂丂丅东.rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
            float val_3 = UnityEngine.Time.deltaTime;
            val_3 = this.丏一上东丗丘三丂世 + val_3;
            this.丏一上东丗丘三丂世 = val_3;
            if(val_3 < this.WaitTime)
            {
                    return;
            }
            
            this = this.丅与丌专丟一丝业三();
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this, 丏业丟一东丂东丘丛:  false);
        }
        internal void 三且世三丂七丐一丟()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
        }
        public PetEffectHandler()
        {
            this.WaitTime = 1f;
        }
    
    }

}
