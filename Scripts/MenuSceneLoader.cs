using UnityEngine;
public class MenuSceneLoader : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject 丆丄万与与丝丌丂丆;
    public UnityEngine.GameObject menuUI;
    
    // Methods
    private void Awake()
    {
        if(this.丆丄万与与丝丌丂丆 != 0)
        {
                return;
        }
        
        this.丆丄万与与丝丌丂丆 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.menuUI);
    }
    public MenuSceneLoader()
    {
    
    }

}
