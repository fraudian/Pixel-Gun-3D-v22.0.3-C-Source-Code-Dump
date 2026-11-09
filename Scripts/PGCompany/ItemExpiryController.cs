using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemExpiryController : PGBehaviour
    {
        // Fields
        private static System.Action 丆丙丈丒丗下一丟世;
        private static System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>> 丑东一丄下丟与丄丘;
        private static PGCompany.ItemExpiryController 丝业丆丁业三丈丟东;
        private System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丐丅三丒丅上一丅专;
        private PGCompany.GoblinAutoCollectorController <丂丐万与世业丒世丌>k__BackingField;
        private UnityEngine.Coroutine 丐下丂下丞丗丙丐万;
        private UnityEngine.Coroutine 丙丗专万丒世一与下;
        
        // Properties
        internal static PGCompany.ItemExpiryController 丆丕丝丒不丙且丐丗 { get; }
        internal PGCompany.GoblinAutoCollectorController 世丕丟丒丁丗丏丐丈 { get; set; }
        
        // Methods
        internal static void 东东丆丆丛丟东丑丘(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.ItemExpiryController.丆丙丈丒丗下一丟世, b:  丙业与丙丗丝不丈东);
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
        internal static void 世丘丌丕东丌丈丟丂(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.ItemExpiryController.丆丙丈丒丗下一丟世, value:  丙业与丙丗丝不丈东);
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
        internal static void 丐丐丞丒下丙丟丂万(System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.ItemExpiryController.丑东一丄下丟与丄丘, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.ItemExpiryController.丑东一丄下丟与丄丘 != 1152921505613717512);
        
        }
        internal static void 丙不世丅丐丛万丅且(System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.ItemExpiryController.丑东一丄下丟与丄丘, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.ItemExpiryController.丑东一丄下丟与丄丘 != 1152921505613717512);
        
        }
        internal static PGCompany.ItemExpiryController 丑七不且上丗丁一世()
        {
            PGCompany.ItemExpiryController val_4;
            var val_5;
            val_4 = PGCompany.ItemExpiryController.丝业丆丁业三丈丟东;
            if(val_4 == 0)
            {
                    UnityEngine.GameObject val_2 = null;
                val_4 = val_2;
                val_2 = new UnityEngine.GameObject(name:  "ItemExpiryController [Singleton]");
                val_5 = null;
                PGCompany.ItemExpiryController.丝业丆丁业三丈丟东 = val_2.AddComponent<PGCompany.ItemExpiryController>();
                return (PGCompany.ItemExpiryController)PGCompany.ItemExpiryController.丝业丆丁业三丈丟东;
            }
            
            val_5 = null;
            return (PGCompany.ItemExpiryController)PGCompany.ItemExpiryController.丝业丆丁业三丈丟东;
        }
        internal PGCompany.GoblinAutoCollectorController 一七丁专丂丛丐丈丞()
        {
            return (PGCompany.GoblinAutoCollectorController)this.<丂丐万与世业丒世丌>k__BackingField;
        }
        private void 与丙三丄且丗丑丗上(PGCompany.GoblinAutoCollectorController 丙业与丙丗丝不丈东)
        {
            this.<丂丐万与世业丒世丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void Awake()
        {
            PGCompany.ItemExpiryController.丝业丆丁业三丈丟东 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.丅与丌专丟一丝业三());
            this.丗东丕万丐丑丌丟丗();
            this.<丂丐万与世业丒世丌>k__BackingField = this.丅与丌专丟一丝业三().AddComponent<PGCompany.GoblinAutoCollectorController>();
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ItemExpiryController::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.上专丌丂上业丕丌七.专丌丁世万丟三丘下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ItemExpiryController::丗东丕万丐丑丌丟丗()));
        }
        private void OnDestroy()
        {
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ItemExpiryController::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.上专丌丂上业丕丌七.不丈丘丁丙且丌丒丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ItemExpiryController::丗东丕万丐丑丌丟丗()));
        }
        private void 世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
        {
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丐下丌丘下丝丞业>(丞世不丒下上上丝丑:  丅一丘丙上东丏丅不.一且丟丁上丑业丕且.业东丅东丌上丗丑不())) == null)
            {
                    return;
            }
            
            this.丗东丕万丐丑丌丟丗();
        }
        private void 丗东丕万丐丑丌丟丗()
        {
            if(this.丐下丂下丞丗丙丐万 != null)
            {
                    this.StopCoroutine(routine:  this.丐下丂下丞丗丙丐万);
                this.丐下丂下丞丗丙丐万 = 0;
            }
            
            this.丐下丂下丞丗丙丐万 = this.StartCoroutine(routine:  this.丂一世丏丐丏丂丕丟());
        }
        private System.Collections.IEnumerator 丂一世丏丐丏丂丕丟()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ItemExpiryController.丂丞丒丙不丕丈业万();
        }
        private void 丘丒丘一丝丁丌丐上(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丁丏丒丁下丌丗丐丒)
        {
            object val_13;
            var val_14;
            System.Func<PGCompany.丌丐下丌丘下丝丞业, System.Int64> val_16;
            long val_17;
            if(丁丏丒丁下丌丗丐丒.Count < 1)
            {
                    return;
            }
            
            if(PixelTime.丝丗专上三不丄丑丑() < 1)
            {
                    return;
            }
            
            ItemExpiryController.丈业丗丞丁七下一不 val_3 = null;
            val_13 = val_3;
            val_3 = new ItemExpiryController.丈业丗丞丁七下一不();
            val_14 = null;
            val_14 = null;
            val_16 = ItemExpiryController.<>c.<>9__21_0;
            if(val_16 == null)
            {
                    System.Func<PGCompany.丌丐下丌丘下丝丞业, System.Int64> val_4 = null;
                val_16 = val_4;
                val_4 = new System.Func<PGCompany.丌丐下丌丘下丝丞业, System.Int64>(object:  ItemExpiryController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int64 ItemExpiryController.<>c::一一专丗丁一丑与丝(PGCompany.丌丐下丌丘下丝丞业 三丟东丕丄丄下下丑));
                ItemExpiryController.<>c.<>9__21_0 = val_16;
            }
            
            val_17 = System.Linq.Enumerable.Min<PGCompany.丌丐下丌丘下丝丞业>(source:  丁丏丒丁下丌丗丐丒, selector:  val_4);
            if(val_13 != null)
            {
                    .丅丕七丐七丌业丐不 = val_17;
            }
            else
            {
                    .丅丕七丐七丌业丐不 = val_17;
                val_17 = (ItemExpiryController.丈业丗丞丁七下一不)[1152921555619312000].丅丕七丐七丌业丐不;
            }
            
            float val_8 = UnityEngine.Mathf.Max(a:  0f, b:  (float)val_17 - PixelTime.丝丗专上三不丄丑丑());
            if(val_8 <= 0f)
            {
                    return;
            }
            
            this.丐丅三丒丅上一丅专 = 丁丏丒丁下丌丗丐丒.FindAll(match:  new System.Predicate<PGCompany.丌丐下丌丘下丝丞业>(object:  val_3, method:  System.Boolean ItemExpiryController.丈业丗丞丁七下一不::上丙丝丟丏丌丗丝丌(PGCompany.丌丐下丌丘下丝丞业 三丟东丕丄丄下下丑)));
            this.丙丗专万丒世一与下 = this.StartCoroutine(routine:  this.丂一世丏丐丏丂丕丟(丆丐七丅丆丗丛上与:  val_8));
        }
        private void 与丆丙与丙且专丗丆()
        {
            if(this.丙丗专万丒世一与下 != null)
            {
                    this.StopCoroutine(routine:  this.丙丗专万丒世一与下);
            }
            
            this.丙丗专万丒世一与下 = 0;
        }
        private System.Collections.IEnumerator 丂一世丏丐丏丂丕丟(float 丆丐七丅丆丗丛上与)
        {
            ItemExpiryController.丘丐上丞丁万丟丆不 val_1 = new ItemExpiryController.丘丐上丞丁万丟丆不();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
            return (System.Collections.IEnumerator)val_1;
        }
        public ItemExpiryController()
        {
            this.丐丅三丒丅上一丅专 = new System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>();
        }
    
    }

}
