using UnityEngine;
public class RandomMaterialSetter : MonoBehaviour
{
    // Fields
    private UnityEngine.Renderer usedRenderer;
    private UnityEngine.Material[] materialsToSet;
    
    // Methods
    public void Execute()
    {
        if(this.usedRenderer == 0)
        {
                return;
        }
        
        if(this.materialsToSet == null)
        {
                return;
        }
        
        if(this.materialsToSet.Length == 0)
        {
                return;
        }
        
        this.usedRenderer.material = this.materialsToSet[(long)UnityEngine.Random.Range(min:  0, max:  this.materialsToSet.Length)];
    }
    public RandomMaterialSetter()
    {
    
    }

}
