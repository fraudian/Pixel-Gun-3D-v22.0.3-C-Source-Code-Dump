using UnityEngine;

namespace Rilisoft
{
    public class BankShopView : MonoBehaviour
    {
        // Fields
        private UnityEngine.BoxCollider 丅专丛且丂且丙世丅;
        private Rilisoft.ButtonHandler 世三丅丕一世且与丙;
        private UIButton 三上丕丌丘丆丂丗专;
        private UnityEngine.BoxCollider 丕上世不丒丒丕一三;
        private Rilisoft.ButtonHandler 丆丆丁丈丕与业丒丄;
        private UIButton 丕丘三且丅丁丛且与;
        public UnityEngine.GameObject ArmoryBlinkHint;
        public UnityEngine.GameObject BankButton;
        public UnityEngine.GameObject BgSimple;
        public UnityEngine.GameObject BgX3;
        public UnityEngine.GameObject[] coinsObjects;
        public UnityEngine.GameObject[] gemsObjects;
        public UnityEngine.GameObject[] pixelBucksObjects;
        public UISprite eventIconSprite;
        public UnityEngine.GameObject[] eventObjects;
        public UnityEngine.GameObject FrameX3Bank;
        public UISprite frameX3Indicators;
        public UnityEngine.GameObject FrameX3Shop;
        public UnityEngine.GameObject GoArmoryHint;
        public UILabel hintLabel;
        public UnityEngine.Transform ObjectForCenter;
        public UnityEngine.GameObject ShopButton;
        public UnityEngine.GameObject[] ticketObjects;
        public UnityEngine.GameObject goldContainer;
        
        // Properties
        public UIButton 丂丌丅丟东业三丈与 { get; }
        public Rilisoft.ButtonHandler 一丑万丈丕丂业业丐 { get; }
        public UnityEngine.BoxCollider 丈不丂下专丟丕专东 { get; }
        public UIButton 丑丑与丆丏丙丛丈专 { get; }
        public Rilisoft.ButtonHandler 下世丒丞丁东业万丞 { get; }
        public UnityEngine.BoxCollider 下万丐业七上丛丈丞 { get; }
        
        // Methods
        public UIButton get_ShopButtonScript()
        {
            UIButton val_3;
            if(this.丕丘三且丅丁丛且与 == 0)
            {
                    this.丕丘三且丅丁丛且与 = this.ShopButton.GetComponent<UIButton>();
                return val_3;
            }
            
            val_3 = this.丕丘三且丅丁丛且与;
            return val_3;
        }
        public Rilisoft.ButtonHandler get_ShopButtonHandler()
        {
            Rilisoft.ButtonHandler val_3;
            if(this.丆丆丁丈丕与业丒丄 == 0)
            {
                    this.丆丆丁丈丕与业丒丄 = this.ShopButton.GetComponent<Rilisoft.ButtonHandler>();
                return val_3;
            }
            
            val_3 = this.丆丆丁丈丕与业丒丄;
            return val_3;
        }
        public UnityEngine.BoxCollider get_ShopButtonCollider()
        {
            UnityEngine.BoxCollider val_3;
            if(this.丕上世不丒丒丕一三 == 0)
            {
                    this.丕上世不丒丒丕一三 = this.ShopButton.GetComponent<UnityEngine.BoxCollider>();
                return val_3;
            }
            
            val_3 = this.丕上世不丒丒丕一三;
            return val_3;
        }
        public UIButton get_BankButtonScript()
        {
            UIButton val_3;
            if(this.三上丕丌丘丆丂丗专 == 0)
            {
                    this.三上丕丌丘丆丂丗专 = this.BankButton.GetComponent<UIButton>();
                return val_3;
            }
            
            val_3 = this.三上丕丌丘丆丂丗专;
            return val_3;
        }
        public Rilisoft.ButtonHandler get_BankButtonHandler()
        {
            Rilisoft.ButtonHandler val_3;
            if(this.世三丅丕一世且与丙 == 0)
            {
                    this.世三丅丕一世且与丙 = this.BankButton.GetComponent<Rilisoft.ButtonHandler>();
                return val_3;
            }
            
            val_3 = this.世三丅丕一世且与丙;
            return val_3;
        }
        public UnityEngine.BoxCollider get_BankButtonCollider()
        {
            UnityEngine.BoxCollider val_3;
            if(this.丅专丛且丂且丙世丅 == 0)
            {
                    this.丅专丛且丂且丙世丅 = this.BankButton.GetComponent<UnityEngine.BoxCollider>();
                return val_3;
            }
            
            val_3 = this.丅专丛且丂且丙世丅;
            return val_3;
        }
        public BankShopView()
        {
        
        }
    
    }

}
