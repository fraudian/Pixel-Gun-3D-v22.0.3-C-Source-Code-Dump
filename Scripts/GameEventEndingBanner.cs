using UnityEngine;
internal sealed class GameEventEndingBanner : SimpleBunner
{
    // Fields
    private PGCompany.TimerUI timerUi;
    private UILabel text;
    private UILabel description;
    private Rilisoft.丛且世丐丆上七业丁 且丞丂丐不丐不丂丒;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
    {
        this.且丞丂丐不丐不丂丒 = 丅东专与不三丂丁丝;
        this.丝丂丕东专世丅丝丁();
    }
    private void 丝丂丕东专世丅丝丁()
    {
        PGCompany.TimerUI val_9;
        int val_10;
        if(this.且丞丂丐不丐不丂丒 != null)
        {
                val_9 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丑世丙丅丙丟业丕丌(丂不世丒世丕丁丝与:  this.且丞丂丐不丐不丂丒.丅丙丛丑丌丆丌丕丒());
        }
        else
        {
                val_9 = 0;
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        if((val_9 & 1) == 0)
        {
            goto label_7;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        System.Nullable<System.TimeSpan> val_5 = this.且丞丂丐不丐不丂丒.丙世丑丅丒丑业与不();
        if(((-1542379392) & 1) == 0)
        {
            goto label_11;
        }
        
        System.Nullable<System.TimeSpan> val_6 = this.且丞丂丐不丐不丂丒.丙世丑丅丒丑业与不();
        val_10 = (int)val_6.HasValue.TotalSeconds;
        goto label_13;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
        return;
        label_11:
        val_10 = 0;
        label_13:
        val_9 = this.timerUi;
        val_9.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  0, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void GameEventEndingBanner::丝丂丕东专世丅丝丁()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
    }
    public override void Hide()
    {
        Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().下丏丆不丛丁上丆七(丂不世丒世丕丁丝与:  this.且丞丂丐不丐不丂丒.丅丙丛丑丌丆丌丕丒());
        this.Hide();
    }
    public GameEventEndingBanner()
    {
    
    }

}
