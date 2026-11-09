using UnityEngine;
internal sealed class PlayerTaskImposterModeController : PGBehaviour
{
    // Fields
    private int taskNumberForPlayer;
    private System.Collections.Generic.List<ImposterModeRoomTasks> allRoomTasks;
    private PlayerTaskImposterMode emergencyButtonTask;
    public UnityEngine.AudioClip taskFailureClip;
    public UnityEngine.AudioClip taskCompleteClip;
    public UnityEngine.AudioClip taskStartClip;
    private System.Collections.Generic.List<PlayerTaskImposterMode> 万七丈业丝且下丞与;
    private System.Collections.Generic.Dictionary<PlayerTaskImposterMode.丌不丕丁丁东且丈丑, int> 下丟丘专丂下丑丁世;
    internal static PlayerTaskImposterModeController 丆丕丝丒不丙且丐丗;
    internal System.Action 丁一东丈丙丒且丒丌;
    private bool <万丕业丁丌一东丌丒>k__BackingField;
    private bool 不丆世丅丘东丙丐丂;
    private bool <丌丙丏丕三一三丁丒>k__BackingField;
    internal int 丂专丁丝丂丒东七上;
    private float 丒且下上丑丆七丟丕;
    private ImposterModeController 丕专与且七丏丅业上;
    private int 丏丏丝丐丙与丏东世;
    private float 三丞专丕丐东丅与丏;
    private float 且丁丕丕丞且丗丝丙;
    
    // Properties
    internal System.Collections.Generic.List<ImposterModeRoomTasks> 上万且不不丏与七丑 { get; }
    internal bool 丁丌不丘下丑专丑万 { get; set; }
    internal bool 丗业下丛专丛丑丘丞 { get; set; }
    public bool 丟不丙丛丒丝下丈丈 { get; }
    public bool 一专丐丛丞业丟丂丗 { get; }
    internal static int 与丈丕不与丛丞丅丅 { get; }
    
