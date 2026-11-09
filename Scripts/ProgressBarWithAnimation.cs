using UnityEngine;
public class ProgressBarWithAnimation : PGBehaviour
{
    // Fields
    public bool showIncrementAnimation;
    public bool showDecrementAnimation;
    public bool showMaxValue;
    public float animationSpeed;
    private System.Collections.Generic.List<UISprite> currentFill;
    private System.Collections.Generic.List<UISprite> additionalFill;
    private System.Collections.Generic.List<UILabel> countLabel;
    private System.Collections.Generic.List<WidgetLayout> widgetLayouts;
    private bool 丑丌丒丈与丟丕丌丈;
    private ProgressBarWithAnimation.丌一七丏不且且丟丙 丝七丁丘丆丈上下万;
    private ProgressBarWithAnimation.丌一七丏不且且丟丙 丞与丟与七且丌丌丆;
    private ProgressBarWithAnimation.丙丟与丐三丐万万丆 丗下丘世三七一专丕;
    internal System.Action 万万丗丛丏丐七丘丏;
    private bool 上丅丝丒丕丙七丛丒;
    private bool 专丝丁专丐丝丌丑一;
    private bool 丂丘丆一东东丝专专;
    private float 不丄丒上丙上世丙丘;
    private float 七世专且丕丗下丝上;
    
    // Properties
    internal ProgressBarWithAnimation.丙丟与丐三丐万万丆 上丅丑丌丑丏丏丙东 { get; }
    
