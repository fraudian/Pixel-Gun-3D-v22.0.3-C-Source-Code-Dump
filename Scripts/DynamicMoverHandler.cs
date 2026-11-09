using UnityEngine;
internal sealed class DynamicMoverHandler : UIDragDropItem
{
    // Fields
    private UnityEngine.Transform 丙与七世丑丐七丗七;
    private UnityEngine.Transform 世丙丝一丛三丞世丑;
    private System.Action 丝丑丂丒丟下丆万不;
    private System.Action<UnityEngine.Vector2> 下丟专丄上丟业且丄;
    private bool 丈丆三且丑丙东丞丈;
    
    // Methods
    public void add_OnDragEnd(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丝丑丂丒丟下丆万不, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝丑丂丒丟下丆万不 != 1152921537082370048);
    
    }
    public void remove_OnDragEnd(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丝丑丂丒丟下丆万不, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝丑丂丒丟下丆万不 != 1152921537082506624);
    
    }
    public void add_OnDragMove(System.Action<UnityEngine.Vector2> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.下丟专丄上丟业且丄, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.下丟专丄上丟业且丄 != 1152921537082643208);
    
    }
    public void remove_OnDragMove(System.Action<UnityEngine.Vector2> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.下丟专丄上丟业且丄, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.下丟专丄上丟业且丄 != 1152921537082779784);
    
    }
    internal void 丘上丐世丆丑且丞丒(UnityEngine.Transform 丑丝丙业丐与丛世丘, UnityEngine.Transform 丕丈丑丈万专丕丅丙)
    {
        this.丙与七世丑丐七丗七 = 丑丝丙业丐与丛世丘;
        this.世丙丝一丛三丞世丑 = 丕丈丑丈万专丕丅丙;
    }
    protected override void 丄丏丈业东万且丝万()
    {
        if(this.丝丑丂丒丟下丆万不 == null)
        {
                return;
        }
        
        this.丝丑丂丒丟下丆万不.Invoke();
    }
    protected override void 丕七业丘丑丅丑且丝(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.下丟专丄上丟业且丄 == null)
        {
                return;
        }
        
        this.下丟专丄上丟业且丄.Invoke(obj:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    internal UnityEngine.Vector3 丏上丛丑丘丗与东丂(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.Vector3 val_1 = this.丙与七世丑丐七丗七.localPosition;
        UnityEngine.Vector3 val_2 = this.世丙丝一丛三丞世丑.localPosition;
        float val_3 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.x, min:  val_1.x, max:  val_2.x);
        UnityEngine.Vector3 val_4 = this.丙与七世丑丐七丗七.localPosition;
        UnityEngine.Vector3 val_5 = this.世丙丝一丛三丞世丑.localPosition;
        float val_6 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.y, min:  val_4.y, max:  val_5.y);
        UnityEngine.Vector3 val_8 = this.transform.localPosition;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void OnApplicationFocus(bool 丄丈丁下丛世丙丗上)
    {
        this.丈丆三且丑丙东丞丈 = 丄丈丁下丛世丙丗上;
    }
    private void Update()
    {
        if(this.丈丆三且丑丙东丞丈 != false)
        {
                return;
        }
        
        if(this.丈丆三且丑丙东丞丈 == false)
        {
                return;
        }
        
        this.StopDragging(丝三丁东丈丒世丅业:  UICamera.hoveredObject);
    }
    public DynamicMoverHandler()
    {
        this.丈丆三且丑丙东丞丈 = true;
    }

}
