using UnityEngine;
internal sealed class TurretControllerScene_TeslaZap : TurretControllerScene_Tower
{
    // Fields
    private int _countRebound;
    private float _percentDeclinePerRebound;
    private System.Collections.Generic.List<不七世丁丟丏世业丑> _listIdTargetsBuffer;
    private MiniPoolMonoBehaviour _miniPool;
    private UnityEngine.Transform pointFromShoot;
    private System.Collections.Generic.List<丅丙上七上一丐不下> 丟丂上丈丝万丟下丝;
    
    // Methods
    protected override void 丟丞丆上上丁丅下丐()
    {
        var val_44;
        float val_46;
        var val_48;
        System.Collections.Generic.List<不七世丁丟丏世业丑> val_49;
        PhotonView val_50;
        float val_52;
        float val_53;
        float val_54;
        var val_56;
        var val_57;
        var val_60;
        val_46 = 0;
        丅丙上七上一丐不下 val_1 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  137129984);
        var val_49 = 0;
        val_49 = val_49 + 1;
        if(val_1.IsDead() == true)
        {
                return;
        }
        
        PhotonView val_4 = this.丕专与下丁不丆世业(丂丈丙且丈丗三丆丕:  val_1);
        val_48 = 1152921504848912384;
        if(val_4 != 0)
        {
                bool val_6 = val_4.isMine;
        }
        
        if(val_4 == 0)
        {
                return;
        }
        
