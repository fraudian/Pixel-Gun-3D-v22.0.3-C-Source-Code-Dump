using UnityEngine;

namespace PGCompany
{
    internal class GuiNotification : PGBehaviour
    {
        // Fields
        private System.Action 丌丗万与丗丞三丝丞;
        private UnityEngine.GameObject _container;
        private System.Collections.Generic.List<UILabel> _labels;
        private PGCompany.上丏丂丙丌丅万丌世 _type;
        private PGCompany.GuiNotificationSettingsUpdater _settingsUpdater;
        private PGCompany.丕业丛世丒且丞丞丘 丙丛下业丗专丝与丞;
        private bool 三丝丝三丑丄与下上;
        
        // Properties
        internal UnityEngine.GameObject 丆丌七丁三丕丌丑丌 { get; }
        
        // Methods
        internal void 七上丑丝七丒业丈业(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丌丗万与丗丞三丝丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丌丗万与丗丞三丝丞 != 1152921555471869112);
        
        }
        internal void 与且东与丏下三业丞(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丌丗万与丗丞三丝丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丌丗万与丗丞三丝丞 != 1152921555472005688);
        
        }
        internal UnityEngine.GameObject 上且丝丆丒一丏丌丆()
        {
            return (UnityEngine.GameObject)this._container;
        }
        protected virtual PGCompany.丗不上业丙丆世丁丘 丁丘业七上丈三丄七(PGCompany.丗不上业丙丆世丁丘 与不丕丆丈不丙丟丛)
        {
            PGCompany.丗不上业丙丆世丁丘 val_0;
            val_0.丒丂丌丑丟东东丒专 = 与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专;
            val_0.丒三丝一上丙专丗丒 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒;
            return val_0;
        }
        protected void 丈且东丑丂且万丒丅(PGCompany.丗不上业丙丆世丁丘 与不丕丆丈不丙丟丛)
        {
            bool val_1;
            PGCompany.上丏丂丙丌丅万丌世 val_2;
            bool val_4;
            PGCompany.上丏丂丙丌丅万丌世 val_5;
            与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专 = val_1;
            与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒 = val_2;
            if(this._settingsUpdater != 0)
            {
                    val_1 = 与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专;
                val_2 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒;
                与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专 = val_4;
                与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒 = val_5;
            }
            
            this.上丙丝丑世三与与丛();
            PGCompany.丕业丛世丒且丞丞丘 val_7 = PGCompany.世专三丑丘丗丂丅丞.丑七不且上丗丁一世().丝丒专丙世与三丌丞(与不丕丆丈不丙丟丛:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒, 丏丟丑丙七东专丌丏 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒, 三丘丄丝丐丘业丟丘 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒, 丒丂丌丑丟东东丒专 = 与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专});
            this.丙丛下业丗专丝与丞 = val_7;
            val_7.下丌业业丐丘丐丘三();
            this.丙丛下业丗专丝与丞.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GuiNotification::丝一丅丆三东丂丞七()));
            this.三丝丝三丑丄与下上 = true;
        }
        protected virtual void Awake()
        {
            if(this.三丝丝三丑丄与下上 != false)
            {
                    return;
            }
            
            this.丈且东丑丂且万丒丅(与不丕丆丈不丙丟丛:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = this._type, 丏丟丑丙七东专丌丏 = false, 丒丂丌丑丟东东丒专 = false, 不丁万丞丘丌世丝丑 = ???});
        }
        protected void OnEnable()
        {
            this.丁专丄丈上丐丟东世(丙丅丌丗上丂丞丆一:  false);
        }
        protected void OnDestroy()
        {
            this.上丙丝丑世三与与丛();
        }
        private void 上丙丝丑世三与与丛()
        {
            if(this.丙丛下业丗专丝与丞 == null)
            {
                    return;
            }
            
            this.丙丛下业丗专丝与丞.不与丞下业丑丒丙万();
            this.丙丛下业丗专丝与丞.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GuiNotification::丝一丅丆三东丂丞七()));
            this.丙丛下业丗专丝与丞 = 0;
        }
        protected void 丝一丅丆三东丂丞七()
        {
            this.丁专丄丈上丐丟东世(丙丅丌丗上丂丞丆一:  false);
        }
        private void 丁专丄丈上丐丟东世(bool 丙丅丌丗上丂丞丆一)
        {
            int val_8;
            if(this == 0)
            {
                    return;
            }
            
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this.丙丛下业丗专丝与丞 != null)
            {
                    val_8 = this.丙丛下业丗专丝与丞.不丌丈专丟丒丕专丏();
            }
            else
            {
                    val_8 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._container, 丏业丟一东丂东丘丛:  false);
            if((this._container == 0) || (this._container.activeSelf == false))
            {
                goto label_14;
            }
            
            if(this.丙丛下业丗专丝与丞 == null)
            {
                goto label_15;
            }
            
            val_8 = this.丙丛下业丗专丝与丞;
            if(val_8 != null)
            {
                goto label_16;
            }
            
            label_15:
            val_8 = System.String.alignConst;
            label_16:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._labels, 丕丗丘丑丛与丑业丒:  val_8);
            label_14:
            this.且上上丌丅丟丆丕丒();
        }
        private void 且上上丌丅丟丆丕丒()
        {
            if(this.丌丗万与丗丞三丝丞 == null)
            {
                    return;
            }
            
            this.丌丗万与丗丞三丝丞.Invoke();
        }
        public GuiNotification()
        {
        
        }
    
    }

}
