using UnityEngine;
internal sealed class MutationModeController : OnlineModeController
{
    // Fields
    internal ModeStartCondition startCondition;
    
    // Methods
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        var val_2;
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        val_2 = null;
        val_2 = null;
        MutationController.丆丕丝丒不丙且丐丗.东一丟丌丏且一丞丌(丝丝不丝上丂三丌世:  0.世业丗丄丁丝丒一丁());
    }
    public override void Initialize()
    {
        this.Initialize();
        this.startCondition.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationModeController::下丙丒丘七丛且不丗()));
    }
    internal void 丌不丂且丁丙丝万丄()
    {
        X20.丒丆且丑业世丅三上();
        mem[1152921537641313192] = 1;
    }
    private void 下丙丒丘七丛且不丗()
    {
        var val_3;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙专丅业东业东丟与(丙业与丙丗丝不丈东:  false);
        val_3 = null;
        val_3 = null;
        MutationController.丆丕丝丒不丙且丐丗.且丒世万东丒丕丗万();
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
    internal override bool 世七丌丟丞且丛七且()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        if(MutationController.丆丕丝丒不丙且丐丗.mutationStartTimer >= 0f)
        {
            goto label_4;
        }
        
        val_8 = null;
        val_8 = null;
        if((0.世业丗丄丁丝丒一丁() & 255) != 2)
        {
            goto label_8;
        }
        
        val_9 = 1;
        return (bool)((0.世业丗丄丁丝丒一丁() & 255) == 3) ? 1 : 0;
        label_4:
        val_9 = 0;
        return (bool)((0.世业丗丄丁丝丒一丁() & 255) == 3) ? 1 : 0;
        label_8:
        val_10 = null;
        val_10 = null;
        return (bool)((0.世业丗丄丁丝丒一丁() & 255) == 3) ? 1 : 0;
    }
    internal override void 丕且丅丞世三不七万()
    {
        var val_3;
        var val_4;
        this.丕且丅丞世三不七万();
        val_3 = null;
        val_3 = null;
        if((0.世业丗丄丁丝丒一丁() & 255) != 3)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        0.业丆业且丁丒丁丈丈(不丄丈丞丟丟且万东:  true);
    }
    private void 丘丁上且不丟丟三世()
    {
        ModeStartCondition val_18;
        var val_19;
        val_18 = this.startCondition;
        if(val_18 != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_18 = 0;
        val_19 = 1;
        goto label_3;
        label_2:
        val_19 = 0;
        label_3:
        if(val_18.丟丛万丅业丛且不丂() == false)
        {
            goto label_4;
        }
        
        float val_3 = UnityEngine.Mathf.Max(a:  0f, b:  val_18.丝丒不万丑丙丏丆上());
        if((val_3 >= 0) || (val_18.丈丁丆丆丁一丅丝丒() == false))
        {
            goto label_10;
        }
        
        string val_5 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
        goto label_16;
        label_4:
        string val_6 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
        goto label_16;
        label_10:
        object[] val_7 = new object[4];
        val_7[0] = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
        float val_9 = val_3 / 60f;
        val_7[1] = UnityEngine.Mathf.FloorToInt(f:  val_9);
        var val_18 = 60;
        val_18 = (UnityEngine.Mathf.FloorToInt(f:  val_9)) * val_18;
        float val_19 = (float)val_18;
        val_19 = val_3 - val_19;
        val_7[2] = ((UnityEngine.Mathf.FloorToInt(f:  val_19)) < 10) ? "0" : "";
        var val_20 = 60;
        val_20 = (UnityEngine.Mathf.FloorToInt(f:  val_9)) * val_20;
        float val_21 = (float)val_20;
        val_21 = val_3 - val_21;
        val_7[3] = UnityEngine.Mathf.FloorToInt(f:  val_21);
        label_16:
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        text = System.String.Format(format:  "{0} {1}:{2}{3}", args:  val_7);
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
        this.丘丁上且不丟丟三世();
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        System.TimeSpan val_1 = X21.Elapsed;
        System.TimeSpan val_3 = X21.Elapsed;
        if(X24 != 0)
        {
                var val_8 = ((X24 + 118) != 0) ? 1 : 0;
            return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丗丟不丒上业丐丌三(丂丌丙丝且东丗丙万:  X21.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 与丛下丐丆丞万万下:  ((X24 + 118) != 0) ? 1 : 0, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds, 万业丌丏丟丂丘丝且:  X24.且世专不丄丏七下万());
        }
        
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丗丟不丒上业丐丌三(丂丌丙丝且东丗丙万:  X21.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 与丛下丐丆丞万万下:  ((X24 + 118) != 0) ? 1 : 0, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds, 万业丌丏丟丂丘丝且:  X24.且世专不丄丏七下万());
    }
    internal override void 下丕丂业业丐丗与丁(丕丁丕上与丅不丙丄 与丆丌丂丟丛丘丑且)
    {
        this.下丕丂业业丐丗与丁(与丆丌丂丟丛丘丑且:  与丆丌丂丟丛丘丑且);
        if(与丆丌丂丟丛丘丑且.isModeRole == true)
        {
                return;
        }
        
        if((this.丈丌丐丅一一且丏丛() & 255) == 1)
        {
                return;
        }
        
        与丆丌丂丟丛丘丑且.isModeRole = true;
    }
    public MutationModeController()
    {
    
    }

}
