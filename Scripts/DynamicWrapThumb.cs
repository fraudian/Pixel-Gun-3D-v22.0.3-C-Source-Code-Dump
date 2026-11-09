using UnityEngine;
internal sealed class DynamicWrapThumb : UIDragDropItem
{
    // Fields
    public UnityEngine.Transform start;
    public UnityEngine.Transform end;
    public DynamicWrapScrollBar scrollBar;
    private bool 丈丆三且丑丙东丞丈;
    
    // Methods
    protected override void 丄丏丈业东万且丝万()
    {
        if(this.scrollBar == 0)
        {
                return;
        }
        
        this = this.scrollBar;
        this.scrollBar.丒丅丛一业丘世不且 = false;
    }
    protected override void 丕七业丘丑丅丑且丝(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.scrollBar != 0)
        {
                if(this.scrollBar.丁丂不丅世丈专丌丂 == false)
        {
                return;
        }
        
            this.scrollBar.丒丅丛一业丘世不且 = true;
        }
        
        UnityEngine.Vector3 val_3 = this.transform.localPosition;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = this.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        this.scrollBar.OnScroll(丑丕与丗世与丂丂与:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
    }
    private UnityEngine.Vector3 丏上丛丑丘丗与东丂(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.Vector3 val_1 = this.end.localPosition;
        UnityEngine.Vector3 val_2 = this.start.localPosition;
        float val_3 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.y, min:  val_1.y, max:  val_2.y);
        UnityEngine.Vector3 val_5 = this.transform.localPosition;
        UnityEngine.Vector3 val_7 = this.transform.localPosition;
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
    public DynamicWrapThumb()
    {
        this.丈丆三且丑丙东丞丈 = true;
    }

}
