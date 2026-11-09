using UnityEngine;
internal class 丁丞不业丑丗七丁七 : 一上不上一丅专专丐
{
    // Methods
    internal override void 丆丌丙万与丛万丝世()
    {
        this.丌丌世丁不丐丂丈丌();
    }
    private void 丌丌世丁不丐丂丈丌()
    {
        UnityEngine.Object val_3;
        object val_39;
        var val_40;
        object val_41;
        UnityEngine.Object val_42;
        val_39 = this;
        val_40 = null;
        val_40 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.GetEnumerator();
        val_41 = 1152921504838316032;
        label_31:
        if((911064992 & 1) == 0)
        {
            goto label_4;
        }
        
        丅丙上七上一丐不下 val_6 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_3.丐丏七丌丕丗业且上().transform);
        if(val_6 == null)
        {
            goto label_31;
        }
        
        UnityEngine.Transform val_7 = val_6.transform;
        UnityEngine.Vector3 val_8 = val_7.position;
        UnityEngine.Transform val_9 = val_7.transform;
        UnityEngine.Vector3 val_10 = val_9.position;
        float val_11 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        if(((val_11 >= 0) || (val_11 >= 0)) || ((val_8.z / val_6.maxHealth) >= 0))
        {
            goto label_31;
        }
        
        RilisoftBot.BotAiController val_14 = val_9.七与世丄丞丒一七三();
        if(val_14.东万三丈万丗专业专 == 0)
        {
            goto label_31;
        }
        
        RilisoftBot.BotAiController val_16 = val_14.东万三丈万丗专业专.七与世丄丞丒一七三();
        UnityEngine.Vector3 val_18 = val_6.transform.position;
        if((val_16.东万三丈万丗专业专 & 1) == 0)
        {
            goto label_31;
        }
        
