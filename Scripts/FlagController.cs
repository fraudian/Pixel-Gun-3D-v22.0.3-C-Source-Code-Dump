using UnityEngine;
internal sealed class FlagController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    public bool isBlue;
    public bool isCapture;
    public bool isBaza;
    public bool isCaptureFromBaza;
    public bool attemptToCapture;
    public UnityEngine.GameObject rayBlue;
    public UnityEngine.GameObject rayRed;
    public UnityEngine.GameObject flagModel;
    public UnityEngine.GameObject flagModelRed;
    public UnityEngine.GameObject flagModelBlue;
    public UnityEngine.GameObject pointObjTexture;
    public UnityEngine.Transform targetTrasform;
    public float timerToBaza;
    private float 丏丂丝丟丞丌丆与丕;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    private int 丑丙丙与丈丂三万丆;
    private InGameGUI 专七下下丝与业丁丂;
    private WorldPosIndicationItem 丂丟东业且丂上丏上;
    private WorldPosIndicationItem 丝上三丌万一不丐丞;
    internal static UnityEngine.Transform 三丑东丏丌丗丄与专;
    internal static UnityEngine.Transform 与丒丌丆一一丒丝业;
    private UnityEngine.Transform 与丛丐丑一丕专丞丏;
    private readonly int 丒丄丝丁东丑丗业七;
    private readonly int 丁专丟丛不东丗丙丆;
    private readonly int 丄一丘下且丕丑丝丟;
    private readonly int 一丒丒丈丝不丌且丗;
    private FlagPedestalController 丒丒丙丐丘万丞专丘;
    private int 丝丌且丝丛丙万丅丙;
    
    // Properties
    private WorldPosIndicationItem 丛丘丘丑且丁丂丄丌 { get; }
    private WorldPosIndicationItem 万万且专丞丌丕丆丙 { get; }
    
    // Methods
    private WorldPosIndicationItem 丛与一且且丟丙专丗()
    {
        WorldPosIndicationItem val_4 = this.丂丟东业且丂上丏上;
        if(val_4 != 0)
        {
                return val_4;
        }
        
        UnityEngine.Transform val_3 = this.丒丒丙丐丘万丞专丘.transform.GetChild(index:  0);
        val_3.丕七下丗专丈三丄丈(丞丈且下且丙丞与丈: out  val_4, 丞下万上三丘上与专:  val_3);
        return val_4;
    }
    private WorldPosIndicationItem 丗丑丆下丝丛三东丟()
    {
        WorldPosIndicationItem val_3 = this.丝上三丌万一不丐丞;
        if(val_3 != 0)
        {
                return val_3;
        }
        
        UnityEngine.Transform val_2 = this.pointObjTexture.transform;
        val_2.丕七下丗专丈三丄丈(丞丈且下且丙丞与丈: out  val_3, 丞下万上三丘上与专:  val_2);
        return val_3;
    }
    private void Awake()
    {
        var val_17;
        var val_18;
        UnityEngine.GameObject val_19;
        var val_20;
        var val_21;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "FlagPedestal");
        val_17 = null;
        val_17 = null;
        val_18 = 0;
        if(val_2 == null)
        {
            goto label_8;
        }
        
        var val_4 = (null == null) ? (val_2) : 0;
        if(this.isBlue == false)
        {
            goto label_9;
        }
        
        label_13:
        val_20 = this;
        this.与丛丐丑一丕专丞丏 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "BazaZoneCommand1").GetComponent<UnityEngine.Transform>();
        val_21 =  + 528;
        goto label_12;
        label_8:
        if(this.isBlue == true)
        {
            goto label_13;
        }
        
        label_9:
        if(val_2 != null)
        {
                var val_7 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_19 = 0;
        }
        
        val_20 = this;
        this.与丛丐丑一丕专丞丏 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "BazaZoneCommand2").GetComponent<UnityEngine.Transform>();
        val_21 =  + 536;
        label_12:
        mem2[0] = this;
        UnityEngine.Vector3 val_10 = this.与丛丐丑一丕专丞丏.position;
        UnityEngine.Quaternion val_11 = this.与丛丐丑一丕专丞丏.rotation;
        this.丒丒丙丐丘万丞专丘 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_19, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}).GetComponent<FlagPedestalController>();
        UnityEngine.Object val_14 = UnityEngine.Resources.Load(path:  "ObjectPictFlag");
        this.SetColor(丂丄一丗业丗丐万丏:  0);
    }
    internal FlagController()
    {
        this.timerToBaza = 10f;
        this.丏丂丝丟丞丌丆与丕 = 10f;
        this.丁专丟丛不东丗丙丆 = 3;
        this.丄一丘下且丕丑丝丟 = 2;
        this.一丒丒丈丝不丌且丗 = 3;
        this.丝丌且丝丛丙万丅丙 = 0;
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void FlagController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.丈万丄与丈三丏丙丂 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void FlagController::OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    private void 丕七下丗专丈三丄丈(out WorldPosIndicationItem 丞丈且下且丙丞与丈, UnityEngine.Transform 丞下万上三丘上与专)
    {
        丞丈且下且丙丞与丈 = 0;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        WorldPosIndicationItem val_2 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem>();
        丞丈且下且丙丞与丈 = val_2;
        val_2.万三丗丆下万丅上丈(丞下万上三丘上与专:  丞下万上三丘上与专, 丒专丌万丄一丒万丏:  0f);
    }
    public void SetColor(int 丂丄一丗业丗丐万丏)
    {
        UnityEngine.Object val_14;
        var val_15;
        var val_16;
        UnityEngine.Texture val_17;
        val_14 = this.丛与一且且丟丙专丗();
        if(val_14 == 0)
        {
                return;
        }
        
        val_14 = this.丗丑丆下丝丛三东丟();
        if(val_14 == 0)
        {
                return;
        }
        
        this.丝丌且丝丛丙万丅丙 = 丂丄一丗业丗丐万丏;
        this.丒丒丙丐丘万丞专丘.SetColor(丂丄一丗业丗丐万丏:  丂丄一丗业丗丐万丏);
        bool val_5 = (丂丄一丗业丗丐万丏 == 2) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.flagModelRed, 丏业丟一东丂东丘丛:  val_5);
        bool val_6 = (丂丄一丗业丗丐万丏 == 1) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.flagModelBlue, 丏业丟一东丂东丘丛:  val_6);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rayRed, 丏业丟一东丂东丘丛:  val_5);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rayBlue, 丏业丟一东丂东丘丛:  val_6);
        val_15 = this.丛与一且且丟丙专丗();
        if(丂丄一丗业丗丐万丏 >= 1)
        {
                var val_8 = (丂丄一丗业丗丐万丏 == 1) ? this.丒丄丝丁东丑丗业七 : this.丁专丟丛不东丗丙丆;
            UnityEngine.Texture[] val_9 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((丂丄一丗业丗丐万丏 == 1 ? this.丒丄丝丁东丑丗业七 : this.丁专丟丛不东丗丙丆) << 3);
            val_15.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (丂丄一丗业丗丐万丏 == 1 ? this.丒丄丝丁东丑丗业七 : this.丁专丟丛不东丗丙丆) << 3) + 32]);
            val_15 = this.丗丑丆下丝丛三东丟();
            var val_11 = (丂丄一丗业丗丐万丏 == 1) ? this.丄一丘下且丕丑丝丟 : this.一丒丒丈丝不丌且丗;
            UnityEngine.Texture[] val_12 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((丂丄一丗业丗丐万丏 == 1 ? this.丄一丘下且丕丑丝丟 : this.一丒丒丈丝不丌且丗) << 3);
            val_16 = mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (丂丄一丗业丗丐万丏 == 1 ? this.丄一丘下且丕丑丝丟 : this.一丒丒丈丝不丌且丗) << 3) + 32];
            val_17 = val_16;
        }
        else
        {
                val_15.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  UnityEngine.Texture[].__il2cppRuntimeField_element_class);
            val_16 = this.丗丑丆下丝丛三东丟();
            val_17 = UnityEngine.Texture[].__il2cppRuntimeField_element_class;
        }
        
        val_16.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  val_17);
    }
    private void LateUpdate()
    {
        var val_4;
        var val_15;
        var val_16;
        UnityEngine.Transform val_17;
        bool val_18;
        val_15 = this;
        if((this.targetTrasform != 0) || (this.丑丙丙与丈丂三万丆 == 1))
        {
            goto label_29;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_17 = 1152921525761785056;
        val_18 = 1152921525761786080;
        label_12:
        if(((-57213136) & 1) == 0)
        {
            goto label_8;
        }
        
        if((X24 + 496 + 32) != this.丑丙丙与丈丂三万丆)
        {
            goto label_12;
        }
        
        this.targetTrasform = transform;
        mem2[0] = this.isCaptureFromBaza;
        UnityEngine.Debug.LogError(message:  "Flag: player "("Flag: player ") + public System.Boolean List.Enumerator<Rilisoft.FortItemEffectHandler>::MoveNext()(public System.Boolean List.Enumerator<Rilisoft.FortItemEffectHandler>::MoveNext()) + " with flag");
        mem2[0] = 1;
        val_18 = this.isBlue;
        val_4.丐丏七丌丕丗业且上().丛七与不丂丕丏丒丈(丝丌丆上丙一世丄一:  (val_18 == true) ? 1 : 0, 不丆业丏上丐与丌业:  " with flag");
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_29:
        if(this.targetTrasform == 0)
        {
                return;
        }
        
        val_17 = this.targetTrasform;
        UnityEngine.Vector3 val_11 = val_17.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        val_15 = this.transform;
        UnityEngine.Quaternion val_13 = this.targetTrasform.rotation;
        val_15.rotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
    }
    private void 世不与丞丟丂丁丒丆()
    {
        var val_8;
        var val_9;
        if(this.丛与一且且丟丙专丗() == 0)
        {
                return;
        }
        
        if((this.isBaza != false) && (this.flagModel.activeInHierarchy != false))
        {
                val_8 = this.丛与一且且丟丙专丗().gameObject;
            val_9 = 0;
        }
        else
        {
                val_8 = this.丛与一且且丟丙专丗().gameObject;
            val_9 = 1;
        }
        
        val_8.SetActive(value:  true);
    }
    private void 一丈丁业下丈万丞丅()
    {
        var val_6;
        if(this.丗丑丆下丝丛三东丟() == 0)
        {
                return;
        }
        
        bool val_3 = this.flagModel.activeInHierarchy;
        UnityEngine.GameObject val_5 = this.丗丑丆下丝丛三东丟().gameObject;
        if(val_5 == null)
        {
            goto label_6;
        }
        
        if(val_3 == false)
        {
            goto label_7;
        }
        
        label_9:
        val_6 = 1;
        goto label_8;
        label_6:
        if(val_3 == true)
        {
            goto label_9;
        }
        
        label_7:
        val_6 = 0;
        label_8:
        val_5.SetActive(value:  false);
    }
    private void Update()
    {
        var val_13;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_41;
        var val_42;
        var val_43;
        bool val_44;
        var val_45;
        var val_46;
        if(this.专七下下丝与业丁丂 == 0)
        {
                this.专七下下丝与业丁丂 = InGameGUI.丙丞专丌丁丞与不丐;
        }
        
        val_35 = null;
        val_35 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_9;
        }
        
        val_36 = 0;
        goto label_10;
        label_9:
        val_37 = null;
        val_37 = null;
        if(丘丑丅三丆丑丌且丝() == 1)
        {
                if(this.isBlue == true)
        {
            goto label_22;
        }
        
        }
        
        val_38 = null;
        val_38 = null;
        if(丘丑丅三丆丑丌且丝() == 2)
        {
                if(this.isBlue == false)
        {
            goto label_22;
        }
        
        }
        
        val_36 = 2;
        goto label_23;
        label_22:
        val_36 = 1;
        label_23:
        label_10:
        this.SetColor(丂丄一丗业丗丐万丏:  1);
        var val_6 = (this.isCapture == true) ? 1 : 0;
        val_6 = this.rayBlue.activeInHierarchy ^ val_6;
        if(val_6 != true)
        {
                this.rayBlue.SetActive(value:  (this.isCapture == false) ? 1 : 0);
        }
        
        var val_9 = (this.isCapture == true) ? 1 : 0;
        val_9 = this.rayRed.activeInHierarchy ^ val_9;
        if(val_9 != true)
        {
                this.rayRed.SetActive(value:  (this.isCapture == false) ? 1 : 0);
        }
        
        val_39 = null;
        val_39 = null;
        List.Enumerator<T> val_11 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_41 = 0;
        val_42 = 0;
        goto label_39;
        label_40:
        string val_14 = val_13.丐丏七丌丕丗业且上();
        if(val_14 != 0)
        {
                int val_16 = val_14.丘丑丅三丆丑丌且丝();
            if(val_16 == 1)
        {
                val_42 = 1;
        }
        else
        {
                var val_17 = (val_16 == 2) ? (val_41 + 1) : (val_41);
        }
        
        }
        
        label_39:
        if(((-56688736) & 1) != 0)
        {
            goto label_40;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_18 = (val_42 == 0) ? 1 : 0;
        bool val_20 = ((val_17 == 0) ? 1 : 0) | val_18;
        val_18 = val_20 ^ this.flagModel.activeSelf;
        if(val_18 != true)
        {
                this.flagModel.SetActive(value:  ((val_17 != 0) ? 1 : 0) & ((val_42 != 0) ? 1 : 0));
        }
        
        if(this.专七下下丝与业丁丂 != 0)
        {
                if(val_20 ^ this.专七下下丝与业丁丂.专专丛丟丆丂且丄丒.message_wait.activeSelf != false)
        {
                this.专七下下丝与业丁丂.专专丛丟丆丂且丄丒.message_wait.SetActive(value:  val_20);
            this.专七下下丝与业丁丂.timerShowNow = (val_20 != 0) ? 0f : 3f;
        }
        
        }
        
        if((val_20 == 0) || (this.isCapture == false))
        {
            goto label_61;
        }
        
        val_43 = null;
        val_43 = null;
        List.Enumerator<T> val_29 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        goto label_69;
        label_70:
        string val_30 = val_13.丐丏七丌丕丗业且上();
        if(this.丑丙丙与丈丂三万丆 == (val_16 == 2 ? (val_41 + 1) : val_41 + 496 + 32))
        {
                mem2[0] = 0;
        }
        
        label_69:
        if(((-56688736) & 1) != 0)
        {
            goto label_70;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.GoBaza();
        label_61:
        val_44 = 1152921505286238208;
        if(((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false) && (this.isCapture != true)) && (this.isBaza != true))
        {
                float val_32 = UnityEngine.Time.deltaTime;
            val_32 = this.timerToBaza - val_32;
            this.timerToBaza = val_32;
            if(val_32 < 0)
        {
                this.GoBaza();
            val_45 = null;
            val_45 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer != 0)
        {
                val_46 = null;
            val_46 = null;
            val_44 = this.isBlue;
            丝丕不丑东世丝丗三(丝丌丆上丙一世丄一:  (val_44 == true) ? 1 : 0);
        }
        
        }
        
        }
        
        this.世不与丞丟丂丁丒丆();
        this.一丈丁业下丈万丞丅();
    }
    public void GoBaza()
    {
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  27, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_2;
        int val_3;
        var val_4;
        val_2 = 丞世不丒下上上丝丑;
        byte val_1 = val_2 & 255;
        if(val_1 == 82)
        {
            goto label_1;
        }
        
        if(val_1 == 63)
        {
            goto label_2;
        }
        
        if(val_1 != 27)
        {
            goto label_3;
        }
        
        this.丌上丑丐万业世一丒();
        goto label_8;
        label_1:
        val_3 = 专丒丌丆下丐丞丟丞.Length;
        if(val_3 == 0)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_2 = 专丒丌丆下丐丞丟丞[0];
        object val_2 = 专丒丌丆下丐丞丟丞[1];
        this.丌上丗万丂丟上丆丑(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion());
        goto label_8;
        label_2:
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        this.三丄七下丟丑丂丌与(下不不丆丐与世丛丗:  21884928);
        label_8:
        val_4 = 1;
        return (bool)val_4;
        label_3:
        val_4 = 0;
        return (bool)val_4;
    }
    internal void 丌上丑丐万业世一丒()
    {
        var val_7;
        if(this.丑丙丙与丈丂三万丆 == 1)
        {
            goto label_16;
        }
        
        val_7 = null;
        val_7 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        goto label_9;
        label_10:
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(this.丑丙丙与丈丂三万丆 == (X24 + 496 + 32))
        {
                mem2[0] = 0;
        }
        
        label_9:
        if(((-56082376) & 1) != 0)
        {
            goto label_10;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_16:
        this.isCapture = true;
        this.isBaza = true;
        this.丑丙丙与丈丂三万丆 = 0;
        this.timerToBaza = this.丏丂丝丟丞丌丆与丕;
        this.targetTrasform = 0;
        UnityEngine.Vector3 val_4 = this.与丛丐丑一丕专丞丏.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Quaternion val_6 = this.与丛丐丑一丕专丞丏.rotation;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
    }
    public void TryCapture(int 下不不丆丐与世丛丗)
    {
        PhotonView val_2;
        if(this.attemptToCapture == true)
        {
                return;
        }
        
        this.attemptToCapture = true;
        val_2 = this.丄丈丑丐丆丞丘与丗;
        object[] val_1 = new object[1];
        val_1[0] = 下不不丆丐与世丛丗;
        val_2.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  63, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 三丄七下丟丑丂丌与(int 下不不丆丐与世丛丗)
    {
        object val_6;
        object val_7;
        var val_8;
        var val_9;
        与丅丕丈丘东丝世丟 val_1 = 与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  下不不丆丐与世丛丗);
        object[] val_2 = new object[4];
        val_2[0] = "Flag: Flag capture by ";
        if(val_1 == null)
        {
            goto label_5;
        }
        
        val_6 = val_1.丁下不丛下且丌专丈();
        if(val_6 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        val_6 = "null";
        label_6:
        label_9:
        val_2[1] = val_6;
        val_2[2] = " ";
        val_2[3] = 下不不丆丐与世丛丗;
        val_7 = +val_2;
        UnityEngine.Debug.LogError(message:  val_7);
        if(this.isCapture == true)
        {
                return;
        }
        
        this.isBaza = false;
        this.丑丙丙与丈丂三万丆 = 下不不丆丐与世丛丗;
        this.isCaptureFromBaza = this.isBaza;
        this.isCapture = true;
        if(this.attemptToCapture != true)
        {
                val_8 = null;
            val_8 = null;
            val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_7 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_7 != 0)
        {
                val_9 = null;
            val_9 = null;
            val_7 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 496];
            val_7 = typeof(Player_move_c).__il2cppRuntimeField_628 + 496;
            this.GoBaza();
        }
        
        }
        
        this.attemptToCapture = false;
    }
    public void SetNOCapture(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(下业丕七东丌丝下且 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(下业丕七东丌丝下且 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 下业丕七东丌丝下且;
        val_1[1] = 丙丆与丅丈丑一且丏;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  82, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丌上丗万丂丟上丆丑(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
    {
        this.isCapture = false;
        this.isBaza = false;
        this.丑丙丙与丈丂三万丆 = 0;
        this.timerToBaza = this.丏丂丝丟丞丌丆与丕;
        if(this.targetTrasform != 0)
        {
                SkinName val_3 = this.targetTrasform.parent.GetComponent<SkinName>();
            val_3.playerMoveC.上丙万丛万丑丘下丛 = false;
        }
        
        this.transform.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        this.targetTrasform = 0;
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.丄丈丑丐丆丞丘与丗 == 0)
        {
                UnityEngine.Debug.Log(message:  "FlagController.OnPhotonPlayerConnected():    photonView == null");
            return;
        }
        
        if(this.isCapture == false)
        {
            goto label_6;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = this.丑丙丙与丈丂三万丆;
        label_24:
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  63, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
        return;
        label_6:
        if(this.isBaza != false)
        {
                this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  27, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            return;
        }
        
        object[] val_4 = new object[2];
        UnityEngine.Vector3 val_6 = this.transform.position;
        val_4[0] = val_6;
        UnityEngine.Quaternion val_8 = this.transform.rotation;
        val_4[1] = val_8;
        if(this.丄丈丑丐丆丞丘与丗 != null)
        {
            goto label_24;
        }
        
        goto label_24;
    }
    public void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.isCapture == false)
        {
                return;
        }
        
        if(this.丑丙丙与丈丂三万丆 == 1)
        {
                return;
        }
        
        if(专丞上七七且丝七丗.业丐丐三丕一丗丛丁() != this.丑丙丙与丈丂三万丆)
        {
                return;
        }
        
        this.isCapture = false;
        this.isBaza = false;
        this.丑丙丙与丈丂三万丆 = 0;
        this.timerToBaza = this.丏丂丝丟丞丌丆与丕;
    }
    private void OnDestroy()
    {
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }

}
