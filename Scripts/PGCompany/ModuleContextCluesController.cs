using UnityEngine;

namespace PGCompany
{
    internal class ModuleContextCluesController : MonoBehaviour
    {
        // Fields
        private static System.Action 丞一世丕丌丒不三东;
        private System.Collections.Generic.List<PGCompany.ModuleContextCluesBase> 丟东丁东下且丁一三;
        private System.Collections.Generic.List<PGCompany.ModuleContextCluesScreen> 与丗丕丐世且丞丅一;
        
        // Methods
        internal static void 丟丒丌丂丙一丅丆丙(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.ModuleContextCluesController.丞一世丕丌丒不三东, b:  丙业与丙丗丝不丈东);
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
        internal static void 专丗上丛专丌上丆丈(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.ModuleContextCluesController.丞一世丕丌丒不三东, value:  丙业与丙丗丝不丈东);
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
        private void Awake()
        {
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<PGCompany.ModuleContextCluesBase>(source:  this.GetComponents<PGCompany.ModuleContextCluesBase>());
            this.丟东丁东下且丁一三 = val_2;
            val_2.ForEach(action:  new System.Action<PGCompany.ModuleContextCluesBase>(object:  this, method:  System.Void PGCompany.ModuleContextCluesController::业丑丄丂一七丝丝丞(PGCompany.ModuleContextCluesBase 三丟东丕丄丄下下丑)));
            this.与丗丕丐世且丞丅一 = System.Linq.Enumerable.ToList<PGCompany.ModuleContextCluesScreen>(source:  this.GetComponentsInChildren<PGCompany.ModuleContextCluesScreen>(includeInactive:  true));
        }
        internal bool 三专七与丟丐丝不丁()
        {
            var val_2 = null;
            if((ModuleContextCluesController.<>c.<>9__6_0) != null)
            {
                    if(this.与丗丕丐世且丞丅一 == null)
            {
                    return this.与丗丕丐世且丞丅一.Exists(match:  ModuleContextCluesController.<>c.<>9__6_0);
            }
            
                return this.与丗丕丐世且丞丅一.Exists(match:  ModuleContextCluesController.<>c.<>9__6_0);
            }
            
            ModuleContextCluesController.<>c.<>9__6_0 = new System.Predicate<PGCompany.ModuleContextCluesScreen>(object:  ModuleContextCluesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModuleContextCluesController.<>c::丛与三丘下丌七世丁(PGCompany.ModuleContextCluesScreen 三丟东丕丄丄下下丑));
            if(this.与丗丕丐世且丞丅一 != null)
            {
                    return this.与丗丕丐世且丞丅一.Exists(match:  ModuleContextCluesController.<>c.<>9__6_0);
            }
            
            return this.与丗丕丐世且丞丅一.Exists(match:  ModuleContextCluesController.<>c.<>9__6_0);
        }
        private void OnEnable()
        {
            var val_2 = null;
            if((ModuleContextCluesController.<>c.<>9__7_0) == null)
            {
                goto label_3;
            }
            
            label_8:
            this.丟东丁东下且丁一三.ForEach(action:  ModuleContextCluesController.<>c.<>9__7_0);
            return;
            label_3:
            ModuleContextCluesController.<>c.<>9__7_0 = new System.Action<PGCompany.ModuleContextCluesBase>(object:  ModuleContextCluesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ModuleContextCluesController.<>c::丈丌丗丟丐丝上且丕(PGCompany.ModuleContextCluesBase 三丟东丕丄丄下下丑));
            if(this.丟东丁东下且丁一三 != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        private void OnDisable()
        {
            var val_2 = null;
            if((ModuleContextCluesController.<>c.<>9__8_0) == null)
            {
                goto label_3;
            }
            
            label_8:
            this.丟东丁东下且丁一三.ForEach(action:  ModuleContextCluesController.<>c.<>9__8_0);
            return;
            label_3:
            ModuleContextCluesController.<>c.<>9__8_0 = new System.Action<PGCompany.ModuleContextCluesBase>(object:  ModuleContextCluesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ModuleContextCluesController.<>c::丆丑业丂上丞不业丘(PGCompany.ModuleContextCluesBase 三丟东丕丄丄下下丑));
            if(this.丟东丁东下且丁一三 != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        public ModuleContextCluesController()
        {
            this.丟东丁东下且丁一三 = new System.Collections.Generic.List<PGCompany.ModuleContextCluesBase>();
            this.与丗丕丐世且丞丅一 = new System.Collections.Generic.List<PGCompany.ModuleContextCluesScreen>();
        }
        private void 业丑丄丂一七丝丝丞(PGCompany.ModuleContextCluesBase 三丟东丕丄丄下下丑)
        {
            三丟东丕丄丄下下丑.<丈丄丄七下专丞与丛>k__BackingField = this;
        }
    
    }

}
