using UnityEngine;
internal sealed class ArmRaceModeController : OnlineModeController
{
    // Fields
    internal ModeStartCondition startCondition;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    public ArmRaceLoadoutsController loadoutsController;
    
    // Methods
    public override void Initialize()
    {
        this.Initialize();
        this.loadoutsController = this.GetComponent<ArmRaceLoadoutsController>();
        this.startCondition.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ArmRaceModeController::下丙丒丘七丛且不丗()));
        this.专丁丈丛丂上丟上一 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
        this.丌业下与丗东丈丌丑 = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
        this.丗丏与丂世丝丐丁且 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
    }
    private void 下丙丒丘七丛且不丗()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                世丁与丕丗丟丒丆上 val_2 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_2.丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        }
        
        val_2.丒丆且丑业世丅三上();
        mem[1152921537515764328] = 1;
    }
    internal override void 丝丐不东一一丁丌七()
    {
        this.loadoutsController.下专丘丗丅丞丄世丏(丐三丞七丝丅不万丛:  this.loadoutsController.weaponId);
        this.丝丐不东一一丁丌七();
        TimeGameController.丄丞丁丈与业上丞丟.丞丞下丒丅丅丛世丕();
        this.丙丅与万丟世一丙丂(丙业与丙丗丝不丈东:  0);
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        if((X8 != 0) && ((X8 + 32) != 0))
        {
                X20.丒丆且丑业世丅三上();
            this.上不丒丄世丞丈丙三();
            return;
        }
        
        X20.ShowStartInterface();
        this.丒东丅下丒业丂丗丄(丙业与丙丗丝不丈东:  true);
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
        System.TimeSpan val_1 = X21.Elapsed;
        System.TimeSpan val_3 = X21.Elapsed;
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丈东丄丌丅丝不丂丘(丂丌丙丝且东丗丙万:  X21.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 与丛下丐丆丞万万下:  X23 + 118, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        }
        
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
    }
    public ArmRaceModeController()
    {
    
    }

}
