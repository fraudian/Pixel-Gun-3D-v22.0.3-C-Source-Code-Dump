using UnityEngine;
internal sealed class PlantTheBombModeController : OnlineModeController
{
    // Fields
    internal ModeStartCondition startCondition;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    internal System.Action 丌一丐且下世下三上;
    private bool 一东下万丝不下丝丐;
    
    // Methods
    internal override void 丝丐不东一一丁丌七()
    {
        this.丝丐不东一一丁丌七();
        this.丐丛丕且东下上丐业();
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        if(丂丘下万丈丘丅一丄 != false)
        {
                this.世丗丅丆丈丟丒丁世();
        }
        
        PlantTheBombController.丆丕丝丒不丙且丐丗.东一丟丌丏且一丞丌(丝丝不丝上丂三丌世:  0.三丘三丈上丕丆丂一());
    }
    public override void Initialize()
    {
        this.专丁丈丛丂上丟上一 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
        this.丌业下与丗东丈丌丑 = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
        this.丗丏与丂世丝丐丁且 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
        this.Initialize();
        this.startCondition.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlantTheBombModeController::下丙丒丘七丛且不丗()));
    }
    private void 下丙丒丘七丛且不丗()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        PlantTheBombController.丆丕丝丒不丙且丐丗.丕丞丁丐丌世世丞丈();
    }
    public void StartActions()
    {
        X20.丒丆且丑业世丅三上();
        mem[1152921537517413928] = 1;
    }
    public void DestroyMyPlayer()
    {
        X19.丟丙不上丝丂丄丗三();
    }
    public void StartNewRound()
    {
        this.DestroyMyPlayer();
        mem[1152921537517642024] = 1;
        mem[1152921537517642028] = UnityEngine.Time.frameCount;
        if(this.丌一丐且下世下三上 == null)
        {
                return;
        }
        
        this.丌一丐且下世下三上.Invoke();
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
        this.丘丁上且不丟丟三世();
    }
    private void 丘丁上且不丟丟三世()
    {
        ModeStartCondition val_15;
        var val_16;
        string val_17;
        val_15 = this.startCondition;
        if(val_15 != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_15 = 0;
        val_16 = 1;
        goto label_3;
        label_2:
        val_16 = 0;
        label_3:
        if(val_15.丟丛万丅业丛且不丂() == false)
        {
            goto label_4;
        }
        
        float val_3 = UnityEngine.Mathf.Max(a:  0f, b:  val_15.丝丒不万丑丙丏丆上());
        if((val_3 >= 0) || (val_15.丈丁丆丆丁一丅丝丒() == false))
        {
            goto label_10;
        }
        
        val_17 = this.丗丏与丂世丝丐丁且;
        goto label_12;
        label_4:
        val_17 = this.专丁丈丛丂上丟上一;
        goto label_12;
        label_10:
        object[] val_5 = new object[4];
        val_5[0] = this.丌业下与丗东丈丌丑;
        float val_6 = val_3 / 60f;
        val_5[1] = UnityEngine.Mathf.FloorToInt(f:  val_6);
        var val_15 = 60;
        val_15 = (UnityEngine.Mathf.FloorToInt(f:  val_6)) * val_15;
        float val_16 = (float)val_15;
        val_16 = val_3 - val_16;
        val_5[2] = ((UnityEngine.Mathf.FloorToInt(f:  val_16)) < 10) ? "0" : "";
        var val_17 = 60;
        val_17 = (UnityEngine.Mathf.FloorToInt(f:  val_6)) * val_17;
        float val_18 = (float)val_17;
        val_18 = val_3 - val_18;
        val_5[3] = UnityEngine.Mathf.FloorToInt(f:  val_18);
        val_17 = System.String.Format(format:  "{0} {1}:{2}{3}", args:  val_5);
        label_12:
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        text = val_17;
    }
    internal override bool 丄一下丒七丝与与万()
    {
        var val_5;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().业丆丛丁丈丌丘丛丅() ^ 1;
            return (bool)val_5 & 1;
        }
        
        val_5 = 0;
        return (bool)val_5 & 1;
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        var val_10;
        System.TimeSpan val_1 = Elapsed;
        System.TimeSpan val_3 = Elapsed;
        val_10 = null;
        val_10 = null;
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丞丟丂东丑三丂丄丝(丂丌丙丝且东丗丙万:  丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 丁丞丗业丆丒上丈丞:  X23.丘丑丅三丆丑丌且丝(), 东丙丂丌丒丏丅丄丕:  TeamController.__il2cppRuntimeField_element_class, 丘丁七丁不丙不丟上:  typeof(TeamController).__il2cppRuntimeField_44, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
    }
    internal override bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        PlantTheBombController val_3;
        UnityEngine.Object val_4;
        val_3 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        val_4 = val_3;
        if(val_4 == 0)
        {
                return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
        }
        
        if(丏业丟一东丂东丘丛 == null)
        {
                val_4 = 0;
        }
        
        val_3 = 丏业丟一东丂东丘丛.rounds;
        if(PlantTheBombController.丆丕丝丒不丙且丐丗 == null)
        {
                val_4 = 0;
        }
        
        if(val_3 == val_4.丁丝三丝一丂丕丑一())
        {
                return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
        }
        
        丏业丟一东丂东丘丛.isDead = true;
        丏业丟一东丂东丘丛.playerHealth = 0f;
        return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    internal override void 丕且丅丞世三不七万()
    {
        this.丕且丅丞世三不七万();
        if(0.三丘三丈上丕丆丂一() == 2)
        {
                this.丝丁丄与丟丗世丈不();
            return;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.世丄东丄丕七丟不丗 == false)
        {
                return;
        }
        
        this.DestroyMyPlayer();
        this.丏丛丈东丘丏丏下丁();
        this.一东下万丝不下丝丐 = true;
    }
    internal void 丝丁丄与丟丗世丈不()
    {
        this.DestroyMyPlayer();
        if(static_value_082C8000 == 0)
        {
                return;
        }
        
        this.SetActive(value:  true);
    }
    internal void 与且丕丑丐丁丒世丟()
    {
        if(static_value_082C8000 == 0)
        {
                return;
        }
        
        this.SetActive(value:  false);
    }
    internal void 丆丄上丛丝东丅专东()
    {
        this.DestroyMyPlayer();
        this.丏丛丈东丘丏丏下丁();
        this.一东下万丝不下丝丐 = true;
    }
    internal void 三丒丕七丒丞丕专业()
    {
        this.与且丕丑丐丁丒世丟();
        if(this.一东下万丝不下丝丐 == false)
        {
                return;
        }
        
        X20.丐丅丑丞丆丝上丈丝();
        this.一丞丄丗世丟业丌万();
        this.一东下万丝不下丝丐 = false;
    }
    internal void 丏丛丈东丘丏丏下丁()
    {
        if(static_value_082C8000 == 0)
        {
                return;
        }
        
        丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  0);
        mem[137134280].SetActive(value:  false);
        mem[137134280].丆丄上丛丝东丅专东();
        this.SetActive(value:  true);
    }
    internal void 一丞丄丗世丟业丌万()
    {
        if(static_value_082C8000 == 0)
        {
                return;
        }
        
        mem[137134232].SetActive(value:  false);
        mem[137134232].业七万七专丄丑万丘();
        this.SetActive(value:  false);
    }
    public PlantTheBombModeController()
    {
    
    }

}
