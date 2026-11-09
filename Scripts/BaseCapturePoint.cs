using UnityEngine;
internal sealed class BaseCapturePoint : PGBehaviour
{
    // Fields
    public string nameBasePoint;
    internal bool isBasePointActive;
    internal UnityEngine.LineRenderer rayPoint;
    private bool 丞一业不丟万世三且;
    internal float captureCounter;
    private float 丘丌丌万丕不丁丙一;
    private const float 丅世下丘丐丐丛不丁 = 5;
    private const float 七与丞世七且丁丗丁 = 100;
    internal UnityEngine.GameObject basePointRender;
    internal int ownerCommand;
    internal int previousCommand;
    private int captureCommand;
    internal int lastCaptureCommand;
    private int myCommand;
    private bool 下丄丟丞丞三丝世丄;
    private UnityEngine.Color 上丂丝丙丌东丒专丂;
    private UnityEngine.Color 丂专一丁丕且与与丁;
    private UnityEngine.Color 下丅丗三丄业丝万东;
    private UnityEngine.Color 丄东丙丑丞丛不专丛;
    private readonly int 丞世丏东丝东上业丞;
    private System.Collections.Generic.List<int> 丛丌三丝丐丈丝七业;
    public System.Collections.Generic.List<Player_move_c> capturePlayers;
    private int 专七万不丐丆丟东丈;
    private bool 丙丞丛丕丅世下丅丒;
    private HoldPositionsPointVisual 上丁丕丐丂丌丐丗丟;
    private WorldPosIndicatonItem_Filling 东丄与丛丂丘丝三丝;
    
    // Properties
    private WorldPosIndicatonItem_Filling 丂丅丆丑丄专丐丑丄 { get; }
    private bool 专丕丝七专丒丘丟与 { get; }
    private bool 丐丛丄三丌万丙丘丕 { get; }
    private bool 下丕丄丒业丙丞丌丐 { get; }
    internal bool 丌丛丁丂丒上丁丗不 { get; }
    internal bool 丑不与东下下丁万丐 { get; }
    private bool 三丏丛不丏不且丈丆 { get; }
    
