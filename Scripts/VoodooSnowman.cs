using UnityEngine;
internal sealed class VoodooSnowman : TurretController
{
    // Fields
    private 丅丙上七上一丐不下 丈万丛丐世丑丛丒且;
    private bool 上下丂丛且东万业与;
    private float 与丙丕万业下且专三;
    private const float 上一业丌丒丑丆上丑 = 0.4;
    private bool 丐丝丁丒下万丂下丞;
    private float 丏丗丒丂丞丏丈七丂;
    private string 上丑丏丄一万丆专东;
    
    // Properties
    public 丅丙上七上一丐不下 丝丟丛不世丏下万丑 { get; }
    
    // Methods
    public 丅丙上七上一丐不下 get_VoodooTarget()
    {
        return (丅丙上七上一丐不下)this.丈万丛丐世丑丛丒且;
    }
    public override void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        var val_18;
        if(this.上下丂丛且东万业与 == false)
        {
                return;
        }
        
        if((this.丈万丛丐世丑丛丒且 & 1) != 0)
        {
                return;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(this.丈万丛丐世丑丛丒且.IsDead() != false)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.与丅丟三丂丞丟丐丌());
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.与丅丟三丂丞丟丐丌());
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_7 = this.GetComponent<UnityEngine.AudioSource>();
            val_7.PlayOneShot(clip:  this.丈万丛丐世丑丛丒且);
        }
        
        this.与丙丕万业下且专三 = (this.与丙丕万业下且专三 < 0) ? 0f : (this.与丙丕万业下且专三 - 丞丈专下丈专业三丞);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        var val_18 = 0;
        val_18 = val_18 + 1;
        this.丈万丛丐世丑丛丒且.ApplyDamage(丞丈专下丈专业三丞:  (this.与丙丕万业下且专三 < 0) ? this.与丙丕万业下且专三 : 丞丈专下丈专业三丞, 丛世一丟丞丁业丘丒:  丛世一丟丞丁业丘丒, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, 丐丟丘世丁三丕专专:  丐丟丘世丁三丕专专, 东丏业丞丞业下丄世:  东丏业丞丞业下丄世, 丝三丛且丘不丌丙下:  val_7, 丒丈丐丐丗丐专丈丏:  丒丈丐丐丗丐专丈丏);
        var val_19 = 0;
        val_19 = val_19 + 1;
        bool val_14 = this.丈万丛丐世丑丛丒且.IsDead();
        丛丐丒上丒丘丆丕与(万丐七下丂丂丛世丞:  val_14, 且世与七东丕丈丗丁:  false, 世丕与丙丄丙不丄丝:  false);
        val_18 = null;
        val_18 = null;
        丐丐丙丕丒丘三上丒(三丕丕七丘不专丏且:  val_14, 不丕丅三丕丏丕上专:  丐丟丘世丁三丕专专);
    }
    public override bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        if(X20 == 0)
        {
            
        }
    
    }
    protected override void 下专专专丄世丗且丐()
    {
        var val_2;
        this.下专专专丄世丗且丐();
        if(true != 0)
        {
                val_2 = null;
            val_2 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_6;
        }
        
        }
        
            if(this.上下丂丛且东万业与 != true)
        {
                this.不丑丒丁丌丛下丆三();
        }
        
        }
        
        label_6:
        if(this.上下丂丛且东万业与 == false)
        {
                return;
        }
        
        if(((this.丈万丛丐世丑丛丒且 & 1) == 0) && (this.与丙丕万业下且专三 > 0f))
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            bool val_2 = this.丈万丛丐世丑丛丒且.IsDead();
            if(val_2 == false)
        {
                return;
        }
        
        }
        
        if(val_2 != false)
        {
                val_2.Invoke();
        }
        
        this.SendImKilledRPC();
    }
    private void 不丑丒丁丌丛下丆三()
    {
        var val_27;
        var val_28;
        int val_29;
        var val_30;
        float val_31;
        var val_32;
        Player_move_c val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        val_27 = null;
        val_27 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(GameConnect.丙丘不世专且万丄丐() == false)
        {
            goto label_6;
        }
        
        }
        
        val_28 = null;
        val_28 = null;
        val_29 = 1152921519068977584;
        if(丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Count < 1)
        {
            goto label_55;
        }
        
        val_30 = null;
        val_30 = null;
        val_29 = UnityEngine.Random.Range(min:  0, max:  丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Count);
        UnityEngine.GameObject val_5 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Item[val_29];
        if(val_5 == 0)
        {
            goto label_55;
        }
        
        val_29 = val_5.transform;
        this.丈万丛丐世丑丛丒且 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_29);
        float val_10 = val_5.GetComponent<RilisoftBot.BaseBot>().baseHealth;
        val_31 = 0.4f;
        goto label_23;
        label_6:
        System.Collections.Generic.List<Player_move_c> val_11 = new System.Collections.Generic.List<Player_move_c>(capacity:  9);
        val_29 = 0;
        goto label_24;
        label_53:
        val_32 = null;
        val_32 = null;
        val_33 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if((val_33.Equals(other:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙)) != true)
        {
                val_34 = null;
            val_34 = null;
            Player_move_c val_14 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_14.万丝一万丐且丌业丛 != true)
        {
                val_35 = null;
            val_35 = null;
            if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丏下丙丞丕丕丏丕丞() != true)
        {
                val_36 = null;
            val_36 = null;
            Player_move_c val_17 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if((val_17.丂七一业下丈业丕丒.IsEnemyTo(专丞上七七且丝七丗:  val_33)) != false)
        {
                val_37 = null;
            val_37 = null;
            val_11.Add(item:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0]);
        }
        
        }
        
        }
        
        }
        
        val_29 = 1;
        label_24:
        val_38 = null;
        val_38 = null;
        if(val_29 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_53;
        }
        
        if(val_11.Count < 1)
        {
            goto label_55;
        }
        
        int val_23 = UnityEngine.Random.Range(min:  0, max:  val_11.Count);
        val_39 = null;
        val_39 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false))
        {
            goto label_63;
        }
        
        val_33 = System.Array.Empty<System.Object>();
        val_23.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  87, 万丌万丅专丞业丈万:  val_24.photonView.owner, 丗丟上上丒丐丗丞丙:  val_33);
        goto label_67;
        label_63:
        if(val_11.Item[val_23] == null)
        {
            goto label_68;
        }
        
        label_67:
        this.丈万丛丐世丑丛丒且 = val_24.丂七一业下丈业丕丒;
        goto label_69;
        label_68:
        this.丈万丛丐世丑丛丒且 = 0;
        label_69:
        val_29 = val_24.mySkinName.playerMoveC;
        val_31 = 0.4f;
        float val_27 = (float)val_24.mySkinName.playerMoveC.丄丞丘不下七一丘丘;
        val_27 = (float)val_24.mySkinName.playerMoveC.丅三业丆丄丝丝丕东 + val_27;
        label_23:
        val_27 = val_27 * val_31;
        this.与丙丕万业下且专三 = val_27;
        label_55:
        if(this.丈万丛丐世丑丛丒且 == null)
        {
                return;
        }
        
        this.上下丂丛且东万业与 = true;
    }
    public override bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_6;
        var val_7;
        int val_8;
        val_6 = 丞世不丒下上上丝丑;
        byte val_1 = val_6 & 255;
        if(val_1 > 87)
        {
            goto label_1;
        }
        
        if(val_1 > 32)
        {
            goto label_2;
        }
        
        byte val_2 = val_6 & 255;
        if(val_2 == 24)
        {
            goto label_3;
        }
        
        if(val_2 != 32)
        {
            goto label_18;
        }
        
        if(专丒丌丆下丐丞丟丞.Length == 0)
        {
            goto label_6;
        }
        
        object val_6 = 专丒丌丆下丐丞丟丞[0];
        this.丑丕一一丄丘万丗丆(一丆丌丝专丂丛丙上:  false);
        goto label_36;
        label_1:
        if(val_1 > 104)
        {
            goto label_9;
        }
        
        byte val_3 = val_6 & 255;
        if(val_3 == 92)
        {
            goto label_10;
        }
        
        if(val_3 != 104)
        {
            goto label_18;
        }
        
        this.丏且上丌丘丈世丂世();
        goto label_36;
        label_2:
        byte val_4 = val_6 & 255;
        if(val_4 == 37)
        {
            goto label_13;
        }
        
        if(val_4 != 87)
        {
            goto label_18;
        }
        
        this.丁丏且丒丗且下丙丈();
        goto label_36;
        label_9:
        byte val_5 = val_6 & 255;
        if(val_5 == 166)
        {
            goto label_16;
        }
        
        if(val_5 == 119)
        {
            goto label_17;
        }
        
        if(val_5 != 110)
        {
            goto label_18;
        }
        
        object val_7 = 专丒丌丆下丐丞丟丞[0];
        this.且不专丙业下丝一下(丒七上丘不丝丁丘与:  21884928);
        goto label_36;
        label_18:
        val_7 = 0;
        return (bool)val_7;
        label_3:
        val_8 = 专丒丌丆下丐丞丟丞.Length;
        if(val_8 == 0)
        {
                val_8 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞[0];
        object val_8 = 专丒丌丆下丐丞丟丞[1];
        this.丟丄丌万丙丘丑丆丘(丛业专丘丂丅丗丝丛:  3.782474E-38f, 丞丗且下世丐业丌丙:  21884928);
        goto label_36;
        label_10:
        this.世且丂丕丐丝丐丐且();
        goto label_36;
        label_13:
        object val_9 = 专丒丌丆下丐丞丟丞[0];
        this.万东专下丆丝丒丙世(丞丗且下世丐业丌丙:  21884928);
        goto label_36;
        label_16:
        object val_10 = 专丒丌丆下丐丞丟丞[0];
        this.且业丆七丌丙且万丌(丒七上丘不丝丁丘与:  21884928);
        goto label_36;
        label_17:
        object val_11 = 专丒丌丆下丐丞丟丞[0];
        this.丙东丟丌丂丝丝七万(丝三不七丑丏一业丑:  3.782474E-38f);
        goto label_36;
        label_6:
        this.丐丕与丟七与三丂业();
        label_36:
        val_7 = 1;
        return (bool)val_7;
    }
    private void 丁丏且丒丗且下丙丈()
    {
        var val_2;
        var val_3;
        this.丐丝丁丒下万丂下丞 = true;
        val_2 = null;
        val_2 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        丅丟一专专上丘万丗(丂丛丆万丁丆下三丘:  this.上丑丏丄一万丆专东, 三丛丄一东丑丁且业:  15, 丘万丟丕与专丁三丘:  this.丏丗丒丂丞丏丈七丂, 丆丅丅丂下丏丏丞丂:  0);
    }
    protected override void 一丕万东丟丏丄业丅(丕丈丏丝丗下丟丅丂 东一丁世丑丞业丄丐, int 丈丘丝一丗下丈丐不, int 东丄丗丂且丞不东丈)
    {
        丕丈丏丝丗下丟丅丂 val_4;
        var val_5;
        val_4 = 东一丁世丑丞业丄丐;
        this.一丕万东丟丏丄业丅(东一丁世丑丞业丄丐:  val_4, 丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不, 东丄丗丂且丞不东丈:  东丄丗丂且丞不东丈);
        this.上丑丏丄一万丆专东 = val_4.业上丙丞丐丄丆丅七();
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        val_4 = val_4.业上丙丞丐丄丆丅七();
        this.丏丗丒丂丞丏丈七丂 = BalanceController.业不一丒下丑丄万丏(丗丑丐丕丟丝且下丕:  val_4, 丂丄丆丁丘丝丞丐不:  丈丘丝一丗下丈丐不);
    }
    protected override void 丐丐丗丒丂上下万且()
    {
        Player_move_c val_2;
        var val_3;
        var val_4;
        val_2 = this;
        this.丐丐丗丒丂上下万且();
        if(this.丐丝丁丒下万丂下丞 == false)
        {
                return;
        }
        
        this.丐丝丁丒下万丂下丞 = false;
        val_3 = null;
        val_3 = null;
        val_2 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_2 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_2 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        专万世丂不丅丏世七(丏不丂丆且三丞丆丏:  15);
    }
    protected override void 丐一丒丝与三上丅七()
    {
        Player_move_c val_2;
        var val_3;
        var val_4;
        val_2 = this;
        this.丐一丒丝与三上丅七();
        if(this.丐丝丁丒下万丂下丞 == false)
        {
                return;
        }
        
        this.丐丝丁丒下万丂下丞 = false;
        val_3 = null;
        val_3 = null;
        val_2 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_2 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_2 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        专万世丂不丅丏世七(丏不丂丆且三丞丆丏:  15);
    }
    public override void StartTurret()
    {
        this.StartTurret();
    }
    public VoodooSnowman()
    {
        this.丏丗丒丂丞丏丈七丂 = 5f;
        this.上丑丏丄一万丆专东 = "";
    }

}
