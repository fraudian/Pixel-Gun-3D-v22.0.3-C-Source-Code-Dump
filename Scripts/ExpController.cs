using UnityEngine;
public sealed class ExpController : MonoBehaviour
{
    // Fields
    private static System.Action 丘下与丈三丅东七丐;
    private static System.Action 下万七丒东丁丈丗下;
    private static System.Action 丐不丑丛丟丌丅东丕;
    internal Rilisoft.BankBannersHolder bannersHolder;
    private ExpView _experienceView;
    private Rilisoft.RankIndicatorGuiElement _rankIndicator;
    private UnityEngine.GameObject _expProgressContainer;
    private UnityEngine.GameObject _raitingProgressContainer;
    public const int MaxLobbyLevel = 3;
    private bool <丙丁丙七业丅丅丞丆>k__BackingField;
    private bool 且东丌丞丒丟且丙丄;
    public static readonly int[] LevelsForTiers;
    private bool <东丆丟丏世丗七丂下>k__BackingField;
    internal bool 丘一专丛丅丗专丅丒;
    private float 丘一丘七万丘不丟业;
    private static ExpController 丝业丆丁业三丈丟东;
    private bool 丝丟丆业且三丄丕丁;
    
    // Properties
    internal bool 丅不不丟丙世且三丞 { get; }
    internal UnityEngine.Camera 丝业专丗丛三上且东 { get; }
    internal bool 上一丂丄丏东丁丛丘 { get; set; }
    internal static ExpController 丆丕丝丒不丙且丐丗 { get; }
    internal static int 丘丟丙业丐丐上一丆 { get; }
    internal bool 丁丐世丈世丐丘丏丈 { get; set; }
    internal bool 不丁丄丌丒上丅丂丟 { get; set; }
    internal bool 且丘三丂且丑丆丁丈 { get; set; }
    internal int 丕丞下上下不丄丈丝 { get; }
    internal int 三专丞丄东丂丟七与 { get; }
    
