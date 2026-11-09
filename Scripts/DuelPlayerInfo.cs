using UnityEngine;
public class DuelPlayerInfo : MonoBehaviour
{
    // Fields
    public TextMeshBounds level;
    public TextMeshBounds[] playerName;
    public TextMeshBounds[] trophies;
    private UnityEngine.Transform 业下丛丌业丏丈七丌;
    private UnityEngine.Transform 世丟丈丏丕万丝丆万;
    public UnityEngine.Rect touchZone;
    private UnityEngine.Quaternion 东业丗下万三丆丝上;
    private UnityEngine.Vector2 下丏业丏三一且万丝;
    private float 丞丌丈东下丛丕专丘;
    private int 丁不专丙丙丘七丕七;
    private static int 万丕丂丅丝七不丕丈;
    
    // Methods
    internal void 丁不丒东三专丒丝丗(NetworkStartTable 不且上一上丐三万丛)
    {
        TextMeshBounds[] val_9;
        var val_10;
        var val_11;
        InGameConnection val_12;
        this.level.Text = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0226"), arg1:  不且上一上丐三万丛.下东且丐丆丅丁世丟);
        val_9 = this.playerName;
        val_10 = 0;
        goto label_8;
        label_12:
        val_9[0].Text = 不且上一上丐三万丛.丂丈丐不丏万三七丐.Substring(startIndex:  0, length:  10)(不且上一上丐三万丛.丂丈丐不丏万三七丐.Substring(startIndex:  0, length:  10)) + "...";
        val_10 = 1;
        label_8:
        if(val_10 < this.playerName.Length)
        {
            goto label_12;
        }
        
        val_11 = null;
        val_11 = null;
        val_12 = GameController.丆丘丂丈世丏丟丑丏;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == false)
        {
                return;
        }
        
