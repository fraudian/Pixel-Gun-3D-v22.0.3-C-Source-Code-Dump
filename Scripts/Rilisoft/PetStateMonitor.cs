using UnityEngine;

namespace Rilisoft
{
    public abstract class PetStateMonitor : MonoBehaviour
    {
        // Fields
        private Rilisoft.PetEngine 丑七三丆丐丙丟丈且;
        protected Rilisoft.丛七下丌丑不一丄业 LookToState;
        
        // Properties
        internal Rilisoft.PetEngine 丌丌丒上丄丅丕丟丌 { get; }
        
        // Methods
        internal Rilisoft.PetEngine 丏且三丝丘丟丙丛丘()
        {
            Rilisoft.PetEngine val_4;
            if(this.丑七三丆丐丙丟丈且 != 0)
            {
                    val_4 = this.丑七三丆丐丙丟丈且;
                return val_3;
            }
            
            Rilisoft.PetEngine val_3 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<Rilisoft.PetEngine>(丝三丁东丈丒世丅业:  this.gameObject);
            this.丑七三丆丐丙丟丈且 = val_3;
            return val_3;
        }
        protected virtual void Awake()
        {
            if(this.丏且三丝丘丟丙丛丘() == 0)
            {
                    return;
            }
            
            this.丏且三丝丘丟丙丛丘().add_OnStateChanged(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>(object:  this, method:  System.Void Rilisoft.PetStateMonitor::丐上丌下丘业丈丈世(Rilisoft.丛七下丌丑不一丄业 与丆丌丂丟丛丘丑且, Rilisoft.丛七下丌丑不一丄业 且东丁丄业世丞丁不)));
        }
        protected virtual void 一丂丆专一丞丞东上()
        {
            if(this.丏且三丝丘丟丙丛丘() == 0)
            {
                    return;
            }
            
            this.丏且三丝丘丟丙丛丘().remove_OnStateChanged(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>(object:  this, method:  System.Void Rilisoft.PetStateMonitor::丐上丌下丘业丈丈世(Rilisoft.丛七下丌丑不一丄业 与丆丌丂丟丛丘丑且, Rilisoft.丛七下丌丑不一丄业 且东丁丄业世丞丁不)));
        }
        private void 丐上丌下丘业丈丈世(Rilisoft.丛七下丌丑不一丄业 与丆丌丂丟丛丘丑且, Rilisoft.丛七下丌丑不一丄业 且东丁丄业世丞丁不)
        {
            if(this.LookToState == 与丆丌丂丟丛丘丑且)
            {
                
            }
        
        }
        protected abstract void 上丌丑丒丒世丌丒丘(); // 0
        protected abstract void 丆与下世丝丆丗丆且(); // 0
        protected PetStateMonitor()
        {
        
        }
    
    }

}
