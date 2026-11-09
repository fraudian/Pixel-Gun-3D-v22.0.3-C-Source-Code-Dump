using UnityEngine;
internal sealed class TaskUIImposterModeRepeatSequence : TaskUIImposterModeAbstract
{
    // Fields
    private static readonly int 丄一丞下丕丝世丕业;
    private static readonly int 丅丂丈丛七丑丛三丒;
    private float showTime;
    private float hideTime;
    private UnityEngine.AudioClip sucessSound;
    private UnityEngine.AudioClip failSound;
    private UnityEngine.AudioClip completeSound;
    private WidgetLayout _indicatorsLayout_Left;
    private WidgetLayout _indicatorLayout_Right;
    private TaskUIImposterNumButton _indicator_Left;
    private TaskUIImposterNumButton _indicator_Right;
    private System.Collections.Generic.List<TaskUIImposterNumButton> 丏丄丘丞丅专丄且丙;
    private System.Collections.Generic.List<TaskUIImposterNumButton> 丁丄万万与丐丂丗丞;
    private UIGrid _grid_Left;
    private UIGrid _grid_Right;
    private TaskUIImposterNumButton _buttonUI_Left;
    private TaskUIImposterNumButton _buttonUI_Right;
    private System.Collections.Generic.List<TaskUIImposterNumButton> 丂丅丕丂丅丄七丅丅;
    private System.Collections.Generic.List<TaskUIImposterNumButton> 下丌东丈丞丈丐丄七;
    private System.Collections.Generic.List<System.Collections.Generic.List<int>> 丟东不万丌丞丘丈万;
    private int 七下专七一下丒丆丝;
    private string 丕专丐丁专万丘丐不;
    private UnityEngine.Coroutine 丅丏与丆万业业世上;
    
    // Methods
    protected override void Awake()
    {
        var val_7;
        TaskUIImposterNumButton val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = null;
        val_7 = null;
        丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<TaskUIImposterNumButton>(专下丐丒丈万丗丟丝:  this.丂丅丕丂丅丄七丅丅, 专丑业丁丗丏丌不丛:  this._buttonUI_Left.gameObject, 丈东丘丏与丌东东下:  this._grid_Left.transform, 与业丄丂丂丆下上丞:  TaskUIImposterModeRepeatSequence.丅丂丈丛七丑丛三丒, 丏东下下一丗专下丏:  0);
        this.丂丅丕丂丅丄七丅丅.Insert(index:  0, item:  this._buttonUI_Left);
        丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<TaskUIImposterNumButton>(专下丐丒丈万丗丟丝:  this.下丌东丈丞丈丐丄七, 专丑业丁丗丏丌不丛:  this._buttonUI_Right.gameObject, 丈东丘丏与丌东东下:  this._grid_Right.transform, 与业丄丂丂丆下上丞:  TaskUIImposterModeRepeatSequence.丅丂丈丛七丑丛三丒, 丏东下下一丗专下丏:  0);
        val_8 = this._buttonUI_Right;
        val_9 = 0;
        this.下丌东丈丞丈丐丄七.Insert(index:  0, item:  val_8);
        val_10 = 0;
        goto label_11;
        label_18:
        this.丂丅丕丂丅丄七丅丅.Item[0].丈且东丑丂且万丒丅(丑丅世丐丒丏丐三丅:  0);
        val_8 = this.下丌东丈丞丈丐丄七.Item[0];
        val_9 = val_10;
        val_8.丈且东丑丂且万丒丅(丑丅世丐丒丏丐三丅:  0);
        val_10 = 1;
        label_11:
        val_11 = null;
        val_11 = null;
        if(val_10 <= TaskUIImposterModeRepeatSequence.丅丂丈丛七丑丛三丒)
        {
            goto label_18;
        }
        
        if(this._grid_Right == null)
        {
            
        }
    
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.下丌东丈丞丈丐丄七.ForEach(action:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeRepeatSequence::丏上丛丝丒且业上丏(TaskUIImposterNumButton 丞丘世丕丝与专丗七)));
        if(this.丟东不万丌丞丘丈万 == null)
        {
                return;
        }
        