        val_9 = 0;
        goto label_17;
        label_24:
        TextMeshBounds val_10 = this.trophies[0];
        val_10.gameObject.SetActive(value:  true);
        val_12 = 不且上一上丐三万丛.丞丗丘丒一丘且万丛().ToString();
        val_10.Text = val_12;
        val_9 = 1;
        label_17:
        if(val_9 < this.trophies.Length)
        {
            goto label_24;
        }
    
    }
    public void SetPointInWorld(UnityEngine.Transform 丐丝世与且不与上丁, UnityEngine.Transform 世丟丈丏丕万丝丆万)
    {
        this.业下丛丌业丏丈七丌 = 丐丝世与且不与上丁;
        this.世丟丈丏丕万丝丆万 = 世丟丈丏丕万丝丆万;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        if((UnityEngine.Quaternion.op_Equality(lhs:  new UnityEngine.Quaternion() {x = this.东业丗下万三丆丝上, y = V10.16B, z = V9.16B, w = V8.16B}, rhs:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w})) == false)
        {
                return;
        }
        
        UnityEngine.Quaternion val_3 = 世丟丈丏丕万丝丆万.rotation;
        this.东业丗下万三丆丝上 = val_3;
        mem[1152921525938458052] = val_3.y;
        mem[1152921525938458056] = val_3.z;
        mem[1152921525938458060] = val_3.w;
    }
    private void Awake()
    {
        TextMeshBounds val_6;
        var val_7;
        var val_8;
        val_6 = this;
        float val_6 = (float)UnityEngine.Screen.width;
        float val_7 = (float)UnityEngine.Screen.height;
        val_6 = val_6 * (-0.2f);
        val_7 = val_7 * (-0.65f);
        float val_8 = (float)UnityEngine.Screen.width;
        float val_9 = (float)UnityEngine.Screen.height;
        val_8 = val_8 * 0.45f;
        val_9 = val_9 * 0.65f;
        this.touchZone = 0;
        mem[1152921525938668340] = 0;
        mem[1152921525938668348] = 0;
        this.level.oneLine = true;
        val_7 = 0;
        goto label_1;
        label_5:
        TextMeshBounds val_10 = this.playerName[0];
        val_7 = 1;
        this.playerName[0x0][0].oneLine = true;
        label_1:
        if(val_7 < this.playerName.Length)
        {
            goto label_5;
        }
        
        val_8 = 0;
        goto label_6;
        label_12:
        val_6 = this.trophies[0];
        val_6.gameObject.SetActive(value:  false);
        val_8 = 1;
        this.trophies[0x0][0].oneLine = true;
        label_6:
        if(val_8 < this.trophies.Length)
        {
            goto label_12;
        }
    
    }
    private void Update()
    {
        var val_11;
        bool val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        if(this.level != 0)
        {
                val_11 = null;
            val_11 = null;
            if(GameController.onlineMode.丗三不丞丈业丑丘万 != false)
        {
                val_12 = 0;
        }
        else
        {
                val_13 = null;
            val_13 = null;
            val_12 = BalanceController.丄专丕世与世丙丏丛;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.level.gameObject, 丏业丟一东丂东丘丛:  (val_12 == true) ? 1 : 0);
        }
        
        if(this.业下丛丌业丏丈七丌 == 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(CrateInfoButton.丙丒丘丐丙一丒东业 != false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        UnityEngine.Vector3 val_6 = this.业下丛丌业丏丈七丌.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_9 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        this.丐丄丁丛丏丘不世七(丛丆丄丁丅丗丑与丕:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
    }
    private void 丐丄丁丛丏丘不世七(UnityEngine.Vector2 丛丆丄丁丅丗丑与丕)
    {
        float val_37;
        UnityEngine.Transform val_38;
        float val_39;
        var val_40;
        float val_41;
        UnityEngine.Rect val_42;
        int val_43;
        float val_44;
        float val_45;
        float val_46;
        var val_47;
        float val_48;
        float val_49;
        var val_50;
        var val_51;
        UnityEngine.Vector2 val_52;
        float val_53;
        var val_54;
        var val_55;
        val_37 = 丛丆丄丁丅丗丑与丕.y;
        val_38 = this;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        val_39 = val_2.x;
        val_40 = val_2.y;
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
        val_41 = val_4.x;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_41, y:  val_5.y);
        val_42 = val_38;
        val_43 = this.丁不专丙丙丘七丕七;
        if(val_43 != 1)
        {
            goto label_4;
        }
        
        val_44 = val_6.x;
        val_41 = val_44;
        val_45 = 丛丆丄丁丅丗丑与丕.x;
        val_46 = val_37;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_41, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_45, y = val_46});
        if((this.touchZone & 1) != 0)
        {
            goto label_7;
        }
        
        val_43 = val_43;
        label_4:
        if(val_43 != 1)
        {
            goto label_44;
        }
        
        label_7:
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
            goto label_9;
        }
        
        this.丁不专丙丙丘七丕七 = 1;
        goto label_44;
        label_3:
        if(UnityEngine.Input.touchCount < 1)
        {
            goto label_44;
        }
        
        val_47 = 0;
        var val_37 = 0;
        val_42 = this.touchZone;
        label_26:
        UnityEngine.Touch val_10 = UnityEngine.Input.GetTouch(index:  0);
        if((this.丁不专丙丙丘七丕七 != 1) || ((Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = 丙东专丂世丈丏丁丂()})) == true))
        {
            goto label_15;
        }
        
        val_48 = val_2.x;
        val_41 = val_48;
        val_45 = 丛丆丄丁丅丗丑与丕.x;
        val_46 = val_37;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_41, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_45, y = val_46});
        if((val_42 & 1) != 0)
        {
            goto label_18;
        }
        
        label_15:
        if(丙东专丂世丈丏丁丂() != this.丁不专丙丙丘七丕七)
        {
            goto label_25;
        }
        
        label_18:
        if(专三三与三且一且一() == 0)
        {
            goto label_20;
        }
        
        if(专三三与三且一且一() != 3)
        {
            goto label_21;
        }
        
        this.丁不专丙丙丘七丕七 = 0;
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.zero;
        this.下丏业丏三一且万丝 = val_17;
        mem[1152921525939043972] = val_17.y;
        goto label_25;
        label_20:
        this.丁不专丙丙丘七丕七 = 丙东专丂世丈丏丁丂();
        goto label_25;
        label_21:
        val_39 = val_13.x;
        val_49 = val_13.y;
        val_47 = 1;
        label_25:
        val_37 = val_37 + 1;
        if(val_37 < UnityEngine.Input.touchCount)
        {
            goto label_26;
        }
        
        if((val_47 & 1) == 0)
        {
            goto label_44;
        }
        
        val_42 = this.丁不专丙丙丘七丕七;
        label_45:
        val_47 = 1152921505058283520;
        val_50 = null;
        val_50 = null;
        DuelPlayerInfo.万丕丂丅丝七不丕丈 = val_42;
        this.丞丌丈东下丛丕专丘 = UnityEngine.Time.time;
        UnityEngine.Vector2 val_21 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.下丏业丏三一且万丝, y = val_37}, rhs:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y})) == false)
        {
            goto label_32;
        }
        
        val_51 = val_49;
        val_52 = val_39;
        this.下丏业丏三一且万丝 = val_13;
        mem[1152921525939043972] = val_49;
        goto label_33;
        label_9:
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
            goto label_34;
        }
        
        this.丁不专丙丙丘七丕七 = 0;
        UnityEngine.Vector2 val_24 = UnityEngine.Vector2.zero;
        this.下丏业丏三一且万丝 = val_24;
        mem[1152921525939043972] = val_24.y;
        goto label_44;
        label_32:
        val_52 = this.下丏业丏三一且万丝;
        label_33:
        UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_39, y = val_49}, b:  new UnityEngine.Vector2() {x = val_52, y = val_37});
        this.下丏业丏三一且万丝 = val_13;
        mem[1152921525939043972] = val_49;
        val_38 = this.世丟丈丏丕万丝丆万;
        val_53 = val_25.x;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.up;
        val_37 = val_26.y;
        val_48 = UnityEngine.Time.deltaTime;
        val_38.Rotate(axis:  new UnityEngine.Vector3() {x = val_26.x, y = val_37, z = val_26.z}, angle:  (val_53 * val_48) * RilisoftRotator.丙丂专一丄丞丛业上());
        return;
        label_34:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_44;
        }
        
        goto label_45;
        label_44:
        val_54 = null;
        val_54 = null;
        DuelPlayerInfo.万丕丂丅丝七不丕丈 = 0;
        val_53 = UnityEngine.Time.time;
        val_55 = null;
        val_55 = null;
        if((val_53 - this.丞丌丈东下丛丕专丘) <= ShopNGUIController.上丈丂丁三丂业丛丝)
        {
                return;
        }
        
        UnityEngine.Quaternion val_34 = this.世丟丈丏丕万丝丆万.rotation;
        float val_38 = 300f;
        val_38 = UnityEngine.Time.deltaTime * val_38;
        UnityEngine.Quaternion val_36 = UnityEngine.Quaternion.RotateTowards(from:  new UnityEngine.Quaternion() {x = val_34.x, y = val_34.y, z = val_34.z, w = val_34.w}, to:  new UnityEngine.Quaternion() {x = this.东业丗下万三丆丝上, y = V12.16B, z = V13.16B, w = V14.16B}, maxDegreesDelta:  val_38);
        val_53 = val_36.x;
        val_37 = val_36.z;
        this.世丟丈丏丕万丝丆万.rotation = new UnityEngine.Quaternion() {x = val_53, y = val_36.y, z = val_37, w = val_36.w};
    }
    private void OnDisable()
    {
        var val_1;
        this.丁不专丙丙丘七丕七 = 0;
        val_1 = null;
        val_1 = null;
        DuelPlayerInfo.万丕丂丅丝七不丕丈 = 0;
    }
    public DuelPlayerInfo()
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        this.东业丗下万三丆丝上 = val_1;
        mem[1152921525939288484] = val_1.y;
        mem[1152921525939288488] = val_1.z;
        mem[1152921525939288492] = val_1.w;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.下丏业丏三一且万丝 = val_2;
        mem[1152921525939288500] = val_2.y;
        this.丁不专丙丙丘七丕七 = 0;
    }
    private static DuelPlayerInfo()
    {
        DuelPlayerInfo.万丕丂丅丝七不丕丈 = 0;
    }

}
