using UnityEngine;

namespace PGCompany
{
    internal abstract class 东上丛丂丅下丄七丝
    {
        // Fields
        private System.Action<int> 三丏七丛一丝且且丅;
        private System.Action 丟丘丙丄丅万丏与丗;
        internal PGCompany.GameTaskActionSettings 丅万丂世不丘丕下一;
        internal PGCompany.世丐下丕专东丘丏且 世丐下丕专东丘丏且;
        
        // Properties
        internal virtual bool 业一丆世丛丝丐丛丂 { get; }
        
        // Methods
        internal void 丐专丏与三丈东丌丐(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.三丏七丛一丝且且丅, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.三丏七丛一丝且且丅 != 1152921555369378928);
        
        }
        internal void 丆丂丐上世丙丏丏世(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.三丏七丛一丝且且丅, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.三丏七丛一丝且且丅 != 1152921555369515504);
        
        }
        internal void 丁七丙丈丑万丕丆与(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丟丘丙丄丅万丏与丗, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丟丘丙丄丅万丏与丗 != 1152921555369652088);
        
        }
        internal void 丐上丑丌七下丏丘丞(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丟丘丙丄丅万丏与丗, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丟丘丙丄丅万丏与丗 != 1152921555369788664);
        
        }
        internal virtual bool 丛且丞丏丝丅丑丞东()
        {
            return false;
        }
        internal abstract void 下丌业业丐丘丐丘三(); // 0
        internal abstract void 不与丞下业丑丒丙万(); // 0
        internal virtual bool 丑上上丟丂丈丛丏丑()
        {
            return false;
        }
        internal virtual int 万丆上丗丂丏上丛丝()
        {
            return -2;
        }
        internal virtual bool 专下丒丘丞下丟不下(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 丞丁丑丏丄丏七丂不)
        {
            return false;
        }
        protected void 丑与七丑丒不丏下专(int 丅专与丒丈丗丒丘丌)
        {
            string val_2 = PolygonController.一下一万丄丅丘且丑;
            if(val_2 != 0)
            {
                    val_2 = PolygonController.一下一万丄丅丘且丑;
                if((PolygonController.一下一万丄丅丘且丑 + 24) != 0)
            {
                    return;
            }
            
            }
            
            if(this.三丏七丛一丝且且丅 == null)
            {
                    return;
            }
            
            this.三丏七丛一丝且且丅.Invoke(obj:  丅专与丒丈丗丒丘丌);
        }
        protected void 万丏丛东下丝下丟丕()
        {
            if(this.丟丘丙丄丅万丏与丗 == null)
            {
                    return;
            }
            
            this.丟丘丙丄丅万丏与丗.Invoke();
        }
        protected bool 下丄丈万世丁丕丄丌(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 丞丁丑丏丄丏七丂不)
        {
            PGCompany.GameTaskActionSettings val_3;
            var val_4;
            val_3 = this;
            if(this.丅万丂世不丘丕下一.GameMode != 100)
            {
                    if(this.丅万丂世不丘丕下一.GameMode != 上且丗一丏丏万丅丌)
            {
                goto label_7;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  this.丅万丂世不丘丕下一.Map)) == true)
            {
                goto label_5;
            }
            
            val_3 = this.丅万丂世不丘丕下一;
            if((PGCompany.丞丂丄丐三业丝丆丂.丙丟丄丕丈丝一丛丘(丘与丙丟丙丙下七丙:  this.丅万丂世不丘丕下一.Map, 丆丁丗一一丆丈丗丞:  丞丁丑丏丄丏七丂不, 丂丛丑东不丅丈一东:  上且丗一丏丏万丅丌)) == false)
            {
                goto label_7;
            }
            
            label_5:
            val_4 = 1;
            return (bool)val_4;
            label_7:
            val_4 = 0;
            return (bool)val_4;
        }
        protected 东上丛丂丅下丄七丝()
        {
        
        }
    
    }

}
