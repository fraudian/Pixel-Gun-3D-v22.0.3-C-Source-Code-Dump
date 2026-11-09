using UnityEngine;
public class DamageFromMegabullet : MonoBehaviour
{
    // Fields
    private Rocket 丌丂丂丗丛丗世丐丗;
    
    // Methods
    private void Start()
    {
        this.丌丂丂丗丛丗世丐丗 = this.transform.root.GetComponent<Rocket>();
    }
    private void Update()
    {
        if(this.丌丂丂丗丛丗世丐丗 != 0)
        {
                return;
        }
        
        this.丌丂丂丗丛丗世丐丗 = this.transform.root.GetComponent<Rocket>();
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.丌丂丂丗丛丗世丐丗, y:  0);
    }
    public DamageFromMegabullet()
    {
    
    }

}
