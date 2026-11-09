using UnityEngine;
public class SetChatLabelController : MonoBehaviour
{
    // Fields
    public UILabel killerLabel;
    public UILabel killedLabel;
    public UITexture reasonSprite;
    public UISprite reasonSprite2;
    
    // Methods
    internal void 丒一业业丝丗三丈丏(Player_move_c.且丗丞丅丕丕丟丕丌 丄丙下丝丛丒七丂丘)
    {
        this.SetChatLabelText(一下丄不丈丆丒与丝:  丄丙下丝丛丒七丂丘.万七且丕丟世且丌不, 丙丞丗丁丑丒不丐且:  丄丙下丝丛丒七丂丘.丕上丄丘世不万一丞, 东东丝东丐丑下丁丏:  丄丙下丝丛丒七丂丘.丙丐丝一丟下丂下丒, 丞丙丛丘丅丙丗丁三:  丄丙下丝丛丒七丂丘.丝丅丏丞丐丈丞三丞, 东丁专丁不丒丂丐丏:  丄丙下丝丛丒七丂丘.丏丒不丌丝万三丄丆, 丂上丛丈上不世丈丈:  丄丙下丝丛丒七丂丘.丄丙下丝丛丒七丂丘, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丄丙下丝丛丒七丂丘.丏与丐且丏丘下东上.r, g = 丄丙下丝丛丒七丂丘.丏与丐且丏丘下东上.g, b = 丄丙下丝丛丒七丂丘.丏与丐且丏丘下东上.b, a = 丄丙下丝丛丒七丂丘.丏与丐且丏丘下东上.a});
    }
    public void SetChatLabelText(string 一下丄不丈丆丒与丝, int 丙丞丗丁丑丒不丐且, string 东东丝东丐丑下丁丏, string 丞丙丛丘丅丙丗丁三, int 东丁专丁不丒丂丐丏, string 丂上丛丈上不世丈丈, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        float val_45;
        float val_46;
        float val_47;
        float val_48;
        UILabel val_49;
        var val_50;
        var val_51;
        var val_52;
        UILabel val_53;
        float val_58;
        float val_59;
        float val_60;
        float val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        UILabel val_66;
        var val_71;
        val_45 = 丑丞丈丗丄丙丟万丄.a;
        val_46 = 丑丞丈丗丄丙丟万丄.b;
        val_47 = 丑丞丈丗丄丙丟万丄.g;
        val_48 = 丑丞丈丗丄丙丟万丄.r;
        val_49 = this;
        val_50 = null;
        val_50 = null;
        val_51 = 丘丑丅三丆丑丌且丝();
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                val_52 = null;
            val_52 = null;
            var val_4 = (typeof(Player_move_c).__il2cppRuntimeField_618.且世专不丄丏七下万() != true) ? (1 + 1) : 1;
        }
        
        val_53 = this.killerLabel;
        val_53.text = 一下丄不丈丆丒与丝;
        UnityEngine.Color val_5 = UnityEngine.Color.white;
        val_58 = val_48;
        val_59 = val_47;
        val_60 = val_46;
        val_61 = val_45;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_48, g = val_47, b = val_46, a = val_45}, rhs:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a})) == true)
        {
            goto label_14;
        }
        
        if(丙丞丗丁丑丒不丐且 == 0)
        {
            goto label_27;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() != true)
        {
                if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_27;
        }
        
        }
        
        val_62 = null;
        val_62 = null;
        val_53 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_53 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_53 == 0)
        {
            goto label_27;
        }
        
        if(val_4 != 丙丞丗丁丑丒不丐且)
        {
            goto label_28;
        }
        
        UnityEngine.Color val_10 = UnityEngine.Color.blue;
        goto label_99;
        label_27:
        UnityEngine.Color val_11 = UnityEngine.Color.white;
        label_99:
        val_58 = val_11.r;
        val_59 = val_11.g;
        val_60 = val_11.b;
        val_61 = val_11.a;
        label_14:
        this.killerLabel.color = new UnityEngine.Color() {r = val_58, g = val_59, b = val_60, a = val_61};
        val_63 = 1152921504848912384;
        val_64 = this.killerLabel.width;
        if(this.reasonSprite != 0)
        {
                if((System.String.IsNullOrEmpty(value:  丂上丛丈上不世丈丈)) == false)
        {
            goto label_35;
        }
        
        }
        
        if((this.reasonSprite == 0) || (this.reasonSprite.gameObject.activeSelf == false))
        {
            goto label_44;
        }
        
        this.reasonSprite.gameObject.SetActive(value:  false);
        goto label_44;
        label_35:
        if(this.reasonSprite.gameObject.activeSelf != true)
        {
                this.reasonSprite.gameObject.SetActive(value:  true);
        }
        
        float val_45 = 33f;
        val_45 = (float)val_64 + val_45;
        this.reasonSprite.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_65 = null;
        val_65 = null;
        val_53 = KillChatIconsStorage.丄丘七三上丕世丞业;
        val_64 = val_64 + 66;
        UnityEngine.Texture val_23 = val_53.丗丄丂且丑丑东万丝(丛丐丌丙丈七丛丛东:  丂上丛丈上不世丈丈);
        label_44:
        bool val_26 = this.reasonSprite2.gameObject.activeSelf;
        if((System.String.IsNullOrEmpty(value:  东东丝东丐丑下丁丏)) == false)
        {
            goto label_58;
        }
        
        if(val_26 == false)
        {
            goto label_62;
        }
        
        this.reasonSprite2.gameObject.SetActive(value:  false);
        goto label_62;
        label_58:
        if(val_26 != true)
        {
                this.reasonSprite2.gameObject.SetActive(value:  true);
        }
        
        float val_46 = (float)val_64;
        val_46 = val_46 + 23f;
        this.reasonSprite2.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_64 = val_64 + 46;
        this.reasonSprite2.spriteName = 东东丝东丐丑下丁丏;
        label_62:
        val_66 = System.String.IsNullOrEmpty(value:  丞丙丛丘丅丙丗丁三);
        bool val_32 = this.killedLabel.gameObject.activeSelf;
        if(val_66 != false)
        {
                if(val_32 == false)
        {
                return;
        }
        
            val_63 = this.killedLabel.gameObject;
            val_63.SetActive(value:  false);
            return;
        }
        
        if(val_32 != true)
        {
                this.killedLabel.gameObject.SetActive(value:  true);
        }
        
        this.killedLabel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_66 = this.killedLabel;
        val_66.text = 丞丙丛丘丅丙丗丁三;
        val_49 = this.killedLabel;
        UnityEngine.Color val_36 = UnityEngine.Color.white;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_48, g = val_47, b = val_46, a = val_45}, rhs:  new UnityEngine.Color() {r = val_36.r, g = val_36.g, b = val_36.b, a = val_36.a})) == true)
        {
            goto label_82;
        }
        
        val_66 = 东丁专丁不丒丂丐丏;
        if(val_66 == 0)
        {
            goto label_95;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() != true)
        {
                if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_95;
        }
        
        }
        
        val_71 = null;
        val_71 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_95;
        }
        
        if(val_4 != val_66)
        {
            goto label_96;
        }
        
        UnityEngine.Color val_41 = UnityEngine.Color.blue;
        goto label_100;
        label_95:
        UnityEngine.Color val_42 = UnityEngine.Color.white;
        label_100:
        val_48 = val_42.r;
        val_47 = val_42.g;
        val_46 = val_42.b;
        val_45 = val_42.a;
        label_82:
        val_49.color = new UnityEngine.Color() {r = val_48, g = val_47, b = val_46, a = val_45};
        return;
        label_28:
        UnityEngine.Color val_43 = UnityEngine.Color.red;
        goto label_99;
        label_96:
        UnityEngine.Color val_44 = UnityEngine.Color.red;
        goto label_100;
    }
    private string 丐七七专世丘丏与丙(string 丑东与丅丐丅丂丞业)
    {
        return (string)丑东与丅丐丅丂丞业;
    }
    public SetChatLabelController()
    {
    
    }

}
