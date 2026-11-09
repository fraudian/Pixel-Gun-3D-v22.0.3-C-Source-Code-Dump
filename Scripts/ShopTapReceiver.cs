using UnityEngine;
public class ShopTapReceiver : MonoBehaviour
{
    // Fields
    private bool 丂丟丆下丏丄丛丑专;
    private float 三丙丑东专丂丏丑丆;
    private UISprite 丄世业且下业上丄丟;
    private static System.Action 东不丗世丛丛丏丘丙;
    
    // Methods
    internal static void 万三丗丌三丝丕七丑(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ShopTapReceiver.东不丗世丛丛丏丘丙, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 上丗丐丛下且世万世(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ShopTapReceiver.东不丗世丛丛丏丘丙, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void Start()
    {
        if(this.丄世业且下业上丄丟 != 0)
        {
                return;
        }
        
        this.丄世业且下业上丄丟 = this.GetComponentInChildren<UISprite>();
    }
    private void 三丛丟且丈丟丐丛七()
    {
        UISprite val_3;
        if(this.丄世业且下业上丄丟 != 0)
        {
            goto label_3;
        }
        
        val_3 = this.GetComponentInChildren<UISprite>();
        this.丄世业且下业上丄丟 = val_3;
        if(val_3 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_3 = this.丄世业且下业上丄丟;
        if(val_3 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        val_3.spriteName = "green_btn";
        this.丂丟丆下丏丄丛丑专 = false;
    }
    private void 丆业丞丈与丌丁丛世()
    {
        this.丂丟丆下丏丄丛丑专 = true;
        this.三丙丑东专丂丏丑丆 = UnityEngine.Time.realtimeSinceStartup;
    }
    private void Update()
    {
        if(this.丂丟丆下丏丄丛丑专 == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.三丙丑东专丂丏丑丆;
        if(val_1 <= 0.16f)
        {
                return;
        }
        
        this.三丙丑东专丂丏丑丆 = UnityEngine.Time.realtimeSinceStartup;
        this.丄世业且下业上丄丟.spriteName = ((this.丄世业且下业上丄丟.spriteName.Equals(value:  "green_btn")) != true) ? "green_btn_n" : "green_btn";
    }
    internal static void 与丝丏丏丌丐万丄丙(System.Action 丕丒上丄丒业丕丕丐)
    {
        if(ShopTapReceiver.东不丗世丛丛丏丘丙 != null)
        {
                if(((System.Array.IndexOf<System.Delegate>(array:  ShopTapReceiver.东不丗世丛丛丏丘丙, value:  丕丒上丄丒业丕丕丐)) & 2147483648) == 0)
        {
                return;
        }
        
        }
        
        ShopTapReceiver.万三丗丌三丝丕七丑(丙业与丙丗丝不丈东:  丕丒上丄丒业丕丕丐);
    }
    private void OnClick()
    {
        InGameGUI val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        UIJoystick val_21;
        var val_22;
        if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)
        {
                return;
        }
        
        val_14 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_14.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_14 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_14.ExitingInCampaign == true)
        {
                return;
        }
        
        }
        
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_16 = null;
            val_16 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_17 = null;
            val_17 = null;
            val_18 = null;
            val_18 = null;
            val_14 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_14 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(丛丌丐丞丅丟专七丂() == 1000)
        {
                return;
        }
        
        }
        
        }
        
        val_14 = 1152921505079742464;
        val_19 = null;
        val_19 = null;
        if(LoadingInAfterGame.世丁与丙丈世丏下丌 != false)
        {
                return;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        val_21 = JoystickController.丗三丄与丂丟丌专东;
        if(val_21 != 0)
        {
                val_22 = null;
            val_22 = null;
            val_21 = JoystickController.丗三丄与丂丟丌专东;
            val_21.Reset();
        }
        
        if(ShopTapReceiver.东不丗世丛丛丏丘丙 != null)
        {
                ShopTapReceiver.东不丗世丛丛丏丘丙.Invoke();
            return;
        }
        
        UnityEngine.Debug.Log(message:  "ShopClicked == null");
    }
    private void OnDestroy()
    {
    
    }
    public ShopTapReceiver()
    {
    
    }

}
