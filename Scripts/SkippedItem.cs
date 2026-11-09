using UnityEngine;
[Serializable]
internal class AdaptiveProgress.SkippedItem
{
    // Fields
    private Rilisoft.不丗上万丟丏不丄下 _offerItemId;
    internal string ItemId;
    internal int Module;
    
    // Properties
    internal Rilisoft.不丗上万丟丏不丄下 OfferItemId { get; }
    
    // Methods
    internal Rilisoft.不丗上万丟丏不丄下 get_OfferItemId()
    {
        string val_3;
        Rilisoft.不丗上万丟丏不丄下 val_4;
        val_3 = this;
        val_4 = this._offerItemId;
        if(val_4 != null)
        {
                return (Rilisoft.不丗上万丟丏不丄下)val_4;
        }
        
        val_4 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.ItemId)) == true)
        {
                return (Rilisoft.不丗上万丟丏不丄下)val_4;
        }
        
        val_3 = this.ItemId;
        Rilisoft.不丗上万丟丏不丄下 val_2 = null;
        val_4 = val_2;
        val_2 = new Rilisoft.不丗上万丟丏不丄下(丞丕丒专一下丙业上:  val_3);
        return (Rilisoft.不丗上万丟丏不丄下)val_4;
    }
    internal AdaptiveProgress.SkippedItem()
    {
    
    }
    internal AdaptiveProgress.SkippedItem(string 丞一丁业丄一一业且, int 丕上业丕丘上丘七一)
    {
        this.ItemId = 丞一丁业丄一一业且;
        this.Module = 丕上业丕丘上丘七一;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "{0}*{1}", arg0:  this.ItemId, arg1:  this.Module);
    }
    internal static Progress.AdaptiveProgress.SkippedItem 与丛丆专东丐一且丅(string 丞丕丒专一下丙业上)
    {
        var val_7;
        System.Char[] val_8;
        var val_9;
        int val_5 = 0;
        val_7 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丕丒专一下丙业上)) == true)
        {
                return (SkippedItem)val_7;
        }
        
        AdaptiveProgress.SkippedItem val_2 = null;
        val_7 = val_2;
        val_2 = new AdaptiveProgress.SkippedItem();
        .ItemId = 0;
        .Module = 0;
        char[] val_3 = new char[1];
        val_8 = val_3;
        val_8[0] = '*';
        System.String[] val_4 = 丞丕丒专一下丙业上.Split(separator:  val_3);
        if(val_4.Length != 2)
        {
                return (SkippedItem)val_7;
        }
        
        val_8 = val_4[0];
        bool val_6 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_4[1], 丙业与丙丗丝不丈东: out  val_5);
        if(val_7 != null)
        {
                .ItemId = val_8;
            val_9 = val_5;
        }
        else
        {
                .ItemId = val_8;
            val_9 = val_5;
        }
        
        .Module = 0;
        return (SkippedItem)val_7;
    }

}
