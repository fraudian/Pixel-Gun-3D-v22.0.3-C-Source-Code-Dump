using UnityEngine;
internal class ClassicArenaController : MonoBehaviour
{
    // Fields
    public static ClassicArenaController instance;
    
    // Methods
    private void Awake()
    {
        ClassicArenaController.instance = this;
    }
    public ClassicArenaController()
    {
    
    }

}
