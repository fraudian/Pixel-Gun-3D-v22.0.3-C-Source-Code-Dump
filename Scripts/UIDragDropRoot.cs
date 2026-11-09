using UnityEngine;
public class UIDragDropRoot : MonoBehaviour
{
    // Fields
    public static UnityEngine.Transform root;
    
    // Methods
    private void OnEnable()
    {
        UIDragDropRoot.root = this.transform;
    }
    private void OnDisable()
    {
        if(UIDragDropRoot.root != this.transform)
        {
                return;
        }
        
        UIDragDropRoot.root = 0;
    }
    public UIDragDropRoot()
    {
    
    }

}
