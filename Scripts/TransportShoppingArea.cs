using UnityEngine;
internal class TransportShoppingArea : ShoppingAreaBase, 东丁丆一业丈万丆丐
{
    // Fields
    public 丏丐丏丘下东丁丐一 transportType;
    public string viewId;
    public float costPurchase;
    public UnityEngine.Transform[] spawnPoints;
    internal Rilisoft.丝丑丂丛万丐丈丘且 专万七三上丑上丈专;
    private FreePlayModeController 下丘丆丁丄一丙东世;
    private System.Collections.Generic.Queue<TransportShoppingArea.下丗丐丏上一丗世下> 丏丑三三世丄丟上下;
    private bool 丏下丄业东丟丐丗丗;
    private bool 丆下丛丘东丈不不世;
    
    // Properties
    private FreePlayModeController 丏丙丙丗丈上丗上业 { get; }
    
    // Methods
    private FreePlayModeController 丛不七丌七丄丕三丞()
    {
        FreePlayModeController val_3;
        var val_4;
        if((UnityEngine.Object.op_Implicit(exists:  this.下丘丆丁丄一丙东世)) != false)
        {
                val_3 = this.下丘丆丁丄一丙东世;
            return val_3;
        }
        
        val_4 = null;
        val_4 = null;
        if(GameController.mode != null)
        {
                var val_2 = (null == null) ? GameController.mode : 0;
        }
        else
        {
                val_3 = 0;
        }
        
        this.下丘丆丁丄一丙东世 = val_3;
        return val_3;
    }
    protected override void Start()
    {
        this.Start();
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.专万七三上丑上丈专 = 0;
        mem[1152921537244990136] = 0;
    }
    internal override void 丙丆丐一三丌丝丕丌()
    {
        this.丙丆丐一三丌丝丕丌();
        this.丏下丄业东丟丐丗丗 = false;
        this.东丐下丛丐丄丒不丆();
    }
    internal override void 丛三丐丘丂丈专丏专()
    {
        this.丛三丐丘丂丈专丏专();
        if((UnityEngine.Object.op_Implicit(exists:  137125888)) != false)
        {
                丐丞专业丈不丕丝丟(丙业与丙丗丝不丈东:  false);
        }
        
        this.下世丟丆专世且下丞();
        if(this.丝专丗丂丅丒七丞东() == 3)
        {
                丄丑七丘丁且丞丙专(与丆丌丂丟丛丘丑且:  1);
        }
        
        mem[1152921537245218184] = 0;
    }
    private void 东丐下丛丐丄丒不丆()
    {
        if((this.丝专丗丂丅丒七丞东() == 1) && (this.丈丂万丗丏丞丏且丟() != true))
        {
                丄丑七丘丁且丞丙专(与丆丌丂丟丛丘丑且:  3);
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丞世不丒下上上丝丑:  135, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) < this.专万七三上丑上丈专)
        {
                string val_6 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12635"), arg0:  this.专万七三上丑上丈专);
        }
        
            TransportShoppingArea.世丐东专丌丆丆丈丞(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12401"));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.专万七三上丑上丈专)) != false)
        {
                this.专万七三上丑上丈专.丐丞专业丈不丕丝丟(丙业与丙丗丝不丈东:  true);
        }
        
        this.不丗丕东丑与且丁丐();
    }
    private void 不丗丕东丑与且丁丐()
    {
        System.Delegate val_8;
        var val_9;
        val_8 = 1152921504848912384;
        if((UnityEngine.Object.op_Implicit(exists:  InGameGUI.丙丞专丌丁丞与不丐)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_170)) == false)
        {
                return;
        }
        
        if(this.丝专丗丂丅丒七丞东() == 1)
        {
                UnityEngine.Events.UnityAction val_5 = null;
            val_8 = val_5;
            val_5 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TransportShoppingArea::丄丛世丝专下七世丝());
            val_9 = System.Delegate.Combine(a:  typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_170 + 88, b:  val_5);
            if((val_9 != null) && (null != null))
        {
                val_9 = 0;
        }
        
