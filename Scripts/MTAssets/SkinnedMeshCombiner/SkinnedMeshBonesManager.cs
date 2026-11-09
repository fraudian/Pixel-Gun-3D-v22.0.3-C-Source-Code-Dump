using UnityEngine;

namespace MTAssets.SkinnedMeshCombiner
{
    public class SkinnedMeshBonesManager : MonoBehaviour
    {
        // Fields
        public UnityEngine.SkinnedMeshRenderer anotherBonesHierarchyCurrentInUse;
        
        // Methods
        private bool 世一三丘丞下丐丝丕(UnityEngine.SkinnedMeshRenderer 丗丘七丕丗业丐丟上, bool 七与丄东业业业丘丞)
        {
            UnityEngine.SkinnedMeshRenderer val_14 = 丗丘七丕丗业丐丟上;
            UnityEngine.SkinnedMeshRenderer val_1 = this.GetComponent<UnityEngine.SkinnedMeshRenderer>();
            bool val_14 = UnityEngine.Object.op_Equality(x:  val_14 = 丗丘七丕丗业丐丟上, y:  0);
            UnityEngine.Transform[] val_4 = val_1.bones;
            val_14 = (UnityEngine.Object.op_Equality(x:  val_1, y:  0)) | val_14;
            UnityEngine.Transform[] val_6 = val_14.bones;
            if(七与丄东业业业丘丞 == false)
            {
                    return (bool)((val_4.Length == val_6.Length) ? 1 : 0) & val_14 ^ 1;
            }
            
            val_14 = "It is not possible for this Skinned Mesh Renderer to use the Skinned Mesh Renderer \"" + val_14.gameObject.name + "\" bone hierarchy, as the two hierarchies are not identical. Both Skinned Mesh Renderers must have an identical bone hierarchy to make it possible for this mesh to be animated by the bones of the desired Skinned Mesh Renderer.";
            if((val_14 | ((val_4.Length != val_6.Length) ? 1 : 0)) == false)
            {
                    return (bool)((val_4.Length == val_6.Length) ? 1 : 0) & val_14 ^ 1;
            }
            
            UnityEngine.Debug.Log(message:  val_14);
            return (bool)((val_4.Length == val_6.Length) ? 1 : 0) & val_14 ^ 1;
        }
        public bool UseAnotherBoneHierarchyForAnimateThis(UnityEngine.SkinnedMeshRenderer 丐且世上丈丂与上上, bool 万下丑丗丟丁上丄丑)
        {
            var val_9;
            var val_10;
            val_9 = 万下丑丗丟丁上丄丑;
            if((this.世一三丘丞下丐丝丕(丗丘七丕丗业丐丟上:  丐且世上丈丂与上上, 七与丄东业业业丘丞:  true)) != false)
            {
                    UnityEngine.SkinnedMeshRenderer val_2 = this.GetComponent<UnityEngine.SkinnedMeshRenderer>();
                val_2.bones = 丐且世上丈丂与上上.bones;
                if(val_9 != false)
            {
                    val_2.rootBone = 丐且世上丈丂与上上.rootBone;
            }
            
                val_9 = this.gameObject.transform;
                val_9.parent = 丐且世上丈丂与上上.transform.parent;
                val_10 = 1;
                this.anotherBonesHierarchyCurrentInUse = 丐且世上丈丂与上上;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public SkinnedMeshBonesManager()
        {
        
        }
    
    }

}
