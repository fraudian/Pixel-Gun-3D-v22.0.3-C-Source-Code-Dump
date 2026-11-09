using UnityEngine;

namespace Rilisoft
{
    public abstract class LobbyItemSceneViewBase : MonoBehaviour, 上丆丕业丘业丈丄丆
    {
        // Fields
        private static UnityEngine.Material 三丅专一万丝且丆七;
        private System.Collections.Generic.List<UnityEngine.GameObject> _disableIfCrafting;
        private bool 丏丈丞丙七丛东七丌;
        private Rilisoft.丏丘七丞丄丙丌丞丁 丐丙丒丈丄不一丈与;
        protected System.Collections.Generic.Dictionary<UnityEngine.Renderer, UnityEngine.Material[]> 丕丆下下丙丝丝丙丄;
        private System.Nullable<bool> <丛丗丈丟丘与万上且>k__BackingField;
        private System.Collections.Generic.List<UnityEngine.Renderer> <三丌万业万丟丕丄七>k__BackingField;
        public bool notUnload;
        private bool <不丁丝丈丙丄丂丐下>k__BackingField;
        
        // Properties
        protected abstract UnityEngine.GameObject 丘三业丒世丘世丞丟 { get; }
        protected System.Nullable<bool> 业丘三三世一下万丕 { get; set; }
        protected System.Collections.Generic.List<UnityEngine.Renderer> 丘丒丑丗丑下丁三世 { get; set; }
        private static UnityEngine.Material 丌丝丘丝东专丏世丙 { get; }
        public Rilisoft.丏丘七丞丄丙丌丞丁 丏丘七丞丄丙丌丞丁 { get; }
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
            if(Rilisoft.LobbyItemSceneViewBase.三丅专一万丝且丆七 != 0)
            {
                    return (UnityEngine.Material)Rilisoft.LobbyItemSceneViewBase.三丅专一万丝且丆七;
            }
            