        this.且丕丕丒丄丑丌丂丝();
        this.三丏丁丛不丗丞丞世();
    }
    protected override void OnDisable()
    {
        this.下丌东丈丞丈丐丄七.ForEach(action:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeRepeatSequence::丕且与丌丅下丙与业(TaskUIImposterNumButton 丞丘世丕丝与专丗七)));
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        this.三丏丁三丆丈丑世专();
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        this.七下专七一下丒丆丝 = 0;
        this.丟东不万丌丞丘丈万 = 0;
        this.丕专丐丁专万丘丐不 = System.String.alignConst;
    }
    private void 三丏丁三丆丈丑世专()
    {
        var val_8;
        System.Collections.Generic.List<System.Int32> val_9;
        int val_10;
        var val_11;
        var val_12;
        val_8 = null;
        val_8 = null;
        this.丟东不万丌丞丘丈万 = new System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>(capacity:  TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业);
        System.Random val_3 = null;
        val_9 = val_3;
        val_3 = new System.Random(Seed:  TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业.丐丕不丅三专万丕丗());
        System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
        val_10 = 0;
        goto label_4;
        label_11:
        int val_5 = TaskUIImposterModeRepeatSequence.丅丂丈丛七丑丛三丒 + 1;
        val_4.Add(item:  -1375746432);
        val_10 = 1;
        label_4:
        val_11 = null;
        val_11 = null;
        if(val_10 < TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业)
        {
            goto label_11;
        }
        
        val_12 = 0;
        goto label_12;
        label_20:
        System.Collections.Generic.List<System.Int32> val_6 = null;
        val_9 = val_6;
        val_6 = new System.Collections.Generic.List<System.Int32>();
        if((val_12 & 2147483648) == 0)
        {
                var val_8 = 0;
            do
        {
            val_10 = val_4.Item[0];
            val_6.Add(item:  val_10);
            val_8 = val_8 + 1;
        }
        while(val_8 <= val_12);
        
        }
        
        this.丟东不万丌丞丘丈万.Add(item:  val_6);
        val_11 = null;
        val_12 = 1;
        label_12:
        val_11 = null;
        if(val_12 < TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业)
        {
            goto label_20;
        }
        
        this.且丕丕丒丄丑丌丂丝();
        this.三丏丁丛不丗丞丞世();
    }
    private void 世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)
    {
        int val_6;
        int val_12;
        if(true != 0)
        {
                return;
        }
        
        if(this.丟东不万丌丞丘丈万 == null)
        {
                return;
        }
        
        if(this.七下专七一下丒丆丝 >= this.丟东不万丌丞丘丈万.Count)
        {
                return;
        }
        
        this.丕专丐丁专万丘丐不 = this.丕专丐丁专万丘丐不 + 丟丄丕且丝丛与业丛.<不丕丐丘一丂东七万>k__BackingField(丟丄丕且丝丛与业丛.<不丕丐丘一丂东七万>k__BackingField);
        val_12 = System.String.alignConst;
        List.Enumerator<T> val_4 = this.丟东不万丌丞丘丈万.Item[this.七下专七一下丒丆丝].GetEnumerator();
        goto label_7;
        label_8:
        val_6 = val_6.丙东专丂世丈丏丁丂();
        val_12 = val_12 + val_6;
        label_7:
        if(((-1375615040) & 1) != 0)
        {
            goto label_8;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_12.StartsWith(value:  this.丕专丐丁专万丘丐不)) != true)
        {
                this.一万丌丏世业丙丂丈();
        }
        
        if(this.丕专丐丁专万丘丐不.Length != val_12.Length)
        {
                return;
        }
        
        this.丅丙上丗丘丕丁丘丛();
    }
    private void 且丕丕丒丄丑丌丂丝()
    {
        if(this.丅丏与丆万业业世上 != null)
        {
                this.StopCoroutine(routine:  this.丅丏与丆万业业世上);
            mem[1152921537591151832] = 0;
        }
        
        mem[1152921537591151832] = 1;
        this.丅丏与丆万业业世上 = this.StartCoroutine(routine:  this.三丈丙丄丕丐丘专丙(丞世不丒下上上丝丑:  this.七下专七一下丒丆丝));
    }
    private System.Collections.IEnumerator 三丈丙丄丕丐丘专丙(int 丞世不丒下上上丝丑)
    {
        TaskUIImposterModeRepeatSequence.丂丕三丌丈丙三丛七 val_1 = new TaskUIImposterModeRepeatSequence.丂丕三丌丈丙三丛七();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丞世不丒下上上丝丑 = 丞世不丒下上上丝丑;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 三丏丁丛不丗丞丞世()
    {
        System.Collections.Generic.List<TaskUIImposterNumButton> val_16;
        var val_17;
        TaskUIImposterNumButton val_18;
        var val_19;
        var val_20;
        var val_21;
        int val_22;
        var val_23;
        if(this.丏丄丘丞丅专丄且丙.Count == 0)
        {
            goto label_2;
        }
        
        val_16 = this.丁丄万万与丐丂丗丞;
        goto label_3;
        label_2:
        val_17 = null;
        val_17 = null;
        丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<TaskUIImposterNumButton>(专下丐丒丈万丗丟丝:  this.丏丄丘丞丅专丄且丙, 专丑业丁丗丏丌不丛:  this._indicator_Left.gameObject, 丈东丘丏与丌东东下:  this._indicatorsLayout_Left.transform, 与业丄丂丂丆下上丞:  TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业 - 1, 丏东下下一丗专下丏:  0);
        this.丏丄丘丞丅专丄且丙.Insert(index:  0, item:  this._indicator_Left);
        val_16 = this;
        丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<TaskUIImposterNumButton>(专下丐丒丈万丗丟丝:  this.丁丄万万与丐丂丗丞, 专丑业丁丗丏丌不丛:  this._indicator_Right.gameObject, 丈东丘丏与丌东东下:  this._indicatorLayout_Right.transform, 与业丄丂丂丆下上丞:  TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业 - 1, 丏东下下一丗专下丏:  0);
        val_18 = this._indicator_Right;
        this.丁丄万万与丐丂丗丞.Insert(index:  0, item:  val_18);
        val_19 = 0;
        goto label_14;
        label_21:
        this.丏丄丘丞丅专丄且丙.Item[0].丈且东丑丂且万丒丅(丑丅世丐丒丏丐三丅:  0);
        val_18 = null.Item[0];
        val_18.丈且东丑丂且万丒丅(丑丅世丐丒丏丐三丅:  0);
        val_19 = 1;
        label_14:
        val_20 = null;
        val_20 = null;
        int val_16 = TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业;
        val_16 = val_16 - 1;
        if(val_19 <= val_16)
        {
            goto label_21;
        }
        
        this._indicatorsLayout_Left.CollectWidgets();
        this._indicatorsLayout_Left.Reposition();
        this._indicatorLayout_Right.CollectWidgets();
        this._indicatorLayout_Right.Reposition();
        label_3:
        val_21 = 0;
        goto label_26;
        label_43:
        this.丏丄丘丞丅专丄且丙.Item[0].丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  false);
        null.Item[0].丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  false);
        this.丏丄丘丞丅专丄且丙.Item[0].东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  false);
        val_18 = null.Item[0];
        val_18.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  false);
        val_22 = this.七下专七一下丒丆丝;
        if(val_21 <= val_22)
        {
                val_18 = this.丏丄丘丞丅专丄且丙.Item[0];
            val_18.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  true);
            val_22 = this.七下专七一下丒丆丝;
        }
        
        if(val_21 < val_22)
        {
                val_18 = null.Item[0];
            val_18.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  true);
        }
        
        val_21 = 1;
        label_26:
        val_23 = null;
        val_23 = null;
        if(val_21 < TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业)
        {
            goto label_43;
        }
    
    }
    private void 一万丌丏世业丙丂丈()
    {
        var val_7;
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Fail!");
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.failSound);
        }
        
        this.丕专丐丁专万丘丐不 = System.String.alignConst;
        this.丁丄万万与丐丂丗丞.Item[this.七下专七一下丒丆丝].丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  true);
        val_7 = null;
        val_7 = null;
        if((TaskUIImposterModeRepeatSequence.<>c.<>9__33_0) == null)
        {
            goto label_10;
        }
        
        label_17:
        this.下丌东丈丞丈丐丄七.ForEach(action:  TaskUIImposterModeRepeatSequence.<>c.<>9__33_0);
        mem[1152921537591797160] = 1;
        UnityEngine.Coroutine val_5 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void TaskUIImposterModeRepeatSequence::专丙丑丕丈丄丑丄丙()), 丆丐七丅丆丗丛上与:  this.showTime);
        return;
        label_10:
        TaskUIImposterModeRepeatSequence.<>c.<>9__33_0 = new System.Action<TaskUIImposterNumButton>(object:  TaskUIImposterModeRepeatSequence.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TaskUIImposterModeRepeatSequence.<>c::下一丒丁丙与丛上一(TaskUIImposterNumButton 三丟东丕丄丄下下丑));
        if(this.下丌东丈丞丈丐丄七 != null)
        {
            goto label_17;
        }
        
        goto label_17;
    }
    private void 丅丙上丗丘丕丁丘丛()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Sucess!");
        int val_1 = this.七下专七一下丒丆丝 + 1;
        this.七下专七一下丒丆丝 = val_1;
        this.丕专丐丁专万丘丐不 = System.String.alignConst;
        if(val_1 < this.丟东不万丌丞丘丈万.Count)
        {
                丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "\tContinue...");
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.sucessSound);
        }
        
            this.三丏丁丛不丗丞丞世();
            this.且丕丕丒丄丑丌丂丝();
            return;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "\tComplete!");
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.completeSound);
        }
        
        this.万丏丛东下丝下丟丕();
    }
    public TaskUIImposterModeRepeatSequence()
    {
        this.showTime = 0.8f;
        this.hideTime = 7.346868E-41f;
        this.丏丄丘丞丅专丄且丙 = new System.Collections.Generic.List<TaskUIImposterNumButton>();
        this.丁丄万万与丐丂丗丞 = new System.Collections.Generic.List<TaskUIImposterNumButton>();
        this.丂丅丕丂丅丄七丅丅 = new System.Collections.Generic.List<TaskUIImposterNumButton>();
        this.下丌东丈丞丈丐丄七 = new System.Collections.Generic.List<TaskUIImposterNumButton>();
        this.丕专丐丁专万丘丐不 = System.String.alignConst;
        this = new PGBehaviour();
    }
    private static TaskUIImposterModeRepeatSequence()
    {
        TaskUIImposterModeRepeatSequence.丄一丞下丕丝世丕业 = 5;
        TaskUIImposterModeRepeatSequence.丅丂丈丛七丑丛三丒 = 8;
    }
    private void 丏上丛丝丒且业上丏(TaskUIImposterNumButton 丞丘世丕丝与专丗七)
    {
        丞丘世丕丝与专丗七.万丂丐丛丒万下丝一(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeRepeatSequence::世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)));
    }
    private void 丕且与丌丅下丙与业(TaskUIImposterNumButton 丞丘世丕丝与专丗七)
    {
        丞丘世丕丝与专丗七.丙与丏丈丘三丅丏丟(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeRepeatSequence::世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)));
    }
    private void 专丙丑丕丈丄丑丄丙()
    {
        if(this == 0)
        {
                return;
        }
        
        this.三丏丁丛不丗丞丞世();
        this.且丕丕丒丄丑丌丂丝();
    }

}
