using UnityEngine;
internal sealed class ChallengeProgressAchieveBox : AchieveBox
{
    // Fields
    public UIProgressBar ProgressBar;
    public Rilisoft.TextGroup ProgressText;
    public Rilisoft.TextGroup Title;
    
    // Methods
    internal void 丒一丝与丏丝万丘且(string 丕丗丘丑丛与丑业丒)
    {
        this.Title.Text = 丕丗丘丑丛与丑业丒;
    }
    internal void 上不丕丌丄世丆丘丘(int 丏上丁丅丗三丁丂三, int 上丞丕专丈业丁世专)
    {
        this.ProgressText.Text = System.String.Format(format:  "{0}/{1}", arg0:  上丞丕专丈业丁世专, arg1:  丏上丁丅丗三丁丂三);
        if(丏上丁丅丗三丁丂三 == 0)
        {
            goto label_2;
        }
        
        if(this.ProgressBar != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.ProgressBar.value = (float)上丞丕专丈业丁世专 / (float)丏上丁丅丗三丁丂三;
        return;
        label_2:
        if(this.ProgressBar != null)
        {
            goto label_4;
        }
        
        goto label_5;
    }
    public ChallengeProgressAchieveBox()
    {
    
    }

}
