using UnityEngine;
internal sealed class TimerBox : MonoBehaviour
{
    // Fields
    private string 丂丘业万丅丛丞丐丗;
    private int 丁丞下丞丐丈丟业丅;
    private float _oneSecondAccumulator;
    public UnityEngine.GameObject[] ObjectsForTimerEnabled;
    public UnityEngine.GameObject[] ObjectsForTimerDisabled;
    public int Time;
    public Rilisoft.TextGroup TimeText;
    public Rilisoft.TextGroup Title;
    public Rilisoft.TextGroup TitleLarge;
    
    // Methods
    internal void 丒丁丅一下丂专万不(string 丕丗丘丑丛与丑业丒)
    {
        this.Title.Text = 丕丗丘丑丛与丑业丒;
        this.TitleLarge.Text = 丕丗丘丑丛与丑业丒;
    }
    internal void 与丕丞一丐七专丗下(float 丂三丟丂丈丐丆丗丟)
    {
        this.Time = (int)丂三丟丂丈丐丆丗丟;
        this.丁丞下丞丐丈丟业丅 = 0;
        this._oneSecondAccumulator = 0f;
    }
    internal void 与丕丞一丐七专丗下(float 丂三丟丂丈丐丆丗丟, string 丕丂丐丌丆丝且万丗)
    {
        this.Time = (int)丂三丟丂丈丐丆丗丟;
        this.丂丘业万丅丛丞丐丗 = 丕丂丐丌丆丝且万丗;
        this.丁丞下丞丐丈丟业丅 = 0;
        this._oneSecondAccumulator = 0f;
    }
    internal void 丛丟丌丛上丟世上世(bool 丙丝丒丘东一下丁丁)
    {
        丙丝丒丘东一下丁丁 = 丙丝丒丘东一下丁丁;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.ObjectsForTimerEnabled, 丏业丟一东丂东丘丛:  丙丝丒丘东一下丁丁);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.ObjectsForTimerDisabled, 丏业丟一东丂东丘丛:  (~丙丝丒丘东一下丁丁) & 1);
    }
    private void Update()
    {
        string val_6;
        int val_7;
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = this._oneSecondAccumulator + val_1;
        val_6 = this;
        this._oneSecondAccumulator = val_1;
        if(val_1 > 1f)
        {
                val_1 = val_1 + (-1f);
            val_7 = this.Time - 1;
            this._oneSecondAccumulator = val_1;
            this.Time = val_7;
        }
        else
        {
                val_7 = this.Time;
        }
        
        if(val_7 <= 0)
        {
            goto label_3;
        }
        
        if(this.丁丞下丞丐丈丟业丅 == val_7)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丂丘业万丅丛丞丐丗)) == false)
        {
            goto label_7;
        }
        
        string val_3 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.Time, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        goto label_10;
        label_3:
        this.丆世与丑丆丅丐万且();
        return;
        label_7:
        label_10:
        val_6 = System.String.Format(format:  this.丂丘业万丅丛丞丐丗, arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.Time, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        this.TimeText.Text = val_6;
        this.丁丞下丞丐丈丟业丅 = this.Time;
    }
    private void 丆世与丑丆丅丐万且()
    {
        InfoWindowController.丑七不且上丗丁一世().HideTimerBox();
    }
    public TimerBox()
    {
    
    }

}
