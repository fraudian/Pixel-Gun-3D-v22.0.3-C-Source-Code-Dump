using UnityEngine;
internal sealed class GeneratorControllerScene_Medical : GeneratorControllerScene
{
    // Fields
    private float _healingTime;
    private bool 丒丙丞丞且丌七丌上;
    private UnityEngine.Transform 世且丄一丑下丝丟丕;
    private float 丘丅丆业世丂丝丝丐;
    
    // Methods
    internal override void 上丛丌丆丑上七世三(byte 丞丅上丏丂且下丅与, BaseEquipmentController 丒专丈丛下丒一丒丛)
    {
        this.上丛丌丆丑上七世三(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
        if(true == 0)
        {
                return;
        }
        
        if(丒专丈丛下丒一丒丛 == null)
        {
                return;
        }
    
    }
    private void 丁三丗丛丕万七东丗()
    {
        InGameGUI val_12;
        var val_13;
        var val_14;
        var val_15;
        float val_16;
        float val_17;
        var val_18;
        val_12 = this;
        val_13 = null;
        val_13 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        UnityEngine.Vector3 val_4 = transform.position;
        UnityEngine.Vector3 val_5 = this.世且丄一丑下丝丟丕.position;
        val_16 = val_4.x;
        val_17 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_16, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if(0 != 0)
        {
                float val_7 = 0.不七不丈丐万丂丌下();
        }
        else
        {
                val_16 = 0f;
        }
        
        if(val_17 > val_16)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        val_17 = this.下与丗丒丐三丕丘丈();
        float val_12 = 0.01f;
        val_12 = val_17 * val_12;
        val_12 = val_12 * typeof(Player_move_c).__il2cppRuntimeField_600.maxHealth;
        if((丂丟丙丂丕专丂七下(上上丗丁丏丙丄丏七:  val_12, 丑东与丅丐丅丂丞业:  6)) == false)
        {
                return;
        }
        
        val_12 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_12 == 0)
        {
                return;
        }
        
        GadgetsSFX.__il2cppRuntimeField_generic_class.Play();
    }
    internal void 丏丒丛下世不丛下万(UnityEngine.Transform 丅专与丒丈丗丒丘丌)
    {
        this.世且丄一丑下丝丟丕 = 丅专与丒丈丗丒丘丌;
    }
    private void Update()
    {
        if(true != 0)
        {
                if(TankController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
            if(TankController.丄丘七三上丕世丞业.丆世丙丈一丕丆丞丆 == 0)
        {
                return;
        }
        
        }
        
        if(this.丒丙丞丞且丌七丌上 == false)
        {
                return;
        }
        
        if(this.丒丙丞丞且丌七丌上 == false)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.丘丅丆业世丂丝丝丐 + val_3;
        this.丘丅丆业世丂丝丝丐 = val_3;
        if(val_3 <= this._healingTime)
        {
                return;
        }
        
        this.丁三丗丛丕万七东丗();
        this.丘丅丆业世丂丝丝丐 = 0f;
    }
    public GeneratorControllerScene_Medical()
    {
        this._healingTime = 5f;
        val_1 = new FortEquipObject();
    }

}
