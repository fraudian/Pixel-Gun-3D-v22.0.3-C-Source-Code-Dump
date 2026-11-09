using UnityEngine;
internal sealed class Switcher : MonoBehaviour
{
    // Fields
    internal static bool 上且下三丕丙与丐专;
    public UnityEngine.GameObject shopNGUIPrefab;
    public UnityEngine.GameObject balanceControllerPrefab;
    public UnityEngine.GameObject coinsShopPrefab;
    public UnityEngine.GameObject nickStackPrefab;
    public UnityEngine.GameObject skinsManagerPrefab;
    public UnityEngine.GameObject ExperienceControllerPrefab;
    public UnityEngine.GameObject weaponManagerPrefab;
    public UnityEngine.GameObject experienceGuiPrefab;
    public UnityEngine.GameObject bankGuiPrefab;
    public UnityEngine.GameObject friendsControllerPrefab;
    public UnityEngine.GameObject clansControllerPrefab;
    public UnityEngine.GameObject buttonClickSoundPrefab;
    public UnityEngine.GameObject faceBookControllerPrefab;
    public UnityEngine.GameObject potionsControllerPrefab;
    public UnityEngine.GameObject protocolListGetterPrefab;
    public UnityEngine.GameObject updateCheckerPrefab;
    public UnityEngine.GameObject promoActionsManagerPrefab;
    public UnityEngine.GameObject tempItemsControllerPrefab;
    public UnityEngine.GameObject remotePushNotificationControllerPrefab;
    public UnityEngine.GameObject twitterControllerPrefab;
    public UnityEngine.GameObject sgo;
    public UnityEngine.GameObject giftControllerPrefab;
    public UnityEngine.GameObject disabler;
    public UnityEngine.GameObject sceneInfoController;
    private UnityEngine.Rect 丑丘业丗丄万丛专丙;
    private UnityEngine.Texture 丈丘丒不丌丕万东三;
    internal static int 丙万丛业专丘三丝丒;
    private bool 不不一上上丅东丝丘;
    private bool 丛不不丕丘丒一万东;
    private string 丌且世丒不丁七丟上;
    private UnityEngine.AsyncOperation 丕下上丗丘丕东业万;
    internal static readonly System.Diagnostics.Stopwatch 丌不丙丞丙丌丗七上;
    private static float 七与与丑丞丒丈丘东;
    private string 东丛丂世丁三东三丏;
    internal const string 万上业万丙丆丂丄丄 = "Banner_CompensationCalculated170818Key";
    internal const string 丒丕丅丞七丝一七东 = "CompensationCalculated090818Key";
    internal const string 丑丗丑丄丆丑三丐丌 = "BannerShownCompensation090818Key";
    internal const string 不七世世东丆丁世三 = "CoinsToCompensate090818Key";
    internal const string 丛丑丆万世丛业不且 = "GemsToCompensate090818Key";
    private static bool 世丗且丐一一业东上;
    private static string 丑下丅丞与丏万且七;
    private Rilisoft.丛业丗不丅丑业丈丛 业东丛丂丏下丗丘且;
    private bool 丏专下丐丌丏一三丗;
    private static readonly int 不丂丛丆下丐丂丑三;
    internal static UnityEngine.GameObject 丐丟万丁丘丌业东丟;
    private float 丈丄丂下丒专丌丛丄;
    private float 上丕专上且上丕万丘;
    internal const string 丅丙专业丆专不丁丌 = "AbuseMethod";
    private static System.Nullable<Rilisoft.丁丆一三丄丌丌丑丄> 一丞上七三丙且且丞;
    
    // Properties
    private string 七且丙丝丅且丂丟业 { get; }
    internal static string 丅世丅丅丅丕丟丌丏 { get; set; }
    internal static Rilisoft.丁丆一三丄丌丌丑丄 丐丌丕丕三丐丁丈丄 { get; }
    