    // Methods
    private WorldPosIndicatonItem_Filling 丑丐丛丅丘丄下丟世()
    {
        if(this.东丄与丛丂丘丝三丝 != 0)
        {
                return (WorldPosIndicatonItem_Filling)this.东丄与丛丂丘丝三丝;
        }
        
        if(this.上丁丕丐丂丌丐丗丟 != 0)
        {
                return (WorldPosIndicatonItem_Filling)this.东丄与丛丂丘丝三丝;
        }
        
        this.丕七下丗专丈三丄丈();
        return (WorldPosIndicatonItem_Filling)this.东丄与丛丂丘丝三丝;
    }
    private void Awake()
    {
        if(this.丞世丏东丝东上业丞 >= 1)
        {
                var val_2 = 0;
            do
        {
            this.丛丌三丝丐丈丝七业.Add(item:  0);
            val_2 = val_2 + 1;
        }
        while(val_2 < this.丞世丏东丝东上业丞);
        
        }
        
        this.上丁丕丐丂丌丐丗丟 = this.GetComponentInChildren<HoldPositionsPointVisual>();
    }
    internal void 丘上丐世丆丑且丞丒(int 专七万不丐丆丟东丈)
    {
        this.专七万不丐丆丟东丈 = 专七万不丐丆丟东丈;
        if(this.上丁丕丐丂丌丐丗丟 == null)
        {
                return;
        }
        
        this.上丁丕丐丂丌丐丗丟.东与丂丏丐丞三丘丁(丙业与丙丗丝不丈东:  this.nameBasePoint);
    }
    internal void Reset()
    {
        this.captureCounter = 0f;
        this.丘丌丌万丕不丁丙一 = 0f;
        this.capturePlayers.Clear();
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.丌丐丛丁与丁丂丛丟(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        this.ownerCommand = 0;
        this.previousCommand = 0;
        this.captureCommand = 0;
        this.lastCaptureCommand = 0;
        this.丈东丌丟丒丄丏丆与();
    }
    private void 丕七下丗专丈三丄丈()
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        WorldPosIndicatonItem_Filling val_2 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicatonItem_Filling>();
        this.东丄与丛丂丘丝三丝 = val_2;
        val_2.与丕与丝丑丐丁丐丕(丒丘丏上丙丟丑丕丈:  "Point_" + this.nameBasePoint);
        this.东丄与丛丂丘丝三丝.万三丗丆下万丅上丈(丞下万上三丘上与专:  this.transform, 丒专丌万丄一丒万丏:  2.4f);
    }
    internal float 业丟东丛且下一丕丘()
    {
        float val_2 = 100f;
        val_2 = System.Math.Abs(this.captureCounter) / val_2;
        return (float)val_2;
    }
    private bool 丛七且专丗丒丟丞丈()
    {
        return (bool)(this.ownerCommand != 0) ? 1 : 0;
    }
    private bool 丅丅世不丝丝丝丄万()
    {
        if(this.ownerCommand == 0)
        {
                return false;
        }
        
        return (bool)((this.captureCommand != 0) ? 1 : 0) & ((this.captureCommand != this.ownerCommand) ? 1 : 0);
    }
    private bool 万业丕丁丒专丈丅三()
    {
        if(this.ownerCommand != this.myCommand)
        {
                return (bool)(this.captureCounter > 0f) ? 1 : 0;
        }
        
        return true;
    }
    internal bool 不东丞丌丂专丂丟东()
    {
        return (bool)(this.captureCommand == this.myCommand) ? 1 : 0;
    }
    internal bool 业七业与三东三丆丐()
    {
        var val_4;
        System.Func<System.Int32, System.Boolean> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = BaseCapturePoint.<>c.<>9__42_0;
        if(val_6 != null)
        {
                return (bool)((System.Linq.Enumerable.Count<System.Int32>(source:  this.丛丌三丝丐丈丝七业, predicate:  System.Func<System.Int32, System.Boolean> val_1 = null)) > 1) ? 1 : 0;
        }
        
        val_6 = val_1;
        val_1 = new System.Func<System.Int32, System.Boolean>(object:  BaseCapturePoint.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BaseCapturePoint.<>c::上丛丅且丕万专丞业(int 丁丟丌专三上丐丕丙));
        BaseCapturePoint.<>c.<>9__42_0 = val_6;
        return (bool)((System.Linq.Enumerable.Count<System.Int32>(source:  this.丛丌三丝丐丈丝七业, predicate:  val_1)) > 1) ? 1 : 0;
    }
    private bool 且丈万七丗东丕业且()
    {
        if(this.captureCommand == 0)
        {
                return false;
        }
        
        return (bool)(this.ownerCommand != this.captureCommand) ? 1 : 0;
    }
    private void Update()
    {
        var val_25;
        var val_26;
        this.丈丝丂业丑丅丗上东();
        if(this.上丁丕丐丂丌丐丗丟 == 0)
        {
                return;
        }
        
        this.上丁丕丐丂丌丐丗丟.gameObject.SetActive(value:  (this.isBasePointActive == true) ? 1 : 0);
        if(this.ownerCommand != 0)
        {
                val_25 = ((this.captureCommand != 0) ? 1 : 0) & ((this.captureCommand != this.ownerCommand) ? 1 : 0);
        }
        else
        {
                val_25 = 0;
        }
        
        this.上丁丕丐丂丌丐丗丟.下与三丅丂专丘业丗(丒丄丂不丝丝丛丁东:  false, 与丝丂丁丗丗丑丟专:  ((this.ownerCommand != this.captureCommand) ? 1 : 0) & ((this.captureCommand != 0) ? 1 : 0), 丙丟丘丌三丌丌世七:  (this.captureCommand == this.myCommand) ? 1 : 0, 丙丒世丂丝一丏不丆:  (this.ownerCommand == 0) ? 1 : 0, 七世丕丅丛且上丛三:  (this.ownerCommand == this.myCommand) ? 1 : 0, 丟下丑三丒与丘世东:  false);
        bool val_14 = ((this.ownerCommand != this.captureCommand) ? 1 : 0) & ((this.captureCommand != 0) ? 1 : 0);
        if(this.ownerCommand == this.myCommand)
        {
                val_26 = 1;
        }
        
        this.上丁丕丐丂丌丐丗丟.丐专丒丁专丌丑丘丙(丙东丏丕丞丁丈丈万:  (this.ownerCommand != 0) ? 1 : 0, 专七世丕且丐丙丕东:  val_14, 七丟丁下且不丟丌丏:  (this.captureCommand == this.myCommand) ? 1 : 0, 丒丌丘不世丁丑丟丂:  (this.captureCounter > 0f) ? 1 : 0, 下且下丄专下丝丞丟:  val_14 & ((this.ownerCommand != 0) ? 1 : 0), 丆丅丐三一不丕世三:  this.业七业与三东三丆丐(), 丑丁丐一三东丟业丝:  this.业丟东丛且下一丕丘(), 上不世不七丒上不东:  false);
        this.上丁丕丐丂丌丐丗丟.SetCircleActive(三丟东丕丄丄下下丑:  (this.丞一业不丟万世三且 == false) ? 1 : 0);
    }
    private void LateUpdate()
    {
        this.丘丌丌万丕不丁丙一 = this.captureCounter;
    }
    private void 丂下丝丌丂丐丛丗丆()
    {
        this.丘丌丌万丕不丁丙一 = this.captureCounter;
    }
    private void 丈丝丂业丑丅丗上东()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        UnityEngine.Object val_16;
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        this.myCommand = 丘丑丅三丆丑丌且丝();
        val_15 = 0;
        goto label_17;
        label_20:
        this.丛丌三丝丐丈丝七业.set_Item(index:  0, value:  0);
        val_15 = 1;
        label_17:
        if(val_15 < this.丛丌三丝丐丈丝七业.Count)
        {
            goto label_20;
        }
        
