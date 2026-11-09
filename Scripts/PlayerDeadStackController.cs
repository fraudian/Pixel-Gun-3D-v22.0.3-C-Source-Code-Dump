using UnityEngine;
public class PlayerDeadStackController : MonoBehaviour
{
    // Fields
    internal static PlayerDeadStackController 丄丞丁丈与业上丞丟;
    public PlayerDeadController[] playerDeads;
    public UnityEngine.GameObject playerDeadObject;
    public UnityEngine.GameObject playerDeadObjectLow;
    public UnityEngine.GameObject playerDeadObjectImposter;
    private int 与不丞丕东丅丁下三;
    public int stackSize;
    
    // Methods
    private void Start()
    {
        UnityEngine.GameObject val_3;
        UnityEngine.GameObject val_4;
        var val_5;
        var val_6;
        UnityEngine.GameObject val_7;
        PlayerDeadStackController.丄丞丁丈与业上丞丟 = this;
        this.playerDeads = new PlayerDeadController[0];
        this.playerDeadObject.SetActive(value:  false);
        this.playerDeadObjectLow.SetActive(value:  false);
        this.playerDeadObjectImposter.SetActive(value:  false);
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                val_3 = this.playerDeadObjectImposter;
            UnityEngine.Object.Destroy(obj:  this.playerDeadObject);
            val_4 = this.playerDeadObjectLow;
        }
        else
        {
                val_5 = null;
            val_5 = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                val_6 = 1152921504848912384;
            val_7 = this.playerDeadObject;
            val_3 = this.playerDeadObjectLow;
        }
        else
        {
                val_6 = 1152921504848912384;
            val_3 = this.playerDeadObject;
            val_7 = this.playerDeadObjectLow;
        }
        
            UnityEngine.Object.Destroy(obj:  val_7);
            val_4 = this.playerDeadObjectImposter;
        }
        
        UnityEngine.Object.Destroy(obj:  val_4);
        val_3.SetActive(value:  true);
        this.丁丂与世丈业世三丌(丘丁三丆丐东不丒丌:  val_3);
    }
    private void 丁丂与世丈业世三丌(UnityEngine.GameObject 丘丁三丆丐东不丒丌)
    {
        PlayerDeadController[] val_9;
        var val_10;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1000f);
        val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        val_9 = this.playerDeads;
        PlayerDeadController val_5 = 丘丁三丆丐东不丒丌.GetComponent<PlayerDeadController>();
        if(val_9 == null)
        {
            goto label_6;
        }
        
        if(val_5 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_5 == null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_9[0] = val_5;
        val_10 = 1;
        goto label_12;
        label_25:
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丘丁三丆丐东不丒丌);
        val_6.transform.parent = val_1;
        val_9 = this.playerDeads;
        PlayerDeadController val_8 = val_6.GetComponent<PlayerDeadController>();
        if(val_9 == null)
        {
            goto label_18;
        }
        
        if(val_8 != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(val_8 == null)
        {
            goto label_22;
        }
        
        label_19:
        label_22:
        val_10 = 2;
        val_9[1] = val_8;
        label_12:
        if(val_10 < this.playerDeads.Length)
        {
            goto label_25;
        }
    
    }
    public PlayerDeadController GetFirstUnusedPlayerDead()
    {
        int val_2;
        PlayerDeadController val_3;
        val_2 = this.与不丞丕东丅丁下三;
        if(val_2 >= (this.stackSize - 1))
        {
                val_2 = 0;
            this.与不丞丕东丅丁下三 = 0;
        }
        
        if(val_2 >= this.stackSize)
        {
            goto label_1;
        }
        
        label_6:
        PlayerDeadController val_3 = this.playerDeads[0];
        int val_2 = val_2 + 1;
        if(this.playerDeads[0x0][0].isInUse == false)
        {
            goto label_5;
        }
        
        if(val_2 < this.stackSize)
        {
            goto label_6;
        }
        
        label_1:
        val_3 = 0;
        return val_3;
        label_5:
        this.与不丞丕东丅丁下三 = val_2;
        val_3 = this.playerDeads[0];
        return val_3;
    }
    private void OnDestroy()
    {
        PlayerDeadStackController.丄丞丁丈与业上丞丟 = 0;
    }
    internal void 下丌与世丅万丞业丌()
    {
        if(this.stackSize < 1)
        {
                return;
        }
        
        var val_3 = 0;
        do
        {
            PlayerDeadController val_1 = this.playerDeads[0];
            if(this.playerDeads[0x0][0].isInUse != false)
        {
                this.playerDeads[0].丞丞丕丒上世专丐丗(丙业与丙丗丝不丈东:  false, 东丏业丞丞业下丄世:  0);
        }
        
            val_3 = val_3 + 1;
        }
        while(val_3 < this.stackSize);
    
    }
    internal PlayerDeadController 三三丞丞丂丒下丐丄(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 下一丟不丆且且丟丑)
    {
        PlayerDeadController[] val_4;
        var val_5;
        PlayerDeadController val_6;
        val_4 = this;
        if(this.stackSize < 1)
        {
            goto label_1;
        }
        
        val_5 = 0;
        float val_1 = 下一丟不丆且且丟丑 * 下一丟不丆且且丟丑;
        label_12:
        PlayerDeadController val_4 = this.playerDeads[0];
        if(this.playerDeads[0x0][0].isInUse == false)
        {
            goto label_5;
        }
        
        UnityEngine.Vector3 val_2 = this.playerDeads[0].丈丈丘丂万丄丟不丑();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        if(val_3.x < 0)
        {
            goto label_11;
        }
        
        label_5:
        val_5 = val_5 + 1;
        if(val_5 < this.stackSize)
        {
            goto label_12;
        }
        
        label_1:
        val_6 = 0;
        return val_6;
        label_11:
        val_4 = this.playerDeads;
        val_6 = val_4[0];
        return val_6;
    }
    public PlayerDeadStackController()
    {
        this.stackSize = 10;
    }

}
