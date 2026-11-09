using UnityEngine;
private sealed class AreaFog.丄丄不丏丑三不丆一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.CancellationToken 不丒三业下丑不丞业;
    public Rilisoft.AreaFog 丝且与丝丒丟万丁专;
    public Rilisoft.FogSettings 丑丘万丝且丑丏丄下;
    public Rilisoft.SkySettings 七丐万丁且东丘丙上;
    public float 丂三丟丂丈丐丆丗丟;
    private Rilisoft.FogSettings 上丐与世且三丌专不;
    private Rilisoft.SkySettings 丞丑七万且丞丌上丟;
    private UnityEngine.Material 万丘世与丞丆与七丗;
    private float 丝丘丗丙东与丝且不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AreaFog.丄丄不丏丑三不丆一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        UnityEngine.Material val_13;
        float val_14;
        int val_15;
        val_12 = 82846;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
                val_12 = 0;
        }
        
        if(val_12.上丈丟七万且丞丌上() == false)
        {
            goto label_3;
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.丑丘万丝且丑丏丄下.Active);
        if(PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙() == false)
        {
            goto label_16;
        }
        
        this.上丐与世且三丌专不 = Rilisoft.FogSettings.且且丘丆三下丂丗下();
        PGCompany.丟丝世世且丗丈丈丞.下丐专且三丄下丘下(丙业与丙丗丝不丈东:  this.丑丘万丝且丑丏丄下.Mode);
        this.丞丑七万且丞丌上丟 = 0;
        this.万丘世与丞丆与七丗 = 0;
        if(this.丝且与丝丒丟万丁专.changeSky == false)
        {
            goto label_8;
        }
        
        if(this.七丐万丁且东丘丙上 == null)
        {
            goto label_9;
        }
        
        val_13 = this.七丐万丁且东丘丙上.mat;
        goto label_10;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_16;
        }
        
        val_14 = this.丝丘丗丙东与丝且不;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_12;
        label_3:
        if((this.不丒三业下丑不丞业 & 1) != 0)
        {
            goto label_16;
        }
        
        val_15 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_9:
        val_13 = 64;
        label_10:
        this.丞丑七万且丞丌上丟 = this.七丐万丁且东丘丙上.且且丘丆三下丂丗下(丘上专不丂万业不一:  val_13);
        this.万丘世与丞丆与七丗 = this.七丐万丁且东丘丙上.mat;
        label_8:
        this.丝丘丗丙东与丝且不 = 0f;
        val_14 = 0f;
        label_12:
        if(val_14 < 0)
        {
                if((this.不丒三业下丑不丞业 & 1) == 0)
        {
            goto label_17;
        }
        
        }
        
        label_16:
        val_15 = 0;
        return (bool)val_15;
        label_17:
        float val_12 = this.丂三丟丂丈丐丆丗丟;
        float val_6 = this.丝丘丗丙东与丝且不 + UnityEngine.Time.deltaTime;
        this.丝丘丗丙东与丝且不 = val_6;
        val_12 = val_6 / val_12;
        PGCompany.丟丝世世且丗丈丈丞.丁专丒东丆丏丏丛丗(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Lerp(a:  this.上丐与世且三丌专不.Start, b:  this.丑丘万丝且丑丏丄下.Start, t:  val_12));
        PGCompany.丟丝世世且丗丈丈丞.东不一丛丟东丆不七(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Lerp(a:  this.上丐与世且三丌专不.End, b:  this.丑丘万丝且丑丏丄下.End, t:  val_12));
        UnityEngine.Color val_9 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.上丐与世且三丌专不.Color, g = this.丑丘万丝且丑丏丄下.Start, b = V12.16B, a = val_6}, b:  new UnityEngine.Color() {r = this.丑丘万丝且丑丏丄下.Color}, t:  val_12);
        PGCompany.丟丝世世且丗丈丈丞.丌三上丂不丝一丄丑(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
        if(this.丝且与丝丒丟万丁专.changeSky != false)
        {
                UnityEngine.Color val_10 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.丞丑七万且丞丌上丟.ambient, g = this.丑丘万丝且丑丏丄下.Start, b = V12.16B, a = val_6}, b:  new UnityEngine.Color() {r = this.七丐万丁且东丘丙上.ambient}, t:  val_12);
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a});
            UnityEngine.Color val_11 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.丞丑七万且丞丌上丟.matColor, g = this.丑丘万丝且丑丏丄下.Start, b = V12.16B, a = val_6}, b:  new UnityEngine.Color() {r = this.七丐万丁且东丘丙上.matColor}, t:  val_12);
            this.万丘世与丞丆与七丗.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_15;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
