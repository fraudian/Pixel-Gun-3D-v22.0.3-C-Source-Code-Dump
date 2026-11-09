using UnityEngine;
internal sealed class BonusCreator : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject[] bonusPrefabs;
    public float creationInterval;
    public float weaponCreationInterval;
    private bool 上丌丆万与丌丌丑丘;
    private System.Collections.ArrayList 丑上与且丏专万丝专;
    private System.Collections.ArrayList 丏丄万丐丙丕世丐丐;
    private WeaponManager 丐下丁三且丗上丈东;
    private ZombieCreator 丏丗与丝丗丈丌丛丝;
    private System.Collections.ArrayList 上七丆丞丁丟不丘上;
    
    // Methods
    private float 丐世丁丅丟丑七丂丟()
    {
        float val_4;
        var val_7;
        var val_8;
        val_4 = 0f;
        goto label_2;
        label_13:
        var val_6 = 0;
        val_6 = val_6 + 1;
        object val_2 = this.上七丆丞丁丟不丘上.Current;
        val_4 = val_4 + (1.152922E+18f);
        label_2:
        var val_7 = 0;
        val_7 = val_7 + 1;
        if(this.上七丆丞丁丟不丘上.MoveNext() == true)
        {
            goto label_13;
        }
        
        val_7 = 0;
        val_8 = 0;
        if(this.上七丆丞丁丟不丘上 != null)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            this.上七丆丞丁丟不丘上.Dispose();
        }
        
        if( != 1)
        {
                return (float)val_4;
        }
        
        if( == false)
        {
                return (float)val_4;
        }
        
        return (float)val_4;
    }
    private void Awake()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = this;
        if(GameConnect.丌专丌万一下丕专上() != false)
        {
                this.creationInterval = 9f;
            this.weaponCreationInterval = 15f;
        }
        
        val_7 = null;
        val_7 = null;
        this.上丌丆万与丌丌丑丘 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        List.Enumerator<T> val_3 = WeaponManager.丟丗丄业丘丗业丗七.丘一丄丕不专上三丅().GetEnumerator();
        label_14:
        if(((-562206456) & 1) == 0)
        {
            goto label_11;
        }
        
        int val_5 = 0.丐丏七丌丕丗业且上().丙丏丒丟东丄业七上();
        if(this.上七丆丞丁丟不丘上 != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void Start()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        this.丏丗与丝丗丈丌丛丝 = ZombieCreator.丞丈丟丒丂丞丏不丑;
        val_2 = null;
        val_2 = null;
        this.丐下丁三且丗上丈东 = WeaponManager.丟丗丄业丘丗业丗七;
    }
    internal void 丕下不东丌下丈丏下()
    {
        var val_11;
        if(UnityEngine.Application.isEditor != false)
        {
                if(GameConnect.丌专丌万一下丕专上() != false)
        {
                val_11 = null;
            val_11 = null;
            int val_4 = 与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length;
            val_4 = 与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - (val_4 * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length);
            System.String[] val_5 = 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与 + (((long)(int)(与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - ((与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length) * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length))) << 3);
            if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  (与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与 + ((long)(int)(与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - ((与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length) * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length))) << 3) + 32)) == false)
        {
                return;
        }
        
        }
        
        }
        
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
                return;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.三下丗万丆专丄且东().GetEnumerator());
    }
    internal void 丒丛世且丒万丅上丕(int 丏世丑万世一七丟丞, int 丌下丏丐丕丏不丗一, UnityEngine.Vector3 丙丆丗业丌丏业丒丝, UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
    {
        var val_2 = (丌下丏丐丕丏不丗一 == 8) ? 1 : 0;
        val_2 = val_2 << 1;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bonusPrefabs[((丌下丏丐丕丏不丗一 - 9) >= 2) ? (val_2) : (0 + 1)], position:  new UnityEngine.Vector3() {x = 丙丆丗业丌丏业丒丝.x, y = 丙丆丗业丌丏业丒丝.y, z = 丙丆丗业丌丏业丒丝.z}, rotation:  new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w});
        val_4.GetComponent<PhotonView>().viewID = 丏世丑万世一七丟丞;
        SettingBonus val_6 = val_4.GetComponent<SettingBonus>();
        val_6.typeOfMass = 丌下丏丐丕丏不丗一;
    }
    private int 三丝丒且丒不一丝丄(int 丁丅丈丌丟世丗丗丟)
    {
        if((丁丅丈丌丟世丗丗丟 - 9) >= 2)
        {
                return (int)((丁丅丈丌丟世丗丗丟 == 8) ? 1 : 0) << 1;
        }
        
        return 1;
    }
    private System.Collections.IEnumerable 三下丗万丆专丄且东()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new BonusCreator.且丛三丒东丂丘不业();
    }
    internal static UnityEngine.GameObject 东丒丌丘丛丟七丙上(string 丆与丕丕丂下丟一丈)
    {
        UnityEngine.Object val_4;
        string val_4 = 丆与丕丕丂下丟一丈;
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "Weapon_Bonuses/"("Weapon_Bonuses/") + val_4 + "_Bonus");
        if(val_2 != null)
        {
                val_4 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_4 = 0;
        }
        
        if(val_4 != 0)
        {
                return (UnityEngine.GameObject)val_4;
        }
        
        UnityEngine.Debug.Log(message:  "null");
        val_4 = 0;
        return (UnityEngine.GameObject)val_4;
    }
    internal static UnityEngine.GameObject 下不三上与丂丅三世(string 丆与丕丕丂下丟一丈, UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        UnityEngine.GameObject val_1 = BonusCreator.东丒丌丘丛丟七丙上(丆与丕丕丂下丟一丈:  丆与丕丕丂下丟一丈);
        if(val_1 != 0)
        {
                return BonusCreator.三丟七丑世世不与上(丂丈丗丄不丅丅丙丒:  val_1, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z});
        }
        
        UnityEngine.Debug.Log(message:  "null");
        return 0;
    }
    internal static UnityEngine.GameObject 三丟七丑世世不与上(UnityEngine.Object 丂丈丗丄不丅丅丙丒, UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        var val_3;
        var val_5;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        val_5 = UnityEngine.Object.Instantiate(original:  丂丈丗丄不丅丅丙丒, position:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
        if(val_5 == null)
        {
            goto label_5;
        }
        
        if(null == null)
        {
            goto label_6;
        }
        
        label_5:
        val_5 = 0;
        label_6:
        val_3 = 0;
        val_5.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return (UnityEngine.GameObject)val_5;
    }
    private int 丏丟丞与丂丈丝丙丟()
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return 丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一();
        }
        
        return 丟丌丁且且世丈丈丟.丙东东丅丁业丝万一();
    }
    public BonusCreator()
    {
        this.creationInterval = 15f;
        this.weaponCreationInterval = 30f;
        this.丑上与且丏专万丝专 = new System.Collections.ArrayList();
        this.丏丄万丐丙丕世丐丐 = new System.Collections.ArrayList();
        this.上七丆丞丁丟不丘上 = new System.Collections.ArrayList();
    }

}
