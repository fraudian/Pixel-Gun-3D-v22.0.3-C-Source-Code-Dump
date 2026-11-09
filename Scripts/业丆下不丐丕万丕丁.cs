using UnityEngine;
private sealed class BaseBot.业丆下不丐丕万丕丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public RilisoftBot.BaseBot 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseBot.业丆下不丐丕万丕丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RilisoftBot.BaseBot val_16;
        float val_17;
        int val_18;
        val_16 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_25;
        }
        
        val_17 = this.丕丕世且下一与丝与;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_17 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_16 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  val_17);
        val_18 = 1;
        this.丒上七丌业七丟与丐 = val_16;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        float val_2 = this.丝且与丝丒丟万丁专.deathSound.length;
        val_17 = val_2;
        val_16.TryPlayDeathSound(丕丕世且下一与丝与:  val_2);
        this.丝且与丝丒丟万丁专.且丈丘三丆一丟丌丐.Stop();
        if((UnityEngine.TrackedReference.op_Implicit(exists:  this.丝且与丝丒丟万丁专.且丈丘三丆一丟丌丐.Item[this.丝且与丝丒丟万丁专.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁])) != false)
        {
                bool val_5 = this.丝且与丝丒丟万丁专.且丈丘三丆一丟丌丐.Play(animation:  this.丝且与丝丒丟万丁专.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁);
            val_17 = UnityEngine.Mathf.Max(a:  val_17, b:  this.丝且与丝丒丟万丁专.且丈丘三丆一丟丌丐.Item[this.丝且与丝丒丟万丁专.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁].length);
            float val_10 = this.丝且与丝丒丟万丁专.且丈丘三丆一丟丌丐.Item[this.丝且与丝丒丟万丁专.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁].length;
            val_10 = val_10 * 1.25f;
            UnityEngine.Coroutine val_12 = val_16.StartCoroutine(routine:  val_16.丕下丑丅下七七且丌(丕丕世且下一与丝与:  val_10));
        }
        else
        {
                this.丝且与丝丒丟万丁专.<东世丐丘丏丂丑专三>k__BackingField = true;
        }
        
        UnityEngine.Coroutine val_14 = val_16.StartCoroutine(routine:  val_16.七下下丗丕且万与丅(丕丕世且下一与丝与:  val_17));
        this.丝且与丝丒丟万丁专.丏七东七丝丁丄丐一.enabled = false;
        if(this.丝且与丝丒丟万丁专.三丝丌丙丂世丈一丟 != 0)
        {
                val_16 = this.丝且与丝丒丟万丁专.三丝丌丙丂世丈一丟;
            val_16.enabled = false;
        }
        
        label_25:
        val_18 = 0;
        return (bool)val_18;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
