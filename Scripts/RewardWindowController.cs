using UnityEngine;
internal class RewardWindowController : MonoBehaviour, IEnumerable
{
    // Fields
    private static System.Action 与丟万丟丏丆业丒且;
    private System.Collections.Generic.List<丁丙丆丑不三丌丗丟> _sortingOrder;
    private UnityEngine.Transform initialRewardPanelPosition;
    private bool 丞三与上东丅丑丁业;
    private RewardWindowView mainReward;
    private UnityEngine.Transform positionOneRewardPanel;
    private UnityEngine.Transform positionTwoRewardPanels;
    private RewardWindowView potentialReward;
    private System.Collections.Generic.HashSet<丞丅与与丈丕丟丑丘> 上业丟世三与七七三;
    private int <丛丛丁七三与丛上一>k__BackingField;
    private int <丁丐丑世丝丏世丈丗>k__BackingField;
    private int <丂三业丒且丝七丁丝>k__BackingField;
    private int <丈东丞丄丈专丄丁丆>k__BackingField;
    private int <世丂丕丙上丑东丘丘>k__BackingField;
    private int <丒一七东东丐丁丟万>k__BackingField;
    private int <七丂丒丞丝丛七万上>k__BackingField;
    private int <业业丆下丅丆丝丑下>k__BackingField;
    private int <三丞专丕世万丟上七>k__BackingField;
    private Rilisoft.OfferItem <丑丆丐丏万丆丌丈丙>k__BackingField;
    private Rilisoft.OfferItem <丕世七丅丙丅丟七专>k__BackingField;
    private PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 <下丈一丈丗丐上丅丛>k__BackingField;
    private int <一丈丆专万丒东专丈>k__BackingField;
    private int <上世丅不丌丝丄上业>k__BackingField;
    private int <丒丙丅下七丟丆丒丝>k__BackingField;
    private int <丟丏七且丝东丗丞三>k__BackingField;
    private int <丗丈丄丄一丘丆丈丞>k__BackingField;
    private int <丆丌不丙上丁不丌三>k__BackingField;
    private int <不丘丟不丗业与丞一>k__BackingField;
    private int <且丕丛丟丅世专丄丐>k__BackingField;
    private int <丛丁丅下不专丕丏丏>k__BackingField;
    private int <万丌丁丒丐丝丑丒丌>k__BackingField;
    private int <丞丁丂丁丒丆丕业丙>k__BackingField;
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> <且丆丈专丟丅丝丛丙>k__BackingField;
    private int <三丂丂不三与丘不与>k__BackingField;
    private int <不与丛业业丁丆丈不>k__BackingField;
    private int <丞一不业专丈丗业丄>k__BackingField;
    private int <丑丅丘丗丝一不丐丙>k__BackingField;
    private int <丟丅丒专丁世专且丅>k__BackingField;
    private int <不不下丐且三丛丄丆>k__BackingField;
    private int <丟业万丆丁丙丕丒与>k__BackingField;
    private int <且丘丑丅上业世丞且>k__BackingField;
    private int <丞万世世上丂丟丟丄>k__BackingField;
    private Rilisoft.OfferItem <丐丅丆丏万丗丂丆丆>k__BackingField;
    private Rilisoft.OfferItem <世三丂三七丘丁丄丐>k__BackingField;
    private PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 <且业业丑丞丙三不丒>k__BackingField;
    private 丁丁丒丆不丒下丟三 <七丏丅丝丄丛丛丅丐>k__BackingField;
    private int <丛上且丐七丁三万专>k__BackingField;
    private bool <丗丆且丑丏丕世丈丙>k__BackingField;
    private bool <丑丟丌丒丘丞丅丈丏>k__BackingField;
    private float _startOpenChestByAlphaValue;
    private UnityEngine.Coroutine 丝丟万业丒丑万丐下;
    
    // Properties
    internal RewardWindowView 丌丆业丅丅上丘专万 { get; }
    internal RewardWindowView 丄专下丟丞三下丞上 { get; }
    internal int 丌丗丐丈丘丝丝丒七 { get; }
    internal int 上丘万上下与丒丞万 { get; set; }
    internal int 丗上世丘丐世上三一 { get; set; }
    internal int 丁丅丅丏丂丂丝三丌 { get; set; }
    internal int 业丙丒上且丙上丐丛 { get; set; }
    internal int 专三丝与丄东一丒丒 { get; set; }
    internal int 专丗丕丁丅世业一七 { get; set; }
    internal int 丝业丟东丌七丑业不 { get; set; }
    internal int 万三丅上世业丝丙不 { get; set; }
    internal int 丂丟专丆丅专下且不 { get; set; }
    internal Rilisoft.OfferItem 三不丒丂丙三丙且万 { get; set; }
    internal Rilisoft.OfferItem 丑世丑下丁东丟与丟 { get; set; }
    internal PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丕丅世丐丏丝丛万丟 { get; set; }
    internal int 丟丆东丙不丘丘丑与 { get; set; }
    internal int 丆不丕且业丝一东丒 { get; set; }
    internal int 丙与丄丘丞业丏丐丟 { get; set; }
    internal int 丟丘万丈万丒丞上丗 { get; set; }
    internal int 丁丗东丐丈丛丕丄丌 { get; set; }
    internal int 与七一业专一丕不三 { get; set; }
    internal int 丞丟丟一丘丑丆丞丗 { get; set; }
    internal int 下丐且万七丝一专丝 { get; set; }
    internal int 一丂与且丞丛丘丑丐 { get; set; }
    internal int 上世三丁丞丌丘丙上 { get; set; }
    internal int 丒丑世丛世丗丁且七 { get; set; }
    internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 世一丆丟与与专七万 { get; set; }
    internal int 丒丗丄丅东东丛且丗 { get; set; }
    internal int 丂丑丟丂丟丏丝丅丛 { get; set; }
    internal int 丕东丞丕与万丈丅专 { get; set; }
    internal int 丗丐丑丞丈专下丗专 { get; set; }
    internal int 丟丂丒三丏丞丆丗一 { get; set; }
    internal int 丞丌一丆七与不丘东 { get; set; }
    internal int 丏丄丙丌业丐丝丝丆 { get; set; }
    internal int 丁不与七不丄丅丟丛 { get; set; }
    internal int 三丄丗且下不丕丘世 { get; set; }
    internal Rilisoft.OfferItem 下丕丙一丒万七丝丌 { get; set; }
    internal Rilisoft.OfferItem 丝丘丅丘下丙业丑且 { get; set; }
    internal PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 下下丑与业与丐丘丂 { get; set; }
    internal 丁丁丒丆不丒下丟三 丁丁丒丆不丒下丟三 { get; set; }
    internal int 丌丈丑一丕丑丂业下 { get; set; }
    internal bool 丒丂专东丕丟丛丑丞 { get; set; }
    internal bool 丒丛七下业丅丁丑专 { get; set; }
    internal bool 丞丈不丄丄三且丞丈 { get; }
    