            Rilisoft.LobbyItemSceneViewBase.三丅专一万丝且丆七 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Materials\\BuildMaterial(Instance)");
            return (UnityEngine.Material)Rilisoft.LobbyItemSceneViewBase.三丅专一万丝且丆七;
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
            return (System.Collections.IEnumerator)new LobbyItemSceneViewBase.丟下丘丁丂东丏丁丅();
        }
        protected void 七丌三东一一丗且七()
        {
            System.Collections.Generic.List<UnityEngine.GameObject> val_24;
            var val_25;
            var val_27;
            var val_28;
            var val_30;
            var val_31;
            var val_32;
            val_24 = this;
            if(((-88360932) & 1) != 0)
            {
                    bool val_23 = this.<不丁丝丈丙丄丂丐下>k__BackingField;
                val_23 = ((val_23 == true) ? 1 : 0) ^ (this.<丛丗丈丟丘与万上且>k__BackingField.GetValueOrDefault());
                if(val_23 != true)
            {
                    if(((-88360932) & 1) != 0)
            {
                    return;
            }
            
            }
            
            }
            
            this.<丛丗丈丟丘与万上且>k__BackingField = 0;
            if(this.丐丙丒丈丄不一丈与.丘专上世与丟丝丟丛() == 4)
            {
                    return;
            }
            
            if(this.丐丙丒丈丄不一丈与.丘专上世与丟丝丟丛() == 12)
            {
                    return;
            }
            
            if((this.<不丁丝丈丙丄丂丐下>k__BackingField) == false)
            {
                goto label_43;
            }
            
            if(((this.<三丌万业万丟丕丄七>k__BackingField) == null) || ((this.<三丌万业万丟丕丄七>k__BackingField.Count) < 1))
            {
                goto label_31;
            }
            
            List.Enumerator<T> val_6 = this.<三丌万业万丟丕丄七>k__BackingField.GetEnumerator();
            val_27 = 1152921525724388416;
            label_22:
            if(((-88360976) & 1) == 0)
            {
                goto label_12;
            }
            
            string val_8 = 0.丐丏七丌丕丗业且上();
            UnityEngine.Material[] val_9 = val_8.sharedMaterials;
            UnityEngine.Material[] val_10 = new UnityEngine.Material[0];
            val_28 = 0;
            goto label_15;
            label_20:
            val_28 = 1;
            val_10[0] = Rilisoft.LobbyItemSceneViewBase.丈丕丅丁专丂专丈丝();
            label_15:
            if(val_28 < val_10.Length)
            {
                goto label_20;
            }
            
            val_8.sharedMaterials = val_10;
            goto label_22;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_31:
            List.Enumerator<T> val_12 = this._disableIfCrafting.GetEnumerator();
            val_25 = 1152921519068955088;
            label_38:
            if(((-88361008) & 1) == 0)
            {
                goto label_33;
            }
            
            string val_13 = 0.丐丏七丌丕丗业且上();
            if(val_13 == 0)
            {
                goto label_38;
            }
            
            val_13.SetActive(value:  false);
            goto label_38;
            label_33:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return;
            label_43:
            if(((this.<三丌万业万丟丕丄七>k__BackingField) == null) || ((this.<三丌万业万丟丕丄七>k__BackingField.Count) < 1))
            {
                goto label_45;
            }
            
            List.Enumerator<T> val_16 = this.<三丌万业万丟丕丄七>k__BackingField.GetEnumerator();
            label_52:
            if(((-88360976) & 1) == 0)
            {
                goto label_47;
            }
            
            string val_17 = 0.丐丏七丌丕丗业且上();
            if((this.丕丆下下丙丝丝丙丄.ContainsKey(key:  val_17)) == false)
            {
                goto label_52;
            }
            
            val_17.sharedMaterials = this.丕丆下下丙丝丝丙丄.Item[val_17];
            goto label_52;
            label_45:
            val_30 = 0;
            label_68:
            label_70:
            val_24 = this._disableIfCrafting;
            List.Enumerator<T> val_20 = val_24.GetEnumerator();
            val_27 = 1152921504848912384;
            label_59:
            if(((-88361008) & 1) == 0)
            {
                goto label_54;
            }
            
            string val_21 = 0.丐丏七丌丕丗业且上();
            if(val_21 == 0)
            {
                goto label_59;
            }
            
            val_21.SetActive(value:  true);
            goto label_59;
            label_54:
            val_25 = 0 + 1;
            mem2[0] = 472;
            goto label_60;
            label_47:
            val_31 = 0;
            val_32 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if(405 == 405)
            {
                goto label_68;
            }
            
            }
            
            if( == 0)
            {
                goto label_70;
            }
            
            goto label_70;
            label_60:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_31 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(405 == 472)
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
            var val_47;
            if(this.notUnload != false)
            {
                    return;
            }
            
            if((this.<三丌万业万丟丕丄七>k__BackingField) == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.<三丌万业万丟丕丄七>k__BackingField.GetEnumerator();
            goto label_8;
            label_65:
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((val_4 == 0) || (val_4.sharedMaterials == null))
            {
                goto label_8;
            }
            
            val_47 = 0;
            goto label_10;
            label_64:
            UnityEngine.Material val_47 = val_4.sharedMaterials[0];
            if(((val_47 == 0) || ((val_47.name.Contains(value:  "(Instance)")) == true)) || ((val_47.name.ToLower().Contains(value:  "shadow")) == true))
            {
                goto label_21;
            }
            
            if(val_47.mainTexture != 0)
            {
                    if(val_47.mainTexture.name != null)
            {
                    if(((((((((val_47.mainTexture.name.StartsWith(value:  "Particle_Stack")) == true) || ((val_47.mainTexture.name.ToLowerInvariant().Contains(value:  "water")) == true)) || ((System.String.op_Inequality(a:  val_47.mainTexture.name, b:  "decor_big_space_2")) == false)) || ((System.String.op_Inequality(a:  val_47.mainTexture.name, b:  "GlossTexture2")) == false)) || ((System.String.op_Inequality(a:  val_47.mainTexture.name, b:  "Castle_grass")) == false)) || ((val_47.mainTexture.name.ToLower().Contains(value:  "shadow")) == true)) || ((val_47.mainTexture.name.ToLower().Contains(value:  "glass")) == true)) || ((val_47.mainTexture.name.ToLower().Contains(value:  "lightning")) == true))
            {
                goto label_61;
            }
            
            }
            
                UnityEngine.Resources.UnloadAsset(assetToUnload:  val_47.mainTexture);
            }
            
            label_61:
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_47);
            label_21:
            val_47 = 1;
            label_10:
            if(val_47 < val_7.Length)
            {
                goto label_64;
            }
            
