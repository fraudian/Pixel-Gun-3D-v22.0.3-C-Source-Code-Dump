using UnityEngine;
public sealed class WeaponManager : MonoBehaviour
{
    // Fields
    private const string 丑丟丛世丞丝丌专万 = "WeaponManager.CRAFTING_WEAPONS_KEY";
    internal static readonly System.Collections.Generic.HashSet<string> 与丌丕丝下丏丒三一;
    internal static readonly System.Collections.Generic.HashSet<string> 丆丘丘丑丌丁世七不;
    internal static readonly System.Collections.Generic.HashSet<string> 丁丟丟一下专万丒丒;
    internal static System.Collections.Generic.HashSet<string> 丂丒丒丘上丁丘丕丐;
    internal static readonly string 丙丟丂丗丛丟丑东丑;
    internal static System.Collections.Generic.HashSet<string> 丆丘下丛不丒丛丌丄;
    private static System.Action<string, CategoryNames> 丁世世丂丗丁丑丐丗;
    private static System.Collections.Generic.List<string> 下不且丑上下丗丐世;
    private static System.Action 东丄三丆丌丟下丛一;
    private static System.Action<三丅丁丗丗丝丂万且, 丕丑丙丑丙东丌丘丕, 丕丑丙丑丙东丌丘丕, bool> 丈丙丌丝丑一丗下丂;
    private static System.Action<bool, 三丅丁丗丗丝丂万且> 丛与丅丘丛丆且与丛;
    private static System.Action<三丅丁丗丗丝丂万且> 丗业丘丘丏七丟丆一;
    private static System.Collections.Generic.HashSet<string> 丏丈丆一三丟世世丝;
    internal static System.Collections.Generic.Dictionary<string, ItemRarity> 丂丝下丑丘不丙且丁;
    private const string 三丄丑丏业丄丐业丈 = "V7_WeaponManager.REMEMBERED_STARS_EVENT_GOCHA_WEAPONS_KEY";
    private static System.Collections.Generic.Dictionary<string, Rilisoft.丝丑丂丛万丐丈丘且> 万丗下丒丈丛丅一七;
    private const string 下丆东丑三丅三丌丙 = "WeaponManager.REMEMBERED_COMBAT_LEVELS_EVENT_GOCHA_WEAPONS_KEY";
    private const string 东专丝丂业丐丑丒丄 = "WeaponManager.FIRST_COMBAT_LEVELS_KEY_250118";
    private static System.Collections.Generic.Dictionary<string, Rilisoft.丝丑丂丛万丐丈丘且> 丞业丕专丆七丛丑丗;
    private const string 丈丘业下且丒七丏丂 = "WeaponManager.UPGRADING_WEAPONS_KEY";
    internal const string 上七丆丘丅丅丆世与 = "V7_WeaponManager.WEAPON_LEVELS_KEY";
    internal const string 与丗业丅丛丙丞一丝 = "RARITY";
    private static System.Collections.Generic.Dictionary<string, string> 不丐东丏且一丏丗丙;
    private const string 与上丅业丐丙丕丐且 = "V7_WeaponManager.REMEMBERED_UPS_OF_WEAPONS_GIVEN_IN_EVENT";
    internal static System.Collections.Generic.Dictionary<FilterMaps, 丅一丈与丄三丝丝丞> 且专专丁丌丗丛且丙;
    private static System.Collections.Generic.HashSet<string> 与丁丏专世丑与一丑;
    private static bool 丛丛丒丝与万丂丗一;
    private static System.Collections.Generic.Dictionary<FilterMaps, System.Collections.Generic.HashSet<string>> 且与丏业万丌丛丏东;
    private static System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<string>> 东且丗丂丁一东丞下;
    public UnityEngine.GameObject _grenadeWeaponCache;
    public UnityEngine.GameObject _rocketCache;
    public UnityEngine.GameObject _turretCache;
    private static System.Action<三丅丁丗丗丝丂万且> 丟下丌丆万东下专丏;
    private static System.Action<三丅丁丗丗丝丂万且> 与丏世专万丘丁丄丑;
    internal static string 与丗万与专丑一且丘;
    internal static string 业丝丛丂三丄丁与丁;
    internal static string 丑与一世丛丄业丐丒;
    internal static string 与丗世丅东丗丏三丗;
    internal static string 丑丄丘世三丞丁上一;
    internal static string 丛丘丘丕丟一万丛丏;
    internal static string 丁三世丛丑东丙业丅;
    internal static string 丐丘丗丑丄与三丁丒;
    internal static string 丁三丗丁丕万万丏世;
    internal static string 丈专丁一丕丈与丂三;
    internal static string 丘专丐丅丞与丗丞丆;
    internal static string 且丆丑专丅专丐丛丗;
    internal static string 一丐丒丙丌下一三一;
    internal static string 下一丗上丗丆丑丟且;
    internal static string 丒下丄东丌丗三丌丘;
    internal static string 丞业丌丑丂丏专万丕;
    internal static string 丁丒丞下丂丈不丝丟;
    internal static string 不丛专三丐丟丟业丙;
    internal static string 丒与下丝东下丝丅丁;
    internal static string 业世丁上丂丐丏丐丛;
    internal static string 丘丗丛且丝丈丏丗丌;
    internal static string 且专丐丑丞丆丙丅七;
    internal static string 东丟丆万丆丐万丙丙;
    internal static string 专丞丆与丞丟丈丈丏;
    internal static string 业丙不业下丗东丁丟;
    internal static string 丒丗丂丕丆丒丄丟万;
    internal static string 丌业上丐丌丒丗业丛;
    internal static string 东丄专丐与业丘丒丑;
    internal static string 丆丂丑丄东丂不丛与;
    internal static string 业丛专下丙丐丙丕丝;
    internal static string 上丆丕下丂上丏丏丞;
    internal static string 丅且丟丘丄丘丐丈丌;
    internal static string 业丛丑业上丝上丆丙;
    internal static string 东丟不丈丈三丒万丁;
    internal static string 丙下专七专丑丟丝不;
    internal static string 丁丝丁万丛丒业丛业;
    internal static string 专上丟丄丏专丑下万;
    internal static string 丁一丈丙一丐世丈三;
    internal static string 下丛丟丌不东丌七丏;
    internal static string 丏下丁丒与丝丙下丁;
    internal static string 东世丘一丐丏专世下;
    internal static string 与一丅丛丟丝丘下丏;
    internal static string 不丑丄丐业三丝与丂;
    internal static string 丞丌上万丆下东丞七;
    internal static WeaponManager 丟丗丄业丘丗业丗七;
    internal static readonly int 上不专七丞丆丟丒丘;
    public System.Collections.Generic.List<string> shownWeapons;
    public string ServerIp;
    public UnityEngine.GameObject myPlayer;
    internal Player_move_c myPlayerMoveC;
    public UnityEngine.GameObject myGun;
    public UnityEngine.GameObject myTable;
    internal NetworkStartTable myNetworkStartTable;
    private System.Collections.Generic.List<三丅丁丗丗丝丂万且> 万丛丌东与三丅一东;
    internal System.Collections.Generic.List<三丈丟与丏丘丈丐万> 丝丄丂丛七不丐丁东;
    private UnityEngine.Object[] 下下丏专丄丈丌丂丑;
    private UnityEngine.Object[] 不丅丟丈丐七丏三丙;
    private System.Collections.Generic.List<三丈丟与丏丘丈丐万> 丙下丅丒与丈丈丒与;
    private System.Collections.Generic.List<三丈丟与丏丘丈丐万> 丁一丏东七丌丗丁丏;
    private Rilisoft.丝丑丂丛万丐丈丘且 丒七丅丟丟丐业上丄;
    internal static readonly string 丒丆丙一且丂一丙专;
    private WeaponSounds 专丑一业业下且丅丗;
    internal System.Collections.Generic.List<WeaponManager.丌丄丈丕丘丄世且上> 丁丟丌专三上丐丕丙;
    private System.Collections.Generic.List<System.Collections.Generic.List<三丅丁丗丗丝丂万且>> 丈丆丝丁丟与不丁万;
    internal const int 丌丑一七丏上三七丄 = 6;
    private static System.Action<string> 丗不不东丄丌丝万丙;
    internal const string 一丏丆丒丐丅世丈丟 = "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY";
    internal static int 丂丐丛业世丝丁丛丕;
    internal static System.Collections.Generic.HashSet<string> 丅丑丏上丟丌丛丑丐;
    private static bool <专丗丆且丒丙丗丆丐>k__BackingField;
    private static System.Collections.Generic.HashSet<string> 丞丅丟不万七丞丑丌;
    private static System.Collections.Generic.HashSet<string> 东丛专丛丅丒丐丐丄;
    private static System.Collections.Generic.HashSet<string> 万丛丒上三丟丗丞专;
    private static System.Collections.Generic.HashSet<string> 丌丟下丌业丁世万且;
    private float 丑丘丗东丕丐下且专;
    private bool 三丒世丙丙丒丝丟且;
    private static int 三丁丆丑不且丞丅丆;
    private static System.Action 三与丂丙三专丑下丌;
    internal FilterMaps 丅丛丗丒丏丕丞丒丐;
    private bool 丙丐丄丛东七丑万丙;
    internal const string 丙丌丅丝一丞丒丅丘 = "WeaponManager.LastUsedWeaponsKey";
    private static System.Collections.Generic.List<string> 丘万专丏与丙且丘世;
    private int 丆丒丗丈下丕丏下丗;
    private static System.Comparison<三丅丁丗丗丝丂万且> 一不丙丄丕丕七上万;
    private static CategoryNames[] 七丘一丛七丏丏世下;
    internal static readonly System.Collections.Generic.HashSet<string> 东丆丅丘丆丂不丑丆;
    internal static readonly System.Collections.Generic.HashSet<string> 丝丕东丈丞丞下与丆;
    internal static readonly System.Collections.Generic.HashSet<string> 七下下丆丈丌丅丞上;
    private static System.Action 丅且丘丌丟专丞丕七;
    private static System.Action 丛丏三七丁一丞丛与;
    private static System.Action 丈下丑丅丞万七丈丕;
    internal const int 丑专东丙丈丅万丂且 = 3;
    private static bool 丕与丌丙丈丏丟专与;
    private static System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<System.Collections.Generic.List<string>>> 下丆上丐不丘东丗三;
    private static System.Action 上丐丄丆丈丛上不丛;
    private static System.Collections.Generic.List<int> 丐丘丟丒丞上专上东;
    private System.Collections.Generic.List<int> 丂丘专丆专三丒三丑;
    internal static System.Collections.Generic.Dictionary<string, ItemRarity> 世丂丙不丁不丒万且;
    internal static System.Collections.Generic.Dictionary<string, ItemRarity> 丞丗东丒丐不丞丂东;
    internal static System.Collections.Generic.Dictionary<string, int> 业丛丒且丞丞丒丒丂;
    internal static System.Collections.Generic.Dictionary<string, int> 丟世世三万丘丞专不;
    private const string 丟丑世上丄丕丒丆且 = "WeaponManager.REMEMBERED_PENALTIES_KEY";
    internal const string 上东世丌丌三丙且丘 = "WeaponManager.WEAPON_LEVELS_V5_KEY";
    private const string 与丏丑东丅丟丄一七 = "WeaponManager.FIRST_STARS_KEY_210817";
    private const string 丏七丐丁丟丝丐丐丟 = "WeaponManager.WEAPON_LEVELS_KEY";
    internal const string 与下一丘丗丌丌丝世 = "TIER";
    internal const string 丗丈丁世且世丂丈丝 = "LEVEL";
    internal static System.Collections.Generic.Dictionary<string, WeaponManager.与丕丙丄丕丞一丒下> 东东丒丝一一丘且丕;
    private static System.Collections.Generic.Dictionary<string, int> 丘且丘丛东丅专丆万;
    private static int[] 丛万丐丁丁东丆专丗;
    private static System.Collections.Generic.Dictionary<string, Rilisoft.丝丑丂丛万丐丈丘且> 业上丞丞三专七丞上;
    private static System.Collections.Generic.Dictionary<string, int> 业专丂丑不专下三丂;
    private static System.Collections.Generic.Dictionary<string, WeaponManager.丅专上丝与三东丗丝> 丂丁丙专丆丄丐丐丟;
    
    // Properties
    internal static System.Collections.Generic.KeyValuePair<string, long> 丈丆东世东业丝一业 { get; }
    private static bool 世万不丝丄业丒丅丞 { get; }
    internal static System.Collections.Generic.KeyValuePair<string, long> 业丈上与丐七丛丌上 { get; }
    internal static System.Collections.Generic.HashSet<string> 不上丅丁七丒丕与七 { get; }
    private static System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<string>> 东丌丙丏丌丟丐专万 { get; }
    internal bool 丘丂一下丞下不且三 { get; }
    internal static string 丅丁不丁一与丈不丞 { get; }
    internal static string 丅专丒下丁丞丁丁与 { get; }
    internal static string 丄且东不三三丙丗丑 { get; }
    internal static string 丗丈丕丁丛丛丞三丛 { get; }
    internal static string 且丆与丗丛丄七三丂 { get; }
    internal static string 专丗丆世丘丞与丏不 { get; }
    internal static string 且七丘丛丈与七丄七 { get; }
    internal static string 丙丄丄且不丏丛丟丝 { get; }
    internal static string 丌丌且丟世丂世丗七 { get; }
    internal static string 业丗一上一丗下丙丝 { get; }
    internal static string 七丘世三丁丛业下丅 { get; }
    internal static string 丐丛丝丕下丐丙丝丑 { get; }
    internal static string 丞丑丅丏丆东与丙下 { get; }
    internal static string 万丝丐三丈丛丑专丑 { get; }
    internal static string 丆与不丌丒丅上丆丒 { get; }
    internal static string 与不上不丑丝七丒丒 { get; }
    internal static string 丕丕不万丗丝丕丛专 { get; }
    internal static string 专上丅丈丟丏不丕万 { get; }
    internal static string 丟万丕三不丗丏业业 { get; }
    internal static string 丝三三丗上万丈不丞 { get; }
    internal static string 丗一丆丌七一世三且 { get; }
    internal static string 丅丑丛丙东下万专丌 { get; }
    internal static string 万与丟且丈丝丆丂三 { get; }
    internal static string 七丆丗丁上丆上丟上 { get; }
    internal static string 丒丁不七与上丒不丝 { get; }
    internal static string 丕丛丙三丙丂七且丅 { get; }
    internal static string 丅东下丙丆丌丝下七 { get; }
    internal static string 且丂丗上三与与东丁 { get; }
    internal static string 专丞丆丒丞世丐丙丅 { get; }
    internal static string 丂七丄一丈丗丕不丏 { get; }
    internal static string 丘丏丁丑上丏丌丄丏 { get; }
    internal static string 与丝丗丘世丝丏丞业 { get; }
    internal static string 丆三丏不丝一丝丟下 { get; }
    internal static string 丂不丝丗上与专与丙 { get; }
    internal static string 世三丂丂丆丗且丝丘 { get; }
    internal static string 不丑一丛丐丏丏丑丙 { get; }
    internal static string 丝丅七一丐七业丛上 { get; }
    internal static string 且上东万丅与丛丅与 { get; }
    internal static string 丕丁丗丙丙丌不丂世 { get; }
    internal static string 一丅七丂不与东上丈 { get; }
    internal static string 万专业一丞丐丑丕丆 { get; }
    internal static string 丙专上丕专专丄三丝 { get; }
    internal static string 丐与丌三下丄与丘上 { get; }
    internal static string 丂丐丏三丝丝三丙专 { get; }
    internal static string 丐丈业不上丐丗丞丅 { get; }
    internal static string 丒丄丘不丁丕东上不 { get; }
    internal static string 丐一丝丌丅七上世丒 { get; }
    internal static string 丆七专下丗丘丕一丁 { get; }
    internal static string 丄丄不丐东三丁世丂 { get; }
    internal static string 丆世丟且丅且丅丌世 { get; }
    internal static string 丐东业与丛丙不丝世 { get; }
    internal static string 专丏与丙与丐丁业丐 { get; }
    internal static string 三东与丈世与丆丘世 { get; }
    internal static string 丁丒丈丆世丂丅丟丟 { get; }
    internal static string 丑丌东丈丗三丁三丗 { get; }
    internal static string 丞世丛三三丐丄丑丁 { get; }
    internal static string 丑丂一下丛丁世丈丟 { get; }
    internal static string 上丘上东专丗且丞七 { get; }
    internal static string 丅三丟东下业丞七专 { get; }
    internal static string 业丘丒丁万丑丗丛丞 { get; }
    internal static string 丞万一丕丑丆上丆丕 { get; }
    internal static string 世世世丌与丄丗丅世 { get; }
    internal static string 丈丄万万丒丐丐三一 { get; }
    internal static string 上万丛东丟丘三丞下 { get; }
    internal static string 世七丂专丒丆丄世丈 { get; }
    internal static string 上世专丟丕丅三一丗 { get; }
    internal static string 丛丝丌上丅丟丂丟业 { get; }
    internal static string 丄丙三丂万专丛丘丐 { get; }
    internal static string 世丘与丟专丞丈世业 { get; }
    internal static string 专一三丞丈丐专丕丑 { get; }
    internal static string 上上丘丗丈上丕三业 { get; }
    internal static string 丑世丕丁业不丑不不 { get; }
    internal static string 业一丘三丂且丒下专 { get; }
    internal static string 丄丟世丐丁丏世三上 { get; }
    internal static string 三丆丒世丞丈三丑三 { get; }
    internal static string 丌丑丑丌七丆丈七丈 { get; }
    internal static string 丐丝七七东且丄丈丏 { get; }
    internal static string 上一丘下丈业七丁丒 { get; }
    internal static string 丄七丂丈丅丈丘丟丕 { get; }
    internal static string 一丞丘丕丕下丏七业 { get; }
    internal static string 万万丆丂上七丝东丏 { get; }
    internal static string 万下丛丞丐丁与丌丘 { get; }
    internal static string 丈丞丟丁丐丆丙丄世 { get; }
    internal static string 世丑丈丕丒丙下东不 { get; }
    internal static string 丝丂丒专丌三万上下 { get; }
    internal static string 丅三丐万万丄丛且业 { get; }
    internal static string 七丒且业丞丐一丄丌 { get; }
    internal static string 丛丆丑丏丟三七丕与 { get; }
    internal static string 世业丑丗丝丘丏丛丛 { get; }
    internal static string 丘业丏世丅丕七丐三 { get; }
    internal static string 三丗上丁丒一不丞专 { get; }
    internal static string 不丄业丝丂专一丒丗 { get; }
    internal static string 丏下丘丄丏丅不三丗 { get; }
    internal static string 丑业丁丄不丑万一东 { get; }
    internal static string 丘一丒丁且丌丈丌下 { get; }
    internal static string 与上丏东丒丏丛丕业 { get; }
    internal static string 丘丄三万丐丆东丅业 { get; }
    internal static string 丂丑丐丕丟丈不丅丈 { get; }
    internal static string 丝丅丄下世下不丂丐 { get; }
    internal static string 丕丄一丁专三丄万丕 { get; }
    internal static string 专丐三丄丞丞专丙丟 { get; }
    internal static string 业丑不丛丝丏丞丘丟 { get; }
    internal static string 与丂世万丌三世丝丗 { get; }
    internal static string 丘七与丐三丝丛丂丘 { get; }
    internal static string 丐丆业丐世三世与丟 { get; }
    internal static string 丏丁专丟丘丁丞且下 { get; }
    internal static string 丏丘丐丁丏丛上丁万 { get; }
    internal static string 与丒丛世丒丆下上丙 { get; }
    internal static string 东丙丙且丗丟丌丌一 { get; }
    internal static string 丆丑丒三丛丌东万七 { get; }
    internal int 丑丑下丆丈丘丄一万 { get; set; }
    internal 三丈丟与丏丘丈丐万 丟七丈且丙丒丆三上 { get; }
    internal System.Collections.Generic.List<System.Collections.Generic.List<三丅丁丗丗丝丂万且>> 丏万一丙丗业七丕丂 { get; }
    internal static string 且东丟丅丂与丟丑丆 { get; set; }
    internal System.Collections.Generic.List<三丅丁丗丗丝丂万且> 丑丁七世丁丐丑专下 { get; }
    internal System.Collections.Generic.List<三丈丟与丏丘丈丐万> 与丈丞上不丙丈丄下 { get; set; }
    internal System.Collections.Generic.List<三丈丟与丏丘丈丐万> 丌丕丅丅丗丟下丁丆 { get; set; }
    internal WeaponSounds 丆业七丌丁丕一丐七 { get; set; }
    internal static bool 下丌与万丒丏专东丂 { get; set; }
    internal static System.Collections.Generic.HashSet<string> 世丒丄丝丒丙与丂丂 { get; }
    internal static System.Collections.Generic.HashSet<string> 东丏丂丂丈世丛丞丆 { get; }
    internal static System.Collections.Generic.HashSet<string> 上丂丄丑专丐丙丘丅 { get; }
    internal FilterMaps 丕丟丛丈丄丆世丑与 { get; }
    internal bool 上丁且业世丟专丂三 { get; }
    internal static CategoryNames[] 专丌丕丞上丏丅与不 { get; }
    internal static int 丂三丐丙丂丏丗七三 { get; }
    internal static float 丘东丘丗不世且丟丞 { get; }
    internal static System.Collections.Generic.List<float> 丑一丅不业丐丆三业 { get; }
    internal bool 丂一万东业七与丝丗 { get; }
    
