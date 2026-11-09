using UnityEngine;
internal sealed class SettingsSpawnMobWave : PGBehaviour
{
    // Fields
    private const string 不万丈丐丘上世丑丗 = "DungeonMobs/";
    private int _numberSpawnPoint;
    private System.Collections.Generic.List<UnityEngine.Transform> _listPositions;
    private System.Collections.Generic.List<FortDamageableGenerator> _listFortDamageableGenerator;
    private SettingsPathMob _settingsPathMob;
    private AddTargetWorldPoseIndicationFort _indication;
    private FortPointSpawnInfo _fortWaveInfo;
    
    // Properties
    internal bool 七一上与丈七丁丅丁 { get; }
    internal int 不丟三丘一丁丆丈丗 { get; }
    internal System.Collections.Generic.List<UnityEngine.Vector3> 世丒业丂一上丆一东 { get; }
    internal FortPointSpawnInfo 丛万东丅丈东丑丂丂 { set; }
    
    // Methods
    internal bool 三丄丈丏丟丐业世丄()
    {
        var val_4;
        List.Enumerator<T> val_1 = this._listFortDamageableGenerator.GetEnumerator();
        label_4:
        if((1173102040 & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上().丏丏丘丄丟丆丝丗丄() == true)
        {
            goto label_4;
        }
        
        val_4 = 0;
        goto label_5;
        label_2:
        val_4 = 1;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    internal int 丝一丗且丙丂丌三丁()
    {
        return (int)this._numberSpawnPoint;
    }
    internal System.Collections.Generic.List<UnityEngine.Vector3> 丕丞专不丌东丒丄世()
    {
        System.Collections.Generic.List<UnityEngine.Vector3> val_3;
        if(this._settingsPathMob == 0)
        {
                System.Collections.Generic.List<UnityEngine.Vector3> val_2 = null;
            val_3 = val_2;
            val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            return val_3;
        }
        
        val_3 = this._settingsPathMob._listPath;
        return val_3;
    }
    internal void 丐丒丗一丗丐且一丁(FortPointSpawnInfo 丙业与丙丗丝不丈东)
    {
        this._fortWaveInfo = 丙业与丙丗丝不丈东;
        mem[1152921540140076536] = 丙业与丙丗丝不丈东.listWaveFort;
    }
    private void Awake()
    {
        RilisoftBot.BotAiController.丞上丗一丅与丛且丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void SettingsSpawnMobWave::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
    }
    internal void 丄七丕且万专丅丞万(float 丟丆丆丝东世一丒丐)
    {
        List.Enumerator<T> val_1 = this._listFortDamageableGenerator.GetEnumerator();
        label_5:
        if((1173724504 & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().业丒丁丙丛丒上丙丟().三丁丆上上丒丐丏丗(世丙丟上丘上七万万:  丟丆丆丝东世一丒丐);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void OnDestroy()
    {
        RilisoftBot.BotAiController.丞丁丆丘丌丝丏三丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void SettingsSpawnMobWave::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
    }
    internal void 丟丕丏专专丙专丂丗(string 丗丙丒一且丝丂丒世, int 丞丌丌丕丆世七一丏)
    {
        System.Collections.Generic.List<UnityEngine.Transform> val_8;
        object val_9;
        val_8 = this;
        object[] val_1 = new object[3];
        val_1[0] = 1;
        val_9 = this._numberSpawnPoint;
        val_1[1] = val_9;
        val_1[2] = 丞丌丌丕丆世七一丏;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_9 = 1152921519067102480;
        if(this._listPositions.Count != 0)
        {
                val_8 = this._listPositions;
            UnityEngine.Transform val_6 = val_8.Item[UnityEngine.Random.Range(min:  0, max:  val_8.Count)];
        }
        else
        {
                UnityEngine.Transform val_7 = this.丌丟丄业且三丛丕丄();
        }
        
        val_7.丒万丕七东丌世上丞(丗丙丒一且丝丂丒世:  丗丙丒一且丝丂丒世, 丅专与丒丈丗丒丘丌:  val_7, 一丐丗丁丞丆丅丟丄:  val_1);
    }
    internal UnityEngine.Vector3 下专丟世丏丏世世专()
    {
        UnityEngine.Transform val_3 = this._listPositions.Item[UnityEngine.Random.Range(min:  0, max:  this._listPositions.Count)];
        if(val_3 != null)
        {
                return val_3.position;
        }
        
        return val_3.position;
    }
    private void 丒万丕七东丌世上丞(string 丗丙丒一且丝丂丒世, UnityEngine.Transform 丅专与丒丈丗丒丘丌, object[] 一丐丗丁丞丆丅丟丄)
    {
        UnityEngine.Vector3 val_2 = 丅专与丒丈丗丒丘丌.position;
        UnityEngine.Quaternion val_3 = 丅专与丒丈丗丒丘丌.rotation;
        UnityEngine.GameObject val_4 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  "DungeonMobs/"("DungeonMobs/") + 丗丙丒一且丝丂丒世, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
    }
    private void 丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        var val_20;
        UnityEngine.Object val_47;
        var val_48;
        UnityEngine.Transform val_49;
        System.Collections.Generic.IEnumerable<T> val_50;
        且丝丈东丂丁且丘七 val_51;
        val_47 = 1152921504848912384;
        if(丑丁一丛万丘万丗不 == 0)
        {
                return;
        }
        
        val_47 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_47 == 0)
        {
                return;
        }
        
        val_47 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_4.丞丁丝丕世丏丌丞丁 == null)
        {
                return;
        }
        
        PhotonView val_5 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        val_47 = val_5.丞丁丝丕世丏丌丞丁;
        if(val_5.丞丁丝丕世丏丌丞丁.Length == 0)
        {
                return;
        }
        
        PhotonView val_6 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        object val_46 = val_6.丞丁丝丕世丏丌丞丁[0];
        val_48 = 1152921504622075904;
        if(null != 1)
        {
                PhotonView val_7 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
            val_47 = val_7.丞丁丝丕世丏丌丞丁;
            object val_47 = val_47[0];
            if(null != 3)
        {
                return;
        }
        
        }
        
        PhotonView val_8 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        object val_48 = val_8.丞丁丝丕世丏丌丞丁[1];
        val_47 = this._numberSpawnPoint;
        if(null != val_47)
        {
                return;
        }
        
        PatrolModifierMoveToPoints val_10 = 丑丁一丛万丘万丗不.gameObject.AddComponent<PatrolModifierMoveToPoints>();
        System.Collections.Generic.List<UnityEngine.Vector3> val_11 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        if(丑丁一丛万丘万丗不.七与世丄丞丒一七三().与丛上丙丟丘三世丁() != 3)
        {
            goto label_34;
        }
        
        System.Collections.Generic.List<UnityEngine.Transform> val_16 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_16.Add(item:  丑丁一丛万丘万丗不.transform);
        List.Enumerator<T> val_18 = this._listFortDamageableGenerator.GetEnumerator();
        label_44:
        if((1175025856 & 1) == 0)
        {
            goto label_40;
        }
        
        val_16.Add(item:  val_20.丐丏七丌丕丗业且上().业丒丁丙丛丒上丙丟().transform);
        goto label_44;
        label_40:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_49 = transform;
        val_16.Add(item:  val_49);
        丑丁一丛万丘万丗不.gameObject.AddComponent<BossIndicationsFortDefence>().丑丙丄丄丁丟三丙丝(丌丆一七丈丈丄下下:  val_16);
        val_48 = 1152921504622075904;
        label_34:
        UnityEngine.Vector3 val_26 = 丑丁一丛万丘万丗不.transform.position;
        val_11.Add(item:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        val_50 = this.丕丞专不丌东丒丄世();
        val_11.AddRange(collection:  val_50);
        val_10.与丘丗万业丕丏丄万(丑七丐丈下世丆丞丟:  val_11);
        if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.丌万丁七丈业丈丗东 = val_10;
        }
        else
        {
                mem[96] = val_10;
        }
        
        FortCurrentAiState val_29 = 丑丁一丛万丘万丗不.gameObject.AddComponent<FortCurrentAiState>();
        val_29.丐丑七丈业丝丄东丝(丗不丛七丏丄业三丁:  丑丁一丛万丘万丗不.七与世丄丞丒一七三(), 丑丁一丛万丘万丗不:  丑丁一丛万丘万丗不);
        if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.丆丞业丅三丞专丝丒 = val_29;
        }
        else
        {
                mem[120] = val_29;
        }
        
        val_47 = 丑丁一丛万丘万丗不.gameObject.AddComponent<MobFortChooseNewTarget>();
        val_32.丈专世丌三丝东万东 = val_29;
        PhotonView val_33 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_33.丞丁丝丕世丏丌丞丁.Length < 2)
        {
            goto label_99;
        }
        
        PhotonView val_34 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        val_32.且三丕三丕丈下丕丝 = (System.Convert.ToInt32(value:  val_34.丞丁丝丕世丏丌丞丁[1])) + 1;
        if(丑丁一丛万丘万丗不.七与世丄丞丒一七三().与丛上丙丟丘三世丁() != 3)
        {
            goto label_81;
        }
        
        val_51 = 4;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 != null)
        {
            goto label_84;
        }
        
