using UnityEngine;
internal sealed class 丗一丐丁丂业丂七专 : 丏丒三上丗丌丄丛丄
{
    // Properties
    protected override string 万丟丛且丑七世丁丞 { get; }
    
    // Methods
    protected override string 与丏不上丙七丐且丞()
    {
        return "feature.clans";
    }
    internal override void 下丏且一三丐一丐不()
    {
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  57, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    internal override bool 丅丂与丈下东三不丟()
    {
        var val_5;
        if(this.丅丂与丈下东三不丟() != false)
        {
                PGCompany.丏丌丝丕丐七丈且丒 val_2 = PGCompany.七丄三丝丐业丄丅丝.世丟丈丌丝东丂丆丁();
            if(val_2 == null)
        {
                return (bool)val_5;
        }
        
            var val_4 = (val_2.丁丕丁三丁丗不三丟() > 0) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public 丗一丐丁丂业丂七专()
    {
    
    }

}