            label_8:
            if(((-87680912) & 1) != 0)
            {
                goto label_65;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public Rilisoft.丏丘七丞丄丙丌丞丁 get_LobbyItem()
        {
            return (Rilisoft.丏丘七丞丄丙丌丞丁)this.丐丙丒丈丄不一丈与;
        }
        public bool get_IsSelected()
        {
            return (bool)this.丏丈丞丙七丛东七丌;
        }
        public void set_IsSelected(bool 丙业与丙丗丝不丈东)
        {
            this.丏丈丞丙七丛东七丌 = 丙业与丙丗丝不丈东;
            goto typeof(Rilisoft.LobbyItemSceneViewBase).__il2cppRuntimeField_258;
        }
        public bool get_IsCrafting()
        {
            return (bool)this.<不丁丝丈丙丄丂丐下>k__BackingField;
        }
        public void set_IsCrafting(bool 丙业与丙丗丝不丈东)
        {
            this.<不丁丝丈丙丄丂丐下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual void Setup(UnityEngine.Transform 七万上丐一丈丏丏专, Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            object val_27;
            UnityEngine.Events.UnityAction val_28;
            var val_29;
            var val_30;
            System.Func<UnityEngine.Renderer, System.Boolean> val_32;
            val_27 = this;
            this.丐丙丒丈丄不一丈与 = 下丅丙一丂丗丅丝七;
            this.gameObject.transform.SetParent(p:  七万上丐一丈丏丏专);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            this.gameObject.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
            val_28 = 1;
            val_29 = 0;
            goto label_14;
            label_25:
            T val_27 = this.gameObject.GetComponentsInChildren<UnityEngine.Collider>(includeInactive:  true)[0];
            val_28 = 0;
            if(val_27.isTrigger != true)
            {
                    Rilisoft.ButtonEventsHandler val_16 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.ButtonEventsHandler>(丝三丁东丈丒世丅业:  val_27.gameObject);
                val_16.OnClickEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(Rilisoft.LobbyItemSceneViewBase).__il2cppRuntimeField_210));
                UnityEngine.Events.UnityAction val_18 = new UnityEngine.Events.UnityAction(object:  this, method:  typeof(Rilisoft.LobbyItemSceneViewBase).__il2cppRuntimeField_210);
                val_28 = val_18;
                val_16.OnClickEvent.AddListener(call:  val_18);
            }
            
            val_29 = 1;
            label_14:
            if(val_29 < val_13.Length)
            {
                goto label_25;
            }
            
            val_30 = null;
            val_30 = null;
            val_32 = LobbyItemSceneViewBase.<>c.<>9__34_0;
            if(val_32 == null)
            {
                    System.Func<UnityEngine.Renderer, System.Boolean> val_20 = null;
                val_32 = val_20;
                val_20 = new System.Func<UnityEngine.Renderer, System.Boolean>(object:  LobbyItemSceneViewBase.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemSceneViewBase.<>c::丟七丄业丌丏三万丄(UnityEngine.Renderer 东七上世万下丗丄丛));
                LobbyItemSceneViewBase.<>c.<>9__34_0 = val_32;
            }
            
            this.<三丌万业万丟丕丄七>k__BackingField = System.Linq.Enumerable.ToList<UnityEngine.Renderer>(source:  System.Linq.Enumerable.Where<UnityEngine.Renderer>(source:  this.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true), predicate:  val_20));
            this.丕丆下下丙丝丝丙丄.Clear();
            List.Enumerator<T> val_23 = this.<三丌万业万丟丕丄七>k__BackingField.GetEnumerator();
            label_37:
            if(((-86557352) & 1) == 0)
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
        protected LobbyItemSceneViewBase()
        {
            this.丕丆下下丙丝丝丙丄 = new System.Collections.Generic.Dictionary<UnityEngine.Renderer, UnityEngine.Material[]>();
        }
    
    }

}
