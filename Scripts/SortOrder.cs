using UnityEngine;
public class SortOrder : MonoBehaviour
{
    // Fields
    public int sortOrder;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        this.GetComponent<UnityEngine.Renderer>().sortingOrder = this.sortOrder;
    }
    public SortOrder()
    {
    
    }

}
