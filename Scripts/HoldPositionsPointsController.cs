using UnityEngine;
internal sealed class HoldPositionsPointsController : PGBehaviour
{
    // Fields
    public HoldPositionsPoint[] points;
    private double photonTime;
    public int[] currentPointsIndexes;
    private int[] pointsMixedIndexes;
    private int pointCycles;
    public static string nextPointsTimesParamName;
    public static string currentPointsIndexesParamName;
    public static string currentPointsCreateOrdersParamName;
    private int _newestPointCreateOrder;
    private HoldPositionsController 一丌丗丂丝丘丁丄丆;
    private bool 丘丟东业上不丝丂丅;
    public System.Action PointsApplied;
    private bool 丐三丞丗丈丘不丗上;
    private System.Collections.Generic.List<int> 丛下下丗七丝专万丟;
    private System.Collections.Generic.List<int> 丝丟且丒东丞一与丁;
    private bool 丑丐专上世丒丝丈专;
    
    // Properties
    private int 丘丝丕专世不下丘下 { get; set; }
    internal HoldPositionsPoint[] 丏丘丟丑三丞丘丞下 { get; }
    private int 与丒丒一丞下专丗七 { get; }
    
    // Methods
    private int 丙丝丐七业丁万业万()
    {
        return (int)this._newestPointCreateOrder;
    }
    private void 丕丘专丂丙丞专丈丝(int 丙业与丙丗丝不丈东)
    {
        this._newestPointCreateOrder = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        var val_13;
        System.Action<ExitGames.Client.Photon.Hashtable> val_14;
        var val_15;
        System.Action val_16;
        System.Action val_17;
        if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
            goto label_3;
        }
        
        HoldPositionsController val_2 = this.GetComponentInParent<HoldPositionsController>();
        this.一丌丗丂丝丘丁丄丆 = val_2;
        if(val_2 != 0)
        {
                this.一丌丗丂丝丘丁丄丆.pointsController = this;
        }
        
