using UnityEngine;
private sealed class FortsManager.丂世丁下东业丘且七
{
    // Fields
    public System.Action 万世丌东丑且丏丅丏;
    public System.Action 丟业丌丅丆与万丈丛;
    public Rilisoft.FortsManager 丝且与丝丒丟万丁专;
    public Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七;
    public Rilisoft.FortItemState 丏业丟一东丂东丘丛;
    
    // Methods
    public FortsManager.丂世丁下东业丘且七()
    {
    
    }
    internal void 业丗丒上丁丐丏业丌()
    {
        var val_5;
        System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐> val_6;
        PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.业与且丆丄专丆专丝(丙业与丙丗丝不丈东:  this.万世丌东丑且丏丅丏);
        PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.丄三丐上丈且丄丘下(丙业与丙丗丝不丈东:  this.丟业丌丅丆与万丈丛);
        Rilisoft.一丟专且三万丞丁丂.丝丄丙丏一下丏丐丛(丞一丁业丄一一业且:  this.丝且与丝丒丟万丁专.丟丑丒丂万丟专丁万().业上丙丞丐丄丆丅七());
        this.丝且与丝丒丟万丁专.世上丁丏世万且下业();
        this.丝且与丝丒丟万丁专.丄且专与丌专丁丒丒 = false;
        val_5 = null;
        val_5 = null;
        val_6 = Rilisoft.FortsManager.丘丐丟丑丈丗丟专下;
        if(val_6 == null)
        {
                return;
        }
        
        val_6 = Rilisoft.FortsManager.丘丐丟丑丈丗丟专下;
        val_6.Invoke(arg1:  this.丝且与丝丒丟万丁专.丟丑丒丂万丟专丁万(), arg2:  this.丝且与丝丒丟万丁专.丏世丛丂与丐丟与丏());
    }
    internal void 丕丆丟丂与且丏七专()
    {
        var val_3;
        PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.业与且丆丄专丆专丝(丙业与丙丗丝不丈东:  this.万世丌东丑且丏丅丏);
        PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.丄三丐上丈且丄丘下(丙业与丙丗丝不丈东:  this.丟业丌丅丆与万丈丛);
        this.丝且与丝丒丟万丁专.丌丘丘上三丅丆不丝(丙业与丙丗丝不丈东:  0);
        this.丝且与丝丒丟万丁专.丐与丙丏业且丏丛万(丙业与丙丗丝不丈东:  0);
        if(this.下丅丙一丂丗丅丝七.丁丞一不不丗丕丟丛().Count <= 1)
        {
                this.丏业丟一东丂东丘丛.CraftStarted = 0;
        }
        else
        {
                this.丏业丟一东丂东丘丛.CraftStartedV2 = 0;
        }
        
        this.丏业丟一东丂东丘丛.CraftSlot = 0;
        this.丝且与丝丒丟万丁专.丄且专与丌专丁丒丒 = false;
        val_3 = null;
        val_3 = null;
        Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.丄东丘七世世丞不丛();
    }

}
