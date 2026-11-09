using UnityEngine;

namespace PGCompany
{
    internal class ClanWarEndUIContainer : PGBehaviour
    {
        // Fields
        private UITexture _currentDivisionTexture;
        private UITexture _nextDivisionTexture;
        private UILabel _divisionLabel;
        private PGCompany.InventoryItemView _item;
        private WidgetLayout _widgetLayout;
        private UITexture _chestTexture;
        private UILabel _chestNameLabel;
        private UITexture _giftChestTexture;
        private UILabel _giftChestNameLabel;
        private UILabel _giftChestCountLabel;
        private UITextureMasked _warGiftChestTexture;
        private UnityEngine.GameObject _warGiftChestContainer;
        private PGCompany.ItemCurrencyUI currencyRewardUi;
        
        // Methods
        internal void 丅丈丞业专丁丈上且(一一万丒与专丙丁丛 丅丅下丟丑专下与一, PGCompany.丗丟丄丈东丝丕丄世 丐下丝丘丑丟丟丗丌, string 丝三一丁一丛丒丄一, PGCompany.三东丏不丗世丅丌丄 丏一丅三不世丐且丄, PGCompany.三东丏不丗世丅丌丄 丐丙东下万丕丈专丕)
        {
            string val_16;
            WidgetLayout val_17;
            UnityEngine.Texture val_18;
            UILabel val_19;
            PGCompany.ItemCurrencyUI val_20;
            var val_21;
            UnityEngine.MonoBehaviour val_22;
            val_16 = 丐下丝丘丑丟丟丗丌;
            val_17 = this;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._divisionLabel, 丕丗丘丑丛与丑业丒:  丝三一丁一丛丒丄一);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._currentDivisionTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "Shields/tournament_shield_{0}", arg0:  丅丅下丟丑专下与一.ToString())));
            if(val_16 != null)
            {
                    val_18 = val_16;
            }
            else
            {
                    val_18 = 0;
            }
            
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._chestTexture, 与万丆丛丒万丝丙丑:  val_18);
            val_19 = this._chestNameLabel;
            if(val_16 != null)
            {
                    val_16 = val_16;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_19, 丕丗丘丑丛与丑业丒:  val_16);
            if(丏一丅三不世丐且丄 != null)
            {
                    PGCompany.七东万三万丒丏一丁 val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.七东万三万丒丏一丁>(丞世不丒下上上丝丑:  丏一丅三不世丐且丄.业东丅东丌上丗丑不());
                丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._giftChestTexture, 与万丆丛丒万丝丙丑:  val_6);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._giftChestNameLabel, 丕丗丘丑丛与丑业丒:  val_6.七业丑不七丐业丟丂());
                val_19 = this._warGiftChestTexture;
                丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_19, 与万丆丛丒万丝丙丑:  val_6);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._giftChestCountLabel, 丕丗丘丑丛与丑业丒:  丏一丅三不世丐且丄.丂丁丏一丙丛业且丌().ToString());
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._giftChestCountLabel, 丏业丟一东丂东丘丛:  (丏一丅三不世丐且丄.丂丁丏一丙丛业且丌() > 1) ? 1 : 0);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warGiftChestContainer, 丏业丟一东丂东丘丛:  (丏一丅三不世丐且丄 != 0) ? 1 : 0);
            val_20 = this.currencyRewardUi;
            if(val_20 == 0)
            {
                goto label_21;
            }
            
            if((丐丙东下万丕丈专丕 == null) || (丐丙东下万丕丈专丕.丂丁丏一丙丛业且丌() < 1))
            {
                goto label_23;
            }
            
            val_20 = this.currencyRewardUi;
            val_20.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  丐丙东下万丕丈专丕, 丗丂丞丛丒丒丟万丗:  false);
            val_21 = 1;
            val_22 = this.currencyRewardUi;
            goto label_27;
            label_21:
            UnityEngine.Debug.LogError(message:  "ERROR currencyRewardUi == null");
            goto label_30;
            label_23:
            val_22 = this.currencyRewardUi;
            val_21 = 0;
            label_27:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_22, 丏业丟一东丂东丘丛:  false);
            label_30:
            if(this._widgetLayout == 0)
            {
                    return;
            }
            
            this._widgetLayout.CollectWidgets();
            val_17 = this._widgetLayout;
            val_17.Reposition();
        }
        internal void 与上丘七业丝丞丌世(一一万丒与专丙丁丛 专丑丕丄丗丂一丝且, 一一万丒与专丙丁丛 东且万丕上丑丁丅丆, PGCompany.丗丟丄丈东丝丕丄世 丐下丝丘丑丟丟丗丌, string 丟丅且七丅东丂不丐, PGCompany.三东丏不丗世丅丌丄 丏一丅三不世丐且丄, PGCompany.三东丏不丗世丅丌丄 丐丙东下万丕丈专丕)
        {
            this.丅丈丞业专丁丈上且(丅丅下丟丑专下与一:  专丑丕丄丗丂一丝且, 丐下丝丘丑丟丟丗丌:  丐下丝丘丑丟丟丗丌, 丝三一丁一丛丒丄一:  丟丅且七丅东丂不丐, 丏一丅三不世丐且丄:  丏一丅三不世丐且丄, 丐丙东下万丕丈专丕:  丐丙东下万丕丈专丕);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._nextDivisionTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "Shields/tournament_shield_{0}", arg0:  东且万丕上丑丁丅丆.ToString())));
        }
        internal void 丆丕丕丈三丐上七丑(一一万丒与专丙丁丛 专丑丕丄丗丂一丝且, 一一万丒与专丙丁丛 东且万丕上丑丁丅丆, System.Collections.Generic.IEnumerable<PGCompany.丗丟丄丈东丝丕丄世> 丙丙与丕不丞丛丐业, PGCompany.丗丟丄丈东丝丕丄世 丐下丝丘丑丟丟丗丌, PGCompany.三东丏不丗世丅丌丄 丏一丅三不世丐且丄, string 丄三丛下丟且万丞丑, PGCompany.三东丏不丗世丅丌丄 丐丙东下万丕丈专丕)
        {
            var val_11;
            var val_12;
            this.与上丘七业丝丞丌世(专丑丕丄丗丂一丝且:  专丑丕丄丗丂一丝且, 东且万丕上丑丁丅丆:  东且万丕上丑丁丅丆, 丐下丝丘丑丟丟丗丌:  丐下丝丘丑丟丟丗丌, 丟丅且七丅东丂不丐:  丄三丛下丟且万丞丑, 丏一丅三不世丐且丄:  丏一丅三不世丐且丄, 丐丙东下万丕丈专丕:  丐丙东下万丕丈专丕);
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Collections.Generic.IEnumerator<T> val_2 = 丙丙与丕不丞丛丐业.GetEnumerator();
            label_21:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            UnityEngine.Object.Instantiate<PGCompany.InventoryItemView>(original:  this._item, parent:  this._widgetLayout.transform).Setup(与且专丈不万东一万:  val_2.Current);
            goto label_21;
            label_11:
            val_11 = 0;
            val_12 = 0;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_2.Dispose();
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._item, 丏业丟一东丂东丘丛:  false);
            if(this._widgetLayout == 0)
            {
                    return;
            }
            
            this._widgetLayout.CollectWidgets();
            this._widgetLayout.Reposition();
        }
        public ClanWarEndUIContainer()
        {
        
        }
    
    }

}
