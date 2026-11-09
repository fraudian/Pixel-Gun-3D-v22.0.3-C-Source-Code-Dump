using UnityEngine;
internal class LootBoxUI_RouletteListener : LootBoxUI_Listener
{
    // Fields
    private LootBoxRewardsView_Roulette 且万丘丙世专上丄丒;
    private PGCompany.三东丏不丗世丅丌丄 <万丘丑丁且万丆丈且>k__BackingField;
    
    // Properties
    internal LootBoxRewardsView_Roulette 下不业丙三丌丏丏丁 { get; }
    internal PGCompany.三东丏不丗世丅丌丄 专一丟丆专丟一世一 { get; set; }
    
    // Methods
    internal LootBoxRewardsView_Roulette 丛东专七丞下丕丙丐()
    {
        LootBoxRewardsView_Roulette val_3;
        if(this.且万丘丙世专上丄丒 == 0)
        {
                var val_2 = (0 == null) ? UnityEngine.Object.__il2cppRuntimeField_cctor_finished : 0;
        }
        else
        {
                val_3 = this.且万丘丙世专上丄丒;
            return (LootBoxRewardsView_Roulette);
        }
        
        this.且万丘丙世专上丄丒 = ;
        return (LootBoxRewardsView_Roulette);
    }
    internal PGCompany.三东丏不丗世丅丌丄 丕丟丐丈丐丄丌三丐()
    {
        return (PGCompany.三东丏不丗世丅丌丄)this.<万丘丑丁且万丆丈且>k__BackingField;
    }
    private void 丌世一丛与丒七丗丄(PGCompany.三东丏不丗世丅丌丄 丙业与丙丗丝不丈东)
    {
        this.<万丘丑丁且万丆丈且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    protected override void 丑丏上丈丒丂且丞丛()
    {
        this.丑丏上丈丒丂且丞丛();
        new System.Action() = new System.Action(object:  this, method:  typeof(LootBoxUI_RouletteListener).__il2cppRuntimeField_280);
        this.丛东专七丞下丕丙丐().丐丗世三丝丞专三一(丙业与丙丗丝不丈东:  new System.Action());
        this.丛东专七丞下丕丙丐().且下业丝三丘丆丕丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_RouletteListener).__il2cppRuntimeField_290));
        this.丛东专七丞下丕丙丐().丁丒丏专且丌三丞丗(丙业与丙丗丝不丈东:  new System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>(object:  this, method:  typeof(LootBoxUI_RouletteListener).__il2cppRuntimeField_2A0));
    }
    protected override void 丌丞下万丈丒丑万丅()
    {
        this.丌丞下万丈丒丑万丅();
        new System.Action() = new System.Action(object:  this, method:  typeof(LootBoxUI_RouletteListener).__il2cppRuntimeField_280);
        this.丛东专七丞下丕丙丐().丝丈专且丆业一丄丂(丙业与丙丗丝不丈东:  new System.Action());
        this.丛东专七丞下丕丙丐().丘丙丅丄丘七丘且丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(LootBoxUI_RouletteListener).__il2cppRuntimeField_290));
        this.丛东专七丞下丕丙丐().丒丆丐丝丝丝专七丈(丙业与丙丗丝不丈东:  new System.Action<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>(object:  this, method:  typeof(LootBoxUI_RouletteListener).__il2cppRuntimeField_2A0));
    }
    protected virtual void 丘下丟丁上丏丛且且()
    {
        if((X20 + 144) != 0)
        {
                return;
        }
        
        if((this.<万丘丑丁且万丆丈且>k__BackingField) == this.丛东专七丞下丕丙丐().丕丟丐丈丐丄丌三丐())
        {
                return;
        }
        
        this.<万丘丑丁且万丆丈且>k__BackingField = this.丛东专七丞下丕丙丐().丕丟丐丈丐丄丌三丐();
    }
    protected virtual void 东丕丞丈东丟丝丂丅()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "[LootBoxUI] Listener - OnPreDropItem");
        丐丐七丒丄丘丙专丞(丑丙丙丕与丂丐丘一:  0);
    }
    protected virtual void 与世万丄一丑丒丞世(PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 丘丂丅且丄丑丞万丟)
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "[LootBoxUI] Listener - OnDropItem");
    }
    public LootBoxUI_RouletteListener()
    {
        mem[1152921537737286264] = 1082130432;
        val_1 = new PGBehaviour();
    }

}
