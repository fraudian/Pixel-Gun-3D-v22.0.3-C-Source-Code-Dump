using UnityEngine;
internal sealed class ProfileButton : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _defaultContainer;
    private UILabel _defaultNickLabel;
    private UnityEngine.GameObject _maxLevelContainer;
    private UILabel _maxLevelNickLabel;
    
    // Methods
    private void OnEnable()
    {
        this.丈且东丑丂且万丒丅();
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProfileButton::丈且东丑丂且万丒丅()));
        ExpController.一丈与丒丘下七丛丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProfileButton::丈且东丑丂且万丒丅()));
        Progress.上丁丆七丁丗万丘丐.不业丘丑丐丟上丂东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProfileButton::丈且东丑丂且万丒丅()));
    }
    private void OnDisable()
    {
        ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProfileButton::丈且东丑丂且万丒丅()));
        ExpController.丄丂一丛丅丄丄丘且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProfileButton::丈且东丑丂且万丒丅()));
        Progress.上丁丆七丁丗万丘丐.丕且丁东丆七丑丌丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProfileButton::丈且东丑丂且万丒丅()));
    }
    private void 丈且东丑丂且万丒丅()
    {
        var val_4;
        UILabel val_5;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._defaultContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._maxLevelContainer, 丏业丟一东丂东丘丛:  false);
        if(ExperienceController.丞丞丘业东丙丏七丌() == 65)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._maxLevelContainer, 丏业丟一东丂东丘丛:  true);
            val_4 = 1152921505248538624;
            val_5 = this._maxLevelNickLabel;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._defaultContainer, 丏业丟一东丂东丘丛:  true);
            val_4 = 1152921505248538624;
            val_5 = this._defaultNickLabel;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_5, 丕丗丘丑丛与丑业丒:  专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  ProfileController.丆三丂丂丆上丆丕专()));
    }
    public void U_Click()
    {
        var val_4;
        if(ProfileController.丑七不且上丗丁一世() != 0)
        {
                ProfileController.丑七不且上丗丁一世().SetStaticticTab(丈丒丅上丗丅丙下丞:  0);
        }
        
        val_4 = null;
        val_4 = null;
        MainMenuController.丄丞丁丈与业上丞丟.万丅与丞东丅丆专丕();
    }
    public ProfileButton()
    {
    
    }

}
