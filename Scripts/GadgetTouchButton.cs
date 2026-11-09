using UnityEngine;
public class GadgetTouchButton : TouchButton
{
    // Fields
    public UITexture duration;
    public UITexture cooldown;
    public UnityEngine.GameObject cooldownEnds;
    private UIBasicSprite gadgetIcon;
    private 丕丈丏丝丗下丟丅丂 丁丏专且丙下丒丕不;
    private bool 丅丒下丝三丁丛丄业;
    private bool 且专上丛丌丈专丕丅;
    private bool 丟丈上上万丕丛丕万;
    private GadgetCategory 七丆丒与丗丌丄且丂;
    private bool 业丟业三丟丕业丁万;
    public UnityEngine.GameObject daterIcon;
    public UnityEngine.GameObject daterCounter;
    public UnityEngine.GameObject daterPrice;
    public UILabel daterCounterLabel;
    public UnityEngine.GameObject cantUseGadgetObj;
    private static GadgetTouchButton 业丘上三七七丞且七;
    private int 丗丐专一与丘丆丆东;
    public bool canShowSniperHint;
    private bool 丏丕丌丙不且专三不;
    
    // Properties
    private bool 丂七东业不上丒丌丑 { get; set; }
    public UIBasicSprite 丟丙丑丞一丈三丁丞 { get; }
    
    // Methods
    private bool 与丟丟万下丙丏不丄()
    {
        Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        if(val_1 != null)
        {
                return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  23);
        }
        
