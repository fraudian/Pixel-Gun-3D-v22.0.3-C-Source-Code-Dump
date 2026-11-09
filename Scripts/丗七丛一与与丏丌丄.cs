using UnityEngine;
private sealed class 七丆丐丕一丐丅丆丞.丗七丛一与与丏丌丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 七丆丐丕一丐丅丆丞 丝且与丝丒丟万丁专;
    private int 世丒丒上丐丒东丑丄;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 七丆丐丕一丐丅丆丞.丗七丛一与与丏丌丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        七丆丐丕一丐丅丆丞 val_9;
        var val_10;
        int val_11;
        int val_12;
        int val_13;
        val_9 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        int val_1 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  this.丝且与丝丒丟万丁专.<世丗丁且丄丄丆七丏>k__BackingField);
        val_10 = this;
        this.世丒丒上丐丒东丑丄 = val_1;
        val_11 = UnityEngine.Random.Range(min:  System.Math.Max(val1:  0, val2:  val_1 - 2), max:  this.世丒丒上丐丒东丑丄);
        val_12 = this.丈丌丝且业丏丈丂丁;
        this.丈丌丝且业丏丈丂丁 = val_11;
        goto label_8;
        label_1:
        val_12 = this;
        val_11 = this.丈丌丝且业丏丈丂丁 + 1;
        val_10 = 1152921536967108168;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丈丌丝且业丏丈丂丁 = val_11;
        label_8:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_11 < val_10)
        {
                val_5.set_Item(key:  "room_count", value:  this.丈丌丝且业丏丈丂丁);
            val_9.业丆世丐三丒丟专丟(丑与丂丌世丕丆一丗:  val_5, 东丞丒丙世丏三下丟:  this.丈丌丝且业丏丈丂丁, 丁不七丙下七丐与不:  public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value));
            UnityEngine.WaitForSeconds val_6 = null;
            val_9 = val_6;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  4f);
            val_13 = 1;
            this.丒上七丌业七丟与丐 = val_9;
            this.丗丏丅丕丆世丁专丟 = val_13;
            return (bool)val_13;
        }
        
        val_5.set_Item(key:  "room_id", value:  0.专下与与下丙丅丙丛());
        val_5.set_Item(key:  "group", value:  1);
        val_9.上三万且丆丅丙万丗(丑与丂丌世丕丆一丗:  val_5, 东丞丒丙世丏三下丟:  1, 丁不七丙下七丐与不:  public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value));
        label_2:
        val_13 = 0;
        return (bool)val_13;
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
