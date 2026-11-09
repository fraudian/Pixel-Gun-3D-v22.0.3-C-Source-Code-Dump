using UnityEngine;
public class Scr : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public Scr()
    {
    
    }

}
