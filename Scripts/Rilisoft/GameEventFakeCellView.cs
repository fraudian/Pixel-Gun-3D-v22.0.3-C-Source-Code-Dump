using UnityEngine;

namespace Rilisoft
{
    public abstract class GameEventFakeCellView : MonoBehaviour
    {
        // Fields
        private System.Nullable<Rilisoft.GameEventFakeCellView.丙丟与丐三丐万万丆> 丗下丘世三七一专丕;
        
        // Properties
        public System.Nullable<Rilisoft.GameEventFakeCellView.丙丟与丐三丐万万丆> 上丅丑丌丑丏丏丙东 { get; set; }
        
        // Methods
        public System.Nullable<Rilisoft.GameEventFakeCellView.丙丟与丐三丐万万丆> get_CurrentState()
        {
            return (System.Nullable<丙丟与丐三丐万万丆>)this.丗下丘世三七一专丕;
        }
        public void set_CurrentState(System.Nullable<Rilisoft.GameEventFakeCellView.丙丟与丐三丐万万丆> 丙业与丙丗丝不丈东)
        {
            if(this.丗下丘世三七一专丕.丙东专丂世丈丏丁丂() == 丙业与丙丗丝不丈东.HasValue.丙东专丂世丈丏丁丂())
            {
                    if((16 & 1) == 0)
            {
                    return;
            }
            
            }
            
            this.丗下丘世三七一专丕 = 丙业与丙丗丝不丈东.HasValue;
        }
        protected abstract void 丕丕业七丙七丅丈丄(); // 0
        protected GameEventFakeCellView()
        {
        
        }
    
    }

}
