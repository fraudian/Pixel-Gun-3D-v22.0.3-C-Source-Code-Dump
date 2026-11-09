using UnityEngine;
public class AirDropItem : PGBehaviour
{
    // Fields
    public double timeStart;
    public float heightFly;
    public double timeFly;
    public int chestIndex;
    public UnityEngine.Transform shuttle;
    public UnityEngine.GameObject smokePrefab;
    public UnityEngine.GameObject curSmoke;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        float val_19;
        var val_20;
        UnityEngine.GameObject val_21;
        var val_22;
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() <= 0f)
        {
                return;
        }
        
        if(this.timeStart <= 0f)
        {
            goto label_7;
        }
        
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_19 = this.timeStart + this.timeFly;
        if(val_19 >= 0)
        {
            goto label_7;
        }
        
        this.timeStart = -1;
        val_20 = null;
        val_20 = null;
        ChestBatleRoyale[] val_3 = ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + ((this.chestIndex) << 3);
        mem[(ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + (this.chestIndex) << 3) + 32].gameObject.SetActive(value:  true);
        ChestBatleRoyale[] val_5 = ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + ((this.chestIndex) << 3);
        mem[(ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + (this.chestIndex) << 3) + 32].IsActiveChest = true;
        ChestBatleRoyale[] val_6 = ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + ((this.chestIndex) << 3);
        val_21 = 1152921504848912384;
        if((mem[(ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + (this.chestIndex) << 3) + 32] + 72) != 0)
        {
            goto label_25;
        }
        
        val_22 = null;
        val_22 = null;
        ChestBatleRoyale[] val_9 = ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + ((this.chestIndex) << 3);
        this.curSmoke.transform.parent = mem[(ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + (this.chestIndex) << 3) + 32].transform;
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Euler(x:  -90f, y:  0f, z:  0f);
        val_19 = val_12.y;
        this.curSmoke.transform.localRotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_19, z = val_12.z, w = val_12.w};
        ChestBatleRoyale[] val_13 = ChestsBattleRoyaleController.丄丘七三上丕世丞业.airDropChests + ((this.chestIndex) << 3);
        val_21 = this.curSmoke;
        mem2[0] = val_21;
        goto label_42;
        label_7:
        double val_14 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_14 = val_14 - this.timeStart;
        val_14 = val_14 / this.timeFly;
        float val_18 = (float)val_14;
        float val_19 = 1f;
        val_18 = val_19 - val_18;
        val_19 = this.heightFly * val_18;
        this.shuttle.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_25:
        UnityEngine.Object.Destroy(obj:  this.curSmoke);
        label_42:
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  20000f);
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
    }
    public AirDropItem()
    {
        this.timeStart = -1;
        this.heightFly = 200f;
        this.timeFly = 15;
    }

}
