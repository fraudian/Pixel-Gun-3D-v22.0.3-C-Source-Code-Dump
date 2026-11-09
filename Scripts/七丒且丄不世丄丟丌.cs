using UnityEngine;
private sealed class InfoWindowController.七丒且丄不世丄丟丌 : InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    private PGCompany.ClanWarTaskDoneAchieveBox 东丏丘丁丌专业丅丟;
    public string 不三世丏丙丁与丑丒;
    public string 下丄丈不与世丐业专;
    public bool 下丟丂丌丛丁上上丑;
    
    // Methods
    public InfoWindowController.七丒且丄不世丄丟丌(AchieveBox 不丌丗丂丆业丂丏世)
    {
        PGCompany.ClanWarTaskDoneAchieveBox val_3;
        this = new System.Object();
        mem[1152921538053193688] = 不丌丗丂丆业丂丏世;
        if(不丌丗丂丆业丂丏世 != null)
        {
                var val_2 = (null == null) ? 不丌丗丂丆业丂丏世 : 0;
        }
        else
        {
                val_3 = 0;
        }
        
        this.东丏丘丁丌专业丅丟 = val_3;
    }
    public override void 一丌一丞世不下丄专()
    {
        this.东丏丘丁丌专业丅丟.丒一丝与丏丝万丘且(丕丗丘丑丛与丑业丒:  this.不三世丏丙丁与丑丒);
        this.东丏丘丁丌专业丅丟.三丆丐与丛一丈不丕(丞丅上丏丂且下丅与:  this.下丄丈不与世丐业专);
        this.东丏丘丁丌专业丅丟.一不与丂丞丛丁丝丐(丐万丗丒下七丟丁三:  (this.下丟丂丌丛丁上上丑 == true) ? 1 : 0);
        this.一丌一丞世不下丄专();
    }

}
