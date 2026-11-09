using UnityEngine;
public class WeaponBonusItem : MonoBehaviour, 世丂丈世且万世丞上
{
    // Fields
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    public string weaponPrefabName;
    public bool isUsedBonus;
    private float 三丑与上不东丗丁丄;
    public int previewIndex;
    public int ownerId;
    private float 丛丞丆且丕丑丄丗上;
    private float 丟万三下专与与丄丘;
    public int ammoInClip;
    public int initialAmmoInBackUp;
    public bool isMineBonus;
    private bool 业丗三丌世上丘专丄;
    private WeaponSounds 丆业七丌丁丕一丐七;
    private bool 万丙丛丐且丑丗丏业;
    private float 与丘上丑不丐上丙丐;
    private float 丙七丝东世丒丝与一;
    private float 丘丁丘世丄丒且一丘;
    internal static float 丞丄丗丅丙七业东丈;
    public float progressLockMineBonus;
    private UnityEngine.GameObject 丅丅丌丕世丙不丑丄;
    
    // Methods
    private void Awake()
    {
        this.万一丂丐丄丁上与丟 = this.transform;
    }
    public void InitBonus(int 丗万丛丙上丟上万三, int 东七丛丝丑专世丏三, string 丆与丕丕丂下丟一丈)
    {
        this.previewIndex = 东七丛丝丑专世丏三;
        this.ownerId = 丗万丛丙上丟上万三;
        this.weaponPrefabName = 丆与丕丕丂下丟一丈;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丂丒丆丏丁业丁丁丂(丗万丛丙上丟上万三:  丗万丛丙上丟上万三, 东七丛丝丑专世丏三:  东七丛丝丑专世丏三));
        this.业丗三丌世上丘专丄 = false;
    }
    private void Update()
    {
        this.丟一且上丘专丗丅丛();
    }
    private void 七丐丂万丁一与丕不()
    {
        var val_46;
        var val_47;
        float val_48;
        float val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_65;
        var val_66;
        var val_67;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        float val_2 = this.三丑与上不东丗丁丄 * UnityEngine.Time.deltaTime;
        this.万一丂丐丄丁上与丟.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_46 = null;
        val_46 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_4 = this.万一丂丐丄丁上与丟.position;
        val_47 = null;
        val_48 = val_4.z;
        val_47 = null;
        UnityEngine.Vector3 val_5 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_49 = val_5.y;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_48}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_49, z = val_5.z});
        this.丟万三下专与与丄丘 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        if(this.isUsedBonus != true)
        {
                val_50 = null;
            val_50 = null;
            val_51 = null;
            val_51 = null;
            val_52 = null;
            val_52 = null;
            val_53 = null;
            val_53 = null;
            if((InGameGUI.丙丞专丌丁丞与不丐.isTurretInterfaceActive != true) && (this.丟万三下专与与丄丘 < 0))
        {
                val_54 = null;
            val_54 = null;
        }
        
        }
        
        val_55 = this;
        this.丘丁丘世丄丒且一丘 = 0f;
        mem[1152921540692024748] = 0;
        val_56 = null;
        val_56 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_528.Contains(item:  this)) == false)
        {
            goto label_170;
        }
        
        val_57 = null;
        val_57 = null;
        bool val_9 = typeof(Player_move_c).__il2cppRuntimeField_528.Remove(item:  this);
        goto label_170;
        label_7:
        val_58 = null;
        val_58 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_59 = null;
            val_59 = null;
            if(NetworkStartTable.__il2cppRuntimeField_typeDefinition != 0)
        {
                UnityEngine.Vector3 val_12 = this.万一丂丐丄丁上与丟.position;
            val_60 = null;
            val_48 = val_12.z;
            val_60 = null;
            UnityEngine.Vector3 val_14 = myTransform.position;
            val_49 = val_14.y;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_48}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_49, z = val_14.z});
            this.丟万三下专与与丄丘 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        }
        
        }
        
        val_55 = this;
        this.丘丁丘世丄丒且一丘 = 0f;
        mem[1152921540692024748] = 0;
        label_170:
        val_61 = null;
        val_61 = null;
        this.progressLockMineBonus = UnityEngine.Mathf.Clamp01(value:  this.丘丁丘世丄丒且一丘 / WeaponBonusItem.丞丄丗丅丙七业东丈);
        return;
        label_116:
        val_67 = null;
        val_67 = null;
        三丈丟与丏丘丈丐万 val_26 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if((System.String.op_Equality(a:  val_26.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛(), b:  与不丞丑七丘丁丂丛())) == true)
        {
            goto label_128;
        }
        
        val_65 = null;
        val_66 = 1;
        val_65 = null;
        if(val_66 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_116;
        }
        
        val_69 = null;
        val_69 = null;
        if(this.丘丁丘世丄丒且一丘 >= WeaponBonusItem.丞丄丗丅丙七业东丈)
        {
            goto label_128;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_143;
        }
        
        val_70 = null;
        val_70 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丐丁丂丛万丂丒下不()) == true)
        {
            goto label_138;
        }
        
        val_71 = null;
        val_71 = null;
        if(丗丞业丐丛三上丄丕() == false)
        {
            goto label_143;
        }
        
        label_138:
        this.丘丁丘世丄丒且一丘 = 0f;
        val_72 = null;
        val_72 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_528.Contains(item:  this)) != false)
        {
                val_73 = null;
            val_73 = null;
            bool val_41 = typeof(Player_move_c).__il2cppRuntimeField_528.Remove(item:  this);
        }
        
        this.与丘上丑不丐上丙丐 = this.丙七丝东世丒丝与一;
        goto label_170;
        label_128:
        this.GetBonus();
        goto label_170;
        label_143:
        if(this.与丘上丑不丐上丙丐 <= 0f)
        {
            goto label_157;
        }
        
        float val_42 = UnityEngine.Time.deltaTime;
        val_42 = this.与丘上丑不丐上丙丐 - val_42;
        this.与丘上丑不丐上丙丐 = val_42;
        goto label_170;
        label_157:
        float val_43 = UnityEngine.Time.deltaTime;
        val_43 = this.丘丁丘世丄丒且一丘 + val_43;
        this.丘丁丘世丄丒且一丘 = val_43;
        val_74 = null;
        val_74 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_528.Contains(item:  this)) == true)
        {
            goto label_170;
        }
        
        val_75 = null;
        val_75 = null;
        typeof(Player_move_c).__il2cppRuntimeField_528.Add(item:  this);
        goto label_170;
    }
    private void 丟一且上丘专丗丅丛()
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        float val_2 = this.三丑与上不东丗丁丄 * UnityEngine.Time.deltaTime;
        this.万一丂丐丄丁上与丟.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        int val_3 = UnityEngine.Time.frameCount;
        if(0 != 0)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_5 = this.万一丂丐丄丁上与丟.position;
        val_21 = null;
        val_21 = null;
        UnityEngine.Vector3 val_6 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.丟万三下专与与丄丘 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_22 = null;
        val_22 = null;
        val_23 = null;
        val_23 = null;
        val_24 = null;
        val_24 = null;
        val_25 = null;
        val_25 = null;
        if(InGameGUI.丙丞专丌丁丞与不丐.isTurretInterfaceActive == true)
        {
            goto label_63;
        }
        
        val_26 = null;
        val_26 = null;
        if(this.丟万三下专与与丄丘 < 0)
        {
                if(this.业丗三丌世上丘专丄 == false)
        {
            goto label_47;
        }
        
        }
        
        if(this.万丙丛丐且丑丗丏业 == false)
        {
                return;
        }
        
        if(this.丟万三下专与与丄丘 > 36f)
        {
            goto label_49;
        }
        
        return;
        label_8:
        val_27 = null;
        val_27 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_28 = null;
            val_28 = null;
            if(NetworkStartTable.__il2cppRuntimeField_typeDefinition != 0)
        {
                UnityEngine.Vector3 val_11 = this.万一丂丐丄丁上与丟.position;
            val_29 = null;
            val_29 = null;
            UnityEngine.Vector3 val_13 = myTransform.position;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            this.丟万三下专与与丄丘 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        }
        
        }
        
        label_63:
        if(this.万丙丛丐且丑丗丏业 == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丘丏丛丂丅丂世上丒 == 0)
        {
                return;
        }
        
        label_49:
        this.丐丁丂专业不一且丅(丁丈丝上丐且丘且专:  false);
        return;
        label_47:
        if(this.万丙丛丐且丑丗丏业 == true)
        {
                return;
        }
        
        this.万丙丛丐且丑丗丏业 = InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂下丗丛丂丄业业业(丆丗上丗丆丑丘一丞:  this);
    }
    public void GetBonus()
    {
        var val_3;
        var val_4;
        if( != null)
        {
                val_3 = null;
            val_3 = null;
            typeof(Player_move_c).__il2cppRuntimeField_538.Add(item:  this.previewIndex);
        }
        
        val_4 = null;
        val_4 = null;
        BonusController.丄丞丁丈与业上丞丟.丝三且丒丗丌且七丁(七丄丞七丄丏七下上:  this.ownerId, 三丁丐丂丂丘丈丆丕:  this.previewIndex, 丄丒且丙三丆丟与丏:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁());
    }
    private void 丐丁丂专业不一且丅(bool 丁丈丝上丐且丘且专 = False)
    {
        InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂丟丗丗三不丁丏上(丆丗上丗丆丑丘一丞:  this, 丁丈丝上丐且丘且专:  丁丈丝上丐且丘且专);
        this.万丙丛丐且丑丗丏业 = false;
    }
    public void GetBonusRPC(int 业上上丏丄不上丅丈)
    {
        int val_42;
        var val_43;
        string val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        BonusController val_55;
        string val_56;
        int val_57;
        丞上七丈丗丝与丏丄 val_58;
        string val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() == 业上上丏丄不上丅丈)
        {
                if(this.isUsedBonus == false)
        {
            goto label_5;
        }
        
        }
        
        label_116:
        this.isUsedBonus = true;
        return;
        label_5:
        WeaponBonusItem.丒丂万丒丂一上丞一 val_3 = new WeaponBonusItem.丒丂万丒丂一上丞一();
        val_42 = 1152921505219145728;
        if( != null)
        {
                val_43 = null;
            val_43 = null;
            bool val_4 = typeof(Player_move_c).__il2cppRuntimeField_538.Remove(item:  this.previewIndex);
        }
        
        val_44 = this.weaponPrefabName;
        if(val_44 == null)
        {
                val_44 = System.String.alignConst;
        }
        
        三丅丁丗丗丝丂万且 val_5 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_44);
        if(val_3 == null)
        {
            goto label_17;
        }
        
        .丆丐七世世且丏丐业 = val_5;
        if(val_5 == null)
        {
            goto label_18;
        }
        
        label_71:
        val_45 = null;
        if( == null)
        {
            goto label_21;
        }
        
        val_46 = null;
        val_47 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count < WeaponManager.丂丐丛业世丝丁丛丕)
        {
            goto label_83;
        }
        
        val_48 = 0;
        goto label_27;
        label_47:
        三丈丟与丏丘丈丐万 val_9 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if(val_9.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() != .丆丐七世世且丏丐业.万上丄下业丛丌不丈())
        {
            goto label_35;
        }
        
        val_49 = null;
        val_49 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0].丈专世七丗三丙丝下().Equals(value:  this.weaponPrefabName)) == true)
        {
            goto label_83;
        }
        
        label_35:
        val_47 = null;
        val_48 = 1;
        label_27:
        val_47 = null;
        val_50 = null;
        if(val_48 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_47;
        }
        
        val_50 = null;
        val_51 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        if(val_20.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == 2)
        {
                if(val_51.七丝丈东丈丕丐与丗() != true)
        {
                val_52 = null;
            val_52 = null;
            System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_24 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  WeaponTogglesController.__il2cppRuntimeField_interfaceOffsets);
            val_51 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[1726134312];
            if(val_51 == null)
        {
            goto label_122;
        }
        
        }
        
        }
        
        label_122:
        val_53 = null;
        if(val_51.七丝丈东丈丕丐与丗() == false)
        {
            goto label_64;
        }
        
        val_54 = null;
        val_55 = BonusController.丄丞丁丈与业上丞丟;
        val_56 = val_25.丙丗丕丟七丟上丈丌.业上丙丞丐丄丆丅七();
        val_42 = val_51.下世万丆丛专丒丑丙();
        val_57 = val_51.东东丄丅丐一丙一业();
        val_58 = 2;
        goto label_70;
        label_17:
        .丆丐七世世且丏丐业 = val_5;
        if(.丆丐七世世且丏丐业 != null)
        {
            goto label_71;
        }
        
        label_18:
        object[] val_30 = new object[1];
        val_59 = this.weaponPrefabName;
        if(val_59 == null)
        {
            goto label_72;
        }
        
        if(val_30 == null)
        {
            goto label_73;
        }
        
        label_110:
        if(val_59 != null)
        {
            goto label_74;
        }
        
        goto label_112;
        label_21:
        val_60 = null;
        三丈丟与丏丘丈丐万 val_33 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Find(match:  new System.Predicate<三丈丟与丏丘丈丐万>(object:  val_3, method:  System.Boolean WeaponBonusItem.丒丂万丒丂一上丞一::不丆丐丐丌丌丄丅丒(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)));
        if((val_33 == null) || ((val_33.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  this.weaponPrefabName)) == true))
        {
            goto label_83;
        }
        
        val_61 = null;
        val_61 = null;
        val_55 = BonusController.丄丞丁丈与业上丞丟;
        if(val_33.三丐三丞丘丕不丒专 != null)
        {
            goto label_120;
        }
        
        label_121:
        label_120:
        val_56 = val_33.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌();
        val_42 = val_33.下世万丆丛专丒丑丙();
        val_57 = val_33.东东丄丅丐一丙一业();
        val_58 = 1;
        label_70:
        val_55.丌丐丐丒丏且丏丁不(丆与丕丕丂下丟一丈:  val_56, 丟丒丙丁丑丐世三丈:  val_42, 上丂丝上丘专丟丁丈:  val_57, 丞丙丟丈丌七丐丝上:  -1000f, 万丁丕七丞丞丂与丟:  val_58);
        label_83:
        val_62 = null;
        val_62 = null;
        三下丗万丆专丄且东(三与世丈丂丕丏三上:  .丆丐七世世且丏丐业, 丙丏与丘一丁上丙一:  false, 丟丒丙丁丑丐世三丈:  this.ammoInClip, 上丂丝上丘专丟丁丈:  this.initialAmmoInBackUp);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_116;
        }
        
        val_63 = null;
        val_63 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_298 == 0)
        {
            goto label_116;
        }
        
        val_64 = null;
        val_64 = null;
        GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  typeof(Player_move_c).__il2cppRuntimeField_298);
        goto label_116;
        label_72:
        val_59 = System.String.alignConst;
        if(val_30 != null)
        {
            goto label_110;
        }
        
        label_73:
        if(val_59 == 0)
        {
            goto label_112;
        }
        
        label_74:
        label_112:
        val_30[0] = val_59;
        UnityEngine.Debug.LogErrorFormat(format:  "weapon bonus: rec == null, prefab name = {0}", args:  val_30);
        goto label_116;
        label_64:
        val_65 = null;
        if(val_25.三丐三丞丘丕不丒专 != null)
        {
            goto label_120;
        }
        
        goto label_121;
    }
    public void SetWeaponName(string 丞丕丟丄且丂丅丏万, int 丗万丛丙上丟上万三, int 东七丛丝丑专世丏三)
    {
        this.weaponPrefabName = 丞丕丟丄且丂丅丏万;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丂丒丆丏丁业丁丁丂(丗万丛丙上丟上万三:  丗万丛丙上丟上万三, 东七丛丝丑专世丏三:  东七丛丝丑专世丏三));
    }
    private System.Collections.IEnumerator 丂丒丆丏丁业丁丁丂(int 丗万丛丙上丟上万三, int 东七丛丝丑专世丏三)
    {
        WeaponBonusItem.丐丘丑丘下丟万与业 val_1 = new WeaponBonusItem.丐丘丑丘下丟万与业();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丗万丛丙上丟上万三 = 丗万丛丙上丟上万三;
        }
        else
        {
                mem[32] = this;
            mem[48] = 丗万丛丙上丟上万三;
        }
        
        .东七丛丝丑专世丏三 = 东七丛丝丑专世丏三;
        return (System.Collections.IEnumerator)val_1;
    }
    public void RemoveWeaponPreview(int 丗万丛丙上丟上万三, int 东七丛丝丑专世丏三)
    {
        var val_3;
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() != 丗万丛丙上丟上万三)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        BonusController.丄丞丁丈与业上丞丟.且与丟丞三不丙业不(东七丛丝丑专世丏三:  东七丛丝丑专世丏三, 业丟下丐不丆丆丄七:  this);
    }
    public void SetIndex(int 丗万丛丙上丟上万三, int 东七丛丝丑专世丏三)
    {
        this.previewIndex = 东七丛丝丑专世丏三;
        this.ownerId = 丗万丛丙上丟上万三;
    }
    private void OnDestroy()
    {
        var val_6;
        var val_7;
        var val_8;
        if(this.丅丅丌丕世丙不丑丄 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丅丅丌丕世丙不丑丄);
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_528.Contains(item:  this)) != false)
        {
                val_8 = null;
            val_8 = null;
            bool val_4 = typeof(Player_move_c).__il2cppRuntimeField_528.Remove(item:  this);
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        if(this.万丙丛丐且丑丗丏业 == false)
        {
                return;
        }
        
        this.丐丁丂专业不一且丅(丁丈丝上丐且丘且专:  false);
    }
    public bool AlreadyHaveThisWeapon()
    {
        string val_9;
        var val_10;
        string val_11;
        var val_12;
        var val_13;
        val_9 = this.weaponPrefabName;
        if(val_9 == null)
        {
                val_9 = System.String.alignConst;
        }
        
        var val_9 = 0;
        label_16:
        val_10 = null;
        val_10 = null;
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        if(val_9 >= val_11.Count)
        {
            goto label_8;
        }
        
        val_12 = null;
        val_12 = null;
        三丈丟与丏丘丈丐万 val_5 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        val_11 = val_5.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
        val_9 = val_9 + 1;
        if((System.String.op_Equality(a:  val_11, b:  丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_9).与不丞丑七丘丁丂丛())) == false)
        {
            goto label_16;
        }
        
        val_13 = 1;
        return (bool)val_13;
        label_8:
        val_13 = 0;
        return (bool)val_13;
    }
    public void AddWeaponToPlayer()
    {
        var val_3;
        var val_4;
        this.业丗三丌世上丘专丄 = true;
        this.GetBonus();
        val_3 = null;
        val_3 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_528.Contains(item:  this)) != false)
        {
                val_4 = null;
            val_4 = null;
            bool val_2 = typeof(Player_move_c).__il2cppRuntimeField_528.Remove(item:  this);
        }
        
        if(this.万丙丛丐且丑丗丏业 == false)
        {
                return;
        }
        
        this.丐丁丂专业不一且丅(丁丈丝上丐且丘且专:  true);
    }
    public string GetWeaponName()
    {
        return (string)this.weaponPrefabName;
    }
    public int GetCurrentAmmoInClip()
    {
        int val_4 = this.ammoInClip;
        if(val_4 != 1)
        {
                return val_4;
        }
        
        if(this.丆业七丌丁丕一丐七 != 0)
        {
                val_4 = this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁();
            this.ammoInClip = val_4.下世下丂丂丌丑丝世();
            return val_4;
        }
        
        val_4 = this.ammoInClip;
        return val_4;
    }
    public int GetCurrentAmmoInBackpack()
    {
        int val_4 = this.initialAmmoInBackUp;
        if(val_4 != 1)
        {
                return val_4;
        }
        
        if(this.丆业七丌丁丕一丐七 != 0)
        {
                val_4 = this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁();
            this.initialAmmoInBackUp = val_4.丆丁丄丐丕下丘业丟();
            return val_4;
        }
        
        val_4 = this.initialAmmoInBackUp;
        return val_4;
    }
    public ItemRarity GetRarity()
    {
        if(this.丆业七丌丁丕一丐七 == 0)
        {
                三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.weaponPrefabName);
            this = ???;
        }
        else
        {
                三丅丁丗丗丝丂万且 val_3 = val_8 + 80.丌上丗丕不七世丅丁();
            if(val_3 != null)
        {
                return val_3.丆丙专丆丅丟丙与丈();
        }
        
            return val_3.丆丙专丆丅丟丙与丈();
        }
    
    }
    public bool IsGadget()
    {
        return false;
    }
    public WeaponBonusItem()
    {
        this.三丑与上不东丗丁丄 = 120f;
        this.丛丞丆且丕丑丄丗上 = 100f;
        this.丟万三下专与与丄丘 = 9.183409E-41f;
        this.weaponPrefabName = System.String.alignConst;
        this.ammoInClip = 0;
        this.initialAmmoInBackUp = 0;
        this.丙七丝东世丒丝与一 = 0.25f;
    }
    private static WeaponBonusItem()
    {
        WeaponBonusItem.丞丄丗丅丙七业东丈 = 1f;
    }
    private UnityEngine.Transform IPickUpWeapon.get_transform()
    {
        return this.transform;
    }

}
