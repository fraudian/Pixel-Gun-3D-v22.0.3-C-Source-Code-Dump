using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class EventCallback
    {
        // Fields
        public UnityEngine.MonoBehaviour Target;
        public string MethodName;
        
        // Methods
        public void 丞丙东丌一三专丏不(UnityEngine.Object 丒丗丒丞万万丗丟丂)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.Target)) == false)
            {
                    return;
            }
            
            this.Target.SendMessage(methodName:  this.MethodName, value:  丒丗丒丞万万丗丟丂, options:  1);
        }
        public EventCallback()
        {
            this.MethodName = System.String.alignConst;
        }
    
    }

}
