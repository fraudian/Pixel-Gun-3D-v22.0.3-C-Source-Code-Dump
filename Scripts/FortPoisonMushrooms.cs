using UnityEngine;
internal class FortPoisonMushrooms : FortTrap
{
    // Fields
    public float damagePercent;
    private float 丂丐丈丕丞下丁下丘;
    private int 丂上上不一丐业一丕;
    private float 丙一丑丏丁一且丒业;
    
    // Methods
    public override void DetectTargets()
    {
        var val_10;
        var val_11;
        var val_12;
        float val_13;
        float val_14;
        if(this.丙一丑丏丁一且丒业 >= 0f)
        {
            goto label_1;
        }
        
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if((this & 1) == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        UnityEngine.Vector3 val_2 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_13 = 0f;
        if(val_5.x == 0)
        {
            goto label_20;
        }
        
        val_14 = val_5.x.不七不丈丐万丂丌下();
        if(val_5.x == 0)
        {
            goto label_22;
        }
        
        val_13 = val_5.x.不七不丈丐万丂丌下();
        goto label_22;
        label_1:
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = this.丙一丑丏丁一且丒业 - val_8;
        this.丙一丑丏丁一且丒业 = val_8;
        return;
        label_20:
        val_14 = 0f;
        label_22:
        float val_9 = val_14 * val_13;
        if(val_5.x >= 0)
        {
                return;
        }
    
    }
    public override void DetectedTarget()
    {
        this.丁丛丏上一业七上丁();
    }
    private void 丁丛丏上一业七上丁()
    {
        var val_3;
        WeaponManager val_4;
        val_3 = null;
        val_3 = null;
        val_4 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_3;
        }
        
        val_4 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        label_3:
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        float val_2 = this.下与丗丒丐三丕丘丈();
        丈丞与与丕丕一丝世(丞下万上三丘上与专:  WeaponManager.丟丗丄业丘丗业丗七.myPlayer, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 丂丐丄丁丆与丈丂上:  new 丛上一丂不业丒丄丏() {丈丒丄丝丐专丐丙丌 = 0f, 丂丐丈丕丞下丁下丘 = 0f, 丌丛丑三丆丘万丘丛 = false});
        this.丙一丑丏丁一且丒业 = this.丂丐丈丕丞下丁下丘;
        return;
        label_4:
    }
    public override void StartDeactivate()
    {
        if(true != 0)
        {
                return;
        }
        
        mem[1152921526064010660] = 1;
        if(137105408 != 0)
        {
                SetActive(value:  false);
        }
        
        this.Invoke(methodName:  "DeactivateDelayed", time:  null);
        UnityEngine.GameObject val_3 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  "Explosion47"));
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.transform.position;
        val_3.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public FortPoisonMushrooms()
    {
        this.丂丐丈丕丞下丁下丘 = 3f;
        this.丂上上不一丐业一丕 = 3;
        this.丙一丑丏丁一且丒业 = -1f;
        mem[1152921526064139024] = 1073741824;
        mem[1152921526064139048] = 1073741824;
        val_1 = new FortEquipObject();
    }

}
