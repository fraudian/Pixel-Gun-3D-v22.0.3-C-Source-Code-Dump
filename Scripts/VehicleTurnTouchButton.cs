using UnityEngine;
public class VehicleTurnTouchButton : VehiclePedalTouchButton
{
    // Fields
    private bool 丆丌一丝万丕丝世不;
    private int 业丞不丕专上一万上;
    
    // Methods
    public override bool OnPress(bool 丆且上丘世下丅且丞, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_2;
        int val_3;
        if(丆且上丘世下丅且丞 != false)
        {
                val_2 = null;
            val_2 = null;
            val_3 = UICamera.currentTouchID;
        }
        else
        {
                val_3 = 0;
        }
        
        bool val_1 = 丆且上丘世下丅且丞;
        this.业丞不丕专上一万上 = val_3;
        this.丆丌一丝万丕丝世不 = val_1;
        return val_1;
    }
    public override void ButtonUpdate()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = 0;
        this.ButtonUpdate();
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        val_8 = val_1.x;
        val_9 = val_1.y;
        val_10 = 0;
        goto label_3;
        label_8:
        UnityEngine.Touch[] val_2 = UnityEngine.Input.touches;
        if(val_10 >= val_2.Length)
        {
                val_11 = 0;
        }
        
        val_7 = 0;
        if((0 + 32.GetHashCode()) == this.业丞不丕专上一万上)
        {
            goto label_6;
        }
        
        val_10 = 1;
        label_3:
        UnityEngine.Touch[] val_5 = UnityEngine.Input.touches;
        if(val_10 < val_5.Length)
        {
            goto label_8;
        }
        
        goto label_9;
        label_6:
        UnityEngine.Touch[] val_6 = UnityEngine.Input.touches;
        if(val_10 >= val_6.Length)
        {
                val_11 = 0;
        }
        
        var val_7 = val_6 + (0 * 68);
        val_6 = val_7 + 32;
        val_7 = 0;
        val_8 = val_1.x;
        val_9 = val_1.y;
        label_9:
        if(val_7 == 0)
        {
                if((this.丆丌一丝万丕丝世不 != false) && (((this.CanPress() != false) && ((1152921540680659400 & 1) != 0)) && (null != null)))
        {
                val_11 = public System.Void TouchButton::SetPressed(bool 丁丐不且七丂业丗丆);
            this.SetPressed(丁丐不且七丂业丗丆:  true);
            mem[1152921540680659417] = 1;
        }
        else
        {
                if(this.丆丌一丝万丕丝世不 == false)
        {
                return;
        }
        
        }
        
        }
        
        if(this.丆丌一丝万丕丝世不 != false)
        {
                if((1152921540680659400 & 1) != 0)
        {
                return;
        }
        
        }
        
        this.SetPressed(丁丐不且七丂业丗丆:  false);
        if((null != null) && ((1152921540680659400 & 1) != 0))
        {
                this.OnClick();
        }
        
        mem[1152921540680659417] = 0;
    }
    public VehicleTurnTouchButton()
    {
        this.业丞不丕专上一万上 = 0;
        val_1 = new TouchButton();
    }

}