    // Methods
    private static double 丁世丙三丘与丅丘一(double 三丟东丕丄丄下下丑, double 丒丒丄丁且丄丆丂丌)
    {
        float val_3;
        double val_3 = System.Math.Abs(三丟东丕丄丄下下丑);
        double val_4 = System.Math.Abs(丒丒丄丁且丄丆丂丌);
        double val_1 = System.Math.Max(val1:  val_3, val2:  val_4);
        double val_2 = System.Math.Min(val1:  val_3, val2:  val_4);
        val_2 = val_2 / val_1;
        val_2 = val_2 * val_2;
        double val_5 = 1;
        val_5 = val_2 + val_5;
        if(val_2 >= _TYPE_MAX_)
        {
                val_3 = val_5;
        }
        
        val_3 = val_1 * val_3;
        return (double)val_3;
    }
    public void ChangeTextureFolderName(string 丒丘丏上丙丟丑丕丈)
    {
        this.东丛丂世丁三东三丏 = 丒丘丏上丙丟丑丕丈;
    }
    private static void 专丘丂丝世世丑丄一()
    {
        var val_64;
        var val_65;
        var val_66;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 与丕丙丄丕丞一丒下>, System.String> val_68;
        var val_69;
        System.Func<System.String, System.Boolean> val_71;
        object val_72;
        var val_73;
        var val_74;
        System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_76;
        var val_77;
        System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>> val_79;
        int val_80;
        int val_81;
        var val_82;
        System.Func<三丅丁丗丗丝丂万且, System.Single> val_84;
        var val_87;
        var val_88;
        int val_89;
        int val_90;
        var val_91;
        System.Func<三丅丁丗丗丝丂万且, System.Single> val_93;
        var val_94;
        var val_95;
        System.Func<System.String, 三丅丁丗丗丝丂万且> val_97;
        new Switcher.专丏丌丏丑东万丝专() = new Switcher.专丏丌丏丑东万丝专();
        val_64 = 1152921505286238208;
        val_65 = null;
        val_65 = null;
        val_66 = null;
        val_66 = null;
        val_68 = Switcher.<>c.<>9__42_0;
        if(val_68 == null)
        {
                val_68 = null;
            val_68 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 与丕丙丄丕丞一丒下>, System.String>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  System.String Switcher.<>c::丂下丟丙丂丛专丌丁(System.Collections.Generic.KeyValuePair<string, WeaponManager.与丕丙丄丕丞一丒下> 丈丏万丄丒业丅丒一));
            Switcher.<>c.<>9__42_0 = val_68;
        }
        
