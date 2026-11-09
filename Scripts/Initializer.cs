using UnityEngine;
public class Initializer : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip resistSound;
    public UnityEngine.Texture killstreakeAtlas;
    public UnityEngine.GameObject playerPrefab;
    internal static System.Collections.Generic.List<SingularityHole> 丌丒丙丏丞丄三丒万;
    internal System.Collections.Generic.Dictionary<UnityEngine.Collider, Rilisoft.AreaBase> 丏丗丙丞丛世丞七七;
    private static PGCompany.NamedZoneOnMap[] 丌丒上丂丈不丗七丐;
    internal System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丌与丄丑丄业丁丘丄;
    private const int 丙专丕丐丟与丁一丅 = 100;
    private const int 丂丈丗与丕三不丑七 = 101;
    internal static int 万与丈世丝丙万丕一;
    private System.Diagnostics.Stopwatch 丒丅丟与丞丌七丏丕;
    private static Initializer <不丁丄七丛不丆丁丕>k__BackingField;
    private static readonly Rilisoft.七丞丞丅东丞专丙丝<string> 丆丒丈丏丁丐丌丌一;
    
    // Properties
    internal static PGCompany.NamedZoneOnMap[] 下丞丒丄丄丘一且世 { get; }
    internal static Initializer 丆丕丝丒不丙且丐丗 { get; set; }
    internal static string 丌丈不世业不世丄且 { get; }
    
    // Methods
    internal static PGCompany.NamedZoneOnMap[] 丆丝丒不丘丛丆上丗()
    {
        PGCompany.NamedZoneOnMap[] val_2;
        var val_3 = null;
        if(Initializer.丌丒上丂丈不丗七丐 == null)
        {
                val_3 = null;
            val_2 = new PGCompany.NamedZoneOnMap[0];
            val_3 = null;
            Initializer.丌丒上丂丈不丗七丐 = val_2;
        }
        
        val_3 = null;
        return (PGCompany.NamedZoneOnMap[])Initializer.丌丒上丂丈不丗七丐;
    }
    internal static Initializer 丑七不且上丗丁一世()
    {
        null = null;
        return (Initializer)Initializer.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(Initializer 丙业与丙丗丝不丈东)
    {
        null = null;
        Initializer.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        string val_29;
        var val_30;
        var val_32;
        Rilisoft.丝一丌上丟且三一丏 val_34;
        UnityEngine.Vector3 val_35;
        float val_36;
        float val_37;
        Initializer.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        Initializer.丌丒上丂丈不丗七丐 = UnityEngine.Object.FindObjectsOfType<PGCompany.NamedZoneOnMap>();
        Initializer.万与丈世丝丙万丕一 = 0;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_29 = val_2.m_Handle.name;
        val_30 = null;
        val_30 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
            goto label_7;
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_10;
        }
        
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "In game");
        var val_30 = 0;
        val_30 = val_30 + 1;
        goto label_19;
        label_10:
        val_30 = null;
        label_7:
        val_30 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
            goto label_22;
        }
        
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_25;
        }
        
        val_29 = 101;
        goto label_36;
        label_25:
        val_30 = null;
        label_22:
        val_30 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        val_29 = GameConnect.丑丌丛丈丅丅与不业();
        goto label_36;
        label_19:
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Clear();
        val_32 = val_29 + " In game";
        var val_31 = 0;
        val_31 = val_31 + 1;
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().丘一一丆业丂丘丒世().Add(key:  ???, value:  val_2.m_Handle);
        if((val_15.Length != 0) && (Progress.丅丕东丑下世丏丑与.丑万丅丏丞一丟丌丝() != true))
        {
                val_32 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
            if(val_15.Length != 0)
        {
                do
        {
            CoinConfigurator val_19 = UnityEngine.GameObject.FindGameObjectsWithTag(tag:  "Configurator")[0].GetComponent<CoinConfigurator>();
            if((val_19 != 0) && (val_19.CoinIsPresent != false))
        {
                if(val_19.BonusType != 0)
        {
                val_34 = val_19.BonusType;
        }
        else
        {
                val_34 = 1;
        }
        
            if((val_32 & (CoinBonus.丟丐业东丑丘丐丘东(丆丙丅丝七丒丐丙万:  val_34).Contains(item:  val_29))) != true)
        {
                if(val_19.coinCreatePoint == 0)
        {
                val_35 = val_19.pos;
        }
        else
        {
                UnityEngine.Vector3 val_27 = val_19.coinCreatePoint.position;
            val_35 = val_27.x;
            val_36 = val_27.y;
            val_37 = val_27.z;
        }
        
            UnityEngine.GameObject val_28 = Initializer.丕丛不丄丁丞丗且下(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37}, 丆丙丅丝七丒丐丙万:  val_34);
        }
        
        }
        
        }
        while((0 + 1) != val_15.Length);
        
        }
        
        }
        
        val_29 = 100;
        label_36:
        Initializer.万与丈世丝丙万丕一 = 100;
    }
    private void Start()
    {
        var val_13;
        GotToNextLevel val_14;
        var val_15;
        var val_16;
        var val_17;
        丞丙万下丘丐丛与丑 val_18;
        this.丒丅丟与丞丌七丏丕.Start();
        val_13 = static_value_081DACA8;
        val_13 = static_value_081DACA8;
        mem2[0] = 0;
        val_14 = 1152921505171275776;
        val_15 = null;
        val_15 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_16 = null;
            val_16 = null;
            val_14 = GotToNextLevel.丄丘七三上丕世丞业;
            if(val_14 != 0)
        {
                val_17 = null;
            val_17 = null;
            val_14 = GotToNextLevel.丄丘七三上丕世丞业.gameObject;
            val_14.SetActive(value:  false);
        }
        
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() != 1)
        {
            goto label_27;
        }
        
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_14 = val_4.m_Handle.name;
        if((System.String.Equals(a:  val_14, b:  PGCompany.丁东丌世与丕东丆上.丛不丝丆与不丌与七(), comparisonType:  5)) == false)
        {
            goto label_21;
        }
        
        val_18 = 24;
        goto label_24;
        label_21:
        UnityEngine.SceneManagement.Scene val_8 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_14 = val_8.m_Handle.name;
        if((System.String.Equals(a:  val_14, b:  PGCompany.丁东丌世与丕东丆上.丈丝丘丑丞丗丐丒丆(), comparisonType:  5)) == false)
        {
            goto label_27;
        }
        
        val_18 = 30;
        label_24:
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  val_18);
        label_27:
        if(ExperienceController.丞丞丘业东丙丏七丌() != 2)
        {
                return;
        }
        
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  35);
    }
    private void OnDestroy()
    {
        var val_20;
        int val_21;
        System.Diagnostics.Stopwatch val_22;
        var val_23;
        var val_24;
        this.丒丅丟与丞丌七丏丕.Stop();
        val_20 = null;
        val_20 = null;
        val_21 = Initializer.万与丈世丝丙万丕一;
        if(val_21 == 100)
        {
            goto label_4;
        }
        
        val_20 = null;
        val_21 = Initializer.万与丈世丝丙万丕一;
        if(val_21 != 101)
        {
            goto label_7;
        }
        
        label_4:
        val_20 = null;
        val_22 = this.丒丅丟与丞丌七丏丕;
        System.TimeSpan val_1 = val_22.Elapsed;
        NetworkStartTable.七丁丞东丛且丈且丝(丂丛丑东不丅丈一东:  Initializer.万与丈世丝丙万丕一, 万丌丅世专丟丞丏与:  val_1._ticks.TotalMinutes);
        label_7:
        this.丏丗丙丞丛世丞七七.Clear();
        val_23 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        val_24 = static_value_081DACA8;
        val_24 = static_value_081DACA8;
        if(val_23 == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "[Initializer.OnDestroy] Skip requesting interstitial: NeedShowReviewInConnectScene");
    }
    internal static string 不丐世丗丒业丝东丐()
    {
        null = null;
        if(Initializer.丆丒丈丏丁丐丌丌一 != null)
        {
                return Initializer.丆丒丈丏丁丐丌丌一.世三丞丅丑丌丈丈一();
        }
        
        return Initializer.丆丒丈丏丁丐丌丌一.世三丞丅丑丌丈丈一();
    }
    private static string 且一七丛丞丈丅丝下()
    {
        return Initializer.丏七三且丙丛丆丌丝();
    }
    private static string 丏七三且丙丛丆丌丝()
    {
        var val_19;
        var val_20;
        object val_21;
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
                val_20 = "bada8a20";
            return (string)val_20;
        }
        
        val_19 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().且丄业丈丞丘丛业下();
        if(val_19 == null)
        {
            goto label_8;
        }
        
        val_19 = val_19.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
        if(val_19 == null)
        {
            goto label_9;
        }
        
        object[] val_6 = new object[2];
        val_6[0] = "com.pixel.gun3d";
        val_21 = 64;
        val_6[1] = val_21;
        UnityEngine.AndroidJavaObject val_7 = val_19.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_6);
        if(val_7 == null)
        {
            goto label_17;
        }
        
        UnityEngine.AndroidJavaObject[] val_8 = val_7.Get<UnityEngine.AndroidJavaObject[]>(fieldName:  "signatures");
        if(val_8 == null)
        {
            goto label_18;
        }
        
        if(val_8.Length != 1)
        {
            goto label_19;
        }
        
        System.Security.Cryptography.SHA1Managed val_11 = null;
        val_19 = val_11;
        val_11 = new System.Security.Cryptography.SHA1Managed();
        val_20 = System.BitConverter.ToString(value:  System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Take<System.Byte>(source:  val_11.ComputeHash(buffer:  val_8[0].Call<System.Byte[]>(methodName:  "toByteArray", args:  System.Array.Empty<System.Object>())), count:  4))).Replace(oldValue:  "-", newValue:  System.String.alignConst).ToLower();
        val_21 = 0;
        if(val_19 == null)
        {
            goto label_45;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        goto label_30;
        label_8:
        val_20 = "deadac71";
        return (string)val_20;
        label_9:
        val_20 = "dead3a9a";
        return (string)val_20;
        label_17:
        val_20 = "dead6ac5";
        return (string)val_20;
        label_18:
        val_20 = "deadc199";
        return (string)val_20;
        label_19:
        val_20 = "dead139c";
        return (string)val_20;
        label_30:
        val_11.Dispose();
        label_45:
        if(0 != 1)
        {
                return (string)val_20;
        }
        
        if(val_21 == 0)
        {
                return (string)val_20;
        }
        
        return (string)val_20;
    }
    internal static UnityEngine.GameObject 丕丛不丄丁丞丗且下(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, Rilisoft.丝一丌上丟且三一丏 丆丙丅丝七丒丐丙万)
    {
        Rilisoft.丝一丌上丟且三一丏 val_17;
        var val_18;
        UnityEngine.Object val_19;
        string val_20;
        System.Object[] val_21;
        var val_22;
        UnityEngine.Object val_23;
        val_17 = 丆丙丅丝七丒丐丙万;
        val_18 = 0;
        if(Progress.丅丕东丑下世丏丑与.丑万丅丏丞一丟丌丝() == true)
        {
                return (UnityEngine.GameObject)val_18;
        }
        
        val_18 = 0;
        if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false)
        {
                return (UnityEngine.GameObject)val_18;
        }
        
        if((val_17 - 1) >= 3)
        {
            goto label_7;
        }
        
        string val_17 = 130691200 + ((丆丙丅丝七丒丐丙万 - 1)) << 3;
        val_19 = UnityEngine.Resources.Load(path:  val_17);
        if(val_19 != 0)
        {
            goto label_10;
        }
        
        val_17 = new object[1];
        val_17[0] = val_17;
        val_20 = "Failed to load \'{0}\'";
        goto label_17;
        label_7:
        object[] val_7 = new object[1];
        val_17 = val_17;
        val_7[0] = val_17;
        val_21 = val_7;
        val_22 = "Failed to determine resource for \'{0}\'";
        goto label_24;
        label_10:
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        UnityEngine.Object val_9 = UnityEngine.Object.Instantiate(original:  val_19, position:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
        val_19 = val_9;
        if(val_9 != 0)
        {
            goto label_29;
        }
        
        object[] val_11 = new object[1];
        val_17 = val_11;
        val_17[0] = val_17;
        val_20 = "Failed to instantiate \'{0}\'";
        label_17:
        val_21 = val_17;
        label_24:
        UnityEngine.Debug.LogErrorFormat(format:  val_20, args:  val_11);
        val_18 = 0;
        return (UnityEngine.GameObject)val_18;
        label_29:
        if(val_19 != null)
        {
                val_17 = (null == null) ? (val_19) : 0;
        }
        else
        {
                val_23 = 0;
        }
        
        if(val_23 == 0)
        {
                return (UnityEngine.GameObject)val_18;
        }
        
        CoinBonus val_13 = val_23.GetComponent<CoinBonus>();
        if(val_13 == 0)
        {
                object[] val_15 = new object[1];
            val_15[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Debug.LogErrorFormat(format:  "Cannot find \'{0}\' script.", args:  val_15);
            return (UnityEngine.GameObject)val_18;
        }
        
        val_13.BonusType = val_17;
        return (UnityEngine.GameObject)val_18;
    }
    public Initializer()
    {
        this.丏丗丙丞丛世丞七七 = new System.Collections.Generic.Dictionary<UnityEngine.Collider, Rilisoft.AreaBase>();
        this.丌与丄丑丄业丁丘丄 = new System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>();
        this.丒丅丟与丞丌七丏丕 = new System.Diagnostics.Stopwatch();
    }
    private static Initializer()
    {
        Initializer.丂丈丗与丕三不丑七 = new System.Collections.Generic.List<SingularityHole>();
        Initializer.万与丈世丝丙万丕一 = 0;
        Initializer.丆丒丈丏丁丐丌丌一 = new Rilisoft.七丞丞丅东丞专丙丝<System.String>(丙丂丌且丌世丒丐三:  new System.Func<System.String>(object:  0, method:  static System.String Initializer::且一七丛丞丈丅丝下()));
    }

}