        goto label_83;
        label_81:
        val_51 = val_32.且三丕三丕丈下丕丝;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 != null)
        {
            goto label_84;
        }
        
        label_83:
        label_84:
        val_32.专丐丛丆与专世丆丂 = FortDefenceLinkController.丄丘七三上丕世丞业.丅七丂丆三业丘丌世(且三丕三丕丈下丕丝:  val_51);
        List.Enumerator<T> val_40 = this._listFortDamageableGenerator.GetEnumerator();
        val_50 = 1152921540102888656;
        val_49 = 1152921540102873296;
        label_89:
        if((1175025856 & 1) == 0)
        {
            goto label_86;
        }
        
        val_32.丌丆一七丈丈丄下下.Add(item:  val_20.丐丏七丌丕丗业且上().业丒丁丙丛丒上丙丟());
        goto label_89;
        label_86:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PhotonView val_43 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_43.丞丁丝丕世丏丌丞丁.Length >= 3)
        {
                PhotonView val_44 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
            object val_50 = val_44.丞丁丝丕世丏丌丞丁[2];
            丑丁一丛万丘万丗不.丞不且丌丆丆万业丘 = null;
        }
        
        label_99:
        if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.且丑不三上世丈丁丆 = val_47;
        }
        else
        {
                mem[136] = val_47;
        }
        
        RilisoftBot.BaseBot val_45 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
    }
    public SettingsSpawnMobWave()
    {
        this._listPositions = new System.Collections.Generic.List<UnityEngine.Transform>();
        this._listFortDamageableGenerator = new System.Collections.Generic.List<FortDamageableGenerator>();
    }

}