        this._listIdTargetsBuffer.Clear();
        丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上 val_9 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W23, 丅七上一丈丕上丒丞:  W21);
        val_49 = 1152921504686346240;
        val_50 = val_9.世且一丄且上丄不一();
        goto label_28;
        label_34:
        var val_50 = 0;
        val_50 = val_50 + 1;
        T val_12 = val_50.Current;
        UnityEngine.Vector3 val_13 = val_12.position;
        val_52 = val_13.z;
        UnityEngine.Vector3 val_14 = val_12.position;
        val_53 = val_14.y;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_52}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_53, z = val_14.z});
        val_54 = val_15.x;
        val_46 = this.丝丟丆上业丒丕上丂() * this.丝丟丆上业丒丕上丂();
        label_28:
        var val_51 = 0;
        val_51 = val_51 + 1;
        if(val_50.MoveNext() == true)
        {
            goto label_34;
        }
        
        val_56 = 0;
        val_57 = 0;
        if(val_50 == null)
        {
            
        }
        else
        {
                var val_52 = 0;
            val_52 = val_52 + 1;
            val_50.Dispose();
        }
        
        if(( != 1) && (193 == 193))
        {
                val_56 = 0;
        }
        else
        {
                if( != false)
        {
                val_57 = 0;
        }
        
        }
        
        if(this.丄上上不丛万丝不一() == false)
        {
                return;
        }
        
        float val_22 = UnityEngine.Time.deltaTime;
        val_22 = val_54 - val_22;
        mem[1152921540634086104] = val_22;
        if(val_22 >= 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_23 = this.pointFromShoot.position;
        int val_54 = this._countRebound;
        val_54 = val_23.x;
        val_52 = val_23.z;
        label_72:
        UnityEngine.Transform val_27 = this.下丌丑丂上专专丌业(丌丆一七丈丈丄下下:  val_9, 专丂不丐一丛一丕丌:  0, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_54, y = val_23.y, z = val_52}, 丅丝不丞下东丘且不:  this.丝丟丆上业丒丕上丂() * this.丝丟丆上业丒丕上丂());
        if(val_27 != 0)
        {
                丅丙上七上一丐不下 val_29 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_27);
            不七世丁丟丏世业丑 val_30 = this.丛丞丘一丘丈丐丂丙(丂丈丙且丈丗三丆丕:  val_29);
            val_50 = val_30.丄丈丑丐丆丞丘与丗;
            var val_53 = 0;
            val_53 = val_53 + 1;
            UnityEngine.Vector3 val_33 = val_29.transform.position;
            val_49 = this._listIdTargetsBuffer;
            val_54 = val_33.x;
            val_52 = val_33.z;
            val_49.Add(item:  new 不七世丁丟丏世业丑() {丄丈丑丐丆丞丘与丗 = val_50, 丏与丅下丞丗与七下 = val_30.丏与丅下丞丗与七下});
        }
        
        val_53 = this.SplashRadius;
        val_54 = val_54 - 1;
        if(val_54 < 1)
        {
            goto label_71;
        }
        
        float val_37 = this.SplashRadius * val_53;
        if(val_27 != 0)
        {
            goto label_72;
        }
        
        label_71:
        val_56 = 1152921540634035920;
        if(this._listIdTargetsBuffer.Count < 1)
        {
            goto label_74;
        }
        
        int val_39 = this._listIdTargetsBuffer.Count;
        int[] val_40 = new int[0];
        int val_41 = this._listIdTargetsBuffer.Count;
        byte[] val_42 = new byte[0];
        val_50 = this._listIdTargetsBuffer;
        List.Enumerator<T> val_43 = val_50.GetEnumerator();
        val_49 = 1152921540634058448;
        val_48 = 1152921540634059472;
        goto label_78;
        label_84:
        ConfiguredValueTaskAwaiter val_46 = val_44.GetAwaiter();
        val_50 = val_46._value._token;
        val_40[0] = val_46._value._obj.viewID;
        val_42[0] = val_50;
        label_78:
        if((1667487984 & 1) != 0)
        {
            goto label_84;
        }
        
        val_60 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_90;
        }
        
        if((val_44 == 0) || (193 == 522))
        {
            goto label_95;
        }
        
        label_94:
        label_95:
        val_60.SendShotTargets(上世万世丐丄上丑丆:  this, 丏丌丄丆丟丝下丟丝:  val_40, 丘业丌下丁业下丐东:  val_42);
        label_74:
        mem[1152921540634086104] = this.丐丕世丂上丐丑东丂();
        return;
        label_90:
        if(val_44 != 0)
        {
            goto label_94;
        }
        
        goto label_95;
    }
    public override void AttackTargetsRPC(int[] 丏丌丄丆丟丝下丟丝, byte[] 丘业丌下丁业下丐东)
    {
        var val_24;
        var val_25;
        var val_27;
        var val_29;
        var val_31;
        var val_32;
        MiniPoolMonoBehaviour val_34;
        if(丏丌丄丆丟丝下丟丝 == null)
        {
            goto label_1;
        }
        
        label_74:
        if(丏丌丄丆丟丝下丟丝.Length != 丘业丌下丁业下丐东.Length)
        {
                return;
        }
        
        this.丟丂上丈丝万丟下丝.Clear();
        val_24 = 1152921504848912384;
        val_25 = 0;
        goto label_23;
        label_28:
        UnityEngine.Transform val_1 = this.丗丕一丁下丅世一三(世上丕丐丈世上不丏:  丏丌丄丆丟丝下丟丝[0], 丏与丅下丞丗与七下:  丘业丌下丁业下丐东[0]);
        if(val_1 != 0)
        {
                丅丙上七上一丐不下 val_3 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_1);
            if(val_3 != null)
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            if(val_3.IsDead() != true)
        {
                this.丟丂上丈丝万丟下丝.Add(item:  val_3);
        }
        
        }
        
        }
        
        val_25 = 1;
        label_23:
        if(val_25 < 丏丌丄丆丟丝下丟丝.Length)
        {
            goto label_28;
        }
        
        val_27 = 0;
        goto label_29;
        label_68:
        SetLineRendererInPositions val_6 = this._miniPool.Get<SetLineRendererInPositions>();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector3[] val_7 = new UnityEngine.Vector3[2];
        if(val_27 == 0)
        {
            goto label_33;
        }
        
        var val_30 = 0;
        val_30 = val_30 + 1;
        goto label_39;
        label_33:
        UnityEngine.Vector3 val_9 = position;
        val_7[0] = val_9;
        val_7[0] = val_9.y;
        val_7[1] = val_9.z;
        val_29 = this.丟丂上丈丝万丟下丝.Item[0];
        val_31 = null;
        var val_31 = 0;
        val_32 = 1152921505240215560;
        val_31 = val_31 + 1;
        goto label_57;
        label_39:
        UnityEngine.Vector3 val_13 = this.丟丂上丈丝万丟下丝.Item[-1].transform.position;
        val_7[0] = val_13;
        val_7[0] = val_13.y;
        val_7[1] = val_13.z;
        val_29 = this.丟丂上丈丝万丟下丝.Item[0];
        val_31 = null;
        var val_32 = 0;
        val_32 = 1152921505240215560;
        val_32 = val_32 + 1;
        label_57:
        val_24 = val_29.transform;
        UnityEngine.Vector3 val_17 = val_24.position;
        val_7[1] = val_17;
        val_7[2] = val_17.y;
        val_7[2] = val_17.z;
        if(val_6 != null)
        {
                val_6.丟三丒丂丌丒丒丕丏(一丅万丒上万七下世:  val_7);
            val_34 = this._miniPool;
        }
        else
        {
                val_6.丟三丒丂丌丒丒丕丏(一丅万丒上万七下世:  val_7);
            val_34 = this._miniPool;
        }
        
        val_6.丟上业专丈东丞丅上(丝东丄不不东丐不不:  val_34);
        if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  this.丟丂上丈丝万丟下丝.Item[0])) != false)
        {
                this.丕专丞丅丕丐丄丈东(丂丈丙且丈丗三丆丕:  this.丟丂上丈丝万丟下丝.Item[0], 且丑丐丂与丐丟丒下:  this.专丟丟东且丐东丞且(丏丌丄丆丟丝下丟丝:  丏丌丄丆丟丝下丟丝, 丘业丌下丁业下丐东:  丘业丌下丁业下丐东, 丂丈丙且丈丗三丆丕:  this.丟丂上丈丝万丟下丝.Item[0]));
        }
        
        val_27 = 1;
        label_29:
        if(val_27 < this.丟丂上丈丝万丟下丝.Count)
        {
            goto label_68;
        }
        
        if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  丘业丌下丁业下丐东))) == true)
        {
                return;
        }
        
        float val_26 = this.丐丕世丂上丐丑东丂();
        val_26 = val_26 + 0.1f;
        mem[1152921540634437864] = val_26;
        return;
        label_1:
        if(丘业丌下丁业下丐东 != null)
        {
            goto label_74;
        }
        
        goto label_74;
    }
    private UnityEngine.Transform 下丌丑丂上专专丌业(丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上 丌丆一七丈丈丄下下, UnityEngine.Transform 专丂不丐一丛一丕丌, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 丅丝不丞下东丘且不)
    {
        float val_10;
        var val_11;
        var val_13;
        var val_16;
        var val_17;
        val_10 = 丅丝不丞下东丘且不;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_1 = 丌丆一七丈丈丄下下.世且一丄且上丄不一();
        val_11 = 0;
        goto label_27;
        label_33:
        var val_13 = 0;
        val_13 = val_13 + 1;
        T val_3 = val_1.Current;
        val_13 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_3);
        if(专丂不丐一丛一丕丌 != val_3)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_13.IsDead() != true)
        {
                if(val_13 != null)
        {
                if(null != 0)
        {
            goto label_27;
        }
        
        }
        
            UnityEngine.Vector3 val_8 = val_3.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
            if(val_9.x < 0)
        {
                val_10 = val_9.x;
            val_11 = val_3;
        }
        
        }
        
        }
        
        label_27:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_1.MoveNext() == true)
        {
            goto label_33;
        }
        
        val_16 = 0;
        val_17 = 0;
        if(val_1 == null)
        {
            
        }
        else
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_1.Dispose();
        }
        
        if( != 1)
        {
                return (UnityEngine.Transform)val_11;
        }
        
        if( == false)
        {
                return (UnityEngine.Transform)val_11;
        }
        
        return (UnityEngine.Transform)val_11;
    }
    private float 专丟丟东且丐东丞且(int[] 丏丌丄丆丟丝下丟丝, byte[] 丘业丌下丁业下丐东, 丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        goto label_1;
        label_16:
        UnityEngine.Transform val_1 = this.丗丕一丁下丅世一三(世上丕丐丈世上不丏:  丏丌丄丆丟丝下丟丝[0], 丏与丅下丞丗与七下:  丘业丌下丁业下丐东[0]);
        if((val_1 != 0) && (val_1 != 0))
        {
                丅丙上七上一丐不下 val_4 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_1);
            if(val_4 != null)
        {
                if(val_4 == 丂丈丙且丈丗三丆丕)
        {
            goto label_14;
        }
        
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < 丏丌丄丆丟丝下丟丝.Length)
        {
            goto label_16;
        }
        
        return this.下与丗丒丐三丕丘丈();
        label_14:
        float val_6 = this.专丂丘且世丑丛丞与(丌丒丝东丌下丕丁丅:  0, 与丅丝丈东三业丙丑:  this._percentDeclinePerRebound);
        val_6 = this.下与丗丒丐三丕丘丈() * val_6;
        return (float)val_6;
    }
    private void 丕专丞丅丕丐丄丈东(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕, float 且丑丐丂与丐丟丒下)
    {
        Player_move_c val_16;
        float val_17;
        float val_18;
        var val_19;
        var val_21;
        var val_22;
        val_17 = 且丑丐丂与丐丟丒下;
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                if(一丝丌丏万丐丌丆东() != false)
        {
                val_17 = FortDefenceLinkController.丄丘七三上丕世丞业.damageBotFromTurretsCoeff * val_17;
        }
        
        }
        
        this.丟丌丞丗丛丘丑不丅(丂丈丙且丈丗三丆丕:  丂丈丙且丈丗三丆丕);
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Vector3 val_4 = val_3.position;
        val_18 = val_4.y;
        val_19 = 1152921505284374528;
        var val_16 = 0;
        val_16 = val_16 + 1;
        丂丈丙且丈丗三丆丕.ApplyDamage(丞丈专下丈专业三丞:  val_17, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_4.x, y = val_18, z = val_4.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  val_3, 丝三丛且丘不丌丙下:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject), 丒丈丐丐丗丐专丈丏:  0);
        if((public System.Void 丅丙上七上一丐不下::ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, string 丝三丛且丘不丌丙下, int 丒丈丐丐丗丐专丈丏)) == 0)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        val_16 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_16 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_16 == 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_16 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_16 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        var val_17 = 0;
        val_17 = val_17 + 1;
        UnityEngine.Vector3 val_13 = this.transform.position;
        val_17 = val_13.x;
        val_18 = val_13.z;
        float val_14 = this.下与丗丒丐三丕丘丈();
        string val_15 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this);
        丈丞与与丕丕一丝世(丞下万上三丘上与专:  丂丈丙且丈丗三丆丕.transform.gameObject, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_17, y = val_13.y, z = val_18}, 丂丐丄丁丆与丈丂上:  new 丛上一丂不业丒丄丏() {丈丒丄丝丐专丐丙丌 = 0f, 丂丐丈丕丞下丁下丘 = 0f, 丌丛丑三丆丘万丘丛 = false});
    }
    internal float 专丂丘且世丑丛丞与(int 丌丒丝东丌下丕丁丅, float 与丅丝丈东三业丙丑)
    {
    
    }
    public TurretControllerScene_TeslaZap()
    {
        mem2[0] = 5;
        this._listIdTargetsBuffer = new System.Collections.Generic.List<不七世丁丟丏世业丑>();
        this.丟丂上丈丝万丟下丝 = new System.Collections.Generic.List<丅丙上七上一丐不下>();
        mem[1152921540635453768] = ;
        mem[1152921540635453784] = ;
        mem[1152921540635453804] = 1110704128;
        1152921540635453768 = new TurretControllerScene();
    }

}
