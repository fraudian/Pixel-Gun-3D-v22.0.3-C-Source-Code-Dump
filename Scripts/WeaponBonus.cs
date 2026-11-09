using UnityEngine;
internal sealed class WeaponBonus : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private bool 丒丞一下丑丆丐丕丞;
    private bool 万丝一万丐且丌业丛;
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    private string 丅丐丞丞丐丘东丘丘;
    private float 三丑与上不东丗丁丄;
    public bool isWear;
    private bool 丞专丄丙丂丘丞专丒;
    private UnityEngine.GameObject 丅丅丌丕世丙不丑丄;
    
    // Methods
    private void Awake()
    {
        this.万一丂丐丄丁上与丟 = this.transform;
    }
    private void Start()
    {
        UnityEngine.GameObject val_26;
        var val_27;
        if((System.String.IsNullOrEmpty(value:  this.丅丐丞丞丐丘东丘丘)) != false)
        {
                this.丅丐丞丞丐丘东丘丘 = this.gameObject.name.Substring(startIndex:  0, length:  this.gameObject.name.Length - 13);
        }
        
        if(PGCompany.丁东丌世与丕东丆上.丕丆万一丅丄业世丌() == false)
        {
                return;
        }
        
        if(GameConnect.丌专丌万一下丕专上() == true)
        {
                return;
        }
        
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
                return;
        }
        
        if(GameConnect.世丐丄三三上丅七三() == true)
        {
                return;
        }
        
        if(GameConnect.丙丘不世专且万丄丐() == true)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.identity;
        val_26 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "BonusFX"), position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, rotation:  new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w});
        if(val_26 != null)
        {
                if(null == null)
        {
            goto label_31;
        }
        
        }
        
        val_26 = 0;
        val_27 = 1;
        goto label_32;
        label_31:
        val_27 = 0;
        label_32:
        val_26.transform.parent = this.万一丂丐丄丁上与丟;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
        val_26.transform.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        val_26.layer = this.gameObject.layer;
        ZombieCreator.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_26, 丁东丑丞与下丛丐东:  this.gameObject.layer);
    }
    private void Update()
    {
        UnityEngine.Object val_48;
        float val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        string val_56;
        var val_57;
        Player_move_c val_58;
        var val_59;
        string val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        val_48 = this;
        if(this.丒丞一下丑丆丐丕丞 != true)
        {
                if((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false) && (this.万丝一万丐且丌业丛 != false))
        {
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
            return;
        }
        
        }
        
        this.丒丞一下丑丆丐丕丞 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(this.万丝一万丐且丌业丛 == true)
        {
                return;
        }
        
        val_49 = this.三丑与上不东丗丁丄;
        float val_6 = val_49 * UnityEngine.Time.deltaTime;
        this.万一丂丐丄丁上与丟.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_50 = 1152921505286238208;
        val_51 = null;
        val_51 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_52 = null;
        val_52 = null;
        val_53 = null;
        val_53 = null;
        if(this.万丝一万丐且丌业丛 == true)
        {
                return;
        }
        
        val_54 = null;
        val_54 = null;
        UnityEngine.Vector3 val_8 = this.万一丂丐丄丁上与丟.position;
        val_55 = null;
        val_49 = val_8.x;
        val_55 = null;
        UnityEngine.Vector3 val_10 = myTransform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_49, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) >= 0)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_45;
        }
        
        this.GetBonus();
        goto label_56;
        label_45:
        if(this.isWear == true)
        {
            goto label_56;
        }
        
        val_56 = this.丅丐丞丞丐丘东丘丘;
        if(val_56 == null)
        {
                val_56 = System.String.alignConst;
        }
        
        三丅丁丗丗丝丂万且 val_14 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_56);
        if(val_14 == null)
        {
            goto label_51;
        }
        
        val_57 = null;
        val_57 = null;
        val_58 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_58 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        三下丗万丆专丄且东(三与世丈丂丕丏三上:  val_14, 丙丏与丘一丁上丙一:  false, 丟丒丙丁丑丐世三丈:  0, 上丂丝上丘专丟丁丈:  0);
        goto label_56;
        label_51:
        val_59 = val_50;
        object[] val_15 = new object[1];
        val_60 = this.丅丐丞丞丐丘东丘丘;
        val_58 = "weapon bonus: rec == null, prefab name = {0}";
        if(val_60 == null)
        {
            goto label_57;
        }
        
        if(val_15 == null)
        {
            goto label_58;
        }
        
        label_61:
        if(val_60 != null)
        {
            goto label_59;
        }
        
        goto label_63;
        label_57:
        val_60 = System.String.alignConst;
        if(val_15 != null)
        {
            goto label_61;
        }
        
        label_58:
        if(val_60 == 0)
        {
            goto label_63;
        }
        
        label_59:
        label_63:
        val_15[0] = val_60;
        UnityEngine.Debug.LogErrorFormat(format:  val_58, args:  val_15);
        val_50 = val_59;
        label_56:
        this.万丝一万丐且丌业丛 = true;
        if((GameConnect.丌专丌万一下丕专上() == true) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false))
        {
            goto label_71;
        }
        
        val_59 = 1152921505171275776;
        val_61 = null;
        val_61 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_74;
        }
        
        label_71:
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                TrainingController.丛丒丝丅丞丁且业上(丏丘丙丆三丕丕上丌:  3);
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  18);
        }
        
        val_62 = null;
        val_62 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_48 = this.photonView;
            val_58 = System.Array.Empty<System.Object>();
            val_48.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  18, 丞下万上三丘上与专:  (GameConnect.万不丒丌丙万丗东不() != true) ? 6 : 3, 丗丟上上丒丐丗丞丙:  val_58);
        }
        else
        {
                val_48 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  val_48);
        }
        
        if(GameConnect.世丐丄三三上丅七三() == false)
        {
                return;
        }
        
        val_63 = null;
        typeof(Player_move_c).__il2cppRuntimeField_618.万丑东上万丙业丁丑(丆丞丌东丐一丕一丄:  2);
        return;
        label_74:
        if(this.isWear == false)
        {
            goto label_98;
        }
        
        val_64 = null;
        val_64 = null;
        Rilisoft.OfferItem val_29 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  40, 丞一丁业丄一一业且:  下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.Item[UnityEngine.Application.loadedLevelName], 丂丕丂丏专丂丄丕且:  1);
        if((Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  val_29)) == true)
        {
            goto label_121;
        }
        
        丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_29, 丁且丟不七下丆丒丟:  false, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  false, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  39, 不丐丅丁丂七丐丘丛:  0, 丁七丐丁丙丄丙不东:  false);
        goto label_121;
        label_98:
        char[] val_33 = new char[1];
        val_33[0] = '#';
        System.Collections.Generic.List<System.String> val_35 = new System.Collections.Generic.List<System.String>();
        val_65 = 0;
        goto label_112;
        label_116:
        val_35.Add(item:  Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟上七七一且丞丈与().Split(separator:  val_33)[0]);
        val_65 = 1;
        label_112:
        if(val_65 < val_34.Length)
        {
            goto label_116;
        }
        
        val_66 = null;
        val_66 = null;
        if((val_35.Contains(item:  下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.Item[UnityEngine.Application.loadedLevelName])) != true)
        {
                val_67 = null;
            val_67 = null;
            val_35.Add(item:  下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.Item[UnityEngine.Application.loadedLevelName]);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄丘丘丑一丛上丗丌(下下丏一丙不丘丌丞:  System.String.Join(separator:  "#", value:  val_35.ToArray()));
        }
        
        label_121:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_68 = null;
            val_68 = null;
            val_69 = null;
            val_69 = null;
            Rilisoft.一丟专且三万丞丁丂.万丒三丟业专丈不丁(丞与世丏丌东丞一下:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 下丛不丕七且三一丆:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, 丐丞与丐世丗与下丗:  与丂丏丛丞丞丒丟丄.一丗丈丛丌专专世世, 丄上七业丒与丙三下:  false);
        }
        
        val_70 = null;
        val_70 = null;
        LevelCompleteLoader.七丐丅专且专七三丆 = 0;
        LevelCompleteLoader.专万丟三世业丙丈且 = "LevelComplete";
        UnityEngine.Color val_46 = UnityEngine.Color.white;
        AutoFade.上丅丏丑东丅丐一丈(丒丙业业丌丅丒丅丝:  "LevelToCompleteProm", 世三丏丑丙丅丌且下:  2f, 丅世丗丛万下下专丕:  0f, 一七专业丞丛世且丌:  new UnityEngine.Color() {r = val_46.r, g = val_46.g, b = val_46.b, a = val_46.a});
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.ExitingInCampaign = true;
        InGameGUI.丙丞专丌丁丞与不丐.SetEnablePerfectLabel(丝三丄专丗丞丄丄丌:  true);
    }
    public void GetBonus()
    {
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() == null)
        {
                return;
        }
        
        this = this.photonView;
        object[] val_3 = new object[1];
        val_3[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        this.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  170, 丞下万上三丘上与专:  6, 丗丟上上丒丐丗丞丙:  val_3);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_4;
        object val_5;
        var val_6;
        int val_7;
        val_4 = 专丒丌丆下丐丞丟丞;
        val_5 = 丞世不丒下上上丝丑;
        byte val_1 = val_5 & 255;
        if(val_1 > 89)
        {
            goto label_1;
        }
        
        if(val_1 == 18)
        {
            goto label_2;
        }
        
        if(val_1 != 89)
        {
            goto label_9;
        }
        
        val_4 = val_4[0];
        this.丅丐丞丞丐丘东丘丘 = val_4;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丂丒丆丏丁业丁丁丂());
        goto label_14;
        label_1:
        if(val_1 == 173)
        {
            goto label_8;
        }
        
        if(val_1 != 170)
        {
            goto label_9;
        }
        
        object val_4 = val_4[0];
        this.且七三丏丂专丁丆丘(丐丌丌丈下丁丝丅万:  21884928);
        goto label_14;
        label_9:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        this.业丆世丒且三丁专上();
        goto label_14;
        label_8:
        val_7 = 专丒丌丆下丐丞丟丞.Length;
        if(val_7 == 0)
        {
                val_7 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_5 = val_4[0];
        if(val_7 == 0)
        {
                val_5 = val_4[0];
        }
        
        val_5.一丘丙丘世万丐丝丘(丗万丛丙上丟上万三:  21884928, 东七丛丝丑专世丏三:  21884928);
        label_14:
        val_6 = 1;
        return (bool)val_6;
    }
    private void 且七三丏丂专丁丆丘(int 丐丌丌丈下丁丝丅万)
    {
        string val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        string val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() == 丐丌丌丈下丁丝丅万)
        {
                if(this.丞专丄丙丂丘丞专丒 == false)
        {
            goto label_5;
        }
        
        }
        
        label_103:
        this.丞专丄丙丂丘丞专丒 = true;
        return;
        label_5:
        WeaponBonus.丒丛丁与丅东丒不七 val_3 = new WeaponBonus.丒丛丁与丅东丒不七();
        val_37 = this.丅丐丞丞丐丘东丘丘;
        if(val_37 == null)
        {
                val_37 = System.String.alignConst;
        }
        
        三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_37);
        if(val_3 == null)
        {
            goto label_9;
        }
        
        .丆丐七世世且丏丐业 = val_4;
        if(val_4 == null)
        {
            goto label_10;
        }
        
        label_62:
        val_38 = null;
        if( == null)
        {
            goto label_13;
        }
        
        val_39 = null;
        val_40 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count < WeaponManager.丂丐丛业世丝丁丛丕)
        {
            goto label_71;
        }
        
        val_41 = 0;
        goto label_19;
        label_40:
        三丈丟与丏丘丈丐万 val_8 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if(val_8.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() != .丆丐七世世且丏丐业.万上丄下业丛丌不丈())
        {
            goto label_27;
        }
        
        val_42 = null;
        val_42 = null;
        三丈丟与丏丘丈丐万 val_12 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if((val_12.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  this.丅丐丞丞丐丘东丘丘)) == true)
        {
            goto label_71;
        }
        
        label_27:
        val_40 = null;
        val_41 = 1;
        label_19:
        val_40 = null;
        val_43 = null;
        if(val_41 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_40;
        }
        
        val_43 = null;
        val_44 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        if(val_19.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == 2)
        {
                if(val_44.七丝丈东丈丕丐与丗() != true)
        {
                val_45 = null;
            val_45 = null;
            System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_23 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  WeaponTogglesController.__il2cppRuntimeField_interfaceOffsets);
            val_44 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[1722374728];
        }
        
        }
        
        val_46 = null;
        val_46 = null;
        if(val_24.三丐三丞丘丕不丒专 != null)
        {
            goto label_106;
        }
        
        label_107:
        label_106:
        BonusController.丄丞丁丈与业上丞丟.丌丐丐丒丏且丏丁不(丆与丕丕丂下丟一丈:  val_24.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), 丟丒丙丁丑丐世三丈:  val_44.下世万丆丛专丒丑丙(), 上丂丝上丘专丟丁丈:  val_44.东东丄丅丐一丙一业(), 丞丙丟丈丌七丐丝上:  -1000f, 万丁丕七丞丞丂与丟:  1);
        goto label_71;
        label_9:
        .丆丐七世世且丏丐业 = val_4;
        if(.丆丐七世世且丏丐业 != null)
        {
            goto label_62;
        }
        
        label_10:
        object[] val_28 = new object[1];
        val_47 = this.丅丐丞丞丐丘东丘丘;
        if(val_47 == null)
        {
            goto label_63;
        }
        
        if(val_28 == null)
        {
            goto label_64;
        }
        
        label_97:
        if(val_47 != null)
        {
            goto label_65;
        }
        
        goto label_99;
        label_13:
        val_48 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Find(match:  new System.Predicate<三丈丟与丏丘丈丐万>(object:  val_3, method:  System.Boolean WeaponBonus.丒丛丁与丅东丒不七::不丆丐丐丌丌丄丅丒(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)))) != null)
        {
                if((val_31.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  this.丅丐丞丞丐丘东丘丘)) == false)
        {
            goto label_74;
        }
        
        }
        
        label_71:
        val_49 = null;
        val_49 = null;
        三下丗万丆专丄且东(三与世丈丂丕丏三上:  .丆丐七世世且丏丐业, 丙丏与丘一丁上丙一:  false, 丟丒丙丁丑丐世三丈:  0, 上丂丝上丘专丟丁丈:  0);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_103;
        }
        
        val_50 = null;
        val_50 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_298 == 0)
        {
            goto label_103;
        }
        
        val_51 = null;
        val_51 = null;
        GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  typeof(Player_move_c).__il2cppRuntimeField_298);
        goto label_103;
        label_63:
        val_47 = System.String.alignConst;
        if(val_28 != null)
        {
            goto label_97;
        }
        
        label_64:
        if(val_47 == 0)
        {
            goto label_99;
        }
        
        label_65:
        label_99:
        val_28[0] = val_47;
        UnityEngine.Debug.LogErrorFormat(format:  "weapon bonus: rec == null, prefab name = {0}", args:  val_28);
        goto label_103;
        label_74:
        val_52 = null;
        val_52 = null;
        if(val_31.三丐三丞丘丕不丒专 != null)
        {
            goto label_106;
        }
        
        goto label_107;
    }
    public void SetWeaponName(string 丞丕丟丄且丂丅丏万)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丞丕丟丄且丂丅丏万 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丞丕丟丄且丂丅丏万 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丞丕丟丄且丂丅丏万;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  89, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 下丐丟丗丛三丛东丌(string 丞丕丟丄且丂丅丏万)
    {
        this.丅丐丞丞丐丘东丘丘 = 丞丕丟丄且丂丅丏万;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丂丒丆丏丁业丁丁丂());
    }
    public void RemoveWeaponPreview(int 丗万丛丙上丟上万三, int 东七丛丝丑专世丏三)
    {
        object[] val_2 = new object[2];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丗万丛丙上丟上万三 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丗万丛丙上丟上万三 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丗万丛丙上丟上万三;
        val_2[1] = 东七丛丝丑专世丏三;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  173, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 一丘丙丘世万丐丝丘(int 丗万丛丙上丟上万三, int 东七丛丝丑专世丏三)
    {
        var val_3;
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() != 丗万丛丙上丟上万三)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        BonusController.丄丞丁丈与业上丞丟.且与丟丞三不丙业不(东七丛丝丑专世丏三:  东七丛丝丑专世丏三, 业丟下丐不丆丆丄七:  0);
    }
    private System.Collections.IEnumerator 丂丒丆丏丁业丁丁丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponBonus.丆丈丂且不丐一丏专();
    }
    private void 业丆世丒且三丁专上()
    {
        InGameGUI val_6;
        if(this.丅丅丌丕世丙不丑丄 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丅丅丌丕世丙不丑丄);
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
        }
        else
        {
                this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        val_6 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6 = InGameGUI.丙丞专丌丁丞与不丐;
        val_6.SetEnablePerfectLabel(丝三丄专丗丞丄丄丌:  false);
    }
    public WeaponBonus()
    {
        this.三丑与上不东丗丁丄 = 120f;
        this.丅丐丞丞丐丘东丘丘 = System.String.alignConst;
    }

}
