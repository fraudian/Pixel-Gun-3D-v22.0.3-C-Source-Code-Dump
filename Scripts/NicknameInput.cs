using UnityEngine;
internal sealed class NicknameInput : MonoBehaviour
{
    // Fields
    private UIButton 与下东丄万丘丝丞丂;
    public UIInput input;
    
    // Methods
    private void 丝三丄不与丁且丏且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "NicknameRequested", value:  "1");
        if(this.input != 0)
        {
                if(this.input.value != null)
        {
                string val_5 = this.input.value.Trim();
            string val_7 = ((System.String.IsNullOrEmpty(value:  val_5)) != true) ? "Unnamed" : (val_5);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丐万丑丏上专世专(丑与丕丐七丆三丟一:  val_7);
            1152921505043054592 = this.input;
            1152921505043054592.value = val_7;
        }
        
            bool val_9 = UnityEngine.Object.op_Inequality(x:  this.与下东丄万丘丝丞丂, y:  0);
        }
        
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐());
    }
    private void Start()
    {
        var val_12;
        var val_13;
        Rilisoft.ButtonHandler val_2 = this.gameObject.GetComponentInChildren<Rilisoft.ButtonHandler>();
        if(val_2 != 0)
        {
                System.EventHandler val_4 = new System.EventHandler(object:  this, method:  System.Void NicknameInput::丝三丄不与丁且丏且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            if(val_2 != null)
        {
                val_2.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        else
        {
                val_2.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
            this.与下东丄万丘丝丞丂 = val_2.GetComponent<UIButton>();
        }
        
        val_12 = null;
        val_12 = null;
        if(ExperienceController.sharedController != 0)
        {
                if(ExpController.丑七不且上丗丁一世() != 0)
        {
                val_13 = null;
            val_13 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
            ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        if(this.input == 0)
        {
                return;
        }
        
        this.input.value = ProfileController.丆三丂丂丆上丆丕专();
    }
    public NicknameInput()
    {
    
    }

}
