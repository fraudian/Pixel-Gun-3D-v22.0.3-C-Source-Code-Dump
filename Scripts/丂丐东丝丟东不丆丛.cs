using UnityEngine;
internal sealed class 丂丐东丝丟东不丆丛 : 丝一七万丗不丄丒上
{
    // Fields
    private Rilisoft.丝丑丂丛万丐丈丘且 丗丝丝丑丌丌丑一万;
    private readonly string <且丈丁专东丆丄丂与>k__BackingField;
    
    // Properties
    internal override string 丒三丝一上丙专丗丒 { get; }
    
    // Methods
    public 丂丐东丝丟东不丆丛(int 丟丟丄专上丟丁丐丝, System.Collections.Generic.List<string> 丗丟上上丒丐丗丞丙, PGCompany.GameModeEvents.GMERewardConditionProgress 上丕丈丞丌丘丅不与)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
        this.丗丝丝丑丌丌丑一万 = val_1;
        mem[1152921537676806128] = val_1.上万三丆专丏丒丗业;
    }
    public override void 丈且东丑丂且万丒丅()
    {
        this.丈且东丑丂且万丒丅();
        if(Count >= 1)
        {
                if((System.Int32.TryParse(s:  Item[0], result: out  0)) != false)
        {
                Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            this.丗丝丝丑丌丌丑一万 = val_5;
            mem[1152921537676939632] = val_5.上万三丆专丏丒丗业;
            Rilisoft.丝丑丂丛万丐丈丘且 val_6 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            this.丅丐下丌丅丛且丁丛(丙业与丙丗丝不丈东:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_6.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_6.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_6.上万三丆专丏丒丗业});
        }
        
        }
        
        if(this.丑丑丏丁丗丏丘七一() != 0)
        {
                return;
        }
        
        int val_8 = Points;
        if(val_8 >= this.丗丝丝丑丌丌丑一万)
        {
                val_8.CompleteResult = 1;
            mem[1152921537676939600] = 0;
        }
        
        RatingSystem.丁丐丙三丁丄丄七世(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void 丂丐东丝丟东不丆丛::丆丏丏丘丗丒万丗丛(int 丙业与丙丗丝不丈东)));
        RatingSystem.世上且丑丞万丗丐丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void 丂丐东丝丟东不丆丛::丆丏丏丘丗丒万丗丛(int 丙业与丙丗丝不丈东)));
    }
    private void 丆丏丏丘丗丒万丗丛(int 丙业与丙丗丝不丈东)
    {
        var val_14;
        var val_15;
        var val_16;
        val_14 = 1152921505066536960;
        val_15 = null;
        val_15 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕 == null)
        {
                return;
        }
        
        val_14 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  this.丅东丄丛上丁丐万丏());
        if(val_14 == null)
        {
                return;
        }
        
        if(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三丆丌上丄丁万丞丈() == null)
        {
                return;
        }
        
        val_14 = val_14.业上丙丞丐丄丆丅七();
        if(val_14 != PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三丆丌上丄丁万丞丈().业上丙丞丐丄丆丅七())
        {
                return;
        }
        
        if(GameConnect.丈丝丂丐丟万丙丑丕 == null)
        {
                return;
        }
        
        if(val_14 != 0)
        {
                val_16 = val_14.Points;
        }
        else
        {
                val_16 = 0.Points;
        }
        
        val_14.Points = val_16 + 丙业与丙丗丝不丈东;
        int val_13 = 丙业与丙丗丝不丈东.Points;
        if(val_13 >= this.丗丝丝丑丌丌丑一万)
        {
                val_13.CompleteResult = 1;
            mem[1152921537677088464] = 0;
        }
        
        this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  true, 丂丂丟丘丆东丟丄丒:  true);
    }
    internal override string 不业丙丒丂丞下丆丙()
    {
        return (string)this.<且丈丁专东丆丄丂与>k__BackingField;
    }
    public override string 丙丄上丆丝丂丘专丒()
    {
        return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8940"), arg0:  X21.Points + "/"("/") + this);
    }
    public override string 与丏丞丟丆七丈丐上()
    {
        if(CompleteResult != 2)
        {
                return (string)System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8941"), arg0:  this);
        }
        
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6508");
    }
    public override string 丂丌丐丕丝不且丏丅()
    {
        if(CompleteResult != 2)
        {
                return (string)System.String.Format(format:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_8941"), arg0:  this);
        }
        
        return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_6508");
    }
    public override int 丘且丘下丁丑丗且丒()
    {
    
    }
    public override bool 万且丏丂下丘丄不丑()
    {
        return false;
    }

}