    // Methods
    internal static int 世万世七与丐丆七七(string 丒东业不丐丑丕丄丆, out bool 三丂丏丕与丈丙专丝, out bool 丁三丌七丝丞丐专丐, out bool 万丈丞丑东下与世丅)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = 1152921539572768608;
        val_12 = 1152921539572764576;
        三丂丏丕与丈丙专丝 = false;
        丁三丌七丝丞丐专丐 = false;
        万丈丞丑东下与世丅 = false;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丒东业不丐丑丕丄丆)) != false)
        {
                val_13 = 0;
            return (int)val_13.业东丅东丌上丗丑不();
        }
        
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        if(val_2 != null)
        {
                int val_3 = val_2.业东丅东丌上丗丑不();
            val_12 = 1152921539572760544;
        }
        else
        {
                val_14 = null;
            val_14 = null;
            if((WeaponManager.丁丟丟一下专万丒丒.Contains(item:  丒东业不丐丑丕丄丆)) != false)
        {
                val_11 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上();
            val_13 = val_11.Item[丒东业不丐丑丕丄丆];
            int val_7 = val_13.业东丅东丌上丗丑不();
        }
        else
        {
                val_13 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[丒东业不丐丑丕丄丆];
            val_12 = val_11;
        }
        
        }
        
        万丈丞丑东下与世丅 = true;
        return (int)val_13.业东丅东丌上丗丑不();
    }
    internal static System.Collections.Generic.KeyValuePair<string, long> 万一丛七丙丑丄丆丑()
    {
        Progress.专丗丑丞丏不丝东丁 val_1 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
        if(val_1 != null)
        {
                return val_1.丈丆东世东业丝一业();
        }
        
        return val_1.丈丆东世东业丝一业();
    }
    internal static void 丛丞三丙且丁丑丄丗(System.Action<string, CategoryNames> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丁世世丂丗丁丑丐丗, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丁世世丂丗丁丑丐丗 != 1152921505286242352);
    
    }
    internal static void 丕丝丟丘丛与丆万七(System.Action<string, CategoryNames> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丁世世丂丗丁丑丐丗, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丁世世丂丗丁丑丐丗 != 1152921505286242352);
    
    }
    internal static bool 丕专丕丛丌丛丌业丑(string 丒东业不丐丑丕丄丆)
    {
        var val_10;
        if((丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  丒东业不丐丑丕丄丆)) != false)
        {
                val_10 = 1;
            return (bool)val_10;
        }
        
        if((丛且丗丌丏下七下丈.世上万一丌一上丐上(丞一丁业丄一一业且:  丒东业不丐丑丕丄丆)) != false)
        {
                return 上丑三丁丄丛丁万丑.不丛丟丗丐丄丒丑丄();
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                if(GameConnect.世丐丄三三上丅七三() == false)
        {
            goto label_15;
        }
        
        }
        
        val_10 = 0;
        return (bool)val_10;
        label_15:
        三丅丁丗丗丝丂万且 val_5 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        if(val_5 == null)
        {
                return (bool)val_10;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
                return val_5.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  ShopNGUIController.丛丐丛专丟丞万三七());
        }
        
        var val_8 = (val_5.丒万丕七专不丏丞丌() == 5) ? 1 : 0;
        return (bool)val_10;
    }
    internal static string 业丌丗上业丏丛世丙()
    {
        return System.Linq.Enumerable.FirstOrDefault<System.String>(source:  WeaponManager.七世丂丁丆丙丐丆丌(), predicate:  new System.Func<System.String, System.Boolean>(object:  0, method:  static System.Boolean WeaponManager::丕专丕丛丌丛丌业丑(string 丒东业不丐丑丕丄丆)));
    }
    internal static bool 丙丒丐丌一丁业且丟(string 丒东业不丐丑丕丄丆)
    {
        .丒东业不丐丑丕丄丆 = 丒东业不丐丑丕丄丆;
        return System.Linq.Enumerable.Any<丙东丕丌下丄不丐不>(source:  Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丝丟丝丘丙丌丘丕东(), predicate:  new System.Func<丙东丕丌下丄不丐不, System.Boolean>(object:  new WeaponManager.丕丛业丁丏下一七丘(), method:  System.Boolean WeaponManager.丕丛业丁丏下一七丘::一下上丗丙丄丅东一(丙东丕丌下丄不丐不 三丟东丕丄丄下下丑)));
    }
    internal static System.Collections.Generic.List<string> 七世丂丁丆丙丐丆丌()
    {
        var val_10;
        var val_11;
        var val_12;
        val_10 = null;
        val_10 = null;
        WeaponManager.下不且丑上下丗丐世.Clear();
        long val_1 = FriendsController.丝丗专上三不丄丑丑();
        if(val_1 == 1)
        {
                return (System.Collections.Generic.List<System.String>)WeaponManager.下不且丑上下丗丐世;
        }
        
        System.Collections.Generic.List<丙东丕丌下丄不丐不> val_3 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丝丟丝丘丙丌丘丕东();
        val_11 = 0;
        goto label_10;
        label_22:
        if(val_3.Item[0] != null)
        {
                if(val_3.Item[0].下丒丗丄丌丘不丑丘() > val_1)
        {
            goto label_15;
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        WeaponManager.下不且丑上下丗丐世.Add(item:  val_3.Item[0].与不丞丑七丘丁丂丛());
        label_15:
        val_11 = 1;
        label_10:
        if(val_11 < val_3.Count)
        {
            goto label_22;
        }
        
        return (System.Collections.Generic.List<System.String>)WeaponManager.下不且丑上下丗丐世;
    }
    internal static void 三万不上上三一丟丕(string 丒东业不丐丑丕丄丆, bool 七丆丟丗世丟且丒丆 = False, bool 丒三且丟丈七丈丙丏 = False, System.Nullable<PGCompany.丛丈下且丐丝不东丈> 不丌丟专丙丈丟丘专)
    {
        object val_33;
        bool val_79;
        string val_80;
        string val_81;
        string val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        int val_89;
        int val_90;
        int val_91;
        WeaponManager.与丟业一丈上丅上不 val_92;
        var val_93;
        var val_95;
        var val_96;
        var val_98;
        丛且专丞丗丆丙丒万 val_99;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        val_79 = 不丌丟专丙丈丟丘专.HasValue;
        val_80 = 丒东业不丐丑丕丄丆;
        WeaponManager.与丟业一丈上丅上不 val_1 = new WeaponManager.与丟业一丈上丅上不();
        if(val_1 != null)
        {
                val_81 = val_1;
            .丒东业不丐丑丕丄丆 = val_80;
        }
        else
        {
                val_81 = 16;
            mem[16] = val_80;
            val_80 = mem[16];
        }
        
        bool val_6 = 丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  val_81);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  14);
        if(丒三且丟丈七丈丙丏 != true)
        {
                三丅丁丗丗丝丂万且 val_8 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  mem[16]);
            if(val_8 != null)
        {
                val_82 = val_8.三与丛丑且丐丈业丌();
            val_83 = null;
        }
        else
        {
                val_82 = mem[16];
            val_83 = null;
        }
        
            Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  mem[16], 丌丒丝东丌下丕丁丅:  -(BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_82)), 与丘万三东一丄丄丙:  true);
        }
        
        if(val_6 == false)
        {
            goto label_25;
        }
        
        丛且专丞丗丆丙丒万 val_12 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[mem[16]];
        val_84 = null;
        val_84 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_35;
        }
        
        val_85 = null;
        val_85 = null;
        val_86 = UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  0);
        goto label_41;
        label_25:
        val_87 = 1152921505253916672;
        val_88 = 1152921505286238208;
        if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  mem[16])) == false)
        {
            goto label_46;
        }
        
        丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[mem[16]].丒万丕七专不丏丞丌(), 丞一丁业丄一一业且:  mem[16], 七丝下七下丗三且丟:  0, 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  true, 丝丗不东丙不三丄专:  false, 万丐丏丐丒万不丟三:  0, 丄下丁东丘业丆丝上:  0, 不丐丅丁丂七丐丘丛:  0);
        丟丄七万东与上丒丟 val_21 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[mem[16]];
        val_87 = val_79;
        if(val_21 == null)
        {
            goto label_57;
        }
        
        val_89 = val_21.业东丅东丌上丗丑不();
        val_90 = val_21.丈丒丟下丂丒东与丑();
        val_91 = val_21.七东与丄丕丁丛世三();
        goto label_58;
        label_46:
        WeaponManager.丟业丒丈万与业丞丝(丆不丁东不丄丗丄世:  mem[16], 丄下丁东丘业丆丝上:  0, 丑东与丅丐丅丂丞业:  public System.Boolean System.Collections.Generic.Dictionary<System.String, 丟丄七万东与上丒丟>::ContainsKey(System.String key), 不丐丅丁丂七丐丘丛:  34);
        if(val_1 == null)
        {
            goto label_62;
        }
        
        WeaponManager.专丗丏三丘上一丒丈(丒东业不丐丑丕丄丆:  mem[16]);
        goto label_63;
        label_35:
        val_86 = 0;
        label_41:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丑东下上丏丄万丈上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞一丁业丄一一业且:  val_12.上七不丅丈丁不丛丝.业东丅东丌上丗丑不(), 下丒专丅丝丄丑不丏:  1, 丙丒世丂下三丑丛丝:  0, 丟下丟丈万一丙东丄:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_12.上七不丅丈丁不丛丝.丑丗丁丞丒丂与丙丈), 丑东与丅丐丅丂丞业:  "", 下丗丁丒丘东丂不丑:  150000.ToString());
        Dictionary.Enumerator<TKey, TValue> val_30 = val_12.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.GetEnumerator();
        val_87 = 1152921539018831280;
        label_77:
        if((607473216 & 1) == 0)
        {
            goto label_74;
        }
        
        ConfiguredValueTaskAwaiter val_34 = val_33.GetAwaiter();
        丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  val_34._value._obj.丙东专丂世丈丏丁丂(), 丞一丁业丄一一业且:  val_34._value._obj, 七丝下七下丗三且丟:  0, 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  true, 丝丗不东丙不三丄专:  false, 万丐丏丐丒万不丟三:  0, 丄下丁东丘业丆丝上:  0, 不丐丅丁丂七丐丘丛:  0);
        丆丟七丌丞东丆丕丌.丈且丗七丐丟上丌丒(丒东业不丐丑丕丄丆:  val_34._value._obj, 丙丑丕丂下丏一丁专:  val_34._value._obj.丙东专丂世丈丏丁丂(), 丆万丐丗丅丘丆丁丌:  false);
        goto label_77;
        label_57:
        val_89 = val_21.业东丅东丌上丗丑不();
        val_90 = val_21.丈丒丟下丂丒东与丑();
        val_91 = val_21.七东与丄丕丁丛世三();
        label_58:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丑东下上丏丄万丈上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞一丁业丄一一业且:  val_89, 下丒专丅丝丄丑不丏:  val_90, 丙丒世丂下三丑丛丝:  val_91, 丟下丟丈万一丙东丄:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_21.丛丈丅丞丏丅丛丛丐()), 丑东与丅丐丅丂丞业:  "FinishCraftingWeaponOrAvatar", 下丗丁丒丘东丂不丑:  val_21.丒万丕七专不丏丞丌().ToString());
        val_92 = val_1;
        val_79 = val_87;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_177;
        }
        
        val_93 = null;
        val_93 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.七丟与下丅上丈东业(下丈丝丁丟下世丐丒:  false);
        goto label_177;
        label_62:
        WeaponManager.专丗丏三丘上一丒丈(丒东业不丐丑丕丄丆:  mem[16]);
        label_63:
        三丅丁丗丗丝丂万且 val_45 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  mem[16]);
        if(val_45 != null)
        {
                val_87 = val_79;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.Analytics.一业丗丆世世上丁且.丑东下上丏丄万丈上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞一丁业丄一一业且:  val_45.业东丅东丌上丗丑不(), 下丒专丅丝丄丑不丏:  val_45.七丑丌专丒上丒丙七().丈一下下丞世三丑丄(), 丙丒世丂下三丑丛丝:  val_45, 丟下丟丈万一丙东丄:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_45.丗丗与丅丈且与丟丏()), 丑东与丅丐丅丂丞业:  "FinishCraftingWeaponOrAvatar", 下丗丁丒丘东丂不丑:  val_45.丒万丕七专不丏丞丌().ToString());
            val_81 = val_81;
            val_88 = 1152921505286238208;
            val_79 = val_87;
        }
        
        val_92 = val_1;
        WeaponManager.丟丗丄业丘丗业丗七.丒丆丟丒丞下不丗与();
        WeaponManager.东一业丅丝丕丏业世(丒东业不丐丑丕丄丆:  val_81);
        goto label_177;
        label_74:
        val_79 = val_79;
        val_92 = val_1;
        val_95 = 0;
        val_96 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_158;
        }
        
        if( == 0)
        {
            goto label_162;
        }
        
        if(338 != 338)
        {
            goto label_160;
        }
        
        goto label_162;
        label_158:
        if( == 0)
        {
            goto label_162;
        }
        
        label_160:
        label_162:
        丆丟七丌丞东丆丕丌.丈且丗七丐丟上丌丒(丒东业不丐丑丕丄丆:  "Armor_Army_1", 丙丑丕丂下丏一丁专:  7, 丆万丐丗丅丘丆丁丌:  false);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  1)) != true)
        {
                new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  70, 丞丅上丏丂且下丅与:  1);
            PGCompany.丗丟丄丈东丝丕丄世 val_59 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄());
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_98 = null;
            val_98 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.七丟与下丅上丈东业(下丈丝丁丟下世丐丒:  false);
        }
        
        PersConfigurator.与与丑丂丛上七上丗();
        label_177:
        val_99 = 1152921517987147792;
        bool val_78 = val_6;
        val_78 = val_78 | (WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  mem[16]));
        if(val_78 == false)
        {
            goto label_255;
        }
        
        val_100 = null;
        val_100 = null;
        if((WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  mem[16])) == true)
        {
            goto label_255;
        }
        
        val_101 = null;
        val_101 = null;
        if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  mem[16])) == true)
        {
            goto label_255;
        }
        
        System.Func<丛且专丞丗丆丙丒万, System.Boolean> val_68 = new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.与丟业一丈上丅上不::丘丁丘丞丏世丄一丘(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌));
        val_99 = System.Linq.Enumerable.First<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  null);
        System.Collections.Generic.Dictionary<CategoryNames, System.String> val_70 = 丙丞丟丑丗丅专丈一.丂丙丟丅七七丗丄与(丂万丏专丒下丈丂丟:  val_99);
        val_87 = 1152921524422708400;
        if(val_69.上七不丅丈丁不丛丝 == null)
        {
            goto label_215;
        }
        
        val_102 = val_69.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.Count;
        if(val_70 != null)
        {
            goto label_220;
        }
        
        goto label_218;
        label_215:
        val_102 = 0;
        if(val_70 != null)
        {
            goto label_220;
        }
        
        label_218:
        label_220:
        if((val_102 + val_69.丝丈不丗丐不丙丟丁.Count) == val_70.Count)
        {
                Rilisoft.一丟专且三万丞丁丂.且下且丟丞丝丆丘世(丐世下不一丁丟丅专:  val_69.下丄丈不与世丐业专);
        }
        
        label_255:
        if( != false)
        {
                PGCompany.三东丏不丗世丅丌丄 val_75 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  WeaponManager.世万世七与丐丆七七(丒东业不丐丑丕丄丆:  val_80, 三丂丏丕与丈丙专丝: out  false, 丁三丌七丝丞丐专丐: out  false, 万丈丞丑东下与世丅: out  false));
            PGCompany.世东三上七丂丌下丑.东丐丗三丛丟三丁七(丅一丘丙上东丏丅不:  new 丕丝丝丝丅丕专丅丝() {且丝丕丆不丅丏丛东 = new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = false}});
        }
        
        WeaponManager.丛世丝万丌丄上丒丅(丒东业不丐丑丕丄丆:  mem[16]);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_257:
        val_103 = ;
        label_246:
        if(123444064 != 1)
        {
            goto label_257;
        }
        
        if((null & 1) == 0)
        {
            goto label_248;
        }
        
        object[] val_77 = new object[1];
        val_77[0] = ;
        UnityEngine.Debug.LogErrorFormat(format:  "Exception in setting set crafted analytics: {0}", args:  val_77);
        goto label_255;
        label_248:
        mem[8] = ;
        goto label_246;
    }
    internal static void 丛世丝万丌丄上丒丅(string 丒东业不丐丑丕丄丆)
    {
        null = null;
        if(WeaponManager.丁世世丂丗丁丑丐丗 == null)
        {
                return;
        }
        
        WeaponManager.丁世世丂丗丁丑丐丗.Invoke(arg1:  丒东业不丐丑丕丄丆, arg2:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆));
    }
    internal static void 东一业丅丝丕丏业世(string 丒东业不丐丑丕丄丆)
    {
        object val_15;
        var val_16;
        System.Func<TSource, System.Boolean> val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        WeaponManager.丒业丛丟专丛丒与东 val_1 = null;
        val_15 = val_1;
        val_1 = new WeaponManager.丒业丛丟专丛丒与东();
        .丒东业不丐丑丕丄丆 = 丒东业不丐丑丕丄丆;
        val_16 = null;
        val_16 = null;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_3 = null;
        val_17 = val_3;
        val_3 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.丒业丛丟专丛丒与东::丕丌丙且丂下东丏丄(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        三丈丟与丏丘丈丐万 val_4 = System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  System.Linq.Enumerable.OfType<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.丁一丏东七丌丗丁丏), predicate:  val_3);
        if(val_4 == null)
        {
                return;
        }
        
        if(GameConnect.世丐丄三三上丅七三() == true)
        {
            goto label_13;
        }
        
        val_18 = null;
        val_18 = null;
        if((val_4.三丐三丞丘丕不丒专.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐)) == false)
        {
            goto label_13;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
            goto label_37;
        }
        
        var val_9 = (val_4.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == 5) ? 0 : 4;
        goto label_37;
        label_13:
        val_19 = 4;
        label_37:
        val_20 = null;
        val_20 = null;
        val_17 = System.Linq.Enumerable.OfType<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.丙下丅丒与丈丈丒与);
        if((val_19 & 7) != 0)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<三丈丟与丏丘丈丐万>(source:  val_17, predicate:  new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.丒业丛丟专丛丒与东::丌上丗专丕丑丕丗专(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)))) == true)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        val_17 = WeaponManager.丟丗丄业丘丗业丗七;
        val_17.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_4, 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        val_15 = (WeaponManager.丒业丛丟专丛丒与东)[1152921539574617600].丒东业不丐丑丕丄丆;
        ShopNGUIController.三丟不东丆万七三与(下丅丙一丂丗丅丝七:  val_15);
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_15 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_15.东丂丈与丄丛万丞丑() == null)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
    }
    internal static 丆丘丞不丒七丆与不 万七丂丑丙丘丌丙丟(string 丞一丁业丄一一业且)
    {
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_15 = 丞一丁业丄一一业且;
        PGCompany.丟丁且丝丁三丏丙且 val_8 = 0;
        if(val_15 == null)
        {
            goto label_18;
        }
        
        val_16 = null;
        val_16 = null;
        if((val_15.StartsWith(value:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒)) != false)
        {
                val_17 = 2;
            return (丆丘丞不丒七丆与不)val_17;
        }
        
        val_18 = null;
        val_18 = null;
        if((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  val_15)) == false)
        {
            goto label_18;
        }
        
        val_15 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_15);
        if(val_15 == null)
        {
                return (丆丘丞不丒七丆与不)val_17;
        }
        
        if(val_15.七丑丌专丒上丒丙七() == null)
        {
            goto label_13;
        }
        
        label_18:
        val_17 = 0;
        return (丆丘丞不丒七丆与不)val_17;
        label_13:
        bool val_9 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆().TryGetValue(下上丐丆丝丟丝丒不:  val_15.业东丅东丌上丗丑不(), 丙业与丙丗丝不丈东: out  val_8);
        if(val_8 == 0)
        {
            goto label_18;
        }
        
        丞丂丘丒丟丞丑下丄 val_11 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_11 != null)
        {
                val_19 = val_11.世丝丌一且丝专丑丛();
        }
        else
        {
                val_19 = 0;
        }
        
        var val_14 = (val_19 < val_8.世丝丌一且丝专丑丛()) ? (1 + 1) : 1;
        return (丆丘丞不丒七丆与不)val_17;
    }
    internal static void 丄与丒东七丁丐一东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.东丄三丆丌丟下丛一, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.东丄三丆丌丟下丛一 != 1152921505286242368);
    
    }
    internal static void 丙丑丕上上丁丈世不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.东丄三丆丌丟下丛一, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.东丄三丆丌丟下丛一 != 1152921505286242368);
    
    }
    internal static void 丂万丆与丕丈丒下丏(System.Action<三丅丁丗丗丝丂万且, 丕丑丙丑丙东丌丘丕, 丕丑丙丑丙东丌丘丕, bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丈丙丌丝丑一丗下丂, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丈丙丌丝丑一丗下丂 != 1152921505286242376);
    
    }
    internal static void 丑丆丌业丕丝世与丟(System.Action<三丅丁丗丗丝丂万且, 丕丑丙丑丙东丌丘丕, 丕丑丙丑丙东丌丘丕, bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丈丙丌丝丑一丗下丂, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丈丙丌丝丑一丗下丂 != 1152921505286242376);
    
    }
    internal static void 东丞丌丅丏业东且丕(System.Action<bool, 三丅丁丗丗丝丂万且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丛与丅丘丛丆且与丛, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丛与丅丘丛丆且与丛 != 1152921505286242384);
    
    }
    internal static void 丈业下丘丈不且丞丙(System.Action<bool, 三丅丁丗丗丝丂万且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丛与丅丘丛丆且与丛, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丛与丅丘丛丆且与丛 != 1152921505286242384);
    
    }
    internal static void 丗世丁与丗丂东东丙(System.Action<三丅丁丗丗丝丂万且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丗业丘丘丏七丟丆一, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丗业丘丘丏七丟丆一 != 1152921505286242392);
    
    }
    internal static void 丅万丑且三丁丑丛世(System.Action<三丅丁丗丗丝丂万且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丗业丘丘丏七丟丆一, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丗业丘丘丏七丟丆一 != 1152921505286242392);
    
    }
    internal static bool 丒上丙丕一丘三万丄(string 三不三丟专丘东东丂)
    {
        string val_6;
        var val_7;
        val_6 = 三不三丟专丘东东丂;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == true)
        {
            goto label_3;
        }
        
        val_6 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_6);
        if(val_6 == null)
        {
                return (bool)val_7;
        }
        
        if(val_6.七丑丌专丒上丒丙七() == null)
        {
            goto label_7;
        }
        
        label_3:
        val_7 = 0;
        return (bool)val_7;
        label_7:
        var val_5 = (ExperienceController.丞丞丘业东丙丏七丌() < val_6) ? 1 : 0;
        return (bool)val_7;
    }
    private static string 丞上世丌上万丗丞世(int 一丙专三丁世丌丝丂)
    {
        int val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        System.Predicate<三丅丁丗丗丝丂万且> val_36;
        var val_37;
        System.Func<三丅丁丗丗丝丂万且, 三丅丁丗丗丝丂万且> val_39;
        val_28 = 一丙专三丁世丌丝丂;
        val_29 = null;
        val_29 = null;
        val_30 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return (string)val_30;
        }
        
        val_31 = null;
        val_31 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丈不丒丘丌丏丕丞丅() != null)
        {
                val_32 = null;
            val_32 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.丈不丒丘丌丏丕丞丅().Count > val_28)
        {
                val_33 = null;
            val_33 = null;
            System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  WeaponManager.丟丗丄业丘丗业丗七.丈不丒丘丌丏丕丞丅().Item[val_28]);
            System.Collections.Generic.List<TSource> val_8 = val_7;
            上丑三丁丄丛丁万丑.丆丏七三三上世丂一(丝丘丑业丛万丞丌丝:  val_7, 丙丑丄与丅丐一不东:  true, 七丆丒与丗丌丄且丂:  val_28);
            上丑三丁丄丛丁万丑.丞丘丑丗万丙丄丂丙(丝丘丑业丛万丞丌丝: ref  val_8);
            if(上丑三丁丄丛丁万丑.丌丂专丐丈丁丅丄世() != true)
        {
                val_34 = null;
            val_34 = null;
            val_36 = WeaponManager.<>c.<>9__35_0;
            if(val_36 == null)
        {
                System.Predicate<三丅丁丗丗丝丂万且> val_10 = null;
            val_36 = val_10;
            val_10 = new System.Predicate<三丅丁丗丗丝丂万且>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丁业东丟东丟三丑下(三丅丁丗丗丝丂万且 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__35_0 = val_36;
        }
        
            int val_11 = val_8.RemoveAll(match:  val_10);
        }
        
            int val_13 = val_8.RemoveAll(match:  new System.Predicate<三丅丁丗丗丝丂万且>(object:  0, method:  static System.Boolean 上丑三丁丄丛丁万丑::丄丄七万丅丝丆丟丒(三丅丁丗丗丝丂万且 下丅丙一丂丗丅丝七)));
            val_37 = null;
            val_37 = null;
            val_39 = WeaponManager.<>c.<>9__35_1;
            if(val_39 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, 三丅丁丗丗丝丂万且> val_14 = null;
            val_39 = val_14;
            val_14 = new System.Func<三丅丁丗丗丝丂万且, 三丅丁丗丗丝丂万且>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  三丅丁丗丗丝丂万且 WeaponManager.<>c::丆丏丝上东丙丕上三(三丅丁丗丗丝丂万且 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__35_1 = val_39;
        }
        
            val_28 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Select<三丅丁丗丗丝丂万且, 三丅丁丗丗丝丂万且>(source:  val_8, selector:  val_14));
            if(val_28.Count >= 1)
        {
                int val_19 = val_28.Count - 1;
            if((val_19 & 2147483648) == 0)
        {
                do
        {
            val_30 = val_28.Item[val_19].与不丞丑七丘丁丂丛();
            if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(val_28.Item[val_19].丐七丐丝与丒七丈丐().丈一下下丞世三丑丄() <= ExperienceController.丞丞丘业东丙丏七丌())
        {
                return (string)val_30;
        }
        
        }
        
            val_19 = val_19 - 1;
        }
        while((val_19 & 2147483648) == 0);
        
        }
        
        }
        
        }
        
        }
        
        val_30 = 0;
        return (string)val_30;
    }
    internal static string 丘丄丂与且世丕丅专(CategoryNames 业三一丌丛丅下丗丁, out CategoryNames 丕丝丗丅丘上七丞万)
    {
        var val_6;
        var val_7;
        var val_8;
        丕丝丗丅丘上七丞万 = 业三一丌丛丅下丗丁;
        if((WeaponManager.丞上世丌上万丗丞世(一丙专三丁世丌丝丂:  业三一丌丛丅下丗丁)) != null)
        {
                return (string)val_6;
        }
        
        val_7 = null;
        val_7 = null;
        if(Count >= 1)
        {
                val_8 = null;
            val_8 = null;
            三丈丟与丏丘丈丐万 val_3 = Item[0];
            三丅丁丗丗丝丂万且 val_6 = val_3.三丐三丞丘丕不丒专;
            val_6 = val_6.万上丄下业丛丌不丈() - 1;
            string val_5 = WeaponManager.丞上世丌上万丗丞世(一丙专三丁世丌丝丂:  val_6);
            丕丝丗丅丘上七丞万 = val_6;
            return (string)val_6;
        }
        
        val_6 = 0;
        return (string)val_6;
    }
    internal static System.Collections.Generic.HashSet<string> 丏不丆丌丅丕丐丝丟()
    {
        System.Collections.Generic.HashSet<T> val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_15;
        var val_16;
        System.Func<三丅丁丗丗丝丂万且, System.String> val_18;
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丏丈丆一三丟世世丝 == null)
        {
                string[] val_1 = new string[11];
            val_11 = null;
            val_11 = null;
            val_1[0] = 与世丁丙且丑下丌不.一专丂丏丒丄丙丗一;
            val_1[1] = 与世丁丙且丑下丌不.丗不丆丙万七万丛丘;
            val_1[2] = 与世丁丙且丑下丌不.下不丝丐丙与丕丘丌;
            val_1[3] = 与世丁丙且丑下丌不.专三与丗东七丂丆丙;
            val_1[4] = 与世丁丙且丑下丌不.东下丕丅三与丙一三;
            val_1[5] = 与世丁丙且丑下丌不.丗丐丒上专丅丐丆丈;
            val_12 = null;
            val_12 = null;
            val_1[6] = WeaponManager.丑与一世丛丄业丐丒;
            val_1[7] = 与世丁丙且丑下丌不.丘上丙三丐丁丞丅丌;
            val_1[8] = 与世丁丙且丑下丌不.丌一东丏丐三丑三东;
            val_1[9] = 与世丁丙且丑下丌不.丘三丄丟丑业丏丄万;
            val_1[10] = "pixelgun_old";
            val_13 = null;
            val_13 = null;
            val_15 = WeaponManager.<>c.<>9__37_0;
            if(val_15 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_3 = null;
            val_15 = val_3;
            val_3 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::上丆丛丕不丟丞万丘(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
            WeaponManager.<>c.<>9__37_0 = val_15;
        }
        
            val_16 = null;
            val_16 = null;
            val_18 = WeaponManager.<>c.<>9__37_1;
            if(val_18 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, System.String> val_5 = null;
            val_18 = val_5;
            val_5 = new System.Func<三丅丁丗丗丝丂万且, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::丝七七下专丒丐三丁(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
            WeaponManager.<>c.<>9__37_1 = val_18;
        }
        
            System.Collections.Generic.HashSet<System.String> val_8 = null;
            val_9 = val_8;
            val_8 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.Union<System.String>(first:  val_1, second:  System.Linq.Enumerable.Select<三丅丁丗丗丝丂万且, System.String>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丛丐专不世丂丝与三(), predicate:  val_3), selector:  val_5)));
            val_10 = null;
            val_10 = null;
            WeaponManager.丏丈丆一三丟世世丝 = val_9;
        }
        
        val_10 = null;
        return (System.Collections.Generic.HashSet<System.String>)WeaponManager.丏丈丆一三丟世世丝;
    }
    internal static 丕丑丙丑丙东丌丘丕 丝丒丂丂丏丞一与丆(ItemRarity 丈下丑丆上丏丗丈专)
    {
        return (丕丑丙丑丙东丌丘丕)new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  ExperienceController.丞丞丘业东丙丏七丌(), 丏丆丐丑专与丄丘丞:  丈下丑丆上丏丗丈专);
    }
    internal static bool 丈丏且一与东三丐丞(string 丒东业不丐丑丕丄丆)
    {
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return false;
        }
        
        if(GameConnect.世丐丄三三上丅七三() != false)
        {
                return false;
        }
        
        三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        if(val_3 == null)
        {
                return false;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
                return val_3.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  ShopNGUIController.丛丐丛专丟丞万三七());
        }
        
        var val_6 = (val_3.丒万丕七专不丏丞丌() == 5) ? 1 : 0;
        return false;
    }
    private static bool 业东丛与丙丑三下丐()
    {
        return false;
    }
    internal static System.Collections.Generic.KeyValuePair<string, long> 且且丟丗丏与世万丏()
    {
        Progress.专丗丑丞丏不丝东丁 val_1 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
        if(val_1 != null)
        {
                return val_1.业丈上与丐七丛丌上();
        }
        
        return val_1.业丈上与丐七丛丌上();
    }
    internal static void 七丟不丌丒三三丟丙(long 丆丐七丅丆丗丛上与)
    {
    
    }
    internal static void 丂丗丂丞且丄业与丄(三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且, Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 世丙与专七丟丒丆世, bool 丝丗不东丙不三丄专 = False, bool 一三世且与专丕丆丂 = False, 丕丑丙丑丙东丌丘丕 丄下丁东丘业丆丝上, string 世丁丙世丄一万丆三 = "")
    {
        丕丑丙丑丙东丌丘丕 val_17;
        七专丁丕世丏丁丘丛 val_18;
        var val_19;
        var val_20;
        val_17 = 丄下丁东丘业丆丝上;
        val_18 = 世丙与专七丟丒丆世;
        if(丝丂丁丌丆三丆专且 == null)
        {
                return;
        }
        
        丕丑丙丑丙东丌丘丕 val_3 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  丝丂丁丌丆三丆专且.业东丅东丌上丗丑不());
        if(val_17 == null)
        {
                if(val_3 != null)
        {
                val_17 = BalanceController.丌丛丄丙丘丈与下专(丞丌东丟且丒丐丑丂:  val_3, 丐丏上业丈丂与万丞:  false);
        }
        else
        {
                if(丝丂丁丌丆三丆专且.东七与与不丅丙上上() != false)
        {
                val_17 = new 丕丑丙丑丙东丌丘丕();
            val_17 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  丝丂丁丌丆三丆专且);
        }
        else
        {
                if(丝丗不东丙不三丄专 != false)
        {
                val_17 = WeaponManager.丝丒丂丂丏丞一与丆(丈下丑丆上丏丗丈专:  丝丂丁丌丆三丆专且);
        }
        else
        {
                val_17 = 丝丂丁丌丆三丆专且.丐七丐丝与丒七丈丐();
        }
        
        }
        
        }
        
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  220)) != false)
        {
                val_19 = null;
            val_19 = null;
            if((System.String.op_Equality(a:  丝丂丁丌丆三丆专且.与不丞丑七丘丁丂丛(), b:  与世丁丙且丑下丌不.七丒丞丙丏三业丐丙)) != false)
        {
                val_17 = new 丕丑丙丑丙东丌丘丕();
            val_17 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  丝丂丁丌丆三丆专且);
        }
        
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三下丗万丆专丄且东(下且与丐上丟七丑丏:  丝丂丁丌丆三丆专且.业东丅东丌上丗丑不(), 丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(), 世丙与专七丟丒丆世:  val_18, 世丁丙世丄一万丆三:  世丁丙世丄一万丆三);
        val_18 = 1152921505286238208;
        val_20 = null;
        val_20 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丒丆丟丒丞下不丗与();
        if(WeaponManager.丈丙丌丝丑一丗下丂 == null)
        {
                return;
        }
        
        WeaponManager.丈丙丌丝丑一丗下丂.Invoke(arg1:  丝丂丁丌丆三丆专且, arg2:  val_3, arg3:  new 丕丑丙丑丙东丌丘丕(), arg4:  (val_3 == 0) ? 1 : 0);
    }
    internal static void 丟业丒丈万与业丞丝(string 丆不丁东不丄丗丄世, 丕丑丙丑丙东丌丘丕 丄下丁东丘业丆丝上, string 丑东与丅丐丅丂丞业, Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 不丐丅丁丂七丐丘丛)
    {
        var val_6;
        ShopNGUIController val_7;
        var val_8;
        三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丆不丁东不丄丗丄世);
        if(val_1 != null)
        {
                int val_2 = val_1.万上丄下业丛丌不丈();
            val_2 = val_2 - 1;
            丐一且丝丂丟丞三丅.丂七丗丒丅世丒丌下(七丆丒与丗丌丄且丂:  val_2, 丞一丁业丄一一业且:  丆不丁东不丄丗丄世, 七丝下七下丗三且丟:  0, 丁丌业丂丐与丌丑丂:  0, 丁且丟不七下丆丒丟:  false, 丝丗不东丙不三丄专:  true, 万丐丏丐丒万不丟三:  0, 丄下丁东丘业丆丝上:  丄下丁东丘业丆丝上, 不丐丅丁丂七丐丘丛:  不丐丅丁丂七丐丘丛);
            val_6 = null;
            val_6 = null;
            val_7 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            if(val_7 == 0)
        {
                return;
        }
        
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
            val_8 = null;
            val_8 = null;
            val_7 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            val_7.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
            return;
        }
        
        object[] val_5 = new object[1];
        val_5[0] = 丆不丁东不丄丗丄世;
        UnityEngine.Debug.LogErrorFormat(format:  "AddEventW_eapon rec == null, appropr_iateTag = {0}", args:  val_5);
    }
    internal static void 丌丐东业世上丗丅丅()
    {
        var val_23;
        WeaponManager val_24;
        var val_25;
        var val_26;
        WeaponManager val_27;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_28;
        var val_29;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_31;
        var val_32;
        var val_33;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_34;
        var val_35;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_37;
        var val_38;
        var val_39;
        var val_40;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_42;
        var val_43;
        var val_44;
        val_23 = null;
        val_23 = null;
        val_24 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_24 == 0)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        val_24 = WeaponManager.丟丗丄业丘丗业丗七;
        if(null == 0)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_27 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_27 != null)
        {
                val_28 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 136];
            val_28 = WeaponManager.丟丗丄业丘丗业丗七.丙下丅丒与丈丈丒与;
        }
        else
        {
                val_28 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 136];
            val_28 = WeaponManager.丟丗丄业丘丗业丗七.丙下丅丒与丈丈丒与;
            if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                val_27 = WeaponManager.丟丗丄业丘丗业丗七;
        }
        else
        {
                val_27 = 0;
        }
        
        }
        
        val_24 = 123438416;
        val_29 = null;
        val_29 = null;
        val_31 = WeaponManager.<>c.<>9__59_0;
        if(val_31 == null)
        {
                val_31 = null;
            val_31 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丙一专世丛七不上东(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__59_0 = val_31;
        }
        
        if((System.Linq.Enumerable.Any<三丈丟与丏丘丈丐万>(source:  val_28, predicate:  null)) != true)
        {
                new WeaponManager.下世丗丈丞丂丐丐丘() = new WeaponManager.下世丗丈丞丂丐丐丘();
            val_32 = null;
            val_32 = null;
            .丟丈一下东业一丝丆 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.专三与丗东七丂丆丙).三与丛丑且丐丈业丌();
            val_33 = null;
            val_33 = null;
            val_34 = null;
            val_34 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new WeaponManager.下世丗丈丞丂丐丐丘(), method:  System.Boolean WeaponManager.下世丗丈丞丂丐丐丘::丄丙上专丄丙丛丐丏(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.丟丗丄业丘丗业丗七.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  System.Linq.Enumerable.First<三丈丟与丏丘丈丐万>(source:  val_24, predicate:  null), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        }
        
        val_35 = null;
        val_35 = null;
        val_37 = WeaponManager.<>c.<>9__59_1;
        if(val_37 == null)
        {
                val_37 = null;
            val_37 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::上丝丄丁丅世下丂世(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__59_1 = val_37;
        }
        
        if((System.Linq.Enumerable.Any<三丈丟与丏丘丈丐万>(source:  val_28, predicate:  null)) != true)
        {
                new WeaponManager.丐上丌丛丑丛丗上丈() = new WeaponManager.丐上丌丛丑丛丗上丈();
            val_38 = null;
            val_38 = null;
            .丟丈一下东业一丝丆 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.丗丐丒上专丅丐丆丈).三与丛丑且丐丈业丌();
            val_39 = null;
            val_39 = null;
            val_34 = null;
            val_34 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new WeaponManager.丐上丌丛丑丛丗上丈(), method:  System.Boolean WeaponManager.丐上丌丛丑丛丗上丈::丒丗与丏下一专与丄(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.丟丗丄业丘丗业丗七.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  System.Linq.Enumerable.First<三丈丟与丏丘丈丐万>(source:  val_24, predicate:  null), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        }
        
        val_40 = null;
        val_40 = null;
        val_42 = WeaponManager.<>c.<>9__59_2;
        if(val_42 == null)
        {
                val_42 = null;
            val_42 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丕世丕与且东丒丅丕(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__59_2 = val_42;
        }
        
        if((System.Linq.Enumerable.Any<三丈丟与丏丘丈丐万>(source:  val_28, predicate:  null)) == true)
        {
                return;
        }
        
        new WeaponManager.丕丟丂丄业丙丅上三() = new WeaponManager.丕丟丂丄业丙丅上三();
        val_43 = null;
        val_43 = null;
        .丟丈一下东业一丝丆 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.东下丕丅三与丙一三).三与丛丑且丐丈业丌();
        val_44 = null;
        val_44 = null;
        val_42 = WeaponManager.丟丗丄业丘丗业丗七;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_21 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new WeaponManager.丕丟丂丄业丙丅上三(), method:  System.Boolean WeaponManager.丕丟丂丄业丙丅上三::丑丈业丁丞万丁丈专(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        val_24 = System.Linq.Enumerable.First<三丈丟与丏丘丈丐万>(source:  val_24, predicate:  null);
        val_42.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_24, 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
    }
    internal static string 丘丁丒上丑世丙丟丆(FilterMaps 专丆丌丛东一不丑丙)
    {
        return (string)System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}_SettingWSSN", arg0:  专丆丌丛东一不丑丙);
    }
    internal static System.Collections.Generic.HashSet<string> 丁下一丆丙不世七三()
    {
        var val_4;
        var val_5;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_21;
        val_14 = null;
        val_14 = null;
        if(WeaponManager.与丁丏专世丑与一丑 != null)
        {
            goto label_41;
        }
        
        System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
        val_15 = null;
        val_15 = null;
        WeaponManager.与丁丏专世丑与一丑 = val_1;
        Dictionary.Enumerator<TKey, TValue> val_2 = WeaponManager.且专专丁丌丗丛且丙.GetEnumerator();
        val_13 = 0;
        val_16 = 0;
        var val_12 = 0;
        label_26:
        if((611505616 & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if(val_4 == 0)
        {
            goto label_26;
        }
        
        HashSet.Enumerator<T> val_9 = WeaponManager.不丗丒丏丄丐丁丑下(专丆丌丛东一不丑丙:  val_6._value._obj.丙东专丂世丈丏丁丂()).GetEnumerator();
        label_17:
        if((611505568 & 1) == 0)
        {
            goto label_13;
        }
        
        val_17 = null;
        val_17 = null;
        bool val_11 = val_1.Add(item:  val_5.丐丏七丌丕丗业且上());
        goto label_17;
        label_13:
        val_12 = val_12 + 1;
        mem2[0] = 120;
        val_18 = val_16;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_12 == 1) || ((1152921539578090848 + ((0 + 1)) << 2) != 120))
        {
            goto label_23;
        }
        
        var val_13 = 0;
        val_13 = val_13 ^ (val_12 >> 31);
        val_12 = val_12 + val_13;
        goto label_26;
        label_23:
        if( == 0)
        {
            goto label_26;
        }
        
        goto label_26;
        label_7:
        val_12 = val_12 + 1;
        mem2[0] = 145;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_12 == 1)
        {
            goto label_35;
        }
        
        if(( == 0) || ((1152921539578090848 + ((0 + 1)) << 2) == 145))
        {
            goto label_41;
        }
        
        label_40:
        label_41:
        val_21 = null;
        val_21 = null;
        return (System.Collections.Generic.HashSet<System.String>)WeaponManager.与丁丏专世丑与一丑;
        label_35:
        if( != 0)
        {
            goto label_40;
        }
        
        goto label_41;
    }
    internal static System.Collections.Generic.HashSet<string> 不丗丒丏丄丐丁丑下(FilterMaps 专丆丌丛东一不丑丙)
    {
        var val_5;
        System.Collections.Generic.HashSet<System.String> val_1 = 0;
        WeaponManager.丒丒三丕丝且一丟丁();
        val_5 = val_1;
        if(val_5 != 0)
        {
                if((WeaponManager.且与丏业万丌丛丏东.TryGetValue(key:  专丆丌丛东一不丑丙, value: out  val_1)) == true)
        {
                return (System.Collections.Generic.HashSet<System.String>)val_5;
        }
        
        }
        
        object[] val_3 = new object[1];
        val_3[0] = 专丆丌丛东一不丑丙;
        UnityEngine.Debug.LogErrorFormat(format:  "TagsOfDefaultSet false, filterMap = {0}", args:  val_3);
        System.Collections.Generic.HashSet<System.String> val_4 = null;
        val_5 = val_4;
        val_4 = new System.Collections.Generic.HashSet<System.String>();
        return (System.Collections.Generic.HashSet<System.String>)val_5;
    }
    private static void 丒丒三丕丝且一丟丁()
    {
        System.Collections.Generic.IEnumerable<T> val_4;
        var val_5;
        var val_7;
        System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_9;
        var val_11;
        System.Action<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>> val_13;
        var val_14;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丛丛丒丝与万丂丗一 == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_9 = WeaponManager.<>c.<>9__68_0;
        if(val_9 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_1 = null;
            val_9 = val_1;
            val_1 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::与与丄与与不丙丗丛(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
            WeaponManager.<>c.<>9__68_0 = val_9;
        }
        
        val_11 = null;
        val_4 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  WeaponManager.且专专丁丌丗丛且丙, predicate:  val_1);
        val_11 = null;
        val_13 = WeaponManager.<>c.<>9__68_1;
        if(val_13 == null)
        {
                System.Action<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>> val_3 = null;
            val_13 = val_3;
            val_3 = new System.Action<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WeaponManager.<>c::世上丁丆丂丁丂与与(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
            WeaponManager.<>c.<>9__68_1 = val_13;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(丌丛丏业世丄丞三丌:  val_4, 七丐丅专且专七三丆:  val_3);
        val_14 = null;
        val_14 = null;
        WeaponManager.丛丛丒丝与万丂丗一 = true;
    }
    internal static System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<string>> 丝丐丁一丌丟丞丒丒(System.Collections.Generic.List<string> 丑七不与丛丆一丂丞)
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        do
        {
            WeaponManager.丞业不丙不丞丏万下().Item[0 + 1].Clear();
            val_19 = 0 + 1;
        }
        while(val_19 < 5);
        
        val_20 = 1152921516934571616;
        val_21 = 1152921516223708000;
        val_22 = 1152921505369411584;
        val_23 = 0;
        goto label_6;
        label_25:
        val_19 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丑七不与丛丆一丂丞.Item[0]);
        if((val_19 == null) || (val_19.东七与与不丅丙上上() == true))
        {
            goto label_18;
        }
        
        if((WeaponManager.丕下丘丆万丌丝丟丞(丒东业不丐丑丕丄丆:  val_19.与不丞丑七丘丁丂丛())) == false)
        {
            goto label_14;
        }
        
        val_22 = val_22;
        val_20 = val_20;
        val_21 = 1152921516223708000;
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_19.业东丅东丌上丗丑不())) == null)
        {
            goto label_18;
        }
        
        label_14:
        val_19 = WeaponManager.丞业不丙不丞丏万下().Item[val_19.丒万丕七专不丏丞丌()];
        val_19.Add(item:  丑七不与丛丆一丂丞.Item[0]);
        label_18:
        val_23 = 1;
        label_6:
        if(val_23 < 丑七不与丛丆一丂丞.Count)
        {
            goto label_25;
        }
        
        val_24 = WeaponManager.丞业不丙不丞丏万下();
        return (System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<System.String>>)val_24;
    }
    private static System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<string>> 丞业不丙不丞丏万下()
    {
        var val_4;
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.东且丗丂丁一东丞下 == null)
        {
                System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<System.String>> val_2 = new System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<System.String>>(capacity:  6, comparer:  new 丟丗丒丏丈不丌专一());
            val_6 = null;
            val_6 = null;
            WeaponManager.东且丗丂丁一东丞下 = val_2;
            do
        {
            val_6 = null;
            val_2.set_Item(key:  0, value:  new System.Collections.Generic.List<System.String>());
            val_5 = null;
            val_4 = 0 + 1;
        }
        while(val_4 != 6);
        
        }
        
        val_5 = null;
        return (System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<System.String>>)WeaponManager.东且丗丂丁一东丞下;
    }
    internal static System.Collections.Generic.List<string> 一丙丂下丆七丁丙丟(int 丈丘丝一丗下丈丐不)
    {
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_8;
        var val_9;
        System.Func<三丅丁丗丗丝丂万且, System.String> val_11;
        .丈丘丝一丗下丈丐不 = 丈丘丝一丗下丈丐不;
        val_8 = null;
        val_8 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new WeaponManager.丘丈万一丅东一上万(), method:  System.Boolean WeaponManager.丘丈万一丅东一上万::且世丄丂东丙与万丛(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
        val_9 = null;
        val_9 = null;
        val_11 = WeaponManager.<>c.<>9__75_1;
        if(val_11 != null)
        {
                return (System.Collections.Generic.List<System.String>)System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<三丅丁丗丗丝丂万且, System.String>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  null), selector:  null));
        }
        
        val_11 = null;
        val_11 = new System.Func<三丅丁丗丗丝丂万且, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::丅一三且丄丂丏三下(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
        WeaponManager.<>c.<>9__75_1 = val_11;
        return (System.Collections.Generic.List<System.String>)System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<三丅丁丗丗丝丂万且, System.String>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  null), selector:  null));
    }
    internal void 上丁丆下丌丗万丅丁()
    {
        this._rocketCache = 0;
        this._turretCache = 0;
        this.丙下丅丒与丈丈丒与.Clear();
        this.丁一丏东七丌丗丁丏.Clear();
        this.万丛丌东与三丅一东 = 0;
        UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
    }
    internal bool 业一丞七万丁丏丑丅()
    {
        return (bool)this.三丒世丙丙丒丝丟且;
    }
    internal static void 不万且专丕且丘丛世(System.Action<三丅丁丗丗丝丂万且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丟下丌丆万东下专丏, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丟下丌丆万东下专丏 != 1152921505286242480);
    
    }
    internal static void 丒世丛丄且七丐东丆(System.Action<三丅丁丗丗丝丂万且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丟下丌丆万东下专丏, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丟下丌丆万东下专丏 != 1152921505286242480);
    
    }
    internal static void 丏丂丐丅丘丛丏丏丗(System.Action<三丅丁丗丗丝丂万且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.与丏世专万丘丁丄丑, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.与丏世专万丘丁丄丑 != 1152921505286242488);
    
    }
    internal static void 丐丙丁三丁丟丄丅七(System.Action<三丅丁丗丗丝丂万且> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.与丏世专万丘丁丄丑, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.与丏世专万丘丁丄丑 != 1152921505286242488);
    
    }
    internal static UnityEngine.GameObject 上不丝专丏丝丙丅丆(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Vector3 丗丟东丗丕世丛丌丗, string 丛丄万三丂东丙丑东, float 不丅丛专丘丅专丘丕 = 150)
    {
        var val_11;
        UnityEngine.Object val_12;
        UnityEngine.GameObject val_2 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Rays", 丌丗丏丏丛东专丁且:  丛丄万三丂东丙丑东));
        val_11 = 0;
        if(val_2 == 0)
        {
                return (UnityEngine.GameObject)val_11;
        }
        
        UnityEngine.Transform val_4 = val_2.transform;
        if(val_4.childCount >= 1)
        {
                val_12 = val_4.GetChild(index:  0);
        }
        else
        {
                val_12 = 0;
        }
        
        if(val_12 != 0)
        {
                val_12.GetComponent<UnityEngine.LineRenderer>().SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        
        val_2.transform.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        val_2.transform.forward = new UnityEngine.Vector3() {x = 丗丟东丗丕世丛丌丗.x, y = 丗丟东丗丕世丛丌丗.y, z = 丗丟东丗丕世丛丌丗.z};
        val_11 = val_2;
        return (UnityEngine.GameObject)val_11;
    }
    internal static void 丙与业东丒丒丈业不(UnityEngine.GameObject 世上与丁丈与丁丂丁, bool 丙丗七丕且与丞丘丁)
    {
        UnityEngine.Object val_11;
        if(世上与丁丈与丁丂丁 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = 世上与丁丈与丁丂丁.transform;
        if(val_2.childCount >= 1)
        {
                val_11 = val_2.GetChild(index:  0);
        }
        else
        {
                val_11 = 0;
        }
        
        if(val_11 == 0)
        {
                return;
        }
        
        if(val_11.gameObject.activeSelf ^ 丙丗七丕且与丞丘丁 == false)
        {
                return;
        }
        
        val_11.gameObject.SetActive(value:  丙丗七丕且与丞丘丁);
    }
    internal static string 丅丗丟丕丅下丆世丙()
    {
        return "Weapon1";
    }
    internal static string 丞丗丆丑三丈丆七丐()
    {
        return "Weapon2";
    }
    internal static string 上业丅丂丘不且丕丌()
    {
        return "Weapon3";
    }
    internal static string 丗三专丆专东丟世业()
    {
        return "Weapon4";
    }
    internal static string 七东丕世下丌一丘丐()
    {
        return "Weapon5";
    }
    internal static string 丂丝丁丐且丏丒丈丂()
    {
        return "Weapon8";
    }
    internal static string 丑世丐世丟三三不丒()
    {
        return "Weapon9";
    }
    internal static string 丕丑一三丅不七丝丅()
    {
        return "Weapon51";
    }
    internal static string 丘丏丒丌丞与丙丙下()
    {
        return "Weapon52";
    }
    internal static string 业丆丝丅丘丙专丐丗()
    {
        return "Weapon250";
    }
    internal static string 且丝与世东丟丒且世()
    {
        return "Weapon302";
    }
    internal static string 不丁丐丌丘丐七万专()
    {
        return "FirstPistol";
    }
    internal static string 丄七上丁丂丝丙丏丙()
    {
        return "Weapon6";
    }
    internal static string 世丛丛丆丑专世不与()
    {
        return "Knife";
    }
    internal static string 丞一与丝世丏丄丗上()
    {
        return "Weapon7";
    }
    internal static string 且丄下且七丐专业丄()
    {
        return "Weapon10";
    }
    internal static string 丐丆一东业丗丈丞丘()
    {
        return "Weapon11";
    }
    internal static string 丒丞丁七丂丄丘丂与()
    {
        return "Weapon12";
    }
    internal static string 且东丆丏丂丐万丒丏()
    {
        return "Weapon13";
    }
    internal static string 与且丝丗丁七丞与丗()
    {
        return "Weapon14";
    }
    internal static string 万丄丁丁与丆丏上丄()
    {
        return "Weapon15";
    }
    internal static string 万丟丘三丟且专专三()
    {
        return "Weapon16";
    }
    internal static string 与世丝丐丏丅丞且丛()
    {
        return "Weapon17";
    }
    internal static string 世与业丏丙丐丐丛丌()
    {
        return "Weapon18";
    }
    internal static string 不业丌丅一三与丁丅()
    {
        return "Weapon68";
    }
    internal static string 丐丙丅丒与不丘业丟()
    {
        return "Weapon19";
    }
    internal static string 丕丁丝丛丑七丞七丙()
    {
        return "Weapon20";
    }
    internal static string 丙一七丒丂丏不七丄()
    {
        return "Weapon21";
    }
    internal static string 丞丂丈丟万丂下东丙()
    {
        return "Weapon22";
    }
    internal static string 三三且下世丄丂丏丑()
    {
        return "Weapon23";
    }
    internal static string 丂丂丆丄一丑上丆丁()
    {
        return "Weapon24";
    }
    internal static string 丑丐丗丏丘丑丏一不()
    {
        return "Weapon25";
    }
    internal static string 丘专丌丄上不七下丏()
    {
        return "Weapon71";
    }
    internal static string 丞丗三七丈丟且且丞()
    {
        return "Weapon26";
    }
    internal static string 丗丟丏丛世丘丁丞丗()
    {
        return "Weapon27";
    }
    internal static string 丅丌丞丛丝且下万丑()
    {
        return "Weapon28";
    }
    internal static string 七不七下丐丒丝与丐()
    {
        return "Weapon29";
    }
    internal static string 下丐丕丕且一与上丈()
    {
        return "Weapon30";
    }
    internal static string 丕丂一丛世丐丞丁丗()
    {
        return "Weapon31";
    }
    internal static string 下世七丛丁丏丝丆丁()
    {
        return "Weapon32";
    }
    internal static string 丁与下丑业七不丕丘()
    {
        return "Weapon33";
    }
    internal static string 丕丘上丏七丁七丑丅()
    {
        return "Weapon34";
    }
    internal static string 丁丛丆丅七专丈上丈()
    {
        return "Weapon35";
    }
    internal static string 丈丗丒专万丙万七不()
    {
        return "Weapon36";
    }
    internal static string 丘专专且专丙丗且丆()
    {
        return "Weapon37";
    }
    internal static string 丂世丝丕丟丐丆丏且()
    {
        return "Weapon38";
    }
    internal static string 丏丛丛丁丁专丄下丐()
    {
        return "Weapon39";
    }
    internal static string 丞一不一丅丞丆丂万()
    {
        return "Weapon40";
    }
    internal static string 不丟丅丟七丂丂万东()
    {
        return "Weapon41";
    }
    internal static string 万业丄且丕与专且业()
    {
        return "Weapon42";
    }
    internal static string 丐万不与丑丝丑丏丒()
    {
        return "Weapon43";
    }
    internal static string 下丆丟丝七丑专丕丄()
    {
        return "Weapon44";
    }
    internal static string 丏丘专业业且丙丈丝()
    {
        return "Weapon45";
    }
    internal static string 丏一丏万丞东一丗丏()
    {
        return "Weapon46";
    }
    internal static string 丄丂丝丞万丗与业丗()
    {
        return "Weapon47";
    }
    internal static string 丆东上丆世丄丛丅七()
    {
        return "Weapon48";
    }
    internal static string 三东丂丑丙丂三丗丑()
    {
        return "Weapon49";
    }
    internal static string 业丄丘七丆丞丂丞上()
    {
        return "Weapon50";
    }
    internal static string 且丞丅丆世丝三丈上()
    {
        return "Weapon53";
    }
    internal static string 丆不丅丈丗业且丅丑()
    {
        return "Weapon69";
    }
    internal static string 三丄万丏丂与万丗丈()
    {
        return "Weapon70";
    }
    internal static string 丌丏丑上丂不丗下丙()
    {
        return "Weapon54";
    }
    internal static string 不丒三丄丕丙丕业业()
    {
        return "Weapon55";
    }
    internal static string 不丂且丌七丒业不丙()
    {
        return "Weapon56";
    }
    internal static string 丟且业不七三丛丟丙()
    {
        return "Weapon72";
    }
    internal static string 且丌丞丂丈丟与丅上()
    {
        return "Weapon57";
    }
    internal static string 丐丞丘一丝丛丑丅丝()
    {
        return "Weapon58";
    }
    internal static string 丑丄丂三丈与不丒万()
    {
        return "Weapon59";
    }
    internal static string 丏丆不与丑丁丈专丅()
    {
        return "Weapon60";
    }
    internal static string 丗七丒七丌丆且丈不()
    {
        return "Weapon61";
    }
    internal static string 丕丒丂世世丕丙万下()
    {
        return "Weapon62";
    }
    internal static string 丙丞丟且万一专世上()
    {
        return "Weapon63";
    }
    internal static string 专丗丞万专丁业万不()
    {
        return "Weapon64";
    }
    internal static string 丌业丆丐上丅与七东()
    {
        return "Weapon65";
    }
    internal static string 与下一业丘丁七丄世()
    {
        return "Weapon66";
    }
    internal static string 丘专与世丅丌丛丙世()
    {
        return "Weapon67";
    }
    internal static string 丘三丅丝专万丅丒丒()
    {
        return "Weapon333";
    }
    internal static string 丝三东丈丐世丐丂与()
    {
        return "Weapon73";
    }
    internal static string 丑丛不七丝丙丆万东()
    {
        return "Weapon74";
    }
    internal static string 七丒下丛与丟不丂丆()
    {
        return "Weapon75";
    }
    internal static string 丕丆丌丘丈上上丈丁()
    {
        return "Weapon76";
    }
    internal static string 七东专丁丒与丟丅丁()
    {
        return "Weapon77";
    }
    internal static string 七丒世丘丟丞专上丑()
    {
        return "Weapon78";
    }
    internal static string 丂丄丄万三丝丌丂丈()
    {
        return "Weapon79";
    }
    internal static string 一专上丕三丐上丙丈()
    {
        return "Weapon80";
    }
    internal static string 专丐丒丒下且三丒一()
    {
        return "Weapon81";
    }
    internal static string 下丅一世丏丑丏丂不()
    {
        return "Weapon82";
    }
    internal static string 七丈丄丌丒丁丂万丙()
    {
        return "Weapon83";
    }
    internal static string 业下三七七丂丏丒丅()
    {
        return "Weapon84";
    }
    internal static string 下且不专专七丝丑丝()
    {
        return "Weapon85";
    }
    internal static string 丄丞且丙七不丈丝丘()
    {
        return "Weapon86";
    }
    internal static string 不一不丏丕东丟丘丅()
    {
        return "Weapon87";
    }
    internal static string 三上丝丂世业丅丁丈()
    {
        return "Weapon88";
    }
    internal static string 丒丒丘专丕丄上东上()
    {
        return "Weapon89";
    }
    internal static string 丄丌丟且万上丙丒七()
    {
        return "Weapon90";
    }
    internal static string 丄七业丘下丗丑丞丆()
    {
        return "Weapon91";
    }
    internal static string 丕丛一丁业丘世丞七()
    {
        return "Weapon92";
    }
    internal static string 丅丄上丌东不丛丞不()
    {
        return "Weapon93";
    }
    internal static string 丌专世丗与丛丛一丈()
    {
        return "Weapon94";
    }
    internal static string 丈下丒丙业丂业丈丙()
    {
        return "Weapon95";
    }
    internal static string 上丘且三丕丅丏世丝()
    {
        return "Weapon96";
    }
    internal static string 丛丝不丛世且下丙丂()
    {
        return "Weapon97";
    }
    internal static string 世与丗丐丝丒丘丟与()
    {
        return "Weapon98";
    }
    internal static string 丅丟不七丈丙专且且()
    {
        return "Weapon99";
    }
    internal static string 下业丄丑东丁丝东丌()
    {
        return "Weapon100";
    }
    internal static string 世业丈丗丂丙七一一()
    {
        return "Weapon101";
    }
    internal static string 丗一丆世业丛丒丆丑()
    {
        return "Weapon102";
    }
    internal static string 丌不丄丕东丘丛七丆()
    {
        return "Weapon103";
    }
    internal static string 七丐世丝专丅丌七与()
    {
        return "Weapon104";
    }
    internal static string 丘丙世丒丑上不丞丐()
    {
        return "Weapon105";
    }
    internal int 丈丄丙丙丈丗业丆万()
    {
    
    }
    internal void 丏丁丑万丐丄世丌丒(int 丙业与丙丗丝不丈东)
    {
        var val_9;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_1 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  7);
        if(val_1 != null)
        {
                val_9 = val_1.丛丅下丆丗丏三丁丕<System.Collections.Generic.List<CategoryNames>>(丒丑丂丐丕丒丕东与:  "custom");
            三丈丟与丏丘丈丐万 val_3 = this.丙下丅丒与丈丈丒与.Item[丙业与丙丗丝不丈东];
            var val_9 = 0;
            do
        {
            if(val_9 >= val_9.Count)
        {
                return;
        }
        
            val_9 = val_9 + 1;
        }
        while(val_9.Item[0] != (val_3.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() - 1));
        
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_8 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        this.丒七丅丟丟丐业上丄 = val_8;
        mem[1152921539592615312] = val_8.上万三丆专丏丒丗业;
    }
    internal 三丈丟与丏丘丈丐万 一丗上丆三东上丄丛()
    {
        if(this.丙下丅丒与丈丈丒与 != null)
        {
                return this.丙下丅丒与丈丈丒与.Item[this.丒七丅丟丟丐业上丄];
        }
        
        return this.丙下丅丒与丈丈丒与.Item[this.丒七丅丟丟丐业上丄];
    }
    private void 丄丆下东丕丐三丌与(int 七丆丒与丗丌丄且丂)
    {
        Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丄丆下东丕丐三丌与(丑一丕三专东不上丞:  this.丄丐丌丛东丌丘丂丄(), 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
    }
    private string 丄丐丌丛东丌丘丂丄()
    {
        var val_10;
        var val_11;
        FilterMaps val_12;
        string val_13;
        var val_14;
        var val_15;
        val_10 = 1152921505171275776;
        val_11 = null;
        val_11 = null;
        val_12 = ShopNGUIController.丛丐丛专丟丞万三七();
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_7;
        }
        
        val_13 = 0;
        if((GameConnect.世丐丄三三上丅七三() | GameConnect.万不丒丌丙万丗东不()) == true)
        {
                return (string)val_13;
        }
        
        val_10 = 1152921505286238208;
        val_14 = null;
        val_14 = null;
        if((WeaponManager.且专专丁丌丗丛且丙.ContainsKey(key:  val_12)) == false)
        {
            goto label_14;
        }
        
        val_15 = null;
        val_15 = null;
        val_12 = WeaponManager.且专专丁丌丗丛且丙.Item[val_12];
        val_13 = val_6.丟丌东且上业丝丂丞;
        return (string)val_13;
        label_7:
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                return 与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七();
        }
        
        val_13 = 0;
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
                return (string)val_13;
        }
        
        return 与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗();
        label_14:
        val_12 = "WeaponSetSet_tingNamesFor_FilterMaps.ContainsKey (filterMap): filterMap = "("WeaponSetSet_tingNamesFor_FilterMaps.ContainsKey (filterMap): filterMap = ") + val_12;
        UnityEngine.Debug.LogError(message:  val_12);
        val_13 = 0;
        return (string)val_13;
    }
    private void 丙东丞下与丐丗丆下()
    {
        var val_7;
        var val_30;
        var val_31;
        string val_32;
        var val_34;
        string val_35;
        var val_36;
        var val_37;
        var val_38;
        val_30 = null;
        val_30 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  WeaponManager.丒丆丙一且丂一丙专)) == false)
        {
            goto label_25;
        }
        
        val_31 = null;
        val_31 = null;
        val_32 = WeaponManager.丒丆丙一且丂一丙专;
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_32));
        if(val_3 == null)
        {
                return;
        }
        
        val_32 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        Dictionary.Enumerator<TKey, TValue> val_4 = val_32.GetEnumerator();
        val_34 = 1152921505369411584;
        label_18:
        if((626626784 & 1) == 0)
        {
            goto label_14;
        }
        
        ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
        Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丄丆下东丕丐三丌与(丑一丕三专东不上丞:  val_8._value._obj.丐丏七丌丕丗业且上(), 七丆丒与丗丌丄且丂:  val_8._value._obj);
        goto label_18;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_25:
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "WeaponManager.LastUsedWeaponsKey")) == false)
        {
            goto label_72;
        }
        
        object val_13 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "WeaponManager.LastUsedWeaponsKey"));
        val_32 = 0;
        val_34 = 1;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_15 = val_32.Keys.GetEnumerator();
        label_58:
        if((626626736 & 1) == 0)
        {
            goto label_35;
        }
        
        string val_16 = val_7.丐丏七丌丕丗业且上();
        int val_17 = 0;
        val_35 = "";
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_16, 丙业与丙丗丝不丈东: out  val_17)) == false)
        {
            goto label_58;
        }
        
        val_36 = null;
        val_36 = null;
        if((WeaponManager.且专专丁丌丗丛且丙.ContainsKey(key:  val_17)) != false)
        {
                val_37 = null;
            val_37 = null;
            丅一丈与丄三丝丝丞 val_20 = WeaponManager.且专专丁丌丗丛且丙.Item[val_17];
            val_35 = val_20.丟丌东且上业丝丂丞;
        }
        
        if(val_17 == 0)
        {
                object val_23 = val_32.Item[val_16];
            Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丄丆下东丕丐三丌与(丑一丕三专东不上丞:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七(), 七丆丒与丗丌丄且丂:  21884928);
        }
        
        object val_25 = val_32.Item[val_16];
        Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丄丆下东丕丐三丌与(丑一丕三专东不上丞:  val_35, 七丆丒与丗丌丄且丂:  21884928);
        goto label_58;
        label_35:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_72:
        List.Enumerator<T> val_27 = WeaponManager.一丝丞丗不丄万丅丗().GetEnumerator();
        label_77:
        if((626626704 & 1) == 0)
        {
            goto label_76;
        }
        
        string val_28 = 0.丐丏七丌丕丗业且上();
        goto label_77;
        label_76:
        val_38 = 0;
        val_32 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(366 == 366)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    internal void 丘丄万上丐上丞上丆(int 丞世不丒下上上丝丑)
    {
        var val_8;
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return;
        }
        
        if(GameConnect.世丐丄三三上丅七三() == true)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return;
        }
        
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丙下丅丒与丈丈丒与 == null)
        {
                return;
        }
        
        if((丞世不丒下上上丝丑 & 2147483648) != 0)
        {
                return;
        }
        
        if(this.丙下丅丒与丈丈丒与.Count <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        三丈丟与丏丘丈丐万 val_6 = this.丙下丅丒与丈丈丒与.Item[丞世不丒下上上丝丑];
        this.丄丆下东丕丐三丌与(七丆丒与丗丌丄且丂:  val_6.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌());
    }
    internal int 七丅丒万万丅一丄专()
    {
        var val_23;
        var val_24;
        if(GameConnect.世丐丄三三上丅七三() == true)
        {
                return 0;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == true)
        {
                return 0;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return 0;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return 0;
        }
        
        if(GameConnect.万七丄丛丈丟专一丑() != false)
        {
                return 0;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_6 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  7);
        if(val_6 == null)
        {
            goto label_18;
        }
        
        System.Collections.Generic.List<CategoryNames> val_7 = val_6.丛丅下丆丗丏三丁丕<System.Collections.Generic.List<CategoryNames>>(丒丑丂丐丕丒丕东与:  "custom");
        val_23 = 0;
        goto label_19;
        label_24:
        val_23 = 1;
        label_19:
        if(val_23 < val_7.Count)
        {
            goto label_24;
        }
        
        val_24 = 0;
        goto label_25;
        label_31:
        三丈丟与丏丘丈丐万 val_11 = this.丙下丅丒与丈丈丒与.Item[0];
        if((UnityEngine.Mathf.Min(a:  2147483647, b:  val_7.Item[0])) == (val_11.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() - 1))
        {
                return 0;
        }
        
        val_24 = 1;
        label_25:
        if(val_24 < this.丙下丅丒与丈丈丒与.Count)
        {
            goto label_31;
        }
        
        label_18:
        new WeaponManager.丞丘万丈东一万丂丕() = new WeaponManager.丞丘万丈东一万丂丕();
        Progress.丏丘丄丆丂丆丛丐丝 val_16 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三();
        .世丏丞下丟专丆世丝 = val_16.丅世丌且下业丐丟且(丛丘丂丈丘下丂一丛:  val_16.丄丐丌丛东丌丘丂丄());
        System.Predicate<三丈丟与丏丘丈丐万> val_19 = new System.Predicate<三丈丟与丏丘丈丐万>(object:  new WeaponManager.丞丘万丈东一万丂丕(), method:  System.Boolean WeaponManager.丞丘万丈东一万丂丕::专东丝业丗上丈上丄(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        int val_20 = this.丙下丅丒与丈丈丒与.FindIndex(match:  null);
        var val_21 = (val_20 != 1) ? (val_20) : 0;
        return 0;
    }
    internal System.Collections.Generic.List<System.Collections.Generic.List<三丅丁丗丗丝丂万且>> 丈不丒丘丌丏丕丞丅()
    {
        var val_5;
        System.Collections.Generic.List<System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_6;
        val_5 = null;
        val_5 = null;
        val_6 = this.丈丆丝丁丟与不丁万;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                return (System.Collections.Generic.List<System.Collections.Generic.List<三丅丁丗丗丝丂万且>>)val_6;
        }
        
        val_6 = System.Linq.Enumerable.ToList<System.Collections.Generic.List<三丅丁丗丗丝丂万且>>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.List<三丅丁丗丗丝丂万且>, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>(source:  val_6, selector:  new System.Func<System.Collections.Generic.List<三丅丁丗丗丝丂万且>, System.Collections.Generic.List<三丅丁丗丗丝丂万且>>(object:  this, method:  System.Collections.Generic.List<三丅丁丗丗丝丂万且> WeaponManager::万专七丝丅东东丒丘(System.Collections.Generic.List<三丅丁丗丗丝丂万且> 丐三丞七丝丅不万丛))));
        return (System.Collections.Generic.List<System.Collections.Generic.List<三丅丁丗丗丝丂万且>>)val_6;
    }
    internal static void 不一七丗丗丆丌上丙(string 丅丟丛下业丙七业一, string 专丟丌丄东且上业一, int 下业丕七东丌丝下且, bool 下与丙业丁世三丞丒 = True)
    {
        var val_11;
        System.Array val_12;
        var val_13;
        val_11 = 下与丙业丁世三丞丒;
        char[] val_2 = new char[1];
        val_2[0] = '#';
        val_12 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  丅丟丛下业丙七业一).Split(separator:  val_2);
        if(val_3.Length <= 下业丕七东丌丝下且)
        {
                int val_4 = 下业丕七东丌丝下且 + 1;
            string[] val_5 = new string[0];
            System.Array.Copy(sourceArray:  val_12, destinationArray:  val_5, length:  val_3.Length);
            val_12 = val_5;
        }
        
        val_12[(long)下业丕七东丌丝下且] = 专丟丌丄东且上业一;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  丅丟丛下业丙七业一, 下下丏一丙不丘丌丞:  System.String.Join(separator:  "#", value:  val_5));
        if(val_11 == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        val_11 = WeaponManager.且专专丁丌丗丛且丙.Item[107];
        if((System.String.op_Equality(a:  丅丟丛下业丙七业一, b:  val_8.丟丌东且上业丝丂丞)) == false)
        {
                return;
        }
        
        Competition.与丝丆丝丘丕七丞丒.丑七不且上丗丁一世().丁丂丟且丆七一业丑(七丆丒与丗丌丄且丂:  下业丕七东丌丝下且);
    }
    internal static void 丛丞三丂丂东丌丝丗(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丗不不东丄丌丝万丙, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丗不不东丄丌丝万丙 != 1152921505286242872);
    
    }
    internal static void 下丁丘世丏世丅丘丌(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丗不不东丄丌丝万丙, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丗不不东丄丌丝万丙 != 1152921505286242872);
    
    }
    internal static string 七丄丄业丛万丄下上()
    {
        Progress.丏丘丄丆丂丆丛丐丝 val_1 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三();
        if(val_1 != null)
        {
                return val_1.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  4, 下上丐丆丝丟丝丒不:  "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY");
        }
        
        return val_1.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  4, 下上丐丆丝丟丝丒不:  "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY");
    }
    internal static void 丝丅丛丛丙丆丂丏丁(string 丙业与丙丗丝不丈东)
    {
        string val_10;
        System.Object[] val_11;
        var val_12;
        System.Object[] val_13;
        string val_14;
        var val_15;
        val_10 = 丙业与丙丗丝不丈东;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10)) == false)
        {
            goto label_3;
        }
        
        val_10 = System.Array.Empty<System.Object>();
        val_11 = val_10;
        val_12 = "BattleRoy_aleShovel trying to set empty shovel";
        goto label_6;
        label_3:
        三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_10);
        if(val_3 == null)
        {
            goto label_9;
        }
        
        if((val_3.东七与与不丅丙上上() == true) || ((System.String.op_Inequality(a:  val_3.三与丛丑且丐丈业丌(), b:  "Weapon19")) == false))
        {
            goto label_14;
        }
        
        val_13 = new object[1];
        val_13[0] = val_10;
        val_14 = "BattleRoy_aleShovel !rec.IsRoyale  {0}";
        goto label_21;
        label_14:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  4, 下上丐丆丝丟丝丒不:  "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY", 下下丏一丙不丘丌丞:  val_10);
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丗不不东丄丌丝万丙 == null)
        {
                return;
        }
        
        WeaponManager.丗不不东丄丌丝万丙.Invoke(obj:  val_10);
        return;
        label_9:
        object[] val_9 = new object[1];
        val_13 = val_9;
        val_13[0] = val_10;
        val_14 = "BattleRo_yaleShovel rec == null  {0}";
        label_21:
        val_11 = val_13;
        label_6:
        UnityEngine.Debug.LogErrorFormat(format:  val_14, args:  val_9);
    }
    internal static string 丐丅丕世丈世丁丅东()
    {
        return "##" + WeaponManager.七丄丄业丛万丄下上() + "###";
    }
    internal static string 不七丁丂丏丆丏丁丈()
    {
        return "##" + "Weapon9" + "###";
    }
    internal static string 丛东丘丈七专丌专丛()
    {
        string[] val_1 = new string[5];
        val_1[0] = "#";
        val_1[1] = "Weapon1";
        val_1[2] = "#";
        val_1[3] = "Weapon9";
        val_1[4] = "###";
        return +val_1;
    }
    internal static string 业丗万上丅丏丑下丆()
    {
        return "#Weapon1004####";
    }
    internal static string 业丞业丕丈丟丂丄丏()
    {
        string[] val_1 = new string[6];
        if(val_1 == null)
        {
            goto label_4;
        }
        
        if("Weapon2" != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        label_5:
        label_8:
        val_1[0] = "Weapon2";
        val_1[1] = "#";
        val_1[2] = "Weapon1";
        val_1[3] = "#";
        val_1[4] = "Weapon9";
        val_1[5] = "###";
        return +val_1;
    }
    internal static string 与下丝丙丏丅万一七()
    {
        string[] val_1 = new string[7];
        val_1[0] = "#";
        val_1[1] = "Weapon1";
        val_1[2] = "#";
        val_1[3] = "Weapon9";
        val_1[4] = "##";
        val_1[5] = "Weapon67";
        val_1[6] = "#";
        return +val_1;
    }
    internal static string 丛丛丗且丕世丞且丄()
    {
        return "Weapon936#Weapon937#Weapon938###";
    }
    internal static string 上丅丈不丈七丁万丌()
    {
        return "Weapon908#Weapon909#Weapon910#Weapon913#Weapon911#Weapon912";
    }
    internal static string 与丂丒丆丒一丕且丞()
    {
        null = null;
        return "#####" + WeaponManager.丞丌上万丆下东丞七;
    }
    internal static string 丑丄丁三丑且且丂丐()
    {
        string[] val_1 = new string[11];
        if(val_1 == null)
        {
            goto label_4;
        }
        
        if("Weapon3" != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        label_5:
        label_8:
        val_1[0] = "Weapon3";
        val_1[1] = "#";
        val_1[2] = "Weapon1";
        val_1[3] = "#";
        val_1[4] = "Weapon9";
        val_1[5] = "#";
        val_1[6] = "Weapon333";
        val_1[7] = "#";
        val_1[8] = "Weapon67";
        val_1[9] = "#";
        val_1[10] = WeaponManager.丞丌上万丆下东丞七;
        return +val_1;
    }
    internal static string 丛丂丗丛业丐下且丛()
    {
        string[] val_1 = new string[10];
        val_1[0] = "Weapon10#";
        val_1[1] = "Weapon1";
        val_1[2] = "#";
        val_1[3] = "Weapon9";
        val_1[4] = "#";
        val_1[5] = "Weapon333";
        val_1[6] = "#";
        val_1[7] = "Weapon67";
        val_1[8] = "#";
        val_1[9] = WeaponManager.丞丌上万丆下东丞七;
        return +val_1;
    }
    internal static string 丆丒丆且丕丄丞三丒()
    {
        return "####" + "Weapon67" + "#";
    }
    internal static string 丝与丏世丒丒丈东丌()
    {
        string[] val_1 = new string[6];
        if(val_1 == null)
        {
            goto label_4;
        }
        
        if("Weapon3" != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        label_5:
        label_8:
        val_1[0] = "Weapon3";
        val_1[1] = "#";
        val_1[2] = "Weapon1";
        val_1[3] = "#";
        val_1[4] = "Weapon9";
        val_1[5] = "###";
        return +val_1;
    }
    internal static string 丒丟丕丒不丞丆丈丝()
    {
        null = null;
        return "##" + WeaponManager.业丝丛丂三丄丁与丁 + "###";
    }
    internal static string 丆丆七丆万丝丆丑丟(string 丅丟丛下业丙七业一)
    {
        string val_9;
        var val_10;
        var val_11;
        .丅丟丛下业丙七业一 = 丅丟丛下业丙七业一;
        val_9 = (WeaponManager.东且与上丝世丝不丂)[1152921539596505376].丅丟丛下业丙七业一;
        val_10 = WeaponManager.业丞业丕丈丟丂丄丏();
        if((System.String.op_Inequality(a:  val_9, b:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七())) == false)
        {
                return (string)val_10;
        }
        
        val_11 = null;
        val_11 = null;
        System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_5 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean>(object:  new WeaponManager.东且与上丝世丝不丂(), method:  System.Boolean WeaponManager.东且与上丝世丝不丂::专丅丕三丗丆上丒丁(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
        System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> val_7 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  WeaponManager.且专专丁丌丗丛且丙, predicate:  null));
        val_9 = ???;
        val_10 = val_9.Invoke();
        return (string)val_10;
    }
    internal static string 丑丂丅丂丟且三丗丂(string 丕与丝万丑丏丑东与, FilterMaps 专丆丌丛东一不丑丙)
    {
        var val_19;
        string val_20;
        var val_21;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.Int32> val_23;
        var val_24;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.String> val_26;
        System.String[] val_27;
        CategoryNames val_28;
        string val_30;
        val_19 = null;
        val_19 = null;
        丅一丈与丄三丝丝丞 val_1 = WeaponManager.且专专丁丌丗丛且丙.Item[专丆丌丛东一不丑丙];
        val_20 = val_1.万丏丁丟丝丛业不丕.Invoke();
        if(专丆丌丛东一不丑丙 == 107)
        {
                val_21 = null;
            val_21 = null;
            val_23 = WeaponManager.<>c.<>9__411_0;
            if(val_23 == null)
        {
                val_23 = null;
            val_23 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.Int32>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponManager.<>c::丒丟丞丌丑专丆丆丄(System.Collections.Generic.KeyValuePair<int, string> 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__411_0 = val_23;
        }
        
            val_24 = null;
            val_24 = null;
            val_26 = WeaponManager.<>c.<>9__411_1;
            if(val_26 == null)
        {
                val_26 = null;
            val_26 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::业不丆七丟丙万业与(System.Collections.Generic.KeyValuePair<int, string> 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__411_1 = val_26;
        }
        
            TSource[] val_8 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.String>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.Int32>(source:  WeaponManager.世万东丘丈丒与丌七(专丆丌丛东一不丑丙:  107), keySelector:  null), selector:  null));
        }
        else
        {
                char[] val_9 = new char[1];
            val_9[0] = '#';
        }
        
        char[] val_11 = new char[1];
        val_11[0] = '#';
        val_27 = 丕与丝万丑丏丑东与.Split(separator:  val_11);
        val_28 = 0;
        goto label_26;
        label_47:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_27[0])) != true)
        {
                三丅丁丗丗丝丂万且 val_14 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_12[0x0] + 32);
            if(val_14 != null)
        {
                if((val_14.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  专丆丌丛东一不丑丙)) == true)
        {
            goto label_35;
        }
        
        }
        
            if(专丆丌丛东一不丑丙 == 107)
        {
                val_20 = mem[val_12[0x0] + 32];
            val_20 = val_12[0x0] + 32;
            Competition.与丝丆丝丘丕七丞丒.丑七不且上丗丁一世().丒丝世专下上丞上丞(七丆丒与丗丌丄且丂:  val_28, 丝三丛且丘不丌丙下:  val_20);
        }
        
            if(val_28 < val_10.Length)
        {
            
        }
        
            mem2[0] = System.String.__il2cppRuntimeField_static_fields;
        }
        
        label_35:
        val_28 = 1;
        label_26:
        if(val_28 < val_12.Length)
        {
            goto label_47;
        }
        
        val_30 = System.String.Join(separator:  "#", value:  val_27);
        return (string);
    }
    internal static string 七三上丅丘丗专一丌(FilterMaps 专丆丌丛东一不丑丙)
    {
        var val_7;
        var val_8;
        System.Collections.Generic.Dictionary<System.Int32, System.String> val_1 = WeaponManager.世万东丘丈丒与丌七(专丆丌丛东一不丑丙:  专丆丌丛东一不丑丙);
        new System.Text.StringBuilder() = new System.Text.StringBuilder();
        val_7 = 0;
        goto label_3;
        label_9:
        val_8 = "#";
        System.Text.StringBuilder val_4 = new System.Text.StringBuilder().AppendFormat(format:  "{0}{1}", arg0:  val_1.Item[0], arg1:  System.String.__il2cppRuntimeField_static_fields);
        val_7 = 1;
        label_3:
        if(val_7 < val_1.Keys.Count)
        {
            goto label_9;
        }
        
        if(new System.Text.StringBuilder() != null)
        {
                return (string)new System.Text.StringBuilder();
        }
        
        return (string)new System.Text.StringBuilder();
    }
    internal static System.Collections.Generic.Dictionary<int, string> 世万东丘丈丒与丌七(FilterMaps 专丆丌丛东一不丑丙)
    {
        var val_17;
        System.Func<三丅丁丗丗丝丂万且, CategoryNames> val_19;
        var val_20;
        System.Func<System.Linq.IGrouping<CategoryNames, 三丅丁丗丗丝丂万且>, 三丅丁丗丗丝丂万且> val_22;
        var val_23;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_25;
        var val_26;
        System.Func<System.Int32, System.Int32> val_28;
        .专丆丌丛东一不丑丙 = 专丆丌丛东一不丑丙;
        new WeaponManager.丘万七不不丑丄丄丞() = new WeaponManager.丘万七不不丑丄丄丞();
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_4 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new WeaponManager.丕世业丝与丟丌丂万(), method:  System.Boolean WeaponManager.丕世业丝与丟丌丂万::丒丑世丙丌丆丄丒丄(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
        val_17 = null;
        val_17 = null;
        val_19 = WeaponManager.<>c.<>9__413_1;
        if(val_19 == null)
        {
                val_19 = null;
            val_19 = new System.Func<三丅丁丗丗丝丂万且, CategoryNames>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames WeaponManager.<>c::丛业万丅专丌不万丌(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
            WeaponManager.<>c.<>9__413_1 = val_19;
        }
        
        val_20 = null;
        val_20 = null;
        val_22 = WeaponManager.<>c.<>9__413_2;
        if(val_22 == null)
        {
                val_22 = null;
            val_22 = new System.Func<System.Linq.IGrouping<CategoryNames, 三丅丁丗丗丝丂万且>, 三丅丁丗丗丝丂万且>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  三丅丁丗丗丝丂万且 WeaponManager.<>c::专世丁且丞丗下丑丈(System.Linq.IGrouping<CategoryNames, 三丅丁丗丗丝丂万且> 不一丅丛一丈且丕丆));
            WeaponManager.<>c.<>9__413_2 = val_22;
        }
        
        val_23 = null;
        val_23 = null;
        val_25 = WeaponManager.<>c.<>9__413_3;
        if(val_25 == null)
        {
                val_25 = null;
            val_25 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丁丁丙丏丙万丐东丘(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
            WeaponManager.<>c.<>9__413_3 = val_25;
        }
        
        .丒三丞丕万丑上丒上 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Select<System.Linq.IGrouping<CategoryNames, 三丅丁丗丗丝丂万且>, 三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.GroupBy<三丅丁丗丗丝丂万且, CategoryNames>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丛丐专不世丂丝与三(), predicate:  null), keySelector:  null), selector:  null), predicate:  null));
        val_26 = null;
        val_26 = null;
        val_28 = WeaponManager.<>c.<>9__413_4;
        if(val_28 == null)
        {
                val_28 = null;
            val_28 = new System.Func<System.Int32, System.Int32>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponManager.<>c::业丐丙专世丌丞丄丏(int 丏丟万且丝丒丝丅东));
            WeaponManager.<>c.<>9__413_4 = val_28;
        }
        
        System.Func<System.Int32, System.String> val_15 = new System.Func<System.Int32, System.String>(object:  new WeaponManager.丘万七不不丑丄丄丞(), method:  System.String WeaponManager.丘万七不不丑丄丄丞::世与丑丞丈丕下一丒(int 丏丟万且丝丒丝丅东));
        return (System.Collections.Generic.Dictionary<System.Int32, System.String>)System.Linq.Enumerable.ToDictionary<System.Int32, System.Int32, System.String>(source:  System.Linq.Enumerable.Range(start:  0, count:  6), keySelector:  null, elementSelector:  null);
    }
    internal static string 一下一与丂三三丑丑(string 丅丟丛下业丙七业一)
    {
        Progress.丏丘丄丆丂丆丛丐丝 val_1 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三();
        if(val_1 != null)
        {
                return val_1.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  2, 下上丐丆丝丟丝丒不:  丅丟丛下业丙七业一);
        }
        
        return val_1.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  2, 下上丐丆丝丟丝丒不:  丅丟丛下业丙七业一);
    }
    internal void 下东与丌丁丝丁丘专(FilterMaps 专丆丌丛东一不丑丙)
    {
        this.东业丞丁丌丟上上东(专丆丌丛东一不丑丙:  专丆丌丛东一不丑丙);
        this.丒丆丟丒丞下不丗与();
    }
    internal void 东业丞丁丌丟上上东(FilterMaps 专丆丌丛东一不丑丙)
    {
        FilterMaps val_30;
        var val_71;
        var val_73;
        var val_74;
        var val_75;
        System.Func<System.String, System.String> val_77;
        System.Func<TSource, TResult> val_78;
        var val_80;
        string val_81;
        WeaponManager val_82;
        var val_83;
        var val_84;
        string val_85;
        FilterMaps val_86;
        var val_87;
        var val_88;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_90;
        var val_91;
        var val_92;
        mem[1152921539598049016].Clear();
        val_71 = null;
        val_71 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_6;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_9;
        }
        
        string val_3 = WeaponManager.丐丅丕世丈世丁丅东();
        goto label_109;
        label_6:
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_15;
        }
        
        if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == false)
        {
            goto label_18;
        }
        
        char[] val_9 = new char[1];
        val_9[0] = '#';
        .一业丆世丂世上丛丂 = new System.Collections.Generic.List<System.String>();
        val_73 = 0;
        goto label_26;
        label_30:
        (WeaponManager.丞万丏丄丕七七丅下)[1152921539598089072].一业丆世丂世上丛丂.Add(item:  Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟上七七一且丞丈与().Split(separator:  val_9)[0]);
        val_73 = 1;
        label_26:
        if(val_73 < val_10.Length)
        {
            goto label_30;
        }
        
        val_74 = null;
        val_74 = null;
        val_75 = null;
        val_75 = null;
        val_77 = WeaponManager.<>c.<>9__416_1;
        if(val_77 == null)
        {
                System.Func<System.String, System.String> val_12 = null;
            val_77 = val_12;
            val_12 = new System.Func<System.String, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::万万丞专丝丂丛与下(string 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__416_1 = val_77;
        }
        
        System.Func<System.String, System.String> val_14 = null;
        val_78 = val_14;
        val_14 = new System.Func<System.String, System.String>(object:  new WeaponManager.丞万丏丄丕七七丅下(), method:  System.String WeaponManager.丞万丏丄丕七七丅下::丏丄丙丅丗丞东丈丏(string 三丟东丕丄丄下下丑));
        string val_17 = System.String.Join(separator:  "#", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.String, System.String>(source:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  WeaponManager.丅丑丏上丟丌丛丑丐, keySelector:  val_12), selector:  val_14)));
        goto label_109;
        label_9:
        if(GameConnect.世丐丄三三上丅七三() == false)
        {
            goto label_39;
        }
        
        string val_18 = WeaponManager.不七丁丂丏丆丏丁丈();
        goto label_109;
        label_15:
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_45;
        }
        
        string val_20 = 与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗();
        goto label_48;
        label_39:
        if((WeaponManager.且专专丁丌丗丛且丙.ContainsKey(key:  专丆丌丛东一不丑丙)) == false)
        {
            goto label_52;
        }
        
        val_80 = null;
        val_80 = null;
        丅一丈与丄三丝丝丞 val_22 = WeaponManager.且专专丁丌丗丛且丙.Item[专丆丌丛东一不丑丙];
        val_81 = val_22.丟丌东且上业丝丂丞;
        goto label_57;
        label_18:
        label_48:
        val_81 = 与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七();
        label_57:
        label_109:
        label_106:
        char[] val_25 = new char[1];
        val_25[0] = '#';
        val_82 = 0;
        val_83 = 0;
        val_84 = 0;
        goto label_65;
        label_85:
        val_78 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_81).Split(separator:  val_25)[0];
        if((System.String.IsNullOrEmpty(value:  val_78)) == true)
        {
            goto label_83;
        }
        
        List.Enumerator<T> val_28 = mem[1152921539598049024].GetEnumerator();
        label_73:
        if((631451408 & 1) == 0)
        {
            goto label_69;
        }
        
        string val_31 = val_30.丐丏七丌丕丗业且上();
        val_85 = X25.三与丛丑且丐丈业丌();
        if((val_85.Equals(value:  val_78)) == false)
        {
            goto label_73;
        }
        
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_31, 专东丅一三丏三丐丟:  false, 丂丐丕丟丕丗且东丐:  false);
        label_69:
        val_84 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_84 != 1) && (482 == 482))
        {
                val_84 = val_84 + 0 ^ 0;
        }
        else
        {
                if(this != null)
        {
                val_82 = 0;
        }
        
        }
        
        label_83:
        val_83 = 1;
        label_65:
        if(val_83 < val_26.Length)
        {
            goto label_85;
        }
        
        val_86 = 专丆丌丛东一不丑丙;
        if(val_86 != 2)
        {
            goto label_161;
        }
        
        List.Enumerator<T> val_35 = mem[1152921539598049024].GetEnumerator();
        label_95:
        if((631451408 & 1) == 0)
        {
            goto label_88;
        }
        
        val_78 = val_30.丐丏七丌丕丗业且上();
        val_85 = "Weapon9";
        if((val_31.三与丛丑且丐丈业丌().Equals(value:  val_85)) == false)
        {
            goto label_95;
        }
        
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_78, 专东丅一三丏三丐丟:  false, 丂丐丕丟丕丗且东丐:  false);
        label_88:
        val_87 = val_84 + 1;
        mem2[0] = 588;
        goto label_96;
        label_45:
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_99;
        }
        
        goto label_106;
        label_52:
        val_30 = 专丆丌丛东一不丑丙;
        UnityEngine.Debug.LogError(message:  "WeaponSetSet_tingNamesFor_FilterMaps.ContainsKey (filterMap): filterMap = "("WeaponSetSet_tingNamesFor_FilterMaps.ContainsKey (filterMap): filterMap = ") + val_30);
        goto label_106;
        label_99:
        string val_41 = WeaponManager.丛东丘丈七专丌专丛();
        goto label_109;
        label_96:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((W28 != 1) && ((631451296 + (W28) << 2) == 588))
        {
                var val_70 = 0;
            val_70 = val_70 ^ (((int)W28) >> 31);
            val_87 = W28 + val_70;
        }
        else
        {
                if(null != null)
        {
                val_82 = 0;
        }
        
        }
        
        List.Enumerator<T> val_42 = mem[1152921539598049024].GetEnumerator();
        label_128:
        if((631451408 & 1) == 0)
        {
            goto label_121;
        }
        
        val_78 = val_30.丐丏七丌丕丗业且上();
        string val_44 = X24.三与丛丑且丐丈业丌();
        val_85 = "Weapon1";
        if((val_44.Equals(value:  val_85)) == false)
        {
            goto label_128;
        }
        
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_78, 专东丅一三丏三丐丟:  false, 丂丐丕丟丕丗且东丐:  false);
        label_121:
        val_84 = W28 + 1;
        mem2[0] = 673;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_84 != 1) && ((631451296 + ((W28 + 1)) << 2) == 673))
        {
                var val_71 = 0;
            val_71 = val_71 ^ (val_84 >> 31);
            val_84 = val_84 + val_71;
        }
        else
        {
                if(this != null)
        {
                val_82 = 0;
        }
        
        }
        
        if(mem[1152921539598049016].Count != 2)
        {
            goto label_210;
        }
        
        List.Enumerator<T> val_47 = mem[1152921539598049024].GetEnumerator();
        label_150:
        if((631451408 & 1) == 0)
        {
            goto label_143;
        }
        
        val_78 = val_30.丐丏七丌丕丗业且上();
        string val_49 = val_44.三与丛丑且丐丈业丌();
        val_85 = "Weapon67";
        if((val_49.Equals(value:  val_85)) == false)
        {
            goto label_150;
        }
        
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_78, 专东丅一三丏三丐丟:  false, 丂丐丕丟丕丗且东丐:  false);
        label_143:
        val_86 = 专丆丌丛东一不丑丙;
        val_84 = val_84 + 1;
        mem2[0] = 776;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_84 != 1) && ((631451296 + (((W28 + 1) + 1)) << 2) == 776))
        {
                var val_72 = 0;
            val_72 = val_72 ^ (val_84 >> 31);
            val_84 = val_84 + val_72;
        }
        else
        {
                if(this != null)
        {
                val_82 = 0;
        }
        
        }
        
        label_161:
        if( != 4)
        {
            goto label_184;
        }
        
        if(mem[1152921539598049016].Count != 0)
        {
            goto label_210;
        }
        
        List.Enumerator<T> val_52 = mem[1152921539598049024].GetEnumerator();
        label_173:
        if((631451408 & 1) == 0)
        {
            goto label_166;
        }
        
        val_78 = val_30.丐丏七丌丕丗业且上();
        val_85 = "Weapon67";
        if((val_49.三与丛丑且丐丈业丌().Equals(value:  val_85)) == false)
        {
            goto label_173;
        }
        
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_78, 专东丅一三丏三丐丟:  false, 丂丐丕丟丕丗且东丐:  false);
        label_166:
        val_86 = 专丆丌丛东一不丑丙;
        val_84 = val_84 + 1;
        mem2[0] = 878;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_84 != 1) && ((631451296 + ((((W28 + 1) + 1) + 1)) << 2) == 878))
        {
                var val_73 = 0;
            val_73 = val_73 ^ (val_84 >> 31);
            val_84 = val_84 + val_73;
        }
        else
        {
                if(this != null)
        {
                val_82 = 0;
        }
        
        }
        
        label_184:
        if( != 3)
        {
            goto label_210;
        }
        
        val_88 = null;
        val_88 = null;
        val_90 = WeaponManager.<>c.<>9__416_0;
        if(val_90 == null)
        {
                System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_56 = null;
            val_90 = val_56;
            val_56 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丕丞世世与丗丏丁丛(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__416_0 = val_90;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  mem[1152921539598049016], predicate:  val_56)) != null)
        {
            goto label_210;
        }
        
        List.Enumerator<T> val_58 = mem[1152921539598049024].GetEnumerator();
        label_199:
        if((631451408 & 1) == 0)
        {
            goto label_193;
        }
        
        string val_60 = val_56.三与丛丑且丐丈业丌();
        val_91 = null;
        val_91 = null;
        val_78 = WeaponManager.业丝丛丂三丄丁与丁;
        if((val_60.Equals(value:  val_78)) == false)
        {
            goto label_199;
        }
        
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_30.丐丏七丌丕丗业且上(), 专东丅一三丏三丐丟:  false, 丂丐丕丟丕丗且东丐:  false);
        label_193:
        val_84 = val_84 + 1;
        mem2[0] = 1014;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_84 != 1) && ((631451296 + (((((W28 + 1) + 1) + 1) + 1)) << 2) == 1014))
        {
                var val_74 = 0;
            val_74 = val_74 ^ (val_84 >> 31);
            val_84 = val_84 + val_74;
        }
        else
        {
                if(this != null)
        {
                val_82 = 0;
        }
        
        }
        
        label_210:
        if((GameConnect.与丈丘丈上丌丝丝丛() == false) || (mem[1152921539598049016].Count != 0))
        {
            goto label_237;
        }
        
        List.Enumerator<T> val_64 = mem[1152921539598049024].GetEnumerator();
        label_223:
        if((631451408 & 1) == 0)
        {
            goto label_217;
        }
        
        val_92 = null;
        val_92 = null;
        val_78 = WeaponManager.丞丌上万丆下东丞七;
        if((val_60.三与丛丑且丐丈业丌().Equals(value:  val_78)) == false)
        {
            goto label_223;
        }
        
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_30.丐丏七丌丕丗业且上(), 专东丅一三丏三丐丟:  false, 丂丐丕丟丕丗且东丐:  false);
        label_217:
        val_84 = val_84 + 1;
        mem2[0] = 1119;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_84 == 1)
        {
            goto label_231;
        }
        
        if((this == null) || ((631451296 + ((((((W28 + 1) + 1) + 1) + 1) + 1)) << 2) == 1119))
        {
            goto label_237;
        }
        
        label_236:
        label_237:
        int val_68 = mem[1152921539598049016].Count;
        if(val_68 != 0)
        {
                return;
        }
        
        val_68.丞丟丐丁丒万丁不上();
        return;
        label_231:
        if(this != null)
        {
            goto label_236;
        }
        
        goto label_237;
    }
    internal static string 上丐一丏丞丈三丙丗(string 丒东业不丐丑丕丄丆)
    {
        var val_12;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_48;
        var val_49;
        if(丒东业不丐丑丕丄丆 == null)
        {
            goto label_1;
        }
        
        if((丏丄丑上丛不丈且万.丗丗上丘一万丈丟丆().ContainsKey(key:  丒东业不丐丑丕丄丆)) == false)
        {
            goto label_5;
        }
        
        if((WeaponManager.丏不丆丌丅丕丐丝丟().Contains(item:  丒东业不丐丑丕丄丆)) == true)
        {
            goto label_89;
        }
        
        var val_7 = ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  丒东业不丐丑丕丄丆)) != 0) ? 丒东业不丐丑丕丄丆 : 0;
        return (string)val_36;
        label_1:
        val_36 = 0;
        return (string)val_36;
        label_5:
        Dictionary.Enumerator<TKey, TValue> val_9 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().GetEnumerator();
        val_37 = 1152921535992016992;
        val_38 = 0;
        val_39 = 0;
        val_36 = 0;
        val_40 = 0;
        goto label_78;
        label_79:
        ConfiguredValueTaskAwaiter val_13 = val_12.GetAwaiter();
        List.Enumerator<T> val_14 = val_13._value._obj.GetEnumerator();
        label_22:
        if((631896176 & 1) == 0)
        {
            goto label_20;
        }
        
        string val_15 = val_12.丐丏七丌丕丗业且上();
        if((val_15.Contains(item:  丒东业不丐丑丕丄丆)) == false)
        {
            goto label_22;
        }
        
        val_41 = null;
        val_41 = null;
        if((TempItemsController.上且丗丌东丟丂世丒.ContainsKey(key:  丒东业不丐丑丕丄丆)) == false)
        {
            goto label_26;
        }
        
        val_42 = null;
        val_37 = 1152921535992016992;
        val_42 = null;
        val_37 = 1152921535992016992;
        if(TempItemsController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_31;
        }
        
        val_43 = null;
        val_43 = null;
        val_37 = 1152921535992016992;
        var val_20 = ((TempItemsController.丄丞丁丈与业上丞丟.万七上丁丑丞业丑丛(下丅丙一丂丗丅丝七:  丒东业不丐丑丕丄丆)) != true) ? 丒东业不丐丑丕丄丆 : 0;
        goto label_35;
        label_20:
        val_44 = 1;
        val_45 = 304;
        goto label_36;
        label_26:
        System.Collections.Generic.List<System.String> val_22 = 七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  val_13._value._obj.丙东专丂世丈丏丁丂());
        if((val_22.Contains(item:  val_15.Item[0])) == false)
        {
            goto label_41;
        }
        
        val_46 = 0;
        goto label_42;
        label_49:
        val_46 = 136283873;
        val_35 = val_22;
        label_42:
        if(136283874 >= val_15.Count)
        {
            goto label_44;
        }
        
        if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  val_13._value._obj.丙东专丂世丈丏丁丂()).Contains(item:  val_15.Item[136283874])) == true)
        {
            goto label_49;
        }
        
        val_35 = val_35;
        string val_30 = val_15.Item[136283873];
        val_44 = 1;
        mem2[0] = 334;
        val_37 = 1152921535992016992;
        goto label_51;
        label_31:
        val_36 = 0;
        label_35:
        val_44 = 1;
        val_45 = 334;
        label_36:
        val_48 = val_39;
        goto label_56;
        label_41:
        val_44 = 1;
        val_37 = 1152921535992016992;
        val_36 = 0;
        val_48 = val_39;
        goto label_56;
        label_44:
        val_44 = 1;
        mem2[0] = 334;
        val_37 = 1152921535992016992;
        label_51:
        val_48 = val_39;
        val_36 = val_15.Item[val_15.Count - 1];
        label_56:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_44 == 1)
        {
            goto label_74;
        }
        
        if(1152921535992049760 == 304)
        {
            goto label_75;
        }
        
        if(1152921535992049760 == 334)
        {
            goto label_76;
        }
        
        label_74:
        val_38 = 0;
        val_39 = 0;
        if( == null)
        {
            goto label_78;
        }
        
        val_38 = 0;
        val_39 = 0;
        goto label_78;
        label_75:
        var val_34 = 0;
        val_34 = val_34 ^ 0;
        val_40 = val_44 + val_34;
        val_39 = ;
        label_78:
        if((631896224 & 1) != 0)
        {
            goto label_79;
        }
        
        val_49 = val_40 + 1;
        mem2[0] = 332;
        goto label_80;
        label_76:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (string)val_36;
        label_80:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_44 == 1)
        {
            goto label_86;
        }
        
        if(1152921535992050784 == 332)
        {
            goto label_89;
        }
        
        if(1152921535992050784 == 334)
        {
                return (string)val_36;
        }
        
        label_86:
        label_89:
        val_36 = 丒东业不丐丑丕丄丆;
        return (string)val_36;
    }
    internal static string 一丅丅万丄丅丘丆专(string 丒东业不丐丑丕丄丆)
    {
        var val_8;
        string val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        string val_30;
        string val_31;
        var val_32;
        string val_33;
        val_23 = 丒东业不丐丑丕丄丆;
        if(val_23 == null)
        {
            goto label_1;
        }
        
        if((丏丄丑上丛不丈且万.丗丗上丘一万丈丟丆().ContainsKey(key:  val_23)) == true)
        {
            goto label_58;
        }
        
        val_25 = null;
        val_25 = null;
        if((TempItemsController.上且丗丌东丟丂世丒.ContainsKey(key:  val_23)) == true)
        {
            goto label_58;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_5 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().GetEnumerator();
        val_26 = 0;
        val_27 = 0;
        goto label_46;
        label_47:
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        List.Enumerator<T> val_10 = val_9._value._obj.GetEnumerator();
        label_17:
        if((632094192 & 1) == 0)
        {
            goto label_15;
        }
        
        string val_11 = val_8.丐丏七丌丕丗业且上();
        if((val_11.Contains(item:  val_23)) == false)
        {
            goto label_17;
        }
        
        val_28 = 0;
        goto label_18;
        label_25:
        val_23 = val_23;
        val_28 = 1;
        label_18:
        if(val_28 >= val_11.Count)
        {
            goto label_20;
        }
        
        if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  val_9._value._obj.丙东专丂世丈丏丁丂()).Contains(item:  val_11.Item[1])) == true)
        {
            goto label_25;
        }
        
        string val_18 = val_11.Item[1];
        val_24 = 632094096;
        val_29 = 136404497;
        mem[1152921540144297428] = 224;
        val_23 = val_23;
        val_30 = 0;
        goto label_31;
        label_15:
        val_30 = 0;
        val_29 = 1;
        goto label_31;
        label_20:
        string val_21 = val_11.Item[val_11.Count - 1];
        val_24 = 632094096;
        val_30 = 0;
        val_29 = 136404497;
        mem[1152921540144297428] = 224;
        label_31:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_42;
        }
        
        if(mem[1152921540144297424] == 194)
        {
            goto label_43;
        }
        
        if(mem[1152921540144297424] == 224)
        {
            goto label_44;
        }
        
        label_42:
        val_26 = 0;
        if( == null)
        {
            goto label_46;
        }
        
        val_26 = 0;
        goto label_46;
        label_43:
        var val_22 = 0;
        val_22 = val_22 ^ 0;
        val_27 =  + val_22;
        label_46:
        if((632094240 & 1) != 0)
        {
            goto label_47;
        }
        
        val_31 = ;
        val_32 = val_27 + 1;
        mem2[0] = 222;
        goto label_48;
        label_1:
        val_33 = 0;
        return (string)val_33;
        label_44:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_33 = val_21;
        return (string)val_33;
        label_48:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_33 = val_21;
        if( == 1)
        {
            goto label_55;
        }
        
        if(mem[1152921540144297424] == 222)
        {
            goto label_58;
        }
        
        if(mem[1152921540144297424] == 224)
        {
                return (string)val_33;
        }
        
        label_55:
        label_58:
        val_33 = ;
        return (string)val_33;
    }
    private void 丞丟丐丁丒万丁不上()
    {
        if(东丗上丁下业一丂丂.专七与丏丞丁丅丈丟() == false)
        {
                return;
        }
        
        UnityEngine.AsyncOperation val_2 = UnityEngine.Resources.UnloadUnusedAssets();
    }
    private void 丛丗丞丛丏丑丅丌世(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        var val_13;
        var val_20;
        var val_21;
        string val_22;
        var val_23;
        var val_24;
        val_20 = 丆丐七世世且丏丐业;
        if(val_20.一丝丈丂世丒丟东丕() == null)
        {
            goto label_2;
        }
        
        val_21 = System.Linq.Enumerable.ToList<FilterMaps>(source:  val_20.一丝丈丂世丒丟东丕());
        if((val_21.Contains(item:  0)) == false)
        {
            goto label_5;
        }
        
        label_38:
        if((val_21.Contains(item:  2)) != false)
        {
                val_22 = val_20.三与丛丑且丐丈业丌();
            if((System.String.op_Inequality(a:  val_22, b:  "Weapon1")) != false)
        {
                val_22 = val_20.三与丛丑且丐丈业丌();
            if((System.String.op_Inequality(a:  val_22, b:  "Weapon9")) != false)
        {
                if((val_21.Contains(item:  4)) != true)
        {
                val_21.Add(item:  4);
        }
        
        }
        
        }
        
        }
        
        List.Enumerator<T> val_11 = val_21.GetEnumerator();
        label_35:
        if((632405312 & 1) == 0)
        {
            goto label_22;
        }
        
        int val_14 = val_13.丙东专丂世丈丏丁丂();
        if(val_14 >= 100)
        {
                if(val_14 != 105)
        {
            goto label_35;
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        if((WeaponManager.且专专丁丌丗丛且丙.ContainsKey(key:  val_14)) == false)
        {
            goto label_35;
        }
        
        val_24 = null;
        val_24 = null;
        丅一丈与丄三丝丝丞 val_16 = WeaponManager.且专专丁丌丗丛且丙.Item[val_14];
        WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  val_16.丟丌东且上业丝丂丞, 专丟丌丄东且上业一:  val_20.三与丛丑且丐丈业丌(), 下业丕七东丌丝下且:  val_20.丒万丕七专不丏丞丌(), 下与丙业丁世三丞丒:  true);
        goto label_35;
        label_2:
        System.Collections.Generic.List<FilterMaps> val_19 = null;
        val_21 = val_19;
        val_19 = new System.Collections.Generic.List<FilterMaps>();
        label_5:
        val_19.Add(item:  0);
        if(val_21 != null)
        {
            goto label_38;
        }
        
        goto label_38;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丆丌且三丟丒丟丛丁(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万, bool 专东丅一三丏三丐丟 = True, bool 丂丐丕丟丕丗且东丐 = False)
    {
        三丅丁丗丗丝丂万且 val_72;
        string val_73;
        三丈丟与丏丘丈丐万 val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        val_73 = 专东丅一三丏三丐丟;
        val_74 = 与丘东下丈东丛丂万;
        if(val_74 == null)
        {
            goto label_1;
        }
        
        val_75 = 1152921505066536960;
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                val_72 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专;
            if(val_72.丒万丕七专不丏丞丌() != 5)
        {
                return;
        }
        
        }
        
        val_76 = 1152921505261211648;
        val_72 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专;
        FilterMaps val_3 = ShopNGUIController.丛丐丛专丟丞万三七();
        if((val_72.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  val_3)) == false)
        {
            goto label_10;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
            goto label_13;
        }
        
        val_72 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专;
        if(val_72.东七与与不丅丙上上() == true)
        {
            goto label_185;
        }
        
        label_13:
        if((InGameGUI.丙丞专丌丁丞与不丐 == 0) || ( == null))
        {
            goto label_21;
        }
        
        val_77 = null;
        val_77 = null;
        if(this.丙下丅丒与丈丈丒与.Count >= WeaponManager.丂丐丛业世丝丁丛丕)
        {
            goto label_25;
        }
        
        this.丙下丅丒与丈丈丒与.Add(item:  val_74);
        val_72 = this.专丑一业业下且丅丗;
        if(this.专丑一业业下且丅丗.categoryNabor != 3)
        {
            goto label_185;
        }
        
        val_72 = this.丙下丅丒与丈丈丒与.Item[this.丒七丅丟丟丐业上丄];
        if(val_72.七丝丈东丈丕丐与丗() == false)
        {
            goto label_31;
        }
        
        goto label_185;
        label_1:
        UnityEngine.Debug.LogWarning(message:  "Exiting from EquipW_eapon(), because weapon is null.");
        return;
        label_21:
        val_78 = 0;
        goto label_36;
        label_43:
        三丈丟与丏丘丈丐万 val_11 = val_3.Item[0];
        if(val_11.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == 与丘东下丈东丛丂万.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌())
        {
            goto label_40;
        }
        
        val_78 = 1;
        label_36:
        if(val_78 < this.丙下丅丒与丈丈丒与.Count)
        {
            goto label_43;
        }
        
        this.丙下丅丒与丈丈丒与.Add(item:  val_74);
        goto label_44;
        label_40:
        this.丙下丅丒与丈丈丒与.set_Item(index:  0, value:  val_74);
        label_44:
        val_76 = val_76;
        val_75 = 1152921505066536960;
        this.丙下丅丒与丈丈丒与.Sort(comparison:  new System.Comparison<三丈丟与丏丘丈丐万>(object:  0, method:  static System.Int32 丒丈一与东一丝丙丏::丂丆世世丕丅丕丅上(object 三丟东丕丄丄下下丑, object 丒丒丄丁且丄丆丂丌)));
        this.丙下丅丒与丈丈丒与.Reverse();
        label_31:
        val_72 = this.丙下丅丒与丈丈丒与;
        this.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  val_72.IndexOf(item:  val_74));
        label_185:
        WeaponManager.丈丝丕上丏丌丏一丁(与丘东下丈东丛丂万:  val_74);
        label_10:
        if(val_73 == false)
        {
                return;
        }
        
        val_73 = ShopNGUIController.丛丐丛专丟丞万三七();
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
            goto label_208;
        }
        
        val_72 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专.东七与与不丅丙上上();
        string val_20 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌();
        if(val_72 == false)
        {
            goto label_59;
        }
        
        WeaponManager.丝丅丛丛丙丆丂丏丁(丙业与丙丗丝不丈东:  val_20);
        goto label_208;
        label_59:
        if((System.String.op_Equality(a:  val_20, b:  "Weapon19")) != false)
        {
                WeaponManager.丝丅丛丛丙丆丂丏丁(丙业与丙丗丝不丈东:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌());
        }
        
        char[] val_25 = new char[1];
        val_25[0] = '#';
        System.Collections.Generic.List<System.String> val_27 = new System.Collections.Generic.List<System.String>();
        val_79 = 0;
        goto label_76;
        label_80:
        val_27.Add(item:  Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟上七七一且丞丈与().Split(separator:  val_25)[0]);
        val_79 = 1;
        label_76:
        if(val_79 < val_26.Length)
        {
            goto label_80;
        }
        
        val_80 = val_76;
        val_81 = null;
        val_81 = null;
        if((System.String.op_Equality(a:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), b:  WeaponManager.丞丌上万丆下东丞七)) == false)
        {
            goto label_84;
        }
        
        val_82 = null;
        val_82 = null;
        val_72 = WeaponManager.丞丌上万丆下东丞七;
        if((val_27.Contains(item:  val_72)) == false)
        {
            goto label_88;
        }
        
        label_84:
        if((与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  "Weapon3")) == false)
        {
            goto label_94;
        }
        
        val_72 = "Weapon3";
        if((val_27.Contains(item:  val_72)) == false)
        {
            goto label_110;
        }
        
        label_94:
        if((与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  "Weapon67")) == false)
        {
            goto label_105;
        }
        
        val_72 = "Weapon67";
        if((val_27.Contains(item:  val_72)) == false)
        {
            goto label_110;
        }
        
        label_105:
        val_72 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌();
        if((val_72.Equals(value:  "Weapon333")) == false)
        {
            goto label_116;
        }
        
        val_72 = "Weapon333";
        val_83 = val_27.Contains(item:  val_72);
        goto label_131;
        label_25:
        三丈丟与丏丘丈丐万 val_40 = this.丙下丅丒与丈丈丒与.Item[this.丒七丅丟丟丐业上丄];
        if(val_40.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == 2)
        {
                if(this.丙下丅丒与丈丈丒与.Item[this.丒七丅丟丟丐业上丄].七丝丈东丈丕丐与丗() == false)
        {
            goto label_128;
        }
        
        }
        
        this.丙下丅丒与丈丈丒与.set_Item(index:  this.丒七丅丟丟丐业上丄, value:  val_74);
        goto label_185;
        label_110:
        val_83 = 0;
        goto label_131;
        label_88:
        val_83 = 0;
        goto label_132;
        label_116:
        val_83 = 1;
        label_131:
        val_80 = val_76;
        label_132:
        val_84 = null;
        val_84 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_135;
        }
        
        if((GameConnect.世丐丄三三上丅七三() == true) || (GameConnect.万不丒丌丙万丗东不() == true))
        {
            goto label_208;
        }
        
        if((丂丐丕丟丕丗且东丐 == false) || (GameConnect.东且三丆丑世世丘丟() == false))
        {
            goto label_145;
        }
        
        val_85 = null;
        val_85 = null;
        val_72 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌();
        WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  与丂丏丛丞丞丒丟丄.一丑丛丒丆丞不专且, 专丟丌丄东且上业一:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), 下业丕七东丌丝下且:  val_72, 下与丙业丁世三丞丒:  true);
        if(val_83 != 0)
        {
            goto label_190;
        }
        
        goto label_208;
        label_135:
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_156;
        }
        
        if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)
        {
            goto label_208;
        }
        
        if(与丘东下丈东丛丂万.三丐三丞丘丕不丒专.七不丕世且丟丑丈丒() == true)
        {
            goto label_205;
        }
        
        bool val_53 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  "Weapon52");
        if(val_53 == true)
        {
            goto label_205;
        }
        
        val_53.丛丗丞丛丏丑丅丌世(丆丐七世世且丏丐业:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专);
        goto label_205;
        label_156:
        if((GameConnect.丌专丌万一下丕专上() == false) || (与丘东下丈东丛丂万.三丐三丞丘丕不丒专.七不丕世且丟丑丈丒() == true))
        {
            goto label_208;
        }
        
        val_73 = "Weapon52";
        bool val_57 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  val_73);
        if(val_57 == true)
        {
            goto label_208;
        }
        
        val_57.丛丗丞丛丏丑丅丌世(丆丐七世世且丏丐业:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专);
        if(val_83 != 0)
        {
            goto label_205;
        }
        
        goto label_208;
        label_128:
        System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_58 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  WeaponTogglesController.__il2cppRuntimeField_interfaceOffsets);
        this.丙下丅丒与丈丈丒与.set_Item(index:  632937512, value:  val_74);
        goto label_185;
        label_145:
        if(val_73 < 100)
        {
            goto label_186;
        }
        
        FilterMaps val_59 = ShopNGUIController.丛丐丛专丟丞万三七();
        if(val_59 != 105)
        {
            goto label_189;
        }
        
        label_186:
        val_59.丛丗丞丛丏丑丅丌世(丆丐七世世且丏丐业:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专);
        if(val_83 != 0)
        {
            goto label_190;
        }
        
        goto label_208;
        label_189:
        val_86 = null;
        val_86 = null;
        丅一丈与丄三丝丝丞 val_61 = WeaponManager.且专专丁丌丗丛且丙.Item[ShopNGUIController.丛丐丛专丟丞万三七()];
        val_72 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专;
        WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  val_61.丟丌东且上业丝丂丞, 专丟丌丄东且上业一:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), 下业丕七东丌丝下且:  val_72.丒万丕七专不丏丞丌(), 下与丙业丁世三丞丒:  true);
        if(val_83 == 0)
        {
            goto label_208;
        }
        
        label_190:
        val_87 = null;
        val_87 = null;
        if((System.String.op_Inequality(a:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), b:  WeaponManager.业丝丛丂三丄丁与丁)) == false)
        {
            goto label_208;
        }
        
        if(val_73 >= 100)
        {
                if(ShopNGUIController.丛丐丛专丟丞万三七() != 105)
        {
            goto label_208;
        }
        
        }
        
        label_205:
        val_72 = 1152921505286238208;
        val_73 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌();
        WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七(), 专丟丌丄东且上业一:  val_73, 下业丕七东丌丝下且:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌(), 下与丙业丁世三丞丒:  true);
        label_208:
        val_88 = null;
        val_88 = null;
        if(WeaponManager.丟下丌丆万东下专丏 == null)
        {
                return;
        }
        
        val_74 = 与丘东下丈东丛丂万.三丐三丞丘丕不丒专;
        WeaponManager.丟下丌丆万东下专丏.Invoke(obj:  val_74);
    }
    private static void 丈丝丕上丏丌丏一丁(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)
    {
        null = null;
        if(WeaponManager.与丏世专万丘丁丄丑 == null)
        {
                return;
        }
        
        WeaponManager.与丏世专万丘丁丄丑.Invoke(obj:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专);
    }
    internal System.Collections.Generic.List<三丅丁丗丗丝丂万且> 丘一丄丕不专上三丅()
    {
        return (System.Collections.Generic.List<三丅丁丗丗丝丂万且>)this.万丛丌东与三丅一东;
    }
    internal System.Collections.Generic.List<三丈丟与丏丘丈丐万> 下上丏丁东丝丑世与()
    {
        return (System.Collections.Generic.List<三丈丟与丏丘丈丐万>)this.丙下丅丒与丈丈丒与;
    }
    internal void 丁丆七丆丝丌世丂丗(System.Collections.Generic.List<三丈丟与丏丘丈丐万> 丙业与丙丗丝不丈东)
    {
        this.丙下丅丒与丈丈丒与 = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<三丈丟与丏丘丈丐万> 丅下三且万丟东不下()
    {
        return (System.Collections.Generic.List<三丈丟与丏丘丈丐万>)this.丁一丏东七丌丗丁丏;
    }
    private void 三东丂丒与丏丂丝上(System.Collections.Generic.List<三丈丟与丏丘丈丐万> 丙业与丙丗丝不丈东)
    {
        this.丁一丏东七丌丗丁丏 = 丙业与丙丗丝不丈东;
    }
    internal WeaponSounds 丞丛丏丐丘与丆七丗()
    {
        return (WeaponSounds)this.专丑一业业下且丅丗;
    }
    internal void 丙丄丕丞丛万与丟丆(WeaponSounds 丙业与丙丗丝不丈东)
    {
        this.专丑一业业下且丅丗 = 丙业与丙丗丝不丈东;
    }
    private void 丆丛丛丅上丐丌且丘(FilterMaps 专丆丌丛东一不丑丙)
    {
        var val_21;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        System.Func<System.Collections.Generic.List<System.String>, System.Collections.Generic.IEnumerable<System.String>> val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        val_36 = this;
        val_37 = null;
        val_37 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                bool val_2 = GameConnect.世丐丄三三上丅七三();
        }
        
        val_38 = 0;
        if(GameConnect.丌专丌万一下丕专上() != false)
        {
                val_39 = null;
            val_39 = null;
            val_40 = null;
            val_40 = null;
            val_42 = WeaponManager.<>c.<>9__435_0;
            if(val_42 == null)
        {
                System.Func<System.Collections.Generic.List<System.String>, System.Collections.Generic.IEnumerable<System.String>> val_4 = null;
            val_42 = val_4;
            val_4 = new System.Func<System.Collections.Generic.List<System.String>, System.Collections.Generic.IEnumerable<System.String>>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> WeaponManager.<>c::与丒不丅上丕丝万丘(System.Collections.Generic.List<string> 专万丏丝丟丈丝丄丕));
            WeaponManager.<>c.<>9__435_0 = val_42;
        }
        
            System.Collections.Generic.HashSet<System.String> val_6 = null;
            val_38 = val_6;
            val_6 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.List<System.String>, System.String>(source:  ZombieCreator.丂下七丈丄丄东专丒, selector:  val_4));
            bool val_7 = val_6.Add(item:  "Weapon9");
        }
        
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
            goto label_23;
        }
        
        System.Collections.Generic.HashSet<System.String> val_9 = null;
        val_38 = val_9;
        val_9 = new System.Collections.Generic.HashSet<System.String>();
        val_43 = 0;
        goto label_24;
        label_33:
        val_44 = null;
        val_44 = null;
        bool val_13 = val_9.Add(item:  "Weapon" + ChestController.weaponForHungerGames.Length + 32.ToString()(ChestController.weaponForHungerGames.Length + 32.ToString()));
        val_43 = 1;
        label_24:
        val_45 = null;
        val_45 = null;
        if(val_43 < ChestController.weaponForHungerGames.Length)
        {
            goto label_33;
        }
        
        val_36 = val_36;
        bool val_14 = val_9.Add(item:  "Weapon9");
        label_23:
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_17 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>(capacity:  丏丄丑上丛不丈且万.丛丐专不世丂丝与三().Count);
        List.Enumerator<T> val_19 = 丏丄丑上丛不丈且万.丛丐专不世丂丝与三().GetEnumerator();
        label_77:
        if((634447280 & 1) == 0)
        {
            goto label_42;
        }
        
        string val_22 = val_21.丐丏七丌丕丗业且上();
        if(val_22.丒丁三三丙丄上上丛() == true)
        {
            goto label_77;
        }
        
        if(专丆丌丛东一不丑丙 <= 99)
        {
                if(((val_22.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  专丆丌丛东一不丑丙)) ^ 1) == true)
        {
            goto label_77;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_48;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_51;
        }
        
        val_17.Add(item:  val_22);
        goto label_77;
        label_48:
        val_17.Add(item:  val_22);
        goto label_77;
        label_51:
        if(0 == 0)
        {
            goto label_56;
        }
        
        val_46 = "Weapon";
        if("Weapon" == null)
        {
                val_46 = "Weapon";
        }
        
        int val_30 = System.Int32.Parse(s:  val_22.三与丛丑且丐丈业丌().Substring(startIndex:  Length));
        if(val_30 == 9)
        {
            goto label_60;
        }
        
        val_47 = null;
        val_47 = null;
        if((万上丈专丐专丞丛丛.丟不下下且业丛丄丏(丞下万上三丘上与专:  ChestController.weaponForHungerGames, 丏东丁丂七丟不丒丅:  val_30)) == false)
        {
            goto label_77;
        }
        
        label_60:
        val_17.Add(item:  val_22);
        goto label_77;
        label_56:
        if(val_22.七不丕世且丟丑丈丒() != false)
        {
                if((GameConnect.丙丘不世专且万丄丐() == false) || ((val_9.Contains(item:  val_22.三与丛丑且丐丈业丌())) == false))
        {
            goto label_77;
        }
        
        }
        
        val_17.Add(item:  val_22);
        goto label_77;
        label_42:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.万丛丌东与三丅一东 = val_17;
    }
    private bool 丈万东不丁与且东东(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业, System.Collections.Generic.List<string> 一业丆世丂世上丛丂, FilterMaps 专丆丌丛东一不丑丙)
    {
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        bool val_1 = GameConnect.万不丒丌丙万丗东不();
        if(丆丐七世世且丏丐业 == null)
        {
            goto label_3;
        }
        
        if(val_1 == false)
        {
            goto label_4;
        }
        
        label_7:
        val_68 = null;
        val_68 = null;
        return System.String.op_Equality(a:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), b:  与世丁丙且丑下丌不.与丝业丆七丐下三丐);
        label_3:
        if(val_1 == true)
        {
            goto label_7;
        }
        
        label_4:
        string val_5 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌()).与不丞丑七丘丁丂丛();
        val_69 = null;
        val_69 = null;
        var val_7 = (与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) ? 1 : 0;
        bool val_8 = GameConnect.世丐丄三三上丅七三();
        bool val_9 = GameConnect.上丏丈七丘丁与丅丏();
        if(((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true) || (GameConnect.万七丄丛丈丟专一丑() == false)) || ((System.String.op_Equality(a:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌(), b:  "Weapon1004")) == false))
        {
            goto label_22;
        }
        
        label_135:
        val_70 = 1;
        return (bool)val_70;
        label_22:
        if(GameConnect.万七丄丛丈丟专一丑() != true)
        {
                if((System.String.op_Equality(a:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌(), b:  "Weapon1004")) == false)
        {
            goto label_28;
        }
        
        }
        
        val_70 = 0;
        return (bool)val_70;
        label_28:
        bool val_17 = val_9 & val_7;
        val_17 = val_17 & 丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈();
        if(val_17 != true)
        {
            goto label_29;
        }
        
        if((((System.String.op_Equality(a:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌(), b:  "Weapon962")) == true) || ((System.String.op_Equality(a:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌(), b:  "Weapon963")) == true)) || ((System.String.op_Equality(a:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌(), b:  "Weapon250")) == true))
        {
            goto label_135;
        }
        
        val_71 = null;
        val_71 = null;
        if(一业丆世丂世上丛丂 == null)
        {
                return (bool)val_70;
        }
        
        if((WeaponManager.丅丑丏上丟丌丛丑丐.Contains(item:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌())) == false)
        {
                return (bool)val_70;
        }
        
        return 一业丆世丂世上丛丂.Contains(item:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌());
        label_29:
        if((专丆丌丛东一不丑丙 != 3) || (与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false))
        {
            goto label_47;
        }
        
        val_72 = null;
        val_72 = null;
        if((丆丐七世世且丏丐业.三与丛丑且丐丈业丌().Equals(value:  WeaponManager.业丝丛丂三丄丁与丁)) == true)
        {
            goto label_135;
        }
        
        label_47:
        if((((System.String.op_Equality(a:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌(), b:  "Weapon9")) == true) || ((val_8 | (~(System.String.op_Equality(a:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌(), b:  "Weapon1")))) == false)) || ((val_8 | (~(丆丐七世世且丏丐业.三与丛丑且丐丈业丌().Equals(value:  "Weapon2")))) == false))
        {
            goto label_135;
        }
        
        if((丆丐七世世且丏丐业.三与丛丑且丐丈业丌().Equals(value:  "Weapon3")) != false)
        {
                if(((val_8 | val_7) == false) || (GameConnect.丌专丌万一下丕专上() == true))
        {
            goto label_135;
        }
        
        }
        
        if((丆丐七世世且丏丐业.三与丛丑且丐丈业丌().Equals(value:  "Weapon67")) != false)
        {
                if(((val_8 | val_7) == false) || (GameConnect.丌专丌万一下丕专上() == true))
        {
            goto label_135;
        }
        
        }
        
        if((丆丐七世世且丏丐业.三与丛丑且丐丈业丌().Equals(value:  "Weapon333")) != false)
        {
                if(((val_8 | val_7) == false) || (GameConnect.丌专丌万一下丕专上() == true))
        {
            goto label_135;
        }
        
        }
        
        val_73 = null;
        val_73 = null;
        if((丆丐七世世且丏丐业.三与丛丑且丐丈业丌().Equals(value:  WeaponManager.丞丌上万丆下东丞七)) != false)
        {
                if(((val_8 | val_7) == false) || (GameConnect.丌专丌万一下丕专上() == true))
        {
            goto label_135;
        }
        
        }
        
        bool val_53 = val_9 ^ 1;
        val_53 = ((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true) ? 1 : 0) | val_53;
        if(val_53 == true)
        {
            goto label_116;
        }
        
        val_74 = null;
        val_74 = null;
        if(((下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.ContainsValue(value:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌())) == false) || ((一业丆世丂世上丛丂.Contains(item:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌())) == false))
        {
            goto label_116;
        }
        
        val_75 = null;
        val_75 = null;
        if((WeaponManager.丅丑丏上丟丌丛丑丐.Contains(item:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌())) == false)
        {
            goto label_135;
        }
        
        label_116:
        if((丆丐七世世且丏丐业.三与丛丑且丐丈业丌().Equals(value:  "Weapon250")) != false)
        {
                val_76 = (一业丆世丂世上丛丂.Contains(item:  "Weapon250")) ^ 1;
        }
        else
        {
                val_76 = 1;
        }
        
        bool val_65 = ((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true) ? 1 : 0) | (~GameConnect.丌专丌万一下丕专上());
        val_65 = val_76 | val_65;
        if(val_65 == false)
        {
            goto label_135;
        }
        
        bool val_66 = val_8 | val_7;
        val_66 = val_66 | val_76;
        var val_67 = (~val_66) & 1;
        return (bool)val_70;
    }
    internal static bool 丄专丞东专下丑不丝()
    {
        null = null;
        return (bool)WeaponManager.<专丗丆且丒丙丗丆丐>k__BackingField;
    }
    internal static void 丟丅丌下丛七丁业上(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        WeaponManager.<专丗丆且丒丙丗丆丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丒丆丟丒丞下不丗与()
    {
        var val_10;
        System.Object[] val_37;
        int val_38;
        var val_39;
        var val_41;
        System.Collections.Generic.List<System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_42;
        var val_43;
        System.Func<三丅丁丗丗丝丂万且, System.Int32> val_45;
        var val_46;
        System.Func<三丅丁丗丗丝丂万且, System.Single> val_48;
        .七丞丙丒三丕且丌丟 = 0;
        label_85:
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_3 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_4 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_5 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        val_38 = (WeaponManager.丁丆丛丟丂业丁丏上)[1152921539601939952].七丞丙丒三丕且丌丟;
        List.Enumerator<T> val_8 = this.丈丆丝丁丟与不丁万.Item[val_38].GetEnumerator();
        label_41:
        if((635310480 & 1) == 0)
        {
            goto label_31;
        }
        
        string val_11 = val_10.丐丏七丌丕丗业且上();
        if((val_11.七丑丌专丒上丒丙七() != null) || (val_11.丐七丐丝与丒七丈丐().丈一下下丞世三丑丄() <= ExperienceController.丞丞丘业东丙丏七丌()))
        {
            goto label_36;
        }
        
        val_5.Add(item:  val_11);
        goto label_41;
        label_36:
        (val_11.与丕丒世七丁万丂丛() != true) ? (val_3) : (val_4).Add(item:  val_11);
        goto label_41;
        label_31:
        var val_36 = 0;
        val_39 = 1152921539147417088;
        val_36 = val_36 + 1;
        mem2[0] = 162;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_38 = val_36;
        if((val_38 != 1) && ((635310416 + ((0 + 1)) << 2) == 162))
        {
                var val_37 = 0;
            val_37 = val_37 ^ (val_38 >> 31);
            val_38 = val_38 + val_37;
        }
        
        val_41 = null;
        val_41 = null;
        val_3.Sort(comparison:  WeaponManager.一不丙丄丕丕七上万);
        val_4.Sort(comparison:  WeaponManager.一不丙丄丕丕七上万);
        val_42 = this.丈丆丝丁丟与不丁万;
        val_37 = System.Linq.Enumerable.Concat<三丅丁丗丗丝丂万且>(first:  val_4, second:  val_3);
        val_43 = null;
        val_43 = null;
        val_45 = WeaponManager.<>c.<>9__442_0;
        if(val_45 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, System.Int32> val_18 = null;
            val_45 = val_18;
            val_18 = new System.Func<三丅丁丗丗丝丂万且, System.Int32>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponManager.<>c::丈丐丂丏丐下与一丘(三丅丁丗丗丝丂万且 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__442_0 = val_45;
        }
        
        val_46 = null;
        val_46 = null;
        val_48 = WeaponManager.<>c.<>9__442_1;
        if(val_48 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, System.Single> val_20 = null;
            val_48 = val_20;
            val_20 = new System.Func<三丅丁丗丗丝丂万且, System.Single>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Single WeaponManager.<>c::丕丏丗丂丆丗与丏丕(三丅丁丗丗丝丂万且 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__442_1 = val_48;
        }
        
        val_42.set_Item(index:  (WeaponManager.丁丆丛丟丂业丁丏上)[1152921539601939952].七丞丙丒三丕且丌丟, value:  System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Concat<三丅丁丗丗丝丂万且>(first:  val_37, second:  System.Linq.Enumerable.ThenBy<三丅丁丗丗丝丂万且, System.Single>(source:  System.Linq.Enumerable.OrderBy<三丅丁丗丗丝丂万且, System.Int32>(source:  val_5, keySelector:  val_18), keySelector:  val_20))));
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
        {
            goto label_78;
        }
        
        new WeaponManager.丙世丒丁丑丅丗万丛() = new WeaponManager.丙世丒丁丑丅丗万丛();
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_27 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new WeaponManager.丁丆丛丟丂业丁丏上(), method:  System.Boolean WeaponManager.丁丆丛丟丂业丁丏上::丙丆丕不丝且丕丄丌(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        val_37 = System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  this.丙下丅丒与丈丈丒与, predicate:  null);
        if(new WeaponManager.丙世丒丁丑丅丗万丛() == null)
        {
            goto label_72;
        }
        
        .丐且丅一丙三丏下丈 = val_37;
        if(val_37 != null)
        {
            goto label_73;
        }
        
        goto label_78;
        label_72:
        mem[16] = val_37;
        val_37 = mem[16];
        if(val_37 == 0)
        {
            goto label_78;
        }
        
        label_73:
        val_37 = this.丈丆丝丁丟与不丁万.Item[(WeaponManager.丁丆丛丟丂业丁丏上)[1152921539601939952].七丞丙丒三丕且丌丟];
        System.Predicate<三丅丁丗丗丝丂万且> val_30 = new System.Predicate<三丅丁丗丗丝丂万且>(object:  new WeaponManager.丙世丒丁丑丅丗万丛(), method:  System.Boolean WeaponManager.丙世丒丁丑丅丗万丛::丏万丕丛丕丆上一丁(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
        int val_31 = val_37.FindIndex(match:  null);
        if(val_31 != 1)
        {
                val_37 = this.丈丆丝丁丟与不丁万.Item[(WeaponManager.丁丆丛丟丂业丁丏上)[1152921539601939952].七丞丙丒三丕且丌丟].Item[val_31];
            val_42 = (WeaponManager.丁丆丛丟丂业丁丏上)[1152921539601939952].七丞丙丒三丕且丌丟;
            this.丈丆丝丁丟与不丁万.Item[val_42].RemoveAt(index:  val_31);
            this.丈丆丝丁丟与不丁万.Item[(WeaponManager.丁丆丛丟丂业丁丏上)[1152921539601939952].七丞丙丒三丕且丌丟].Insert(index:  0, item:  val_37);
        }
        
        label_78:
        int val_39 = (WeaponManager.丁丆丛丟丂业丁丏上)[1152921539601939952].七丞丙丒三丕且丌丟;
        val_39 = val_39 + 1;
        .七丞丙丒三丕且丌丟 = val_39;
        if(val_39 < 6)
        {
            goto label_85;
        }
        
        WeaponManager.丟丅丌下丛七丁业上(丙业与丙丗丝不丈东:  false);
    }
    internal static System.Collections.Generic.HashSet<string> 上丙上万七丆丐丆业()
    {
        null = null;
        return (System.Collections.Generic.HashSet<System.String>)WeaponManager.丞丅丟不万七丞丑丌;
    }
    internal static bool 丕下丘丆万丌丝丟丞(string 丒东业不丐丑丕丄丆)
    {
        string val_8;
        var val_9;
        val_8 = 1152921505284374528;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丒东业不丐丑丕丄丆)) == true)
        {
                return false;
        }
        
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        if(val_2 == null)
        {
                return false;
        }
        
        val_8 = val_2.三与丛丑且丐丈业丌();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) == true)
        {
                return false;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = WeaponManager.丞丅丟不万七丞丑丌;
        if((val_8.Contains(item:  val_2.三与丛丑且丐丈业丌())) != false)
        {
                return false;
        }
        
        System.Collections.Generic.HashSet<System.String> val_7 = WeaponManager.丐上业丐丏丐万世丑();
        if(val_7 != null)
        {
                return val_7.Contains(item:  丒东业不丐丑丕丄丆);
        }
        
        return val_7.Contains(item:  丒东业不丐丑丕丄丆);
    }
    internal static System.Collections.Generic.HashSet<string> 丐上业丐丏丐万世丑()
    {
        System.Collections.Generic.HashSet<T> val_17;
        var val_18;
        var val_20;
        System.Func<System.String, 世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>> val_22;
        var val_23;
        System.Func<世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>, System.Boolean> val_25;
        var val_26;
        System.Func<世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>, System.String> val_28;
        var val_29;
        var val_30;
        System.Func<System.String, System.Boolean> val_32;
        var val_33;
        var val_34;
        System.Func<System.String, System.Boolean> val_36;
        var val_37;
        var val_38;
        System.Func<System.String, System.Boolean> val_40;
        val_18 = null;
        val_18 = null;
        if(WeaponManager.东丛专丛丅丒丐丐丄 == null)
        {
                val_20 = null;
            val_20 = null;
            val_22 = WeaponManager.<>c.<>9__449_0;
            if(val_22 == null)
        {
                System.Func<System.String, 世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>> val_1 = null;
            val_22 = val_1;
            val_1 = new System.Func<System.String, 世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且> WeaponManager.<>c::丆丁丌不不世丒丒丐(string 专丟丌丄东且上业一));
            WeaponManager.<>c.<>9__449_0 = val_22;
        }
        
            val_23 = null;
            val_23 = null;
            val_25 = WeaponManager.<>c.<>9__449_1;
            if(val_25 == null)
        {
                System.Func<世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>, System.Boolean> val_3 = null;
            val_25 = val_3;
            val_3 = new System.Func<世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::一丞专一且与丘世一(世丏丐上丌丒丏丒上<string, 三丅丁丗丗丝丂万且> 丟业丙东三丂丈丘业));
            WeaponManager.<>c.<>9__449_1 = val_25;
        }
        
            val_26 = null;
            val_26 = null;
            val_28 = WeaponManager.<>c.<>9__449_2;
            if(val_28 == null)
        {
                System.Func<世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>, System.String> val_5 = null;
            val_28 = val_5;
            val_5 = new System.Func<世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::三丁丐丒不丂丟丈丛(世丏丐上丌丒丏丒上<string, 三丅丁丗丗丝丂万且> 丟业丙东三丂丈丘业));
            WeaponManager.<>c.<>9__449_2 = val_28;
        }
        
            val_29 = null;
            val_29 = null;
            val_30 = null;
            val_30 = null;
            val_32 = WeaponManager.<>c.<>9__449_3;
            if(val_32 == null)
        {
                System.Func<System.String, System.Boolean> val_7 = null;
            val_32 = val_7;
            val_7 = new System.Func<System.String, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::一世丒三且丟丞世业(string 丒东业不丐丑丕丄丆));
            WeaponManager.<>c.<>9__449_3 = val_32;
        }
        
            val_33 = null;
            val_33 = null;
            val_34 = null;
            val_34 = null;
            val_36 = WeaponManager.<>c.<>9__449_4;
            if(val_36 == null)
        {
                System.Func<System.String, System.Boolean> val_10 = null;
            val_36 = val_10;
            val_10 = new System.Func<System.String, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丝丞东丏专丆丐业下(string 丒东业不丐丑丕丄丆));
            WeaponManager.<>c.<>9__449_4 = val_36;
        }
        
            val_37 = null;
            val_37 = null;
            val_38 = null;
            val_38 = null;
            val_40 = WeaponManager.<>c.<>9__449_5;
            if(val_40 == null)
        {
                System.Func<System.String, System.Boolean> val_13 = null;
            val_40 = val_13;
            val_13 = new System.Func<System.String, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丄丙业丛丟一业丏上(string 丒东业不丐丑丕丄丆));
            WeaponManager.<>c.<>9__449_5 = val_40;
        }
        
            System.Collections.Generic.HashSet<System.String> val_16 = null;
            val_17 = val_16;
            val_16 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.Union<System.String>(first:  System.Linq.Enumerable.Union<System.String>(first:  System.Linq.Enumerable.Union<System.String>(first:  System.Linq.Enumerable.Select<世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>, System.String>(source:  System.Linq.Enumerable.Where<世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>>(source:  System.Linq.Enumerable.Select<System.String, 世丏丐上丌丒丏丒上<System.String, 三丅丁丗丗丝丂万且>>(source:  WeaponManager.丞丅丟不万七丞丑丌, selector:  val_1), predicate:  val_3), selector:  val_5), second:  System.Linq.Enumerable.Where<System.String>(source:  WeaponManager.丆丘丘丑丌丁世七不, predicate:  val_7)), second:  System.Linq.Enumerable.Where<System.String>(source:  WeaponManager.丗丈丁世且世丂丈丝, predicate:  val_10)), second:  System.Linq.Enumerable.Where<System.String>(source:  WeaponManager.丆丘下丛不丒丛丌丄, predicate:  val_13)));
            val_18 = null;
            val_18 = null;
            WeaponManager.东丛专丛丅丒丐丐丄 = val_17;
        }
        
        val_18 = null;
        return (System.Collections.Generic.HashSet<System.String>)WeaponManager.东丛专丛丅丒丐丐丄;
    }
    private static void 丟丙丘丄丈丟丆专丐()
    {
        var val_3 = null;
        WeaponManager.万丛丒上三丟丗丞专 = new System.Collections.Generic.HashSet<System.String>(collection:  BalanceController.丕丒丙不业丝丟丘丁());
    }
    internal static System.Collections.Generic.HashSet<string> 丞上一丘丆三下丐丑()
    {
        var val_1 = null;
        if(WeaponManager.万丛丒上三丟丗丞专 == null)
        {
                WeaponManager.丟丙丘丄丈丟丆专丐();
            val_1 = null;
        }
        
        val_1 = null;
        return (System.Collections.Generic.HashSet<System.String>)WeaponManager.万丛丒上三丟丗丞专;
    }
    private void 丄丁丞丄不丂丏一丏(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        var val_43;
        var val_44;
        string val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        val_43 = 丆丐七世世且丏丐业.一丝丈丂世丒丟东丕();
        if((val_43.Contains(item:  104)) == true)
        {
                return;
        }
        
        val_43 = 丆丐七世世且丏丐业.一丝丈丂世丒丟东丕();
        if((val_43.Contains(item:  110)) == true)
        {
                return;
        }
        
        丕丑丙丑丙东丌丘丕 val_7 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  丆丐七世世且丏丐业.业东丅东丌上丗丑不());
        val_44 = null;
        val_44 = null;
        val_45 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  val_45)) == false)
        {
            goto label_22;
        }
        
        if(((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.threechests")) == true) || ((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.roulette")) == true))
        {
            goto label_30;
        }
        
        val_46 = null;
        val_46 = null;
        val_45 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        if((WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  val_45)) != false)
        {
                if(ExperienceController.丞丞丘业东丙丏七丌() > 1)
        {
            goto label_30;
        }
        
        }
        
        label_22:
        val_47 = null;
        val_47 = null;
        val_45 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  val_45)) == true)
        {
            goto label_30;
        }
        
        string val_17 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        if((val_17.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_17)) == false)
        {
            goto label_32;
        }
        
        label_30:
        val_43 = 1;
        label_65:
        业丟丘一丑丗世丏丁.丑七不且上丗丁一世().七一丕丆丐万丏下丌(丆丐七世世且丏丐业:  丆丐七世世且丏丐业, 丐专丙丝丕丅丄丌丅:  true);
        if(val_43 == 0)
        {
                return;
        }
        
        val_43 = 丆丐七世世且丏丐业.万上丄下业丛丌不丈();
        this.丈丆丝丁丟与不丁万.Item[val_43 - 1].Add(item:  丆丐七世世且丏丐业);
        return;
        label_32:
        if((val_7 != null) || ((WeaponManager.丞上一丘丆三下丐丑().Contains(item:  丆丐七世世且丏丐业.三与丛丑且丐丈业丌())) == false))
        {
            goto label_45;
        }
        
        label_60:
        val_48 = 0;
        goto label_58;
        label_45:
        if((val_7 == null) && ((WeaponManager.丐上业丐丏丐万世丑().Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛())) != false))
        {
                if(((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛())) | (与丑丛万不东专丅丙.丕三丌万丞世丟七丑(丞一丁业丄一一业且:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), 世七七丟丑丁丂与丞:  40))) == false)
        {
            goto label_56;
        }
        
        }
        
        if(val_7 == null)
        {
            goto label_57;
        }
        
        val_48 = 1;
        goto label_58;
        label_56:
        string val_35 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        if((val_35.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_35)) == false)
        {
            goto label_60;
        }
        
        label_57:
        val_49 = null;
        val_49 = null;
        System.Collections.Generic.HashSet<System.String> val_42 = WeaponManager.丆丘丘丑丌丁世七不;
        val_48 = (val_42.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛())) ^ 1;
        label_58:
        val_42 = val_48;
        goto label_65;
    }
    private void 丟丆丛且丗丒丁一丏(bool 万业丒丙丂丝丗不丈, FilterMaps 专丆丌丛东一不丑丙)
    {
        var val_18;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        System.Action val_86;
        var val_87;
        System.Action<System.Collections.Generic.List<三丅丁丗丗丝丂万且>> val_89;
        var val_90;
        var val_91;
        var val_92;
        var val_93;
        WeaponManager.丑丐丌丌丞丑丏丏丞 val_1 = new WeaponManager.丑丐丌丌丞丑丏丏丞();
        if(val_1 != null)
        {
                .万业丒丙丂丝丗不丈 = 万业丒丙丂丝丗不丈;
        }
        else
        {
                mem[16] = 万业丒丙丂丝丗不丈;
        }
        
        .丝且与丝丒丟万丁专 = this;
        val_81 = null;
        val_81 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_82 = GameConnect.世丐丄三三上丅七三();
        }
        else
        {
                val_82 = 0;
        }
        
        val_83 = 1152921505066536960;
        var val_6 = (与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true) ? 1 : 0;
        bool val_79 = GameConnect.上丏丈七丘丁与丅丏();
        bool val_8 = 丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈();
        char[] val_11 = new char[1];
        val_79 = val_79 ^ 1;
        val_11[0] = '#';
        val_6 = val_6 | val_79;
        System.Collections.Generic.List<System.String> val_13 = null;
        val_84 = val_13;
        val_13 = new System.Collections.Generic.List<System.String>();
        val_85 = 0;
        goto label_19;
        label_23:
        val_13.Add(item:  Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟上七七一且丞丈与().Split(separator:  val_11)[0]);
        val_85 = 1;
        label_19:
        if(val_85 < val_12.Length)
        {
            goto label_23;
        }
        
        System.Action val_14 = new System.Action(object:  val_1, method:  System.Void WeaponManager.丑丐丌丌丞丑丏丏丞::丕丗丕丄上丙丗丁丒());
        val_86 = 1152921505286717440;
        val_87 = null;
        val_87 = null;
        val_89 = WeaponManager.<>c.<>9__455_1;
        if(val_89 == null)
        {
            goto label_26;
        }
        
        label_83:
        mem[1152921539603388616].ForEach(action:  val_89);
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_30;
        }
        
        List.Enumerator<T> val_16 = mem[1152921539603388536].GetEnumerator();
        val_89 = 1152921525519450752;
        val_84 = 106453;
        label_40:
        if((636790960 & 1) == 0)
        {
            goto label_96;
        }
        
        string val_19 = val_18.丐丏七丌丕丗业且上();
        if(val_19.东七与与不丅丙上上() != true)
        {
                if((System.String.op_Equality(a:  val_19.三与丛丑且丐丈业丌(), b:  "Weapon19")) == false)
        {
            goto label_40;
        }
        
        }
        
        this.丄丁丞丄不丂丏一丏(丆丐七世世且丏丐业:  val_19);
        goto label_40;
        label_30:
        var val_23 = (val_82 != 0) ? 1 : 0;
        val_23 = val_23 | ((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) ? 1 : 0);
        if(val_23 == 1)
        {
                if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_44;
        }
        
        }
        
        List.Enumerator<T> val_25 = mem[1152921539603388536].GetEnumerator();
        val_82 = 1152921505286238208;
        val_83 = 1152921538214977056;
        label_79:
        if((636790960 & 1) == 0)
        {
            goto label_96;
        }
        
        string val_26 = val_18.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_26.三与丛丑且丐丈业丌(), b:  "Weapon1004")) == true)
        {
            goto label_79;
        }
        
        val_90 = null;
        val_90 = null;
        if((System.String.op_Equality(a:  val_26.三与丛丑且丐丈业丌(), b:  WeaponManager.业丝丛丂三丄丁与丁)) == false)
        {
            goto label_52;
        }
        
        if(专丆丌丛东一不丑丙 != 3)
        {
            goto label_79;
        }
        
        mem[1152921539603388616].Item[val_26.万上丄下业丛丌不丈() - 1].Add(item:  val_26);
        goto label_79;
        label_52:
        if((val_26.七不丕世且丟丑丈丒() == true) || ((System.String.op_Equality(a:  val_26.三与丛丑且丐丈业丌(), b:  "Weapon52")) == true))
        {
            goto label_79;
        }
        
        if((System.String.op_Equality(a:  val_26.三与丛丑且丐丈业丌(), b:  "Weapon250")) == false)
        {
            goto label_69;
        }
        
        if((val_13.Contains(item:  "Weapon250")) == false)
        {
            goto label_79;
        }
        
        mem[1152921539603388616].Item[val_26.万上丄下业丛丌不丈() - 1].Add(item:  val_26);
        goto label_79;
        label_69:
        this.丄丁丞丄不丂丏一丏(丆丐七世世且丏丐业:  val_26);
        goto label_79;
        label_26:
        WeaponManager.<>c.<>9__455_1 = new System.Action<System.Collections.Generic.List<三丅丁丗丗丝丂万且>>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WeaponManager.<>c::三丄丞丙丌丙上世丏(System.Collections.Generic.List<三丅丁丗丗丝丂万且> 丝丘丑业丛万丞丌丝));
        if(mem[1152921539603388616] != 0)
        {
            goto label_83;
        }
        
        goto label_83;
        label_44:
        if(val_6 == false)
        {
            goto label_84;
        }
        
        if(val_82 == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_44 = mem[1152921539603388536].GetEnumerator();
        val_89 = 1152921525519450752;
        val_84 = 106462;
        label_93:
        if((636790960 & 1) == 0)
        {
            goto label_96;
        }
        
        string val_45 = val_18.丐丏七丌丕丗业且上();
        val_82 = val_45.三与丛丑且丐丈业丌();
        if((val_82.Equals(value:  "Weapon9")) == false)
        {
            goto label_93;
        }
        
        this.丄丁丞丄不丂丏一丏(丆丐七世世且丏丐业:  val_45);
        goto label_96;
        label_84:
        List.Enumerator<T> val_48 = mem[1152921539603388536].GetEnumerator();
        val_83 = 1152921525519450752;
        val_82 = "Weapon1004";
        label_162:
        if((636790960 & 1) == 0)
        {
            goto label_96;
        }
        
        string val_49 = val_18.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_49.三与丛丑且丐丈业丌(), b:  "Weapon1004")) == true)
        {
            goto label_162;
        }
        
        if((106520 & 1) == 0)
        {
            goto label_99;
        }
        
        if((System.String.op_Equality(a:  val_49.三与丛丑且丐丈业丌(), b:  "Weapon250")) == true)
        {
            goto label_104;
        }
        
        val_91 = null;
        val_91 = null;
        if((WeaponManager.丅丑丏上丟丌丛丑丐.Contains(item:  val_49.三与丛丑且丐丈业丌())) == false)
        {
            goto label_162;
        }
        
        label_104:
        mem[1152921539603388616].Item[val_49.万上丄下业丛丌不丈() - 1].Add(item:  val_49);
        goto label_162;
        label_99:
        val_92 = null;
        val_92 = null;
        if((System.String.op_Equality(a:  val_49.三与丛丑且丐丈业丌(), b:  WeaponManager.业丝丛丂三丄丁与丁)) == true)
        {
            goto label_162;
        }
        
        if((((((val_49.七不丕世且丟丑丈丒() == true) || ((val_49.三与丛丑且丐丈业丌().Equals(value:  "Weapon250")) == true)) || ((val_49.三与丛丑且丐丈业丌().Equals(value:  "Weapon52")) == true)) || ((val_49.三与丛丑且丐丈业丌().Equals(value:  "Weapon3")) == true)) || ((val_49.三与丛丑且丐丈业丌().Equals(value:  "Weapon67")) == true)) || ((val_49.三与丛丑且丐丈业丌().Equals(value:  "Weapon333")) == true))
        {
            goto label_149;
        }
        
        val_93 = null;
        val_93 = null;
        if((val_49.三与丛丑且丐丈业丌().Equals(value:  WeaponManager.丞丌上万丆下东丞七)) == false)
        {
            goto label_154;
        }
        
        label_149:
        if((val_13.Contains(item:  val_49.三与丛丑且丐丈业丌())) == false)
        {
            goto label_162;
        }
        
        mem[1152921539603388616].Item[val_49.万上丄下业丛丌不丈() - 1].Add(item:  val_49);
        goto label_162;
        label_154:
        this.丄丁丞丄不丂丏一丏(丆丐七世世且丏丐业:  val_49);
        goto label_162;
        label_96:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_86 = val_14;
        val_14.Invoke();
    }
    private void 一下不丘丈丁丈与业(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)
    {
        System.Collections.Generic.IEnumerable<TSource> val_10;
        WeaponManager.下丄七丐丘丗丝丒专 val_1 = new WeaponManager.下丄七丐丘丗丝丒专();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .与丘东下丈东丛丂万 = 与丘东下丈东丛丂万;
        if(与丘东下丈东丛丂万 != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        val_10 = this.丈丆丝丁丟与不丁万.Item[与丘东下丈东丛丂万.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() - 1];
        if((System.Linq.Enumerable.Any<三丅丁丗丗丝丂万且>(source:  val_10, predicate:  new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.下丄七丐丘丗丝丒专::丏丒上丏上不不下丈(三丅丁丗丗丝丂万且 东七上世万下丗丄丛)))) != true)
        {
                val_10 = this.丈丆丝丁丟与不丁万.Item[与丘东下丈东丛丂万.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() - 1];
            val_10.Add(item:  与丘东下丈东丛丂万.三丐三丞丘丕不丒专);
        }
        
        this.丒丆丟丒丞下不丗与();
        return;
        label_1:
        mem[16] = 与丘东下丈东丛丂万;
        if(mem[16] != 0)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    internal void Reset(bool 万业丒丙丂丝丗不丈, FilterMaps 专丆丌丛东一不丑丙 = 0)
    {
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start Reset");
        System.Collections.IEnumerator val_2 = this.业丂下丒丙且世不丝(万业丒丙丂丝丗不丈:  万业丒丙丂丝丗不丈, 专丆丌丛东一不丑丙:  专丆丌丛东一不丑丙);
        goto label_3;
        label_14:
        var val_7 = 0;
        val_7 = val_7 + 1;
        object val_4 = val_2.Current;
        label_3:
        var val_8 = 0;
        val_8 = val_8 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_14;
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "End Reset");
    }
    internal static System.Collections.Generic.List<string> 一丝丞丗不丄万丅丗()
    {
        var val_7;
        var val_8;
        System.Func<丅一丈与丄三丝丝丞, System.String> val_10;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_1.Add(item:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七());
        val_7 = null;
        val_7 = null;
        val_8 = null;
        val_8 = null;
        val_10 = WeaponManager.<>c.<>9__459_0;
        if(val_10 != null)
        {
                return System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  val_1, second:  System.Linq.Enumerable.Select<丅一丈与丄三丝丝丞, System.String>(source:  WeaponManager.且专专丁丌丗丛且丙.Values, selector:  System.Func<丅一丈与丄三丝丝丞, System.String> val_4 = null)));
        }
        
        val_10 = val_4;
        val_4 = new System.Func<丅一丈与丄三丝丝丞, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::一丗丐丄上丑丛丗三(丅一丈与丄三丝丝丞 不七丅丗七万丈万且));
        WeaponManager.<>c.<>9__459_0 = val_10;
        return System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  val_1, second:  System.Linq.Enumerable.Select<丅一丈与丄三丝丝丞, System.String>(source:  WeaponManager.且专专丁丌丗丛且丙.Values, selector:  val_4)));
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.丑丘丗东丕丐下且专;
        if(val_1 <= 0.5f)
        {
                return;
        }
        
        this.丑丘丗东丕丐下且专 = UnityEngine.Time.realtimeSinceStartup;
        int val_4 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丝七丘丐七丟丟丁世();
        if(val_4 <= this.丆丒丗丈下丕丏下丗)
        {
                return;
        }
        
        this.丆丒丗丈下丕丏下丗 = val_4;
    }
    internal void 丄丕且一东丒业不丞()
    {
        var val_20;
        var val_21;
        var val_22;
        UnityEngine.Object val_23;
        var val_24;
        string val_25;
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_21 = null;
            val_21 = null;
            bool val_3 = UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  0);
        }
        
        System.Collections.Generic.List<CategoryNames> val_4 = new System.Collections.Generic.List<CategoryNames>();
        val_22 = 1152921505259454464;
        val_23 = 1152921505294970880;
        val_24 = 0;
        goto label_12;
        label_32:
        CategoryNames val_20 = new CategoryNames[4][0];
        val_25 = 丆丟七丌丞东丆丕丌.丈丑东丆丛万丙丅业(丁丂专业丁丅丅丈丙:  val_20);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_9 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  val_20.ToString());
        if(((val_25 != null) && (val_9 != null)) && ((val_9.Equals(value:  val_25)) != true))
        {
                string val_11 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  val_9);
            val_25 = val_11;
            if((System.String.IsNullOrEmpty(value:  val_11)) != true)
        {
                if((System.String.op_Inequality(a:  val_25, b:  val_9)) != false)
        {
                丆丟七丌丞东丆丕丌.丈且丗七丐丟上丌丒(丒东业不丐丑丕丄丆:  val_25, 丙丑丕丂下丏一丁专:  null, 丆万丐丗丅丘丆丁丌:  false);
            val_25 = null;
            val_4.Add(item:  val_25);
        }
        
        }
        
        }
        
        val_24 = 1;
        label_12:
        if(val_24 < val_5.Length)
        {
            goto label_32;
        }
        
        if(0 != 0)
        {
                val_22 = mem[1152921539604315416];
            val_23 = mem[mem[1152921539604315416] + 1576];
            val_23 = mem[1152921539604315416] + 1576;
            if(val_23 == 0)
        {
                return;
        }
        
            val_23 = mem[mem[1152921539604315416] + 1576];
            val_23 = mem[1152921539604315416] + 1576;
            val_23.专丁丗下业丏且丟世(专丞上七七且丝七丗:  0);
            val_22 = 1152921539096349248;
            if((val_4.Contains(item:  10)) != false)
        {
                val_23 = mem[mem[1152921539604315416] + 1576];
            val_23 = mem[1152921539604315416] + 1576;
            val_23.上丒丈世丗丆丗丛下(专丞上七七且丝七丗:  0, 业万丙丟丁丁下丌丅:  "");
        }
        
            if((val_4.Contains(item:  9)) != false)
        {
                val_23 = mem[mem[1152921539604315416] + 1576];
            val_23 = mem[1152921539604315416] + 1576;
            val_23.丑丞丟丁东丂三与丁(专丞上七七且丝七丗:  0, 万下上丏丙丈丄业丆:  "");
        }
        
            if((val_4.Contains(item:  6)) != false)
        {
                val_23 = mem[mem[1152921539604315416] + 1576];
            val_23 = mem[1152921539604315416] + 1576;
            val_23.丘丄丏世丒上东丘丒(专丞上七七且丝七丗:  0, 丙一丙丙丑丕丘万专:  "");
        }
        
            if((val_4.Contains(item:  12)) == false)
        {
                return;
        }
        
            val_22 = mem[mem[1152921539604315416] + 1576];
            val_22 = mem[1152921539604315416] + 1576;
            val_22.不一丙东七下不丕丑(专丞上七七且丝七丗:  0, 万丑丗七丁丂丗世专:  "");
            return;
        }
        
        if(val_4.Count < 1)
        {
                return;
        }
        
        PersConfigurator.与与丑丂丛上七上丗();
    }
    private 三丈丟与丏丘丈丐万 丝丟丌丛丆丅上万丑(string 丛丄东丙业上丈丄且)
    {
        三丅丁丗丗丝丂万且 val_5;
        var val_6;
        new 三丈丟与丏丘丈丐万() = new 三丈丟与丏丘丈丐万();
        val_5 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丛丄东丙业上丈丄且);
        if(new 三丈丟与丏丘丈丐万() == null)
        {
            goto label_3;
        }
        
        val_6 = new 三丈丟与丏丘丈丐万();
        .三丐三丞丘丕不丒专 = val_5;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        mem[48] = val_5;
        val_6 = 48;
        val_5 = mem[48];
        if(val_5 != 0)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        new 三丈丟与丏丘丈丐万().上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_5.丟七下专丈丏丕丈上());
        new 三丈丟与丏丘丈丐万().业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  val_6.下世下丂丂丌丑丝世());
        this.丁一丏东七丌丗丁丏.Add(item:  new 三丈丟与丏丘丈丐万());
        return (三丈丟与丏丘丈丐万)new 三丈丟与丏丘丈丐万();
    }
    internal FilterMaps 丟三上丁丗一丅丝丐()
    {
        return (FilterMaps)this.丅丛丗丒丏丕丞丒丐;
    }
    private static bool 丐丌丝丒专万丈丌丒(System.Collections.Generic.List<FilterMaps> 且丕万丞丏世丄上丗, System.Collections.Generic.List<FilterMaps> 丂丆东上丂丏丟下专)
    {
        System.Func<FilterMaps, FilterMaps> val_9;
        System.Collections.Generic.IEnumerable<TSource> val_10;
        var val_11;
        System.Func<FilterMaps, FilterMaps> val_13;
        var val_14;
        var val_16;
        var val_17;
        val_10 = 丂丆东上丂丏丟下专;
        if(且丕万丞丏世丄上丗 == null)
        {
                return (bool)val_17;
        }
        
        if(val_10 != null)
        {
                val_11 = null;
            val_11 = null;
            val_13 = WeaponManager.<>c.<>9__467_0;
            if(val_13 == null)
        {
                val_13 = null;
            val_13 = new System.Func<FilterMaps, FilterMaps>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  FilterMaps WeaponManager.<>c::与丌下丏七下业三丞(FilterMaps 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__467_0 = val_13;
        }
        
            val_14 = null;
            val_14 = null;
            val_9 = WeaponManager.<>c.<>9__467_1;
            if(val_9 == null)
        {
                val_9 = null;
            val_9 = new System.Func<FilterMaps, FilterMaps>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  FilterMaps WeaponManager.<>c::丙不丟丂世专丅不世(FilterMaps 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__467_1 = val_9;
        }
        
            val_16 = (System.Linq.Enumerable.SequenceEqual<FilterMaps>(first:  System.Linq.Enumerable.OrderBy<FilterMaps, FilterMaps>(source:  且丕万丞丏世丄上丗, keySelector:  null), second:  System.Linq.Enumerable.OrderBy<FilterMaps, FilterMaps>(source:  val_10, keySelector:  null))) ^ 1;
        }
        else
        {
                val_16 = 1;
        }
        
        val_17 = val_16 & 1;
        return (bool)val_17;
    }
    internal static void 丙与专丝下丏与上下(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.三与丂丙三专丑下丌, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.三与丂丙三专丑下丌 != 1152921505286242944);
    
    }
    internal static void 丛丏下丞丗业万丕丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.三与丂丙三专丑下丌, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.三与丂丙三专丑下丌 != 1152921505286242944);
    
    }
    internal System.Collections.IEnumerator 业丂下丒丙且世不丝(bool 万业丒丙丂丝丗不丈, FilterMaps 专丆丌丛东一不丑丙)
    {
        WeaponManager.丂一丛下下丞丕丈丛 val_1 = new WeaponManager.丂一丛下下丞丕丈丛(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .万业丒丙丂丝丗不丈 = 万业丒丙丂丝丗不丈;
        }
        else
        {
                mem[32] = this;
            .万业丒丙丂丝丗不丈 = 万业丒丙丂丝丗不丈;
        }
        
        .专丆丌丛东一不丑丙 = 专丆丌丛东一不丑丙;
        return (System.Collections.IEnumerator)val_1;
    }
    internal bool 丛丑丗丛丛丂丗丅丟(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上, 丕丈丏丝丗下丟丅丂 丙丗丕丟七丟上丈丌, int 丌丒丝东丌下丕丁丅)
    {
        var val_3;
        var val_4;
        三丈丟与丏丘丈丐万 val_16;
        System.Object[] val_17;
        int val_18;
        var val_19;
        val_17 = this;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_3;
        }
        
        if(三与世丈丂丕丏三上 == null)
        {
            goto label_4;
        }
        
        List.Enumerator<T> val_2 = this.丙下丅丒与丈丈丒与.GetEnumerator();
        val_18 = 1152921525778334208;
        label_11:
        if((638757232 & 1) == 0)
        {
            goto label_6;
        }
        
        val_16 = val_4.丐丏七丌丕丗业且上();
        if(((System.String.op_Equality(a:  X24.三与丛丑且丐丈业丌(), b:  三与世丈丂丕丏三上.三与丛丑且丐丈业丌())) == false) || ((val_16.七丝丈东丈丕丐与丗() == false) || (val_3 != 丙丗丕丟七丟上丈丌)))
        {
            goto label_11;
        }
        
        val_18 = 丙丗丕丟七丟上丈丌.且丗丟丟专一丈丙丝;
        val_16.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Min(a:  val_16.下世万丆丛专丒丑丙() + 丌丒丝东丌下丕丁丅, b:  val_18));
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_19 = 1;
        return (bool)val_19;
        label_4:
        val_17 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "AddW_eapon weapo_nRecord == null", args:  val_17);
        label_3:
        val_19 = 0;
        return (bool)val_19;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        三丈丟与丏丘丈丐万 val_14 = null;
        val_16 = val_14;
        val_14 = new 三丈丟与丏丘丈丐万();
        if(val_16 != null)
        {
                .三丐三丞丘丕不丒专 = 三与世丈丂丕丏三上;
            val_14.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  0);
            val_14.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  丌丒丝东丌下丕丁丅);
        }
        else
        {
                mem[48] = 三与世丈丂丕丏三上;
            val_14.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  0);
            val_14.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  丌丒丝东丌下丕丁丅);
        }
        
        .丙丗丕丟七丟上丈丌 = 丙丗丕丟七丟上丈丌;
        val_19 = 1;
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_14, 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        return (bool)val_19;
    }
    internal bool 三下丗万丆专丄且东(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上, out int 万且丒下丕丝专丟上, bool 丁且丟不七下丆丒丟, bool 丙丏与丘一丁上丙一, int 丟丒丙丁丑丐世三丈 = -1, int 上丂丝上丘专丟丁丈 = -1)
    {
        var val_21;
        int val_87;
        System.Object[] val_88;
        三丅丁丗丗丝丂万且 val_89;
        var val_90;
        var val_91;
        var val_92;
        var val_94;
        var val_95;
        var val_96;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_98;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        var val_104;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_105;
        var val_106;
        var val_107;
        var val_108;
        val_87 = 丟丒丙丁丑丐世三丈;
        val_88 = this;
        int val_36 = 0;
        WeaponManager.丞下丁七丙七丄与丐 val_1 = null;
        val_89 = val_1;
        val_1 = new WeaponManager.丞下丁七丙七丄与丐();
        .三与世丈丂丕丏三上 = 三与世丈丂丕丏三上;
        万且丒下丕丝专丟上 = 0;
        if(PolygonController.一下一万丄丅丘且丑 != 0)
        {
                if((PolygonController.一下一万丄丅丘且丑 + 24) != 0)
        {
                return (bool)0 & 1;
        }
        
        }
        
        if((WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上 == null)
        {
            goto label_7;
        }
        
        if((WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上.东七与与不丅丙上上() == false)
        {
            goto label_8;
        }
        
        val_89 = (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上;
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  this.丝丟丌丛丆丅上万丑(丛丄东丙业上丈丄且:  val_89.与不丞丑七丘丁丂丛()), 专东丅一三丏三丐丟:  丁且丟不七下丆丒丟, 丂丐丕丟丕丗且东丐:  false);
        return (bool)0 & 1;
        label_7:
        val_88 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "AddW_eapon weapo_nRecord == null", args:  val_88);
        return (bool)0 & 1;
        label_8:
        val_90 = 1152921505066536960;
        if(GameConnect.万七丄丛丈丟专一丑() != true)
        {
                if((丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == false) || (丙丏与丘一丁上丙一 == false))
        {
            goto label_20;
        }
        
        }
        
        return (bool)0 & 1;
        label_20:
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                if((WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上.丒万丕七专不丏丞丌() != 5)
        {
                return (bool)0 & 1;
        }
        
        }
        
        val_91 = null;
        val_91 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_92 = null;
            val_92 = null;
            val_90 = 1152921505066536960;
            if(((WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐)) == false)
        {
                return (bool)0 & 1;
        }
        
        }
        
        if(GameConnect.世丐丄三三上丅七三() != false)
        {
                if(ConnectScene.丈丘丂丙不丛业丟三() == false)
        {
            goto label_41;
        }
        
        }
        
        label_77:
        if((GameConnect.万不丒丌丙万丗东不() != false) && (丙丏与丘一丁上丙一 != false))
        {
                if(ConnectScene.丈丘丂丙不丛业丟三() == false)
        {
                return (bool)0 & 1;
        }
        
        }
        
        List.Enumerator<T> val_19 = this.丁一丏东七丌丗丁丏.GetEnumerator();
        label_63:
        label_54:
        if((639260528 & 1) == 0)
        {
            goto label_50;
        }
        
        string val_22 = val_21.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上.三与丛丑且丐丈业丌(), b:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上.三与丛丑且丐丈业丌())) == false)
        {
            goto label_54;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
            goto label_57;
        }
        
        if((this.丒上世丗丄丂专丏三(丘丒丌下丕专且七专:  this.丁一丏东七丌丗丁丏.IndexOf(item:  val_22))) != true)
        {
                万且丒下丕丝专丟上 = 与丂丏丛丞丞丒丟丄.丗丘丝丏业丟丗丗丁() + 万且丒下丕丝专丟上;
        }
        
        string val_31 = (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上.与不丞丑七丘丁丂丛();
        if((val_31.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_31)) == true)
        {
            goto label_63;
        }
        
        goto label_84;
        label_41:
        val_94 = "Weapon";
        if("Weapon" == null)
        {
                val_94 = "Weapon";
        }
        
        val_95 = val_36;
        if((val_95 == 9) || ((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上.三与丛丑且丐丈业丌().Substring(startIndex:  Length), 丙业与丙丗丝不丈东: out  val_36)) == false))
        {
            goto label_77;
        }
        
        val_96 = null;
        val_96 = null;
        val_95 = val_36;
        if((万上丈专丐专丞丛丛.丟不下下且业丛丄丏(丞下万上三丘上与专:  ChestController.weaponForHungerGames, 丏东丁丂七丟不丒丅:  0)) == false)
        {
                return (bool)0 & 1;
        }
        
        goto label_77;
        label_50:
        label_84:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(610 == 1303)
        {
                return (bool)0 & 1;
        }
        
        var val_39 = (610 == 610) ? -1 : 0;
        goto label_79;
        label_57:
        if(this.丙下丅丒与丈丈丒与 == null)
        {
            goto label_80;
        }
        
        val_98 = (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].上丌丘丑一且丆且丏;
        if(val_98 == null)
        {
                val_98 = null;
            val_98 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.丞下丁七丙七丄与丐::丞丈且丂丕七丞丄不(三丈丟与丏丘丈丐万 丝下七丕不丒与东丙));
            .上丌丘丑一且丆且丏 = val_98;
        }
        
        if((System.Linq.Enumerable.Any<三丈丟与丏丘丈丐万>(source:  this.丙下丅丒与丈丈丒与, predicate:  null)) == false)
        {
            goto label_82;
        }
        
        label_80:
        bool val_43 = this.丒上世丗丄丂专丏三(丘丒丌下丕专且七专:  this.丁一丏东七丌丗丁丏.IndexOf(item:  val_22));
        goto label_84;
        label_82:
        val_22.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  上丂丝上丘专丟丁丈.丟七下专丈丏丕丈上());
        if((val_87 & 2147483648) != 0)
        {
                val_87 = val_87.下世下丂丂丌丑丝世();
        }
        
        val_22.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  val_87);
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_22, 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        goto label_84;
        label_79:
        .三丂丟丕丕三丈且业 = new 三丈丟与丏丘丈丐万();
        .三丐三丞丘丕不丒专 = (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上;
        (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业.三丐三丞丘丕不丒专.丟七下专丈丏丕丈上());
        (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业.三丐三丞丘丕不丒专.下世下丂丂丌丑丝世());
        if((0 & 1) == 0)
        {
            goto label_115;
        }
        
        List.Enumerator<T> val_49 = this.丁一丏东七丌丗丁丏.GetEnumerator();
        label_122:
        if((639260528 & 1) == 0)
        {
            goto label_117;
        }
        
        if(((WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三与世丈丂丕丏三上.三与丛丑且丐丈业丌())) == false)
        {
            goto label_122;
        }
        
        val_100 = this.丁一丏东七丌丗丁丏.IndexOf(item:  val_21.丐丏七丌丕丗业且上());
        val_101 = 1;
        val_102 = 0;
        goto label_124;
        label_115:
        this.丁一丏东七丌丗丁丏.Add(item:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业);
        goto label_139;
        label_117:
        val_102 = 0;
        val_101 = 0 + 1;
        mem2[0] = 816;
        val_100 = 0;
        label_124:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_101 == 1)
        {
            goto label_134;
        }
        
        if(( == 0) || ((1152921539605845808 + ((0 + 1)) << 2) == 816))
        {
            goto label_187;
        }
        
        label_186:
        label_187:
        if((val_100 & 2147483648) == 0)
        {
                if(val_100 < this.丁一丏东七丌丗丁丏.Count)
        {
                this.丁一丏东七丌丗丁丏.set_Item(index:  0, value:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业);
        }
        
        }
        
        label_139:
        System.Collections.Generic.List<System.String> val_56 = new System.Collections.Generic.List<System.String>();
        val_56.Add(item:  "Weapon67");
        val_56.Add(item:  "Weapon52");
        val_56.Add(item:  "Weapon333");
        val_56.Add(item:  "Weapon250");
        val_103 = 1152921505066536960;
        val_56.Add(item:  WeaponManager.丞丌上万丆下东丞七);
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_154;
        }
        
        val_104 = 1;
        goto label_200;
        label_154:
        if((WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业.三丐三丞丘丕不丒专.七不丕世且丟丑丈丒() != true)
        {
                if((System.String.op_Equality(a:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), b:  "Weapon3")) != true)
        {
                if((val_56.Contains(item:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌())) == false)
        {
            goto label_168;
        }
        
        }
        
        }
        
        val_103 = 1152921505066536960;
        if((this.丒七丅丟丟丐业上丄 & 2147483648) != 0)
        {
            goto label_169;
        }
        
        val_105 = val_88;
        if((this.丒七丅丟丟丐业上丄 >= this.丙下丅丒与丈丈丒与.Count) || (this.丙下丅丒与丈丈丒与.Item[this.丒七丅丟丟丐业上丄] == null))
        {
            goto label_184;
        }
        
        三丅丁丗丗丝丂万且 val_66 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_64.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌());
        if(val_66 == null)
        {
            goto label_184;
        }
        
        if((WeaponManager.丏不丆丌丅丕丐丝丟().Contains(item:  val_66.与不丞丑七丘丁丂丛())) == false)
        {
            goto label_181;
        }
        
        val_106 = null;
        val_106 = null;
        val_103 = 1152921505066536960;
        if((System.String.op_Equality(a:  val_66.与不丞丑七丘丁丂丛(), b:  与世丁丙且丑下丌不.丏世丕丄丂七丂丅且)) == false)
        {
            goto label_184;
        }
        
        label_181:
        val_107 = 0;
        goto label_185;
        label_134:
        if( != 0)
        {
            goto label_186;
        }
        
        goto label_187;
        label_169:
        val_105 = this.丙下丅丒与丈丈丒与;
        label_184:
        val_107 = 1;
        label_185:
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_73 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.丞下丁七丙七丄与丐::与丌万丙丏世万丟不(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        var val_75 = (val_107 != 0) ? 1 : 0;
        if((System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  System.Linq.Enumerable.OfType<三丈丟与丏丘丈丐万>(source:  this.丙下丅丒与丈丈丒与.SyncRoot), predicate:  null)) == null)
        {
            goto label_200;
        }
        
        三丅丁丗丗丝丂万且 val_77 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_74.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌());
        if(val_77 == null)
        {
            goto label_200;
        }
        
        if((WeaponManager.丏不丆丌丅丕丐丝丟().Contains(item:  val_77.与不丞丑七丘丁丂丛())) == false)
        {
            goto label_196;
        }
        
        val_108 = null;
        val_108 = null;
        val_103 = 1152921505066536960;
        if((System.String.op_Equality(a:  val_77.与不丞丑七丘丁丂丛(), b:  与世丁丙且丑下丌不.丏世丕丄丂七丂丅且)) == false)
        {
            goto label_200;
        }
        
        label_196:
        val_104 = 0;
        goto label_200;
        label_168:
        val_104 = 1;
        val_103 = 1152921505066536960;
        label_200:
        bool val_88 = 丁且丟不七下丆丒丟;
        val_88 = val_104 & val_88;
        if(val_88 != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_204;
        }
        
        }
        
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业, 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        this.丘丄万上丐上丞上丆(丞世不丒下上上丝丑:  this.丒七丅丟丟丐业上丄);
        label_204:
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                this.一下不丘丈丁丈与业(与丘东下丈东丛丂万:  (WeaponManager.丞下丁七丙七丄与丐)[1152921539605898144].三丂丟丕丕三丈且业);
        }
        
        bool val_86 = val_104 | GameConnect.万不丒丌丙万丗东不();
        return (bool)0 & 1;
    }
    internal static UnityEngine.GameObject 丄丟上一上丐丄与丆(string 三不三丟专丘东东丂)
    {
        string val_13;
        System.Object[] val_14;
        var val_15;
        System.Object[] val_16;
        string val_17;
        UnityEngine.Object val_18;
        val_13 = 三不三丟专丘东东丂;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_13)) == false)
        {
            goto label_3;
        }
        
        val_13 = System.Array.Empty<System.Object>();
        val_14 = val_13;
        val_15 = "GetPrefab_ByTag: weaponTag.IsNullOrEmpty()";
        goto label_6;
        label_3:
        三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_13);
        if(val_3 == null)
        {
            goto label_9;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3.三与丛丑且丐丈业丌())) == false)
        {
            goto label_12;
        }
        
        val_16 = new object[1];
        val_16[0] = val_13;
        val_17 = "GetPre_fabByTag: rec.PrefabName.IsNullOrEmpty(), weaponTag = {0}";
        goto label_26;
        label_9:
        val_16 = new object[1];
        val_16[0] = val_13;
        val_17 = "GetPre_fabByTag: rec == null, weaponTag = {0}";
        goto label_26;
        label_12:
        val_18 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "Weapons/{0}", arg0:  val_3.三与丛丑且丐丈业丌()));
        if(val_18 != 0)
        {
                return (UnityEngine.GameObject)val_18;
        }
        
        object[] val_12 = new object[1];
        val_16 = val_12;
        val_16[0] = val_13;
        val_17 = "GetPref_abByTag: prefab == null, weaponTag = {0}";
        label_26:
        val_14 = val_16;
        label_6:
        UnityEngine.Debug.LogErrorFormat(format:  val_17, args:  val_12);
        val_18 = 0;
        return (UnityEngine.GameObject)val_18;
    }
    internal bool 丒上世丗丄丂专丏三(int 丘丒丌下丕专且七专 = -1)
    {
        int val_24;
        三丅丁丗丗丝丂万且 val_25;
        int val_26;
        WeaponSounds val_27;
        var val_28;
        var val_29;
        val_24 = 丘丒丌下丕专且七专;
        val_25 = this;
        if(val_24 == 1)
        {
                val_24 = this.丁一丏东七丌丗丁丏.IndexOf(item:  this.丙下丅丒与丈丈丒与.Item[this.丒七丅丟丟丐业上丄]);
        }
        
        val_26 = this.丒七丅丟丟丐业上丄;
        if((this.丁一丏东七丌丗丁丏.Item[val_24] != this.丙下丅丒与丈丈丒与.Item[val_26]) || ((this.专丑一业业下且丅丗 == 0) || (this.专丑一业业下且丅丗.isMelee == false)))
        {
            goto label_11;
        }
        
        val_27 = this.专丑一业业下且丅丗;
        if(this.专丑一业业下且丅丗.isShotMelee == false)
        {
            goto label_17;
        }
        
        label_11:
        三丈丟与丏丘丈丐万 val_6 = this.丁一丏东七丌丗丁丏.Item[val_24];
        val_27 = val_6.三丐三丞丘丕不丒专.世与不万丆丒丂丁丒();
        if(val_6.东东丄丅丐一丙一业() >= val_27)
        {
            goto label_17;
        }
        
        val_26 = this.专丑一业业下且丅丗;
        if(val_26 == 0)
        {
            goto label_31;
        }
        
        val_26 = this.专丑一业业下且丅丗;
        if(this.专丑一业业下且丅丗.isShotMelee != true)
        {
                val_26 = this.专丑一业业下且丅丗.name;
            if((System.String.op_Equality(a:  val_26.Replace(oldValue:  "(Clone)", newValue:  ""), b:  "Weapon335")) != true)
        {
                val_26 = this.专丑一业业下且丅丗.name;
            if((System.String.op_Equality(a:  val_26.Replace(oldValue:  "(Clone)", newValue:  ""), b:  "Weapon353")) != true)
        {
                if((System.String.op_Equality(a:  this.专丑一业业下且丅丗.name.Replace(oldValue:  "(Clone)", newValue:  ""), b:  "Weapon354")) == false)
        {
            goto label_31;
        }
        
        }
        
        }
        
        }
        
        val_25 = val_6.三丐三丞丘丕不丒专;
        val_28 = val_25;
        int val_20 = val_28.丝丙丈丙丄三丅专丆();
        goto label_33;
        label_17:
        val_29 = 0;
        return (bool)val_29;
        label_31:
        val_25 = val_6.三丐三丞丘丕不丒专;
        val_28 = val_25;
        label_33:
        val_6.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_28.下世下丂丂丌丑丝世() + val_6.东东丄丅丐一丙一业());
        if(val_6.东东丄丅丐一丙一业() > val_27)
        {
                val_6.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_27);
        }
        
        val_29 = 1;
        return (bool)val_29;
    }
    internal bool 下丒丄丌丆丘不丝万(float 丗与丘不且万丟丙丑, int 丘丒丌下丕专且七专 = -1)
    {
        int val_25;
        var val_26;
        int val_27;
        WeaponSounds val_28;
        var val_29;
        var val_30;
        val_25 = 丘丒丌下丕专且七专;
        float val_25 = 丗与丘不且万丟丙丑;
        val_26 = this;
        if(val_25 == 1)
        {
                val_25 = this.丁一丏东七丌丗丁丏.IndexOf(item:  this.丙下丅丒与丈丈丒与.Item[this.丒七丅丟丟丐业上丄]);
        }
        
        val_27 = this.丒七丅丟丟丐业上丄;
        if((this.丁一丏东七丌丗丁丏.Item[val_25] != this.丙下丅丒与丈丈丒与.Item[val_27]) || ((this.专丑一业业下且丅丗 == 0) || (this.专丑一业业下且丅丗.isMelee == false)))
        {
            goto label_11;
        }
        
        val_28 = this.专丑一业业下且丅丗;
        if(this.专丑一业业下且丅丗.isShotMelee == false)
        {
            goto label_17;
        }
        
        label_11:
        三丈丟与丏丘丈丐万 val_6 = this.丁一丏东七丌丗丁丏.Item[val_25];
        val_28 = val_6.三丐三丞丘丕不丒专.世与不万丆丒丂丁丒();
        if(val_6.东东丄丅丐一丙一业() >= val_28)
        {
            goto label_17;
        }
        
        if(this.专丑一业业下且丅丗 == 0)
        {
            goto label_31;
        }
        
        if(this.专丑一业业下且丅丗.isShotMelee != true)
        {
                val_27 = "(Clone)";
            if((System.String.op_Equality(a:  this.专丑一业业下且丅丗.name.Replace(oldValue:  "(Clone)", newValue:  ""), b:  "Weapon335")) != true)
        {
                if((System.String.op_Equality(a:  this.专丑一业业下且丅丗.name.Replace(oldValue:  "(Clone)", newValue:  ""), b:  "Weapon353")) != true)
        {
                if((System.String.op_Equality(a:  this.专丑一业业下且丅丗.name.Replace(oldValue:  "(Clone)", newValue:  ""), b:  "Weapon354")) == false)
        {
            goto label_31;
        }
        
        }
        
        }
        
        }
        
        val_29 = val_6.三丐三丞丘丕不丒专;
        int val_19 = val_29.丝丙丈丙丄三丅专丆();
        goto label_33;
        label_17:
        val_30 = 0;
        return (bool)val_30;
        label_31:
        val_29 = val_6.三丐三丞丘丕不丒专;
        label_33:
        val_25 = (float)val_29.下世下丂丂丌丑丝世() * val_25;
        val_26 = val_6.东东丄丅丐一丙一业();
        val_6.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  (UnityEngine.Mathf.CeilToInt(f:  val_25)) + val_26);
        if(val_6.东东丄丅丐一丙一业() > val_28)
        {
                val_6.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_28);
        }
        
        val_30 = 1;
        return (bool)val_30;
    }
    internal bool 丕丗丐丁丌丏丙丗不()
    {
        Player_move_c val_25;
        var val_26;
        var val_27;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_1 = new System.Collections.Generic.List<三丈丟与丏丘丈丐万>(collection:  this.丙下丅丒与丈丈丒与);
        val_25 = this.myPlayerMoveC;
        if(this.myPlayerMoveC.丅下万丏丘东丄丌万 == false)
        {
            goto label_2;
        }
        
        val_25 = 0;
        goto label_4;
        label_10:
        三丈丟与丏丘丈丐万 val_26 = this.myPlayerMoveC.charWeapon[0];
        if((val_26 != null) && (this.myPlayerMoveC.charWeapon[0x0][0].三丐三丞丘丕不丒专 != null))
        {
                val_1.Add(item:  val_26);
        }
        
        val_25 = 1;
        label_4:
        if(val_25 < this.myPlayerMoveC.charWeapon.Length)
        {
            goto label_10;
        }
        
        label_2:
        val_26 = 0;
        val_27 = 0;
        goto label_30;
        label_38:
        val_25 = val_1.Item[0];
        if(val_2.三丐三丞丘丕不丒专.丐专丒丟丈丛丈丂业() != false)
        {
                if(val_2.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_19;
        }
        
        }
        
        int val_5 = val_2.三丐三丞丘丕不丒专.世与不万丆丒丂丁丒();
        if(val_25.东东丄丅丐一丙一业() >= val_5)
        {
            goto label_19;
        }
        
        if((val_2.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() != true) && ((System.String.op_Equality(a:  val_2.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), b:  "Weapon335")) != true))
        {
                if((System.String.op_Equality(a:  val_2.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), b:  "Weapon353")) != true)
        {
                if((System.String.op_Equality(a:  val_2.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), b:  "Weapon354")) == false)
        {
            goto label_27;
        }
        
        }
        
        }
        
        val_25.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  val_2.三丐三丞丘丕不丒专.丝丙丈丙丄三丅专丆() + val_25.下世万丆丛专丒丑丙());
        if(val_25.下世万丆丛专丒丑丙() > val_5)
        {
                val_25.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  val_5);
        }
        
        label_36:
        val_27 = 1;
        label_19:
        val_26 = 1;
        goto label_30;
        label_27:
        if(val_2.三丐三丞丘丕不丒专.七与上丌万下丟丅专() > 0)
        {
                int val_20 = val_2.三丐三丞丘丕不丒专.七与上丌万下丟丅专();
        }
        
        val_25.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_2.三丐三丞丘丕不丒专.下世下丂丂丌丑丝世() + val_25.东东丄丅丐一丙一业());
        if(val_25.东东丄丅丐一丙一业() <= val_5)
        {
            goto label_36;
        }
        
        val_25.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_5);
        goto label_36;
        label_30:
        if(val_26 < val_1.Count)
        {
            goto label_38;
        }
        
        return (bool)val_27 & 1;
    }
    internal bool 丅三丕丐丏丙东丂丆()
    {
        Player_move_c val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_14;
        var val_15;
        val_11 = this;
        val_12 = 0;
        val_13 = 0;
        goto label_1;
        label_11:
        三丈丟与丏丘丈丐万 val_1 = this.丙下丅丒与丈丈丒与.Item[0];
        if(val_1.三丐三丞丘丕不丒专.丐专丒丟丈丛丈丂业() != false)
        {
                if(val_1.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_9;
        }
        
        }
        
        int val_4 = val_1.三丐三丞丘丕不丒专.世与不万丆丒丂丁丒();
        if(val_1.东东丄丅丐一丙一业() < val_4)
        {
                val_1.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_4);
            val_13 = 1;
        }
        
        label_9:
        val_12 = 1;
        label_1:
        val_14 = this.丙下丅丒与丈丈丒与;
        if(val_12 < val_14.Count)
        {
            goto label_11;
        }
        
        if(this.myPlayerMoveC.丅下万丏丘东丄丌万 == false)
        {
                return (bool)val_13 & 1;
        }
        
        val_11 = this.myPlayerMoveC;
        val_14 = this.myPlayerMoveC.charWeapon;
        val_15 = 0;
        goto label_15;
        label_25:
        val_11 = val_14[0];
        if(val_11 != null)
        {
                if(this.myPlayerMoveC.charWeapon[0x0][0].三丐三丞丘丕不丒专.丐专丒丟丈丛丈丂业() != false)
        {
                if(this.myPlayerMoveC.charWeapon[0x0][0].三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_23;
        }
        
        }
        
            int val_9 = this.myPlayerMoveC.charWeapon[0x0][0].三丐三丞丘丕不丒专.世与不万丆丒丂丁丒();
            if(val_11.东东丄丅丐一丙一业() < val_9)
        {
                val_11.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_9);
            val_13 = 1;
        }
        
        }
        
        label_23:
        val_15 = 1;
        label_15:
        if(val_15 < this.myPlayerMoveC.charWeapon.Length)
        {
            goto label_25;
        }
        
        return (bool)val_13 & 1;
    }
    internal void 丏丕东万世三丅东丛()
    {
        List.Enumerator<T> val_1 = this.丁一丏东七丌丗丁丏.GetEnumerator();
        label_6:
        if((641249560 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_2.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  下世下丂丂丌丑丝世());
        val_2.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  世与不万丆丒丂丁丒());
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal bool 七一丆丙丗丛业丌丌()
    {
        return (bool)this.丙丐丄丛东七丑万丙;
    }
    private void 丅七下下丆丆丕上七()
    {
        string val_12;
        var val_13;
        var val_14;
        System.Func<System.String, System.Boolean> val_16;
        val_12 = 1152921505266909184;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false)
        {
                if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "sniperArenaSetMigratedFromSniperKey_march_2018", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0)
        {
                return;
        }
        
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "sniperArenaSetMigratedFromSniperKey_march_2018", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            val_13 = "";
            char[] val_7 = new char[1];
            val_7[0] = '#';
            val_14 = null;
            val_14 = null;
            val_16 = WeaponManager.<>c.<>9__487_0;
            if(val_16 == null)
        {
                val_16 = null;
            val_16 = new System.Func<System.String, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::业不丈丕丁不丛不业(string 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__487_0 = val_16;
        }
        
            val_12 = System.Linq.Enumerable.FirstOrDefault<System.String>(source:  WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  "WeaponManager.SniperModeWSSN").Replace(oldValue:  "Weapon1", newValue:  "").Replace(oldValue:  "Weapon9", newValue:  "").Split(separator:  val_7), predicate:  null);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_12)) == true)
        {
                return;
        }
        
            WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  "WeaponManager.SniperEventWSSN", 专丟丌丄东且上业一:  val_12, 下业丕七东丌丝下且:  4, 下与丙业丁世三丞丒:  true);
            return;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "sniperArenaSetMigratedFromSniperKey_march_2018", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void WeaponManager::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void WeaponManager::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void Awake()
    {
        bool val_2 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        0.丅七下下丆丆丕上七();
        0.丙东丞下与丐丗丆下();
        FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void WeaponManager::一七丂丌丝丒一丕丒()));
        Rilisoft.丕七东丗丁丐丂三下.下丝业丑丞丙业业业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void WeaponManager::丑七专业丞丙丛且丄()));
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        bool val_2 = 丁与丟万丄丒丗专丌;
        if(val_2 == false)
        {
                return;
        }
        
        val_2 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三();
        val_2.丑丘三且丞丕丟丁下();
    }
    private System.Collections.IEnumerator 丏专丂丁丝丄丑丏丐()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponManager.丗丅丒专丈丗万丅业(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator 丗且一丌丁不丅丅一()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponManager.丛丗丙丞上丒下丘丐(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator Start()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponManager.丅丙丑丏世万丘丕且(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 下丑丞丈业丘万世丆(string 丒东业不丐丑丕丄丆, Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 世丙与专七丟丒丆世, bool 丁且丟不七下丆丒丟 = True, bool 丝丗不东丙不三丄专 = False, 丕丑丙丑丙东丌丘丕 丄下丁东丘业丆丝上)
    {
        三丅丁丗丗丝丂万且 val_10;
        丕丑丙丑丙东丌丘丕 val_11;
        System.Object[] val_12;
        var val_13;
        val_11 = 丄下丁东丘业丆丝上;
        val_12 = this;
        if(丒东业不丐丑丕丄丆 == null)
        {
                return;
        }
        
        val_10 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        if(val_10 != null)
        {
                WeaponManager.丂丗丂丞且丄业与丄(丝丂丁丌丆三丆专且:  val_10, 世丙与专七丟丒丆世:  世丙与专七丟丒丆世, 丝丗不东丙不三丄专:  丝丗不东丙不三丄专, 一三世且与专丕丆丂:  false, 丄下丁东丘业丆丝上:  val_11, 世丁丙世丄一万丆三:  "");
            val_11 = val_10.业东丅东丌上丗丑不();
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_11)) != null)
        {
                val_13 = null;
            val_13 = null;
            if(WeaponManager.丗业丘丘丏七丟丆一 != null)
        {
                WeaponManager.丗业丘丘丏七丟丆一.Invoke(obj:  val_10);
        }
        
        }
        
            bool val_8 = this.三下丗万丆专丄且东(三与世丈丂丕丏三上:  val_10, 万且丒下丕丝专丟上: out  0, 丁且丟不七下丆丒丟:  丁且丟不七下丆丒丟, 丙丏与丘一丁上丙一:  true, 丟丒丙丁丑丐世三丈:  0, 上丂丝上丘专丟丁丈:  0);
            return;
        }
        
        object[] val_9 = new object[1];
        val_12 = val_9;
        val_12[0] = 丒东业不丐丑丕丄丆;
        UnityEngine.Debug.LogErrorFormat(format:  "AddW_eaponToInv rec == null , tag =  {0}", args:  val_9);
    }
    private void 三下丗万丆专丄且东(Prime31.GooglePurchase 七丏丄丅丌业与且丙)
    {
    
    }
    private void OnDestroy()
    {
        Rilisoft.丕七东丗丁丐丂三下.世一业一一丈世丌丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void WeaponManager::丑七专业丞丙丛且丄()));
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙(), method:  System.Void Progress.下丁下丂七丆丙七一::东丗且丂与丐七与丒()));
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void WeaponManager::业丞丕丙丙且丁万丘()));
        FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void WeaponManager::一七丂丌丝丒一丕丒()));
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
                return;
        }
        
        Prime31.GoogleIABManager.remove_purchaseSucceededEvent(value:  new System.Action<Prime31.GooglePurchase>(object:  this, method:  System.Void WeaponManager::三下丗万丆专丄且东(Prime31.GooglePurchase 七丏丄丅丌业与且丙)));
    }
    internal void 丟且东丄丙业丂丏丗(int 丞世不丒下上上丝丑)
    {
        var val_36;
        三丈丟与丏丘丈丐万 val_37;
        int val_38;
        var val_39;
        var val_40;
        int val_41;
        int val_42;
        Player_move_c val_43;
        val_36 = null;
        val_36 = null;
        val_37 = this.myPlayerMoveC.charWeaponCurrent;
        if(val_37 != null)
        {
                val_38 = val_37.东东丄丅丐一丙一业();
        }
        else
        {
                val_38 = 0.东东丄丅丐一丙一业();
        }
        
        val_39 = val_2.三丐三丞丘丕不丒专.下世下丂丂丌丑丝世();
        val_40 = 1152921505066536960;
        val_41 = 下世万丆丛专丒丑丙();
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_14;
        }
        
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        label_18:
        var val_7 = (null == null) ? GameController.onlineMode : 0;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        label_21:
        var val_8 = (null == null) ? GameController.onlineMode : 0;
        val_38 = val_38;
        val_40 = val_40;
        onlineMode == null ? GameController.onlineMode : 0 + 536 + 88.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  onlineMode == null ? GameController.onlineMode : 0 + 536 + 88 + 48.下世下丂丂丌丑丝世());
        val_39 = val_39;
        val_41 = val_41;
        label_14:
        if(this.myPlayerMoveC.丄丝丝下丟丘丄丒丈() != false)
        {
                三丈丟与丏丘丈丐万 val_12 = this.myPlayerMoveC.丆丌丏丝一丕丕业且();
            this.myPlayerMoveC.丆丌丏丝一丕丕业且().业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  val_12.三丐三丞丘丕不丒专.下世下丂丂丌丑丝世());
            return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(七丝丈东丈丕丐与丗() == true)
        {
            goto label_56;
        }
        
        }
        
        val_41 = val_39 - val_41;
        if(((GameConnect.与丈丘丈上丌丝丝丛() == true) || (GameConnect.丟丆丏上丌一丝丟业() == true)) || (东东丄丅丐一丙一业() >= val_41))
        {
            goto label_43;
        }
        
        业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  this.丙下丅丒与丈丈丒与.Item[丞世不丒下上上丝丑].东东丄丅丐一丙一业() + 下世万丆丛专丒丑丙());
        val_42 = 0;
        goto label_46;
        label_43:
        业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  下世万丆丛专丒丑丙() + val_41);
        if((((GameConnect.与丈丘丈上丌丝丝丛() == true) || (GameConnect.丟丆丏上丌一丝丟业() == true)) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)) || (this.myPlayerMoveC.丄丝丝下丟丘丄丒丈() == true))
        {
            goto label_56;
        }
        
        val_42 = 东东丄丅丐一丙一业() - val_41;
        label_46:
        上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_42);
        label_56:
        if(val_2.万丅丈东丙丑丆丑丅 != null)
        {
                丏丛丝丄丟丒不一不();
        }
        
        val_43 = this.myPlayerMoveC;
        if(val_43 != null)
        {
                var val_31 = (this.myPlayerMoveC.丅下万丏丘东丄丌万 == false) ? 1 : 0;
        }
        else
        {
                val_43 = this.myPlayerMoveC;
        }
        
        WeaponSounds val_33 = val_43.丙不丅丕三丂业东丕();
        if(((this.myPlayerMoveC.丅下万丏丘东丄丌万 == false) ? 1 : 0) == 0)
        {
            goto label_62;
        }
        
        if(val_33.isUnlimitedAmmo == false)
        {
                return;
        }
        
        if(this.myPlayerMoveC.丛丌丐丞丅丟专七丂() == 丞世不丒下上上丝丑)
        {
            goto label_65;
        }
        
        return;
        label_62:
        if(val_33.isUnlimitedAmmo == false)
        {
                return;
        }
        
        label_65:
        上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  val_38);
    }
    internal void ReloadAmmo()
    {
        this.丟且东丄丙业丂丏丗(丞世不丒下上上丝丑:  this.丒七丅丟丟丐业上丄);
        if(this.myPlayerMoveC == 0)
        {
                return;
        }
        
        this.myPlayerMoveC.丆丂丕专丒丌三一七 = false;
        WeaponManager val_2 = this.myPlayerMoveC.丛丒丒与丞丝丄丝丒();
        if(val_2.专丑一业业下且丅丗.丌上丗丕不七世丅丁().下世下丂丂丌丑丝世() >= 2)
        {
                FirstPersonControlSharp.三与丏上下上下丘丘();
        }
        
        if((System.String.IsNullOrEmpty(value:  this.myPlayerMoveC.丙专丙丈与上下丝东())) != true)
        {
                if((this.myPlayerMoveC.丙专丙丈与上下丝东().Equals(value:  this.专丑一业业下且丅丗.Tag)) != false)
        {
                this.myPlayerMoveC.丗丘不丁七丅七七与(且丆万丕丐丛三丙丟:  false, 丝三丛且丘不丌丙下:  "");
        }
        
        }
        
        this.myPlayerMoveC.万丛世且下且丄专且(丈专丗且下丁丂丏丑:  false);
    }
    internal void 丆丁世一且丒丒世世()
    {
        var val_17;
        Player_move_c val_18;
        val_17 = this;
        if(this.专丑一业业下且丅丗.isShotMelee == true)
        {
                return;
        }
        
        UnityEngine.Animation val_2 = this.专丑一业业下且丅丗.丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>();
        val_2.Stop(name:  "Empty");
        if(this.专丑一业业下且丅丗.isDoubleShot != true)
        {
                val_2.CrossFade(animation:  "Shoot");
        }
        
        if(this.专丑一业业下且丅丗.一与上丙一丙丅丐业() != 0)
        {
                this.专丑一业业下且丅丗.一与上丙一丙丅丐业().上万丟与丏东一丅丘();
        }
        
        if(val_2 != null)
        {
                val_2.CrossFade(animation:  "Reload");
        }
        else
        {
                val_2.CrossFade(animation:  "Reload");
        }
        
        val_18 = this.myPlayerMoveC;
        val_2.Item["Reload"].speed = this.myPlayerMoveC.不不丂丗丁丛丟丛丑;
        if(this.专丑一业业下且丅丗.丒丒丁丕东丆丙丕上() == 0)
        {
                return;
        }
        
        WeaponReloadEffect val_9 = this.专丑一业业下且丅丗.丒丒丁丕东丆丙丕上();
        val_17 = ???;
        val_18 = ???;
        goto typeof(WeaponReloadEffect).__il2cppRuntimeField_168;
    }
    internal static void 专丗丏三丘上一丒丈(string 丒东业不丐丑丕丄丆)
    {
        if(丒东业不丐丑丕丄丆 != null)
        {
                三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
            if(val_1 == null)
        {
                return;
        }
        
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  137);
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丈一丂丏下东丑丂丘().ContainsKey(key:  val_1.业东丅东丌上丗丑不())) != false)
        {
                bool val_9 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().且与丛丌丂业丑七东(丞世不丒下上上丝丑:  val_1.业东丅东丌上丗丑不(), 丐专世与丆丌丒丆丁:  "");
        }
        
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().ContainsKey(key:  val_1.业东丅东丌上丗丑不())) != false)
        {
                if((Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丟丁三不世丕丗丘东(丞世不丒下上上丝丑:  val_1.业东丅东丌上丗丑不(), 丐专世与丆丌丒丆丁:  "")) != false)
        {
                WeaponManager.业丑专丞万丑丄丛下();
        }
        
        }
        
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "RemoveGun_FromAllTry_GunRelated: tg == null");
    }
    internal static void 业丞丕丙丙且丁万丘()
    {
        if(Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟不丆东丁丈丅七一() != false)
        {
                return;
        }
        
        WeaponManager.丐世东丐丁丟三业东(丘专丑丕且且丄专丁:  true);
    }
    internal static void 丐世东丐丁丟三业东(bool 丘专丑丕且且丄专丁)
    {
        object val_13;
        var val_18;
        var val_40;
        var val_41;
        object val_42;
        string val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        string val_24 = 0;
        val_41 = 1152921505369411584;
        char[] val_3 = new char[1];
        val_3[0] = '#';
        System.Collections.Generic.List<System.String> val_5 = new System.Collections.Generic.List<System.String>();
        val_42 = 0;
        goto label_7;
        label_11:
        null.Add(item:  Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丟上七七一且丞丈与().Split(separator:  val_3)[0]);
        val_42 = 1;
        label_7:
        if(val_42 < val_4.Length)
        {
            goto label_11;
        }
        
        val_43 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏();
        if(val_43.三丒东不世丈丒万丈() == null)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_10 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().三丒东不世丈丒万丈().GetEnumerator();
        val_44 = 0;
        val_45 = 0;
        var val_39 = 0;
        label_58:
        if((644309776 & 1) == 0)
        {
            goto label_20;
        }
        
        ConfiguredValueTaskAwaiter val_14 = val_13.GetAwaiter();
        Dictionary.Enumerator<TKey, TValue> val_15 = val_13.GetEnumerator();
        label_40:
        if((644309712 & 1) == 0)
        {
            goto label_23;
        }
        
        ConfiguredValueTaskAwaiter val_19 = val_18.GetAwaiter();
        if(644309712 < 1)
        {
            goto label_40;
        }
        
        val_46 = null;
        val_46 = null;
        if((Progress.丅丕东丑下世丏丑与.丅丙专丄丟业丂丘七.ContainsKey(key:  val_19._value._obj.丙东专丂世丈丏丁丂())) == false)
        {
            goto label_40;
        }
        
        val_47 = null;
        val_47 = null;
        val_48 = null;
        val_48 = null;
        if(((下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.TryGetValue(key:  Progress.丅丕东丑下世丏丑与.丅丙专丄丟业丂丘七.Item[val_19._value._obj.丙东专丂世丈丏丁丂()], value: out  val_24)) == false) || ((null.Contains(item:  val_24)) == true))
        {
            goto label_40;
        }
        
        null.Add(item:  val_24);
        goto label_40;
        label_23:
        val_39 = val_39 + 1;
        mem2[0] = 251;
        val_49 = val_45;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_39 == 1) || ((1152921539610894912 + ((0 + 1)) << 2) != 251))
        {
            goto label_55;
        }
        
        var val_40 = 0;
        val_40 = val_40 ^ (val_39 >> 31);
        val_39 = val_39 + val_40;
        goto label_58;
        label_55:
        if( == 0)
        {
            goto label_58;
        }
        
        goto label_58;
        label_20:
        val_39 = val_39 + 1;
        mem2[0] = 279;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_39 == 1)
        {
            goto label_73;
        }
        
        if( == 0)
        {
            goto label_77;
        }
        
        if((1152921539610894912 + ((0 + 1)) << 2) != 279)
        {
            goto label_75;
        }
        
        goto label_77;
        label_73:
        if( == 0)
        {
            goto label_77;
        }
        
        label_75:
        label_77:
        val_40 = "Weapon2";
        val_43 = "Weapon2";
        if((null.Contains(item:  val_43)) != false)
        {
                val_43 = null.IndexOf(item:  "Weapon2");
            null.set_Item(index:  val_43, value:  "Weapon66");
        }
        
        string val_30 = System.String.Join(separator:  "#", value:  null.ToArray());
        if(丘专丑丕且且丄专丁 != false)
        {
                val_42 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_42.丄丘丘丑一丛上丗丌(下下丏一丙不丘丌丞:  val_30);
            return;
        }
        
        val_42 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏();
        if((System.String.op_Inequality(a:  val_30, b:  val_42.丟上七七一且丞丈与())) == false)
        {
                return;
        }
        
        Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().万七丗专万丌丁丆丗(下下丏一丙不丘丌丞:  val_30);
        val_42 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏();
        if(val_42 != null)
        {
                return;
        }
    
    }
    private void 东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        var val_2 = null;
        if(WeaponManager.丄专丞东专下丑不丝() == false)
        {
                return;
        }
        
        this.丒丆丟丒丞下不丗与();
    }
    internal static void 丒不丄丐丏丑世丟东()
    {
        var val_16;
        WeaponManager val_17;
        var val_18;
        var val_19;
        var val_20;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_22;
        System.Collections.Generic.IEnumerable<TSource> val_23;
        var val_24;
        var val_25;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_27;
        var val_29;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_31;
        var val_32;
        var val_33;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_35;
        var val_36;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_38;
        var val_39;
        var val_40;
        val_16 = null;
        val_16 = null;
        val_17 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_17 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        val_17 = WeaponManager.丟丗丄业丘丗业丗七;
        if(null == 0)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 136];
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.丙下丅丒与丈丈丒与;
        val_20 = null;
        val_20 = null;
        val_22 = WeaponManager.<>c.<>9__507_0;
        if(val_22 == null)
        {
                val_22 = null;
            val_22 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::万丂丝丏万下七万丈(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__507_0 = val_22;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  val_17, predicate:  null)) == null)
        {
                val_24 = null;
            val_24 = null;
            val_23 = System.Linq.Enumerable.OfType<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.丁一丏东七丌丗丁丏);
            val_25 = null;
            val_25 = null;
            val_27 = WeaponManager.<>c.<>9__507_1;
            if(val_27 == null)
        {
                val_27 = null;
            val_27 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丅业丝三三丞丐丑万(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__507_1 = val_27;
        }
        
            WeaponManager.丟丗丄业丘丗业丗七.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  System.Linq.Enumerable.First<三丈丟与丏丘丈丐万>(source:  val_23, predicate:  null), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        }
        
        val_29 = null;
        val_29 = null;
        val_31 = WeaponManager.<>c.<>9__507_2;
        if(val_31 == null)
        {
                val_31 = null;
            val_31 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丐丛丌丌丝世丟丒世(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__507_2 = val_31;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  val_17, predicate:  null)) == null)
        {
                val_32 = null;
            val_32 = null;
            val_23 = System.Linq.Enumerable.OfType<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.丁一丏东七丌丗丁丏);
            val_33 = null;
            val_33 = null;
            val_35 = WeaponManager.<>c.<>9__507_3;
            if(val_35 == null)
        {
                val_35 = null;
            val_35 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丆丅丟专七与且丅三(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__507_3 = val_35;
        }
        
            WeaponManager.丟丗丄业丘丗业丗七.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  System.Linq.Enumerable.First<三丈丟与丏丘丈丐万>(source:  val_23, predicate:  null), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        }
        
        val_36 = null;
        val_36 = null;
        val_38 = WeaponManager.<>c.<>9__507_4;
        if(val_38 == null)
        {
                val_38 = null;
            val_38 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::东丄丑与丙万三丘丌(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__507_4 = val_38;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  val_17, predicate:  null)) != null)
        {
                return;
        }
        
        val_39 = null;
        val_39 = null;
        val_17 = WeaponManager.丟丗丄业丘丗业丗七;
        val_40 = null;
        val_40 = null;
        val_23 = WeaponManager.<>c.<>9__507_5;
        if(val_23 == null)
        {
                val_23 = null;
            val_23 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丝丛丄三万上丒不丘(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__507_5 = val_23;
        }
        
        val_17.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  System.Linq.Enumerable.First<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.丁一丏东七丌丗丁丏, predicate:  null), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
    }
    internal static void 丗丛丕一下且不东丛()
    {
        var val_6;
        WeaponManager val_7;
        var val_8;
        var val_9;
        var val_10;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_12;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_13;
        var val_14;
        var val_15;
        val_6 = null;
        val_6 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_7 == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(null == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 136];
        val_7 = WeaponManager.丟丗丄业丘丗业丗七.丙下丅丒与丈丈丒与;
        val_10 = null;
        val_10 = null;
        val_12 = WeaponManager.<>c.<>9__508_0;
        if(val_12 == null)
        {
                val_12 = null;
            val_12 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::丕丏丒丕且丏丒上丆(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__508_0 = val_12;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  val_7, predicate:  null)) != null)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        val_15 = null;
        val_15 = null;
        val_13 = WeaponManager.<>c.<>9__508_1;
        if(val_13 == null)
        {
                val_13 = null;
            val_13 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::业丅丏一三丞七丏世(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            WeaponManager.<>c.<>9__508_1 = val_13;
        }
        
        val_7.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  System.Linq.Enumerable.First<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.丁一丏东七丌丗丁丏, predicate:  null), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
    }
    internal static CategoryNames[] 万三不丄丈丙与丁不()
    {
        CategoryNames[] val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(WeaponManager.七丘一丛七丏丏世下 == null)
        {
                val_4 = null;
            val_4 = null;
            var val_2 = 0;
            WeaponManager.七丘一丛七丏丏世下 = new CategoryNames[6];
            do
        {
            val_4 = null;
            val_2 = WeaponManager.七丘一丛七丏丏世下;
            mem2[0] = val_2;
            val_3 = null;
            val_2 = val_2 + 1;
        }
        while(val_2 != 6);
        
        }
        
        val_3 = null;
        return (CategoryNames[])WeaponManager.七丘一丛七丏丏世下;
    }
    internal static int 世下丞丄世上丒不丌()
    {
        null = null;
        return (int)WeaponManager.三丁丆丑不且丞丅丆;
    }
    internal static System.Collections.Generic.IEnumerable<三丅丁丗丗丝丂万且> 三丏丏丄专丅世丞不(System.Nullable<ItemRarity> 丈下丑丆上丏丗丈专, System.Collections.Generic.IEnumerable<CategoryNames> 丈专且丄丈丞丙丘三, System.Collections.Generic.IEnumerable<string> 且上下丌一下且丑丟, bool 丒万丂七不丏丙万丝, bool 丄七丛丛丛下三业丛)
    {
        var val_17;
        var val_18;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_20;
        System.Collections.Generic.IEnumerable<TSource> val_21;
        var val_22;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_24;
        var val_25;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_27;
        System.Collections.Generic.IEnumerable<TSource> val_28;
        var val_29;
        System.Func<三丅丁丗丗丝丂万且, System.Int32> val_31;
        WeaponManager.丘丄万东东七丐不业 val_1 = new WeaponManager.丘丄万东东七丐不业();
        if(val_1 != null)
        {
                val_17 = val_1;
            .丈专且丄丈丞丙丘三 = 丈专且丄丈丞丙丘三;
            mem[1152921539612017940] = 丈下丑丆上丏丗丈专.HasValue;
        }
        else
        {
                .丈下丑丆上丏丗丈专 = 丈下丑丆上丏丗丈专;
            val_17 = 32;
            mem[32] = 丈专且丄丈丞丙丘三;
        }
        
        .且上下丌一下且丑丟 = 且上下丌一下且丑丟;
        .丙丂丏丛丌丏下丝不 = ExperienceController.丞丞丘业东丙丏七丌();
        val_18 = null;
        val_18 = null;
        val_20 = WeaponManager.<>c.<>9__514_1;
        if(val_20 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_6 = null;
            val_20 = val_6;
            val_6 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::三丗丐不业丘丞丞万(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
            WeaponManager.<>c.<>9__514_1 = val_20;
        }
        
        val_21 = System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丐丙丛丒世三业丏丙(), predicate:  new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.丘丄万东东七丐不业::丕丕一业三丏丄三丅(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业))), predicate:  val_6);
        if(丒万丂七不丏丙万丝 != true)
        {
                val_22 = null;
            val_22 = null;
            val_24 = WeaponManager.<>c.<>9__514_2;
            if(val_24 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_8 = null;
            val_24 = val_8;
            val_8 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::且丅万三丄业不丗丐(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
            WeaponManager.<>c.<>9__514_2 = val_24;
        }
        
            val_21 = System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  val_21, predicate:  val_8);
        }
        
        val_25 = null;
        val_25 = null;
        val_27 = WeaponManager.<>c.<>9__514_3;
        if(val_27 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_10 = null;
            val_27 = val_10;
            val_10 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::与丟东丈不丙世丂与(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
            WeaponManager.<>c.<>9__514_3 = val_27;
        }
        
        val_28 = System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  val_21, predicate:  val_10);
        if(val_17 != 0)
        {
                val_28 = System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  val_28, predicate:  new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.丘丄万东东七丐不业::丂丌东丌丒丘丁丈丄(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)));
        }
        
        if((WeaponManager.丘丄万东东七丐不业)[1152921539612017920].且上下丌一下且丑丟 != null)
        {
                val_28 = System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  val_28, predicate:  new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  val_1, method:  System.Boolean WeaponManager.丘丄万东东七丐不业::丆丂丘丏丄丛丁不专(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)));
        }
        
        if(丄七丛丛丛下三业丛 != false)
        {
                return 丞东丑专丛丆丄丝世.丆丝丙丁不丅丄七丂<三丅丁丗丗丝丂万且>(丅东丗丒丄东丛业丄:  val_28, 丂丆且一丛丙丑七丒:  0);
        }
        
        val_29 = null;
        val_29 = null;
        val_31 = WeaponManager.<>c.<>9__514_6;
        if(val_31 != null)
        {
                return System.Linq.Enumerable.OrderByDescending<三丅丁丗丗丝丂万且, System.Int32>(source:  val_28, keySelector:  System.Func<三丅丁丗丗丝丂万且, System.Int32> val_16 = null);
        }
        
        val_31 = val_16;
        val_16 = new System.Func<三丅丁丗丗丝丂万且, System.Int32>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponManager.<>c::且上七丞丘丞七丈不(三丅丁丗丗丝丂万且 业七丐世专丝丂丟丈));
        WeaponManager.<>c.<>9__514_6 = val_31;
        return System.Linq.Enumerable.OrderByDescending<三丅丁丗丗丝丂万且, System.Int32>(source:  val_28, keySelector:  val_16);
    }
    internal static string[] 世东一丑丆丑与丆一()
    {
        var val_7;
        var val_8;
        string val_9;
        var val_10;
        string[] val_1 = new string[6];
        val_7 = null;
        val_7 = null;
        val_8 = 0;
        goto label_3;
        label_18:
        if(0 >= Count)
        {
            goto label_10;
        }
        
        三丈丟与丏丘丈丐万 val_3 = Item[0];
        if(val_8 != (val_3.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() - 1))
        {
            goto label_10;
        }
        
        val_9 = val_3.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
        val_10 = 0;
        if(val_8 < val_1.Length)
        {
            goto label_15;
        }
        
        goto label_15;
        label_10:
        val_10 = 0;
        val_9 = 0;
        label_15:
        val_8 = 1;
        val_1[val_10] = val_9;
        label_3:
        if(val_8 < val_1.Length)
        {
            goto label_18;
        }
        
        return (System.String[])val_1;
    }
    internal static void 丌丐不不下丏丝丏丒(Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 不丐丅丁丂七丐丘丛)
    {
        PGCompany.三东丏不丗世丅丌丄 val_13;
        var val_15;
        七专丁丕世丏丁丘丛 val_13 = 不丐丅丁丂七丐丘丛;
        PGCompany.三东丏不丗世丅丌丄 val_1 = null;
        val_13 = val_1;
        val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  "m16");
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_1, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != true)
        {
                PGCompany.丗丟丄丈东丝丕丄世 val_5 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_1, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        val_15 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  "m16");
        if(val_15.丈一下下丞世三丑丄() > 1)
        {
                return;
        }
        
        val_13 = val_13 << 32;
        val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        val_13 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世(丈丄不七三万丄丁不:  val_1, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        bool val_12 = val_15.丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  val_13, 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = val_13});
    }
    internal static string 且丑一丏丄且丁丑丒(string 丕丒不丟丏丈东丒与)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if((WeaponManager.东丆丅丘丆丂不丑丆.Contains(item:  丕丒不丟丏丈东丒与)) != false)
        {
                val_6 = "vehicle_helicopter";
            return (string)((WeaponManager.七下下丆丈丌丅丞上.Contains(item:  丕丒不丟丏丈东丒与)) != true) ? "royale_snowmobile" : "vehicle";
        }
        
        val_7 = null;
        val_7 = null;
        if((WeaponManager.丝丕东丈丞丞下与丆.Contains(item:  丕丒不丟丏丈东丒与)) != false)
        {
                val_6 = "royale_atv";
            return (string)((WeaponManager.七下下丆丈丌丅丞上.Contains(item:  丕丒不丟丏丈东丒与)) != true) ? "royale_snowmobile" : "vehicle";
        }
        
        val_8 = null;
        val_8 = null;
        return (string)((WeaponManager.七下下丆丈丌丅丞上.Contains(item:  丕丒不丟丏丈东丒与)) != true) ? "royale_snowmobile" : "vehicle";
    }
    internal static void 一丞丞丞丕丄丑万下(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丅且丘丌丟专丞丕七, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丅且丘丌丟专丞丕七 != 1152921505286243000);
    
    }
    internal static void 丏丝万专丕下且丗丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丅且丘丌丟专丞丕七, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丅且丘丌丟专丞丕七 != 1152921505286243000);
    
    }
    internal static void 丝丑世且丄丆丏上丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丛丏三七丁一丞丛与, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丛丏三七丁一丞丛与 != 1152921505286243008);
    
    }
    internal static void 且丛丏丅专丏丒专世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丛丏三七丁一丞丛与, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丛丏三七丁一丞丛与 != 1152921505286243008);
    
    }
    internal static void 丐万丑丙七丒且丂上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.丈下丑丅丞万七丈丕, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丈下丑丅丞万七丈丕 != 1152921505286243016);
    
    }
    internal static void 七丕丕丒丗丄丒丌上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.丈下丑丅丞万七丈丕, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.丈下丑丅丞万七丈丕 != 1152921505286243016);
    
    }
    internal static float 丗与丒世丏一丈下丅()
    {
        PGCompany.丌丗丄不万丑丌丌丅 val_1 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.专丏丏业丌丕丄丈丕();
        }
        
        return val_1.专丏丏业丌丕丄丈丕();
    }
    internal static System.Collections.Generic.List<float> 丟丂丏丗专丌丌七世()
    {
        PGCompany.丌丗丄不万丑丌丌丅 val_1 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丙上与丐丁丈万专丆();
        }
        
        return val_1.丙上与丐丁丈万专丆();
    }
    internal float 丌丄丄丙与丟丐丕丑(int 丈丁丄丘丛世七丙丝)
    {
        if(Progress.七七世万专丕丁上业.一万万与七万丄丗丟() == null)
        {
                return 1f;
        }
        
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丆丗丐不丘丒专丌万().ContainsKey(key:  丈丁丄丘丛世七丙丝)) != false)
        {
                if(WeaponManager.丟丂丏丗专丌丌七世().Count <= Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丆丗丐不丘丒专丌万().Item[丈丁丄丘丛世七丙丝])
        {
                return 1f;
        }
        
            System.Collections.Generic.List<System.Single> val_10 = WeaponManager.丟丂丏丗专丌丌七世();
            if(val_10 != null)
        {
                return val_10.Item[Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丆丗丐不丘丒专丌万().Item[丈丁丄丘丛世七丙丝]];
        }
        
            return val_10.Item[Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丆丗丐不丘丒专丌万().Item[丈丁丄丘丛世七丙丝]];
        }
        
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丈一丂丏下东丑丂丘().ContainsKey(key:  丈丁丄丘丛世七丙丝)) == false)
        {
                return 1f;
        }
        
        return WeaponManager.丗与丒世丏一丈下丅();
    }
    internal bool 丑丂丌丂丞下丘七丁()
    {
        return (bool)(Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().Count > 0) ? 1 : 0;
    }
    internal long 丌东丙丈上丈丁且三(string 丒东业不丐丑丕丄丆)
    {
        string val_13;
        var val_14;
        var val_15;
        val_13 = 丒东业不丐丑丕丄丆;
        if(val_13 == null)
        {
            goto label_1;
        }
        
        val_13 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_13);
        if(val_13 == null)
        {
                return (long)val_14;
        }
        
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().ContainsKey(key:  val_13.业东丅东丌上丗丑不())) == false)
        {
            goto label_9;
        }
        
        val_13 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().Item[val_13.业东丅东丌上丗丑不()];
        val_15 = val_13;
        int val_10 = val_15.丑东丄丝丁上丂下业();
        goto label_15;
        label_1:
        val_14 = 0;
        return (long)val_14;
        label_9:
        val_13 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世();
        val_15 = val_13;
        label_15:
        val_14 = (long)val_15.丌下与丗业丞丕丆上();
        return (long)val_14;
    }
    internal static void 一万一丈丙丝一三丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  WeaponManager.上丐丄丆丈丛上不丛, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.上丐丄丆丈丛上不丛 != 1152921505286243040);
    
    }
    internal static void 丞丞上丗丛丆丐与丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  WeaponManager.上丐丄丆丈丛上不丛, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(WeaponManager.上丐丄丆丈丛上不丛 != 1152921505286243040);
    
    }
    internal void 丁丁丌丘万下丕七丆(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        三丅丁丗丗丝丂万且 val_36;
        WeaponManager.业七下丌不丕丒丄丐 val_37;
        decimal val_38;
        var val_39;
        int val_40;
        int val_41;
        decimal val_42;
        三丅丁丗丗丝丂万且 val_43;
        var val_44;
        val_36 = 丆丐七世世且丏丐业;
        WeaponManager.业七下丌不丕丒丄丐 val_1 = null;
        val_37 = val_1;
        val_1 = new WeaponManager.业七下丌不丕丒丄丐();
        if(val_36 == null)
        {
            goto label_1;
        }
        
        val_38 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        decimal val_5 = System.Decimal.op_Implicit(value:  PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().不丑东丐上与世丝七());
        .三丒万万丗世三丆丄 = val_5;
        mem[1152921539614529128] = val_5.lo;
        mem[1152921539614529132] = val_5.mid;
        decimal val_8 = System.Decimal.op_Implicit(value:  PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().丌下与丗业丞丕丆上());
        new WeaponManager.世七万且业与丗上丛() = new WeaponManager.世七万且业与丗上丛();
        .东丟且丗且三专丙丁 = val_37;
        丈丞丕丘丕丗与上一 val_10 = val_36.且丅万下业下三丛与();
        .丒丁丟三丛业一丝东 = val_10;
        val_39 = null;
        val_39 = null;
        bool val_12 = System.String.op_Equality(a:  val_10.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        val_40 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().丐丏丌丄丐丐丁丏丝();
        if(val_12 != false)
        {
                float val_36 = 1.7f;
            val_36 = (float)val_40 / val_36;
            val_40 = (int)val_36;
        }
        
        decimal val_15 = System.Decimal.op_Implicit(value:  val_40);
        if(val_12 == false)
        {
            goto label_18;
        }
        
        val_41 = BankController.七丐三丑上丘且丛丛();
        goto label_21;
        label_1:
        UnityEngine.Debug.LogError(message:  "Add_TryGun_Promo tg == null");
        return;
        label_18:
        val_41 = BankController.丒丈丁七丗丁丗一丐();
        label_21:
        decimal val_18 = System.Decimal.op_Implicit(value:  val_41);
        decimal val_19 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid}, d2:  new System.Decimal() {flags = val_18.flags, hi = val_18.hi, lo = val_18.lo, mid = val_18.mid});
        System.Func<System.Decimal> val_20 = new System.Func<System.Decimal>(object:  new WeaponManager.世七万且业与丗上丛(), method:  System.Decimal WeaponManager.世七万且业与丗上丛::不专丙上丂丟丁不下());
        goto label_28;
        label_39:
        decimal val_21 = null.Invoke();
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_21.flags, hi = val_21.hi, lo = val_21.lo, mid = val_21.mid}, d2:  new System.Decimal() {flags = val_19.flags, hi = val_19.hi, lo = val_19.lo, mid = val_19.mid})) == false)
        {
            goto label_32;
        }
        
        val_42 = (WeaponManager.世七万且业与丗上丛)[1152921539614541392].东丟且丗且三专丙丁.三丒万万丗世三丆丄;
        decimal val_23 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = val_42, hi = val_42, lo = val_21.lo, mid = val_21.mid}, d2:  new System.Decimal());
        (WeaponManager.世七万且业与丗上丛)[1152921539614541392].东丟且丗且三专丙丁.三丒万万丗世三丆丄 = val_23;
        mem2[0] = val_23.lo;
        mem[4] = val_23.mid;
        label_28:
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = (WeaponManager.世七万且业与丗上丛)[1152921539614541392].东丟且丗且三专丙丁.三丒万万丗世三丆丄, hi = (WeaponManager.世七万且业与丗上丛)[1152921539614541392].东丟且丗且三专丙丁.三丒万万丗世三丆丄, lo = val_42, mid = val_42}, d2:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid})) == true)
        {
            goto label_39;
        }
        
        label_32:
        val_38 = (WeaponManager.世七万且业与丗上丛)[1152921539614541392].东丟且丗且三专丙丁.三丒万万丗世三丆丄;
        val_43 = val_36;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_38, hi = val_38, lo = val_19.flags, mid = val_19.hi}, d2:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid})) != false)
        {
                (WeaponManager.世七万且业与丗上丛)[1152921539614541392].东丟且丗且三专丙丁.三丒万万丗世三丆丄 = val_8;
            mem2[0] = val_8.lo;
            mem[4] = val_8.mid;
        }
        
        Rilisoft.一丟专且三万丞丁丂.东业丁不上丁丝丛丄();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  134);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈丂三丌丌东丂丅丙(丞世不丒下上上丝丑:  业东丅东丌上丗丑不(), 丞丈丂世丌万业丅业:  new 不上且丙丘丞丕业丙(丂丂丆丟丑七丟丑业:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = (WeaponManager.业七下丌不丕丒丄丐)[1152921539614529104].三丒万万丗世三丆丄, hi = (WeaponManager.业七下丌不丕丒丄丐)[1152921539614529104].三丒万万丗世三丆丄, lo = 647943760, mid = 268435464}), 专万丂丛与丙一丘万:  FriendsController.丝丗专上三不丄丑丑()), 丐专世与丆丌丒丆丁:  "");
        WeaponManager.业丑专丞万丑丄丛下();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        val_37 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
        val_37.且丛丕业丞万东七丒(丁丅丈丌丟世丗丗丟:  new System.Nullable<OfferModule>() {HasValue = false}, 丙三丈与东三东世丏:  false, 丆丄丘丂业丛七丁且:  false);
        return;
        label_97:
        val_44 = 8;
        do
        {
        
        }
        while(123444064 != 1);
        
        if((null & 1) != 0)
        {
                object[] val_35 = new object[1];
            val_35[0] = ;
            UnityEngine.Debug.LogErrorFormat(format:  "Exception in recal adaptive offers after adding try gun discount: {0}", args:  val_35);
            return;
        }
        
        mem[8] = ;
        goto label_97;
    }
    internal void 且丟下丝丄万丞丞与(int 丞世不丒下上上丝丑)
    {
        var val_14;
        var val_15;
        var val_16;
        val_14 = this;
        new WeaponManager.丟且丌且丝东丐丕业() = new WeaponManager.丟且丌且丝东丐丕业();
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
        if(new WeaponManager.丟且丌且丝东丐丕业() == null)
        {
            goto label_3;
        }
        
        val_15 = new WeaponManager.丟且丌且丝东丐丕业();
        .丆丐七世世且丏丐业 = val_2;
        if(val_2 != null)
        {
            goto label_4;
        }
        
        return;
        label_3:
        mem[16] = val_2;
        val_15 = 16;
        if(mem[16] == 0)
        {
                return;
        }
        
        label_4:
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_5 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new WeaponManager.丟且丌且丝东丐丕业(), method:  System.Boolean WeaponManager.丟且丌且丝东丐丕业::七丆不且丌专丟丁下(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        三丈丟与丏丘丈丐万 val_6 = System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  this.丙下丅丒与丈丈丒与, predicate:  null);
        int val_7 = val_6.三丐三丞丘丕不丒专.业东丅东丌上丗丑不();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  130);
        new 世专丂一一丌万丅丆() = new 世专丂一一丌万丅丆(丑丘一三丗丂东一专:  PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().与丈丙丞专上七丏丅(), 专丙专丈三丗东丞丘:  new System.Nullable<System.Int32>() {HasValue = false});
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().且丟下丝丄万丞丞与(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 丆丈七世丅丁业丆业:  new 世专丂一一丌万丅丆(), 丐专世与丆丌丒丆丁:  "");
        this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  this.丝丟丌丛丆丅上万丑(丛丄东丙业上丈丄且:  val_15.与不丞丑七丘丁丂丛()), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  false);
        val_16 = null;
        val_16 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丒七丅丟丟丐业上丄
        WeaponManager.丟丗丄业丘丗业丗七.丘丄万上丐上丞上丆(丞世不丒下上上丝丑:  WeaponManager.丟丗丄业丘丗业丗七.丒七丅丟丟丐业上丄);
        WeaponManager.三丌丟丕丒七专丌丌();
        val_14 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_14.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private static void 三丌丟丕丒七专丌丌()
    {
        null = null;
        if(WeaponManager.丅且丘丌丟专丞丕七 == null)
        {
                return;
        }
        
        WeaponManager.丅且丘丌丟专丞丕七.Invoke();
    }
    internal static bool 丘丘丑上丁丑丁丟七()
    {
        return (bool)((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  72)) >= PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().业且丙世与与三丛丒()) ? 1 : 0;
    }
    internal static void 丘丕一三业东七万与()
    {
        var val_7;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        val_7 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
        if((val_7.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  73)) == 0)
        {
                return;
        }
        
        val_7 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_7.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  72, 丙业与丙丗丝不丈东:  PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().业且丙世与与三丛丒());
    }
    internal static void 丌丟上丕一丙丟丌丄()
    {
        var val_3;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        val_3 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_3.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  72, 丙业与丙丗丝不丈东:  0);
    }
    internal static void 万下丟丁丘丂一与丛(bool 上丑丕上丕丁丂丏专)
    {
        bool val_4 = 上丑丕上丕丁丂丏专;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        bool val_3 = val_4;
        val_4 = val_3;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  73, 丙业与丙丗丝不丈东:  val_3);
    }
    internal void 丈东下丄专三业丛万()
    {
        var val_50;
        var val_64;
        string val_69;
        var val_70;
        var val_71;
        string val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_80;
        丙且上东下丏丏丟下 val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_86;
        var val_87;
        var val_88;
        var val_89;
        var val_90;
        var val_91;
        var val_92;
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
                return;
        }
        
        if(GameConnect.不专专丂万丝上东丐() != false)
        {
                if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
                return;
        }
        
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return;
        }
        
        if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        int val_12 = (Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  72)) + 1;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  72, 丙业与丙丗丝不丈东:  val_12);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  131);
        Dictionary.Enumerator<TKey, TValue> val_16 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丈一丂丏下东丑丂丘().GetEnumerator();
        label_75:
        if((649090016 & 1) == 0)
        {
            goto label_38;
        }
        
        new WeaponManager.丟丞不丝丅丁丟丗七() = new WeaponManager.丟丞不丝丅丁丟丗七();
        ConfiguredValueTaskAwaiter val_20 = val_12.GetAwaiter();
        .丈丏万丄丒业丅丒一 = val_20._value._obj;
        mem[1152921539615744104] = val_20._value._token;
        mem[1152921539615744106] = val_20._value._continueOnCapturedContext;
        val_70 = null;
        val_70 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_44;
        }
        
        val_71 = null;
        val_71 = null;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_22 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new WeaponManager.丟丞不丝丅丁丟丗七(), method:  System.Boolean WeaponManager.丟丞不丝丅丁丟丗七::丛丄东一丘丅丄丘世(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
        if((System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  WeaponManager.丟丗丄业丘丗业丗七.万丛丌东与三丅一东, predicate:  null)) == null)
        {
            goto label_75;
        }
        
        label_44:
        三丅丁丗丗丝丂万且 val_25 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  .丈丏万丄丒业丅丒一.丙东专丂世丈丏丁丂());
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                if(val_25.丒万丕七专不丏丞丌() != 5)
        {
            goto label_75;
        }
        
        }
        
        if((.丈丏万丄丒业丅丒一.与丏东丂丂丄丒丙丁() == 0) || ((Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().与丝丌三丁丝丄丐丐(丞世不丒下上上丝丑:  .丈丏万丄丒业丅丒一.丙东专丂世丈丏丁丂(), 丐专世与丆丌丒丆丁:  "")) == false))
        {
            goto label_75;
        }
        
        System.Nullable<System.Int32> val_32 = .丈丏万丄丒业丅丒一.丁丅丏丌业丑丟丟专();
        if((649090008 & 1) == 0)
        {
            goto label_63;
        }
        
        System.Nullable<System.Int32> val_33 = .丈丏万丄丒业丅丒一.丁丅丏丌业丑丟丟专();
        val_72 = "";
        if( == 1)
        {
            goto label_85;
        }
        
        val_72 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  649090008).与不丞丑七丘丁丂丛();
        goto label_85;
        label_63:
        val_72 = "";
        label_85:
        val_73 = null;
        val_73 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丌丗世丙丌丝一丒三(丕丘丕丏丆一上丏丙:  val_25.与不丞丑七丘丁丂丛(), 三丁丗丂与一一专万:  val_72);
        WeaponManager.丟丗丄业丘丗业丗七.丅业丝丝丝丟丑业丙(丞世不丒下上上丝丑:  .丈丏万丄丒业丅丒一.丙东专丂世丈丏丁丂());
        goto label_75;
        label_38:
        val_74 = 1152921505359773696;
        val_75 = 1152921505369411584;
        val_76 = 0;
        val_69 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (496 == 496))
        {
                val_76 = 0;
        }
        else
        {
                if( != 0)
        {
                val_69 = 0;
        }
        
        }
        
        if(1 >= 1)
        {
                val_82 = null;
            val_82 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_83 = null;
            val_83 = null;
            val_81 = ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑();
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丆丂丅东业丂丕世丕(下丅丙一丂丗丅丝七:  val_81);
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        }
        
        }
        
            val_84 = null;
            val_84 = null;
            if(WeaponManager.丛丏三七丁一丞丛与 != null)
        {
                WeaponManager.丛丏三七丁一丞丛与.Invoke();
        }
        
        }
        
        val_80 = 0 + 1;
        mem2[0] = 632;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        if(( != 1) && (496 == 632))
        {
                val_80 =  - 1;
        }
        else
        {
                if( != 0)
        {
                val_69 = 0;
        }
        
        }
        
        val_86 = null;
        val_86 = null;
        WeaponManager.丐丘丟丒丞上专上东.Clear();
        Dictionary.Enumerator<TKey, TValue> val_48 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丆丗丐不丘丒专丌万().GetEnumerator();
        label_220:
        if((649089968 & 1) == 0)
        {
            goto label_198;
        }
        
        new WeaponManager.丏东三丟丁丒丈不业() = new WeaponManager.丏东三丟丁丒丈不业();
        .丈丏万丄丒业丅丒一 = val_50.丐丏七丌丕丗业且上();
        val_87 = null;
        val_87 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_204;
        }
        
        val_88 = null;
        val_88 = null;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_54 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new WeaponManager.丏东三丟丁丒丈不业(), method:  System.Boolean WeaponManager.丏东三丟丁丒丈不业::丁丈与丁七不七一东(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
        if((System.Linq.Enumerable.FirstOrDefault<三丅丁丗丗丝丂万且>(source:  WeaponManager.丟丗丄业丘丗业丗七.万丛丌东与三丅一东, predicate:  null)) == null)
        {
            goto label_220;
        }
        
        label_204:
        三丅丁丗丗丝丂万且 val_57 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  .丈丏万丄丒业丅丒一.丙东专丂世丈丏丁丂());
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                if(val_57.丒万丕七专不丏丞丌() != 5)
        {
            goto label_220;
        }
        
        }
        
        val_89 = null;
        val_89 = null;
        WeaponManager.丐丘丟丒丞上专上东.Add(item:  val_57.业东丅东丌上丗丑不());
        goto label_220;
        label_198:
        val_90 =  + 1;
        mem2[0] = 839;
        val_91 = 1152921505359773696;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (496 == 839))
        {
                var val_68 = 0;
            val_68 = val_68 ^ 0;
            val_90 =  + val_68;
        }
        else
        {
                if( != 0)
        {
                val_69 = 0;
        }
        
        }
        
        val_92 = null;
        val_92 = null;
        List.Enumerator<T> val_62 = WeaponManager.丐丘丟丒丞上专上东.GetEnumerator();
        label_264:
        if((649089936 & 1) == 0)
        {
            goto label_260;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞下丅丞丆丑丙上丐(丞世不丒下上上丝丑:  val_64.丙东专丂世丈丏丁丂());
        goto label_264;
        label_260:
         =  + 1;
        mem2[0] = 899;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921539615675088 + ((val_80 + 1)) << 2) != 899)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    internal bool 丐丂丁丟丘世丝丁丐(string 丒丝丄丅丒丘丏丕与)
    {
        string val_9;
        var val_10;
        val_9 = 丒丝丄丅丒丘丏丕与;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == true)
        {
            goto label_6;
        }
        
        val_9 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_9);
        if(val_9 == null)
        {
            goto label_6;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, 世专丂一一丌万丅丆> val_4 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丈一丂丏下东丑丂丘();
        val_9 = val_9.业东丅东丌上丗丑不();
        val_10 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
        goto label_11;
        label_6:
        val_10 = 0;
        label_11:
        val_10 = val_10 & 1;
        return (bool)val_10;
    }
    internal void 丅业丝丝丝丟丑业丙(int 丞世不丒下上上丝丑)
    {
        .丞世不丒下上上丝丑 = 丞世不丒下上上丝丑;
        int val_3 = this.丁一丏东七丌丗丁丏.RemoveAll(match:  new System.Predicate<三丈丟与丏丘丈丐万>(object:  new WeaponManager.丞丁丆丙不东万丕与(), method:  System.Boolean WeaponManager.丞丁丆丙不东万丕与::不业与丝丁丂丞丘丑(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)));
    }
    internal bool 丟丁三不世丕丗丘东(int 丞世不丒下上上丝丑)
    {
        Progress.下丁下丂七丆丙七一 val_1 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        if(val_1 != null)
        {
                return val_1.丟丁三不世丕丗丘东(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 丐专世与丆丌丒丆丁:  "");
        }
        
        return val_1.丟丁三不世丕丗丘东(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 丐专世与丆丌丒丆丁:  "");
    }
    internal bool 世世丟上三与东丘不(string 丒东业不丐丑丕丄丆)
    {
        string val_5 = 丒东业不丐丑丕丄丆;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5 = 丒东业不丐丑丕丄丆)) == true)
        {
                return false;
        }
        
        val_5 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_5);
        if(val_5 == null)
        {
                return false;
        }
        
        Progress.专丗丑丞丏不丝东丁 val_3 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
        if(val_3 != null)
        {
                return val_3.七丙丙世丁丟丕上不(丞世不丒下上上丝丑:  val_5.业东丅东丌上丗丑不());
        }
        
        return val_3.七丙丙世丁丟丕上不(丞世不丒下上上丝丑:  val_5.业东丅东丌上丗丑不());
    }
    internal long 东丑丗专丗万世丙丒(string 丒东业不丐丑丕丄丆)
    {
        string val_9;
        var val_10;
        val_9 = 丒东业不丐丑丕丄丆;
        不上且丙丘丞丕业丙 val_6 = 0;
        val_10 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == true)
        {
                return (long)val_10;
        }
        
        val_9 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_9);
        if(val_9 == null)
        {
                return (long)val_10;
        }
        
        val_9 = val_9.业东丅东丌上丗丑不();
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().TryGetValue(key:  val_9, value: out  val_6)) != false)
        {
                val_10 = val_6;
            if(val_10 == 0)
        {
                return (long)val_10;
        }
        
            long val_8 = val_10.业丗世丙世且丞丆丆();
            return (long)val_10;
        }
        
        val_10 = 0;
        return (long)val_10;
    }
    internal static int 业丗丌下丙丗丛丝万()
    {
        int val_2 = PGCompany.丌丗丄不万丑丌丌丅.丑七不且上丗丁一世().不丁丝丗丑丗丝且一();
        val_2 = val_2 * 60;
        return (int)val_2;
    }
    private void 丑七专业丞丙丛且丄()
    {
        var val_10;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 不上且丙丘丞丕业丙>, 三丅丁丗丗丝丂万且> val_12;
        var val_13;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_15;
        val_10 = null;
        val_10 = null;
        val_12 = WeaponManager.<>c.<>9__559_0;
        if(val_12 == null)
        {
                val_12 = null;
            val_12 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 不上且丙丘丞丕业丙>, 三丅丁丗丗丝丂万且>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  三丅丁丗丗丝丂万且 WeaponManager.<>c::丙业七不三丛丅丟下(System.Collections.Generic.KeyValuePair<int, 不上且丙丘丞丕业丙> 丈丏万丄丒业丅丒一));
            WeaponManager.<>c.<>9__559_0 = val_12;
        }
        
        val_13 = null;
        val_13 = null;
        val_15 = WeaponManager.<>c.<>9__559_1;
        if(val_15 == null)
        {
                val_15 = null;
            val_15 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponManager.<>c::万丌东丏下丒丞丑丕(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
            WeaponManager.<>c.<>9__559_1 = val_15;
        }
        
        System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Int32, 不上且丙丘丞丕业丙>, 三丅丁丗丗丝丂万且>(source:  Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一(), selector:  null), predicate:  null));
        if(val_7.Count <= 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = new System.Action<三丅丁丗丗丝丂万且>(object:  this, method:  System.Void WeaponManager::丗东丕丅丒下丈专万(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
        val_7.ForEach(action:  null);
        WeaponManager.业丑专丞万丑丄丛下();
    }
    private void 一七丂丌丝丒一丕丒()
    {
        object val_8;
        object val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
                return;
        }
        
        val_18 = 1152921505359773696;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  132);
        Dictionary.Enumerator<TKey, TValue> val_5 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().GetEnumerator();
        val_19 = 0;
        goto label_13;
        label_19:
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        if(val_9._value._obj.业丗世丙世且丞丆丆() == 1)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下丒丆三丒丐丝下不(丞世不丒下上上丝丑:  val_9._value._obj.丙东专丂世丈丏丁丂(), 丂三丟丂丈丐丆丗丟:  FriendsController.丝丗专上三不丄丑丑(), 丐专世与丆丌丒丆丁:  "");
            val_18 = 1152921505359773696;
            val_19 = 1;
        }
        
        label_13:
        if((650370400 & 1) != 0)
        {
            goto label_19;
        }
        
        val_20 = 0;
        val_21 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_31;
        }
        
        if( == 0)
        {
            goto label_35;
        }
        
        if(129 != 129)
        {
            goto label_33;
        }
        
        goto label_35;
        label_31:
        if( == 0)
        {
            goto label_35;
        }
        
        label_33:
        label_35:
        if(val_19 >= 1)
        {
                WeaponManager.业丑专丞万丑丄丛下();
        }
        
        val_17 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_17.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    internal void 丟丐丌丙丗丞东丑丙()
    {
        object val_8;
        object val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        val_32 = this;
        long val_1 = FriendsController.丝丗专上三不丄丑丑();
        if(val_1 < 1)
        {
                return;
        }
        
        val_1.一七丂丌丝丒一丕丒();
        val_33 = null;
        this.丂丘专丆专三丒三丑.Clear();
        Dictionary.Enumerator<TKey, TValue> val_5 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().GetEnumerator();
        label_19:
        if((650572880 & 1) == 0)
        {
            goto label_11;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        if(val_9._value._obj.业丗世丙世且丞丆丆() == 1)
        {
            goto label_19;
        }
        
        if((FriendsController.丝丗专上三不丄丑丑() - val_9._value._obj.业丗世丙世且丞丆丆()) < (long)WeaponManager.业丗丌下丙丗丛丝万())
        {
            goto label_19;
        }
        
        this.丂丘专丆专三丒三丑.Add(item:  val_9._value._obj.丙东专丂世丈丏丁丂());
        goto label_19;
        label_11:
        val_34 = 650572768;
        val_35 = 0;
        val_36 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (140 == 140))
        {
                val_35 = 0;
        }
        else
        {
                if( != 0)
        {
                val_36 = 0;
        }
        
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  133);
        var val_31 = 0;
        label_53:
        if(val_31 >= this.丂丘专丆专三丒三丑.Count)
        {
            goto label_39;
        }
        
        bool val_19 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丟丁三不世丕丗丘东(丞世不丒下上上丝丑:  this.丂丘专丆专三丒三丑.Item[0], 丐专世与丆丌丒丆丁:  "");
        三丅丁丗丗丝丂万且 val_21 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  this.丂丘专丆专三丒三丑.Item[0]);
        Rilisoft.一丟专且三万丞丁丂.丅丅丐业东丘丝丈丛(丞一丁业丄一一业且:  val_21.三与丛丑且丐丈业丌(), 七丆丒与丗丌丄且丂:  val_21.丒万丕七专不丏丞丌(), 丙丂丏丛丌丏下丝不:  ExperienceController.丞丞丘业东丙丏七丌(), 业七不世丆专丆丈业:  false, 一一下丞丕丁丕丈丁:  false, 不东丐下丆丂丛与丞:  false);
        val_31 = val_31 + 1;
        goto label_53;
        label_39:
        val_39 = val_36;
        if(this.丂丘专丆专三丒三丑.Count >= 1)
        {
                val_40 = null;
            val_40 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_41 = null;
            val_41 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丙丑丘业丕丗丗不丘();
        }
        
        }
        
            WeaponManager.业丑专丞万丑丄丛下();
        }
        
        val_42 = 1;
        val_32 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_32.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        if( != 1)
        {
                if(null == null)
        {
                return;
        }
        
            if(140 != 341)
        {
                return;
        }
        
            return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    internal static void 业丑专丞万丑丄丛下()
    {
        null = null;
        if(WeaponManager.丈下丑丅丞万七丈丕 == null)
        {
                return;
        }
        
        WeaponManager.丈下丑丅丞万七丈丕.Invoke();
    }
    private System.Collections.IEnumerator 且丑七专与且丈业丑()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponManager.上专丗丅丂丞丁丒不(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 丌丗世丙丌丝一丒三(string 丕丘丕丏丆一上丏丙, string 三丁丗丂与一一专万)
    {
        var val_26;
        System.Object[] val_68;
        string val_69;
        string val_70;
        System.Object[] val_71;
        var val_72;
        var val_73;
        System.Func<System.String, System.String> val_75;
        System.Func<System.String, System.String[]> val_77;
        var val_79;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String[]>, System.String> val_81;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String[]>, System.String[]> val_83;
        var val_84;
        FilterMaps val_85;
        var val_86;
        int val_87;
        System.Collections.Generic.Dictionary<TKey, TElement> val_89;
        var val_90;
        string val_91;
        var val_93;
        int val_94;
        System.String[] val_56 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丘丕丏丆一上丏丙)) == false)
        {
            goto label_3;
        }
        
        val_68 = new object[1];
        val_68[0] = (三丁丗丂与一一专万 == null) ? "null" : 三丁丗丂与一一专万;
        val_70 = "wea_ponTo_ReplaceT_ag.IsNull_OrEmpty new = {0}";
        val_71 = val_68;
        goto label_10;
        label_3:
        new WeaponManager.不且丄丅丈上丈丆专() = new WeaponManager.不且丄丅丈上丈丆专();
        .丝且与丝丒丟万丁专 = this;
        三丅丁丗丗丝丂万且 val_5 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丕丘丕丏丆一上丏丙);
        .丞丙七丙丐丁丕丙七 = val_5;
        if(val_5 == null)
        {
            goto label_14;
        }
        
        val_72 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  三丁丗丂与一一专万);
        if((val_72 != null) && (val_72.与丕丒世七丁万丂丛() != false))
        {
                if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_72.业东丅东丌上丗丑不())) == null)
        {
                string val_11 = val_72.与不丞丑七丘丁丂丛();
            var val_13 = ((val_11.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_11)) != true) ? (val_72) : 0;
        }
        
        }
        
        val_73 = null;
        val_73 = null;
        val_75 = WeaponManager.<>c.<>9__565_0;
        if(val_75 == null)
        {
                val_75 = null;
            val_75 = new System.Func<System.String, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::世丄丝东上且丌丘且(string 三丟东丕丄丄下下丑));
            val_73 = null;
            WeaponManager.<>c.<>9__565_0 = val_75;
        }
        
        val_73 = null;
        val_77 = WeaponManager.<>c.<>9__565_1;
        if(val_77 == null)
        {
                val_77 = null;
            val_77 = new System.Func<System.String, System.String[]>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String[] WeaponManager.<>c::丄一七上丗丗丏下不(string 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__565_1 = val_77;
        }
        
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String[]>, System.Boolean> val_18 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String[]>, System.Boolean>(object:  new WeaponManager.不且丄丅丈上丈丆专(), method:  System.Boolean WeaponManager.不且丄丅丈上丈丆专::丒丁丈下丐丝丘丕丐(System.Collections.Generic.KeyValuePair<string, string[]> 丈丏万丄丒业丅丒一));
        val_79 = null;
        val_79 = null;
        val_81 = WeaponManager.<>c.<>9__565_3;
        if(val_81 == null)
        {
                val_81 = null;
            val_81 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String[]>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::丗丏丕东丁万丐丞丒(System.Collections.Generic.KeyValuePair<string, string[]> 丈丏万丄丒业丅丒一));
            val_79 = null;
            WeaponManager.<>c.<>9__565_3 = val_81;
        }
        
        val_79 = null;
        val_83 = WeaponManager.<>c.<>9__565_4;
        if(val_83 == null)
        {
                val_83 = null;
            val_83 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String[]>, System.String[]>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String[] WeaponManager.<>c::业世与丝丅不下三丘(System.Collections.Generic.KeyValuePair<string, string[]> 丈丏万丄丒业丅丒一));
            WeaponManager.<>c.<>9__565_4 = val_83;
        }
        
        System.Collections.Generic.Dictionary<TKey, TElement> val_22 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.String[]>, System.String, System.String[]>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, System.String[]>>(source:  System.Linq.Enumerable.ToDictionary<System.String, System.String, System.String[]>(source:  WeaponManager.一丝丞丗不丄万丅丗(), keySelector:  null, elementSelector:  null), predicate:  null), keySelector:  null, elementSelector:  null);
        Dictionary.Enumerator<TKey, TValue> val_23 = val_22.GetEnumerator();
        label_122:
        if((651241392 & 1) == 0)
        {
            goto label_46;
        }
        
        new WeaponManager.丙不丑业世一世业与() = new WeaponManager.丙不丑业世一世业与();
        ConfiguredValueTaskAwaiter val_28 = val_26.GetAwaiter();
        if(new WeaponManager.丙不丑业世一世业与() != null)
        {
                val_84 = new WeaponManager.丙不丑业世一世业与();
            .丈丏万丄丒业丅丒一 = val_28._value._obj;
            mem[1152921539617944648] = val_28._value._token;
            mem[1152921539617944650] = val_28._value._continueOnCapturedContext;
        }
        else
        {
                mem[16] = val_28._value._obj;
            mem[24] = val_28._value._token;
            mem[26] = val_28._value._continueOnCapturedContext;
            val_84 = 16;
        }
        
        bool val_31 = System.String.op_Equality(a:  mem[16].丐丏七丌丕丗业且上(), b:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七());
        if(val_31 == false)
        {
            goto label_51;
        }
        
        val_85 = 0;
        if(val_13 != 0)
        {
            goto label_52;
        }
        
        goto label_58;
        label_51:
        val_86 = null;
        val_86 = null;
        System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_32 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean>(object:  new WeaponManager.丙不丑业世一世业与(), method:  System.Boolean WeaponManager.丙不丑业世一世业与::丝丘丆丞丆且丑世丘(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丙丁上东且七丂世丗));
        System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> val_33 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  WeaponManager.且专专丁丌丗丛且丙, predicate:  null);
        val_85 = val_33.Value.丙东专丂世丈丏丁丂();
        if(val_13 == 0)
        {
            goto label_58;
        }
        
        label_52:
        bool val_35 = val_13.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  val_85);
        if((val_31 | (~val_35)) == false)
        {
            goto label_57;
        }
        
        if(val_35 == false)
        {
            goto label_58;
        }
        
        label_62:
        val_87 = val_13.三与丛丑且丐丈业丌();
        if(val_87 == null)
        {
            goto label_59;
        }
        
        label_73:
        if(new WeaponManager.丙不丑业世一世业与() != null)
        {
            goto label_74;
        }
        
        goto label_61;
        label_57:
        if(val_13.七不丕世且丟丑丈丒() == false)
        {
            goto label_62;
        }
        
        label_58:
        char[] val_41 = new char[1];
        val_41[0] = '#';
        if((WeaponManager.丆丆七丆万丝丆丑丟(丅丟丛下业丙七业一:  mem[16].丐丏七丌丕丗业且上()).Split(separator:  val_41)[(long)(WeaponManager.不且丄丅丈上丈丆专)[1152921539617883184].丞丙七丙丐丁丕丙七.丒万丕七专不丏丞丌()]) != null)
        {
            goto label_73;
        }
        
        label_59:
        val_87 = System.String.alignConst;
        if(new WeaponManager.丙不丑业世一世业与() != null)
        {
            goto label_74;
        }
        
        label_61:
        label_74:
        CategoryNames val_44 = (WeaponManager.不且丄丅丈上丈丆专)[1152921539617883184].丞丙七丙丐丁丕丙七.丒万丕七专不丏丞丌();
        var val_45 = val_84 + (((long)(int)(val_44)) << 3);
        mem2[0] = val_87;
        WeaponManager.不一七丗丗丆丌上丙(丅丟丛下业丙七业一:  mem[16].丐丏七丌丕丗业且上(), 专丟丌丄东且上业一:  val_87, 下业丕七东丌丝下且:  (WeaponManager.不且丄丅丈上丈丆专)[1152921539617883184].丞丙七丙丐丁丕丙七.丒万丕七专不丏丞丌(), 下与丙业丁世三丞丒:  true);
        goto label_122;
        label_14:
        object[] val_49 = new object[2];
        val_68 = val_49;
        val_81 = "null";
        val_68[0] = (丕丘丕丏丆一上丏丙 == null) ? "null" : 丕丘丕丏丆一上丏丙;
        val_68[1] = (三丁丗丂与一一专万 == null) ? "null" : 三丁丗丂与一一专万;
        UnityEngine.Debug.LogErrorFormat(format:  "oldRec == null   old = {0} new = {1}", args:  val_49);
        return;
        label_46:
        val_89 = val_22;
        val_90 = 0;
        val_91 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_164;
        }
        
        if( == 0)
        {
            goto label_168;
        }
        
        if(641 != 641)
        {
            goto label_166;
        }
        
        goto label_168;
        label_164:
        if( == 0)
        {
            goto label_168;
        }
        
        label_166:
        label_168:
        .不且丗万业丞丞七七 = 0;
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_172;
        }
        
        val_69 = 与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七();
        if( != 0)
        {
            goto label_183;
        }
        
        goto label_176;
        label_172:
        val_93 = null;
        val_93 = null;
        val_81 = ShopNGUIController.丛丐丛专丟丞万三七();
        丅一丈与丄三丝丝丞 val_55 = WeaponManager.且专专丁丌丗丛且丙.Item[val_81];
        val_69 = val_55.丟丌东且上业丝丂丞;
        if( != 0)
        {
            goto label_183;
        }
        
        label_176:
        label_183:
        val_68 = val_56;
        if((val_68 == 0) || (((TryGetValue(key:  val_69, value: out  val_56)) ^ 1) == true))
        {
            goto label_187;
        }
        
        val_69 = (WeaponManager.不且丄丅丈上丈丆专)[1152921539617883184].丞丙七丙丐丁丕丙七;
        if(val_69.丒万丕七专不丏丞丌() >= mem[24])
        {
            goto label_187;
        }
        
        val_68 = val_56;
        val_69 = (WeaponManager.不且丄丅丈上丈丆专)[1152921539617883184].丞丙七丙丐丁丕丙七.丒万丕七专不丏丞丌();
        var val_61 = val_68 + (((long)(int)(val_60)) << 3);
        val_94 = mem[(val_68 + ((long)(int)(val_60)) << 3) + 32];
        val_94 = (val_68 + ((long)(int)(val_60)) << 3) + 32;
        if(val_94 == 0)
        {
                val_94 = System.String.alignConst;
        }
        
        .不且丗万业丞丞七七 = val_94;
        if(val_94 != 0)
        {
            goto label_192;
        }
        
        return;
        label_187:
        if((WeaponManager.不且丄丅丈上丈丆专)[1152921539617883184].不且丗万业丞丞七七 == null)
        {
                return;
        }
        
        label_192:
        val_69 = new System.Action();
        val_69 = new System.Action(object:  new WeaponManager.不且丄丅丈上丈丆专(), method:  System.Void WeaponManager.不且丄丅丈上丈丆专::丌丁丌丐与世丙丏丐());
        val_68 = this;
        if((System.String.op_Equality(a:  (WeaponManager.不且丄丅丈上丈丆专)[1152921539617883184].不且丗万业丞丞七七, b:  System.String.alignConst)) != false)
        {
                new System.Action().Invoke();
            return;
        }
        
        val_81 = null;
        val_81 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new WeaponManager.不且丄丅丈上丈丆专(), method:  System.Boolean WeaponManager.不且丄丅丈上丈丆专::丄丞丆丛丆且丌丑丐(三丈丟与丏丘丈丐万 三丟东丕丄丄下下丑));
        三丈丟与丏丘丈丐万 val_65 = System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  mem[1152921539617839024], predicate:  null);
        if(val_65 != null)
        {
                this.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  val_65, 专东丅一三丏三丐丟:  false, 丂丐丕丟丕丗且东丐:  false);
            return;
        }
        
        new System.Action().Invoke();
        return;
        label_10:
        UnityEngine.Debug.LogErrorFormat(format:  null, args:  null);
    }
    private static void 丁丄丗万丞上万下丙()
    {
        System.Collections.Generic.Dictionary<TKey, TElement> val_10;
        var val_11;
        var val_12;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_14;
        var val_15;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32> val_17;
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丘且丘丛东丅专丆万 != null)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "WeaponManager.REMEMBERED_PENALTIES_KEY")) == false)
        {
            goto label_6;
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "WeaponManager.REMEMBERED_PENALTIES_KEY"));
        val_12 = null;
        val_12 = null;
        val_14 = WeaponManager.<>c.<>9__582_0;
        val_15 = 0;
        if(val_14 == null)
        {
            goto label_13;
        }
        
        val_15 = 0;
        goto label_25;
        label_6:
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "WeaponManager.REMEMBERED_PENALTIES_KEY", 下下丏一丙不丘丌丞:  "{}");
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = null;
        val_10 = val_4;
        val_4 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        goto label_32;
        label_13:
        val_14 = null;
        val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::丞一丆丘丞不且丙丈(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
        val_12 = null;
        WeaponManager.<>c.<>9__582_0 = val_14;
        label_25:
        val_12 = null;
        val_17 = WeaponManager.<>c.<>9__582_1;
        if(val_17 == null)
        {
                val_17 = null;
            val_17 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponManager.<>c::丗丕一丑且专七与丕(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            WeaponManager.<>c.<>9__582_1 = val_17;
        }
        
        val_10 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, System.Int32>(source:  null, keySelector:  val_14, elementSelector:  null);
        label_32:
        WeaponManager.丘且丘丛东丅专丆万 = val_10;
    }
    private static void 万丗且丙世丒丆不丟()
    {
        System.Collections.Generic.Dictionary<TKey, TElement> val_10;
        var val_11;
        var val_12;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_14;
        var val_15;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, Rilisoft.丝丑丂丛万丐丈丘且> val_17;
        val_11 = null;
        val_11 = null;
        if(WeaponManager.万丗下丒丈丛丅一七 != null)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "WeaponManager.REMEMBERED_COMBAT_LEVELS_EVENT_GOCHA_WEAPONS_KEY")) == false)
        {
            goto label_6;
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "WeaponManager.REMEMBERED_COMBAT_LEVELS_EVENT_GOCHA_WEAPONS_KEY"));
        val_12 = null;
        val_12 = null;
        val_14 = WeaponManager.<>c.<>9__583_0;
        val_15 = 0;
        if(val_14 == null)
        {
            goto label_13;
        }
        
        val_15 = 0;
        goto label_25;
        label_6:
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "WeaponManager.REMEMBERED_COMBAT_LEVELS_EVENT_GOCHA_WEAPONS_KEY", 下下丏一丙不丘丌丞:  "{}");
        System.Collections.Generic.Dictionary<System.String, Rilisoft.丝丑丂丛万丐丈丘且> val_4 = null;
        val_10 = val_4;
        val_4 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.丝丑丂丛万丐丈丘且>();
        goto label_32;
        label_13:
        val_14 = null;
        val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::万丝与下丌三丘一下(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
        val_12 = null;
        WeaponManager.<>c.<>9__583_0 = val_14;
        label_25:
        val_12 = null;
        val_17 = WeaponManager.<>c.<>9__583_1;
        if(val_17 == null)
        {
                val_17 = null;
            val_17 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, Rilisoft.丝丑丂丛万丐丈丘且>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.丝丑丂丛万丐丈丘且 WeaponManager.<>c::丝丅丝丟丞丑七丙万(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            WeaponManager.<>c.<>9__583_1 = val_17;
        }
        
        val_10 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, Rilisoft.丝丑丂丛万丐丈丘且>(source:  null, keySelector:  val_14, elementSelector:  null);
        label_32:
        WeaponManager.万丗下丒丈丛丅一七 = val_10;
    }
    private static void 丕丒丌丙丝业七一万()
    {
        System.Collections.Generic.Dictionary<TKey, TElement> val_9;
        var val_10;
        var val_11;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_13;
        var val_14;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, Rilisoft.丝丑丂丛万丐丈丘且> val_16;
        var val_17;
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丞业丕专丆七丛丑丗 != null)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "WeaponManager.FIRST_COMBAT_LEVELS_KEY_250118")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "WeaponManager.FIRST_COMBAT_LEVELS_KEY_250118", 下下丏一丙不丘丌丞:  "{}");
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "WeaponManager.FIRST_COMBAT_LEVELS_KEY_250118"));
        val_11 = null;
        val_11 = null;
        val_13 = WeaponManager.<>c.<>9__584_0;
        val_14 = 0;
        if(val_13 != null)
        {
                val_14 = 0;
        }
        else
        {
                val_13 = null;
            val_13 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::丏专丑七丝丟丛丑丛(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            val_11 = null;
            WeaponManager.<>c.<>9__584_0 = val_13;
        }
        
        val_11 = null;
        val_16 = WeaponManager.<>c.<>9__584_1;
        if(val_16 == null)
        {
                val_16 = null;
            val_16 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, Rilisoft.丝丑丂丛万丐丈丘且>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.丝丑丂丛万丐丈丘且 WeaponManager.<>c::世三三丟丌丕七丌丟(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            WeaponManager.<>c.<>9__584_1 = val_16;
        }
        
        val_9 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, Rilisoft.丝丑丂丛万丐丈丘且>(source:  null, keySelector:  val_13, elementSelector:  null);
        val_17 = null;
        val_17 = null;
        WeaponManager.丞业丕专丆七丛丑丗 = val_9;
    }
    internal static System.Collections.Generic.Dictionary<string, int> 东七丞丝东丑不业七()
    {
        var val_3;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.丝丑丂丛万丐丈丘且>, System.String> val_5;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_7;
        WeaponManager.一不一丕丅丐世一丗();
        val_3 = null;
        val_3 = null;
        val_5 = WeaponManager.<>c.<>9__585_0;
        if(val_5 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.丝丑丂丛万丐丈丘且>, System.String> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.丝丑丂丛万丐丈丘且>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::丐丐丂东不三丙世业(System.Collections.Generic.KeyValuePair<string, Rilisoft.丝丑丂丛万丐丈丘且> 丈丏万丄丒业丅丒一));
            val_3 = null;
            WeaponManager.<>c.<>9__585_0 = val_5;
        }
        
        val_3 = null;
        val_7 = WeaponManager.<>c.<>9__585_1;
        if(val_7 != null)
        {
                return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.丝丑丂丛万丐丈丘且>, System.String, System.Int32>(source:  WeaponManager.业上丞丞三专七丞上, keySelector:  val_1, elementSelector:  System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_2 = null);
        }
        
        val_7 = val_2;
        val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponManager.<>c::三且专丆与丂丏丂丑(System.Collections.Generic.KeyValuePair<string, Rilisoft.丝丑丂丛万丐丈丘且> 丈丏万丄丒业丅丒一));
        WeaponManager.<>c.<>9__585_1 = val_7;
        return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, Rilisoft.丝丑丂丛万丐丈丘且>, System.String, System.Int32>(source:  WeaponManager.业上丞丞三专七丞上, keySelector:  val_1, elementSelector:  val_2);
    }
    private static void 一不一丕丅丐世一丗()
    {
        object val_8;
        object val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_16 = null;
        val_16 = null;
        if(WeaponManager.业上丞丞三专七丞上 != null)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "WeaponManager.WEAPON_LEVELS_V5_KEY")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "WeaponManager.WEAPON_LEVELS_V5_KEY", 下下丏一丙不丘丌丞:  "{}");
        }
        
        System.Collections.Generic.Dictionary<System.String, Rilisoft.丝丑丂丛万丐丈丘且> val_4 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.丝丑丂丛万丐丈丘且>();
        val_17 = null;
        val_17 = null;
        WeaponManager.业上丞丞三专七丞上 = null;
        Dictionary.Enumerator<TKey, TValue> val_6 = GetEnumerator();
        label_25:
        if((652234400 & 1) == 0)
        {
            goto label_19;
        }
        
        ConfiguredValueTaskAwaiter val_10 = val_8.GetAwaiter();
        int val_11 = System.Convert.ToInt32(value:  val_10._value._obj);
        val_18 = null;
        val_18 = null;
        int val_13 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        val_8 = 0;
        null.set_Item(key:  val_10._value._obj.丐丏七丌丕丗业且上(), value:  new Rilisoft.丝丑丂丛万丐丈丘且());
        goto label_25;
        label_19:
        val_19 = 652234320;
        val_20 = 0;
        val_15 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if( != 149)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    private static void 且下一丙丝丐业世丂()
    {
        System.Collections.Generic.Dictionary<TKey, TElement> val_9;
        var val_10;
        var val_11;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_13;
        var val_14;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32> val_16;
        var val_17;
        val_10 = null;
        val_10 = null;
        if(WeaponManager.业专丂丑不专下三丂 != null)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "WeaponManager.FIRST_STARS_KEY_210817")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "WeaponManager.FIRST_STARS_KEY_210817", 下下丏一丙不丘丌丞:  "{}");
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "WeaponManager.FIRST_STARS_KEY_210817"));
        val_11 = null;
        val_11 = null;
        val_13 = WeaponManager.<>c.<>9__587_0;
        val_14 = 0;
        if(val_13 != null)
        {
                val_14 = 0;
        }
        else
        {
                val_13 = null;
            val_13 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::丁丝七且丗丘万丈业(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            val_11 = null;
            WeaponManager.<>c.<>9__587_0 = val_13;
        }
        
        val_11 = null;
        val_16 = WeaponManager.<>c.<>9__587_1;
        if(val_16 == null)
        {
                val_16 = null;
            val_16 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Int32>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponManager.<>c::丆丗丙丞丞丆丕丝丑(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
            WeaponManager.<>c.<>9__587_1 = val_16;
        }
        
        val_9 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, System.Int32>(source:  null, keySelector:  val_13, elementSelector:  null);
        val_17 = null;
        val_17 = null;
        WeaponManager.业专丂丑不专下三丂 = val_9;
    }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> 世业世丗丕丒不丒丑()
    {
        var val_3;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丅专上丝与三东丗丝>, System.String> val_5;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丅专上丝与三东丗丝>, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_7;
        WeaponManager.丏专丆丘万与丅丕丞();
        val_3 = null;
        val_3 = null;
        val_5 = WeaponManager.<>c.<>9__588_0;
        if(val_5 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, 丅专上丝与三东丗丝>, System.String> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丅专上丝与三东丗丝>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::丞专东丄丟专下万七(System.Collections.Generic.KeyValuePair<string, WeaponManager.丅专上丝与三东丗丝> 丈丏万丄丒业丅丒一));
            val_3 = null;
            WeaponManager.<>c.<>9__588_0 = val_5;
        }
        
        val_3 = null;
        val_7 = WeaponManager.<>c.<>9__588_1;
        if(val_7 != null)
        {
                return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, 丅专上丝与三东丗丝>, System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>(source:  WeaponManager.丂丁丙专丆丄丐丐丟, keySelector:  val_1, elementSelector:  System.Func<System.Collections.Generic.KeyValuePair<System.String, 丅专上丝与三东丗丝>, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_2 = null);
        }
        
        val_7 = val_2;
        val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丅专上丝与三东丗丝>, System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Int32> WeaponManager.<>c::七丆丞与丐丂且业下(System.Collections.Generic.KeyValuePair<string, WeaponManager.丅专上丝与三东丗丝> 丈丏万丄丒业丅丒一));
        WeaponManager.<>c.<>9__588_1 = val_7;
        return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, 丅专上丝与三东丗丝>, System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>(source:  WeaponManager.丂丁丙专丆丄丐丐丟, keySelector:  val_1, elementSelector:  val_2);
    }
    private static void 丏专丆丘万与丅丕丞()
    {
        object val_8;
        object val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丂丁丙专丆丄丐丐丟 != null)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "WeaponManager.WEAPON_LEVELS_KEY")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "WeaponManager.WEAPON_LEVELS_KEY", 下下丏一丙不丘丌丞:  "{}");
        }
        
        System.Collections.Generic.Dictionary<System.String, 丅专上丝与三东丗丝> val_4 = new System.Collections.Generic.Dictionary<System.String, 丅专上丝与三东丗丝>();
        val_21 = null;
        val_21 = null;
        WeaponManager.丂丁丙专丆丄丐丐丟 = null;
        Dictionary.Enumerator<TKey, TValue> val_6 = GetEnumerator();
        label_30:
        if((652690832 & 1) == 0)
        {
            goto label_19;
        }
        
        ConfiguredValueTaskAwaiter val_10 = val_8.GetAwaiter();
        val_22 = 0;
        val_23 = null;
        val_23 = null;
        new WeaponManager.丅专上丝与三东丗丝() = new WeaponManager.丅专上丝与三东丗丝(业万上丆丐丞且丒七:  System.Convert.ToInt32(value:  Item["TIER"]), 丈丘丝一丗下丈丐不:  System.Convert.ToInt32(value:  Item["LEVEL"]));
        null.set_Item(key:  val_10._value._obj.丐丏七丌丕丗业且上(), value:  new WeaponManager.丅专上丝与三东丗丝());
        goto label_30;
        label_19:
        val_24 = 0;
        val_19 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(175 != 175)
        {
                return;
        }
        
            return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    internal static void 丁三丞丐丏丆丝世丘()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_1 = WeaponManager.世业世丗丕丒不丒丑();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "SaveWeap_onLevelsV4: \n"("SaveWeap_onLevelsV4: \n") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1)(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1)));
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "WeaponManager.WEAPON_LEVELS_KEY", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1));
    }
    private static void 与丁丝且万丄东丙丟(string 丒东业不丐丑丕丄丆, WeaponManager.丅专上丝与三东丗丝 丞丌东丟且丒丐丑丂)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                object[] val_2 = new object[6];
            val_2[0] = "Migrate: tg=";
            val_2[1] = 丒东业不丐丑丕丄丆;
            val_2[2] = " tier = ";
            val_2[3] = 丞丌东丟且丒丐丑丂.丌且丐下不丂丒与丘;
            val_2[4] = " Level = ";
            val_2[5] = 丞丌东丟且丒丐丑丂.万丄丅丛下丐丒丞上;
            UnityEngine.Debug.Log(message:  +val_2);
        }
        
        WeaponManager.丏专丆丘万与丅丕丞();
        WeaponManager.丂丁丙专丆丄丐丐丟.set_Item(key:  丒东业不丐丑丕丄丆, value:  丞丌东丟且丒丐丑丂);
    }
    internal static void 丈下丕下且丕丄丆丁()
    {
        var val_2;
        System.Collections.Generic.Dictionary<System.String, 丅专上丝与三东丗丝> val_1 = new System.Collections.Generic.Dictionary<System.String, 丅专上丝与三东丗丝>();
        val_2 = null;
        val_2 = null;
        WeaponManager.丂丁丙专丆丄丐丐丟 = null;
        WeaponManager.丁三丞丐丏丆丝世丘();
    }
    internal static void 丅下丁丁万丏丑且丒(string 丒东业不丐丑丕丄丆)
    {
        string val_5;
        System.Collections.Generic.Dictionary<System.String, Rilisoft.丝丑丂丛万丐丈丘且> val_6;
        val_5 = 丒东业不丐丑丕丄丆;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) == true)
        {
                return;
        }
        
        WeaponManager.一不一丕丅丐世一丗();
        val_6 = WeaponManager.业上丞丞三专七丞上;
        if(val_6 != null)
        {
                val_6 = WeaponManager.业上丞丞三专七丞上;
            if(val_6 == null)
        {
                val_6 = 0;
        }
        
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = val_6.Item[val_5];
            int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            WeaponManager.业上丞丞三专七丞上.set_Item(key:  val_5, value:  new Rilisoft.丝丑丂丛万丐丈丘且());
            WeaponManager.与与不且丛丏丗专且();
            return;
        }
        
        val_5 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "GiveUpOfWEapon_Immediately_V5 _weaponL_evels_V5 == null", args:  val_5);
    }
    private static void 与与不且丛丏丗专且()
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = WeaponManager.东七丞丝东丑不业七();
        UnityEngine.Debug.Log(message:  "SaveWeapo_nLevels_V5: \n"("SaveWeapo_nLevels_V5: \n") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1)(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1)));
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "WeaponManager.WEAPON_LEVELS_V5_KEY", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1));
    }
    public WeaponManager()
    {
        this.shownWeapons = new System.Collections.Generic.List<System.String>();
        this.丝丄丂丛七不丐丁东 = new System.Collections.Generic.List<三丈丟与丏丘丈丐万>();
        this.丙下丅丒与丈丈丒与 = new System.Collections.Generic.List<三丈丟与丏丘丈丐万>();
        this.丁一丏东七丌丗丁丏 = new System.Collections.Generic.List<三丈丟与丏丘丈丐万>();
        this.丁丟丌专三上丐丕丙 = new System.Collections.Generic.List<丌丄丈丕丘丄世且上>();
        this.丈丆丝丁丟与不丁万 = new System.Collections.Generic.List<System.Collections.Generic.List<三丅丁丗丗丝丂万且>>();
        this.丂丘专丆专三丒三丑 = new System.Collections.Generic.List<System.Int32>(capacity:  3);
    }
    private static WeaponManager()
    {
        System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
        if(val_1 != null)
        {
                bool val_2 = val_1.Add(item:  "laser_assistant");
        }
        else
        {
                bool val_3 = val_1.Add(item:  "laser_assistant");
        }
        
        bool val_4 = val_1.Add(item:  "last_christmas");
        if(val_1 != null)
        {
                bool val_5 = val_1.Add(item:  "dual_cryo_pistols");
        }
    
    }
    private System.Collections.Generic.List<三丅丁丗丗丝丂万且> 万专七丝丅东东丒丘(System.Collections.Generic.List<三丅丁丗丗丝丂万且> 丐三丞七丝丅不万丛)
    {
        return System.Linq.Enumerable.ToList<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丐三丞七丝丅不万丛, predicate:  new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  this, method:  System.Boolean WeaponManager::业丗丒丘不丂丌丌丗(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业))));
    }
    private bool 业丗丒丘不丂丌丌丗(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        null = null;
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛())) == false)
        {
                return true;
        }
        
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  丆丐七世世且丏丐业.业东丅东丌上丗丑不())) != null)
        {
                return true;
        }
        
        string val_6 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        return val_6.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_6);
    }
    private void 一丛与七专丂上丂丐()
    {
        this.三丒世丙丙丒丝丟且 = false;
    }
    private void 丂丏丄丛一丛丝且专(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        三丈丟与丏丘丈丐万 val_2 = this.丝丟丌丛丆丅上万丑(丛丄东丙业上丈丄且:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛());
    }
    private void 丗东丕丅丒下丈专万(三丅丁丗丗丝丂万且 东七上世万下丗丄丛)
    {
        int val_1 = 东七上世万下丗丄丛.业东丅东丌上丗丑不();
        bool val_2 = val_1.丟丁三不世丕丗丘东(丞世不丒下上上丝丑:  val_1);
    }

}
