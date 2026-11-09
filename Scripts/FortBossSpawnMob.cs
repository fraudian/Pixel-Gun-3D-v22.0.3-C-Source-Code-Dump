using UnityEngine;
internal sealed class FortBossSpawnMob : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<string> _spawnBot;
    public int maxCountSpawnMob;
    public float timeForSpawnMob;
    private System.Collections.Generic.List<RilisoftBot.BaseBot> 世丞且丒丑丈丈与丞;
    private const string 不万丈丐丘上世丑丗 = "DungeonMobs/";
    private UnityEngine.Coroutine 丘上下与丟一丘丙丁;
    private RilisoftBot.BaseBot 丅万丗丕丑丑东丌丙;
    
    // Methods
    private void Awake()
    {
        this.丐丌丗丐丐丟丈上一();
        if(this.丅万丗丕丑丑东丌丙 == 0)
        {
                this.丅万丗丕丑丑东丌丙 = this.gameObject.GetComponent<RilisoftBot.BaseBot>();
        }
        
        RilisoftBot.BotAiController.丞上丗一丅与丛且丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortBossSpawnMob::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
    }
    private void OnDestroy()
    {
        System.Collections.Generic.List<RilisoftBot.BaseBot> val_6;
        RilisoftBot.BotAiController.丞丁丆丘丌丝丏三丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortBossSpawnMob::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
        val_6 = this.世丞且丒丑丈丈与丞;
        List.Enumerator<T> val_2 = val_6.GetEnumerator();
        label_7:
        if(((-1738401928) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_3.ApplyDamage(丞丈专下丈专业三丞:  val_3.maxHealth, 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丐丟丘世丁三丕专专:  0, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
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
        return (System.Collections.IEnumerator)new FortBossSpawnMob.世丂专专丙业丈丆上();
    }
    private void 上丌万丁丄丅一丐丙()
    {
        var val_3 = null;
        if((FortBossSpawnMob.<>c.<>9__11_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        int val_1 = this.世丞且丒丑丈丈与丞.RemoveAll(match:  FortBossSpawnMob.<>c.<>9__11_0);
        return;
        label_3:
        FortBossSpawnMob.<>c.<>9__11_0 = new System.Predicate<RilisoftBot.BaseBot>(object:  FortBossSpawnMob.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortBossSpawnMob.<>c::丞下丘丝下丞丏丄丞(RilisoftBot.BaseBot 三丟东丕丄丄下下丑));
        if(this.世丞且丒丑丈丈与丞 != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void 丟丕丏专专丙专丂丗(string 丗丙丒一且丝丂丒世)
    {
        string val_17 = 丗丙丒一且丝丂丒世;
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(3 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(3 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 3;
        object val_17 = this.丅万丗丕丑丑东丌丙.photonView.instantiationData[1];
        val_1[1] = System.Convert.ToInt32(value:  21884928);
        val_1[2] = this.丅万丗丕丑丑东丌丙.photonView.viewID;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_17 = "DungeonMobs/"("DungeonMobs/") + val_17;
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.3f);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Quaternion val_15 = this.transform.rotation;
        UnityEngine.GameObject val_16 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  val_17, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_1);
    }
    private void 丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        UnityEngine.Object val_12 = 1152921504848912384;
        if(丑丁一丛万丘万丗不 == 0)
        {
                return;
        }
        
        val_12 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_12 == 0)
        {
                return;
        }
        
        val_12 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_4.丞丁丝丕世丏丌丞丁 == null)
        {
                return;
        }
        
        PhotonView val_5 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        val_12 = val_5.丞丁丝丕世丏丌丞丁;
        if(val_5.丞丁丝丕世丏丌丞丁.Length == 0)
        {
                return;
        }
        
        PhotonView val_6 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        val_12 = val_6.丞丁丝丕世丏丌丞丁;
        object val_12 = val_12[0];
        if(null != 3)
        {
                return;
        }
        
        PhotonView val_7 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        val_12 = val_7.丞丁丝丕世丏丌丞丁[2];
        if(null != this.丅万丗丕丑丑东丌丙.photonView.viewID)
        {
                return;
        }
        
        RilisoftBot.BaseBot val_10 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
        val_10.七丄丆丛丌世丁且专 = true;
        this.世丞且丒丑丈丈与丞.Add(item:  丑丁一丛万丘万丗不.七与世丄丞丒一七三());
    }
    public FortBossSpawnMob()
    {
        this._spawnBot = new System.Collections.Generic.List<System.String>();
        this.maxCountSpawnMob = 3;
        this.timeForSpawnMob = 10f;
        this.世丞且丒丑丈丈与丞 = new System.Collections.Generic.List<RilisoftBot.BaseBot>();
    }

}
