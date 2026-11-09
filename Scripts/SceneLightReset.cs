using UnityEngine;
internal sealed class SceneLightReset : MonoBehaviour
{
    // Fields
    private bool setFogActive;
    private UnityEngine.Color newAmbientEquatorColorBase;
    private UnityEngine.Color newAmbientGroundColorBase;
    private UnityEngine.Color newAmbientSkyColorBase;
    private UnityEngine.Color 万丞丞丄丄不丐丛丗;
    private UnityEngine.Color 丟且丐丂丂三下丒专;
    private UnityEngine.Color 丆丙丅丅东且万一丄;
    private bool 下丐丈丞丄万丗丂上;
    private static bool 丕丝丆丝丞丑丈且不;
    private bool 丄丛丏东丝丐丑且一;
    
    // Methods
    private void OnEnable()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        if(SceneLightReset.丕丝丆丝丞丑丈且不 == false)
        {
                return;
        }
        
        this.丗与业东一不业丈丄();
        val_2 = null;
        val_2 = null;
        SceneLightReset.丕丝丆丝丞丑丈且不 = false;
    }
    private void 丗与业东一不业丈丄()
    {
        UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.业三不丈丌丗丙丆丞();
        this.万丞丞丄丄不丐丛丗 = val_1;
        mem[1152921538406325312] = val_1.g;
        mem[1152921538406325316] = val_1.b;
        mem[1152921538406325320] = val_1.a;
        UnityEngine.Color val_2 = PGCompany.丟丝世世且丗丈丈丞.丗丙丟丂且丂丗业世();
        this.丟且丐丂丂三下丒专 = val_2;
        mem[1152921538406325328] = val_2.g;
        mem[1152921538406325332] = val_2.b;
        mem[1152921538406325336] = val_2.a;
        UnityEngine.Color val_3 = PGCompany.丟丝世世且丗丈丈丞.丄丐丒丆与丅不丗不();
        this.丆丙丅丅东且万一丄 = val_3;
        mem[1152921538406325344] = val_3.g;
        mem[1152921538406325348] = val_3.b;
        mem[1152921538406325352] = val_3.a;
        this.下丐丈丞丄万丗丂上 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        this.丄丛丏东丝丐丑且一 = true;
        PGCompany.丟丝世世且丗丈丈丞.一丆丛丑与上丝世东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.newAmbientEquatorColorBase, g = val_3.g, b = val_3.b, a = val_3.a});
        PGCompany.丟丝世世且丗丈丈丞.上丝丙丛下不一丘下(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.newAmbientGroundColorBase, g = val_3.g, b = val_3.b, a = val_3.a});
        PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.newAmbientSkyColorBase, g = val_3.g, b = val_3.b, a = val_3.a});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.setFogActive);
    }
    private void OnDisable()
    {
        this.丈世业丆丞丐丈下专();
    }
    private void OnDestroy()
    {
        this.丈世业丆丞丐丈下专();
    }
    private void 丈世业丆丞丐丈下专()
    {
        var val_1;
        var val_2;
        val_1 = this;
        if(this.丄丛丏东丝丐丑且一 == false)
        {
                return;
        }
        
        PGCompany.丟丝世世且丗丈丈丞.一丆丛丑与上丝世东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.万丞丞丄丄不丐丛丗});
        PGCompany.丟丝世世且丗丈丈丞.上丝丙丛下不一丘下(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丟且丐丂丂三下丒专});
        PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丆丙丅丅东且万一丄});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.下丐丈丞丄万丗丂上);
        this.丄丛丏东丝丐丑且一 = false;
        val_1 = 1152921505233788928;
        val_2 = null;
        val_2 = null;
        SceneLightReset.丕丝丆丝丞丑丈且不 = true;
    }
    public SceneLightReset()
    {
    
    }
    private static SceneLightReset()
    {
        SceneLightReset.丕丝丆丝丞丑丈且不 = true;
    }

}
