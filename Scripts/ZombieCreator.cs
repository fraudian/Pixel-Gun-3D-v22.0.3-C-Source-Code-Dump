using UnityEngine;
public sealed class ZombieCreator : MonoBehaviour
{
    // Fields
    internal static ZombieCreator 丞丈丟丒丂丞丏不丑;
    private static int 万丌丅七丛丆东丅不;
    private static System.Collections.Generic.List<System.Collections.Generic.List<string>> 且丁丙上与丝丌丐不;
    private static System.Collections.Generic.List<string> 世丙专不七丘丕东丘;
    private static readonly System.Collections.Generic.HashSet<string> 东丆东不下丝丙丁丘;
    internal static System.Collections.Generic.Dictionary<int, int> 专不丈专丑丈不丕丑;
    internal static System.Collections.Generic.List<System.Collections.Generic.List<string>> 丂下七丈丄丄东专丒;
    internal static System.Collections.Generic.List<string> 上万丆七丙丙三丟专;
    private static System.Nullable<int> 一丞丏丛三业丌世丌;
    private System.Collections.Generic.List<string[]> 三东丙万丝丟丛丅丏;
    private bool 丒丗丟丄丕丘三丗丏;
    private int 丙业七且东丞万业与;
    private int 丐三且下丒丆丙不与;
    private int[] 且丒业丈七东七丘丗;
    private float timeForSpawnMobInClassicArena;
    private bool 上丌丆万与丌丌丑丘;
    private string 下丏丙七丏丙丄七世;
    private Rilisoft.丝丑丂丛万丐丈丘且 上丝丂丘一丅丄丆七;
    private Rilisoft.丝丑丂丛万丐丈丘且 丞丘不上万与丘丙且;
    private Rilisoft.丝丑丂丛万丐丈丘且 不丛丂丟丞七丈东丌;
    private UnityEngine.GameObject 丏丁丒丞万丏丑丗不;
    private UnityEngine.GameObject 与丝丈丑丝丕丘丏丅;
    private UnityEngine.AudioClip 丕丅一丆丂丞丝丑丐;
    public bool bossShowm;
    public float curInterval;
    internal int 丘丂丄丗丙丅丈丏下;
    public UnityEngine.GUIStyle labelStyle;
    public bool stopGeneratingBonuses;
    private int 下丑与丐丂丟世丒丘;
    public System.Collections.Generic.List<UnityEngine.GameObject> waveZombiePrefabs;
    public UnityEngine.GameObject weaponBonus;
    public System.Collections.Generic.List<UnityEngine.GameObject> zombiePrefabs;
    private UnityEngine.GameObject[] <丝丂丆七丁丐专丗丒>k__BackingField;
    private UnityEngine.GameObject[] <七与丂东丑丏不丂丏>k__BackingField;
    private static System.Action 丟丁丝丕业三不丁世;
    private static System.Action 丞七丗业丌丛丗丞丒;
    private System.Collections.Generic.List<ZombieCreator.业世万且丐与丒丕丕> 丞丙东七丆丗东丁丒;
    
    // Properties
    internal UnityEngine.GameObject[] 业丆丟丙丂丂三丁东 { get; set; }
    internal UnityEngine.GameObject[] 丛专丝三下丏丛三丈 { get; set; }
    internal static int 上丘七丄万丂丐不专 { get; set; }
    internal static int 丌丄丑丌丁且丗丁丒 { get; }
    internal int 三七丆丗丘世丞丗且 { get; set; }
    internal bool 丒丆一上东丒七且丟 { get; }
    internal int 丗不世丛一丕丐丒东 { get; set; }
    internal static int 万丌业丏世丛丅业丒 { get; }
    
