using UnityEngine;
internal sealed class TextMeshLayerOrderer : PGBehaviour
{
    // Fields
    public int OrderInLayer;
    
    // Methods
    private void Start()
    {
        this.GetComponent<UnityEngine.MeshRenderer>().sortingOrder = this.OrderInLayer;
    }
    private void Update()
    {
    
    }
    public TextMeshLayerOrderer()
    {
    
    }

}
