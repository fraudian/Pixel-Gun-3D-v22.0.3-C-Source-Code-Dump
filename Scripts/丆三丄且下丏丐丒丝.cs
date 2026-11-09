using UnityEngine;
public class GiftController.丆三丄且下丏丐丒丝
{
    // Fields
    public GiftCategoryType 七丌丌丏丗东丕且丅;
    private Rilisoft.丝丑丂丛万丐丈丘且 丙业丂丑丄业万下业;
    public bool 丘上丙专丛丏三丐丒;
    public string 下丄丈不与世丐业专;
    public string 丄丅丛丆丟丁丘业丂;
    public System.Nullable<CategoryNames> 不上上丕且丗丕丝三;
    
    // Properties
    public int 丒专下与丑丁丆丟业 { get; set; }
    
    // Methods
    public int 丂丁丏一丙丛业且丌()
    {
    
    }
    public void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丙业丂丑丄业万下业 = 0;
        mem[1152921537810800112] = 0;
    }
    internal static GiftController.丆三丄且下丏丐丒丝 东丝七业丄丑丒世七(SlotInfo 与丄不丌一世东丁丙, bool 下万丄且丄丕丌七丞)
    {
        GiftCategory val_2 = 与丄不丌一世东丁丙.category;
        .七丌丌丏丗东丕且丅 = val_2.Type;
        .下丄丈不与世丐业专 = 与丄不丌一世东丁丙.gift.Id;
        int val_3 = 与丄不丌一世东丁丙.gift.Count;
        int val_4 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        .丙业丂丑丄业万下业 = 0;
        mem[1152921537810989168] = 0;
        System.Nullable<CategoryNames> val_5 = 与丄不丌一世东丁丙.gift.TypeShopCat;
        .不上上丕且丗丕丝三 = val_5;
        .丄丅丛丆丟丁丘业丂 = 与丄不丌一世东丁丙.gift.KeyTranslateInfo;
        .丘上丙专丛丏三丐丒 = 与丄不丌一世东丁丙.HasParts;
        return (丆三丄且下丏丐丒丝)new GiftController.丆三丄且下丏丐丒丝();
    }
    public GiftController.丆三丄且下丏丐丒丝()
    {
    
    }

}
