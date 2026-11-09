using UnityEngine;
internal class PlayerCoreSettingsStorager : ScriptableObject
{
    // Fields
    private static Rilisoft.七丞丞丅东丞专丙丝<PlayerCoreSettingsStorager> _instance;
    private float _autoAimDistance;
    private float _autoAimBRSnipeZoomDistance;
    public float MinDistanceAutoAim;
    public float BRMinDistanceAutoAim;
    public bool IsDistanceBlockOn;
    public float RadiusAutoAim;
    internal readonly float AUTOSHOOT_DEPENDENCE_MULTI;
    public float tracerFadeSpeed;
    public float tracerStartAlpha;
    public float tracerMinBulletSize;
    public float maxWidthOfTracer;
    public float tracerWithMulti;
    public System.Collections.Generic.List<PlayerCoreSettingsStorager.WeaponFlashesConnect> weaponFlashes;
    public System.Collections.Generic.List<string> listNewEmojies;
    internal static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, PlayerCoreSettingsStorager.一三专丈世丑丆丑丐> dynamicSettingsGameModes;
    internal static System.Collections.Generic.Dictionary<PGCompany.GameModeEvents.下丑一丈与丝与丐丛.EventMovementScheme, PlayerCoreSettingsStorager.一三专丈世丑丆丑丐> dynamicSettingsMoveSchemes;
    internal static PlayerCoreSettingsStorager.丄丁丂丗不一丐丐丙 recoildAndScopeSettings;
    private static PlayerCoreSettingsStorager.一三专丈世丑丆丑丐 cachedGameModeDynamicSettings_Settings;
    private static Rilisoft.七丕丟丏三丈一丄世 cachedGameModeDynamicSettings_GameMode;
    private static PlayerCoreSettingsStorager.一三专丈世丑丆丑丐 cachedMoveSchemeDynamicSettings_Settings;
    private static PGCompany.GameModeEvents.下丑一丈与丝与丐丛.EventMovementScheme cachedMoveSchemeDynamicSettings_MoveScheme;
    private static int cachedMapEventId;
    private static PGCompany.GameModeEvents.下丑一丈与丝与丐丛.EventMovementScheme cachedMapEventMoveScheme;
    
    // Properties
    internal static PlayerCoreSettingsStorager Instance { get; }
    public float AutoAimDistance { get; }
    public float AutoAimBRSnipeZoomDistance { get; }
    public float AutoAimDistanceGetter { get; }
    public float AutoAimBRSnipeZoomDistanceGetter { get; }
    public float MinDistanceAutoAimGetter { get; }
    public float BRMinDistanceAutoAimGetter { get; }
    public bool IsDistanceBlockOnGetter { get; }
    public float RadiusAutoAimGetter { get; }
    internal static PlayerCoreSettingsStorager.一三专丈世丑丆丑丐 dynamicSettings { get; }
    
    // Methods
    internal static PlayerCoreSettingsStorager get_Instance()
    {
        null = null;
        if(PlayerCoreSettingsStorager._instance != null)
        {
                return PlayerCoreSettingsStorager._instance.世三丞丅丑丌丈丈一();
        }
        
        return PlayerCoreSettingsStorager._instance.世三丞丅丑丌丈丈一();
    }
    public float get_AutoAimDistance()
    {
        float val_1 = PGCompany.AdaptiveAutoAimController.丅业专丏不丒丄丐一(丄丒丗丟世丘万丙丟:  4);
        val_1 = this._autoAimDistance + val_1;
        return (float)val_1;
    }
    public float get_AutoAimBRSnipeZoomDistance()
    {
        float val_1 = PGCompany.AdaptiveAutoAimController.丅业专丏不丒丄丐一(丄丒丗丟世丘万丙丟:  5);
        val_1 = this._autoAimBRSnipeZoomDistance + val_1;
        return (float)val_1;
    }
    public float get_AutoAimDistanceGetter()
    {
        return this.AutoAimDistance;
    }
    public float get_AutoAimBRSnipeZoomDistanceGetter()
    {
        return this.AutoAimBRSnipeZoomDistance;
    }
    public float get_MinDistanceAutoAimGetter()
    {
        return (float)this.MinDistanceAutoAim;
    }
    public float get_BRMinDistanceAutoAimGetter()
    {
        return (float)this.BRMinDistanceAutoAim;
    }
    public bool get_IsDistanceBlockOnGetter()
    {
        return (bool)this.IsDistanceBlockOn;
    }
    public float get_RadiusAutoAimGetter()
    {
        return (float)this.RadiusAutoAim;
    }
    internal static PlayerCoreSettingsStorager.一三专丈世丑丆丑丐 get_dynamicSettings()
    {
        var val_10;
        var val_11;
        var val_12;
        EventMovementScheme val_13;
        var val_14;
        EventMovementScheme val_15;
        var val_16;
        var val_17;
        var val_18;
        EventMovementScheme val_19;
        var val_20;
        EventMovementScheme val_21;
        val_10 = null;
        val_10 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕 == null)
        {
            goto label_26;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = null;
        val_10 = null;
        if(PlayerCoreSettingsStorager.cachedMapEventId == GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七())
        {
                val_12 = null;
        }
        else
        {
                PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_2 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  14);
            if(val_2 != null)
        {
                val_13 = val_2.丛丅下丆丗丏三丁丕<EventMovementScheme>(丒丑丂丐丕丒丕东与:  "custom");
        }
        else
        {
                val_13 = 0;
        }
        
            PlayerCoreSettingsStorager.cachedMapEventMoveScheme = val_13;
            val_14 = null;
            val_14 = null;
            val_12 = null;
            val_12 = null;
            PlayerCoreSettingsStorager.cachedMapEventId = GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七();
        }
        
