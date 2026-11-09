using UnityEngine;
internal sealed class SabotageImposterModeController : MonoBehaviour
{
    // Fields
    private const string 且丕丁丙丌丂丄丄丄 = "sbtype";
    private const string 丘丑世万丁不丝上丆 = "sbint";
    private System.Collections.Generic.List<UnityEngine.Coroutine> 不丞丆丐丛三丝丏与;
    private float _startSabotageLockTime;
    private float _afterVoteLockTime;
    private float _doorSabotageReloadingTime;
    private float _sabotageLockTimeAfterDoorSabotage;
    private float _timeLockAfterDeactivateSabotage;
    private int 丞丈丝丁下七专丘专;
    private double 丐丑丅丗丗与丁东丅;
    private System.Collections.Generic.List<SabotageImposterModeController.SabotageTask> sabotageTasks;
    private int 东不一丕丟一上丅三;
    private int 丂专丙一丒与东三丝;
    internal System.Action 丄丘丅不三东丙丆七;
    internal static SabotageImposterModeController 丆丕丝丒不丙且丐丗;
    private ImposterModeController 丙下丆与丁丘丙丕丙;
    
    // Properties
    internal bool 丐七丄且东下丛不业 { get; }
    private int 丐丆丁丘七丑上丙丄 { get; set; }
    internal bool 丐与专丛丑丅不且丅 { get; }
    
