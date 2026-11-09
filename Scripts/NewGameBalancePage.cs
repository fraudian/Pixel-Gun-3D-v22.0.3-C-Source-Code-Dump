using UnityEngine;
public class NewGameBalancePage : MonoBehaviour
{
    // Fields
    protected Rilisoft.ButtonHandler _bgClickHandler;
    protected UIButton _nextButton;
    protected UILabel _nextLabel;
    protected UILabel _okLabel;
    protected float _showTime;
    private float 丙上丝丈世下丁七世;
    protected UILabel _timeLeftLabel;
    protected UnityEngine.GameObject _timeLeftObject;
    public bool TimeBlockingEnabled;
    
    // Properties
    public virtual bool 丕世一与业丅万专丑 { get; }
    
    // Methods
    public virtual bool get_CanShow()
    {
        return true;
    }
    protected virtual void OnEnable()
    {
        this.丙上丝丈世下丁七世 = this._showTime;
        if(this._bgClickHandler != 0)
        {
                this._bgClickHandler.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NewGameBalancePage::丒丘下丅东丄上且丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this._bgClickHandler.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NewGameBalancePage::丒丘下丅东丄上且丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        this.不丞下丝丕丈上丈丕();
    }
    private void 丒丘下丅东丄上且丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        goto typeof(NewGameBalancePage).__il2cppRuntimeField_1A8;
    }
    protected virtual void OnDisable()
    {
        if(this._bgClickHandler == 0)
        {
                return;
        }
        
        this._bgClickHandler.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NewGameBalancePage::丒丘下丅东丄上且丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    protected virtual void Update()
    {
        this.不丞下丝丕丈上丈丕();
    }
    private void 不丞下丝丕丈上丈丕()
    {
        float val_3;
        if(this.TimeBlockingEnabled == false)
        {
            goto label_1;
        }
        
        val_3 = this.丙上丝丈世下丁七世;
        if(val_3 > 0f)
        {
                val_3 = val_3 - UnityEngine.Time.deltaTime;
            this.丙上丝丈世下丁七世 = val_3;
        }
        
        if(val_3 <= 0f)
        {
            goto label_6;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftObject, 丏业丟一东丂东丘丛:  true);
        this.丈丘业不丞丗丑丐且(丝三丄专丗丞丄丄丌:  false);
        this._timeLeftLabel.text = System.String.Format(format:  "{0} ...", arg0:  val_3);
        return;
        label_1:
        if(this._nextButton != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_6:
        label_11:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftObject, 丏业丟一东丂东丘丛:  false);
        this.丈丘业不丞丗丑丐且(丝三丄专丗丞丄丄丌:  true);
    }
    protected virtual void 业丒丄丁丘丒丝专丌()
    {
        if(this.TimeBlockingEnabled != false)
        {
                if(this.丙上丝丈世下丁七世 > 0f)
        {
                return;
        }
        
        }
        
        this = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<NewGameBalance12_5WindowController>(丝三丁东丈丒世丅业:  this.gameObject);
        if(this == 0)
        {
                return;
        }
        
        this.NextPage();
    }
    public void U_Skip()
    {
        goto typeof(NewGameBalancePage).__il2cppRuntimeField_1A8;
    }
    private void 丈丘业不丞丗丑丐且(bool 丝三丄专丗丞丄丄丌)
    {
        var val_17;
        var val_19;
        if(丝三丄专丗丞丄丄丌 == false)
        {
            goto label_1;
        }
        
        val_17 = 1152921505284374528;
        NewGameBalance12_5WindowController val_2 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<NewGameBalance12_5WindowController>(丝三丁东丈丒世丅业:  this.gameObject);
        if(val_2 == 0)
        {
                return;
        }
        
        if(val_2.HasNextPage() == false)
        {
            goto label_8;
        }
        
        if(this._nextLabel != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nextLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this._okLabel == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_8 = this._okLabel.gameObject;
        val_19 = null;
        goto label_19;
        label_1:
        val_17 = 1152921504848912384;
        if(this._nextLabel != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nextLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this._okLabel == 0)
        {
                return;
        }
        
        val_19 = null;
        label_19:
        label_44:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._okLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        return;
        label_8:
        if(this._nextLabel != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nextLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this._okLabel == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_16 = this._okLabel.gameObject;
        goto label_44;
    }
    public NewGameBalancePage()
    {
        this._showTime = 2f;
    }

}
