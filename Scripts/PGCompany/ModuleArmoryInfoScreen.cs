using UnityEngine;

namespace PGCompany
{
    internal class ModuleArmoryInfoScreen : MonoBehaviour
    {
        // Fields
        private PGCompany.ModuleStorageView _moduleStorageView;
        private PGCompany.ModuleStoragePropertiesView _moduleStoragePropertiesView;
        private UnityEngine.GameObject _specialStatsContainer;
        private UnityEngine.GameObject _moduleStatsContainer;
        private UnityEngine.GameObject _propertiesSwitcher;
        private UILabel _propertiesSwitcherLabel;
        private UILabel _armorPropertiesContainer;
        private 丙且上东下丏丏丟下 丂三下七万丛一丁丕;
        private PGCompany.丗丟丅七东丄丙丟上 丂丐丗专丞与丄丕万;
        private bool 丞丒丁与业丛东丙专;
        
        // Properties
        internal PGCompany.ModuleStorageView 丒丌丙丂丂丛丑丕丏 { get; }
        
        // Methods
        internal PGCompany.ModuleStorageView 不丞丄三丗且不东丆()
        {
            return (PGCompany.ModuleStorageView)this._moduleStorageView;
        }
        private void Awake()
        {
            Progress.丕业丗丕丈不下下不.业丗丒丄业丌不且丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleArmoryInfoScreen::丝一丅丆三东丂丞七()));
            Progress.丕业丗丕丈不下下不.东丛业专专丄世丒丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleArmoryInfoScreen::丝一丅丆三东丂丞七()));
        }
        private void OnDestroy()
        {
            Progress.丕业丗丕丈不下下不.丈且丐丟丐丄世丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleArmoryInfoScreen::丝一丅丆三东丂丞七()));
            Progress.丕业丗丕丈不下下不.丈丕丁丄丒丐三丞与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleArmoryInfoScreen::丝一丅丆三东丂丞七()));
        }
        internal void 东丌丟三丞世一一丑(丙且上东下丏丏丟下 丑丝丏丂且不下一东)
        {
            object val_11;
            this.丂三下七万丛一丁丕 = 丑丝丏丂且不下一东;
            this.丂丐丗专丞与丄丕万 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._specialStatsContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._moduleStatsContainer, 丏业丟一东丂东丘丛:  false);
            this.丆丆丑丏丒丛丙丞丑(丏业丟一东丂东丘丛:  true);
            this.丞丒丁与业丛东丙专 = false;
            if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.丂三下七万丛一丁丕.丒万丕七专不丏丞丌())) != false)
            {
                    this.丟上丌世丅丘丅东丆();
            }
            else
            {
                    if(this.丂三下七万丛一丁丕.丒万丕七专不丏丞丌() == 7)
            {
                    this.下丒丘丒丘丏丏万丝();
            }
            else
            {
                    if(this.丂三下七万丛一丁丕.丒万丕七专不丏丞丌() != 150000)
            {
                    if(丑丝丏丂且不下一东 != null)
            {
                    val_11 = 丑丝丏丂且不下一东.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_11 = 0.业上丙丞丐丄丆丅七();
            }
            
                UnityEngine.Debug.LogError(message:  System.String.Format(format:  "[{0}] Cannot setup view for item {1} with category {2}", arg0:  this.GetType(), arg1:  val_11, arg2:  丑丝丏丂且不下一东.丒万丕七专不丏丞丌()));
            }
            
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleStorageView, 丏业丟一东丂东丘丛:  (this.丞丒丁与业丛东丙专 == true) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleStoragePropertiesView, 丏业丟一东丂东丘丛:  this.丞丒丁与业丛东丙专);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._propertiesSwitcher, 丏业丟一东丂东丘丛:  this.丞丒丁与业丛东丙专);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._propertiesSwitcherLabel, 丏业丟一东丂东丘丛:  this.丞丒丁与业丛东丙专);
            this.丝一丅丆三东丂丞七();
        }
        private void 下丒丘丒丘丏丏万丝()
        {
            bool val_10;
            this.丂丐丗专丞与丄丕万 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.下丗且丆七丛丕与丕();
            if((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  this.丂三下七万丛一丁丕.业上丙丞丐丄丆丅七()))) < 1)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<PGCompany.ModulesController>.Instance.与丁上丌丝丟丑一丏()) != false)
            {
                    var val_9 = (this.丂丐丗专丞与丄丕万 != 0) ? 1 : 0;
            }
            else
            {
                    val_10 = false;
            }
            
            this.丞丒丁与业丛东丙专 = val_10;
        }
        private void 丟上丌世丅丘丅东丆()
        {
            var val_18;
            System.Collections.Generic.IEnumerable<TSource> val_19;
            var val_20;
            var val_21;
            System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_23;
            var val_24;
            System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>> val_26;
            val_18 = 1152921524402545584;
            this.丂丐丗专丞与丄丕万 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  this.丂三下七万丛一丁丕.业上丙丞丐丄丆丅七());
            val_19 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
            if((val_19.丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.丂三下七万丛一丁丕.业上丙丞丐丄丆丅七())) == null)
            {
                    return;
            }
            
            val_19 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
            if(val_19.与丁上丌丝丟丑一丏() != false)
            {
                    this.丞丒丁与业丛东丙专 = (this.丂丐丗专丞与丄丕万 != 0) ? 1 : 0;
                if(this.丂丐丗专丞与丄丕万 == null)
            {
                    return;
            }
            
                val_20 = null;
                val_20 = null;
                val_21 = null;
                val_21 = null;
                val_23 = ModuleArmoryInfoScreen.<>c.<>9__16_0;
                if(val_23 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_12 = null;
                val_23 = val_12;
                val_12 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean>(object:  ModuleArmoryInfoScreen.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModuleArmoryInfoScreen.<>c::丁上丟丛丄丏专上下(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
                ModuleArmoryInfoScreen.<>c.<>9__16_0 = val_23;
            }
            
                val_24 = null;
                val_24 = null;
                val_26 = ModuleArmoryInfoScreen.<>c.<>9__16_1;
                if(val_26 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>> val_14 = null;
                val_26 = val_14;
                val_14 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>>(object:  ModuleArmoryInfoScreen.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> ModuleArmoryInfoScreen.<>c::丆丈三业专一下丞丞(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
                ModuleArmoryInfoScreen.<>c.<>9__16_1 = val_26;
            }
            
                val_19 = System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  WeaponManager.且专专丁丌丗丛且丙, predicate:  val_12), selector:  val_14);
                if(val_19 == null)
            {
                    return;
            }
            
                if((System.Linq.Enumerable.Contains<System.String>(source:  val_19, value:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丂三下七万丛一丁丕.业上丙丞丐丄丆丅七()).与不丞丑七丘丁丂丛())) == false)
            {
                    return;
            }
            
            }
            
            this.丞丒丁与业丛东丙专 = false;
        }
        internal void 丝一丅丆三东丂丞七()
        {
            if(this.丂丐丗专丞与丄丕万 == null)
            {
                    return;
            }
            
            if(this.丞丒丁与业丛东丙专 == false)
            {
                    return;
            }
            
            this._moduleStorageView.丂丐丗专丞与丄丕万 = this.丂丐丗专丞与丄丕万;
            this._moduleStorageView.丝一丅丆三东丂丞七();
            this._moduleStoragePropertiesView.丂丐丗专丞与丄丕万 = this.丂丐丗专丞与丄丕万;
            this._moduleStoragePropertiesView.丝一丅丆三东丂丞七();
            int val_2 = this.丂丐丗专丞与丄丕万.丆丟且丗丒不丄七丌().Count;
            bool val_4 = (val_2 < 1) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._specialStatsContainer, 丏业丟一东丂东丘丛:  val_4);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._moduleStatsContainer, 丏业丟一东丂东丘丛:  (val_2 > 0) ? 1 : 0);
            this.丆丆丑丏丒丛丙丞丑(丏业丟一东丂东丘丛:  val_4);
        }
        public void SwitchProperties()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._specialStatsContainer, 丏业丟一东丂东丘丛:  (~this._specialStatsContainer.activeSelf) & 1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._moduleStatsContainer, 丏业丟一东丂东丘丛:  (~this._moduleStatsContainer.activeSelf) & 1);
            this.丆丆丑丏丒丛丙丞丑(丏业丟一东丂东丘丛:  this._specialStatsContainer.activeSelf);
        }
        private void 丆丆丑丏丒丛丙丞丑(bool 丏业丟一东丂东丘丛)
        {
            var val_12;
            string val_13;
            bool val_12 = 丏业丟一东丂东丘丛;
            if(this.丂三下七万丛一丁丕 != null)
            {
                    var val_2 = (this.丂三下七万丛一丁丕.丒万丕七专不丏丞丌() == 7) ? 1 : 0;
            }
            else
            {
                    val_12 = 0;
            }
            
            val_12 = val_12 & val_12;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._armorPropertiesContainer, 丏业丟一东丂东丘丛:  val_12);
            if((val_12 & (UnityEngine.Object.op_Inequality(x:  this._armorPropertiesContainer, y:  0))) == false)
            {
                    return;
            }
            
            PGCompany.且万丅丙丛丌丞与丈 val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.且万丅丙丛丌丞与丈>(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  this.丂三下七万丛一丁丕.业上丙丞丐丄丆丅七());
            if(val_7 == null)
            {
                    return;
            }
            
            System.Collections.Generic.List<七丅上上丟丞丗丗与> val_8 = val_7.下丆丂丌上丑一三丆();
            if((val_8 != null) && (val_8.Count > 0))
            {
                    val_13 = val_7.下丆丘丆一丝七世专();
            }
            else
            {
                    val_13 = "Key_8971";
            }
            
            this._armorPropertiesContainer.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_13);
        }
        public ModuleArmoryInfoScreen()
        {
        
        }
    
    }

}
