using UnityEngine;
public class TouchButtonDelayed : TouchButton
{
    // Fields
    private float 丄且丈一万业丗丝丞;
    private UnityEngine.Vector2 丅丄丗且丞业丈丒且;
    private float 上与丞丑与丄丒与丏;
    private float 一丟丅丐世丑三丂业;
    private bool 丑丌丘丞丞万丌丞且;
    private bool 丈丈上丕万丏丈世上;
    private bool 丙与丟丑丑丏丟丑丅;
    private int 业丐三丒丑三丑世丒;
    private int 万东丄丏丏丏东业七;
    protected float 丂七上与上不丘丐丛;
    
    // Methods
    public override void ButtonUpdate()
    {
        var val_14;
        float val_15;
        var val_16;
        float val_17;
        val_14 = 0;
        this.ButtonUpdate();
        if(this.丙与丟丑丑丏丟丑丅 != false)
        {
                if(this.业丐三丒丑三丑世丒 < UnityEngine.Time.frameCount)
        {
                this.丙与丟丑丑丏丟丑丅 = false;
            val_14 = 0;
            this.SetPressed(丁丐不且七丂业丗丆:  false);
        }
        
        }
        
        if(this.丈丈上丕万丏丈世上 != false)
        {
                val_15 = this.上与丞丑与丄丒与丏;
            if(val_15 <= 0f)
        {
                this.丈丈上丕万丏丈世上 = false;
            val_14 = public System.Boolean TouchButton::CanPress();
            if(this.CanPress() != false)
        {
                int val_3 = UnityEngine.Input.touchCount;
            if(val_3 >= 1)
        {
                do
        {
            UnityEngine.Touch val_4 = UnityEngine.Input.GetTouch(index:  0);
            val_15 = val_15;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_15, y = V1.16B}, b:  new UnityEngine.Vector2() {x = this.丅丄丗且丞业丈丒且, y = V9.16B});
            if((UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y})) < 0)
        {
                val_14 = 1;
            this.SetPressed(丁丐不且七丂业丗丆:  true);
            this.万东丄丏丏丏东业七 = UnityEngine.Time.frameCount;
        }
        else
        {
                val_14 = 0;
            if((1152921540544111192 & 1) != 0)
        {
                this.丑丌丘丞丞万丌丞且 = true;
            this.一丟丅丐世丑三丂业 = X25 + 24;
        }
        
        }
        
            val_16 = 0 + 1;
        }
        while(val_3 != val_16);
        
        }
        
        }
        
        }
        
            val_17 = this.上与丞丑与丄丒与丏;
            float val_8 = UnityEngine.Time.deltaTime;
            val_8 = val_17 - val_8;
            this.上与丞丑与丄丒与丏 = val_8;
        }
        
        if(this.丑丌丘丞丞万丌丞且 == false)
        {
                return;
        }
        
        if(this.一丟丅丐世丑三丂业 <= 0f)
        {
                this.丑丌丘丞丞万丌丞且 = false;
            if(this.CanPress() != false)
        {
                int val_10 = UnityEngine.Input.touchCount;
            if(val_10 >= 1)
        {
                do
        {
            UnityEngine.Touch val_11 = UnityEngine.Input.GetTouch(index:  0);
            if((1152921540544111192 & 1) != 0)
        {
                this.SetPressed(丁丐不且七丂业丗丆:  true);
            this.万东丄丏丏丏东业七 = UnityEngine.Time.frameCount;
        }
        
            val_16 = 0 + 1;
        }
        while(val_10 != val_16);
        
        }
        
        }
        
        }
        
        val_17 = this.一丟丅丐世丑三丂业;
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = val_17 - val_13;
        this.一丟丅丐世丑三丂业 = val_13;
    }
    public override bool OnPress(bool 丆且上丘世下丅且丞, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_8;
        if(丆且上丘世下丅且丞 != false)
        {
                if(((this.CanPress() != false) && ((1152921540544247864 & 1) != 0)) && (null != null))
        {
                this.丈丈上丕万丏丈世上 = true;
            this.上与丞丑与丄丒与丏 = this.丂七上与上不丘丐丛;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
            this.丅丄丗且丞业丈丒且 = val_2;
            mem[1152921540544247948] = val_2.y;
        }
        
            var val_3 = (this.丈丈上丕万丏丈世上 == true) ? 1 : 0;
            return (bool)val_8;
        }
        
        if((this.丈丈上丕万丏丈世上 != true) && (this.丑丌丘丞丞万丌丞且 != true))
        {
                if(this.万东丄丏丏丏东业七 != UnityEngine.Time.frameCount)
        {
                if(this.万东丄丏丏丏东业七 != (UnityEngine.Time.frameCount - 1))
        {
            goto label_12;
        }
        
        }
        
        }
        
        if((1152921540544247864 & 1) != 0)
        {
                this.SetPressed(丁丐不且七丂业丗丆:  true);
            this.丙与丟丑丑丏丟丑丅 = true;
            this.业丐三丒丑三丑世丒 = UnityEngine.Time.frameCount;
        }
        else
        {
                label_12:
            this.SetPressed(丁丐不且七丂业丗丆:  false);
        }
        
        val_8 = 0;
        this.丈丈上丕万丏丈世上 = false;
        return (bool)val_8;
    }
    public override void Reset()
    {
        mem[1152921540544359881] = 0;
        this.丈丈上丕万丏丈世上 = false;
    }
    public TouchButtonDelayed()
    {
        float val_4 = 0.0001f;
        val_4 = (float)UnityEngine.Screen.height * val_4;
        this.万东丄丏丏丏东业七 = 0;
        this.丂七上与上不丘丐丛 = 0.045f;
        val_4 = val_4 * (float)UnityEngine.Screen.height;
        mem[1152921540544471880] = 1;
        this.丄且丈一万业丗丝丞 = val_4;
        mem[1152921540544471920] = 1109393408;
        this = new UnityEngine.MonoBehaviour();
    }

}
