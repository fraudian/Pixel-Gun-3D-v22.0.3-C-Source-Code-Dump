using UnityEngine;
public class RemovePanelAuth : MonoBehaviour
{
    // Fields
    public float lifetime;
    private float 与丕丌丒丗丄丘丙东;
    private bool 下世万业丗世且业丌;
    
    // Methods
    private void Start()
    {
        this.与丕丌丒丗丄丘丙东 = UnityEngine.Time.realtimeSinceStartup;
    }
    private void Update()
    {
        if(this.下世万业丗世且业丌 == true)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.与丕丌丒丗丄丘丙东;
        if(val_1 < this.lifetime)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        this.下世万业丗世且业丌 = true;
    }
    public RemovePanelAuth()
    {
        this.lifetime = 0.7f;
    }

}
