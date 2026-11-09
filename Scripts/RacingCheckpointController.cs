using UnityEngine;
public class RacingCheckpointController : MonoBehaviour
{
    // Fields
    public static int lapCountForWin;
    internal static RacingCheckpointController 丄丘七三上丕世丞业;
    public PlayerCheckpoint startCheckpoint;
    internal PlayerCheckpoint 丆且且世丛丗三丁丌;
    internal int 专上丒丏业七丂丆东;
    private int 丄丏丝丅上丘万丟丟;
    private bool 一丂丗一与丕丈东万;
    private float 丈丝上上丟东丝丝丗;
    private Rilisoft.丒且丐三丁丅丕一业 下丝丏三三丛丛丑业;
    private float 七丌丟上丆丆丄丌丐;
    internal float 七丟丏丟世丅丒丐业;
    internal float 丗丟丏世丆丈丘丙丒;
    private readonly int 丘丈丁丗丂丘丗业丏;
    private int 丝三丟丈丙丗丞东丙;
    private float 丐丙丞丞丐丝丝丗一;
    internal System.Collections.Generic.List<MinigameScoreTableItem.丟七三丒丝与且丙世> 丘丕丑丞丛丐丗丗丞;
    public UnityEngine.GameObject planeTest;
    public UnityEngine.GameObject planeTestBack;
    private float 与下丘丆下丝下丞专;
    private float 丝丌丕万丒不丄丛丟;
    
    // Properties
    private float 丝上七万上丄专丟丘 { get; set; }
    private bool 丗与世下丒世丘丅上 { get; }
    
