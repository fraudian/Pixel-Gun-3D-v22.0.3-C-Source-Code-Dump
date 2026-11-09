using UnityEngine;
public class SeasonEndAnimationEvents : MonoBehaviour
{
    // Methods
    public void AnimationEventSeasonShowStarted()
    {
        null = null;
        SeasonEndView.丄与丙丛丙丕丑专丄 = false;
    }
    public void AnimationEventSeasonShowFinished()
    {
        null = null;
        SeasonEndView.丄与丙丛丙丕丑专丄 = true;
    }
    public void AnimationEventSeasonLeagueAnyStarted()
    {
        null = null;
        SeasonEndView.丄与丙丛丙丕丑专丄 = false;
    }
    public void AnimationEventSeasonLeagueAnyFinished()
    {
        null = null;
        SeasonEndView.丄与丙丛丙丕丑专丄 = true;
    }
    public void AnimationEventLeagueStay()
    {
        UnityEngine.Object val_10;
        var val_11;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_10 = SeasonEndView.Instance;
        if(val_10 == 0)
        {
                return;
        }
        
        val_10 = SeasonEndView.Instance;
        if(val_4._leagueStaySounds == null)
        {
                return;
        }
        
        SeasonEndView val_5 = SeasonEndView.Instance;
        val_10 = val_5._leagueStaySounds;
        if(val_10 == null)
        {
                val_11 = 0;
        }
        
        if(SeasonEndView.丙丏下且丛丘丅丁丕() >= val_5._leagueStaySounds.Length)
        {
                return;
        }
        
        SeasonEndView val_7 = SeasonEndView.Instance;
        UnityEngine.AudioSource val_9 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_7._leagueStaySounds[(long)SeasonEndView.丙丏下且丛丘丅丁丕()]);
    }
    public void AnimationEventLeagueUp()
    {
        UnityEngine.Object val_6;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_6 = SeasonEndView.Instance;
        if(val_6 == 0)
        {
                return;
        }
        
        SeasonEndView val_4 = SeasonEndView.Instance;
        UnityEngine.AudioSource val_5 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_4._anyLeagueUpSound);
    }
    public void AnimationEventLeagueDown()
    {
        UnityEngine.Object val_6;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_6 = SeasonEndView.Instance;
        if(val_6 == 0)
        {
                return;
        }
        
        SeasonEndView val_4 = SeasonEndView.Instance;
        UnityEngine.AudioSource val_5 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_4._anyLeagueDownSound);
    }
    public SeasonEndAnimationEvents()
    {
    
    }

}
