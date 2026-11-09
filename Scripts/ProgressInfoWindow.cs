using UnityEngine;
public class ProgressInfoWindow : MonoBehaviour
{
    // Fields
    private UILabel _infoLabel;
    private System.Collections.Generic.List<UITweener> _tweeners;
    private UIScrollView _scroll;
    private System.IDisposable 丄丘业与丈丛丛丝世;
    private string 与丏丌且丌下丛世丒;
    
    // Properties
    private bool 丌上丞与与丈世丙丄 { get; }
    
    // Methods
    private bool 丈一丙丐丁丐丞丙丁()
    {
        return System.String.op_Inequality(a:  I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业(), b:  this.与丏丌且丌下丛世丒);
    }
    private void OnEnable()
    {
        var val_7;
        if(this.丄丘业与丈丛丛丝世 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        
        this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ProgressInfoWindow::U_Hide()), 与且专丈不万东一万:  0);
        val_7 = null;
        val_7 = null;
        if((ProgressInfoWindow.<>c.<>9__7_0) == null)
        {
            goto label_11;
        }
        
        label_18:
        this._tweeners.ForEach(action:  ProgressInfoWindow.<>c.<>9__7_0);
        this._scroll.StopMomentumForce();
        this._scroll.ResetPosition();
        this.丒丁丅一下丂专万不();
        return;
        label_11:
        ProgressInfoWindow.<>c.<>9__7_0 = new System.Action<UITweener>(object:  ProgressInfoWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ProgressInfoWindow.<>c::丈丌丗丟丐丝上且丕(UITweener 三丟东丕丄丄下下丑));
        if(this._tweeners != null)
        {
            goto label_18;
        }
        
        goto label_18;
    }
    private void OnDisable()
    {
        var val_4;
        if(this.丄丘业与丈丛丛丝世 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        
        val_4 = null;
        val_4 = null;
        if((ProgressInfoWindow.<>c.<>9__8_0) == null)
        {
            goto label_8;
        }
        
        label_13:
        this._tweeners.ForEach(action:  ProgressInfoWindow.<>c.<>9__8_0);
        return;
        label_8:
        ProgressInfoWindow.<>c.<>9__8_0 = new System.Action<UITweener>(object:  ProgressInfoWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ProgressInfoWindow.<>c::丆丑业丂上丞不业丘(UITweener 三丟东丕丄丄下下丑));
        if(this._tweeners != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    private void 丒丁丅一下丂专万不()
    {
        string val_7;
        if(this.丈一丙丐丁丐丞丙丁() == false)
        {
                return;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
        {
                var val_4 = (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1) ? "Key_7397" : "Key_7401";
        }
        else
        {
                val_7 = "Key_7402";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._infoLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_7));
        this.与丏丌且丌下丛世丒 = I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
    }
    public void U_Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public ProgressInfoWindow()
    {
        this.与丏丌且丌下丛世丒 = System.String.alignConst;
    }

}
