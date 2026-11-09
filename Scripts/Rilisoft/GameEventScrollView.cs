using UnityEngine;

namespace Rilisoft
{
    public class GameEventScrollView : MonoBehaviour
    {
        // Fields
        private Rilisoft.GameEventItemData _item;
        private string _uid;
        private System.Action<Rilisoft.GameEventScrollView> 专与丌丝丞下丌丗专;
        private UIBasicSprite _itemTexture;
        private UILabel _testLabel;
        
        // Properties
        public string 丘丞丆上万与丂丞丝 { get; }
        private UIBasicSprite 下丝万丄丕世丝丝与 { get; }
        public Rilisoft.GameEventItemData 不下下丞三一丘丗丐 { get; }
        
        // Methods
        public string get_Uid()
        {
            return (string)this._uid;
        }
        private UIBasicSprite 丑世丝世丈世丌丝七()
        {
            UIBasicSprite val_4;
            if(this._itemTexture == 0)
            {
                    val_4 = this.GetComponent<UITextureMasked>();
                this._itemTexture = val_4;
            }
            else
            {
                    val_4 = this._itemTexture;
            }
            
            UIBasicSprite val_3 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  val_4);
            this._itemTexture = val_3;
            return val_3;
        }
        public Rilisoft.GameEventItemData get_Item()
        {
            return (Rilisoft.GameEventItemData)this._item;
        }
        public void add_OnClickAction(System.Action<Rilisoft.GameEventScrollView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.专与丌丝丞下丌丗专, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专与丌丝丞下丌丗专 != 1152921542848494968);
        
        }
        public void remove_OnClickAction(System.Action<Rilisoft.GameEventScrollView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.专与丌丝丞下丌丗专, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专与丌丝丞下丌丗专 != 1152921542848631544);
        
        }
        public void SetContainer(Rilisoft.GameEventItemData 万三丂且丆三且丝且, string 丞丅上丏丂且下丅与 = "")
        {
            this._item = 万三丂且丆三且丝且;
            this._uid = 丞丅上丏丂且下丅与;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            if(this._item == null)
            {
                    return;
            }
            
            if(this._testLabel != 0)
            {
                    this._testLabel.text = this._item.Id;
            }
            
            UIBasicSprite val_3 = this.丑世丝世丈世丌丝七();
            UnityEngine.Texture val_4 = this._item.丑东丐下专丞丕丘世();
            this = ???;
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        }
        private void OnClick()
        {
            if(this.专与丌丝丞下丌丗专 == null)
            {
                    return;
            }
            
            this.专与丌丝丞下丌丗专.Invoke(obj:  this);
        }
        public GameEventScrollView()
        {
            this._uid = "";
        }
    
    }

}