    // Methods
    internal bool 业东东丞专丒丛不丕()
    {
        int val_2 = this.东不一丕丟一上丅三;
        val_2 = val_2 >> 31;
        return (bool)val_2 ^ 1;
    }
    private int 且丑丂丁三专丛丂一()
    {
        return (int)this.东不一丕丟一上丅三;
    }
    private void 万丒丕上丏七丟丙世(int 丙业与丙丗丝不丈东)
    {
        this.东不一丕丟一上丅三 = 丙业与丙丗丝不丈东;
    }
    internal bool 东与丈丗与丘丟丘丟()
    {
        return (bool)(this.东不一丕丟一上丅三 != 1) ? 1 : 0;
    }
    private void Awake()
    {
        SabotageImposterModeController val_17 = this;
        SabotageImposterModeController.丆丕丝丒不丙且丐丗 = val_17;
        this._startSabotageLockTime = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().万丘丂东丅丘丄一七();
        this._afterVoteLockTime = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().万丘丂东丅丘丄一七();
        this._doorSabotageReloadingTime = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().丂丌与丑世且丑一七();
        this._timeLockAfterDeactivateSabotage = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().丏丁东丞丐丟丕世丑();
        if(this.sabotageTasks == null)
        {
                return;
        }
        
        if(this.sabotageTasks.Count >= 1)
        {
                SabotageTask val_10 = this.sabotageTasks.Item[0];
            val_10.secondsForComplete = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().丝丒业世三丛丘丙丗();
        }
        
        if(this.sabotageTasks.Count < 2)
        {
                return;
        }
        
        val_17 = this.sabotageTasks.Item[1];
        val_14.secondsForComplete = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘().丝丘丂下丕业丅业丂();
    }
    private void Start()
    {
        var val_2;
        OnlineModeController val_3;
        val_2 = null;
        val_2 = null;
        val_3 = GameController.onlineMode;
        this.丙下丆与丁丘丙丕丙 = (null == null) ? (val_3) : 0;
    }
    internal void 丘上丐世丆丑且丞丒()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈丙丐丑与丞丆丌丁());
    }
    private System.Collections.IEnumerator 丈丙丐丑与丞丆丌丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SabotageImposterModeController.且丏上丅丕丞下丅不();
    }
    private void Update()
    {
        this.下下丝七专丙丘专不();
        this.不丄丂与业丗丗专三();
        this.上丝一七丄上三丐下();
    }
    internal void 一世丘丐世丘世下丏(SabotageImposterModeController.三与丕东丗东丏丞业 丒丆不且上东业万七)
    {
        if(this.东不一丕丟一上丅三 != 1)
        {
                return;
        }
        
        if(this.东东丆丟丗丒丏丁丁() != false)
        {
                return;
        }
        
        this.丞不丆丄业七丁丅丑(丞世不丒下上上丝丑:  this.丟丅丝丑丒丑下业丌(丒丆不且上东业万七:  丒丆不且上东业万七), 丘丂丕丝丛丏丑丟丘:  0);
    }
    private void 丞不丆丄业七丁丅丑(int 丞世不丒下上上丝丑, int 丘丂丕丝丛丏丑丟丘 = 0)
    {
        SabotageTask val_1 = this.sabotageTasks.Item[丞世不丒下上上丝丑];
        this.丑一业丈丁丁丝三丗(丒丆不且上东业万七:  val_1.sabotageType, 丘丂丕丝丛丏丑丟丘:  丘丂丕丝丛丏丑丟丘, 业万丂上业丙一与丑:  true);
    }
    private void 丒一七丌丁上上万丏(int 丞世不丒下上上丝丑)
    {
        var val_16;
        var val_17;
        var val_18;
        this.东不一丕丟一上丅三 = 丞世不丒下上上丝丑;
        SabotageTask val_1 = this.sabotageTasks.Item[丞世不丒下上上丝丑];
        val_1.sabotageIsActive = true;
        SabotageTask val_2 = this.sabotageTasks.Item[丞世不丒下上上丝丑];
        val_16 = 0;
        goto label_5;
        label_16:
        val_2.tasks.Item[0].丏丛专丘丄且丑下丑();
        val_2.tasks.Item[0].丝丏东丛丂三不东丆(丈丈专丁专丟万丟丏:  new System.Action<System.Int32>(object:  this, method:  System.Void SabotageImposterModeController::上丗丈不丂丝下上丈(int 丞世不丒下上上丝丑)), 三专三丐丁世丑丁丅:  0);
        typeof(InGameGUIPart_Imposter).__il2cppRuntimeField_28.丛丘丗丆丌丏不丑专(万不且且丛丆东丒业:  val_2.tasks.Item[0].gameObject, 丁丅丈丌丟世丗丗丟:  21);
        val_16 = 1;
        label_5:
        if(val_16 < val_2.tasks.Count)
        {
            goto label_16;
        }
        
        SabotageTask val_9 = this.sabotageTasks.Item[丞世不丒下上上丝丑];
        this.丐丑丅丗丗与丁东丅 = (double)UnityEngine.Mathf.Max(a:  this.丞丈丝丁下七专丘专, b:  val_9.secondsForComplete);
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                SabotageTask val_12 = this.sabotageTasks.Item[丞世不丒下上上丝丑];
            float val_16 = (float)val_12.secondsForComplete;
            val_16 = val_16 + 5f;
            0x1000000024724000.__il2cppRuntimeField_1C = val_16;
            Play();
        }
        
        float val_17 = (float)val_13.secondsForComplete;
        val_17 = this._timeLockAfterDeactivateSabotage + val_17;
        this.sabotageTasks.Item[丞世不丒下上上丝丑].丂与上不丂丑一丐东(丂丅丄丈下与一丌丆:  val_17);
        CloseTaskUI();
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        UnityEngine.Color val_15 = UnityEngine.Color.red;
        typeof(Player_move_c).__il2cppRuntimeField_168.丒丗三丗东丌丘丅东(丕丟上万上且一丑三:  new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a});
    }
    private void 上丗丈不丂丝下上丈(int 丞世不丒下上上丝丑)
    {
        var val_7;
        int val_8;
        var val_9;
        var val_10;
        val_7 = 0;
        val_8 = 0;
        val_9 = 1;
        goto label_1;
        label_13:
        SabotageTask val_1 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        PlayerTaskImposterMode val_2 = val_1.tasks.Item[0];
        if(val_2.丕丞丌万丞丄丘且丘 != false)
        {
                val_10 = 1;
        }
        else
        {
                val_10 = 0;
        }
        
        val_8 = val_10 + val_8;
        val_9 = val_9 & ((val_2.丕丞丌万丞丄丘且丘 == true) ? 1 : 0);
        val_7 = 1;
        label_1:
        SabotageTask val_4 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        if(val_7 < val_4.tasks.Count)
        {
            goto label_13;
        }
        
        if((val_9 & 1) != 0)
        {
                this.丑一业丈丁丁丝三丗(丒丆不且上东业万七:  0, 丘丂丕丝丛丏丑丟丘:  0, 业万丂上业丙一与丑:  false);
            this.丈下丕丄丄不丂下三();
            return;
        }
        
        SabotageTask val_6 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        this.丑一业丈丁丁丝三丗(丒丆不且上东业万七:  val_6.sabotageType, 丘丂丕丝丛丏丑丟丘:  val_8, 业万丂上业丙一与丑:  false);
    }
    private void 丈丅丁丂与丐丑丟万(int 丘丂丕丝丛丏丑丟丘)
    {
        var val_26;
        System.Collections.Generic.List<PlayerTaskImposterMode> val_27;
        int val_28;
        var val_29;
        val_26 = 1152921537615244432;
        SabotageTask val_1 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        val_27 = val_1.tasks;
        if(val_27.Count == 0)
        {
                return;
        }
        
        string val_3 = System.Convert.ToString(value:  丘丂丕丝丛丏丑丟丘, toBase:  2);
        SabotageTask val_5 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        System.Collections.BitArray val_8 = new System.Collections.BitArray(length:  UnityEngine.Mathf.Max(a:  val_3.Length, b:  val_5.tasks.Count));
        val_28 = this.东不一丕丟一上丅三;
        SabotageTask val_9 = this.sabotageTasks.Item[val_28];
        int val_12 = val_9.tasks.Count - val_3.Length;
        if(val_12 >= 1)
        {
                var val_26 = 0;
            do
        {
            val_8.set_Item(index:  0, value:  false);
            val_26 = val_26 + 1;
        }
        while(val_12 != val_26);
        
        }
        
        val_29 = 0;
        goto label_20;
        label_24:
        val_28 = val_3.Chars[0];
        val_8.set_Item(index:  val_12 + val_29, value:  ((val_28 & 65535) == '1') ? 1 : 0);
        val_29 = 1;
        label_20:
        if(val_29 < val_3.Length)
        {
            goto label_24;
        }
        
        SabotageTask val_18 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        val_27 = 0;
        val_26 = 0;
        goto label_27;
        label_43:
        val_28 = val_18.tasks.Count;
        if((val_8.Item[val_28 + val_26]) != false)
        {
                val_28 = val_18.tasks.Item[0];
            if(val_22.丕丞丌万丞丄丘且丘 != true)
        {
                val_28 = val_18.tasks.Item[0];
            val_28.丄三丙丄丞东丕丒丝();
            if(val_27 == this.丂专丙一丒与东三丝)
        {
                val_28 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_28 != 0)
        {
                val_28 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 856];
            val_28 = InGameGUI.丙丞专丌丁丞与不丐.丙下丆与丁丘丙丕丙;
            CloseTaskUI();
        }
        
        }
        
        }
        
        }
        
        val_27 = 1;
        val_26 = -1;
        label_27:
        if(val_27 < val_18.tasks.Count)
        {
            goto label_43;
        }
    
    }
    private int 丟丅丝丑丒丑下业丌(SabotageImposterModeController.三与丕东丗东丏丞业 丒丆不且上东业万七)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        val_5 = 0;
        goto label_1;
        label_5:
        SabotageTask val_1 = this.sabotageTasks.Item[0];
        val_4 = 1;
        label_1:
        if(val_4 < this.sabotageTasks.Count)
        {
            goto label_5;
        }
        
        return (int)(val_1.sabotageType == 丒丆不且上东业万七) ? (val_4) : (val_5);
    }
    private void 下下丝七专丙丘专不()
    {
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(this.东东丆丟丗丒丏丁丁() == true)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_4 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        if((val_4.ContainsKey(key:  "sbtype")) == false)
        {
                return;
        }
        
        object val_6 = val_4.Item["sbtype"];
        if(null != null)
        {
                if(this.东不一丕丟一上丅三 == 1)
        {
                int val_7 = this.丟丅丝丑丒丑下业丌(丒丆不且上东业万七:  null);
            this.东不一丕丟一上丅三 = val_7;
            this.丒一七丌丁上上万丏(丞世不丒下上上丝丑:  val_7);
        }
        
            if((val_4.ContainsKey(key:  "sbint")) == false)
        {
                return;
        }
        
            object val_9 = val_4.Item["sbint"];
            this.丈丅丁丂与丐丑丟万(丘丂丕丝丛丏丑丟丘:  21884928);
            return;
        }
        
        if(this.东不一丕丟一上丅三 == 1)
        {
                return;
        }
        
        this.丈下丕丄丄不丂下三();
    }
    internal void 丞丌丗丒丂丟丙三丘(int 丂丙上丁丗与丆业七, double 一下丗丌丒丏不丘不)
    {
        var val_21;
        System.Predicate<T> val_22;
        EventDelegate val_23;
        float val_24;
        var val_25;
        double val_21 = 一下丗丌丒丏不丘不;
        SabotageImposterModeController.丟丑不七不丆业丐丛 val_1 = new SabotageImposterModeController.丟丑不七不丆业丐丛();
        if(val_1 != null)
        {
                val_21 = val_1;
            .丂丙上丁丗与丆业七 = 丂丙上丁丗与丆业七;
        }
        else
        {
                val_21 = 16;
            mem[16] = 丂丙上丁丗与丆业七;
        }
        
        .丝且与丝丒丟万丁专 = this;
        val_22 = 1152921504616751104;
        val_23 = 1152921537617161952;
        int val_23 = this.sabotageTasks.FindIndex(match:  new System.Predicate<SabotageTask>(object:  val_1, method:  System.Boolean SabotageImposterModeController.丟丑不七不丆业丐丛::丕丒丈丏丕丐丄万丆(SabotageImposterModeController.SabotageTask 三丟东丕丄丄下下丑)));
        SabotageTask val_4 = this.sabotageTasks.Item[val_23];
        double val_5 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_5 = val_5 - val_21;
        val_21 = (double)val_4.secondsForComplete - val_5;
        val_24 = (float)val_21;
        SabotageTask val_6 = this.sabotageTasks.Item[val_23];
        if(System.Math.Abs(val_24) > (float)val_6.secondsForComplete)
        {
                SabotageTask val_7 = this.sabotageTasks.Item[val_23];
            val_24 = (float)val_7.secondsForComplete;
        }
        
        if(val_24 < 0)
        {
                return;
        }
        
        System.Predicate<SabotageTask> val_8 = null;
        val_22 = val_8;
        val_8 = new System.Predicate<SabotageTask>(object:  val_1, method:  System.Boolean SabotageImposterModeController.丟丑不七不丆业丐丛::丕丈丄不业丕丐业专(SabotageImposterModeController.SabotageTask 三丟东丕丄丄下下丑));
        int val_9 = this.sabotageTasks.FindIndex(match:  val_8);
        if(val_9 == 1)
        {
                return;
        }
        
        SabotageTask val_10 = this.sabotageTasks.Item[val_23];
        val_25 = 0;
        goto label_20;
        label_24:
        val_23 = val_10.roomDoors.Item[0];
        val_23.丏专丆丌丕丒丌丁丘();
        val_25 = 1;
        label_20:
        if(val_25 < val_10.roomDoors.Count)
        {
            goto label_24;
        }
        
        if(val_23 != 1)
        {
                val_23 = val_23 - 2;
            if(this.不丞丆丐丛三丝丏与.Item[val_23] == null)
        {
                EventDelegate val_15 = null;
            val_23 = val_15;
            val_15 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void SabotageImposterModeController.丟丑不七不丆业丐丛::丐丈丒三丙丕丕一且()));
            this.不丞丆丐丛三丝丏与.set_Item(index:  val_23, value:  this.StartCoroutine(routine:  val_15.SabotageTimeCoroutine(丂三丟丂丈丐丆丗丟:  val_24, 东丛三丌丂三且丝丂:  val_15)));
        }
        
        }
        
        SabotageTask val_20 = this.sabotageTasks.Item[val_9];
        float val_24 = (float)val_20.secondsForComplete;
        val_24 = this._doorSabotageReloadingTime + val_24;
        Item[val_21 - 1].丁丛丄丞丌丂丄且一(丂三丟丂丈丐丆丗丟:  val_24);
        丁丛丄丞丌丂丄且一(丂三丟丂丈丐丆丗丟:  this._sabotageLockTimeAfterDoorSabotage);
        丁丛丄丞丌丂丄且一(丂三丟丂丈丐丆丗丟:  this._sabotageLockTimeAfterDoorSabotage);
    }
    internal void 丞丛丑丁丂丒丄下与()
    {
        this.丈下丕丄丄不丂下三();
    }
    private void 丈下丕丄丄不丂下三()
    {
        var val_9;
        var val_10;
        var val_11;
        if(this.东不一丕丟一上丅三 == 1)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丟丝丞专丂上丁丝世();
        SabotageTask val_1 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        if((val_1.tasks != null) && (val_1.tasks.Count >= 1))
        {
                var val_9 = 0;
            do
        {
            PlayerTaskImposterMode val_3 = val_1.tasks.Item[0];
            if(val_3.丕丞丌万丞丄丘且丘 != true)
        {
                val_1.tasks.Item[0].丄三丙丄丞东丕丒丝();
        }
        
            val_9 = val_9 + 1;
            int val_5 = val_1.tasks.Count;
        }
        while(val_9 < val_5);
        
        }
        
        val_5.丗丝丝丙丅东丝丂丙();
        this.东不一丕丟一上丅三 = 0;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                Stop();
            CloseTaskUI();
        }
        
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_11 = null;
            val_11 = null;
            UnityEngine.Color val_8 = UnityEngine.Color.white;
            typeof(Player_move_c).__il2cppRuntimeField_168.丒丗三丗东丌丘丅东(丕丟上万上且一丑三:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
        }
        
        typeof(Player_move_c).__il2cppRuntimeField_168.丂与上不丂丑一丐东(丂丅丄丈下与一丌丆:  this._timeLockAfterDeactivateSabotage);
    }
    private void 丑一业丈丁丁丝三丗(SabotageImposterModeController.三与丕东丗东丏丞业 丒丆不且上东业万七, int 丘丂丕丝丛丏丑丟丘, bool 业万丂上业丙一与丑)
    {
        var val_10;
        ExitGames.Client.Photon.Hashtable val_11;
        var val_12;
        var val_13;
        ExitGames.Client.Photon.Hashtable val_14;
        ExitGames.Client.Photon.Hashtable val_15;
        val_11 = this;
        if(this.东不一丕丟一上丅三 == 1)
        {
                if(业万丂上业丙一与丑 == false)
        {
                return;
        }
        
        }
        
        ExitGames.Client.Photon.Hashtable val_1 = null;
        val_11 = val_1;
        val_1 = new ExitGames.Client.Photon.Hashtable();
        val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_1.set_Item(key:  "sbtype", value:  丒丆不且上东业万七);
        if((val_10.ContainsKey(key:  "sbint")) != false)
        {
                object val_5 = val_10.Item["sbint"];
        }
        else
        {
                val_12 = 0;
        }
        
        if(((丘丂丕丝丛丏丑丟丘 | 丒丆不且上东业万七) == 0) || (val_12 < 丘丂丕丝丛丏丑丟丘))
        {
            goto label_12;
        }
        
        if(丒丆不且上东业万七 == 0)
        {
            goto label_13;
        }
        
        label_17:
        ExitGames.Client.Photon.Hashtable val_7 = new ExitGames.Client.Photon.Hashtable();
        if(业万丂上业丙一与丑 == false)
        {
            goto label_14;
        }
        
        val_13 = null;
        goto label_15;
        label_12:
        val_1.set_Item(key:  "sbint", value:  丘丂丕丝丛丏丑丟丘);
        if(丒丆不且上东业万七 != 0)
        {
            goto label_17;
        }
        
        label_13:
        世丁与丕丗丟丒丆上 val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_14 = val_11;
        val_15 = 0;
        goto label_21;
        label_14:
        val_13 = null;
        label_15:
        val_7.set_Item(key:  "sbtype", value:  丒丆不且上东业万七);
        val_14 = val_11;
        val_15 = val_7;
        label_21:
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  val_7, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 一且丐丆三丟丝丟丁(bool 丞七丛与丝下一一丆)
    {
        null = null;
        if(丟东丘丏上世且上丕() == false)
        {
                return;
        }
        
        InGameGUIPart_Imposter.__il2cppRuntimeField_interopData.SetActive(value:  丞七丛与丝下一一丆);
    }
    internal bool 世丈三丐丛丐三丙丒()
    {
        var val_1;
        if(this.东不一丕丟一上丅三 == 1)
        {
                return false;
        }
        
        if(this.丂专丙一丒与东三丝 == 1)
        {
                return false;
        }
        
        val_1 = null;
        val_1 = null;
        if(null != 0)
        {
                return 丑丈上东丗丐丆世上();
        }
        
        return 丑丈上东丗丐丆世上();
    }
    internal void 万丏丕丑下上丕丈丂()
    {
        var val_4;
        if(this.东不一丕丟一上丅三 == 1)
        {
                return;
        }
        
        if(this.丂专丙一丒与东三丝 == 1)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(丑丈上东丗丐丆世上() == false)
        {
                return;
        }
        
        SabotageTask val_2 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        东上业与丐丝丁万丛(万不且且丛丆东丒业:  val_2.tasks.Item[this.丂专丙一丒与东三丝]);
    }
    internal void 丆世丑与丗丁丐一丌(PlayerTaskImposterMode 七东不世业丙世七不)
    {
        .七东不世业丙世七不 = 七东不世业丙世七不;
        if(this.东不一丕丟一上丅三 != 1)
        {
                SabotageTask val_2 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
            this.丂专丙一丒与东三丝 = val_2.tasks.FindIndex(match:  new System.Predicate<PlayerTaskImposterMode>(object:  new SabotageImposterModeController.丅三丈世丝丑专丂世(), method:  System.Boolean SabotageImposterModeController.丅三丈世丝丑专丂世::丌丝世丆丛东下丛下(PlayerTaskImposterMode 三丟东丕丄丄下下丑)));
            this.不丐上丙丄丅丙业不();
            return;
        }
        
        this.丂专丙一丒与东三丝 = 0;
        this.丕三不上丝七丐丂丝();
    }
    private void 上丝一七丄上三丐下()
    {
        var val_9;
        System.Func<PlayerTaskImposterMode, System.Boolean> val_11;
        if(this.东不一丕丟一上丅三 == 1)
        {
                return;
        }
        
        SabotageTask val_1 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        if(val_1.sabotageType == 3)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        SabotageTask val_3 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        val_9 = null;
        val_9 = null;
        val_11 = SabotageImposterModeController.<>c.<>9__45_0;
        if(val_11 == null)
        {
                System.Func<PlayerTaskImposterMode, System.Boolean> val_4 = null;
            val_11 = val_4;
            val_4 = new System.Func<PlayerTaskImposterMode, System.Boolean>(object:  SabotageImposterModeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SabotageImposterModeController.<>c::一丙一世丙丏丕万东(PlayerTaskImposterMode 三丟东丕丄丄下下丑));
            SabotageImposterModeController.<>c.<>9__45_0 = val_11;
        }
        
        SabotageTask val_6 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        SabotageTask val_8 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        丑丟丒一东与与一丆(丞上丛丑丕万丕丑丗:  val_8.localizationText, 丑丟丞丗丂丌且一丆:  (int)this.丐丑丅丗丗与丁东丅, 丐七丟丘专丅万丂世:  System.Linq.Enumerable.Count<PlayerTaskImposterMode>(source:  val_3.tasks, predicate:  val_4), 丞丁不丗丙丌三丝丙:  val_6.tasks.Count);
    }
    private void 丗丝丝丙丅东丝丂丙()
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        丒丌丆丁丞七万丟丘();
    }
    private void 不丄丂与业丗丗专三()
    {
        if(this.东不一丕丟一上丅三 == 1)
        {
                return;
        }
        
        if(this.东东丆丟丗丒丏丁丁() == true)
        {
                return;
        }
        
        double val_4 = (double)UnityEngine.Time.deltaTime;
        val_4 = this.丐丑丅丗丗与丁东丅 - val_4;
        this.丐丑丅丗丗与丁东丅 = val_4;
        if(val_4 >= 0)
        {
                return;
        }
        
        SabotageTask val_3 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        if((val_3.isDeadly != false) && (this.丄丘丅不三东丙丆七 != null))
        {
                this.丄丘丅不三东丙丆七.Invoke();
        }
        
        this.丑一业丈丁丁丝三丗(丒丆不且上东业万七:  0, 丘丂丕丝丛丏丑丟丘:  0, 业万丂上业丙一与丑:  false);
    }
    private bool 东东丆丟丗丒丏丁丁()
    {
        ImposterModeController val_4;
        var val_5;
        val_4 = this;
        if(this.丙下丆与丁丘丙丕丙.三丘三丈上丕丆丂一() == 3)
        {
                val_5 = 1;
            return (bool)(val_4.三丘三丈上丕丆丂一() == 4) ? 1 : 0;
        }
        
        val_4 = this.丙下丆与丁丘丙丕丙;
        return (bool)(val_4.三丘三丈上丕丆丂一() == 4) ? 1 : 0;
    }
    private void 不丐上丙丄丅丙业不()
    {
        if(this.东不一丕丟一上丅三 == 1)
        {
                return;
        }
        
        if(this.丂专丙一丒与东三丝 == 1)
        {
                return;
        }
        
        SabotageTask val_1 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        val_1.tasks.Item[this.丂专丙一丒与东三丝].丄丟东丑下丄万上丄();
    }
    private void 丕三不上丝七丐丂丝()
    {
        int val_5;
        var val_6;
        int val_7;
        System.Collections.Generic.List<PlayerTaskImposterMode> val_8;
        val_5 = this.东不一丕丟一上丅三;
        if(val_5 == 1)
        {
                return;
        }
        
        val_6 = 0;
        goto label_2;
        label_10:
        SabotageTask val_1 = this.sabotageTasks.Item[this.东不一丕丟一上丅三];
        val_1.tasks.Item[0].业七丈丁丂丌业丝下();
        val_7 = this.东不一丕丟一上丅三;
        val_6 = 1;
        label_2:
        SabotageTask val_3 = this.sabotageTasks.Item[val_7];
        val_8 = val_3.tasks;
        if(val_6 < val_8.Count)
        {
            goto label_10;
        }
    
    }
    internal System.Collections.Generic.List<PlayerTaskImposterMode> 与丂丑丁丂专三丙丌()
    {
        int val_2;
        System.Collections.Generic.List<PlayerTaskImposterMode> val_3;
        val_2 = this.东不一丕丟一上丅三;
        if(val_2 != 1)
        {
                val_2 = this.sabotageTasks.Item[val_2];
            val_3 = val_1.tasks;
            return (System.Collections.Generic.List<PlayerTaskImposterMode>)val_3;
        }
        
        val_3 = 0;
        return (System.Collections.Generic.List<PlayerTaskImposterMode>)val_3;
    }
    private void 丂与上不丂丑一丐东(float 丂丅丄丈下与一丌丆)
    {
        var val_6;
        InGameGUI val_7;
        val_6 = 1152921504848912384;
        val_7 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_7 == 0)
        {
                return;
        }
        
        if(InGameGUIPart_Imposter.__il2cppRuntimeField_klass != 0)
        {
                丁丛丄丞丌丂丄且一(丂三丟丂丈丐丆丗丟:  丂丅丄丈下与一丌丆);
        }
        
        if(InGameGUIPart_Imposter.__il2cppRuntimeField_fields != 0)
        {
                丁丛丄丞丌丂丄且一(丂三丟丂丈丐丆丗丟:  丂丅丄丈下与一丌丆);
        }
        
        val_7 = 0;
        goto label_22;
        label_26:
        val_6 = Item[0];
        val_6.丁丛丄丞丌丂丄且一(丂三丟丂丈丐丆丗丟:  丂丅丄丈下与一丌丆);
        val_7 = 1;
        label_22:
        if(val_7 < Count)
        {
            goto label_26;
        }
    
    }
    private void 丗丝七七业丆丁上丗(int 丂丙上丁丗与丆业七)
    {
        if(this.东不一丕丟一上丅三 != 1)
        {
                return;
        }
        
        if(丂丙上丁丗与丆业七 < 1)
        {
                return;
        }
        
        if(this.东东丆丟丗丒丏丁丁() == true)
        {
                return;
        }
        
        this.丙下丆与丁丘丙丕丙.sabotageDoorsNetwork.业丐丘万下丁东丑且(丂丙上丁丗与丆业七:  丂丙上丁丗与丆业七);
    }
    private void 丗一丑丆丆东三下丞(int 丂丙上丁丗与丆业七)
    {
        object val_7;
        var val_8;
        SabotageImposterModeController.丛丄丁业且世丝丂丅 val_1 = null;
        val_7 = val_1;
        val_1 = new SabotageImposterModeController.丛丄丁业且世丝丂丅();
        .丂丙上丁丗与丆业七 = 丂丙上丁丗与丆业七;
        SabotageTask val_4 = this.sabotageTasks.Item[this.sabotageTasks.FindIndex(match:  new System.Predicate<SabotageTask>(object:  val_1, method:  System.Boolean SabotageImposterModeController.丛丄丁业且世丝丂丅::与与丆丙东丙丂丘上(SabotageImposterModeController.SabotageTask 三丟东丕丄丄下下丑)))];
        val_8 = 0;
        goto label_5;
        label_9:
        val_7 = val_4.roomDoors.Item[0];
        val_7.三世三东丕下丈万丛();
        val_8 = 1;
        label_5:
        if(val_8 < val_4.roomDoors.Count)
        {
            goto label_9;
        }
    
    }
    public System.Collections.IEnumerator SabotageTimeCoroutine(float 丂三丟丂丈丐丆丗丟, EventDelegate 东丛三丌丂三且丝丂)
    {
        SabotageImposterModeController.丟丒丝丗丏丒东丂丞 val_1 = new SabotageImposterModeController.丟丒丝丗丏丒东丂丞();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
        }
        else
        {
                mem[32] = 丂三丟丂丈丐丆丗丟;
        }
        
        .东丛三丌丂三且丝丂 = 东丛三丌丂三且丝丂;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 上丘丗丕专下丂丟万()
    {
        this.丂与上不丂丑一丐东(丂丅丄丈下与一丌丆:  this._afterVoteLockTime);
    }
    public SabotageImposterModeController()
    {
        this.不丞丆丐丛三丝丏与 = new System.Collections.Generic.List<UnityEngine.Coroutine>();
        this._timeLockAfterDeactivateSabotage = 30f;
        this.丞丈丝丁下七专丘专 = 30;
        this.丐丑丅丗丗与丁东丅 = -1;
        this._startSabotageLockTime = ;
        this._afterVoteLockTime = ;
        this._doorSabotageReloadingTime = 10f;
        this._sabotageLockTimeAfterDoorSabotage = 10f;
        this.sabotageTasks = new System.Collections.Generic.List<SabotageTask>();
        this.东不一丕丟一上丅三 = 0;
        this.丂专丙一丒与东三丝 = 0;
    }
    private void 丏专世且不丘丞一丙()
    {
        this.一世丘丐世丘世下丏(丒丆不且上东业万七:  2);
    }
    private void 丏业丝上丅一东业一()
    {
        this.一世丘丐世丘世下丏(丒丆不且上东业万七:  1);
    }

}
