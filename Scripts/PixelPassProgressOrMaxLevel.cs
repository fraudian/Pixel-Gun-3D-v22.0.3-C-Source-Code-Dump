using UnityEngine;
internal sealed class PixelPassProgressOrMaxLevel : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject progressView;
    private UnityEngine.GameObject lastLevelViewHolder;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    private void OnEnable()
    {
        PGCompany.万下丛丁丟不下丄业.东业丅万丌丌丑丗丑(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassProgressOrMaxLevel::丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.万丘丑丙丈丛与丝丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassProgressOrMaxLevel::丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        if(this.丑与万三丐丒丏一专 == null)
        {
                this.丑与万三丐丒丏一专 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            this.丝一丅丆三东丂丞七();
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        PGCompany.万下丛丁丟不下丄业.丗世且上七丐丗丈东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassProgressOrMaxLevel::丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.丆万丛万丙七世万业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassProgressOrMaxLevel::丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
    {
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        UnityEngine.GameObject val_2;
        var val_3;
        if(this.丑与万三丐丒丏一专.丘丗与丝专丑一丙丌() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.progressView, 丏业丟一东丂东丘丛:  false);
            val_2 = this.lastLevelViewHolder;
            val_3 = 1;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.progressView, 丏业丟一东丂东丘丛:  true);
            val_2 = this.lastLevelViewHolder;
            val_3 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
    }
    private void 丟专丌丆丆丙丂丁上(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)
    {
        this.丝一丅丆三东丂丞七();
    }
    public PixelPassProgressOrMaxLevel()
    {
    
    }

}
