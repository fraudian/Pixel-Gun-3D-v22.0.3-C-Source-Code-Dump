using UnityEngine;
internal abstract class AbstractBankView : MonoBehaviour
{
    // Fields
    internal static int[] 丙不丌丁丆丕丒上丏;
    internal static int[] 专丄丒万丘专丏丐万;
    private UILabel 丞不三丟万丑万丑丄;
    private float 丌与丞丘且丏丈丞丆;
    private StoreKitEventListener 丕业丐业且丐万东丏;
    public UnityEngine.GameObject[] AdFreeLabels;
    public UILabel amazonEventCaptionLabel;
    public UILabel amazonEventTitleLabel;
    public UnityEngine.GameObject bankVipDescription;
    public UnityEngine.GameObject bankX3Description;
    public TweenColor colorBlinkForX3;
    public UIWidget eventX3AmazonBonusWidget;
    public UIButton freeAwardButton;
    public UnityEngine.GameObject gemsTabExclamation;
    public UnityEngine.GameObject coinsTabExclamation;
    private UILabel getNTimesMore;
    public UnityEngine.GameObject touchBlockObject;
    public UnityEngine.GameObject[] usualBankElements;
    public UnityEngine.GameObject[] x3BankElements;
    private AbstractBankViewItem <丟三且丘世上丅丅丒>k__BackingField;
    private string <丏专丝世专丘东丛不>k__BackingField;
    private string <丐丛丄丟丟东专丄丝>k__BackingField;
    private System.Action<AbstractBankViewItem> 丑业下丂丘丛丟一丅;
    private System.Action<AbstractBankViewItem> 丕丒与业丟丞丑丟丏;
    public Rilisoft.ButtonHandler backButton;
    public UILabel connectionProblemLabel;
    public UILabel crackersWarningLabel;
    private UILabel _notEnoughCurrencyLabel;
    private System.Collections.Generic.Dictionary<string, string> 丁丏专丁丅丈与世与;
    public UISprite purchaseSuccessfulLabel;
    public UILabel[] eventX3RemainTime;
    
    // Properties
    public AbstractBankViewItem 丒与丁丒万丛丘不丞 { get; set; }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 与丑丒丈丂丌上丙东 { get; }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 丅丛且丂丌丝丈丕业 { get; }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 丏丙万丄与丏万丏丏 { get; }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 东丝丞丝丞丅业丆丞 { get; }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 世世丘下丕业丒丕丂 { get; }
    public string 丌世世且七东丙丈丗 { get; set; }
    public string 三七丒丑业丟丄丑丂 { get; set; }
    public bool 丁丁三丞丕丅丗且丗 { get; set; }
    public bool 业丝三与业一丛丘三 { get; set; }
    public bool 业下丞丅丟一不万丅 { get; set; }
    public abstract bool 世丌且丟丗丆三与不 { get; set; }
    private UILabel 丌丑七丂下丑丁丑上 { get; }
    
