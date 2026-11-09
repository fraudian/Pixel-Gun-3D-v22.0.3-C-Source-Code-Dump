using UnityEngine;

namespace Rilisoft
{
    public class ClanCurrencyView : MonoBehaviour
    {
        // Fields
        private UILabel _count;
        private UILabel _price;
        private UIBasicSprite _texture;
        private Rilisoft.GameCurrencyData <不丑丂上丘丒丙与丅>k__BackingField;
        private System.Action<Rilisoft.ClanCurrencyView> 一万东丛且不丌丁丈;
        private System.Action<Rilisoft.ClanCurrencyView> 丛下丟与丟不丙丝且;
        
        // Properties
        private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        public Rilisoft.GameCurrencyData 丈且丌业上一丌不丞 { get; set; }
        
        // Methods
        private UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        public Rilisoft.GameCurrencyData get_CurrencyData()
        {
            return (Rilisoft.GameCurrencyData)this.<不丑丂上丘丒丙与丅>k__BackingField;
        }
        private void 丛且上丅丕丘不丙丄(Rilisoft.GameCurrencyData 丙业与丙丗丝不丈东)
        {
            this.<不丑丂上丘丒丙与丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void add_Click(System.Action<Rilisoft.ClanCurrencyView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.一万东丛且不丌丁丈, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一万东丛且不丌丁丈 != 1152921542382452424);
        
        }
        public void remove_Click(System.Action<Rilisoft.ClanCurrencyView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.一万东丛且不丌丁丈, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一万东丛且不丌丁丈 != 1152921542382589000);
        
        }
        public void add_GiftClick(System.Action<Rilisoft.ClanCurrencyView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛下丟与丟不丙丝且, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛下丟与丟不丙丝且 != 1152921542382725584);
        
        }
        public void remove_GiftClick(System.Action<Rilisoft.ClanCurrencyView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛下丟与丟不丙丝且, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛下丟与丟不丙丝且 != 1152921542382862160);
        
        }
        public void Set(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            this.<不丑丂上丘丒丙与丅>k__BackingField = 一下世丆丙万丞东丆;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  this.丆下世世丟七专丞丒(), y:  0);
            this.丘丈丅丝丙丌不一丆(一下世丆丙万丞东丆:  一下世丆丙万丞东丆);
            if(this._count == 0)
            {
                    return;
            }
            
            this = this._count;
            this.text = 一下世丆丙万丞东丆.CurrencyCount.ToString();
        }
        private void OnClick()
        {
            if(this.一万东丛且不丌丁丈 == null)
            {
                    return;
            }
            
            this.一万东丛且不丌丁丈.Invoke(obj:  this);
        }
        public void U_GiftClick()
        {
            if(this.丛下丟与丟不丙丝且 == null)
            {
                    return;
            }
            
            this.丛下丟与丟不丙丝且.Invoke(obj:  this);
        }
        public void U_Click()
        {
            this.OnClick();
        }
        private void Awake()
        {
            FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanCurrencyView::专丈且丆丄专丒丁丅()));
        }
        private void 专丈且丆丄专丒丁丅()
        {
            if((this.<不丑丂上丘丒丙与丅>k__BackingField) == null)
            {
                    return;
            }
            
            this.丘丈丅丝丙丌不一丆(一下世丆丙万丞东丆:  this.<不丑丂上丘丒丙与丅>k__BackingField);
        }
        private void OnDestroy()
        {
            FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanCurrencyView::专丈且丆丄专丒丁丅()));
        }
        private void 丘丈丅丝丙丌不一丆(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            UnityEngine.Object val_5 = this.gameObject;
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5 = this._price;
            if(val_5 == 0)
            {
                    return;
            }
            
            this._price.text = 一下世丆丙万丞东丆.丛不专与三丅万丌下();
        }
        public ClanCurrencyView()
        {
        
        }
    
    }

}
