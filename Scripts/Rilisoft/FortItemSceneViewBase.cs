using UnityEngine;

namespace Rilisoft
{
    public abstract class FortItemSceneViewBase : MonoBehaviour, 丕丂丒丁丏东且一七
    {
        // Fields
        private static UnityEngine.Material 三丅专一万丝且丆七;
        protected Rilisoft.FortCraftController 业专万丏丘丙丝一丕;
        private System.Collections.Generic.List<UnityEngine.GameObject> _disableIfCrafting;
        private bool 丏丈丞丙七丛东七丌;
        private Rilisoft.东且东丒丐世丐丞丒 丐丙丒丈丄不一丈与;
        private 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丆丐专丘丅万丂丐不;
        protected System.Collections.Generic.Dictionary<UnityEngine.Renderer, UnityEngine.Material[]> 丕丆下下丙丝丝丙丄;
        private System.Nullable<bool> <丛丗丈丟丘与万上且>k__BackingField;
        private System.Collections.Generic.List<UnityEngine.Renderer> <三丌万业万丟丕丄七>k__BackingField;
        private bool <不丁丝丈丙丄丂丐下>k__BackingField;
        
        // Properties
        protected abstract UnityEngine.GameObject 丘三业丒世丘世丞丟 { get; }
        protected System.Nullable<bool> 业丘三三世一下万丕 { get; set; }
        protected System.Collections.Generic.List<UnityEngine.Renderer> 丘丒丑丗丑下丁三世 { get; set; }
        private static UnityEngine.Material 丌丝丘丝东专丏世丙 { get; }
        public Rilisoft.东且东丒丐世丐丞丒 东且东丒丐世丐丞丒 { get; }
        public 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丙丕丈一一丝丑七丈 { get; }
        public bool 丟七一丏丈丒丘丝世 { get; set; }
        public bool 且丗丈丈世丐丐万七 { get; set; }
        
