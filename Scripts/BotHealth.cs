using UnityEngine;
public sealed class BotHealth : MonoBehaviour
{
    // Fields
    internal static bool 专丛丁下丝下与万不;
    private static SkinsManagerPixlGun 丛丅东丟丞下下丐丒;
    private bool 上丕丂一丗丁丗丞丄;
    private UnityEngine.GameObject 丐丒丅丗丏上一丏丅;
    private UnityEngine.Texture 丑丄丅丟丙丛丒丑丅;
    private Sounds 丁一世丈下上与丅七;
    private bool 丌丅丆专丐丁丛丏丗;
    private BotAI 下上丐东丛丗丐且丑;
    private Player_move_c 东丌七丘丂丄丘丈万;
    public UnityEngine.Texture hitTexture;
    private bool 丁一丗专丂丏且世丈;
    public string myName;
    
    // Methods
    private System.Collections.IEnumerator 一丏上不一上万丄丅(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new BotHealth.丒一三丙丘丙与一三();
    }
    public bool RequestPlayHurt(float 七且丆丞丌丘下世丑)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(BotHealth.专丛丁下丝下与万不 != false)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  一丏上不一上万丄丅(七且丆丞丌丘下世丑:  七且丆丞丌丘下世丑));
        val_4 = 1;
        return (bool)val_4;
    }
    private void Awake()
    {
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void Start()
    {
        var val_32;
        ZombieCreator val_33;
        var val_35;
        Sounds val_36;
        float val_37;
        Sounds val_38;
        float val_39;
        Sounds val_40;
        float val_41;
        var val_42;
        Sounds val_43;
        float val_44;
        Sounds val_45;
        float val_46;
        Sounds val_47;
        var val_48;
        Sounds val_49;
        float val_50;
        Sounds val_51;
        float val_52;
        Sounds val_53;
        float val_54;
        var val_55;
        Sounds val_56;
        float val_57;
        float val_58;
        var val_59;
        Sounds val_60;
        System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
        var val_32 = 0;
        val_32 = val_32 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_33 = 0;
        val_33 = val_33 + 1;
        goto label_12;
        label_7:
        val_32 = 0;
        val_33 = 0;
        goto label_13;
        label_12:
        object val_6 = val_2.Current;
        val_32 = 0;
        val_33 = 0;
        this.丐丒丅丗丏上一丏丅 = 0.gameObject;
        label_13:
        if(val_2 != null)
        {
                var val_34 = 0;
            val_34 = val_34 + 1;
            val_2.Dispose();
        }
        
        if(val_32 == 1)
        {
            goto label_22;
        }
        
        if((val_33 == 0) || (67 == 67))
        {
            goto label_36;
        }
        
        label_35:
        label_36:
        this.丁一世丈下上与丅七 = this.丐丒丅丗丏上一丏丅.GetComponent<Sounds>();
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_72;
        }
        
        val_35 = null;
        val_35 = null;
        if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 != 0)
        {
            goto label_32;
        }
        
        val_36 = this.丁一世丈下上与丅七;
        if(val_36 == null)
        {
            goto label_33;
        }
        
        val_37 = this.丁一世丈下上与丅七.notAttackingSpeed;
        goto label_34;
        label_22:
        if(val_33 != 0)
        {
            goto label_35;
        }
        
        goto label_36;
        label_33:
        val_36 = 56;
        val_37 = 5.877482E-39f;
        label_34:
        mem[56] = val_37 * 0.75f;
        val_38 = this.丁一世丈下上与丅七;
        if(val_38 != null)
        {
                val_39 = this.丁一世丈下上与丅七.attackingSpeed;
        }
        else
        {
                val_38 = 60;
            val_39 = 2.479598E-39f;
        }
        
        mem[60] = val_39 * 0.75f;
        val_40 = this.丁一世丈下上与丅七;
        if(val_40 != null)
        {
                val_41 = this.丁一世丈下上与丅七.health;
        }
        else
        {
                val_40 = 64;
            val_41 = 1.401298E-45f;
        }
        
        float val_35 = 0.7f;
        val_35 = val_41 * val_35;
        mem[64] = val_35;
        label_32:
        val_42 = null;
        val_42 = null;
        if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 == 1)
        {
                val_43 = this.丁一世丈下上与丅七;
            if(val_43 != null)
        {
                val_44 = this.丁一世丈下上与丅七.notAttackingSpeed;
        }
        else
        {
                val_43 = 56;
            val_44 = mem[56];
        }
        
            mem[56] = val_44 * 0.85f;
            val_45 = this.丁一世丈下上与丅七;
            if(val_45 != null)
        {
                val_46 = this.丁一世丈下上与丅七.attackingSpeed;
        }
        else
        {
                val_45 = 60;
            val_46 = mem[60];
        }
        
            mem[60] = val_46 * 0.85f;
            val_47 = this.丁一世丈下上与丅七;
            if(val_47 != null)
        {
                val_41 = this.丁一世丈下上与丅七.health;
        }
        else
        {
                val_47 = 64;
            val_41 = mem[64];
        }
        
            float val_36 = 0.8f;
            val_36 = val_41 * val_36;
            mem[64] = val_36;
        }
        
        val_48 = null;
        val_48 = null;
        if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 == 2)
        {
                val_49 = this.丁一世丈下上与丅七;
            if(val_49 != null)
        {
                val_50 = this.丁一世丈下上与丅七.notAttackingSpeed;
        }
        else
        {
                val_49 = 56;
            val_50 = mem[56];
        }
        
            val_41 = 0.9f;
            mem[56] = val_50 * val_41;
            val_51 = this.丁一世丈下上与丅七;
            if(val_51 != null)
        {
                val_52 = this.丁一世丈下上与丅七.attackingSpeed;
        }
        else
        {
                val_51 = 60;
            val_52 = mem[60];
        }
        
            mem[60] = val_52 * val_41;
            val_53 = this.丁一世丈下上与丅七;
            if(val_53 != null)
        {
                val_54 = this.丁一世丈下上与丅七.health;
        }
        else
        {
                val_53 = 64;
            val_54 = mem[64];
        }
        
            mem[64] = val_54 * val_41;
        }
        
        val_55 = null;
        val_55 = null;
        val_33 = ZombieCreator.丞丈丟丒丂丞丏不丑;
        if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 >= 7)
        {
                val_56 = this.丁一世丈下上与丅七;
            if(val_56 != null)
        {
                val_57 = this.丁一世丈下上与丅七.notAttackingSpeed;
        }
        else
        {
                val_56 = 56;
            val_57 = mem[56];
        }
        
            val_41 = 1.25f;
            mem[56] = val_57 * val_41;
            val_33 = this.丁一世丈下上与丅七;
            if(val_33 != null)
        {
                val_58 = this.丁一世丈下上与丅七.attackingSpeed;
        }
        else
        {
                val_33 = 60;
            val_58 = mem[60];
        }
        
            mem[60] = val_58 * val_41;
        }
        
        val_59 = null;
        val_59 = null;
        if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 >= 9)
        {
                val_60 = this.丁一世丈下上与丅七;
            if(val_60 != null)
        {
                val_41 = this.丁一世丈下上与丅七.health;
        }
        else
        {
                val_60 = 64;
            val_41 = mem[64];
        }
        
            float val_37 = 1.25f;
            val_37 = val_41 * val_37;
            mem[64] = val_37;
        }
        
        label_72:
        this.下上丐东丛丗丐且丑 = this.GetComponent<BotAI>();
        this.东丌七丘丂丄丘丈万 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PlayerGun").GetComponent<Player_move_c>();
        if((this.gameObject.name.IndexOf(value:  "Boss")) != 1)
        {
                UnityEngine.Texture val_30 = this.丐丒丅丗丏上一丏丅.GetComponentInChildren<UnityEngine.Renderer>().material.mainTexture;
        }
        
        this.丑丄丅丟丙丛丒丑丅 = BotHealth.丈丈丕丆不丆丗东下(丝三丁东丈丒世丅业:  this.丐丒丅丗丏上一丏丅);
    }
    internal static UnityEngine.Texture 丈丈丕丆不丆丗东下(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        if((UnityEngine.Object.op_Implicit(exists:  BotHealth.丛丅东丟丞下下丐丒)) != true)
        {
                val_9 = null;
            val_9 = null;
            BotHealth.丛丅东丟丞下下丐丒 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "SkinsManager").GetComponent<SkinsManagerPixlGun>();
        }
        
        System.Collections.Hashtable val_8 = val_3.专丗丕丐七丅下七丟;
        val_10 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  null)) != true)
        {
                UnityEngine.Debug.Log(message:  "No skin: "("No skin: ") + BotHealth.丅世丝丂丅丅丐世七(丆丗丗三丗丌丒丂不:  丝三丁东丈丒世丅业.name)(BotHealth.丅世丝丂丅丅丐世七(丆丗丗三丗丌丒丂不:  丝三丁东丈丒世丅业.name)));
        }
        
        BotHealth.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  丝三丁东丈丒世丅业, 丐丅丁丂丐下丘世丄:  null);
        return (UnityEngine.Texture);
    }
    internal static string 丅世丝丂丅丅丐世七(string 丆丗丗三丗丌丒丂不)
    {
        string val_5 = 丆丗丗三丗丌丒丂不;
        if(GameConnect.丌专丌万一下丕专上() == true)
        {
                return (string)val_5;
        }
        
        if(PGCompany.丁东丌世与丕东丆上.丕丆万一丅丄业世丌() == false)
        {
                return val_5 + "_Level3";
        }
        
        val_5 = System.String.Format(format:  "{0}_Level{1}", arg0:  val_5 = 丆丗丗三丗丌丒丂不, arg1:  丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一());
        return (string)val_5;
    }
    internal static void 且丁丞业丝万丄三丗(UnityEngine.GameObject 万且万且丑丗且丌丆, UnityEngine.Texture 丐丅丁丂丐下丘世丄)
    {
        var val_23;
        var val_24;
        System.Collections.IEnumerator val_2 = 万且万且丑丗且丌丆.transform.GetEnumerator();
        goto label_33;
        label_40:
        var val_23 = 0;
        val_23 = val_23 + 1;
        object val_4 = val_2.Current;
        if((0.name.Equals(value:  "Ears")) != true)
        {
                if((UnityEngine.Object.op_Implicit(exists:  0.gameObject.GetComponent<UnityEngine.Renderer>())) != false)
        {
                if((UnityEngine.Object.op_Implicit(exists:  0.gameObject.GetComponent<UnityEngine.Renderer>().material)) != false)
        {
                0.gameObject.GetComponent<UnityEngine.Renderer>().material.mainTexture = 丐丅丁丂丐下丘世丄;
        }
        
        }
        
            UnityEngine.GameObject val_19 = 0.gameObject;
        }
        
        label_33:
        var val_24 = 0;
        val_24 = val_24 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_40;
        }
        
        val_23 = 0;
        val_24 = 0;
        if(val_2 != null)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private System.Collections.IEnumerator 且丅丛丗专丑丕七丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BotHealth.丏三不丈丙丈世丂丁();
    }
    private void 世丌不丂丐一丒丂丏()
    {
        var val_19;
        string val_20;
        var val_21;
        val_19 = null;
        val_19 = null;
        val_20 = UnityEngine.Application.loadedLevelName;
        if((下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.ContainsKey(key:  val_20)) == false)
        {
                return;
        }
        
        if((this.gameObject.name.Contains(value:  "Boss")) == false)
        {
                return;
        }
        
        if(this.丌丅丆专丐丁丛丏丗 == true)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        UnityEngine.Vector3 val_10 = this.gameObject.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        BotMovement val_12 = this.GetComponent<BotMovement>();
        val_20 = val_12._gameController.weaponBonus;
        if(val_20 != 0)
        {
                BotMovement val_14 = this.GetComponent<BotMovement>();
            UnityEngine.GameObject val_15 = BonusCreator.三丟七丑世世不与上(丂丈丗丄不丅丅丙丒:  val_14._gameController.weaponBonus, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        }
        
        GotToNextLevel val_17 = BonusCreator.下不三上与丂丅三世(丆与丕丕丂下丟一丈:  下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.Item[UnityEngine.Application.loadedLevelName], 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}).AddComponent<GotToNextLevel>();
        BotMovement val_18 = this.GetComponent<BotMovement>();
        val_18._gameController.weaponBonus = 0;
        this.丌丅丆专丐丁丛丏丗 = true;
    }
    public void adjustHealth(float 丝三不七丑丏一业丑, UnityEngine.Transform 丞下万上三丘上与专)
    {
        Sounds val_11;
        float val_12;
        UnityEngine.AudioClip val_13;
        if((丝三不七丑丏一业丑 < 0) && (this.上丕丂一丗丁丗丞丄 != true))
        {
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.且丅丛丗专丑丕七丕());
        }
        
        val_11 = this.丁一世丈下上与丅七;
        if(val_11 != null)
        {
                val_12 = this.丁一世丈下上与丅七.health;
        }
        else
        {
                val_11 = 64;
            val_12 = 1.401298E-45f;
        }
        
        丝三不七丑丏一业丑 = val_12 + 丝三不七丑丏一业丑;
        mem[64] = 丝三不七丑丏一业丑;
        if(this.丁一世丈下上与丅七.health < 0)
        {
                this.丁一世丈下上与丅七.health = 0f;
        }
        
        if(UnityEngine.Debug.isDebugBuild != true)
        {
                if(this.丁一世丈下上与丅七.health != 0f)
        {
            goto label_12;
        }
        
        }
        
        this.世丌不丂丐一丒丂丏();
        this.丁一丗专丂丏且世丈 = false;
        label_12:
        val_13 = this.丁一世丈下上与丅七.hurt;
        if((this.RequestPlayHurt(七且丆丞丌丘下世丑:  val_13.length)) != false)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_13 = this.GetComponent<UnityEngine.AudioSource>();
            val_13.PlayOneShot(clip:  this.丁一世丈下上与丅七.hurt);
        }
        
        }
        
        if((丞下万上三丘上与专.CompareTag(tag:  "Player")) == false)
        {
            goto label_22;
        }
        
        SkinName val_9 = 丞下万上三丘上与专.GetComponent<SkinName>();
        val_13 = val_9.playerMoveC;
        if(val_9.playerMoveC.万万一与丝业七专下 == false)
        {
            goto label_26;
        }
        
        label_22:
        if((丞下万上三丘上与专.CompareTag(tag:  "Turret")) == false)
        {
                return;
        }
        
        label_26:
        this.下上丐东丛丗丐且丑.SetTarget(与且且丑丌业丙与三:  丞下万上三丘上与专, 不专丁丌丌丌与丝世:  true);
    }
    public bool getIsLife()
    {
        return (bool)this.丁一丗专丂丏且世丈;
    }
    public BotHealth()
    {
        this.丁一丗专丂丏且世丈 = true;
        this.myName = "Bot";
    }
    private static BotHealth()
    {
    
    }

}
