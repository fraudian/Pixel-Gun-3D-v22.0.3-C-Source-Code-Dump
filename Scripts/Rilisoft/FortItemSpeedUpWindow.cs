using UnityEngine;

namespace Rilisoft
{
    public class FortItemSpeedUpWindow : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.东且东丒丐世丐丞丒 东丏丂丗与与丟七上;
        private System.Action<Rilisoft.FortItemSpeedUpWindow.上三上与丒不丒丘丝, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒> 一万丅世丏丏专七业;
        private Rilisoft.东且东丒丐世丐丞丒 丁丛丑丄丟丕与丈且;
        private UILabel _labelSpeedUpItemName;
        private UILabel _labelSpeedUpTimeLeft;
        private UIBasicSprite _textureSpeedUpItem;
        private UILabel _labelBuyItemName;
        private UIBasicSprite _textureBuyItem;
        private Rilisoft.PriceView _btnSpeedUp;
        private Rilisoft.PriceView _btnBuy;
        
        // Properties
        public bool 七七业丒丟丝丘不丞 { get; }
        private UIBasicSprite 不一七不丗与丟丛一 { get; }
        private UIBasicSprite 丞丈丄丝七丅一丈丈 { get; }
        
        // Methods
        public bool get_IsVisible()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void Show(Rilisoft.东且东丒丐世丐丞丒 丆丝丕上丛且丗丝丙, Rilisoft.东且东丒丐世丐丞丒 丑丟一丄丟丞七世丘, System.Action<Rilisoft.FortItemSpeedUpWindow.上三上与丒不丒丘丝, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒> 七丈丐与不一丘东一)
        {
            Rilisoft.东且东丒丐世丐丞丒 val_15 = 丑丟一丄丟丞七世丘;
            this.gameObject.SetActive(value:  true);
            this.东丏丂丗与与丟七上 = val_15;
            this.一万丅世丏丏专七业 = 七丈丐与不一丘东一;
            this.丁丛丑丄丟丕与丈且 = 丆丝丕上丛且丗丝丙;
            if(丆丝丕上丛且丗丝丙 != null)
            {
                    this._labelSpeedUpItemName.text = 丆丝丕上丛且丗丝丙.丙丕丞且丕不丘丙丑().东丙上东业丆不丟丘();
                UIBasicSprite val_4 = this.丗东丞丞七丟丛丕丑();
                UnityEngine.Texture val_6 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.丁丛丑丄丟丕与丈且.丙三专万丛丟万丝丘());
                this._btnSpeedUp.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  this.丁丛丑丄丟丕与丈且.且丕三丙七且且东下(), 万丐丁三且下丞丈丌:  0);
                val_15 = this.东丏丂丗与与丟七上;
            }
            
            if(val_15 == null)
            {
                    return;
            }
            
            this._labelBuyItemName.text = val_15.丙丕丞且丕不丘丙丑().东丙上东业丆不丟丘();
            UIBasicSprite val_10 = this.丌丕与丙且丄丙丗东();
            UnityEngine.Texture val_12 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.东丏丂丗与与丟七上.丙三专万丛丟万丝丘());
            this._btnBuy.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  this.东丏丂丗与与丟七上.丙丕丞且丕不丘丙丑().丙丏丁丐丟上丁东丌(), 万丐丁三且下丞丈丌:  0);
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
            this.一万丅世丏丏专七业 = 0;
            this.丁丛丑丄丟丕与丈且 = 0;
            this.东丏丂丗与与丟七上 = 0;
        }
        private void Update()
        {
            null = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == false)
            {
                goto label_4;
            }
            
            if(this.丁丛丑丄丟丕与丈且 == null)
            {
                    return;
            }
            
            if(this.丁丛丑丄丟丕与丈且.丕丐丈丁上丞与三丌() == false)
            {
                goto label_6;
            }
            
            label_4:
            this.丏丆下丘丅丙丐丌丅(东且丁丆丛丁丏丘且:  0);
            return;
            label_6:
            if(this._btnSpeedUp != 0)
            {
                    this._btnSpeedUp.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  this.丁丛丑丄丟丕与丈且.且丕三丙七且且东下(), 万丐丁三且下丞丈丌:  0);
            }
            
            if(this._labelSpeedUpTimeLeft == 0)
            {
                    return;
            }
            
            this._labelSpeedUpTimeLeft.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.丁丛丑丄丟丕与丈且.下丞丘丏丂丕丄丐丘(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        }
        private void OnEnable()
        {
            this._btnSpeedUp.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortItemSpeedUpWindow::丑丙丑且丐专丞东东()));
            this._btnBuy.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortItemSpeedUpWindow::丒上上丘与三丘丁丁()));
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.FortItemSpeedUpWindow::丁丄专丛不不丟一东()), 与且专丈不万东一万:  "craft speedup window");
        }
        private void OnDisable()
        {
            this._btnSpeedUp.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortItemSpeedUpWindow::丑丙丑且丐专丞东东()));
            this._btnBuy.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortItemSpeedUpWindow::丒上上丘与三丘丁丁()));
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            if(丁与丟万丄丒丗专丌 == false)
            {
                    return;
            }
            
            this.Hide();
        }
        private void 丑丙丑且丐专丞东东()
        {
            this.丏丆下丘丅丙丐丌丅(东且丁丆丛丁丏丘且:  1);
        }
        private void 丒上上丘与三丘丁丁()
        {
            this.丏丆下丘丅丙丐丌丅(东且丁丆丛丁丏丘且:  2);
        }
        private void 丏丆下丘丅丙丐丌丅(Rilisoft.FortItemSpeedUpWindow.上三上与丒不丒丘丝 东且丁丆丛丁丏丘且)
        {
            if(this.一万丅世丏丏专七业 != null)
            {
                    this.一万丅世丏丏专七业.Invoke(arg1:  东且丁丆丛丁丏丘且, arg2:  this.丁丛丑丄丟丕与丈且, arg3:  this.东丏丂丗与与丟七上);
            }
            
            this.Hide();
        }
        private UIBasicSprite 丗东丞丞七丟丛丕丑()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._textureSpeedUpItem);
            this._textureSpeedUpItem = val_1;
            return val_1;
        }
        private UIBasicSprite 丌丕与丙且丄丙丗东()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._textureBuyItem);
            this._textureBuyItem = val_1;
            return val_1;
        }
        public void U_Dismiss()
        {
            this.丏丆下丘丅丙丐丌丅(东且丁丆丛丁丏丘且:  0);
        }
        public FortItemSpeedUpWindow()
        {
        
        }
        private void 丁丄专丛不不丟一东()
        {
            this.丏丆下丘丅丙丐丌丅(东且丁丆丛丁丏丘且:  0);
        }
    
    }

}