        val_69 = null;
        val_69 = null;
        val_71 = Switcher.<>c.<>9__42_1;
        if(val_71 == null)
        {
                val_71 = null;
            val_71 = new System.Func<System.String, System.Boolean>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Switcher.<>c::且丐丒业不丙且万不(string 三丟东丕丄丄下下丑));
            Switcher.<>c.<>9__42_1 = val_71;
        }
        
        val_72 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, 与丕丙丄丕丞一丒下>, System.String>(source:  WeaponManager.东东丒丝一一丘且丕, selector:  null), predicate:  null));
        val_73 = null;
        val_73 = null;
        val_74 = null;
        val_74 = null;
        val_76 = Switcher.<>c.<>9__42_2;
        if(val_76 == null)
        {
                val_76 = null;
            val_76 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Switcher.<>c::丈丞七丕上丝丏上万(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
            Switcher.<>c.<>9__42_2 = val_76;
        }
        
        val_77 = null;
        val_77 = null;
        val_79 = Switcher.<>c.<>9__42_3;
        if(val_79 == null)
        {
                val_79 = null;
            val_79 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> Switcher.<>c::且上万丂丈丟丂丕专(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
            Switcher.<>c.<>9__42_3 = val_79;
        }
        
        System.Collections.Generic.HashSet<System.String> val_11 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  WeaponManager.且专专丁丌丗丛且丙, predicate:  null), selector:  null));
        .世丂丏丘丟丈业七丈 = null;
        char[] val_14 = new char[1];
        val_14[0] = '#';
        System.String[] val_15 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗()).Split(separator:  val_14);
        new Switcher.丙丄丅东丁丛万下下() = new Switcher.丙丄丅东丁丛万下下();
        if(new Switcher.丙丄丅东丁丛万下下() != null)
        {
                .东丟且丗且三专丙丁 = new Switcher.专丏丌丏丑东万丝专();
        }
        else
        {
                mem[24] = new Switcher.专丏丌丏丑东万丝专();
        }
        
        val_80 = 0;
        goto label_35;
        label_66:
        if(val_15[(Switcher.丙丄丅东丁丛万下下)[1152921540447380304].七丞丙丒三丕且丌丟] == null)
        {
            goto label_40;
        }
        
        if((val_72.Contains(item:  val_15[(Switcher.丙丄丅东丁丛万下下)[1152921540447380304].七丞丙丒三丕且丌丟])) == false)
        {
            goto label_40;
        }
        
        val_81 = System.String.alignConst;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_19 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new Switcher.丙丄丅东丁丛万下下(), method:  System.Boolean Switcher.丙丄丅东丁丛万下下::专丟丕丁丝万且丗丁(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
        val_82 = null;
        val_82 = null;
        val_84 = Switcher.<>c.<>9__42_5;
        if(val_84 == null)
        {
                val_84 = null;
            val_84 = new System.Func<三丅丁丗丗丝丂万且, System.Single>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Single Switcher.<>c::丙不与丙丆丏丆世丟(三丅丁丗丗丝丂万且 三丟东丕丄丄下下丑));
            val_64 = val_64;
            Switcher.<>c.<>9__42_5 = val_84;
        }
        
        三丅丁丗丗丝丂万且 val_23 = System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.OrderByDescending<三丅丁丗丗丝丂万且, System.Single>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  null), keySelector:  null));
        if(val_23 == null)
        {
            goto label_48;
        }
        
        if(val_23.三与丛丑且丐丈业丌() == null)
        {
            goto label_50;
        }
        
        val_81 = val_23.三与丛丑且丐丈业丌();
        goto label_50;
        label_48:
        label_50:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_81)) != false)
        {
                char[] val_28 = new char[1];
            val_28[0] = '#';
            val_81 = WeaponManager.丑丄丁三丑且且丂丐().Split(separator:  val_28)[(Switcher.丙丄丅东丁丛万下下)[1152921540447380304].七丞丙丒三丕且丌丟];
        }
        
        WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗(), 专丟丌丄东且上业一:  val_81, 下业丕七东丌丝下且:  (Switcher.丙丄丅东丁丛万下下)[1152921540447380304].七丞丙丒三丕且丌丟, 下与丙业丁世三丞丒:  true);
        label_40:
        val_80 = (Switcher.丙丄丅东丁丛万下下)[1152921540447380304].七丞丙丒三丕且丌丟 + 1;
        label_35:
        .七丞丙丒三丕且丌丟 = val_80;
        if(val_80 < val_15.Length)
        {
            goto label_66;
        }
        
        val_87 = 1152921505725372656;
        char[] val_34 = new char[1];
        val_34[0] = '#';
        val_88 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七()).Split(separator:  val_34);
        new Switcher.上丘专丐丑丒丈丈万() = new Switcher.上丘专丐丑丒丈丈万();
        if(new Switcher.上丘专丐丑丒丈丈万() != null)
        {
                .丕丅丏丁丅东且七丌 = new Switcher.专丏丌丏丑东万丝专();
        }
        else
        {
                mem[24] = new Switcher.专丏丌丏丑东万丝专();
        }
        
        val_89 = 0;
        goto label_129;
        label_171:
        if(val_88[(Switcher.上丘专丐丑丒丈丈万)[1152921540447531904].七丞丙丒三丕且丌丟] == null)
        {
            goto label_134;
        }
        
        if((val_72.Contains(item:  val_88[(Switcher.上丘专丐丑丒丈丈万)[1152921540447531904].七丞丙丒三丕且丌丟])) == false)
        {
            goto label_134;
        }
        
        val_90 = System.String.alignConst;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_39 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new Switcher.上丘专丐丑丒丈丈万(), method:  System.Boolean Switcher.上丘专丐丑丒丈丈万::世丟丏丆丘丁丛上丈(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
        val_91 = null;
        val_91 = null;
        val_93 = Switcher.<>c.<>9__42_7;
        if(val_93 == null)
        {
                val_93 = null;
            val_93 = new System.Func<三丅丁丗丗丝丂万且, System.Single>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Single Switcher.<>c::丝丏丟丅专东七丌丕(三丅丁丗丗丝丂万且 三丟东丕丄丄下下丑));
            val_87 = val_87;
            Switcher.<>c.<>9__42_7 = val_93;
        }
        
        三丅丁丗丗丝丂万且 val_43 = System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.OrderByDescending<三丅丁丗丗丝丂万且, System.Single>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  null), keySelector:  null));
        if(val_43 != null)
        {
                if(val_43.三与丛丑且丐丈业丌() != null)
        {
                val_90 = val_43.三与丛丑且丐丈业丌();
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_90)) == false)
        {
            goto label_165;
        }
        
        if((Switcher.上丘专丐丑丒丈丈万)[1152921540447531904].七丞丙丒三丕且丌丟 == 0)
        {
            goto label_147;
        }
        
        char[] val_49 = new char[1];
        val_49[0] = '#';
        val_94 = null;
        val_94 = null;
        val_95 = null;
        val_95 = null;
        val_97 = Switcher.<>c.<>9__42_8;
        if(val_97 == null)
        {
                val_97 = null;
            val_97 = new System.Func<System.String, 三丅丁丗丗丝丂万且>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  三丅丁丗丗丝丂万且 Switcher.<>c::七丛万丞丁丟世且丅(string 三丟东丕丄丄下下丑));
            Switcher.<>c.<>9__42_8 = val_97;
        }
        
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_54 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new Switcher.上丘专丐丑丒丈丈万(), method:  System.Boolean Switcher.上丘专丐丑丒丈丈万::一丛丁丒丛专丝东丛(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
        三丅丁丗丗丝丂万且 val_56 = System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Select<System.String, 三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Except<System.String>(first:  Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟上七七一且丞丈与().Split(separator:  val_49, options:  1), second:  WeaponManager.丅丑丏上丟丌丛丑丐), selector:  null), predicate:  null));
        if(val_56 == null)
        {
            goto label_161;
        }
        
        val_90 = val_56.三与丛丑且丐丈业丌();
        goto label_165;
        label_147:
        val_90 = WeaponManager.丞丗丆丑三丈丆七丐();
        goto label_165;
        label_161:
        val_90 = System.String.alignConst;
        label_165:
        val_80 = 与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七();
        WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  val_80, 专丟丌丄东且上业一:  val_90, 下业丕七东丌丝下且:  (Switcher.上丘专丐丑丒丈丈万)[1152921540447531904].七丞丙丒三丕且丌丟, 下与丙业丁世三丞丒:  true);
        label_134:
        val_89 = (Switcher.上丘专丐丑丒丈丈万)[1152921540447531904].七丞丙丒三丕且丌丟 + 1;
        label_129:
        .七丞丙丒三丕且丌丟 = val_89;
        if(val_89 < val_35.Length)
        {
            goto label_171;
        }
    
    }
    private string 丂丏丕业丙七丝丕丐()
    {
        return System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "bundles");
    }
    private void 丏东丅一丏东丆丌且()
    {
        bool val_2 = System.IO.Directory.Exists(path:  this.丂丏丕业丙七丝丕丐());
        if(val_2 == false)
        {
                return;
        }
        
        System.IO.Directory.Delete(path:  val_2.丂丏丕业丙七丝丕丐(), recursive:  true);
    }
    private System.Collections.IEnumerator Start()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new Switcher.上丆丂丆下丞专业丟(丗丏丅丕丆世丁专丟:  0);
    }
    internal static string 丑一丙丛七万丑丞丗()
    {
        string val_3;
        var val_4 = null;
        if(Switcher.世丗且丐一一业东上 != true)
        {
                val_4 = null;
            val_3 = UnityEngine.PlayerPrefs.GetString(key:  与丂丏丛丞丞丒丟丄.与丗与与丟丘一丕业());
            val_4 = null;
            Switcher.丑下丅丞与丏万且七 = val_3;
            Switcher.世丗且丐一一业东上 = true;
        }
        
        val_4 = null;
        return (string)Switcher.丑下丅丞与丏万且七;
    }
    private static void 丒丕丗丐丝丑丈丕丟(string 丙业与丙丗丝不丈东)
    {
        null = null;
        Switcher.丑下丅丞与丏万且七 = 丙业与丙丗丝不丈东;
        Switcher.世丗且丐一一业东上 = true;
    }
    internal static string 丌三丟丈东丑七丑上(int 丑丅世丐丒丏丐三丅)
    {
        return (string)"loading_cups_" + 丑丅世丐丒丏丐三丅.ToString();
    }
    public System.Collections.Generic.IEnumerable<float> InitializeSwitcher()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.Generic.IEnumerable<System.Single>)new Switcher.丑丅丈丙丅世万丄丘(丗丏丅丕丆世丁专丟:  -2);
    }
    private System.Collections.IEnumerator 丅一丆专丑丑丅丘丕()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new Switcher.世丄丑万丗丗丞丞丟(丗丏丅丕丆世丁专丟:  0);
    }
    internal static void 丘丑丛丄丐丟不七丞(HiddenSettings 与不丕丆丈不丙丟丛)
    {
        var val_4;
        var val_5;
        string val_1 = Switcher.丗丝丟丕一丄丞丏丛(与不丕丆丈不丙丟丛:  与不丕丆丈不丙丟丛);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_3.Add(key:  "appId", value:  val_1);
            val_4 = static_value_081D9CF0;
            val_4 = static_value_081D9CF0;
            val_3.Add(key:  "defaultAppId", value:  static_value_081D9CF0 + 184 + 32 + 24);
        }
        
        val_5 = static_value_081D9CF0;
        val_5 = static_value_081D9CF0;
        mem2[0] = val_1;
    }
    private static string 丗丝丟丕一丄丞丏丛(HiddenSettings 与不丕丆丈不丙丟丛)
    {
        var val_11;
        byte[] val_4 = new byte[0];
        new System.Collections.BitArray(bytes:  Switcher.丞丈世上专上一丂丄(与不丕丆丈不丙丟丛:  与不丕丆丈不丙丟丛)).Xor(value:  new System.Collections.BitArray(bytes:  Switcher.丛业与丌丝东世丗丒(与不丕丆丈不丙丟丛:  与不丕丆丈不丙丟丛))).Xor(value:  new System.Collections.BitArray(bytes:  Switcher.业丞三丒丛专三丙丝())).CopyTo(array:  val_4, index:  0);
        val_11 = System.Text.Encoding.UTF8;
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_9:
        val_11 = ???;
        goto typeof(System.Text.Encoding).__il2cppRuntimeField_368;
        label_6:
        if(val_11 != 0)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    private static byte[] 丞丈世上专上一丂丄(HiddenSettings 与不丕丆丈不丙丟丛)
    {
        System.Byte[] val_1 = System.Convert.FromBase64String(s:  与不丕丆丈不丙丟丛.PhotonAppIdSignaturePad);
        Switcher.七且专丑丆丕丆且万(丝业丌丑丌丘世下丒:  val_1);
        return val_1;
    }
    private static byte[] 丛业与丌丝东世丗丒(HiddenSettings 与不丕丆丈不丙丟丛)
    {
        return System.Convert.FromBase64String(s:  与不丕丆丈不丙丟丛.PhotonAppIdSignatureZeroEncoded);
    }
    private static byte[] 业丞三丒丛专三丙丝()
    {
        var val_7;
        System.Func<System.Byte[], System.Collections.Generic.IEnumerable<System.Byte>> val_9;
        var val_10;
        System.Byte[] val_2 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().丒丆专上下东丟丆丛();
        if(val_2 == null)
        {
                return val_2;
        }
        
        val_7 = null;
        val_7 = null;
        val_9 = Switcher.<>c.<>9__62_0;
        if(val_9 == null)
        {
                System.Func<System.Byte[], System.Collections.Generic.IEnumerable<System.Byte>> val_4 = null;
            val_9 = val_4;
            val_4 = new System.Func<System.Byte[], System.Collections.Generic.IEnumerable<System.Byte>>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.Byte> Switcher.<>c::丈与丗丁七与专丙丗(byte[] 上世丘丐东万丐丆不));
            Switcher.<>c.<>9__62_0 = val_9;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Linq.Enumerable.ToArray<System.Byte>(source:  System.Linq.Enumerable.Take<System.Byte>(source:  System.Linq.Enumerable.SelectMany<System.Byte[], System.Byte>(source:  System.Linq.Enumerable.Repeat<System.Byte[]>(element:  val_2, count:  2147483647), selector:  val_4), count:  Switcher.不丂丛丆下丐丂丑三));
    }
    private static void 七且专丑丆丕丆且万(byte[] 丝业丌丑丌丘世下丒)
    {
        var val_8;
        System.Globalization.CodePageDataItem val_9;
        string val_8 = "gfts";
        val_8 = (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_8, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "easy", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        string val_4 = val_8.ToString();
        val_8 = 0;
        goto label_4;
        label_9:
        val_9 = val_3.dataItem;
        var val_5 = (0 < val_9) ? 0 : 0;
        if(val_8 >= 丝业丌丑丌丘世下丒.Length)
        {
                val_9 = val_3.dataItem;
        }
        
        var val_6 = val_5 + 1;
        System.Text.Encoding val_7 = System.Text.Encoding.UTF8 + (long)val_5;
        bool val_10 = (val_3 + (long)(int)(0 < val_9 ? 0 : 0)).m_deserializedFromEverett;
        val_8 = 1;
        val_10 = val_10 ^ 丝业丌丑丌丘世下丒[0];
        mem2[0] = val_10;
        label_4:
        if(val_8 < 丝业丌丑丌丘世下丒.Length)
        {
            goto label_9;
        }
    
    }
    internal static void 专且丏丕丁上丌万丕()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(Switcher.丐丟万丁丘丌业东丟 != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "BackgroundMusic/Background_Comics");
        if(val_2 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "ComicsSoundPrefab is null.");
            return;
        }
        
        val_6 = null;
        val_6 = null;
        Switcher.丐丟万丁丘丌业东丟 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_2);
        UnityEngine.Object.DontDestroyOnLoad(target:  Switcher.丐丟万丁丘丌业东丟);
    }
    private static void 丒丙丙丆丙丏上丕且(string 丂下丗丞丙丂上丈丞, Rilisoft.业丒且世丄丑丞万丞 丛丌丙世专世东丕下)
    {
    
    }
    public System.Collections.Generic.IEnumerable<float> LoadMainMenu()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.Generic.IEnumerable<System.Single>)new Switcher.世丅上万丅上世丟丌(丗丏丅丕丆世丁专丟:  -2);
    }
    private System.Collections.IEnumerator 世丗万上丁一与丝万(UnityEngine.AsyncOperation 三丗一丛丝丘不丟丁, string 专万丟三世业丙丈且, float 丘丛与上丞丐丝丑丑)
    {
        Switcher.丁且与业丒专丏万丝 val_1 = new Switcher.丁且与业丒专丏万丝();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .专万丟三世业丙丈且 = 专万丟三世业丙丈且;
            .丝且与丝丒丟万丁专 = this;
            .三丗一丛丝丘不丟丁 = 三丗一丛丝丘不丟丁;
        }
        else
        {
                mem[40] = this;
            mem[56] = 三丗一丛丝丘不丟丁;
            mem[32] = 专万丟三世业丙丈且;
        }
        
        .丘丛与上丞丐丝丑丑 = 丘丛与上丞丐丝丑丑;
        return (System.Collections.IEnumerator)val_1;
    }
    private static void 丙丁专丐下专且丟丕()
    {
        var val_7;
        var val_21;
        string val_22;
        bool val_1 = 丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "RemovedArmorHatMethodExecuted");
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "RemovedArmorHatMethodExecuted", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  "MoneyGivenRemovedArmorHat", 丝丒上丑一三丑丐丛:  true)) == true)
        {
            goto label_25;
        }
        
        val_22 = 1152921505290498048;
        List.Enumerator<T> val_5 = 七丌丞万七万丁丐丙.丗且且丁万丛丗与一().GetEnumerator();
        label_18:
        if((1484010016 & 1) == 0)
        {
            goto label_10;
        }
        
        string val_8 = val_7.丐丏七丌丕丗业且上();
        if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  6).Contains(item:  val_8)) == false)
        {
            goto label_18;
        }
        
        int val_12 = 丏丄丑上丛不丈且万.丅专一丘专丁丂丞与(下上丐丆丝丟丝丒不:  val_8).丟丂丞不专丆万丒世();
        goto label_18;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_25:
        string val_13 = 七丌丞万七万丁丐丙.丌丅丐不丞丘丌下不();
        if((七丌丞万七万丁丐丙.丗且且丁万丛丗与一().Contains(item:  (val_13 == null) ? "" : (val_13))) != false)
        {
                val_21 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_22 = 丆丟七丌丞东丆丕丌.丈丑东丆丛万丙丅业(丁丂专业丁丅丅丈丙:  6);
            val_21.丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  3, 下上丐丆丝丟丝丒不:  6.ToString(), 下下丏一丙不丘丌丞:  val_22);
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "RemovedArmorHatMethodExecuted", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.东丌丟三丞世一一丑(丌丘不丆丈丈世万上:  "MoneyGivenRemovedArmorHat", 丕万不丌世丟三丛丈:  false);
    }
    internal static float 一丝丟丐一丑万业丘()
    {
        System.DateTime val_1 = System.DateTime.Now;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime());
        return (float)(float)val_2._ticks.TotalSeconds;
    }
    internal static Rilisoft.丁丆一三丄丌丌丑丄 下业丅上丟且丙一丏()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((1152921505326604336 & 1) != 0)
        {
                val_3 = null;
        }
        else
        {
                int val_1 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "AbuseMethod", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
            val_3 = null;
            val_3 = null;
            Switcher.一丞上七三丙且且丞 = 0;
        }
        
        val_3 = null;
        return (Rilisoft.丁丆一三丄丌丌丑丄)1152921505326604336;
    }
    private static void 丁丙世东世丅下丐丏()
    {
        var val_44;
        var val_45;
        string val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        string val_51;
        long val_32 = 0;
        val_44 = null;
        val_44 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丑丛丄且丛丈下三)) != true)
        {
                val_45 = null;
            val_45 = null;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丑丛丄且丛丈下三, 下下丏一丙不丘丌丞:  "");
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐丕万七万丏一丅丟, 下下丏一丙不丘丌丞:  "");
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "inappBonusesConfigKey", 下下丏一丙不丘丌丞:  "");
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丏丕丘专丗不丞万())) == false)
        {
            goto label_14;
        }
        
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丏丕丘专丗不丞万(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0)
        {
            goto label_19;
        }
        
        val_46 = 与丂丏丛丞丞丒丟丄.东不丞丗丟丞世与丛();
        val_47 = 3;
        goto label_24;
        label_14:
        val_46 = 与丂丏丛丞丞丒丟丄.丑丏丕丘专丗不丞万();
        val_47 = 1;
        label_24:
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_46, 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        label_19:
        if((UnityEngine.PlayerPrefs.HasKey(key:  "SpeedUpMultRotationCamSett")) != true)
        {
                UnityEngine.PlayerPrefs.SetFloat(key:  "SpeedUpMultRotationCamSett", value:  ((UnityEngine.PlayerPrefs.HasKey(key:  "SensitivitySett")) != true) ? 0f : 1f);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  "SpeedUpMultThirdRotationCamSett")) != true)
        {
                UnityEngine.PlayerPrefs.SetFloat(key:  "SpeedUpMultThirdRotationCamSett", value:  ((UnityEngine.PlayerPrefs.HasKey(key:  "SensitivitySett")) != true) ? 0f : 1f);
        }
        
        val_48 = null;
        val_48 = null;
        if((丌丝世丞世丛丆丅丟.丐丘丐且业三丑丅丈(世丐与丞丕三丂专与:  与丂丏丛丞丞丒丟丄.丐世丑丞与丘万丂丏)) != true)
        {
                val_49 = null;
            val_49 = null;
            丌丝世丞世丛丆丅丟.丏七丂万不东丘丄丂(世丐与丞丕三丂专与:  与丂丏丛丞丞丒丟丄.丐世丑丞与丘万丂丏);
            System.DateTime val_16 = System.DateTime.UtcNow;
            UnityEngine.PlayerPrefs.SetString(key:  与丂丏丛丞丞丒丟丄.七丄专万丒与丂东丞(), value:  val_16.dateData);
            UnityEngine.PlayerPrefs.Save();
        }
        
        与丂丏丛丞丞丒丟丄.上不七丘三专丐丁专 = UnityEngine.PlayerPrefs.GetString(key:  与丂丏丛丞丞丒丟丄.七丄专万丒与丂东丞(), defaultValue:  System.String.alignConst);
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丝丝七丗丞丟且下丐)) != true)
        {
                val_50 = null;
            val_50 = null;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丝丝七丗丞丟且下丐, 下下丏一丙不丘丌丞:  0.ToString());
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.东丘一丙东一丐丑丂, 下下丏一丙不丘丌丞:  0.ToString());
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.与专丒专三丙三丂丗, 下下丏一丙不丘丌丞:  0.ToString());
            UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丗丅丐业七丁丒下东, value:  0);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  与丂丏丛丞丞丒丟丄.下丘世丅丘丁丗三下())) != true)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丞业丆丈丌世丕丙丙(), value:  3);
            UnityEngine.PlayerPrefs.SetString(key:  与丂丏丛丞丞丒丟丄.下丘世丅丘丁丗三下(), value:  专七专下且专三一且.上且一丈丐三丄一丆().ToString());
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "Notifications.PreviousDayShowNotficationsBannerKey", 下下丏一丙不丘丌丞:  -2147483648, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            UnityEngine.PlayerPrefs.Save();
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  "Notifications.FirstLaunch_WillShowNotificationPermissionAlert")) != true)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "Notifications.FirstLaunch_WillShowNotificationPermissionAlert", value:  1);
            UnityEngine.PlayerPrefs.Save();
        }
        
        bool val_33 = System.Int64.TryParse(s:  UnityEngine.PlayerPrefs.GetString(key:  与丂丏丛丞丞丒丟丄.下丘世丅丘丁丗三下()), result: out  val_32);
        val_51 = 专七专下且专三一且.上且一丈丐三丄一丆();
        System.TimeSpan val_37 = System.TimeSpan.FromHours(value:  (与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != true) ? 0.0833333358168602 : 12);
        if((val_51 - val_32) > (long)val_37._ticks.TotalSeconds)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丞业丆丈丌世丕丙丙(), value:  3);
            val_51 = 与丂丏丛丞丞丒丟丄.下丘世丅丘丁丗三下();
            UnityEngine.PlayerPrefs.SetString(key:  val_51, value:  专七专下且专三一且.上且一丈丐三丄一丆().ToString());
        }
        
        UnityEngine.PlayerPrefs.Save();
    }
    public Switcher()
    {
        this.丌且世丒不丁七丟上 = 与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐();
        this.业东丛丂丏下丗丘且 = new Rilisoft.丛业丗不丅丑业丈丛();
    }
    private static Switcher()
    {
        Switcher.丅丙专业丆专不丁丌 = 0;
        Switcher.丌不丙丞丙丌丗七上 = new System.Diagnostics.Stopwatch();
        Switcher.七与与丑丞丒丈丘东 = 3f;
        Switcher.世丗且丐一一业东上 = false;
        Switcher.丑下丅丞与丏万且七 = System.String.alignConst;
        Switcher.不丂丛丆下丐丂丑三 = 36;
    }

}
