using UnityEngine;

namespace PGCompany
{
    internal class ModuleChestViewer : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.三丘丌上丁万丏丛丟>
    {
        // Fields
        private System.Collections.Generic.List<UILabel> _chestName;
        private UILabel _chestDescription;
        private UIBasicSprite _chestTexture;
        private UILabel _modulesCount;
        private UILabel _uniqueModulesCount;
        private UILabel _craftCurrencyCount;
        internal static System.Action 丛丄业丘不丆丄三丞;
        private static PGCompany.ModuleChestViewer 丝业丆丁业三丈丟东;
        private PGCompany.三丘丌上丁万丏丛丟 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Properties
        public PGCompany.三丘丌上丁万丏丛丟 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public PGCompany.三丘丌上丁万丏丛丟 get_Context()
        {
            return (PGCompany.三丘丌上丁万丏丛丟)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.三丘丌上丁万丏丛丟 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static PGCompany.ModuleChestViewer 下与丞三丅丛丄七丕(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌, UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            UnityEngine.Object val_19;
            PGCompany.ModuleChestViewer val_20;
            if(PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东 == 0)
            {
                    val_19 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Banners\\ModuleChestInfo");
                val_20 = 0;
                if(val_19 == 0)
            {
                    return val_20;
            }
            
                val_19 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_19, 丈东丘丏与丌东东下:  丆丏七丟不丒与七专, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                val_20 = 0;
                if(val_19 == 0)
            {
                    return val_20;
            }
            
                PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东 = val_19.GetComponent<PGCompany.ModuleChestViewer>();
                if(PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东 == 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_19);
                val_20 = 0;
                return val_20;
            }
            
            }
            
            PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东.transform.SetParent(p:  丆丏七丟不丒与七专);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_19 = PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东.transform;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.identity;
            val_19.localRotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
            if((UnityEngine.Object.op_Implicit(exists:  丆丏七丟不丒与七专)) != false)
            {
                    val_19 = PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东.gameObject;
                丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_19, 不东丛三丂丌丑专丆:  丆丏七丟不丒与七专.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东.Setup(与且专丈不万东一万:  丐下丝丘丑丟丟丗丌);
            val_20 = PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东;
            return val_20;
        }
        public void Setup(PGCompany.三丘丌上丁万丏丛丟 与且专丈不万东一万)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            UILabel val_9;
            System.Collections.Generic.List<UILabel> val_10;
            val_9 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            val_10 = this._chestName;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_10, 丕丗丘丑丛与丑业丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.七业丑不七丐业丟丂());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._chestDescription, 丕丗丘丑丛与丑业丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
            if(this._chestTexture != 0)
            {
                    val_10 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            }
            
            if(this._modulesCount != 0)
            {
                    ModuleChestData val_4 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁且七专七丗上与丑();
                val_10 = val_4.modulesCount;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._modulesCount, 丕丗丘丑丛与丑业丒:  val_4.modulesCount);
            }
            
            if(this._uniqueModulesCount != 0)
            {
                    ModuleChestData val_6 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁且七专七丗上与丑();
                val_10 = val_6.modulesTypesCount;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._uniqueModulesCount, 丕丗丘丑丛与丑业丒:  val_6.modulesTypesCount);
            }
            
            if(this._craftCurrencyCount == 0)
            {
                    return;
            }
            
            val_9 = this._craftCurrencyCount;
            ModuleChestData val_8 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丁且七专七丗上与丑();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_9, 丕丗丘丑丛与丑业丒:  val_8.currencyReward);
        }
        internal void 丆世与丑丆丅丐万且()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
            PGCompany.ModuleChestViewer.丝业丆丁业三丈丟东 = 0;
            if(PGCompany.ModuleChestViewer.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.ModuleChestViewer.丛丄业丘不丆丄三丞.Invoke();
        }
        public void U_Hide()
        {
            this.丆世与丑丆丅丐万且();
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleChestViewer::丆世与丑丆丅丐万且()), 与且专丈不万东一万:  0);
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        public ModuleChestViewer()
        {
        
        }
    
    }

}
