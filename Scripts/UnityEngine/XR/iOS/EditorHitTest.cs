using UnityEngine;

namespace UnityEngine.XR.iOS
{
    public class EditorHitTest : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform m_HitTransform;
        public float maxRayDistance;
        public UnityEngine.LayerMask collisionLayerMask;
        
        // Methods
        public EditorHitTest()
        {
            this.maxRayDistance = 30f;
        }
    
    }

}
