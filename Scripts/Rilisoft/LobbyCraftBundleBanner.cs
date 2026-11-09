using UnityEngine;

namespace Rilisoft
{
    public class LobbyCraftBundleBanner : MonoBehaviour
    {
        // Fields
        private Rilisoft.LobbyItemsBundle 丑不且东丛专丁丌丘;
        private UnityEngine.GameObject _rootObject;
        private UIBasicSprite _itemSprite;
        private System.Collections.Generic.List<UILabel> _itemNameLabels;
        private UITable _currencyTable;
        private UnityEngine.GameObject _gemsContainer;
        private System.Collections.Generic.List<UILabel> _gemsCountLabels;
        private UnityEngine.GameObject _coinsContainer;
        private System.Collections.Generic.List<UILabel> _coinsCountLabels;
        private UnityEngine.GameObject _plusContainer;
        private System.Collections.Generic.List<UILabel> _profitLabels;
        
        // Methods
        private void OnEnable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rootObject, 丏业丟一东丂东丘丛:  false);
            this.丝一丅丆三东丂丞七();
            Rilisoft.LobbyItemsController.三丘丒丞丕下丘万丂(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftBundleBanner::一世业丆丛且下且丙(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)));
        }
        private void OnDisable()
        {
            Rilisoft.LobbyItemsController.万丂丐一世业世万丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftBundleBanner::一世业丆丛且下且丙(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)));
            this.丑不且东丛专丁丌丘 = 0;
        }
        private void Update()
        {
            if((Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0) || (null == 0))
            {
                goto label_5;
            }
            
            if(丒丙丙世丅且下丁丐() != this.丑不且东丛专丁丌丘)
            {
                goto label_8;
            }
            
            return;
            label_5:
            if(this.丑不且东丛专丁丌丘 == null)
            {
                    return;
            }
            
            label_8:
            this.丝一丅丆三东丂丞七();
        }
        private void 一世业丆丛且下且丙(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            if(this.丑不且东丛专丁丌丘 == null)
            {
                    return;
            }
            
            if(下丅丙一丂丗丅丝七.丒丙丙世丅且下丁丐() != this.丑不且东丛专丁丌丘)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            string val_50;
            string val_51;
            System.Collections.Generic.List<UILabel> val_52;
            string val_53;
            string val_54;
            var val_55;
            var val_56;
            if(((Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0) && (null != 0)) && (丒丙丙世丅且下丁丐() != null))
            {
                    if(且丅一一三七专丑丏() != true)
            {
                    if(丒丙丙世丅且下丁丐().IsMyBandle == false)
            {
                goto label_15;
            }
            
            }
            
            }
            
            this.丑不且东丛专丁丌丘 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rootObject, 丏业丟一东丂东丘丛:  false);
            return;
            label_15:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rootObject, 丏业丟一东丂东丘丛:  true);
            Rilisoft.LobbyItemsBundle val_6 = 丒丙丙世丅且下丁丐();
            this.丑不且东丛专丁丌丘 = val_6;
            val_6.七丄丟不且丐丙万专();
            if(this.丑不且东丛专丁丌丘.WeaponReward == null)
            {
                goto label_25;
            }
            
            三丅丁丗丗丝丂万且 val_8 = this.丑不且东丛专丁丌丘.WeaponReward;
            if(val_8 == null)
            {
                goto label_26;
            }
            
            val_50 = val_8.与不丞丑七丘丁丂丛();
            goto label_27;
            label_25:
            if((this.丑不且东丛专丁丌丘.GemsReward.丟丂丞不专丆万丒世() < 1) || (this.丑不且东丛专丁丌丘.CoinsReward.丟丂丞不专丆万丒世() < 1))
            {
                goto label_32;
            }
            
            val_51 = "Textures/Bank/Coins_Shop_Mixed";
            goto label_44;
            label_26:
            val_50 = 0.与不丞丑七丘丁丂丛();
            label_27:
            UnityEngine.Texture val_16 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_50, 七丆丒与丗丌丄且丂:  val_8.万上丄下业丛丌不丈(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            val_52 = this._itemNameLabels;
            val_53 = val_8.丟丄丞丅丑七丞丄丞();
            goto label_40;
            label_32:
            if(this.丑不且东丛专丁丌丘.GemsReward.丟丂丞不专丆万丒世() < 1)
            {
                goto label_43;
            }
            
            val_51 = "Textures/Bank/Coins_Shop_Gem_4";
            goto label_44;
            label_43:
            if(this.丑不且东丛专丁丌丘.CoinsReward.丟丂丞不专丆万丒世() < 1)
            {
                goto label_47;
            }
            
            val_51 = "Textures/Bank/Coins_Shop_6";
            label_44:
            UnityEngine.Texture val_22 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_51);
            val_54 = 0;
            label_108:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_54)) != false)
            {
                    val_54 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4835");
            }
            
            val_52 = this._itemNameLabels;
            val_53 = val_54;
            label_40:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_52, 丕丗丘丑丛与丑业丒:  val_53);
            if(this.丑不且东丛专丁丌丘.GemsReward.丟丂丞不专丆万丒世() >= 1)
            {
                    var val_29 = (this.丑不且东丛专丁丌丘.CoinsReward.丟丂丞不专丆万丒世() > 0) ? 1 : 0;
            }
            else
            {
                    val_55 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._plusContainer, 丏业丟一东丂东丘丛:  false);
            if(this.丑不且东丛专丁丌丘.GemsReward.丟丂丞不专丆万丒世() >= 1)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsContainer, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._gemsCountLabels, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丑不且东丛专丁丌丘.GemsReward.丟丂丞不专丆万丒世()));
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsContainer, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this.丑不且东丛专丁丌丘.CoinsReward.丟丂丞不专丆万丒世() >= 1)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsContainer, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._coinsCountLabels, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丑不且东丛专丁丌丘.CoinsReward.丟丂丞不专丆万丒世()));
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsContainer, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this.丑不且东丛专丁丌丘.GemsReward.丟丂丞不专丆万丒世() > 0)
            {
                    val_56 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._currencyTable.gameObject, 丏业丟一东丂东丘丛:  (this.丑不且东丛专丁丌丘.CoinsReward.丟丂丞不专丆万丒世() > 0) ? 1 : 0);
            this._currencyTable.repositionNow = true;
            if(coinsShop.丏丅世七丞与丛丘业() != false)
            {
                    string val_47 = this.丑不且东丛专丁丌丘.丌丕七与与万业丂丁();
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._profitLabels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278"));
            return;
            label_47:
            UnityEngine.Texture val_49 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/bundle_my_icon1_big");
            goto label_108;
        }
        public void U_OnClick()
        {
            if(this.丑不且东丛专丁丌丘 == null)
            {
                    return;
            }
            
            if(this.丑不且东丛专丁丌丘.WeaponReward == null)
            {
                    return;
            }
            
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丈丑丙丌丛东丙丅丐(丆万一不丌且东丐丐:  this.丑不且东丛专丁丌丘.WeaponReward.与不丞丑七丘丁丂丛(), 丌丒丝东丌下丕丁丅:  1);
        }
        public LobbyCraftBundleBanner()
        {
        
        }
    
    }

}
