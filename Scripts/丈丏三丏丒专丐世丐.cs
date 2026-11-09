using UnityEngine;
internal sealed class 丈丏三丏丒专丐世丐
{
    // Fields
    private Rilisoft.七丕丟丏三丈一丄世 一丗丟丛丈专丙三丌;
    private int 一丘东丌丑且丏一丙;
    private string 世丁与丕丗丟丒丆上;
    private int 丐丙丞丅不丙丂丟丐;
    private System.Action 万丈三丑丐丘丐丟七;
    private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丈丝丂丐丟万丙丑丕;
    internal System.Action 世专丂丑丟丁业与丄;
    private 丈丏三丏丒专丐世丐.丝丟万丞不丒业丙与 世东丛一且且丐丒丂;
    
    // Methods
    internal void 丈丕丄丅丛丐三一东()
    {
        var val_6;
        System.Action val_7;
        var val_8;
        var val_9;
        System.Action val_10;
        val_6 = null;
        val_6 = null;
        val_8 = null;
        val_9 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  System.Void 丈丏三丏丒专丐世丐::丏丛丄万下业一七专()))) != null) && (null != val_9))
        {
                val_8 = null;
            val_9 = null;
            val_7 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_7;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void 丈丏三丏丒专丐世丐::不且不丛专丏丂七丁()))) != null) && (null != null))
        {
                val_10 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_10;
    }
    internal void 三丞丐丐丆下且丐丑(七丆丐丕一丐丅丆丞 七丁丑丗丐专丌丝丗)
    {
        if(七丁丑丗丐专丌丝丗 != null)
        {
                this.一丗丟丛丈专丙三丌 = 七丁丑丗丐专丌丝丗.丘丛丆丕且丂业世丌();
            this.一丘东丌丑且丏一丙 = 七丁丑丗丐专丌丝丗.丕丆丞丂业东与上丅();
            this.世丁与丕丗丟丒丆上 = 七丁丑丗丐专丌丝丗.且丁丙丑丄丁丄与丑();
        }
        else
        {
                this.一丗丟丛丈专丙三丌 = 0.丘丛丆丕且丂业世丌();
            this.一丘东丌丑且丏一丙 = 0.丕丆丞丂业东与上丅();
            this.世丁与丕丗丟丒丆上 = 0.且丁丙丑丄丁丄与丑();
        }
        
        this.丐丙丞丅不丙丂丟丐 = 七丁丑丗丐专丌丝丗.上丐丛七丌丝丐丄丟();
    }
    internal void 三丞丐丐丆下且丐丑(丈且且世丏丟丅丒业 七丁丑丗丐专丌丝丗)
    {
        与丟丆一七丛丆且丟 val_5;
        if(七丁丑丗丐专丌丝丗.丈丏业一不下与丄万 == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.一丗丟丛丈专丙三丌 = 七丁丑丗丐专丌丝丗.丈丏业一不下与丄万.丘丛丆丕且丂业世丌();
        this.一丘东丌丑且丏一丙 = 七丁丑丗丐专丌丝丗.丈丏业一不下与丄万.丕丆丞丂业东与上丅();
        val_5 = 七丁丑丗丐专丌丝丗.丈丏业一不下与丄万;
        this.世丁与丕丗丟丒丆上 = val_5.且丁丙丑丄丁丄与丑();
        this.丐丙丞丅不丙丂丟丐 = 七丁丑丗丐专丌丝丗.丈丏业一不下与丄万.上丐丛七丌丝丐丄丟();
        return;
        label_1:
        if(this != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    private void 丈丒不且丘与丙下七(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        bool val_10;
        Rilisoft.七丕丟丏三丈一丄世 val_11;
        var val_12;
        System.Action val_13;
        val_10 = 丐且丘丑与万丞丑丅;
        丅丒丗丑丒丙丛不丆.丌三七与不丐丅丞上(丙业与丙丗丝不丈东:  false);
        val_11 = this.一丗丟丛丈专丙三丌;
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  val_11);
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != false)
        {
                this.丏丛丄万下业一七专();
            return;
        }
        
        val_12 = null;
        val_12 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄业丅东丑且三七上, b:  new System.Action(object:  this, method:  System.Void 丈丏三丏丒专丐世丐::丏丛丄万下业一七专()))) != null) && (null != null))
        {
                val_13 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_13;
        if(val_10 != null)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_5 = val_10.丌不丅不丞东万专专();
            val_10 = ((val_5.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0) & ;
        }
        
        bool val_9 = GameConnect.丆下丅丟下丂一不丙(业万上丆丐丞且丒七:  GameConnect.三东丄丞丛丒丄与万(丞丁丑丏丄丏七丂不:  this.一丘东丌丑且丏一丙, 一丅丆丂七与丆丈丂:  val_10), 丛丈丑丏与上丄丝丌:  true, 丐且丘丑与万丞丑丅:  true);
    }
    internal void 丄与丄东丗三丕不不(System.Action 丌丁丅丌东丐丗丛丈, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        this.万丈三丑丐丘丐丟七 = 丌丁丅丌东丐丗丛丈;
        this.丈丝丂丐丟万丙丑丕 = 丐且丘丑与万丞丑丅;
        this.世东丛一且且丐丒丂 = 1;
        this.丈丒不且丘与丙下七(丐且丘丑与万丞丑丅:  丐且丘丑与万丞丑丅);
    }
    internal void 上丂丆丆且丏东丝且(System.Action 丌丁丅丌东丐丗丛丈, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        this.万丈三丑丐丘丐丟七 = 丌丁丅丌东丐丗丛丈;
        this.丈丝丂丐丟万丙丑丕 = 丐且丘丑与万丞丑丅;
        this.世东丛一且且丐丒丂 = 0;
        this.丈丒不且丘与丙下七(丐且丘丑与万丞丑丅:  丐且丘丑与万丞丑丅);
    }
    internal void 丄丗丆专丌丑万丄丑(System.Action 丌丁丅丌东丐丗丛丈)
    {
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  this.一丗丟丛丈专丙三丌);
        this.万丈三丑丐丘丐丟七 = 丌丁丅丌东丐丗丛丈;
        this.世东丛一且且丐丒丂 = 1;
        this.丈丒不且丘与丙下七(丐且丘丑与万丞丑丅:  0);
    }
    private void 丏丛丄万下业一七专()
    {
        object val_7;
        var val_8;
        System.Action val_9;
        var val_10;
        var val_11;
        System.Delegate val_12;
        System.Action val_13;
        val_7 = this;
        val_8 = null;
        val_8 = null;
        val_10 = null;
        val_11 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  System.Void 丈丏三丏丒专丐世丐::丏丛丄万下业一七专()))) != null) && (null != val_11))
        {
                val_10 = null;
            val_11 = null;
            val_9 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_9;
        System.Action val_4 = null;
        val_12 = val_4;
        val_4 = new System.Action(object:  this, method:  System.Void 丈丏三丏丒专丐世丐::不且不丛专丏丂七丁());
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  val_4)) != null) && (null != null))
        {
                val_13 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_13;
        if(this.世东丛一且且丐丒丂 != 0)
        {
                if(this.世东丛一且且丐丒丂 != 1)
        {
                return;
        }
        
            val_7 = this.世丁与丕丗丟丒丆上;
            bool val_6 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  val_7);
            return;
        }
        
        val_12 = this.一丗丟丛丈专丙三丌;
        val_7 = this.丐丙丞丅不丙丂丟丐;
        GameConnect.万丐丑上丟丞丞丏丑(丅一丞万丑专丅丅与:  this.世丁与丕丗丟丒丆上, 丛且丞与丕业下丏丞:  this.一丘东丌丑且丏一丙, 上且丗一丏丏万丅丌:  val_12, 丟丑业丌丙丙丑下丑:  true, 下下东且万业丞丅丒:  true, 七专丙丏丘丌丌下与:  0, 丐且丘丑与万丞丑丅:  this.丈丝丂丐丟万丙丑丕, 丙丘东丏三丆丄丁丟:  0, 丕丑专丗万丕与专丐:  val_7);
    }
    private void 不且不丛专丏丂七丁()
    {
        var val_4;
        System.Action val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void 丈丏三丏丒专丐世丐::不且不丛专丏丂七丁()))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_5;
        if(this.万丈三丑丐丘丐丟七 != null)
        {
                this.万丈三丑丐丘丐丟七.Invoke();
        }
        
        this.世专丂丑丟丁业与丄.Invoke();
        this.丁万丒丄丁世与世世();
    }
    private void 丁万丒丄丁世与世世()
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_18 = null;
        val_18 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆] == null)
        {
                return;
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "On JoinedRoom");
        if(UnityEngine.Application.isEditor != false)
        {
                val_19 = null;
            val_19 = null;
            UnityEngine.Debug.Log(message:  "On Joined Room " + 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]);
        }
        
        NotificationController.下世东丘且丏丙丐与();
        val_20 = null;
        val_20 = null;
        val_21 = null;
        val_21 = null;
        SceneInfo val_13 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]));
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        val_22 = static_value_081DACA8;
        val_22 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) != 0)
        {
                val_23 = static_value_081DACA8;
            val_23 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.东与丌东丐丏七且专();
        }
        
        UnityEngine.Coroutine val_17 = CoroutineRunner.Instance.StartCoroutine(routine:  MainMenuController.丝业丗上上丘丐与丗(丛丑丂丛丙一上专丆:  true, 世不丛业丟丝与丆丙:  false, 丑丐丗三丒世丏东丅:  "", 丒不丙万万不丕丞与:  false, 丌与一丌且一不七丆:  false, 丝丅与业且一丛丒一:  false, 丁丟丑丆三丆业一丅:  3, 丅与丏与丙东世丌世:  this.一丗丟丛丈专丙三丌));
    }
    public 丈丏三丏丒专丐世丐()
    {
    
    }

}
