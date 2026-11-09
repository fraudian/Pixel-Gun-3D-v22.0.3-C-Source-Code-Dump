using UnityEngine;
public class DeathMatchController : OnlineModeController
{
    // Fields
    internal ModeStartCondition startCondition;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    
    // Methods
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        var val_6;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_7;
        if(this.startCondition != 0)
        {
                val_6 = null;
            val_6 = null;
            val_7 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_7 != null)
        {
                val_7 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_7 == null)
        {
                val_7 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_7.丌不丅不丞东万专专();
            if((val_2.HasValue.丙东专丂世丈丏丁丂() == 4) && (((-1501044760) & 1) != 0))
        {
                if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        }
        
        }
        
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
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
    private void 丘丁上且不丟丟三世()
    {
        ModeStartCondition val_14;
        var val_15;
        string val_16;
        val_14 = this.startCondition;
        if(val_14 != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_14 = 0;
        val_15 = 1;
        goto label_3;
        label_2:
        val_15 = 0;
        label_3:
        if(val_14.丟丛万丅业丛且不丂() == false)
        {
            goto label_4;
        }
        
        float val_3 = UnityEngine.Mathf.Max(a:  0f, b:  val_14.丝丒不万丑丙丏丆上());
        bool val_4 = val_14.丈丁丆丆丁一丅丝丒();
        if((val_3 >= 0) || (val_4 == false))
        {
            goto label_10;
        }
        
        val_16 = this.丗丏与丂世丝丐丁且;
        goto label_12;
        label_4:
        val_16 = this.专丁丈丛丂上丟上一;
        goto label_12;
        label_10:
        mem2[0] = this.丌业下与丗东丈丌丑;
        float val_5 = val_3 / 60f;
        mem2[0] = UnityEngine.Mathf.FloorToInt(f:  val_5);
        mem[4] = 268435463;
        var val_14 = 60;
        val_14 = (UnityEngine.Mathf.FloorToInt(f:  val_5)) * val_14;
        float val_15 = (float)val_14;
        val_15 = val_3 - val_15;
        mem2[0] = ((UnityEngine.Mathf.FloorToInt(f:  val_15)) < 10) ? "0" : "";
        var val_16 = 60;
        val_16 = (UnityEngine.Mathf.FloorToInt(f:  val_5)) * val_16;
        float val_17 = (float)val_16;
        val_17 = val_3 - val_17;
        mem2[0] = UnityEngine.Mathf.FloorToInt(f:  val_17);
        mem[4] = 268435463;
        val_16 = System.String.Format(format:  "{0} {1}:{2}{3}", args:  val_4);
        label_12:
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        text = val_16;
    }
    public override void Initialize()
    {
        this.专丁丈丛丂上丟上一 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
        this.丌业下与丗东丈丌丑 = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
        this.丗丏与丂世丝丐丁且 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
        this.Initialize();
        if(GameConnect.丕上丐丄三上丝专万() == false)
        {
                return;
        }
        
        this.startCondition.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DeathMatchController::下丙丒丘七丛且不丗()));
    }
    private void 下丙丒丘七丛且不丗()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                世丁与丕丗丟丒丆上 val_2 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_2.丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        }
        
        val_2.丒丆且丑业世丅三上();
        mem[1152921537466149432] = 1;
    }
    protected override void 丟不东丌丕不丐专业()
    {
        var val_4;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_5;
        this.丟不东丌丕不丐专业();
        if(this.startCondition == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_5.丌不丅不丞东万专专();
        if(val_2.HasValue.丙东专丂世丈丏丁丂() != 4)
        {
                return;
        }
        
        if(((-1500328024) & 1) == 0)
        {
                return;
        }
        
        this.丘丁上且不丟丟三世();
    }
    internal override void 丝丐不东一一丁丌七()
    {
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
    internal override bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        var val_8;
        double val_9;
        val_8 = null;
        val_8 = null;
        double val_4 = System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.专丝下世丄业丕丑七]);
        if(GameConnect.丕上丐丄三上丝专万() == false)
        {
            goto label_10;
        }
        
        val_9 = 60;
        if((System.Math.Abs(丏业丟一东丂东丘丛.timeEndMatch - val_4)) < val_9)
        {
            goto label_13;
        }
        
        return false;
        label_10:
        val_9 = val_4;
        if((丏业丟一东丂东丘丛.timeEndMatch & 1) == 0)
        {
                return false;
        }
        
        label_13:
        double val_7 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(val_4 < 0)
        {
                return false;
        }
        
        return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    internal override void 下丕丂业业丐丗与丁(丕丁丕上与丅不丙丄 与丆丌丂丟丛丘丑且)
    {
        this.下丕丂业业丐丗与丁(与丆丌丂丟丛丘丑且:  与丆丌丂丟丛丘丑且);
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        System.TimeSpan val_1 = X21.Elapsed;
        System.TimeSpan val_3 = X21.Elapsed;
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丈东丄丌丅丝不丂丘(丂丌丙丝且东丗丙万:  X21.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 与丛下丐丆丞万万下:  X23 + 118, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
    }
    public DeathMatchController()
    {
    
    }

}
