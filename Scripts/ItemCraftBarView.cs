using UnityEngine;
internal sealed class ItemCraftBarView : PGBehaviour
{
    // Fields
    public UnityEngine.GameObject barContainer;
    public UnityEngine.GameObject levelsContainer;
    public UIBasicSprite countIcon;
    public UILabel countLabel;
    public UISprite oldFill;
    public UISprite newFill;
    public SimpleProgressBarWithAnimation fillAnim;
    public UILabel currentLavelLabel;
    public UILabel nextLavelLabel;
    public WidgetLayout widgetLayout;
    public System.Collections.Generic.List<int> dontShowForItems;
    private PGCompany.丗丟丄丈东丝丕丄世 丘丏丂丐丌专丐七丞;
    private PGCompany.三东丏不丗世丅丌丄 丕丟丈丙丟丅丟丑七;
    private System.Action 丁丏且七丘丌丑丗丌;
    
    // Properties
    internal System.Action 丐丄丘丟丂丆丂丘丏 { get; set; }
    
    // Methods
    internal System.Action 丂丙专丌丕七专丞丅()
    {
        return (System.Action)this.丁丏且七丘丌丑丗丌;
    }
    internal void 七丙上丒且丁丛东丄(System.Action 丙业与丙丗丝不丈东)
    {
        this.丁丏且七丘丌丑丗丌 = 丙业与丙丗丝不丈东;
        if(this.fillAnim == 0)
        {
                return;
        }
        
        this = this.丁丏且七丘丌丑丗丌;
        this.fillAnim.万万丗丛丏丐七丘丏 = this;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, System.Action 丅万下三丅上丙专与)
    {
        this.七丙上丒且丁丛东丄(丙业与丙丗丝不丈东:  丅万下三丅上丙专与);
        this.丕丟丈丙丟丅丟丑七 = 丈丄不七三万丄丁不;
        this.丘丏丂丐丌专丐七丞 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.barContainer, 丏业丟一东丂东丘丛:  false);
        if(this.丕丟丈丙丟丅丟丑七 == null)
        {
                return;
        }
        
        if(this.丘丏丂丐丌专丐七丞 == null)
        {
                return;
        }
        
        if(this.丅丄且丐东且与丏丞() == false)
        {
                return;
        }
        
        if((this.dontShowForItems.Contains(item:  this.丕丟丈丙丟丅丟丑七.业东丅东丌上丗丑不())) != false)
        {
                return;
        }
        
