using UnityEngine;

namespace Rilisoft
{
    public class CraftCategoryView : MonoBehaviour
    {
        // Fields
        private UnityEngine.Color 丁丐丄丁丑丆丈丅上;
        private Rilisoft.LobbyItemGroupType _groupType;
        private UISprite _icon;
        private UnityEngine.GameObject _newIndicator;
        
        // Methods
        private void OnClick()
        {
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丐丟业丏丕东丗下一(一丐丅且丛不不丌丗:  this._groupType, 丗丒世丒东丆丅一七:  true, 世万丐专世丕业丟东:  0);
        }
        private void Awake()
        {
            UnityEngine.Color val_1 = this._icon.color;
            this.丁丐丄丁丑丆丈丅上 = val_1;
            mem[1152921543125737260] = val_1.g;
            mem[1152921543125737264] = val_1.b;
            mem[1152921543125737268] = val_1.a;
        }
        private void OnEnable()
        {
            UnityEngine.GameObject val_12;
            var val_13;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_15;
            var val_16;
            val_12 = this._newIndicator;
            if(val_12 != 0)
            {
                    val_13 = null;
                val_13 = null;
                val_15 = CraftCategoryView.<>c.<>9__6_0;
                if(val_15 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_4 = null;
                val_15 = val_4;
                val_4 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  CraftCategoryView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CraftCategoryView.<>c::丞丐丙丄三丐不丂上(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                CraftCategoryView.<>c.<>9__6_0 = val_15;
            }
            
                val_12 = System.Linq.Enumerable.Any<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.万丂丙丒丒丞丏下下(一丐丅且丛不不丌丗:  this._groupType, 丁丅丑下丝丆丄下丏:  true), predicate:  val_4);
                this._newIndicator.SetActive(value:  val_12);
            }
            
            if(this._icon == 0)
            {
                    return;
            }
            
            if((Rilisoft.LobbyItemsController.丑丆丏丟丗丌丄丟丝() == true) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
            {
                goto label_19;
            }
            
            val_16 = null;
            val_16 = null;
            val_12 = this._groupType;
            if((Rilisoft.LobbyItemsController.一丑不丐丌丁一上丒.Contains(item:  val_12)) == false)
            {
                goto label_23;
            }
            
            label_19:
            label_26:
            this._icon.color = new UnityEngine.Color() {r = this.丁丐丄丁丑丆丈丅上, g = V9.16B, b = V10.16B, a = V11.16B};
            return;
            label_23:
            UnityEngine.Color val_11 = UnityEngine.Color.gray;
            if(this._icon != null)
            {
                goto label_26;
            }
            
            goto label_26;
        }
        public CraftCategoryView()
        {
        
        }
    
    }

}