        val_12 = null;
        val_15 = PlayerCoreSettingsStorager.cachedMapEventMoveScheme;
        if(val_15 == 0)
        {
            goto label_26;
        }
        
        val_15 = PlayerCoreSettingsStorager.cachedMapEventMoveScheme;
        val_16 = PlayerCoreSettingsStorager.不三丛丁丅丞丆上丆(丕丁丙丝丅一丒丂丌:  val_15);
        goto label_29;
        label_26:
        val_16 = 0;
        label_29:
        val_17 = null;
        val_17 = null;
        if(GameConnect.丛丑世丕丌上丑丂丈 != false)
        {
                val_18 = null;
            val_18 = null;
            val_17 = null;
            PlayerCoreSettingsStorager.cachedMapEventId = 0;
            PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_6 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  14);
            if(val_6 != null)
        {
                val_19 = val_6.丛丅下丆丗丏三丁丕<EventMovementScheme>(丒丑丂丐丕丒丕东与:  "custom");
        }
        else
        {
                val_19 = 0;
        }
        
            val_20 = null;
            PlayerCoreSettingsStorager.cachedMapEventMoveScheme = val_19;
            val_20 = null;
            val_21 = PlayerCoreSettingsStorager.cachedMapEventMoveScheme;
            if(val_21 != 0)
        {
                val_21 = PlayerCoreSettingsStorager.cachedMapEventMoveScheme;
            val_16 = PlayerCoreSettingsStorager.不三丛丁丅丞丆上丆(丕丁丙丝丅一丒丂丌:  val_21);
        }
        
        }
        
        if(val_16 == null)
        {
                return PlayerCoreSettingsStorager.丌丐丙丘丙不下万且(下丁上丟业一三丒东:  GameConnect.丑丌丛丈丅丅与不业());
        }
        
        return (一三专丈世丑丆丑丐)val_16;
    }
    private static PlayerCoreSettingsStorager.一三专丈世丑丆丑丐 丌丐丙丘丙不下万且(Rilisoft.七丕丟丏三丈一丄世 下丁上丟业一三丒东)
    {
        var val_2;
        var val_4;
        var val_5;
        val_2 = null;
        val_2 = null;
        if(PlayerCoreSettingsStorager.cachedGameModeDynamicSettings_Settings == null)
        {
            goto label_3;
        }
        
        val_2 = null;
        if(PlayerCoreSettingsStorager.cachedGameModeDynamicSettings_GameMode == 下丁上丟业一三丒东)
        {
            goto label_6;
        }
        
        label_3:
        val_4 = null;
        val_5 = null;
        PlayerCoreSettingsStorager.cachedGameModeDynamicSettings_Settings = PlayerCoreSettingsStorager.dynamicSettingsGameModes.Item[下丁上丟业一三丒东];
        PlayerCoreSettingsStorager.cachedGameModeDynamicSettings_GameMode = 下丁上丟业一三丒东;
        label_6:
        val_5 = null;
        return (一三专丈世丑丆丑丐)PlayerCoreSettingsStorager.cachedGameModeDynamicSettings_Settings;
    }
    private static PlayerCoreSettingsStorager.一三专丈世丑丆丑丐 不三丛丁丅丞丆上丆(PGCompany.GameModeEvents.下丑一丈与丝与丐丛.EventMovementScheme 丕丁丙丝丅一丒丂丌)
    {
        var val_2;
        var val_4;
        var val_5;
        val_2 = null;
        val_2 = null;
        if(PlayerCoreSettingsStorager.cachedMoveSchemeDynamicSettings_Settings == null)
        {
            goto label_3;
        }
        
        val_2 = null;
        if(PlayerCoreSettingsStorager.cachedMoveSchemeDynamicSettings_MoveScheme == 丕丁丙丝丅一丒丂丌)
        {
            goto label_6;
        }
        
        label_3:
        val_4 = null;
        val_5 = null;
        PlayerCoreSettingsStorager.cachedMoveSchemeDynamicSettings_Settings = PlayerCoreSettingsStorager.dynamicSettingsMoveSchemes.Item[丕丁丙丝丅一丒丂丌];
        PlayerCoreSettingsStorager.cachedMoveSchemeDynamicSettings_MoveScheme = 丕丁丙丝丅一丒丂丌;
        label_6:
        val_5 = null;
        return (一三专丈世丑丆丑丐)PlayerCoreSettingsStorager.cachedMoveSchemeDynamicSettings_Settings;
    }
    internal void 丏丑丕丁一三丄与丈(System.Collections.Generic.Dictionary<string, object> 丞丅丛丞丟丘丗丌东)
    {
        var val_4;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_14 = 丞丅丛丞丟丘丗丌东;
        Dictionary.Enumerator<TKey, TValue> val_1 = val_14.GetEnumerator();
        label_26:
        if((1298696736 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        System.Nullable<T> val_7 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<Rilisoft.七丕丟丏三丈一丄世>(下业七不丑丂丏丟东:  val_5._value._obj.丐丏七丌丕丗业且上(), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
        if((1298696712 & 1) == 0)
        {
            goto label_26;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = null;
        if((PlayerCoreSettingsStorager.dynamicSettingsGameModes.ContainsKey(key:  val_7.HasValue)) == false)
        {
            goto label_9;
        }
        
        val_17 = null;
        val_18 = 0;
        goto label_16;
        label_9:
        val_19 = null;
        new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐() = new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐(上且丗一丏丏万丅丌:  val_7.HasValue);
        PlayerCoreSettingsStorager.dynamicSettingsGameModes.Add(key:  val_7.HasValue, value:  new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐());
        val_20 = 0;
        goto label_24;
        label_16:
        PlayerCoreSettingsStorager.dynamicSettingsGameModes.Item[val_7.HasValue].世丄丘丄丆且丌丙且(丌丆丆丆丏丄万丛不:  null);
        goto label_26;
        label_24:
        PlayerCoreSettingsStorager.dynamicSettingsGameModes.Item[val_7.HasValue].世丄丘丄丆且丌丙且(丌丆丆丆丏丄万丛不:  null);
        goto label_26;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 三丕丞丟丟丘丑一万(System.Collections.Generic.Dictionary<string, object> 丙丕丈下丙丆丞丝丝)
    {
        var val_4;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_14 = 丙丕丈下丙丆丞丝丝;
        Dictionary.Enumerator<TKey, TValue> val_1 = val_14.GetEnumerator();
        label_27:
        if((1298854816 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        System.Nullable<T> val_7 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<EventMovementScheme>(下业七不丑丂丏丟东:  val_5._value._obj.丐丏七丌丕丗业且上(), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
        if((1298854792 & 1) == 0)
        {
            goto label_27;
        }
        
        val_15 = null;
        val_15 = null;
        if((PlayerCoreSettingsStorager.dynamicSettingsMoveSchemes.ContainsKey(key:  val_7.HasValue)) == false)
        {
            goto label_9;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = 0;
        goto label_16;
        label_9:
        new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐() = new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐(上且丗一丏丏万丅丌:  2);
        new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐().丈丟丒万与丅业一专(丕丁丙丝丅一丒丂丌:  val_7.HasValue);
        val_18 = null;
        val_18 = null;
        PlayerCoreSettingsStorager.dynamicSettingsMoveSchemes.Add(key:  val_7.HasValue, value:  new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐());
        val_19 = 0;
        goto label_25;
        label_16:
        PlayerCoreSettingsStorager.dynamicSettingsMoveSchemes.Item[val_7.HasValue].世丄丘丄丆且丌丙且(丌丆丆丆丏丄万丛不:  null);
        goto label_27;
        label_25:
        PlayerCoreSettingsStorager.dynamicSettingsMoveSchemes.Item[val_7.HasValue].世丄丘丄丆且丌丙且(丌丆丆丆丏丄万丛不:  null);
        goto label_27;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, PlayerCoreSettingsStorager.一三专丈世丑丆丑丐> 世丂丐一丞一三且丗()
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 一三专丈世丑丆丑丐> val_5 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 一三专丈世丑丆丑丐>();
        List.Enumerator<T> val_6 = System.Linq.Enumerable.ToList<Rilisoft.七丕丟丏三丈一丄世>(source:  System.Linq.Enumerable.Cast<Rilisoft.七丕丟丏三丈一丄世>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))).GetEnumerator();
        label_8:
        if((1299014984 & 1) == 0)
        {
            goto label_6;
        }
        
        int val_7 = 0.丙东专丂世丈丏丁丂();
        new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐() = new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐(上且丗一丏丏万丅丌:  val_7);
        val_5.Add(key:  val_7, value:  new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐());
        goto label_8;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_5;
    }
    private static System.Collections.Generic.Dictionary<PGCompany.GameModeEvents.下丑一丈与丝与丐丛.EventMovementScheme, PlayerCoreSettingsStorager.一三专丈世丑丆丑丐> 丞丒丌丑下丙七丈世()
    {
        System.Collections.Generic.Dictionary<EventMovementScheme, 一三专丈世丑丆丑丐> val_5 = new System.Collections.Generic.Dictionary<EventMovementScheme, 一三专丈世丑丆丑丐>();
        List.Enumerator<T> val_6 = System.Linq.Enumerable.ToList<EventMovementScheme>(source:  System.Linq.Enumerable.Cast<EventMovementScheme>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))).GetEnumerator();
        label_9:
        if((1299183304 & 1) == 0)
        {
            goto label_6;
        }
        
        int val_7 = 0.丙东专丂世丈丏丁丂();
        new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐() = new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐(上且丗一丏丏万丅丌:  2);
        new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐().丈丟丒万与丅业一专(丕丁丙丝丅一丒丂丌:  val_7);
        val_5.Add(key:  val_7, value:  new PlayerCoreSettingsStorager.一三专丈世丑丆丑丐());
        goto label_9;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_5;
    }
    public PlayerCoreSettingsStorager()
    {
        this._autoAimDistance = 40f;
        this._autoAimBRSnipeZoomDistance = 130f;
        this.BRMinDistanceAutoAim = 2f;
        this.tracerMinBulletSize = 0.1f;
        this.maxWidthOfTracer = 7.346868E-41f;
        this.tracerWithMulti = 1f;
        this.RadiusAutoAim = ;
        this.AUTOSHOOT_DEPENDENCE_MULTI = ;
        this.tracerFadeSpeed = 7f;
        this.tracerStartAlpha = 0.95f;
        this.weaponFlashes = new System.Collections.Generic.List<WeaponFlashesConnect>();
        this.listNewEmojies = new System.Collections.Generic.List<System.String>();
    }
    private static PlayerCoreSettingsStorager()
    {
        null = null;
        PlayerCoreSettingsStorager._instance = new Rilisoft.七丞丞丅东丞专丙丝<PlayerCoreSettingsStorager>(丙丂丌且丌世丒丐三:  new System.Func<PlayerCoreSettingsStorager>(object:  PlayerCoreSettingsStorager.<>c.<>9, method:  PlayerCoreSettingsStorager PlayerCoreSettingsStorager.<>c::万且不上丌东三丌与()));
        PlayerCoreSettingsStorager.dynamicSettingsGameModes = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 一三专丈世丑丆丑丐>(dictionary:  PlayerCoreSettingsStorager.世丂丐一丞一三且丗());
        PlayerCoreSettingsStorager.dynamicSettingsMoveSchemes = new System.Collections.Generic.Dictionary<EventMovementScheme, 一三专丈世丑丆丑丐>(dictionary:  PlayerCoreSettingsStorager.丞丒丌丑下丙七丈世());
        PlayerCoreSettingsStorager.recoildAndScopeSettings = new PlayerCoreSettingsStorager.丄丁丂丗不一丐丐丙();
        PlayerCoreSettingsStorager.cachedGameModeDynamicSettings_Settings = 0;
        PlayerCoreSettingsStorager.cachedGameModeDynamicSettings_GameMode = 2;
        PlayerCoreSettingsStorager.cachedMoveSchemeDynamicSettings_Settings = 0;
        PlayerCoreSettingsStorager.cachedMoveSchemeDynamicSettings_MoveScheme = 0;
        PlayerCoreSettingsStorager.cachedMapEventId = 0;
        PlayerCoreSettingsStorager.cachedMapEventMoveScheme = 0;
    }

}
