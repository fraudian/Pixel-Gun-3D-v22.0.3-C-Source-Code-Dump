using UnityEngine;
internal sealed class LobbySeasonLinks : PGBehaviour
{
    // Fields
    internal UnityEngine.GameObject firstBackground;
    internal UnityEngine.MeshRenderer[] meshessForUpdateShader;
    
    // Methods
    internal void 与不丈世且丈丒不丙(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.firstBackground, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    internal void 七丙东丈丅丂丌丛丞()
    {
        goto label_1;
        label_7:
        UnityEngine.MeshRenderer val_2 = this.meshessForUpdateShader[0];
        if(val_2 != 0)
        {
                this.七丙东丈丅丂丌丛丞(丟不丅丄丙丟丝业上:  val_2);
        }
        
        0 = 1;
        label_1:
        if(0 < this.meshessForUpdateShader.Length)
        {
            goto label_7;
        }
    
    }
    internal void 七丙东丈丅丂丌丛丞(UnityEngine.MeshRenderer 丟不丅丄丙丟丝业上)
    {
        var val_7;
        this.业丒丘万丌七世一丌(丑与丗丛丝丈丙丆丌:  丟不丅丄丙丟丝业上);
        val_7 = 0;
        goto label_1;
        label_11:
        UnityEngine.MeshRenderer val_3 = 丟不丅丄丙丟丝业上.transform.GetChild(index:  0).GetComponent<UnityEngine.MeshRenderer>();
        if(val_3 != 0)
        {
                this.业丒丘万丌七世一丌(丑与丗丛丝丈丙丆丌:  val_3);
        }
        
        val_7 = 1;
        label_1:
        if(val_7 < 丟不丅丄丙丟丝业上.transform.childCount)
        {
            goto label_11;
        }
    
    }
    internal void 业丒丘万丌七世一丌(UnityEngine.MeshRenderer 丑与丗丛丝丈丙丆丌)
    {
        if(丑与丗丛丝丈丙丆丌 == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Material> val_2 = new System.Collections.Generic.List<UnityEngine.Material>();
        丑与丗丛丝丈丙丆丌.GetMaterials(m:  val_2);
        List.Enumerator<T> val_3 = val_2.GetEnumerator();
        label_10:
        if((456428920 & 1) == 0)
        {
            goto label_6;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        val_4.shader = UnityEngine.Shader.Find(name:  val_4.shader.name);
        goto label_10;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丑与丗丛丝丈丙丆丌.materials = val_2.ToArray();
    }
    public LobbySeasonLinks()
    {
    
    }

}
