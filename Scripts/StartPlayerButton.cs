using UnityEngine;
public class StartPlayerButton : MonoBehaviour
{
    // Fields
    public StartPlayerButton.下万丕且丏一与丂上 command;
    public BlueRedButtonController buttonController;
    private float 丁东丞一丘丒上且丟;
    private UIButton 不且丛丑且丟丏丆东;
    
    // Properties
    private UIButton 丆万三丄丕下丗丐丞 { get; }
    
    // Methods
    private void Awake()
    {
        var val_28;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_29;
        if((GameConnect.丑丌丛丈丅丅与不业() != 2) && (GameConnect.丑丌丛丈丅丅与不业() != 4))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 19)
        {
            goto label_12;
        }
        
        }
        
        }
        
        label_64:
        bool val_5 = NetworkStartTable.与一专丒东丏丘专丕();
        if(1 == 0)
        {
            goto label_15;
        }
        
        if(this.command == 0)
        {
            goto label_73;
        }
        
        if((this.command & 4294967294) != 2)
        {
            goto label_17;
        }
        
        if(this.command == 4)
        {
            goto label_73;
        }
        
        if(val_5 ^ 1 == false)
        {
            goto label_22;
        }
        
        goto label_73;
        label_15:
        if(this.command != 0)
        {
            goto label_73;
        }
        
        goto label_22;
        label_17:
        var val_9 = (this.command == 4) ? 1 : 0;
        val_9 = val_5 & val_9;
        if((val_9 == true) || ((val_5 | ((this.command != 1) ? 1 : 0)) == false))
        {
            goto label_73;
        }
        
        label_22:
        if((((((((((GameConnect.不专专丂万丝上东丐() != true) && (GameConnect.与丂丝丟丟三丑丝万() != true)) && (GameConnect.万不丒丌丙万丗东不() != true)) && (GameConnect.东丒七专丂世丝丏丗() != true)) && (GameConnect.丙丌丒丈东七丒上丌() != true)) && (PGCompany.丁东丌世与丕东丆上.且丏下丂专丞不丂丞() != false)) && (GameConnect.东丒七专丂世丝丏丗() != true)) && (GameConnect.丒丗丁丙丗丄丙不丐() != true)) && (GameConnect.丄丏丒丏上东业丒一() != true)) && (GameConnect.丙丌丒丈东七丒上丌() != true))
        {
                if(GameConnect.一业上七丟业且业丙() != true)
        {
                if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_60;
        }
        
        }
        
        }
        
        label_73:
        this.gameObject.SetActive(value:  false);
        return;
        label_12:
        var val_25 = (GameConnect.丑丌丛丈丅丅与不业() == 33) ? 1 : 0;
        goto label_64;
        label_60:
        val_28 = null;
        val_28 = null;
        val_29 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_29 == null)
        {
                return;
        }
        
        val_29 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_29 == null)
        {
                val_29 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_26 = val_29.丌不丅不丞东万专专();
        if(val_26.HasValue.丙东专丂世丈丏丁丂() != 4)
        {
                return;
        }
        
        if((1473853160 & 1) == 0)
        {
                return;
        }
        
        下万丕且丏一与丂上 val_28 = this.command;
        val_28 = val_28 - 1;
        if(val_28 >= 2)
        {
            goto label_73;
        }
    
    }
    private void Start()
    {
        var val_3;
        下万丕且丏一与丂上 val_3 = this.command;
        val_3 = val_3 | 4;
        if(val_3 != 4)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.与丈丝丌东丄丏丞丙 == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        this.丌丛丙专丑丄丕一与().enabled = false;
    }
    private void OnEnable()
    {
        this.丁东丞一丘丒上且丟 = UnityEngine.Time.realtimeSinceStartup;
    }
    private void Update()
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        OnlineModeController val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        ClickerDetector val_38;
        val_23 = null;
        val_23 = null;
        if((((丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count == 0) || (GameConnect.东且三丆丑世世丘丟() == true)) || (GameConnect.万不丒丌丙万丗东不() == true)) || (GameConnect.不专专丂万丝上东丐() == true))
        {
            goto label_18;
        }
        
        val_24 = 0;
        if((TimeGameController.丄丞丁丈与业上丞丟 == 0) || (TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 <= 0f))
        {
            goto label_18;
        }
        
        var val_6 = (TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 > 16) ? 1 : 0;
        goto label_20;
        label_18:
        val_25 = 1;
        label_20:
        val_26 = null;
        val_26 = null;
        if(GameController.onlineMode.丅丅丌丞七东丂上丙 != false)
        {
                val_27 = null;
            val_27 = null;
            int val_22 = BalanceController.业丌丁丞丆丆万业丘;
            val_22 = val_22 + 2;
            var val_9 = (ExperienceController.丞丞丘业东丙丏七丌() > val_22) ? 1 : 0;
        }
        else
        {
                val_28 = 0;
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = GameConnect.丘丐丅丌上与丒丞万() ^ 1;
        val_31 = GameController.onlineMode;
        if(GameConnect.丘丐丅丌上与丒丞万() != false)
        {
                val_32 = null;
            val_32 = null;
            val_31 = 1152921505190604800;
            if(GameController.mode != null)
        {
                val_33 = null;
        }
        
            val_33 = null;
            var val_13 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + (LegacyModeController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_33) ? GameController.mode : 0;
            val_24 = 0;
            val_30 = UnityEngine.Object.op_Inequality(x:  (GameModeController.__il2cppRuntimeField_typeHierarchy + (LegacyModeController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_33 ? GameController.mode : 0 + 528, y:  0);
        }
        
        bool val_16 = val_25 & GameController.onlineMode.专丝上丟丆丝丙丄丈();
        val_16 = val_16 & val_30;
        val_34 = this.丌丛丙专丑丄丕一与();
        if(val_16 == false)
        {
            goto label_44;
        }
        
        bool val_19 = ((val_28 != 0) ? 1 : 0) | (~下丟世丏三东万丘丏.下不丙丌丙丞丞万上());
        val_19 = val_31.丆丏丟专业丏且三一() | val_19;
        if(val_19 == false)
        {
            goto label_47;
        }
        
        label_44:
        if(val_34 != null)
        {
            goto label_65;
        }
        
        label_66:
        label_65:
        val_34 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
        label_47:
        val_35 = null;
        val_35 = null;
        if(ClickerDetector.丄丘七三上丕世丞业 == 0)
        {
            goto label_57;
        }
        
        val_36 = null;
        val_36 = null;
        if(null == 0)
        {
            goto label_57;
        }
        
        val_37 = null;
        val_37 = null;
        val_38 = ClickerDetector.丄丘七三上丕世丞业;
        if(ClickerDetector.丄丘七三上丕世丞业 != null)
        {
            goto label_60;
        }
        
        val_38 = ClickerDetector.丄丘七三上丕世丞业;
        if(val_38 == null)
        {
            goto label_61;
        }
        
        label_60:
        var val_21 = (ClickerDetector.丄丘七三上丕世丞业.丈丐世下丞与丂专丏 < 0) ? 1 : 0;
        if(val_34 != 0)
        {
            goto label_65;
        }
        
        goto label_66;
        label_57:
        if(val_34 != 0)
        {
            goto label_65;
        }
        
        goto label_66;
        label_61:
    }
    private void OnClick()
    {
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        下万丕且丏一与丂上 val_30;
        BlueRedButtonController val_31;
        BlueRedButtonController val_32;
        BlueRedButtonController val_33;
        var val_34;
        val_24 = null;
        val_24 = null;
        if(GameController.onlineMode.专丝上丟丆丝丙丄丈() == false)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        float val_24 = NotificationController.专东丒丗下丞专丘丛;
        val_24 = UnityEngine.Time.time - val_24;
        if(val_24 < 0)
        {
                return;
        }
        
        if(GameConnect.丞丂丑一丕丑丙三丐() != false)
        {
                float val_4 = UnityEngine.Time.realtimeSinceStartup;
            val_4 = val_4 - this.丁东丞一丘丒上且丟;
            if(val_4 < 0)
        {
                return;
        }
        
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        val_26 = null;
        val_26 = null;
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
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_27 = null;
        val_27 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 == true)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_28 = null;
        val_28 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable == 0)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = 丘丑丅三丆丑丌且丝();
        if(val_30 > 0)
        {
            goto label_63;
        }
        
        val_30 = this.command;
        if((val_30 - 3) > 1)
        {
            goto label_63;
        }
        
        val_31 = this.buttonController;
        val_31 = val_31;
        if(val_31 == 0)
        {
            goto label_63;
        }
        
        val_32 = this.buttonController;
        if(this.buttonController != null)
        {
            goto label_56;
        }
        
        val_32 = this.buttonController;
        if(val_32 == null)
        {
            goto label_61;
        }
        
        label_56:
        if(this.buttonController.countRed >= this.buttonController.countBlue)
        {
            goto label_58;
        }
        
        val_30 = 2;
        goto label_63;
        label_58:
        val_33 = this.buttonController;
        if(this.buttonController != null)
        {
            goto label_60;
        }
        
        val_33 = this.buttonController;
        if(val_33 == null)
        {
            goto label_61;
        }
        
        label_60:
        if(this.buttonController.countRed > this.buttonController.countBlue)
        {
                val_30 = 1;
        }
        else
        {
                val_30 = UnityEngine.Random.Range(min:  1, max:  3);
        }
        
        label_63:
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                Rilisoft.一丟专且三万丞丁丂.丝丕业与丗三丕七丒(丛丝丗万丐业丒丂丞:  GameConnect.丑丌丛丈丅丅与不业());
        }
        
        if(GameConnect.不专专丂万丝上东丐() != true)
        {
                if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                Rilisoft.一丟专且三万丞丁丂.丁不丒且丈东丞业丑(丂丛丑东不丅丈一东:  "Multiplayer");
        }
        
        }
        
        val_34 = null;
        val_34 = null;
        GetComponent<NetworkStartTable>().不丅丗丂与丌与丐丒(与丁丟东丞丙丗丌丈:  val_30);
        GameModeController.专丁东七丑丕一不丁();
        return;
        label_61:
    }
    private UIButton 丌丛丙专丑丄丕一与()
    {
        UIButton val_3;
        if(this.不且丛丑且丟丏丆东 == 0)
        {
                this.不且丛丑且丟丏丆东 = this.GetComponent<UIButton>();
            return val_3;
        }
        
        val_3 = this.不且丛丑且丟丏丆东;
        return val_3;
    }
    public StartPlayerButton()
    {
    
    }

}
