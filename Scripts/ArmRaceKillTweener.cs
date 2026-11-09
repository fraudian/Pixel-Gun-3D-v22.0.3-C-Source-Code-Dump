using UnityEngine;
internal sealed class ArmRaceKillTweener : PGBehaviour
{
    // Fields
    private SimpleTweenePlayer tweenAnimationOnKill;
    private UnityEngine.AudioSource killAudio;
    private bool 丝世丞一丒丗丗丕且;
    
    // Methods
    public void PlayKillAnimation()
    {
        if(this.killAudio == 0)
        {
                return;
        }
        
        this.丝世丞一丒丗丗丕且 = true;
        this.killAudio.Play();
        this.tweenAnimationOnKill.Play();
    }
    private void Start()
    {
        this.GetComponent<UIPanel>().enabled = true;
    }
    private void Update()
    {
    
    }
    private void OnEnable()
    {
        if(this.tweenAnimationOnKill == null)
        {
            goto label_0;
        }
        
        if(this.丝世丞一丒丗丗丕且 == false)
        {
            goto label_1;
        }
        
        label_2:
        this.tweenAnimationOnKill.SetFinal();
        return;
        label_0:
        if(this.丝世丞一丒丗丗丕且 == true)
        {
            goto label_2;
        }
        
        label_1:
        this.tweenAnimationOnKill.SetInitial();
    }
    public ArmRaceKillTweener()
    {
    
    }

}
