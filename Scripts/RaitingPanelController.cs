using UnityEngine;
internal sealed class RaitingPanelController : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> allInterface;
    private UnityEngine.Transform oldRaiting;
    private UnityEngine.Transform newRating;
    private UILabel raitingLabel;
    
    // Methods
    private void 丘丈丁丞丂业万丟上()
    {
        var val_11;
        var val_12;
        if(((PGCompany.丁东丌世与丕东丆上.上丘丈专丝丞与丏丐() == false) || (TournamentController.丅业东万丌丕上丌丄() == false)) || (GameConnect.丕上丐丄三上丝专万() == false))
        {
            goto label_9;
        }
        
        val_11 = 0;
        goto label_10;
        label_15:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterface.Item[0], 丏业丟一东丂东丘丛:  true);
        val_11 = 1;
        label_10:
        if(val_11 < this.allInterface.Count)
        {
            goto label_15;
        }
        
        this.raitingLabel.text = 专且丝丄丙丗丈不丞.丌丄丟东丂下业丕东(丑丅世丐丒丏丐三丅:  (float)RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅());
        return;
        label_9:
        val_12 = 0;
        goto label_22;
        label_27:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterface.Item[0], 丏业丟一东丂东丘丛:  false);
        val_12 = 1;
        label_22:
        if(val_12 < this.allInterface.Count)
        {
            goto label_27;
        }
    
    }
    private void Start()
    {
        RatingSystem.丘世一丂丝世丏丆一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RaitingPanelController::世丕丆丒丕丝下业丘()));
        this.丘丈丁丞丂业万丟上();
    }
    private void OnEnable()
    {
        this.丘丈丁丞丂业万丟上();
    }
    private void 世丕丆丒丕丝下业丘()
    {
        this.丘丈丁丞丂业万丟上();
    }
    private void OnDestroy()
    {
        RatingSystem.不上丗东丞不丌丐世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RaitingPanelController::世丕丆丒丕丝下业丘()));
    }
    public RaitingPanelController()
    {
    
    }

}
