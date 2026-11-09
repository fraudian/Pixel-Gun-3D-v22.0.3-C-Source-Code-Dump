using UnityEngine;
internal class TurretController_ArmorRegeneration : TurretController
{
    // Fields
    public float regenerateRadius;
    public float timeRegenerate;
    private float 丗丅东丏丟丈三上专;
    private float 丝上丘专丞一丄丗丁;
    
    // Methods
    protected override void 下专专专丄世丗且丐()
    {
        var val_9;
        var val_10;
        var val_11;
        this.下专专专丄世丗且丐();
        if(true == 0)
        {
                return;
        }
        
        if(0 != 0)
        {
                return;
        }
        
        if(0 != 0)
        {
                if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.time;
        if(this.丗丅东丏丟丈三上专 >= 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        val_10 = null;
        val_10 = null;
        UnityEngine.Vector3 val_6 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        float val_9 = this.regenerateRadius;
        val_9 = val_9 * val_9;
        if(val_7.x >= 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        typeof(Player_move_c).__il2cppRuntimeField_DE0.下东丞丆专丟丙丝丒(下丝丘丁专丐丅丛丝:  this.丝上丘专丞一丄丗丁);
        丌与专丑不且专丌一(丞丂丌丆丅丘下与丕:  this.丝上丘专丞一丄丗丁, 丑东与丅丐丅丂丞业:  1);
        float val_8 = UnityEngine.Time.time;
        val_8 = val_8 + this.timeRegenerate;
        this.丗丅东丏丟丈三上专 = val_8;
    }
    protected override void 一丕万东丟丏丄业丅(丕丈丏丝丗下丟丅丂 东一丁世丑丞业丄丐, int 丈丘丝一丗下丈丐不, int 东丄丗丂且丞不东丈)
    {
        this.一丕万东丟丏丄业丅(东一丁世丑丞业丄丐:  东一丁世丑丞业丄丐, 丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不, 东丄丗丂且丞不东丈:  东丄丗丂且丞不东丈);
        this.丝上丘专丞一丄丗丁 = BalanceController.三丁丟万丄与丌丒与(丗丑丐丕丟丝且下丕:  东一丁世丑丞业丄丐.业上丙丞丐丄丆丅七(), 丂丄丆丁丘丝丞丐不:  丈丘丝一丗下丈丐不, 丙丂丏丛丌丏下丝不:  东丄丗丂且丞不东丈);
        this.regenerateRadius = 东一丁世丑丞业丄丐.丏丕丄东世丕三丆丘();
    }
    public TurretController_ArmorRegeneration()
    {
        mem2[0] = 2139095040;
        this.丝上丘专丞一丄丗丁 = 1f;
    }

}
