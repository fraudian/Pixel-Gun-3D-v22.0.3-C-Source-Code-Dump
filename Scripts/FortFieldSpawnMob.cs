using UnityEngine;
internal sealed class FortFieldSpawnMob : PGBehaviour
{
    // Fields
    private const string 不万丈丐丘上世丑丗 = "DungeonMobs/";
    private string mobName;
    private UnityEngine.Transform mobSpawnPoint;
    private System.Collections.Generic.List<RilisoftBot.BaseBot> 世丞且丒丑丈丈与丞;
    private float mobSize;
    
    // Methods
    private void Start()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_1.m_Handle.name, b:  "FortFieldBuild")) == true)
        {
                return;
        }
        
        this.丟丕丏专专丙专丂丗();
        RilisoftBot.BotAiController.丞上丗一丅与丛且丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortFieldSpawnMob::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
    }
    private void 丟丕丏专专丙专丂丗()
    {
        float val_21;
        float val_22;
        UnityEngine.Object val_23;
        var val_24;
        var val_25;
        if(this.mobSpawnPoint == 0)
        {
                UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        else
        {
                UnityEngine.Vector3 val_5 = this.mobSpawnPoint.position;
        }
        
        val_21 = val_5.x;
        val_22 = val_5.z;
        UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  "DungeonMobs/"("DungeonMobs/") + this.mobName);
        if(val_7 != null)
        {
                var val_8 = (null == null) ? (val_7) : 0;
        }
        else
        {
                val_23 = 0;
        }
        
        if(val_23 == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_11 = this.丌丟丄业且三丛丕丄().rotation;
        UnityEngine.GameObject val_14 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_23, position:  new UnityEngine.Vector3() {x = val_21, y = val_5.y, z = val_22}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, parent:  this.丌丟丄业且三丛丕丄().parent);
        val_24 = 0;
        goto label_19;
        label_30:
        T val_21 = val_14.GetComponentsInChildren<UnityEngine.Renderer>()[0];
        val_25 = 0;
        goto label_21;
        label_28:
        val_21.materials[0].renderQueue = 194;
        val_25 = 1;
        label_21:
        UnityEngine.Material[] val_17 = val_21.materials;
        if(val_25 < val_17.Length)
        {
            goto label_28;
        }
        
        val_24 = 1;
        label_19:
        if(val_24 < val_15.Length)
        {
            goto label_30;
        }
        
        UnityEngine.Transform val_18 = val_14.transform;
        UnityEngine.Vector3 val_19 = val_18.localScale;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  this.mobSize);
        val_21 = val_20.x;
        val_22 = val_20.z;
        val_18.localScale = new UnityEngine.Vector3() {x = val_21, y = val_20.y, z = val_22};
    }
    private void 丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        this.世丞且丒丑丈丈与丞.Add(item:  丑丁一丛万丘万丗不.七与世丄丞丒一七三());
    }
    public FortFieldSpawnMob()
    {
        this.世丞且丒丑丈丈与丞 = new System.Collections.Generic.List<RilisoftBot.BaseBot>();
        this.mobSize = 1f;
    }

}
