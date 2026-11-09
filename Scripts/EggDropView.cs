using UnityEngine;
internal class EggDropView : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject guarantedDropContainer;
    private UnityEngine.GameObject chanceDropContainer;
    private UILabel guarantedDrop;
    private UILabel chanceDrop;
    private System.Collections.Generic.List<UITexture> iconsGuaranted;
    private System.Collections.Generic.List<UITexture> iconsChanced;
    private WidgetLayout _widgetLayoutGuaranted;
    private WidgetLayout _widgetLayoutChanced;
    private PGCompany.丕下丆丑万世业丈丟 丄丈世业七丐三上东;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕)
    {
        this.丄丈世业七丐三上东 = 世丕丘丈丙世业东丕;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        object val_4;
        var val_24;
        var val_25;
        var val_26;
        float val_27;
        float val_28;
        object val_29;
        var val_30;
        PGCompany.专丛且丌丒丘业专万 val_1 = this.丄丈世业七丐三上东.丏丝丆丆丆丏丗上丛();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.guarantedDropContainer, 丏业丟一东丂东丘丛:  ( > 0) ? 1 : 0);
        if( < 1)
        {
            goto label_4;
        }
        
        val_4 = val_4;
        this.guarantedDrop.text = System.String.Format(format:  "x{0}-{1}", arg0:  val_4, arg1:  null);
        val_24 = 1152921525976703440;
        val_25 = 1152921525976705488;
        val_26 = 0;
        goto label_6;
        label_18:
        int val_7 = val_4.Count;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.iconsGuaranted.Item[0], 丏业丟一东丂东丘丛:  (val_7 > val_26) ? 1 : 0);
        if(val_7 > val_26)
        {
                UnityEngine.Color val_12 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_4.Item[0]);
            val_27 = val_12.r;
            val_28 = val_12.b;
            this.iconsGuaranted.Item[0].color = new UnityEngine.Color() {r = val_27, g = val_12.g, b = val_28, a = val_12.a};
        }
        
        val_26 = 1;
        label_6:
        if(val_26 < this.iconsGuaranted.Count)
        {
            goto label_18;
        }
        
        label_4:
        PGCompany.专丛且丌丒丘业专万 val_14 = this.丄丈世业七丐三上东.上丂丌业与丘世丌丕();
        val_29;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chanceDropContainer, 丏业丟一东丂东丘丛:  (val_29 > 0) ? 1 : 0);
        if(val_29 < 1)
        {
            goto label_22;
        }
        
        val_4 = val_4;
        this.chanceDrop.text = System.String.Format(format:  "x{0}-{1}", arg0:  val_4, arg1:  val_29);
        val_24 = 1152921525976703440;
        val_25 = 1152921525976705488;
        val_30 = 0;
        goto label_24;
        label_36:
        int val_17 = val_4.Count;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.iconsChanced.Item[0], 丏业丟一东丂东丘丛:  (val_17 > val_30) ? 1 : 0);
        if(val_17 > val_30)
        {
                UnityEngine.Color val_22 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_4.Item[0]);
            val_27 = val_22.r;
            val_28 = val_22.b;
            this.iconsChanced.Item[0].color = new UnityEngine.Color() {r = val_27, g = val_22.g, b = val_28, a = val_22.a};
        }
        
        val_30 = 1;
        label_24:
        val_29 = this.iconsChanced;
        if(val_30 < val_29.Count)
        {
            goto label_36;
        }
        
        label_22:
        this._widgetLayoutGuaranted.Reposition();
        this._widgetLayoutChanced.Reposition();
    }
    public EggDropView()
    {
    
    }

}
