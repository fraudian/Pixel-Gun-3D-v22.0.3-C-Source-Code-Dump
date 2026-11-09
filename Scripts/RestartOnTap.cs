using UnityEngine;
public class RestartOnTap : MonoBehaviour
{
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        if(UnityEngine.Input.touchCount < 1)
        {
                return;
        }
        
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "Level2");
    }
    public RestartOnTap()
    {
    
    }

}
