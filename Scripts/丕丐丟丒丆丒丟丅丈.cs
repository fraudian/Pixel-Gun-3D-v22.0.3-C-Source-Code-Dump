using UnityEngine;
internal sealed class 丕丐丟丒丆丒丟丅丈
{
    // Fields
    private PGCompany.PixelPass.丒且丏万业业七业万 世不丐万三丄丆东丝;
    private System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丕丛丅专万丁万东一;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    internal bool 丝丐丄丕东世丙七丏;
    
    // Properties
    internal PGCompany.PixelPass.丒且丏万业业七业万 七丞专丞一丛丙丒丄 { get; }
    internal System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 专丂三丒一丂丛丄丞 { get; }
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丒且丏万业业七业万 丞丛与丞丛一丅业东()
    {
        return (PGCompany.PixelPass.丒且丏万业业七业万)this.世不丐万三丄丆东丝;
    }
    internal System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 与丑丛下且专七万丄()
    {
        return (System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>)this.丕丛丅专万丁万东一;
    }
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    internal 丕丐丟丒丆丒丟丅丈(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, PGCompany.PixelPass.丒且丏万业业七业万 丌丏与丐东丘东丕不, System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丞丗上不丂一丘且丙)
    {
        val_1 = new System.Object();
        this.丕丛丅专万丁万东一 = val_1;
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        this.世不丐万三丄丆东丝 = 丌丏与丐东丘东丕不;
    }
    internal UnityEngine.Texture 三丗一丄不丆不丏三()
    {
        return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "PixelPass/PixelAssetsStorage/PixelPassTextures/{0}_task_icon_pp", arg0:  this.世不丐万三丄丆东丝));
    }
    internal string 丘丄业丞丏与与丅丐()
    {
        var val_3;
        string val_4;
        val_3 = this.世不丐万三丄丆东丝.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.世不丐万三丄丆东丝 == 1)
        {
            goto label_3;
        }
        
        if(this.世不丐万三丄丆东丝 == 3)
        {
            goto label_4;
        }
        
        if(this.世不丐万三丄丆东丝 != 2)
        {
                return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4 = "Key_11517");
        }
        
        val_4 = "Key_11519";
        return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4);
        label_3:
        val_4 = "Key_11518";
        return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4);
        label_4:
        return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4);
    }
    internal int 丝且丁丌丂七丟且丙()
    {
        return PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丐世万丄三上丙七丟(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 丌丏与丐东丘东丕不:  this.世不丐万三丄丆东丝);
    }

}