        UnityEngine.Transform val_19 = val_6.transform;
        goto label_31;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(0 == 0)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_22 = 0.transform;
        UnityEngine.Vector3 val_23 = val_22.position;
        UnityEngine.Transform val_24 = val_22.transform;
        UnityEngine.Vector3 val_25 = val_24.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z})) <= (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z})))
        {
                return;
        }
        
        val_42 = val_24.七与世丄丞丒一七三().gameObject.AddComponent<NavMeshMoveMobToTarget>();
        float val_39 = val_39 * 0.8f;
        val_3 = val_39;
        val_41 = val_3;
        new object[1][0] = val_41;
        val_42.SetBot(丑丁一丛万丘万丗不:  0.七与世丄丞丒一七三());
        val_42.万世丙下丏下东丒丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(丁丞不业丑丗七丁七).__il2cppRuntimeField_190));
        System.Action val_33 = new System.Action(object:  this, method:  System.Void 丁丞不业丑丗七丁七::丙丕上丑丝万世丁丁());
        val_42.不丗业丁专一丁上不(丙业与丙丗丝不丈东:  val_33);
        val_34.丞丟丌七东丕丁与东 = val_42;
        UnityEngine.GameObject val_36 = val_33.七与世丄丞丒一七三().七与世丄丞丒一七三().gameObject;
        val_39 = val_36.AddComponent<MoveToTargetCurrentAiState>();
        RilisoftBot.BotAiController val_38 = val_36.七与世丄丞丒一七三();
        val_38.丆丞业丅三丞专丝丒 = val_39;
    }
    private void 丙丕上丑丝万世丁丁()
    {
        var val_6;
        RilisoftBot.BotAiController val_1 = 七与世丄丞丒一七三();
        System.Action val_2 = new System.Action(object:  this, method:  typeof(丁丞不业丑丗七丁七).__il2cppRuntimeField_190);
        if(val_1.丞丟丌七东丕丁与东 != null)
        {
                val_6 = null;
            val_6 = null;
            var val_3 = (((MoveMobToTarget.__il2cppRuntimeField_typeHierarchy + (NavMeshMoveMobToTarget.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_6) ? val_1.丞丟丌七东丕丁与东 : 0;
        }
        
        0.丐丐东一丟业丕丝且(丙业与丙丗丝不丈东:  val_2);
        RilisoftBot.BotAiController val_4 = val_2.七与世丄丞丒一七三();
        UnityEngine.Object.Destroy(obj:  val_4.丞丟丌七东丕丁与东);
        RilisoftBot.BotAiController val_5 = val_4.丞丟丌七东丕丁与东.七与世丄丞丒一七三();
        UnityEngine.Object.Destroy(obj:  val_5.丆丞业丅三丞专丝丒);
        this.丌丌世丁不丐丂丈丌();
    }
    protected override void 丁丟丁世丐丅上丄万()
    {
        this.丁丟丁世丐丅上丄万();
        goto typeof(丁丞不业丑丗七丁七).__il2cppRuntimeField_198;
    }
    protected override void 且下一七丒丝与世不()
    {
        var val_8;
        this.且下一七丒丝与世不();
        RilisoftBot.BotAiController val_1 = 七与世丄丞丒一七三();
        if(val_1.丞丟丌七东丕丁与东 == 0)
        {
                return;
        }
        
        RilisoftBot.BotAiController val_3 = val_1.丞丟丌七东丕丁与东.七与世丄丞丒一七三();
        System.Action val_4 = new System.Action(object:  this, method:  typeof(丁丞不业丑丗七丁七).__il2cppRuntimeField_190);
        if(val_3.丞丟丌七东丕丁与东 != null)
        {
                val_8 = null;
            val_8 = null;
            var val_5 = (((MoveMobToTarget.__il2cppRuntimeField_typeHierarchy + (NavMeshMoveMobToTarget.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_8) ? val_3.丞丟丌七东丕丁与东 : 0;
        }
        
        0.丐丐东一丟业丕丝且(丙业与丙丗丝不丈东:  val_4);
        RilisoftBot.BotAiController val_6 = val_4.七与世丄丞丒一七三();
        UnityEngine.Object.Destroy(obj:  val_6.丞丟丌七东丕丁与东);
        RilisoftBot.BotAiController val_7 = this.七与世丄丞丒一七三();
        UnityEngine.Object.Destroy(obj:  val_7.丆丞业丅三丞专丝丒);
    }
    protected override void 丙丝丞一丏专丘丐丄()
    {
        this.丑丅丄三一专七业业();
    }
    private void 丑丅丄三一专七业业()
    {
        var val_3;
        var val_14;
        var val_15;
        val_14 = this;
        val_15 = null;
        val_15 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.GetEnumerator();
        label_13:
        if((911891328 & 1) == 0)
        {
            goto label_4;
        }
        
        丅丙上七上一丐不下 val_6 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_3.丐丏七丌丕丗业且上().transform);
        if(val_6 == null)
        {
            goto label_13;
        }
        
        float val_7 = val_6.maxHealth;
        if(S8 >= 0)
        {
            goto label_13;
        }
        
        float val_14 = X25 + 96;
        val_14 = val_6.maxHealth * val_14;
        val_6.丞万丟万上且丟业丘(世丙丟上丘上七万万:  val_14, 丘丞丛万世丈丅丂丆:  true);
        goto label_13;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        DisableWithDelay val_9 = val_3.ParticleObject;
        if(val_9 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_12 = val_9.ParticleObject.gameObject;
        val_12.SetActive(value:  true);
        val_14 = val_12.ParticleObject;
        val_14.下三与丙丒一丞丐丒(丕丕世且下一与丝与:  V8.16B);
    }
    protected override System.Collections.Generic.List<丅丙上七上一丐不下> 丑不专丈丄专下世丒()
    {
        return (System.Collections.Generic.List<丅丙上七上一丐不下>)new System.Collections.Generic.List<丅丙上七上一丐不下>();
    }
    public 丁丞不业丑丗七丁七()
    {
    
    }

}
