using UnityEngine;
internal class ExchangeBankViewItem : AbstractBankViewItem
{
    // Fields
    public UILabel countLabel;
    
    // Methods
    public override void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丑业丄不丏丏丒丗丏)
    {
        this.Setup(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞, 上业一丄三与丂丄丏:  上业一丄三与丂丄丏, 丆不丁且丙丅丂专丟:  丆不丁且丙丅丂专丟, 七一丂丟东丟万丙丘:  七一丂丟东丟万丙丘, 丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丕东不丐世丕丐万上:  丕东不丐世丕丐万上, 丄丆丘丏万三丞丐丏:  丄丆丘丏万三丞丐丏, 丛与世且丑丅丟下丛:  丑业丄不丏丏丒丗丏);
        this.countLabel.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丆不丁且丙丅丂专丟.丏业丁七世丆七上丑());
        this.countLabel.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丆不丁且丙丅丂专丟.丕丛下丘上丆丘专丁());
        goto typeof(ExchangeBankViewItem).__il2cppRuntimeField_1F8;
    }
    protected override void OnEnable()
    {
    
    }
    protected override void OnDisable()
    {
    
    }
    protected override void 丞业与下丛万丁下丙()
    {
        UnityEngine.Texture val_4 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Textures/Bank/Coins_Shop_"("Textures/Bank/Coins_Shop_") + this.ExchangeInfo.丒不丟丒丁丗丒丕丑());
        if(this != null)
        {
                return;
        }
    
    }
    public ExchangeBankViewItem()
    {
    
    }

}
