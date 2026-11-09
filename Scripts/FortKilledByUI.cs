using UnityEngine;
public class FortKilledByUI : MonoBehaviour
{
    // Fields
    public UITextureMasked itemIcon;
    public UILabel itemName;
    public UILabel itemLevel;
    public UnityEngine.Texture[] mobModuleTypeIcons;
    public UITexture mobModule;
    
    // Methods
    internal void 下与丞三丅丛丄七丕(string 丝三丛且丘不丌丙下)
    {
        string val_67;
        UITextureMasked val_68;
        string val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        string val_74;
        var val_75;
        object val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        object val_82;
        string val_83;
        val_67 = 丝三丛且丘不丌丙下;
        val_68 = this;
        val_69 = 1152921505066536960;
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_24;
        }
        
        if((val_67.StartsWith(value:  "Enemy")) != true)
        {
                if((val_67.StartsWith(value:  "enemy")) == false)
        {
            goto label_24;
        }
        
        }
        
        this.gameObject.SetActive(value:  true);
        string val_6 = 丞东丑专丛丆丄丝世.丄丘一丐上丕丌一丏(下业七不丑丂丏丟东:  val_67).ToLower();
        val_70 = null;
        val_70 = null;
        val_71 = mem[FortEquipmentController.丝丘丞不丂丆不丘且 + 32];
        val_71 = FortEquipmentController.丝丘丞不丂丆不丘且 + 32;
        val_72 = 0;
        goto label_15;
        label_23:
        var val_7 = val_71 + 0;
        if(((FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32) == 0)
        {
            goto label_20;
        }
        
        val_73 = mem[(FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32];
        val_73 = (FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32;
        if(val_73 != null)
        {
            goto label_18;
        }
        
        if(((FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32.丑丝丈丟丌且且万世(丗丙丒一且丝丂丒世:  val_6)) == true)
        {
            goto label_21;
        }
        
        val_73 = mem[(FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32];
        val_73 = (FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32;
        label_18:
        if(val_73 == null)
        {
                if(((FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32.丑丝丈丟丌且且万世(丗丙丒一且丝丂丒世:  val_6)) == true)
        {
            goto label_21;
        }
        
        }
        
        label_20:
        val_72 = 1;
        label_15:
        if(val_72 < (FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 24))
        {
            goto label_23;
        }
        
        goto label_24;
        label_21:
        val_67 = mem[(FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32 + 96];
        val_67 = (FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32 + 96;
        label_24:
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_31;
        }
        
        if((val_67.StartsWith(value:  "Enemy")) != true)
        {
                if((val_67.StartsWith(value:  "enemy")) == false)
        {
            goto label_31;
        }
        
        }
        
        UnityEngine.Object val_15 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "DungeonMobs/{0}", arg0:  丞东丑专丛丆丄丝世.丄丘一丐上丕丌一丏(下业七不丑丂丏丟东:  val_67)));
        if(val_15 == null)
        {
            goto label_34;
        }
        
        var val_16 = (null == null) ? (val_15) : 0;
        goto label_36;
        label_31:
        if(this.mobModule != 0)
        {
                this.mobModule.gameObject.SetActive(value:  false);
        }
        
        if((val_67.StartsWith(value:  "fort_bot")) != false)
        {
                this.gameObject.SetActive(value:  true);
            this.itemName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (GameConnect.七丂万专且丏丘一丙() != true) ? "Key_8113" : "Key_8151");
            this.itemLevel.gameObject.SetActive(value:  false);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.itemIcon, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/{0}_icon1_big", arg0:  val_67.Replace(oldValue:  "fort_bot_", newValue:  System.String.alignConst))));
            return;
        }
        
        val_74 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_67);
        if(val_74 == null)
        {
                return;
        }
        
        val_75 = 0;
        val_76 = 0;
        goto label_58;
        label_76:
        val_77 = null;
        val_77 = null;
        var val_29 = (FortEquipmentController.丝丘丞不丂丆不丘且 + 32) + 0;
        if((System.String.op_Equality(a:  (FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32 + 96, b:  val_67)) != false)
        {
                val_78 = null;
            val_78 = null;
            var val_31 = (FortEquipmentController.丝丘丞不丂丆不丘且 + 32) + 0;
            val_76 = ((FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 0) + 32 + 88) + 1;
        }
        
        val_75 = 1;
        label_58:
        val_79 = null;
        val_79 = null;
        if(val_75 < (FortEquipmentController.丝丘丞不丂丆不丘且 + 32 + 24))
        {
            goto label_76;
        }
        
        this.itemLevel.gameObject.SetActive(value:  true);
        val_71 = 1152921505072021504;
        val_69 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  val_76);
        this.itemLevel.text = val_69;
        this.gameObject.SetActive(value:  true);
        val_74 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_28.nameLocalizationKey);
        this.itemName.text = val_74;
        val_68 = this.itemIcon;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_68, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/{0}_icon1_big", arg0:  val_67)));
        return;
        label_34:
        label_36:
        RilisoftBot.BaseBot val_39 = 0.GetComponent<RilisoftBot.BaseBot>();
        val_71 = 1152921504848912384;
        if(val_39 == 0)
        {
            goto label_91;
        }
        
        if(val_39 == null)
        {
            goto label_92;
        }
        
        val_80 = val_39.与丛上丙丟丘三世丁();
        goto label_93;
        label_91:
        val_81 = 0;
        val_80 = 1;
        goto label_94;
        label_92:
        val_80 = val_39.与丛上丙丟丘三世丁();
        label_93:
        val_81 = val_39.丙丕丁丅丁与丗丑丘();
        label_94:
        this.gameObject.SetActive(value:  true);
        val_82 = "fort_mob";
        val_83 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8147");
        if((val_80 - 2) <= 3)
        {
                var val_66 = 106037752 + ((val_42 - 2)) << 2;
            val_66 = val_66 + 106037752;
        }
        else
        {
                this.itemLevel.gameObject.SetActive(value:  false);
            val_69 = this.itemName;
            val_69.text = ;
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.itemIcon, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/{0}_icon1_big", arg0:  null)));
            val_74 = this.mobModule.gameObject;
            if(val_74 == 0)
        {
                return;
        }
        
            this.mobModule.gameObject.SetActive(value:  (val_81 != 0) ? 1 : 0);
            UnityEngine.Texture val_67 = this.mobModuleTypeIcons[(long)val_81];
            val_68 = ???;
            val_74 = ???;
            val_69 = ???;
            val_71 = ???;
        }
    
    }
    internal void 丆世与丑丆丅丐万且()
    {
        this.gameObject.SetActive(value:  false);
    }
    public FortKilledByUI()
    {
    
    }

}