    // Methods
    public AbstractBankViewItem get_LastClickedItem()
    {
        return (AbstractBankViewItem)this.<丟三且丘世上丅丅丒>k__BackingField;
    }
    protected void 丈丏丘七丂且丌三且(AbstractBankViewItem 丙业与丙丗丝不丈东)
    {
        this.<丟三且丘世上丅丅丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 万丏丝与专下丂丐丏()
    {
        var val_9;
        var val_10;
        System.Collections.Generic.List<丘丝丑丐丆丑七不丙> val_1 = new System.Collections.Generic.List<丘丝丑丐丆丑七不丙>();
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = null;
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  0, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  0, 三丒万万丗世三丆丄:  AbstractBankView.丙不丌丁丆丕丒上丏 + 32));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  1, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  0, 三丒万万丗世三丆丄:  AbstractBankView.丙不丌丁丆丕丒上丏 + 36));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  2, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  0, 三丒万万丗世三丆丄:  AbstractBankView.丙不丌丁丆丕丒上丏 + 40));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  3, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  0, 三丒万万丗世三丆丄:  AbstractBankView.丙不丌丁丆丕丒上丏 + 44));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  4, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  0, 三丒万万丗世三丆丄:  AbstractBankView.丙不丌丁丆丕丒上丏 + 48));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  5, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  0, 三丒万万丗世三丆丄:  AbstractBankView.丙不丌丁丆丕丒上丏 + 52));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  6, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  0, 三丒万万丗世三丆丄:  AbstractBankView.丙不丌丁丆丕丒上丏 + 56));
        return (System.Collections.Generic.IList<丘丝丑丐丆丑七不丙>)val_1;
    }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 丘丅丕丂丗丞上一丐()
    {
        var val_9;
        var val_10;
        System.Collections.Generic.List<丘丝丑丐丆丑七不丙> val_1 = new System.Collections.Generic.List<丘丝丑丐丆丑七不丙>();
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = null;
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  0, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  1, 三丒万万丗世三丆丄:  AbstractBankView.专丄丒万丘专丏丐万 + 32));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  1, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  1, 三丒万万丗世三丆丄:  AbstractBankView.专丄丒万丘专丏丐万 + 36));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  2, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  1, 三丒万万丗世三丆丄:  AbstractBankView.专丄丒万丘专丏丐万 + 40));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  3, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  1, 三丒万万丗世三丆丄:  AbstractBankView.专丄丒万丘专丏丐万 + 44));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  4, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  1, 三丒万万丗世三丆丄:  AbstractBankView.专丄丒万丘专丏丐万 + 48));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  5, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  1, 三丒万万丗世三丆丄:  AbstractBankView.专丄丒万丘专丏丐万 + 52));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  6, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  1, 三丒万万丗世三丆丄:  AbstractBankView.专丄丒万丘专丏丐万 + 56));
        return (System.Collections.Generic.IList<丘丝丑丐丆丑七不丙>)val_1;
    }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 丌一业与七丘丒东丕()
    {
        var val_9;
        System.Collections.Generic.List<丘丝丑丐丆丑七不丙> val_1 = new System.Collections.Generic.List<丘丝丑丐丆丑七不丙>();
        val_9 = null;
        val_9 = null;
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  0, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  4, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  1, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  4, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  2, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  4, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  3, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  4, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  4, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  4, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  5, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  4, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  6, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  4, 三丒万万丗世三丆丄:  0));
        return (System.Collections.Generic.IList<丘丝丑丐丆丑七不丙>)val_1;
    }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 丒丁丞丝世三与七东()
    {
        var val_9;
        System.Collections.Generic.List<丘丝丑丐丆丑七不丙> val_1 = new System.Collections.Generic.List<丘丝丑丐丆丑七不丙>();
        val_9 = null;
        val_9 = null;
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  0, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  2, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  1, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  2, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  2, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  2, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  3, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  2, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  4, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  2, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  5, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  2, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  6, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  2, 三丒万万丗世三丆丄:  0));
        return (System.Collections.Generic.IList<丘丝丑丐丆丑七不丙>)val_1;
    }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 上丐七丕丘丏且三业()
    {
        var val_9;
        System.Collections.Generic.List<丘丝丑丐丆丑七不丙> val_1 = new System.Collections.Generic.List<丘丝丑丐丆丑七不丙>();
        val_9 = null;
        val_9 = null;
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  0, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  5, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  1, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  5, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  2, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  5, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  3, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  5, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  4, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  5, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  5, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  5, 三丒万万丗世三丆丄:  0));
        val_1.Add(item:  new 丘丝丑丐丆丑七不丙(丞世不丒下上上丝丑:  6, 丌丒丝东丌下丕丁丅:  0, 丌丟丕不丄业不上业:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, 丁丅丈丌丟世丗丗丟:  5, 三丒万万丗世三丆丄:  0));
        return (System.Collections.Generic.IList<丘丝丑丐丆丑七不丙>)val_1;
    }
    public string get_CurrencyThatNotEnough()
    {
        return (string)this.<丏专丝世专丘东丛不>k__BackingField;
    }
    public void set_CurrencyThatNotEnough(string 丙业与丙丗丝不丈东)
    {
        this.<丏专丝世专丘东丛不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string get_DesiredCurrency()
    {
        return (string)this.<丐丛丄丟丟东专丄丝>k__BackingField;
    }
    public void set_DesiredCurrency(string 丙业与丙丗丝不丈东)
    {
        this.<丐丛丄丟丟东专丄丝>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_ConnectionProblemLabelEnabled()
    {
        if(this.connectionProblemLabel == 0)
        {
                return false;
        }
        
        return 丅丆万丟丐丏丏下丄.世三丅不丄丂丒丕上(丞下万上三丘上与专:  this.connectionProblemLabel.gameObject);
    }
    public void set_ConnectionProblemLabelEnabled(bool 丙业与丙丗丝不丈东)
    {
        if(this.connectionProblemLabel == 0)
        {
                return;
        }
        
        this.connectionProblemLabel.gameObject.SetActive(value:  丙业与丙丗丝不丈东);
    }
    public bool get_CrackersWarningLabelEnabled()
    {
        if(this.crackersWarningLabel == 0)
        {
                return false;
        }
        
        return 丅丆万丟丐丏丏下丄.世三丅不丄丂丒丕上(丞下万上三丘上与专:  this.crackersWarningLabel.gameObject);
    }
    public void set_CrackersWarningLabelEnabled(bool 丙业与丙丗丝不丈东)
    {
        if(this.crackersWarningLabel == 0)
        {
                return;
        }
        
        this.crackersWarningLabel.gameObject.SetActive(value:  丙业与丙丗丝不丈东);
    }
    public bool get_PurchaseSuccessfulLabelEnabled()
    {
        if(this.purchaseSuccessfulLabel == 0)
        {
                return false;
        }
        
        return 丅丆万丟丐丏丏下丄.世三丅不丄丂丒丕上(丞下万上三丘上与专:  this.purchaseSuccessfulLabel.gameObject);
    }
    public void set_PurchaseSuccessfulLabelEnabled(bool 丙业与丙丗丝不丈东)
    {
        if(this.purchaseSuccessfulLabel == 0)
        {
                return;
        }
        
        this.purchaseSuccessfulLabel.gameObject.SetActive(value:  丙业与丙丗丝不丈东);
    }
    public abstract bool get_AreBankContentsEnabled(); // 0
    public abstract void set_AreBankContentsEnabled(bool 丙业与丙丗丝不丈东); // 0
    private UILabel 丙丛丒不丌丂与丈世()
    {
        UILabel val_4;
        if(this.丞不三丟万丑万丑丄 == 0)
        {
                if(this.freeAwardButton != 0)
        {
            goto label_6;
        }
        
        }
        
        val_4 = this.丞不三丟万丑万丑丄;
        return val_3;
        label_6:
        UILabel val_3 = this.freeAwardButton.GetComponentInChildren<UILabel>();
        this.丞不三丟万丑万丑丄 = val_3;
        return val_3;
    }
    public void add_PurchaseButtonPressed(System.Action<AbstractBankViewItem> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丑业下丂丘丛丟一丅, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丑业下丂丘丛丟一丅 != 1152921537914372440);
    
    }
    public void remove_PurchaseButtonPressed(System.Action<AbstractBankViewItem> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丑业下丂丘丛丟一丅, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丑业下丂丘丛丟一丅 != 1152921537914509016);
    
    }
    public void add_InfoButtonPressed(System.Action<AbstractBankViewItem> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丕丒与业丟丞丑丟丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丒与业丟丞丑丟丏 != 1152921537914645600);
    
    }
    public void remove_InfoButtonPressed(System.Action<AbstractBankViewItem> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丕丒与业丟丞丑丟丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丒与业丟丞丑丟丏 != 1152921537914782176);
    
    }
    public abstract void StopScrolling(); // 0
    public void add_BackButtonPressed(System.EventHandler 丙业与丙丗丝不丈东)
    {
        if(this.backButton == 0)
        {
                return;
        }
        
        this.backButton.add_Clicked(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public void remove_BackButtonPressed(System.EventHandler 丙业与丙丗丝不丈东)
    {
        if(this.backButton == 0)
        {
                return;
        }
        
        this.backButton.remove_Clicked(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public void SetXModes(bool 且丐上且丞丒丟与丘, bool 丅丂东丞丛丐上不三)
    {
        var val_14;
        bool val_15;
        var val_16;
        var val_20;
        UILabel val_21;
        var val_23;
        val_14 = 0;
        bool val_1 = 且丐上且丞丒丟与丘 | 丅丂东丞丛丐上不三;
        goto label_1;
        label_7:
        val_15 = val_1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.x3BankElements[0], 丏业丟一东丂东丘丛:  val_15);
        val_14 = 1;
        label_1:
        if(val_14 < this.x3BankElements.Length)
        {
            goto label_7;
        }
        
        val_16 = 0;
        goto label_8;
        label_14:
        val_15 = val_1 ^ 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.usualBankElements[0], 丏业丟一东丂东丘丛:  val_15);
        val_16 = 1;
        label_8:
        if(val_16 < this.usualBankElements.Length)
        {
            goto label_14;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        System.Collections.Generic.IEnumerator<T> val_5 = this.GetEnumerator();
        label_32:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_25;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_5.Current != 0)
        {
            goto label_32;
        }
        
        goto label_32;
        label_25:
        val_20 = 0;
        val_21 = 0;
        if(val_5 == null)
        {
            
        }
        else
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_5.Dispose();
        }
        
        val_23 = null;
        bool val_11 = AbstractBankView.丐与丐丄七丗三专万();
        if(val_1 != false)
        {
                val_21 = this.getNTimesMore;
            if(val_21 != 0)
        {
                val_21 = this.getNTimesMore;
            val_21.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (val_11 != true) ? "Key_4828" : "Key_0978");
        }
        
        }
        
        this.专丏丞丆丕丗丗一丙(丗丈丒丏丏丂三丕丂:  val_11);
    }
    protected static bool 丐与丐丄七丗三专万()
    {
        if(X10Manager.丑七不且上丗丁一世().丑丅丞丝丕丕丞丈专() != false)
        {
                return true;
        }
        
        X10Manager val_3 = X10Manager.丑七不且上丗丁一世();
        if(val_3 != null)
        {
                return val_3.丗丘丌一丞丝丂丟丒();
        }
        
        return val_3.丗丘丌一丞丝丂丟丒();
    }
    protected void 专丏丞丆丕丗丗一丙(bool 丗丈丒丏丏丂三丕丂)
    {
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.GameObject val_10;
        var val_11;
        val_7 = 丗丈丒丏丏丂三丕丂;
        if(this.gemsTabExclamation != 0)
        {
                if(val_7 != false)
        {
                val_8 = null;
            val_8 = null;
            val_9 = (~(X10Manager.丑七不且上丗丁一世().丛世丟世丅七万丄不(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝))) & 1;
        }
        else
        {
                val_9 = 0;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gemsTabExclamation, 丏业丟一东丂东丘丛:  false);
        }
        
        val_10 = this.coinsTabExclamation;
        if(val_10 == 0)
        {
                return;
        }
        
        if(val_7 != false)
        {
                val_11 = null;
            val_11 = null;
            val_10 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            val_7 = (~(X10Manager.丑七不且上丗丁一世().丛世丟世丅七万丄不(丏丂不专上丘丂不丅:  val_10))) & 1;
        }
        else
        {
                val_7 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.coinsTabExclamation, 丏业丟一东丂东丘丛:  false);
    }
    public abstract void UpdateUi(); // 0
    protected virtual void Awake()
    {
        var val_3;
        this.add_BackButtonPressed(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void AbstractBankView::丅不一丄专丒不与丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_3 = null;
        val_3 = null;
        this.丕业丐业且丐万东丏 = StoreKitEventListener.丆丕丝丒不丙且丐丗;
        if(StoreKitEventListener.丆丕丝丒不丙且丐丗 == 0)
        {
                UnityEngine.Debug.LogError(message:  "storeKitEventListener == null");
            return;
        }
        
        this.<丐丛丄丟丟东专丄丝>k__BackingField = this.<丐丛丄丟丟东专丄丝>k__BackingField;
    }
    private void 丅不一丄专丒不与丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(东丗上丁下业一丂丂.专七与丏丞丁丅丈丟() == false)
        {
                return;
        }
        
        ActivityIndicator.丁与丏东且与万丝下();
    }
    protected virtual void OnEnable()
    {
    
    }
    protected virtual void Start()
    {
        goto label_3;
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.AdFreeLabels[0], 丏业丟一东丂东丘丛:  StoreKitEventListener.丝丝一丟丈三丂丌丁());
        0 = 1;
        label_3:
        if(0 < this.AdFreeLabels.Length)
        {
            goto label_8;
        }
    
    }
    protected virtual void Update()
    {
        var val_27;
        double val_28;
        UILabel[] val_29;
        var val_30;
        var val_31;
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.丌与丞丘且丏丈丞丆;
        if(val_1 < 0.5f)
        {
            goto label_1;
        }
        
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世().丐且丘业丙丅丛丝丛() == false)
        {
            goto label_5;
        }
        
        val_27 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().东不丟丁业丈不丟丆();
        if(val_27 != 0)
        {
            goto label_13;
        }
        
        label_5:
        val_27 = 0;
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌() != false)
        {
                val_27 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().三三世丕丂专下丆世();
        }
        
        label_13:
        val_28 = (double)val_27;
        System.TimeSpan val_10 = System.TimeSpan.FromSeconds(value:  val_28);
        val_29 = this.eventX3RemainTime;
        if(val_29 == null)
        {
            goto label_21;
        }
        
        val_30 = 0;
        goto label_22;
        label_27:
        this.eventX3RemainTime[0].text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_10._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_29 = this.eventX3RemainTime;
        val_30 = 1;
        label_22:
        if(val_30 < this.eventX3RemainTime.Length)
        {
            goto label_27;
        }
        
        label_21:
        if((this.colorBlinkForX3 == 0) || (this.colorBlinkForX3.enabled == true))
        {
            goto label_39;
        }
        
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世().丐且丘业丙丅丛丝丛() == true)
        {
            goto label_36;
        }
        
        val_28 = (double)与丂丏丛丞丞丒丟丄.上上东丑一与丙丆丒();
        if(val_10._ticks.TotalHours >= 0)
        {
            goto label_39;
        }
        
        label_36:
        this.colorBlinkForX3.enabled = true;
        label_39:
        this.丌与丞丘且丏丈丞丆 = UnityEngine.Time.realtimeSinceStartup;
        label_1:
        if(this.丙丛丒不丌丂与丈世() != 0)
        {
                if(this.freeAwardButton.isActiveAndEnabled != false)
        {
                val_29 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3994");
            this.丙丛丒不丌丂与丈世().text = val_29;
        }
        
        }
        
        if(coinsShop.世丒丏上丘丁与丟丁() != false)
        {
                val_31 = 0;
        }
        else
        {
                val_31 = 0;
        }
        
        this.丛业丆丘丐丟丈丆丘(丐一丞一丐丒专丙丂:  coinsShop.七三丗丏丑丗三丆世());
    }
    private void 丛业丆丘丐丟丈丆丘(bool 丐一丞一丐丒专丙丂)
    {
        if((丐一丞一丐丒专丙丂 != false) && ((System.String.IsNullOrEmpty(value:  this.<丏专丝世专丘东丛不>k__BackingField)) != true))
        {
                if((this.丁丏专丁丅丈与世与.ContainsKey(key:  this.<丏专丝世专丘东丛不>k__BackingField)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._notEnoughCurrencyLabel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._notEnoughCurrencyLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丁丏专丁丅丈与世与.Item[this.<丏专丝世专丘东丛不>k__BackingField]));
            return;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._notEnoughCurrencyLabel, 丏业丟一东丂东丘丛:  false);
    }
    protected virtual void OnDestroy()
    {
        this.remove_BackButtonPressed(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void AbstractBankView::丅不一丄专丒不与丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    protected abstract System.Collections.Generic.IEnumerable<AbstractBankViewItem> 丙万丗丑丐专且与丈(); // 0
    protected virtual void 东专丑七与丟丁上丗(AbstractBankViewItem 下丅丙一丂丗丅丝七, 丘丝丑丐丆丑七不丙 一丒丆业丅七丛且丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 东丈丏东丑丟不不丞)
    {
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_21 = 东丈丏东丑丟不不丞;
        val_22 = 丆不丁且丙丅丂专丟;
        val_23 = 一丒丆业丅七丛且丏;
        val_24 = 下丅丙一丂丗丅丝七;
        val_25 = this;
        if(val_23 != null)
        {
                val_25 = ???;
            val_24 = ???;
            val_21 = ???;
            val_22 = ???;
            val_23 = ???;
        }
        else
        {
                if(val_22 != 0)
        {
                val_26 = mem[val_25 + 552];
            val_26 = val_25 + 552;
        }
        else
        {
                if((???) != 0)
        {
                val_26 = mem[val_25 + 568];
            val_26 = val_25 + 568;
        }
        else
        {
                if(val_21 != 0)
        {
                val_26 = mem[val_25 + 584];
            val_26 = val_25 + 584;
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "unknown item data");
        }
        
        }
        
        }
        
        }
    
    }
    internal static System.Nullable<丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙> 万与丘丙业丈丆丂三(PGCompany.三丌上丁一丟丐丟丈 丞丂业丅丟丙丏七丗)
    {
        var val_1;
        if(丞丂业丅丟丙丏七丗 <= 19015)
        {
            goto label_1;
        }
        
        if(丞丂业丅丟丙丏七丗 == 20015)
        {
            goto label_2;
        }
        
        if(丞丂业丅丟丙丏七丗 != 21015)
        {
                return 0;
        }
        
        val_1 = 1152921537917392528;
        return 0;
        label_1:
        if(丞丂业丅丟丙丏七丗 == 10015)
        {
            goto label_5;
        }
        
        if(丞丂业丅丟丙丏七丗 != 19015)
        {
                return 0;
        }
        
        val_1 = 1152921537917392528;
        return 0;
        label_2:
        val_1 = 1152921537917392528;
        return 0;
        label_5:
        val_1 = 1152921537917392528;
        return 0;
    }
    internal static int[] 丅三丝丏一丟丙丛不(PGCompany.三丌上丁一丟丐丟丈 丞丂业丅丟丙丏七丗)
    {
        PGCompany.三丌上丁一丟丐丟丈 val_3;
        var val_4;
        val_3 = 丞丂业丅丟丙丏七丗;
        System.Nullable<一丅丌丁丙丈丙上丙> val_1 = AbstractBankView.万与丘丙业丈丆丂三(丞丂业丅丟丙丏七丗:  val_3);
        if(((-1049020728) & 1) != 0)
        {
                val_3;
            System.Int32[] val_2 = AbstractBankView.丅三丝丏一丟丙丛不(丁丅丈丌丟世丗丗丟:  val_1.HasValue);
            return (System.Int32[])val_4;
        }
        
        val_4 = 0;
        return (System.Int32[])val_4;
    }
    internal static int[] 丅三丝丏一丟丙丛不(丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 丁丅丈丌丟世丗丗丟)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_1 = 丁丅丈丌丟世丗丗丟;
        if(val_1 == 4)
        {
            goto label_1;
        }
        
        if(val_1 == 1)
        {
            goto label_2;
        }
        
        if(val_1 != 0)
        {
            goto label_3;
        }
        
        val_1 = 1152921505317388288;
        val_2 = null;
        val_2 = null;
        val_3 = 1152921505317392512;
        return (System.Int32[])val_3;
        label_1:
        val_1 = 1152921505317388288;
        val_4 = null;
        val_4 = null;
        val_3 = 1152921505317392536;
        return (System.Int32[])val_3;
        label_2:
        val_1 = 1152921505317388288;
        val_5 = null;
        val_5 = null;
        val_3 = 1152921505317392520;
        return (System.Int32[])val_3;
        label_3:
        val_6 = null;
        if(val_1 == 6)
        {
                val_7 = null;
            val_3 = 1152921505317392552;
            return (System.Int32[])val_3;
        }
        
        val_8 = null;
        val_3 = 1152921505317392528;
        return (System.Int32[])val_3;
    }
    internal static int 丁且丘丅丌丛下一丆(PGCompany.三丌上丁一丟丐丟丈 丞丂业丅丟丙丏七丗, string 丘专丈与三专丈丈专)
    {
        string val_7;
        int val_8;
        int val_9;
        object val_10;
        val_7 = 丘专丈与三专丈丈专;
        System.String[] val_1 = AbstractBankView.丄丕东丝丕丏丞丄与(丞丂业丅丟丙丏七丗:  丞丂业丅丟丙丏七丗);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        val_7 = System.Array.IndexOf<System.String>(array:  val_1, value:  val_7);
        if((val_7 & 2147483648) != 0)
        {
            goto label_4;
        }
        
        System.Int32[] val_3 = AbstractBankView.丅三丝丏一丟丙丛不(丞丂业丅丟丙丏七丗:  47);
        if(val_3 == null)
        {
            goto label_7;
        }
        
        val_8 = val_3.Length;
        if(val_7 > (val_8 - 1))
        {
                UnityEngine.Debug.Log(message:  System.String.Format(format:  "[TEST] index > reals.Length-1, index: {0}", arg0:  val_7));
            val_8 = val_3.Length;
        }
        
        if(val_7 > (val_8 - 1))
        {
            goto label_11;
        }
        
        val_7 = (long)val_7;
        val_9 = val_3[((long)(int)(val_2)) << 2];
        return (int)val_9;
        label_3:
        val_10 = "[TEST] inapps: null";
        goto label_19;
        label_4:
        val_10 = "[TEST] index: < 0";
        goto label_19;
        label_7:
        val_10 = "[TEST] reals: null";
        label_19:
        UnityEngine.Debug.Log(message:  val_10);
        label_11:
        val_9 = 0;
        return (int)val_9;
    }
    internal static int 丕东专下上丆丝丆专(int 世丈三丐丞一丒丛不, 丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 万丐丝一万专上且丝)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        if(万丐丝一万专上且丝 == 1)
        {
                val_3 = null;
            val_4 = 1152921505209671688;
        }
        else
        {
                val_3 = null;
        }
        
        val_5 = 0;
        goto label_9;
        label_13:
        if((AbstractBankView.丅三丝丏一丟丙丛不(丁丅丈丌丟世丗丗丟:  万丐丝一万专上且丝)[0]) == 世丈三丐丞一丒丛不)
        {
            goto label_11;
        }
        
        val_5 = 1;
        label_9:
        if(val_5 < val_1.Length)
        {
            goto label_13;
        }
        
        return 0;
        label_11:
        if((val_5 & 2147483648) == 0)
        {
                if(val_5 <= (AbstractBankView.丙不丌丁丆丕丒上丏.Length - 1))
        {
            goto label_17;
        }
        
        }
        
        return 0;
        label_17:
        if(val_5 < AbstractBankView.丙不丌丁丆丕丒上丏.Length)
        {
                return 0;
        }
        
        return 0;
    }
    internal static string[] 丄丕东丝丕丏丞丄与(PGCompany.三丌上丁一丟丐丟丈 丞丂业丅丟丙丏七丗)
    {
        PGCompany.三丌上丁一丟丐丟丈 val_3;
        var val_4;
        val_3 = 丞丂业丅丟丙丏七丗;
        System.Nullable<一丅丌丁丙丈丙上丙> val_1 = AbstractBankView.万与丘丙业丈丆丂三(丞丂业丅丟丙丏七丗:  val_3);
        if(((-1048219976) & 1) != 0)
        {
                val_3;
            System.String[] val_2 = AbstractBankView.丄丕东丝丕丏丞丄与(丁丅丈丌丟世丗丗丟:  val_1.HasValue);
            return (System.String[])val_4;
        }
        
        val_4 = 0;
        return (System.String[])val_4;
    }
    internal static string[] 丄丕东丝丕丏丞丄与(丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 丁丅丈丌丟世丗丗丟)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_1 = 丁丅丈丌丟世丗丗丟;
        if(val_1 == 4)
        {
            goto label_1;
        }
        
        if(val_1 == 1)
        {
            goto label_2;
        }
        
        if(val_1 != 0)
        {
            goto label_3;
        }
        
        val_1 = 1152921505272713216;
        val_2 = null;
        val_2 = null;
        val_3 = 1152921505272717328;
        return (System.String[])val_3;
        label_1:
        val_1 = 1152921505272713216;
        val_4 = null;
        val_4 = null;
        val_3 = 1152921505272717536;
        return (System.String[])val_3;
        label_2:
        val_1 = 1152921505272713216;
        val_5 = null;
        val_5 = null;
        val_3 = 1152921505272717520;
        return (System.String[])val_3;
        label_3:
        val_6 = null;
        if(val_1 == 6)
        {
                val_7 = null;
            val_3 = 1152921505272717320;
            return (System.String[])val_3;
        }
        
        val_8 = null;
        val_3 = 1152921505272717528;
        return (System.String[])val_3;
    }
    private static int 丆三丅丝丟丞丟一东(丘丝丑丐丆丑七不丙 一丒丆业丅七丛且丏)
    {
        if(一丒丆业丅七丛且丏.不业丙丒丂丞下丆丙() == 0)
        {
            goto label_2;
        }
        
        if(一丒丆业丅七丛且丏.不业丙丒丂丞下丆丙() != 1)
        {
            goto label_4;
        }
        
        业丗丙东丄不万丁三 val_3 = 丏丄丑上丛不丈且万.丒丂且不业丕丈丌一();
        goto label_10;
        label_2:
        业丗丙东丄不万丁三 val_4 = 丏丄丑上丛不丈且万.三丁七丞丐丆与丏三();
        goto label_10;
        label_4:
        if(一丒丆业丅七丛且丏.不业丙丒丂丞下丆丙() != 4)
        {
                return 0;
        }
        
        业丗丙东丄不万丁三 val_6 = 丏丄丑上丛不丈且万.丐三万专丌丌世丘上();
        label_10:
        if(val_6 != null)
        {
                return val_6.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  一丒丆业丅七丛且丏.业东丅东丌上丗丑不());
        }
        
        return val_6.丂丑丞丝且万丐万丟(丞世不丒下上上丝丑:  一丒丆业丅七丛且丏.业东丅东丌上丗丑不());
    }
    private static decimal 万丑丞专专丁丒东一(丘丝丑丐丆丑七不丙 一丒丆业丅七丛且丏)
    {
        var val_7;
        System.Int32[] val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if(一丒丆业丅七丛且丏.不业丙丒丂丞下丆丙() == 0)
        {
            goto label_2;
        }
        
        if(一丒丆业丅七丛且丏.不业丙丒丂丞下丆丙() != 1)
        {
            goto label_4;
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏;
        if(一丒丆业丅七丛且丏 != null)
        {
            goto label_30;
        }
        
        goto label_31;
        label_2:
        val_9 = null;
        val_9 = null;
        val_8 = 丏丄丑上丛不丈且万.丟世下上不下丘丄丒;
        if(一丒丆业丅七丛且丏 != null)
        {
            goto label_30;
        }
        
        label_31:
        label_30:
        int val_3 = 一丒丆业丅七丛且丏.业东丅东丌上丗丑不();
        System.Int32[] val_4 = val_8 + (((long)(int)(val_3)) << 2);
        return System.Decimal.op_Implicit(value:  (丏丄丑上丛不丈且万.丟世下上不下丘丄丒 + ((long)(int)(val_3)) << 2) + 32);
        label_4:
        if(一丒丆业丅七丛且丏.不业丙丒丂丞下丆丙() != 4)
        {
            goto label_17;
        }
        
        val_10 = null;
        val_10 = null;
        if(一丒丆业丅七丛且丏 != null)
        {
            goto label_30;
        }
        
        goto label_31;
        label_17:
        val_11 = null;
        if(一丒丆业丅七丛且丏.不业丙丒丂丞下丆丙() != 6)
        {
            goto label_23;
        }
        
        val_12 = null;
        if(一丒丆业丅七丛且丏 != null)
        {
            goto label_30;
        }
        
        goto label_31;
        label_23:
        val_13 = null;
        if(一丒丆业丅七丛且丏 != null)
        {
            goto label_30;
        }
        
        goto label_31;
    }
    internal static 丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 一丄丂丛业丘东丌东(string 丄丒丌上丁丂不万东)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄丒丌上丁丂不万东)) != false)
        {
                val_8 = 0;
            return (一丅丌丁丙丈丙上丙)((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丒丁丐丙丐丈丕专世, value:  丄丒丌上丁丂不万东)) != true) ? 6 : (!0);
        }
        
        val_9 = null;
        val_9 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.业丝丐三上丈丛丂专, value:  丄丒丌上丁丂不万东)) != false)
        {
                val_8 = 0;
            return (一丅丌丁丙丈丙上丙)((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丒丁丐丙丐丈丕专世, value:  丄丒丌上丁丂不万东)) != true) ? 6 : (!0);
        }
        
        val_10 = null;
        val_10 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丒丕丗丑丕且丌丁丂, value:  丄丒丌上丁丂不万东)) != false)
        {
                val_8 = 1;
            return (一丅丌丁丙丈丙上丙)((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丒丁丐丙丐丈丕专世, value:  丄丒丌上丁丂不万东)) != true) ? 6 : (!0);
        }
        
        val_11 = null;
        val_11 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.业万专三一丟且丘业, value:  丄丒丌上丁丂不万东)) != false)
        {
                val_8 = 2;
            return (一丅丌丁丙丈丙上丙)((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丒丁丐丙丐丈丕专世, value:  丄丒丌上丁丂不万东)) != true) ? 6 : (!0);
        }
        
        val_12 = null;
        val_12 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.下丕丄东与丙三丂丒, value:  丄丒丌上丁丂不万东)) != false)
        {
                val_8 = 4;
            return (一丅丌丁丙丈丙上丙)((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丒丁丐丙丐丈丕专世, value:  丄丒丌上丁丂不万东)) != true) ? 6 : (!0);
        }
        
        val_13 = null;
        val_13 = null;
        return (一丅丌丁丙丈丙上丙)((System.Linq.Enumerable.Contains<System.String>(source:  StoreKitEventListener.丒丁丐丙丐丈丕专世, value:  丄丒丌上丁丂不万东)) != true) ? 6 : (!0);
    }
    internal static int 丈三丏东丞丈丕丝丁(string 丄丒丌上丁丂不万东)
    {
        var val_5;
        int val_6;
        val_5 = 1152921505209667584;
        一丅丌丁丙丈丙上丙 val_1 = AbstractBankView.一丄丂丛业丘东丌东(丄丒丌上丁丂不万东:  丄丒丌上丁丂不万东);
        if(val_1 == 1)
        {
                return (int)val_6;
        }
        
        val_5 = AbstractBankView.丄丕东丝丕丏丞丄与(丁丅丈丌丟世丗丗丟:  val_1);
        System.Int32[] val_3 = AbstractBankView.丅三丝丏一丟丙丛不(丁丅丈丌丟世丗丗丟:  val_1);
        val_6 = 0;
        if(val_5 == null)
        {
                return (int)val_6;
        }
        
        if(val_3 == null)
        {
                return (int)val_6;
        }
        
        val_6 = 0;
        if(val_2.Length != val_3.Length)
        {
                return (int)val_6;
        }
        
        if(val_2.Length < 1)
        {
                return (int)val_6;
        }
        
        label_12:
        if((System.String.op_Equality(a:  val_5[0], b:  丄丒丌上丁丂不万东)) == true)
        {
            goto label_11;
        }
        
        if((0 + 1) < val_2.Length)
        {
            goto label_12;
        }
        
        goto label_14;
        label_11:
        if((0 & 2147483648) == 0)
        {
                val_6 = val_3[0];
            return (int)val_6;
        }
        
        label_14:
        val_6 = 0;
        return (int)val_6;
    }
    internal static 丘丝丑丐丆丑七不丙 七丆丆世丄且丕世万(string 丄丒丌上丁丂不万东)
    {
        var val_6;
        var val_7;
        val_6 = 1152921505209667584;
        一丅丌丁丙丈丙上丙 val_1 = AbstractBankView.一丄丂丛业丘东丌东(丄丒丌上丁丂不万东:  丄丒丌上丁丂不万东);
        if(val_1 == 1)
        {
                return 0;
        }
        
        val_6 = 0;
        goto label_6;
        label_10:
        val_7 = 0;
        if((System.String.op_Equality(a:  AbstractBankView.丄丕东丝丕丏丞丄与(丁丅丈丌丟世丗丗丟:  val_1)[0], b:  丄丒丌上丁丂不万东)) == true)
        {
            goto label_8;
        }
        
        val_6 = 1;
        label_6:
        if(val_6 < val_2.Length)
        {
            goto label_10;
        }
        
        return 0;
        label_8:
        if((val_6 & 2147483648) != 0)
        {
                return 0;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_7 = 0;
        return BankView.丅世丌丏丈不丙且丟(万丐丝一万专上且丝:  val_1).Item[0];
    }
    internal static string 丕东与丐丆丛丛与丅(PGCompany.三丌上丁一丟丐丟丈 丞丂业丅丟丙丏七丗, int 世丈三丐丞一丒丛不)
    {
        var val_3;
        System.Nullable<一丅丌丁丙丈丙上丙> val_1 = AbstractBankView.万与丘丙业丈丆丂三(丞丂业丅丟丙丏七丗:  丞丂业丅丟丙丏七丗);
        if(((-1046993576) & 1) != 0)
        {
                string val_2 = AbstractBankView.丕东与丐丆丛丛与丅(万丐丝一万专上且丝:  val_1.HasValue, 世丈三丐丞一丒丛不:  世丈三丐丞一丒丛不);
            return (string)val_3;
        }
        
        val_3 = 0;
        return (string)val_3;
    }
    internal static string 丕东与丐丆丛丛与丅(丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 万丐丝一万专上且丝, int 世丈三丐丞一丒丛不)
    {
        var val_9;
        System.Object[] val_10;
        var val_11;
        string val_13;
        val_9 = 世丈三丐丞一丒丛不;
        val_10 = 0;
        goto label_3;
        label_7:
        val_11 = 0;
        if((AbstractBankView.丅三丝丏一丟丙丛不(丁丅丈丌丟世丗丗丟:  万丐丝一万专上且丝)[0]) == val_9)
        {
            goto label_5;
        }
        
        val_10 = 1;
        label_3:
        if(val_10 < val_1.Length)
        {
            goto label_7;
        }
        
        goto label_9;
        label_5:
        if((val_10 & 2147483648) == 0)
        {
                var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = 0;
            T val_4 = BankView.丅世丌丏丈不丙且丟(万丐丝一万专上且丝:  万丐丝一万专上且丝).Item[0];
            val_9 = val_4.业东丅东丌上丗丑不();
            if(val_9 < val_6.Length)
        {
                val_10 = (long)val_4.业东丅东丌上丗丑不();
            val_13 = AbstractBankView.丄丕东丝丕丏丞丄与(丁丅丈丌丟世丗丗丟:  val_4.不业丙丒丂丞下丆丙())[val_10];
            return (string)val_13;
        }
        
            val_10 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "UpdateItem: purchaseInfo.Index < inAppIds.Length", args:  val_10);
        }
        
        label_9:
        val_13 = 0;
        return (string)val_13;
    }
    internal static int 丆丟万丆专丂丝丌丕(丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 万丐丝一万专上且丝, int 世丈三丐丞一丒丛不)
    {
        var val_8;
        System.Object[] val_9;
        var val_10;
        val_8 = 世丈三丐丞一丒丛不;
        val_9 = 0;
        goto label_3;
        label_7:
        val_10 = 0;
        if((AbstractBankView.丅三丝丏一丟丙丛不(丁丅丈丌丟世丗丗丟:  万丐丝一万专上且丝)[0]) == val_8)
        {
            goto label_5;
        }
        
        val_9 = 1;
        label_3:
        if(val_9 < val_1.Length)
        {
            goto label_7;
        }
        
        return 0;
        label_5:
        if((val_9 & 2147483648) != 0)
        {
                return 0;
        }
        
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_10 = 0;
        T val_4 = BankView.丅世丌丏丈不丙且丟(万丐丝一万专上且丝:  万丐丝一万专上且丝).Item[0];
        System.String[] val_6 = AbstractBankView.丄丕东丝丕丏丞丄与(丁丅丈丌丟世丗丗丟:  val_4.不业丙丒丂丞下丆丙());
        val_8 = val_4.业东丅东丌上丗丑不();
        if(val_8 < val_6.Length)
        {
                return AbstractBankView.丆三丅丝丟丞丟一东(一丒丆业丅七丛且丏:  val_4);
        }
        
        val_9 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "UpdateItem: purchaseInfo.Index < inAppIds.Length", args:  val_9);
        return 0;
    }
    protected virtual void 下丝一一丈丑丄丝七(AbstractBankViewItem 下丅丙一丂丗丅丝七, 丘丝丑丐丆丑七不丙 一丒丆业丅七丛且丏, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘)
    {
        var val_19;
        var val_20;
        AbstractBankView.上与专上专丞东丄丆 val_1 = new AbstractBankView.上与专上专丞东丄丆();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
        if(一丒丆业丅七丛且丏.业东丅东丌上丗丑不() >= val_3.Length)
        {
            goto label_8;
        }
        
        .丘专丈与三专丈丈专 = AbstractBankView.丄丕东丝丕丏丞丄与(丁丅丈丌丟世丗丗丟:  一丒丆业丅七丛且丏.不业丙丒丂丞下丆丙())[(long)一丒丆业丅七丛且丏.业东丅东丌上丗丑不()];
        一丒丆业丅七丛且丏.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  AbstractBankView.丆三丅丝丟丞丟一东(一丒丆业丅七丛且丏:  一丒丆业丅七丛且丏));
        decimal val_7 = AbstractBankView.万丑丞专专丁丒东一(一丒丆业丅七丛且丏:  一丒丆业丅七丛且丏);
        decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid}, d2:  new System.Decimal());
        if(一丒丆业丅七丛且丏 == null)
        {
            goto label_16;
        }
        
        一丒丆业丅七丛且丏.丛七丄七丛丒万与世(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid});
        goto label_17;
        label_8:
        UnityEngine.Debug.LogErrorFormat(format:  "UpdateItem: purchaseInfo.Index < inAppIds.Length", args:  System.Array.Empty<System.Object>());
        return;
        label_16:
        0.丛七丄七丛丒万与世(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid});
        label_17:
        decimal val_10 = 一丒丆业丅七丛且丏.丕七丗丘业丆一丘一();
        val_19 = System.String.Format(format:  "${0}", arg0:  val_10);
        val_20 = public static Rilisoft.与丗丌丑专业丝丛丏 System.Linq.Enumerable::FirstOrDefault<Rilisoft.与丗丌丑专业丝丛丏>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
        Rilisoft.与丗丌丑专业丝丛丏 val_14 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.与丗丌丑专业丝丛丏>(source:  this.丕业丐业且丐万东丏.世丝世业丙丙丄一一(), predicate:  new System.Func<Rilisoft.与丗丌丑专业丝丛丏, System.Boolean>(object:  val_1, method:  System.Boolean AbstractBankView.上与专上专丞东丄丆::丛丛丗丗三丒七丑丆(Rilisoft.与丗丌丑专业丝丛丏 七丏丄丅丌业与且丙)));
        if(val_14 == null)
        {
            goto label_21;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        val_20 = 3;
        goto label_25;
        label_21:
        val_20 = 0;
        UnityEngine.Debug.LogWarning(message:  "marketProduct == null,    inappId: "("marketProduct == null,    inappId: ") + (AbstractBankView.上与专上专丞东丄丆)[1152921537920646080].丘专丈与三专丈丈专);
        if(val_1 != null)
        {
            goto label_30;
        }
        
        goto label_29;
        label_25:
        val_19 = val_14.丟丂丞不专丆万丒世();
        if(val_1 != null)
        {
            goto label_30;
        }
        
        label_29:
        label_30:
        new System.EventHandler() = new System.EventHandler(object:  val_1, method:  System.Void AbstractBankView.上与专上专丞东丄丆::上丝业丈丘下丄东世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        new System.EventHandler() = new System.EventHandler(object:  val_1, method:  System.Void AbstractBankView.上与专上专丞东丄丆::且丑丞丒丅丅丙丌丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        if((AbstractBankView.上与专上专丞东丄丆)[1152921537920646080].下丅丙一丂丗丅丝七 != null)
        {
                return;
        }
    
    }
    protected virtual void 丅七丆专丈丄丆丐丙(AbstractBankViewItem 下丅丙一丂丗丅丝七, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟)
    {
        AbstractBankView.一东丑丈丐丂丒业丞 val_1 = new AbstractBankView.一东丑丈丐丂丒业丞();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
        mem[1152921537920941584] = this;
        if(丆不丁且丙丅丂专丟 != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        string val_4 = System.String.Format(format:  "${0}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丆不丁且丙丅丂专丟.丏业丁七世丆七上丑()));
        new System.EventHandler() = new System.EventHandler(object:  val_1, method:  System.Void AbstractBankView.一东丑丈丐丂丒业丞::七丅丗业丅丙世丙丑(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        new System.EventHandler() = new System.EventHandler(object:  val_1, method:  System.Void AbstractBankView.一东丑丈丐丂丒业丞::丏业业下业丐下不万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        if(.下丅丙一丂丗丅丝七 != null)
        {
                return;
        }
        
        return;
        label_1:
        mem[16] = this;
        mem[24] = 下丅丙一丂丗丅丝七;
        if(丆不丁且丙丅丂专丟 != null)
        {
            goto label_8;
        }
        
        goto label_9;
    }
    protected virtual void 丏丒万丙下丞万丅丐(AbstractBankViewItem 下丅丙一丂丗丅丝七, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌)
    {
        AbstractBankView.丑七丂丙一丕丘东世 val_1 = new AbstractBankView.丑七丂丙一丕丘东世();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
        mem[1152921537921125296] = this;
        if(丙业丞丑七丗下丟丌 != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        string val_5 = System.String.Format(format:  "${0}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丙业丞丑七丗下丟丌.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世()));
        new System.EventHandler() = new System.EventHandler(object:  val_1, method:  System.Void AbstractBankView.丑七丂丙一丕丘东世::丟不丑丐且与丏上丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        new System.EventHandler() = new System.EventHandler(object:  val_1, method:  System.Void AbstractBankView.丑七丂丙一丕丘东世::丄丈一丌丗丅三丈业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        if(.下丅丙一丂丗丅丝七 != null)
        {
                return;
        }
        
        return;
        label_1:
        mem[16] = this;
        mem[24] = 下丅丙一丂丗丅丝七;
        if(丙业丞丑七丗下丟丌 != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    protected virtual void 下丝一一丈丑丄丝七(AbstractBankViewItem 下丅丙一丂丗丅丝七, PGCompany.丘丒下东丗丏丁丅业 东丈丏东丑丟不不丞)
    {
        AbstractBankView.丂丞丕丏丈且丆丞丆 val_1 = new AbstractBankView.丂丞丕丏丈且丆丞丆();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
        mem[1152921537921313104] = this;
        if(东丈丏东丑丟不不丞 != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        string val_4 = System.String.Format(format:  "${0}", arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  东丈丏东丑丟不不丞.Price.丟丂丞不专丆万丒世()));
        new System.EventHandler() = new System.EventHandler(object:  val_1, method:  System.Void AbstractBankView.丂丞丕丏丈且丆丞丆::丛丛丗丗三丒七丑丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        new System.EventHandler() = new System.EventHandler(object:  val_1, method:  System.Void AbstractBankView.丂丞丕丏丈且丆丞丆::上丝业丈丘下丄东世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        if(.下丅丙一丂丗丅丝七 != null)
        {
                return;
        }
        
        return;
        label_1:
        mem[16] = this;
        mem[24] = 下丅丙一丂丗丅丝七;
        if(东丈丏东丑丟不不丞 != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    public virtual void GoToGems(bool 不且丂丛丏业丘丂丝, bool 世不丆上世丆丅业且, System.Action 丟丘丙丄丅万丏与丗)
    {
    
    }
    protected virtual void 丑丛丈三丑一丘专上<T>(bool 不且丂丛丏业丘丂丝, bool 世不丆上世丆丅业且, System.Action 丟丘丙丄丅万丏与丗)
    {
    
    }
    protected AbstractBankView()
    {
        var val_2;
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_2 = null;
        val_2 = null;
        val_1.Add(key:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, value:  "Key_0280");
        if(val_1 != null)
        {
                val_1.Add(key:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, value:  "Key_0982");
        }
        else
        {
                val_1.Add(key:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, value:  "Key_0982");
        }
        
        val_1.Add(key:  "TicketsCurrency", value:  "Key_3150");
        if(val_1 != null)
        {
                val_1.Add(key:  "EventCurrency", value:  "Key_3682");
        }
        else
        {
                val_1.Add(key:  "EventCurrency", value:  "Key_3682");
        }
        
        val_1.Add(key:  "ClanSilver", value:  "Key_8155");
        this.丁丏专丁丅丈与世与 = val_1;
    }
    private static AbstractBankView()
    {
        AbstractBankView.丙不丌丁丆丕丒上丏 = new int[7];
        AbstractBankView.专丄丒万丘专丏丐万 = new int[7];
    }

}
