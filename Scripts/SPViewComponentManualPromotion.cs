using UnityEngine;
internal sealed class SPViewComponentManualPromotion : SPViewComponentBase
{
    // Fields
    private System.Collections.Generic.List<UIBasicSprite> patternRessivers;
    private System.Collections.Generic.List<UIWidget> colorRessivers;
    private string defaultPatternPath;
    private string defaultColorHex;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_19;
        System.Collections.Generic.List<UIWidget> val_20;
        UnityEngine.Object val_21;
        val_20 = this;
        if((且丘丏丁丑与丙与丁 != null) && ((System.String.op_Equality(a:  且丘丏丁丑与丙与丁.丝丒丙一丙丄不三丞(), b:  "manual")) != false))
        {
                this.gameObject.SetActive(value:  true);
            mem[1152921539229468888] = 且丘丏丁丑与丙与丁;
            val_21 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世().丅丙丑丛专一丟丐丈(一丗与一专丙丙丅丄:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与()));
            if(val_21 == 0)
        {
                val_21 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.defaultPatternPath);
        }
        
            if(val_21 != 0)
        {
                丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丁丗不丐丅丆丕与三:  this.patternRessivers, 与万丆丛丒万丝丙丑:  val_21);
        }
        
            val_19 = PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世();
            UnityEngine.Color val_14 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  val_19.丏丑丛丘丕丛丆丗丝(一丗与一专丙丙丅丄:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与()));
            UnityEngine.Color32 val_15 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.a});
            byte val_16 = val_15.r & 4294967295;
            if((262871416 & 1) == 0)
        {
                return;
        }
        
            val_20 = this.colorRessivers;
            UnityEngine.Color val_17 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 120, g = 25, b = 171, a = 15});
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  val_20, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a});
            return;
        }
        
        val_20 = this.gameObject;
        val_20.SetActive(value:  false);
    }
    public SPViewComponentManualPromotion()
    {
        val_1 = new PGBehaviour();
    }

}
