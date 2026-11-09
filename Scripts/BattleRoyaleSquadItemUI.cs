using UnityEngine;
public class BattleRoyaleSquadItemUI : MonoBehaviour
{
    // Fields
    public UISprite healthBar;
    public UISprite armorBar;
    public UILabel nickname;
    public UITexture skinTexture;
    public TweenColor faceBlinkTween;
    public UISprite faceColorBorder;
    public UISprite deadIndication;
    public UnityEngine.GameObject deadAnimation;
    
    // Methods
    internal void 丗上丘丁丁且丂七丅(万丅世丈丕丕丌丅丗 东一丁世丑丞业丄丐)
    {
        bool val_31;
        float val_32;
        bool val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        float val_39;
        float val_41;
        UnityEngine.Texture val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        var val_48;
        float val_49;
        if(东一丁世丑丞业丄丐 != null)
        {
                val_31 = 东一丁世丑丞业丄丐.万丝一万丐且丌业丛;
        }
        else
        {
                val_31 = 104;
        }
        
        if(东一丁世丑丞业丄丐.不且上一上丐三万丛 == 0)
        {
            goto label_5;
        }
        
        东一丁世丑丞业丄丐.丑丁不万丈丟万且业();
        val_32 = 0f;
        if(东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕 == 0)
        {
            goto label_9;
        }
        
        val_33 = 东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.东丑丌丄丝世丞丘三;
        val_34 = null;
        val_34 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_16;
        }
        
        val_35 = null;
        val_35 = null;
        val_36 = UnityEngine.Object.op_Equality(x:  typeof(Player_move_c).__il2cppRuntimeField_E28, y:  东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕);
        goto label_23;
        label_5:
        val_37 = 0;
        val_38 = 0;
        val_32 = 0f;
        val_39 = 0f;
        goto label_24;
        label_9:
        val_36 = 0;
        val_33 = 0;
        val_39 = 0f;
        goto label_37;
        label_16:
        val_36 = 0;
        label_23:
        if(val_33 == false)
        {
            goto label_26;
        }
        
        val_39 = 0f;
        if(东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕 == 0)
        {
            goto label_33;
        }
        
        val_39 = 东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.丐下丘丟丁丆丟丆丈() / 东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.丆丛不丄丂下且不丏();
        goto label_33;
        label_26:
        val_39 = 0f;
        if(东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕 != 0)
        {
                val_41 = (float)东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.丄丞丘不下七一丘丘;
            val_39 = 东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.丘七业丒丐世丂丅丒() / val_41;
        }
        
        label_33:
        if((东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕 != 0) && (东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.丅三业丆丄丝丝丕东 >= 1))
        {
                val_41 = (float)东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.丅三业丆丄丝丝丕东;
            val_32 = 东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.三丕丘下业丑丞下丘 / val_41;
        }
        
        label_37:
        bool val_11 = UnityEngine.Object.op_Inequality(x:  东一丁世丑丞业丄丐.不且上一上丐三万丛.万丛丏万丟丕丒丛与, y:  0);
        if(东一丁世丑丞业丄丐.不且上一上丐三万丛 == null)
        {
            goto label_41;
        }
        
        if(val_11 == false)
        {
            goto label_42;
        }
        
        label_45:
        val_42 = 东一丁世丑丞业丄丐.不且上一上丐三万丛.万丛丏万丟丕丒丛与;
        if(this.skinTexture != null)
        {
            goto label_46;
        }
        
        goto label_44;
        label_41:
        if(val_11 == true)
        {
            goto label_45;
        }
        
        label_42:
        val_42 = 东一丁世丑丞业丄丐.不且上一上丐三万丛.丌丏丞丆丗与东丗业;
        if(this.skinTexture != null)
        {
            goto label_46;
        }
        
        label_44:
        label_46:
        label_24:
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_43 = mem[(BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + (东一丁世丑丞业丄丐.丒东丑丟世与下且丟) << 4) + 32];
            val_43 = (BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + (东一丁世丑丞业丄丐.丒东丑丟世与下且丟) << 4) + 32;
            val_44 = mem[(BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + (东一丁世丑丞业丄丐.丒东丑丟世与下且丟) << 4) + 32 + 4];
            val_44 = (BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + (东一丁世丑丞业丄丐.丒东丑丟世与下且丟) << 4) + 32 + 4;
            val_45 = mem[(BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + (东一丁世丑丞业丄丐.丒东丑丟世与下且丟) << 4) + 40];
            val_45 = (BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + (东一丁世丑丞业丄丐.丒东丑丟世与下且丟) << 4) + 40;
            val_46 = mem[(BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + (东一丁世丑丞业丄丐.丒东丑丟世与下且丟) << 4) + 40 + 4];
            val_46 = (BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + (东一丁世丑丞业丄丐.丒东丑丟世与下且丟) << 4) + 40 + 4;
        }
        else
        {
                UnityEngine.Color val_16 = UnityEngine.Color.grey;
            val_43 = val_16.r;
            val_44 = val_16.g;
            val_45 = val_16.b;
            val_46 = val_16.a;
        }
        
        this.faceColorBorder.color = new UnityEngine.Color() {r = val_43, g = val_44, b = val_45, a = val_46};
        this.nickname.color = new UnityEngine.Color() {r = val_43, g = val_44, b = val_45, a = val_46};
        this.deadIndication.color = new UnityEngine.Color() {r = val_43, g = val_44, b = val_45, a = val_46};
        if((val_31 != 0) || (((((val_33 == true) ? 1 : 0) ^ 1) & 1) != 0))
        {
            goto label_59;
        }
        
        this.faceBlinkTween.enabled = true;
        if((((val_36 != 0) ? 1 : 0) & 1) == 0)
        {
            goto label_61;
        }
        
        UnityEngine.Color val_18 = UnityEngine.Color.green;
        goto label_62;
        label_59:
        UnityEngine.Color val_19 = UnityEngine.Color.white;
        val_48 = val_19.r;
        val_49 = val_19.b;
        this.faceBlinkTween.from = val_19;
        mem2[0] = val_19.g;
        mem2[0] = val_49;
        mem2[0] = val_19.a;
        this.faceBlinkTween.ResetToBeginning();
        this.faceBlinkTween.enabled = false;
        goto label_66;
        label_61:
        UnityEngine.Color val_20 = UnityEngine.Color.red;
        label_62:
        val_48 = val_20.r;
        val_49 = val_20.b;
        this.faceBlinkTween.from = val_20;
        mem2[0] = val_20.g;
        mem2[0] = val_49;
        mem2[0] = val_20.a;
        label_66:
        this.nickname.text = 东一丁世丑丞业丄丐.丛三三与丁丘丄丑下;
        this.healthBar.fillAmount = val_39;
        this.armorBar.fillAmount = val_32;
        if((((val_31 != 0) ? 1 : 0) ^ this.deadIndication.gameObject.activeSelf) == false)
        {
                return;
        }
        
        this.deadIndication.gameObject.SetActive(value:  (val_31 != 0) ? 1 : 0);
        this.deadAnimation.SetActive(value:  (val_31 != 0) ? 1 : 0);
    }
    public BattleRoyaleSquadItemUI()
    {
    
    }

}
