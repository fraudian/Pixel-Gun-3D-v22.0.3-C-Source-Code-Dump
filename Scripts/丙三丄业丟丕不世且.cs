using UnityEngine;
private sealed class Player_move_c.丙三丄业丟丕不世且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.GameObject 丌专万丄与丕一东丗;
    public Player_move_c 丝且与丝丒丟万丁专;
    public float 丄且一丄丏丆丐丗与;
    public float 丈丝世且万世丈丌万;
    public float 丏上万丅丏一不不丕;
    private UnityEngine.GUITexture 丝不丛丂不丏丂万丝;
    private float 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丙三丄业丟丕不世且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Object[] val_13;
        string val_14;
        val_13 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丌专万丄与丕一东丗 != 0)
        {
            goto label_5;
        }
        
        val_13 = new object[1];
        val_13[0] = this.丝且与丝丒丟万丁专.GetType();
        val_14 = "{0}: currentObject == null";
        goto label_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝不丛丂不丏丂万丝 == 0)
        {
            goto label_17;
        }
        
        UnityEngine.Color val_5 = this.丝不丛丂不丏丂万丝.color;
        this.丝不丛丂不丏丂万丝.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = this.丈丝世且万世丈丌万};
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = val_6 / this.丏上万丅丏一不不丕;
        val_6 = this.丈丌丝且业丏丈丂丁 + val_6;
        this.丈丌丝且业丏丈丂丁 = val_6;
        if(val_6 < 0)
        {
            goto label_20;
        }
        
        return false;
        label_5:
        this.丝不丛丂不丏丂万丝 = this.丌专万丄与丕一东丗.GetComponent<UnityEngine.GUITexture>();
        this.丈丌丝且业丏丈丂丁 = 0f;
        label_20:
        if(this.丝不丛丂不丏丂万丝 != 0)
        {
            goto label_25;
        }
        
        label_17:
        object[] val_9 = new object[1];
        val_13 = val_9;
        val_13[0] = this.丝且与丝丒丟万丁专.GetType();
        val_14 = "{0}: texture == null";
        label_14:
        UnityEngine.Debug.LogWarningFormat(format:  val_14, args:  val_9);
        return false;
        label_25:
        UnityEngine.Color val_11 = this.丝不丛丂不丏丂万丝.color;
        this.丝不丛丂不丏丂万丝.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = UnityEngine.Mathf.Lerp(a:  this.丄且一丄丏丆丐丗与, b:  this.丈丝世且万世丈丌万, t:  this.丈丌丝且业丏丈丂丁)};
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
