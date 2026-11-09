using UnityEngine;
internal sealed class DisableObjectAfterDelay : PGBehaviour
{
    // Fields
    public float timer;
    public bool isDestroy;
    private float 丄一丒丛丄丙丞一上;
    
    // Methods
    private void OnEnable()
    {
        this.丄一丒丛丄丙丞一上 = this.timer;
    }
    private void Update()
    {
        if(this.丄一丒丛丄丙丞一上 < 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丄一丒丛丄丙丞一上 - val_1;
        this.丄一丒丛丄丙丞一上 = val_1;
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
    public DisableObjectAfterDelay()
    {
        this.timer = -1f;
    }

}
