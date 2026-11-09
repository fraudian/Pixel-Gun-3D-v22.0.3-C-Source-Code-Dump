using UnityEngine;
internal class SpawnMobBase : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<string> spawnBot;
    public int maxCountSpawnMob;
    public float timeForSpawnMob;
    protected PhotonView 丅丏三七丁丑丞丄丏;
    private System.Collections.Generic.List<RilisoftBot.BaseBot> 世丞且丒丑丈丈与丞;
    private UnityEngine.Coroutine 丘上下与丟一丘丙丁;
    
    // Properties
    internal PhotonView 万上世上丑丘丑且丄 { get; }
    
    // Methods
    internal PhotonView 丛丘丟业下丐专丕丑()
    {
        return (PhotonView)this.丅丏三七丁丑丞丄丏;
    }
    private void Awake()
    {
        this.丅丏三七丁丑丞丄丏 = this.GetComponent<PhotonView>();
    }
    protected virtual void Start()
    {
        RilisoftBot.BotAiController.丞上丗一丅与丛且丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void SpawnMobBase::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
    }
    protected virtual void OnDestroy()
    {
        RilisoftBot.BotAiController.丞丁丆丘丌丝丏三丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void SpawnMobBase::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
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
        return (System.Collections.IEnumerator)new SpawnMobBase.丈专专丏业东七丟丙();
    }
    private void 上丌万丁丄丅一丐丙()
    {
        var val_3 = null;
        if((SpawnMobBase.<>c.<>9__13_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        int val_1 = this.世丞且丒丑丈丈与丞.RemoveAll(match:  SpawnMobBase.<>c.<>9__13_0);
        return;
        label_3:
        SpawnMobBase.<>c.<>9__13_0 = new System.Predicate<RilisoftBot.BaseBot>(object:  SpawnMobBase.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SpawnMobBase.<>c::三丒丘丑丆丘业下一(RilisoftBot.BaseBot 三丟东丕丄丄下下丑));
        if(this.世丞且丒丑丈丈与丞 != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void 丟丕丏专专丙专丂丗()
    {
        var val_7;
        if(this.spawnBot == null)
        {
                return;
        }
        
        if(this.spawnBot.Count == 0)
        {
                return;
        }
        
        if(this.世丞且丒丑丈丈与丞.Count >= this.maxCountSpawnMob)
        {
                return;
        }
        
        object val_7 = this.丅丏三七丁丑丞丄丏.丞丁丝丕世丏丌丞丁[0];
        object val_8 = this.丅丏三七丁丑丞丄丏.丞丁丝丕世丏丌丞丁[1];
        object val_9 = this.丅丏三七丁丑丞丄丏.丞丁丝丕世丏丌丞丁[2];
        val_7 = null;
        val_7 = null;
        SpawnDungeonMobeSetting.丄丘七三上丕世丞业.丛丞丘丞万丆丞丛丄(丒丘丏上丙丟丑丕丈:  this.spawnBot.Item[UnityEngine.Random.Range(min:  0, max:  this.spawnBot.Count)], 丛不丒与七丗丆丏且:  21884928, 上丅丌丛且丕且丑丆:  21884928, 丞丒且丅丝丝专丟上:  SpawnDungeonMobeSetting.丄丘七三上丕世丞业.丟下丝一丈东万且丛, 丟丆且不七丈丐丂专:  this.丅丏三七丁丑丞丄丏.viewID, 上东丟三丒丛丁不且:  21884928);
    }
    private void 丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        UnityEngine.Object val_14;
        if(丑丁一丛万丘万丗不 == 0)
        {
                return;
        }
        
        val_14 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
        if(val_14 == 0)
        {
                return;
        }
        
        val_14 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_14 == 0)
        {
                return;
        }
        
        val_14 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_14.instantiationData == null)
        {
                return;
        }
        
        val_14 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑().instantiationData;
        if(val_9.Length < 5)
        {
                return;
        }
        
        val_14 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑().instantiationData[4];
        if(null != this.丅丏三七丁丑丞丄丏.viewID)
        {
                return;
        }
        
        this.世丞且丒丑丈丈与丞.Add(item:  丑丁一丛万丘万丗不.七与世丄丞丒一七三());
    }
    public SpawnMobBase()
    {
        this.spawnBot = new System.Collections.Generic.List<System.String>();
        this.maxCountSpawnMob = 10;
        this.timeForSpawnMob = 10f;
        this.世丞且丒丑丈丈与丞 = new System.Collections.Generic.List<RilisoftBot.BaseBot>();
    }

}
