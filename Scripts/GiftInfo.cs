using UnityEngine;
[Serializable]
public class GiftInfo
{
    // Fields
    internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> Counts;
    public bool HasParts;
    public string Id;
    public string KeyTranslateInfo;
    public GiftInfo RootInfo;
    internal PGCompany.三东丏不丗世丅丌丄 itemParams;
    internal GiftSettingType Setting;
    
    // Properties
    internal int Count { get; }
    private int InternalCount { get; }
    public System.Nullable<CategoryNames> TypeShopCat { get; }
    
    // Methods
    internal int get_Count()
    {
        if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  this.itemParams)) == false)
        {
                return this.InternalCount;
        }
        
        if(this.itemParams != null)
        {
                return this.itemParams.丂丁丏一丙丛业且丌();
        }
        
        return this.itemParams.丂丁丏一丙丛业且丌();
    }
    private int get_InternalCount()
    {
        System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = this;
        val_7 = null;
        val_7 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_8 = null;
            val_8 = null;
            if(GiftController.丆丕丝丒不丙且丐丗.丅丒东丝上丌丗丒丞() < this.Counts.Count)
        {
                val_9 = null;
            val_6 = this.Counts;
            val_9 = null;
            Rilisoft.丝丑丂丛万丐丈丘且 val_5 = val_6.Item[GiftController.丆丕丝丒不丙且丐丗.丅丒东丝上丌丗丒丞()];
            val_10;
            return (int)val_10;
        }
        
        }
        
        val_10 = 0;
        return (int)val_10;
    }
    public System.Nullable<CategoryNames> get_TypeShopCat()
    {
        var val_6;
        三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.Id);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.Id)) == false)
        {
            goto label_5;
        }
        
        label_14:
        val_6 = 0;
        return (System.Nullable<CategoryNames>)val_6;
        label_5:
        if(((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.Id)) & 2147483648) != 0)
        {
            goto label_9;
        }
        
        label_13:
        val_6 = 0;
        return (System.Nullable<CategoryNames>)val_6;
        label_9:
        三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.Id);
        if(val_4 == null)
        {
                return (System.Nullable<CategoryNames>)val_6;
        }
        
        if((val_4.万上丄下业丛丌不丈() & 2147483648) == 0)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    internal static GiftInfo 丌世不万丒丂且上上(GiftInfo 业丘丙一一业丑丐丆, string 丑丞业丗丒三丂且东, int 丌丒丝东丌下丕丁丅 = 1)
    {
        GiftInfo val_1 = new GiftInfo();
        if(val_1 != null)
        {
                .Counts = 业丘丙一一业丑丐丆.Counts;
            .Id = 丑丞业丗丒三丂且东;
            .KeyTranslateInfo = 业丘丙一一业丑丐丆.KeyTranslateInfo;
        }
        else
        {
                mem[16] = 业丘丙一一业丑丐丆.Counts;
            mem[32] = 丑丞业丗丒三丂且东;
            mem[40] = 业丘丙一一业丑丐丆.KeyTranslateInfo;
        }
        
        .RootInfo = 业丘丙一一业丑丐丆;
        return val_1;
    }
    public GiftInfo()
    {
        this.Counts = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
        this.Setting = 1;
        this.KeyTranslateInfo = "";
    }

}
