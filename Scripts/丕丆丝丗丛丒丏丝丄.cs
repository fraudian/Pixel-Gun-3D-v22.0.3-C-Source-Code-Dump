using UnityEngine;
internal class 丕丆丝丗丛丒丏丝丄 : 一上不上一丅专专丐
{
    // Fields
    private System.Collections.Generic.List<BulletForBot> 丈丕丈下不丐不丕丙;
    private int 三丗丑丂丝与丛且丗;
    
    // Methods
    internal override void 丆丌丙万与丛万丝世()
    {
        UnityEngine.Transform val_1 = this.下丌丑丂上专专丌业();
        UnityEngine.Vector3 val_2 = val_1.position;
        UnityEngine.Transform val_3 = val_1.transform;
        UnityEngine.Vector3 val_4 = val_3.position;
        val_3.七与世丄丞丒一七三().七与世丄丞丒一七三().OrientToTarget(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_2.x, y = val_4.y, z = val_2.z});
        this.且下一七丒丝与世不();
    }
    protected override System.Collections.Generic.List<丅丙上七上一丐不下> 丑不专丈丄专下世丒()
    {
        return 0;
    }
    protected override void 丁丟丁世丐丅上丄万()
    {
        this.丁丟丁世丐丅上丄万();
        goto typeof(丕丆丝丗丛丒丏丝丄).__il2cppRuntimeField_198;
    }
    internal override void 丙丂丅丛丄丆业丛丆(AlternativeAttackSettings 与不丕丆丈不丙丟丛, AlternativeMobAttackController 丒专丈丛下丒一丒丛, TriggerAlternativeAttackSetting 七丗丘与丕且丘丑世)
    {
        this.丙丂丅丛丄丆业丛丆(与不丕丆丈不丙丟丛:  与不丕丆丈不丙丟丛, 丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛, 七丗丘与丕且丘丑世:  七丗丘与丕且丘丑世);
        this.丂丐丞丟丟上丙丝丐();
    }
    protected override void 丙丝丞一丏专丘丐丄()
    {
        if(七与世丄丞丒一七三().丛丘丟业下丐专丕丑().isMine == false)
        {
                return;
        }
        
        UnityEngine.Transform val_4 = this.下丌丑丂上专专丌业();
        if(val_4 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = val_4.position;
        this.丁丗丈丈丛丅世不下(丅七丟上专一丈万丙:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        string val_7 = val_4.上丆东与丙丗丌七丛(世万不丘丗专上丞业:  this);
        if((System.String.IsNullOrEmpty(value:  val_7)) == true)
        {
                return;
        }
        
        this = this.七与世丄丞丒一七三().丛丘丟业下丐专丕丑();
        object[] val_11 = new object[2];
        val_11[0] = val_7;
        val_11[1] = val_6;
        this.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  212, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_11);
    }
    internal void 丁丗丈丈丛丅世不下(UnityEngine.Vector3 丅七丟上专一丈万丙)
    {
        var val_11;
        var val_12;
        var val_21;
        var val_24;
        var val_27;
        val_21 = this;
        BulletForBot val_1 = this.丝下丘丟丆东丞下丙();
        RilisoftBot.BaseBot val_3 = X21.七与世丄丞丒一七三().七与世丄丞丒一七三();
        val_1.丗丞丝不三且不丕丘(丗不丛七丏丄业三丁:  val_3);
        if(val_3.上丞丞丏丂丅专丝丆 == false)
        {
            goto label_27;
        }
        
        UnityEngine.Transform val_4 = val_3.transform;
        UnityEngine.Vector3 val_5 = val_4.right;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.AngleAxis(angle:  X22 + 84, axis:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Transform val_7 = val_4.transform;
        UnityEngine.Vector3 val_8 = val_7.forward;
        UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        List.Enumerator<T> val_10 = val_7.GetEnumerator();
        val_24 = 1152921524349664160;
        label_21:
        if((913789040 & 1) == 0)
        {
            goto label_30;
        }
        
        UnityEngine.Vector3 val_14 = val_12.丐丏七丌丕丗业且上().position;
        if(X24 != 0)
        {
                var val_15 = ((X24 + 64) != 0) ? 1 : 0;
        }
        else
        {
                bool val_16 = ((X24 + 64) != 0) ? 1 : 0;
        }
        
        val_1.ApplyForceFroBullet(七丝丑丐东丅丒丁丂:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, 丂七丅一一丒且万丕:  new UnityEngine.Vector3() {x = 丅七丟上专一丈万丙.x, y = 丅七丟上专一丈万丙.y, z = 丅七丟上专一丈万丙.z}, 丅上丝丟且专世丏与:  val_16, 丒东业丙一丙业丏丆:  X24 + 88, 丅丕万丐不丄丗且七:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.z, z = 丅七丟上专一丈万丙.y}, 丂丘且丝丙上业世丙:  true);
        goto label_21;
        label_27:
        List.Enumerator<T> val_17 = BulletForBot.__il2cppRuntimeField_byval_arg.GetEnumerator();
        val_24 = 1152921524349664160;
        label_37:
        if((913789040 & 1) == 0)
        {
            goto label_30;
        }
        
        string val_18 = val_12.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_19 = val_18.position;
        if(val_18 != null)
        {
            
        }
        else
        {
                if(val_11 != 0)
        {
                val_27 = val_11;
        }
        else
        {
                val_27 = 0;
        }
        
        }
        
        val_1.StartBullet(七丝丑丐东丅丒丁丂:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, 丂七丅一一丒且万丕:  new UnityEngine.Vector3() {x = 丅七丟上专一丈万丙.x, y = 丅七丟上专一丈万丙.y, z = 丅七丟上专一丈万丙.z}, 丘丛丝世丄丄丑三丁:  val_9.z, 丅上丝丟且专世丏与:  (1 != 0) ? 1 : 0, 丂丘且丝丙上业世丙:  true);
        goto label_37;
        label_30:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丘丟丐且一丁丗丟丒(UnityEngine.GameObject 丞下万上三丘上与专, UnityEngine.Vector3 世丘丂丁七丐丐一专, bool 丂丘且丝丙上业世丙)
    {
        UnityEngine.Object val_30;
        float val_31;
        var val_32;
        UnityEngine.Object val_33;
        val_30 = 丞下万上三丘上与专;
        System.Collections.Generic.List<丅丙上七上一丐不下> val_1 = new System.Collections.Generic.List<丅丙上七上一丐不下>();
        if((X22 + 48) == 0)
        {
            goto label_2;
        }
        
        if(val_30 != 0)
        {
                UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            val_31 = val_3.y;
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_30, position:  new UnityEngine.Vector3() {x = 世丘丂丁七丐丐一专.x, y = 世丘丂丁七丐丐一专.y, z = 世丘丂丁七丐丐一专.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_31, z = val_3.z, w = val_3.w});
        }
        
        val_30 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = 世丘丂丁七丐丐一专.x, y = 世丘丂丁七丐丐一专.y, z = 世丘丂丁七丐丐一专.z}, radius:  val_3.x, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.与万与一不丌丈业丞());
        if(val_6.Length == 0)
        {
                return;
        }
        
        val_32 = X22;
        if(X22 == 0)
        {
                if(val_32 == 0)
        {
            goto label_16;
        }
        
        }
        
        val_31 = mem[X22 + 24];
        val_31 = X22 + 24;
        val_1.Clear();
        if(val_6.Length < 1)
        {
            goto label_63;
        }
        
        do
        {
            if(val_30[0].gameObject != 0)
        {
                UnityEngine.Transform val_11 = val_6[0x0] + 32.transform.root;
            val_33 = val_11.gameObject;
            if(val_33 != 0)
        {
                val_33 = val_33.transform.gameObject;
            if(val_33 != 0)
        {
                val_33 = val_33.transform;
            if((val_11.Equals(other:  val_33)) != true)
        {
                UnityEngine.Vector3 val_19 = val_11.position;
            val_31 = val_19.y;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_31, z = val_19.z}, b:  new UnityEngine.Vector3() {x = 世丘丂丁七丐丐一专.x, y = 世丘丂丁七丐丐一专.y, z = 世丘丂丁七丐丐一专.z});
            if((val_20.x <= ((X22 + 24) * val_31)) && ((val_11.CompareTag(tag:  "Enemy")) != true))
        {
                丅丙上七上一丐不下 val_25 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_6[0x0] + 32.transform.root.transform);
            if(val_25 != null)
        {
                if((val_1.Contains(item:  val_25)) != true)
        {
                val_1.Add(item:  val_25);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        while((0 + 1) < val_6.Length);
        
        goto label_63;
        label_2:
        if(val_30 != 0)
        {
                val_30 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_30.transform);
            if(val_30 != null)
        {
                val_1.Add(item:  val_30);
        }
        
        }
        
        label_63:
        this.丌丐万丛三上一与东(丏万下业丘七业丙专:  val_1);
        return;
        label_16:
    }
    private UnityEngine.Transform 下丌丑丂上专专丌业()
    {
        var val_3;
        null = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_13:
        label_11:
        if((914271088 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_6 = X22.transform.position;
        UnityEngine.Vector3 val_8 = val_4.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) >= 0)
        {
            goto label_11;
        }
        
        UnityEngine.Transform val_10 = val_4.transform;
        goto label_13;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return 0;
    }
    protected BulletForBot 丝下丘丟丆东丞下丙()
    {
        int val_1 = this.三丗丑丂丝与丛且丗 + 1;
        this.三丗丑丂丝与丛且丗 = val_1;
        if(val_1 >= this.丈丕丈下不丐不丕丙.Count)
        {
                this.三丗丑丂丝与丛且丗 = 0;
        }
        
        if(this.丈丕丈下不丐不丕丙 != null)
        {
                return this.丈丕丈下不丐不丕丙.Item[this.三丗丑丂丝与丛且丗];
        }
        
        return this.丈丕丈下不丐不丕丙.Item[this.三丗丑丂丝与丛且丗];
    }
    private void 丂丐丞丟丟上丙丝丐()
    {
        System.Collections.Generic.List<BulletForBot> val_7;
        int val_1 = CountPoolProjectile;
        val_7 = mem[X21 + 32];
        val_7 = X21 + 32;
        int val_3 = val_7.Count * val_1;
        if(val_3 < 1)
        {
                return;
        }
        
        do
        {
            BulletForBot val_5 = UnityEngine.Object.Instantiate<BulletForBot>(original:  val_1.Projectile);
            val_5.lifeTime = X21 + 32 + 44;
            val_5.add_OnBulletDamage(丙业与丙丗丝不丈东:  new BulletForBot.东世丌丗丂丛丂丑下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 丕丆丝丗丛丒丏丝丄::丘丟丐且一丁丗丟丒(UnityEngine.GameObject 丞下万上三丘上与专, UnityEngine.Vector3 世丘丂丁七丐丐一专, bool 丂丘且丝丙上业世丙)));
            val_7 = this.丈丕丈下不丐不丕丙;
            val_7.Add(item:  val_5);
            val_3 = val_3 - 1;
        }
        while(val_3 != 0);
    
    }
    public 丕丆丝丗丛丒丏丝丄()
    {
        this.丈丕丈下不丐不丕丙 = new System.Collections.Generic.List<BulletForBot>();
    }

}
