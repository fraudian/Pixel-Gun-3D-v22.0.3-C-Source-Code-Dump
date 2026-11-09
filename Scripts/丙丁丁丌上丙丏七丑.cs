using UnityEngine;
private sealed class 七丆丐丕一丐丅丆丞.丙丁丁丌上丙丏七丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 七丆丐丕一丐丅丆丞 丝且与丝丒丟万丁专;
    private int 世丒丒上丐丒东丑丄;
    private int 上丘丒丝且上丗丄万;
    private int 丕丏与丌丁下丆丌世;
    private int 丐丐丝丈丛与世与丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 七丆丐丕一丐丅丆丞.丙丁丁丌上丙丏七丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_12;
        int val_13;
        int val_14;
        int val_15;
        int val_16;
        val_12 = this;
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
        int val_1 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  this.丝且与丝丒丟万丁专.<世丗丁且丄丄丆七丏>k__BackingField);
        this.世丒丒上丐丒东丑丄 = val_1;
        int val_3 = ((val_1 < 0) ? (val_1 + 1) : (val_1)) >> 1;
        int val_4 = UnityEngine.Random.Range(min:  0, max:  val_3);
        this.上丘丒丝且上丗丄万 = val_4;
        val_13 = this.世丒丒上丐丒东丑丄;
        val_3 = 40 / (val_13 - val_4);
        this.丕丏与丌丁下丆丌世 = System.Math.Min(val1:  30, val2:  val_3);
        val_14 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  3f);
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_1:
        val_15 = val_12;
        val_16 = this.丐丐丝丈丛与世与丄 + 1;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丐丐丝丈丛与世与丄 = val_16;
        goto label_10;
        label_2:
        val_16 = this.上丘丒丝且上丗丄万;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = this.丐丐丝丈丛与世与丄;
        this.丐丐丝丈丛与世与丄 = val_16;
        label_10:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = null;
        val_13 = val_8;
        val_8 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_16 < this.世丒丒上丐丒东丑丄)
        {
                val_8.set_Item(key:  "room_count", value:  val_15);
            this.丝且与丝丒丟万丁专.业丆世丐三丒丟专丟(丑与丂丌世丕丆一丗:  val_8, 东丞丒丙世丏三下丟:  val_15, 丁不七丙下七丐与不:  public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value));
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  (float)this.丕丏与丌丁下丆丌世);
            this.丗丏丅丕丆世丁专丟 = 2;
            val_14 = 1;
            return (bool)val_14;
        }
        
        val_8.set_Item(key:  "room_id", value:  0.专下与与下丙丅丙丛());
        val_12 = 1;
        val_8.set_Item(key:  "group", value:  1);
        this.丝且与丝丒丟万丁专.上三万且丆丅丙万丗(丑与丂丌世丕丆一丗:  val_8, 东丞丒丙世丏三下丟:  1, 丁不七丙下七丐与不:  public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value));
        label_3:
        val_14 = 0;
        return (bool)val_14;
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
