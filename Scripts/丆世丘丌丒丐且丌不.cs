using UnityEngine;
private sealed class InfoWindowController.丆世丘丌丒丐且丌不 : InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    private ChallengeProgressAchieveBox 东丏丘丁丌专业丅丟;
    public int 下丅丛不丄丙专丆下;
    public string 不三世丏丙丁与丑丒;
    public int 丙与丙丌丘丐三丆丙;
    
    // Methods
    public InfoWindowController.丆世丘丌丒丐且丌不(AchieveBox 不丌丗丂丆业丂丏世)
    {
        ChallengeProgressAchieveBox val_3;
        this = new System.Object();
        mem[1152921538057141752] = 不丌丗丂丆业丂丏世;
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
        this.东丏丘丁丌专业丅丟.上不丕丌丄世丆丘丘(丏上丁丅丗三丁丂三:  this.丙与丙丌丘丐三丆丙, 上丞丕专丈业丁世专:  this.下丅丛不丄丙专丆下);
        this.一丌一丞世不下丄专();
    }

}
