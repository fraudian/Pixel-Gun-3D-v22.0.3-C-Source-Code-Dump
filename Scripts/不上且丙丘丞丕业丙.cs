using UnityEngine;
internal sealed class 不上且丙丘丞丕业丙
{
    // Fields
    private Rilisoft.丝丑丂丛万丐丈丘且 丐丞不丌丛丒上丏丛;
    private long 业下丟丟丕丄不七丞;
    
    // Properties
    internal int 上丈万丛丌丝丌一专 { get; }
    internal long 丐且且专丏东与专七 { get; set; }
    
    // Methods
    internal int 丑东丄丝丁上丂下业()
    {
    
    }
    internal long 业丗世丙世且丞丆丆()
    {
        return (long)this.业下丟丟丕丄不七丞;
    }
    internal void 万下世丂丄丛丒下东(long 丙业与丙丗丝不丈东)
    {
        this.业下丟丟丕丄不七丞 = 丙业与丙丗丝不丈东;
    }
    internal 不上且丙丘丞丕业丙()
    {
    
    }
    internal 不上且丙丘丞丕业丙(string 丌且专不丙丕专丅万)
    {
        object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌且专不丙丕专丅万);
    }
    internal 不上且丙丘丞丕业丙(object 丌且专不丙丕专丅万)
    {
        System.IFormatProvider val_10;
        object val_1 = 0;
        object val_6 = 0;
        if((0.TryGetValue(key:  "d", value: out  val_1)) == false)
        {
            goto label_4;
        }
        
        val_10 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        int val_5 = System.Convert.ToInt32(value:  val_1, provider:  System.Globalization.CultureInfo.InvariantCulture);
        this.丐丞不丌丛丒上丏丛 = 0;
        mem[1152921539652618312] = 0;
        if(1 != 0)
        {
            goto label_9;
        }
        
        goto label_13;
        label_4:
        UnityEngine.Debug.LogError(message:  "TryGun_OfferI_nfo: ErrorParse discnt");
        if(1 == 0)
        {
            goto label_13;
        }
        
        label_9:
        label_13:
        if((0.TryGetValue(key:  "t", value: out  val_6)) != false)
        {
                val_10 = System.Globalization.CultureInfo.InvariantCulture;
            this.业下丟丟丕丄不七丞 = System.Convert.ToInt64(value:  val_6, provider:  val_10);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "TryGun_Offer_Info: ErrorParse timeSt_artOffer");
    }
    internal 不上且丙丘丞丕业丙(int 丂丂丆丟丑七丟丑业, long 专万丂丛与丙一丘万)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.业下丟丟丕丄不七丞 = 专万丂丛与丙一丘万;
        this.丐丞不丌丛丒上丏丛 = 0;
        mem[1152921539652742600] = 0;
    }
    public override string ToString()
    {
        return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丁丕上三丕丌丟丗丙());
    }
    internal System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.set_Item(key:  "d", value:  this.丐丞不丌丛丒上丏丛);
        val_1.set_Item(key:  "t", value:  this.业下丟丟丕丄不七丞);
        return val_1;
    }

}
