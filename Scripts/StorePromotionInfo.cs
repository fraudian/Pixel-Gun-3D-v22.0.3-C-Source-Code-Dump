using UnityEngine;
internal sealed class StorePromotionInfo : StorePromotionInfoUIAbstract
{
    // Fields
    private StorePromotionInfoPanel storePromotionInfoPanel;
    private UnityEngine.Color 世下丕东七丆丆专三;
    private bool 丁丝丌丞与丑丂三上;
    private System.IDisposable 东三世丝丒三一丈丛;
    private PGCompany.UI.七万丁丞丄丛业一丌 丕丒丕七上东丌世丌;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        new System.Action() = new System.Action(object:  this, method:  typeof(StorePromotionInfo).__il2cppRuntimeField_1C0);
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "StorePromotionInfo_" + this.gameObject.name);
        UnityEngine.Color val_7 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        this.世下丕东七丆丆专三 = val_7;
        mem[1152921539302121332] = val_7.g;
        mem[1152921539302121336] = val_7.b;
        mem[1152921539302121340] = val_7.a;
        this.丁丝丌丞与丑丂三上 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
        PGCompany.丌与丛丕业丈不丐世.丅丂且三丂丟丒业丕(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void StorePromotionInfo::丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)));
    }
    protected override void OnDisable()
    {
        if(this.东三世丝丒三一丈丛 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.丁丝丌丞与丑丂三上);
        PGCompany.丌与丛丕业丈不丐世.丟丗丄丟东丆丈与丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void StorePromotionInfo::丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)));
        this.OnEnable();
    }
    protected override void 丝一丅丆三东丂丞七()
    {
        this.storePromotionInfoPanel.丈且东丑丂且万丒丅(丐丆丝业丙丈下世丁:  this.与丞丆丑东东丟丆丌());
    }
    internal override void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, object 一丐丗丁丞丆丅丟丄, PGCompany.丞丙上世丑丕与丁丁 且丒丛与丞世丙丕丌 = 0)
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_3;
        PGCompany.UI.七万丁丞丄丛业一丌 val_4;
        val_3 = 且丘丏丁丑与丙与丁;
        this.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  val_3, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 且丒丛与丞世丙丕丌:  0);
        val_4 = this.丕丒丕七上东丌世丌;
        if(val_4 == null)
        {
                val_3 = this.transform;
            PGCompany.UI.七万丁丞丄丛业一丌 val_2 = null;
            val_4 = val_2;
            val_2 = new PGCompany.UI.七万丁丞丄丛业一丌(七万上丐一丈丏丏专:  val_3);
            this.丕丒丕七上东丌世丌 = val_4;
        }
        
        val_2.丒上丁丄丛上丅丁且();
    }
    internal override void 丆世与丑丆丅丐万且()
    {
        if(this.丕丒丕七上东丌世丌 != null)
        {
                this.丕丒丕七上东丌世丌.Dispose();
            this.丕丒丕七上东丌世丌 = 0;
        }
        
        this.丆世与丑丆丅丐万且();
    }
    private void 丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)
    {
        goto typeof(StorePromotionInfo).__il2cppRuntimeField_1B8;
    }
    public StorePromotionInfo()
    {
    
    }

}