    // Methods
    private static ZombieCreator()
    {
        ZombieCreator.丞丈丟丒丂丞丏不丑 = 0;
        ZombieCreator.万丌丅七丛丆东丅不 = 45;
        ZombieCreator.且丁丙上与丝丌丐不 = new System.Collections.Generic.List<System.Collections.Generic.List<System.String>>();
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        if(val_2 != null)
        {
                val_2.Add(item:  "Enemy143_go");
        }
        else
        {
                val_2.Add(item:  "Enemy143_go");
        }
        
        val_2.Add(item:  "Enemy144_go");
        ZombieCreator.世丙专不七丘丕东丘 = val_2;
        ZombieCreator.东丆东不下丝丙丁丘 = new System.Collections.Generic.HashSet<System.String>();
        ZombieCreator.专不丈专丑丈不丕丑 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_5 = new System.Collections.Generic.List<System.Collections.Generic.List<System.String>>();
        ZombieCreator.丂下七丈丄丄东专丒 = val_5;
        ZombieCreator.上万丆七丙丙三丟专 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
        val_7.Add(item:  WeaponManager.丅丗丟丕丅下丆世丙());
        val_7.Add(item:  WeaponManager.丞丗丆丑三丈丆七丐());
        val_7.Add(item:  WeaponManager.上业丅丂丘不且丕丌());
        System.Collections.Generic.List<System.String> val_11 = new System.Collections.Generic.List<System.String>();
        val_11.Add(item:  WeaponManager.丂丝丁丐且丏丒丈丂());
        val_11.Add(item:  WeaponManager.丗三专丆专东丟世业());
        System.Collections.Generic.List<System.String> val_14 = new System.Collections.Generic.List<System.String>();
        val_14.Add(item:  WeaponManager.且丞丅丆世丝三丈上());
        val_14.Add(item:  WeaponManager.丕丑一三丅不七丝丅());
        System.Collections.Generic.List<System.String> val_17 = new System.Collections.Generic.List<System.String>();
        val_17.Add(item:  WeaponManager.七东丕世下丌一丘丐());
        System.Collections.Generic.List<System.String> val_19 = new System.Collections.Generic.List<System.String>();
        val_19.Add(item:  WeaponManager.丘丏丒丌丞与丙丙下());
        val_5.Add(item:  val_7);
        val_5.Add(item:  val_11);
        val_5.Add(item:  val_14);
        val_5.Add(item:  val_17);
        val_5.Add(item:  val_19);
    }
    private void 与丘丟丟丂一东世丅(UnityEngine.GameObject[] 丙业与丙丗丝不丈东)
    {
        this.<丝丂丆七丁丐专丗丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.GameObject[] 丏丒丏丂丞七丘丂丙()
    {
        return (UnityEngine.GameObject[])this.<丝丂丆七丁丐专丗丒>k__BackingField;
    }
    private void 丛万丕丘丘三与三专(UnityEngine.GameObject[] 丙业与丙丗丝不丈东)
    {
        this.<七与丂东丑丏不丂丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.GameObject[] 丒丏专丙世下丁三专()
    {
        return (UnityEngine.GameObject[])this.<七与丂东丑丏不丂丏>k__BackingField;
    }
    internal static int 与世丐一丂丗丆丈丏()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        if((1152921505292152896 & 1) != 0)
        {
                val_7 = null;
            val_6 = 1152921516376905760;
        }
        
        if((val_6 & 512) == 0)
        {
                return ZombieCreator.丌七不一丆业丑丂丘();
        }
        
        return ZombieCreator.丌七不一丆业丑丂丘();
    }
    internal static void 不丄与丌万万与丟东(int 丙业与丙丗丝不丈东)
    {
        null = null;
        ZombieCreator.一丞丏丛三业丌世丌 = 0;
    }
    internal static int 丌七不一丆业丑丂丘()
    {
        null = null;
        return (int)ZombieCreator.万丌丅七丛丆东丅不;
    }
    internal int 且世三丘丕丞丏万万()
    {
    
    }
    internal void 专东丒世且丞丝下丞(int 丙业与丙丗丝不丈东)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  丙业与丙丗丝不丈东);
        this.不丛丂丟丞七丈东丌 = val_1;
        mem[1152921539710616096] = val_1.上万三丆专丏丒丗业;
    }
    internal bool 丌万与丝丒世丅三丆()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_3;
        var val_4;
        val_3 = this.上丝丂丘一丅丄丆七;
        if(null == ZombieCreator.专丁且业专不丑东丏())
        {
                var val_2 = (this.bossShowm == false) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal int 丌丟且丛丄丒万丈丑()
    {
    
    }
    internal void 丂丟丑丂丁丝下与丒(int 丙业与丙丗丝不丈东)
    {
        int val_73;
        GotToNextLevel val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        UnityEngine.Object val_79;
        UnityEngine.Object val_80;
        var val_81;
        float val_82;
        var val_83;
        var val_84;
        float val_85;
        float val_86;
        float val_87;
        float val_88;
        var val_89;
        var val_90;
        var val_94;
        System.Action val_95;
        var val_96;
        var val_97;
        var val_98;
        var val_99;
        float val_101;
        float val_102;
        float val_103;
        var val_107;
        var val_108;
        System.Action val_109;
        var val_110;
        var val_111;
        var val_112;
        var val_113;
        var val_114;
        var val_115;
        var val_116;
        val_73 = 丙业与丙丗丝不丈东;
        val_74 = this;
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_75 = null;
            val_75 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == true)
        {
                return;
        }
        
        }
        
        if(GameConnect.万七丄丛丈丟专一丑() != false)
        {
                int val_73 = this.下丑与丐丂丟世丒丘;
            Rilisoft.丝丑丂丛万丐丈丘且 val_74 = this.不丛丂丟丞七丈东丌;
            val_73 = val_73 + 1;
            this.下丑与丐丂丟世丒丘 = val_73;
            val_74 = val_74 - 1;
            Rilisoft.丝丑丂丛万丐丈丘且 val_4 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_74);
            this.不丛丂丟丞七丈东丌 = val_4;
            mem[1152921539711058704] = val_4.上万三丆专丏丒丗业;
            return;
        }
        
        if(this.bossShowm == false)
        {
            goto label_11;
        }
        
        this.bossShowm = false;
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_17;
        }
        
        }
        
        int val_75 = this.下丑与丐丂丟世丒丘;
        Rilisoft.丝丑丂丛万丐丈丘且 val_76 = this.不丛丂丟丞七丈东丌;
        val_75 = val_75 + 1;
        this.下丑与丐丂丟世丒丘 = val_75;
        val_76 = val_76 - 1;
        Rilisoft.丝丑丂丛万丐丈丘且 val_7 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_76);
        this.不丛丂丟丞七丈东丌 = val_7;
        mem[1152921539711058704] = val_7.上万三丆专丏丒丗业;
        label_166:
        this.丕三丅与丗丞下上万();
        return;
        label_11:
        int val_8 = val_73 - this.上丝丂丘一丅丄丆七;
        Rilisoft.丝丑丂丛万丐丈丘且 val_9 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_73);
        int val_77 = this.下丑与丐丂丟世丒丘;
        this.上丝丂丘一丅丄丆七 = val_9;
        mem[1152921539711058672] = val_9.上万三丆专丏丒丗业;
        Rilisoft.丝丑丂丛万丐丈丘且 val_78 = this.不丛丂丟丞七丈东丌;
        val_77 = val_77 + val_8;
        this.下丑与丐丂丟世丒丘 = val_77;
        val_78 = val_78 - val_8;
        Rilisoft.丝丑丂丛万丐丈丘且 val_10 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_78);
        this.不丛丂丟丞七丈东丌 = val_10;
        mem[1152921539711058704] = val_10.上万三丆专丏丒丗业;
        if((GameConnect.丌专丌万一下丕专上() == true) || (GameConnect.万七丄丛丈丟专一丑() == true))
        {
            goto label_67;
        }
        
        val_76 = null;
        if((ZombieCreator.专丁且业专不丑东丏() - this.上丝丂丘一丅丄丆七) > 5)
        {
            goto label_67;
        }
        
        val_77 = null;
        val_77 = null;
        if(丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Count < 1)
        {
            goto label_67;
        }
        
        val_78 = null;
        val_78 = null;
        val_79 = 0;
        val_80 = 0;
        goto label_36;
        label_63:
        val_81 = null;
        val_81 = null;
        RilisoftBot.BaseBot val_17 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Item[0].GetComponent<RilisoftBot.BaseBot>();
        val_82 = val_17.health;
        if(val_82 > 0f)
        {
                val_83 = null;
            val_83 = null;
            UnityEngine.Vector3 val_19 = transform.position;
            val_84 = null;
            val_85 = val_19.z;
            val_84 = null;
            UnityEngine.Vector3 val_22 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Item[0].transform.position;
            val_82 = val_19.x;
            val_86 = val_19.y;
            val_87 = val_85;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_82, y = val_86, z = val_87}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            val_88 = val_23.x;
            if(val_88 < 0)
        {
                val_89 = null;
            val_89 = null;
            val_80 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Item[0].transform;
        }
        
        }
        
        val_79 = 1;
        label_36:
        val_90 = null;
        val_90 = null;
        if(val_79 < 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Count)
        {
            goto label_63;
        }
        
        typeof(Player_move_c).__il2cppRuntimeField_168.一专丘东三丞东丁三();
        if(val_80 == 0)
        {
            goto label_67;
        }
        
        val_79 = val_80.gameObject.GetComponentInChildren<UnityEngine.BoxCollider>();
        if(val_79 == 0)
        {
            goto label_72;
        }
        
        UnityEngine.Vector3 val_31 = val_79.center;
        goto label_74;
        label_17:
        val_94 = null;
        val_94 = null;
        val_95 = ZombieCreator.丞七丗业丌丛丗丞丒;
        if(val_95 != null)
        {
                val_95 = ZombieCreator.丞七丗业丌丛丗丞丒;
            if(val_95 == null)
        {
                val_95 = 0;
        }
        
            val_95.Invoke();
        }
        
        val_96 = null;
        val_96 = null;
        val_73 = UnityEngine.Application.loadedLevelName;
        if((下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.ContainsKey(key:  val_73)) != false)
        {
                val_73 = 1152921505068720128;
            val_97 = null;
            val_97 = null;
            val_74 = GotToNextLevel.丄丘七三上丕世丞业;
            if(val_74 == 0)
        {
                return;
        }
        
            val_98 = null;
            val_98 = null;
            val_74 = GotToNextLevel.丄丘七三上丕世丞业.transform;
            if(val_74 == 0)
        {
                return;
        }
        
            val_99 = null;
            val_99 = null;
            val_73 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_73 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(typeof(Player_move_c).__il2cppRuntimeField_168 == 0)
        {
                return;
        }
        
            typeof(Player_move_c).__il2cppRuntimeField_168.一专丘东三丞东丁三();
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.up;
            val_101 = 0f;
            val_102 = val_38.x;
            val_103 = val_38.y;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Multiply(d:  val_101, a:  new UnityEngine.Vector3() {x = val_102, y = val_103, z = val_38.z});
        }
        else
        {
                this.丏丁丒丞万丏丑丗不.SetActive(value:  true);
            val_107 = null;
            val_107 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_168 == 0)
        {
                return;
        }
        
            typeof(Player_move_c).__il2cppRuntimeField_168.一专丘东三丞东丁三();
            UnityEngine.Transform val_41 = this.丏丁丒丞万丏丑丗不.transform;
            UnityEngine.GameObject val_42 = new UnityEngine.GameObject(name:  "Teleport Replacement");
            val_73 = val_42.transform;
            UnityEngine.Vector3 val_44 = val_41.position;
            val_79 = typeof(Player_move_c).__il2cppRuntimeField_168.七丒丝丗与东丆丞丂().transform;
            UnityEngine.Vector3 val_47 = val_79.position;
            UnityEngine.Vector3 val_48 = val_41.position;
            val_101 = 0f;
            val_102 = 0f;
            val_103 = 0f;
            val_73.position = new UnityEngine.Vector3() {x = val_101, y = val_102, z = val_103};
            val_74 = val_42.transform;
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.zero;
        }
        
        val_88 = val_50.x;
        val_85 = val_50.z;
        typeof(Player_move_c).__il2cppRuntimeField_168.丒丐丙业丘丄三丕丁(丞上世与丈业丒丕不:  val_74, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_88, y = val_50.y, z = val_85});
        return;
        label_72:
        UnityEngine.Vector3 val_51 = UnityEngine.Vector3.up;
        val_82 = 1.618f;
        val_86 = val_51.x;
        val_87 = val_51.y;
        UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Multiply(d:  val_82, a:  new UnityEngine.Vector3() {x = val_86, y = val_87, z = val_51.z});
        label_74:
        val_88 = val_52.x;
        val_85 = val_52.z;
        typeof(Player_move_c).__il2cppRuntimeField_168.一专丘东三丞东丁三();
        typeof(Player_move_c).__il2cppRuntimeField_168.丒丐丙业丘丄三丕丁(丞上世与丈业丒丕不:  val_80, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_88, y = val_52.y, z = val_85});
        label_67:
        if((GameConnect.丌专丌万一下丕专上() != true) && (GameConnect.万七丄丛丈丟专一丑() != true))
        {
                Rilisoft.丝丑丂丛万丐丈丘且 val_79 = this.丞丘不上万与丘丙且;
            val_79 = val_79 + val_8;
            Rilisoft.丝丑丂丛万丐丈丘且 val_55 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_79);
            this.丞丘不上万与丘丙且 = val_55;
            mem[1152921539711058688] = val_55.上万三丆专丏丒丗业;
            if(this.丞丘不上万与丘丙且 == 12)
        {
                float val_80 = this.curInterval;
            if(val_80 > 5f)
        {
                val_80 = val_80 + (-5f);
            this.curInterval = val_80;
        }
        
            Rilisoft.丝丑丂丛万丐丈丘且 val_56 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            this.丞丘不上万与丘丙且 = val_56;
            mem[1152921539711058688] = val_56.上万三丆专丏丒丗业;
        }
        
            if(this.丌万与丝丒世丅三丆() != false)
        {
                val_108 = null;
            val_108 = null;
            val_109 = ZombieCreator.丟丁丝丕业三不丁世;
            if(val_109 != null)
        {
                val_109 = ZombieCreator.丟丁丝丕业三不丁世;
            if(val_109 == null)
        {
                val_109 = 0;
        }
        
            val_109.Invoke();
        }
        
        }
        
        }
        
        if(GameConnect.丌专丌万一下丕专上() != false)
        {
                val_110 = this.上丝丂丘一丅丄丆七;
            if(val_110 == (ZombieCreator.专丁且业专不丑东丏() - 1))
        {
                this.stopGeneratingBonuses = true;
        }
        
        }
        
        val_111 = this.上丝丂丘一丅丄丆七;
        val_73 = 1152921505292148736;
        if(val_111 < ZombieCreator.专丁且业专不丑东丏())
        {
                return;
        }
        
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_162;
        }
        
        }
        
        val_112 = null;
        val_112 = null;
        val_73 = this.丘丂丄丗丙丅丈丏下;
        if((ZombieCreator.专不丈专丑丈不丕丑.ContainsKey(key:  val_73)) == false)
        {
            goto label_166;
        }
        
        this.丗不一东七三丗下丆();
        return;
        label_162:
        if(丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一() != 0)
        {
                this.丗不一东七三丗下丆();
            if(this.丕丅一丆丂丞丝丑丐 == 0)
        {
                return;
        }
        
            val_113 = null;
            val_113 = null;
            if(BackgroundMusicController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
            val_114 = null;
            val_114 = null;
            BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁().Stop();
            BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁().clip = this.丕丅一丆丂丞丝丑丐;
            val_115 = null;
            val_115 = null;
            if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == false)
        {
                return;
        }
        
            val_116 = null;
            val_116 = null;
            BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁().Play();
            return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                TrainingController.丛丒丝丅丞丁且业上(丏丘丙丆三丕丕上丌:  5);
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  19);
        }
        
        this.丏丁丒丞万丏丑丗不.SetActive(value:  true);
    }
    internal static int 专丁且业专不丑东丏()
    {
        if(GameConnect.丌专丌万一下丕专上() == true)
        {
                return ZombieCreator.与世丐一丂丗丆丈丏();
        }
        
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
                return 丟丌丁且且世丈丈丟.丆丂丆丂上丄下丒丒();
        }
        
        return ZombieCreator.与世丐一丂丗丆丈丏();
    }
    internal static void 东上不丝丌丗丂下丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ZombieCreator.丟丁丝丕业三不丁世, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ZombieCreator.丟丁丝丕业三不丁世 != 1152921505292152904);
    
    }
    internal static void 丟丙丅业丞丂上且丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ZombieCreator.丟丁丝丕业三不丁世, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ZombieCreator.丟丁丝丕业三不丁世 != 1152921505292152904);
    
    }
    private System.Collections.IEnumerator 上丁不丌丒丙三丐下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new ZombieCreator.七丘丕丌丐三且丂不();
    }
    private System.Collections.IEnumerator 且专七丂丛丆丂丅三(System.Action 丌专业且丛丏丞丝且)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丌专业且丛丏丞丝且 = 丌专业且丛丏丞丝且;
        return (System.Collections.IEnumerator)new ZombieCreator.丐丗丞丏丘丆业与不();
    }
    private void OnDestroy()
    {
        int val_8;
        var val_9;
        val_8 = this;
        val_9 = null;
        val_9 = null;
        ZombieCreator.丞丈丟丒丂丞丏不丑 = 0;
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
                return;
        }
        
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丑丗不东丏丑专丒丕(), value:  this.下丑与丐丂丟世丒丘);
        if(this.下丑与丐丂丟世丒丘 > (UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.一丌丝丏丒丞丁丞丟(), defaultValue:  0)))
        {
                UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.一丌丝丏丒丞丁丞丟(), value:  this.下丑与丐丂丟世丒丘);
        }
        
        WavesSurvivedStat.丑丛丗丂丞三业东业(丙业与丙丗丝不丈东:  this.丘丂丄丗丙丅丈丏下);
        val_8 = this.丘丂丄丗丙丅丈丏下;
        if(val_8 <= 与丂丏丛丞丞丒丟丄.丐三丂丅不丆业丕丅())
        {
                return;
        }
        
        与丂丏丛丞丞丒丟丄.丗万万丟世万与世上(丙业与丙丗丝不丈东:  val_8);
    }
    private void 专丛丞丈丘七丅丒丛()
    {
        float val_2;
        this.丙业七且东丞万业与 = 0;
        this.丐三且下丒丆丙不与 = 0;
        if(GameConnect.万七丄丛丈丟专一丑() != false)
        {
                val_2 = (float)this.且丒业丈七东七丘丗[this.丐三且下丒丆丙不与];
        }
        else
        {
                val_2 = this.timeForSpawnMobInClassicArena;
        }
        
        this.curInterval = val_2;
    }
    internal static void 丂专一万丛业与一丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ZombieCreator.丞七丗业丌丛丗丞丒, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ZombieCreator.丞七丗业丌丛丗丞丒 != 1152921505292152912);
    
    }
    internal static void 不丟丞三丘丆丟与丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ZombieCreator.丞七丗业丌丛丗丞丒, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ZombieCreator.丞七丗业丌丛丗丞丒 != 1152921505292152912);
    
    }
    private void 丙丙丄丒七不万丄丅()
    {
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        int val_5 = this.丘丂丄丗丙丅丈丏下;
        val_5 = val_5 + 1;
        this = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0349"), arg1:  val_5);
        InGameGUIPart_Arena.__il2cppRuntimeField_byval_arg.text = this;
    }
    private void 丕三丅与丗丞下上万()
    {
        UnityEngine.Object val_27;
        int val_1 = this.丘丂丄丗丙丅丈丏下 + 1;
        this.丘丂丄丗丙丅丈丏下 = val_1;
        Rilisoft.丞丛七上丕专丏丌丈.七万下丗丁与丒三三(丘丂丄丗丙丅丈丏下:  val_1);
        var val_24 = 0;
        val_24 = val_24 + 1;
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Clear();
        int val_25 = this.丘丂丄丗丙丅丈丏下;
        if(val_25 < 10)
        {
                val_25 = val_25 + 1;
            string val_7 = +val_25;
        }
        else
        {
                val_25 = val_25 >> 35;
            val_25 = val_25 + (val_25 << 2);
            val_25 = val_25 << 1;
            int val_26 = this.丘丂丄丗丙丅丈丏下;
            int val_8 = val_26 * 1717986919;
            val_8 = val_8 >> 34;
            val_8 = val_8 + (val_8 >> 63);
            val_8 = val_26 - (val_8 * 10);
            val_26 = val_26 + 9;
            val_26 = val_26 - val_8;
        }
        
        string val_11 = System.String.Format(format:  "{0}-{1}", arg0:  val_25, arg1:  val_26)(System.String.Format(format:  "{0}-{1}", arg0:  val_25, arg1:  val_26)) + " In game";
        var val_27 = 0;
        val_27 = val_27 + 1;
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Add(key:  null, value:  val_26);
        System.Action val_13 = new System.Action(object:  this, method:  System.Void ZombieCreator::丘丞丐东丆不丞丌丈());
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  val_13.且专七丂丛丆丂丅三(丌专业且丛丏丞丝且:  val_13));
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "Pizza")) != false)
        {
            
        }
        
        val_27 = Initializer.丕丛不丄丁丞丗且下(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丆丙丅丝七丒丐丙万:  1);
        if(val_27 == 0)
        {
                return;
        }
        
        CoinBonus val_20 = val_27.GetComponent<CoinBonus>();
        if(val_20 == 0)
        {
                object[] val_22 = new object[1];
            val_27 = val_22;
            val_27[0] = val_20.GetType();
            UnityEngine.Debug.LogErrorFormat(format:  "Cannot find component \'{0}\'", args:  val_22);
            return;
        }
        
        val_20.SetPlayer();
    }
    internal static void 世丙丆业世丝与丝七(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丁东丑丞与下丛丐东)
    {
        var val_4;
        var val_5;
        if(丝三丁东丈丒世丅业 == 0)
        {
                return;
        }
        
        val_5 = 0;
        goto label_5;
        label_10:
        val_4 = 丝三丁东丈丒世丅业.GetComponentsInChildren<UnityEngine.Transform>(includeInactive:  true)[0].gameObject;
        val_4.layer = 丁东丑丞与下丛丐东;
        val_5 = 1;
        label_5:
        if(val_5 < val_2.Length)
        {
            goto label_10;
        }
    
    }
    private System.Collections.IEnumerator 丐东专丆丛丅一世丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ZombieCreator.业三不七丞与丐丏丆();
    }
    private void 丅东丗丁丒且丅且丄(UnityEngine.GameObject 丗丕下上丟丑一专丁)
    {
        UnityEngine.GameObject[] val_8;
        this.<丝丂丆七丁丐专丗丒>k__BackingField = 0;
        if((RilisoftBot.BaseBot.丌丌且丏丟上丈丌世(万且万且丑丗且丌丆:  丗丕下上丟丑一专丁.transform)) == 0)
        {
                return;
        }
        
        val_8 = val_2.guards;
        if(val_2.guards.Length == 0)
        {
                return;
        }
        
        val_8 = val_2.guards.Length & 4294967295;
        this.<丝丂丆七丁丐专丗丒>k__BackingField = new UnityEngine.GameObject[0];
        if(val_2.guards.Length < 1)
        {
                return;
        }
        
        var val_14 = 4;
        label_27:
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_2.guards[0]);
        if((this.<丝丂丆七丁丐专丗丒>k__BackingField) == null)
        {
            goto label_15;
        }
        
        if(val_6 != null)
        {
            goto label_16;
        }
        
        goto label_19;
        label_15:
        if(val_6 == null)
        {
            goto label_19;
        }
        
        label_16:
        label_19:
        this.<丝丂丆七丁丐专丗丒>k__BackingField[0] = val_6;
        object val_7 = (val_14 - 4) + 1;
        this.<丝丂丆七丁丐专丗丒>k__BackingField[0].name = System.String.Format(format:  "{0}{1}", arg0:  "BossGuard", arg1:  val_7);
        this.<丝丂丆七丁丐专丗丒>k__BackingField[0].SetActive(value:  false);
        val_14 = val_14 + 1;
        if(((val_7 - 1) + 1) != val_8)
        {
            goto label_27;
        }
    
    }
    internal void 丏丗一丁万丗丟丐业(RilisoftBot.BaseBot 下丒丌万上与丙丑专)
    {
        UnityEngine.GameObject[] val_23;
        object val_24;
        UnityEngine.GameObject[] val_25;
        var val_26;
        var val_27;
        UnityEngine.GameObject val_28;
        float val_29;
        float val_30;
        var val_31;
        var val_32;
        if(下丒丌万上与丙丑专 == 0)
        {
                return;
        }
        
        if((this.<七与丂东丑丏不丂丏>k__BackingField) == null)
        {
                this.<七与丂东丑丏不丂丏>k__BackingField = new UnityEngine.GameObject[0];
        }
        
        this.丞丙东七丆丗东丁丒.Clear();
        val_24 = 1152921537034121936;
        val_25 = 1152921539713818864;
        val_26 = 0;
        goto label_8;
        label_24:
        val_27 = null;
        val_27 = null;
        val_28 = 丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Item[0].gameObject;
        EnemyCreationZone val_5 = 丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Item[0];
        UnityEngine.Vector3 val_6 = val_5.万东万丆专丌丕丐丗.position;
        val_29 = val_6.z;
        UnityEngine.Vector3 val_8 = 下丒丌万上与丙丑专.transform.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_29}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        val_30 = val_9.x;
        X22.Add(item:  new 业世万且丐与丒丕丕() {丟不丄不三不东业丆 = val_28, 东丂丕丄东与三丂丂 = val_30});
        val_26 = 1;
        label_8:
        val_31 = null;
        val_31 = null;
        if(val_26 < 丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Count)
        {
            goto label_24;
        }
        
        this.丞丙东七丆丗东丁丒.Sort(comparison:  new System.Comparison<业世万且丐与丒丕丕>(object:  0, method:  static System.Int32 ZombieCreator::丞万七七不丅丁丟丗(ZombieCreator.业世万且丐与丒丕丕 丆丛丑世下一丐且丕, ZombieCreator.业世万且丐与丒丕丕 丌丗丏丏丛东专丁且)));
        val_32 = 0;
        goto label_64;
        label_69:
        if((this.<七与丂东丑丏不丂丏>k__BackingField[0]) == 0)
        {
            goto label_31;
        }
        
        val_32 = 1;
        goto label_64;
        label_31:
        UnityEngine.GameObject val_13 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  下丒丌万上与丙丑专.spawnMobs[0]);
        if((this.<七与丂东丑丏不丂丏>k__BackingField) == null)
        {
            goto label_37;
        }
        
        if(val_13 != null)
        {
            goto label_38;
        }
        
        goto label_41;
        label_37:
        if(val_13 == null)
        {
            goto label_41;
        }
        
        label_38:
        label_41:
        this.<七与丂东丑丏不丂丏>k__BackingField[0] = val_13;
        val_24 = 1;
        this.<七与丂东丑丏不丂丏>k__BackingField[0].name = System.String.Format(format:  "{0}{1}", arg0:  "BossGuard", arg1:  val_24);
        val_25 = 下丒丌万上与丙丑专.spawnMobs;
        if(val_25 == null)
        {
            goto label_49;
        }
        
        label_66:
        val_28 = UnityEngine.Random.Range(min:  0, max:  UnityEngine.Mathf.Min(a:  下丒丌万上与丙丑专.spawnMobs.Length, b:  this.丞丙东七丆丗东丁丒.Count));
        业世万且丐与丒丕丕 val_19 = this.丞丙东七丆丗东丁丒.Item[val_28];
        UnityEngine.Vector3 val_20 = val_19.丟不丄不三不东业丆.丈丐七丙丗丅丁专丂(丟不丄不三不东业丆:  val_19.丟不丄不三不东业丆);
        this.<七与丂东丑丏不丂丏>k__BackingField[0].transform.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.identity;
        val_30 = val_22.x;
        val_29 = val_22.z;
        this.<七与丂东丑丏不丂丏>k__BackingField[0].transform.rotation = new UnityEngine.Quaternion() {x = val_30, y = val_22.y, z = val_29, w = val_22.w};
        this.<七与丂东丑丏不丂丏>k__BackingField[0].SetActive(value:  true);
        val_32 = val_24;
        goto label_64;
        label_49:
        if(this.丞丙东七丆丗东丁丒 != null)
        {
            goto label_66;
        }
        
        goto label_66;
        label_64:
        val_23 = 下丒丌万上与丙丑专.spawnMobs;
        if(val_32 < 下丒丌万上与丙丑专.spawnMobs.Length)
        {
            goto label_69;
        }
    
    }
    private static int 丞万七七不丅丁丟丗(ZombieCreator.业世万且丐与丒丕丕 丆丛丑世下一丐且丕, ZombieCreator.业世万且丐与丒丕丕 丌丗丏丏丛东专丁且)
    {
        if(丆丛丑世下一丐且丕.东丂丕丄东与三丂丂 >= 0)
        {
                return (int)(丆丛丑世下一丐且丕.东丂丕丄东与三丂丂 > 丌丗丏丏丛东专丁且.东丂丕丄东与三丂丂) ? 1 : 0;
        }
        
        return 0;
    }
    private void Awake()
    {
        int val_33;
        var val_37;
        ZombieCreator val_64;
        var val_65;
        var val_66;
        System.IFormatProvider val_67;
        var val_68;
        var val_70;
        var val_71;
        var val_72;
        int val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_79;
        var val_80;
        UnityEngine.GameObject val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        var val_89;
        val_64 = this;
        val_66 = 1152921505066536960;
        if(GameConnect.万七丄丛丈丟专一丑() != false)
        {
                ClassicArenaController val_3 = this.gameObject.AddComponent<ClassicArenaController>();
        }
        
        val_67 = System.Globalization.CultureInfo.InvariantCulture;
        string val_6 = System.String.Format(provider:  val_67, format:  "{0}.Awake()", arg0:  this.GetType());
        val_67 = 1152921505171275776;
        val_68 = 0;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                return;
        }
        
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_17;
        }
        
        }
        
        ZombieCreator.且丁丙上与丝丌丐不.Clear();
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "Pizza")) != false)
        {
                System.Collections.Generic.List<System.String> val_11 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_12 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_13 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_14 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_15 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_16 = new System.Collections.Generic.List<System.String>();
            null.Add(item:  "88");
            null.Add(item:  "85");
            null.Add(item:  "86");
            null.Add(item:  "85");
            null.Add(item:  "87");
            null.Add(item:  "82");
            null.Add(item:  "81");
            null.Add(item:  "88");
            null.Add(item:  "86");
            null.Add(item:  "82");
            null.Add(item:  "84");
            null.Add(item:  "81");
            null.Add(item:  "88");
            null.Add(item:  "87");
            null.Add(item:  "81");
            null.Add(item:  "82");
            null.Add(item:  "86");
            null.Add(item:  "80");
            null.Add(item:  "83");
            null.Add(item:  "87");
            null.Add(item:  "84");
            null.Add(item:  "81");
            null.Add(item:  "86");
            null.Add(item:  "88");
            null.Add(item:  "80");
            null.Add(item:  "83");
            null.Add(item:  "82");
            null.Add(item:  "84");
            null.Add(item:  "87");
            null.Add(item:  "81");
            null.Add(item:  "80");
            null.Add(item:  "83");
            null.Add(item:  "82");
            null.Add(item:  "84");
            null.Add(item:  "87");
            val_70 = null;
            val_70 = null;
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
        }
        else
        {
                System.Collections.Generic.List<System.String> val_17 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_18 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_19 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_20 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_21 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_22 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_23 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_24 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_25 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_26 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_27 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_28 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_29 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_30 = new System.Collections.Generic.List<System.String>();
            null.Add(item:  "1");
            null.Add(item:  "2");
            null.Add(item:  "15");
            null.Add(item:  "1");
            null.Add(item:  "2");
            null.Add(item:  "15");
            null.Add(item:  "77");
            null.Add(item:  "12");
            val_19.Add(item:  "3");
            val_19.Add(item:  "9");
            val_19.Add(item:  "10");
            val_19.Add(item:  "11");
            val_19.Add(item:  "12");
            val_19.Add(item:  "57");
            val_20.Add(item:  "49");
            val_20.Add(item:  "9");
            val_20.Add(item:  "24");
            val_20.Add(item:  "29");
            val_20.Add(item:  "38");
            val_20.Add(item:  "74");
            val_20.Add(item:  "48");
            val_20.Add(item:  "10");
            val_21.Add(item:  "80");
            val_21.Add(item:  "81");
            val_21.Add(item:  "82");
            val_21.Add(item:  "83");
            val_21.Add(item:  "84");
            val_21.Add(item:  "85");
            val_21.Add(item:  "86");
            val_21.Add(item:  "87");
            val_21.Add(item:  "88");
            val_22.Add(item:  "37");
            val_22.Add(item:  "46");
            val_22.Add(item:  "47");
            val_22.Add(item:  "57");
            val_22.Add(item:  "24");
            val_22.Add(item:  "74");
            val_22.Add(item:  "50");
            val_22.Add(item:  "20");
            val_22.Add(item:  "51");
            null.Add(item:  "74");
            null.Add(item:  "57");
            null.Add(item:  "20");
            null.Add(item:  "66");
            null.Add(item:  "60");
            null.Add(item:  "50");
            null.Add(item:  "53");
            null.Add(item:  "33");
            null.Add(item:  "24");
            null.Add(item:  "46");
            null.Add(item:  "74");
            null.Add(item:  "57");
            null.Add(item:  "49");
            null.Add(item:  "66");
            null.Add(item:  "60");
            null.Add(item:  "50");
            null.Add(item:  "50");
            null.Add(item:  "59");
            null.Add(item:  "24");
            null.Add(item:  "46");
            null.Add(item:  "21");
            null.Add(item:  "22");
            null.Add(item:  "53");
            null.Add(item:  "75");
            null.Add(item:  "50");
            null.Add(item:  "17");
            null.Add(item:  "73");
            null.Add(item:  "6");
            null.Add(item:  "49");
            null.Add(item:  "79");
            val_26.Add(item:  "59");
            val_26.Add(item:  "60");
            val_26.Add(item:  "62");
            val_26.Add(item:  "54");
            val_26.Add(item:  "55");
            val_26.Add(item:  "56");
            val_26.Add(item:  "74");
            val_26.Add(item:  "75");
            val_26.Add(item:  "53");
            null.Add(item:  "58");
            null.Add(item:  "64");
            null.Add(item:  "65");
            null.Add(item:  "74");
            null.Add(item:  "57");
            null.Add(item:  "20");
            null.Add(item:  "66");
            null.Add(item:  "60");
            null.Add(item:  "50");
            null.Add(item:  "53");
            null.Add(item:  "33");
            null.Add(item:  "24");
            null.Add(item:  "46");
            null.Add(item:  "74");
            null.Add(item:  "57");
            null.Add(item:  "49");
            null.Add(item:  "66");
            null.Add(item:  "60");
            null.Add(item:  "50");
            null.Add(item:  "53");
            null.Add(item:  "59");
            null.Add(item:  "24");
            null.Add(item:  "46");
            null.Add(item:  "21");
            null.Add(item:  "22");
            null.Add(item:  "53");
            null.Add(item:  "75");
            null.Add(item:  "50");
            null.Add(item:  "17");
            null.Add(item:  "73");
            null.Add(item:  "6");
            null.Add(item:  "49");
            null.Add(item:  "79");
            val_71 = null;
            val_71 = null;
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  val_19);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  val_20);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  val_21);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  val_22);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  val_26);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
            ZombieCreator.且丁丙上与丝丌丐不.Add(item:  null);
        }
        
        val_72 = null;
        val_72 = null;
        List.Enumerator<T> val_31 = ZombieCreator.且丁丙上与丝丌丐不.GetEnumerator();
        val_73 = 1152921519126358176;
        val_67 = 0;
        val_74 = 0;
        var val_63 = 0;
        label_213:
        if((748563584 & 1) == 0)
        {
            goto label_198;
        }
        
        List.Enumerator<T> val_35 = val_33.丐丏七丌丕丗业且上().GetEnumerator();
        label_204:
        if((748563552 & 1) == 0)
        {
            goto label_200;
        }
        
        val_75 = null;
        val_75 = null;
        bool val_39 = ZombieCreator.东丆东不下丝丙丁丘.Add(item:  val_37.丐丏七丌丕丗业且上());
        goto label_204;
        label_200:
        val_63 = val_63 + 1;
        val_76 = val_74;
        mem2[0] = 2328;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_63 == 1) || ((2671 + ((0 + 1)) << 2) != 2328))
        {
            goto label_210;
        }
        
        var val_64 = 0;
        val_64 = val_64 ^ (val_63 >> 31);
        val_63 = val_63 + val_64;
        goto label_213;
        label_210:
        if( == 0)
        {
            goto label_213;
        }
        
        goto label_213;
        label_17:
        val_67 = 0;
        val_74 = 0;
        val_79 = 0;
        goto label_413;
        label_198:
        val_65 = 2671;
        val_79 = val_63 + 1;
        mem2[0] = 2353;
        val_64 = val_64;
        val_66 = 1152921505066536960;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && ( == 2353))
        {
                var val_65 = 0;
            val_65 = val_65 ^ 0;
            val_79 =  + val_65;
        }
        else
        {
                if( != 0)
        {
                val_67 = 0;
            val_74 = 0;
        }
        else
        {
                val_67 = 0;
        }
        
        }
        
        label_413:
        mem[1152921539715161256] = 0;
        val_80 = null;
        val_80 = null;
        ZombieCreator.丞丈丟丒丂丞丏不丑 = ;
        if(((GameConnect.丌专丌万一下丕专上() != true) && (GameConnect.万七丄丛丈丟专一丑() != true)) && (丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一() != 0))
        {
                val_33 = 丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一();
            UnityEngine.Object val_47 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Bosses", 丌丗丏丏丛东专丁且:  "Boss" + val_33)));
            if(val_47 != null)
        {
                var val_48 = (null == null) ? (val_47) : 0;
        }
        else
        {
                val_81 = 0;
        }
        
            mem[1152921539715161216] = val_81;
            this.丅东丗丁丒且丅且丄(丗丕下上丟丑一专丁:  val_81);
            mem[1152921539715161216].SetActive(value:  false);
            val_73 = 1152921505226227712;
            val_82 = null;
            val_82 = null;
            if((下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.ContainsKey(key:  UnityEngine.Application.loadedLevelName)) != false)
        {
                val_83 = null;
            val_83 = null;
            mem[1152921539715161272] = BonusCreator.东丒丌丘丛丟七丙上(丆与丕丕丂下丟一丈:  下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.Item[UnityEngine.Application.loadedLevelName]);
        }
        
            UnityEngine.Coroutine val_55 = this.StartCoroutine(routine:  this.丐东专丆丛丅一世丐());
            UnityEngine.Object val_56 = UnityEngine.Resources.Load(path:  "Snd/boss_campaign");
            if(val_56 != null)
        {
                var val_57 = (null == null) ? (val_56) : 0;
        }
        else
        {
                val_84 = 0;
        }
        
            mem[1152921539715161224] = val_84;
        }
        
        val_85 = null;
        val_85 = null;
        丟丌丁且且世丈丈丟.丛丄丛丒丗丑丅丌世 = 丟丌丁且且世丈丈丟.丅专丛世与东七七丁;
        this.七一丂且下一丄丅丕();
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_450;
        }
        
        }
        
        this.丈世丕丐丁丑丘万丛();
        label_450:
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_86 = null;
            val_87 = 1152921505171275776;
            val_86 = null;
            val_87 = 1152921505171275776;
            val_88 = null;
            val_73 = 与丂丏丛丞丞丒丟丄.一丗丈丛丌专专世世;
            Rilisoft.一丟专且三万丞丁丂.万丒三丟业专丈不丁(丞与世丏丌东丞一下:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 下丛不丕七且三一丆:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, 丐丞与丐世丗与下丗:  val_73, 丄上七业丒与丙三下:  true);
        }
        
        val_89 = null;
        val_89 = null;
        ZombieCreator.上万丆七丙丙三丟专.Clear();
        this.世与不上三丕丞丘丑();
        this.专丛丞丈丘七丅丒丛();
        System.Collections.IEnumerator val_61 = this.上丁不丌丒丙三丐下();
        val_68 =  + 1;
        mem2[0] = 2671;
        if(val_68 != 1)
        {
                if((val_65 + ((val_68 + 1)) << 2) == 2671)
        {
                return;
        }
        
        }
        
        if( == null)
        {
                return;
        }
    
    }
    private void 丈世丕丐丁丑丘万丛()
    {
        var val_4;
        var val_22;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        int val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_22 = this;
        this.waveZombiePrefabs.Clear();
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_19;
        }
        
        List.Enumerator<T> val_2 = this.zombiePrefabs.GetEnumerator();
        val_24 = 1152921505292148736;
        val_25 = 1152921519068975536;
        label_13:
        if((748904992 & 1) == 0)
        {
            goto label_29;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        val_26 = null;
        val_26 = null;
        if((ZombieCreator.世丙专不七丘丕东丘.Contains(item:  val_5.name)) == false)
        {
            goto label_13;
        }
        
        this.waveZombiePrefabs.Add(item:  val_5);
        goto label_13;
        label_19:
        val_24 = 1152921505292148736;
        val_27 = null;
        val_27 = null;
        if(this.丘丂丄丗丙丅丈丏下 < ZombieCreator.且丁丙上与丝丌丐不.Count)
        {
                val_28 = this.丘丂丄丗丙丅丈丏下;
        }
        else
        {
                val_29 = null;
            val_29 = null;
            val_28 = ZombieCreator.且丁丙上与丝丌丐不.Count - 1;
        }
        
        List.Enumerator<T> val_10 = this.zombiePrefabs.GetEnumerator();
        val_25 = 1152921519068956112;
        label_44:
        if((748904992 & 1) == 0)
        {
            goto label_29;
        }
        
        string val_11 = val_4.丐丏七丌丕丗业且上();
        val_30 = "Enemy";
        if("Enemy" == null)
        {
                val_30 = "Enemy";
        }
        
        val_31 = "Enemy";
        if("Enemy" == null)
        {
                val_31 = "Enemy";
        }
        
        val_32 = null;
        val_32 = null;
        if((ZombieCreator.且丁丙上与丝丌丐不.Item[val_28].Contains(item:  val_11.name.Substring(startIndex:  Length).Substring(startIndex:  0, length:  val_11.name.Substring(startIndex:  Length).IndexOf(value:  "_")))) == false)
        {
            goto label_44;
        }
        
        this.waveZombiePrefabs.Add(item:  val_11);
        goto label_44;
        label_29:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 世与不上三丕丞丘丑()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        if(this.丘丂丄丗丙丅丈丏下 >= ZombieCreator.丂下七丈丄丄东专丒.Count)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_5 = ZombieCreator.丂下七丈丄丄东专丒.Item[this.丘丂丄丗丙丅丈丏下];
        List.Enumerator<T> val_3 = val_5.GetEnumerator();
        label_13:
        if((749082568 & 1) == 0)
        {
            goto label_9;
        }
        
        val_8 = null;
        val_8 = null;
        ZombieCreator.上万丆七丙丙三丟专.Add(item:  0.丐丏七丌丕丗业且上());
        goto label_13;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 七一丂且下一丄丅丕()
    {
        var val_7;
        System.Collections.Generic.List<System.String> val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        UnityEngine.GameObject val_23;
        this.zombiePrefabs.Clear();
        val_18 = 1152921505066536960;
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_7;
        }
        
        }
        
        val_19 = null;
        val_19 = null;
        label_31:
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_37;
        }
        
        val_20 = null;
        val_20 = null;
        val_18 = ZombieCreator.世丙专不七丘丕东丘;
        List.Enumerator<T> val_5 = val_18.GetEnumerator();
        val_21 = 1152921519126358176;
        val_22 = "Enemies/";
        label_20:
        if((749317424 & 1) == 0)
        {
            goto label_16;
        }
        
        UnityEngine.Object val_10 = UnityEngine.Resources.Load(path:  "Enemies/"("Enemies/") + val_7.丐丏七丌丕丗业且上());
        if(val_10 != null)
        {
                var val_11 = (null == null) ? (val_10) : 0;
        }
        else
        {
                val_23 = 0;
        }
        
        this.zombiePrefabs.Add(item:  val_23);
        goto label_20;
        label_7:
        if((丛丑且业丗世丈丙丌.丈丏与上丑丒专丈丕(丞世不丒下上上丝丑:  丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一())) == null)
        {
            goto label_25;
        }
        
        goto label_31;
        label_25:
        new string[1][0] = "1";
        goto label_31;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_37:
        val_22 = "_go";
        val_21 = 0;
        goto label_38;
        label_44:
        long val_18 = 0;
        UnityEngine.Object val_16 = UnityEngine.Resources.Load(path:  "Enemies/Enemy"("Enemies/Enemy") + System.Linq.Enumerable.ToArray<System.String>(source:  ZombieCreator.东丆东不下丝丙丁丘)[val_18](System.Linq.Enumerable.ToArray<System.String>(source:  ZombieCreator.东丆东不下丝丙丁丘)[val_18]) + "_go");
        if(val_16 != null)
        {
                val_18 = (null == null) ? (val_16) : 0;
        }
        else
        {
                val_18 = 0;
        }
        
        this.zombiePrefabs.Add(item:  val_18);
        val_21 = 1;
        label_38:
        if(val_21 < val_3.Length)
        {
            goto label_44;
        }
    
    }
    private void Start()
    {
        UnityEngine.GameObject val_21;
        var val_24;
        var val_25;
        var val_26;
        val_21 = this;
        if(GameConnect.丌专丌万一下丕专上() != false)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Clear();
            int val_22 = this.丘丂丄丗丙丅丈丏下;
            val_22 = val_22 + 1;
            string val_7 = val_22 + " In game";
            var val_23 = 0;
            val_23 = val_23 + 1;
            StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Add(key:  null, value:  null);
        }
        
        float val_24 = 50f;
        val_24 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_24;
        this.labelStyle.fontSize = UnityEngine.Mathf.RoundToInt(f:  val_24);
        this.labelStyle.font = 丟丏下丂七三下丗丕.三万丁丂万丆丅下丟(专万与丁丈丐丑丛且:  "Key_04B_03");
        this.上丌丆万与丌丌丑丘 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        val_24 = 1152921505068720128;
        val_25 = null;
        val_25 = null;
        if(GotToNextLevel.丄丘七三上丕世丞业 != 0)
        {
                val_26 = null;
            val_26 = null;
            UnityEngine.GameObject val_13 = GotToNextLevel.丄丘七三上丕世丞业.gameObject;
            this.丏丁丒丞万丏丑丗不 = val_13;
            val_13.SetActive(value:  false);
        }
        
        if((this.上丌丆万与丌丌丑丘 != true) && (GameConnect.丌专丌万一下丕专上() != true))
        {
                if(GameConnect.万七丄丛丈丟专一丑() != true)
        {
                this.丕七丙丆七丅且丒丝();
        }
        
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
                return;
        }
        
        val_24 = 1152921505169678336;
        if((丛丑且业丗世丈丙丌.丈丏与上丑丒专丈丕(丞世不丒下上上丝丑:  丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一())) == null)
        {
                return;
        }
        
        丒丟丏丙丌丅丛丑下 val_20 = 丛丑且业丗世丈丙丌.丈丏与上丑丒专丈丕(丞世不丒下上上丝丑:  丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一());
        if(val_20.且丗万一丈丄专丌不 != 0)
        {
                return;
        }
        
        val_21 = this.丏丁丒丞万丏丑丗不;
        val_21.SetActive(value:  true);
    }
    private void 丕七丙丆七丅且丒丝()
    {
        this.curInterval = UnityEngine.Mathf.Max(a:  1f, b:  this.curInterval);
    }
    internal void 丙丙丟丄丘万丟上不()
    {
        var val_12;
        var val_13;
        if(UnityEngine.Application.isEditor != false)
        {
                if(GameConnect.丌专丌万一下丕专上() != false)
        {
                val_12 = null;
            val_12 = null;
            int val_4 = 与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length;
            val_4 = 与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - (val_4 * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length);
            System.String[] val_5 = 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与 + (((long)(int)(与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - ((与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length) * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length))) << 3);
            if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  (与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与 + ((long)(int)(与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - ((与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length) * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length))) << 3) + 32)) == false)
        {
                return;
        }
        
        }
        
        }
        
        if(GameConnect.丌专丌万一下丕专上() != false)
        {
                this.丙丙丄丒七不万丄丅();
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_13 = null;
            val_13 = null;
            if((System.String.op_Inequality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.丘上丑丑一与三丙丈());
    }
    internal static int 东丐丄七丆三且丕万(string 专万丟三世业丙丈且)
    {
        if(GameConnect.丌专丌万一下丕专上() == true)
        {
                return ZombieCreator.与世丐一丂丗丆丈丏();
        }
        
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
                return 丟丌丁且且世丈丈丟.东丐丄七丆三且丕万(专万丟三世业丙丈且:  专万丟三世业丙丈且);
        }
        
        return ZombieCreator.与世丐一丂丗丆丈丏();
    }
    internal static int 一世丟丄丂一丐丕丏()
    {
        null = null;
        if((丛丑且业丗世丈丙丌.丈丏与上丑丒专丈丕(下丛不丕七且三一丆:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) == null)
        {
                return 丟丌丁且且世丈丈丟.丞丒丕丆丆三丛丛丞();
        }
        
        return (int)val_1.且丗万一丈丄专丌不;
    }
    private System.Collections.IEnumerator 丘上丑丑一与三丙丈()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ZombieCreator.且万业业丅丌丂且丟();
    }
    private UnityEngine.Vector3 丈丐七丙丗丅丁专丂(UnityEngine.GameObject 丟不丄不三不东业丆)
    {
        UnityEngine.BoxCollider val_1 = 丟不丄不三不东业丆.GetComponent<UnityEngine.BoxCollider>();
        UnityEngine.Vector3 val_2 = val_1.size;
        UnityEngine.Vector3 val_4 = 丟不丄不三不东业丆.transform.localScale;
        UnityEngine.Vector3 val_5 = val_1.size;
        UnityEngine.Vector3 val_7 = 丟不丄不三不东业丆.transform.localScale;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_2.x * val_4.x, y:  val_5.z * val_7.z);
        UnityEngine.Vector3 val_12 = 丟不丄不三不东业丆.transform.position;
        UnityEngine.Vector3 val_14 = 丟不丄不三不东业丆.transform.position;
        float val_23 = 0.5f;
        float val_15 = val_10.x * val_23;
        val_15 = val_12.x - val_15;
        val_23 = val_10.y * val_23;
        val_23 = val_14.z - val_23;
        float val_16 = 0.x;
        UnityEngine.Vector3 val_19 = 丟不丄不三不东业丆.transform.position;
        float val_21 = val_16 + (UnityEngine.Random.Range(min:  0f, max:  val_16));
        float val_22 = val_19.x + (UnityEngine.Random.Range(min:  0f, max:  val_19.x));
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 丘丅且东一万丙丏丟(UnityEngine.Vector3 丐世丂丁一丞不丒万)
    {
        UnityEngine.GameObject[] val_5;
        var val_6;
        val_5 = this.<丝丂丆七丁丐专丗丒>k__BackingField;
        if(val_5 == null)
        {
                return;
        }
        
        val_6 = 0;
        goto label_2;
        label_19:
        UnityEngine.Vector3 val_2 = RilisoftBot.BaseBot.不丂丏七丗不专丗丕(丐世丂丁一丞不丒万:  new UnityEngine.Vector3() {x = 丐世丂丁一丞不丒万.x, y = 丐世丂丁一丞不丒万.y, z = 丐世丂丁一丞不丒万.z});
        this.<丝丂丆七丁丐专丗丒>k__BackingField[0].transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        this.<丝丂丆七丁丐专丗丒>k__BackingField[0].transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        this.<丝丂丆七丁丐专丗丒>k__BackingField[0].SetActive(value:  true);
        val_5 = this.<丝丂丆七丁丐专丗丒>k__BackingField;
        val_6 = 1;
        label_2:
        if(val_6 < (this.<丝丂丆七丁丐专丗丒>k__BackingField.Length))
        {
            goto label_19;
        }
    
    }
    private void 丗不一东七三丗下丆()
    {
        int val_4;
        var val_46;
        UnityEngine.GameObject val_47;
        var val_48;
        float val_49;
        UnityEngine.Object val_50;
        var val_51;
        float val_52;
        float val_53;
        float val_55;
        float val_56;
        float val_57;
        float val_58;
        float val_59;
        var val_60;
        var val_61;
        var val_62;
        val_46 = null;
        val_46 = null;
        val_47 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_47 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if((UnityEngine.Object.op_Implicit(exists:  val_47)) == false)
        {
                return;
        }
        
        val_48 = null;
        val_48 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.GetEnumerator();
        val_49 = 225f;
        label_25:
        val_50 = 0;
        label_24:
        if((751173312 & 1) == 0)
        {
            goto label_10;
        }
        
        UnityEngine.Transform val_6 = transform;
        UnityEngine.Vector3 val_7 = val_6.position;
        UnityEngine.Vector3 val_8 = val_6.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        float val_10 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Transform val_11 = transform;
        UnityEngine.Vector3 val_12 = val_11.position;
        UnityEngine.Vector3 val_13 = val_11.position;
        if(((val_10 <= val_49) || (val_10 >= 0)) || ((System.Math.Abs(val_12.y - val_13.y)) >= 0))
        {
            goto label_24;
        }
        
        UnityEngine.GameObject val_15 = val_4.丐丏七丌丕丗业且上().gameObject;
        goto label_25;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((UnityEngine.Object.op_Implicit(exists:  val_50)) != true)
        {
                val_51 = null;
            val_51 = null;
            UnityEngine.GameObject val_18 = 丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Item[0].gameObject;
            val_50 = val_18;
        }
        
        UnityEngine.Vector3 val_19 = val_18.丈丐七丙丗丅丁专丂(丟不丄不三不东业丆:  val_50);
        val_52 = val_19.y;
        val_53 = val_19.z;
        if(this.与丝丈丑丝丕丘丏丅 == 0)
        {
            goto label_49;
        }
        
        this.与丝丈丑丝丕丘丏丅.transform.position = new UnityEngine.Vector3() {x = val_19.x, y = val_52, z = val_53};
        UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.identity;
        val_55 = val_23.y;
        val_49 = val_23.w;
        val_56 = val_49;
        this.与丝丈丑丝丕丘丏丅.transform.rotation = new UnityEngine.Quaternion() {x = val_23.x, y = val_55, z = val_23.z, w = val_56};
        this.与丝丈丑丝丕丘丏丅.SetActive(value:  true);
        val_57 = val_19.x;
        val_58 = val_52;
        val_59 = val_53;
        this.丘丅且东一万丙丏丟(丐世丂丁一丞不丒万:  new UnityEngine.Vector3() {x = val_57, y = val_58, z = val_59});
        goto label_64;
        label_49:
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_64;
        }
        
        val_60 = null;
        val_60 = null;
        val_47 = this.丘丂丄丗丙丅丈丏下;
        if((ZombieCreator.专不丈专丑丈不丕丑.ContainsKey(key:  val_47)) == false)
        {
            goto label_64;
        }
        
        val_61 = null;
        val_61 = null;
        val_47 = this.丘丂丄丗丙丅丈丏下;
        val_4 = ZombieCreator.专不丈专丑丈不丕丑.Item[val_47];
        UnityEngine.Object val_30 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Bosses", 丌丗丏丏丛东专丁且:  "Boss" + val_4)));
        if(val_30 != null)
        {
                if(null == null)
        {
            goto label_73;
        }
        
        }
        
        this.与丝丈丑丝丕丘丏丅 = 0;
        goto label_74;
        label_73:
        this.与丝丈丑丝丕丘丏丅 = val_30;
        label_74:
        val_30.transform.position = new UnityEngine.Vector3() {x = val_19.x, y = val_52, z = val_53};
        UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.identity;
        val_52 = val_33.x;
        val_53 = val_33.z;
        val_57 = val_52;
        val_58 = val_33.y;
        val_59 = val_53;
        val_56 = val_33.w;
        this.与丝丈丑丝丕丘丏丅.transform.rotation = new UnityEngine.Quaternion() {x = val_57, y = val_58, z = val_59, w = val_56};
        label_64:
        if((this.与丝丈丑丝丕丘丏丅 != 0) && (GameConnect.丌专丌万一下丕专上() != true))
        {
                val_62 = null;
            val_62 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_168 != 0)
        {
                UnityEngine.BoxCollider val_38 = this.与丝丈丑丝丕丘丏丅.gameObject.GetComponentInChildren<UnityEngine.BoxCollider>();
            if(val_38 != 0)
        {
                UnityEngine.Vector3 val_40 = val_38.center;
        }
        else
        {
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.up;
            val_57 = 1.618f;
            val_58 = val_41.x;
            val_59 = val_41.y;
            val_56 = val_41.z;
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Multiply(d:  val_57, a:  new UnityEngine.Vector3() {x = val_58, y = val_59, z = val_56});
        }
        
            val_52 = val_42.x;
            val_53 = val_42.z;
            typeof(Player_move_c).__il2cppRuntimeField_168.一专丘东三丞东丁三();
            val_47 = this.与丝丈丑丝丕丘丏丅.transform;
            UnityEngine.Color val_44 = UnityEngine.Color.red;
            val_55 = val_44.g;
            val_49 = val_44.a;
            typeof(Player_move_c).__il2cppRuntimeField_168.丒丐丙业丘丄三丕丁(丞上世与丈业丒丕不:  val_47, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_52, y = val_42.y, z = val_53}, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_44.r, g = val_55, b = val_44.b, a = val_49});
        }
        
        }
        
        this.与丝丈丑丝丕丘丏丅 = 0;
        this.bossShowm = true;
    }
    public ZombieCreator()
    {
        this.三东丙万丝丟丛丅丏 = new System.Collections.Generic.List<System.String[]>();
        this.且丒业丈七东七丘丗 = new int[3] {6, 4, 3};
        this.timeForSpawnMobInClassicArena = 6f;
        this.下丏丙七丏丙丄七世 = "";
        Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this.上丝丂丘一丅丄丆七 = val_3;
        mem[1152921539718015072] = val_3.上万三丆专丏丒丗业;
        Rilisoft.丝丑丂丛万丐丈丘且 val_4 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this.丞丘不上万与丘丙且 = val_4;
        mem[1152921539718015088] = val_4.上万三丆专丏丒丗业;
        Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this.不丛丂丟丞七丈东丌 = val_5;
        mem[1152921539718015104] = val_5.上万三丆专丏丒丗业;
        this.curInterval = 10f;
        this.waveZombiePrefabs = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.zombiePrefabs = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.丞丙东七丆丗东丁丒 = new System.Collections.Generic.List<业世万且丐与丒丕丕>();
    }
    private void 丘丞丐东丆不丞丌丈()
    {
        this.专丛丞丈丘七丅丒丛();
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this.上丝丂丘一丅丄丆七 = val_1;
        mem[1152921539718147584] = val_1.上万三丆专丏丒丗业;
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this.丞丘不上万与丘丙且 = val_2;
        mem[1152921539718147600] = val_2.上万三丆专丏丒丗业;
        this.丈世丕丐丁丑丘万丛();
        this.世与不上三丕丞丘丑();
        this.丒丗丟丄丕丘三丗丏 = false;
        this.stopGeneratingBonuses = false;
        this.丙丙丄丒七不万丄丅();
    }

}
