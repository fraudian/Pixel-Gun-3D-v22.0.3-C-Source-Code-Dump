using UnityEngine;
internal abstract class PromotionViewAbstract : PGBehaviour, 丁丈丏万且丛丆丁七
{
    // Fields
    private PGCompany.东丑丆丗丏丐丟下丄 <丒丄丙世且丑丑丄不>k__BackingField;
    
    // Properties
    internal PGCompany.东丑丆丗丏丐丟下丄 丒丁丝与且丂且丐丝 { get; set; }
    
    // Methods
    internal PGCompany.东丑丆丗丏丐丟下丄 与丞丆丑东东丟丆丌()
    {
        return (PGCompany.东丑丆丗丏丐丟下丄)this.<丒丄丙世且丑丑丄不>k__BackingField;
    }
    private void 丛丐丟万丐世万丏丌(PGCompany.东丑丆丗丏丐丟下丄 丙业与丙丗丝不丈东)
    {
        this.<丒丄丙世且丑丑丄不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public virtual void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.<丒丄丙世且丑丑丄不>k__BackingField = 且丘丏丁丑与丙与丁;
    }
    protected void 且丞丝丑丛一丝七丞(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.<丒丄丙世且丑丑丄不>k__BackingField = 且丘丏丁丑与丙与丁;
    }
    public void U_Gift()
    {
        if((this.<丒丄丙世且丑丑丄不>k__BackingField.三丛丈且与丒丙丟丟()) == false)
        {
                return;
        }
        
        this.<丒丄丙世且丑丑丄不>k__BackingField.丐丗丛万丙丏丗丌丐();
    }
    public virtual void TryPurchase()
    {
        var val_14;
        var val_15;
        PGCompany.东丑丆丗丏丐丟下丄 val_16;
        var val_17;
        var val_18;
        var val_19;
        val_14 = this;
        if((this.<丒丄丙世且丑丑丄不>k__BackingField) == null)
        {
                return;
        }
        
        val_15 = 0;
        val_16 = this.<丒丄丙世且丑丑丄不>k__BackingField;
        val_17 = this.<丒丄丙世且丑丑丄不>k__BackingField.且丏三丞丝丟丘丅丕();
        if(val_16 == null)
        {
            goto label_2;
        }
        
        if(val_17 == false)
        {
            goto label_3;
        }
        
        label_4:
        val_16.丈丙且一万丟丕万下();
        val_16 = ???;
        val_18 = ???;
        val_17 = ???;
        goto typeof(PromotionViewAbstract).__il2cppRuntimeField_1A8;
        label_2:
        if((val_17 & 1) != 0)
        {
            goto label_4;
        }
        
        label_3:
        if((((val_16 == 0) || ((val_18 + 72.业东丅东丌上丗丑不()) == 17015)) || ((val_18 + 72.业东丅东丌上丗丑不()) == 11015)) || ((PGCompany.万丞丘与丕丞下万丌.丈三世丆丙丄丌东丗(丈丄不七三万丄丁不:  val_18 + 72)) == true))
        {
            goto label_15;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(上丙且丙丏万丄上业:  val_18 + 72, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_18;
        }
        
        label_15:
        val_19 = mem[val_18 + 72];
        val_19 = val_18 + 72;
        val_19.丏丝丘七丕与世丅丆();
        return;
        label_18:
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Cant purchase promotion, not enough currency: \'{0}\'", arg0:  val_18 + 72));
    }
    internal abstract bool 丝一丅丆三东丂丞七(); // 0
    internal abstract void 丐丌丘不上且东业丘(); // 0
    internal abstract void 丌丆丌且丘丝丝丑丄(); // 0
    internal abstract void 世世丑丞丒丟业丁与(); // 0
    protected PromotionViewAbstract()
    {
    
    }

}
