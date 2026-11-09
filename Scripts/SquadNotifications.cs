using UnityEngine;
internal sealed class SquadNotifications : PGBehaviour
{
    // Fields
    private string 下与丟世丒丕丁丞且;
    private string 东丝七丟专万丒东丌;
    private string 上丗万丛三与且上丙;
    private string 丙丘丐丗丅东一丛且;
    private string 下丅丗不东丑专丒万;
    private string 丂上七丁三与丄丘丈;
    private string 一东丆丏丙世丝丛丏;
    private string 丞丞一不丏丒世丈丐;
    private string 丛丑丘丐万丘丆上丝;
    private string 上丈下丕丞丁万丙丟;
    private string 丙丘丙丂丛丑且丝丂;
    private string 丙丄业丄三丝丟丐下;
    private string 丄业丏丗丟万世一世;
    private string 丗三世丆丄丌上丈丅;
    private string 丁业三丑丘丏丁丂丞;
    private string 七丗世丈专丈丕与丑;
    private string 丂上且丝丝世丅丝丗;
    private UnityEngine.GameObject infoMessageContainer;
    private UnityEngine.GameObject questionMessageContainer;
    private UILabel infoLabel;
    private UILabel questionLabel;
    private UILabel greenButtonLabel;
    private UILabel greyButtonLabel;
    private UILabel redButtonLabel;
    private UnityEngine.GameObject greenButton;
    private UnityEngine.GameObject greyButton;
    private UnityEngine.GameObject redButton;
    private UnityEngine.GameObject progressContainer;
    private UISprite progressFill;
    private DisableObjectFromTimer 丞丅丁丅丕丅丒东丗;
    private const float 业丐丌一丕东丝丕丗 = 3;
    private float 丙一丑丏丁一且丒业;
    private float 与丈业丛丝丒丙一丏;
    private System.Action<System.Nullable<bool>> 世业丛上丗万丝丌专;
    private bool 万专丐七丑丏丒丗七;
    private bool 业上一与专七七东丏;
    private bool 丒不丘丕业与丌不万;
    private bool 丑上丑专丆专与丘丄;
    
    // Properties
    internal bool 下丄丕丗一丞丒丘东 { get; }
    
