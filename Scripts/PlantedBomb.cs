using UnityEngine;
internal sealed class PlantedBomb : ZoneWithActivePlayers
{
    // Fields
    private bool 世丟丂三七丕丗丌丛;
    private bool 丙丛丁丘万丌下丙丁;
    private ZoneActionSounds zoneSounds;
    private PlantedBombExplosion explosion;
    private double 丐上丗丙万丕丕不丛;
    private UnityEngine.ParticleSystem redLampParticle;
    private UnityEngine.ParticleSystem blueLampParticle;
    private UnityEngine.Vector3 丈七丅上丟丑专丅丝;
    
    // Properties
    internal bool 丗丈丆丟上不丏与三 { get; }
    internal bool 专丙丌丈丙三丝东丘 { get; }
    
    // Methods
    internal bool 丅业丑丗下丑丘丌丗()
    {
        return (bool)this.世丟丂三七丕丗丌丛;
    }
    internal bool 丒丝丗专丅丕七丗丅()
    {
        return (bool)this.丙丛丁丘万丌下丙丁;
    }
    internal override void 与七丌专丌与丆丌丒(int 业上上丏丄不上丅丈)
    {
        this.与七丌专丌与丆丌丒(业上上丏丄不上丅丈:  业上上丏丄不上丅丈);
        if(this.zoneSounds == 0)
        {
                return;
        }
        
        this.zoneSounds.三丈七七丈丞东丗东();
    }
    protected override void 专丈下丐不业万七丗(bool 东丝丁下丁东且丑业)
    {
        bool val_1 = 东丝丁下丁东且丑业;
        this.专丈下丐不业万七丗(东丝丁下丁东且丑业:  val_1);
        if(val_1 == true)
        {
                return;
        }
        
        if(this.世丟丂三七丕丗丌丛 == false)
        {
                return;
        }
        
        this.下丕丝丕丒丌丐与丌();
    }
    internal float 业不丈三不丈丏丞丘()
    {
        PlantTheBombController val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        val_7 = 0f;
        if((下一且丄不与丑东丅(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
                return (float)val_7;
        }
        
        val_8 = null;
        val_8 = null;
        val_5 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        float val_5 = (float)PlantTheBombController.丆丕丝丒不丙且丐丗.丂丟丑丌丕丌丙丙丘;
        val_5 = (UnityEngine.Time.time - (this.不世丏东丅丁丆丟东(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC))) / val_5;
        if(val_5 < 0)
        {
                return (float)val_7;
        }
        
        return (float)val_7;
    }
    internal void 业东丅一丝丐东丁丐()
    {
        var val_3;
        if(this.丙丛丁丘万丌下丙丁 == true)
        {
                return;
        }
        
        this.世丟丂三七丕丗丌丛 = true;
        val_3 = null;
        val_3 = null;
        UnityEngine.Vector3 val_2 = transform.position;
        this.丈七丅上丟丑专丅丝 = val_2;
        mem[1152921538604408540] = val_2.y;
        mem[1152921538604408544] = val_2.z;
    }
    internal void 下丕丝丕丒丌丐与丌()
    {
        this.世丟丂三七丕丗丌丛 = false;
        PlantTheBombController.丆丕丝丒不丙且丐丗.丐丌与与东丛丕丕丈();
    }
    internal override void Reset()
    {
        this.Reset();
        this.世丟丂三七丕丗丌丛 = false;
        this.丙丛丁丘万丌下丙丁 = false;
        this.丐上丗丙万丕丕不丛 = -1;
    }
    internal void 丘丒丐丒丆丑丒东上()
    {
        this.世丟丂三七丕丗丌丛 = true;
        this.丙丛丁丘万丌下丙丁 = true;
        X19.世业丒万丘丆专丘丐();
    }
    internal void 丏与东丙丑丛丌丝丛()
    {
        var val_19;
        Player_move_c val_20;
        float val_21;
        float val_22;
        var val_23;
        var val_24;
        var val_25;
        val_19 = this;
        if(this.explosion != 0)
        {
                val_20 = this.transform;
            UnityEngine.Vector3 val_4 = val_20.position;
            val_21 = val_4.x;
            val_22 = val_4.z;
            this.explosion.transform.position = new UnityEngine.Vector3() {x = val_21, y = val_4.y, z = val_22};
            this.explosion.丆丌且丙丝不万丂丆();
        }
        
        val_23 = null;
        val_23 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.transform.position;
        val_21 = val_7.x;
        val_22 = val_7.z;
        val_20 = transform;
        UnityEngine.Vector3 val_9 = val_20.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21, y = val_7.y, z = val_22}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        if(val_10.x > 20f)
        {
                return;
        }
        
        丅丙上七上一丐不下 val_12 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  transform);
        val_24 = 0;
        if( == 0)
        {
                return;
        }
        
        if(IsDead() == true)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        val_20 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_20 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_19 = this.transform;
        val_21 = typeof(Player_move_c).__il2cppRuntimeField_DE0.丈下丏丟丑丐丆三不() + 专一丟丏且丆丕丝七();
        UnityEngine.Vector3 val_18 = val_19.position;
        val_22 = val_18.y;
        ApplyDamage(丞丈专下丈专业三丞:  val_21, 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_18.x, y = val_22, z = val_18.z}, 丐丟丘世丁三丕专专:  19, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
    }
    private void 世丒丅丈丆专丂丏丝()
    {
        if(this.redLampParticle == 0)
        {
                return;
        }
        
        this.redLampParticle.Emit(count:  1);
    }
    internal void 下丏丝丂丁丘丞丝上()
    {
        if(this.zoneSounds != 0)
        {
                this.zoneSounds.丘丁丘东与丛丁上三();
        }
        
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_2 = val_2 + 1;
        this.丐上丗丙万丕丕不丛 = val_2;
    }
    private void Update()
    {
        var val_19;
        var val_20;
        var val_21;
        double val_22;
        var val_23;
        if(this.zoneSounds != 0)
        {
                this.zoneSounds.丐七丌下三专专丆丑(丙业与丙丗丝不丈东:  this.东丟下专七且与一三());
        }
        
        if((this.世三丕丒丗丅丁一丙() == false) || (this.世丟丂三七丕丗丌丛 == false))
        {
            goto label_42;
        }
        
        val_19 = null;
        val_19 = null;
        if((this.zoneSounds.下一且丄不与丑东丅(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
            goto label_42;
        }
        
        val_20 = null;
        val_20 = null;
        if(丗丞业丐丛三上丄丕() == true)
        {
            goto label_16;
        }
        
        val_21 = null;
        val_21 = null;
        UnityEngine.Transform val_7 = transform;
        UnityEngine.Vector3 val_8 = val_7.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.丈七丅上丟丑专丅丝, y = V11.16B, z = V10.16B});
        if(val_9.x <= 0.01f)
        {
            goto label_24;
        }
        
        label_16:
        this.下丕丝丕丒丌丐与丌();
        label_42:
        val_22 = this.丐上丗丙万丕丕不丛;
        double val_10 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(val_22 >= 0)
        {
                return;
        }
        
        if(this.zoneSounds != 0)
        {
                this.zoneSounds.丆万丑丞丅丕下上丞();
        }
        
        this.世丒丅丈丆专丂丏丝();
        val_22 = 0.不丙万万丗且丞丌专() - 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        double val_14 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_14 = val_14 + ((val_22 > 5) ? 1 : 0.5);
        this.丐上丗丙万丕丕不丛 = val_14;
        return;
        label_24:
        val_23 = null;
        val_23 = null;
        if((UnityEngine.Time.time - (val_7.不世丏东丅丁丆丟东(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC))) < (float)PlantTheBombController.丆丕丝丒不丙且丐丗.丂丟丑丌丕丌丙丙丘)
        {
            goto label_42;
        }
        
        PlantTheBombController.丆丕丝丒不丙且丐丗.东丆丄下丑业与丘七();
        this.丘丒丐丒丆丑丒东上();
        goto label_42;
    }
    public PlantedBomb()
    {
        this.丐上丗丙万丕丕不丛 = -1;
    }

}