    // Methods
    internal System.Collections.Generic.List<ImposterModeRoomTasks> 万丝不丗丌三东业丟()
    {
        return (System.Collections.Generic.List<ImposterModeRoomTasks>)this.allRoomTasks;
    }
    internal bool 丂丗一丈丏丞丈万丟()
    {
        return (bool)this.<万丕业丁丌一东丌丒>k__BackingField;
    }
    private void 丆丏丆三东上丟丄丏(bool 丙业与丙丗丝不丈东)
    {
        this.<万丕业丁丌一东丌丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丐丟一东丅丘一丒下()
    {
        return (bool)this.<丌丙丏丕三一三丁丒>k__BackingField;
    }
    private void 与与丟丅且丟世七三(bool 丙业与丙丗丝不丈东)
    {
        this.<丌丙丏丕三一三丁丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_TaskIsOpen()
    {
        return (bool)this.不丆世丅丘东丙丐丂;
    }
    public bool get_TaskWasOpen()
    {
        float val_3 = 5f;
        val_3 = this.丒且下上丑丆七丟丕 + val_3;
        return (bool)(val_3 > (float)UnityEngine.Time.frameCount) ? 1 : 0;
    }
    private void Awake()
    {
        var val_6;
        if(GameConnect.丙丌丒丈东七丒上丌() != true)
        {
                this.enabled = false;
        }
        
        this.丂专丁丝丂丒东七上 = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().丈丞丐上丄丕丕丗丛();
        this.taskNumberForPlayer = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().丙与丐丗七东丁一丅();
        val_6 = null;
        val_6 = null;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗 = this;
        this.<丌丙丏丕三一三丁丒>k__BackingField = false;
    }
    internal static int 丄七且丁丟丆不丑丕()
    {
        var val_8;
        var val_9;
        var val_10;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 0;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_9 = null;
        val_9 = null;
        if((val_8.ContainsKey(key:  GameConnect.七丝丕东丘丐丗不世)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丝丕东丘丐丗不世]);
    }
    private void Start()
    {
        var val_7;
        var val_8;
        var val_10;
        OnlineModeController val_11;
        val_7 = null;
        .丂丆且一丛丙丑七丒 = new System.Random(Seed:  PlayerTaskImposterModeController.丄七且丁丟丆不丑丕());
        this.allRoomTasks.ForEach(action:  new System.Action<ImposterModeRoomTasks>(object:  new PlayerTaskImposterModeController.下丏丌丑七丗丕丅世(), method:  System.Void PlayerTaskImposterModeController.下丏丌丑七丗丕丅世::丙丗丆七世专丛丁东(ImposterModeRoomTasks 丛下丄业丈东丆一丄)));
        val_8 = null;
        val_8 = null;
        if((PlayerTaskImposterModeController.<>c.<>9__34_1) == null)
        {
            goto label_7;
        }
        
        label_15:
        this.allRoomTasks.ForEach(action:  PlayerTaskImposterModeController.<>c.<>9__34_1);
        this.三业丌一业业丆丏丞();
        val_10 = null;
        val_10 = null;
        val_11 = GameController.onlineMode;
        this.丕专与且七丏丅业上 = (null == null) ? (val_11) : 0;
        return;
        label_7:
        PlayerTaskImposterModeController.<>c.<>9__34_1 = new System.Action<ImposterModeRoomTasks>(object:  PlayerTaskImposterModeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PlayerTaskImposterModeController.<>c::下三万业丆世专丈东(ImposterModeRoomTasks 丛下丄业丈东丆一丄));
        if(this.allRoomTasks != null)
        {
            goto label_15;
        }
        
        goto label_15;
    }
    internal void 三业丌一业业丆丏丞()
    {
        var val_23;
        var val_24;
        var val_25;
        丌不丕丁丁东且丈丑 val_26;
        var val_27;
        var val_28;
        int val_29;
        this.万七丈业丝且下丞与.Clear();
        System.Collections.Generic.List<PlayerTaskImposterMode> val_1 = new System.Collections.Generic.List<PlayerTaskImposterMode>();
        System.Collections.Generic.Dictionary<丌不丕丁丁东且丈丑, System.Int32> val_2 = new System.Collections.Generic.Dictionary<丌不丕丁丁东且丈丑, System.Int32>();
        System.Collections.Generic.List<丌不丕丁丁东且丈丑> val_3 = new System.Collections.Generic.List<丌不丕丁丁东且丈丑>();
        val_23 = 1152921537607330992;
        val_24 = 1152921504848912384;
        val_25 = 0;
        goto label_2;
        label_21:
        PlayerTaskImposterMode val_5 = this.allRoomTasks.Item[0].丌丟丈丕丛丑业不三(三下一丈专丈丂东世:  val_3);
        if(val_5 == 0)
        {
            goto label_18;
        }
        
        if(val_2 == null)
        {
            goto label_9;
        }
        
        val_26 = val_5.taskType;
        if((val_2.ContainsKey(key:  val_5.taskType)) == false)
        {
            goto label_10;
        }
        
        val_27 = 1152921537607354544;
        val_28 = val_2.Item[val_26];
        goto label_11;
        label_9:
        val_26 = val_5.taskType;
        if((val_2.ContainsKey(key:  val_5.taskType)) == false)
        {
            goto label_12;
        }
        
        val_27 = 1152921537607354544;
        val_28 = val_2.Item[val_26];
        label_11:
        val_2.set_Item(key:  val_26, value:  val_28 + 1);
        val_1.Add(item:  val_5);
        val_24 = 1152921504848912384;
        val_23 = val_23;
        if(val_2.Item[val_5.taskType] != this.下丟丘专丂下丑丁世.Item[val_5.taskType])
        {
            goto label_18;
        }
        
        val_3.Add(item:  val_5.taskType);
        goto label_18;
        label_12:
        label_10:
        val_2.Add(key:  val_26, value:  1);
        val_1.Add(item:  val_5);
        label_18:
        val_25 = 1;
        label_2:
        if(val_25 < this.allRoomTasks.Count)
        {
            goto label_21;
        }
        
        System.Collections.Generic.List<TSource> val_16 = System.Linq.Enumerable.ToList<PlayerTaskImposterMode>(source:  丞东丑专丛丆丄丝世.丆丝丙丁不丅丄七丂<PlayerTaskImposterMode>(丅东丗丒丄东丛业丄:  val_1, 丂丆且一丛丙丑七丒:  0));
        val_29 = this.taskNumberForPlayer;
        if(val_29 < 1)
        {
            goto label_30;
        }
        
        var val_23 = 0;
        do
        {
            this.万七丈业丝且下丞与.Add(item:  val_16.Item[0]);
            this.万七丈业丝且下丞与.Item[0].丝丏东丛丂三不东丆(丈丈专丁专丟万丟丏:  new System.Action<System.Int32>(object:  this, method:  System.Void PlayerTaskImposterModeController::丄三丙丄丞东丕丒丝(int 三专三丐丁世丑丁丅)), 三专三丐丁世丑丁丅:  0);
            val_29 = this.taskNumberForPlayer;
            val_23 = val_23 + 1;
        }
        while(val_23 < val_29);
        
        val_24 = 1152921504848912384;
        goto label_30;
        label_34:
        val_16.Item[val_29].丏丛专丘丄且丑下丑();
        val_29 = val_29 + 1;
        label_30:
        if(val_29 < val_1.Count)
        {
            goto label_34;
        }
        
        if(this.emergencyButtonTask == 0)
        {
                return;
        }
        
        this.万七丈业丝且下丞与.Add(item:  this.emergencyButtonTask);
        this.emergencyButtonTask.丝丏东丛丂三不东丆(丈丈专丁专丟万丟丏:  0, 三专三丐丁世丑丁丅:  0);
    }
    private void Update()
    {
        this.世丁丆丛丆丂丆丟丙();
        if(this.丕专与且七丏丅业上.丗丛一丑丂丏丘上下() != true)
        {
                this.下丏上专专丛丂丌丕();
        }
        
        this.丑丙业业世丁丄丅东();
    }
    private void 世丁丆丛丆丂丆丟丙()
    {
        var val_28;
        var val_29;
        var val_30;
        WeaponManager val_31;
        float val_32;
        var val_33;
        var val_34;
        System.Collections.Generic.List<PlayerTaskImposterMode> val_35;
        var val_36;
        float val_37;
        var val_38;
        val_28 = 1152921505286238208;
        val_29 = null;
        val_29 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        val_31 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_9;
        }
        
        val_31 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_31 == null)
        {
            goto label_10;
        }
        
        label_9:
        if(丑丈上东丗丐丆世上() != false)
        {
                val_32 = this.且丁丕丕丞且丗丝丙;
            if(val_32 > 0f)
        {
                if(SabotageImposterModeController.丆丕丝丒不丙且丐丗.业东东丞专丒丛不丕() == false)
        {
            goto label_15;
        }
        
        }
        
        }
        
        val_33 = null;
        val_33 = null;
        if(丑丈上东丗丐丆世上() != true)
        {
                if(SabotageImposterModeController.丆丕丝丒不丙且丐丗.业东东丞专丒丛不丕() == true)
        {
            goto label_52;
        }
        
        }
        
        val_34 = null;
        val_34 = null;
        val_35 = 0;
        if(丟东丘丏上世且上丕() != true)
        {
                val_35 = this.万七丈业丝且下丞与;
        }
        
        if(SabotageImposterModeController.丆丕丝丒不丙且丐丗.业东东丞专丒丛不丕() != false)
        {
                val_35 = SabotageImposterModeController.丆丕丝丒不丙且丐丗.与丂丑丁丂专三丙丌();
        }
        
        if(val_35 == null)
        {
            goto label_52;
        }
        
        val_36 = null;
        val_36 = null;
        UnityEngine.Vector3 val_9 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_37 = val_9.x;
        if(val_35.Count < 1)
        {
            goto label_39;
        }
        
        val_28 = 1152921537569174416;
        PlayerTaskImposterMode val_11 = val_35.Item[0];
        if(val_11.丕丞丌万丞丄丘且丘 == true)
        {
            goto label_39;
        }
        
        PlayerTaskImposterMode val_12 = val_35.Item[0];
        if(val_12.dontFollow == false)
        {
            goto label_41;
        }
        
        label_39:
        val_38 = 0;
        label_63:
        if(val_35.Count > 1)
        {
                do
        {
            PlayerTaskImposterMode val_14 = val_35.Item[1];
            if(val_14.丕丞丌万丞丄丘且丘 != true)
        {
                PlayerTaskImposterMode val_15 = val_35.Item[1];
            if(val_15.dontFollow != true)
        {
                UnityEngine.Vector3 val_17 = val_35.Item[1].世丈一丝丒且不丈丙();
            val_32 = val_37;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_32, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z})) < 0)
        {
                val_38 = 1;
        }
        
        }
        
        }
        
            val_28 = 1 + 1;
        }
        while(val_28 < val_35.Count);
        
        }
        
        if(val_38 == 1)
        {
            goto label_52;
        }
        
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  1f);
        typeof(Player_move_c).__il2cppRuntimeField_168.专丗丑上丝万丘丁丅(丞上世与丈业丒丕不:  val_35.Item[1].transform, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        return;
        label_15:
        val_37 = this.且丁丕丕丞且丗丝丙;
        float val_24 = UnityEngine.Time.deltaTime;
        val_24 = val_37 - val_24;
        this.且丁丕丕丞且丗丝丙 = val_24;
        label_52:
        typeof(Player_move_c).__il2cppRuntimeField_168.一专丘东三丞东丁三();
        return;
        label_41:
        UnityEngine.Vector3 val_26 = val_35.Item[0].世丈一丝丒且不丈丙();
        float val_27 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_37, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        goto label_63;
        label_10:
    }
    internal void 上专世丙丄丄丅万丟()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.一丛万上丛不七万丁());
    }
    private System.Collections.IEnumerator 一丛万上丛不七万丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerTaskImposterModeController.丙丗丘丛七丅万丝丞();
    }
    private void 下丏上专专丛丂丌丕()
    {
        var val_12;
        int val_13;
        int val_14;
        与丅丕丈丘东丝世丟 val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_12 = 0;
        val_13 = 0;
        val_14 = 0;
        goto label_3;
        label_27:
        val_15 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0];
        val_16 = null;
        val_16 = null;
        if((val_15.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丒东下丈且丕丌丞七)) != false)
        {
                val_17 = null;
            val_17 = null;
            object val_5 = val_15.丑丗三丛丛丆丟丌丆().Item[GameConnect.丒东下丈且丕丌丞七];
            if(null != 1)
        {
                val_14 = this.taskNumberForPlayer + val_14;
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        if((val_15.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.上丛万丏丄不丗下丐)) != false)
        {
                val_19 = null;
            val_19 = null;
            val_15 = val_15.丑丗三丛丛丆丟丌丆().Item[GameConnect.上丛万丏丄不丗下丐];
            val_13 = (System.Convert.ToInt32(value:  val_15)) + val_13;
        }
        
        val_12 = 1;
        label_3:
        if(val_12 < val_1.Length)
        {
            goto label_27;
        }
        
        if((((val_13 == val_14) && (val_13 != 0)) && (val_14 != 0)) && (this.丕专与且七丏丅业上.丞丕丟丘万丁上丌一() != false))
        {
                this.<丌丙丏丕三一三丁丒>k__BackingField = true;
            if(this.丁一东丈丙丒且丒丌 != null)
        {
                this.丁一东丈丙丒且丒丌.Invoke();
        }
        
        }
        
        this.丁丟丏丁业世且世世(下一七丟专丗丒丆三:  val_13, 丄丄丝丁丂专丄不丅:  val_14);
    }
    private void 丁丟丏丁业世且世世(int 下一七丟专丗丒丆三, int 丄丄丝丁丂专丄不丅)
    {
        int val_8;
        string val_9;
        var val_10;
        System.Func<PlayerTaskImposterMode, System.Boolean> val_12;
        val_8 = 丄丄丝丁丂专丄不丅;
        val_9 = this;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUIPart_Imposter.__il2cppRuntimeField_castClass.SetActive(value:  true);
        if(1179403647 == 0)
        {
            goto label_9;
        }
        
        if(val_8 == 0)
        {
            goto label_10;
        }
        
        label_12:
        float val_8 = (float)下一七丟专丗丒丆三;
        val_8 = val_8 / (float)val_8;
        goto label_11;
        label_9:
        if(val_8 != 0)
        {
            goto label_12;
        }
        
        label_10:
        label_11:
        fillAmount = 0f;
        val_10 = null;
        val_10 = null;
        val_12 = PlayerTaskImposterModeController.<>c.<>9__41_0;
        if(val_12 == null)
        {
                System.Func<PlayerTaskImposterMode, System.Boolean> val_2 = null;
            val_12 = val_2;
            val_2 = new System.Func<PlayerTaskImposterMode, System.Boolean>(object:  PlayerTaskImposterModeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PlayerTaskImposterModeController.<>c::丁七世丟专万丆丆七(PlayerTaskImposterMode 三丟东丕丄丄下下丑));
            PlayerTaskImposterModeController.<>c.<>9__41_0 = val_12;
        }
        
        val_9 = "{0}/{1}";
        InGameGUIPart_Imposter.__il2cppRuntimeField_generic_class.text = System.String.Format(format:  val_9, arg0:  System.Linq.Enumerable.Count<PlayerTaskImposterMode>(source:  this.万七丈业丝且下丞与, predicate:  val_2), arg1:  this.万七丈业丝且下丞与.Count - 1);
        val_8 = System.String.Format(format:  val_9, arg0:  下一七丟专丗丒丆三, arg1:  val_8);
        text = val_8;
    }
    private void 丄三丙丄丞东丕丒丝(int 三专三丐丁世丑丁丅)
    {
        var val_9;
        var val_10;
        var val_11;
        object val_12;
        object val_13;
        var val_14;
        三专三丐丁世丑丁丅 = 三专三丐丁世丑丁丅 + 1;
        三丅丄不丂丝丕丐与(三专三丐丁世丑丁丅:  三专三丐丁世丑丁丅);
        Play();
        ExitGames.Client.Photon.Hashtable val_2 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆();
        val_9 = null;
        val_9 = null;
        val_10 = null;
        if((val_2.ContainsKey(key:  GameConnect.上丛万丏丄不丗下丐)) != false)
        {
                val_11 = null;
            val_12 = GameConnect.上丛万丏丄不丗下丐;
            val_13 = (System.Convert.ToInt32(value:  val_2.Item[GameConnect.上丛万丏丄不丗下丐])) + 1.ToString();
        }
        else
        {
                val_14 = null;
            val_12 = GameConnect.上丛万丏丄不丗下丐;
            val_13 = "1";
        }
        
        val_2.set_Item(key:  val_12, value:  val_13);
        丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        this.且丁丕丕丞且丗丝丙 = this.三丞专丕丐东丅与丏;
    }
    private void 丑丙业业世丁丄丅东()
    {
        float val_11;
        float val_12;
        var val_42;
        var val_43;
        UnityEngine.Camera val_44;
        float val_45;
        var val_46;
        var val_47;
        var val_48;
        System.Func<UnityEngine.RaycastHit, System.Single> val_50;
        var val_51;
        System.Func<UnityEngine.RaycastHit, PlayerTaskImposterMode> val_53;
        var val_54;
        System.Func<PlayerTaskImposterMode, System.Boolean> val_56;
        var val_57;
        var val_58;
        var val_59;
        SabotageImposterModeController val_60;
        var val_61;
        var val_62;
        var val_63;
        bool val_64;
        var val_65;
        var val_66;
        val_42 = 1152921505207164928;
        val_43 = null;
        val_43 = null;
        val_44 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专;
        if(val_44 == 0)
        {
                return;
        }
        
        float val_7 = (float)UnityEngine.Screen.width * 0.5f;
        val_45 = 0f;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_46 = null;
            val_46 = null;
            float val_41 = (float)UnityEngine.Screen.height;
            float val_40 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_40 = 1f - val_40;
            val_40 = val_40 * val_41;
            val_45 = val_40 * 0.5f;
        }
        
        val_41 = ((float)UnityEngine.Screen.height * 0.5f) + val_45;
        val_47 = null;
        val_47 = null;
        UnityEngine.Ray val_9 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_48 = null;
        val_48 = null;
        val_50 = PlayerTaskImposterModeController.<>c.<>9__43_0;
        if(val_50 == null)
        {
                System.Func<UnityEngine.RaycastHit, System.Single> val_16 = null;
            val_50 = val_16;
            val_16 = new System.Func<UnityEngine.RaycastHit, System.Single>(object:  PlayerTaskImposterModeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Single PlayerTaskImposterModeController.<>c::丟与丙丒丕专万丗丈(UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂));
            PlayerTaskImposterModeController.<>c.<>9__43_0 = val_50;
        }
        
        val_51 = null;
        val_51 = null;
        val_53 = PlayerTaskImposterModeController.<>c.<>9__43_1;
        if(val_53 == null)
        {
                System.Func<UnityEngine.RaycastHit, PlayerTaskImposterMode> val_18 = null;
            val_53 = val_18;
            val_18 = new System.Func<UnityEngine.RaycastHit, PlayerTaskImposterMode>(object:  PlayerTaskImposterModeController.<>c.__il2cppRuntimeField_static_fields, method:  PlayerTaskImposterMode PlayerTaskImposterModeController.<>c::业丏一与不上丒丒且(UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂));
            PlayerTaskImposterModeController.<>c.<>9__43_1 = val_53;
        }
        
        val_54 = null;
        val_54 = null;
        val_56 = PlayerTaskImposterModeController.<>c.<>9__43_2;
        if(val_56 == null)
        {
                System.Func<PlayerTaskImposterMode, System.Boolean> val_20 = null;
            val_56 = val_20;
            val_20 = new System.Func<PlayerTaskImposterMode, System.Boolean>(object:  PlayerTaskImposterModeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PlayerTaskImposterModeController.<>c::下七万东专丄丄丁丛(PlayerTaskImposterMode 丁丂丝不丟丛丟一丂));
            PlayerTaskImposterModeController.<>c.<>9__43_2 = val_56;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_21 = System.Linq.Enumerable.Where<PlayerTaskImposterMode>(source:  System.Linq.Enumerable.Select<UnityEngine.RaycastHit, PlayerTaskImposterMode>(source:  System.Linq.Enumerable.OrderBy<UnityEngine.RaycastHit, System.Single>(source:  UnityEngine.Physics.RaycastAll(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_11, y = val_11, z = val_11}, m_Direction = new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_12}}, maxDistance:  5f, layerMask:  1 << ((UnityEngine.LayerMask.NameToLayer(layerName:  "IgnoreRocketsAndBullets")) & 31)), keySelector:  val_16), selector:  val_18), predicate:  val_20);
        .七东不世业丙世七不 = 0;
        if((System.Linq.Enumerable.Any<PlayerTaskImposterMode>(source:  val_21)) != false)
        {
                .七东不世业丙世七不 = System.Linq.Enumerable.First<PlayerTaskImposterMode>(source:  val_21);
        }
        
        this.丏丏丝丐丙与丏东世 = this.万七丈业丝且下丞与.FindIndex(match:  new System.Predicate<PlayerTaskImposterMode>(object:  new PlayerTaskImposterModeController.丆世丒一丈专丆丆七(), method:  System.Boolean PlayerTaskImposterModeController.丆世丒一丈专丆丆七::丄丆专丆丏丆丛丕东(PlayerTaskImposterMode 三丟东丕丄丄下下丑)));
        if((((PlayerTaskImposterModeController.丆世丒一丈专丆丆七)[1152921537609012048].七东不世业丙世七不 == 0) || ((PlayerTaskImposterModeController.丆世丒一丈专丆丆七)[1152921537609012048].七东不世业丙世七不.taskType != 3)) || (SabotageImposterModeController.丆丕丝丒不丙且丐丗.东与丈丗与丘丟丘丟() == true))
        {
            goto label_49;
        }
        
        val_57 = null;
        val_57 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_49;
        }
        
        val_58 = null;
        val_58 = null;
        if(丑丈上东丗丐丆世上() == false)
        {
            goto label_49;
        }
        
        val_42 = 1;
        goto label_50;
        label_49:
        val_59 = null;
        val_59 = null;
        if(丟东丘丏上世且上丕() == false)
        {
            goto label_55;
        }
        
        this.丏丏丝丐丙与丏东世 = 0;
        val_42 = 0;
        val_60 = SabotageImposterModeController.丆丕丝丒不丙且丐丗;
        goto label_57;
        label_55:
        val_42 = 0;
        label_50:
        val_60 = SabotageImposterModeController.丆丕丝丒不丙且丐丗;
        if(this.丏丏丝丐丙与丏东世 == 1)
        {
            goto label_57;
        }
        
        if(val_60.业东东丞专丒丛不丕() == true)
        {
            goto label_88;
        }
        
        val_61 = null;
        val_61 = null;
        if(丟东丘丏上世且上丕() == false)
        {
            goto label_64;
        }
        
        val_62 = 0;
        goto label_65;
        label_57:
        val_60.丆世丑与丗丁丐一丌(七东不世业丙世七不:  (PlayerTaskImposterModeController.丆世丒一丈专丆丆七)[1152921537609012048].七东不世业丙世七不);
        this.丕三不上丝七丐丂丝();
        label_88:
        if(this.丏丏丝丐丙与丏东世 != 1)
        {
                if(SabotageImposterModeController.丆丕丝丒不丙且丐丗.业东东丞专丒丛不丕() == false)
        {
            goto label_69;
        }
        
        }
        
        val_63 = SabotageImposterModeController.丆丕丝丒不丙且丐丗.世丈三丐丛丐三丙丒() ^ 1;
        goto label_71;
        label_69:
        val_63 = 0;
        label_71:
        val_44 = (PlayerTaskImposterModeController.丆世丒一丈专丆丆七)[1152921537609012048].七东不世业丙世七不;
        if(val_44 == 0)
        {
            goto label_74;
        }
        
        val_44 = (PlayerTaskImposterModeController.丆世丒一丈专丆丆七)[1152921537609012048].七东不世业丙世七不;
        var val_36 = ((PlayerTaskImposterModeController.丆世丒一丈专丆丆七)[1152921537609012048].七东不世业丙世七不.丕丞丌万丞丄丘且丘 == true) ? 1 : 0;
        val_36 = val_63 | val_36;
        if((val_36 & 1) == 0)
        {
            goto label_76;
        }
        
        label_74:
        val_64 = 0;
        goto label_77;
        label_76:
        if(this.丏丏丝丐丙与丏东世 == 1)
        {
            goto label_78;
        }
        
        val_65 = null;
        val_65 = null;
        val_44 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_44 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(丟东丘丏上世且上丕() == false)
        {
            goto label_83;
        }
        
        val_66 = 0;
        goto label_85;
        label_78:
        val_66 = 1;
        goto label_85;
        label_64:
        var val_38 = ((PlayerTaskImposterModeController.丆世丒一丈专丆丆七)[1152921537609012048].七东不世业丙世七不.taskType != 3) ? 1 : 0;
        label_65:
        val_38 = val_38 | val_42;
        if(val_38 == 0)
        {
            goto label_88;
        }
        
        this.不丐上丙丄丅丙业不(丞世不丒下上上丝丑:  this.丏丏丝丐丙与丏东世);
        goto label_88;
        label_83:
        label_85:
        val_64 = (((PlayerTaskImposterModeController.丆世丒一丈专丆丆七)[1152921537609012048].七东不世业丙世七不.taskType != 3) ? 1 : 0) | val_42;
        label_77:
        this.<万丕业丁丌一东丌丒>k__BackingField = val_64;
    }
    internal void 上不丆七丌丟与丛丅()
    {
        if(this.丏丏丝丐丙与丏东世 != 1)
        {
                if(SabotageImposterModeController.丆丕丝丒不丙且丐丗.业东东丞专丒丛不丕() == false)
        {
            goto label_3;
        }
        
        }
        
        SabotageImposterModeController.丆丕丝丒不丙且丐丗.万丏丕丑下上丕丈丂();
        return;
        label_3:
        东上业与丐丝丁万丛(万不且且丛丆东丒业:  this.万七丈业丝且下丞与.Item[this.丏丏丝丐丙与丏东世]);
        this.不丆世丅丘东丙丐丂 = true;
    }
    internal void 三东三丐下丅丐一万()
    {
        this.不丆世丅丘东丙丐丂 = false;
        this.丒且下上丑丆七丟丕 = (float)UnityEngine.Time.frameCount;
    }
    private void 不丐上丙丄丅丙业不(int 丞世不丒下上上丝丑)
    {
        this.万七丈业丝且下丞与.Item[丞世不丒下上上丝丑].丄丟东丑下丄万上丄();
    }
    private void 丕三不上丝七丐丂丝()
    {
        goto label_1;
        label_5:
        this.万七丈业丝且下丞与.Item[0].业七丈丁丂丌业丝下();
        0 = 1;
        label_1:
        if(0 < this.万七丈业丝且下丞与.Count)
        {
            goto label_5;
        }
    
    }
    internal void 丟丝丞专丂上丁丝世()
    {
        this.且丁丕丕丞且丗丝丙 = this.三丞专丕丐东丅与丏;
    }
    public PlayerTaskImposterModeController()
    {
        this.taskNumberForPlayer = 2;
        this.万七丈业丝且下丞与 = new System.Collections.Generic.List<PlayerTaskImposterMode>();
        System.Collections.Generic.Dictionary<丌不丕丁丁东且丈丑, System.Int32> val_2 = new System.Collections.Generic.Dictionary<丌不丕丁丁东且丈丑, System.Int32>();
        if(val_2 != null)
        {
                val_2.Add(key:  1, value:  2);
            val_2.Add(key:  2, value:  2);
            val_2.Add(key:  4, value:  2);
            val_2.Add(key:  5, value:  2);
            val_2.Add(key:  6, value:  2);
            val_2.Add(key:  7, value:  2);
            val_2.Add(key:  8, value:  2);
            val_2.Add(key:  9, value:  2);
            val_2.Add(key:  10, value:  2);
            val_2.Add(key:  11, value:  2);
            val_2.Add(key:  12, value:  2);
            val_2.Add(key:  13, value:  2);
            val_2.Add(key:  14, value:  2);
            val_2.Add(key:  15, value:  2);
            val_2.Add(key:  16, value:  2);
            val_2.Add(key:  17, value:  2);
        }
        else
        {
                val_2.Add(key:  1, value:  2);
            val_2.Add(key:  2, value:  2);
            val_2.Add(key:  4, value:  2);
            val_2.Add(key:  5, value:  2);
            val_2.Add(key:  6, value:  2);
            val_2.Add(key:  7, value:  2);
            val_2.Add(key:  8, value:  2);
            val_2.Add(key:  9, value:  2);
            val_2.Add(key:  10, value:  2);
            val_2.Add(key:  11, value:  2);
            val_2.Add(key:  12, value:  2);
            val_2.Add(key:  13, value:  2);
            val_2.Add(key:  14, value:  2);
            val_2.Add(key:  15, value:  2);
            val_2.Add(key:  16, value:  2);
            val_2.Add(key:  17, value:  2);
        }
        
        val_2.Add(key:  18, value:  2);
        this.下丟丘专丂下丑丁世 = val_2;
        this.丏丏丝丐丙与丏东世 = 0;
        this.三丞专丕丐东丅与丏 = 60.25f;
    }
    private static PlayerTaskImposterModeController()
    {
    
    }

}
