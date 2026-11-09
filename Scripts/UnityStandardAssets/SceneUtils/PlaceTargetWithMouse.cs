using UnityEngine;

namespace UnityStandardAssets.SceneUtils
{
    public class PlaceTargetWithMouse : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject setTargetOn;
        public float surfaceOffset;
        
        // Methods
        private void Update()
        {
            float val_5;
            float val_6;
            object val_14;
            float val_15;
            float val_16;
            val_14 = this;
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            val_15 = val_3.x;
            val_16 = val_3.z;
            UnityEngine.Ray val_4 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_15, y = val_3.y, z = val_16});
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, m_Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}})) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6, y = val_3.y, z = val_16}, d:  this.surfaceOffset);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_3.y, z = val_16}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_15 = val_10.x;
            val_16 = val_10.z;
            this.transform.position = new UnityEngine.Vector3() {x = val_15, y = val_10.y, z = val_16};
            if(this.setTargetOn == 0)
            {
                    return;
            }
            
            val_14 = this.transform;
            this.setTargetOn.SendMessage(methodName:  "SetTarget", value:  val_14);
        }
        public PlaceTargetWithMouse()
        {
            this.surfaceOffset = 1.5f;
        }
    
    }

}
