using UnityEngine;

namespace UnityEngine.XR.iOS
{
    public class UnityARGeneratePlane : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject planePrefab;
        private UnityEngine.XR.iOS.丆丌丘丒丅三丗不丛 丅丙下丐丅丒丂业丙;
        
        // Methods
        private void Start()
        {
            this.丅丙下丐丅丒丂业丙 = new UnityEngine.XR.iOS.丆丌丘丒丅三丗不丛();
            UnityEngine.XR.iOS.丒七丄下丏东下一丈.下且丈丑专丘丌专丞(丝三丁东丈丒世丅业:  this.planePrefab);
        }
        private void OnDestroy()
        {
            this.丅丙下丐丅丒丂业丙.Destroy();
        }
        private void OnGUI()
        {
            int val_2 = this.丅丙下丐丅丒丂业丙.且丑丘丑业丈一专三().Count;
        }
        public UnityARGeneratePlane()
        {
        
        }
    
    }

}
