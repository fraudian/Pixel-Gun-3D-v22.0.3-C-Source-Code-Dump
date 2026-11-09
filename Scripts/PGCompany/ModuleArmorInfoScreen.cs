using UnityEngine;

namespace PGCompany
{
    internal class ModuleArmorInfoScreen : MonoBehaviour
    {
        // Fields
        private PGCompany.ModuleStorageView _moduleStorageView;
        private PGCompany.ModuleStoragePropertiesView _moduleStoragePropertiesView;
        private UnityEngine.GameObject _clanContainer;
        private PGCompany.丗丟丅七东丄丙丟上 丏丂丂且丁丗丁丗东;
        private bool 丞丒丁与业丛东丙专;
        
        // Methods
        private void Awake()
        {
            Progress.丕业丗丕丈不下下不.业丗丒丄业丌不且丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleArmorInfoScreen::丝一丅丆三东丂丞七()));
            Progress.丕业丗丕丈不下下不.东丛业专专丄世丒丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleArmorInfoScreen::丝一丅丆三东丂丞七()));
        }
        private void OnDestroy()
        {
            Progress.丕业丗丕丈不下下不.丈且丐丟丐丄世丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleArmorInfoScreen::丝一丅丆三东丂丞七()));
            Progress.丕业丗丕丈不下下不.丈丕丁丄丒丐三丞与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleArmorInfoScreen::丝一丅丆三东丂丞七()));
        }
        private void OnEnable()
        {
            var val_8;
            var val_9;
            var val_10;
            bool val_11;
            val_8 = null;
            val_8 = null;
            if(SquadController.丄丘七三上丕世丞业 != 0)
            {
                    val_9 = null;
                val_9 = null;
                val_10 = SquadController.丄丘七三上丕世丞业.inSquad;
            }
            else
            {
                    val_10 = 0;
            }
            
            if((val_10 | GameConnect.上丏丈七丘丁与丅丏()) != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_15;
            }
            
            }
            
            val_11 = 0;
            goto label_16;
            label_15:
            val_11 = UnityEngine.Object.op_Equality(x:  GameController.丑七不且上丗丁一世(), y:  0);
            label_16:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanContainer, 丏业丟一东丂东丘丛:  val_11);
        }
        internal void 东丌丟三丞世一一丑(丙且上东下丏丏丟下 丑丝丏丂且不下一东, System.Collections.Generic.List<string> 丄万丟丏且业丒上业)
        {
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            PGCompany.丗丟丅七东丄丙丟上 val_2 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.下丗且丆七丛丕与丕();
            this.丏丂丂且丁丗丁丗东 = val_2;
            this.丞丒丁与业丛东丙专 = (val_2 != 0) ? 1 : 0;
            if(val_2 == null)
            {
                    return;
            }
            
            this._moduleStorageView.丂丐丗专丞与丄丕万 = val_2;
            this._moduleStorageView.丝一丅丆三东丂丞七();
            this._moduleStoragePropertiesView.丂丐丗专丞与丄丕万 = this.丏丂丂且丁丗丁丗东;
            this._moduleStoragePropertiesView.丝一丅丆三东丂丞七();
        }
        public void U_GoToClanShopInClanLootbox()
        {
            this.丅丕下丑三下丌丝下();
        }
        private void 丅丕下丑三下丌丝下()
        {
            null = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
            {
                    return;
            }
            
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丂丅世东丘丛丘丕丟(且丂专丄丄丕丝丈一:  1);
        }
        public void U_GoToClan()
        {
            this.丘丗丞不丂丒一世丈();
        }
        private void 丘丗丞不丂丒一世丈()
        {
            null = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
            {
                    return;
            }
            
            ShopNGUIController.丏丙丅丕一丑丕丑丑.HandleGoToClanLobbyButton();
        }
        public ModuleArmorInfoScreen()
        {
        
        }
    
    }

}