    // Methods
    private float 业且丝丌丄丏丅丑丛()
    {
        if(this.下丝丏三三丛丛丑业 != null)
        {
                return this.下丝丏三三丛丛丑业.丝丙丐且丟丅三丛七();
        }
        
        return this.下丝丏三三丛丛丑业.丝丙丐且丟丅三丛七();
    }
    private void 丗丕与丁丟丟丗丏且(float 丙业与丙丗丝不丈东)
    {
        this.下丝丏三三丛丛丑业.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private bool 丑丒东上丕丛专七丛()
    {
        return (bool)(this.丝三丟丈丙丗丞东丙 > 1) ? 1 : 0;
    }
    private void Awake()
    {
        null = null;
        float val_8 = 0f;
        RacingCheckpointController.丄丘七三上丕世丞业 = this;
        label_19:
        label_10:
        if(this.startCheckpoint == 0)
        {
            goto label_5;
        }
        
        if(this.startCheckpoint != null)
        {
                this.startCheckpoint.丌七丒世丄上丞丞丁 = val_8;
        }
        else
        {
                this.startCheckpoint.丌七丒世丄上丞丞丁 = val_8;
        }
        
        if(this.startCheckpoint.next == 0)
        {
            goto label_10;
        }
        
        UnityEngine.Vector3 val_4 = this.startCheckpoint.next.transform.position;
        UnityEngine.Vector3 val_6 = this.startCheckpoint.transform.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_8 = val_8 + val_7.x;
        if(this.startCheckpoint.next.startPoint == false)
        {
            goto label_19;
        }
        
        this.丈丝上上丟东丝丝丗 = val_8;
        goto label_19;
        label_5:
        this.丆且且世丛丗三丁丌 = this.startCheckpoint.back;
        this.planeTest.SetActive(value:  false);
        this.planeTestBack.SetActive(value:  false);
    }
    internal void 不丏世世上下丒丁丒(PlayerCheckpoint 丆丄丘七东世丒丐七)
    {
        this.丆且且世丛丗三丁丌 = 丆丄丘七东世丒丐七;
    }
    private void Update()
    {
        var val_48;
        float val_49;
        float val_50;
        int val_51;
        PlayerCheckpoint val_52;
        float val_54;
        PlayerCheckpoint val_55;
        var val_56;
        PlayerCheckpoint val_57;
        float val_58;
        float val_59;
        val_48 = null;
        val_48 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        val_49 = this.与下丘丆下丝下丞专;
        if(val_49 > 0f)
        {
                val_50 = val_49 - UnityEngine.Time.deltaTime;
            this.与下丘丆下丝下丞专 = val_50;
            if(val_50 <= 0f)
        {
                this.与下丘丆下丝下丞专 = 0f;
            val_49 = this.丝丌丕万丒不丄丛丟;
            float val_48 = 100f;
            val_48 = val_49 * val_48;
            val_51 = UnityEngine.Mathf.RoundToInt(f:  val_48);
            val_50 = 2f;
            Show(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7070"), arg0:  DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  val_51)), 丂三丟丂丈丐丆丗丟:  val_50, 丂丝且专丒三世丞丐:  true);
        }
        
        }
        
        val_52 = this.丆且且世丛丗三丁丌.next;
        if(val_52 == 0)
        {
            goto label_92;
        }
        
        val_54 = this.七丌丟上丆丆丄丌丐 + UnityEngine.Time.deltaTime;
        this.七丌丟上丆丆丄丌丐 = val_54;
        if(this.专上丒丏业七丂丆东 >= 1)
        {
                val_54 = this.丗丟丏世丆丈丘丙丒 + UnityEngine.Time.deltaTime;
            this.丗丟丏世丆丈丘丙丒 = val_54;
        }
        
        val_55 = this.丆且且世丛丗三丁丌;
        if((this.丘丕专丏丒且上三不(丆丄丘七东世丒丐七:  this.丆且且世丛丗三丁丌, 丌丒丌丁丛丕专丗丝:  false)) != false)
        {
                if(this.丆且且世丛丗三丁丌.next.startPoint != false)
        {
                int val_11 = this.专上丒丏业七丂丆东 + 1;
            this.专上丒丏业七丂丆东 = val_11;
            val_51 = 1152921504838422528;
            int val_12 = UnityEngine.Mathf.Max(a:  this.丄丏丝丅上丘万丟丟, b:  val_11);
            this.丄丏丝丅上丘万丟丟 = val_12;
            if(val_12 == this.专上丒丏业七丂丆东)
        {
                val_54 = 2f;
            Show(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7069"), arg0:  this.专上丒丏业七丂丆东), 丂三丟丂丈丐丆丗丟:  val_54, 丂丝且专丒三世丞丐:  true);
            if(this.专上丒丏业七丂丆东 == 1)
        {
                this.七丌丟上丆丆丄丌丐 = 0f;
        }
        else
        {
                this.与下丘丆下丝下丞专 = 3f;
            this.丝丌丕万丒不丄丛丟 = this.七丌丟上丆丆丄丌丐;
            val_54 = this.七丌丟上丆丆丄丌丐;
            this.七丟丏丟世丅丒丐业 = UnityEngine.Mathf.Min(a:  val_54, b:  this.七丟丏丟世丅丒丐业);
            this.七丌丟上丆丆丄丌丐 = 0f;
            this.CheckWin();
        }
        
        }
        
        }
        
            val_55 = this.丆且且世丛丗三丁丌.next;
            this.丆且且世丛丗三丁丌 = val_55;
            if(this.丝三丟丈丙丗丞东丙 >= 1)
        {
                this.丝三丟丈丙丗丞东丙 = 0;
        }
        
        }
        
        if((this.丘丕专丏丒且上三不(丆丄丘七东世丒丐七:  this.丆且且世丛丗三丁丌.next.back, 丌丒丌丁丛丕专丗丝:  true)) != false)
        {
                if(this.丆且且世丛丗三丁丌.startPoint != false)
        {
                int val_49 = this.专上丒丏业七丂丆东;
            val_49 = val_49 - 1;
            this.专上丒丏业七丂丆东 = val_49;
        }
        
            this.丆且且世丛丗三丁丌 = this.丆且且世丛丗三丁丌.back;
            this.丝三丟丈丙丗丞东丙 = this.丝三丟丈丙丗丞东丙 + 1;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
            goto label_53;
        }
        
        val_51 = this.丝三丟丈丙丗丞东丙;
        if(val_51 < 2)
        {
            goto label_51;
        }
        
        val_56 = 1;
        goto label_52;
        label_51:
        if(InGameGUIPart_Racing.__il2cppRuntimeField_byval_arg.gameObject.activeSelf == false)
        {
            goto label_53;
        }
        
        val_56 = 0;
        label_52:
        InGameGUIPart_Racing.__il2cppRuntimeField_byval_arg.gameObject.SetActive(value:  false);
        label_53:
        UnityEngine.Vector3 val_23 = this.丆且且世丛丗三丁丌.next.transform.position;
        UnityEngine.Vector3 val_25 = this.丆且且世丛丗三丁丌.transform.position;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Quaternion val_28 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w});
        UnityEngine.Vector3 val_30 = transform.position;
        UnityEngine.Vector3 val_32 = this.丆且且世丛丗三丁丌.transform.position;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        UnityEngine.Vector3 val_34 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_28.x, y = val_28.y, z = val_28.z, w = val_28.w}, point:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        val_49 = val_34.z;
        UnityEngine.Quaternion val_35 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w});
        UnityEngine.Vector3 val_37 = this.丆且且世丛丗三丁丌.next.transform.position;
        UnityEngine.Vector3 val_39 = this.丆且且世丛丗三丁丌.transform.position;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
        UnityEngine.Vector3 val_41 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_35.x, y = val_35.y, z = val_35.z, w = val_35.w}, point:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
        float val_50 = val_41.z;
        val_57 = this.丆且且世丛丗三丁丌;
        if(this.丆且且世丛丗三丁丌 != null)
        {
            goto label_76;
        }
        
        val_57 = this.丆且且世丛丗三丁丌;
        if(val_57 == null)
        {
            goto label_77;
        }
        
        label_76:
        if(this.丆且且世丛丗三丁丌.next.startPoint != false)
        {
                val_58 = this.丈丝上上丟东丝丝丗;
        }
        else
        {
                val_58 = this.丆且且世丛丗三丁丌.next.丌七丒世丄上丞丞丁;
        }
        
        float val_43 = UnityEngine.Mathf.Clamp01(value:  val_49 / val_50);
        val_52 = this.专上丒丏业七丂丆东;
        if(val_52 != 0)
        {
                val_49 = this.丈丝上上丟东丝丝丗;
            val_43 = (val_58 - this.丆且且世丛丗三丁丌.丌七丒世丄上丞丞丁) * val_43;
            val_50 = this.丆且且世丛丗三丁丌.丌七丒世丄上丞丞丁 + val_43;
            float val_51 = (float)UnityEngine.Mathf.Max(a:  0, b:  val_52 - 1);
            val_51 = val_49 * val_51;
            val_59 = val_50 + val_51;
        }
        else
        {
                val_59 = 0f;
        }
        
        this.丗丕与丁丟丟丗丏且(丙业与丙丗丝不丈东:  val_59);
        float val_47 = this.业且丝丌丄丏丅丑丛();
        if(this.丝三丟丈丙丗丞东丙 <= 1)
        {
            goto label_90;
        }
        
        val_47 = val_47 - this.丐丙丞丞丐丝丝丗一;
        if(val_47 <= (float)this.丘丈丁丗丂丘丗业丏)
        {
            goto label_92;
        }
        
        this.丝三丟丈丙丗丞东丙 = 0;
        goto label_92;
        label_90:
        this.丐丙丞丞丐丝丝丗一 = val_47;
        label_92:
        this.丂丆丄丛丂三丘业一();
        return;
        label_77:
    }
    private void 丂丆丄丛丂三丘业一()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        int val_4 = UnityEngine.Mathf.RoundToInt(f:  this.业且丝丌丄丏丅丑丛());
        val_7 = null;
        val_7 = null;
        东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  val_4);
        val_8 = null;
        val_8 = null;
        GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  val_4);
    }
    internal UnityEngine.Quaternion 上与上丂上七丞下丆()
    {
        UnityEngine.Vector3 val_2 = this.丆且且世丛丗三丁丌.next.transform.position;
        UnityEngine.Vector3 val_4 = this.丆且且世丛丗三丁丌.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        return new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
    }
    public void CheckWin()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = this;
        if(this.一丂丗一与丕丈东万 == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(RacingCheckpointController.lapCountForWin >= this.专上丒丏业七丂丆东)
        {
                return;
        }
        
        this.一丂丗一与丕丈东万 = true;
        val_5 = null;
        val_5 = null;
        float val_3 = 100f;
        val_3 = this.丗丟丏世丆丈丘丙丒 * val_3;
        丆专世丒七丒东丕世(丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  val_3));
        专丅世与下丕且且丕(专丞上七七且丝七丗:  0);
        丐丗丅丈丒丈丂七丒();
        val_3 = 1152921505189646336;
        val_6 = null;
        val_6 = null;
        if(GameController.mode == null)
        {
                return;
        }
        
        var val_2 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + (LegacyModeController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? GameController.mode : 0;
    }
    private bool 丘丕专丏丒且上三不(PlayerCheckpoint 丆丄丘七东世丒丐七, bool 丌丒丌丁丛丕专丗丝)
    {
        var val_40;
        var val_41;
        PlayerCheckpoint val_42;
        UnityEngine.GameObject val_43;
        var val_44;
        float val_45;
        float val_46;
        float val_47;
        float val_48;
        float val_49;
        float val_50;
        float val_51;
        float val_52;
        float val_53;
        float val_54;
        float val_55;
        float val_56;
        float val_57;
        float val_61;
        float val_62;
        float val_63;
        PlayerCheckpoint val_64;
        var val_65;
        val_40 = 丆丄丘七东世丒丐七;
        val_41 = null;
        val_41 = null;
        val_42 = 1152921504848912384;
        val_43 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_43 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if(val_43 == 0)
        {
                val_44 = 0;
            return (bool)(val_38.z > 1f) ? 1 : 0;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if(丌丒丌丁丛丕专丗丝 == false)
        {
            goto label_10;
        }
        
        if(丆丄丘七东世丒丐七.back == 0)
        {
            goto label_14;
        }
        
        UnityEngine.Vector3 val_5 = 丆丄丘七东世丒丐七.back.transform.position;
        UnityEngine.Vector3 val_7 = val_40.transform.position;
        val_45 = val_5.x;
        val_46 = val_5.y;
        val_47 = val_5.z;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = val_47}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_48 = val_8.x;
        val_49 = val_8.y;
        val_50 = val_8.z;
        UnityEngine.Vector3 val_10 = val_40.transform.position;
        val_51 = val_10.x;
        val_52 = val_10.y;
        val_53 = val_10.z;
        if(丆丄丘七东世丒丐七.next != null)
        {
            goto label_22;
        }
        
        goto label_22;
        label_10:
        bool val_11 = UnityEngine.Object.op_Inequality(x:  this.丆且且世丛丗三丁丌.next.next, y:  0);
        val_42 = 丆丄丘七东世丒丐七.next;
        if(val_42 == null)
        {
            goto label_28;
        }
        
        if(val_11 == false)
        {
            goto label_29;
        }
        
        label_43:
        UnityEngine.Vector3 val_13 = 丆丄丘七东世丒丐七.next.next.transform.position;
        UnityEngine.Vector3 val_15 = 丆丄丘七东世丒丐七.next.transform.position;
        val_45 = val_13.x;
        val_46 = val_13.y;
        val_47 = val_13.z;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_45, y = val_46, z = val_47}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        val_48 = val_16.x;
        val_49 = val_16.y;
        val_50 = val_16.z;
        UnityEngine.Vector3 val_18 = 丆丄丘七东世丒丐七.next.transform.position;
        val_51 = val_18.x;
        val_52 = val_18.y;
        val_53 = val_18.z;
        label_22:
        UnityEngine.Vector3 val_20 = val_40.transform.position;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_51, y = val_52, z = val_53}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        val_54 = val_21.x;
        val_55 = val_48;
        val_56 = val_49;
        val_57 = val_50;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_55, y = val_56, z = val_57}, b:  new UnityEngine.Vector3() {x = val_54, y = val_21.y, z = val_21.z});
        goto label_39;
        label_14:
        UnityEngine.Vector3 val_24 = val_40.transform.position;
        val_61 = val_24.x;
        val_62 = val_24.y;
        val_63 = val_24.z;
        if(丆丄丘七东世丒丐七.next != null)
        {
            goto label_42;
        }
        
        goto label_42;
        label_28:
        if(val_11 == true)
        {
            goto label_43;
        }
        
        label_29:
        UnityEngine.Vector3 val_26 = val_42.transform.position;
        val_61 = val_26.x;
        val_62 = val_26.y;
        val_63 = val_26.z;
        label_42:
        UnityEngine.Vector3 val_28 = val_40.transform.position;
        val_55 = val_61;
        val_56 = val_62;
        val_57 = val_63;
        val_54 = val_28.x;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_55, y = val_56, z = val_57}, b:  new UnityEngine.Vector3() {x = val_54, y = val_28.y, z = val_28.z});
        label_39:
        UnityEngine.Quaternion val_30 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.zero;
        val_43 = transform;
        UnityEngine.Vector3 val_33 = val_43.position;
        if(丌丒丌丁丛丕专丗丝 != true)
        {
                val_64 = 丆丄丘七东世丒丐七.next;
        }
        
        val_65 = val_64.transform;
        UnityEngine.Vector3 val_35 = val_65.position;
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
        UnityEngine.Quaternion val_37 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_30.x, y = val_30.y, z = val_30.z, w = val_30.w});
        UnityEngine.Vector3 val_38 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_37.x, y = val_37.y, z = val_37.z, w = val_37.w}, point:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
        return (bool)(val_38.z > 1f) ? 1 : 0;
    }
    public RacingCheckpointController()
    {
        this.下丝丏三三丛丛丑业 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.七丟丏丟世丅丒丐业 = -1.175494E-38f;
        this.丘丈丁丗丂丘丗业丏 = 20;
        this.丘丕丑丞丛丐丗丗丞 = new System.Collections.Generic.List<丟七三丒丝与且丙世>();
    }
    private static RacingCheckpointController()
    {
        RacingCheckpointController.lapCountForWin = 3;
    }

}
