using UnityEngine;
internal sealed class DevelopOutput : MonoBehaviour
{
    // Fields
    private UILabel outputLabel;
    public static DevelopOutput instance;
    
    // Methods
    private void Awake()
    {
        DevelopOutput.instance = this;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public DevelopOutput()
    {
    
    }

}
