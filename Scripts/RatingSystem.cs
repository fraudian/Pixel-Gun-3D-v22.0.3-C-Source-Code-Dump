using UnityEngine;
public sealed class RatingSystem : MonoBehaviour
{
    // Fields
    private static RatingSystem 丝业丆丁业三丈丟东;
    internal static readonly string[] 与丛丌与丂丒丟且丗;
    internal static readonly string[] 丌丆七丒下不东丑一;
    internal const string 丏丘丙七一不三丘三 = "Sep2018_RatingLocal";
    internal static string 东万一丅丏丝丗丂丞;
    internal static string 丁且且东丛丒丏业丕;
    internal const string 不丛不丈且丁丛专世 = "RatingPositiveLocal";
    internal Rilisoft.丝丑丂丛万丐丈丘且 丕丙丗上七丗专丐丈;
    internal bool 一下三丗七七丗丆下;
    private static System.Action 丟东丌七业丁世丞不;
    private static System.Action<int> 丑丝丟且丞不丏不业;
    internal const string 丄丆丞丛丆丞且丘丈 = "p_Leave_count";
    internal const string 丙七上丆丈丟丟丘丝 = "p_leave_time";
    private int 丂丐丗丈不万不丙丝;
    private long 丗丘丅三丄丁丝不丟;
    internal const string 七一专丘丑丁丘世丟 = "RatingSystem";
    internal const string 万丟丞三世下丏七丐 = "League";
    internal const string 且丆丟丄丝丏下丝万 = "Division";
    private PGCompany.丘丛丈与丑丌丑专丐 <丁丅丘业万与万丙且>k__BackingField;
    internal static bool 丑丛东丈丌且下与丂;
    internal static bool 丝七丘丝丒丞丝丆世;
    private static System.Collections.Generic.List<RatingSystem.丄丑丌丝丅丞丘丆一> 不万丝且业东世丈世;
    internal static System.Collections.Generic.List<int> 业且三丏业一丈七东;
    internal static int 七业丈丝万丆下丏七;
    
    // Properties
    internal static RatingSystem 丄丘七三上丕世丞业 { get; }
    internal static RatingSystem.RatingLeague 丄专丂三丑专丁丂丁 { get; }
    internal static RatingSystem.RatingLeague 东一与且世上丁丝一 { get; }
    internal int 下东丁东三丆上丘三 { get; }
    internal RatingSystem.RatingLeague 丞丄丕专三丁丙一上 { get; }
    internal int 丏丞丙丒世七丈丕丞 { get; }
    internal RatingSystem.丁上且上一丆丘与业 不丕丕丞丞三丂丅业 { get; }
    internal int 丅丝专万丘丆丐丆丟 { get; set; }
    internal PGCompany.丘丛丈与丑丌丑专丐 与丄丕一丗丙丕下丁 { get; set; }
    
    // Methods
    internal static RatingSystem 与一丅丝不丈业与丙()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(RatingSystem.且丆丟丄丝丏下丝万 == 0)
        {
                RatingSystem.下下丐丏与丈丄七东();
        }
        
