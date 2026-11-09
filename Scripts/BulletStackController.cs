using UnityEngine;
public class BulletStackController : MonoBehaviour
{
    // Fields
    internal static BulletStackController 丄丞丁丈与业上丞丟;
    public UnityEngine.Transform standartBulletStack;
    public UnityEngine.Transform redBulletStack;
    public UnityEngine.Transform for252BulletStack;
    public UnityEngine.Transform turquoiseBulletStack;
    public UnityEngine.Transform greenBulletStack;
    public UnityEngine.Transform violetBulletStack;
    public UnityEngine.Transform pistolBulletStack;
    public UnityEngine.Transform shotgunBulletStack;
    public UnityEngine.Transform minigunBulletStack;
    public UnityEngine.Transform snipeBulletStack;
    public UnityEngine.Transform blueBulletStack;
    public UnityEngine.Transform orangeBulletStack;
    public UnityEngine.GameObject[][] bullets;
    private int[] 丄丂丙丒一丏丞且丘;
    private UnityEngine.GameObject _standartBulletPrefab;
    private UnityEngine.GameObject _redBulletPrefab;
    private UnityEngine.GameObject _for252BulletPrefab;
    private UnityEngine.GameObject _turquoiseBulletPrefab;
    private UnityEngine.GameObject _greenBulletPrefab;
    private UnityEngine.GameObject _violetBulletPrefab;
    private UnityEngine.GameObject _pistolBulletPrefab;
    private UnityEngine.GameObject _shotGunBulletPrefab;
    private UnityEngine.GameObject _minigunBulletPrefab;
    private UnityEngine.GameObject _snipeBulletPrefab;
    private UnityEngine.GameObject _blueBulletPrefab;
    public UnityEngine.GameObject _orangeBulletPrefab;
    private int prefabsCount;
    
    // Methods
    private void Awake()
    {
        BulletStackController.丄丞丁丈与业上丞丟 = this;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    private void Start()
    {
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
        var val_62;
        var val_50 = 0;
        do
        {
            val_50 = val_50 + 1;
            this.丄丂丙丒一丏丞且丘[val_50] = 0;
        }
        while(val_50 != 10);
        
        UnityEngine.GameObject[][] val_1 = new UnityEngine.GameObject[][12];
        this.bullets = val_1;
        int val_2 = this.standartBulletStack.childCount;
        val_50 = 1152921507364547232;
        UnityEngine.GameObject[] val_3 = new UnityEngine.GameObject[0];
        if(val_1 == null)
        {
            goto label_5;
        }
        
        if(val_3 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_3 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_51 = 0;
        val_1[0] = val_3;
        goto label_11;
        label_25:
        UnityEngine.GameObject val_5 = this.standartBulletStack.GetChild(index:  0).gameObject;
        if(val_3[0] == null)
        {
            goto label_16;
        }
        
        if(val_5 != null)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        if(val_5 == null)
        {
            goto label_20;
        }
        
        label_17:
        label_20:
        val_51 = 1;
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_20 = val_5;
        label_11:
        UnityEngine.GameObject[] val_52 = this.bullets[0];
        if(val_51 < this.bullets[0].Length)
        {
            goto label_25;
        }
        
        int val_6 = this.redBulletStack.childCount;
        UnityEngine.GameObject[] val_7 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_27;
        }
        
        if(val_7 != null)
        {
            goto label_28;
        }
        
        goto label_31;
        label_27:
        if(val_7 == null)
        {
            goto label_31;
        }
        
        label_28:
        label_31:
        val_52 = 0;
        this.bullets[1] = val_7;
        goto label_33;
        label_47:
        UnityEngine.GameObject[] val_53 = this.bullets[1];
        UnityEngine.GameObject val_9 = this.redBulletStack.GetChild(index:  0).gameObject;
        if(val_53 == null)
        {
            goto label_38;
        }
        
        if(val_9 != null)
        {
            goto label_39;
        }
        
        goto label_42;
        label_38:
        if(val_9 == null)
        {
            goto label_42;
        }
        
        label_39:
        label_42:
        val_52 = 1;
        val_53[0] = val_9;
        label_33:
        UnityEngine.GameObject[] val_54 = this.bullets[1];
        if(val_52 < this.bullets[1].Length)
        {
            goto label_47;
        }
        
        int val_10 = this.for252BulletStack.childCount;
        UnityEngine.GameObject[] val_11 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_49;
        }
        
        if(val_11 != null)
        {
            goto label_50;
        }
        
        goto label_53;
        label_49:
        if(val_11 == null)
        {
            goto label_53;
        }
        
        label_50:
        label_53:
        val_53 = 0;
        this.bullets[2] = val_11;
        goto label_55;
        label_69:
        UnityEngine.GameObject[] val_55 = this.bullets[2];
        UnityEngine.GameObject val_13 = this.for252BulletStack.GetChild(index:  0).gameObject;
        if(val_55 == null)
        {
            goto label_60;
        }
        
        if(val_13 != null)
        {
            goto label_61;
        }
        
        goto label_64;
        label_60:
        if(val_13 == null)
        {
            goto label_64;
        }
        
        label_61:
        label_64:
        val_53 = 1;
        val_55[0] = val_13;
        label_55:
        UnityEngine.GameObject[] val_56 = this.bullets[2];
        if(val_53 < this.bullets[2].Length)
        {
            goto label_69;
        }
        
        int val_14 = this.turquoiseBulletStack.childCount;
        UnityEngine.GameObject[] val_15 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_71;
        }
        
