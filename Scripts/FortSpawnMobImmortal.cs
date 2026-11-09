using UnityEngine;
internal sealed class FortSpawnMobImmortal : FortEquipObject
{
    // Fields
    private System.Collections.Generic.List<string> _spawnBot;
    public int maxCountSpawnMob;
    public float timeForSpawnMob;
    private float _patrolRadius;
    private System.Collections.Generic.List<RilisoftBot.BaseBot> 世丞且丒丑丈丈与丞;
    private const string 不万丈丐丘上世丑丗 = "DungeonMobs/";
    private UnityEngine.Coroutine 丘上下与丟一丘丙丁;
    
    // Methods
    private void Awake()
    {
        this.丐丌丗丐丐丟丈上一();
    }
    private void Start()
    {
        RilisoftBot.BotAiController.丞上丗一丅与丛且丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortSpawnMobImmortal::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
    }
    private void OnDestroy()
    {
        RilisoftBot.BotAiController.丞丁丆丘丌丝丏三丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortSpawnMobImmortal::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
    }
    internal void 丐丌丗丐丐丟丈上一()
    {
        if(this.丘上下与丟一丘丙丁 != null)
        {
                return;
        }
        
        this.丘上下与丟一丘丙丁 = this.StartCoroutine(routine:  this.万丏上丘且一下丈下());
    }
    private System.Collections.IEnumerator 万丏上丘且一下丈下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortSpawnMobImmortal.丛三丈丘丞丕丏丈东();
    }
    private void 上丌万丁丄丅一丐丙()
    {
        var val_3 = null;
        if((FortSpawnMobImmortal.<>c.<>9__12_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        int val_1 = this.世丞且丒丑丈丈与丞.RemoveAll(match:  FortSpawnMobImmortal.<>c.<>9__12_0);
        return;
        label_3:
        FortSpawnMobImmortal.<>c.<>9__12_0 = new System.Predicate<RilisoftBot.BaseBot>(object:  FortSpawnMobImmortal.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortSpawnMobImmortal.<>c::上业丛不丕下丏丁丟(RilisoftBot.BaseBot 三丟东丕丄丄下下丑));
        if(this.世丞且丒丑丈丈与丞 != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void 丟丕丏专专丙专丂丗(string 丗丙丒一且丝丂丒世)
    {
        string val_12 = 丗丙丒一且丝丂丒世;
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(2 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(2 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 2;
        val_1[1] = val_1.Length;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_12 = "DungeonMobs/"("DungeonMobs/") + val_12;
        UnityEngine.Vector3 val_5 = this.transform.position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.3f);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Quaternion val_10 = this.transform.rotation;
        UnityEngine.GameObject val_11 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  val_12, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_1);
    }
    private void 丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        if(丑丁一丛万丘万丗不 == 0)
        {
                return;
        }
        
        if(丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑() == 0)
        {
                return;
        }
        
        PhotonView val_4 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_4.丞丁丝丕世丏丌丞丁 == null)
        {
                return;
        }
        
        PhotonView val_5 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_5.丞丁丝丕世丏丌丞丁.Length == 0)
        {
                return;
        }
        
        PhotonView val_6 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        object val_11 = val_6.丞丁丝丕世丏丌丞丁[0];
        if(null != 2)
        {
                return;
        }
        
        PhotonView val_7 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        object val_12 = val_7.丞丁丝丕世丏丌丞丁[1];
        if(null != val_7.丞丁丝丕世丏丌丞丁)
        {
                return;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() != false)
        {
                this.东专丆业世丝丅丟丈(丑丁一丛万丘万丗不:  丑丁一丛万丘万丗不);
        }
        else
        {
                if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                this.丗丄且丄丅丗上世上(丑丁一丛万丘万丗不:  丑丁一丛万丘万丗不);
        }
        
        }
        
        this.世丞且丒丑丈丈与丞.Add(item:  丑丁一丛万丘万丗不.七与世丄丞丒一七三());
    }
    private void 东专丆业世丝丅丟丈(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        PatrolModifierMoveInRadius val_2 = 丑丁一丛万丘万丗不.gameObject.AddComponent<PatrolModifierMoveInRadius>();
        UnityEngine.Vector3 val_4 = this.transform.position;
        val_2.丆业丙丘与丄专七不(且丛上丕业丂丒与一:  this._patrolRadius, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.丌万丁七丈业丈丗东 = val_2;
        }
        else
        {
                mem[96] = val_2;
        }
        
        MyMobsCurrentAiState val_6 = 丑丁一丛万丘万丗不.gameObject.AddComponent<MyMobsCurrentAiState>();
        val_6.丐丑七丈业丝丄东丝(丗不丛七丏丄业三丁:  丑丁一丛万丘万丗不.七与世丄丞丒一七三(), 丑丁一丛万丘万丗不:  丑丁一丛万丘万丗不);
        if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.丆丞业丅三丞专丝丒 = val_6;
        }
        else
        {
                mem[120] = val_6;
        }
        
        MyMobFortChooseNewTarget val_9 = 丑丁一丛万丘万丗不.gameObject.AddComponent<MyMobFortChooseNewTarget>();
        if(val_9 != null)
        {
                val_9.丐丑七丈业丝丄东丝(丗不丛七丏丄业三丁:  丑丁一丛万丘万丗不.七与世丄丞丒一七三(), 丑丁一丛万丘万丗不:  丑丁一丛万丘万丗不);
            val_9.丈专世丌三丝东万东 = val_6;
            val_9.专丒东丝丕丟一专专(丟丝上丄丂三丞且丄:  val_2);
            PhotonView val_11 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
            if(val_11.丞丁丝丕世丏丌丞丁.Length >= 2)
        {
                PhotonView val_12 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
            int val_13 = System.Convert.ToInt32(value:  val_12.丞丁丝丕世丏丌丞丁[1]);
            val_9.且三丕三丕丈下丕丝 = val_13;
            val_9.专丐丛丆与专世丆丂 = FortDefenceLinkController.丄丘七三上丕世丞业.丅七丂丆三业丘丌世(且三丕三丕丈下丕丝:  val_13);
        }
        
            if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.且丑不三上世丈丁丆 = val_9;
        }
        else
        {
                mem[136] = val_9;
        }
        
            RilisoftBot.BaseBot val_15 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
            val_15.世丗万丞世丂丂丕丝 = false;
            丑丁一丛万丘万丗不.丝丘丗丘业丝丈下丞 = 丑丁一丛万丘万丗不.gameObject.AddComponent<MyMobIgnorIDamageable>();
            return;
        }
    
    }
    private void 丗丄且丄丅丗上世上(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        PatrolModifierMoveInRadius val_2 = 丑丁一丛万丘万丗不.gameObject.AddComponent<PatrolModifierMoveInRadius>();
        UnityEngine.Vector3 val_4 = this.transform.position;
        val_2.丆业丙丘与丄专七不(且丛上丕业丂丒与一:  this._patrolRadius, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.丌万丁七丈业丈丗东 = val_2;
        }
        else
        {
                mem[96] = val_2;
        }
        
        MyMobsCurrentAiState val_6 = 丑丁一丛万丘万丗不.gameObject.AddComponent<MyMobsCurrentAiState>();
        val_6.丐丑七丈业丝丄东丝(丗不丛七丏丄业三丁:  丑丁一丛万丘万丗不.七与世丄丞丒一七三(), 丑丁一丛万丘万丗不:  丑丁一丛万丘万丗不);
        if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.丆丞业丅三丞专丝丒 = val_6;
        }
        else
        {
                mem[120] = val_6;
        }
        
        EnemyMobFortChooseNewTarget val_9 = 丑丁一丛万丘万丗不.gameObject.AddComponent<EnemyMobFortChooseNewTarget>();
        RilisoftBot.BaseBot val_10 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
        if(val_9 != null)
        {
                val_9.丈专世丌三丝东万东 = val_6;
            val_9.专丒东丝丕丟一专专(丟丝上丄丂三丞且丄:  val_2);
            PhotonView val_11 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
            if(val_11.丞丁丝丕世丏丌丞丁.Length >= 2)
        {
                PhotonView val_12 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
            int val_13 = System.Convert.ToInt32(value:  val_12.丞丁丝丕世丏丌丞丁[1]);
            val_9.且三丕三丕丈下丕丝 = val_13;
            val_9.专丐丛丆与专世丆丂 = FortDefenceLinkController.丄丘七三上丕世丞业.丅七丂丆三业丘丌世(且三丕三丕丈下丕丝:  val_13);
        }
        
            if(丑丁一丛万丘万丗不 != null)
        {
                丑丁一丛万丘万丗不.且丑不三上世丈丁丆 = val_9;
        }
        else
        {
                mem[136] = val_9;
        }
        
            RilisoftBot.BaseBot val_15 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
            val_15.世丗万丞世丂丂丕丝 = false;
            丑丁一丛万丘万丗不.丝丘丗丘业丝丈下丞 = 丑丁一丛万丘万丗不.gameObject.AddComponent<MyMobIgnorIDamageable>();
            return;
        }
    
    }
    internal bool 丑丝丈丟丌且且万世(string 丗丙丒一且丝丂丒世)
    {
        var val_5;
        List.Enumerator<T> val_1 = this._spawnBot.GetEnumerator();
        label_4:
        if(((-8523640) & 1) == 0)
        {
            goto label_2;
        }
        
        if((System.String.op_Equality(a:  0.丐丏七丌丕丗业且上().ToLower(), b:  丗丙丒一且丝丂丒世)) == false)
        {
            goto label_4;
        }
        
        val_5 = 1;
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    public FortSpawnMobImmortal()
    {
        this._spawnBot = new System.Collections.Generic.List<System.String>();
        this.maxCountSpawnMob = 3;
        this.timeForSpawnMob = 10f;
        this._patrolRadius = 5f;
        this.世丞且丒丑丈丈与丞 = new System.Collections.Generic.List<RilisoftBot.BaseBot>();
    }

}
