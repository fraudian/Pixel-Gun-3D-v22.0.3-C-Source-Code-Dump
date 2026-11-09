using UnityEngine;
private sealed class ClanWarController.丁丈丅丝一且与丄三
{
    // Fields
    public PGCompany.丂不上丗与丌与丐丌 且下丕七丙丗丄不七;
    public System.Nullable<System.DateTime> 丝丙一丝丈丂不丙一;
    
    // Methods
    public ClanWarController.丁丈丅丝一且与丄三()
    {
    
    }
    internal bool 丅丂丛不万丐专丛七(PGCompany.丟与丞丗丌丂万丕丝 三丟东丕丄丄下下丑)
    {
        ulong val_5;
        ulong val_6;
        val_5 = this;
        if(三丟东丕丄丄下下丑.不业丙丒丂丞下丆丙() != this.且下丕七丙丗丄不七)
        {
            goto label_4;
        }
        
        System.DateTime val_2 = 三丟东丕丄丄下下丑.上丟丄与丁三丌丘专();
        if(( & 1) == 0)
        {
            goto label_4;
        }
        
        val_5 = this.丝丙一丝丈丂不丙一.丐丏七丌丕丗业且上();
        val_6 = val_2.dateData;
        bool val_4 = System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_6}, t2:  new System.DateTime() {dateData = val_5});
        goto label_7;
        label_4:
        val_6 = 0;
        label_7:
        val_6 = val_6 & 1;
        return (bool)val_6;
    }

}
