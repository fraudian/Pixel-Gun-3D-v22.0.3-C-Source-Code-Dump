using UnityEngine;

namespace UnityEngine.XR.iOS
{
    [Serializable]
    public struct UnityVideoParams
    {
        // Fields
        public int yWidth;
        public int yHeight;
        public int screenOrientation;
        public float texCoordScale;
        public IntPtr cvPixelBufferPtr;
        
    
    }

}
