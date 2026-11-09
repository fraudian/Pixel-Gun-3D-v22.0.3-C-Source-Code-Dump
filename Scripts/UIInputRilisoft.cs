using UnityEngine;
public class UIInputRilisoft : UIInput
{
    // Fields
    public UIInputRilisoft.丆上上不丄东万下三 onFocus;
    public UIInputRilisoft.丂一世丝丝丞七下上 onFocusLost;
    public bool validateName;
    
    // Methods
    protected override void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(丞丈丌且东丆丅丗万 != false)
        {
                this.与不三丑业丟丏与丘();
            if(this.onFocus == null)
        {
                return;
        }
        
            if(ProfileView.丄丞丁丈与业上丞丟 != 0)
        {
                ProfileView.丄丞丁丈与业上丞丟.HideNotifValidation();
        }
        
            this.onFocus.Invoke();
            return;
        }
        
        this.万丗丞丟下且不丛丕();
        if(this.onFocusLost == null)
        {
                return;
        }
        
        this.onFocusLost.Invoke();
    }
    public override void Submit()
    {
        System.Collections.IEnumerator val_7;
        if((this.validateName != false) && ((NickNameValidator.instance.ValidateNickName(丕丗丘丑丛与丑业丒:  X21 + 408)) != true))
        {
                this.value = ProfileController.丆三丂丂丆上丆丕专();
            if(ProfileView.丄丞丁丈与业上丞丟 != 0)
        {
                if(ProfileView.丄丞丁丈与业上丞丟 != null)
        {
                val_7 = ProfileView.丄丞丁丈与业上丞丟.丐且丑丅丈丒丝东不();
        }
        else
        {
                val_7 = 0.丐且丑丅丈丒丝东不();
        }
        
            UnityEngine.Coroutine val_6 = ProfileView.丄丞丁丈与业上丞丟.StartCoroutine(routine:  val_7);
        }
        
        }
        
        this.Submit();
    }
    public UIInputRilisoft()
    {
    
    }

}
