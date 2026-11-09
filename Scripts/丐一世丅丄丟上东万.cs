using UnityEngine;
private sealed class InfoWindowController.丐一世丅丄丟上东万 : InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    private int 东一七丟与丗三丐不;
    private string 丑世一丐一丁世丅业;
    private int 世丘且丞丘专丛丁丄;
    private int 三下丏丒专与上丝专;
    private bool 丏丏与丗一专上丆丆;
    
    // Methods
    public InfoWindowController.丐一世丅丄丟上东万(AchieveBox 不丌丗丂丆业丂丏世, PGCompany.世丐下丕专东丘丏且 丙丒七丄上与丏丙丙, bool 丏丏与丗一专上丆丆)
    {
        val_1 = new System.Object();
        mem[1152921538051452376] = 不丌丗丂丆业丂丏世;
        if(val_1 != null)
        {
                this.东一七丟与丗三丐不 = val_1.业上丙丞丐丄丆丅七();
        }
        else
        {
                this.东一七丟与丗三丐不 = 0.业上丙丞丐丄丆丅七();
        }
        
        this.丑世一丐一丁世丅业 = val_1;
        if(val_1 != null)
        {
                this.世丘且丞丘专丛丁丄 = val_1.丁丝丞与丟与丟丌三();
        }
        else
        {
                this.世丘且丞丘专丛丁丄 = 0.丁丝丞与丟与丟丌三();
        }
        
        this.三下丏丒专与上丝专 = val_1.且丆丟业丞丕丑上且();
        this.丏丏与丗一专上丆丆 = 丏丏与丗一专上丆丆;
    }
    public override void 一丌一丞世不下丄专()
    {
        string val_3;
        if(this.丏丏与丗一专上丆丆 != false)
        {
                InfoWindowController val_1 = InfoWindowController.丑七不且上丗丁一世();
            val_3 = this.丑世一丐一丁世丅业;
            val_1.freePlayTaskProgressNotification.三七万不七下不丏万(丞丟丂丄下万丈万东:  val_3);
        }
        else
        {
                InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
            val_3 = this.丑世一丐一丁世丅业;
            val_2.freePlayTaskProgressNotification.上不丕丌丄世丆丘丘(丞丟丂丄下万丈万东:  val_3, 丐丑丟丞三丐丂丛三:  this.世丘且丞丘专丛丁丄, 丗丛万下丙丕上专丌:  this.三下丏丒专与上丝专);
        }
        
        this.一丌一丞世不下丄专();
    }

}
