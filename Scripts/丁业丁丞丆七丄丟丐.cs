using UnityEngine;
internal static class 丁业丁丞丆七丄丟丐
{
    // Fields
    private static UnityEngine.Shader 丌丐丑丝世丁丂丗东;
    
    // Methods
    internal static void 东丕三丞丌丐专丗丝(UnityEngine.GameObject 且丄下不丑丁丂三丗)
    {
        new 丁业丁丞丆七丄丟丐.丝丂下丂丐丄丁丑丄() = new System.Object();
        WeaponSounds val_2 = 且丄下不丑丁丂三丗.GetComponent<WeaponSounds>();
        WeaponAnimParticleEffects val_4 = val_2._innerPars.GetComponent<WeaponAnimParticleEffects>();
        if(val_4 != 0)
        {
                val_4.DisableAllEffects = true;
        }
        
        InnerWeaponPars val_6 = val_2._innerPars;
        System.Collections.Generic.List<UnityEngine.GameObject> val_7 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        null.Add(item:  val_6.bonusPrefab);
        InnerWeaponPars val_8 = val_2._innerPars;
        if(val_8.particlePoint != 0)
        {
                InnerWeaponPars val_10 = val_2._innerPars;
            null.Add(item:  val_10.particlePoint);
        }
        
        bool val_12 = System.String.op_Equality(a:  val_2.三与丛丑且丐丈业丌(), b:  "Weapon530");
        if(new 丁业丁丞丆七丄丟丐.丝丂下丂丐丄丁丑丄() == null)
        {
            goto label_20;
        }
        
        bool val_13 = val_12;
        .下丆东丆丁下丅下丕 = val_13;
        if(val_13 == false)
        {
            goto label_31;
        }
        
        label_30:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2.与东七万丘东丙丄丟().Item[0].transform.parent.gameObject, 丏业丟一东丂东丘丛:  false);
        label_31:
        System.Action<UnityEngine.GameObject> val_19 = new System.Action<UnityEngine.GameObject>(object:  new 丁业丁丞丆七丄丟丐.丝丂下丂丐丄丁丑丄(), method:  System.Void 丁业丁丞丆七丄丟丐.丝丂下丂丐丄丁丑丄::丂不且丝世丈一丟七(UnityEngine.GameObject 丈世丁丒世丈世与与));
        null.ForEach(action:  null);
        return;
        label_20:
        mem[16] = val_12;
        if(mem[16] == true)
        {
            goto label_30;
        }
        
