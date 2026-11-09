using UnityEngine;

namespace Rilisoft
{
    public class GameEventBuyCurrencyView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.丛且世丐丆上七业丁>, 丈丕丑且丘丘丆东丑
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Collections.Generic.List<Rilisoft.GameEventCurrencyView> _views;
        private System.Action 丛丄业丘不丆丄三丞;
        private System.Action<Rilisoft.GameCurrencyData> 专丌业且丁丘七丗且;
        
        // Properties
        public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        public bool 东且世与一东丂一丆 { get; }
        
        // Methods
        public Rilisoft.丛且世丐丆上七业丁 get_Context()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get___InterfaceEnabled()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void add_OnHide(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921542826778080);
        
        }
        public void remove_OnHide(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921542826914656);
        
        }
        public void add_OnPurchaseSelected(System.Action<Rilisoft.GameCurrencyData> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.专丌业且丁丘七丗且, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专丌业且丁丘七丗且 != 1152921542827051240);
        
        }
        public void remove_OnPurchaseSelected(System.Action<Rilisoft.GameCurrencyData> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.专丌业且丁丘七丗且, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专丌业且丁丘七丗且 != 1152921542827187816);
        
        }
        public void Show(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
        {
            Rilisoft.丛且世丐丆上七业丁 val_9;
            var val_10;
            val_9 = 丅东专与不三丂丁丝;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = val_9;
            val_10 = 0;
            goto label_1;
            label_10:
            Rilisoft.GameEventCurrencyView val_3 = this._views.Item[0];
            val_3.Set(一下世丆丙万丞东丆:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.业丈丂丏上丄丘丐丞().Item[0]);
            val_3.remove_Click(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventCurrencyView>(object:  this, method:  System.Void Rilisoft.GameEventBuyCurrencyView::三丛丅丛不丗与丂且(Rilisoft.GameEventCurrencyView 丈与丞下丝世丆丘丕)));
            val_3.add_Click(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameEventCurrencyView>(object:  this, method:  System.Void Rilisoft.GameEventBuyCurrencyView::三丛丅丛不丗与丂且(Rilisoft.GameEventCurrencyView 丈与丞下丝世丆丘丕)));
            val_9 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            val_10 = 1;
            label_1:
            if(val_10 < val_9.业丈丂丏上丄丘丐丞().Count)
            {
                goto label_10;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        private void 三丛丅丛不丗与丂且(Rilisoft.GameEventCurrencyView 丈与丞下丝世丆丘丕)
        {
            if(this.专丌业且丁丘七丗且 == null)
            {
                    return;
            }
            
            this.专丌业且丁丘七丗且.Invoke(obj:  丈与丞下丝世丆丘丕.<不丑丂上丘丒丙与丅>k__BackingField);
        }
        public void U_Hide()
        {
            this.Hide();
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
            if(this.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            this.丛丄业丘不丆丄三丞.Invoke();
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.GameEventBuyCurrencyView::U_Hide()), 与且专丈不万东一万:  0);
        }
        protected virtual void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        public void Setup(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public GameEventBuyCurrencyView()
        {
        
        }
    
    }

}