        val_3 = null;
        val_3 = null;
        return (RatingSystem)RatingSystem.且丆丟丄丝丏下丝万;
    }
    internal static void 下下丐丏与丈丄七东()
    {
        var val_5;
        string val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        val_6 = RatingSystem.且丆丟丄丝丏下丝万;
        if(val_6 != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "RatingSystem");
        if(UnityEngine.Application.isPlaying != false)
        {
                UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        }
        
        val_7 = null;
        val_6 = val_2.AddComponent<RatingSystem>();
        val_7 = null;
        RatingSystem.且丆丟丄丝丏下丝万 = val_6;
    }
    internal static RatingSystem.RatingLeague 丒丐丁一丈丏丗丅东()
    {
        return 7;
    }
    internal static RatingSystem.RatingLeague 丒东丆丞七与丁东丒()
    {
        return 0;
    }
    internal int 丄专上业下丛丛东丁()
    {
        return 3000;
    }
    internal RatingSystem.RatingLeague 与丌丛七七与东下丏()
    {
        Progress.丛丞丗丈不专业丒不 val_1 = Progress.七七世万专丕丁上业.丘三丏且且专下丞丘();
        if(val_1 != null)
        {
                return val_1.丈三与世丟下丅丄专();
        }
        
        return val_1.丈三与世丟下丅丄专();
    }
    internal int 万与一丂丗丞一世丅()
    {
        Progress.丛丞丗丈不专业丒不 val_1 = Progress.七七世万专丕丁上业.丘三丏且且专下丞丘();
        if(val_1 != null)
        {
                return val_1.丏三世七东丒万丕丅();
        }
        
        return val_1.丏三世七东丒万丕丅();
    }
    internal RatingSystem.丁上且上一丆丘与业 丝丒丒七下与下不丑()
    {
        int val_2 = this.与丌丛七七与东下丏().万与一丂丗丞一世丅();
        val_0.丈丐丒丐丕丛东丑业 = 0;
        val_0.丗丛世世丙丝丌与丑 = 0;
        val_0.丙东与与万丌丟专丛 = 0;
        val_0.丈丘丙丛丗不七专丟 = 0;
    }
    internal int 三万丟丌万且丄丛万()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "RatingPositiveLocal")) == false)
        {
                return 0;
        }
        
        return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "RatingPositiveLocal", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    internal void 丑上丙上丟丈丑且丒(int 丙业与丙丗丝不丈东)
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "RatingPositiveLocal", 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    internal static void 丘世一丂丝世丏丆一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  RatingSystem.丟东丌七业丁世丞不, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(RatingSystem.丟东丌七业丁世丞不 != 1152921505122770984);
    
    }
    internal static void 不上丗东丞不丌丐世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  RatingSystem.丟东丌七业丁世丞不, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(RatingSystem.丟东丌七业丁世丞不 != 1152921505122770984);
    
    }
    internal static void 世上且丑丞万丗丐丄(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  RatingSystem.丑丝丟且丞不丏不业, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(RatingSystem.丑丝丟且丞不丏不业 != 1152921505122770992);
    
    }
    internal static void 丁丐丙三丁丄丄七世(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  RatingSystem.丑丝丟且丞不丏不业, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(RatingSystem.丑丝丟且丞不丏不业 != 1152921505122770992);
    
    }
    internal static void 丘丆一丌丁东世一丏(int 三丙专丁不丌丛七且)
    {
        var val_1;
        System.Action<System.Int32> val_2;
        val_1 = null;
        val_1 = null;
        val_2 = RatingSystem.丑丝丟且丞不丏不业;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = RatingSystem.丑丝丟且丞不丏不业;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke(obj:  三丙专丁不丌丛七且);
    }
    internal static int 丞一丌东丗丙世下丆(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        return 0;
    }
    private void 三丝丑一上丕与东丁(int 丈丐世下丞与丂专丏, bool 丞业一专不七三丁丘, bool 专且丙世丅专丕业丈)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丟丘七丛丁东丙丝下(丁丟与丈丛丝丒下丏:  丈丐世下丞与丂专丏, 丐专世与丆丌丒丆丁:  (专且丙世丅专丕业丈 != true) ? (1 + 1) : 1);
        if(GameConnect.丕上丐丄三上丝专万() != false)
        {
                Rilisoft.Singleton<TournamentController>.Instance.七七丂东丌世且丈丈();
        }
        
        string val_5 = System.String.Format(format:  "<color=yellow>Add {0} rating.</color>", arg0:  丈丐世下丞与丂专丏);
        UnityEngine.Debug.Log(message:  val_5);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "<color=yellow>I\'m in {0} league, division: {1}. Rating: {2}</color>", arg0:  val_5.与丌丛七七与东下丏().ToString(), arg1:  3, arg2:  3.万与一丂丗丞一世丅()));
    }
    internal int 一丈丒东丑专丒丅丘()
    {
        var val_21;
        var val_22;
        if((TournamentController.七东丕丌且丟丙丈下() != false) && ((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament")) != false))
        {
                Rilisoft.七丕丟丏三丈一丄世 val_3 = GameConnect.丑丌丛丈丅丅与不业();
            val_21 = this.且丘专三丙世丆丒不(上且丗一丏丏万丅丌:  val_3, 丙丑七万丆万丆且丌:  val_3.与丌丛七七与东下丏());
            bool val_7 = UnityEngine.Object.op_Inequality(x:  Rilisoft.Singleton<TournamentController>.Instance, y:  0);
            if((val_21 & 2147483648) == 0)
        {
                return (int)val_21;
        }
        
            if(val_7 == false)
        {
                return (int)val_21;
        }
        
            TournamentController val_9 = Rilisoft.Singleton<TournamentController>.Instance;
            val_22 = val_9;
            int val_11 = val_22.七丌专万专与丗丛一(丙丑七万丆万丆且丌:  val_9.与丌丛七七与东下丏());
            if(val_7.万与一丂丗丞一世丅() > val_11)
        {
                TournamentController val_13 = Rilisoft.Singleton<TournamentController>.Instance;
            val_22 = val_13;
            if((val_11.万与一丂丗丞一世丅() + val_21) >= (val_22.七丌专万专与丗丛一(丙丑七万丆万丆且丌:  val_13.与丌丛七七与东下丏())))
        {
                return (int)val_21;
        }
        
            TournamentController val_17 = Rilisoft.Singleton<TournamentController>.Instance;
            int val_19 = val_17.七丌专万专与丗丛一(丙丑七万丆万丆且丌:  val_17.与丌丛七七与东下丏());
            val_21 = val_19 - val_19.万与一丂丗丞一世丅();
            return (int)val_21;
        }
        
        }
        
        val_21 = 0;
        return (int)val_21;
    }
    internal RatingSystem.丁上且上一丆丘与业 丛一上丈世一丙丗世(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, int 且丒丛与丞世丙丕丌, bool 丑一丂丙丈丝丑丅丑, bool 丞业一专不七三丁丘 = False, bool 丛七丂丕一世不不丄 = False, bool 专且丙世丅专丕业丈 = False)
    {
        int val_2;
        RatingLeague val_3;
        var val_30;
        RatingLeague val_31;
        var val_32;
        var val_33;
        int val_34;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_35;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_36;
        var val_37;
        var val_38;
        var val_39;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        int val_45;
        丁上且上一丆丘与业 val_0;
        val_30 = 丛七丂丕一世不不丄;
        丁上且上一丆丘与业 val_1 = this.丝丒丒七下与下不丑();
        val_31 = this.与丌丛七七与东下丏();
        val_32 = 0;
        val_33 = null;
        val_34 = this.丐丏丛丂七业业七丁(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丙丑七万丆万丆且丌:  val_31, 且丒丛与丞世丙丕丌:  ((GameConnect.一与东丝万上三丆丏() != true) ? 3 : 5) + 且丒丛与丞世丙丕丌);
        val_33 = null;
        val_35 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_35 == null)
        {
            goto label_10;
        }
        
        val_35 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_35 == null)
        {
                val_35 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_10 = val_35.丌不丅不丞东万专专();
        if(val_10.HasValue.丙东专丂世丈丏丁丂() != 3)
        {
            goto label_14;
        }
        
        val_36 = 0;
        if((1380379560 & 1) != 0)
        {
            goto label_18;
        }
        
        label_14:
        val_37 = null;
        val_37 = null;
        val_36 = GameConnect.丈丝丂丐丟万丙丑丕;
        goto label_18;
        label_10:
        val_36 = 0;
        label_18:
        PGCompany.GameModeEvents.下与丛丒丙一世丟专 val_12 = new PGCompany.GameModeEvents.下与丛丒丙一世丟专(与不下三丈专丘丂世:  val_36);
        if(val_12.丙丂丐且丐丒丆与丞() != false)
        {
                val_38 = UnityEngine.Mathf.Clamp(value:  val_34, min:  0, max:  val_34);
        }
        
        if((val_38 & 2147483648) != 0)
        {
            goto label_23;
        }
        
        val_39 = null;
        val_39 = null;
        val_40 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_40 == null)
        {
            goto label_26;
        }
        
        val_40 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_40 == null)
        {
                val_40 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_15 = val_40.丌不丅不丞东万专专();
        if((val_15.HasValue.丙东专丂世丈丏丁丂() != 3) || ((1380379560 & 1) == 0))
        {
            goto label_31;
        }
        
        label_26:
        val_30 = 0;
        if(val_12 == null)
        {
            goto label_32;
        }
        
        label_45:
        val_41 = val_12.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  4, 世东上丕专丞丑专丄:  true, 专丂丑且丙七丈万丑:  false);
        goto label_33;
        label_31:
        val_42 = null;
        val_42 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕.丘一丒丕丟万丏一丟() != false)
        {
                val_43 = null;
            val_43 = null;
            val_31 = GameConnect.丈丝丂丐丟万丙丑丕.三业丂丞丕东下七丒();
        }
        else
        {
                val_31 = 0;
        }
        
        val_44 = null;
        val_44 = null;
        bool val_22 = val_30 & (~GameConnect.丈丝丂丐丟万丙丑丕.丘一丒丕丟万丏一丟());
        val_22 = val_31 | val_22;
        bool val_23 = (val_22 == true) ? 1 : 0;
        if(val_12 != null)
        {
            goto label_45;
        }
        
        label_32:
        val_41 = val_12.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  4, 世东上丕专丞丑专丄:  true, 专丂丑且丙七丈万丑:  val_23);
        label_33:
        int val_25 = val_12.丈丈下丞且丙丛丒丒(丁丅丈丌丟世丗丗丟:  13, 专不三上丏专丄且丞:  0, 世东上丕专丞丑专丄:  true, 丑丆世丟万丁丆上丛:  val_23);
        val_45 = val_25 + (val_41 * val_38);
        label_23:
        val_25.三丝丑一上丕与东丁(丈丐世下丞与丂专丏:  val_45, 丞业一专不七三丁丘:  false, 专且丙世丅专丕业丈:  专且丙世丅专丕业丈);
        int val_28 = val_25.与丌丛七七与东下丏().万与一丂丗丞一世丅();
        val_0.丗丛世世丙丝丌与丑 = val_2;
        val_0.丈丘丙丛丗不七专丟 = val_3;
        return val_0;
    }
    internal static bool 与且丙丒丂丗世丂世()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  "p_leave_time", defaultValue:  "-1");
        if((val_1.Equals(value:  "-1")) != true)
        {
                bool val_4 = System.Int64.TryParse(s:  val_1, result: out  0);
        }
        
        System.DateTime val_6 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  0);
        System.DateTime val_7 = val_6.dateData.Date;
        System.DateTime val_8 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  专七专下且专三一且.上且一丈丐三丄一丆());
        System.DateTime val_9 = val_8.dateData.Date;
        return (bool)(1380536672 != 0) ? 1 : 0;
    }
    internal void 丏丁丐丅丑丙与丗不()
    {
        int val_15;
        string val_16;
        var val_17;
        int val_18;
        var val_19;
        if((UnityEngine.PlayerPrefs.GetInt(key:  "leave_from_duel_penalty")) != 0)
        {
                return;
        }
        
        val_16 = "p_Leave_count";
        val_17 = 1152921505122766848;
        val_18 = UnityEngine.PlayerPrefs.GetInt(key:  val_16, defaultValue:  0);
        if(RatingSystem.与且丙丒丂丗世丂世() != false)
        {
                val_18 = 0;
        }
        
        this.丂丐丗丈不万不丙丝 = val_18;
        this.丗丘丅三丄丁丝不丟 = 0;
        val_19 = null;
        val_19 = null;
        if(val_18 >= RatingSystem.七业丈丝万丆下丏七)
        {
                丁上且上一丆丘与业 val_4 = 丝丒丒七下与下不丑();
            int val_7 = this.一丈丒东丑专丒丅丘();
            val_7.三丝丑一上丕与东丁(丈丐世下丞与丂专丏:  val_7, 丞业一专不七三丁丘:  false, 专且丙世丅专丕业丈:  true);
            RatingLeague val_8 = val_7.与丌丛七七与东下丏();
            val_17 = val_8;
            int val_9 = val_8.万与一丂丗丞一世丅();
            if((1380673168 & 2147483648) != 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "leave_from_duel_penalty", value:  1380673168);
            UnityEngine.PlayerPrefs.Save();
        }
        
        }
        
        val_15 = val_18 + 1;
        UnityEngine.PlayerPrefs.SetInt(key:  "p_Leave_count", value:  val_15);
        UnityEngine.PlayerPrefs.SetString(key:  "p_leave_time", value:  专七专下且专三一且.上且一丈丐三丄一丆().ToString());
    }
    internal void 丁丞专三丑丒下上丂()
    {
        if(this.丂丐丗丈不万不丙丝 == 1)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  "p_Leave_count", value:  this.丂丐丗丈不万不丙丝);
        UnityEngine.PlayerPrefs.SetString(key:  "p_leave_time", value:  this.丗丘丅三丄丁丝不丟.ToString());
        this.丂丐丗丈不万不丙丝 = 0;
        this.专丄丂丈丛丄丒丙丗();
    }
    internal int 万业丘丟丏业且与上()
    {
        var val_18;
        int val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_18 = "-1";
        val_19 = UnityEngine.PlayerPrefs.GetInt(key:  "p_Leave_count", defaultValue:  0);
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  "p_leave_time", defaultValue:  "-1");
        long val_4 = 0;
        if((val_2.Equals(value:  "-1")) != true)
        {
                bool val_5 = System.Int64.TryParse(s:  val_2, result: out  val_4);
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() != 1)
        {
                var val_18 = val_4;
            val_18 = FriendsController.丝丗专上三不丄丑丑() - val_18;
            if(val_18 >= 86401)
        {
                val_19 = 0;
        }
        
        }
        
        long val_8 = FriendsController.丝丗专上三不丄丑丑();
        if(val_8 == 1)
        {
                return (int)System.Math.Max(val1:  0, val2:  (val_23 - val_19) + val_18);
        }
        
        val_19 = val_19 - 1;
        val_20 = 0;
        if(val_8 < 1)
        {
                return (int)System.Math.Max(val1:  0, val2:  (val_23 - val_19) + val_18);
        }
        
        if(0 == 1)
        {
                return (int)System.Math.Max(val1:  0, val2:  (val_23 - val_19) + val_18);
        }
        
        val_21 = null;
        val_21 = null;
        if(RatingSystem.业且三丏业一丈七东.Count >= 1)
        {
                val_22 = null;
            val_22 = null;
            val_23 = (long)RatingSystem.业且三丏业一丈七东.Item[UnityEngine.Mathf.Clamp(value:  val_19, min:  0, max:  RatingSystem.业且三丏业一丈七东.Count - 1)];
        }
        else
        {
                val_23 = 0;
        }
        
        val_18 = 0;
        val_19 = FriendsController.丝丗专上三不丄丑丑();
        return (int)System.Math.Max(val1:  0, val2:  (val_23 - val_19) + val_18);
    }
    internal void 丗不丈丕不上丝丌与()
    {
        if((UnityEngine.PlayerPrefs.GetInt(key:  "leave_from_duel_penalty")) == 0)
        {
                return;
        }
        
        this.专丄丂丈丛丄丒丙丗();
    }
    internal void 专丄丂丈丛丄丒丙丗()
    {
        if((this.丕丙丗上七丗专丐丈 & 2147483648) == 0)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丟丘七丛丁东丙丝下(丁丟与丈丛丝丒下丏:  -this.丕丙丗上七丗专丐丈, 丐专世与丆丌丒丆丁:  3);
        if(GameConnect.丕上丐丄三上丝专万() != false)
        {
                Rilisoft.Singleton<TournamentController>.Instance.七七丂东丌世且丈丈();
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  "leave_from_duel_penalty", value:  0);
    }
    internal bool 且与丝东一丌下丁一()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = this.丕丙丗上七丗专丐丈;
        val_1 = val_1 >> 31;
        return (bool)val_1;
    }
    internal void 丗不东万丘专丑丆丕()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = RatingSystem.丟东丌七业丁世丞不;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = RatingSystem.丟东丌七业丁世丞不;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    internal PGCompany.丘丛丈与丑丌丑专丐 与丕丅与三七业丘丛()
    {
        return (PGCompany.丘丛丈与丑丌丑专丐)this.<丁丅丘业万与万丙且>k__BackingField;
    }
    private void 丅丝万万丛丁下一丘(PGCompany.丘丛丈与丑丌丑专丐 丙业与丙丗丝不丈东)
    {
        this.<丁丅丘业万与万丙且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丐丏丛丂七业业七丁(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, RatingSystem.RatingLeague 丙丑七万丆万丆且丌, int 且丒丛与丞世丙丕丌)
    {
        if(TournamentController.七东丕丌且丟丙丈下() == false)
        {
                return 0;
        }
        
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament")) == false)
        {
                return 0;
        }
        
        if((this.<丁丅丘业万与万丙且>k__BackingField) == null)
        {
                return 0;
        }
        
        return this.<丁丅丘业万与万丙且>k__BackingField.丛丗七三丄丑丂丗丁(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌, 且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
    }
    internal int 且丘专三丙世丆丒不(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        if(TournamentController.七东丕丌且丟丙丈下() == false)
        {
                return 0;
        }
        
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament")) == false)
        {
                return 0;
        }
        
        if((this.<丁丅丘业万与万丙且>k__BackingField) == null)
        {
                return 0;
        }
        
        return this.<丁丅丘业万与万丙且>k__BackingField.丝专与丆下万七丗与(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌);
    }
    private void Awake()
    {
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void RatingSystem::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        this.丟丈上丛丙丕业丁丐();
    }
    private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 43)
        {
                return;
        }
        
        this.丟丈上丛丙丕业丁丐();
    }
    internal static int 丛丂与丄三下三万万(int 丛丟下丅丗丁不万丆)
    {
        var val_9;
        var val_24;
        System.Collections.Generic.List<丄丑丌丝丅丞丘丆一> val_25;
        var val_26;
        int val_1 = 丛丟下丅丗丁不万丆 - 1;
        if()
        {
            goto label_1;
        }
        
        System.DateTime val_2 = System.DateTime.UtcNow;
        System.DateTime val_3 = System.DateTime.UtcNow;
        System.TimeSpan val_4 = System.TimeSpan.FromDays(value:  60);
        System.DateTime val_5 = System.DateTime.op_Subtraction(d:  new System.DateTime() {dateData = val_3.dateData}, t:  new System.TimeSpan() {_ticks = val_4._ticks});
        decimal val_7 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().丘丁丈万丗丑丈东七(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_5.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_2.dateData});
        val_24 = null;
        val_24 = null;
        val_25 = RatingSystem.不万丝且业东世丈世;
        List.Enumerator<T> val_8 = val_25.GetEnumerator();
        label_18:
        if((1382302160 & 1) == 0)
        {
            goto label_12;
        }
        
        ConfiguredValueTaskAwaiter val_11 = val_9.GetAwaiter();
        val_25 = val_11._value._token;
        decimal val_12 = System.Decimal.op_Implicit(value:  val_11._value._obj);
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid}, d2:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid})) == false)
        {
            goto label_18;
        }
        
        decimal val_15 = System.Decimal.op_Implicit(value:  val_11._value._obj >> 32);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.mid}, d2:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid})) == false)
        {
            goto label_18;
        }
        
        if(val_25 == 0)
        {
            goto label_19;
        }
        
        if(val_25.Count != 0)
        {
            goto label_20;
        }
        
        label_12:
        val_26 = 0;
        label_27:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)val_26;
        label_19:
        label_20:
        if(val_25.Count >= 丛丟下丅丗丁不万丆)
        {
            goto label_27;
        }
        
        int val_21 = val_25.Item[val_25.Count - 1];
        goto label_27;
        label_1:
        val_26 = 0;
        return (int)val_26;
    }
    internal void 丟丈上丛丙丕业丁丐()
    {
        this.<丁丅丘业万与万丙且>k__BackingField = 0;
        if((System.String.IsNullOrEmpty(value:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  43))) == true)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        this.<丁丅丘业万与万丙且>k__BackingField = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
    }
    public RatingSystem()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = new Rilisoft.丝丑丂丛万丐丈丘且(丑三不丌丌丆丞丆丐:  210674148);
        this.一下三丗七七丗丆下 = true;
        this.丂丐丗丈不万不丙丝 = 0;
        this.丕丙丗上七丗专丐丈 = val_1.七丄不丐丗三丝丑一;
        mem[1152921536054190160] = val_1.上万三丆专丏丒丗业;
        this.丗丘丅三丄丁丝不丟 = 0;
    }
    private static RatingSystem()
    {
        string[] val_1 = new string[3];
        val_1[0] = "III";
        val_1[1] = "II";
        val_1[2] = "I";
        RatingSystem.与丛丌与丂丒丟且丗 = val_1;
        string[] val_2 = new string[7];
        val_2[0] = "Key_1953";
        val_2[1] = "Key_1954";
        val_2[2] = "Key_1955";
        val_2[3] = "Key_1956";
        val_2[4] = "Key_1957";
        val_2[5] = "Key_1958";
        val_2[6] = "Key_6524";
        RatingSystem.丌丆七丒下不东丑一 = val_2;
        RatingSystem.东万一丅丏丝丗丂丞 = "LeaguePositive_After30Nov2018";
        RatingSystem.丁且且东丛丒丏业丕 = "LeagueNegative_After30Nov2018";
        RatingSystem.丑丛东丈丌且下与丂 = false;
        RatingSystem.丝七丘丝丒丞丝丆世 = false;
        RatingSystem.不万丝且业东世丈世 = new System.Collections.Generic.List<丄丑丌丝丅丞丘丆一>();
        RatingSystem.业且三丏业一丈七东 = new System.Collections.Generic.List<System.Int32>();
        RatingSystem.七业丈丝万丆下丏七 = 0;
    }

}