        return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  23);
    }
    private void 且丐一丅业三丛丞丛(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  23);
            return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄上丅丝不丆世万三(业丄七丙丛上专专丕:  23);
    }
    public UIBasicSprite get_GadgetIcon()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.gadgetIcon);
        this.gadgetIcon = val_1;
        return val_1;
    }
    public override bool IsActive()
    {
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        GadgetCategory val_33;
        var val_34;
        var val_35;
        var val_36;
        bool val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_47;
        var val_48;
        var val_49;
        if(this.业丟业三丟丕业丁万 == false)
        {
            goto label_1;
        }
        
        val_29 = null;
        bool val_1 = GadgetTouchButton.丕上丅不丌丂丕万丌();
        label_92:
        val_30 = (val_1 | val_1.专丝丘丒一丘与丏丞()) & ((this.丅丒下丝三丁丛丄业 == true) ? 1 : 0);
        return (bool)val_30;
        label_1:
        val_31 = 1152921505066536960;
        不丘丄丝丗丒丙一丌 val_7 = 0;
        val_32 = null;
        if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                val_33 = this.七丆丒与丗丌丄且丂;
            bool val_8 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  val_33, value: out  val_7);
        }
        
        val_34 = null;
        val_34 = null;
        val_35 = null;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_36 = null;
            val_36 = null;
            val_37 = 1;
        }
        
        if(val_7 != 0)
        {
                val_38 = 0;
        }
        else
        {
                val_38 = 0;
        }
        
        val_39 = null;
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                val_40 = InGameGUI.丙丞专丌丁丞与不丐.isWorldMapOpened;
        }
        else
        {
                val_40 = 0;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_41 = 丅与丌专丟一丝业三().activeInHierarchy;
        }
        else
        {
                val_41 = 0;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 != 0)
        {
                val_42 = WindowEnabled;
        }
        else
        {
                val_42 = 0;
        }
        
        val_43 = null;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_44 = null;
            val_44 = null;
            val_45 = 1;
        }
        else
        {
                val_45 = 0;
        }
        
        val_47 = null;
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                val_48 = null;
            val_48 = null;
            val_31 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_31 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_49 = 0;
        }
        else
        {
                val_49 = 1;
        }
        
        if((this.丅丒下丝三丁丛丄业 == false) || (WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0))
        {
            goto label_90;
        }
        
        bool val_26 = ;
        var val_23 = val_42 | val_41;
        val_23 = val_23 | ;
        val_26 = val_38 | val_26;
        val_26 = val_26 | val_40;
        var val_24 = (val_26 == false) ? 1 : 0;
        val_24 = val_24 & 万丐业丏且丑上业丛();
        val_24 =  & val_24;
        var val_25 = (val_23 == 0) ? 1 : 0;
        goto label_92;
        label_90:
        val_30 = 0;
        return (bool)val_30;
    }
    private void OnEnable()
    {
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void GadgetTouchButton::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void OnDisable()
    {
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void GadgetTouchButton::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    public override bool CanPress()
    {
        var val_23;
        GadgetCategory val_24;
        var val_25;
        Player_move_c val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        不丘丄丝丗丒丙一丌 val_3 = 0;
        val_23 = null;
        if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                val_24 = this.七丆丒与丗丌丄且丂;
            bool val_4 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  val_24, value: out  val_3);
        }
        
        val_25 = null;
        val_25 = null;
        val_26 = 1152921505217175552;
        val_27 = null;
        val_27 = null;
        val_28 = 0;
        if((东丟丟万下丛丆丛丟.丆丐丕丗与丘丟一不 != false) && (val_3 != 0))
        {
                val_24 = 0;
            float val_5 = val_3.世丙丈丁丘七七丌丝();
        }
        
        val_29 = null;
        val_30 = 0;
        if((val_3 != 0) && (GameConnect.万不丒丌丙万丗东不() != false))
        {
                val_31 = null;
            val_31 = null;
            val_26 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_26 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            val_24 = val_3;
            val_30 = (~(丘丛丌丁丘丝世丑且(东一丁世丑丞业丄丐:  val_24))) & 1;
        }
        
        val_32 = 1;
        val_33 = null;
        val_34 = 0;
        if((val_3 != 0) && (GameConnect.丙丌丒丈东七丒上丌() != false))
        {
                val_24 = mem[282584257677055];
            val_34 = 0;
        }
        
        if((this & 1) == 0)
        {
            goto label_46;
        }
        
        val_26 = this.gameObject;
        if(((val_26.activeInHierarchy == false) || (WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)) || (万丐丘与丙丂丕下丒() == false))
        {
            goto label_46;
        }
        
        val_35 = null;
        val_35 = null;
        if(GadgetTouchButton.业丘上三七七丞且七 == 0)
        {
            goto label_41;
        }
        
        val_36 = null;
        val_36 = null;
        val_26 = GadgetTouchButton.业丘上三七七丞且七;
        if(val_26 != this)
        {
            goto label_46;
        }
        
        label_41:
        val_26 = 1152921504848912384;
        if((((WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0) || (val_3 == 0)) || (val_5 <= 0f)) || (丗丑丞丙一丟丂丗三() == false))
        {
            goto label_52;
        }
        
        label_46:
        var val_23 = 0;
        label_72:
        val_23 = val_23 & 1;
        return (bool)val_23;
        label_52:
        var val_19 = val_30 | ((val_5 > 0f) ? 1 : 0);
        if(this.丁丏专且丙下丒丕不.丙丅专丒丈丐丂与丝() == true)
        {
            goto label_72;
        }
        
        val_37 = null;
        val_37 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_72;
        }
        
        val_38 = null;
        val_38 = null;
        bool val_22 = GameConnect.且丘丄丛下丆丟万丕();
        goto label_72;
    }
    public void SetupDaterButton()
    {
        this.丅丒下丝三丁丛丄业 = true;
        this.业丟业三丟丕业丁万 = true;
        this.gadgetIcon.gameObject.SetActive(value:  false);
        this.daterIcon.SetActive(value:  true);
    }
    internal void 丐不世丘丁丘下七一(UnityEngine.Texture 丅东丕丄与一丛丂世, 丕丈丏丝丗下丟丅丂 东一丁世丑丞业丄丐, GadgetCategory 七丆丒与丗丌丄且丂)
    {
        var val_10;
        var val_11 = null;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_10 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅();
            if((val_10.ContainsKey(key:  东一丁世丑丞业丄丐.丒万丕七专不丏丞丌())) != false)
        {
                val_10 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[东一丁世丑丞业丄丐.丒万丕七专不丏丞丌()];
            this.且专上丛丌丈专丕丅 = val_10 & 1;
        }
        
        }
        
        this.七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
        UIBasicSprite val_9 = this.GadgetIcon;
        this.丁丏专且丙下丒丕不 = 东一丁世丑丞业丄丐;
        this.丅丒下丝三丁丛丄业 = true;
    }
    public void DeactivateGadgetButton()
    {
        this.丁丏专且丙下丒丕不 = 0;
        this.丅丒下丝三丁丛丄业 = false;
    }
    public void InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        bool val_9;
        var val_10;
        var val_11;
        val_9 = 丙业与丙丗丝不丈东;
        val_10 = this;
        val_11 = null;
        if(val_9 == null)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_9);
        if(七丐丅专且专七三丆 != 4)
        {
                return;
        }
        
        if(null == 2)
        {
                if(this.isActiveAndEnabled == false)
        {
                return;
        }
        
            this.丏丕丌丙不且专三不 = true;
        }
        else
        {
                if(null == null)
        {
                return;
        }
        
            if(this.丏丕丌丙不且专三不 == false)
        {
                return;
        }
        
            this.丏丕丌丙不且专三不 = false;
        }
        
        val_10 = ???;
        val_9 = ???;
        goto typeof(GadgetTouchButton).__il2cppRuntimeField_1D8;
    }
    public void EnableSniperHint()
    {
        bool val_2 = ~this.与丟丟万下丙丏不丄();
        val_2 = val_2 & 1;
        this.canShowSniperHint = val_2;
        this.丝上七丕丑丘丘丙丆();
    }
    private void 丝上七丕丑丘丘丙丆()
    {
        if(this.且专上丛丌丈专丕丅 != false)
        {
                int val_2 = this.丗丐专一与丘丆丆东;
            if((val_2 <= 1) && (this.canShowSniperHint != false))
        {
                val_2 = val_2 + 1;
            this.丗丐专一与丘丆丆东 = val_2;
            HintController.与一丅丝不丈业与丙().丄一丟丕丌业丆上丌(丒丘丏上丙丟丑丕丈:  "use_teleport", 丂三丟丂丈丐丆丗丟:  0f);
        }
        
        }
        
        this.canShowSniperHint = false;
    }
    public override void ButtonUpdate()
    {
        UITexture val_41;
        var val_42;
        下七一丌丝丂丙七丑 val_43;
        下七一丌丝丂丙七丑 val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        val_41 = this;
        if(137105408 == 0)
        {
            goto label_3;
        }
        
        if(((val_41 & 1) != 0) || (this.丁丏专且丙下丒丕不 == null))
        {
            goto label_6;
        }
        
        val_42 = 0;
        if(this.丁丏专且丙下丒丕不.丙丅专丒丈丐丂与丝() == false)
        {
            goto label_6;
        }
        
        val_43 = 4;
        goto label_8;
        label_6:
        if((val_41 & 1) == 0)
        {
                if(this.业丟业三丟丕业丁万 == false)
        {
            goto label_10;
        }
        
        }
        
        if(this.isPressed == false)
        {
            goto label_11;
        }
        
        val_44 = 1;
        if(!=0)
        {
            goto label_90;
        }
        
        label_91:
        label_90:
        val_43 = val_44;
        label_8:
        state = val_43;
        label_3:
        if(this.业丟业三丟丕业丁万 == false)
        {
            goto label_13;
        }
        
        val_44 = 1152921505066483712;
        val_45 = null;
        bool val_4 = GadgetTouchButton.丕上丅不丌丂丕万丌();
        bool val_5 = val_4.专丝丘丒一丘与丏丞();
        if(val_4 == false)
        {
            goto label_16;
        }
        
        val_46 = null;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.daterPrice, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.daterCounter, 丏业丟一东丂东丘丛:  false);
        return;
        label_13:
        if(this.丁丏专且丙下丒丕不 == null)
        {
                return;
        }
        
        val_44 = this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌();
        if((东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().ContainsKey(key:  val_44)) == false)
        {
                return;
        }
        
        不丘丄丝丗丒丙一丌 val_12 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()];
        if(((val_12 & 1) != 0) && (this.且专上丛丌丈专丕丅 != true))
        {
                this.且专上丛丌丈专丕丅 = true;
            val_47 = null;
            if(GameConnect.丙丌丒丈东七丒上丌() != true)
        {
                this.cooldownEnds.SetActive(value:  true);
            this.cooldownEnds.GetComponent<TweenScale>().PlayForward();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.cooldownEnds.GetComponent<UIPlaySound>().Play();
        }
        
        }
        
            val_48 = null;
            if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                this.丝上七丕丑丘丘丙丆();
        }
        
        }
        
        this.且专上丛丌丈专丕丅 = val_12 & 1;
        val_49 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()].且丑丂丐不七丌丌丂();
        val_50 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()].世丙丈丁丘七七丌丝();
        val_51 = null;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                不丘丄丝丗丒丙一丌 val_30 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()];
            float val_31 = (val_30 == this.丁丏专且丙下丒丕不) ? (val_50) : 1f;
            float val_32 = (val_30 == this.丁丏专且丙下丒丕不) ? (val_49) : 0f;
        }
        
        this.duration.gameObject.SetActive(value:  (val_32 > 0f) ? 1 : 0);
        val_44 = 0;
        if((val_31 > 0f) && (val_32 <= 0f))
        {
                val_52 = null;
            val_52 = null;
            bool val_40 = 东丟丟万下丛丆丛丟.丆丐丕丗与丘丟一不;
            val_40 = val_40 ^ 1;
            val_44 = val_40 & 255;
        }
        
        this.cooldown.gameObject.SetActive(value:  (val_44 == true) ? 1 : 0);
        this.duration.fillAmount = val_32;
        val_41 = this.cooldown;
        val_41.fillAmount = val_31;
        return;
        label_16:
        val_53 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.daterPrice, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.daterCounter, 丏业丟一东丂东丘丛:  true);
        val_41 = this.daterCounterLabel;
        val_41.text = GadgetTouchButton.丈专丕三丑且丈丅上().ToString();
        return;
        label_11:
        if(this.业丟业三丟丕业丁万 == false)
        {
            goto label_82;
        }
        
        if(!=0)
        {
            goto label_90;
        }
        
        goto label_91;
        label_10:
        if(!=0)
        {
            goto label_90;
        }
        
        goto label_91;
        label_82:
        if(this.业丟业三丟丕业丁万 == false)
        {
            goto label_87;
        }
        
        if(!=0)
        {
            goto label_90;
        }
        
        goto label_91;
        label_87:
        var val_39 = (val_41 != 1) ? 2 : 0;
        if(!=0)
        {
            goto label_90;
        }
        
        goto label_91;
    }
    public override bool OnPress(bool 丆且上丘世下丅且丞, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_2;
        if(丆且上丘世下丅且丞 == false)
        {
            goto label_0;
        }
        
        if((this & 1) == 0)
        {
                if(this.业丟业三丟丕业丁万 == false)
        {
            goto label_4;
        }
        
        }
        
        if(((1152921526126979704 & 1) != 0) && (this.业丟业三丟丕业丁万 != false))
        {
                mem[1152921526126979721] = 1;
        }
        
        label_4:
        var val_1 = (null != 0) ? 1 : 0;
        return (bool)val_2;
        label_0:
        val_2 = 0;
        mem[1152921526126979721] = 0;
        return (bool)val_2;
    }
    public bool Press(bool 丆且上丘世下丅且丞)
    {
        var val_2;
        if(丆且上丘世下丅且丞 == false)
        {
            goto label_0;
        }
        
        if((this & 1) == 0)
        {
                if(this.业丟业三丟丕业丁万 == false)
        {
            goto label_3;
        }
        
        }
        
        if(this.业丟业三丟丕业丁万 != false)
        {
                mem[1152921526127091721] = 1;
        }
        
        label_3:
        var val_1 = (null != 0) ? 1 : 0;
        return (bool)val_2;
        label_0:
        val_2 = 0;
        mem[1152921526127091721] = 0;
        return (bool)val_2;
    }
    public override void Reset()
    {
        var val_2;
        var val_3;
        this.Reset();
        val_2 = null;
        val_2 = null;
        if(GadgetTouchButton.业丘上三七七丞且七 != this)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        GadgetTouchButton.业丘上三七七丞且七 = 0;
    }
    public void RestartCooldownGadget()
    {
        if(this.丁丏专且丙下丒丕不 == null)
        {
                return;
        }
        
        if((东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().ContainsKey(key:  this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌())) == false)
        {
                return;
        }
        
        this = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()];
        if(this == null)
        {
                return;
        }
        
        if(this.丄不与丁丗东专且丈() == false)
        {
                return;
        }
        
        this.丌上丛丆三东下丅丙();
    }
    public override void OnPressed(bool 丁丐不且七丂业丗丆)
    {
        UnityEngine.Object val_10;
        var val_11;
        var val_12;
        var val_13;
        上丅丁不丒一丌丙东 val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_10 = this;
        丁丐不且七丂业丗丆 = 丁丐不且七丂业丗丆;
        this.OnPressed(丁丐不且七丂业丗丆:  丁丐不且七丂业丗丆);
        val_11 = null;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_3;
        }
        
        val_12 = null;
        val_13 = GadgetTouchButton.丕上丅不丌丂丕万丌();
        if(丁丐不且七丂业丗丆 == true)
        {
            goto label_6;
        }
        
        label_22:
        val_14 = 1152921505066483712;
        val_15 = null;
        val_15 = null;
        if(GadgetTouchButton.业丘上三七七丞且七 == this)
        {
                val_16 = null;
            val_16 = null;
            GadgetTouchButton.业丘上三七七丞且七 = 0;
        }
        
        if(val_13 == false)
        {
            goto label_14;
        }
        
        val_10 = 1152921526127509624;
        UnityEngine.Vector2 val_4 = UICamera.lastEventPosition;
        if((val_10 & 1) == 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        HandleBuyGrenadeClicked(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  System.EventArgs.Empty);
        return;
        label_3:
        val_13 = 0;
        if(丁丐不且七丂业丗丆 == false)
        {
            goto label_22;
        }
        
        label_6:
        val_18 = null;
        val_18 = null;
        if((ClickerDetector.丄丘七三上丕世丞业 != 0) && (this.丁丏专且丙下丒丕不 != null))
        {
                val_14 = ClickerDetector.丗丁万丈丅丕丄丙丂(七丆丒与丗丌丄且丂:  this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌());
            ClickerDetector.丄丘七三上丕世丞业.不世上丐丑世下丁业(丟丒丞丐丐丘丒丄东:  val_14);
        }
        
        if(val_13 != 0)
        {
                return;
        }
        
        val_14 = 1152921505066483712;
        val_19 = null;
        val_19 = null;
        if(GadgetTouchButton.业丘上三七七丞且七 != 0)
        {
                return;
        }
        
        this.丌丅丘丟丛一七丑上();
        val_20 = null;
        val_20 = null;
        GadgetTouchButton.业丘上三七七丞且七 = val_10;
        return;
        label_14:
        this.丏丛七丗丌上丗三丂();
    }
    private void 丌丅丘丟丛一七丑上()
    {
        string val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_12 = this;
        val_13 = null;
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                HintController val_2 = HintController.与一丅丝不丈业与丙();
            val_2.三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "use_teleport");
            val_2.且丐一丅业三丛丞丛(丙业与丙丗丝不丈东:  true);
            this.canShowSniperHint = false;
        }
        
        val_14 = null;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_15 = null;
            val_15 = null;
            val_16 = null;
            val_16 = null;
            if((((与丂丏丛丞丞丒丟丄.三丆下丆七丁丛丐东 == true) ? 1 : 0) & 1) == 0)
        {
                return;
        }
        
            this.丟丈上上万丕丛丕万 = true;
            if(this.丁丏专且丙下丒丕不 == null)
        {
                return;
        }
        
            val_12 = this.丁丏专且丙下丒丕不.业东丅东丌上丗丑不().ToString();
            Rilisoft.丞丛七上丕专丏丌丈.七丄丐下与丟丝丛丑(丗丑丐丕丟丝且下丕:  val_12);
            return;
        }
        
        丁下万丟且丟丛下业.丛丁七业东上世丅丛(丙业与丙丗丝不丈东:  this.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌());
        bool val_10 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  this.七丆丒与丗丌丄且丂, value: out  typeof(Player_move_c).__il2cppRuntimeField_D58);
        val_17 = null;
        val_17 = null;
        if(万丐丘与丙丂丕下丒() == false)
        {
                return;
        }
    
    }
    private void 丏丛七丗丌上丗三丂()
    {
        GadgetCategory val_5;
        var val_6;
        var val_7;
        val_5 = this;
        if(this.丟丈上上万丕丛丕万 == false)
        {
                return;
        }
        
        this.丟丈上上万丕丛丕万 = false;
        val_6 = null;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_7 = null;
            val_7 = null;
            return;
        }
        
        不丘丄丝丗丒丙一丌 val_3 = 0;
        val_5 = this.七丆丒与丗丌丄且丂;
        if((东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  val_5, value: out  val_3)) == false)
        {
                return;
        }
        
        val_5 = val_3;
        if((val_5 & 1) == 0)
        {
                return;
        }
        
        if(val_3 != 0)
        {
                return;
        }
    
    }
    internal static bool 丕上丅不丌丂丕万丌()
    {
        WeaponManager val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false)
        {
                return false;
        }
        
        val_8 = null;
        if(GadgetTouchButton.与丝世丗丘三且丝三() == false)
        {
                return false;
        }
        
        val_9 = null;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return false;
        }
        
        val_10 = null;
        val_10 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_7 == 0)
        {
                return false;
        }
        
        val_11 = null;
        val_11 = null;
        val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_7 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_7 != 0)
        {
                val_7 = 1152921505316536320;
            val_12 = null;
            val_12 = null;
            if((下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  下专世丏丈丞三丗不.下丏一丕丁丄丏丛丕)) < 1)
        {
                return false;
        }
        
        }
        
        return false;
    }
    private static bool 与丝世丗丘三且丝三()
    {
        Player_move_c val_4;
        var val_5;
        var val_6;
        if(InGameGUI.丙丞专丌丁丞与不丐.playerMoveC == 0)
        {
            goto label_7;
        }
        
        val_4 = 1152921505171275776;
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 == false)
        {
            goto label_10;
        }
        
        label_7:
        val_4 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 552];
        val_4 = InGameGUI.丙丞专丌丁丞与不丐.playerMoveC;
        if(val_4 != 0)
        {
            goto label_14;
        }
        
        val_5 = null;
        label_10:
        val_5 = null;
        var val_3 = (与丂丏丛丞丞丒丟丄.丄丁丑丞丅一三丌丆 == false) ? 1 : 0;
        return (bool)val_6;
        label_14:
        val_6 = 0;
        return (bool)val_6;
    }
    private bool 专丝丘丒一丘与丏丞()
    {
        WeaponManager val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_6 = 1152921505066483712;
        val_7 = null;
        if(GadgetTouchButton.与丝世丗丘三且丝三() == false)
        {
                return false;
        }
        
        val_8 = null;
        val_8 = null;
        if(与丂丏丛丞丞丒丟丄.三丆下丆七丁丛丐东 == false)
        {
                return false;
        }
        
        if(Player_move_c.丗丒丕专丛丆丈万一() == false)
        {
                return false;
        }
        
        val_9 = null;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_10 = null;
            if(GadgetTouchButton.丈专丕三丑且丈丅上() < 1)
        {
                return false;
        }
        
        }
        
        val_6 = 1152921505286238208;
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 1)
        {
                return false;
        }
        
        val_12 = null;
        val_12 = null;
        val_6 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 2)
        {
                return false;
        }
        
        PGCompany.丗三万丁三丗上专丟 val_5 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if(val_5 != null)
        {
                return val_5.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
        }
        
        return val_5.丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
    }
    internal static int 丈专丕三丑且丈丅上()
    {
        var val_4;
        var val_5;
        var val_6;
        WeaponManager val_7;
        var val_8;
        var val_9;
        val_4 = null;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_5 = null;
            val_5 = null;
            return 下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  下专世丏丈丞三丗不.下丏一丕丁丄丏丛丕);
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_7 == 0)
        {
                return 0;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_7 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_7 == 0)
        {
                return 0;
        }
        
        val_9 = null;
        val_9 = null;
        if(null != 0)
        {
                return 丐丑专与与丗丗丟丂();
        }
        
        return 丐丑专与与丗丗丟丂();
    }
    public GadgetTouchButton()
    {
        this.且专上丛丌丈专丕丅 = true;
    }
    private static GadgetTouchButton()
    {
    
    }

}
