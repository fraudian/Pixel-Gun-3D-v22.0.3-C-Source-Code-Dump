using UnityEngine;

namespace Rilisoft
{
    public class GameEventScrollContainerView : MonoBehaviour
    {
        // Fields
        private Rilisoft.GameEventItemContainer _container;
        private UIBasicSprite _itemTexture;
        private Rilisoft.GameEventItemScrollRewardGui itemUI;
        private System.Action<Rilisoft.GameEventScrollContainerView> 专与丌丝丞下丌丗专;
        
        // Properties
        private UIBasicSprite 下丝万丄丕世丝丝与 { get; }
        public Rilisoft.GameEventItemContainer 丆丌七丁三丕丌丑丌 { get; }
        
        // Methods
        private UIBasicSprite 丑世丝世丈世丌丝七()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._itemTexture);
            this._itemTexture = val_1;
            return val_1;
        }
        public Rilisoft.GameEventItemContainer get_Container()
        {
            return (Rilisoft.GameEventItemContainer)this._container;
        }
        public void add_OnClickAction(System.Action<Rilisoft.GameEventScrollContainerView> 丙业与丙丗丝不丈东)
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
            while(this.专与丌丝丞下丌丗专 != 1152921542847248208);
        
        }
        public void remove_OnClickAction(System.Action<Rilisoft.GameEventScrollContainerView> 丙业与丙丗丝不丈东)
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
            while(this.专与丌丝丞下丌丗专 != 1152921542847384784);
        
        }
        public void SetContainer(Rilisoft.GameEventItemContainer 万三丂且丆三且丝且)
        {
            this._container = 万三丂且丆三且丝且;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            System.Object[] val_18;
            UIBasicSprite val_19;
            UIBasicSprite val_20;
            Rilisoft.GameEventItemScrollRewardGui val_21;
            var val_22;
            val_18 = this;
            if(this._container == null)
            {
                    return;
            }
            
            Rilisoft.GameEventItem val_1 = this._container.丙业丈专万下丄丙丏();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            val_19 = this._itemTexture;
            if(this.itemUI == 0)
            {
                goto label_5;
            }
            
            if(val_19 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this._itemTexture);
            }
            
            val_20 = this.itemUI.gameObject;
            val_20.SetActive(value:  true);
            val_21 = this.itemUI;
            val_22 = val_1.Data;
            if(val_21 != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_2:
            object[] val_6 = new object[1];
            val_18 = val_6;
            val_18[0] = this._container.Id;
            UnityEngine.Debug.LogErrorFormat(format:  "container \'{0}\' without any item!", args:  val_6);
            return;
            label_5:
            if(val_19 == 0)
            {
                    return;
            }
            
            val_20 = this._itemTexture;
            val_20.enabled = true;
            val_21 = this.丑世丝世丈世丌丝七();
            val_22 = val_1.丑东丐下专丞丕丘世();
            label_14:
            val_18 = ???;
            val_19 = ???;
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
        public GameEventScrollContainerView()
        {
        
        }
    
    }

}
