using UnityEngine;
internal class ChasingAreaModifierControllerDungeon : ChasingAreaModifierController
{
    // Fields
    private UnityEngine.Vector3 丗上下丂万丑上与丌;
    private UnityEngine.Vector3 丟业丌丄丞丆万与丐;
    private System.Collections.Generic.List<SpawnDungeonMobeSetting.AreaInfo> 丆七丛业不丕丏丅丘;
    private bool 丙上丈专丈丌丘丑万;
    
    // Methods
    internal void 丑丁丂与三丙上丏丁(UnityEngine.Vector3 丙丂丂业丂丁丌丂下, UnityEngine.Vector3 丟丒且一专丟丙下一, bool 丙上丈专丈丌丘丑万)
    {
        this.丗上下丂万丑上与丌 = 丙丂丂业丂丁丌丂下;
        mem[1152921540014961868] = 丙丂丂业丂丁丌丂下.y;
        mem[1152921540014961872] = 丙丂丂业丂丁丌丂下.z;
        this.丟业丌丄丞丆万与丐 = 丟丒且一专丟丙下一;
        mem[1152921540014961880] = 丟丒且一专丟丙下一.y;
        mem[1152921540014961884] = 丟丒且一专丟丙下一.z;
        this.丙上丈专丈丌丘丑万 = 丙上丈专丈丌丘丑万;
    }
    internal void 丑丁丂与三丙上丏丁(System.Collections.Generic.List<SpawnDungeonMobeSetting.AreaInfo> 丛丆丄丌丗丌万上专, bool 丙上丈专丈丌丘丑万)
    {
        this.丆七丛业不丕丏丅丘 = 丛丆丄丌丗丌万上专;
        this.丙上丈专丈丌丘丑万 = 丙上丈专丈丌丘丑万;
    }
    internal override bool 专丞三丈丐丝下丞丘(UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        var val_3;
        float val_11;
        int val_12;
        var val_13;
        float val_14;
        var val_15;
        List.Enumerator<T> val_1 = this.丆七丛业不丕丏丅丘.GetEnumerator();
        label_23:
        if((1048608816 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 != null)
        {
                val_11 = val_4;
            val_12 = val_4.m_stringLength;
            val_13 = val_4 + 16;
        }
        else
        {
                val_12 = 1.68059E-38f;
            val_11 = 1.68059E-38f;
            val_13 = 16;
        }
        
        float val_11 = System.Math.Abs(S13 * 0.5f);
        val_11 = val_12 - val_11;
        if(val_11 > 丅专与丒丈丗丒丘丌.x)
        {
            goto label_23;
        }
        
        float val_12 = System.Math.Abs(S13 * 0.5f);
        val_12 = val_11 + val_12;
        if(丅专与丒丈丗丒丘丌.x > val_12)
        {
            goto label_23;
        }
        
        float val_13 = System.Math.Abs(S13 * 0.5f);
        val_13 = val_11 - val_13;
        if(val_13 > 丅专与丒丈丗丒丘丌.z)
        {
            goto label_23;
        }
        
        float val_14 = System.Math.Abs(S13 * 0.5f);
        val_14 = val_11 + val_14;
        if(丅专与丒丈丗丒丘丌.z > val_14)
        {
            goto label_23;
        }
        
        if(this.丙上丈专丈丌丘丑万 == false)
        {
            goto label_17;
        }
        
        float val_15 = System.Math.Abs(S13 * 0.5f);
        val_15 = (1.401298E-45f) - val_15;
        if(val_15 > 丅专与丒丈丗丒丘丌.y)
        {
            goto label_23;
        }
        
        val_14 = 1.401298E-45f;
        float val_16 = System.Math.Abs(S13 * 0.5f);
        val_16 = val_14 + val_16;
        if(丅专与丒丈丗丒丘丌.y > val_16)
        {
            goto label_23;
        }
        
        label_17:
        val_15 = 1;
        goto label_24;
        label_2:
        val_15 = 0;
        label_24:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_15;
    }
    public ChasingAreaModifierControllerDungeon()
    {
        this.丆七丛业不丕丏丅丘 = new System.Collections.Generic.List<AreaInfo>();
        this = new UnityEngine.MonoBehaviour();
    }

}