        this.丑丈不丌丑丅丄丛丈();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.barContainer, 丏业丟一东丂东丘丛:  true);
        this.丗丒丁丐丞丏丑七丅();
    }
    private bool 丅丄且丐东且与丏丞()
    {
        PGCompany.三东丏不丗世丅丌丄 val_9;
        var val_10;
        val_9 = this;
        if(this.丘丏丂丐丌专丐七丞 == null)
        {
            goto label_1;
        }
        
        if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  this.丕丟丈丙丟丅丟丑七.业东丅东丌上丗丑不())) != true)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  this.丕丟丈丙丟丅丟丑七)) == null)
        {
                return (bool)(val_9.丙丑丁专一专世万丕() > 0) ? 1 : 0;
        }
        
        }
        
        if(this.丕丟丈丙丟丅丟丑七.丂丁丏一丙丛业且丌() <= 0)
        {
            goto label_8;
        }
        
        val_10 = 1;
        return (bool)(val_9.丙丑丁专一专世万丕() > 0) ? 1 : 0;
        label_1:
        val_10 = 0;
        return (bool)(val_9.丙丑丁专一专世万丕() > 0) ? 1 : 0;
        label_8:
        val_9 = this.丕丟丈丙丟丅丟丑七;
        return (bool)(val_9.丙丑丁专一专世万丕() > 0) ? 1 : 0;
    }
    private void 丑丈不丌丑丅丄丛丈()
    {
        if(this.countIcon == 0)
        {
                return;
        }
        
        UnityEngine.Object val_3 = 0;
        val_3 = UnityEngine.Object.op_Inequality(x:  this.丘丏丂丐丌专丐七丞, y:  val_3);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.countIcon, 丏业丟一东丂东丘丛:  val_3);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.countIcon, 与万丆丛丒万丝丙丑:  this.丘丏丂丐丌专丐七丞);
        this.countIcon.color = new UnityEngine.Color() {r = V0.16B, g = V1.16B, b = V2.16B, a = V3.16B};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.countIcon, 丏业丟一东丂东丘丛:  true);
    }
    private void 丗丒丁丐丞丏丑七丅()
    {
        int val_22;
        int val_23;
        int val_24;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.levelsContainer, 丏业丟一东丂东丘丛:  false);
        PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  this.丕丟丈丙丟丅丟丑七);
        if(val_2 == null)
        {
            goto label_4;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        goto label_8;
        label_4:
        val_22 = this.丕丟丈丙丟丅丟丑七.业东丅东丌上丗丑不();
        if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  val_22)) == false)
        {
                return;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_7 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丐丆丅丝丂丄下业业(上七下丘一下三世丏:  this.丕丟丈丙丟丅丟丑七);
        int val_10 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丂世丐丁丒上丐丏丂(世且丐丐丑丛东专丟:  val_7.业东丅东丌上丗丑不());
        PGCompany.三东丏不丗世丅丌丄 val_24 = this.丕丟丈丙丟丅丟丑七;
        val_22 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().七丏万丞且丛丌专丞(丞世不丒下上上丝丑:  val_7.业东丅东丌上丗丑不());
        val_24 = val_10 - val_24.丂丁丏一丙丛业且丌();
        val_23 = UnityEngine.Mathf.Min(a:  val_10, b:  val_22);
        val_24 = UnityEngine.Mathf.Min(a:  val_24, b:  val_23);
        if(val_22 != 0)
        {
            goto label_20;
        }
        
        return;
        label_8:
        val_23 = val_2.且丆丟业丞丕丑上且();
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_22 = val_2.丏丈丁专专丘丒丂丂();
        val_24 = val_23 - this.丕丟丈丙丟丅丟丑七.丂丁丏一丙丛业且丌();
        this.丌与上三丅丙丑丌不(丌丞世七万业丝丙丄:  val_2);
        if(val_22 == 0)
        {
                return;
        }
        
        label_20:
        float val_26 = (float)val_24;
        val_26 = val_26 / (float)val_22;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this.oldFill, 丙业与丙丗丝不丈东:  val_26);
        float val_27 = (float)val_23;
        val_27 = val_27 / (float)val_22;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this.newFill, 丙业与丙丗丝不丈东:  val_27);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_23, arg1:  val_22));
        this.widgetLayout.Reposition();
        if(this.fillAnim == null)
        {
                return;
        }
        
        this.fillAnim.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  val_24, 丑丒丒丅七丞东丟丕:  val_23, 七丝东丛东丝且丆不:  val_22, 丈世万丙丟东与丕丞:  true);
    }
    private void 丌与上三丅丙丑丌不(PGCompany.业世丑丑丞丑丂丘东 丌丞世七万业丝丙丄)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.levelsContainer, 丏业丟一东丂东丘丛:  true);
        var val_6 = 0;
        val_6 = val_6 + 1;
        int val_2 = 丌丞世七万业丝丙丄.丁丕丁三丁丗不三丟();
        int val_3 = val_2 + 1;
        var val_7 = 0;
        val_7 = val_7 + 1;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentLavelLabel, 丕丗丘丑丛与丑业丒:  val_2);
        if(val_3 > 丌丞世七万业丝丙丄.万丙东丙丐丕专丈丕())
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nextLavelLabel, 丕丗丘丑丛与丑业丒:  "");
            return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nextLavelLabel, 丕丗丘丑丛与丑业丒:  val_3);
    }
    public ItemCraftBarView()
    {
        this.dontShowForItems = new System.Collections.Generic.List<System.Int32>();
    }

}
