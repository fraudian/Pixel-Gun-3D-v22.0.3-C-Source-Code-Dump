using UnityEngine;
public class HelicopterView : TransportViewBase
{
    // Fields
    public UnityEngine.Transform mainRotor;
    public UnityEngine.Transform tailRotor;
    public UnityEngine.Material material;
    public UnityEngine.Renderer[] renderers;
    public UnityEngine.Transform cameraPivot;
    private bool 丁丛东丄世丂世丑三;
    private UnityEngine.Material 丁丐丗丗丝丞丁三上;
    private HelicopterController <三三三丅万业丆丕丅>k__BackingField;
    
    // Properties
    internal HelicopterController 丆东七丟丌丝丟一丗 { get; set; }
    internal override UnityEngine.Material 丘丐丞专业世丝丞丆 { get; }
    
    // Methods
    internal HelicopterController 专丙丐丌丞七丂上丁()
    {
        return (HelicopterController)this.<三三三丅万业丆丕丅>k__BackingField;
    }
    internal void 丅丙丙丘万上丟丝丌(HelicopterController 丙业与丙丗丝不丈东)
    {
        this.<三三三丅万业丆丕丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal override UnityEngine.Material 上丒专丝丌万丂上丌()
    {
        if(this.丁丛东丄世丂世丑三 == true)
        {
                return (UnityEngine.Material)this.丁丐丗丗丝丞丁三上;
        }
        
        this.丝丑丑业不丝丗丕丄();
        return (UnityEngine.Material)this.丁丐丗丗丝丞丁三上;
    }
    private void 丝丑丑业不丝丗丕丄()
    {
        UnityEngine.Material val_3;
        var val_4;
        this.丁丛东丄世丂世丑三 = true;
        val_3 = 1152921504848912384;
        if(this.material != 0)
        {
                this.丁丐丗丗丝丞丁三上 = UnityEngine.Object.Instantiate<UnityEngine.Material>(original:  this.material);
        }
        
        val_4 = 0;
        goto label_7;
        label_12:
        val_3 = mem[this.丁丐丗丗丝丞丁三上];
        this.renderers[0].sharedMaterial = val_3;
        val_4 = 1;
        label_7:
        if(val_4 < this.renderers.Length)
        {
            goto label_12;
        }
    
    }
    protected override System.Collections.IEnumerator 丝三丐不上万丕专东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new HelicopterView.丛丘丗东丟与丕与上();
    }
    public HelicopterView()
    {
    
    }

}