            mem2[0] = val_9;
        }
        
        typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_170.丄丂丙东业丆业不三(丙丟三丅一丂丂下世:  this);
        this.丏下丄业东丟丐丗丗 = true;
    }
    private void 下世丟丆专世且下丞()
    {
        System.Delegate val_7;
        var val_8;
        val_7 = 1152921504848912384;
        if((UnityEngine.Object.op_Implicit(exists:  InGameGUI.丙丞专丌丁丞与不丐)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_170)) == false)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_4 = null;
        val_7 = val_4;
        val_4 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TransportShoppingArea::丄丛世丝专下七世丝());
        val_8 = System.Delegate.Remove(source:  typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_170 + 88, value:  val_4);
        if((val_8 != null) && (null != null))
        {
                val_8 = 0;
        }
        
        mem2[0] = val_8;
        typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_170.丆世与丑丆丅丐万且();
        this.丏下丄业东丟丐丗丗 = false;
    }
    protected override void LateUpdate()
    {
        this.LateUpdate();
        if(true == 0)
        {
            goto label_6;
        }
        
        if(this.丏下丄业东丟丐丗丗 == false)
        {
            goto label_2;
        }
        
        if(this.不上丕丙丞丗丆丈上() != true)
        {
                this = this;
            this.下世丟丆专世且下丞();
        }
        
        if(this.丏下丄业东丟丐丗丗 == true)
        {
            goto label_6;
        }
        
        label_2:
        if((this.不上丕丙丞丗丆丈上() != false) && (this.丆下丛丘东丈不不世 != true))
        {
                this.东丐下丛丐丄丒不丆();
        }
        
        label_6:
        if(((this.丝专丗丂丅丒七丞东() == 2) && (this.丆下丛丘东丈不不世 != true)) && ((UnityEngine.Object.op_Implicit(exists:  this.丛不七丌七丄丕三丞())) != false))
        {
                FreePlayModeController val_6 = this.丛不七丌七丄丕三丞();
            if(val_6.vehicleController.丏丛万丆丝丌丏丟下() <= 0f)
        {
                val_6.vehicleController.丄丑七丘丁且丞丙专(与丆丌丂丟丛丘丑且:  1);
            if(null != 0)
        {
                this.东丐下丛丐丄丒不丆();
        }
        
        }
        
        }
        
        this.丂丑丒丝专丛专丂七();
    }
    private void 丄丛世丝专下七世丝()
    {
        if(true == 0)
        {
                return;
        }
        
        if((this.业丗丝丆丅丅下东业(丏丅丅专七丘丑上丂: out  0)) != false)
        {
                if(this.丒丌业丐丘七丐丁丆() == false)
        {
                return;
        }
        
            this.丆下丛丘东丈不不世 = true;
            object[] val_4 = new object[2];
            val_4[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
            val_4[1] = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  0, 丈丅丘丐三丂丗且丌:  2, 丕业丑万一丞丞东三:  false, 丗丟上上丒丐丗丞丙:  val_4);
            this.下世丟丆专世且下丞();
            return;
        }
        
        this.与下下丛且丛一丌丄();
    }
    private void 丑丄丆丑丈三丕丑丏()
    {
        丄丑七丘丁且丞丙专(与丆丌丂丟丛丘丑且:  2);
        if((UnityEngine.Object.op_Implicit(exists:  this.丛不七丌七丄丕三丞())) != false)
        {
                FreePlayModeController val_3 = this.丛不七丌七丄丕三丞();
            val_3.vehicleController.丝丂与丒丟丕丙不丅();
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  183);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丌丅丅丘丟丁丟丐业(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丒世丘丘上丆丝东丞:  this.专万七三上丑上丈专, 东丒丙丞丘万世丏下:  0, 专丁丅专丙丙下丂不:  this.viewId, 世丟万一丘丐丙丝与:  this.transportType.ToString());
        PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().下且上丛丞一东不不(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  135, 丂丕丂丏专丂丄丕且:  this.专万七三上丑上丈专), 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        if((public System.Void System.Nullable<PGCompany.丆丈丘东丆丕三丞东>::.ctor(PGCompany.丆丈丘东丆丕三丞东 value)) == 0)
        {
                return;
        }
        
        this.东丐下丛丐丄丒不丆();
    }
    private void 与下下丛且丛一丌丄()
    {
        丄丑七丘丁且丞丙专(与丆丌丂丟丛丘丑且:  3);
        this.下世丟丆专世且下丞();
        TransportShoppingArea.世丐东专丌丆丆丈丞(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12618"));
        this.东丐下丛丐丄丒不丆();
    }
    private static void 世丐东专丌丆丆丈丞(string 丕丗丘丑丛与丑业丒)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丗丘丑丛与丑业丒)) == true)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  InGameGUI.丙丞专丌丁丞与不丐)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_170)) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_170 + 80, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
    }
    private void 丗丑丕丁丂一三七且(object[] 专丒丌丆下丐丞丟丞)
    {
        System.Collections.Generic.Queue<下丗丐丏上一丗世下> val_4;
        object val_5;
        val_4 = this;
        if(专丒丌丆下丐丞丟丞 == null)
        {
                return;
        }
        
        if(专丒丌丆下丐丞丟丞.Length < 2)
        {
                return;
        }
        
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        val_5 = 专丒丌丆下丐丞丟丞[1];
        if((val_5 != null) && (null != null))
        {
                val_5 = 0;
        }
        
        val_4 = this.丏丑三三世丄丟上下;
        .<世丞丂丆世丌丂丝丈>k__BackingField = null;
        .<专一丘丁丂丏丒丘丟>k__BackingField = val_5;
        val_4.Enqueue(item:  new TransportShoppingArea.下丗丐丏上一丗世下());
    }
    private void 且七丙丆丘丈下丛丞()
    {
        与丅丕丈丘东丝世丟 val_10;
        上与三业丅专丌万丟 val_11;
        UnityEngine.Transform val_3 = 0;
        if(this.丏丑三三世丄丟上下.Dequeue() == null)
        {
                return;
        }
        
        与丅丕丈丘东丝世丟 val_2 = 与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  val_1.<世丞丂丆世丌丂丝丈>k__BackingField);
        if(val_2 == null)
        {
                return;
        }
        
        if((this.业丗丝丆丅丅下东业(丏丅丅专七丘丑上丂: out  val_3)) == false)
        {
            goto label_4;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = val_1.<世丞丂丆世丌丂丝丈>k__BackingField;
        UnityEngine.GameObject val_6 = 业丛丙丛丗世丑丑丂.丄七丝丏丈丗业世业(丁丅丈丌丟世丗丗丟:  this.transportType, 丂丁万丞万丆三一丒:  val_3, 丂东丄丏丕丕丅上一:  this.viewId, 一丐丗丁丞丆丅丟丄:  val_5);
        if((UnityEngine.Object.op_Implicit(exists:  val_6)) == false)
        {
            goto label_13;
        }
        
        TransportControllerBase val_8 = val_6.GetComponent<TransportControllerBase>();
        if((UnityEngine.Object.op_Implicit(exists:  val_8)) == false)
        {
            goto label_17;
        }
        
        if(val_8 == null)
        {
            goto label_18;
        }
        
        val_8.下上东丙丝丂丑东丐(与丛丘上丛丝下丟丏:  true);
        val_8.丐专且七与世上丞丛(丈三世丞丕万丄七丂:  val_1.<专一丘丁丂丏丒丘丟>k__BackingField);
        label_17:
        val_10 = val_2;
        val_11 = 0;
        goto label_19;
        label_4:
        val_11 = 1;
        goto label_20;
        label_13:
        val_11 = 2;
        label_20:
        val_10 = val_2;
        label_19:
        this.不与丛业且丂丆一下(丞下万上三丘上与专:  val_10, 东且丁丆丛丁丏丘且:  val_11);
        return;
        label_18:
    }
    private void 丂丑丒丝专丛专丂七()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(this.丏丑三三世丄丟上下.Count < 1)
        {
                return;
        }
        
        this.且七丙丆丘丈下丛丞();
    }
    private bool 丒丌业丐丘七丐丁丆()
    {
        if(this.丝专丗丂丅丒七丞东() != 1)
        {
                return false;
        }
        
        return this.丈丂万丗丏丞丏且丟();
    }
    private bool 不上丕丙丞丗丆丈上()
    {
        var val_3;
        Player_move_c val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                val_5 = 1;
            return (bool);
        }
        
        val_6 = null;
        val_6 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_5 = 0;
        return (bool);
    }
    private bool 丈丂万丗丏丞丏且丟()
    {
        var val_15;
        var val_16;
        val_15 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.丛不七丌七丄丕三丞())) == false)
        {
            goto label_3;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丞世不丒下上上丝丑:  135, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) >= this.专万七三上丑上丈专)
        {
            goto label_5;
        }
        
        label_3:
        val_16 = 0;
        return (bool)val_16 & 1;
        label_5:
        FreePlayModeController val_5 = this.丛不七丌七丄丕三丞();
        if(val_5.vehicleController.丏丛万丆丝丌丏丟下() > 0f)
        {
                FreePlayModeController val_7 = this.丛不七丌七丄丕三丞();
            if((UnityEngine.Object.op_Implicit(exists:  val_7.vehicleController.丂一丞丝丄丑与丝丄())) != false)
        {
                FreePlayModeController val_10 = this.丛不七丌七丄丕三丞();
            val_15 = val_10.vehicleController.丂一丞丝丄丑与丝丄();
            val_16 = val_15.不丐一丙丏丑丑丗一() ^ 1;
            return (bool)val_16 & 1;
        }
        
        }
        
        val_16 = 1;
        return (bool)val_16 & 1;
    }
    private bool 且丞丂世丈丂东丌丒(UnityEngine.Vector3 一丌丕丅东上丛专丌, UnityEngine.Transform 丏丅丅专七丘丑上丂)
    {
        UnityEngine.Vector3 val_1 = 丏丅丅专七丘丑上丂.position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.5f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Quaternion val_5 = 丏丅丅专七丘丑上丂.rotation;
        bool val_6 = UnityEngine.Physics.CheckBox(center:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, halfExtents:  new UnityEngine.Vector3() {x = 一丌丕丅东上丛专丌.x, y = 一丌丕丅东上丛专丌.y, z = 一丌丕丅东上丛专丌.z}, orientation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.z, z = ???, w = ???}, layermask:  -5, queryTriggerInteraction:  1);
        val_6 = (~val_6) & 1;
        return (bool)val_6;
    }
    private bool 业丗丝丆丅丅下东业(out UnityEngine.Transform 丏丅丅专七丘丑上丂)
    {
        UnityEngine.Transform val_9;
        float val_10;
        float val_11;
        float val_12;
        var val_13;
        var val_14;
        Player_move_c val_15;
        var val_16;
        var val_17;
        val_9 = 1152921537247694688;
        val_10 = 1.36f;
        val_11 = 2.21f;
        val_12 = 0.25f;
        if(this.transportType == 2)
        {
                val_10 = 2.5f;
            val_12 = 0.25f;
            val_11 = 5.5f;
        }
        
        丏丅丅专七丘丑上丂 = 0;
        val_13 = 1152921505286238208;
        val_14 = null;
        val_14 = null;
        val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if((UnityEngine.Object.op_Implicit(exists:  val_15)) == false)
        {
            goto label_28;
        }
        
        val_16 = null;
        val_16 = null;
        UnityEngine.Vector3 val_2 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_13 = 0;
        goto label_13;
        label_25:
        UnityEngine.Transform val_9 = this.spawnPoints[0];
        if(val_9 != 0)
        {
                UnityEngine.Vector3 val_4 = val_9.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) <= (3.402823E+38f))
        {
                if((this.且丞丂世丈丂东丌丒(一丌丕丅东上丛专丌:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丏丅丅专七丘丑上丂:  val_9)) != false)
        {
                丏丅丅专七丘丑上丂 = val_9;
        }
        
        }
        
        }
        
        val_13 = 1;
        label_13:
        val_15 = this.spawnPoints;
        if(val_13 < this.spawnPoints.Length)
        {
            goto label_25;
        }
        
        val_9 = 丏丅丅专七丘丑上丂;
        if(val_9 != 0)
        {
                val_17 = 1;
            return (bool)val_17;
        }
        
        label_28:
        val_17 = 0;
        return (bool)val_17;
    }
    internal string 下丛且丁上丗丅世丝()
    {
        var val_7;
        string val_8;
        丟丞世万丈丒丒上丟 val_2 = this.丝专丗丂丅丒七丞东();
        if(val_2 == 3)
        {
            goto label_3;
        }
        
        if(val_2 == 2)
        {
            goto label_4;
        }
        
        if(val_2 != 1)
        {
                return (string)System.String.alignConst;
        }
        
        FreePlayModeController val_3 = this.丛不七丌七丄丕三丞();
        TransportControllerBase val_4 = val_3.vehicleController.丂一丞丝丄丑与丝丄();
        if(val_4 == null)
        {
            goto label_8;
        }
        
        val_7 = null;
        if(val_4.不丐一丙丏丑丑丗一() == false)
        {
            goto label_9;
        }
        
        val_8 = "Key_12763";
        return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_8 = "Key_12399"), arg0:  丛且丗丌丏下七下丈.七业丑不七丐业丟丂(丞一丁业丄一一业且:  this.viewId));
        label_3:
        if((1152921505072021504 & 2) == 0)
        {
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12401");
        }
        
        if(null != 0)
        {
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12401");
        }
        
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12401");
        label_4:
        val_8 = "Key_12400";
        return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_8), arg0:  丛且丗丌丏下七下丈.七业丑不七丐业丟丂(丞一丁业丄一一业且:  this.viewId));
        label_8:
        val_7 = null;
        goto label_21;
        label_9:
        label_21:
        return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_8), arg0:  丛且丗丌丏下七下丈.七业丑不七丐业丟丂(丞一丁业丄一一业且:  this.viewId));
    }
    private void OnDestroy()
    {
        goto typeof(TransportShoppingArea).__il2cppRuntimeField_198;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 == 1)
        {
            goto label_0;
        }
        
        if(val_1 != 0)
        {
            goto label_1;
        }
        
        this.丗丑丕丁丂一三七且(专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        goto label_2;
        label_0:
        this.丕丝专世丝丁丐且丐(专丒丌丆下丐丞丟丞:  专丒丌丆下丐丞丟丞);
        label_2:
        val_2 = 1;
        return (bool)val_2;
        label_1:
        val_2 = 0;
        return (bool)val_2;
    }
    private void 不与丛业且丂丆一下(与丅丕丈丘东丝世丟 丞下万上三丘上与专, TransportShoppingArea.上与三业丅专丌万丟 东且丁丆丛丁丏丘且)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(东且丁丆丛丁丏丘且 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(东且丁丆丛丁丏丘且 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 东且丁丆丛丁丏丘且;
        this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  1, 丞下万上三丘上与专:  丞下万上三丘上与专, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 丕丝专世丝丁丐且丐(object[] 专丒丌丆下丐丞丟丞)
    {
        if(专丒丌丆下丐丞丟丞 == null)
        {
                return;
        }
        
        if(专丒丌丆下丐丞丟丞.Length < 1)
        {
                return;
        }
        
        object val_1 = 专丒丌丆下丐丞丟丞[0];
        if(null == 2)
        {
            goto label_3;
        }
        
        if(null == 1)
        {
            goto label_4;
        }
        
        if(null != null)
        {
            goto label_9;
        }
        
        this.丑丄丆丑丈三丕丑丏();
        goto label_9;
        label_3:
        UnityEngine.Debug.LogError(message:  "Transport purchase error");
        goto label_9;
        label_4:
        this.与下下丛且丛一丌丄();
        label_9:
        this.丆下丛丘东丈不不世 = false;
    }
    public TransportShoppingArea()
    {
        this.spawnPoints = new UnityEngine.Transform[8];
        this.丏丑三三世丄丟上下 = new System.Collections.Generic.Queue<下丗丐丏上一丗世下>();
    }

}
