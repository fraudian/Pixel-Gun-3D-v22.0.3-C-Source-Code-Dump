using UnityEngine;
internal sealed class 且丆丟一丒专且上不
{
    // Fields
    private 世丗与丕丏丂业丁丙 <七丆世丁丄丌丏丏且>k__BackingField;
    private UnityEngine.Coroutine 与丈丁丄丅丂丘不东;
    private static 且丆丟一丒专且上不 丝业丆丁业三丈丟东;
    
    // Properties
    internal static 且丆丟一丒专且上不 丆丕丝丒不丙且丐丗 { get; }
    internal 世丗与丕丏丂业丁丙 上丅丑丌丑丏丏丙东 { get; set; }
    
    // Methods
    internal static 且丆丟一丒专且上不 丑七不且上丗丁一世()
    {
        且丆丟一丒专且上不 val_2 = 且丆丟一丒专且上不.丝业丆丁业三丈丟东;
        if(val_2 != null)
        {
                return val_2;
        }
        
        且丆丟一丒专且上不 val_1 = null;
        val_2 = val_1;
        val_1 = new 且丆丟一丒专且上不();
        且丆丟一丒专且上不.丝业丆丁业三丈丟东 = val_2;
        return val_2;
    }
    internal void 三丑丛丄万丟丄丞丁()
    {
        if((this.<七丆世丁丄丌丏丏且>k__BackingField) == 1)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        this.<七丆世丁丄丌丏丏且>k__BackingField = 1;
        this.丅丘丌丂且与丙丘且();
        this.与丈丁丄丅丂丘不东 = CoroutineRunner.Instance.StartCoroutine(routine:  this.下且且业且三万丂专());
    }
    internal void 丌丄丏下七丁专丂世()
    {
        if((this.<七丆世丁丄丌丏丏且>k__BackingField) != 1)
        {
                return;
        }
        
        this.<七丆世丁丄丌丏丏且>k__BackingField = 0;
        this.丅丘丌丂且与丙丘且();
    }
    private System.Collections.IEnumerator 下且且业且三万丂专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new 且丆丟一丒专且上不.丟丕丕丂三丐丆丏丝();
    }
    private void 丅丘丌丂且与丙丘且()
    {
        if(this.与丈丁丄丅丂丘不东 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.与丈丁丄丅丂丘不东);
        this.与丈丁丄丅丂丘不东 = 0;
    }
    private 且丆丟一丒专且上不()
    {
    
    }
    internal 世丗与丕丏丂业丁丙 万丘三丘下与与且业()
    {
        return (世丗与丕丏丂业丁丙)this.<七丆世丁丄丌丏丏且>k__BackingField;
    }
    internal void 丒丟丛丂丆三三丙丑(世丗与丕丏丂业丁丙 丙业与丙丗丝不丈东)
    {
        this.<七丆世丁丄丌丏丏且>k__BackingField = 丙业与丙丗丝不丈东;
    }

}
