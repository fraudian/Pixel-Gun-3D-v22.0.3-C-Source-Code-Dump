using UnityEngine;
internal sealed class MailBoxLobbyButton : PGBehaviour
{
    // Fields
    private UnityEngine.BoxCollider BoxCollider;
    private UISprite mainSprite;
    private UILabel levelRequiredLabel;
    
    // Methods
    private void Awake()
    {
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MailBoxLobbyButton::世专丞丞世不丆丈丈()));
    }
    private void OnDestroy()
    {
        ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MailBoxLobbyButton::世专丞丞世不丆丈丈()));
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
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        UILabel val_11;
        var val_12;
        bool val_1 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.mailbox");
        bool val_2 = val_1;
        this.BoxCollider.enabled = val_2;
        if(val_2 != false)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.white;
            val_7 = val_3.r;
            val_8 = val_3.g;
            val_9 = val_3.b;
            val_10 = val_3.a;
        }
        else
        {
                val_7 = 0f;
            val_8 = 0f;
            val_9 = 0f;
            val_10 = 0f;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.mainSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_7, g = val_8, b = val_9, a = val_10});
        if(val_1 != false)
        {
                val_11 = this.levelRequiredLabel;
            val_12 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelRequiredLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.mailbox")));
            val_11 = this.levelRequiredLabel;
            val_12 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_11, 丏业丟一东丂东丘丛:  true);
    }
    public MailBoxLobbyButton()
    {
    
    }

}
