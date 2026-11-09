using UnityEngine;
internal sealed class TaskUIImposterNumButton : PGBehaviour
{
    // Fields
    private System.Action<TaskUIImposterNumButton> 丏与一丏且丂丄丑丐;
    internal UIButton button;
    internal UIWidget widget;
    private UILabel _numberLabel;
    private UnityEngine.GameObject _activatedGO;
    private UnityEngine.GameObject _failedGO;
    private int <不丕丐丘一丂东七万>k__BackingField;
    
    // Properties
    internal bool 丑丌上丆丙丐丛一丗 { get; }
    internal bool 且丅丐丈上不丈丏专 { get; }
    internal int 一丘丁丒丂丁不万世 { get; set; }
    
    // Methods
    internal void 万丂丐丛丒万下丝一(System.Action<TaskUIImposterNumButton> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丏与一丏且丂丄丑丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏与一丏且丂丄丑丐 != 1152921537601366712);
    
    }
    internal void 丙与丏丈丘三丅丏丟(System.Action<TaskUIImposterNumButton> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丏与一丏且丂丄丑丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏与一丏且丂丄丑丐 != 1152921537601503288);
    
    }
    internal bool 丑丈与丛丕一丞丏丐()
    {
        if(this._activatedGO == 0)
        {
                return false;
        }
        
        if(this._activatedGO != null)
        {
                return this._activatedGO.activeSelf;
        }
        
        return this._activatedGO.activeSelf;
    }
    internal bool 丞且丐下丏丂丘七东()
    {
        if(this._failedGO == 0)
        {
                return false;
        }
        
        if(this._failedGO != null)
        {
                return this._failedGO.activeSelf;
        }
        
        return this._failedGO.activeSelf;
    }
    internal int 一丗专丅丐丝业万丒()
    {
        return (int)this.<不丕丐丘一丂东七万>k__BackingField;
    }
    private void 丛丕万丏丒丌丄与丗(int 丙业与丙丗丝不丈东)
    {
        this.<不丕丐丘一丂东七万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丈且东丑丂且万丒丅(int 丑丅世丐丒丏丐三丅)
    {
        this.<不丕丐丘一丂东七万>k__BackingField = 丑丅世丐丒丏丐三丅;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._numberLabel, 丕丗丘丑丛与丑业丒:  丑丅世丐丒丏丐三丅);
        this.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  false);
        this.丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  false);
    }
    internal void Reset()
    {
        this.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  false);
        this.丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  false);
    }
    internal void 丛七丘上丂上丘丙丞(bool 丏业丟一东丂东丘丛)
    {
        丏业丟一东丂东丘丛 = 丏业丟一东丂东丘丛;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._failedGO, 丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    internal void 东丄丅丆丙丏丟丏丒(bool 丏业丟一东丂东丘丛)
    {
        丏业丟一东丂东丘丛 = 丏业丟一东丂东丘丛;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._activatedGO, 丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    private void OnClick()
    {
        if(this.丏与一丏且丂丄丑丐 == null)
        {
                return;
        }
        
        this.丏与一丏且丂丄丑丐.Invoke(obj:  this);
    }
    public TaskUIImposterNumButton()
    {
    
    }

}
