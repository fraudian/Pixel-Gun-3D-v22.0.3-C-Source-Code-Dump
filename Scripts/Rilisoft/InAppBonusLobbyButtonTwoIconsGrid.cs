using UnityEngine;

namespace Rilisoft
{
    public class InAppBonusLobbyButtonTwoIconsGrid : InAppBonusLobbyButtonAbstractIconsGrid
    {
        // Fields
        private UnityEngine.GameObject _centerPlus;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _leftIcon;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _rightIcon;
        
        // Methods
        public override void ShowWeaponIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UIBasicSprite val_1 = this._leftIcon.Texture;
            UnityEngine.Texture val_2 = 0.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  一丐丗丁丞丆丅丟丄.WeaponId);
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowRoyaleIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.BonusData val_19;
            System.Collections.Generic.List<System.String> val_20;
            val_19 = 一丐丗丁丞丆丅丟丄;
            if(一丐丗丁丞丆丅丟丄.Royales.Count == 1)
            {
                    UIBasicSprite val_2 = this._leftIcon.Texture;
                string val_3 = 一丐丗丁丞丆丅丟丄.Royales.Item[0];
                UnityEngine.Texture val_4 = val_3.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_3);
                this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  val_19);
                return;
            }
            
            val_20 = 一丐丗丁丞丆丅丟丄.Royales;
            if(val_20.Count != 2)
            {
                    return;
            }
            
            UIBasicSprite val_6 = this._leftIcon.Texture;
            string val_7 = 一丐丗丁丞丆丅丟丄.Royales.Item[0];
            UnityEngine.Texture val_8 = val_7.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_7);
            UIBasicSprite val_9 = this._rightIcon.Texture;
            string val_10 = 一丐丗丁丞丆丅丟丄.Royales.Item[1];
            UnityEngine.Texture val_11 = val_10.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_10);
            val_19 = ???;
            val_20 = ???;
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
                    UnityEngine.Texture val_6 = this._leftIcon.Texture.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  一丐丗丁丞丆丅丟丄.DetailsItemId);
            }
            
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowEventCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            EventCurrencyData val_2 = 一丐丗丁丞丆丅丟丄.EventCurrencies.Item[0];
            EventCurrencyData val_4 = 一丐丗丁丞丆丅丟丄.EventCurrencies.Item[0];
            string val_5 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  val_2.EventType).丐丙丁一丅丞不丅丟(丑丏万丈丟丝丝丌丗:  val_4.Count);
            UnityEngine.Texture val_6 = val_5.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  val_5);
            UIBasicSprite val_7 = this._leftIcon.Texture;
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowBattlePassCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Texture val_1 = 43721.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/bp_currency_10");
            UIBasicSprite val_2 = this._leftIcon.Texture;
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowWearIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UIBasicSprite val_1 = this._leftIcon.Texture;
            string val_2 = 一丐丗丁丞丆丅丟丄.Wears.Item[0];
            UnityEngine.Texture val_3 = val_2.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_2);
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
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
            UIBasicSprite val_6 = this._leftIcon.Texture;
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowPetIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  一丐丗丁丞丆丅丟丄.PetId)) == null)
            {
                    return;
            }
            
            UnityEngine.Texture val_5 = this._leftIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  System.String.Format(format:  "Pets/Icons/{0}_icon", arg0:  val_2.Id));
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowOfferPackIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            string val_5;
            if(一丐丗丁丞丆丅丟丄.Offer.丑且一丐东三不丈丝() == 150)
            {
                    val_5 = "OfferIcons/Constructable/constructable-prom-icon-mini";
            }
            else
            {
                    val_5 = "OfferIcons/MiniOfferIcons/offer_icon_offerPack2";
            }
            
            UnityEngine.Texture val_3 = this._leftIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  val_5);
            if(一丐丗丁丞丆丅丟丄.Offer.丑且一丐东三不丈丝() == 150)
            {
                    return;
            }
            
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowGadgetsIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.BonusData val_19;
            System.Collections.Generic.List<System.String> val_20;
            val_19 = 一丐丗丁丞丆丅丟丄;
            if(一丐丗丁丞丆丅丟丄.Gadgets.Count == 1)
            {
                    UIBasicSprite val_2 = this._leftIcon.Texture;
                string val_3 = 一丐丗丁丞丆丅丟丄.Gadgets.Item[0];
                UnityEngine.Texture val_4 = val_3.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_3);
                this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  val_19);
                return;
            }
            
            val_20 = 一丐丗丁丞丆丅丟丄.Gadgets;
            if(val_20.Count != 2)
            {
                    return;
            }
            
            UIBasicSprite val_6 = this._leftIcon.Texture;
            string val_7 = 一丐丗丁丞丆丅丟丄.Gadgets.Item[0];
            UnityEngine.Texture val_8 = val_7.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_7);
            UIBasicSprite val_9 = this._rightIcon.Texture;
            string val_10 = 一丐丗丁丞丆丅丟丄.Gadgets.Item[1];
            UnityEngine.Texture val_11 = val_10.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  val_10);
            val_19 = ???;
            val_20 = ???;
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        }
        public override void ShowTryGunIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UIBasicSprite val_1 = this._leftIcon.Texture;
            UnityEngine.Texture val_2 = 0.丏东东上一东丈且丈(丕丁下丌不万丅丞丛:  一丐丗丁丞丆丅丟丄.WeaponId);
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowMixIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Texture val_2 = this._leftIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/MiniOfferIcons/offer_icon_mix");
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowLeprechauntIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Texture val_2 = this._leftIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/MiniOfferIcons/offer_icon_leprechaun2");
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowVipIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.Texture val_2 = this._leftIcon.Texture.丐丝丛与丆丂丐丆专(丛丄业丕且丗下一万:  "OfferIcons/MiniOfferIcons/offer_icon_VIP");
            this.丘业丁万与东丄丆丌(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public override void ShowCurrencyIcons(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄.Coins >= 1)
            {
                    this.丂世不下上丟丞与丅(与丄不丌一世东丁丙:  this._leftIcon);
            }
            
            if(一丐丗丁丞丆丅丟丄.Gems < 1)
            {
                    return;
            }
            
            this.且丝丛丘丘三业与丘(与丄不丌一世东丁丙:  this._rightIcon);
        }
        private void 丘业丁万与东丄丆丌(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.InAppBonusLobbyButtonDependingObject val_3;
            var val_4;
            var val_5;
            if(一丐丗丁丞丆丅丟丄.Coins >= 1)
            {
                    val_3 = this;
                this.丂世不下上丟丞与丅(与丄不丌一世东丁丙:  this._rightIcon);
            }
            else
            {
                    val_3 = this._rightIcon;
                if(一丐丗丁丞丆丅丟丄.Gems >= 1)
            {
                    this.且丝丛丘丘三业与丘(与丄不丌一世东丁丙:  this._rightIcon);
            }
            
            }
            
            if(一丐丗丁丞丆丅丟丄.Coins > 0)
            {
                    val_4 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  mem[this._rightIcon], 丏业丟一东丂东丘丛:  (一丐丗丁丞丆丅丟丄.Gems > 0) ? 1 : 0);
            if(一丐丗丁丞丆丅丟丄.Coins > 0)
            {
                    val_5 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._centerPlus, 丏业丟一东丂东丘丛:  (一丐丗丁丞丆丅丟丄.Gems > 0) ? 1 : 0);
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
        public InAppBonusLobbyButtonTwoIconsGrid()
        {
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