    // Methods
    internal bool 下丄业丆丟丌丘丆丂()
    {
        if(this.questionMessageContainer != null)
        {
                return this.questionMessageContainer.activeSelf;
        }
        
        return this.questionMessageContainer.activeSelf;
    }
    internal bool 丏丏专丗丐丒一丆丌()
    {
        return (bool)this.丑上丑专丆专与丘丄;
    }
    private void 不丒与下上丁不丒丐(float 丙业与丙丗丝不丈东)
    {
        DisableObjectFromTimer val_4;
        DisableObjectFromTimer val_5;
        val_4 = this;
        if(this.丞丅丁丅丕丅丒东丗 == 0)
        {
                val_5 = this.GetComponent<DisableObjectFromTimer>();
            this.丞丅丁丅丕丅丒东丗 = val_5;
        }
        else
        {
                val_5 = this.丞丅丁丅丕丅丒东丗;
        }
        
        if(val_5 == 0)
        {
                return;
        }
        
        val_4 = this.丞丅丁丅丕丅丒东丗;
        this.丞丅丁丅丕丅丒东丗.timer = 丙业与丙丗丝不丈东;
    }
    private void 丒万业丛丏东专世丟(System.Nullable<bool> 丙业与丙丗丝不丈东)
    {
        this.世业丛上丗万丝丌专 = 0;
        this.丑上丑专丆专与丘丄 = false;
        if(this.世业丛上丗万丝丌专 == null)
        {
                return;
        }
        
        丙业与丙丗丝不丈东.HasValue = 丙业与丙丗丝不丈东.HasValue & 65535;
        this.世业丛上丗万丝丌专.Invoke(obj:  new System.Nullable<System.Boolean>() {HasValue = 丙业与丙丗丝不丈东.HasValue});
    }
    internal void 业丌丐丄丒丌丘丛丗()
    {
        this.丈丈丞丅一丅丗丁丅();
        if(this.infoLabel == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.下与丟世丒丕丁丞且));
    }
    internal void 丝丏三与丐业丌丂万()
    {
        this.丈丈丞丅一丅丗丁丅();
        if(this.infoLabel == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.一东丆丏丙世丝丛丏));
    }
    internal void 世东一丆与丘丞上丝()
    {
        this.丈丈丞丅一丅丗丁丅();
        if(this.infoLabel == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丙丘丐丗丅东一丛且));
    }
    internal void 丏且丑丁丟七丝丆且()
    {
        this.丈丈丞丅一丅丗丁丅();
        if(this.infoLabel == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丙丘丙丂丛丑且丝丂));
    }
    internal void 丑三一丒丛丑上丄万(string 丒丘丏上丙丟丑丕丈)
    {
        this.丈丈丞丅一丅丗丁丅();
        if(this.infoLabel == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.下丅丗不东丑专丒万), arg0:  丒丘丏上丙丟丑丕丈));
    }
    internal void 丟万丟丌一丁专丏丏(string 丒丘丏上丙丟丑丕丈)
    {
        this.丈丈丞丅一丅丗丁丅();
        if(this.infoLabel == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丂上七丁三与丄丘丈), arg0:  丒丘丏上丙丟丑丕丈));
    }
    internal void 七上丂丞上丝丈业万(string 丒丘丏上丙丟丑丕丈)
    {
        this.丈丈丞丅一丅丗丁丅();
        if(this.infoLabel == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.上丗万丛三与且上丙), arg0:  丒丘丏上丙丟丑丕丈));
    }
    internal void 下丆与七丌丕丂丂上(string 丒丘丏上丙丟丑丕丈)
    {
        this.丈丈丞丅一丅丗丁丅();
        if(this.infoLabel == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.上丈下丕丞丁万丙丟), arg0:  丒丘丏上丙丟丑丕丈));
    }
    internal void 与丂丏七丝三三丑丂(System.Action<System.Nullable<bool>> 业丏丈世世世丞丒世)
    {
        this.丅七丏丈业丘专丗万(三丕与专丌丁丛东上:  false, 丞上丞丁丂丗丆上东:  true, 与丁丑与东丑东三业:  true, 丑丄一丝世业专丛不:  -1f);
        this.世业丛上丗万丝丌专 = 业丏丈世世世丞丒世;
        if(this.questionLabel != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.questionLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丛丑丘丐万丘丆上丝));
        }
        
        if(this.greyButtonLabel != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.greyButtonLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.七丗世丈专丈丕与丑));
        }
        
        if(this.redButtonLabel != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.redButtonLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丂上且丝丝世丅丝丗));
        }
        
        this.万专丐七丑丏丒丗七 = true;
        this.业上一与专七七东丏 = false;
    }
    internal void 丟丐丌一丕不与一且(System.Action<System.Nullable<bool>> 业丏丈世世世丞丒世, string 三世东丅丂东丒丁丘)
    {
        UILabel val_5;
        this.丅七丏丈业丘专丗万(三丕与专丌丁丛东上:  true, 丞上丞丁丂丗丆上东:  true, 与丁丑与东丑东三业:  false, 丑丄一丝世业专丛不:  -1f);
        val_5 = this.questionLabel;
        this.世业丛上丗万丝丌专 = 业丏丈世世世丞丒世;
        if(val_5 != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_5, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.东丝七丟专万丒东丌), arg0:  三世东丅丂东丒丁丘));
        }
        
        if(this.greenButtonLabel != null)
        {
                val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丗三世丆丄丌上丈丅);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.greenButtonLabel, 丕丗丘丑丛与丑业丒:  val_5);
        }
        
        if(this.redButtonLabel != null)
        {
                val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丁业三丑丘丏丁丂丞);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.redButtonLabel, 丕丗丘丑丛与丑业丒:  val_5);
        }
        
        this.万专丐七丑丏丒丗七 = false;
        this.丒不丘丕业与丌不万 = true;
        this.丑上丑专丆专与丘丄 = true;
    }
    internal void 东丞专丗不丏丏一丞(System.Action<System.Nullable<bool>> 业丏丈世世世丞丒世, string 丒与不丑丅丄一东丈)
    {
        UILabel val_5;
        this.丅七丏丈业丘专丗万(三丕与专丌丁丛东上:  true, 丞上丞丁丂丗丆上东:  true, 与丁丑与东丑东三业:  false, 丑丄一丝世业专丛不:  10f);
        val_5 = this.questionLabel;
        this.世业丛上丗万丝丌专 = 业丏丈世世世丞丒世;
        if(val_5 != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_5, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丞丞一不丏丒世丈丐), arg0:  丒与不丑丅丄一东丈));
        }
        
        if(this.greenButtonLabel != null)
        {
                val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丙丄业丄三丝丟丐下);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.greenButtonLabel, 丕丗丘丑丛与丑业丒:  val_5);
        }
        
        if(this.redButtonLabel != null)
        {
                val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丄业丏丗丟万世一世);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.redButtonLabel, 丕丗丘丑丛与丑业丒:  val_5);
        }
        
        this.丒不丘丕业与丌不万 = true;
        this.万专丐七丑丏丒丗七 = false;
    }
    private void 丈丈丞丅一丅丗丁丅()
    {
        this.不丒与下上丁不丒丐(丙业与丙丗丝不丈东:  3f);
        this.gameObject.SetActive(value:  true);
        this.infoMessageContainer.SetActive(value:  true);
        this.questionMessageContainer.SetActive(value:  false);
        this.丒万业丛丏东专世丟(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
    }
    private void 丅七丏丈业丘专丗万(bool 三丕与专丌丁丛东上, bool 丞上丞丁丂丗丆上东, bool 与丁丑与东丑东三业, float 丑丄一丝世业专丛不 = -1)
    {
        this.不丒与下上丁不丒丐(丙业与丙丗丝不丈东:  -1f);
        this.gameObject.SetActive(value:  true);
        this.infoMessageContainer.SetActive(value:  false);
        this.questionMessageContainer.SetActive(value:  true);
        this.progressContainer.SetActive(value:  (丑丄一丝世业专丛不 >= 0f) ? 1 : 0);
        this.丙一丑丏丁一且丒业 = 丑丄一丝世业专丛不;
        if(丑丄一丝世业专丛不 > 0f)
        {
                this.progressFill.fillAmount = 1f;
            this.与丈业丛丝丒丙一丏 = this.丙一丑丏丁一且丒业;
        }
        
        this.redButton.SetActive(value:  丞上丞丁丂丗丆上东);
        this.greenButton.SetActive(value:  三丕与专丌丁丛东上);
        this.greyButton.SetActive(value:  与丁丑与东丑东三业);
        this.丒万业丛丏东专世丟(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
    }
    private void Update()
    {
        float val_3 = this.丙一丑丏丁一且丒业;
        if(val_3 < 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_3 = val_3 - val_1;
        this.丙一丑丏丁一且丒业 = val_3;
        if(val_3 < 0)
        {
                this.gameObject.SetActive(value:  false);
            this.丒万业丛丏东专世丟(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
            return;
        }
        
        val_1 = val_3 / this.与丈业丛丝丒丙一丏;
        this.progressFill.fillAmount = val_1;
    }
    public void OnGreenButtonClick()
    {
        this.gameObject.SetActive(value:  false);
        this.丒万业丛丏东专世丟(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
    }
    public void OnGreyButtonClick()
    {
        this.gameObject.SetActive(value:  false);
        this.丒万业丛丏东专世丟(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
    }
    public void OnRedButtonClick()
    {
        this.gameObject.SetActive(value:  false);
        this.丒万业丛丏东专世丟(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
    }
    public SquadNotifications()
    {
        this.下与丟世丒丕丁丞且 = "Key_10510";
        this.东丝七丟专万丒东丌 = "Key_10511";
        this.上丗万丛三与且上丙 = "Key_10512";
        this.丙丘丐丗丅东一丛且 = "Key_10513";
        this.下丅丗不东丑专丒万 = "Key_10514";
        this.丂上七丁三与丄丘丈 = "Key_10515";
        this.一东丆丏丙世丝丛丏 = "Key_10516";
        this.丞丞一不丏丒世丈丐 = "Key_10517";
        this.丛丑丘丐万丘丆上丝 = "Key_10518";
        this.上丈下丕丞丁万丙丟 = "Key_10519";
        this.丙丘丙丂丛丑且丝丂 = "Key_10529";
        this.丙丄业丄三丝丟丐下 = "Key_3626";
        this.丄业丏丗丟万世一世 = "Key_6461";
        this.丗三世丆丄丌上丈丅 = "Key_0167";
        this.丁业三丑丘丏丁丂丞 = "Key_0168";
        this.七丗世丈专丈丕与丑 = "Key_7407";
        this.丂上且丝丝世丅丝丗 = "Key_5208";
        this.丙一丑丏丁一且丒业 = -1f;
    }

}