    // Methods
    internal static void 一丈与丒丘下七丛丗(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  ExpController.MaxLobbyLevel, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丄丂一丛丅丄丄丘且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  ExpController.MaxLobbyLevel, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丈丂东丘丙世不七丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ExpController.下万七丒东丁丈丗下, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ExpController.下万七丒东丁丈丗下 != 1152921505175113736);
    
    }
    internal static void 丛丘丅与丞丁万不丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ExpController.下万七丒东丁丈丗下, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ExpController.下万七丒东丁丈丗下 != 1152921505175113736);
    
    }
    internal static void 上业业丝丑丆三与丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ExpController.丐不丑丛丟丌丅东丕, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ExpController.丐不丑丛丟丌丅东丕 != 1152921505175113744);
    
    }
    internal static void 丟丅七丄下丙下丑丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ExpController.丐不丑丛丟丌丅东丕, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ExpController.丐不丑丛丟丌丅东丕 != 1152921505175113744);
    
    }
    internal bool 丐丛丁丅丟丆丟业丂()
    {
        return ProgressRoadView.IsActive;
    }
    internal UnityEngine.Camera 丄下丆丗丞丕丁丟丙()
    {
        ExpView val_2;
        UnityEngine.Camera val_3;
        val_2 = this;
        val_3 = 0;
        if(this._experienceView == 0)
        {
                return val_3;
        }
        
        val_2 = this._experienceView;
        val_3 = this._experienceView.experienceCamera;
        return val_3;
    }
    internal bool 业丁一丕丛丏上丄丟()
    {
        if(this._experienceView == 0)
        {
                return false;
        }
        
        if(this._experienceView != null)
        {
                return this._experienceView.七丂下丗丏与丕丂下();
        }
        
        return this._experienceView.七丂下丗丏与丕丂下();
    }
    internal void 丞丝丏丈与一下专下(bool 丙业与丙丗丝不丈东)
    {
        if(this._experienceView == 0)
        {
                return;
        }
        
        this._experienceView.上专丌专丁丏且丆一(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    internal static int 万上一丝丆且七丅丅()
    {
        if(ExpController.丑七不且上丗丁一世() == 0)
        {
                return ExpController.东东丒丈丛丈七丘不();
        }
        
        ExpController val_3 = ExpController.丑七不且上丗丁一世();
        if(val_3 != null)
        {
                return val_3.丆丝丁丞丙上万三一();
        }
        
        return val_3.丆丝丁丞丙上万三一();
    }
    internal static ExpController 丑七不且上丗丁一世()
    {
        null = null;
        return (ExpController)ExpController.丝业丆丁业三丈丟东;
    }
    internal static int 与丁丆丂丒丌丝且丅()
    {
        return 3;
    }
    internal bool 下不上丌丘七世丘丙()
    {
        return (bool)this.<丙丁丙七业丅丅丞丆>k__BackingField;
    }
    private void 丈与丕丝七万丒丅上(bool 丙业与丙丗丝不丈东)
    {
        this.<丙丁丙七业丅丅丞丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 上丙丆不丂丂丄一丂()
    {
        if(this._experienceView == 0)
        {
                return false;
        }
        
        if(this._experienceView.interfaceHolder == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_3 = this._experienceView.interfaceHolder.gameObject;
        if(val_3 != null)
        {
                return val_3.activeInHierarchy;
        }
        
        return val_3.activeInHierarchy;
    }
    internal void 丟丁专丁丈丕丁一丙(bool 丙业与丙丗丝不丈东)
    {
        this.世丗七丙丙业下丆与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 世丗七丙丙业下丆与(bool 丙业与丙丗丝不丈东)
    {
        ExpView val_13;
        if(丙业与丙丗丝不丈东 != false)
        {
                val_13 = this._experienceView;
            if(val_13 != 0)
        {
                val_13 = this._expProgressContainer;
            bool val_3 = ConnectScene.丈丘丂丙不丛业丟三();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  val_3);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._raitingProgressContainer, 丏业丟一东丂东丘丛:  val_3);
        }
        
        }
        
        if(this.上丙丆不丂丂丄一丂() ^ 丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        val_13 = this._experienceView;
        if(val_13 == 0)
        {
                return;
        }
        
        val_13 = this._experienceView.interfaceHolder;
        if(val_13 == 0)
        {
                return;
        }
        
        val_13 = this._experienceView.interfaceHolder.gameObject;
        val_13.SetActive(value:  丙业与丙丗丝不丈东);
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        if(this._experienceView.experienceCamera == 0)
        {
                return;
        }
        
        this = this._experienceView.experienceCamera.GetComponent<UnityEngine.AudioListener>();
        if(this == 0)
        {
                return;
        }
        
        this.enabled = false;
    }
    public void HandleContinueButton(UnityEngine.GameObject 世丞丑上丅与世丁世)
    {
        var val_8;
        WeaponManager val_9;
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        var val_15;
        var val_16;
        val_8 = null;
        val_8 = null;
        val_9 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_9 != 0)
        {
                val_10 = null;
            val_10 = null;
            val_11 = null;
            val_9 = WeaponManager.丟丗丄业丘丗业丗七;
            val_11 = null;
            val_12 = UnityEngine.Application.loadedLevelName;
            if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  val_12)) != false)
        {
                val_13 = null;
            val_13 = null;
            val_12 = UnityEngine.Application.loadedLevelName;
            FilterMaps val_5 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[val_12];
        }
        else
        {
                val_15 = null;
            val_15 = null;
        }
        
            val_9.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐());
        }
        
        if((this.且东丌丞丒丟且丙丄 != true) && (ExperienceController.丞丞丘业东丙丏七丌() == 2))
        {
                val_9 = 1152921505037303808;
            val_16 = null;
            val_16 = null;
            if(BalanceController.丑丌业丌丁丕七丌业 != false)
        {
                this.且东丌丞丒丟且丙丄 = true;
            val_16 = null;
            this._experienceView.不一丒丟丄丂下丅七(业丈丙丌上丛与丏丞:  BalanceController.丕万丅且丐丙丝不丐, 丑丒下三业丗丘丛丁:  BalanceController.专丆丟丙丕三七世万);
            return;
        }
        
        }
        
        this.且东丌丞丒丟且丙丄 = false;
        ExpController.丏丂丛一与丄世上丒(世丞丑上丅与世丁世:  世丞丑上丅与世丁世);
    }
    public void HandleShopButtonFromTierPanel(UnityEngine.GameObject 世丞丑上丅与世丁世)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丁且丛丆上丒且丗丆(世丞丑上丅与世丁世:  世丞丑上丅与世丁世));
    }
    public void HandleNewAvailableItem(UnityEngine.GameObject 世丞丑上丅与世丁世, Rilisoft.NewAvailableItemInShop 丘丌丂下上丆丞丈丌)
    {
        var val_21;
        object val_22;
        string val_24;
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(GameConnect.世丐丄三三上丅七三() == true)
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
        
        if(GameConnect.与丈丘丈上丌丝丝丛() == true)
        {
                return;
        }
        
        if(丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)
        {
                return;
        }
        
        if(ExpController.丕丟丛丈丄丆世丑与() == 0)
        {
            goto label_65;
        }
        
        bool val_9 = UnityEngine.Object.op_Inequality(x:  丘丌丂下上丆丞丈丌, y:  0);
        if((val_9 == false) || (丘丌丂下上丆丞丈丌._tag == null))
        {
            goto label_34;
        }
        
        三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丘丌丂下上丆丞丈丌._tag);
        if(val_10 != null)
        {
                if((val_10.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  ExpController.丕丟丛丈丄丆世丑与())) == false)
        {
            goto label_34;
        }
        
        }
        
        label_65:
        val_21 = null;
        val_21 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
            goto label_39;
        }
        
        val_22 = "ShopNGUIController.sharedShop == null";
        goto label_42;
        label_34:
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  val_9.丁且丛丆上丒且丗丆(世丞丑上丅与世丁世:  世丞丑上丅与世丁世));
        return;
        label_39:
        if(丘丌丂下上丆丞丈丌 != 0)
        {
            goto label_45;
        }
        
        val_22 = "itemInfo == null";
        label_42:
        UnityEngine.Debug.LogWarning(message:  val_22);
        System.Collections.IEnumerator val_17 = 丁且丛丆上丒且丗丆(世丞丑上丅与世丁世:  世丞丑上丅与世丁世);
        return;
        label_45:
        val_24 = 丘丌丂下上丆丞丈丌._tag;
        if(val_24 == null)
        {
                val_24 = System.String.alignConst;
        }
        
        System.Collections.IEnumerator val_18 = this.丌丕丕丅丄专与万且(世丞丑上丅与世丁世:  世丞丑上丅与世丁世, 丕丁下丌不万丅丞丛:  val_24, 七丆丒与丗丌丄且丂:  丘丌丂下上丆丞丈丌.category);
    }
    internal static FilterMaps 丕丟丛丈丄丆世丑与()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  UnityEngine.Application.loadedLevelName)) != false)
        {
                val_5 = null;
            val_5 = null;
            if(与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑 != null)
        {
                return 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[UnityEngine.Application.loadedLevelName];
        }
        
            return 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[UnityEngine.Application.loadedLevelName];
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                return WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐();
        }
        
        return WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐();
    }
    private System.Collections.IEnumerator 丁且丛丆上丒且丗丆(UnityEngine.GameObject 世丞丑上丅与世丁世)
    {
        .世丞丑上丅与世丁世 = 世丞丑上丅与世丁世;
        return (System.Collections.IEnumerator)new ExpController.丟三丞丅丌丆丟丒与(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator 丌丕丕丅丄专与万且(UnityEngine.GameObject 世丞丑上丅与世丁世, string 丕丁下丌不万丅丞丛, CategoryNames 七丆丒与丗丌丄且丂)
    {
        ExpController.丌丞丞丙丂丏丏七丄 val_1 = new ExpController.丌丞丞丙丂丏丏七丄(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .世丞丑上丅与世丁世 = 世丞丑上丅与世丁世;
            .丕丁下丌不万丅丞丛 = 丕丁下丌不万丅丞丛;
        }
        else
        {
                mem[48] = 世丞丑上丅与世丁世;
            mem[32] = 丕丁下丌不万丅丞丛;
        }
        
        .七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static int 丐丈丒丈上业与丅丆(int 丝下三丆丅丕丐丒且)
    {
        System.Int32[] val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_2 = 丝下三丆丅丕丐丒且;
        label_9:
        val_3 = null;
        val_3 = null;
        if(ExpController.LevelsForTiers == null)
        {
                val_3 = null;
        }
        
        int val_4 = ExpController.LevelsForTiers.Length;
        val_4 = val_4 - 1;
        if((0 + 1) >= val_4)
        {
            goto label_4;
        }
        
        val_4 = null;
        var val_2 = 0 + 2;
        System.Int32[] val_3 = ExpController.LevelsForTiers + (((long)(int)((0 + 2))) << 2);
        val_5 = 0 + 1;
        if(((ExpController.LevelsForTiers + ((long)(int)((0 + 2))) << 2) + 32) <= val_2)
        {
            goto label_9;
        }
        
        return (int)val_5;
        label_4:
        val_6 = null;
        val_2 = ExpController.LevelsForTiers;
        val_5 = ExpController.LevelsForTiers.Length - 1;
        return (int)val_5;
    }
    internal static bool 丕丈丆丈丙上丟丛专(int 业万上丆丐丞且丒七, out int 丄上七业丒与丙三下, out int 丅丗一专丕丗丌三丑)
    {
        System.Int32[] val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = 1152921537192508368;
        丄上七业丒与丙三下 = 0;
        丅丗一专丕丗丌三丑 = 0;
        if((业万上丆丐丞且丒七 & 2147483648) != 0)
        {
            goto label_1;
        }
        
        val_5 = null;
        val_5 = null;
        System.Int32[] val_1 = ExpController.LevelsForTiers + (((long)(int)(业万上丆丐丞且丒七)) << 2);
        丄上七业丒与丙三下 = (ExpController.LevelsForTiers + ((long)(int)(业万上丆丐丞且丒七)) << 2) + 32;
        val_4 = ExpController.LevelsForTiers;
        int val_4 = ExpController.LevelsForTiers.Length;
        val_4 = val_4 - 1;
        if(val_4 <= 业万上丆丐丞且丒七)
        {
            goto label_7;
        }
        
        val_6 = null;
        val_6 = null;
        val_4 = ExpController.LevelsForTiers;
        int val_2 = 业万上丆丐丞且丒七 + 1;
        System.Int32[] val_3 = val_4 + (((long)(int)((业万上丆丐丞且丒七 + 1))) << 2);
        val_7 = ((ExpController.LevelsForTiers + ((long)(int)((业万上丆丐丞且丒七 + 1))) << 2) + 32) - 1;
        goto label_12;
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_7:
        val_7 = 65;
        label_12:
        val_8 = 1;
        丅丗一专丕丗丌三丑 = 65;
        return (bool)val_8;
    }
    internal bool 丆丝丅丗世丞丟下且()
    {
        return (bool)this.<东丆丟丏世丗七丂下>k__BackingField;
    }
    private void 三丆一丝世上丛丛丄(bool 丙业与丙丗丝不丈东)
    {
        this.<东丆丟丏世丗七丂下>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static int 东东丒丈丛丈七丘不()
    {
        return ExpController.丐丈丒丈上业与丅丆(丝下三丆丅丕丐丒且:  ExperienceController.丕世丆丘业丁不丛不());
    }
    internal int 丆丝丁丞丙上万三一()
    {
        null = null;
        if(ExperienceController.sharedController == 0)
        {
                return 0;
        }
        
        return ExpController.丐丈丒丈上业与丅丆(丝下三丆丅丕丐丒且:  ExperienceController.丞丞丘业东丙丏七丌());
    }
    private void 丗丒丂丕丟东丟丙不(string 不且一丌丘丈丄东丂, int 七丐一丙下丌丙丞丝, int 三东丈丝丂万丒丅丒, int 与丑世丞丞七丟丆下, UnityEngine.AudioClip 丗丈丈东世不丛万一, UnityEngine.AudioClip 世不丑丘丞丑丘丄与, UnityEngine.AudioClip 丂不丟丂丂丗一丝丒)
    {
        var val_26;
        int val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        int val_34;
        var val_35;
        var val_36;
        var val_37;
        UnityEngine.AudioClip val_38;
        var val_39;
        val_26 = 世不丑丘丞丑丘丄与;
        val_27 = 与丑世丞丞七丟丆下;
        int val_26 = 七丐一丙下丌丙丞丝;
        if(val_27 >= 1)
        {
                val_28 = ProgressRoad.丁丒丛丆与七丟丗丙.丑七不且上丗丁一世().丗丐丛与丌丏与与专(上丕丈丞丌丘丅不与:  ExperienceController.丂丂下丑且下丌丝东() - val_27);
            if(val_28 != (ProgressRoad.丁丒丛丆与七丟丗丙.丑七不且上丗丁一世().丗丐丛与丌丏与与专(上丕丈丞丌丘丅不与:  ExperienceController.丂丂下丑且下丌丝东())))
        {
                this.丘一专丛丅丗专丅丒 = true;
            val_28 = ExperienceController.丂丂下丑且下丌丝东();
            ProgressRoad.丁丒丛丆与七丟丗丙.丄丄业世业丈丒丁万(丂世且丙丅丘不七丑:  val_28 - val_27, 丏丆丅且上丅上丌丘:  ExperienceController.丂丂下丑且下丌丝东(), 丘丒丅三丞丞丛丛丌:  this.bannersHolder);
            this.丘一专丛丅丗专丅丒 = false;
        }
        
            ExpController.不丟东丆丘丐东东丆(七丐一丙下丌丙丞丝:  val_26, 三东丈丝丂万丒丅丒:  三东丈丝丂万丒丅丒, 丐专丙丝丕丅丄丌丅:  val_27);
            return;
        }
        
        if(this._experienceView == 0)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        val_27 = val_27 + 三东丈丝丂万丒丅丒;
        if(val_27 < (ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  val_26)))
        {
                return;
        }
        
        if(丂不丟丂丂丗一丝丒 != 0)
        {
                val_31 = null;
            val_31 = null;
        }
        
        Rilisoft.Singleton<PGCompany.ModulesController>.Instance.世丁丒丅丝丂七专丏();
        if(val_26 <= 63)
        {
            goto label_29;
        }
        
        val_32 = null;
        if(val_26 != 64)
        {
            goto label_30;
        }
        
        val_33 = null;
        int val_19 = ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  65);
        val_34 = 65;
        int val_20 = ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  65);
        val_35 = 65;
        val_36 = 1;
        goto label_35;
        label_29:
        val_37 = null;
        val_26 = val_26 + 1;
        val_37 = null;
        val_34 = val_26;
        int val_21 = ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  val_34);
        val_36 = 1;
        val_35 = val_26;
        label_35:
        val_38 = ((System.Array.IndexOf<System.Int32>(array:  ExpController.LevelsForTiers, value:  val_26 + 1)) < 1) ? (val_26) : 丂不丟丂丂丗一丝丒;
        goto label_39;
        label_30:
        val_39 = null;
        int val_22 = ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  65);
        val_34 = 65;
        int val_23 = ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  65);
        val_35 = 65;
        val_36 = 0;
        val_38 = 丗丈丈东世不丛万一;
        label_39:
        UnityEngine.Coroutine val_25 = this.StartCoroutine(routine:  this.一东丌丕丗丆且丅七(不且一丌丘丈丄东丂:  65, 丑丛丌丟丝丆丌七上:  65, 世与丙七且丑七与丙:  三东丈丝丂万丒丅丒, 一世上丗丟丞丆万丗:  与丑世丞丞七丟丆下, 丛丏与专丙丄七三丞:  false, 东世丑世丛丞不专丕:  val_38));
    }
    private static void 不丟东丆丘丐东东丆(int 七丐一丙下丌丙丞丝, int 三东丈丝丂万丒丅丒, int 丐专丙丝丕丅丄丌丅)
    {
        var val_10;
        int val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        System.Action<System.String> val_17;
        var val_18;
        System.Action<System.String> val_20;
        val_10 = 丐专丙丝丕丅丄丌丅;
        val_11 = 七丐一丙下丌丙丞丝;
        val_12 = null;
        val_12 = null;
        if((val_10 + 三东丈丝丂万丒丅丒) < (ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  val_11)))
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        int val_4 = System.Array.BinarySearch<System.Int32>(array:  ExpController.LevelsForTiers, value:  ExperienceController.丞丞丘业东丙丏七丌());
        if((val_4 & 2147483648) != 0)
        {
            goto label_13;
        }
        
        val_14 = null;
        val_14 = null;
        if(val_4 >= ExpController.LevelsForTiers.Length)
        {
            goto label_13;
        }
        
        丆丞丐三与丞专丈丌.丘丝上丞丞丐丑丄丁();
        System.Collections.Generic.List<System.String> val_5 = 丁下万丟且丟丛下业.丑丐丝丕不丒丛丗丌(业万上丆丐丞且丒七:  val_4);
        val_15 = null;
        val_15 = null;
        val_17 = ExpController.<>c.<>9__54_1;
        if(val_17 == null)
        {
            goto label_20;
        }
        
        if(val_5 != null)
        {
            goto label_25;
        }
        
        goto label_22;
        label_20:
        val_17 = null;
        val_17 = new System.Action<System.String>(object:  ExpController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ExpController.<>c::丁丏万东丟七丕下丞(string 三丟东丕丄丄下下丑));
        ExpController.<>c.<>9__54_1 = val_17;
        if(val_5 != null)
        {
            goto label_25;
        }
        
        label_22:
        label_25:
        val_5.ForEach(action:  null);
        label_13:
        val_10 = WeaponManager.一丙丂下丆七丁丙丟(丈丘丝一丗下丈丐不:  ExperienceController.丞丞丘业东丙丏七丌());
        val_18 = null;
        val_18 = null;
        val_20 = ExpController.<>c.<>9__54_0;
        if(val_20 == null)
        {
            goto label_32;
        }
        
        if(val_10 != null)
        {
            goto label_37;
        }
        
        goto label_34;
        label_32:
        val_20 = null;
        val_20 = new System.Action<System.String>(object:  ExpController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ExpController.<>c::与丟丕丅丄专丙丘不(string 三丟东丕丄丄下下丑));
        ExpController.<>c.<>9__54_0 = val_20;
        if(val_10 != null)
        {
            goto label_37;
        }
        
        label_34:
        label_37:
        val_10.ForEach(action:  null);
    }
    internal bool 丙上世与丁丙丘丞丗(UnityEngine.Camera 丁丂专业丁丅丅丈丙)
    {
        ExpView val_3 = this._experienceView;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_3 = this._experienceView.experienceCamera;
        if(val_3 == 0)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Equality(x:  this._experienceView.experienceCamera, y:  丁丂专业丁丅丅丈丙);
    }
    internal int 丙东专丂世丈丏丁丂()
    {
        return UnityEngine.Mathf.Clamp(value:  ExperienceController.丞丞丘业东丙丏七丌(), min:  1, max:  65);
    }
    private string 丞且丐丈且丗东业丏(string 与丕丅丈不丟丁丗丛)
    {
        return (string)与丕丅丈不丟丁丗丛;
    }
    internal void 下丌丁丘不丘丐丁丆()
    {
        int val_37;
        string val_38;
        var val_39;
        UnityEngine.AndroidJavaClass val_40;
        string val_41;
        var val_42;
        val_37 = this;
        val_38 = "";
        val_39 = 1152921504618561536;
        System.Byte[] val_2 = System.Convert.FromBase64String(s:  "Y29tLnVuaXR5M2QucGxheWVyLlVuaXR5UGxheWVy");
        val_40 = new UnityEngine.AndroidJavaClass();
        val_40 = new UnityEngine.AndroidJavaClass(className:  System.Text.Encoding.UTF8);
        if(val_40 != null)
        {
                val_41 = System.Convert.FromBase64String(s:  "Y3VycmVudEFjdGl2aXR5");
            UnityEngine.AndroidJavaObject val_6 = new UnityEngine.AndroidJavaClass().GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  System.Text.Encoding.UTF8);
            if(val_6 != null)
        {
                val_41 = System.Convert.FromBase64String(s:  "Z2V0UGFja2FnZU1hbmFnZXI=");
            val_40 = val_6.Call<UnityEngine.AndroidJavaObject>(methodName:  System.Text.Encoding.UTF8, args:  System.Array.Empty<System.Object>());
            if(val_40 != null)
        {
                System.Byte[] val_12 = System.Convert.FromBase64String(s:  "Z2V0UGFja2FnZU5hbWU=");
            val_41 = System.Text.Encoding.UTF8;
            string val_14 = val_6.Call<System.String>(methodName:  val_41, args:  System.Array.Empty<System.Object>());
            if((System.String.IsNullOrEmpty(value:  val_14)) != true)
        {
                System.Byte[] val_17 = System.Convert.FromBase64String(s:  "Z2V0UGFja2FnZUluZm8=");
            val_41 = System.Text.Encoding.UTF8;
            object[] val_18 = new object[2];
            val_18[0] = val_14;
            val_18[1] = 128;
            val_40 = val_40.Call<UnityEngine.AndroidJavaObject>(methodName:  val_41, args:  val_18);
            if(val_40 != null)
        {
                val_41 = System.Convert.FromBase64String(s:  "YXBwbGljYXRpb25JbmZv");
            val_40 = val_40.Get<UnityEngine.AndroidJavaObject>(fieldName:  System.Text.Encoding.UTF8);
            if(val_40 != null)
        {
                val_41 = System.Convert.FromBase64String(s:  "ZGF0YURpcg==");
            val_38 = val_40.Get<System.String>(fieldName:  System.Text.Encoding.UTF8);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  val_38)) == true)
        {
                return;
        }
        
        new System.IO.DirectoryInfo() = new System.IO.DirectoryInfo(path:  val_38);
        System.Byte[] val_29 = System.Convert.FromBase64String(s:  "bGli");
        val_41 = System.Convert.FromBase64String(s:  "c2hhcmVkX3ByZWZz");
        label_45:
        val_40 = new System.IO.DirectoryInfo().Parent;
        if(val_40 == null)
        {
                return;
        }
        
        val_42 = 0;
        val_41 = val_40.GetDirectories();
        var val_38 = 0;
        label_51:
        if(val_38 >= val_33.Length)
        {
            goto label_45;
        }
        
        if(val_38 >= val_33.Length)
        {
                val_42 = 0;
        }
        
        System.IO.DirectoryInfo val_37 = val_41[0];
        val_39 = val_37;
        if((val_39.Contains(value:  System.Text.Encoding.UTF8)) == true)
        {
            goto label_49;
        }
        
        val_38 = val_38 + 1;
        if((val_37.Contains(value:  System.Text.Encoding.UTF8)) == false)
        {
            goto label_51;
        }
        
        label_49:
        this.丘一丘七万丘不丟业 = (float)UnityEngine.Random.Range(min:  2, max:  7);
    }
    private void 万丟丅丌丂丞丄丙一()
    {
        goto label_3;
        label_11:
        if((UnityEngine.Object.FindObjectsOfType<UnityEngine.Behaviour>()[0]) != 0)
        {
                val_1[0x0] + 32.enabled = false;
        }
        
        0 = 1;
        label_3:
        if(0 < val_1.Length)
        {
            goto label_11;
        }
    
    }
    private System.Collections.IEnumerator 一东丌丕丗丆且丅七(string 不且一丌丘丈丄东丂, int 丑丛丌丟丝丆丌七上, int 世与丙七且丑七与丙, int 一世上丗丟丞丆万丗, bool 丛丏与专丙丄七三丞, UnityEngine.AudioClip 东世丑世丛丞不专丕)
    {
        ExpController.下丁丑下下业一丛下 val_1 = new ExpController.下丁丑下下业一丛下(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丑丛丌丟丝丆丌七上 = 丑丛丌丟丝丆丌七上;
            .丛丏与专丙丄七三丞 = 丛丏与专丙丄七三丞;
        }
        else
        {
                mem[32] = this;
            .丑丛丌丟丝丆丌七上 = 丑丛丌丟丝丆丌七上;
            mem[40] = 丛丏与专丙丄七三丞;
        }
        
        .东世丑世丛丞不专丕 = 东世丑世丛丞不专丕;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static float 丙与丛丝七下丙东丏(int 丛丏丟万世丐丒丛丁)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(ExperienceController.sharedController == 0)
        {
                return (float)val_5;
        }
        
        val_6 = null;
        val_6 = null;
        int val_3 = ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  ExperienceController.丞丞丘业东丙丏七丌());
        float val_5 = (float)UnityEngine.Mathf.Clamp(value:  丛丏丟万世丐丒丛丁, min:  0, max:  val_3);
        val_5 = val_5 / (float)val_3;
        return (float)val_5;
    }
    internal static float 丁丈下丈丘丈丏丏丝()
    {
        return ExpController.丙与丛丝七下丙东丏(丛丏丟万世丐丒丛丁:  ExperienceController.万丏丙丈东东万丝丞());
    }
    internal static string 丆且丘丏丈丙丟万丏(int 丒东专一不与丐丐丁, int 业丄一世丆万丕丂丐)
    {
        if(丒东专一不与丐丐丁 != 业丄一世丆万丕丂丐)
        {
                if(ExperienceController.丞丞丘业东丙丏七丌() != 65)
        {
                return (string)System.String.Format(format:  "{0} {1}/{2}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0204"), arg1:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丒东专一不与丐丐丁), arg2:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  业丄一世丆万丕丂丐));
        }
        
        }
        
        System.String.Format(format:  "{0} {1}/{2}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0204"), arg1:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丒东专一不与丐丐丁), arg2:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  业丄一世丆万丕丂丐)) = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0928");
        return (string)System.String.Format(format:  "{0} {1}/{2}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0204"), arg1:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丒东专一不与丐丐丁), arg2:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  业丄一世丆万丕丂丐));
    }
    internal static string 丄丌丟丙专丙七下丆()
    {
        return ExpController.丆且丘丏丈丙丟万丏(丒东专一不与丐丐丁:  ExperienceController.万丏丙丈东东万丝丞(), 业丄一世丆万丕丂丐:  ExperienceController.上业丆丘丟丐且丘丝.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  ExperienceController.丞丞丘业东丙丏七丌()));
    }
    private static string 与丙三万且丗丆下丕(int 丈丘丝一丗下丈丐不)
    {
        return (string)System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐丞世丌丒丈丑丗丗(), arg1:  丈丘丝一丗下丈丐不);
    }
    private void Awake()
    {
        ExperienceController.丛丒丂世且不丂丝丐(丙业与丙丗丝不丈东:  new System.Action<且且世业丟丆与丄业>(object:  this, method:  System.Void ExpController::三东下丑丐万业丌七(ExperienceController.且且世业丟丆与丄业 上丕丈丞丌丘丅不与)));
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().EndsWith(value:  "Workbench")) != true)
        {
                this.世丗七丙丙业下丆与(丙业与丙丗丝不丈东:  false);
        }
        
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丈丏丕丞一丗丏丄丅(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void ExpController::七丅东丄丁七不丈丈(Rilisoft.且丙业丂丞一丈丙七 万丕与一丂丅丘丅丘)));
    }
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void ExpController::上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void Start()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ExpController.丝业丆丁业三丈丟东 != 0)
        {
                UnityEngine.Debug.LogWarning(message:  "ExpController is not null while starting.");
        }
        
        val_3 = null;
        val_3 = null;
        ExpController.丝业丆丁业三丈丟东 = this;
    }
    private void OnDisable()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = 34605;
        val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void ExpController::上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  val_1);
    }
    private void OnDestroy()
    {
        var val_2;
        ExperienceController.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<且且世业丟丆与丄业>(object:  this, method:  System.Void ExpController::三东下丑丐万业丌七(ExperienceController.且且世业丟丆与丄业 上丕丈丞丌丘丅不与)));
        val_2 = null;
        val_2 = null;
        ExpController.丝业丆丁业三丈丟东 = 0;
    }
    private void Update()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_6 = null;
            val_6 = null;
            this.世丗七丙丙业下丆与(丙业与丙丗丝不丈东:  ExperienceController.sharedController.下一丝丗丁上世丐上());
        }
        
        if(this.丘一丘七万丘不丟业 <= 0f)
        {
                return;
        }
        
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = this.丘一丘七万丘不丟业 - val_4;
        this.丘一丘七万丘不丟业 = val_4;
        if(val_4 > 0f)
        {
                return;
        }
        
        this.万丟丅丌丂丞丄丙一();
    }
    private void 三东下丑丐万业丌七(ExperienceController.且且世业丟丆与丄业 上丕丈丞丌丘丅不与)
    {
        string val_1;
        int val_2;
        int val_3;
        int val_4;
        UnityEngine.AudioClip val_5;
        UnityEngine.AudioClip val_6;
        var val_7;
        if(上丕丈丞丌丘丅不与 != null)
        {
                val_1 = 上丕丈丞丌丘丅不与.丑丗丅丕专丞丝万丒;
            val_2 = 上丕丈丞丌丘丅不与.丂丄与丁上专丘丆丈;
            val_3 = 上丕丈丞丌丘丅不与.三丒三丝丟丗一丑丂;
            val_4 = 上丕丈丞丌丘丅不与.东一丛专世三丆下下;
            val_5 = 上丕丈丞丌丘丅不与.丕下丘丒丄一下专专;
            val_6 = 上丕丈丞丌丘丅不与.业丒万三上丁专丂丅;
        }
        else
        {
                val_1 = 11993091;
            val_2 = 28563616;
            val_3 = 0;
            val_4 = 64;
            val_5 = 135970152;
            val_6 = 0;
        }
        
        this.丗丒丂丕丟东丟丙不(不且一丌丘丈丄东丂:  val_1, 七丐一丙下丌丙丞丝:  28563616, 三东丈丝丂万丒丅丒:  0, 与丑世丞丞七丟丆下:  64, 丗丈丈东世不丛万一:  val_5, 世不丑丘丞丑丘丄与:  val_6, 丂不丟丂丂丗一丝丒:  上丕丈丞丌丘丅不与.丙万丐丄万且丏丒一);
        val_7 = null;
        val_7 = null;
        if(ExpController.MaxLobbyLevel == 0)
        {
                return;
        }
        
        ExpController.MaxLobbyLevel.Invoke();
    }
    internal static void 上专丟丙业丒且丕丘(UnityEngine.GameObject 世丞丑上丅与世丁世)
    {
        UnityEngine.Object val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 世丞丑上丅与世丁世;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6.SetActive(value:  true);
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                ExpController val_4 = ExpController.丑七不且上丗丁一世();
            val_4.<丙丁丙七业丅丅丞丆>k__BackingField = true;
            if(ExpController.下万七丒东丁丈丗下 != null)
        {
                ExpController.下万七丒东丁丈丗下.Invoke();
        }
        
        }
        
        MainMenuController.丕七一丒丆不与丏丑(丝三丄专丗丞丄丄丌:  false);
        Rilisoft.LevelCompleteScript.丕七一丒丆不与丏丑(丝三丄专丗丞丄丄丌:  false);
        val_6 = 1152921505171275776;
        val_7 = null;
        val_7 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_6 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        上丘一丝丅丞东丗丄(丁与丟万丄丒丗专丌:  true);
    }
    internal static void 丏丂丛一与丄世上丒(UnityEngine.GameObject 世丞丑上丅与世丁世)
    {
        UnityEngine.Object val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 世丞丑上丅与世丁世;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6.SetActive(value:  false);
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                ExpController val_4 = ExpController.丑七不且上丗丁一世();
            val_4.<丙丁丙七业丅丅丞丆>k__BackingField = false;
            if(ExpController.丐不丑丛丟丌丅东丕 != null)
        {
                ExpController.丐不丑丛丟丌丅东丕.Invoke();
        }
        
        }
        
        MainMenuController.丕七一丒丆不与丏丑(丝三丄专丗丞丄丄丌:  true);
        Rilisoft.LevelCompleteScript.丕七一丒丆不与丏丑(丝三丄专丗丞丄丄丌:  true);
        val_6 = 1152921505171275776;
        val_7 = null;
        val_7 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_6 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        上丘一丝丅丞东丗丄(丁与丟万丄丒丗专丌:  false);
    }
    private void 上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        this.丝丟丆业且三丄丕丁 = false;
    }
    public ExpController()
    {
    
    }
    private static ExpController()
    {
        ExpController.LevelsForTiers = new int[7] {1, 7, 12, 17, 22, 27, 32};
    }
    private void 七丅东丄丁七不丈丈(Rilisoft.且丙业丂丞一丈丙七 万丕与一丂丅丘丅丘)
    {
        if(this._experienceView != 0)
        {
                LevelUpBanner val_2 = this._experienceView.丌世丘丁丁三丆丕七();
            if(val_2 != 0)
        {
                ExpController.丏丂丛一与丄世上丒(世丞丑上丅与世丁世:  val_2.gameObject);
        }
        
        }
        
        this.<丙丁丙七业丅丅丞丆>k__BackingField = false;
    }

}
