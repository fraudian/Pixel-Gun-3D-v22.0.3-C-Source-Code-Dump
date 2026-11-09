using UnityEngine;

namespace Rilisoft
{
    public class HideAtChildOf : MonoBehaviour
    {
        // Fields
        private string _rootObjectName;
        
        // Methods
        private void Start()
        {
            var val_16;
            var val_17;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._rootObjectName)) != false)
            {
                    return;
            }
            
            this._rootObjectName = this._rootObjectName.ToLower();
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = Unity.Linq.丅丆万丟丐丏丏下丄.东丕丟丏丐业丅东丐(丈丆上丅丘世专丑丕:  this.gameObject).GetEnumerator();
            label_23:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_15;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            if((System.String.op_Equality(a:  val_6.Current.name.ToLower(), b:  this._rootObjectName)) == false)
            {
                goto label_23;
            }
            
            this.gameObject.SetActive(value:  false);
            label_15:
            val_16 = 0;
            val_17 = 0;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_6.Dispose();
            }
            
            if( == 1)
            {
                goto label_39;
            }
            
            if(null == null)
            {
                    return;
            }
            
            if(113 != 113)
            {
                goto label_41;
            }
            
            return;
            label_39:
            if(null == null)
            {
                    return;
            }
            
            label_41:
        }
        public HideAtChildOf()
        {
        
        }
    
    }

}
