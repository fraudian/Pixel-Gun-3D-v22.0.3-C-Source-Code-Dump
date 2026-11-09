using UnityEngine;
internal sealed class VeteranLootBoxView : ItemLootBoxView
{
    // Fields
    private UILabel progressLabel;
    private System.Collections.Generic.List<UISprite> progressBar;
    
    // Methods
    protected override void 丑丏上丈丒丂且丞丛()
    {
        this.丑丏上丈丒丂且丞丛();
        new System.Action() = new System.Action(object:  this, method:  typeof(VeteranLootBoxView).__il2cppRuntimeField_1C0);
        ExpController.一丈与丒丘下七丛丗(丙业与丙丗丝不丈东:  new System.Action());
    }
    protected override void 丌丞下万丈丒丑万丅()
    {
        this.丌丞下万丈丒丑万丅();
        new System.Action() = new System.Action(object:  this, method:  typeof(VeteranLootBoxView).__il2cppRuntimeField_1C0);
        ExpController.丄丂一丛丅丄丄丘且(丙业与丙丗丝不丈东:  new System.Action());
    }
    internal override void 丝一丅丆三东丂丞七()
    {
        this.丝一丅丆三东丂丞七();
        this.丒丙丅万丝不上一上();
    }
    private void 丒丙丅万丝不上一上()
    {
        int val_2 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丑一专与丝丏丂丆上();
        int val_5 = System.Math.Min(val1:  ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丅丂七上一业一丐三(), val2:  val_2);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.progressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  System.String.Format(format:  "{0}/{1}", arg0:  val_5, arg1:  val_2)));
        float val_9 = (float)val_5;
        val_9 = val_9 / (float)val_2;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(丄丁一丐丕与丝一丈:  this.progressBar, 丙业与丙丗丝不丈东:  val_9);
    }
    public VeteranLootBoxView()
    {
    
    }

}
