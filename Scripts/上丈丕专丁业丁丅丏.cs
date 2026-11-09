using UnityEngine;
private sealed class 丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏
{
    // Fields
    public int 丌七丞下不且丄世一;
    public System.Collections.Generic.Dictionary<string, int> 丄且丙丂业七丂丛丝;
    public System.Collections.Generic.List<CategoryNames> 丑丟丒上丕上三丂丁;
    
    // Methods
    public 丌丟专丒丟丂万东丄.上丈丕专丁业丁丅丏()
    {
    
    }
    internal bool 与东丅丒一不与三丈(int 业下丌下三丕丙丌下)
    {
        return (bool)(this.丌七丞下不且丄世一 != 业下丌下三丕丙丌下) ? 1 : 0;
    }
    internal int 丅且万三七丒丝丝丟(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟)
    {
        if(this.丄且丙丂业七丂丛丝 != null)
        {
                return this.丄且丙丂业七丂丛丝.Item[七丞丙丒三丕且丌丟.Items.Item[0].Id];
        }
        
        return this.丄且丙丂业七丂丛丝.Item[七丞丙丒三丕且丌丟.Items.Item[0].Id];
    }
    internal int 三丂万丗且且丗丙与(Rilisoft.Offers.AdaptiveOfferItem 七丞丙丒三丕且丌丟)
    {
        return Rilisoft.Offers.丙东丄万万丑东丘丅.丗丂丝丝丕丆与丙万(下丅丙一丂丗丅丝七:  七丞丙丒三丕且丌丟.Items.Item[0], 丂丅丈丛丗丌丞丅上:  this.丑丟丒上丕上三丂丁);
    }

}
