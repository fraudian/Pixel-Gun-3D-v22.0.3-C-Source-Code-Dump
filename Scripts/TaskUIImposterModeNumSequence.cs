using UnityEngine;
internal sealed class TaskUIImposterModeNumSequence : TaskUIImposterModeAbstract
{
    // Fields
    private static readonly int 丅丂丈丛七丑丛三丒;
    private UIGrid _grid;
    private TaskUIImposterNumButton _exampleNumberUI;
    private System.Collections.Generic.List<TaskUIImposterNumButton> 丕七丗丁丈丙丌一丝;
    private System.Collections.Generic.List<int> 丒丑世丗与世丕丛且;
    private int 丝丄丈丞丙丌丝丑一;
    
    // Methods
    protected override void Awake()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = 1;
        goto label_1;
        label_5:
        this.丒丑世丗与世丕丛且.Add(item:  1);
        val_4 = 2;
        label_1:
        val_5 = null;
        val_5 = null;
        if(val_4 <= TaskUIImposterModeNumSequence.丅丂丈丛七丑丛三丒)
        {
            goto label_5;
        }
        
        val_6 = null;
        val_6 = null;
        丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<TaskUIImposterNumButton>(专下丐丒丈万丗丟丝:  this.丕七丗丁丈丙丌一丝, 专丑业丁丗丏丌不丛:  this._exampleNumberUI.gameObject, 丈东丘丏与丌东东下:  this._exampleNumberUI.transform.parent, 与业丄丂丂丆下上丞:  TaskUIImposterModeNumSequence.丅丂丈丛七丑丛三丒, 丏东下下一丗专下丏:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._exampleNumberUI, 丏业丟一东丂东丘丛:  false);
        if(this._grid == null)
        {
            
        }
    
    }
    protected override void OnEnable()
    {
        this.丕七丗丁丈丙丌一丝.ForEach(action:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeNumSequence::丞丐丙丄三丐不丂上(TaskUIImposterNumButton 丞丘世丕丝与专丗七)));
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        this.丕七丗丁丈丙丌一丝.ForEach(action:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeNumSequence::丑世三一丞与丝丈丗(TaskUIImposterNumButton 丞丘世丕丝与专丗七)));
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        var val_9;
        var val_11;
        System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.丒丑世丗与世丕丛且);
        丞东丑专丛丆丄丝世.万丕业万不丐与丂丐<System.Int32>(丝丘丑业丛万丞丌丝:  val_1, 丂丆且一丛丙丑七丒:  new System.Random(Seed:  X21.丐丕不丅三专万丕丗()));
        val_9 = null;
        val_9 = null;
        if((TaskUIImposterModeNumSequence.<>c.<>9__8_0) == null)
        {
            goto label_6;
        }
        
        label_20:
        this.丕七丗丁丈丙丌一丝.ForEach(action:  TaskUIImposterModeNumSequence.<>c.<>9__8_0);
        this.丗丄万丏丟丘与丙丟();
        val_11 = 0;
        goto label_8;
        label_16:
        this.丕七丗丁丈丙丌一丝.Item[0].丈且东丑丂且万丒丅(丑丅世丐丒丏丐三丅:  val_1.Item[0]);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丕七丗丁丈丙丌一丝.Item[0], 丏业丟一东丂东丘丛:  true);
        val_11 = 1;
        label_8:
        if(val_11 < val_1.Count)
        {
            goto label_16;
        }
        
        return;
        label_6:
        TaskUIImposterModeNumSequence.<>c.<>9__8_0 = new System.Action<TaskUIImposterNumButton>(object:  TaskUIImposterModeNumSequence.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TaskUIImposterModeNumSequence.<>c::不丙丆且丆丛丈丑丄(TaskUIImposterNumButton 丞丘世丕丝与专丗七));
        if(this.丕七丗丁丈丙丌一丝 != null)
        {
            goto label_20;
        }
        
        goto label_20;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        this.丝丄丈丞丙丌丝丑一 = 0;
    }
    private void 世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)
    {
        var val_3;
        var val_4;
        System.Action<TaskUIImposterNumButton> val_6;
        if(true != 0)
        {
                return;
        }
        
        int val_3 = 丟丄丕且丝丛与业丛.<不丕丐丘一丂东七万>k__BackingField;
        val_3 = val_3 - 1;
        if(this.丝丄丈丞丙丌丝丑一 == val_3)
        {
                丟丄丕且丝丛与业丛.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  true);
            this.丝丄丈丞丙丌丝丑一 = 丟丄丕且丝丛与业丛.<不丕丐丘一丂东七万>k__BackingField;
            val_3 = null;
            val_3 = null;
            if((丟丄丕且丝丛与业丛.<不丕丐丘一丂东七万>k__BackingField) != TaskUIImposterModeNumSequence.丅丂丈丛七丑丛三丒)
        {
                return;
        }
        
            this.万丏丛东下丝下丟丕();
            return;
        }
        
        val_4 = null;
        val_4 = null;
        val_6 = TaskUIImposterModeNumSequence.<>c.<>9__11_0;
        if(val_6 == null)
        {
                System.Action<TaskUIImposterNumButton> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Action<TaskUIImposterNumButton>(object:  TaskUIImposterModeNumSequence.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TaskUIImposterModeNumSequence.<>c::丛丐丟丅万上且与七(TaskUIImposterNumButton 丞丘世丕丝与专丗七));
            TaskUIImposterModeNumSequence.<>c.<>9__11_0 = val_6;
        }
        
        this.丕七丗丁丈丙丌一丝.ForEach(action:  val_1);
        this.丁丂专丝丑丗丅业丑(世与丞丄丐丑丗丐三:  0.5f, 业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void TaskUIImposterModeNumSequence::丗丄万丏丟丘与丙丟()));
    }
    private void 丗丄万丏丟丘与丙丟()
    {
        var val_2 = null;
        if((TaskUIImposterModeNumSequence.<>c.<>9__12_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.丕七丗丁丈丙丌一丝.ForEach(action:  TaskUIImposterModeNumSequence.<>c.<>9__12_0);
        return;
        label_3:
        TaskUIImposterModeNumSequence.<>c.<>9__12_0 = new System.Action<TaskUIImposterNumButton>(object:  TaskUIImposterModeNumSequence.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TaskUIImposterModeNumSequence.<>c::下丄丘且与专一丆丟(TaskUIImposterNumButton 丞丘世丕丝与专丗七));
        if(this.丕七丗丁丈丙丌一丝 != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    public TaskUIImposterModeNumSequence()
    {
        this.丕七丗丁丈丙丌一丝 = new System.Collections.Generic.List<TaskUIImposterNumButton>();
        this.丒丑世丗与世丕丛且 = new System.Collections.Generic.List<System.Int32>();
        this = new PGBehaviour();
    }
    private static TaskUIImposterModeNumSequence()
    {
        TaskUIImposterModeNumSequence.丅丂丈丛七丑丛三丒 = 10;
    }
    private void 丞丐丙丄三丐不丂上(TaskUIImposterNumButton 丞丘世丕丝与专丗七)
    {
        丞丘世丕丝与专丗七.万丂丐丛丒万下丝一(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeNumSequence::世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)));
    }
    private void 丑世三一丞与丝丈丗(TaskUIImposterNumButton 丞丘世丕丝与专丗七)
    {
        丞丘世丕丝与专丗七.丙与丏丈丘三丅丏丟(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeNumSequence::世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)));
    }

}
