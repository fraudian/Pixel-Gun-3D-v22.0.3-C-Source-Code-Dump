using UnityEngine;
internal sealed class GamepadCursorController : PGBehaviour
{
    // Fields
    internal static GamepadCursorController 丆丕丝丒不丙且丐丗;
    internal GamepadCursor 丝世丟丂上不万东七;
    private static bool 丙丅丛七丅丒东丆与;
    private static bool 丑丘不丑丞世东专万;
    private static bool <丟丑且丆丛七丝丏丘>k__BackingField;
    private bool <丘丕丒七丑七三丁且>k__BackingField;
    private bool <七三下且与丏世丘丏>k__BackingField;
    
    // Properties
    internal static bool 与万一丝丂下丌丈丗 { get; set; }
    internal bool 丒丕专丛丝丄上丘丕 { get; set; }
    internal bool 丗丄丌丅丛丛丛世三 { get; set; }
    
    // Methods
    internal static bool 丂业丗业世世丛丟七()
    {
        return (bool)GamepadCursorController.<丟丑且丆丛七丝丏丘>k__BackingField;
    }
    private static void 且丗与世丂东世丌丆(bool 丙业与丙丗丝不丈东)
    {
        GamepadCursorController.<丟丑且丆丛七丝丏丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丆丙丆一丒三丕丞丏()
    {
        return (bool)this.<丘丕丒七丑七三丁且>k__BackingField;
    }
    private void 丝丝丁丝专丒且与丌(bool 丙业与丙丗丝不丈东)
    {
        this.<丘丕丒七丑七三丁且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丌丙丟丛七七丂上专()
    {
        return (bool)this.<七三下且与丏世丘丏>k__BackingField;
    }
    private void 丘业丑丅一丂丐丆不(bool 丙业与丙丗丝不丈东)
    {
        this.<七三下且与丏世丘丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        this.丘上丐世丆丑且丞丒();
        GamepadCursorController.<丟丑且丆丛七丝丏丘>k__BackingField = false;
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void GamepadCursorController::且不丅万丕丙丕丆且(PGCompany.丆七丗丂世丞丗丙三 丝丘三万上世丑丑丂, object 丙业与丙丗丝不丈东)));
        GamepadManager.业世丘世丏一丗丗业(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GamepadCursorController::业专丘丑丞且七丅世(string 丙业与丙丗丝不丈东)));
        GamepadManager.丟专与丟丅丑丝丅上(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GamepadCursorController::一上丁一丞业丆且下(string 丙业与丙丗丝不丈东)));
    }
    internal void 丘上丐世丆丑且丞丒()
    {
        if(GamepadCursorController.丆丕丝丒不丙且丐丗 != 0)
        {
                return;
        }
        
        GamepadCursorController.丆丕丝丒不丙且丐丗 = this.GetComponent<GamepadCursorController>();
    }
    private GamepadCursor 丗丞丐专丙不七东丒()
    {
        var val_10;
        GamepadCursor val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Gamepad/GamepadCursor")).GetComponent<GamepadCursor>();
        val_10 = val_3;
        if(val_3 == 0)
        {
                if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.LogError(message:  "Don\'t load gamepad cursor");
            val_10 = 0;
            return (GamepadCursor)val_10;
        }
        
        }
        
        val_10.丌丟丄业且三丛丕丄().SetParent(p:  GamepadUiController.丆丕丝丒不丙且丐丗.丌丟丄业且三丛丕丄());
        val_10.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_10.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return (GamepadCursor)val_10;
    }
    internal void 丗丞丈不且丛不世不(bool 丏业丟一东丂东丘丛, PGCompany.业丐与丕丒下丑下丈 丆下丘丕丐丗丅丅不 = 23)
    {
        PGCompany.业丐与丕丒下丑下丈 val_4 = 丆下丘丕丐丗丅丅不;
        if(val_4 == 23)
        {
                if(丏业丟一东丂东丘丛 != false)
        {
                val_4 = 23;
        }
        else
        {
                PGCompany.业丐与丕丒下丑下丈 val_4 = PGCompany.GamepadCoreController.Instance;
            PGCompany.业丐与丕丒下丑下丈 val_2 = val_4.三丝丂丏一世丛丌东();
            val_4 = (val_2 == 23) ? 0 : (val_2);
        }
        
        }
        
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  val_4);
    }
    private bool 丕丈丕丂丆丞上七下()
    {
        return UnityEngine.Object.op_Inequality(x:  this.丝世丟丂上不万东七, y:  0);
    }
    internal void 下与丆丌世丛丗丝丝(UnityEngine.Transform 丟丒丞丐丐丘丒丄东, UnityEngine.Camera 与业丞东丙丕且丏丈)
    {
        if(this.丕丈丕丂丆丞上七下() == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = 与业丞东丙丕且丏丈.transform.position;
        UnityEngine.Vector3 val_4 = 丟丒丞丐丐丘丒丄东.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_7 = transform.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        this.丆丏丙业丆丈与丘丄(且丌上七丅东与丁万:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
    }
    internal void 丏丁丄丝与世世丕业()
    {
        GamepadCursor val_12;
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.丝世丟丂上不万东七, y:  0);
        if(val_1 == false)
        {
            goto label_3;
        }
        
        val_12 = val_1.丗丞丐专丙不七东丒();
        this.丝世丟丂上不万东七 = val_12;
        if(val_12 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_12 = this.丝世丟丂上不万东七;
        if(val_12 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        int val_4 = UnityEngine.Screen.width;
        int val_5 = UnityEngine.Screen.height;
        var val_6 = (val_4 < 0) ? (val_4 + 1) : (val_4);
        val_6 = val_6 >> 1;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  (float)val_6, y:  (float)((val_5 < 0) ? (val_5 + 1) : (val_5)) >> 1);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        UnityEngine.Vector3 val_11 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_12.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    private void 丆丏丙业丆丈与丘丄(UnityEngine.Vector2 且丌上七丅东与丁万)
    {
        if(this.丕丈丕丂丆丞上七下() == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 且丌上七丅东与丁万.x, y = 且丌上七丅东与丁万.y});
        this.丝世丟丂上不万东七.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    internal void 丅业丂丆万不丏丈丝(bool 丏业丟一东丂东丘丛)
    {
        GamepadCursor val_8;
        bool val_9 = 丏业丟一东丂东丘丛;
        if((this.<丘丕丒七丑七三丁且>k__BackingField) != true)
        {
                val_9 = this.丝世丟丂上不万东七;
            if(val_9 == 0)
        {
                return;
        }
        
            val_9 = 0;
        }
        
        bool val_2 = UnityEngine.Object.op_Equality(x:  this.丝世丟丂上不万东七, y:  0);
        if((val_9 & val_2) != false)
        {
                this.丝世丟丂上不万东七 = val_2.丗丞丐专丙不七东丒();
        }
        else
        {
                val_8 = this.丝世丟丂上不万东七;
            if(val_8 == 0)
        {
                return;
        }
        
        }
        
        bool val_6 = val_9 & 1;
        GamepadCursorController.<丟丑且丆丛七丝丏丘>k__BackingField = val_6;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝世丟丂上不万东七, 丏业丟一东丂东丘丛:  val_6);
        val_8 = 1152921505067495424;
        if(val_9 ^ enabled == false)
        {
                return;
        }
        
        enabled = val_9 & 1;
    }
    private void Update()
    {
        this.丘丁丝与丗且丂丂东();
    }
    private void 且不丅万丕丙丕丆且(PGCompany.丆七丗丂世丞丗丙三 丝丘三万上世丑丑丂, object 丙业与丙丗丝不丈东)
    {
        if(丝丘三万上世丑丑丂 != 33)
        {
                if(丝丘三万上世丑丑丂 != 34)
        {
                return;
        }
        
            this.不与丌东丏万下丏丘(世丐世丄不不丈丗丏:  new UnityEngine.Vector2() {x = 3.782474E-38f});
            return;
        }
        
        GamepadCursorController.丙丅丛七丅丒东丆与 = ;
    }
    internal UnityEngine.Vector2 丐东下丒丞七丂丟业()
    {
        UnityEngine.Vector3 val_2 = this.丝世丟丂上不万东七.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_3 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
    }
    internal bool 丌丘丙丒丅丆三不东()
    {
        return (bool)GamepadCursorController.丙丅丛七丅丒东丆与;
    }
    internal bool 丈丅丗丕上丏丂丛丟()
    {
        return (bool)(GamepadCursorController.丙丅丛七丅丒东丆与 == false) ? 1 : 0;
    }
    internal bool 世丆且丌下丌丟世丌()
    {
        bool val_1;
        if(GamepadCursorController.丙丅丛七丅丒东丆与 == false)
        {
            goto label_1;
        }
        
        if(GamepadCursorController.丑丘不丑丞世东专万 == true)
        {
            goto label_4;
        }
        
        val_1 = true;
        GamepadCursorController.丑丘不丑丞世东专万 = val_1;
        return (bool)val_1;
        label_1:
        if(GamepadCursorController.丑丘不丑丞世东专万 != false)
        {
                val_1 = 0;
            GamepadCursorController.丑丘不丑丞世东专万 = false;
            return (bool)val_1;
        }
        
        label_4:
        val_1 = 0;
        return (bool)val_1;
    }
    private void 丗丅丙丙丌丛世丝且()
    {
        this.<丘丕丒七丑七三丁且>k__BackingField = false;
        this.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  23);
    }
    private void 一上丁一丞业丆且下(string 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丙业与丙丗丝不丈东);
        if(val_1 == false)
        {
                return;
        }
        
        this.<丘丕丒七丑七三丁且>k__BackingField = false;
        val_1.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  23);
    }
    private void 业专丘丑丞且七丅世(string 丙业与丙丗丝不丈东)
    {
        this.<丘丕丒七丑七三丁且>k__BackingField = true;
        PGCompany.业丐与丕丒下丑下丈 val_2 = PGCompany.GamepadCoreController.Instance.丈丛七丐丏丘丕下丕();
        if((val_2 | 16) == 23)
        {
                val_2.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
        }
        
        this.<七三下且与丏世丘丏>k__BackingField = true;
    }
    private void 丘丁丝与丗且丂丂东()
    {
        GamepadCursor val_4 = this.丝世丟丂上不万东七;
        if(val_4 == 0)
        {
                return;
        }
        
        if((GamepadCursorController.<丟丑且丆丛七丝丏丘>k__BackingField) == false)
        {
                return;
        }
        
        val_4 = mem[GamepadUiController.丆丕丝丒不丙且丐丗 + 72];
        val_4 = GamepadUiController.丆丕丝丒不丙且丐丗.RendererCamera;
        if(enabled != false)
        {
                return;
        }
        
        enabled = ((GamepadCursorController.<丟丑且丆丛七丝丏丘>k__BackingField) == true) ? 1 : 0;
    }
    private void 不与丌东丏万下丏丘(UnityEngine.Vector2 世丐世丄不不丈丗丏)
    {
        float val_30;
        var val_31;
        var val_32;
        var val_34;
        float val_35;
        float val_38;
        var val_39;
        val_30 = 世丐世丄不不丈丗丏.y;
        if((GamepadCursorController.<丟丑且丆丛七丝丏丘>k__BackingField) == false)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 世丐世丄不不丈丗丏.x, y = val_30}, d:  PGCompany.GamepadCoreController.专丗丑世丅丂不丂丝);
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  (float)UnityEngine.Screen.width / UnityEngine.Screen.height);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, d:  UnityEngine.Time.unscaledDeltaTime);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
        this.丝世丟丂上不万东七.丌丟丄业且三丛丕丄().Translate(translation:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        if(this.丝世丟丂上不万东七.cursorBoxCollider != null)
        {
                val_32 = this.丝世丟丂上不万东七.cursorBoxCollider.transform;
        }
        else
        {
                val_32 = 0.transform;
        }
        
        UnityEngine.Vector3 val_12 = this.丝世丟丂上不万东七.cursorBoxCollider.center;
        UnityEngine.Vector3 val_13 = val_32.TransformPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_30 = val_14.x;
        UnityEngine.Vector2 val_15 = this.丝世丟丂上不万东七.texture.localSize;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, d:  2f);
        val_34 = 1152921505093320704;
        val_35 = val_16.x;
        UnityEngine.Vector2 val_17 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        val_38 = val_17.x;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                UnityEngine.Vector2 val_19 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
            val_39 = null;
            val_39 = null;
            val_34 = GamepadUiController.丆丕丝丒不丙且丐丗.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_21 = val_34.localScale;
            val_35 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            UnityEngine.Vector3 val_23 = GamepadUiController.丆丕丝丒不丙且丐丗.丌丟丄业且三丛丕丄().localScale;
            float val_24 = IphoneXCameraScaler.七丝丛不万东一与丅 + val_21.x;
            val_23.y = val_35 + val_23.y;
            val_24 = val_38 * val_24;
            val_23.y = val_17.y * val_23.y;
            UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  val_24, y:  val_23.y);
            val_30 = val_25.x;
            val_38 = val_25.y;
            UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_19.x - val_30, y:  val_19.y - val_38);
        }
        else
        {
                UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  0f, y:  0f);
        }
        
        this.丄丂下丝三万与丙丒(东丛丙丗丙丘丙专丒:  new UnityEngine.Vector3() {x = val_30, y = val_14.y, z = 0f}, 丅丆万丗丑不且丈丂:  new UnityEngine.Vector2() {x = val_35, y = val_16.y}, 且丅丗丞丕丝上丒丒:  new UnityEngine.Vector2() {x = val_38, y = val_17.y}, 万专不业专七丞丛丘:  new UnityEngine.Vector2() {x = val_29.x});
    }
    private void 丄丂下丝三万与丙丒(UnityEngine.Vector3 东丛丙丗丙丘丙专丒, UnityEngine.Vector2 丅丆万丗丑不且丈丂, UnityEngine.Vector2 且丅丗丞丕丝上丒丒, UnityEngine.Vector2 万专不业专七丞丛丘)
    {
        float val_1;
        float val_4 = UnityEngine.Mathf.Clamp(value:  东丛丙丗丙丘丙专丒.x, min:  丅丆万丗丑不且丈丂.x + 万专不业专七丞丛丘.x, max:  且丅丗丞丕丝上丒丒.x - 丅丆万丗丑不且丈丂.x);
        UnityEngine.Vector2 val_5 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        float val_8 = UnityEngine.Mathf.Clamp(value:  东丛丙丗丙丘丙专丒.y, min:  丅丆万丗丑不且丈丂.y + val_1, max:  val_5.y - 丅丆万丗丑不且丈丂.y);
        UnityEngine.Vector3 val_10 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.丝世丟丂上不万东七.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    public GamepadCursorController()
    {
    
    }

}
