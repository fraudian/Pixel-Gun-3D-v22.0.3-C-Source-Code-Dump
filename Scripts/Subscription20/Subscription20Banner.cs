using UnityEngine;

namespace Subscription20
{
    internal sealed class Subscription20Banner : BannerWindowWithBack
    {
        // Fields
        private Subscription20.Subscription20UI _subscriptionUI;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            new System.Action() = new System.Action(object:  this, method:  typeof(Subscription20.Subscription20Banner).__il2cppRuntimeField_220);
            this._subscriptionUI.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action());
        }
        protected override void OnDisable()
        {
            new System.Action() = new System.Action(object:  this, method:  typeof(Subscription20.Subscription20Banner).__il2cppRuntimeField_220);
            this._subscriptionUI.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action());
            this.OnDisable();
        }
        public override void Show()
        {
            Subscription20.Subscription20UI val_7;
            Subscription20.Subscription20UI val_8;
            var val_9;
            val_7 = this;
            this.Show();
            Subscription20.丘丛不东丒丆丁丑丁 val_3 = Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().不专丈不丞上丌丟丏(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑());
            if(val_3 == null)
            {
                goto label_4;
            }
            
            val_8 = this._subscriptionUI;
            if((val_8.一东与下三东丄三三(丅丘与三丆丝丑上业:  val_3)) == false)
            {
                    return;
            }
            
            val_8 = this._subscriptionUI;
            if((this._subscriptionUI.<业丟丝万丆丞丙丕丛>k__BackingField) != 1)
            {
                    val_7 = this._subscriptionUI;
                if((this._subscriptionUI.<业丟丝万丆丞丙丕丛>k__BackingField) != 3)
            {
                    return;
            }
            
            }
            
            if(val_3.七丄丞丄万且丝东丗 == null)
            {
                goto label_13;
            }
            
            val_9 = val_3.七丄丞丄万且丝东丗.Id;
            goto label_14;
            label_4:
            this.HideSelf();
            return;
            label_13:
            val_9 = 0;
            label_14:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丅丕上下丗丏三东(丞世不丒下上上丝丑:  0, 丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑());
        }
        public override void Back()
        {
            if((((this._subscriptionUI.gameObject.activeSelf != false) && (this._subscriptionUI.与丐不业丑丗丌业下 != null)) && (this._subscriptionUI.丕丗丛丅丆丏业丕丅 != null)) && ((this._subscriptionUI.丕丗丛丅丆丏业丕丅.业丆七丙丝丌丁万丏(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗())) != false))
            {
                    if((Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  this._subscriptionUI.与丐不业丑丗丌业下.七丈丒丒下下且万与())) == 2)
            {
                    return;
            }
            
            }
            
            if(((this._subscriptionUI.gameObject.activeSelf != false) && (this._subscriptionUI.与丐不业丑丗丌业下 != null)) && (this._subscriptionUI.丕丗丛丅丆丏业丕丅 != null))
            {
                    if((Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  this._subscriptionUI.与丐不业丑丗丌业下.七丈丒丒下下且万与())) == 3)
            {
                    this._subscriptionUI.warningDialog.Show();
                return;
            }
            
            }
            
            this.HideSelf();
            this.Back();
        }
        public Subscription20Banner()
        {
        
        }
    
    }

}
