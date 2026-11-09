using UnityEngine;

namespace Rilisoft
{
    public class ToggleGroupHalper : MonoBehaviour
    {
        // Fields
        private int _toggleGroup;
        private System.Collections.Generic.Dictionary<UIToggle, EventDelegate> 丈丅丈丈丂专丘丒丝;
        private System.Action<string, bool> 上一丝与七业丛一上;
        
        // Methods
        private void OnEnable()
        {
            var val_4;
            Rilisoft.ToggleGroupHalper val_21;
            var val_22;
            var val_23;
            var val_24;
            object val_25;
            val_21 = this;
            if(this._toggleGroup == 0)
            {
                goto label_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.丈丅丈丈丂专丘丒丝.GetEnumerator();
            val_22 = 1152921543651867424;
            val_23 = 1152921504848912384;
            val_24 = 1152921526228309024;
            label_10:
            if((390389344 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if((val_5._value._obj.丐丏七丌丕丗业且上() == 0) || (val_5._value._obj == 0))
            {
                goto label_10;
            }
            
            bool val_9 = val_5._value._obj.丐丏七丌丕丗业且上().Remove(item:  val_5._value._obj);
            goto label_10;
            label_1:
            val_25 = "toggle group not setted";
            goto label_13;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丈丅丈丈丂专丘丒丝.Clear();
            if(this.GetToggles().Count <= 0)
            {
                goto label_24;
            }
            
            List.Enumerator<T> val_13 = this.GetToggles().GetEnumerator();
            val_22 = 1152921543651895200;
            val_23 = 1152921543651897248;
            val_24 = 1152921505092788224;
            label_35:
            if((390389296 & 1) == 0)
            {
                goto label_26;
            }
            
            string val_14 = val_4.丐丏七丌丕丗业且上();
            if((this.丈丅丈丈丂专丘丒丝.ContainsKey(key:  val_14)) == true)
            {
                goto label_35;
            }
            
            new ToggleGroupHalper.丛与丒丞丁丛上丄丆() = new System.Object();
            .丝且与丝丒丟万丁专 = val_21;
            .丒丘丏上丙丟丑丕丈 = val_14.name;
            new EventDelegate.丒万业丛丏东专世丟() = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  new ToggleGroupHalper.丛与丒丞丁丛上丄丆(), 丛丌丙世专世东丕下:  System.Void ToggleGroupHalper.丛与丒丞丁丛上丄丆::丈丆丙丕丆丝三丌与());
            new EventDelegate() = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟());
            this.丈丅丈丈丂专丘丒丝.Add(key:  val_14, value:  new EventDelegate());
            val_14.Add(item:  new EventDelegate());
            goto label_35;
            label_24:
            val_25 = "toggles not found";
            label_13:
            UnityEngine.Debug.LogError(message:  val_25);
            return;
            label_26:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public System.Collections.Generic.List<UIToggle> GetToggles()
        {
            return System.Linq.Enumerable.ToList<UIToggle>(source:  System.Linq.Enumerable.Where<UIToggle>(source:  this.gameObject.GetComponentsInChildren<UIToggle>(), predicate:  new System.Func<UIToggle, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.ToggleGroupHalper::丏丙万一业丁丞丙上(UIToggle 丙丒七丄上与丏丙丙))));
        }
        public UIToggle GetSelectedToggle()
        {
            var val_3;
            System.Func<UIToggle, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = ToggleGroupHalper.<>c.<>9__4_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<UIToggle>(source:  this.GetToggles(), predicate:  System.Func<UIToggle, System.Boolean> val_2 = null);
            }
            
            val_5 = val_2;
            val_2 = new System.Func<UIToggle, System.Boolean>(object:  ToggleGroupHalper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ToggleGroupHalper.<>c::丌业万丏一丁丕丝丞(UIToggle 丙丒七丄上与丏丙丙));
            ToggleGroupHalper.<>c.<>9__4_0 = val_5;
            return System.Linq.Enumerable.FirstOrDefault<UIToggle>(source:  this.GetToggles(), predicate:  val_2);
        }
        private void 上丅业且丛七丄不丂(string 丒丘丏上丙丟丑丕丈)
        {
            string val_8 = 丒丘丏上丙丟丑丕丈;
            .丒丘丏上丙丟丑丕丈 = val_8;
            if(this.上一丝与七业丛一上 == null)
            {
                    return;
            }
            
            val_8 = System.Linq.Enumerable.FirstOrDefault<UIToggle>(source:  this.GetToggles(), predicate:  new System.Func<UIToggle, System.Boolean>(object:  new ToggleGroupHalper.丞丂万丅不丒丘丟丗(), method:  System.Boolean ToggleGroupHalper.丞丂万丅不丒丘丟丗::万业丈丌一丙丗丝业(UIToggle 丙丒七丄上与丏丙丙)));
            if(val_8 == 0)
            {
                    return;
            }
            
            this.上一丝与七业丛一上.Invoke(arg1:  (ToggleGroupHalper.丞丂万丅不丒丘丟丗)[1152921543652535120].丒丘丏上丙丟丑丕丈, arg2:  val_8.value);
        }
        public void SelectToggle(string 丒丈丄上丂业丙三丁)
        {
            .丒丈丄上丂业丙三丁 = 丒丈丄上丂业丙三丁;
            UIToggle val_4 = System.Linq.Enumerable.FirstOrDefault<UIToggle>(source:  this.GetToggles(), predicate:  new System.Func<UIToggle, System.Boolean>(object:  new ToggleGroupHalper.丘丞上世丗丘丏丐东(), method:  System.Boolean ToggleGroupHalper.丘丞上世丗丘丏丐东::东世丈三下丂与不业(UIToggle 丙丒七丄上与丏丙丙)));
            if(val_4 == 0)
            {
                    return;
            }
            
            if(val_4.value != false)
            {
                    return;
            }
            
            val_4.value = true;
        }
        public void add_OnSelectedToggleChanged(System.Action<string, bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.上一丝与七业丛一上, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上一丝与七业丛一上 != 1152921543652810104);
        
        }
        public void remove_OnSelectedToggleChanged(System.Action<string, bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.上一丝与七业丛一上, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上一丝与七业丛一上 != 1152921543652946680);
        
        }
        public ToggleGroupHalper()
        {
            this.丈丅丈丈丂专丘丒丝 = new System.Collections.Generic.Dictionary<UIToggle, EventDelegate>();
        }
        private bool 丏丙万一业丁丞丙上(UIToggle 丙丒七丄上与丏丙丙)
        {
            return (bool)(丙丒七丄上与丏丙丙.group == this._toggleGroup) ? 1 : 0;
        }
    
    }

}
