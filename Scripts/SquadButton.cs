using UnityEngine;
internal sealed class SquadButton : PGBehaviour
{
    // Fields
    public UnityEngine.GameObject InviteButton;
    public UnityEngine.GameObject InfoButton;
    public UnityEngine.GameObject LeaveButton;
    public UnityEngine.GameObject reloadButton;
    public UILabel leaveTimerLabel;
    private 世三丑上丂三专丐丙 七丌丙三东丌丏下丛;
    private readonly UnityEngine.Rect 万业七丆丛丗丞三丝;
    private UnityEngine.Rect 丕丝丆丕丁且七丌丆;
    private Player_move_c 与丅业丕丑上丝丒丁;
    private Player_move_c 一上七丞丑丛丆与丛;
    private Player_move_c 丂且丐丛丘丒丅丛丒;
    private UnityEngine.Texture 丄一上下丟东上丝万;
    private SquadButton.万丄丏丛且丗丕丒丁 丕万丐东与一丈万与;
    private const float 东丘丗丝七丙丅丟三 = 10;
    private float 丂下丄下丈下七专上;
    private bool 丄丒丆丘丘丂丈世丅;
    private bool 丅丟东世专丂丁上下;
    private float 与丁一丄丑不丑丁丆;
    
    // Methods
    private void Awake()
    {
    
    }
    internal void 丂丁下丅丈丌丝丆上(float 丙业与丙丗丝不丈东)
    {
        this.与丁一丄丑不丑丁丆 = 丙业与丙丗丝不丈东;
    }
    internal void 七下七万丆丌不上与(世三丑上丂三专丐丙 丙业与丙丗丝不丈东)
    {
        this.七丌丙三东丌丏下丛 = 丙业与丙丗丝不丈东;
    }
    internal void 丗七世上丏专丘丅丒()
    {
        this.丄丒丆丘丘丂丈世丅 = true;
    }
    internal void 丌与下丐丛丌丌丂与(Player_move_c 丞丑上不世与丒丂东, bool 丅丟东世专丂丁上下)
    {
        var val_12;
        if(this.与丅业丕丑上丝丒丁 != 0)
        {
                if(丅丟东世专丂丁上下 != false)
        {
                if(this.丅丟东世专丂丁上下 == false)
        {
                return;
        }
        
        }
        
            val_12 = null;
            val_12 = null;
            UnityEngine.Vector3 val_2 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            if(this.丅丟东世专丂丁上下 != false)
        {
                if(丅丟东世专丂丁上下 == false)
        {
            goto label_12;
        }
        
        }
        
            UnityEngine.Vector3 val_3 = 丞丑上不世与丒丂东.myPlayerTransform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_7 = this.与丅业丕丑上丝丒丁.myPlayerTransform.position;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            float val_10 = UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            if((UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y})) >= 0)
        {
                return;
        }
        
        }
        
        label_12:
        this.与丅业丕丑上丝丒丁 = 丞丑上不世与丒丂东;
        this.丅丟东世专丂丁上下 = 丅丟东世专丂丁上下;
    }
    private void LateUpdate()
    {
        this.七丝丛丐不丞丌与七();
        if(this.与丅业丕丑上丝丒丁 != 0)
        {
                this.与丅业丕丑上丝丒丁 = 0;
            this.一上七丞丑丛丆与丛 = this.与丅业丕丑上丝丒丁;
        }
        
        this.丄丒丆丘丘丂丈世丅 = false;
        this.丅丟东世专丂丁上下 = false;
        this.丙丑丘业丕丗丗不丘();
    }
    private void 七丝丛丐不丞丌与七()
    {
        万丄丏丛且丗丕丒丁 val_7;
        var val_8;
        var val_9;
        var val_10;
        if(this.丂下丄下丈下七专上 >= 0f)
        {
            goto label_1;
        }
        
        if(this.丅丟东世专丂丁上下 == false)
        {
            goto label_2;
        }
        
        val_7 = 5;
        goto label_32;
        label_1:
        this.丕万丐东与一丈万与 = 3;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丂下丄下丈下七专上 - val_1;
        this.丂下丄下丈下七专上 = val_1;
        return;
        label_2:
        val_8 = null;
        val_8 = null;
        if(丗丞业丐丛三上丄丕() == true)
        {
            goto label_28;
        }
        
        val_9 = null;
        val_9 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 88.isGrounded) == false)
        {
            goto label_28;
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.Vector3 val_4 = typeof(Player_move_c).__il2cppRuntimeField_628 + 88.velocity;
        if(val_4.x >= 0)
        {
            goto label_28;
        }
        
        if(this.丄丒丆丘丘丂丈世丅 == false)
        {
            goto label_24;
        }
        
        val_7 = 4;
        goto label_32;
        label_24:
        if(this.与丅业丕丑上丝丒丁 != 0)
        {
                this.丕万丐东与一丈万与 = 0;
            return;
        }
        
        label_28:
        if((this.七丌丙三东丌丏下丛 != null) && (this.七丌丙三东丌丏下丛.丆世一丄丞专丗不东() != false))
        {
                val_7 = 1;
        }
        else
        {
                val_7 = 2;
        }
        
        label_32:
        this.丕万丐东与一丈万与 = val_7;
    }
    private void 丙丑丘业丕丗丗不丘()
    {
        object val_10;
        InGameGUI val_11;
        UnityEngine.GameObject val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_10 = this;
        val_11 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_11 != null)
        {
                val_11 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
            val_11 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
            if(null != 0)
        {
                bool val_2 = typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_28.丏丏专丗丐丒一丆丌();
            val_11 = 0;
        }
        
        }
        
        if(((-833981940) & 1) == 0)
        {
            goto label_5;
        }
        
        val_12 = this.InviteButton;
        if(GetValueOrDefault() == false)
        {
            goto label_6;
        }
        
        val_13 = 0;
        val_14 = 1;
        if(val_12 != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_5:
        val_12 = this.InviteButton;
        label_6:
        val_14 = 0;
        if(val_12 != null)
        {
            goto label_9;
        }
        
        label_8:
        label_9:
        val_12.SetActive(value:  (this.丕万丐东与一丈万与 == 0) ? 1 : 0);
        if((val_14 & 1) == 0)
        {
            goto label_10;
        }
        
        val_15 = 0;
        if(this.LeaveButton != null)
        {
            goto label_13;
        }
        
        goto label_12;
        label_10:
        if(this.LeaveButton != null)
        {
            goto label_13;
        }
        
        label_12:
        label_13:
        this.LeaveButton.SetActive(value:  (this.丕万丐东与一丈万与 == 1) ? 1 : 0);
        if((val_14 & 1) == 0)
        {
            goto label_14;
        }
        
        val_16 = 0;
        if(this.InfoButton != null)
        {
            goto label_19;
        }
        
        goto label_16;
        label_14:
        val_16 = 1;
        if(this.InfoButton != null)
        {
            goto label_19;
        }
        
        label_16:
        label_19:
        this.InfoButton.SetActive(value:  (this.丕万丐东与一丈万与 == 5) ? 1 : 0);
        if((val_14 & 1) == 0)
        {
            goto label_20;
        }
        
        val_17 = 0;
        if(this.reloadButton != null)
        {
            goto label_23;
        }
        
        goto label_22;
        label_20:
        if(this.reloadButton != null)
        {
            goto label_23;
        }
        
        label_22:
        label_23:
        this.reloadButton.SetActive(value:  (this.丕万丐东与一丈万与 == 3) ? 1 : 0);
        if((val_14 & 1) != 0)
        {
                return;
        }
        
        if(this.丕万丐东与一丈万与 != 1)
        {
                return;
        }
        
        if(this.leaveTimerLabel == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_9 = this.leaveTimerLabel.gameObject;
        if(this.与丁一丄丑不丑丁丆 < 0f)
        {
                val_9.SetActive(value:  false);
            return;
        }
        
        val_9.SetActive(value:  true);
        val_10 = (int)this.与丁一丄丑不丑丁丆;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.leaveTimerLabel, 丕丗丘丑丛与丑业丒:  (int)this.与丁一丄丑不丑丁丆);
    }
    private void 丝丂与丒丟丕丙不丅()
    {
        this.丂下丄下丈下七专上 = 10f;
    }
    private void 丑世丌丕丙丄丗丅业(System.Nullable<bool> 丙业与丙丗丝不丈东)
    {
        if(((((-833692388) & 1) != 0) && (((-833692388) & 1) != 0)) && (this.七丌丙三东丌丏下丛 != null))
        {
                this.七丌丙三东丌丏下丛.不三丟丟专丗万业下();
        }
        
        this.丂下丄下丈下七专上 = 10f;
    }
    private void 业丘与三丑业丗世与(System.Nullable<bool> 丙业与丙丗丝不丈东)
    {
        if(((((-833564004) & 1) != 0) && (((-833564004) & 1) != 0)) && (this.丂且丐丛丘丒丅丛丒 != 0))
        {
                this.丂且丐丛丘丒丅丛丒.丟三丏丅世一丟丟上.丟上丌丑丝与三丂丂();
            if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_28.丏且丑丁丟七丝丆且();
        }
        
        }
        
        this.丂下丄下丈下七专上 = 10f;
    }
    internal void 丁业丕丗丅丌丏业三()
    {
        Player_move_c val_4;
        int val_5;
        val_4 = this.一上七丞丑丛丆与丛;
        val_5 = System.String.alignConst;
        if(val_4 == 0)
        {
            goto label_3;
        }
        
        if(this.一上七丞丑丛丆与丛 != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        if(this.一上七丞丑丛丆与丛.mySkinName == null)
        {
            goto label_5;
        }
        
        val_5 = this.一上七丞丑丛丆与丛.mySkinName.不与丏上丐七丄专且;
        goto label_9;
        label_3:
        val_4 = this.丂且丐丛丘丒丅丛丒;
        if(val_4 == 0)
        {
            goto label_9;
        }
        
        if(this.丂且丐丛丘丒丅丛丒 != null)
        {
            goto label_10;
        }
        
        goto label_11;
        label_9:
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_5)) == false)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_28.丟万丟丌一丁专丏丏(丒丘丏上丙丟丑丕丈:  val_5);
        return;
        label_5:
    }
    public void onClick()
    {
        object val_16 = this;
        if(this.丕万丐东与一丈万与 > 5)
        {
                return;
        }
        
        var val_16 = 106014256 + (this.丕万丐东与一丈万与) << 2;
        val_16 = val_16 + 106014256;
        goto (106014256 + (this.丕万丐东与一丈万与) << 2 + 106014256);
    }
    public SquadButton()
    {
        this.万业七丆丛丗丞三丝 = 0;
        mem[1152921538133498524] = 0;
        mem[1152921538133498532] = 0;
        this.丕万丐东与一丈万与 = 6;
        this.丕丝丆丕丁且七丌丆 = 0;
        mem[1152921538133498540] = 0;
        mem[1152921538133498548] = 0;
        this.与丁一丄丑不丑丁丆 = -1f;
    }

}
