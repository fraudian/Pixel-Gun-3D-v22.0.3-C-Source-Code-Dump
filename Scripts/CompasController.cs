using UnityEngine;
public class CompasController : MonoBehaviour
{
    // Fields
    private UIPanel compasPanel;
    private UIScrollView scrollView;
    private UIWrapContent wrapContent;
    private float compasWidth;
    private float startCompasRotation;
    private UIWidget[] squadMembersIcons;
    private UIWidget[] squadMembersMarkersIcons;
    private CompasTransportIcon[] transportIcons;
    private float 丂丅丆世丏丕丂专丆;
    private Player_move_c[] 丏丗丈丙上丝丂与丕;
    private TransportControllerBase 丅丕不丌丟丒世且专;
    private int 业专东业丕丂业丐丅;
    
    // Methods
    private void Awake()
    {
        CompasController val_7;
        var val_8;
        val_7 = this;
        InGameGUI.丙丞专丌丁丞与不丐.丙丁不东不丅三丛世 = val_7;
        if(Initializer.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        if(this.squadMembersIcons == null)
        {
                return;
        }
        
        this.丏丗丈丙上丝丂与丕 = new Player_move_c[0];
        val_8 = null;
        val_8 = null;
        List.Enumerator<T> val_4 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_14:
        if(((-319879304) & 1) == 0)
        {
            goto label_11;
        }
        
        string val_5 = 0.丐丏七丌丕丗业且上();
        if(val_5.丟丌下三七丁与丟丑() == true)
        {
            goto label_14;
        }
        
        this.万丘三世丛丅与一丗(专丞上七七且丝七丗:  val_5);
        goto label_14;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 万丘三世丛丅与一丗(Player_move_c 专丞上七七且丝七丗)
    {
        PlayerSynchStream val_3 = 1152921504848912384;
        if(专丞上七七且丝七丗 == 0)
        {
                return;
        }
        
        val_3 = 专丞上七七且丝七丗.myPersonNetwork;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
        if(专丞上七七且丝七丗.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == false)
        {
                return;
        }
        
        val_3 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
        if((专丞上七七且丝七丗.丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世 & 2147483648) != 0)
        {
                return;
        }
        
        val_3 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世;
        if(val_3 >= this.丏丗丈丙上丝丂与丕.Length)
        {
                return;
        }
        
        val_3 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世;
        this.丏丗丈丙上丝丂与丕[val_3] = 专丞上七七且丝七丗;
    }
    internal static float 东东丂七专丁丆丛丁(UnityEngine.Vector3 一不丝丟世业丑丙一, UnityEngine.Vector3 丘丑丛丕下丈世下丂, UnityEngine.Vector3 丏丟万且丝丒丝丅东)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 一不丝丟世业丑丙一.x, y = 一不丝丟世业丑丙一.y, z = 一不丝丟世业丑丙一.z}, rhs:  new UnityEngine.Vector3() {x = 丘丑丛丕下丈世下丂.x, y = 丘丑丛丕下丈世下丂.y, z = 丘丑丛丕下丈世下丂.z});
        float val_4 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 一不丝丟世业丑丙一.x, y = 一不丝丟世业丑丙一.y, z = 一不丝丟世业丑丙一.z}, rhs:  new UnityEngine.Vector3() {x = 丘丑丛丕下丈世下丂.x, y = 丘丑丛丕下丈世下丂.y, z = 丘丑丛丕下丈世下丂.z});
        float val_5 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丏丟万且丝丒丝丅东.x, y = val_1, z = 丏丟万且丝丒丝丅东.y}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_5 = val_5 * 57.29578f;
        return (float)val_5;
    }
    private void 丝丂丛丐丏丞专丟丗(UnityEngine.Vector3 专丏业与万丄丐丑且, UnityEngine.Vector3 丑丏与上不丐丘丕丐, UIWidget 丐丁专丌丂专丏与丘, UnityEngine.Vector3 丑与丛丙世一丞丄丝)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丑与丛丙世一丞丄丝.x, y = val_1, z = 丑与丛丙世一丞丄丝.y}, b:  new UnityEngine.Vector3() {x = 丑丏与上不丐丘丕丐.x, y = 丑丏与上不丐丘丕丐.y, z = 丑丏与上不丐丘丕丐.z});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        float val_18 = (float)丐丁专丌丂专丏与丘.width;
        float val_19 = (float)丐丁专丌丂专丏与丘.width;
        val_18 = val_18 * 0.5f;
        val_19 = val_19 * 0.5f;
        float val_12 = this.compasWidth / 360f;
        val_18 = val_18 - (this.compasPanel.width * 0.5f);
        val_12 = (CompasController.东东丂七专丁丆丛丁(一不丝丟世业丑丙一:  new UnityEngine.Vector3() {x = 专丏业与万丄丐丑且.x, y = 专丏业与万丄丐丑且.y, z = 专丏业与万丄丐丑且.z}, 丘丑丛丕下丈世下丂:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丏丟万且丝丒丝丅东:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z})) * val_12;
        val_19 = (this.compasPanel.width * 0.5f) - val_19;
        float val_13 = UnityEngine.Mathf.Clamp(value:  val_12, min:  val_18, max:  val_19);
        UnityEngine.Vector3 val_15 = 丐丁专丌丂专丏与丘.transform.localPosition;
        UnityEngine.Vector3 val_17 = 丐丁专丌丂专丏与丘.transform.localPosition;
        丐丁专丌丂专丏与丘.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Update()
    {
        UnityEngine.Transform val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        UnityEngine.Object val_34;
        float val_35;
        float val_36;
        UIWidget[] val_37;
        var val_38;
        Player_move_c val_39;
        var val_40;
        var val_41;
        UnityEngine.Transform val_42;
        var val_44;
        UnityEngine.Transform val_45;
        val_29 = 1152921505286238208;
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_18;
        }
        
        val_31 = null;
        val_31 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_18;
        }
        
        val_32 = null;
        val_32 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_628 == 0)
        {
            goto label_18;
        }
        
        val_33 = null;
        val_33 = null;
        val_34 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_34 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        goto label_24;
        label_18:
        val_34 = 0;
        label_24:
        if(val_34 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_5 = 1685382481.一丗与上丅东丏丙丑();
        UnityEngine.Quaternion val_6 = val_5.rotation;
        val_35 = val_6.y + this.startCompasRotation;
        if(val_35 <= 180f)
        {
            goto label_31;
        }
        
        val_36 = -360f;
        goto label_32;
        label_31:
        if(val_35 >= 0)
        {
            goto label_33;
        }
        
        val_36 = 360f;
        label_32:
        val_35 = val_35 + val_36;
        label_33:
        float val_31 = this.compasWidth;
        float val_29 = -360f;
        float val_30 = this.丂丅丆世丏丕丂专丆;
        val_29 = val_31 / val_29;
        val_35 = val_35 * val_29;
        val_35 = val_35 - val_30;
        val_29 = val_30 + val_35;
        val_30 = val_29 - val_31;
        val_29 = (val_29 > val_31) ? (val_30) : (val_29);
        val_31 = val_29 + val_31;
        this.丂丅丆世丏丕丂专丆 = (val_29 < 0) ? (val_31) : (val_29);
        val_37 = this.squadMembersIcons;
        if(val_37 == null)
        {
            goto label_35;
        }
        
        val_38 = 0;
        goto label_78;
        label_86:
        UIWidget val_32 = this.squadMembersIcons[0];
        val_39 = this.丏丗丈丙上丝丂与丕[0];
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                if((val_39 != 0) && (val_38 != this.丏丗丈丙上丝丂与丕[0x0][0].丟三丏丅世一丟丟上.丙丕丗丁丌丗不丗世))
        {
                val_39 = 0;
            this.丏丗丈丙上丝丂与丕[0] = 0;
        }
        
        }
        
        if(((val_39 != 0) && (0 != 0)) && ((mem[1460288881096] + 266) != 0))
        {
                val_40 = UnityEngine.Object.op_Equality(x:  8, y:  mem[1460288881096] + 224);
        }
        else
        {
                val_40 = 0;
        }
        
        if((val_39 == 0) || (0 != 0))
        {
            goto label_72;
        }
        
        UnityEngine.Vector3 val_14 = val_39.transform.position;
        if(val_14.y <= (-5000f))
        {
            goto label_72;
        }
        
        val_41 = null;
        if(val_40 == 0)
        {
            goto label_73;
        }
        
        goto label_77;
        label_72:
        val_41 = null;
        label_77:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_32, 丏业丟一东丂东丘丛:  false);
        label_84:
        val_37 = this.squadMembersIcons;
        val_38 = 1;
        goto label_78;
        label_73:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_32, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector3 val_15 = val_5.forward;
        val_42 = val_5;
        if(val_42 == 0)
        {
                val_42 = val_5;
        }
        
        UnityEngine.Vector3 val_16 = val_42.position;
        UnityEngine.Vector3 val_18 = val_39.transform.position;
        this.丝丂丛丐丏丞专丟丗(专丏业与万丄丐丑且:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, 丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, 丐丁专丌丂专丏与丘:  val_32, 丑与丛丙世一丞丄丝:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.z, z = 0f});
        goto label_84;
        label_78:
        if(val_38 < this.squadMembersIcons.Length)
        {
            goto label_86;
        }
        
        label_35:
        if((this.squadMembersMarkersIcons == null) || (GameConnect.丝丆世丕丂丄万东且() == true))
        {
            goto label_90;
        }
        
        val_40 = 0;
        goto label_91;
        label_125:
        UIWidget val_33 = this.squadMembersMarkersIcons[0];
        val_39 = val_33.gameObject;
        if(val_39.activeSelf == false)
        {
            goto label_121;
        }
        
        if(val_40 != 0)
        {
            
        }
        else
        {
                val_44 = null;
            val_44 = null;
            WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC
        }
        
        val_39 = mem[WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC];
        if(val_39 == 0)
        {
            goto label_116;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_109;
        }
        
        if((mem[WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC] + 1391) != 0)
        {
            goto label_116;
        }
        
        goto label_113;
        label_109:
        label_113:
        if((mem[WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC] + 96) == 0)
        {
            goto label_116;
        }
        
        UnityEngine.Vector3 val_25 = val_5.forward;
        val_45 = val_5;
        if(val_45 == 0)
        {
                val_45 = val_5;
        }
        
        UnityEngine.Vector3 val_26 = val_45.position;
        val_39 = mem[WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC] + 96.transform;
        UnityEngine.Vector3 val_28 = val_39.position;
        this.丝丂丛丐丏丞专丟丗(专丏业与万丄丐丑且:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, 丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, 丐丁专丌丂专丏与丘:  val_33, 丑与丛丙世一丞丄丝:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.z, z = 0f});
        goto label_121;
        label_116:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_33, 丏业丟一东丂东丘丛:  false);
        label_121:
        val_40 = 1;
        label_91:
        if(val_40 < this.squadMembersMarkersIcons.Length)
        {
            goto label_125;
        }
        
        label_90:
        val_29 = val_5;
        this.专世上业上丙丁丝丑(东不上丝丅业丟丑不:  val_29);
        this.不丘丌万丈专专且丁(丞丄与业丙丄丏七丘:  val_34, 东不上丝丅业丟丑不:  val_29);
    }
    private void 不丘丌万丈专专且丁(FirstPersonControlSharp 丞丄与业丙丄丏七丘, UnityEngine.Transform 东不上丝丅业丟丑不)
    {
        UnityEngine.Object val_12;
        UIWidget val_6 = 0;
        if((this.丅丕不丌丟丒世且专 != 0) && ((this.丅丕不丌丟丒世且专 & 1) != 0))
        {
                this.丅丕不丌丟丒世且专 = 0;
        }
        
        if((this.丅丕不丌丟丒世且专 != 0) && (丞丄与业丙丄丏七丘.下丅丂丘丏丟世且丐 != false))
        {
                val_12 = (~(UnityEngine.Object.op_Equality(x:  丞丄与业丙丄丏七丘.丌专丒丒丛丐丘上丄, y:  this.丅丕不丌丟丒世且专))) & 1;
        }
        else
        {
                val_12 = 1;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                if(this.丅丕不丌丟丒世且专 != 0)
        {
                this.丝丂三七丏上上丙丕(东丅丞丁丗万且丁丗:  true, 丐丁专丌丂专丏与丘: out  val_6);
            if(val_12 == 0)
        {
                return;
        }
        
            val_12 = val_6;
            if((UnityEngine.Object.op_Implicit(exists:  val_12)) == false)
        {
                return;
        }
        
            UnityEngine.Vector3 val_8 = 东不上丝丅业丟丑不.forward;
            UnityEngine.Vector3 val_9 = 东不上丝丅业丟丑不.position;
            UnityEngine.Vector3 val_11 = this.丅丕不丌丟丒世且专.transform.position;
            this.丝丂丛丐丏丞专丟丗(专丏业与万丄丐丑且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丐丁专丌丂专丏与丘:  val_12, 丑与丛丙世一丞丄丝:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z, z = ???});
            return;
        }
        
        }
        
        this.丝丂三七丏上上丙丕(东丅丞丁丗万且丁丗:  false, 丐丁专丌丂专丏与丘: out  val_6);
    }
    private void 丝丂三七丏上上丙丕(bool 东丅丞丁丗万且丁丗, out UIWidget 丐丁专丌丂专丏与丘)
    {
        var val_2;
        var val_3;
        丐丁专丌丂专丏与丘 = 0;
        val_2 = 0;
        goto label_1;
        label_13:
        if(东丅丞丁丗万且丁丗 != false)
        {
                var val_1 = (this.丅丕不丌丟丒世且专 == this.transportIcons[0x0][0].transportType) ? 1 : 0;
        }
        else
        {
                val_3 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.transportIcons[0], 丏业丟一东丂东丘丛:  false);
        if(val_3 != 0)
        {
                丐丁专丌丂专丏与丘 = this.transportIcons[0x0][0].widget;
        }
        
        val_2 = 1;
        label_1:
        if(val_2 < this.transportIcons.Length)
        {
            goto label_13;
        }
    
    }
    internal void 丘三丘丁专丆业丄业(TransportControllerBase 丝丘下丄丈丗丈丄丘)
    {
        this.丅丕不丌丟丒世且专 = 丝丘下丄丈丗丈丄丘;
    }
    private void 专世上业上丙丁丝丑(UnityEngine.Transform 东不上丝丅业丟丑不)
    {
        Player_move_c val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(this.squadMembersMarkersIcons == null)
        {
                return;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_11 == 0)
        {
                return;
        }
        
        val_13 = 0;
        goto label_24;
        label_41:
        UIWidget val_11 = this.squadMembersMarkersIcons[0];
        if(val_13 != this.业专东业丕丂业丐丅)
        {
            goto label_14;
        }
        
        val_14 = null;
        val_14 = null;
        if(Player_move_c.__il2cppRuntimeField_generic_class != 0)
        {
            goto label_21;
        }
        
        label_14:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_11, 丏业丟一东丂东丘丛:  false);
        label_39:
        val_13 = 1;
        goto label_24;
        label_21:
        if(val_11.gameObject.activeSelf == false)
        {
            goto label_39;
        }
        
        val_15 = null;
        val_15 = null;
        if(Player_move_c.__il2cppRuntimeField_generic_class == 0)
        {
            goto label_39;
        }
        
        UnityEngine.Vector3 val_7 = 东不上丝丅业丟丑不.forward;
        UnityEngine.Vector3 val_8 = 东不上丝丅业丟丑不.position;
        UnityEngine.Vector3 val_10 = Player_move_c.__il2cppRuntimeField_generic_class.transform.position;
        this.丝丂丛丐丏丞专丟丗(专丏业与万丄丐丑且:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 丐丁专丌丂专丏与丘:  val_11, 丑与丛丙世一丞丄丝:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.z, z = ???});
        goto label_39;
        label_24:
        val_11 = this.squadMembersMarkersIcons;
        if(val_13 < this.squadMembersMarkersIcons.Length)
        {
            goto label_41;
        }
    
    }
    public void ShowSquadMemberMapMarker(int 丐丙丞万丞丌丟丄与, bool 丛下且丛万丈丝万丂)
    {
        UIWidget[] val_7;
        int val_8 = 丐丙丞万丞丌丟丄与;
        if((val_8 & 2147483648) != 0)
        {
                return;
        }
        
        val_7 = this.squadMembersMarkersIcons;
        int val_7 = this.squadMembersMarkersIcons.Length;
        val_7 = val_7 - 1;
        if(val_7 < val_8)
        {
                return;
        }
        
        val_7 = this.squadMembersMarkersIcons[(long)val_8];
        if(val_7 == 0)
        {
                return;
        }
        
        this.业专东业丕丂业丐丅 = val_8;
        val_8 = val_7.gameObject;
        val_8.SetActive(value:  true);
        if(丛下且丛万丈丝万丂 == false)
        {
                return;
        }
        
        TweenScale val_3 = val_7.GetComponent<TweenScale>();
        if(val_3 != 0)
        {
                val_3.PlayForward();
        }
        
        val_7 = val_7.GetComponent<TweenColor>();
        if(val_7 == 0)
        {
                return;
        }
        
        val_7.PlayForward();
    }
    public CompasController()
    {
        this.compasWidth = 720f;
        this.业专东业丕丂业丐丅 = 0;
    }

}
