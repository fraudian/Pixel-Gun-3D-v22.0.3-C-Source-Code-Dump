using UnityEngine;
public class FriendBtnContainer : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject mainBtn;
    private UnityEngine.GameObject disableBtn;
    private UILabel levelRequiredLabel;
    
    // Methods
    private void Awake()
    {
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendBtnContainer::世专丞丞世不丆丈丈()));
    }
    private void OnDestroy()
    {
        ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FriendBtnContainer::世专丞丞世不丆丈丈()));
    }
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 世专丞丞世不丆丈丈()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.friends")) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disableBtn, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainBtn, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        this.levelRequiredLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.friends"));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disableBtn, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainBtn, 丏业丟一东丂东丘丛:  false);
    }
    public FriendBtnContainer()
    {
    
    }

}
