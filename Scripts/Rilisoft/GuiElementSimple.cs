using UnityEngine;

namespace Rilisoft
{
    public class GuiElementSimple : GuiElementBase
    {
        // Fields
        private Rilisoft.PrefabHandler _prefabHandler;
        private UnityEngine.GameObject <丝丟丆丐业丘丏丝上>k__BackingField;
        
        // Properties
        public UnityEngine.GameObject 丅上丗丌丄丏丅丆三 { get; set; }
        public override bool 七七业丒丟丝丘不丞 { get; }
        
        // Methods
        public UnityEngine.GameObject get_View()
        {
            return (UnityEngine.GameObject)this.<丝丟丆丐业丘丏丝上>k__BackingField;
        }
        private void 丄丆东与丕丄丟丅上(UnityEngine.GameObject 丙业与丙丗丝不丈东)
        {
            this.<丝丟丆丐业丘丏丝上>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override bool get_IsVisible()
        {
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField) == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_2 = this.<丝丟丆丐业丘丏丝上>k__BackingField.gameObject;
            if(val_2 != null)
            {
                    return val_2.activeInHierarchy;
            }
            
            return val_2.activeInHierarchy;
        }
        public void UpdateView()
        {
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField) == 0)
            {
                    if(this.gameObject.transform.childCount >= 1)
            {
                    this.<丝丟丆丐业丘丏丝上>k__BackingField = this.gameObject.transform.GetChild(index:  0).gameObject;
            }
            
            }
            
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField) != 0)
            {
                    return;
            }
            
            this._prefabHandler.PrefabIsLoaded = false;
            UnityEngine.GameObject val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._prefabHandler.Prefab);
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_11, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            1152921504848912384 = val_11.transform;
            1152921504848912384.SetParent(p:  this.transform);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            1152921504848912384.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
            1152921504848912384.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            this.<丝丟丆丐业丘丏丝上>k__BackingField = val_11;
        }
        protected override void 东丟丘世丕丆下不万()
        {
            this.UpdateView();
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.<丝丟丆丐业丘丏丝上>k__BackingField.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        protected override void 丙丝七丅丑三丞丂且()
        {
            if((this.<丝丟丆丐业丘丏丝上>k__BackingField) == 0)
            {
                    return;
            }
            
            this.<丝丟丆丐业丘丏丝上>k__BackingField.gameObject.gameObject.SetActive(value:  false);
        }
        protected override void OnEnable()
        {
            this.业下丛七业丆丛万丂();
        }
        protected override void OnDisable()
        {
            if(this.专三三上东丆丒丂丘() == false)
            {
                    return;
            }
            
            this.专丌丅下万丐三丗丗();
        }
        public GuiElementSimple()
        {
            this._prefabHandler = new Rilisoft.PrefabHandler();
        }
    
    }

}
