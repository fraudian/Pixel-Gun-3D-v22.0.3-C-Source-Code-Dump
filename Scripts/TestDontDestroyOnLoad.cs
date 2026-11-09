using UnityEngine;
public class TestDontDestroyOnLoad : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public TestDontDestroyOnLoad()
    {
    
    }

}
