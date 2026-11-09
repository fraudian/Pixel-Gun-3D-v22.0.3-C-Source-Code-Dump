using UnityEngine;
internal class TurretController_MedStation : TurretController
{
    // Fields
    public float healRadius;
    public float timeHeal;
    private float 与丆一丞丏丄丙专东;
    private float 业丆丙专丂三丛且七;
    
    // Methods
    protected override void 下专专专丄世丗且丐()
    {
        var val_20;
        var val_21;
        var val_22;
        WeaponManager val_23;
        float val_24;
        var val_25;
        var val_26;
        var val_27;
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
        
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.time;
        if(this.与丆一丞丏丄丙专东 >= 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        val_21 = null;
        val_21 = null;
        UnityEngine.Vector3 val_6 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        float val_20 = this.healRadius;
        val_20 = val_20 * val_20;
        if(val_7.x >= 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_25;
        }
        
        val_23 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_23 == null)
        {
            goto label_26;
        }
        
        label_25:
        float val_21 = 0.02f;
        val_21 = this.业丆丙专丂三丛且七 * val_21;
        val_24 = val_21 * typeof(Player_move_c).__il2cppRuntimeField_600.maxHealth;
        if((丂丟丙丂丕专丂七下(上上丗丁丏丙丄丏七:  val_24, 丑东与丅丐丅丂丞业:  3)) != false)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                GadgetsSFX.__il2cppRuntimeField_generic_class.Play();
        }
        
        }
        
        val_25 = null;
        val_25 = null;
        if(与丆一业七与不不丄() != 0)
        {
                val_26 = null;
            val_26 = null;
            if(与丆一业七与不不丄().丐丂丌丗丆丛东丘丁() != false)
        {
                val_27 = null;
            val_27 = null;
            float val_22 = 0.01f;
            val_22 = this.业丆丙专丂三丛且七 * val_22;
            val_24 = val_22 * 与丆一业七与不不丄().maxHealth;
            float val_18 = 与丆一业七与不不丄().丅丝丐丗专丗丝不丈(丞丅丑世丑丅丘万三:  val_24);
        }
        
        }
        
        float val_19 = UnityEngine.Time.time;
        val_19 = val_19 + this.timeHeal;
        this.与丆一丞丏丄丙专东 = val_19;
        return;
        label_26:
    }
    protected override void 一丕万东丟丏丄业丅(丕丈丏丝丗下丟丅丂 东一丁世丑丞业丄丐, int 丈丘丝一丗下丈丐不, int 东丄丗丂且丞不东丈)
    {
        this.一丕万东丟丏丄业丅(东一丁世丑丞业丄丐:  东一丁世丑丞业丄丐, 丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不, 东丄丗丂且丞不东丈:  东丄丗丂且丞不东丈);
        string val_4 = 东一丁世丑丞业丄丐.业上丙丞丐丄丆丅七();
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                float val_5 = BalanceController.丄专万上三世丘不不(丗丑丐丕丟丝且下丕:  val_4, 丂丄丆丁丘丝丞丐不:  东一丁世丑丞业丄丐.上丙丘丝丅丁丗丐万, 丙丂丏丛丌丏下丝不:  BalanceController.丈丅三丙东丕东下丐(丞世不丒下上上丝丑:  东一丁世丑丞业丄丐.业东丅东丌上丗丑不()));
        }
        
        this.业丆丙专丂三丛且七 = BalanceController.丄专万上三世丘不不(丗丑丐丕丟丝且下丕:  val_4);
    }
    public TurretController_MedStation()
    {
        mem2[0] = 2139095040;
        this.业丆丙专丂三丛且七 = 1f;
    }

}
