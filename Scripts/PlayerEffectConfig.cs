using UnityEngine;
internal sealed class PlayerEffectConfig : ScriptableObject
{
    // Fields
    private static PlayerEffectConfig _instance;
    private System.Collections.Generic.List<PlayerEffectSettings> _listPlayerEffects;
    internal System.Collections.Generic.Dictionary<string, PlayerEffectSettings> dictionaryPlayerEffects;
    
    // Properties
    internal static PlayerEffectConfig Instance { get; }
    
    // Methods
    internal static PlayerEffectConfig get_Instance()
    {
        PlayerEffectConfig val_3 = PlayerEffectConfig._instance;
        if(val_3 != 0)
        {
                return (PlayerEffectConfig)PlayerEffectConfig._instance;
        }
        
        PlayerEffectConfig._instance = UnityEngine.Resources.Load<PlayerEffectConfig>(path:  "SetsAndEffectConfig/PlayerEffectConfig");
        val_3 = PlayerEffectConfig._instance;
        val_3.丘上丐世丆丑且丞丒();
        return (PlayerEffectConfig)PlayerEffectConfig._instance;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        string val_4;
        System.Int32[] val_5;
        丑丄丏丐丅丛丐丆丒 val_6;
        string val_7;
        var val_8 = this;
        List.Enumerator<T> val_1 = this._listPlayerEffects.GetEnumerator();
        label_4:
        if((1263207744 & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = val_7;
        this.dictionaryPlayerEffects.set_Item(key:  val_7, value:  new PlayerEffectSettings() {idEffect = val_4, playerEffects = val_6, factor = val_6, additionalFactor = val_6, arrayId = val_5});
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public PlayerEffectConfig()
    {
        this._listPlayerEffects = new System.Collections.Generic.List<PlayerEffectSettings>();
        this.dictionaryPlayerEffects = new System.Collections.Generic.Dictionary<System.String, PlayerEffectSettings>();
    }

}
