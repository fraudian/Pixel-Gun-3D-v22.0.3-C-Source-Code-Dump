using UnityEngine;
public class TrophyMagicAnimation : MonoBehaviour
{
    // Fields
    private float 丞丄丅上丆丛且丏世;
    private float 丞下上业丆丞丂万丐;
    private float 丕七丄专丁东且丂一;
    public AnimatedAlpha animatedAlpha;
    public UILabel trophyValueLabel;
    public UILabel trophyUpValue;
    public UILabel trophyDownValue;
    public SimpleTweenePlayer upTweene;
    public SimpleTweenePlayer downTweene;
    public bool isPlaying;
    public bool tweenerPlayed;
    public float playProgress;
    public float waitTimer;
    
    // Methods
    public void SetValues(float 丙东专丗上不丂丆业, float 丝三业丛丘且不丝丆, float 丗世丈丂丒丞专上丟)
    {
        this.丞丄丅上丆丛且丏世 = 丙东专丗上不丂丆业;
        this.丞下上业丆丞丂万丐 = 丝三业丛丘且不丝丆;
        this.丕七丄专丁东且丂一 = 丗世丈丂丒丞专上丟;
    }
    private void Reset()
    {
        this.isPlaying = false;
        this.tweenerPlayed = false;
        this.playProgress = 0f;
        this.waitTimer = 1f;
    }
    private void OnDestroy()
    {
        this.isPlaying = false;
        this.tweenerPlayed = false;
        this.playProgress = 0f;
        this.waitTimer = 1f;
    }
    private void Update()
    {
        float val_16;
        float val_17;
        UILabel val_18;
        float val_20;
        if(this.isPlaying == false)
        {
            goto label_1;
        }
        
        val_16 = this.waitTimer;
        float val_2 = UnityEngine.Mathf.MoveTowards(current:  val_16, target:  0f, maxDelta:  UnityEngine.Time.deltaTime);
        this.waitTimer = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        if(this.tweenerPlayed == true)
        {
            goto label_5;
        }
        
        val_17 = this.丕七丄专丁东且丂一;
        if(val_17 != 0f)
        {
            goto label_6;
        }
        
        this.upTweene.gameObject.SetActive(value:  false);
        this.downTweene.gameObject.SetActive(value:  false);
        goto label_11;
        label_1:
        if(this.animatedAlpha.alpha != 1f)
        {
                return;
        }
        
        this.playProgress = 0f;
        this.waitTimer = 1f;
        this.isPlaying = true;
        this.tweenerPlayed = false;
        return;
        label_6:
        UnityEngine.GameObject val_5 = this.upTweene.gameObject;
        if(val_17 > 0f)
        {
                val_5.SetActive(value:  true);
            this.downTweene.gameObject.SetActive(value:  false);
            val_18 = this.trophyUpValue;
            string val_8 = "+"("+") + val_17.ToString();
        }
        else
        {
                val_5.SetActive(value:  false);
            this.downTweene.gameObject.SetActive(value:  true);
            val_18 = this.trophyDownValue;
        }
        
        val_18.text = val_17.ToString();
        label_11:
        this.tweenerPlayed = true;
        this.upTweene.Play();
        this.downTweene.Play();
        label_5:
        this.trophyValueLabel.text = UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Lerp(a:  this.丞丄丅上丆丛且丏世, b:  this.丞下上业丆丞丂万丐, t:  this.playProgress)).ToString();
        val_20 = 1f;
        this.playProgress = UnityEngine.Mathf.MoveTowards(current:  this.playProgress, target:  val_20, maxDelta:  UnityEngine.Time.deltaTime);
        if(this.animatedAlpha.alpha == val_20)
        {
                return;
        }
        
        this.isPlaying = false;
        this.tweenerPlayed = false;
        this.playProgress = 0f;
        this.waitTimer = 1f;
    }
    public TrophyMagicAnimation()
    {
    
    }

}
