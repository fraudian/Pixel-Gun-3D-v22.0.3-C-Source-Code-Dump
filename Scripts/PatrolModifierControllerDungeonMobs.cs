using UnityEngine;
internal class PatrolModifierControllerDungeonMobs : PatrolModifierController
{
    // Fields
    private UnityEngine.Vector3 丗上下丂万丑上与丌;
    private UnityEngine.Vector3 丟业丌丄丞丆万与丐;
    private System.Collections.Generic.List<SpawnDungeonMobeSetting.AreaInfo> 丆七丛业不丕丏丅丘;
    private UnityEngine.Vector3 丅专与丒丈丗丒丘丌;
    private bool 丙上丈专丈丌丘丑万;
    
    // Methods
    internal void 丌丆万丕丗丄丛丄丐(UnityEngine.Vector3 丙丂丂业丂丁丌丂下, UnityEngine.Vector3 丟丒且一专丟丙下一, bool 丙上丈专丈丌丘丑万)
    {
        this.丗上下丂万丑上与丌 = 丙丂丂业丂丁丌丂下;
        mem[1152921540029168364] = 丙丂丂业丂丁丌丂下.y;
        mem[1152921540029168368] = 丙丂丂业丂丁丌丂下.z;
        this.丟业丌丄丞丆万与丐 = 丟丒且一专丟丙下一;
        mem[1152921540029168376] = 丟丒且一专丟丙下一.y;
        mem[1152921540029168380] = 丟丒且一专丟丙下一.z;
        this.丙上丈专丈丌丘丑万 = 丙上丈专丈丌丘丑万;
    }
    internal void 丌丆万丕丗丄丛丄丐(UnityEngine.Vector3 丗上下丂万丑上与丌, System.Collections.Generic.List<SpawnDungeonMobeSetting.AreaInfo> 丛丆丄丌丗丌万上专, bool 丙上丈专丈丌丘丑万)
    {
        this.丗上下丂万丑上与丌 = 丗上下丂万丑上与丌;
        mem[1152921540029284460] = 丗上下丂万丑上与丌.y;
        mem[1152921540029284464] = 丗上下丂万丑上与丌.z;
        this.丆七丛业不丕丏丅丘 = 丛丆丄丌丗丌万上专;
        this.丙上丈专丈丌丘丑万 = 丙上丈专丈丌丘丑万;
    }
    internal override UnityEngine.Vector3 专业业丐与丕丂万丘()
    {
        float val_14;
        UnityEngine.Vector3 val_15;
        UnityEngine.Vector3 val_16;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        AreaInfo val_4 = this.丆七丛业不丕丏丅丘.Item[UnityEngine.Random.Range(min:  0, max:  this.丆七丛业不丕丏丅丘.Count)];
        if(val_4 != null)
        {
                val_14 = val_4;
            val_15 = val_4.centerArea;
        }
        else
        {
                val_14 = 1.68059E-38f;
            val_15 = 1.68059E-38f;
        }
        
        val_16 = val_4.sizeArea;
        val_16 = val_4.sizeArea;
        val_16 = val_4.sizeArea;
        UnityEngine.Vector3 val_16 = this.丗上下丂万丑上与丌;
        val_16 = val_16 * 0.5f;
        float val_14 = System.Math.Abs(val_4.sizeArea * 0.5f);
        float val_15 = System.Math.Abs(val_16);
        float val_6 = this.丗上下丂万丑上与丌 + val_15;
        val_16 = val_16 + val_14;
        val_6 = val_6 - val_14;
        val_16 = val_16 + val_15;
        float val_7 = UnityEngine.Random.Range(min:  val_6, max:  val_16);
        float val_17 = 1.401298E-45f;
        val_17 = val_16 + val_17;
        val_14 = val_14 + S5;
        float val_19 = System.Math.Abs(val_15 * 0.5f);
        float val_10 = val_17 - (System.Math.Abs(val_14 * 0.5f));
        float val_13 = UnityEngine.Random.Range(min:  val_14 - val_19, max:  val_14 + val_19);
        this.丅专与丒丈丗丒丘丌 = val_7;
        mem[1152921540029410828] = val_10;
        mem[1152921540029410832] = val_13;
        return new UnityEngine.Vector3() {x = val_7, y = val_10, z = val_13};
    }
    internal override bool 不丝与下丙丙不丆丙(UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        var val_3;
        float val_17;
        int val_18;
        var val_19;
        var val_21;
        float val_17 = 丅专与丒丈丗丒丘丌.y;
        List.Enumerator<T> val_1 = this.丆七丛业不丕丏丅丘.GetEnumerator();
        val_17 = val_17 + 0.5f;
        label_23:
        if((1062941584 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 != null)
        {
                val_17 = val_4;
            val_18 = val_4.m_stringLength;
            val_19 = val_4 + 16;
        }
        else
        {
                val_18 = 1.68059E-38f;
            val_17 = 1.68059E-38f;
            val_19 = 16;
        }
        
        float val_18 = System.Math.Abs(S14 * 0.5f);
        val_18 = (this.丗上下丂万丑上与丌 + val_18) - val_18;
        if(val_18 > 丅专与丒丈丗丒丘丌.x)
        {
            goto label_23;
        }
        
        float val_19 = System.Math.Abs(S14 * 0.5f);
        val_19 = (this.丗上下丂万丑上与丌 + val_17) + val_19;
        if(丅专与丒丈丗丒丘丌.x > val_19)
        {
            goto label_23;
        }
        
        float val_20 = System.Math.Abs(S14 * 0.5f);
        val_20 = (this.丗上下丂万丑上与丌 + val_17) - val_20;
        if(val_20 > 丅专与丒丈丗丒丘丌.z)
        {
            goto label_23;
        }
        
        float val_21 = System.Math.Abs(S14 * 0.5f);
        val_21 = (this.丗上下丂万丑上与丌 + val_17) + val_21;
        if(丅专与丒丈丗丒丘丌.z > val_21)
        {
            goto label_23;
        }
        
        if(this.丙上丈专丈丌丘丑万 == false)
        {
            goto label_17;
        }
        
        float val_22 = System.Math.Abs(S14 * 0.5f);
        val_22 = (this.丗上下丂万丑上与丌 + (1.401298E-45f)) - val_22;
        if(val_22 > val_17)
        {
            goto label_23;
        }
        
        float val_16 = this.丗上下丂万丑上与丌 + (1.401298E-45f);
        float val_23 = System.Math.Abs(S14 * 0.5f);
        val_16 = val_16 + 0.5f;
        val_23 = val_16 + val_23;
        if(val_17 > val_23)
        {
            goto label_23;
        }
        
        label_17:
        val_21 = 1;
        goto label_24;
        label_2:
        val_21 = 0;
        label_24:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_21;
    }
    internal override bool 与丄万丟丐丝丕丄专()
    {
        return (bool)this.丙上丈专丈丌丘丑万;
    }
    internal override void 与丞丕丝上三不丞与()
    {
    
    }
    private void OnDrawGizmosSelected()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.yellow;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = this.丅专与丒丈丗丒丘丌, y = val_1.g, z = val_1.b}, radius:  1f);
    }
    public PatrolModifierControllerDungeonMobs()
    {
        this.丆七丛业不丕丏丅丘 = new System.Collections.Generic.List<AreaInfo>();
        this = new PGBehaviour();
    }

}
