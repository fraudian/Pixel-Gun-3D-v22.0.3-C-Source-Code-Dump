using UnityEngine;

namespace PGCompany
{
    internal abstract class 丞丛上丛丟东世丝丞
    {
        // Fields
        private System.Action 丂三丒丌东丝丆专丝;
        internal PGCompany.GameConditionSettings 丅万丂世不丘丕下一;
        
        // Methods
        internal void 丐上丌丆专丞丂丟丛(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丂三丒丌东丝丆专丝, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂三丒丌东丝丆专丝 != 1152921555320158192);
        
        }
        internal void 丂七丏三丅丛三丒丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丂三丒丌东丝丆专丝, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂三丒丌东丝丆专丝 != 1152921555320294768);
        
        }
        internal abstract bool 专丄丏丞丈丞丞不丒(); // 0
        internal abstract void 下丌业业丐丘丐丘三(); // 0
        internal abstract void 不与丞下业丑丒丙万(); // 0
        public override string ToString()
        {
            return (string)System.String.Format(format:  "[{0}: {1}]", arg0:  this.丅万丂世不丘丕下一.Type, arg1:  this.丅万丂世不丘丕下一.RequiredValue);
        }
        protected void 丐上丌专丝丏七三且()
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(this.丂三丒丌东丝丆专丝 == null)
            {
                    return;
            }
            
            this.丂三丒丌东丝丆专丝.Invoke();
        }
        protected 丞丛上丛丟东世丝丞()
        {
        
        }
    
    }

}
