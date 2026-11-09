using UnityEngine;

namespace PGCompany
{
    internal class ButtonOpenModuleInsertPanel : MonoBehaviour
    {
        // Fields
        private PGCompany.ModuleStorageView _moduleStorageView;
        
        // Methods
        public void ShowModuleInsertPanelFromArmoryInfoScreen(System.Action 东三丕业与丅丞丟丗, System.Action 一丘上丐丆丏丛且丄)
        {
            var val_19;
            var val_20;
            var val_21;
            丙且上东下丏丏丟下 val_22;
            ButtonOpenModuleInsertPanel.丝丂下丂丐丄丁丑丄 val_1 = new ButtonOpenModuleInsertPanel.丝丂下丂丐丄丁丑丄();
            .丞不丌不丏世丐专与 = 0;
            if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0)
            {
                    .丞不丌不丏世丐专与 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
            }
            else
            {
                    if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
            {
                    val_19 = null;
                val_19 = null;
                if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
            {
                    val_20 = null;
                val_20 = null;
                if(ShopNGUIController.丏丙丅丕一丑丕丑丑.infoScreen != 0)
            {
                    val_21 = null;
                val_21 = null;
                .丞不丌不丏世丐专与 = ShopNGUIController.丏丙丅丕一丑丕丑丑.infoScreen.GetComponent<ArmoryInfoScreenController>();
            }
            
            }
            
            }
            
            }
            
            if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 3)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
            {
                    Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丆丝七业丗世丛丐下(三不三丟专丘东东丂:  ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三().业上丙丞丐丄丆丅七());
            }
            
            }
            
            val_22 = 0;
            if((ButtonOpenModuleInsertPanel.丝丂下丂丐丄丁丑丄)[1152921555774200416].丞不丌不丏世丐专与 != 0)
            {
                    val_22 = (ButtonOpenModuleInsertPanel.丝丂下丂丐丄丁丑丄)[1152921555774200416].丞不丌不丏世丐专与.丈丒丛东上丘丅世三();
            }
            
            this.丌丘下丛丘丟丕丑丕(下丅丙一丂丗丅丝七:  val_22, 东三丕业与丅丞丟丗:  new System.Action(object:  val_1, method:  System.Void ButtonOpenModuleInsertPanel.丝丂下丂丐丄丁丑丄::丅丏与丗丘丐不万三()), 一丘上丐丆丏丛且丄:  new System.Action(object:  val_1, method:  System.Void ButtonOpenModuleInsertPanel.丝丂下丂丐丄丁丑丄::上丏东业七丅丑丗丘()));
        }
        public void ShowModuleInsertPanelFromModuleList(System.Action 东三丕业与丅丞丟丗, System.Action 一丘上丐丆丏丛且丄)
        {
            丙且上东下丏丏丟下 val_1 = PGCompany.七丆丆丕丂丙丕丐丂.丆丒上丗一丙一三丕();
            if(val_1 == null)
            {
                    return;
            }
            
            this.丌丘下丛丘丟丕丑丕(下丅丙一丂丗丅丝七:  val_1, 东三丕业与丅丞丟丗:  0, 一丘上丐丆丏丛且丄:  0);
        }
        private void 丌丘下丛丘丟丕丑丕(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, System.Action 东三丕业与丅丞丟丗, System.Action 一丘上丐丆丏丛且丄)
        {
            System.Action val_17;
            丙且上东下丏丏丟下 val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_23;
            var val_24;
            val_17 = 一丘上丐丆丏丛且丄;
            val_18 = 下丅丙一丂丗丅丝七;
            .一丘上丐丆丏丛且丄 = val_17;
            if(上丑三丁丄丛丁万丑.世丅与丏丕丑丛上业() == false)
            {
                    return;
            }
            
            val_19 = null;
            val_19 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑.丆一丂丕三丄丞丆上 == 0)
            {
                    val_20 = null;
                val_20 = null;
                UnityEngine.GameObject val_5 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Modules/ModuleInsertPanel"), 丈东丘丏与丌东东下:  ShopNGUIController.丏丙丅丕一丑丕丑丑.moduleInsertPanelTransform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                ShopNGUIController.丏丙丅丕一丑丕丑丑.丆一丂丕三丄丞丆上 = val_5.GetComponent<PGCompany.ModuleInsertPanel>();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丆一丂丕三丄丞丆上, 丏业丟一东丂东丘丛:  false);
                val_5.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            val_21 = null;
            val_21 = null;
            val_17 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1512];
            val_17 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丆一丂丕三丄丞丆上;
            if(val_17 == 0)
            {
                    return;
            }
            
            if(this._moduleStorageView != 0)
            {
                goto label_29;
            }
            
            PGCompany.ModulesController val_11 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
            if(val_18.丒万丕七专不丏丞丌() != 7)
            {
                goto label_31;
            }
            
            PGCompany.丗丟丅七东丄丙丟上 val_12 = val_11.下丗且丆七丛丕与丕();
            goto label_35;
            label_29:
            PGCompany.丗丟丅七东丄丙丟上 val_13 = this._moduleStorageView.丅万万丈世业业丗世();
            goto label_35;
            label_31:
            label_35:
            val_23 = null;
            val_23 = null;
            val_17 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1512];
            val_17 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丆一丂丕三丄丞丆上;
            丈且东丑丂且万丒丅(丑丝丏丂且不下一东:  val_18, 丑专丆丟丟丐丆一丕:  val_11.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  val_18.业上丙丞丐丄丆丅七()));
            if(东三丕业与丅丞丟丗 != null)
            {
                    东三丕业与丅丞丟丗.Invoke();
            }
            
            val_24 = null;
            val_24 = null;
            System.Action val_16 = null;
            val_18 = val_16;
            val_16 = new System.Action(object:  new ButtonOpenModuleInsertPanel.上丌专丄丘丂东且丒(), method:  System.Void ButtonOpenModuleInsertPanel.上丌专丄丘丂东且丒::丟与丂不丂丂丒丙东());
            Show(业丏丈世世世丞丒世:  val_16);
        }
        public ButtonOpenModuleInsertPanel()
        {
        
        }
    
    }

}
