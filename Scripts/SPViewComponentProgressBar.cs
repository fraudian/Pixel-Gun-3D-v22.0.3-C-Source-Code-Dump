using UnityEngine;
internal sealed class SPViewComponentProgressBar : SPViewComponentBase
{
    // Fields
    private UISprite bar;
    private UILabel label;
    private WidgetLayout layout;
    private string localKey;
    private System.Collections.Generic.List<UISprite> barFillCopy;
    private System.Collections.Generic.List<UISprite> additionalFill;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        val_7 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛();
        if((val_7.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "promotion-collectable")) != false)
        {
                this.丟丝丗丛业不丗丑丞(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        }
        else
        {
                val_7 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛();
            if((val_7.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "reward-details")) == false)
        {
                return;
        }
        
            this.丑一丒七一丞与业且(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    private void 丑一丒七一丞与业且(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        System.Collections.Generic.IEnumerable<TSource> val_21;
        var val_22;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_24;
        UISprite val_25;
        string val_26;
        val_21 = 且丘丏丁丑与丙与丁;
        val_22 = null;
        val_22 = null;
        val_24 = SPViewComponentProgressBar.<>c.<>9__7_0;
        if(val_24 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_1 = null;
            val_24 = val_1;
            val_1 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  SPViewComponentProgressBar.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SPViewComponentProgressBar.<>c::丙三丝丒丛上下与丞(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛));
            SPViewComponentProgressBar.<>c.<>9__7_0 = val_24;
        }
        
        val_25 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_21, predicate:  val_1);
        if(val_25 == null)
        {
                return;
        }
        
        int val_5 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丂世丐丁丒上丐丏丂(世且丐丐丑丛东专丟:  val_25.业东丅东丌上丗丑不());
        int val_8 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().七丏万丞且丛丌专丞(丞世不丒下上上丝丑:  val_25.业东丅东丌上丗丑不());
        if((val_21.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "state.purchased")) != false)
        {
                val_21 = 0;
        }
        else
        {
                val_21 = UnityEngine.Mathf.Clamp(value:  val_25.丂丁丏一丙丛业且丌(), min:  0, max:  val_8 - val_5);
        }
        
        if(val_8 > 0)
        {
                val_26 = System.String.Format(format:  "{0}/{1}", arg0:  val_5, arg1:  val_8);
            if(val_21 >= 1)
        {
                val_26 = val_26 + System.String.Format(format:  " +{0}", arg0:  val_21)(System.String.Format(format:  " +{0}", arg0:  val_21));
        }
        
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  val_26);
            float val_21 = (float)val_5;
            val_21 = val_21 / (float)val_8;
            this.bar.fillAmount = val_21;
            val_25 = this.bar;
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.barFillCopy, 丙业与丙丗丝不丈东:  val_25.fillAmount);
            float val_22 = (float)val_21 + val_5;
            val_22 = val_22 / (float)val_8;
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.additionalFill, 丙业与丙丗丝不丈东:  val_22);
            if(this.layout == null)
        {
                return;
        }
        
            this.layout.Reposition();
            return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        this.bar.fillAmount = 1f;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.barFillCopy, 丙业与丙丗丝不丈东:  this.bar.fillAmount);
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.additionalFill, 丙业与丙丗丝不丈东:  this.bar.fillAmount);
    }
    private void 丟丝丗丛业不丗丑丞(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        string val_13;
        int val_2 = 且丘丏丁丑与丙与丁.丐丂业丁丑丅与且丐().From;
        int val_4 = 且丘丏丁丑与丙与丁.丐丂业丁丑丅与且丐().To;
        if(val_4 > 0)
        {
                val_13 = System.String.Format(format:  "{0}/{1}", arg0:  val_2, arg1:  val_4);
            float val_13 = 100f;
            float val_6 = (float)val_2 / (float)val_4;
            val_13 = val_6 * val_13;
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.localKey)) != false)
        {
                val_13 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.localKey), arg0:  val_2, arg1:  val_4, arg2:  UnityEngine.Mathf.FloorToInt(f:  val_13));
        }
        
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  val_13);
            this.bar.fillAmount = val_6;
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.barFillCopy, 丙业与丙丗丝不丈东:  this.bar.fillAmount);
            if(this.layout == null)
        {
                return;
        }
        
            this.layout.Reposition();
            return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        this.bar.fillAmount = 1f;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.barFillCopy, 丙业与丙丗丝不丈东:  this.bar.fillAmount);
    }
    public SPViewComponentProgressBar()
    {
        this.barFillCopy = new System.Collections.Generic.List<UISprite>();
        this.additionalFill = new System.Collections.Generic.List<UISprite>();
        this = new PGBehaviour();
    }

}