    // Methods
    internal ProgressBarWithAnimation.丙丟与丐三丐万万丆 万丘三丘下与与且业()
    {
        return (丙丟与丐三丐万万丆)this.丗下丘世三七一专丕;
    }
    internal void 丈且东丑丂且万丒丅(ProgressBarWithAnimation.丌一七丏不且且丟丙 丕丂业丈丗万丁丄丐, ProgressBarWithAnimation.丌一七丏不且且丟丙 三丟世丅丌丅业丟下, bool 业丅丆丘丕丄上不丂 = True)
    {
        this.丗下丘世三七一专丕 = 0;
        this.不丄丒上丙上世丙丘 = 0f;
        this.七世专且丕丗下丝上 = 0f;
        this.上丅丝丒丕丙七丛丒 = false;
        this.专丝丁专丐丝丌丑一 = false;
        this.丂丘丆一东东丝专专 = false;
        this.丌丅丐丘丐丁下丟上();
        this.丝七丁丘丆丈上下万 = 丕丂业丈丗万丁丄丐;
        this.丞与丟与七且丌丌丆 = 三丟世丅丌丅业丟下;
        this.丑丌丒丈与丟丕丌丈 = 业丅丆丘丕丄上不丂;
        if(三丟世丅丌丅业丟下 == null)
        {
                return;
        }
        
        丙丟与丐三丐万万丆 val_2 = this.丄丆专丁丕丆丐丝丝();
        this.丗下丘世三七一专丕 = val_2;
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        if(val_2 == 2)
        {
            goto label_2;
        }
        
        if(val_2 != 1)
        {
                return;
        }
        
        this.丌丅丐丘丐丁下丟上();
        return;
        label_1:
        this.丘丐丒丈丁丞丑世不();
        return;
        label_2:
        this.丝丐丅与丏丐丒丄业();
    }
    private ProgressBarWithAnimation.丙丟与丐三丐万万丆 丄丆专丁丕丆丐丝丝()
    {
        var val_1;
        if(this.丝七丁丘丆丈上下万.丙业与丙丗丝不丈东 == this.丞与丟与七且丌丌丆.丙业与丙丗丝不丈东)
        {
                if(this.丝七丁丘丆丈上下万.七丝东丛东丝且丆不 == this.丞与丟与七且丌丌丆.七丝东丛东丝且丆不)
        {
            goto label_5;
        }
        
        }
        
        if(this.丝七丁丘丆丈上下万.丙业与丙丗丝不丈东 == 1)
        {
            goto label_5;
        }
        
        if(this.丑丌丒丈与丟丕丌丈 == false)
        {
            goto label_6;
        }
        
        if(this.showIncrementAnimation == false)
        {
            goto label_10;
        }
        
        val_1 = 2;
        return (丙丟与丐三丐万万丆)val_1;
        label_5:
        val_1 = 1;
        return (丙丟与丐三丐万万丆)val_1;
        label_6:
        if(this.showDecrementAnimation != false)
        {
                val_1 = 3;
            return (丙丟与丐三丐万万丆)val_1;
        }
        
        label_10:
        val_1 = 4;
        return (丙丟与丐三丐万万丆)val_1;
    }
    private void 世与丕与丗专丒且丘()
    {
        丌一七丏不且且丟丙 val_4;
        if(this.丞与丟与七且丌丌丆 == null)
        {
                return;
        }
        
        if(this.showMaxValue != false)
        {
                string val_1 = System.String.Format(format:  "{0}/{1}", arg0:  this.丝七丁丘丆丈上下万.丙业与丙丗丝不丈东, arg1:  this.丝七丁丘丆丈上下万.七丝东丛东丝且丆不);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.countLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}", arg0:  this.丝七丁丘丆丈上下万.丙业与丙丗丝不丈东));
        val_4 = this.丝七丁丘丆丈上下万;
        if(this.丝七丁丘丆丈上下万 != null)
        {
            goto label_8;
        }
        
        val_4 = this.丝七丁丘丆丈上下万;
        if(val_4 == null)
        {
            goto label_9;
        }
        
        label_8:
        float val_3 = (float)this.丝七丁丘丆丈上下万.丙业与丙丗丝不丈东;
        val_3 = val_3 / (float)this.丝七丁丘丆丈上下万.七丝东丛东丝且丆不;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.currentFill, 丙业与丙丗丝不丈东:  val_3);
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.additionalFill, 丙业与丙丗丝不丈东:  0f);
        return;
        label_9:
    }
    private void 丌丅丐丘丐丁下丟上()
    {
        丌一七丏不且且丟丙 val_4;
        if(this.丞与丟与七且丌丌丆 == null)
        {
                return;
        }
        
        if(this.showMaxValue != false)
        {
                string val_1 = System.String.Format(format:  "{0}/{1}", arg0:  this.丞与丟与七且丌丌丆.丙业与丙丗丝不丈东, arg1:  this.丞与丟与七且丌丌丆.七丝东丛东丝且丆不);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.countLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}", arg0:  this.丞与丟与七且丌丌丆.丙业与丙丗丝不丈东));
        val_4 = this.丞与丟与七且丌丌丆;
        if(this.丞与丟与七且丌丌丆 != null)
        {
            goto label_7;
        }
        
        val_4 = this.丞与丟与七且丌丌丆;
        if(val_4 == null)
        {
            goto label_8;
        }
        
        label_7:
        float val_3 = (float)this.丞与丟与七且丌丌丆.丙业与丙丗丝不丈东;
        val_3 = val_3 / (float)this.丞与丟与七且丌丌丆.七丝东丛东丝且丆不;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.currentFill, 丙业与丙丗丝不丈东:  val_3);
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.additionalFill, 丙业与丙丗丝不丈东:  0f);
        return;
        label_8:
    }
    internal void 世丛丐丂不业七丝三()
    {
        this.丗下丘世三七一专丕 = 0;
        this.不丄丒上丙上世丙丘 = 0f;
        this.七世专且丕丗下丝上 = 0f;
        this.上丅丝丒丕丙七丛丒 = false;
        this.专丝丁专丐丝丌丑一 = false;
        this.丂丘丆一东东丝专专 = false;
        this.丌丅丐丘丐丁下丟上();
    }
    private void 丝丐丅与丏丐丒丄业()
    {
        丌一七丏不且且丟丙 val_3;
        float val_4;
        丌一七丏不且且丟丙 val_5;
        this.世与丕与丗专丒且丘();
        val_3 = this.丝七丁丘丆丈上下万;
        if(this.丝七丁丘丆丈上下万 != null)
        {
            goto label_1;
        }
        
        val_3 = this.丝七丁丘丆丈上下万;
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_1:
        float val_2 = (float)this.丝七丁丘丆丈上下万.丙业与丙丗丝不丈东;
        val_2 = val_2 / (float)this.丝七丁丘丆丈上下万.七丝东丛东丝且丆不;
        this.不丄丒上丙上世丙丘 = val_2;
        this.上丅丝丒丕丙七丛丒 = (this.丞与丟与七且丌丌丆.丙业与丙丗丝不丈东 < this.丝七丁丘丆丈上下万.丙业与丙丗丝不丈东) ? 1 : 0;
        if(this.丞与丟与七且丌丌丆.丙业与丙丗丝不丈东 >= this.丝七丁丘丆丈上下万.丙业与丙丗丝不丈东)
        {
            goto label_5;
        }
        
        val_4 = 1f;
        goto label_6;
        label_5:
        val_5 = this.丞与丟与七且丌丌丆;
        if(this.丞与丟与七且丌丌丆 != null)
        {
            goto label_7;
        }
        
        val_5 = this.丞与丟与七且丌丌丆;
        if(val_5 == null)
        {
            goto label_8;
        }
        
        label_7:
        val_4 = (float)this.丞与丟与七且丌丌丆.丙业与丙丗丝不丈东 / (float)this.丞与丟与七且丌丌丆.七丝东丛东丝且丆不;
        label_6:
        this.七世专且丕丗下丝上 = val_4;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.additionalFill, 丙业与丙丗丝不丈东:  val_4);
        return;
        label_8:
    }
    private void 丕且且三丐丒与丙七()
    {
        float val_18;
        bool val_19;
        string val_22;
        float val_23;
        丌一七丏不且且丟丙 val_24;
        if(this.专丝丁专丐丝丌丑一 != false)
        {
                if(this.上丅丝丒丕丙七丛丒 != false)
        {
                if(this.丂丘丆一东东丝专专 == false)
        {
            goto label_3;
        }
        
        }
        
            this.丗下丘世三七一专丕 = 0;
            this.不丄丒上丙上世丙丘 = 0f;
            this.七世专且丕丗下丝上 = 0f;
            this.上丅丝丒丕丙七丛丒 = false;
            this.专丝丁专丐丝丌丑一 = false;
            this.丂丘丆一东东丝专专 = false;
            this.丌丅丐丘丐丁下丟上();
            if(this.万万丗丛丏丐七丘丏 == null)
        {
                return;
        }
        
            this.万万丗丛丏丐七丘丏.Invoke();
            return;
        }
        
        val_18 = UnityEngine.Time.deltaTime;
        float val_3 = UnityEngine.Mathf.MoveTowards(current:  this.不丄丒上丙上世丙丘, target:  this.七世专且丕丗下丝上, maxDelta:  val_18 * this.animationSpeed);
        this.不丄丒上丙上世丙丘 = val_3;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.currentFill, 丙业与丙丗丝不丈东:  val_3);
        val_19 = this.showMaxValue;
        if(val_19 == false)
        {
            goto label_10;
        }
        
        float val_17 = (float)this.丝七丁丘丆丈上下万.七丝东丛东丝且丆不;
        val_17 = this.不丄丒上丙上世丙丘 * val_17;
        val_19 = 1152921504622075904;
        string val_5 = System.String.Format(format:  "{0}/{1}", arg0:  UnityEngine.Mathf.FloorToInt(f:  val_17), arg1:  this.丝七丁丘丆丈上下万.七丝东丛东丝且丆不);
        goto label_14;
        label_3:
        val_18 = UnityEngine.Time.deltaTime;
        float val_8 = UnityEngine.Mathf.MoveTowards(current:  this.不丄丒上丙上世丙丘, target:  this.七世专且丕丗下丝上, maxDelta:  val_18 * this.animationSpeed);
        this.不丄丒上丙上世丙丘 = val_8;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.currentFill, 丙业与丙丗丝不丈东:  val_8);
        val_19 = this.showMaxValue;
        if(val_19 == false)
        {
            goto label_20;
        }
        
        float val_18 = (float)this.丞与丟与七且丌丌丆.七丝东丛东丝且丆不;
        val_18 = this.不丄丒上丙上世丙丘 * val_18;
        val_19 = 1152921504622075904;
        string val_10 = System.String.Format(format:  "{0}/{1}", arg0:  UnityEngine.Mathf.FloorToInt(f:  val_18), arg1:  this.丞与丟与七且丌丌丆.七丝东丛东丝且丆不);
        goto label_24;
        label_10:
        float val_19 = (float)this.丝七丁丘丆丈上下万.七丝东丛东丝且丆不;
        val_19 = this.不丄丒上丙上世丙丘 * val_19;
        label_14:
        val_22 = System.String.Format(format:  "{0}", arg0:  UnityEngine.Mathf.FloorToInt(f:  val_19));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.countLabel, 丕丗丘丑丛与丑业丒:  val_22);
        val_23 = this.七世专且丕丗下丝上;
        if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  this.不丄丒上丙上世丙丘, 丒丈丙丐丏丕丆万丗:  val_23, 丌丕丗七丒丛万丒东:  0.001f)) == false)
        {
                return;
        }
        
        this.不丄丒上丙上世丙丘 = 0f;
        val_24 = this.丞与丟与七且丌丌丆;
        if(this.丞与丟与七且丌丌丆 != null)
        {
            goto label_32;
        }
        
        val_24 = this.丞与丟与七且丌丌丆;
        if(val_24 == null)
        {
            goto label_33;
        }
        
        label_32:
        val_23 = (float)this.丞与丟与七且丌丌丆.丙业与丙丗丝不丈东 / (float)this.丞与丟与七且丌丌丆.七丝东丛东丝且丆不;
        this.七世专且丕丗下丝上 = val_23;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.additionalFill, 丙业与丙丗丝不丈东:  val_23);
        this.专丝丁专丐丝丌丑一 = true;
        return;
        label_20:
        float val_20 = (float)this.丞与丟与七且丌丌丆.七丝东丛东丝且丆不;
        val_20 = this.不丄丒上丙上世丙丘 * val_20;
        label_24:
        val_22 = System.String.Format(format:  "{0}", arg0:  UnityEngine.Mathf.FloorToInt(f:  val_20));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.countLabel, 丕丗丘丑丛与丑业丒:  val_22);
        val_23 = this.七世专且丕丗下丝上;
        if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  this.不丄丒上丙上世丙丘, 丒丈丙丐丏丕丆万丗:  val_23, 丌丕丗七丒丛万丒东:  0.001f)) == false)
        {
                return;
        }
        
        this.丂丘丆一东东丝专专 = true;
        return;
        label_33:
    }
    private void 丘丐丒丈丁丞丑世不()
    {
        this.世与丕与丗专丒且丘();
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void ProgressBarWithAnimation::世丛丐丂不业七丝三()), 丆丐七丅丆丗丛上与:  0.5f);
    }
    private void 丁丛丟世丙与丆专丆()
    {
        if(this.万万丗丛丏丐七丘丏 == null)
        {
                return;
        }
        
        this.万万丗丛丏丐七丘丏.Invoke();
    }
    private void Update()
    {
        if(this.丗下丘世三七一专丕 != 3)
        {
                if(this.丗下丘世三七一专丕 != 2)
        {
                return;
        }
        
            this.丕且且三丐丒与丙七();
        }
        else
        {
                if(this.万万丗丛丏丐七丘丏 != null)
        {
                this.万万丗丛丏丐七丘丏.Invoke();
        }
        
        }
        
        丞东丑专丛丆丄丝世.丁下丏丙一丗下丈七(下丛丅丕业丁业丁东:  this.widgetLayouts);
    }
    public ProgressBarWithAnimation()
    {
        this.showIncrementAnimation = true;
        this.showDecrementAnimation = true;
        this.showMaxValue = true;
        this.animationSpeed = 1f;
    }

}
