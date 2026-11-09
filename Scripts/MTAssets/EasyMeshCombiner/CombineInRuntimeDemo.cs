using UnityEngine;

namespace MTAssets.EasyMeshCombiner
{
    public class CombineInRuntimeDemo : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject combineButton;
        public UnityEngine.GameObject undoButton;
        public MTAssets.EasyMeshCombiner.RuntimeMeshCombiner runtimeCombiner;
        
        // Methods
        private void Update()
        {
            if(this.runtimeCombiner.丝不丗丘不丒丕丙不 != true)
            {
                    this.combineButton.SetActive(value:  true);
                this.undoButton.SetActive(value:  false);
            }
            
            if(this.runtimeCombiner.丝不丗丘不丒丕丙不 == false)
            {
                    return;
            }
            
            this.combineButton.SetActive(value:  false);
            this.undoButton.SetActive(value:  true);
        }
        public void CombineMeshes()
        {
            bool val_1 = this.runtimeCombiner.CombineMeshes();
        }
        public void UndoMerge()
        {
            bool val_1 = this.runtimeCombiner.UndoMerge();
        }
        public CombineInRuntimeDemo()
        {
        
        }
    
    }

}
