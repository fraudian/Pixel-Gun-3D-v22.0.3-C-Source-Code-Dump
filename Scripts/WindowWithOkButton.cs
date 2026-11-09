using UnityEngine;
public class WindowWithOkButton : MonoBehaviour
{
    // Fields
    private System.IDisposable 丄丘业与丈丛丛丝世;
    
    // Methods
    private void OnEnable()
    {
        if(this.丄丘业与丈丛丛丝世 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        
        this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void WindowWithOkButton::U_Hide()), 与且专丈不万东一万:  0);
    }
    private void OnDisable()
    {
        if(this.丄丘业与丈丛丛丝世 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丄丘业与丈丛丛丝世.Dispose();
    }
    public void U_Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public WindowWithOkButton()
    {
    
    }

}