        this.一丞下业万丄世丂丛();
        int val_5 = this.东丛丗东丕丐丛丟专();
        this.丑丝丑丒七上丌丅业();
        int val_6 = val_5 + 1;
        this.captureCommand = val_6;
        if(this.lastCaptureCommand == 0)
        {
                this.lastCaptureCommand = val_6;
        }
        
        if((val_5 != 1) && (this.isBasePointActive != false))
        {
                this.丄丐与丁世丘上丏丅(丐丟丅丘七丝下下业:  val_5);
        }
        
        val_16 = this.丑丐丛丅丘丄下丟世();
        if(val_16 != 0)
        {
                val_16 = this.丑丐丛丅丘丄下丟世().gameObject;
            val_16.SetActive(value:  (this.isBasePointActive == true) ? 1 : 0);
        }
        
        this.丌七业丑丅且丅丒丏();
        this.丘东丏丕丟丛且丛三();
        this.丌与丟世丑万丙丑一(丐丟丅丘七丝下下业:  val_5);
        this.丁丟丏丁业世且世世();
    }
    private void 一丞下业万丄世丂丛()
    {
        var val_9;
        var val_10;
        val_9 = 0;
        goto label_1;
        label_12:
        Player_move_c val_1 = this.capturePlayers.Item[0];
        if(val_1.丟三丏丅世一丟丟上.丘丑丅三丆丑丌且丝() >= 1)
        {
                Player_move_c val_3 = this.capturePlayers.Item[0];
            NetworkStartTable val_9 = val_3.丟三丏丅世一丟丟上;
            val_9 = val_9.丘丑丅三丆丑丌且丝() - 1;
            if(this.丛丌三丝丐丈丝七业 != null)
        {
                val_10 = this.丛丌三丝丐丈丝七业.Item[val_9];
        }
        else
        {
                val_10 = 0.Item[val_9];
        }
        
            this.丛丌三丝丐丈丝七业.set_Item(index:  val_9, value:  val_10 + 1);
        }
        
        val_9 = 1;
        label_1:
        if(val_9 < this.capturePlayers.Count)
        {
            goto label_12;
        }
    
    }
    private void 丑丝丑丒七上丌丅业()
    {
        System.Collections.Generic.List<Player_move_c> val_4;
        var val_5;
        this.下丄丟丞丞三丝世丄 = false;
        var val_4 = 0;
        do
        {
            val_4 = this.capturePlayers;
            if(val_4 >= val_4.Count)
        {
                return;
        }
        
            val_5 = null;
            val_4 = this.capturePlayers.Item[0];
            val_5 = null;
            val_4 = val_4 + 1;
        }
        while((val_4.Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false);
        
        this.下丄丟丞丞三丝世丄 = true;
    }
    private void 丟世丐三下丞丂与丘(int 丐丟丅丘七丝下下业)
    {
        int val_1 = 丐丟丅丘七丝下下业 + 1;
        this.captureCommand = val_1;
        if(this.lastCaptureCommand != 0)
        {
                return;
        }
        
        this.lastCaptureCommand = val_1;
    }
    private int 东丛丗东丕丐丛丟专()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = 0;
        val_6 = 0;
        goto label_1;
        label_4:
        val_5 = 1;
        label_1:
        if(val_5 < this.丛丌三丝丐丈丝七业.Count)
        {
            goto label_4;
        }
        
        if(((this.丛丌三丝丐丈丝七业.Item[0] > 0) ? (val_6 + 1) : (val_6)) != 1)
        {
                return 0;
        }
        
        val_7 = null;
        val_7 = null;
        if((BaseCapturePoint.<>c.<>9__52_0) != null)
        {
                if(this.丛丌三丝丐丈丝七业 == null)
        {
                return this.丛丌三丝丐丈丝七业.FindIndex(match:  BaseCapturePoint.<>c.<>9__52_0);
        }
        
            return this.丛丌三丝丐丈丝七业.FindIndex(match:  BaseCapturePoint.<>c.<>9__52_0);
        }
        
        BaseCapturePoint.<>c.<>9__52_0 = new System.Predicate<System.Int32>(object:  BaseCapturePoint.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BaseCapturePoint.<>c::丝丙下丌丘下世丙丐(int 三丟东丕丄丄下下丑));
        if(this.丛丌三丝丐丈丝七业 != null)
        {
                return this.丛丌三丝丐丈丝七业.FindIndex(match:  BaseCapturePoint.<>c.<>9__52_0);
        }
        
        return this.丛丌三丝丐丈丝七业.FindIndex(match:  BaseCapturePoint.<>c.<>9__52_0);
    }
    private void 丄丐与丁世丘上丏丅(int 丐丟丅丘七丝下下业)
    {
        float val_4;
        var val_5;
        if((this.丛丌三丝丐丈丝七业.Item[丐丟丅丘七丝下下业] - 1) <= 2)
        {
                val_4 = mem[106023616 + ((val_1 - 1)) << 2];
            val_4 = 106023616 + ((val_1 - 1)) << 2;
        }
        else
        {
                val_4 = 1.3f;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_4 * val_3;
        val_3 = val_3 * 100f;
        val_3 = val_3 / 5f;
        if(this.captureCommand == this.myCommand)
        {
                val_3 = this.captureCounter + val_3;
            this.captureCounter = val_3;
            if(val_3 <= 100f)
        {
                return;
        }
        
            val_5 = 1120403456;
        }
        else
        {
                val_3 = this.captureCounter - val_3;
            this.captureCounter = val_3;
            if(val_3 >= 0)
        {
                return;
        }
        
            val_5 = 3267887104;
        }
        
        this.captureCounter = -100f;
    }
    private void 丌七业丑丅且丅丒丏()
    {
        if(this.丑丐丛丅丘丄下丟世() != 0)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.black;
            if(this.lastCaptureCommand == this.myCommand)
        {
                UnityEngine.Color val_4 = UnityEngine.Color.blue;
        }
        else
        {
                UnityEngine.Color val_5 = UnityEngine.Color.red;
        }
        
            this.丑丐丛丅丘丄下丟世().丛丟专丕世下丒丛七(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            float val_12 = 100f;
            val_12 = System.Math.Abs(this.captureCounter) / val_12;
            this.丑丐丛丅丘丄下丟世().丝与丑与丘丝专与且(丛丁三世世丆七不业:  val_12);
        }
        
        if(this.ownerCommand == 0)
        {
            goto label_10;
        }
        
        if(this.ownerCommand != this.myCommand)
        {
            goto label_11;
        }
        
        UnityEngine.Color val_8 = UnityEngine.Color.blue;
        goto label_13;
        label_10:
        UnityEngine.Color val_9 = UnityEngine.Color.white;
        goto label_13;
        label_11:
        UnityEngine.Color val_10 = UnityEngine.Color.red;
        label_13:
        this.丌丐丛丁与丁丂丛丟(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a});
    }
    private void 丘东丏丕丟丛且丛三()
    {
        int val_5;
        var val_6;
        var val_7;
        float val_5 = this.captureCounter;
        val_5 = val_5 * this.丘丌丌万丕不丁丙一;
        if(val_5 >= 0)
        {
                return;
        }
        
        val_5 = this.captureCommand;
        if(val_5 == 0)
        {
            goto label_11;
        }
        
        if((val_5 != this.myCommand) || (this.previousCommand == val_5))
        {
            goto label_4;
        }
        
        val_6 = null;
        val_6 = null;
        丗丄万丟专丈丌丙丈(下丘与业丗丙且业丑:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1783")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1783")) + " " + this.nameBasePoint);
        val_5 = this.captureCommand;
        if(val_5 == 0)
        {
            goto label_11;
        }
        
        label_4:
        if((val_5 == this.myCommand) || (this.previousCommand != this.myCommand))
        {
            goto label_20;
        }
        
        val_7 = null;
        val_7 = null;
        丗丄万丟专丈丌丙丈(下丘与业丗丙且业丑:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1784")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1784")) + " " + this.nameBasePoint);
        val_5 = this.captureCommand;
        if(val_5 != 0)
        {
            goto label_20;
        }
        
        label_11:
        if(System.Math.Abs(this.captureCounter) > 4f)
        {
                return;
        }
        
        val_5 = this.captureCommand;
        label_20:
        this.lastCaptureCommand = val_5;
        this.ownerCommand = 0;
        this.previousCommand = 0;
    }
    private void 丌与丟世丑万丙丑一(int 丐丟丅丘七丝下下业)
    {
        Player_move_c val_8;
        int val_9;
        int val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(System.Math.Abs(this.captureCounter) <= 99.9f)
        {
                return;
        }
        
        val_9 = this.captureCommand;
        if(val_9 == 0)
        {
                return;
        }
        
        val_10 = this.myCommand;
        if(val_10 == 0)
        {
                return;
        }
        
        if(this.previousCommand == val_9)
        {
                return;
        }
        
        if(val_10 == val_9)
        {
                if(this.captureCounter <= 99.9f)
        {
                return;
        }
        
            val_11 = null;
            val_11 = null;
            val_8 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_8 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            丗丄万丟专丈丌丙丈(下丘与业丗丙且业丑:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1781")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1781")) + " " + this.nameBasePoint);
            if(this.下丄丟丞丞三丝世丄 != false)
        {
                UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            Rilisoft.丞丛七上丕专丏丌丈.丗业上万丌东丝丅丕(丂丛丑东不丅丈一东:  5, 丞丁丑丏丄丏七丂不:  val_3.m_Handle.name, 一丁丏万七丈业丄丕:  false);
            val_8 = this.丛丌三丝丐丈丝七业;
            val_12 = null;
            if(val_8.Item[丐丟丅丘七丝下下业] == 1)
        {
                val_13 = null;
            丅丛丈丕下下丘丁丐();
        }
        else
        {
                val_14 = null;
            typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  62, 专上丝且丂世丛丝丒:  1f);
        }
        
        }
        
            val_9 = this.captureCommand;
            val_10 = this.myCommand;
            this.ownerCommand = val_9;
            this.previousCommand = val_9;
        }
        
        if(val_10 == val_9)
        {
                return;
        }
        
        if(this.captureCounter >= 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1785")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1785")) + " " + this.nameBasePoint;
        丗丄万丟专丈丌丙丈(下丘与业丗丙且业丑:  val_8);
        this.ownerCommand = this.captureCommand;
        this.previousCommand = this.captureCommand;
    }
    private void 丌丅下丕专丈丑下三(int 丈丞与上丒丘丕丞三)
    {
        this.ownerCommand = 丈丞与上丒丘丕丞三;
        this.previousCommand = 丈丞与上丒丘丕丞三;
    }
    private void 丁丟丏丁业世且世世()
    {
        var val_13;
        var val_14;
        if(this.丞一业不丟万世三且 == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUIPart_CapturePoints.__il2cppRuntimeField_this_arg.万与丐业丗丌且东丒(丙业与丙丗丝不丈东:  (this.isBasePointActive == true) ? 1 : 0);
        InGameGUIPart_CapturePoints.__il2cppRuntimeField_this_arg.三丂丘丝丅丑丈丌丏(丕丗丘丑丛与丑业丒:  this.nameBasePoint);
        bool val_5 = ((this.ownerCommand != this.captureCommand) ? 1 : 0) & ((this.captureCommand != 0) ? 1 : 0);
        if(this.ownerCommand != this.myCommand)
        {
                if(this.captureCounter <= 0f)
        {
            goto label_16;
        }
        
        }
        
        val_13 = 1;
        goto label_17;
        label_16:
        val_13 = 0;
        label_17:
        float val_12 = System.Math.Abs(this.captureCounter);
        if(this.业七业与三东三丆丐() != false)
        {
                val_14 = 1;
        }
        else
        {
                bool val_13 = this.isBasePointActive;
            val_13 = val_13 ^ 1;
            val_14 = val_13 & 255;
        }
        
        val_12 = val_12 / 100f;
        InGameGUIPart_CapturePoints.__il2cppRuntimeField_this_arg.丘丁且丒世丞上丄丆(丙东丏丕丞丁丈丈万:  (this.ownerCommand != 0) ? 1 : 0, 专七世丕且丐丙丕东:  val_5, 七丟丁下且不丟丌丏:  (this.captureCommand == this.myCommand) ? 1 : 0, 下丑业丕丌丐三丒丙:  false, 下且下丄专下丝丞丟:  val_5 & ((this.ownerCommand != 0) ? 1 : 0), 丆丅丐三一不丕世三:  (val_14 == true) ? 1 : 0, 丑丁丐一三东丟业丝:  val_12);
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_17;
        var val_18;
        var val_19;
        var val_20;
        val_17 = 1152921505171275776;
        val_18 = null;
        val_18 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(GameConnect.丞丂丑一丕丑丙三丐() == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  丘丛丏丘丝七世七丅.name, b:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_17 = 丘丛丏丘丝七世七丅.transform.parent;
        if(val_17 == 0)
        {
                return;
        }
        
        val_17 = 丘丛丏丘丝七世七丅.transform.parent.gameObject;
        if((val_17.CompareTag(tag:  "Player")) == false)
        {
                return;
        }
        
        this.丘不丕不世三丒丄丄(丒一丄丗丞丗丄丐丂:  丘丛丏丘丝七世七丅.transform.parent.gameObject);
        val_19 = null;
        val_19 = null;
        val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject & 1) == 0)
        {
                return;
        }
        
        this.下一万丄一丐一三丐();
        val_20 = null;
        val_20 = null;
        CapturePointsController.丄丘七三上丕世丞业.丟下三下丈丆丝东丁(专七万不丐丆丟东丈:  this.专七万不丐丆丟东丈, 丂东丄丏丕丕丅上一:  typeof(Player_move_c).__il2cppRuntimeField_3B8 + 32);
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_17;
        var val_18;
        var val_19;
        var val_20;
        val_17 = 1152921505171275776;
        val_18 = null;
        val_18 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(GameConnect.丞丂丑一丕丑丙三丐() == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  丘丛丏丘丝七世七丅.name, b:  "BodyCollider")) == false)
        {
                return;
        }
        
        val_17 = 丘丛丏丘丝七世七丅.transform.parent;
        if(val_17 == 0)
        {
                return;
        }
        
        val_17 = 丘丛丏丘丝七世七丅.transform.parent.gameObject;
        if((val_17.CompareTag(tag:  "Player")) == false)
        {
                return;
        }
        
        this.丆专丘丕丝不一丝与(丒一丄丗丞丗丄丐丂:  丘丛丏丘丝七世七丅.transform.parent.gameObject);
        val_19 = null;
        val_19 = null;
        val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if((丘丛丏丘丝七世七丅.transform.parent.gameObject & 1) == 0)
        {
                return;
        }
        
        this.丈东丌丟丒丄丏丆与();
        val_20 = null;
        val_20 = null;
        CapturePointsController.丄丘七三上丕世丞业.丁世丄不丈丗丕丘上(专七万不丐丆丟东丈:  this.专七万不丐丆丟东丈, 丂东丄丏丕丕丅上一:  typeof(Player_move_c).__il2cppRuntimeField_3B8 + 32);
    }
    private void 丘不丕不世三丒丄丄(UnityEngine.GameObject 丒一丄丗丞丗丄丐丂)
    {
        SkinName val_1 = 丒一丄丗丞丗丄丐丂.GetComponent<SkinName>();
        if((this.capturePlayers.Contains(item:  val_1.playerMoveC)) != false)
        {
                return;
        }
        
        this.capturePlayers.Add(item:  val_1.playerMoveC);
    }
    private void 丆专丘丕丝不一丝与(UnityEngine.GameObject 丒一丄丗丞丗丄丐丂)
    {
        SkinName val_1 = 丒一丄丗丞丗丄丐丂.GetComponent<SkinName>();
        if((this.capturePlayers.Contains(item:  val_1.playerMoveC)) == false)
        {
                return;
        }
        
        bool val_3 = this.capturePlayers.Remove(item:  val_1.playerMoveC);
    }
    private void 下一万丄一丐一三丐()
    {
        this.丞一业不丟万世三且 = true;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUIPart_CapturePoints.__il2cppRuntimeField_this_arg.万与丐业丗丌且东丒(丙业与丙丗丝不丈东:  (this.isBasePointActive == true) ? 1 : 0);
    }
    private void 丈东丌丟丒丄丏丆与()
    {
        this.丞一业不丟万世三且 = false;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUIPart_CapturePoints.__il2cppRuntimeField_this_arg.万与丐业丗丌且东丒(丙业与丙丗丝不丈东:  false);
    }
    internal void 丕丞丙丈丞丞丂丏丞(Player_move_c 上下丗丌丑业丌三与)
    {
        this.capturePlayers.Add(item:  上下丗丌丑业丌三与);
    }
    internal void 丝三丘丙万三与丙丛(Player_move_c 丕丌丛丗三丁丟丛东)
    {
        bool val_1 = this.capturePlayers.Remove(item:  丕丌丛丗三丁丟丛东);
    }
    internal void 七丁丞丌下丏丌丁丟(float 丝丝丝丛上丈丅丕不, int 丙一丆丕丑丟丑三丘, int 与丂一三世丑丕丈丂, int 丝丑丏业七不丆丁且, bool 专丗丛丝丗丞下丑丄)
    {
        if(this.丙丞丛丕丅世下丅丒 == true)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈丗丑专丁丂业丛世(丝丝丝丛上丈丅丕不:  丝丝丝丛上丈丅丕不, 丙一丆丕丑丟丑三丘:  丙一丆丕丑丟丑三丘, 与丂一三世丑丕丈丂:  与丂一三世丑丕丈丂, 丝丑丏业七不丆丁且:  丝丑丏业七不丆丁且));
        this.丙丞丛丕丅世下丅丒 = 专丗丛丝丗丞下丑丄;
    }
    private System.Collections.IEnumerator 丈丗丑专丁丂业丛世(float 丝丝丝丛上丈丅丕不, int 丙一丆丕丑丟丑三丘, int 与丂一三世丑丕丈丂, int 丝丑丏业七不丆丁且)
    {
        BaseCapturePoint.丕丕丘不丌上丒不丛 val_1 = new BaseCapturePoint.丕丕丘不丌上丒不丛();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丝丝丝丛上丈丅丕不 = 丝丝丝丛上丈丅丕不;
            .与丂一三世丑丕丈丂 = 与丂一三世丑丕丈丂;
            .丙一丆丕丑丟丑三丘 = 丙一丆丕丑丟丑三丘;
        }
        else
        {
                mem[32] = this;
            .丝丝丝丛上丈丅丕不 = 丝丝丝丛上丈丅丕不;
            .丙一丆丕丑丟丑三丘 = 丙一丆丕丑丟丑三丘;
            mem[40] = 与丂一三世丑丕丈丂;
        }
        
        .丝丑丏业七不丆丁且 = 丝丑丏业七不丆丁且;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 且不丙丟丘不丌丆丌(float 丝丝丝丛上丈丅丕不)
    {
        float val_2;
        if(this.lastCaptureCommand == this.myCommand)
        {
                val_2 = System.Math.Abs(丝丝丝丛上丈丅丕不);
        }
        else
        {
                float val_2 = System.Math.Abs(丝丝丝丛上丈丅丕不);
            val_2 = -val_2;
        }
        
        val_2 = this.captureCounter - val_2;
        float val_3 = System.Math.Abs(val_2);
        if((val_3 >= 0) && (val_3 <= 10f))
        {
                float val_1 = val_2 - this.captureCounter;
            val_1 = val_1 * 0.5f;
            val_2 = this.captureCounter + val_1;
        }
        
        this.captureCounter = val_2;
    }
    private void 丌丐丛丁与丁丂丛丟(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if(this.rayPoint == 0)
        {
                return;
        }
        
        UnityEngine.Color val_2 = this.rayPoint.startColor;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, rhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a})) != true)
        {
                UnityEngine.Color val_4 = this.rayPoint.endColor;
            if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, rhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a})) == false)
        {
                return;
        }
        
        }
        
        this.rayPoint.startColor = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.rayPoint.endColor = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    internal void 丛丕七丈丂丏丐丂丌()
    {
        this.丙丞丛丕丅世下丅丒 = false;
    }
    public BaseCapturePoint()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.red;
        this.上丂丝丙丌东丒专丂 = val_1;
        mem[1152921537438101556] = val_1.g;
        mem[1152921537438101560] = val_1.b;
        mem[1152921537438101564] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.blue;
        this.丂专一丁丕且与与丁 = val_2;
        mem[1152921537438101572] = val_2.g;
        mem[1152921537438101576] = val_2.b;
        mem[1152921537438101580] = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        this.下丅丗三丄业丝万东 = val_3;
        mem[1152921537438101588] = val_3.g;
        mem[1152921537438101592] = val_3.b;
        mem[1152921537438101596] = val_3.a;
        UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        this.丄东丙丑丞丛不专丛 = val_4;
        mem[1152921537438101604] = val_4.g;
        mem[1152921537438101608] = val_4.b;
        mem[1152921537438101612] = val_4.a;
        this.丞世丏东丝东上业丞 = 2;
        this.丛丌三丝丐丈丝七业 = new System.Collections.Generic.List<System.Int32>();
        this.capturePlayers = new System.Collections.Generic.List<Player_move_c>();
        this.专七万不丐丆丟东丈 = 0;
    }

}
