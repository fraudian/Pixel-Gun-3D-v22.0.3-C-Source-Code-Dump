using UnityEngine;
internal class ProgressBarUI : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _holder;
    private UnityEngine.GameObject _holderBar;
    private UISprite _progressBar;
    private UISprite _progressBackBar;
    private UILabel _currentResult;
    private UISprite _iconWithBar;
    private UISprite _icon;
    private UILabel _taskLabel;
    private bool 丕丄万丑丛且丅且丂;
    private float 丝丏丟丟丏丒丒东丙;
    private float 丏丏丏一与下丁三丄;
    
    // Methods
    internal void 丙业丙与丗丅丂且丌(float 丗与丘不且万丟丙丑, string 上丕丈丞丌丘丅不与, UnityEngine.Color 丑丞丈丗丄丙丟万丄, bool 丘丏丑丁专上世丄不, string 丄一三上七丐专与丘, string 三世丏且丑下专丟丟)
    {
        this._holder.SetActive(value:  true);
        this._progressBar.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this._holderBar.SetActive(value:  丘丏丑丁专上世丄不);
        this._iconWithBar.gameObject.SetActive(value:  丘丏丑丁专上世丄不);
        this._icon.gameObject.SetActive(value:  (~丘丏丑丁专上世丄不) & 1);
        this._taskLabel.text = 丄一三上七丐专与丘;
        this._icon.spriteName = 三世丏且丑下专丟丟;
        this._iconWithBar.spriteName = 三世丏且丑下专丟丟;
        this.丙上丟丏且丐丌不丒(丗与丘不且万丟丙丑:  丗与丘不且万丟丙丑, 上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与);
    }
    internal void 且丞丆与万世万丌丟()
    {
        this._holder.SetActive(value:  false);
    }
    internal void 东万丗丄丕丞丑丌丆()
    {
    
    }
    internal void 丙上丟丏且丐丌不丒(float 丗与丘不且万丟丙丑, string 上丕丈丞丌丘丅不与)
    {
        this._progressBar.fillAmount = 丗与丘不且万丟丙丑;
        this._currentResult.text = 上丕丈丞丌丘丅不与;
        this.丝丏丟丟丏丒丒东丙 = 丗与丘不且万丟丙丑;
    }
    internal void 丝业不业丂上丒丒丄(float 丗与丘不且万丟丙丑, string 上丕丈丞丌丘丅不与, UnityEngine.Color 不业不丗丏丘三与万)
    {
        UISprite val_4;
        this.丕丄万丑丛且丅且丂 = (this.丝丏丟丟丏丒丒东丙 < 0) ? 1 : 0;
        if(this.丝丏丟丟丏丒丒东丙 >= 0)
        {
            goto label_1;
        }
        
        if(this._progressBackBar == 0)
        {
            goto label_4;
        }
        
        val_4 = this._progressBackBar;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_1:
        val_4 = this._progressBar;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        val_4.fillAmount = 丗与丘不且万丟丙丑;
        label_4:
        this.丝丏丟丟丏丒丒东丙 = 丗与丘不且万丟丙丑;
        this._currentResult.text = 上丕丈丞丌丘丅不与;
        if(this._progressBackBar == 0)
        {
                return;
        }
        
        this._progressBackBar.color = new UnityEngine.Color() {r = 不业不丗丏丘三与万.r, g = 不业不丗丏丘三与万.g, b = 不业不丗丏丘三与万.b, a = 不业不丗丏丘三与万.a};
    }
    private void Update()
    {
        if(this.丕丄万丑丛且丅且丂 != false)
        {
                this.七与丛一丛东专下丂(丒上万东三丑三丙丁:  this._progressBackBar, 且丏丂丙丈丞丐东上:  this._progressBar);
            return;
        }
        
        this.七与丛一丛东专下丂(丒上万东三丑三丙丁:  this._progressBar, 且丏丂丙丈丞丐东上:  this._progressBackBar);
    }
    private void 七与丛一丛东专下丂(UISprite 丒上万东三丑三丙丁, UISprite 且丏丂丙丈丞丐东上)
    {
        if(且丏丂丙丈丞丐东上 == 0)
        {
                return;
        }
        
        if(且丏丂丙丈丞丐东上 == 0)
        {
                return;
        }
        
        且丏丂丙丈丞丐东上.fillAmount = UnityEngine.Mathf.Lerp(a:  且丏丂丙丈丞丐东上.fillAmount, b:  丒上万东三丑三丙丁.fillAmount, t:  this.丏丏丏一与下丁三丄 * UnityEngine.Time.deltaTime);
    }
    internal void 丙上丟丏且丐丌不丒(UnityEngine.Color 丘上丄东丁丟丙一与)
    {
        this._progressBar.color = new UnityEngine.Color() {r = 丘上丄东丁丟丙一与.r, g = 丘上丄东丁丟丙一与.g, b = 丘上丄东丁丟丙一与.b, a = 丘上丄东丁丟丙一与.a};
    }
    public ProgressBarUI()
    {
        this.丏丏丏一与下丁三丄 = 5f;
    }

}
