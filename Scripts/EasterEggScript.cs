using UnityEngine;
public class EasterEggScript : MonoBehaviour
{
    // Fields
    public bool debg;
    
    // Methods
    private void Start()
    {
        if(this.debg == true)
        {
                return;
        }
        
        System.DateTime val_1 = System.DateTime.Now;
        if(val_1.dateData.Hour > 22)
        {
                return;
        }
        
        System.DateTime val_3 = System.DateTime.Now;
        if(val_3.dateData.Minute > 54)
        {
                return;
        }
        
        this = this.gameObject;
        UnityEngine.Object.Destroy(obj:  this);
    }
    public EasterEggScript()
    {
    
    }

}