    // Methods
    internal static void 丅丑东业丈丐丒一世(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  RewardWindowController.与丟万丟丏丆业丒且, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丁上丁丆且不上七且(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  RewardWindowController.与丟万丟丏丆业丒且, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal RewardWindowView 丂丅与丘丂丟丛丙七()
    {
        return (RewardWindowView)this.mainReward;
    }
    internal RewardWindowView 丟丕专丁丒与下丌七()
    {
        return (RewardWindowView)this.potentialReward;
    }
    internal int 万万下东上丏且丅七()
    {
        if(this.上业丟世三与七七三 != null)
        {
                return this.上业丟世三与七七三.Count;
        }
        
        return this.上业丟世三与七七三.Count;
    }
    internal int 丝丈丑业不丝丑丏丟()
    {
        return (int)this.<丛丛丁七三与丛上一>k__BackingField;
    }
    private void 一与与丕一丕东专上(int 丙业与丙丗丝不丈东)
    {
        this.<丛丛丁七三与丛上一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丈丙丂丝丞上丆一丅()
    {
        return (int)this.<丁丐丑世丝丏世丈丗>k__BackingField;
    }
    private void 一丑与丝七丁丒丌丏(int 丙业与丙丗丝不丈东)
    {
        this.<丁丐丑世丝丏世丈丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丘丒丄丞丘丂丄丅丅()
    {
        return (int)this.<丂三业丒且丝七丁丝>k__BackingField;
    }
    private void 丑丌丞不丁丏丙丞丌(int 丙业与丙丗丝不丈东)
    {
        this.<丂三业丒且丝七丁丝>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 不丝丟丄丏一丐专丒()
    {
        return (int)this.<丈东丞丄丈专丄丁丆>k__BackingField;
    }
    private void 丙且丘万一世上上丐(int 丙业与丙丗丝不丈东)
    {
        this.<丈东丞丄丈专丄丁丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丕丘丗一下且丆不丒()
    {
        return (int)this.<世丂丕丙上丑东丘丘>k__BackingField;
    }
    private void 丄丈丑丅丛丕丂专丐(int 丙业与丙丗丝不丈东)
    {
        this.<世丂丕丙上丑东丘丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丝丑丞下一丙丝不丌()
    {
        return (int)this.<丒一七东东丐丁丟万>k__BackingField;
    }
    private void 丒业丝东丈不万丑丝(int 丙业与丙丗丝不丈东)
    {
        this.<丒一七东东丐丁丟万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 业一丅丆一丝一丏丘()
    {
        return (int)this.<七丂丒丞丝丛七万上>k__BackingField;
    }
    private void 丑丐万世丟丂专与丟(int 丙业与丙丗丝不丈东)
    {
        this.<七丂丒丞丝丛七万上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丗丛与丏丟丒丒不上()
    {
        return (int)this.<业业丆下丅丆丝丑下>k__BackingField;
    }
    private void 上下丞丛丙丛丅与丈(int 丙业与丙丗丝不丈东)
    {
        this.<业业丆下丅丆丝丑下>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丐丅上且东一七且丘()
    {
        return (int)this.<三丞专丕世万丟上七>k__BackingField;
    }
    private void 丞业丅与业且上七业(int 丙业与丙丗丝不丈东)
    {
        this.<三丞专丕世万丟上七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal Rilisoft.OfferItem 丗东丁世一丞与与专()
    {
        return (Rilisoft.OfferItem)this.<丑丆丐丏万丆丌丈丙>k__BackingField;
    }
    private void 万专七东丈与丌丙丅(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
    {
        this.<丑丆丐丏万丆丌丈丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal Rilisoft.OfferItem 丛丄丏东东丌丙三业()
    {
        return (Rilisoft.OfferItem)this.<丕世七丅丙丅丟七专>k__BackingField;
    }
    private void 一丒丆世一丒下丞丈(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
    {
        this.<丕世七丅丙丅丟七专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 东丂丐与丑专七丌三()
    {
        return (下东丙丑丙丞丛丑上)this.<下丈一丈丗丐上丅丛>k__BackingField;
    }
    private void 专不丌丆丆丐东丞丄(PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丙业与丙丗丝不丈东)
    {
        this.<下丈一丈丗丐上丅丛>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丄丁丝七不丂且丏丛()
    {
        return (int)this.<一丈丆专万丒东专丈>k__BackingField;
    }
    internal void 丕丅世东业三丟丙业(int 丙业与丙丗丝不丈东)
    {
        this.<一丈丆专万丒东专丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丄丛下一丙三丈丈丑()
    {
        return (int)this.<上世丅不丌丝丄上业>k__BackingField;
    }
    internal void 丙与丟丁七业丙东丌(int 丙业与丙丗丝不丈东)
    {
        this.<上世丅不丌丝丄上业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丝丙丐七丒丆丝丑三()
    {
        return (int)this.<丒丙丅下七丟丆丒丝>k__BackingField;
    }
    internal void 丘丆丘丘丏专东丗与(int 丙业与丙丗丝不丈东)
    {
        this.<丒丙丅下七丟丆丒丝>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 且丝丕丁丗万丘万丄()
    {
        return (int)this.<丟丏七且丝东丗丞三>k__BackingField;
    }
    internal void 丟七一丟与七丆不三(int 丙业与丙丗丝不丈东)
    {
        this.<丟丏七且丝东丗丞三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 世丆丏丐专丈丕丏丁()
    {
        return (int)this.<丗丈丄丄一丘丆丈丞>k__BackingField;
    }
    internal void 七丌丗不丄丛丟丞丁(int 丙业与丙丗丝不丈东)
    {
        this.<丗丈丄丄一丘丆丈丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 上丗东丐丘丐丆丈丂()
    {
        return (int)this.<丆丌不丙上丁不丌三>k__BackingField;
    }
    internal void 万三东与丁且且丑丌(int 丙业与丙丗丝不丈东)
    {
        this.<丆丌不丙上丁不丌三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丌丌丒东丑丙一丂不()
    {
        return (int)this.<不丘丟不丗业与丞一>k__BackingField;
    }
    internal void 丌上丏丐丘东丗丛丙(int 丙业与丙丗丝不丈东)
    {
        this.<不丘丟不丗业与丞一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 七丏与世丈丙丐丄世()
    {
        return (int)this.<且丕丛丟丅世专丄丐>k__BackingField;
    }
    internal void 业丏丈丞丐丈丌万丘(int 丙业与丙丗丝不丈东)
    {
        this.<且丕丛丟丅世专丄丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丛上与不丑丑七专一()
    {
        return (int)this.<丛丁丅下不专丕丏丏>k__BackingField;
    }
    internal void 丒丁上万丏世丈丝丈(int 丙业与丙丗丝不丈东)
    {
        this.<丛丁丅下不专丕丏丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丈专丏丗丟专丄丌万()
    {
        return (int)this.<万丌丁丒丐丝丑丒丌>k__BackingField;
    }
    internal void 业丌万且丐丅丏三丗(int 丙业与丙丗丝不丈东)
    {
        this.<万丌丁丒丐丝丑丒丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 东丌丆业丞下上东丒()
    {
        return (int)this.<丞丁丂丁丒丆丕业丙>k__BackingField;
    }
    internal void 丈丒丑丞丌三三丈世(int 丙业与丙丗丝不丈东)
    {
        this.<丞丁丂丁丒丆丕业丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丗丏一丑丑丟与丝专()
    {
        return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this.<且丆丈专丟丅丝丛丙>k__BackingField;
    }
    internal void 丛丛丂一丂三丆不丈(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
    {
        this.<且丆丈专丟丅丝丛丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 专不三丙丅丞丄不丑()
    {
        return (int)this.<三丂丂不三与丘不与>k__BackingField;
    }
    internal void 一丄丁丆丈丕专丌丌(int 丙业与丙丗丝不丈东)
    {
        this.<三丂丂不三与丘不与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丐丞丕丞丟下丑下丒()
    {
        return (int)this.<不与丛业业丁丆丈不>k__BackingField;
    }
    internal void 且三丞丈上丘丛一丄(int 丙业与丙丗丝不丈东)
    {
        this.<不与丛业业丁丆丈不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 且丞上丁万不专下专()
    {
        return (int)this.<丞一不业专丈丗业丄>k__BackingField;
    }
    internal void 下丁一丐丞世专丑丛(int 丙业与丙丗丝不丈东)
    {
        this.<丞一不业专丈丗业丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丝东丗丏丗丁丕丈丝()
    {
        return (int)this.<丑丅丘丗丝一不丐丙>k__BackingField;
    }
    internal void 专世丅不丑下丒东丒(int 丙业与丙丗丝不丈东)
    {
        this.<丑丅丘丗丝一不丐丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丐万丐丌丛上丘丞丂()
    {
        return (int)this.<丟丅丒专丁世专且丅>k__BackingField;
    }
    internal void 丞丏丝七丈丒不丗丅(int 丙业与丙丗丝不丈东)
    {
        this.<丟丅丒专丁世专且丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丅下丐丕丂丞丝丑丝()
    {
        return (int)this.<不不下丐且三丛丄丆>k__BackingField;
    }
    internal void 丄丁丗丄三万丁丌丞(int 丙业与丙丗丝不丈东)
    {
        this.<不不下丐且三丛丄丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丛与丆丏与丛丈世上()
    {
        return (int)this.<丟业万丆丁丙丕丒与>k__BackingField;
    }
    internal void 不丟丄丙丏三丝丅丞(int 丙业与丙丗丝不丈东)
    {
        this.<丟业万丆丁丙丕丒与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丏下七丐且且丙万丕()
    {
        return (int)this.<且丘丑丅上业世丞且>k__BackingField;
    }
    internal void 丒下丗丑丑万下丈丝(int 丙业与丙丗丝不丈东)
    {
        this.<且丘丑丅上业世丞且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丘三丘上丙丌丞丂丏()
    {
        return (int)this.<丞万世世上丂丟丟丄>k__BackingField;
    }
    internal void 丂丐丒丛丁丅丅丞三(int 丙业与丙丗丝不丈东)
    {
        this.<丞万世世上丂丟丟丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal Rilisoft.OfferItem 业一上七一丄丒东丅()
    {
        return (Rilisoft.OfferItem)this.<丐丅丆丏万丗丂丆丆>k__BackingField;
    }
    internal void 上丄丆丈丕七丄业丂(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
    {
        this.<丐丅丆丏万丗丂丆丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal Rilisoft.OfferItem 丕东与丞丈丕丟上丈()
    {
        return (Rilisoft.OfferItem)this.<世三丂三七丘丁丄丐>k__BackingField;
    }
    internal void 丛丅一与丒不丕丆且(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
    {
        this.<世三丂三七丘丁丄丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丗丈丝且一三七不丐()
    {
        return (下东丙丑丙丞丛丑上)this.<且业业丑丞丙三不丒>k__BackingField;
    }
    internal void 丂丟三专丛世七三丒(PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丙业与丙丗丝不丈东)
    {
        this.<且业业丑丞丙三不丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 丁丁丒丆不丒下丟三 下丙丅丑专丝三丗丞()
    {
        return (丁丁丒丆不丒下丟三)this.<七丏丅丝丄丛丛丅丐>k__BackingField;
    }
    private void 丞丛丘与丑丟丈东丒(丁丁丒丆不丒下丟三 丙业与丙丗丝不丈东)
    {
        this.<七丏丅丝丄丛丛丅丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 专丏丁三丝丁丗上丏()
    {
        return (int)this.<丛上且丐七丁三万专>k__BackingField;
    }
    private void 上丂七世不丅丐丘丈(int 丙业与丙丗丝不丈东)
    {
        this.<丛上且丐七丁三万专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丈丂丟丒万下上下业()
    {
        return (bool)this.<丗丆且丑丏丕世丈丙>k__BackingField;
    }
    private void 丝丙下丞丗专丟下与(bool 丙业与丙丗丝不丈东)
    {
        this.<丗丆且丑丏丕世丈丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丑丝七丘东丅专丂七()
    {
        return (bool)this.<丑丟丌丒丘丞丅丈丏>k__BackingField;
    }
    private void 上丞一丟丒丘业世专(bool 丙业与丙丗丝不丈东)
    {
        this.<丑丟丌丒丘丞丅丈丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 三丆世三上万丙丈不()
    {
        return (bool)this.丞三与上东丅丑丁业;
    }
    internal void 三万不业七丘丄丂丞(int 一七东丑丘世丑丙不, int 丂丁丏丏万丛丈丐丆, int 丈上下与丌丘丅丙丒, int 丙七丝丂丏丌丞万一, int 丌丙专丗丏不丐丗丅, bool 不丁丛丈丙世丈万丟, int 上丛丕丙三丁专下丂, int 丕且七丅业丄丝丞东, int 业丒下业丛丆丂丗丕, int 下丅丌丌丆不东专丁, Rilisoft.OfferItem 下丅丙一丂丗丅丝七, Rilisoft.OfferItem 丄丐不丏丁丘不丒丈, PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 上丁丗丐丝丛丝世丂, 丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        下东丙丑丙丞丛丑上 val_5;
        丁丁丒丆不丒下丟三 val_6;
        var val_7;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_8;
        var val_9;
        val_5 = 上丁丗丐丝丛丝世丂;
        val_6 = 丞丙下万丗丝丄七丝;
        val_5 = val_5;
        val_6 = val_6;
        this.<且业业丑丞丙三不丒>k__BackingField = val_5;
        this.<七丏丅丝丄丛丛丅丐>k__BackingField = val_6;
        this.<丛丛丁七三与丛上一>k__BackingField = 一七东丑丘世丑丙不;
        this.<丁丐丑世丝丏世丈丗>k__BackingField = 丂丁丏丏万丛丈丐丆;
        this.<丂三业丒且丝七丁丝>k__BackingField = 丈上下与丌丘丅丙丒;
        this.<丈东丞丄丈专丄丁丆>k__BackingField = 丙七丝丂丏丌丞万一;
        this.<世丂丕丙上丑东丘丘>k__BackingField = 丌丙专丗丏不丐丗丅;
        this.<丒一七东东丐丁丟万>k__BackingField = 上丛丕丙三丁专下丂;
        this.<七丂丒丞丝丛七万上>k__BackingField = 丕且七丅业丄丝丞东;
        this.<业业丆下丅丆丝丑下>k__BackingField = 业丒下业丛丆丂丗丕;
        this.<三丞专丕世万丟上七>k__BackingField = 下丅丌丌丆不东专丁;
        this.<丑丆丐丏万丆丌丈丙>k__BackingField = 下丅丙一丂丗丅丝七;
        this.<丕世七丅丙丅丟七专>k__BackingField = 丄丐不丏丁丘不丒丈;
        this.<下丈一丈丗丐上丅丛>k__BackingField = val_5;
        this.<三丂丂不三与丘不与>k__BackingField = 一七东丑丘世丑丙不;
        this.<不与丛业业丁丆丈不>k__BackingField = 丂丁丏丏万丛丈丐丆;
        this.<丞一不业专丈丗业丄>k__BackingField = 丈上下与丌丘丅丙丒;
        this.<丑丅丘丗丝一不丐丙>k__BackingField = 丙七丝丂丏丌丞万一;
        this.<丟丅丒专丁世专且丅>k__BackingField = 丌丙专丗丏不丐丗丅;
        this.<不不下丐且三丛丄丆>k__BackingField = 上丛丕丙三丁专下丂;
        this.<丟业万丆丁丙丕丒与>k__BackingField = 丕且七丅业丄丝丞东;
        this.<且丘丑丅上业世丞且>k__BackingField = 业丒下业丛丆丂丗丕;
        this.<丞万世世上丂丟丟丄>k__BackingField = 下丅丌丌丆不东专丁;
        this.<丐丅丆丏万丗丂丆丆>k__BackingField = 下丅丙一丂丗丅丝七;
        this.<世三丂三七丘丁丄丐>k__BackingField = 丄丐不丏丁丘不丒丈;
        this.<丗丆且丑丏丕世丈丙>k__BackingField = 不丁丛丈丙世丈万丟;
        this.<丛上且丐七丁三万专>k__BackingField = 0;
        val_7 = null;
        val_7 = null;
        val_8 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_8 != null)
        {
                val_8 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_8 == null)
        {
                val_8 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_8.丌不丅不丞东万专专();
            if((val_2.HasValue.丙东专丂世丈丏丁丂() == 1) && (((-110834824) & 1) != 0))
        {
                val_9 = null;
            val_9 = null;
            this.<丛上且丐七丁三万专>k__BackingField = GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七();
        }
        
        }
        
        this.mainReward.丐万丈与丒业世业丞 = false;
        this.mainReward.丆丆且丘丏七与且业 = false;
        this.mainReward.业不万七下丂专丝且 = false;
        this.mainReward.丏丕丏丆丁丌一丌上 = false;
        this.mainReward.下一丄丝专丛一专丌 = false;
        this.mainReward.下丒世东丒丂且丌世 = false;
        this.mainReward.丗丞丟下东七不万东 = false;
        this.mainReward.与专一七丛丅专丒下 = false;
    }
    internal bool 丗丕东七三世一丗东(丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三)
    {
        丞丅与与丈丕丟丑丘 val_5 = 丗七丟丈三不丕一三;
        .丗七丟丈三不丕一三 = val_5;
        if((this.<丑丟丌丒丘丞丅丈丏>k__BackingField) == true)
        {
                return false;
        }
        
        val_5 = this.上业丟世三与七七三;
        if((System.Linq.Enumerable.FirstOrDefault<丞丅与与丈丕丟丑丘>(source:  val_5, predicate:  new System.Func<丞丅与与丈丕丟丑丘, System.Boolean>(object:  new RewardWindowController.七丒丁不丑下丕且丆(), method:  System.Boolean RewardWindowController.七丒丁不丑下丕且丆::世七万丌业丘丑丕丌(丞丅与与丈丕丟丑丘 三丟东丕丄丄下下丑)))) != null)
        {
                return false;
        }
        
        bool val_4 = this.上业丟世三与七七三.Add(item:  (RewardWindowController.七丒丁不丑下丕且丆)[1152921538855963968].丗七丟丈三不丕一三);
        return false;
    }
    private void 丒丄丈丒丟丒专丂丗(丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三)
    {
        .丗七丟丈三不丕一三 = 丗七丟丈三不丕一三;
        if((this.<丑丟丌丒丘丞丅丈丏>k__BackingField) != false)
        {
                return;
        }
        
        丞丅与与丈丕丟丑丘 val_3 = System.Linq.Enumerable.FirstOrDefault<丞丅与与丈丕丟丑丘>(source:  this.上业丟世三与七七三, predicate:  new System.Func<丞丅与与丈丕丟丑丘, System.Boolean>(object:  new RewardWindowController.丏且丄东上丗丂世丅(), method:  System.Boolean RewardWindowController.丏且丄东上丗丂世丅::上与丁丛丛丛丈与专(丞丅与与丈丕丟丑丘 三丟东丕丄丄下下丑)));
        if(val_3 == null)
        {
                return;
        }
        
        bool val_4 = this.上业丟世三与七七三.Remove(item:  val_3);
        bool val_5 = this.上业丟世三与七七三.Add(item:  (RewardWindowController.丏且丄东上丗丂世丅)[1152921538856139456].丗七丟丈三不丕一三);
    }
    public void Clear()
    {
        if((this.<丑丟丌丒丘丞丅丈丏>k__BackingField) != false)
        {
                return;
        }
        
        this.上业丟世三与七七三.Clear();
    }
    private System.Collections.Generic.List<丞丅与与丈丕丟丑丘> 丕世七丗丁万且世专()
    {
        return this.三丘丘丘丒丒且丂业();
    }
    private System.Collections.Generic.List<丞丅与与丈丕丟丑丘> 三丘丘丘丒丒且丂业()
    {
        System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<丞丅与与丈丕丟丑丘>(source:  this.上业丟世三与七七三);
        if(this._sortingOrder == null)
        {
                return (System.Collections.Generic.List<丞丅与与丈丕丟丑丘>)val_1;
        }
        
        val_1.Sort(comparison:  new System.Comparison<丞丅与与丈丕丟丑丘>(object:  this, method:  System.Int32 RewardWindowController::丒丕丄丛丆专丄专专(丞丅与与丈丕丟丑丘 丈丂丕下丏丈丞丗业, 丞丅与与丈丕丟丑丘 丂丌丌丛丆丆丙丌丈)));
        return (System.Collections.Generic.List<丞丅与与丈丕丟丑丘>)val_1;
    }
    internal void 丌且且丒丝一丝丅一()
    {
        var val_12;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_14;
        var val_15;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_17;
        RatingSystem.丁上且上一丆丘与业 val_18;
        int val_19;
        int val_20;
        int val_21;
        int val_22;
        this.且下丏丄一业万丟丗();
        丞丅与与丈丕丟丑丘 val_2 = new 丞丅与与丈丕丟丑丘(丟丛丑丒丆丛东下丌:  2, 丟业丈丈丞丂丞丑业:  Rilisoft.VIPController.专丌丞丌丕丕丞丅丆());
        val_12 = null;
        val_12 = null;
        val_14 = RewardWindowController.<>c.<>9__185_0;
        if(val_14 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_3 = null;
            val_14 = val_3;
            val_3 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::专万东不丝丏丟丒世(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__185_0 = val_14;
        }
        
        val_15 = null;
        val_15 = null;
        val_17 = RewardWindowController.<>c.<>9__185_1;
        if(val_17 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_5 = null;
            val_17 = val_5;
            val_5 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丕万丅丘丁丟丛丞丅(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__185_1 = val_17;
        }
        
        if((this.<七丏丅丝丄丛丛丅丐>k__BackingField) != null)
        {
                val_18 = this.<七丏丅丝丄丛丛丅丐>k__BackingField.丕丈一丐丛世丆上万;
        }
        else
        {
                val_18 = 0;
        }
        
        val_19 = this.<丛丛丁七三与丛上一>k__BackingField;
        val_20 = this.<丁丐丑世丝丏世丈丗>k__BackingField;
        val_21 = this.<丂三业丒且丝七丁丝>k__BackingField;
        val_22 = this.<丈东丞丄丈专丄丁丆>k__BackingField;
        if(this.potentialReward == null)
        {
                val_22 = val_22;
            val_21 = val_21;
            val_20 = val_20;
            val_19 = val_19;
            val_18 = val_18;
        }
        
        this.potentialReward.丘丘丙一与丛丗丅丌(丑丁丐丏业丗一丏丈:  val_19, 丕丗业下七丕丝七三:  val_20, 且丘丞丕丐丗丅丅丂:  val_21, 丙与丂丘丁且七丝丅:  val_22, 丂世业丏丌丛丛丙丘:  this.<世丂丕丙上丑东丘丘>k__BackingField, 不丁丛丈丙世丈万丟:  ((this.<丗丆且丑丏丕世丈丙>k__BackingField) == true) ? 1 : 0, 万丙丒世七不丌丒丐:  this.<丒一七东东丐丁丟万>k__BackingField, 与上丌丞丙丙丂丈丌:  this.<七丂丒丞丝丛七万上>k__BackingField, 且专不下丒万东丟丏:  this.<业业丆下丅丆丝丑下>k__BackingField, 世丕丅与丆丄丗丐万:  this.<三丞专丕世万丟上七>k__BackingField, 下丅丙一丂丗丅丝七:  0, 丛丐业丞东七丒下丗:  this.<世三丂三七丘丁丄丐>k__BackingField, 与丑丆丑一丂丑上丙:  this.<且业业丑丞丙三不丒>k__BackingField, 丄下丘丘丗丙丙丕丞:  0, 丐下丝丘丑丟丟丗丌:  0);
        this.potentialReward.丝丗丌上丐丑业一业();
        this.potentialReward.丏丏丟上丙万一丌东(丆三与下丅一不丘世:  (this.<丛丛丁七三与丛上一>k__BackingField) * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_3)), 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        this.potentialReward.丘业丏丁万上不丐丙(丟且丗丆丁丐丅丏丆:  (this.<丁丐丑世丝丏世丈丗>k__BackingField) * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_5)), 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        this.potentialReward.业七业丄业丟丄下一(丝世三世不丏上七丞:  this.<丂三业丒且丝七丁丝>k__BackingField, 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        this.potentialReward.七丂万且一上专丒丁(丝世三世不丏上七丞:  this.<丈东丞丄丈专丄丁丆>k__BackingField);
        this.potentialReward.丞与万丌丏下不与丞(丌丁且丕丞一一与七:  this.<世丂丕丙上丑东丘丘>k__BackingField, 丛丕不丞与丕万世丆:  ((this.<丗丆且丑丏丕世丈丙>k__BackingField) == true) ? 1 : 0, 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        this.potentialReward.丟东丅与三一不万丝(丛丅下世丑丈丐与一:  this.<丒一七东东丐丁丟万>k__BackingField, 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        this.potentialReward.丏丘七与上丅丗丆丙(与上丌丞丙丙丂丈丌:  this.<七丂丒丞丝丛七万上>k__BackingField, 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        this.potentialReward.丏丏丁且专丛丅丗丂(且专不下丒万东丟丏:  this.<业业丆下丅丆丝丑下>k__BackingField, 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        this.potentialReward.业丙丈丞一下万丗丐(丂且且丟丟东丕一丑:  this.<世三丂三七丘丁丄丐>k__BackingField, 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        this.potentialReward.丟丁丄世丈丄一万丏(下丅丙一丂丗丅丝七:  this.<且业业丑丞丙三不丒>k__BackingField, 丒丙业丕万丒丞万丂:  val_2, 丙万丟上丞丒丞万丗:  false);
        if((this.<七丏丅丝丄丛丛丅丐>k__BackingField) == null)
        {
            goto label_27;
        }
        
        if(this.potentialReward != null)
        {
            goto label_34;
        }
        
        label_35:
        label_34:
        this.potentialReward.丈丗丟丛丕上三世丙(丄下丘丘丗丙丙丕丞:  this.<七丏丅丝丄丛丛丅丐>k__BackingField.丕丈一丐丛世丆上万);
        this.potentialReward.gameObject.SetActive(value:  true);
        this.potentialReward.Resize();
        Rilisoft.一丟专且三万丞丁丂.丂丙丛丗丂丟丞丞丕();
        return;
        label_27:
        if(this.potentialReward != null)
        {
            goto label_34;
        }
        
        goto label_35;
    }
    internal void 专世七丟丄专丁与且()
    {
        this.potentialReward.gameObject.SetActive(value:  false);
        UnityEngine.Vector3 val_3 = this.mainReward.transform.localPosition;
        this.mainReward.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal void 丂丏丒丁丙世东丏丝()
    {
        if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                if(GameConnect.一与东丝万上三丆丏() == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector3 val_4 = this.positionOneRewardPanel.localPosition;
        this.mainReward.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    internal void 万丑丆丌丗不三下丞()
    {
        UnityEngine.Vector3 val_2 = this.initialRewardPanelPosition.localPosition;
        this.mainReward.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    internal 丟与丁丑丗下丐丛一 丈丕丗业丁上丒上丘()
    {
        System.Collections.Generic.HashSet<丞丅与与丈丕丟丑丘> val_27;
        var val_28;
        var val_29;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_31;
        var val_32;
        var val_33;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_35;
        var val_36;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_38;
        var val_39;
        int val_40;
        int val_41;
        int val_42;
        int val_43;
        int val_44;
        int val_45;
        int val_46;
        int val_47;
        Rilisoft.OfferItem val_48;
        PGCompany.丗丟丄丈东丝丕丄世 val_49;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_51;
        var val_52;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_54;
        var val_55;
        int val_56;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_58;
        var val_59;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_61;
        var val_62;
        var val_63;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_65;
        var val_66;
        int val_67;
        Rilisoft.OfferItem val_68;
        int val_69;
        var val_70;
        丟与丁丑丗下丐丛一 val_0;
        val_27 = this.上业丟世三与七七三;
        if(val_27 == null)
        {
            goto label_1;
        }
        
        val_28 = 1152921505253277696;
        val_29 = null;
        val_29 = null;
        val_31 = RewardWindowController.<>c.<>9__189_0;
        if(val_31 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_1 = null;
            val_31 = val_1;
            val_1 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丑丕世丟丟丁丒丆丗(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__189_0 = val_31;
        }
        
        val_32 = 1152921538856620544;
        val_33 = null;
        val_33 = null;
        val_35 = RewardWindowController.<>c.<>9__189_1;
        if(val_35 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_3 = null;
            val_35 = val_3;
            val_3 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丂上下专丕万丏专丌(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__189_1 = val_35;
        }
        
        val_36 = null;
        val_36 = null;
        val_38 = RewardWindowController.<>c.<>9__189_2;
        if(val_38 != null)
        {
            goto label_14;
        }
        
        val_39 = val_32;
        goto label_18;
        label_1:
        val_40 = 0;
        val_41 = 0;
        val_42 = 0;
        val_43 = 0;
        val_44 = 0;
        val_45 = 0;
        val_46 = 0;
        val_47 = 0;
        val_48 = 0;
        val_49 = 0;
        goto label_17;
        label_18:
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_5 = null;
        val_38 = val_5;
        val_5 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::且下丁丒丏丛丗七丁(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
        val_32 = ;
        RewardWindowController.<>c.<>9__189_2 = val_38;
        label_14:
        val_51 = RewardWindowController.<>c.<>9__189_3;
        if(val_51 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_7 = null;
            val_51 = val_7;
            val_7 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::业不丄丕丙丌丈丘丆(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__189_3 = val_51;
        }
        
        val_52 = null;
        val_52 = null;
        val_54 = RewardWindowController.<>c.<>9__189_4;
        if(val_54 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_9 = null;
            val_54 = val_9;
            val_9 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::与丅丒丆丄丘下业丟(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__189_4 = val_54;
        }
        
        val_55 = null;
        val_56 = this.<丒一七东东丐丁丟万>k__BackingField;
        val_55 = null;
        val_58 = RewardWindowController.<>c.<>9__189_5;
        if(val_58 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_11 = null;
            val_58 = val_11;
            val_11 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丗丈丛丟专丗丘丑一(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__189_5 = val_58;
        }
        
        val_59 = null;
        val_59 = null;
        val_61 = RewardWindowController.<>c.<>9__189_6;
        if(val_61 == null)
        {
                val_62 = val_56;
            System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_13 = null;
            val_61 = val_13;
            val_28 = val_28;
            val_13 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丒丈丝三万世丘与丘(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            val_56 = ;
            RewardWindowController.<>c.<>9__189_6 = val_61;
        }
        
        val_63 = null;
        val_65 = RewardWindowController.<>c.<>9__189_7;
        if(val_65 == null)
        {
                val_66 = val_56;
            System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_15 = null;
            val_65 = val_15;
            val_15 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丂与丟东丑世丅不丗(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            val_56 = ;
            RewardWindowController.<>c.<>9__189_7 = val_65;
        }
        
        val_67 = this.<世丂丕丙上丑东丘丘>k__BackingField;
        val_68 = this.<丑丆丐丏万丆丌丈丙>k__BackingField;
        val_69 = this.<丆丌不丙上丁不丌三>k__BackingField;
        if(val_68 != null)
        {
                val_48 = val_68.Clone();
            if(val_48 != null)
        {
                val_48 = 0;
        }
        
            val_70 = this.<七丂丒丞丝丛七万上>k__BackingField;
            val_67 = val_67;
            val_69 = val_69;
        }
        else
        {
                val_70 = this.<七丂丒丞丝丛七万上>k__BackingField;
            val_48 = 0;
        }
        
        val_27 = val_69 + (val_67 * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_15)));
        val_40 = (this.<丒丙丅下七丟丆丒丝>k__BackingField) + ((this.<丁丐丑世丝丏世丈丗>k__BackingField) * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  val_27, seed:  1, func:  val_1)));
        val_41 = (this.<上世丅不丌丝丄上业>k__BackingField) + ((this.<丛丛丁七三与丛上一>k__BackingField) * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_3)));
        val_43 = (this.<丟丏七且丝东丗丞三>k__BackingField) + ((this.<丂三业丒且丝七丁丝>k__BackingField) * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_5)));
        val_44 = (this.<丗丈丄丄一丘丆丈丞>k__BackingField) + ((this.<丈东丞丄丈专丄丁丆>k__BackingField) * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_7)));
        val_45 = (this.<不丘丟不丗业与丞一>k__BackingField) + (val_56 * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_9)));
        val_46 = (this.<且丕丛丟丅世专丄丐>k__BackingField) + (val_70 * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_11)));
        val_47 = (this.<丛丁丅下不专丕丏丏>k__BackingField) + ((this.<业业丆下丅丆丝丑下>k__BackingField) * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_13)));
        if((this.<且业业丑丞丙三不丒>k__BackingField) == null)
        {
            goto label_52;
        }
        
        val_49 = this.<且业业丑丞丙三不丒>k__BackingField.丈丄丈丛世丈专与丘;
        if(val_49 == null)
        {
            goto label_54;
        }
        
        string val_20 = val_49.业上丙丞丐丄丆丅七();
        goto label_54;
        label_52:
        val_49 = 0;
        label_54:
        val_42 = this.<三丞专丕世万丟上七>k__BackingField;
        label_17:
        val_0.丈丆且与丘丑丌东上 = val_40;
        val_0.丕丁丙与丙丝丞上丄 = val_41;
        val_0.丐世丑丈丟丏专专丝 = val_42;
        val_0.东丝业丅丏丟七丗且 = val_43;
        val_0.丕丟专业下丐丄丗丅 = val_44;
        val_0.三丈丒丙东世丘世丘 = val_27;
        val_0.丌且丕丄丞丗丄与丂 = val_45;
        val_0.东丑丑世丈业下丟专 = val_46;
        val_0.丙丄一专丌丙丂丛丐 = val_47;
        mem[1152921538857540228] = 0;
        val_0.下丅丙一丂丗丅丝七 = val_48;
        val_0.上丁丗丐丝丛丝世丂 = val_49;
        return val_0;
    }
    private System.Collections.Generic.Dictionary<string, object> 一业丟东下丏世专丘()
    {
        var val_5;
        var val_6;
        Rilisoft.七丕丟丏三丈一丄世 val_7;
        var val_8;
        丁丁丒丆不丒下丟三 val_9;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_5 = null;
        val_5 = null;
        世丁与丕丗丟丒丆上 val_2 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_2 == null)
        {
            goto label_6;
        }
        
        string val_3 = val_2.东丙上东业丆不丟丘();
        if(val_3 == null)
        {
            goto label_6;
        }
        
        label_16:
        val_1.set_Item(key:  Progress.丛丝丕丟下三上丏下.一丌业三七丝丁丆丁, value:  val_3);
        val_6 = null;
        val_6 = null;
        val_1.set_Item(key:  Progress.丛丝丕丟下三上丏下.七丒丘专丆丏丝专东, value:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
        if((this.<七丏丅丝丄丛丛丅丐>k__BackingField) == null)
        {
            goto label_13;
        }
        
        val_7 = this.<七丏丅丝丄丛丛丅丐>k__BackingField.丂丛丑东不丅丈一东;
        goto label_14;
        label_6:
        if(val_1 != null)
        {
            goto label_16;
        }
        
        goto label_16;
        label_13:
        val_7 = 100;
        label_14:
        val_1.set_Item(key:  Progress.丛丝丕丟下三上丏下.专且丄业业世丟上不, value:  100);
        val_8 = null;
        val_8 = null;
        val_9 = this.<七丏丅丝丄丛丛丅丐>k__BackingField;
        if(val_9 != null)
        {
                val_9 = this.<七丏丅丝丄丛丛丅丐>k__BackingField.且七丙丁与丌丗与上;
        }
        
        val_1.set_Item(key:  Progress.丛丝丕丟下三上丏下.世丏七三丘丁丙东三, value:  val_9);
        return val_1;
    }
    internal void 不丘丂丐丙丂丟且丁(System.Action 丕下一七东丁丌丂专)
    {
        var val_87;
        System.Action val_88;
        var val_90;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_92;
        int val_93;
        int val_94;
        var val_95;
        var val_96;
        var val_97;
        var val_98;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_100;
        var val_101;
        var val_105;
        var val_106;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_108;
        var val_109;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_111;
        var val_112;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_114;
        PGCompany.三东丏不丗世丅丌丄 val_115;
        Rilisoft.OfferItem val_116;
        Rilisoft.OfferItem val_117;
        var val_118;
        var val_119;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_120;
        Rilisoft.七丕丟丏三丈一丄世 val_121;
        val_88 = 丕下一七东丁丌丂专;
        if(this.丞三与上东丅丑丁业 == true)
        {
                return;
        }
        
        Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
        int val_2 = ExperienceController.丞丞丘业东丙丏七丌();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  140);
        val_90 = null;
        val_90 = null;
        val_92 = RewardWindowController.<>c.<>9__191_0;
        if(val_92 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_4 = null;
            val_92 = val_4;
            val_4 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丌丌丄丕丛丏上不丌(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__191_0 = val_92;
        }
        
        val_93 = this.<丁丐丑世丝丏世丈丗>k__BackingField;
        val_94 = this.<丒丙丅下七丟丆丒丝>k__BackingField;
        var val_7 = (ExperienceController.丞丞丘业东丙丏七丌() != 65) ? System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_4) : (0 + 1);
        if((val_94 + (val_7 * val_93)) >= 1)
        {
                val_95 = null;
            val_95 = null;
            val_93 = this.<丁丐丑世丝丏世丈丗>k__BackingField;
            val_94 = this.<丒丙丅下七丟丆丒丝>k__BackingField;
            ExperienceController.sharedController.丗丒丂丕丟东丟丙不(业不七丗东丛下一东:  val_94 + (val_93 * val_7), 世丁丙世丄一万丆三:  4, 与丌丛丈丕丁丅丄丗:  this.一业丟东下丏世专丘());
            val_96 = null;
            val_96 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_97 = null;
            val_97 = null;
            业业丏丛不丟丆丐东();
        }
        
        }
        
        val_98 = null;
        val_98 = null;
        val_100 = RewardWindowController.<>c.<>9__191_1;
        if(val_100 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_12 = null;
            val_100 = val_12;
            val_12 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::专七世万业丙一丟丘(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__191_1 = val_100;
        }
        
        int val_13 = System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_12);
        int val_14 = (this.<上世丅不丌丝丄上业>k__BackingField) + ((this.<丛丛丁七三与丛上一>k__BackingField) * val_13);
        if(val_14 >= 1)
        {
                PGCompany.丗丟丄丈东丝丕丄世 val_17 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  247, 丂丕丂丏专丂丄丕且:  val_14), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丟丂且丈且丂世三丕() != false)
        {
                bool val_24 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().世丛丑专三丗丆丈丙(且丕且丗丆丘丄丙一:  PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丄丄世丁丒丑丁东世(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()));
        }
        
        val_101 = null;
        val_101 = null;
        if((GameController.丆丘丂丈世丏丟丑丏.丁七丗专业世丈丒下 != true) && (PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丝丞丙丂与上且丙丛() != false))
        {
                PGCompany.七下丐丂丙丑东专丂 val_29 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(((val_29 != null) && (val_29.丂丁丏一丙丛业且丌() >= 1)) && (val_29.且业上丞丄丁专不丙() != null))
        {
                if(val_29.且业上丞丄丁专不丙().Count != 0)
        {
                System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_34 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_34.Add(item:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207).丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  1));
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_39 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙世丕丒世丞丌丆下(丞上下丞丘业业上丘:  val_34, 丌丞不丌丐三七丌丕:  val_29.且业上丞丄丁专不丙(), 东丆下丌业上丙下七:  new PGCompany.世世丘丝丞业三世一() {丁丞丌与丘丝丕丈丂 = 327, 且丝丕丆不丅丏丛东 = new PGCompany.丛丈下且丐丝不东丈() {丁丞丌与丘丝丕丈丂 = 163208757248, 丐上丐丂丆上世丝丆 = 77309411328, 不丐丅丁丂七丐丘丛 = 1, 丐丒上丘丙丕且丕七 = 2, 上丂丑丄丈七丆丁下 = this.<七丏丅丝丄丛丛丅丐>k__BackingField, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false}, 丁东丑丏丐丏丄一丒 = new PGCompany.丆丈丘东丆丕三丞东()});
        }
        
        }
        
        }
        
        if((this.<三丞专丕世万丟上七>k__BackingField) >= 1)
        {
                PGCompany.丗丟丄丈东丝丕丄世 val_42 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  223, 丂丕丂丏专丂丄丕且:  this.<三丞专丕世万丟上七>k__BackingField), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        this.七不业丈丕丂丏丏丈(丝一三下丕且丅丟世:  new PGCompany.丛丈下且丐丝不东丈() {丁丞丌与丘丝丕丈丂 = 163208757248, 丐上丐丂丆上世丝丆 = 77309411328, 不丐丅丁丂七丐丘丛 = 1, 丐丒上丘丙丕且丕七 = 2, 上丂丑丄丈七丆丁下 = this.<七丏丅丝丄丛丛丅丐>k__BackingField, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false});
        this.丞东丑丑下丆丄万丟(丝一三下丕且丅丟世:  new PGCompany.丛丈下且丐丝不东丈() {丁丞丌与丘丝丕丈丂 = 163208757248, 丐上丐丂丆上世丝丆 = 77309411328, 不丐丅丁丂七丐丘丛 = 1, 丐丒上丘丙丕且丕七 = 2, 上丂丑丄丈七丆丁下 = this.<七丏丅丝丄丛丛丅丐>k__BackingField, 丁丁丒丆不丒下丟三 = 163208757248, <丟丟丂东世下丗不丝>k__BackingField = true, <丄东丗世丁丁世丆丏>k__BackingField = 1, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false});
        val_105 = null;
        System.Collections.Generic.HashSet<丞丅与与丈丕丟丑丘> val_85 = this.上业丟世三与七七三;
        val_106 = 1152921538856620544;
        val_108 = RewardWindowController.<>c.<>9__191_2;
        if(val_108 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_43 = null;
            val_108 = val_43;
            val_43 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丛丞不丘丘丝与业一(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__191_2 = val_108;
        }
        
        val_85 = (this.<不丘丟不丗业与丞一>k__BackingField) + ((this.<丒一七东东丐丁丟万>k__BackingField) * (System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  val_85, seed:  1, func:  val_43)));
        if(val_85 >= 1)
        {
                bool val_45 = BankController.东一且丝万一丆七丘(丌丒丝东丌下丕丁丅:  val_85, 三上丆世丞丏丁一上:  20, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0);
        }
        
        val_109 = null;
        val_109 = null;
        val_111 = RewardWindowController.<>c.<>9__191_3;
        if(val_111 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_46 = null;
            val_111 = val_46;
            val_46 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::且七七丏上丒丒丌丈(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__191_3 = val_111;
        }
        
        int val_47 = System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_46);
        int val_86 = this.<七丂丒丞丝丛七万上>k__BackingField;
        val_86 = (this.<且丕丛丟丅世专丄丐>k__BackingField) + (val_86 * val_47);
        if(val_86 >= 1)
        {
                PGCompany.三东丏不丗世丅丌丄 val_48 = new PGCompany.三东丏不丗世丅丌丄(丆专且丕专丗与一丏:  159);
            val_48.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  (this.<且丕丛丟丅世专丄丐>k__BackingField) + ((this.<七丂丒丞丝丛七万上>k__BackingField) * val_47));
            PGCompany.丗丟丄丈东丝丕丄世 val_51 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_48, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        val_112 = null;
        val_112 = null;
        val_114 = RewardWindowController.<>c.<>9__191_4;
        if(val_114 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_52 = null;
            val_114 = val_52;
            val_52 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::且丙与七丞丌丆丂专(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__191_4 = val_114;
        }
        
        val_115 = 1;
        int val_53 = System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_52);
        int val_87 = this.<业业丆下丅丆丝丑下>k__BackingField;
        val_87 = (this.<丛丁丅下不专丕丏丏>k__BackingField) + (val_87 * val_53);
        if(val_87 >= 1)
        {
                PGCompany.三东丏不丗世丅丌丄 val_54 = new PGCompany.三东丏不丗世丅丌丄(丆专且丕专丗与一丏:  183);
            val_54.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  (this.<丛丁丅下不专丕丏丏>k__BackingField) + ((this.<业业丆下丅丆丝丑下>k__BackingField) * val_53));
            val_115 = val_54;
            PGCompany.丗丟丄丈东丝丕丄世 val_57 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_54, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        val_87 = this;
        if((this.<丑丆丐丏万丆丌丈丙>k__BackingField) != null)
        {
                if((this.<丑丆丐丏万丆丌丈丙>k__BackingField.Clone()) != null)
        {
                val_116 = 0;
        }
        
            丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_116, 不丌丟专丙丈丟丘专:  new PGCompany.丛丈下且丐丝不东丈() {丁丞丌与丘丝丕丈丂 = 163208757248, 丐上丐丂丆上世丝丆 = 77309411328, 不丐丅丁丂七丐丘丛 = 1, 丐丒上丘丙丕且丕七 = 2, 上丂丑丄丈七丆丁下 = this.<七丏丅丝丄丛丛丅丐>k__BackingField, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false}, 丁七丐丁丙丄丙不东:  true, 丁且丟不七下丆丒丟:  false, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  true, 丏丏七丘丈丌上且专:  true);
            this.丆丙丆丏丄丄上丂丘();
        }
        
        if((this.<丕世七丅丙丅丟七专>k__BackingField) != null)
        {
                if((this.<丕世七丅丙丅丟七专>k__BackingField.Clone()) != null)
        {
                val_117 = 0;
        }
        
            丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_117, 不丌丟专丙丈丟丘专:  new PGCompany.丛丈下且丐丝不东丈() {丁丞丌与丘丝丕丈丂 = 163208757248, 丐上丐丂丆上世丝丆 = 77309411328, 不丐丅丁丂七丐丘丛 = 1, 丐丒上丘丙丕且丕七 = 2, 上丂丑丄丈七丆丁下 = this.<七丏丅丝丄丛丛丅丐>k__BackingField, <丟丟丂东世下丗不丝>k__BackingField = false, <丑丐丏丏一丛丌专丐>k__BackingField = 163208757248, <且丄丞一下丕丂东丕>k__BackingField = true, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false}, 丁七丐丁丙丄丙不东:  true, 丁且丟不七下丆丒丟:  false, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  true, 丏丏七丘丈丌上且专:  true);
        }
        
        if((((this.<下丈一丈丗丐上丅丛>k__BackingField) != null) && ((this.<下丈一丈丗丐上丅丛>k__BackingField.丈丄丈丛世丈专与丘) != null)) && (null == null))
        {
                val_88 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.三东丏不丗世丅丌丄 val_65 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  this.<下丈一丈丗丐上丅丛>k__BackingField.丈丄丈丛世丈专与丘.不业丙丒丂丞下丆丙(), 丞丅上丏丂且下丅与:  this.<下丈一丈丗丐上丅丛>k__BackingField.丈丄丈丛世丈专与丘.业上丙丞丐丄丆丅七());
            val_65.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  1);
            val_115 = val_65;
            PGCompany.丗丟丄丈东丝丕丄世 val_66 = val_88.丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_65, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        int val_88 = this.<丛丛丁七三与丛上一>k__BackingField;
        Rilisoft.七丕丟丏三丈一丄世 val_67 = GameConnect.丑丌丛丈丅丅与不业();
        System.Nullable<System.DateTime> val_68 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(((-108421072) & 1) == 0)
        {
            goto label_117;
        }
        
        val_88 = 1152921505442680832;
        val_88 = (this.<上世丅不丌丝丄上业>k__BackingField) + (val_88 * val_13);
        val_118 = Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世();
        if((val_88 < 1) || ((val_118.东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  val_67)) == false))
        {
            goto label_117;
        }
        
        val_119 = null;
        val_119 = null;
        val_120 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_120 == null)
        {
            goto label_112;
        }
        
        val_120 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_120 == null)
        {
                val_120 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_71 = val_120.丌不丅不丞东万专专();
        val_118 = val_71.HasValue.丙东专丂世丈丏丁丂();
        if((val_118 != 3) || (((-108421184) & 1) == 0))
        {
            goto label_117;
        }
        
        label_112:
        if((val_67 & 4294967294) == 4)
        {
                Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丄丈丅丄七业丁上丐(上且丗一丏丏万丅丌:  4, 不丗万丘丆丗上丗丏:  new System.Nullable<System.DateTime>() {HasValue = val_68.HasValue});
            Rilisoft.一丟专且三万丞丁丂.丂丅丈丙下丟丆业丄(上且丗一丏丏万丅丌:  4);
            val_88 = Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世();
            val_88.丄丈丅丄七业丁上丐(上且丗一丏丏万丅丌:  5, 不丗万丘丆丗上丗丏:  new System.Nullable<System.DateTime>() {HasValue = val_68.HasValue});
            val_121 = 5;
        }
        else
        {
                val_88 = val_115;
            Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丄丈丅丄七业丁上丐(上且丗一丏丏万丅丌:  val_67, 不丗万丘丆丗上丗丏:  new System.Nullable<System.DateTime>() {HasValue = val_68.HasValue});
            val_121 = GameConnect.丑丌丛丈丅丅与不业();
        }
        
        Rilisoft.一丟专且三万丞丁丂.丂丅丈丙下丟丆业丄(上且丗一丏丏万丅丌:  val_121);
        label_117:
        丟与丁丑丗下丐丛一 val_78 = this.丈丕丗业丁上丒上丘();
        PGCompany.Analytics.一业丗丆世世上丁且.丝丟且丟三丘丟丛丗(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丙七七丈丐且一丟业: ref  new System.Nullable<丟与丁丑丗下丐丛一>() {HasValue = false});
        this.<丞丁丂丁丒丆丕业丙>k__BackingField = 0;
        this.<三丞专丕世万丟上七>k__BackingField = 0;
        this.<丛丛丁七三与丛上一>k__BackingField = 0;
        this.<丁丐丑世丝丏世丈丗>k__BackingField = 0;
        mem[1152921538858176608] = 0;
        mem[1152921538858176616] = 0;
        this.<下丈一丈丗丐上丅丛>k__BackingField = 0;
        this.<丑丆丐丏万丆丌丈丙>k__BackingField = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        this.<丛上且丐七丁三万专>k__BackingField = 0;
        if(RewardWindowController.与丟万丟丏丆业丒且 != null)
        {
                RewardWindowController.与丟万丟丏丆业丒且.Invoke();
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        if(val_88 == 0)
        {
                return;
        }
        
        val_88.Invoke();
    }
    private void 七不业丈丕丂丏丏丈(PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
    {
        int val_7;
        var val_8;
        var val_9;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_11;
        int val_12;
        val_8 = 1152921538858645184;
        if(PGCompany.丁东丌世与丕东丆上.三丘世东一丌上一与() == false)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_11 = RewardWindowController.<>c.<>9__192_0;
        if(val_11 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_2 = null;
            val_11 = val_2;
            val_2 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::与丝丛丟下丅万专丁(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__192_0 = val_11;
        }
        
        int val_3 = System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  this.上业丟世三与七七三, seed:  1, func:  val_2);
        val_7 = (this.<丟丏七且丝东丗丞三>k__BackingField) + ((this.<丂三业丒且丝七丁丝>k__BackingField) * val_3);
        if(val_7 < 1)
        {
                return;
        }
        
        bool val_4 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  val_7, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  0);
        val_12 = this.<丂三业丒且丝七丁丝>k__BackingField;
        Rilisoft.一丟专且三万丞丁丂.上丆丞万专与丛丕丈(且丘丞丕丐丗丅丅丂:  (this.<丟丏七且丝东丗丞三>k__BackingField) + (val_12 * val_3));
        PGCompany.三东丏不丗世丅丌丄 val_6 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  127, 丂丕丂丏专丂丄丕且:  val_7);
        val_8 = public System.Void System.Nullable<PGCompany.丛丈下且丐丝不东丈>::.ctor(PGCompany.丛丈下且丐丝不东丈 value);
        PGCompany.世东三上七丂丌下丑.东丐丗三丛丟三丁七(丅一丘丙上东丏丅不:  new 丕丝丝丝丅丕专丅丝() {且丝丕丆不丅丏丛东 = new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = false}});
    }
    private void 丞东丑丑下丆丄万丟(PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
    {
        var val_9;
        var val_10;
        System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_12;
        int val_13;
        val_9 = 1152921538858885312;
        System.Collections.Generic.HashSet<丞丅与与丈丕丟丑丘> val_9 = this.上业丟世三与七七三;
        val_10 = null;
        val_10 = null;
        val_12 = RewardWindowController.<>c.<>9__193_0;
        if(val_12 == null)
        {
                System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32> val_1 = null;
            val_12 = val_1;
            val_1 = new System.Func<System.Int32, 丞丅与与丈丕丟丑丘, System.Int32>(object:  RewardWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RewardWindowController.<>c::丞且丞丄丑丞丆丑丕(int 东且丁丆丛丁丏丘且, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三));
            RewardWindowController.<>c.<>9__193_0 = val_12;
        }
        
        int val_2 = System.Linq.Enumerable.Aggregate<丞丅与与丈丕丟丑丘, System.Int32>(source:  val_9, seed:  1, func:  val_1);
        val_9 = (this.<丗丈丄丄一丘丆丈丞>k__BackingField) + ((this.<丈东丞丄丈专丄丁丆>k__BackingField) * val_2);
        if(val_9 < 1)
        {
                return;
        }
        
        val_13 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
        Rilisoft.丛且世丐丆上七业丁 val_4 = val_13.不上丁丏且丙丞三丅();
        if(val_4 == null)
        {
                return;
        }
        
        bool val_6 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  val_9, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  val_4.业上丙丞丐丄丆丅七());
        val_13 = this.<丈东丞丄丈专丄丁丆>k__BackingField;
        Rilisoft.一丟专且三万丞丁丂.上丆丞万专与丛丕丈(且丘丞丕丐丗丅丅丂:  (this.<丗丈丄丄一丘丆丈丞>k__BackingField) + (val_13 * val_2));
        PGCompany.三东丏不丗世丅丌丄 val_8 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  127, 丂丕丂丏专丂丄丕且:  val_9);
        val_9 = public System.Void System.Nullable<PGCompany.丛丈下且丐丝不东丈>::.ctor(PGCompany.丛丈下且丐丝不东丈 value);
        PGCompany.世东三上七丂丌下丑.东丐丗三丛丟三丁七(丅一丘丙上东丏丅不:  new 丕丝丝丝丅丕专丅丝() {且丝丕丆不丅丏丛东 = new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = false}});
    }
    internal System.Collections.IEnumerator 丙丝丒专一丌丑且丐(System.Action 丗丗世丘丙不世丁丅)
    {
        RewardWindowController.丂丒与丕业丂上上丝 val_1 = new RewardWindowController.丂丒与丕业丂上上丝();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丗丗世丘丙不世丁丅 = 丗丗世丘丙不世丁丅;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 下世丘丛丝丅丟专丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RewardWindowController.丑丁丘东丅丙丝丁三();
    }
    private void 丁万业且丏丈万丂且()
    {
        int val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  135);
        if(val_2 < 1)
        {
                return;
        }
        
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
                return;
        }
        
        Rilisoft.GameEventOpenChestBase.下与丞三丅丛丄七丕(七万上丐一丈丏丏专:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.BannersHolder, 丐东业丕丕丂丗丅丙:  val_2, 世丁丌万丏丟丗世三:  74, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    private void 丆丙丆丏丄丄上丂丘()
    {
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_10;
        val_8 = 1152921505066536960;
        val_9 = null;
        val_9 = null;
        val_10 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_10 == null)
        {
            goto label_3;
        }
        
        val_10 = GameConnect.丈丝丂丐丟万丙丑丕;
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = val_10.丌不丅不丞东万专专();
        if(val_1.HasValue.丙东专丂世丈丏丁丂() != 1)
        {
                return;
        }
        
        if(((-107177240) & 1) == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<System.Int32> val_4 = null;
        val_8 = val_4;
        val_4 = new System.Collections.Generic.List<System.Int32>();
        val_10 = val_10.业上丙丞丐丄丆丅七();
        val_4.Add(item:  val_10);
        if(Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙() != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_3:
        if((this.<丛上且丐七丁三万专>k__BackingField) == 1)
        {
                return;
        }
        
        val_10 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        System.Collections.Generic.List<System.Int32> val_7 = null;
        val_8 = val_7;
        val_7 = new System.Collections.Generic.List<System.Int32>();
        val_7.Add(item:  this.<丛上且丐七丁三万专>k__BackingField);
        label_14:
        val_10.万业专不下丅三上专(丒丐业丐丌东丑不丌:  val_7);
    }
    private void 且下丏丄一业万丟丗()
    {
        RewardWindowView val_15;
        if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_6;
        }
        
        }
        
        val_15 = this;
        UnityEngine.Vector3 val_4 = this.positionOneRewardPanel.localPosition;
        this.mainReward.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        goto label_10;
        label_6:
        val_15 = this.mainReward;
        label_10:
        UnityEngine.Vector3 val_6 = mem[this.mainReward].transform.localPosition;
        UIWidget val_7 = mem[this.mainReward] + 232.GetComponent<UIWidget>();
        float val_15 = (float)val_7.width;
        val_15 = val_15 * 0.5f;
        val_15 = val_15 + 10f;
        val_15 = val_6.x - val_15;
        mem[this.mainReward].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  (float)val_7.width + 10);
        this.potentialReward.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
    public 丏与丌丐东七丈丑丕 GetEnumerator()
    {
        return (丏与丌丐东七丈丑丕)new 丏与丌丐东七丈丑丕(上业丟世三与七七三:  this.三丘丘丘丒丒且丂业());
    }
    public RewardWindowController()
    {
        this._sortingOrder = new System.Collections.Generic.List<丁丙丆丑不三丌丗丟>();
        this.上业丟世三与七七三 = new System.Collections.Generic.HashSet<丞丅与与丈丕丟丑丘>();
        this._startOpenChestByAlphaValue = 0.1f;
    }
    private int 丒丕丄丛丆专丄专专(丞丅与与丈丕丟丑丘 丈丂丕下丏丈丞丗业, 丞丅与与丈丕丟丑丘 丂丌丌丛丆丆丙丌丈)
    {
        var val_6;
        if(((this._sortingOrder.IndexOf(item:  丂丌丌丛丆丆丙丌丈.丌东业与丞丐丂丝专())) & (this._sortingOrder.IndexOf(item:  丈丂丕下丏丈丞丗业.丌东业与丞丐丂丝专()))) != 1)
        {
                return (int)val_6;
        }
        
        val_6 = 0;
        return (int)val_6;
    }

}
