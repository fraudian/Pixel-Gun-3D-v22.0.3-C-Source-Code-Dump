using UnityEngine;

namespace PGCompany
{
    internal sealed class BuffController : PGBehaviour
    {
        // Fields
        private static System.Action 丞丑与丏丏丄丂且丘;
        private static PGCompany.BuffController 丝业丆丁业三丈丟东;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.BuffData> 丄丕业不丂不丏丆丂;
        private readonly System.Collections.Generic.Dictionary<上七丑业丙丒丙东丏, int> 世丂丁且丁丂丐与丁;
        private UnityEngine.Coroutine 丒丁丆丕且东丂三丆;
        
        // Properties
        internal static PGCompany.BuffController 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static void 丅丕万丝世丒专下专(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.BuffController.丞丑与丏丏丄丂且丘, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 一不丐丘业丘丐上丘(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.BuffController.丞丑与丏丏丄丂且丘, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static PGCompany.BuffController 丑七不且上丗丁一世()
        {
            PGCompany.BuffController val_4;
            var val_5;
            val_4 = PGCompany.BuffController.丝业丆丁业三丈丟东;
            if(val_4 == 0)
            {
                    UnityEngine.GameObject val_2 = null;
                val_4 = val_2;
                val_2 = new UnityEngine.GameObject(name:  "BuffController [Singleton]");
                val_5 = null;
                PGCompany.BuffController.丝业丆丁业三丈丟东 = val_2.AddComponent<PGCompany.BuffController>();
                return (PGCompany.BuffController)PGCompany.BuffController.丝业丆丁业三丈丟东;
            }
            
            val_5 = null;
            return (PGCompany.BuffController)PGCompany.BuffController.丝业丆丁业三丈丟东;
        }
        private void Awake()
        {
            PGCompany.BuffController.丝业丆丁业三丈丟东 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.丅与丌专丟一丝业三());
            this.三七丒丗丑与不丈丄();
            PGCompany.ClanStoreBuffsController.上一七与东丘丘丕上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BuffController::业下专丈三丕丕丛丐()));
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.BuffController::丁与丗七丆丘下丒三(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.上专丌丂上业丕丌七.专丌丁世万丟三丘下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BuffController::七丙丏丙丌丐丅且丗()));
            PGCompany.ItemExpiryController.丐丐丞丒下丙丟丂万(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.BuffController::下丙丗丏丝丛丄专丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞)));
        }
        private void OnDestroy()
        {
            PGCompany.ClanStoreBuffsController.世丐丘七丄一一一丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BuffController::业下专丈三丕丕丛丐()));
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.BuffController::丁与丗七丆丘下丒三(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.上专丌丂上业丕丌七.不丈丘丁丙且丌丒丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BuffController::七丙丏丙丌丐丅且丗()));
            PGCompany.ItemExpiryController.丙不世丅丐丛万丅且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.BuffController::下丙丗丏丝丛丄专丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞)));
        }
        internal PGCompany.BuffData 丁丈丑丝丟丞一丌不(int 丆专且丕专丗与一丏)
        {
            var val_3;
            if((this.丄丕业不丂不丏丆丂.ContainsKey(key:  丆专且丕专丗与一丏)) != false)
            {
                    PGCompany.BuffData val_2 = this.丄丕业不丂不丏丆丂.Item[丆专且丕专丗与一丏];
                return (PGCompany.BuffData)val_3;
            }
            
            val_3 = 0;
            return (PGCompany.BuffData)val_3;
        }
        internal int 丅业专丏不丒丄丐一(上七丑业丙丒丙东丏 丒与丏丛且万丘业丆)
        {
            if((this.世丂丁且丁丂丐与丁.ContainsKey(key:  丒与丏丛且万丘业丆)) == false)
            {
                    return 0;
            }
            
            if(this.世丂丁且丁丂丐与丁 != null)
            {
                    return this.世丂丁且丁丂丐与丁.Item[丒与丏丛且万丘业丆];
            }
            
            return this.世丂丁且丁丂丐与丁.Item[丒与丏丛且万丘业丆];
        }
        internal System.Collections.Generic.List<PGCompany.上丙业丕丟与七专丁> 丈上丗丞世丏丄丞下(上七丑业丙丒丙东丏 丒与丏丛且万丘业丆)
        {
            .丒与丏丛且万丘业丆 = 丒与丏丛且万丘业丆;
            System.Collections.Generic.List<PGCompany.上丙业丕丟与七专丁> val_2 = PGCompany.BuffController.丆丆丒下与世上一不();
            if(val_2 != null)
            {
                    return val_2.FindAll(match:  new System.Predicate<PGCompany.上丙业丕丟与七专丁>(object:  new BuffController.丒丛丁与丅东丒不七(), method:  System.Boolean BuffController.丒丛丁与丅东丒不七::丞丏万丝上丝三丁丌(PGCompany.上丙业丕丟与七专丁 丌丗丏丏丛东专丁且)));
            }
            
            return val_2.FindAll(match:  new System.Predicate<PGCompany.上丙业丕丟与七专丁>(object:  new BuffController.丒丛丁与丅东丒不七(), method:  System.Boolean BuffController.丒丛丁与丅东丒不七::丞丏万丝上丝三丁丌(PGCompany.上丙业丕丟与七专丁 丌丗丏丏丛东专丁且)));
        }
        private void 三七丒丗丑与不丈丄()
        {
            this.丄丕业不丂不丏丆丂.Clear();
            PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世().业丞丌丐丙东丁上不().ForEach(action:  new System.Action<PGCompany.BuffData>(object:  this, method:  System.Void PGCompany.BuffController::东丑万上一丌专世一(PGCompany.BuffData 三丟东丕丄丄下下丑)));
        }
        private void 业下专丈三丕丕丛丐()
        {
            this.三七丒丗丑与不丈丄();
            this.七丙丏丙丌丐丅且丗();
        }
        private void 丁与丗七丆丘下丒三(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
        {
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.上丙业丕丟与七专丁>(丞世不丒下上上丝丑:  丅一丘丙上东丏丅不.一且丟丁上丑业丕且.业东丅东丌上丗丑不())) == null)
            {
                    return;
            }
            
            this.七丙丏丙丌丐丅且丗();
        }
        private void 七丙丏丙丌丐丅且丗()
        {
            if(this.丒丁丆丕且东丂三丆 != null)
            {
                    this.StopCoroutine(routine:  this.丒丁丆丕且东丂三丆);
                this.丒丁丆丕且东丂三丆 = 0;
            }
            
            this.丒丁丆丕且东丂三丆 = this.StartCoroutine(routine:  this.上丞上丄丆丏上下丁());
        }
        private System.Collections.IEnumerator 上丞上丄丆丏上下丁()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BuffController.丈丂丌上世与丆万丟();
        }
        private void 下丙丗丏丝丛丄专丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞)
        {
            var val_3 = null;
            if((BuffController.<>c.<>9__19_0) == null)
            {
                goto label_3;
            }
            
            label_9:
            if((丑七不与丛丆一丂丞.Exists(match:  BuffController.<>c.<>9__19_0)) == false)
            {
                    return;
            }
            
            this.七丙丏丙丌丐丅且丗();
            return;
            label_3:
            BuffController.<>c.<>9__19_0 = new System.Predicate<PGCompany.丌丐下丌丘下丝丞业>(object:  BuffController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BuffController.<>c::丕万丙一丟七丒丐丒(PGCompany.丌丐下丌丘下丝丞业 三丟东丕丄丄下下丑));
            if(丑七不与丛丆一丂丞 != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        public static void RemoveAllBuffs()
        {
        
        }
        private static System.Collections.Generic.List<PGCompany.上丙业丕丟与七专丁> 丆丆丒下与世上一不()
        {
            return (System.Collections.Generic.List<PGCompany.上丙业丕丟与七专丁>)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂<PGCompany.上丙业丕丟与七专丁>(丁丅丈丌丟世丗丗丟:  40, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        public BuffController()
        {
            this.丄丕业不丂不丏丆丂 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.BuffData>();
            this.世丂丁且丁丂丐与丁 = new System.Collections.Generic.Dictionary<上七丑业丙丒丙东丏, System.Int32>();
        }
        private void 东丑万上一丌专世一(PGCompany.BuffData 三丟东丕丄丄下下丑)
        {
            this.丄丕业不丂不丏丆丂.set_Item(key:  三丟东丕丄丄下下丑._indexContainer, value:  三丟东丕丄丄下下丑);
        }
    
    }

}