        // Methods
        protected abstract UnityEngine.GameObject 且丆上丂且下丙丐东(); // 0
        protected System.Nullable<bool> 丝丂丂七万丑三业丈()
        {
            return (System.Nullable<System.Boolean>)this.<丛丗丈丟丘与万上且>k__BackingField;
        }
        private void 丝上七上丗万下丄丛(System.Nullable<bool> 丙业与丙丗丝不丈东)
        {
            this.<丛丗丈丟丘与万上且>k__BackingField = 丙业与丙丗丝不丈东.HasValue;
        }
        protected System.Collections.Generic.List<UnityEngine.Renderer> 丌上丛与丕丏丒专丄()
        {
            return (System.Collections.Generic.List<UnityEngine.Renderer>)this.<三丌万业万丟丕丄七>k__BackingField;
        }
        private void 与与万下丅丐丗与世(System.Collections.Generic.List<UnityEngine.Renderer> 丙业与丙丗丝不丈东)
        {
            this.<三丌万业万丟丕丄七>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private static UnityEngine.Material 丈丕丅丁专丂专丈丝()
        {
            if(Rilisoft.FortItemSceneViewBase.三丅专一万丝且丆七 != 0)
            {
                    return (UnityEngine.Material)Rilisoft.FortItemSceneViewBase.三丅专一万丝且丆七;
            }
            
            Rilisoft.FortItemSceneViewBase.三丅专一万丝且丆七 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Materials\\BuildMaterial(Instance)");
            return (UnityEngine.Material)Rilisoft.FortItemSceneViewBase.三丅专一万丝且丆七;
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private void OnDisable()
        {
            this.StopCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new FortItemSceneViewBase.丒丁丗东丌丛丘丝丄();
        }
        protected void 七丌三东一一丗且七()
        {
            System.Collections.Generic.List<UnityEngine.GameObject> val_23;
            var val_24;
            var val_26;
            var val_27;
            var val_29;
            var val_30;
            var val_31;
            val_23 = this;
            if(((-582420452) & 1) != 0)
            {
                    bool val_22 = this.<不丁丝丈丙丄丂丐下>k__BackingField;
                val_22 = ((val_22 == true) ? 1 : 0) ^ (this.<丛丗丈丟丘与万上且>k__BackingField.GetValueOrDefault());
                if(val_22 != true)
            {
                    if(((-582420452) & 1) != 0)
            {
                    return;
            }
            
            }
            
            }
            
            this.<丛丗丈丟丘与万上且>k__BackingField = 0;
            if((this.<不丁丝丈丙丄丂丐下>k__BackingField) == false)
            {
                goto label_41;
            }
            
            Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if((val_3.<丛丄七丟丈丆丒丆丈>k__BackingField) != this.丆丐专丘丅万丂丐不)
            {
                goto label_41;
            }
            
            if(((this.<三丌万业万丟丕丄七>k__BackingField) == null) || ((this.<三丌万业万丟丕丄七>k__BackingField.Count) < 1))
            {
                goto label_29;
            }
            
            List.Enumerator<T> val_5 = this.<三丌万业万丟丕丄七>k__BackingField.GetEnumerator();
            val_26 = 1152921525724388416;
            label_20:
            if(((-582420496) & 1) == 0)
            {
                goto label_10;
            }
            
            string val_7 = 0.丐丏七丌丕丗业且上();
            UnityEngine.Material[] val_8 = val_7.sharedMaterials;
            UnityEngine.Material[] val_9 = new UnityEngine.Material[0];
            val_27 = 0;
            goto label_13;
            label_18:
            val_27 = 1;
            val_9[0] = Rilisoft.FortItemSceneViewBase.丈丕丅丁专丂专丈丝();
            label_13:
            if(val_27 < val_9.Length)
            {
                goto label_18;
            }
            
            val_7.sharedMaterials = val_9;
            goto label_20;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_29:
            List.Enumerator<T> val_11 = this._disableIfCrafting.GetEnumerator();
            val_24 = 1152921519068955088;
            label_36:
            if(((-582420528) & 1) == 0)
            {
                goto label_31;
            }
            
            string val_12 = 0.丐丏七丌丕丗业且上();
            if(val_12 == 0)
            {
                goto label_36;
            }
            
            val_12.SetActive(value:  false);
            goto label_36;
            label_31:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return;
            label_41:
            if(((this.<三丌万业万丟丕丄七>k__BackingField) == null) || ((this.<三丌万业万丟丕丄七>k__BackingField.Count) < 1))
            {
                goto label_43;
            }
            
            List.Enumerator<T> val_15 = this.<三丌万业万丟丕丄七>k__BackingField.GetEnumerator();
            label_50:
            if(((-582420496) & 1) == 0)
            {
                goto label_45;
            }
            
            string val_16 = 0.丐丏七丌丕丗业且上();
            if((this.丕丆下下丙丝丝丙丄.ContainsKey(key:  val_16)) == false)
            {
                goto label_50;
            }
            
            val_16.sharedMaterials = this.丕丆下下丙丝丝丙丄.Item[val_16];
            goto label_50;
            label_43:
            val_29 = 0;
            label_66:
            label_68:
            val_23 = this._disableIfCrafting;
            List.Enumerator<T> val_19 = val_23.GetEnumerator();
            val_26 = 1152921504848912384;
            label_57:
            if(((-582420528) & 1) == 0)
            {
                goto label_52;
            }
            
            string val_20 = 0.丐丏七丌丕丗业且上();
            if(val_20 == 0)
            {
                goto label_57;
            }
            
            val_20.SetActive(value:  true);
            goto label_57;
            label_52:
            val_24 = 0 + 1;
            mem2[0] = 463;
            goto label_58;
            label_45:
            val_30 = 0;
            val_31 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if(396 == 396)
            {
                goto label_66;
            }
            
            }
            
            if( == 0)
            {
                goto label_68;
            }
            
            goto label_68;
            label_58:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_30 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(396 == 463)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        protected virtual void 丌不丂丌丁丛丆丟与()
        {
        
        }
        protected virtual void 丗丌丂丙丈丆不丂七()
        {
        
        }
        protected virtual void 丐丟丟丈丅三丄丛丌()
        {
            var val_3;
            UnityEngine.Object val_48;
            var val_49;
            UnityEngine.Object val_50;
            val_48 = this;
            if((this.<三丌万业万丟丕丄七>k__BackingField) == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.<三丌万业万丟丕丄七>k__BackingField.GetEnumerator();
            goto label_7;
            label_64:
            val_48 = val_3.丐丏七丌丕丗业且上();
            if((val_48 == 0) || (val_48.sharedMaterials == null))
            {
                goto label_7;
            }
            
            val_48 = val_48.sharedMaterials;
            val_49 = 0;
            goto label_9;
            label_63:
            UnityEngine.Material val_47 = val_48[0];
            if(val_47 == 0)
            {
                goto label_20;
            }
            
            val_50 = val_47.name;
            if((val_50.Contains(value:  "(Instance)")) == true)
            {
                goto label_20;
            }
            
            val_50 = val_47.name.ToLower();
            if((val_50.Contains(value:  "shadow")) == true)
            {
                goto label_20;
            }
            
            val_50 = val_47.mainTexture;
            if(val_50 == 0)
            {
                goto label_60;
            }
            
            val_50 = val_47.mainTexture;
            if(val_50.name == null)
            {
                goto label_27;
            }
            
            val_50 = val_47.mainTexture.name;
            if((val_50.StartsWith(value:  "Particle_Stack")) == true)
            {
                goto label_60;
            }
            
            val_50 = val_47.mainTexture.name.ToLowerInvariant();
            if((val_50.Contains(value:  "water")) == true)
            {
                goto label_60;
            }
            
            val_50 = val_47.mainTexture;
            if((System.String.op_Inequality(a:  val_50.name, b:  "decor_big_space_2")) == false)
            {
                goto label_60;
            }
            
            val_50 = val_47.mainTexture;
            if((System.String.op_Inequality(a:  val_50.name, b:  "GlossTexture2")) == false)
            {
                goto label_60;
            }
            
            val_50 = val_47.mainTexture;
            if((System.String.op_Inequality(a:  val_50.name, b:  "Castle_grass")) == false)
            {
                goto label_60;
            }
            
            val_50 = val_47.mainTexture.name.ToLower();
            if((val_50.Contains(value:  "shadow")) == true)
            {
                goto label_60;
            }
            
            val_50 = val_47.mainTexture.name.ToLower();
            if((val_50.Contains(value:  "glass")) == true)
            {
                goto label_60;
            }
            
            val_50 = val_47.mainTexture.name.ToLower();
            if((val_50.Contains(value:  "lightning")) == true)
            {
                goto label_60;
            }
            
            label_27:
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_47.mainTexture);
            label_60:
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_47);
            label_20:
            val_49 = 1;
            label_9:
            if(val_49 < val_7.Length)
            {
                goto label_63;
            }
            
            label_7:
            if(((-581743792) & 1) != 0)
            {
                goto label_64;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public Rilisoft.东且东丒丐世丐丞丒 get_FortItem()
        {
            return (Rilisoft.东且东丒丐世丐丞丒)this.丐丙丒丈丄不一丈与;
        }
        public 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 get_Slot()
        {
            return (丗丞丏丙七丑丕且丐)this.丆丐专丘丅万丂丐不;
        }
        public bool get_IsSelected()
        {
            return (bool)this.丏丈丞丙七丛东七丌;
        }
        public void set_IsSelected(bool 丙业与丙丗丝不丈东)
        {
            this.丏丈丞丙七丛东七丌 = 丙业与丙丗丝不丈东;
            goto typeof(Rilisoft.FortItemSceneViewBase).__il2cppRuntimeField_268;
        }
        public bool get_IsCrafting()
        {
            return (bool)this.<不丁丝丈丙丄丂丐下>k__BackingField;
        }
        public void set_IsCrafting(bool 丙业与丙丗丝不丈东)
        {
            this.<不丁丝丈丙丄丂丐下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual void Setup(UnityEngine.Transform 七万上丐一丈丏丏专, Rilisoft.FortCraftController 丒专丈丛下丒一丒丛, Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙 = 0)
        {
            object val_27;
            var val_28;
            var val_29;
            System.Func<UnityEngine.Renderer, System.Boolean> val_31;
            val_27 = this;
            this.业专万丏丘丙丝一丕 = 丒专丈丛下丒一丒丛;
            this.丐丙丒丈丄不一丈与 = 下丅丙一丂丗丅丝七;
            this.丆丐专丘丅万丂丐不 = 与丄不丌一世东丁丙;
            this.gameObject.transform.SetParent(p:  七万上丐一丈丏丏专);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            this.gameObject.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
            val_28 = 0;
            goto label_14;
            label_25:
            T val_27 = this.gameObject.GetComponentsInChildren<UnityEngine.Collider>(includeInactive:  true)[0];
            if(val_27.isTrigger != true)
            {
                    Rilisoft.ButtonEventsHandler val_16 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.ButtonEventsHandler>(丝三丁东丈丒世丅业:  val_27.gameObject);
                val_16.OnClickEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(Rilisoft.FortItemSceneViewBase).__il2cppRuntimeField_220));
                val_16.OnClickEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(Rilisoft.FortItemSceneViewBase).__il2cppRuntimeField_220));
            }
            
            val_28 = 1;
            label_14:
            if(val_28 < val_13.Length)
            {
                goto label_25;
            }
            
            val_29 = null;
            val_29 = null;
            val_31 = FortItemSceneViewBase.<>c.<>9__37_0;
            if(val_31 == null)
            {
                    System.Func<UnityEngine.Renderer, System.Boolean> val_20 = null;
                val_31 = val_20;
                val_20 = new System.Func<UnityEngine.Renderer, System.Boolean>(object:  FortItemSceneViewBase.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortItemSceneViewBase.<>c::下丏丛丈且丛东丒丞(UnityEngine.Renderer 东七上世万下丗丄丛));
                FortItemSceneViewBase.<>c.<>9__37_0 = val_31;
            }
            
            this.<三丌万业万丟丕丄七>k__BackingField = System.Linq.Enumerable.ToList<UnityEngine.Renderer>(source:  System.Linq.Enumerable.Where<UnityEngine.Renderer>(source:  this.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true), predicate:  val_20));
            this.丕丆下下丙丝丝丙丄.Clear();
            List.Enumerator<T> val_23 = this.<三丌万业万丟丕丄七>k__BackingField.GetEnumerator();
            label_37:
            if(((-580490824) & 1) == 0)
            {
                goto label_34;
            }
            
            string val_24 = 0.丐丏七丌丕丗业且上();
            this.丕丆下下丙丝丝丙丄.Add(key:  val_24, value:  System.Linq.Enumerable.ToArray<UnityEngine.Material>(source:  val_24.sharedMaterials));
            goto label_37;
            label_34:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public virtual void Hide()
        {
        
        }
        public virtual void UpdateView()
        {
        
        }
        public virtual void Kill()
        {
            this.<丛丗丈丟丘与万上且>k__BackingField = 0;
        }
        public virtual void Kill(bool 不丟一丄丁丆丅上丒)
        {
            this.<丛丗丈丟丘与万上且>k__BackingField = 0;
        }
        protected FortItemSceneViewBase()
        {
            this.丕丆下下丙丝丝丙丄 = new System.Collections.Generic.Dictionary<UnityEngine.Renderer, UnityEngine.Material[]>();
        }
    
    }

}
