using UnityEngine;

namespace PGCompany
{
    public class LoadoutUiCellRespawnWindow : PGBehaviour
    {
        // Fields
        private UILabel _loadoutName;
        private UILabel _loadoutNumber;
        private PGCompany.ItemCellOfLoadoutsUi _primaryWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _backupWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _meleeWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _specialWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _sniperWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _premiumWeaponCell;
        private UnityEngine.GameObject _inUseBackgroundContainer;
        private System.Collections.Generic.List<PGCompany.ItemCellOfLoadoutsUi> 丌丅东丑业且丐与丛;
        private Progress.丛下丄专下万丒专丂 丈一且一丌上不七丌;
        private System.Action 丅不丅且丕业万丁三;
        
        // Methods
        public void add_cellClicked(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丅不丅且丕业万丁三, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅不丅且丕业万丁三 != 1152921555737146512);
        
        }
        public void remove_cellClicked(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丅不丅且丕业万丁三, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅不丅且丕业万丁三 != 1152921555737283088);
        
        }
        private void Awake()
        {
            System.Collections.Generic.List<PGCompany.ItemCellOfLoadoutsUi> val_1 = new System.Collections.Generic.List<PGCompany.ItemCellOfLoadoutsUi>();
            val_1.Add(item:  this._primaryWeaponCell);
            val_1.Add(item:  this._backupWeaponCell);
            val_1.Add(item:  this._meleeWeaponCell);
            val_1.Add(item:  this._specialWeaponCell);
            val_1.Add(item:  this._sniperWeaponCell);
            val_1.Add(item:  this._premiumWeaponCell);
            this.丌丅东丑业且丐与丛 = val_1;
        }
        internal void 丈且东丑丂且万丒丅(Progress.丛下丄专下万丒专丂 丌东万丁三丄万丅上)
        {
            this.丈一且一丌上不七丌 = 丌东万丁三丄万丅上;
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_21;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._loadoutName, 丕丗丘丑丛与丑业丒:  this.丈一且一丌上不七丌.东丙上东业丆不丟丘());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._loadoutNumber, 丕丗丘丑丛与丑业丒:  this.丈一且一丌上不七丌.一丗专丅丐丝业万丒() + 1);
            this._primaryWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  this.丈一且一丌上不七丌.丂丕丄上三东丆丌丟(), 与与丕万丌与下丒丆:  this.丈一且一丌上不七丌.一丗专丅丐丝业万丒());
            this._backupWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  this.丈一且一丌上不七丌.业丞丄七丞丒丐丒丐(), 与与丕万丌与下丒丆:  this.丈一且一丌上不七丌.一丗专丅丐丝业万丒());
            this._meleeWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  this.丈一且一丌上不七丌.丐万一丁专下专东丞(), 与与丕万丌与下丒丆:  this.丈一且一丌上不七丌.一丗专丅丐丝业万丒());
            this._specialWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  this.丈一且一丌上不七丌.丕上下丌与丆丝丛丄(), 与与丕万丌与下丒丆:  this.丈一且一丌上不七丌.一丗专丅丐丝业万丒());
            this._sniperWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  this.丈一且一丌上不七丌.丒丕丕一丙丒丅丑丞(), 与与丕万丌与下丒丆:  this.丈一且一丌上不七丌.一丗专丅丐丝业万丒());
            this._premiumWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  this.丈一且一丌上不七丌.丗不且东丌丙三丆业(), 与与丕万丌与下丒丆:  this.丈一且一丌上不七丌.一丗专丅丐丝业万丒());
            val_21 = null;
            val_21 = null;
            if((LoadoutUiCellRespawnWindow.<>c.<>9__16_0) == null)
            {
                goto label_25;
            }
            
            label_36:
            this.丌丅东丑业且丐与丛.ForEach(action:  LoadoutUiCellRespawnWindow.<>c.<>9__16_0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._inUseBackgroundContainer, 丏业丟一东丂东丘丛:  (Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丑专丘世丙丑丝世七() == this.丈一且一丌上不七丌.一丗专丅丐丝业万丒()) ? 1 : 0);
            return;
            label_25:
            LoadoutUiCellRespawnWindow.<>c.<>9__16_0 = new System.Action<PGCompany.ItemCellOfLoadoutsUi>(object:  LoadoutUiCellRespawnWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoadoutUiCellRespawnWindow.<>c::业下下专世七丈业丈(PGCompany.ItemCellOfLoadoutsUi 三丟东丕丄丄下下丑));
            if(this.丌丅东丑业且丐与丛 != null)
            {
                goto label_36;
            }
            
            goto label_36;
        }
        public void U_OnClick()
        {
            Progress.丛下丄专下万丒专丂 val_6 = this.丈一且一丌上不七丌;
            if(Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丑专丘世丙丑丝世七() == val_6.一丗专丅丐丝业万丒())
            {
                    return;
            }
            
            val_6 = this.丈一且一丌上不七丌.一丗专丅丐丝业万丒();
            Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丒东丗丕万三不七丁(与与丕万丌与下丒丆:  val_6);
            if(this.丅不丅且丕业万丁三 == null)
            {
                    return;
            }
            
            this.丅不丅且丕业万丁三.Invoke();
        }
        public LoadoutUiCellRespawnWindow()
        {
        
        }
    
    }

}
