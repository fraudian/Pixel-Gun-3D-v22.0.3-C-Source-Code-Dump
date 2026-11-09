using UnityEngine;
private sealed class StickerPackScroll.丈上七专不丗上业七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public StickerPackScroll 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StickerPackScroll.丈上七专不丗上业七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        UnityEngine.Object val_16;
        UnityEngine.Transform val_17;
        int val_18;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丅丞丕丁丈丁丅三丁 == 0)
        {
                this.丝且与丝丒丟万丁专.丅丞丕丁丈丁丅三丁 = this.丝且与丝丒丟万丁专.parentButton.GetComponent<UIGrid>();
        }
        
        this.丝且与丝丒丟万丁专.listItemData = StickersController.丗下丂与万丘丒丗世();
        val_15 = 0;
        val_16 = 0;
        goto label_10;
        label_24:
        BtnPackItem val_4 = this.丝且与丝丒丟万丁专.listButton.Item[0];
        UnityEngine.Transform val_6 = val_4.transform;
        if((this.丝且与丝丒丟万丁专.listItemData.Contains(item:  val_4.typePack)) != false)
        {
                val_17 = this.丝且与丝丒丟万丁专.parentButton.transform;
            val_6.parent = val_17;
            val_4.gameObject.SetActive(value:  true);
            var val_10 = (val_16 != 0) ? (val_4) : (val_16);
        }
        else
        {
                val_17 = this.丝且与丝丒丟万丁专.transform;
            val_6.parent = val_17;
            val_4.gameObject.SetActive(value:  false);
        }
        
        val_15 = 1;
        label_10:
        if(val_15 < this.丝且与丝丒丟万丁专.listButton.Count)
        {
            goto label_24;
        }
        
        if(val_16 != 0)
        {
                this.丝且与丝丒丟万丁专.ShowPack(下下丏一丙不丘丌丞:  4194311);
        }
        
        val_18 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.Sort();
        label_2:
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
