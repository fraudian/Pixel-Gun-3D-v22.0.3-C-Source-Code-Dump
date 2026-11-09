using UnityEngine;
private sealed class 丗丄丙丁丌业丅丒丕.丅丅下丟丒丂丘业世
{
    // Fields
    public int 七丞丙丒三丕且丌丟;
    public Rilisoft.丗丄丙丁丌业丅丒丕.丄丆丌丌丕丈丆丆业 东丟且丗且三专丙丁;
    
    // Methods
    public 丗丄丙丁丌业丅丒丕.丅丅下丟丒丂丘业世()
    {
    
    }
    internal bool 丛丏丑丑业丕上丄丝(string 三丟东丕丄丄下下丑)
    {
        System.Collections.Generic.List<Rilisoft.一丙丌丘丑丞专丒丑> val_4;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  三丟东丕丄丄下下丑)) == true)
        {
                return false;
        }
        
        val_4 = this.东丟且丗且三专丙丁.丆丕丒丟丟丅丒与丝;
        if(val_4.Item[this.七丞丙丒三丕且丌丟] == null)
        {
                return false;
        }
        
        Rilisoft.一丙丌丘丑丞专丒丑 val_3 = this.东丟且丗且三专丙丁.丆丕丒丟丟丅丒与丝.Item[this.七丞丙丒三丕且丌丟];
        if(val_3.下丅七世与丛东东丝 != null)
        {
                return val_3.下丅七世与丛东东丝.ContainsValue(value:  三丟东丕丄丄下下丑);
        }
        
        return val_3.下丅七世与丛东东丝.ContainsValue(value:  三丟东丕丄丄下下丑);
    }

}