        goto label_31;
    }
    internal static void 丅丝丅三丅与专专丒(GadgetArmoryItem 丑丁丆丆专且丝不丙)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_7;
        System.Collections.Generic.IEnumerable<TSource> val_8;
        UnityEngine.GameObject val_9;
        var val_10;
        System.Action<UnityEngine.GameObject> val_12;
        val_7 = 丑丁丆丆专且丝不丙.noFillPersSkinObjects;
        if(val_7 == null)
        {
                System.Collections.Generic.List<UnityEngine.GameObject> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
        
        if(丑丁丆丆专且丝不丙.ignoreGadgetPointForColoring == true)
        {
            goto label_3;
        }
        
        System.Collections.Generic.List<UnityEngine.GameObject> val_2 = null;
        val_8 = val_2;
        val_2 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        if((UnityEngine.Object.op_Implicit(exists:  丑丁丆丆专且丝不丙.gadgetPoint)) == false)
        {
            goto label_6;
        }
        
        val_9 = 丑丁丆丆专且丝不丙.gadgetPoint;
        if(val_8 != null)
        {
            goto label_9;
        }
        
        goto label_8;
        label_6:
        val_9 = 丑丁丆丆专且丝不丙.gameObject;
        if(val_8 != null)
        {
            goto label_9;
        }
        
        label_8:
        label_9:
        val_2.Add(item:  val_9);
        val_7 = System.Linq.Enumerable.Concat<UnityEngine.GameObject>(first:  val_1, second:  val_2);
        label_3:
        val_10 = null;
        val_10 = null;
        val_12 = 丁业丁丞丆七丄丟丐.<>c.<>9__2_0;
        if(val_12 == null)
        {
                System.Action<UnityEngine.GameObject> val_6 = null;
            val_12 = val_6;
            val_6 = new System.Action<UnityEngine.GameObject>(object:  丁业丁丞丆七丄丟丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丁业丁丞丆七丄丟丐.<>c::丐不丘上七且且七与(UnityEngine.GameObject 丈世丁丒世丈世与与));
            丁业丁丞丆七丄丟丐.<>c.<>9__2_0 = val_12;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  val_7, 七丐丅专且专七三丆:  val_6);
    }
    internal static void 丄丒一丁丄丄且丙万(GliderShop 与丝丐丏上丄丂与丂)
    {
        if(与丝丐丏上丄丂与丂 == 0)
        {
                return;
        }
        
        Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  与丝丐丏上丄丂与丂.StopObjectForSkinSetting, 丌专业且丛丏丞丝且:  new System.Action<UnityEngine.Transform>(object:  0, method:  static System.Void 丁业丁丞丆七丄丟丐::丐丘丒三丙下丙丒专(UnityEngine.Transform 丝三丁东丈丒世丅业)));
    }
    internal static void 丝丑东与丑丕丂丑丝(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(丝三丁东丈丒世丅业 == 0)
        {
                return;
        }
        
        Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  丝三丁东丈丒世丅业, 丌专业且丛丏丞丝且:  new System.Action<UnityEngine.Transform>(object:  0, method:  static System.Void 丁业丁丞丆七丄丟丐::丐丘丒三丙下丙丒专(UnityEngine.Transform 丝三丁东丈丒世丅业)));
    }
    internal static void 三丏一丐丒丏丁丑丞(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_16;
        var val_17;
        if(丝三丁东丈丒世丅业 == 0)
        {
                return;
        }
        
        丁业丁丞丆七丄丟丐.丌丕业上丒且且丅丞();
        System.Collections.Generic.List<UnityEngine.ParticleSystem> val_2 = null;
        val_16 = val_2;
        val_2 = new System.Collections.Generic.List<UnityEngine.ParticleSystem>();
        val_2.AddRange(collection:  丝三丁东丈丒世丅业.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true));
        val_17 = 0;
        goto label_6;
        label_13:
        UnityEngine.ParticleSystem val_4 = val_2.Item[0];
        ColorOverLifetimeModule val_5 = val_4.colorOverLifetime;
        UnityEngine.Color val_6 = UnityEngine.Color.black;
        MinMaxGradient val_7 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
        val_4.GetComponent<UnityEngine.ParticleSystemRenderer>().material.shader = 丁业丁丞丆七丄丟丐.丌丐丑丝世丁丂丗东;
        val_17 = 1;
        label_6:
        if(val_17 < val_2.Count)
        {
            goto label_13;
        }
    
    }
    private static void 丌丕业上丒且且丅丞()
    {
        if(丁业丁丞丆七丄丟丐.丌丐丑丝世丁丂丗东 != 0)
        {
                return;
        }
        
        丁业丁丞丆七丄丟丐.丌丐丑丝世丁丂丗东 = UnityEngine.Shader.Find(name:  "Mobile/Particles/Alpha Blended");
    }
    private static void 丐丘丒三丙下丙丒专(UnityEngine.Transform 丝三丁东丈丒世丅业)
    {
        var val_6;
        UnityEngine.Renderer val_1 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.Renderer>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_6 = 0;
        goto label_5;
        label_12:
        val_1.materials[0].mainTexture = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "black_pixel");
        val_6 = 1;
        label_5:
        UnityEngine.Material[] val_5 = val_1.materials;
        if(val_6 < val_5.Length)
        {
            goto label_12;
        }
    
    }
    private static void 丅丆七丅丐与丑丁丅(UnityEngine.Transform 丝三丁东丈丒世丅业, bool 下丆东丆丁下丅下丕)
    {
        string val_11;
        var val_12;
        float val_13;
        float val_14;
        UnityEngine.Renderer val_1 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.Renderer>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_11 = val_1.name;
        val_12 = 0;
        goto label_6;
        label_19:
        UnityEngine.Material val_11 = val_1.materials[0];
        val_11.mainTexture = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "black_pixel");
        if(下丆东丆丁下丅下丕 != false)
        {
                if((System.String.op_Equality(a:  val_11, b:  "heart")) != false)
        {
                UnityEngine.Color val_7 = UnityEngine.Color.black;
            val_13 = val_7.r;
            val_14 = val_7.b;
            val_11.color = new UnityEngine.Color() {r = val_13, g = val_7.g, b = val_14, a = val_7.a};
        }
        
        }
        
        if((val_11.Equals(value:  "Sphere")) != false)
        {
                UnityEngine.Color val_9 = UnityEngine.Color.black;
            val_13 = val_9.r;
            val_14 = val_9.b;
            val_11.color = new UnityEngine.Color() {r = val_13, g = val_9.g, b = val_14, a = val_9.a};
        }
        
        val_12 = 1;
        label_6:
        UnityEngine.Material[] val_10 = val_1.materials;
        if(val_12 < val_10.Length)
        {
            goto label_19;
        }
    
    }

}
