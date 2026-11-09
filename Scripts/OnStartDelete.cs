using UnityEngine;
public class OnStartDelete : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public OnStartDelete()
    {
    
    }

}
