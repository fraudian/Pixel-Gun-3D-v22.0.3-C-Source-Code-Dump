using UnityEngine;
private sealed class InfoWindowController.丆丂专专丐万丅专三 : InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    private readonly string 三丄丗世丄丒丟丒丞;
    private readonly int 丗专不丒丕丐丐不丗;
    private readonly string 丐丗万世丕业丘不且;
    
    // Methods
    public InfoWindowController.丆丂专专丐万丅专三(AchieveBox 不丌丗丂丆业丂丏世, string 三丕业丛丛丙专专丙, string 丐一三丞丝丌不丏丑, int 丄东七丄一丄万丕丟)
    {
        int val_2 = val_1;
        val_1 = new System.Object();
        mem[1152921538052027352] = 不丌丗丂丆业丂丏世;
        if(val_2 == null)
        {
                val_2 = System.String.alignConst;
        }
        
        this.三丄丗世丄丒丟丒丞 = val_2;
        this.丐丗万世丕业丘不且 = 丐一三丞丝丌不丏丑;
        this.丗专不丒丕丐丐不丗 = 丄东七丄一丄万丕丟;
    }
    public override void 一丌一丞世不下丄专()
    {
        InfoWindowController val_1 = InfoWindowController.丑七不且上丗丁一世();
        if(val_1._squadMessagePanel == 0)
        {
                return;
        }
        
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        val_3._squadMessagePanel.业东三丒丝丐丏丐且(不丆业丏上丐与丌业:  this.三丄丗世丄丒丟丒丞, 丅一丞万丑专丅丅与:  this.丐丗万世丕业丘不且, 丄东七丄一丄万丕丟:  this.丗专不丒丕丐丐不丗);
        this.一丌一丞世不下丄专();
    }

}
