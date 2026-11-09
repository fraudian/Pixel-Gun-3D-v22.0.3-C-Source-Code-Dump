using UnityEngine;

namespace Rilisoft
{
    public class FortCraftCategoryView : MonoBehaviour
    {
        // Fields
        private UnityEngine.Color 丁丐丄丁丑丆丈丅上;
        private Rilisoft.FortItemGroupType _groupType;
        private UISprite _icon;
        private UILabel _itemsToCraft;
        private UnityEngine.GameObject _newIndicator;
        
        // Methods
        private void OnClick()
        {
            null = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.GoToGroup(一丐丅且丛不不丌丗:  this._groupType, 丗丒世丒东丆丅一七:  true, 丌丒丌丁丛丕专丗丝:  false);
        }
        private void Awake()
        {
            UnityEngine.Color val_1 = this._icon.color;
            this.丁丐丄丁丑丆丈丅上 = val_1;
            mem[1152921542633581436] = val_1.g;
            mem[1152921542633581440] = val_1.b;
            mem[1152921542633581444] = val_1.a;
        }
        private void OnEnable()
        {
            var val_15;
            var val_41;
            var val_42;
            var val_43;
            System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_45;
            var val_46;
            UILabel val_47;
            var val_48;
            val_41 = this;
            System.Collections.Generic.List<Rilisoft.东且东丒丐世丐丞丒> val_2 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.万丂丙丒丒丞丏下下(一丐丅且丛不不丌丗:  this._groupType, 丁丅丑下丝丆丄下丏:  true);
            if(this._newIndicator != 0)
            {
                    val_42 = 1152921505447845888;
                val_43 = null;
                val_43 = null;
                val_45 = FortCraftCategoryView.<>c.<>9__7_0;
                if(val_45 == null)
            {
                    System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean> val_4 = null;
                val_45 = val_4;
                val_4 = new System.Func<Rilisoft.东且东丒丐世丐丞丒, System.Boolean>(object:  FortCraftCategoryView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortCraftCategoryView.<>c::丈丌丗丟丐丝上且丕(Rilisoft.东且东丒丐世丐丞丒 七丞丙丒三丕且丌丟));
                FortCraftCategoryView.<>c.<>9__7_0 = val_45;
            }
            
                this._newIndicator.SetActive(value:  System.Linq.Enumerable.Any<Rilisoft.东且东丒丐世丐丞丒>(source:  val_2, predicate:  val_4));
            }
            
            if(this._icon == 0)
            {
                goto label_13;
            }
            
            if(Rilisoft.FortsManager.丑丆丏丟丗丌丄丟丝() == true)
            {
                goto label_16;
            }
            
            val_46 = null;
            val_46 = null;
            if((Rilisoft.FortsManager.一丑不丐丌丁一上丒.Contains(item:  this._groupType)) == false)
            {
                goto label_20;
            }
            
            label_16:
            if(this._icon != null)
            {
                goto label_48;
            }
            
            label_49:
            label_48:
            this._icon.color = new UnityEngine.Color() {r = this.丁丐丄丁丑丆丈丅上, g = V9.16B, b = V10.16B, a = V11.16B};
            label_13:
            val_47 = this._itemsToCraft;
            if(val_47 == 0)
            {
                    return;
            }
            
            val_47 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if(val_47 == 0)
            {
                    return;
            }
            
            List.Enumerator<T> val_13 = val_2.GetEnumerator();
            val_42 = 1152921540873606048;
            goto label_45;
            label_46:
            string val_16 = val_15.丐丏七丌丕丗业且上();
            val_47 = val_16.丗三三丐丁东丘丌一();
            int val_20 = val_16.丝丗丑万万丗不丙丁() + 1;
            val_20 = val_20 * val_16.三丐丟丒业丞东三丕();
            if((((val_47 >= val_20) && (val_16.丑丆丑三且丛上且丟() != true)) && (val_16.丕丐丈丁上丞与三丌() != true)) && (val_16.丙丄丝丕丏世丏丛丑() != true))
            {
                    val_47 = val_16.丁丞一不不丗丕丟丛();
                if((val_47.Contains(item:  249)) != true)
            {
                    bool val_27 = val_16.丁丞一不不丗丕丟丛().Contains(item:  1022);
            }
            
            }
            
            label_45:
            if(((-627754640) & 1) != 0)
            {
                goto label_46;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_61;
            label_20:
            UnityEngine.Color val_28 = UnityEngine.Color.gray;
            if(this._icon != null)
            {
                goto label_48;
            }
            
            goto label_49;
            label_61:
            if(1 < 1)
            {
                goto label_70;
            }
            
            val_47 = 1152921524404748272;
            if(((Rilisoft.Singleton<ClansController>.Instance) == 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
            {
                goto label_70;
            }
            
            val_47 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丛丛上丕丁丁七一不(丄丒且丙三丆丟与丏:  val_47)) == false)
            {
                goto label_70;
            }
            
            val_47 = 1.ToString();
            this._itemsToCraft.text = val_47;
            val_41 = this._itemsToCraft.gameObject;
            val_48 = 1;
            goto label_74;
            label_70:
            val_41 = this._itemsToCraft.gameObject;
            val_48 = 0;
            label_74:
            val_41.SetActive(value:  false);
        }
        public FortCraftCategoryView()
        {
        
        }
    
    }

}
