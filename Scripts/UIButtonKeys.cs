using UnityEngine;
public class UIButtonKeys : UIKeyNavigation
{
    // Fields
    public UIButtonKeys selectOnClick;
    public UIButtonKeys selectOnUp;
    public UIButtonKeys selectOnDown;
    public UIButtonKeys selectOnLeft;
    public UIButtonKeys selectOnRight;
    
    // Methods
    protected override void OnEnable()
    {
        this.Upgrade();
        this.OnEnable();
    }
    public void Upgrade()
    {
        if(137146368 == 0)
        {
                if(this.selectOnClick != 0)
        {
                mem[1152921531072989072] = this.selectOnClick.gameObject;
            this.selectOnClick = 0;
            不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this);
        }
        
        }
        
        if(this.selectOnClick == 0)
        {
                if(this.selectOnLeft != 0)
        {
                mem[1152921531072989056] = this.selectOnLeft.gameObject;
            this.selectOnLeft = 0;
            不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this);
        }
        
        }
        
        if(this.selectOnLeft == 0)
        {
                if(this.selectOnRight != 0)
        {
                mem[1152921531072989064] = this.selectOnRight.gameObject;
            this.selectOnRight = 0;
            不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this);
        }
        
        }
        
        if(this.selectOnRight == 0)
        {
                if(this.selectOnUp != 0)
        {
                mem[1152921531072989040] = this.selectOnUp.gameObject;
            this.selectOnUp = 0;
            不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this);
        }
        
        }
        
        if(this.selectOnUp != 0)
        {
                return;
        }
        
        if(this.selectOnDown == 0)
        {
                return;
        }
        
        mem[1152921531072989048] = this.selectOnDown.gameObject;
        this.selectOnDown = 0;
        不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this);
    }
    public UIButtonKeys()
    {
    
    }

}
