using UnityEngine;
public class 业业丏业业丛丘丄丌 : 丏下丒东丅丏丌一丛
{
    // Fields
    private int 丁上丕丅丁丗丄不专;
    private bool 上丞三丐不丁丗一世;
    private int 东一下丏丂丈东丒专;
    private int 专丘且业不万丄三丑;
    private bool 丁丏丛丌丘丈业丁丌;
    
    // Properties
    public override string 丛世丗丒丕东丕丌与 { get; }
    
    // Methods
    public 业业丏业业丛丘丄丌(string 丞丅上丏丂且下丅与, string 丆丕下丄万丞丁世丛, string 丑丞丐丐不不与丘业, int 丙上一丁上专丙丐丒, int 世不丑不东与东丌丆, bool 丝丏丅丗丈丁丁万丛)
    {
        this.东一下丏丂丈东丒专 = 4294967297;
        this.专丘且业不万丄三丑 = 1;
        this.东一下丏丂丈东丒专 = 世不丑不东与东丌丆;
        this.专丘且业不万丄三丑 = 丙上一丁上专丙丐丒;
        this.丁丏丛丌丘丈业丁丌 = 丝丏丅丗丈丁丁万丛;
    }
    public override string 万东丄丅丙东丐东丏()
    {
        return (string)System.String.alignConst;
    }
    public override void 丄丌专丂丕丌丕丒三(bool 世丕与丙丄丙不丄丝)
    {
        int val_1;
        if(this.上丞三丐不丁丗一世 == true)
        {
                return;
        }
        
        if(this.东一下丏丂丈东丒专 != 1)
        {
                return;
        }
        
        val_1 = this.丁上丕丅丁丗丄不专;
        if(this.丁丏丛丌丘丈业丁丌 != false)
        {
                if(世丕与丙丄丙不丄丝 == false)
        {
            goto label_3;
        }
        
        }
        
        val_1 = val_1 + 1;
        this.丁上丕丅丁丗丄不专 = val_1;
        label_3:
        if(val_1 != this.专丘且业不万丄三丑)
        {
                return;
        }
        
        this.上丞三丐不丁丗一世 = true;
    }
    public override void 丝丌东七且丞且丛丟(int 与丙丘丗丕一上丙丐)
    {
        if(this.上丞三丐不丁丗一世 == true)
        {
                return;
        }
        
        if(this.东一下丏丂丈东丒专 != 与丙丘丗丕一上丙丐)
        {
                return;
        }
        
        int val_1 = this.丁上丕丅丁丗丄不专;
        val_1 = val_1 + 1;
        this.丁上丕丅丁丗丄不专 = val_1;
        if(val_1 != this.专丘且业不万丄三丑)
        {
                return;
        }
        
        this.上丞三丐不丁丗一世 = true;
    }
    public override bool 丑不丞丁丟与丅丄专(string 丞丁丑丏丄丏七丂不, bool 丘七与丂丑丕丙丙丘, int 且丒丛与丞世丙丕丌)
    {
        if(this.上丞三丐不丁丗一世 == false)
        {
                return false;
        }
        
        this.万丏丛东下丝下丟丕();
        return true;
    }
    public override void 丝三丂万世上丛丛丄()
    {
        this.丁上丕丅丁丗丄不专 = 0;
    }

}
