using UnityEngine;
internal sealed class TaskUIImposterModeCodePanel : TaskUIImposterModeAbstract
{
    // Fields
    private static readonly string 丛丑世丐丐且丅与东;
    private static readonly string 三丕丁七世丟上丕且;
    private static readonly int 丅丂丈丛七丑丛三丒;
    private static readonly int 丈丂丘三不丅七万世;
    private UIGrid _grid;
    private TaskUIImposterNumButton _zeroNumberUI;
    private UILabel _codeLabel;
    private UILabel _inputCodeLabel;
    private UnityEngine.GameObject _shineButtonOk;
    private System.Collections.Generic.List<TaskUIImposterNumButton> 丕七丗丁丈丙丌一丝;
    private System.Collections.Generic.List<int> 丌丐不一丘一丄丂丒;
    private System.Collections.Generic.List<int> 丙丗三万丅丘丈丙万;
    
    // Methods
    protected override void Awake()
    {
        var val_4;
        TaskUIImposterNumButton val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = null;
        val_4 = null;
        丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<TaskUIImposterNumButton>(专下丐丒丈万丗丟丝:  this.丕七丗丁丈丙丌一丝, 专丑业丁丗丏丌不丛:  this._zeroNumberUI.gameObject, 丈东丘丏与丌东东下:  this._grid.transform, 与业丄丂丂丆下上丞:  TaskUIImposterModeCodePanel.丅丂丈丛七丑丛三丒, 丏东下下一丗专下丏:  0);
        val_5 = this._zeroNumberUI;
        val_6 = 0;
        this.丕七丗丁丈丙丌一丝.Insert(index:  0, item:  val_5);
        val_7 = 0;
        goto label_8;
        label_13:
        val_5 = this.丕七丗丁丈丙丌一丝.Item[0];
        val_6 = val_7;
        val_5.丈且东丑丂且万丒丅(丑丅世丐丒丏丐三丅:  0);
        val_7 = 1;
        label_8:
        val_8 = null;
        val_8 = null;
        if(val_7 <= TaskUIImposterModeCodePanel.丅丂丈丛七丑丛三丒)
        {
            goto label_13;
        }
        
        if(this._grid == null)
        {
            
        }
    
    }
    protected override void OnEnable()
    {
        this.丕七丗丁丈丙丌一丝.ForEach(action:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeCodePanel::丈丆丄三与丁丟丟丞(TaskUIImposterNumButton 丞丘世丕丝与专丗七)));
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        this.丕七丗丁丈丙丌一丝.ForEach(action:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeCodePanel::丂丘丐丛专丏东丑丕(TaskUIImposterNumButton 丞丘世丕丝与专丗七)));
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        this.下丛丗丗上丁七丙专();
        this.万专世丂专丈丐丁丁();
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        this.丙丗三万丅丘丈丙万.Clear();
    }
    private void 世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)
    {
        if(true != 0)
        {
                return;
        }
        
        if(this.丙丗三万丅丘丈丙万.Count < this.丌丐不一丘一丄丂丒.Count)
        {
                this.丙丗三万丅丘丈丙万.Add(item:  丟丄丕且丝丛与业丛.<不丕丐丘一丂东七万>k__BackingField);
            this.丟丁丘业上世上丁丄();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shineButtonOk, 丏业丟一东丂东丘丛:  true);
    }
    private void 下丛丗丗上丁七丙专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shineButtonOk, 丏业丟一东丂东丘丛:  false);
        this.丟丁丘业上世上丁丄();
    }
    public void U_PressOk()
    {
        this.丏三下业丁丂丂丅万();
    }
    private void 丏三下业丁丂丂丅万()
    {
        if(true != 0)
        {
                return;
        }
        
        if(this.丙丗三万丅丘丈丙万.Count != this.丌丐不一丘一丄丂丒.Count)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shineButtonOk, 丏业丟一东丂东丘丛:  false);
        var val_8 = 0;
        label_11:
        if(val_8 >= this.丙丗三万丅丘丈丙万.Count)
        {
            goto label_8;
        }
        
        val_8 = val_8 + 1;
        if(this.丙丗三万丅丘丈丙万.Item[0] == this.丌丐不一丘一丄丂丒.Item[0])
        {
            goto label_11;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._inputCodeLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10153"));
        this.丁丂专丝丑丗丅业丑(世与丞丄丐丑丗丐三:  0.5f, 业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void TaskUIImposterModeCodePanel::下丛丗丗上丁七丙专()));
        return;
        label_8:
        this.万丏丛东下丝下丟丕();
    }
    public void U_PressX()
    {
        this.与与丟丘丄丘与专万();
    }
    private void 与与丟丘丄丘与专万()
    {
        var val_5;
        if(true != 0)
        {
                return;
        }
        
        if(this.丙丗三万丅丘丈丙万.Count == 0)
        {
                return;
        }
        
        if(this.丙丗三万丅丘丈丙万 != null)
        {
                val_5 = this.丙丗三万丅丘丈丙万.Count;
        }
        else
        {
                val_5 = 0.Count;
        }
        
        this.丙丗三万丅丘丈丙万.RemoveAt(index:  val_5 - 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._shineButtonOk, 丏业丟一东丂东丘丛:  false);
        this.丟丁丘业上世上丁丄();
    }
    private void 万专世丂专丈丐丁丁()
    {
        var val_8;
        var val_9;
        object val_10;
        this.丌丐不一丘一丄丂丒.Clear();
        System.Random val_2 = new System.Random(Seed:  this.丌丐不一丘一丄丂丒.丐丕不丅三专万丕丗());
        val_8 = 0;
        goto label_3;
        label_10:
        int val_3 = TaskUIImposterModeCodePanel.丅丂丈丛七丑丛三丒 + 1;
        this.丌丐不一丘一丄丂丒.Add(item:  -1387574976);
        val_8 = 1;
        label_3:
        val_9 = null;
        val_9 = null;
        if(val_8 < TaskUIImposterModeCodePanel.丈丂丘三不丅七万世)
        {
            goto label_10;
        }
        
        string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10081");
        val_10 = System.String.Join<System.Int32>(separator:  "", values:  this.丌丐不一丘一丄丂丒);
        if((System.String.IsNullOrEmpty(value:  val_4)) != true)
        {
                val_10 = System.String.Format(format:  val_4, arg0:  val_10);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._codeLabel, 丕丗丘丑丛与丑业丒:  val_10);
    }
    private string 丟不丅专丛丐丐丁且(System.Collections.Generic.List<int> 专丏不丏东丏丈丆上)
    {
        var val_8;
        string val_9;
        var val_10;
        var val_11;
        val_8 = null;
        val_8 = null;
        string[] val_1 = new string[0];
        val_9 = 0;
        goto label_3;
        label_11:
        if(val_9 >= 专丏不丏东丏丈丆上.Count)
        {
            goto label_4;
        }
        
        label_12:
        string val_4 = 专丏不丏东丏丈丆上.Item[0].ToString();
        if(val_1 == null)
        {
            goto label_5;
        }
        
        if(val_4 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_4 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_9 = 1;
        val_1[0] = val_4;
        label_3:
        if(专丏不丏东丏丈丆上 == null)
        {
            goto label_11;
        }
        
        if(val_9 < 专丏不丏东丏丈丆上.Count)
        {
            goto label_12;
        }
        
        label_4:
        val_10 = 专丏不丏东丏丈丆上.Count;
        goto label_13;
        label_24:
        val_9 = TaskUIImposterModeCodePanel.三丕丁七世丟上丕且;
        if(val_1 == null)
        {
            goto label_16;
        }
        
        if(val_9 != null)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        if(val_9 == null)
        {
            goto label_20;
        }
        
        label_17:
        label_20:
        val_10 = val_10 + 1;
        val_1[(long)val_10] = val_9;
        label_13:
        val_11 = null;
        val_11 = null;
        if(val_10 < TaskUIImposterModeCodePanel.丈丂丘三不丅七万世)
        {
            goto label_24;
        }
        
        return (string)System.String.Join(separator:  TaskUIImposterModeCodePanel.__il2cppRuntimeField_static_fields, value:  val_1);
    }
    private void 丟丁丘业上世上丁丄()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._inputCodeLabel, 丕丗丘丑丛与丑业丒:  this.丟不丅专丛丐丐丁且(专丏不丏东丏丈丆上:  this.丙丗三万丅丘丈丙万));
    }
    public TaskUIImposterModeCodePanel()
    {
        var val_5;
        this.丕七丗丁丈丙丌一丝 = new System.Collections.Generic.List<TaskUIImposterNumButton>();
        val_5 = null;
        val_5 = null;
        this.丌丐不一丘一丄丂丒 = new System.Collections.Generic.List<System.Int32>(capacity:  TaskUIImposterModeCodePanel.丈丂丘三不丅七万世);
        this.丙丗三万丅丘丈丙万 = new System.Collections.Generic.List<System.Int32>(capacity:  TaskUIImposterModeCodePanel.丈丂丘三不丅七万世);
        this = new PGBehaviour();
    }
    private static TaskUIImposterModeCodePanel()
    {
        TaskUIImposterModeCodePanel.丛丑世丐丐且丅与东 = " ";
        TaskUIImposterModeCodePanel.三丕丁七世丟上丕且 = "-";
        TaskUIImposterModeCodePanel.丅丂丈丛七丑丛三丒 = 9;
        TaskUIImposterModeCodePanel.丈丂丘三不丅七万世 = 4;
    }
    private void 丈丆丄三与丁丟丟丞(TaskUIImposterNumButton 丞丘世丕丝与专丗七)
    {
        丞丘世丕丝与专丗七.万丂丐丛丒万下丝一(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeCodePanel::世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)));
    }
    private void 丂丘丐丛专丏东丑丕(TaskUIImposterNumButton 丞丘世丕丝与专丗七)
    {
        丞丘世丕丝与专丗七.丙与丏丈丘三丅丏丟(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeCodePanel::世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)));
    }

}
