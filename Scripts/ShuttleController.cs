using UnityEngine;
public class ShuttleController : PGBehaviour
{
    // Fields
    private UnityEngine.Transform 丘丗七丒丁丝丐丑下;
    private float 万三专丝业下专丕丝;
    public bool inShuttle;
    public float speedEmptyShuttle;
    
    // Methods
    private void Awake()
    {
        this.丘丗七丒丁丝丐丑下 = this.丌丟丄业且三丛丕丄();
    }
    private void Update()
    {
        var val_20;
        var val_21;
        var val_22;
        if(this.inShuttle != false)
        {
                val_20 = 1152921505039699968;
            if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_3 = BattleRoyaleController.丑七不且上丗丁一世();
            if(val_3.isStartGame != false)
        {
                double val_20 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            double val_5 = BattleRoyaleController.丄专丕丞丟七丐丞世();
            BattleRoyaleController val_6 = BattleRoyaleController.丑七不且上丗丁一世();
            val_20 = ((float)val_20 - val_5) / val_6.timeFlyShutle;
            this.万三专丝业下专丕丝 = val_20;
            this.万三专丝业下专丕丝 = UnityEngine.Mathf.Clamp01(value:  val_20);
            BattleRoyaleController val_9 = BattleRoyaleController.丑七不且上丗丁一世();
            val_20 = BattleRoyaleController.丑七不且上丗丁一世();
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_9.startPathPoint, y = val_5, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_10.endPathPoint, y = V13.16B, z = V11.16B}, t:  this.万三专丝业下专丕丝);
            this.丘丗七丒丁丝丐丑下.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            if(this.万三专丝业下专丕丝 >= 1f)
        {
                val_20 = 1152921505286238208;
            val_21 = null;
            val_21 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_22 = null;
            val_22 = null;
            typeof(Player_move_c).__il2cppRuntimeField_628 + 456.且丘丘丌丁丂丒丟丈();
        }
        
        }
        
        }
        
        }
        
            if(this.inShuttle != false)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector3 val_13 = this.丘丗七丒丁丝丐丑下.position;
        UnityEngine.Vector3 val_15 = this.transform.forward;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  this.speedEmptyShuttle);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        this.丘丗七丒丁丝丐丑下.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
    }
    public ShuttleController()
    {
        this.inShuttle = true;
        this.speedEmptyShuttle = 100f;
    }

}