        if(val_15 != null)
        {
            goto label_72;
        }
        
        goto label_75;
        label_71:
        if(val_15 == null)
        {
            goto label_75;
        }
        
        label_72:
        label_75:
        val_54 = 0;
        this.bullets[3] = val_15;
        goto label_77;
        label_91:
        UnityEngine.GameObject[] val_57 = this.bullets[3];
        UnityEngine.GameObject val_17 = this.turquoiseBulletStack.GetChild(index:  0).gameObject;
        if(val_57 == null)
        {
            goto label_82;
        }
        
        if(val_17 != null)
        {
            goto label_83;
        }
        
        goto label_86;
        label_82:
        if(val_17 == null)
        {
            goto label_86;
        }
        
        label_83:
        label_86:
        val_54 = 1;
        val_57[0] = val_17;
        label_77:
        UnityEngine.GameObject[] val_58 = this.bullets[3];
        if(val_54 < this.bullets[3].Length)
        {
            goto label_91;
        }
        
        int val_18 = this.greenBulletStack.childCount;
        UnityEngine.GameObject[] val_19 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_93;
        }
        
        if(val_19 != null)
        {
            goto label_94;
        }
        
        goto label_97;
        label_93:
        if(val_19 == null)
        {
            goto label_97;
        }
        
        label_94:
        label_97:
        val_55 = 0;
        this.bullets[4] = val_19;
        goto label_99;
        label_113:
        UnityEngine.GameObject[] val_59 = this.bullets[4];
        UnityEngine.GameObject val_21 = this.greenBulletStack.GetChild(index:  0).gameObject;
        if(val_59 == null)
        {
            goto label_104;
        }
        
        if(val_21 != null)
        {
            goto label_105;
        }
        
        goto label_108;
        label_104:
        if(val_21 == null)
        {
            goto label_108;
        }
        
        label_105:
        label_108:
        val_55 = 1;
        val_59[0] = val_21;
        label_99:
        UnityEngine.GameObject[] val_60 = this.bullets[4];
        if(val_55 < this.bullets[4].Length)
        {
            goto label_113;
        }
        
        int val_22 = this.violetBulletStack.childCount;
        UnityEngine.GameObject[] val_23 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_115;
        }
        
        if(val_23 != null)
        {
            goto label_116;
        }
        
        goto label_119;
        label_115:
        if(val_23 == null)
        {
            goto label_119;
        }
        
        label_116:
        label_119:
        val_56 = 0;
        this.bullets[5] = val_23;
        goto label_121;
        label_135:
        UnityEngine.GameObject[] val_61 = this.bullets[5];
        UnityEngine.GameObject val_25 = this.violetBulletStack.GetChild(index:  0).gameObject;
        if(val_61 == null)
        {
            goto label_126;
        }
        
        if(val_25 != null)
        {
            goto label_127;
        }
        
        goto label_130;
        label_126:
        if(val_25 == null)
        {
            goto label_130;
        }
        
        label_127:
        label_130:
        val_56 = 1;
        val_61[0] = val_25;
        label_121:
        UnityEngine.GameObject[] val_62 = this.bullets[5];
        if(val_56 < this.bullets[5].Length)
        {
            goto label_135;
        }
        
        int val_26 = this.pistolBulletStack.childCount;
        UnityEngine.GameObject[] val_27 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_137;
        }
        
        if(val_27 != null)
        {
            goto label_138;
        }
        
        goto label_141;
        label_137:
        if(val_27 == null)
        {
            goto label_141;
        }
        
        label_138:
        label_141:
        val_57 = 0;
        this.bullets[6] = val_27;
        goto label_143;
        label_157:
        UnityEngine.GameObject[] val_63 = this.bullets[6];
        UnityEngine.GameObject val_29 = this.pistolBulletStack.GetChild(index:  0).gameObject;
        if(val_63 == null)
        {
            goto label_148;
        }
        
        if(val_29 != null)
        {
            goto label_149;
        }
        
        goto label_152;
        label_148:
        if(val_29 == null)
        {
            goto label_152;
        }
        
        label_149:
        label_152:
        val_57 = 1;
        val_63[0] = val_29;
        label_143:
        UnityEngine.GameObject[] val_64 = this.bullets[6];
        if(val_57 < this.bullets[6].Length)
        {
            goto label_157;
        }
        
        int val_30 = this.shotgunBulletStack.childCount;
        UnityEngine.GameObject[] val_31 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_159;
        }
        
        if(val_31 != null)
        {
            goto label_160;
        }
        
        goto label_163;
        label_159:
        if(val_31 == null)
        {
            goto label_163;
        }
        
        label_160:
        label_163:
        val_58 = 0;
        this.bullets[7] = val_31;
        goto label_165;
        label_179:
        UnityEngine.GameObject[] val_65 = this.bullets[7];
        UnityEngine.GameObject val_33 = this.shotgunBulletStack.GetChild(index:  0).gameObject;
        if(val_65 == null)
        {
            goto label_170;
        }
        
        if(val_33 != null)
        {
            goto label_171;
        }
        
        goto label_174;
        label_170:
        if(val_33 == null)
        {
            goto label_174;
        }
        
        label_171:
        label_174:
        val_58 = 1;
        val_65[0] = val_33;
        label_165:
        UnityEngine.GameObject[] val_66 = this.bullets[7];
        if(val_58 < this.bullets[7].Length)
        {
            goto label_179;
        }
        
        int val_34 = this.minigunBulletStack.childCount;
        UnityEngine.GameObject[] val_35 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_181;
        }
        
        if(val_35 != null)
        {
            goto label_182;
        }
        
        goto label_185;
        label_181:
        if(val_35 == null)
        {
            goto label_185;
        }
        
        label_182:
        label_185:
        val_59 = 0;
        this.bullets[8] = val_35;
        goto label_187;
        label_201:
        UnityEngine.GameObject[] val_67 = this.bullets[8];
        UnityEngine.GameObject val_37 = this.minigunBulletStack.GetChild(index:  0).gameObject;
        if(val_67 == null)
        {
            goto label_192;
        }
        
        if(val_37 != null)
        {
            goto label_193;
        }
        
        goto label_196;
        label_192:
        if(val_37 == null)
        {
            goto label_196;
        }
        
        label_193:
        label_196:
        val_59 = 1;
        val_67[0] = val_37;
        label_187:
        UnityEngine.GameObject[] val_68 = this.bullets[8];
        if(val_59 < this.bullets[8].Length)
        {
            goto label_201;
        }
        
        int val_38 = this.snipeBulletStack.childCount;
        UnityEngine.GameObject[] val_39 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_203;
        }
        
        if(val_39 != null)
        {
            goto label_204;
        }
        
        goto label_207;
        label_203:
        if(val_39 == null)
        {
            goto label_207;
        }
        
        label_204:
        label_207:
        val_60 = 0;
        this.bullets[9] = val_39;
        goto label_209;
        label_223:
        UnityEngine.GameObject[] val_69 = this.bullets[9];
        UnityEngine.GameObject val_41 = this.snipeBulletStack.GetChild(index:  0).gameObject;
        if(val_69 == null)
        {
            goto label_214;
        }
        
        if(val_41 != null)
        {
            goto label_215;
        }
        
        goto label_218;
        label_214:
        if(val_41 == null)
        {
            goto label_218;
        }
        
        label_215:
        label_218:
        val_60 = 1;
        val_69[0] = val_41;
        label_209:
        UnityEngine.GameObject[] val_70 = this.bullets[9];
        if(val_60 < this.bullets[9].Length)
        {
            goto label_223;
        }
        
        int val_42 = this.blueBulletStack.childCount;
        UnityEngine.GameObject[] val_43 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_225;
        }
        
        if(val_43 != null)
        {
            goto label_226;
        }
        
        goto label_229;
        label_225:
        if(val_43 == null)
        {
            goto label_229;
        }
        
        label_226:
        label_229:
        val_61 = 0;
        this.bullets[10] = val_43;
        goto label_231;
        label_245:
        UnityEngine.GameObject[] val_71 = this.bullets[10];
        UnityEngine.GameObject val_45 = this.blueBulletStack.GetChild(index:  0).gameObject;
        if(val_71 == null)
        {
            goto label_236;
        }
        
        if(val_45 != null)
        {
            goto label_237;
        }
        
        goto label_240;
        label_236:
        if(val_45 == null)
        {
            goto label_240;
        }
        
        label_237:
        label_240:
        val_61 = 1;
        val_71[0] = val_45;
        label_231:
        UnityEngine.GameObject[] val_72 = this.bullets[10];
        if(val_61 < this.bullets[10].Length)
        {
            goto label_245;
        }
        
        int val_46 = this.orangeBulletStack.childCount;
        UnityEngine.GameObject[] val_47 = new UnityEngine.GameObject[0];
        if(this.bullets == null)
        {
            goto label_247;
        }
        
        if(val_47 != null)
        {
            goto label_248;
        }
        
        goto label_251;
        label_247:
        if(val_47 == null)
        {
            goto label_251;
        }
        
        label_248:
        label_251:
        val_62 = 0;
        this.bullets[11] = val_47;
        goto label_253;
        label_267:
        UnityEngine.GameObject[] val_73 = this.bullets[11];
        UnityEngine.GameObject val_49 = this.orangeBulletStack.GetChild(index:  0).gameObject;
        if(val_73 == null)
        {
            goto label_258;
        }
        
        if(val_49 != null)
        {
            goto label_259;
        }
        
        goto label_262;
        label_258:
        if(val_49 == null)
        {
            goto label_262;
        }
        
        label_259:
        label_262:
        val_50 = 0;
        val_62 = 1;
        val_73[val_50] = val_49;
        label_253:
        UnityEngine.GameObject[] val_74 = this.bullets[11];
        if(val_62 < this.bullets[11].Length)
        {
            goto label_267;
        }
    
    }
    public UnityEngine.GameObject GetCurrentBullet(int 丁丅丈丌丟世丗丗丟 = 0)
    {
        int val_1;
        UnityEngine.GameObject val_2;
        val_1 = 丁丅丈丌丟世丗丗丟;
        if((val_1 & 2147483648) == 0)
        {
                int val_1 = this.丄丂丙丒一丏丞且丘[(long)val_1];
            val_1 = val_1 + 1;
            this.丄丂丙丒一丏丞且丘[(long)val_1] = val_1;
            UnityEngine.GameObject[] val_3 = this.bullets[(long)val_1];
            if(this.丄丂丙丒一丏丞且丘[(long)val_1] >= this.bullets[(long)(int)(丁丅丈丌丟世丗丗丟)][0].Length)
        {
                this.丄丂丙丒一丏丞且丘[(long)val_1] = 0;
        }
        
            val_1 = this.丄丂丙丒一丏丞且丘[(long)val_1];
            val_2 = this.bullets[(long)val_1][val_1];
            return (UnityEngine.GameObject)val_2;
        }
        
        val_2 = 0;
        return (UnityEngine.GameObject)val_2;
    }
    private void OnDestroy()
    {
        BulletStackController.丄丞丁丈与业上丞丟 = 0;
    }
    public BulletStackController()
    {
        this.丄丂丙丒一丏丞且丘 = new int[12];
        this.prefabsCount = 20;
    }

}
