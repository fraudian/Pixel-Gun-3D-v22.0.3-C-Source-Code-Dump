using UnityEngine;

namespace MTAssets.SkinnedMeshCombiner
{
    public class CurrentRP : MonoBehaviour
    {
        // Fields
        public static bool haveAnotherSrpPackages;
        public static string packageDetected;
        
        // Methods
        public CurrentRP()
        {
        
        }
        private static CurrentRP()
        {
            MTAssets.SkinnedMeshCombiner.CurrentRP.haveAnotherSrpPackages = false;
            MTAssets.SkinnedMeshCombiner.CurrentRP.packageDetected = "";
        }
    
    }

}
