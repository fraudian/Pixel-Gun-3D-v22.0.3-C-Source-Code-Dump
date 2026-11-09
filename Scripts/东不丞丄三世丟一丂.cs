using UnityEngine;
internal sealed class 东不丞丄三世丟一丂
{
    // Fields
    private 东不丞丄三世丟一丂.丞丝丙业东丐万丟丕 <丛丐与丕丑丝下丑业>k__BackingField;
    private static 东不丞丄三世丟一丂 丝业丆丁业三丈丟东;
    
    // Properties
    public static 东不丞丄三世丟一丂 丆丕丝丒不丙且丐丗 { get; }
    internal 东不丞丄三世丟一丂.丞丝丙业东丐万丟丕 万丏丏丞丕丅丑丄丅 { get; set; }
    
    // Methods
    public static 东不丞丄三世丟一丂 丑七不且上丗丁一世()
    {
        东不丞丄三世丟一丂 val_2;
        东不丞丄三世丟一丂 val_3 = 东不丞丄三世丟一丂.丝业丆丁业三丈丟东;
        if(val_3 != null)
        {
                return val_3;
        }
        
        东不丞丄三世丟一丂 val_1 = null;
        val_2 = val_1;
        val_1 = new 东不丞丄三世丟一丂();
        东不丞丄三世丟一丂.丝业丆丁业三丈丟东 = val_2;
        val_3 = 东不丞丄三世丟一丂.丝业丆丁业三丈丟东;
        return val_3;
    }
    internal 东不丞丄三世丟一丂()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void 东不丞丄三世丟一丂::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 且丆丏丛东下上丄丟)));
        PGCompany.UnequipClanArmorBanner.丑丗专丄丄丁丆丝丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 东不丞丄三世丟一丂::丂与丟且专万世丐专()));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 东不丞丄三世丟一丂::丝丁丒丈丌丛不丒下()));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 东不丞丄三世丟一丂::丝丁丒丈丌丛不丒下()));
    }
    private void 东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 且丆丏丛东下上丄丟)
    {
        if((System.String.op_Inequality(a:  丏丈丗世丙万丆丐丅.m_Handle.name, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return;
        }
        
        this.<丛丐与丕丑丝下丑业>k__BackingField = 0;
        this.丝丁丒丈丌丛不丒下();
    }
    private void 丝丁丒丈丌丛不丒下()
    {
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_3.m_Handle.name, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        string val_7 = 丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7);
        if((System.String.op_Equality(a:  val_7, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) == true)
        {
                return;
        }
        
        int val_10 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  val_7);
        if((BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  val_10)) == false)
        {
                return;
        }
        
        1152921505171275776 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(1152921505171275776 != null)
        {
                一一万丒与专丙丁丛 val_14 = BalanceController.不丝丁万丁丁三专且(丞世不丒下上上丝丑:  val_10);
            if(1152921505171275776.世丝丌一且丝专丑丛() >= val_14)
        {
                return;
        }
        
            this.丐丝丒一丛业七丛丙(不丘丐三丙丏上上丌:  1152921505171275776.世丝丌一且丝专丑丛(), 专丘且丆丝丗丐丁丌:  val_10, 丗丛世世丙丝丌与丑:  val_14);
            return;
        }
        
        this.丐丝丒一丛业七丛丙(不丘丐三丙丏上上丌:  0, 专丘且丆丝丗丐丁丌:  val_10, 丗丛世世丙丝丌与丑:  0);
    }
    private void 丂与丟且专万世丐专()
    {
        this.<丛丐与丕丑丝下丑业>k__BackingField = 0;
    }
    internal 东不丞丄三世丟一丂.丞丝丙业东丐万丟丕 专丑丑丙业下丑且下()
    {
        return (丞丝丙业东丐万丟丕)this.<丛丐与丕丑丝下丑业>k__BackingField;
    }
    internal void 不东丒丆丆一丛丛丙(东不丞丄三世丟一丂.丞丝丙业东丐万丟丕 丙业与丙丗丝不丈东)
    {
        this.<丛丐与丕丑丝下丑业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 丐丝丒一丛业七丛丙(一一万丒与专丙丁丛 不丘丐三丙丏上上丌, int 专丘且丆丝丗丐丁丌, 一一万丒与专丙丁丛 丗丛世世丙丝丌与丑)
    {
        var val_16;
        var val_17;
        var val_18;
        System.Collections.Generic.List<下丘丙丛上丄丆三丑> val_2 = 七丌丞万七万丁丐丙.上与下东丑七丄专丌().Item[7];
        val_16 = 0;
        val_17 = 0;
        val_18 = 0;
        goto label_4;
        label_21:
        下丘丙丛上丄丆三丑 val_3 = val_2.Item[0];
        int val_5 = val_3.丈与丅丄丁丙三专丞.Item[0].业东丅东丌上丗丑不();
        int val_7 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_5);
        if(val_7 > val_17)
        {
                if((BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  val_5)) != false)
        {
                if((BalanceController.不丝丁万丁丁三专且(丞世不丒下上上丝丑:  val_5)) > 不丘丐三丙丏上上丌)
        {
            goto label_18;
        }
        
        }
        
            val_18 = val_2.Item[0];
            val_17 = val_7;
        }
        
        label_18:
        val_16 = 1;
        label_4:
        if(val_16 < val_2.Count)
        {
            goto label_21;
        }
        
        if(val_18 == null)
        {
                return;
        }
        
        丝丏东万丄世丆丛丛 val_12 = val_10.丈与丅丄丁丙三专丞.Item[0];
        丆丟七丌丞东丆丕丌.丄东世丌专下丈丑丙(丒东业不丐丑丕丄丆:  val_12.下丄丈不与世丐业专, 丙丑丕丂下丏一丁专:  7, 丆万丐丗丅丘丆丁丌:  false);
        .不上丛丁三与上专与 = 专丘且丆丝丗丐丁丌;
        .与不丁丂丙七丏丌七 = val_10.丈与丅丄丁丙三专丞.Item[0].业东丅东丌上丗丑不();
        .丒丙下丂丕丞万万丕 = 丗丛世世丙丝丌与丑;
        .专专丐丏万丄上丆丌 = 不丘丐三丙丏上上丌;
        mem[1152921536775364736] = new 东不丞丄三世丟一丂.丞丝丙业东丐万丟丕();
    }

}
