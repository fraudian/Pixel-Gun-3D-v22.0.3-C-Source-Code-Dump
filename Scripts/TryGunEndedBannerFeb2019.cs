using UnityEngine;
internal class TryGunEndedBannerFeb2019 : MonoBehaviour
{
    // Fields
    public UILabel[] name;
    public UILabel rarityLabel;
    public UIBasicSprite icon;
    public UnityEngine.GameObject enoughDetails;
    public UnityEngine.GameObject detailsContainer;
    public UILabel detailsCount;
    public UILabel description;
    public UILabel price;
    public UILabel oldPrice;
    public UIWidget[] rarityColorObjects;
    private Rilisoft.业丙丘丆东丈丕丂丄 <丌丝世世上丝丄丑丄>k__BackingField;
    private Rilisoft.业丙丘丆东丈丕丂丄 且七丞丅不七丙丌与;
    private string 丌丕世丞丈丒丞丈丟;
    private bool 丛丒专丑不丗丌丙丏;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    internal string 丝丞丂丄不且三丑专 { get; set; }
    private Rilisoft.业丙丘丆东丈丕丂丄 丈丝一丈与丟业丈专 { get; set; }
    
    // Methods
    internal string 丆万丌万丛丏丈万丌()
    {
        return (string)this.丌丕世丞丈丒丞丈丟;
    }
    internal void 上丙丅丘丄东万一下(string 丙业与丙丗丝不丈东)
    {
        var val_32;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_34;
        new TryGunEndedBannerFeb2019.丒丛丁与丅东丒不七() = new System.Object();
        this.丌丕世丞丈丒丞丈丟 = 丙业与丙丗丝不丈东;
        int val_2 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丙业与丙丗丝不丈东);
        .丛丄万三丂东丙丑东 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.丌丕世丞丈丒丞丈丟, 七丆丒与丗丌丄且丂:  val_2);
        System.Action<UILabel> val_4 = new System.Action<UILabel>(object:  new TryGunEndedBannerFeb2019.丒丛丁与丅东丒不七(), method:  System.Void TryGunEndedBannerFeb2019.丒丛丁与丅东丒不七::丛三丟丒丒丑万丟世(UILabel 丐三丞七丝丅不万丛));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.name, 七丐丅专且专七三丆:  null);
        UnityEngine.Texture val_5 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.丌丕世丞丈丒丞丈丟, 七丆丒与丗丌丄且丂:  val_2, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_8 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  this, method:  System.Boolean TryGunEndedBannerFeb2019::丆丝丄且七丆丙丘丏(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
        this.<丌丝世世上丝丄丑丄>k__BackingField = System.Linq.Enumerable.First<Rilisoft.业丙丘丆东丈丕丂丄>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().东东丛一丄丅丌丗且(世七七丟丑丁丂与丞:  70), predicate:  null);
        三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丌丕世丞丈丒丞丈丟);
        UnityEngine.Color val_11 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_10);
        .丒万不丗丅丌丌丅丄 = val_11;
        mem[1152921540580238092] = val_11.g;
        mem[1152921540580238096] = val_11.b;
        mem[1152921540580238100] = val_11.a;
        this.rarityLabel.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        this.rarityLabel.text = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_10);
        bool val_13 = WeaponManager.丕下丘丆万丌丝丟丞(丒东业不丐丑丕丄丆:  this.丌丕世丞丈丒丞丈丟);
        bool val_14 = val_13;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enoughDetails, 丏业丟一东丂东丘丛:  val_14);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.detailsContainer, 丏业丟一东丂东丘丛:  val_14);
        if(val_13 != false)
        {
                val_32 = null;
            val_32 = null;
            val_34 = TryGunEndedBannerFeb2019.<>c.<>9__12_3;
            if(val_34 == null)
        {
                val_34 = null;
            val_34 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  TryGunEndedBannerFeb2019.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TryGunEndedBannerFeb2019.<>c::丈下丛上与丐丏业丕(Rilisoft.OfferItem 东七上世万下丗丄丛));
            TryGunEndedBannerFeb2019.<>c.<>9__12_3 = val_34;
        }
        
            this.detailsCount.text = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  this.<丌丝世世上丝丄丑丄>k__BackingField.丏与丅专三丙与丘丒(), predicate:  null).Count.ToString();
            System.Action<UIWidget> val_20 = new System.Action<UIWidget>(object:  new TryGunEndedBannerFeb2019.丒丛丁与丅东丒不七(), method:  System.Void TryGunEndedBannerFeb2019.丒丛丁与丅东丒不七::业丘丟丝丅丈丏丐下(UIWidget 三丟东丕丄丄下下丑));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UIWidget>(丌丛丏业世丄丞三丌:  this.rarityColorObjects, 七丐丅专且专七三丆:  null);
        }
        
        this.price.text = this.<丌丝世世上丝丄丑丄>k__BackingField.丈世下下丅丕丐丗丁();
        decimal val_22 = this.<丌丝世世上丝丄丑丄>k__BackingField.丕丗丁七下且与丝万();
        this.oldPrice.text = BonusBankViewItem.丑丈丒丅丝丕世丞丗(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_22.flags, hi = val_22.hi, lo = val_22.lo, mid = val_22.mid}, 七丏丂丈世万丈上丕:  "F0");
        System.TimeSpan val_25 = System.TimeSpan.FromSeconds(value:  (double)WeaponManager.业丗丌下丙丗丛丝万());
        decimal val_27 = this.<丌丝世世上丝丄丑丄>k__BackingField.丐丁丒世丟世丘丌丅();
        this.description.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (val_13 != true) ? "Key_6917" : "Key_6918"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_25._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0), arg1:  Rilisoft.业丙丘丆东丈丕丂丄.丌丕七与与万业丂丁(丐丌一丈丒一丕丐丙:  new System.Decimal() {flags = val_27.flags, hi = val_27.hi, lo = val_27.lo, mid = val_27.mid}, 丅丟丏丐丅三不丗东:  true));
    }
    public void HandleBuy()
    {
        Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丈专且专丗不一专丘(丙业丞丑七丗下丟丌:  this.<丌丝世世上丝丄丑丄>k__BackingField, 且丗丅上丄丕且下上:  0);
        this.丆世与丑丆丅丐万且();
    }
    private void Awake()
    {
        this.东三世丙丁丒丝世丕();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void TryGunEndedBannerFeb2019::HandleBackgroundTapped()), 与且专丈不万东一万:  "TryGun_EndedB_annerFeb_2019");
    }
    private void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
    }
    public void HandleBackgroundTapped()
    {
        this.丆世与丑丆丅丐万且();
    }
    private void 丆世与丑丆丅丐万且()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void 东三世丙丁丒丝世丕()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private Rilisoft.业丙丘丆东丈丕丂丄 丘三丞丏丈丗东世丈()
    {
        return (Rilisoft.业丙丘丆东丈丕丂丄)this.<丌丝世世上丝丄丑丄>k__BackingField;
    }
    private void 丆丗专万万丅丒丄丈(Rilisoft.业丙丘丆东丈丕丂丄 丙业与丙丗丝不丈东)
    {
        this.<丌丝世世上丝丄丑丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public TryGunEndedBannerFeb2019()
    {
    
    }
    private bool 丆丝丄且七丆丙丘丏(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上)
    {
        return System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  丄三丅七丆丛与与上.丏与丅专三丙与丘丒(), predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  this, method:  System.Boolean TryGunEndedBannerFeb2019::丈不且丑业下丐且丁(Rilisoft.OfferItem 世万丏丛且下世丞且)));
    }
    private bool 丈不且丑业下丐且丁(Rilisoft.OfferItem 世万丏丛且下世丞且)
    {
        return System.String.op_Equality(a:  世万丏丛且下世丞且.Id, b:  this.丌丕世丞丈丒丞丈丟);
    }

}
