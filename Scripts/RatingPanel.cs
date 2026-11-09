using UnityEngine;
public class RatingPanel : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject leaguePanel;
    public UISprite cup;
    public UILabel leagueLabel;
    public UILabel ratingLabel;
    private Rilisoft.ButtonHandler _btnOpenProfile;
    
    // Methods
    private void OnEnable()
    {
        this.丑丁不万丈丟万且业();
        RatingSystem.丘世一丂丝世丏丆一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RatingPanel::丑丁不万丈丟万且业()));
    }
    private void 丑丁不万丈丟万且业()
    {
        bool val_16 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220);
        if(this.leaguePanel == null)
        {
            goto label_2;
        }
        
        if(val_16 == false)
        {
            goto label_3;
        }
        
        label_23:
        this.leaguePanel.SetActive(value:  true);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.cup.spriteName = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏().ToString() + " 1";
        RatingLeague val_8 = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        System.String[] val_9 = RatingSystem.丌丆七丒下不东丑一 + (((long)(int)(val_8)) << 3);
        this.leagueLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (RatingSystem.丌丆七丒下不东丑一 + ((long)(int)(val_8)) << 3) + 32);
        val_16 = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅().ToString();
        this.ratingLabel.text = val_16;
        if(this._btnOpenProfile == 0)
        {
                return;
        }
        
        System.EventHandler val_15 = null;
        val_16 = val_15;
        val_15 = new System.EventHandler(object:  this, method:  System.Void RatingPanel::丌丂丑丑不丞世与丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        this._btnOpenProfile.add_Clicked(丙业与丙丗丝不丈东:  val_15);
        return;
        label_2:
        if(val_16 == true)
        {
            goto label_23;
        }
        
        label_3:
        this.leaguePanel.SetActive(value:  false);
    }
    private void OnDisable()
    {
        if(this._btnOpenProfile != 0)
        {
                this._btnOpenProfile.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void RatingPanel::丌丂丑丑不丞世与丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        RatingSystem.不上丗东丞不丌丐世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RatingPanel::丑丁不万丈丟万且业()));
    }
    private void 丌丂丑丑不丞世与丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_6 = null;
            val_6 = null;
            MainMenuController.丄丞丁丈与业上丞丟.万丅与丞东丅丆专丕();
        }
        
        if(ProfileController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        ProfileController.丑七不且上丗丁一世().SetStaticticTab(丈丒丅上丗丅丙下丞:  2);
    }
    public RatingPanel()
    {
    
    }

}
