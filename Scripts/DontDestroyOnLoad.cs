using UnityEngine;
public class DontDestroyOnLoad : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void Update()
    {
    
    }
    public DontDestroyOnLoad()
    {
    
    }

}