        this.丘丟东业上不丝丂丅 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        val_13 = null;
        val_13 = null;
        val_15 = null;
        if(((System.Delegate.Combine(a:  GameConnect.世丄丄与丌业丑丕丈, b:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void HoldPositionsPointsController::丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_15 = null;
            val_14 = 0;
        }
        
        GameConnect.世丄丄与丌业丑丕丈 = val_14;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void HoldPositionsPointsController::丂丐与丞丗丒丘丑上()))) != null) && (null != null))
        {
                val_16 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_16;
        val_17 = System.Delegate.Combine(a:  this.一丌丗丂丝丘丁丄丆.丂丈丒丂上业丕丘世, b:  new System.Action(object:  this, method:  System.Void HoldPositionsPointsController::丁丝不丙丆专丘丌丙()));
        if(this.一丌丗丂丝丘丁丄丆 == null)
        {
            goto label_17;
        }
        
        if(val_17 != null)
        {
            goto label_18;
        }
        
        goto label_21;
        label_3:
        this.enabled = false;
        return;
        label_17:
        if(val_17 == null)
        {
            goto label_21;
        }
        
        label_18:
        if(null != null)
        {
                val_17 = 0;
        }
        
        label_21:
        this.一丌丗丂丝丘丁丄丆.丂丈丒丂上业丕丘世 = val_17;
    }
    private void 丂丐与丞丗丒丘丑上()
    {
        this.丗不七丗万丘丟丛丞(丟七丑丆丈与丆丙世:  this.points);
    }
    private void FixedUpdate()
    {
        object val_27;
        object val_28;
        var val_29;
        var val_30;
        string val_31;
        string val_32;
        var val_33;
        var val_34;
        var val_35;
        val_27 = this;
        bool val_1 = UnityEngine.Input.GetKeyDown(key:  121);
        if(val_1 == false)
        {
                return;
        }
        
        val_28 = "Current local points: ";
        val_29 = 0;
        goto label_2;
        label_29:
        if(val_1 == false)
        {
            goto label_3;
        }
        
        if(("Current local points: ") != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        label_4:
        label_7:
        mem2[0] = val_28;
        mem2[0] = this.currentPointsIndexes[0];
        mem[4] = 268435463;
        mem2[0] = " with name ";
        mem2[0] = this.points[this.currentPointsIndexes[0]].myLetterName;
        mem2[0] = "; ";
        val_28 = +val_1;
        val_29 = 1;
        label_2:
        if(val_29 < this.currentPointsIndexes.Length)
        {
            goto label_29;
        }
        
        object[] val_4 = new object[4];
        val_4[0] = val_28;
        val_4[1] = "Photon room current points indexes: ";
        val_30 = null;
        val_30 = null;
        val_4[2] = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[HoldPositionsPointsController.currentPointsIndexesParamName];
        val_4[3] = " ; Photon room current points names: ";
        val_31 = +val_4;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[HoldPositionsPointsController.currentPointsCreateOrdersParamName] != null) && (null != null))
        {
                val_32 = 0;
        }
        
        object val_13 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_32);
        val_33 = 0;
        System.Collections.Generic.List<System.Int32> val_15 = new System.Collections.Generic.List<System.Int32>();
        val_34 = 0;
        goto label_56;
        label_61:
        val_15.Add(item:  System.Int32.Parse(s:  Item[0]));
        val_34 = 1;
        label_56:
        if(val_34 < Count)
        {
            goto label_61;
        }
        
        val_35 = 0;
        goto label_62;
        label_67:
        val_31 = val_31 + HoldPositionsPoint.NumToLetterName(丙丐一丕丗万丁下一:  val_15.Item[0])(HoldPositionsPoint.NumToLetterName(丙丐一丕丗万丁下一:  val_15.Item[0])) + " ";
        val_35 = 1;
        label_62:
        if(val_35 < val_15.Count)
        {
            goto label_67;
        }
        
        val_27 = val_31 + ". PhotonNetwork.isMasterClient = "(". PhotonNetwork.isMasterClient = ") + 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东().ToString();
        UnityEngine.Debug.LogError(message:  val_27);
    }
    private void 丂专下不丕丄下世丅()
    {
        var val_23;
        var val_24;
        string val_25;
        var val_26;
        string val_27;
        var val_28;
        string val_29;
        var val_30;
        var val_31;
        var val_32;
        val_23 = 1152921505107111936;
        val_24 = null;
        val_24 = null;
        val_25 = HoldPositionsPointsController.currentPointsCreateOrdersParamName;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_25)) == false)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_25 = HoldPositionsPointsController.currentPointsCreateOrdersParamName;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_25] != null) && (null != null))
        {
                val_27 = 0;
        }
        
        if((System.String.op_Equality(a:  val_27, b:  "")) == true)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        val_25 = HoldPositionsPointsController.currentPointsCreateOrdersParamName;
        val_29 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_25];
        if((val_29 != null) && (null != null))
        {
                val_29 = 0;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_29)) == true)
        {
                return;
        }
        
        object val_13 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_29);
        val_30 = 0;
        System.Collections.Generic.List<System.Int32> val_15 = new System.Collections.Generic.List<System.Int32>();
        val_31 = 0;
        goto label_31;
        label_36:
        val_15.Add(item:  System.Int32.Parse(s:  Item[0]));
        val_31 = 1;
        label_31:
        if(val_31 < Count)
        {
            goto label_36;
        }
        
        val_23 = 1152921516995557280;
        val_25 = 0;
        val_32 = 0;
        goto label_37;
        label_42:
        if(val_32 < val_15.Item[0])
        {
                val_32 = val_15.Item[0];
        }
        
        val_25 = 1;
        label_37:
        if(val_25 < val_15.Count)
        {
            goto label_42;
        }
        
        this._newestPointCreateOrder = val_32 + 1;
    }
    private void 丑上一上丐不世不三()
    {
        int val_20;
        var val_21;
        string val_22;
        var val_23;
        string val_24;
        var val_25;
        string val_26;
        var val_27;
        var val_28;
        var val_29;
        val_20 = 1152921505107111936;
        val_21 = null;
        val_21 = null;
        val_22 = HoldPositionsPointsController.currentPointsCreateOrdersParamName;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_22)) == false)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        val_22 = HoldPositionsPointsController.currentPointsCreateOrdersParamName;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_22] != null) && (null != null))
        {
                val_24 = 0;
        }
        
        if((System.String.op_Equality(a:  val_24, b:  "")) == true)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        val_22 = HoldPositionsPointsController.currentPointsCreateOrdersParamName;
        val_26 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_22];
        if((val_26 != null) && (null != null))
        {
                val_26 = 0;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_26)) == true)
        {
                return;
        }
        
        object val_13 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_26);
        val_27 = 0;
        System.Collections.Generic.List<System.Int32> val_15 = new System.Collections.Generic.List<System.Int32>();
        val_28 = 1152921523884262800;
        val_29 = 0;
        goto label_31;
        label_36:
        val_20 = System.Int32.Parse(s:  Item[0]);
        val_15.Add(item:  val_20);
        val_29 = 1;
        label_31:
        if(val_29 < Count)
        {
            goto label_36;
        }
        
        val_22 = 0;
        goto label_37;
        label_45:
        val_28 = 0;
        val_20 = val_15.Item[0];
        this.points[this.currentPointsIndexes[val_28]].createOrder = val_20;
        val_22 = 1;
        label_37:
        if(val_22 < this.currentPointsIndexes.Length)
        {
            goto label_45;
        }
    
    }
    internal HoldPositionsPoint[] 一万丑万丌丐下丞丆()
    {
        return System.Linq.Enumerable.ToArray<HoldPositionsPoint>(source:  System.Linq.Enumerable.Where<HoldPositionsPoint>(source:  this.points, predicate:  new System.Func<HoldPositionsPoint, System.Boolean>(object:  this, method:  System.Boolean HoldPositionsPointsController::且丟世丁且东丝世上(HoldPositionsPoint 丅专与丒丈丗丒丘丌))));
    }
    internal HoldPositionsPoint 丐丗上且丒万丝丛专(int 丞世不丒下上上丝丑)
    {
        var val_1;
        HoldPositionsPoint val_2;
        val_1 = 丞世不丒下上上丝丑;
        if(((val_1 & 2147483648) == 0) && (this.points.Length > val_1))
        {
                val_1 = (long)val_1;
            val_2 = this.points[val_1];
            return (HoldPositionsPoint)val_2;
        }
        
        val_2 = 0;
        return (HoldPositionsPoint)val_2;
    }
    internal HoldPositionsPoint[] 七东丞丕丄丅丏丟丕()
    {
        return (HoldPositionsPoint[])this.points;
    }
    private void 丈丙丂丒丙丕丟下丛()
    {
        var val_23;
        var val_24;
        string val_25;
        var val_26;
        var val_27;
        var val_28;
        string val_29;
        var val_30;
        string val_31;
        var val_32;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_23 = null;
        val_23 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  HoldPositionsPointsController.nextPointsTimesParamName)) != false)
        {
                val_24 = null;
            val_24 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[HoldPositionsPointsController.nextPointsTimesParamName] != null) && (null != null))
        {
                val_25 = 0;
        }
        
            if((System.String.op_Inequality(a:  val_25, b:  "")) != false)
        {
                val_26 = null;
            val_26 = null;
            val_27 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_1.set_Item(key:  HoldPositionsPointsController.nextPointsTimesParamName, value:  val_27.Item[HoldPositionsPointsController.nextPointsTimesParamName]);
        }
        
        }
        
        val_28 = null;
        val_29 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_28 = null;
        if((val_29.ContainsKey(key:  HoldPositionsPointsController.currentPointsIndexesParamName)) != false)
        {
                val_30 = null;
            val_29 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_30 = null;
            if((val_29.Item[HoldPositionsPointsController.currentPointsIndexesParamName] != null) && (null != null))
        {
                val_31 = 0;
        }
        
            bool val_19 = System.String.op_Inequality(a:  val_31, b:  "");
            if(val_19 != false)
        {
                val_19.丗不七丗万丘丟丛丞(丟七丑丆丈与丆丙世:  this.points);
            val_32 = null;
            val_32 = null;
            val_29 = HoldPositionsPointsController.currentPointsIndexesParamName;
            val_27 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_1.set_Item(key:  val_29, value:  val_27.Item[HoldPositionsPointsController.currentPointsIndexesParamName]);
        }
        
        }
        
        if(val_1 != null)
        {
                this.丟丘丄丅丅丐丂专世(业上上东丑东丞丗不:  val_1);
        }
        
        this.丕万丄上丙世且丏丌();
    }
    private void 与丏丂七丙丒下与专()
    {
        if(this.一丌丗丂丝丘丁丄丆 != null)
        {
            goto label_1;
        }
        
        this.一丌丗丂丝丘丁丄丆 = this.一丌丗丂丝丘丁丄丆;
        if(this.一丌丗丂丝丘丁丄丆 == null)
        {
            goto label_2;
        }
        
        label_1:
        int val_3 = (int)this.一丌丗丂丝丘丁丄丆.spotLifeTime;
        val_3 = this.一丌丗丂丝丘丁丄丆.matchTime / val_3;
        this.pointCycles = UnityEngine.Mathf.CeilToInt(f:  (float)val_3);
        this.currentPointsIndexes = new int[0];
        return;
        label_2:
    }
    private void 丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        string val_33;
        var val_34;
        string val_35;
        var val_36;
        int val_37;
        var val_38;
        var val_39;
        System.Int32[] val_40;
        var val_41;
        var val_42;
        string val_43;
        var val_44;
        string val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        string val_50;
        var val_51;
        string val_52;
        val_29 = 1152921505209081856;
        val_30 = null;
        val_30 = null;
        val_31 = 1152921525484599408;
        if((业上上东丑东丞丗不.ContainsKey(key:  HoldPositionsPointsController.currentPointsIndexesParamName)) == false)
        {
            goto label_10;
        }
        
        val_32 = null;
        val_32 = null;
        if((业上上东丑东丞丗不.Item[HoldPositionsPointsController.currentPointsIndexesParamName] != null) && (null != null))
        {
                val_33 = 0;
        }
        
        if((System.String.op_Inequality(a:  val_33, b:  "")) == false)
        {
            goto label_10;
        }
        
        val_34 = null;
        val_34 = null;
        if((业上上东丑东丞丗不.Item[HoldPositionsPointsController.currentPointsIndexesParamName] != null) && (null != null))
        {
                val_35 = 0;
        }
        
        object val_6 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_35);
        val_36 = 0;
        System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
        val_37 = 1152921516473664400;
        val_38 = 0;
        goto label_19;
        label_24:
        val_8.Add(item:  System.Int32.Parse(s:  Item[0]));
        val_38 = 1;
        label_19:
        if(val_38 < Count)
        {
            goto label_24;
        }
        
        val_31 = 1152921525484599408;
        val_39 = 0;
        goto label_25;
        label_34:
        val_37 = 0;
        if(this.currentPointsIndexes[val_37] != val_8.Item[0])
        {
                this.currentPointsIndexes[val_37] = val_8.Item[0];
        }
        
        val_39 = 1;
        label_25:
        val_40 = this.currentPointsIndexes;
        if(val_39 < this.currentPointsIndexes.Length)
        {
            goto label_34;
        }
        
        this.丝丌丑丄七丈一丝下(丛下下丗七丝专万丟:  val_8);
        label_10:
        val_41 = null;
        val_41 = null;
        if((业上上东丑东丞丗不.ContainsKey(key:  HoldPositionsPointsController.nextPointsTimesParamName)) == false)
        {
            goto label_44;
        }
        
        val_42 = null;
        val_42 = null;
        if((业上上东丑东丞丗不.Item[HoldPositionsPointsController.nextPointsTimesParamName] != null) && (null != null))
        {
                val_43 = 0;
        }
        
        if((System.String.op_Inequality(a:  val_43, b:  "")) == false)
        {
            goto label_44;
        }
        
        val_44 = null;
        val_44 = null;
        if((业上上东丑东丞丗不.Item[HoldPositionsPointsController.nextPointsTimesParamName] != null) && (null != null))
        {
                val_45 = 0;
        }
        
        object val_18 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_45);
        val_46 = 0;
        System.Collections.Generic.List<System.Double> val_20 = new System.Collections.Generic.List<System.Double>();
        val_37 = 1152921537894787120;
        val_47 = 0;
        goto label_53;
        label_60:
        val_20.Add(item:  System.Double.Parse(s:  Item[0]));
        val_47 = 1;
        label_53:
        if(val_47 < Count)
        {
            goto label_60;
        }
        
        val_29 = 1152921505209081856;
        val_31 = 1152921525484599408;
        val_48 = 0;
        goto label_61;
        label_69:
        val_37 = this.currentPointsIndexes[0];
        this.points[val_37].nextPointTime = val_20.Item[0];
        val_48 = 1;
        label_61:
        val_40 = this.currentPointsIndexes;
        if(val_48 < this.currentPointsIndexes.Length)
        {
            goto label_69;
        }
        
        label_44:
        val_49 = null;
        val_50 = HoldPositionsPointsController.currentPointsCreateOrdersParamName;
        if((业上上东丑东丞丗不.ContainsKey(key:  val_50)) == false)
        {
                return;
        }
        
        val_51 = null;
        val_51 = null;
        val_50 = HoldPositionsPointsController.currentPointsCreateOrdersParamName;
        if((业上上东丑东丞丗不.Item[val_50] != null) && (null != null))
        {
                val_52 = 0;
        }
        
        if((System.String.op_Inequality(a:  val_52, b:  "")) == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == true)
        {
                return;
        }
        
        this.丂专下不丕丄下世丅();
        this.丑上一上丐不世不三();
    }
    private void 丑丙东专业丗丐丝丙()
    {
        var val_6;
        var val_7;
        var val_8;
        HoldPositionsPoint[] val_9;
        System.Int32[] val_10;
        var val_11;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_6 = 0;
        goto label_1;
        label_8:
        if(this.points == null)
        {
            goto label_2;
        }
        
        val_7 = this.points;
        if(val_6 < (X21 + 24))
        {
            goto label_9;
        }
        
        goto label_4;
        label_2:
        val_8 = 0;
        label_9:
        var val_2 = val_8 + 0;
        val_1.Add(item:  (val_8 + 0) + 32 + 24);
        val_6 = 1;
        label_1:
        val_9 = this.points;
        if(val_9 == null)
        {
            goto label_8;
        }
        
        if(val_6 < this.points.Length)
        {
            goto label_9;
        }
        
        label_4:
        val_10 = new int[0];
        this.pointsMixedIndexes = val_10;
        val_11 = 0;
        goto label_10;
        label_17:
        int val_5 = UnityEngine.Random.Range(min:  0, max:  val_1.Count);
        this.pointsMixedIndexes[0] = val_1.Item[val_5];
        val_1.RemoveAt(index:  val_5);
        val_10 = this.pointsMixedIndexes;
        val_11 = 1;
        label_10:
        if(val_11 < this.pointsMixedIndexes.Length)
        {
            goto label_17;
        }
    
    }
    private void Start()
    {
        this.与丏丂七丙丒下与专();
    }
    private void 丁丝不丙丆专丘丌丙()
    {
    
    }
    private void 丗不七丗万丘丟丛丞()
    {
        this.丗不七丗万丘丟丛丞(丟七丑丆丈与丆丙世:  this.points);
    }
    private void 丗不七丗万丘丟丛丞(HoldPositionsPoint[] 丟七丑丆丈与丆丙世)
    {
        goto label_0;
        label_4:
        丟七丑丆丈与丆丙世[0].丑丟丂丈丌一不丛专();
        0 = 1;
        label_0:
        if(0 < 丟七丑丆丈与丆丙世.Length)
        {
            goto label_4;
        }
    
    }
    private void 丑丂丄丐丟万丛丕丏(System.Collections.Generic.List<int> 丅一上丈丏丙丌下丗)
    {
        .丅一上丈丏丙丌下丗 = 丅一上丈丏丙丌下丗;
        TSource[] val_4 = System.Linq.Enumerable.ToArray<HoldPositionsPoint>(source:  System.Linq.Enumerable.Where<HoldPositionsPoint>(source:  this.points, predicate:  new System.Func<HoldPositionsPoint, System.Boolean>(object:  new HoldPositionsPointsController.下丏丌丑七丗丕丅世(), method:  System.Boolean HoldPositionsPointsController.下丏丌丑七丗丕丅世::业丂丗丘一一丛丈三(HoldPositionsPoint 丅专与丒丈丗丒丘丌))));
        val_4.丗不七丗万丘丟丛丞(丟七丑丆丈与丆丙世:  val_4);
    }
    private void 上丙丌丈专东丗丂下(int 专七万不丐丆丟东丈)
    {
        this.points[(long)专七万不丐丆丟东丈].丑丟丂丈丌一不丛专();
    }
    private void 世下丐与七万一不万(int 专七万不丐丆丟东丈)
    {
        this.points[(long)专七万不丐丆丟东丈].丕与一丄丅三丏业丆();
    }
    private void 丑与一专业丂不丑丕(System.Collections.Generic.List<int> 丈丌丟丅丑东丝丁三, bool 丞丈下一丐丅丗丌丗 = False)
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        if(丞丈下一丐丅丗丌丗 != false)
        {
                if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                this.丘丟东业上不丝丂丅 = true;
        }
        
        }
        
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        val_23 = 0;
        goto label_5;
        label_40:
        if(this.丘丟东业上不丝丂丅 == false)
        {
            goto label_6;
        }
        
        HoldPositionsPoint val_23 = this.points[0];
        if(this.points[0x0][0].myPointType != 0)
        {
            goto label_34;
        }
        
        goto label_32;
        label_6:
        val_24 = 0;
        val_25 = 1;
        goto label_12;
        label_18:
        HoldPositionsPoint val_25 = this.points[0];
        val_24 = 1;
        val_25 = val_25 & ((this.points[0x0][0].index != this.currentPointsIndexes[0]) ? 1 : 0);
        label_12:
        if(val_24 < this.currentPointsIndexes.Length)
        {
            goto label_18;
        }
        
        if(this.一丌丗丂丝丘丁丄丆.spotComebackSpawn == false)
        {
            goto label_28;
        }
        
        if(this.一丌丗丂丝丘丁丄丆.LosingTeam != 2)
        {
            goto label_22;
        }
        
        HoldPositionsPoint val_26 = this.points[0];
        if(this.points[0x0][0].myPointType != 2)
        {
            goto label_34;
        }
        
        label_22:
        if(this.一丌丗丂丝丘丁丄丆.LosingTeam != 1)
        {
            goto label_28;
        }
        
        HoldPositionsPoint val_27 = this.points[0];
        var val_6 = (this.points[0x0][0].myPointType == 1) ? 1 : 0;
        val_6 = val_25 & val_6;
        if((val_6 & 1) != 0)
        {
            goto label_32;
        }
        
        goto label_34;
        label_28:
        if((val_25 & 1) == 0)
        {
            goto label_34;
        }
        
        label_32:
        HoldPositionsPoint val_28 = this.points[0];
        val_2.Add(item:  this.points[0x0][0].index);
        label_34:
        val_23 = 1;
        label_5:
        if(val_23 < this.points.Length)
        {
            goto label_40;
        }
        
        this.丘丟东业上不丝丂丅 = false;
        if(val_2.Count < this.一丌丗丂丝丘丁丄丆.spotLimit)
        {
                UnityEngine.Debug.LogError(message:  "NOT ENOUGH POINTS!");
        }
        
        System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
        val_26 = 0;
        goto label_46;
        label_52:
        int val_10 = UnityEngine.Random.Range(min:  0, max:  val_2.Count);
        val_8.Add(item:  val_2.Item[val_10]);
        val_2.RemoveAt(index:  val_10);
        val_26 = 1;
        label_46:
        if(val_26 < this.currentPointsIndexes.Length)
        {
            goto label_52;
        }
        
        if(丈丌丟丅丑东丝丁三 == null)
        {
            goto label_53;
        }
        
        val_27 = 0;
        goto label_54;
        label_64:
        if(丈丌丟丅丑东丝丁三.Count < 1)
        {
            goto label_55;
        }
        
        var val_30 = 0;
        var val_29 = 1;
        do
        {
            val_29 = val_29 & ((val_27 != 丈丌丟丅丑东丝丁三.Item[0]) ? 1 : 0);
            val_30 = val_30 + 1;
        }
        while(val_30 < 丈丌丟丅丑东丝丁三.Count);
        
        if(val_29 == 0)
        {
            goto label_59;
        }
        
        label_55:
        if(val_27 < this.currentPointsIndexes.Length)
        {
                val_8.set_Item(index:  0, value:  this.currentPointsIndexes[0]);
        }
        
        label_59:
        val_27 = 1;
        label_54:
        if(val_27 < val_8.Count)
        {
            goto label_64;
        }
        
        label_53:
        System.Collections.Generic.List<System.Object> val_17 = new System.Collections.Generic.List<System.Object>();
        val_28 = 0;
        goto label_65;
        label_69:
        val_17.Add(item:  val_8.Item[0]);
        val_28 = 1;
        label_65:
        if(val_28 < val_8.Count)
        {
            goto label_69;
        }
        
        ExitGames.Client.Photon.Hashtable val_20 = new ExitGames.Client.Photon.Hashtable();
        val_29 = null;
        val_29 = null;
        val_20.set_Item(key:  HoldPositionsPointsController.currentPointsIndexesParamName, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_17));
        if(丞丈下一丐丅丗丌丗 != false)
        {
                val_30 = null;
            val_30 = null;
            val_20.set_Item(key:  HoldPositionsPointsController.currentPointsCreateOrdersParamName, value:  "");
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_20, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        this.丘丟东业上不丝丂丅 = false;
    }
    private string 丕上丞下不上且专世()
    {
        var val_7;
        var val_8;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_7 = 0;
        goto label_1;
        label_9:
        val_1.Add(item:  this.points[this.currentPointsIndexes[0]].createOrder);
        val_7 = 1;
        label_1:
        if(val_7 < this.currentPointsIndexes.Length)
        {
            goto label_9;
        }
        
        System.Collections.Generic.List<System.Object> val_3 = new System.Collections.Generic.List<System.Object>();
        val_8 = 0;
        goto label_10;
        label_14:
        val_3.Add(item:  val_1.Item[0]);
        val_8 = 1;
        label_10:
        if(val_8 < val_1.Count)
        {
            goto label_14;
        }
        
        return (string)Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_3);
    }
    private void 丕万丄上丙世且丏丌()
    {
        var val_15;
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        int val_20;
        var val_21;
        val_15 = null;
        val_15 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[HoldPositionsPointsController.currentPointsCreateOrdersParamName] != null) && (null != null))
        {
                val_16 = 0;
        }
        
        object val_5 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_16);
        val_17 = 0;
        System.Collections.Generic.List<System.Int32> val_7 = new System.Collections.Generic.List<System.Int32>();
        val_18 = 1152921523884262800;
        val_19 = 0;
        goto label_12;
        label_17:
        val_20 = System.Int32.Parse(s:  Item[0]);
        val_7.Add(item:  val_20);
        val_19 = 1;
        label_12:
        if(val_19 < Count)
        {
            goto label_17;
        }
        
        val_21 = 0;
        goto label_18;
        label_29:
        val_18 = 0;
        val_20 = val_7.Item[0];
        this.points[this.currentPointsIndexes[val_18]].createOrder = val_20;
        if(this._newestPointCreateOrder < val_7.Item[0])
        {
                this._newestPointCreateOrder = val_7.Item[0] + 1;
        }
        
        val_21 = 1;
        label_18:
        if(val_21 < this.currentPointsIndexes.Length)
        {
            goto label_29;
        }
        
        this.丂专下不丕丄下世丅();
    }
    private void 丝丌丑丄七丈一丝下(System.Collections.Generic.List<int> 丛下下丗七丝专万丟)
    {
        var val_6;
        int val_7;
        double val_8;
        HoldPositionsController val_9;
        this.丑丂丄丐丟万丛丕丏(丅一上丈丏丙丌下丗:  丛下下丗七丝专万丟);
        val_6 = 0;
        goto label_1;
        label_45:
        this.currentPointsIndexes[0] = 丛下下丗七丝专万丟.Item[0];
        if(this.points[this.currentPointsIndexes[0]].丅与世丒丑上专丆丙() != true)
        {
                this.points[this.currentPointsIndexes[0]].丕与一丄丅三丏业丆();
        }
        
        val_7 = this.currentPointsIndexes[0];
        if(this.points[val_7].isTimeOfActionPassed == false)
        {
            goto label_21;
        }
        
        this.points[this.currentPointsIndexes[0]].Reset();
        this.points[this.currentPointsIndexes[0]].createOrder = this._newestPointCreateOrder;
        double val_4 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_7 = this.一丌丗丂丝丘丁丄丆;
        if(val_7 == null)
        {
            goto label_38;
        }
        
        val_8 = this.一丌丗丂丝丘丁丄丆.spotLifeTime;
        val_9 = val_7;
        goto label_41;
        label_38:
        val_9 = this.一丌丗丂丝丘丁丄丆;
        val_8 = this.一丌丗丂丝丘丁丄丆.spotLifeTime;
        if(val_9 == null)
        {
            goto label_40;
        }
        
        val_7 = val_9;
        goto label_41;
        label_40:
        val_7 = this.一丌丗丂丝丘丁丄丆;
        if(val_7 == null)
        {
            goto label_42;
        }
        
        label_41:
        val_4 = val_4 + val_8;
        val_4 = val_4 + (double)this.一丌丗丂丝丘丁丄丆.spotSpawnDelay;
        val_4 = val_4 + (double)this.一丌丗丂丝丘丁丄丆.spotAllowCaptureDelay;
        this.points[this.currentPointsIndexes[0]].nextPointTime = val_4;
        int val_17 = this._newestPointCreateOrder;
        val_17 = val_17 + 1;
        this._newestPointCreateOrder = val_17;
        label_21:
        val_6 = 1;
        label_1:
        if(val_6 < this.currentPointsIndexes.Length)
        {
            goto label_45;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                this.丌丒业世丕丟丝一丕();
            this.下且丘丑七丑与与丛();
        }
        else
        {
                this.丂专下不丕丄下世丅();
        }
        
        if(this.PointsApplied == null)
        {
                return;
        }
        
        this.PointsApplied.Invoke();
        return;
        label_42:
    }
    private void 丌丒业世丕丟丝一丕()
    {
        var val_7;
        var val_8;
        var val_9;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        double[] val_2 = new double[0];
        val_7 = 0;
        goto label_2;
        label_11:
        val_7 = 1;
        val_2[0] = this.points[this.currentPointsIndexes[0]].nextPointTime;
        label_2:
        if(val_7 < this.currentPointsIndexes.Length)
        {
            goto label_11;
        }
        
        object[] val_4 = new object[0];
        val_8 = 0;
        goto label_13;
        label_19:
        val_8 = 1;
        val_4[0] = val_2[0];
        label_13:
        if(val_8 < val_4.Length)
        {
            goto label_19;
        }
        
        val_9 = null;
        val_9 = null;
        val_1.set_Item(key:  HoldPositionsPointsController.nextPointsTimesParamName, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4));
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 下且丘丑七丑与与丛()
    {
        var val_4;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_4 = null;
        val_4 = null;
        val_1.set_Item(key:  HoldPositionsPointsController.currentPointsCreateOrdersParamName, value:  this.丕上丞下不上且专世());
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丗丆下丝丟七七一一()
    {
        var val_4;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_4 = null;
        val_4 = null;
        val_2.set_Item(key:  HoldPositionsPointsController.currentPointsCreateOrdersParamName, value:  "");
        val_2.set_Item(key:  HoldPositionsPointsController.currentPointsIndexesParamName, value:  "");
        val_2.set_Item(key:  HoldPositionsPointsController.nextPointsTimesParamName, value:  "");
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丑业业丆一与丙不丛()
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  HoldPositionsPointsController.currentPointsCreateOrdersParamName, value:  "");
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private System.Collections.IEnumerator 万丅丙丁丑丗丈丄丒()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new HoldPositionsPointsController.东一丛丟上七不丁丁();
    }
    private void 不丏丘丐丞与下东丞()
    {
        null = null;
        typeof(TeamController).__il2cppRuntimeField_40 = 0;
        typeof(TeamController).__il2cppRuntimeField_44 = 0;
        typeof(TeamController).__il2cppRuntimeField_38 = 0;
        typeof(TeamController).__il2cppRuntimeField_3C = 0;
    }
    private void LateUpdate()
    {
    
    }
    private void 丐下丁丝一丗丞丛不()
    {
        this.丐三丞丗丈丘不丗上 = true;
        this._newestPointCreateOrder = 0;
        this.currentPointsIndexes = new int[0];
        this.HardResetAllPoints();
        this.丗不七丗万丘丟丛丞(丟七丑丆丈与丆丙世:  this.points);
        this.丗丆下丝丟七七一一();
        this.不丏丘丐丞与下东丞();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.万丅丙丁丑丗丈丄丒());
        TimeGameController.丄丞丁丈与业上丞丟.丞丞下丒丅丅丛世丕();
    }
    public void HardResetAllPoints()
    {
        goto label_0;
        label_4:
        this.points[0].丗丅不且与与丑丐丐();
        0 = 1;
        label_0:
        if(0 < this.points.Length)
        {
            goto label_4;
        }
    
    }
    public void LostPlayersActions()
    {
        UnityEngine.Debug.LogError(message:  "LostPlayersActions");
    }
    private void Update()
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        float val_21;
        int val_22;
        this.photonTime = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_17 = null;
        val_17 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count != 0)
        {
                if((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false) && (this.丐三丞丗丈丘不丗上 != true))
        {
                this.丐下丁丝一丗丞丛不();
        }
        
        }
        
        if((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != true) && (this.丐三丞丗丈丘不丗上 != true))
        {
                val_18 = null;
            val_18 = null;
            if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count != 0)
        {
                this.丈丙丂丒丙丕丟下丛();
        }
        
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = 0;
        this.丐三丞丗丈丘不丗上 = (丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count != 0) ? 1 : 0;
        goto label_22;
        label_41:
        if(this.points[this.currentPointsIndexes[0]].nextPointTime != 0f)
        {
                val_21 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            double val_21 = (double)this.一丌丗丂丝丘丁丄丆.spotSpawnDelay;
            val_21 = this.points[this.currentPointsIndexes[0]].nextPointTime - val_21;
            if(val_21 > val_21)
        {
                this.上丙丌丈专东丗丂下(专七万不丐丆丟东丈:  this.currentPointsIndexes[0]);
        }
        
        }
        
        val_20 = 1;
        label_22:
        if(val_20 < this.currentPointsIndexes.Length)
        {
            goto label_41;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        System.Collections.Generic.List<System.Int32> val_12 = new System.Collections.Generic.List<System.Int32>();
        val_20 = 0;
        goto label_45;
        label_62:
        val_22 = 0;
        if(this.points[this.currentPointsIndexes[val_22]].nextPointTime != 0f)
        {
                val_21 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            val_22 = this.currentPointsIndexes[val_22];
            if(val_21 > this.points[val_22].nextPointTime)
        {
                val_12.Add(item:  0);
        }
        
        }
        
        val_20 = 1;
        label_45:
        if(val_20 < this.currentPointsIndexes.Length)
        {
            goto label_62;
        }
        
        if(val_12 == null)
        {
                return;
        }
        
        if(val_12.Count < 1)
        {
                return;
        }
        
        this.丑与一专业丂不丑丕(丈丌丟丅丑东丝丁三:  val_12, 丞丈下一丐丅丗丌丗:  false);
    }
    private void 丕丆丗丞丐三丏下丙()
    {
        HoldPositionsPoint[] val_7;
        var val_8;
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == true)
        {
                return;
        }
        
        val_7 = this.gameObject.transform.GetComponentsInChildren<HoldPositionsPoint>();
        val_8 = 0;
        this.points = val_7;
        goto label_5;
        label_10:
        HoldPositionsPoint val_6 = this.points[0];
        this.points[0x0][0].index = ;
        val_7 = this.points;
        val_8 = W21 + 1;
        label_5:
        if(((int)val_8 & 65535) < this.points.Length)
        {
            goto label_10;
        }
    
    }
    private void OnDestroy()
    {
        var val_6;
        System.Action<ExitGames.Client.Photon.Hashtable> val_7;
        var val_8;
        System.Action val_9;
        val_6 = null;
        val_6 = null;
        val_8 = null;
        if(((System.Delegate.Remove(source:  GameConnect.世丄丄与丌业丑丕丈, value:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void HoldPositionsPointsController::丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_8 = null;
            val_7 = 0;
        }
        
        GameConnect.世丄丄与丌业丑丕丈 = val_7;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void HoldPositionsPointsController::丂丐与丞丗丒丘丑上()))) != null) && (null != null))
        {
                val_9 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_9;
    }
    private int 三丛上丙万丂丁三与()
    {
        var val_5;
        OnlineModeController val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_5 = null;
        val_5 = null;
        val_6 = GameController.onlineMode;
        if(val_6 != 0)
        {
                val_7 = null;
            val_7 = null;
            val_6 = mem[GameController.onlineMode + 360];
            val_6 = GameController.onlineMode.teamController;
            if(val_6 != 0)
        {
                val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            val_6 = mem[GameController.onlineMode + 360];
            val_6 = GameController.onlineMode.teamController;
            val_10 = ((typeof(TeamController).__il2cppRuntimeField_44 > TeamController.__il2cppRuntimeField_element_class) ? 1 : 0) << 1;
            return (int)val_10;
        }
        
        }
        
        val_10 = 0;
        return (int)val_10;
    }
    public HoldPositionsPointsController()
    {
    
    }
    private static HoldPositionsPointsController()
    {
        HoldPositionsPointsController.nextPointsTimesParamName = "nextPointsTimes";
        HoldPositionsPointsController.currentPointsIndexesParamName = "currentPointsIndexes";
        HoldPositionsPointsController.currentPointsCreateOrdersParamName = "currentPointsCreateOrders";
    }
    private bool 且丟世丁且东丝世上(HoldPositionsPoint 丅专与丒丈丗丒丘丌)
    {
        return 万上丈专丐专丞丛丛.丟不下下且业丛丄丏(丞下万上三丘上与专:  this.currentPointsIndexes, 丏东丁丂七丟不丒丅:  丅专与丒丈丗丒丘丌.index);
    }

}
