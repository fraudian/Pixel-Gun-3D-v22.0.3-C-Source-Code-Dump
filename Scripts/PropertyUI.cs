using UnityEngine;
public class PropertyUI : MonoBehaviour
{
    // Fields
    private UILabel nameLabel;
    private UILabel descriptionLabel;
    private UISprite icon;
    private UILabel countLabel;
    private bool dynamicDepth;
    private bool applyColor;
    private UILabel countAdditionalLabel;
    private UISprite barA;
    private UISprite barB;
    private UISprite bg;
    public UIWidget widget;
    private UISprite frame;
    
    // Properties
    internal UILabel 丑丅丒专丕丕与一七 { get; }
    internal UILabel 丞丄专业七丅丆丌丄 { get; }
    internal UISprite 丛丙丂丝不丏上东不 { get; }
    internal UILabel 专丕下万业专丌丙下 { get; }
    internal UISprite 且且丞丕丛世丝且万 { get; }
    
    // Methods
    internal UILabel 丆丘与丌一不万不丐()
    {
        return (UILabel)this.nameLabel;
    }
    internal UILabel 丗丗丁丛东丝上上不()
    {
        return (UILabel)this.descriptionLabel;
    }
    internal UISprite 丑一丆丑且丟上业丛()
    {
        return (UISprite)this.icon;
    }
    internal UILabel 下丌丘七世丟丂业丟()
    {
        return (UILabel)this.countLabel;
    }
    internal UISprite 丅丑丗上专丁丛丝业()
    {
        return (UISprite)this.frame;
    }
    internal void 专东下上丛丙下东上(int 丟丕丞丁丝丂上丄上)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.nameLabel)) != false)
        {
                this.nameLabel.depth = 丟丕丞丁丝丂上丄上;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.icon)) != false)
        {
                this.icon.depth = 丟丕丞丁丝丂上丄上;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.countLabel)) != false)
        {
                this.countLabel.depth = 丟丕丞丁丝丂上丄上;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.frame)) != false)
        {
                this.frame.depth = 丟丕丞丁丝丂上丄上;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.barA)) != false)
        {
                this.barA.depth = 丟丕丞丁丝丂上丄上;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.barB)) != false)
        {
                this.barB.depth = 丟丕丞丁丝丂上丄上 - 1;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.bg)) != false)
        {
                this.bg.depth = 丟丕丞丁丝丂上丄上 - 2;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.widget)) == false)
        {
                return;
        }
        
        this.widget.depth = 丟丕丞丁丝丂上丄上 - 3;
    }
    internal void 世与东丗世三丞丞不(string 世丒丟丂丟丟丈丄丙, int 丟丕丞丁丝丂上丄上, string 丛丐丌丙丈七丛丛东, string 丟丒丏丛三丟丑丗丝, string 丌丒丝东丌下丕丁丅, float 丙丝与丆三丝不且丑 = 0, System.Nullable<UnityEngine.Color> 丑丞丈丗丄丙丟万丄, System.Nullable<UnityEngine.Color> 业丑丙一丐丞丌丘丅)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.descriptionLabel)) != false)
        {
                this.descriptionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  世丒丟丂丟丟丈丄丙);
            if(this.applyColor != false)
        {
                if(业丑丙一丐丞丌丘丅.HasValue.HasValue != false)
        {
                this.descriptionLabel.color = new UnityEngine.Color() {r = 丙丝与丆三丝不且丑, g = V1.16B, b = V2.16B, a = V3.16B};
        }
        
        }
        
        }
        
        this.世与东丗世三丞丞不(丟丕丞丁丝丂上丄上:  丟丕丞丁丝丂上丄上, 丛丐丌丙丈七丛丛东:  丛丐丌丙丈七丛丛东, 丟丒丏丛三丟丑丗丝:  丟丒丏丛三丟丑丗丝, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丙丝与丆三丝不且丑:  丙丝与丆三丝不且丑, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
    }
    internal void 世与东丗世三丞丞不(int 丟丕丞丁丝丂上丄上, string 丛丐丌丙丈七丛丛东, string 丟丒丏丛三丟丑丗丝, string 丌丒丝东丌下丕丁丅, float 丙丝与丆三丝不且丑 = 0, System.Nullable<UnityEngine.Color> 丑丞丈丗丄丙丟万丄, System.Nullable<UnityEngine.Color> 业丑丙一丐丞丌丘丅)
    {
        string val_6;
        UISprite val_7;
        float val_8;
        val_6 = 丟丒丏丛三丟丑丗丝;
        if(this.dynamicDepth != false)
        {
                this.专东下上丛丙下东上(丟丕丞丁丝丂上丄上:  丟丕丞丁丝丂上丄上);
        }
        
        val_7 = this.icon;
        if((UnityEngine.Object.op_Implicit(exists:  val_7)) != false)
        {
                val_7 = this.icon;
            val_7.spriteName = 丛丐丌丙丈七丛丛东;
            if(this.applyColor != false)
        {
                if(业丑丙一丐丞丌丘丅.HasValue.HasValue != false)
        {
                val_8 = V1.16B;
            this.icon.color = new UnityEngine.Color() {r = 丙丝与丆三丝不且丑, g = val_8, b = V2.16B, a = V3.16B};
        }
        
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.nameLabel)) != false)
        {
                val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6);
            this.nameLabel.text = val_6;
            if(this.applyColor != false)
        {
                if(业丑丙一丐丞丌丘丅.HasValue.HasValue != false)
        {
                val_6 = this.nameLabel;
            val_8 = val_8;
            val_6.color = new UnityEngine.Color() {r = 丙丝与丆三丝不且丑, g = val_8, b = V2.16B, a = V3.16B};
        }
        
        }
        
        }
        
        this.世与东丗世三丞丞不(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丙丝与丆三丝不且丑:  丙丝与丆三丝不且丑, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
    }
    internal void 世与东丗世三丞丞不(int 丟丕丞丁丝丂上丄上, string 丞丅上丏丂且下丅与, string 丌丒丝东丌下丕丁丅, float 丙丝与丆三丝不且丑 = 0, System.Nullable<UnityEngine.Color> 丑丞丈丗丄丙丟万丄, System.Nullable<UnityEngine.Color> 业丑丙一丐丞丌丘丅)
    {
        this.世与东丗世三丞丞不(丟丕丞丁丝丂上丄上:  丟丕丞丁丝丂上丄上, 丛丐丌丙丈七丛丛东:  丞丅上丏丂且下丅与, 丟丒丏丛三丟丑丗丝:  丞丅上丏丂且下丅与, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅, 丙丝与丆三丝不且丑:  丙丝与丆三丝不且丑, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
    }
    internal void 世与东丗世三丞丞不(string 丌丒丝东丌下丕丁丅, float 丙丝与丆三丝不且丑, System.Nullable<UnityEngine.Color> 丑丞丈丗丄丙丟万丄, System.Nullable<UnityEngine.Color> 业丑丙一丐丞丌丘丅)
    {
        UILabel val_8;
        float val_9;
        UISprite val_10;
        val_8 = this.countLabel;
        if((UnityEngine.Object.op_Implicit(exists:  val_8)) != false)
        {
                val_8 = this.countLabel;
            val_8.text = 丌丒丝东丌下丕丁丅;
            if(this.applyColor != false)
        {
                if(业丑丙一丐丞丌丘丅.HasValue.HasValue != false)
        {
                val_9 = 丙丝与丆三丝不且丑;
            this.countLabel.color = new UnityEngine.Color() {r = val_9, g = V1.16B, b = V2.16B, a = V3.16B};
        }
        
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.countAdditionalLabel)) != false)
        {
                this.countAdditionalLabel.text = "";
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.barB)) != false)
        {
                val_9 = 0f;
            this.barB.fillAmount = val_9;
        }
        
        val_10 = this.barA;
        if((UnityEngine.Object.op_Implicit(exists:  val_10)) != false)
        {
                val_10 = this.barA;
            val_9 = 丙丝与丆三丝不且丑;
            val_10.fillAmount = val_9;
        }
        
        if(this.applyColor == false)
        {
                return;
        }
        
        val_10 = this.barA;
        if((UnityEngine.Object.op_Implicit(exists:  val_10)) == false)
        {
                return;
        }
        
        if(丑丞丈丗丄丙丟万丄.HasValue.HasValue == false)
        {
                return;
        }
        
        this.barA.color = new UnityEngine.Color() {r = val_9, g = V1.16B, b = V2.16B, a = V3.16B};
    }
    internal void 业丐丅丕丏丅丅丞丒(int 丟丕丞丁丝丂上丄上, string 丞丅上丏丂且下丅与, float 丛丌丏专万业丞上丛, float 三上七丑东丅业东丁, float 丆丝七丕丘七丝丁三 = 0, bool 丕丛丂丞世丁丐丌专 = False, string 业丙丐丑丘世一一丏 = "")
    {
        this.业丐丅丕丏丅丅丞丒(丟丕丞丁丝丂上丄上:  丟丕丞丁丝丂上丄上, 丛丐丌丙丈七丛丛东:  丞丅上丏丂且下丅与, 丟丒丏丛三丟丑丗丝:  丞丅上丏丂且下丅与, 丛丌丏专万业丞上丛:  丛丌丏专万业丞上丛, 三上七丑东丅业东丁:  三上七丑东丅业东丁, 丆丝七丕丘七丝丁三:  丆丝七丕丘七丝丁三, 丕丛丂丞世丁丐丌专:  丕丛丂丞世丁丐丌专, 业丙丐丑丘世一一丏:  业丙丐丑丘世一一丏);
    }
    internal void 业丐丅丕丏丅丅丞丒(int 丟丕丞丁丝丂上丄上, string 丛丐丌丙丈七丛丛东, string 丟丒丏丛三丟丑丗丝, float 丛丌丏专万业丞上丛, float 三上七丑东丅业东丁, float 丆丝七丕丘七丝丁三 = 0, bool 丕丛丂丞世丁丐丌专 = False, string 业丙丐丑丘世一一丏 = "")
    {
        if(this.dynamicDepth != false)
        {
                this.专东下上丛丙下东上(丟丕丞丁丝丂上丄上:  丟丕丞丁丝丂上丄上);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.icon)) != false)
        {
                this.icon.spriteName = 丛丐丌丙丈七丛丛东;
        }
        
        this.nameLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丟丒丏丛三丟丑丗丝);
        this.业丐丅丕丏丅丅丞丒(丛丌丏专万业丞上丛:  丛丌丏专万业丞上丛, 三上七丑东丅业东丁:  三上七丑东丅业东丁, 丆丝七丕丘七丝丁三:  丆丝七丕丘七丝丁三, 丕丛丂丞世丁丐丌专:  丕丛丂丞世丁丐丌专, 业丙丐丑丘世一一丏:  业丙丐丑丘世一一丏);
    }
    internal void 业丐丅丕丏丅丅丞丒(float 丛丌丏专万业丞上丛, float 三上七丑东丅业东丁, float 丆丝七丕丘七丝丁三 = 0, bool 丕丛丂丞世丁丐丌专 = False, string 业丙丐丑丘世一一丏 = "")
    {
        float val_25;
        float val_27;
        UISprite val_28;
        float val_29;
        string val_30;
        string val_31;
        UILabel val_32;
        丛丌丏专万业丞上丛 = 三上七丑东丅业东丁 - 丛丌丏专万业丞上丛;
        val_25 = System.Math.Abs(丛丌丏专万业丞上丛);
        string val_1 = val_25.ToString();
        this.countLabel.text = 丛丌丏专万业丞上丛.ToString();
        if(this.applyColor != false)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.barA)) != false)
        {
                UnityEngine.Color val_4 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompareDefault");
            val_25 = val_4.r;
            val_27 = val_4.g;
            this.barA.color = new UnityEngine.Color() {r = val_25, g = val_27, b = val_4.b, a = val_4.a};
        }
        
        }
        
        if(丆丝七丕丘七丝丁三 <= 0f)
        {
            goto label_9;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.barA)) != false)
        {
                val_27 = 三上七丑东丅业东丁 / 丆丝七丕丘七丝丁三;
            val_25 = UnityEngine.Mathf.Min(a:  丛丌丏专万业丞上丛 / 丆丝七丕丘七丝丁三, b:  val_27);
            this.barA.fillAmount = val_25;
        }
        
        val_28 = this.barB;
        if((UnityEngine.Object.op_Implicit(exists:  val_28)) == false)
        {
            goto label_30;
        }
        
        val_28 = this.barB;
        val_29 = 丛丌丏专万业丞上丛 / 丆丝七丕丘七丝丁三;
        val_27 = 三上七丑东丅业东丁 / 丆丝七丕丘七丝丁三;
        goto label_21;
        label_9:
        if((UnityEngine.Object.op_Implicit(exists:  this.barA)) != false)
        {
                val_27 = 三上七丑东丅业东丁;
            val_25 = UnityEngine.Mathf.Min(a:  丛丌丏专万业丞上丛, b:  val_27);
            this.barA.fillAmount = val_25;
        }
        
        val_28 = this.barB;
        if((UnityEngine.Object.op_Implicit(exists:  val_28)) == false)
        {
            goto label_30;
        }
        
        val_28 = this.barB;
        val_29 = 丛丌丏专万业丞上丛;
        val_27 = 三上七丑东丅业东丁;
        label_21:
        val_25 = UnityEngine.Mathf.Max(a:  val_29, b:  val_27);
        val_28.fillAmount = val_25;
        label_30:
        UnityEngine.Color val_13 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompareDefault");
        if(丛丌丏专万业丞上丛 <= 三上七丑东丅业东丁)
        {
            goto label_34;
        }
        
        val_30 = " - "(" - ") + val_1;
        if(丕丛丂丞世丁丐丌专 == false)
        {
            goto label_35;
        }
        
        label_38:
        val_31 = "CompareGreen";
        goto label_36;
        label_34:
        if(丛丌丏专万业丞上丛 >= 0)
        {
            goto label_37;
        }
        
        val_30 = " + "(" + ") + val_1;
        if(丕丛丂丞世丁丐丌专 == false)
        {
            goto label_38;
        }
        
        label_35:
        val_31 = "CompareRed";
        label_36:
        UnityEngine.Color val_16 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_31);
        label_53:
        if(this.applyColor != false)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.barB)) != false)
        {
                this.barB.color = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.countAdditionalLabel)) != false)
        {
                if(this.applyColor != false)
        {
                this.countAdditionalLabel.color = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
        }
        
            val_32 = this.countAdditionalLabel;
            string val_19 = val_30 + 业丙丐丑丘世一一丏;
        }
        else
        {
                val_32 = this.countLabel;
        }
        
        val_32.text = val_32.text + val_30 + 业丙丐丑丘世一一丏;
        return;
        label_37:
        if(丛丌丏专万业丞上丛 != 三上七丑东丅业东丁)
        {
            goto label_53;
        }
        
        goto label_53;
    }
    internal void 丐丘七丘丒丅业丈世()
    {
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        if(this.applyColor == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.icon)) != false)
        {
                UnityEngine.Color val_2 = UnityEngine.Color.white;
            val_7 = val_2.r;
            val_8 = val_2.b;
            val_9 = val_7;
            val_10 = val_2.g;
            val_11 = val_8;
            val_12 = val_2.a;
            this.icon.color = new UnityEngine.Color() {r = val_9, g = val_10, b = val_11, a = val_12};
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.nameLabel)) != false)
        {
                UnityEngine.Color val_4 = UnityEngine.Color.white;
            val_7 = val_4.r;
            val_8 = val_4.b;
            val_9 = val_7;
            val_10 = val_4.g;
            val_11 = val_8;
            val_12 = val_4.a;
            this.nameLabel.color = new UnityEngine.Color() {r = val_9, g = val_10, b = val_11, a = val_12};
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.countLabel)) == false)
        {
                return;
        }
        
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        this.countLabel.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
    }
    public PropertyUI()
    {
        this.dynamicDepth = true;
        this.applyColor = true;
    }

}
