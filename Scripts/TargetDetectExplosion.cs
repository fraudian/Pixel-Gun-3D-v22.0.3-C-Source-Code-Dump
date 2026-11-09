using UnityEngine;
public class TargetDetectExplosion : MonoBehaviour
{
    // Fields
    private bool 丒丏丕丁丗丟丙不丑;
    public float durationBeforeExplosion;
    internal DamagedExplosionObject explosionScript;
    
    // Methods
    private void Awake()
    {
        if(this.explosionScript != 0)
        {
                return;
        }
        
        this.explosionScript = this.transform.parent.GetComponent<DamagedExplosionObject>();
    }
    private bool 业丅丙丏业且上丄丏(UnityEngine.Transform 丄三丟丗东丟丝下丝)
    {
        var val_5;
        if((丄三丟丗东丟丝下丝.Equals(other:  this.transform)) != false)
        {
                val_5 = 0;
            return (bool)val_5;
        }
        
        if((丄三丟丗东丟丝下丝.CompareTag(tag:  "Player")) != true)
        {
                if((丄三丟丗东丟丝下丝.CompareTag(tag:  "Enemy")) == false)
        {
                return 丄三丟丗东丟丝下丝.CompareTag(tag:  "Turret");
        }
        
        }
        
        val_5 = 1;
        return (bool)val_5;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丛丂丁丅丂东丒东丅)
    {
        if((this.业丅丙丏业且上丄丏(丄三丟丗东丟丝下丝:  丛丂丁丅丂东丒东丅.transform.root)) == false)
        {
                return;
        }
        
        if(this.丒丏丕丁丗丟丙不丑 != false)
        {
                return;
        }
        
        this.丒丏丕丁丗丟丙不丑 = true;
        if(this.durationBeforeExplosion != 0f)
        {
                this.Invoke(methodName:  "OnTargetEnter", time:  this.durationBeforeExplosion);
            return;
        }
        
        this.OnTargetEnter();
    }
    private void OnTargetEnter()
    {
        float val_1;
        if(this.explosionScript != null)
        {
                val_1 = this.explosionScript.healthPoints;
        }
        else
        {
                val_1 = 1.651491E-34f;
        }
        
        this.explosionScript.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  val_1, 丛世一丟丞丁业丘丒:  0);
    }
    public TargetDetectExplosion()
    {
    
    }

}
