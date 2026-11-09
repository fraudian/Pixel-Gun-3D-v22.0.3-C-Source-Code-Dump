using UnityEngine;
internal sealed class DetectExplosionObject : BaseExplosionObject
{
    // Fields
    private bool 丒丏丕丁丗丟丙不丑;
    public float durationBeforeExplosion;
    
    // Methods
    private void 世丐丘丂丆丈且丁丕(bool 丑丒业丘丑东丕世丅)
    {
        UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.enabled = 丑丒业丘丑东丕世丅;
    }
    private void Awake()
    {
        this.世丐丘丂丆丈且丁丕(丑丒业丘丑东丕世丅:  false);
    }
    private void OnTriggerEnter(UnityEngine.Collider 丛丂丁丅丂东丒东丅)
    {
        this.三东三世丑业七丆丗(丛丂丁丅丂东丒东丅:  丛丂丁丅丂东丒东丅.gameObject);
    }
    private void OnCollisionEnter(UnityEngine.Collision 丛丂丁丅丂东丒东丅)
    {
        this.三东三世丑业七丆丗(丛丂丁丅丂东丒东丅:  丛丂丁丅丂东丒东丅.gameObject);
    }
    private void 三东三世丑业七丆丗(UnityEngine.GameObject 丛丂丁丅丂东丒东丅)
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
                this.Invoke(methodName:  "RunExplosion", time:  this.durationBeforeExplosion);
            return;
        }
        
        this.RunExplosion();
    }
    protected override void 上不丒丘且丑专丞丕()
    {
        this.上不丒丘且丑专丞丕();
        this.世丐丘丂丆丈且丁丕(丑丒业丘丑东丕世丅:  true);
    }
    public DetectExplosionObject()
    {
    
    }

}
