using UnityEngine;
public class DisableObjectFromTimer : PGBehaviour
{
    // Fields
    public float timer;
    public bool isDestroy;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        if(this.timer < 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.timer - val_1;
        this.timer = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.丅与丌专丟一丝业三();
        if(this.isDestroy != false)
        {
                UnityEngine.Object.Destroy(obj:  val_2);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
    }
    public DisableObjectFromTimer()
    {
        this.timer = -1f;
    }

}
