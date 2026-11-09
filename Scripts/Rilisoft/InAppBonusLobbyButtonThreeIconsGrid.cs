using UnityEngine;

namespace Rilisoft
{
    public class InAppBonusLobbyButtonThreeIconsGrid : InAppBonusLobbyButtonAbstractIconsGrid
    {
        // Fields
        private Rilisoft.InAppBonusLobbyButtonDependingObject _centerIcon;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _leftIcon;
        private UnityEngine.GameObject _leftPlus;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _rightIcon;
        private UnityEngine.GameObject _rightPlus;
        
        // Methods
        public override void ShowWeaponIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UIBasicSprite val_1 = this._centerIcon.Texture;
            UnityEngine.Texture val_2 = 0.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  一丐丗丁丞丆丅丟丄.WeaponId);
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowRoyaleIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.BonusData val_22;
            System.Collections.Generic.List<System.String> val_23;
            val_22 = 一丐丗丁丞丆丅丟丄;
            if(一丐丗丁丞丆丅丟丄.Royales.Count == 1)
            {
                    UIBasicSprite val_2 = this._centerIcon.Texture;
                string val_3 = 一丐丗丁丞丆丅丟丄.Royales.Item[0];
                UnityEngine.Texture val_4 = val_3.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_3);
                this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  val_22);
                return;
            }
            
            val_23 = 一丐丗丁丞丆丅丟丄.Royales;
            if(val_23.Count != 3)
            {
                    return;
            }
            
            UIBasicSprite val_6 = this._leftIcon.Texture;
            string val_7 = 一丐丗丁丞丆丅丟丄.Royales.Item[0];
            UnityEngine.Texture val_8 = val_7.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_7);
            UIBasicSprite val_9 = this._centerIcon.Texture;
            string val_10 = 一丐丗丁丞丆丅丟丄.Royales.Item[1];
            UnityEngine.Texture val_11 = val_10.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_10);
            UIBasicSprite val_12 = this._rightIcon.Texture;
            string val_13 = 一丐丗丁丞丆丅丟丄.Royales.Item[2];
            UnityEngine.Texture val_14 = val_13.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_13);
            val_22 = ???;
            val_23 = ???;
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        }
        public override void ShowPartsIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.东且东丒丐世丐丞丒 val_2 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  一丐丗丁丞丆丅丟丄.DetailsItemId);
            if(val_2 != null)
            {
                    string val_4 = val_2.丙三专万丛丟万丝丘();
                UnityEngine.Texture val_5 = val_4.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  val_4);
            }
            else
            {
                    UnityEngine.Texture val_6 = this._centerIcon.Texture.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  一丐丗丁丞丆丅丟丄.DetailsItemId);
            }
            
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowEventCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            EventCurrencyData val_2 = 一丐丗丁丞丆丅丟丄.EventCurrencies.Item[0];
            EventCurrencyData val_4 = 一丐丗丁丞丆丅丟丄.EventCurrencies.Item[0];
            string val_5 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  val_2.EventType).丐丙丁一丅丞不丅丟(丑丏万丈丟丝丝丌丗:  val_4.Count);
            UnityEngine.Texture val_6 = val_5.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  val_5);
            UIBasicSprite val_7 = this._centerIcon.Texture;
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowBattlePassCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Texture val_1 = 43704.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/bp_currency_10");
            UIBasicSprite val_2 = this._centerIcon.Texture;
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowWearIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UIBasicSprite val_1 = this._centerIcon.Texture;
            string val_2 = 一丐丗丁丞丆丅丟丄.Wears.Item[0];
            UnityEngine.Texture val_3 = val_2.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_2);
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowLobbyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_3 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  一丐丗丁丞丆丅丟丄.LobbyItems.Item[0]);
            if(val_3 == null)
            {
                    return;
            }
            
            string val_4 = val_3.丙三专万丛丟万丝丘();
            UnityEngine.Texture val_5 = val_4.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  val_4);
            UIBasicSprite val_6 = this._centerIcon.Texture;
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowPetIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  一丐丗丁丞丆丅丟丄.PetId)) == null)
            {
                    return;
            }
            
            UnityEngine.Texture val_5 = this._centerIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  System.String.Format(format:  "Pets/Icons/{0}_icon", arg0:  val_2.Id));
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowOfferPackIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.业丙丘丆东丈丕丂丄 val_21;
            string val_22;
            var val_24;
            val_21 = 一丐丗丁丞丆丅丟丄.Offer;
            if(val_21 == null)
            {
                goto label_28;
            }
            
            if(val_21.丑且一丐东三不丈丝() != 60)
            {
                goto label_3;
            }
            
            System.Nullable<AdaptiveModuleType> val_2 = val_21.下丐丝万丞丙丁丂丑();
            if(((-289215992) & 1) == 0)
            {
                goto label_6;
            }
            
            System.Nullable<AdaptiveModuleType> val_3 = val_21.下丐丝万丞丙丁丂丑();
            if((val_3.HasValue.丙东专丂世丈丏丁丂() != 70) || (((-289215992) & 1) == 0))
            {
                goto label_6;
            }
            
            val_22 = "Textures/Bank/Coins_Shop_Mixed";
            goto label_13;
            label_3:
            if(val_21.丑且一丐东三不丈丝() != 80)
            {
                goto label_8;
            }
            
            val_22 = "OfferIcons/ModuleChests/ModuleChest_Tutorial_icon";
            goto label_13;
            label_6:
            System.Nullable<AdaptiveModuleType> val_6 = val_21.下丐丝万丞丙丁丂丑();
            if(((-289215992) & 1) == 0)
            {
                goto label_12;
            }
            
            System.Nullable<AdaptiveModuleType> val_7 = val_21.下丐丝万丞丙丁丂丑();
            if((val_7.HasValue.丙东专丂世丈丏丁丂() != 90) || (((-289215992) & 1) == 0))
            {
                goto label_12;
            }
            
            val_22 = "OfferIcons\\adaptive-gadgets";
            goto label_13;
            label_12:
            val_21 = val_21.丏与丅专三丙与丘丒();
            if((val_21 == null) || ((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_21)) == false))
            {
                goto label_28;
            }
            
            UnityEngine.Texture val_12 = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  val_21).Texture;
            goto label_17;
            label_8:
            if(val_21.丑且一丐东三不丈丝() != 120)
            {
                goto label_18;
            }
            
            Rilisoft.七丈业与与不七丈丟 val_14 = val_21.丁专丗万三上丟三丆();
            val_24 = System.String.Format(format:  "OfferIcons/Lobby/{0}", arg0:  val_14.丒上一丁丆丛东专丙.下丄丈不与世丐业专);
            goto label_21;
            label_18:
            OfferModule val_16 = val_21.丑且一丐东三不丈丝();
            val_21 = 0;
            if(val_16 != 150)
            {
                goto label_28;
            }
            
            val_22 = "OfferIcons/Constructable/constructable-prom-icon-mini";
            label_13:
            label_21:
            label_17:
            val_21 = val_16.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  val_22);
            label_28:
            bool val_18 = UnityEngine.Object.op_Equality(x:  val_21, y:  0);
            if(val_18 != false)
            {
                    val_21 = val_18.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/MiniOfferIcons/offer_icon_offerPack2");
            }
            
            UIBasicSprite val_20 = this._centerIcon.Texture;
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowGadgetsIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.BonusData val_22;
            System.Collections.Generic.List<System.String> val_23;
            val_22 = 一丐丗丁丞丆丅丟丄;
            if(一丐丗丁丞丆丅丟丄.Gadgets.Count == 1)
            {
                    UIBasicSprite val_2 = this._centerIcon.Texture;
                string val_3 = 一丐丗丁丞丆丅丟丄.Gadgets.Item[0];
                UnityEngine.Texture val_4 = val_3.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_3);
                this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  val_22);
                return;
            }
            
            val_23 = 一丐丗丁丞丆丅丟丄.Gadgets;
            if(val_23.Count != 3)
            {
                    return;
            }
            
            UIBasicSprite val_6 = this._leftIcon.Texture;
            string val_7 = 一丐丗丁丞丆丅丟丄.Gadgets.Item[0];
            UnityEngine.Texture val_8 = val_7.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_7);
            UIBasicSprite val_9 = this._centerIcon.Texture;
            string val_10 = 一丐丗丁丞丆丅丟丄.Gadgets.Item[1];
            UnityEngine.Texture val_11 = val_10.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_10);
            UIBasicSprite val_12 = this._rightIcon.Texture;
            string val_13 = 一丐丗丁丞丆丅丟丄.Gadgets.Item[2];
            UnityEngine.Texture val_14 = val_13.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_13);
            val_22 = ???;
            val_23 = ???;
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        }
        public override void ShowTryGunIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UIBasicSprite val_1 = this._centerIcon.Texture;
            UnityEngine.Texture val_2 = 0.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  一丐丗丁丞丆丅丟丄.WeaponId);
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowMixIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Texture val_2 = this._centerIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/MiniOfferIcons/offer_icon_mix");
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowLeprechauntIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Texture val_2 = this._centerIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/MiniOfferIcons/offer_icon_leprechaun2");
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowVipIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Texture val_2 = this._centerIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/MiniOfferIcons/offer_icon_VIP");
            this.丑丄丁丆丌丐七世且(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UIBasicSprite val_1 = this._leftIcon.Texture;
            UIBasicSprite val_2 = this._rightIcon.Texture;
            if(一丐丗丁丞丆丅丟丄.Coins < 1)
            {
                goto label_6;
            }
            
            if(一丐丗丁丞丆丅丟丄.Gems < 1)
            {
                goto label_7;
            }
            
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "This type of object cannot show only two icons. Use `InAppBonusLobbyButtonTwoIconsGrid` instead.");
            return;
            label_6:
            if(一丐丗丁丞丆丅丟丄.Gems < 1)
            {
                    return;
            }
            
            this.且丝丛丘丘三业与丘(与丄不丌一世东丁丙:  this._centerIcon);
            return;
            label_7:
            this.丂世不下上丟丞与丅(与丄不丌一世东丁丙:  this._centerIcon);
        }
        private void 丑丄丁丆丌丐七世且(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.InAppBonusLobbyButtonDependingObject val_7;
            bool val_8;
            int val_9;
            int val_10;
            if(一丐丗丁丞丆丅丟丄.Offer == null)
            {
                goto label_2;
            }
            
            if(一丐丗丁丞丆丅丟丄.Offer.丑且一丐东三不丈丝() != 150)
            {
                goto label_3;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftPlus, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rightPlus, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._leftIcon, 丏业丟一东丂东丘丛:  false);
            val_7 = this._rightIcon;
            val_8 = 0;
            goto label_6;
            label_2:
            val_9 = 一丐丗丁丞丆丅丟丄.Coins;
            val_10 = 一丐丗丁丞丆丅丟丄.Gems;
            goto label_10;
            label_3:
            val_9 = 一丐丗丁丞丆丅丟丄.Coins;
            val_10 = 一丐丗丁丞丆丅丟丄.Gems;
            if(一丐丗丁丞丆丅丟丄.Offer == null)
            {
                goto label_10;
            }
            
            System.Nullable<AdaptiveModuleType> val_2 = 一丐丗丁丞丆丅丟丄.Offer.下丐丝万丞丙丁丂丑();
            if((val_2.HasValue.丙东专丂世丈丏丁丂() != 70) || (((-287919384) & 1) == 0))
            {
                goto label_10;
            }
            
            val_10 = 0;
            val_9 = 0;
            goto label_13;
            label_10:
            if(val_9 >= 1)
            {
                    this.丂世不下上丟丞与丅(与丄不丌一世东丁丙:  this._leftIcon);
            }
            
            if(val_10 >= 1)
            {
                    this.且丝丛丘丘三业与丘(与丄不丌一世东丁丙:  this._rightIcon);
            }
            
            label_13:
            bool val_4 = (val_9 > 0) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftPlus, 丏业丟一东丂东丘丛:  val_4);
            bool val_5 = (val_10 > 0) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rightPlus, 丏业丟一东丂东丘丛:  val_5);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._leftIcon, 丏业丟一东丂东丘丛:  val_4);
            val_7 = this._rightIcon;
            val_8 = val_5;
            label_6:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  val_8);
        }
        private void 丂世不下上丟丞与丅(Rilisoft.InAppBonusLobbyButtonDependingObject 与丄不丌一世东丁丙)
        {
            UIBasicSprite val_1 = 与丄不丌一世东丁丙.Texture;
            UnityEngine.Texture val_2 = val_1.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "Textures/Bank/Coins_Shop_3");
            if(val_1 == null)
            {
                
            }
        
        }
        private void 且丝丛丘丘三业与丘(Rilisoft.InAppBonusLobbyButtonDependingObject 与丄不丌一世东丁丙)
        {
            UIBasicSprite val_1 = 与丄不丌一世东丁丙.Texture;
            UnityEngine.Texture val_2 = val_1.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "Textures/Bank/Coins_Shop_Gem_3");
            if(val_1 == null)
            {
                
            }
        
        }
        public InAppBonusLobbyButtonThreeIconsGrid()
        {
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
