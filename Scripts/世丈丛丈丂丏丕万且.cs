using UnityEngine;
private sealed class Player_move_c.世丈丛丈丂丏丕万且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    public bool 下世一丞丝专业不丕;
    public float 丌专东上丛丂丄且丒;
    public float 丌丐且丄业丆丁丝万;
    public float 丕丕世且下一与丝与;
    private float 丛丌万丘丒丘不七不;
    private float 丐专东不上下丘丌丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.世丈丛丈丂丏丕万且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UISprite val_8;
        float val_9;
        int val_10;
        float val_11;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.专七丟丙丝丕丄丌丏 = true;
        if(this.下世一丞丝专业不丕 == false)
        {
            goto label_5;
        }
        
        this.丛丌万丘丒丘不七不 = this.丌专东上丛丂丄且丒;
        this.丐专东不上下丘丌丞 = this.丌丐且丄业丆丁丝万;
        val_9 = this.丌专东上丛丂丄且丒;
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.ChargeValue;
        if(val_8 != 0)
        {
                val_8 = this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.ChargeValue.gameObject;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  false);
        }
        
        val_10 = 0;
        this.丝且与丝丒丟万丁专.专七丟丙丝丕丄丌丏 = false;
        this.丝且与丝丒丟万丁专.三丟一丛与丙业丘七 = 0;
        return (bool)val_10;
        label_2:
        val_9 = this.丛丌万丘丒丘不七不;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_6:
        if(val_9 > 0f)
        {
            goto label_17;
        }
        
        label_5:
        val_11 = this.丕丕世且下一与丝与;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_11);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_10 = 1;
        return (bool)val_10;
        label_3:
        val_10 = 0;
        return (bool)val_10;
        label_17:
        float val_6 = UnityEngine.Mathf.Max(a:  0f, b:  val_9 - UnityEngine.Time.deltaTime);
        float val_8 = this.丌专东上丛丂丄且丒;
        float val_9 = this.丐专东不上下丘丌丞;
        this.丛丌万丘丒丘不七不 = val_6;
        val_8 = val_6 / val_8;
        val_11 = UnityEngine.Mathf.Lerp(a:  0f, b:  val_9, t:  val_8);
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.ChargeValue.fillAmount = val_11;
        val_9 = 1f - val_11;
        this.丝且与丝丒丟万丁专.丙且丁业与丄丝世丈.ChargeValue.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_10 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
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
