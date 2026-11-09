using UnityEngine;

namespace PickUpObjectSystem
{
    internal abstract class BasePickUpTrigger : PGBehaviour
    {
        // Fields
        private System.Action 丈与丈万丗与世且丞;
        private System.Action 丂丝丆丛不丄丞一丈;
        protected PickUpObjectSystem.PickUpObject 丙丁丕丙丅丕丈世万;
        
        // Methods
        internal void 丟专不丐世丌丙下丘(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丈与丈万丗与世且丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丈与丈万丗与世且丞 != 1152921540851138776);
        
        }
        internal void 丟世东丆专业丗丏丗(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丈与丈万丗与世且丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丈与丈万丗与世且丞 != 1152921540851275352);
        
        }
        internal void 丄丛丗且万丁丆丗丝(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丂丝丆丛不丄丞一丈, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂丝丆丛不丄丞一丈 != 1152921540851411936);
        
        }
        internal void 丏上丂丞业不丂世丆(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丂丝丆丛不丄丞一丈, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂丝丆丛不丄丞一丈 != 1152921540851548512);
        
        }
        internal void 丘上丐世丆丑且丞丒(PickUpObjectSystem.PickUpObject 不丌丘丟丅丛丄丌丞)
        {
            this.丙丁丕丙丅丕丈世万 = 不丌丘丟丅丛丄丌丞;
        }
        protected void 丙丞丏丂与丄三丐七()
        {
            if(this.丈与丈万丗与世且丞 == null)
            {
                    return;
            }
            
            this.丈与丈万丗与世且丞.Invoke();
        }
        protected void 丕丐丅业丌丂丙丄丆()
        {
            if(this.丂丝丆丛不丄丞一丈 == null)
            {
                    return;
            }
            
            this.丂丝丆丛不丄丞一丈.Invoke();
        }
        protected BasePickUpTrigger()
        {
        
        }
    
    }

}
