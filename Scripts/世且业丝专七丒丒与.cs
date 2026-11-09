using UnityEngine;
public class 世且业丝专七丒丒与 : 丏下丒东丅丏丌一丛
{
    // Fields
    private int 上丐三丑与一丝一业;
    private int 丑丘一三丗丂东一专;
    private string 丛丘七丂且丟丁一丙;
    private int 与万丏业丞丌三专丌;
    private bool 丄丁且丏三不东丙丙;
    
    // Properties
    public override string 丛世丗丒丕东丕丌与 { get; }
    
    // Methods
    public 世且业丝专七丒丒与(string 丞丅上丏丂且下丅与, string 丆丕下丄万丞丁世丛, string 丑丞丐丐不不与丘业, string 七丆丂丂下丈且丟世, int 一丑丗三一丛一丄业, bool 且丘与丑且丟与丐世, int 且丒丛与丞世丙丕丌)
    {
        this.丑丘一三丗丂东一专 = 1;
        this.与万丏业丞丌三专丌 = 0;
        this.丛丘七丂且丟丁一丙 = System.String.alignConst;
        this.丛丘七丂且丟丁一丙 = 七丆丂丂下丈且丟世;
        this.丑丘一三丗丂东一专 = 一丑丗三一丛一丄业;
        this.丄丁且丏三不东丙丙 = 且丘与丑且丟与丐世;
        this.与万丏业丞丌三专丌 = 且丒丛与丞世丙丕丌;
    }
    public override string 万东丄丅丙东丐东丏()
    {
        return (string)this.丛丘七丂且丟丁一丙;
    }
    public override void 丄丌专丂丕丌丕丒三(bool 世丕与丙丄丙不丄丝)
    {
    
    }
    public override void 丝丌东七且丞且丛丟(int 与丙丘丗丕一上丙丐)
    {
    
    }
    public override bool 丑不丞丁丟与丅丄专(string 丞丁丑丏丄丏七丂不, bool 丘七与丂丑丕丙丙丘, int 且丒丛与丞世丙丕丌)
    {
        int val_3;
        var val_4;
        if((((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丛丘七丂且丟丁一丙)) == false) || (this.丄丁且丏三不东丙丙 == false)) || (丘七与丂丑丕丙丙丘 == false))
        {
            goto label_5;
        }
        
        val_3 = this.上丐三丑与一丝一业;
        if(this.与万丏业丞丌三专丌 != 1)
        {
                if(this.与万丏业丞丌三专丌 != 且丒丛与丞世丙丕丌)
        {
            goto label_7;
        }
        
        }
        
        val_3 = val_3 + 1;
        this.上丐三丑与一丝一业 = val_3;
        label_7:
        if(val_3 == this.丑丘一三丗丂东一专)
        {
            goto label_8;
        }
        
        label_5:
        if((System.String.op_Equality(a:  丞丁丑丏丄丏七丂不, b:  this.丛丘七丂且丟丁一丙)) == false)
        {
            goto label_10;
        }
        
        int val_3 = this.上丐三丑与一丝一业;
        val_3 = val_3 + 1;
        this.上丐三丑与一丝一业 = val_3;
        if(val_3 != this.丑丘一三丗丂东一专)
        {
            goto label_10;
        }
        
        label_8:
        this.万丏丛东下丝下丟丕();
        val_4 = 1;
        return (bool)val_4;
        label_10:
        val_4 = 0;
        return (bool)val_4;
    }
    public override void 丝三丂万世上丛丛丄()
    {
        this.上丐三丑与一丝一业 = 0;
    }

}
