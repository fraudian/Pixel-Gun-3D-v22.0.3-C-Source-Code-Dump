using UnityEngine;
public class ClansSeasonTimer : MonoBehaviour
{
    // Fields
    private const float 丟三专丗丄丑丕上专 = 0.5;
    private UILabel noInternetConnectionLabel;
    private float 丏万丘不东三不丝丐;
    private UILabel timeLeftLabel;
    
    // Methods
    private void OnEnable()
    {
        this.丕丕业七丙七丅丈丄();
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = this.丏万丘不东三不丝丐 - val_1;
        this.丏万丘不东三不丝丐 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.丏万丘不东三不丝丐 = 0.5f;
        this.丕丕业七丙七丅丈丄();
    }
    private void 丕丕业七丙七丅丈丄()
    {
        UILabel val_13;
        string val_14;
        string val_15;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_3;
        }
        
        int val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐丏丌丟一丁丄丏上();
        UnityEngine.GameObject val_4 = this.timeLeftLabel.gameObject;
        if(val_3 <= 0)
        {
            goto label_6;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noInternetConnectionLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        val_13 = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4439"), arg1:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_3, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        val_14 = val_13;
        goto label_15;
        label_3:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noInternetConnectionLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        val_13 = this.noInternetConnectionLabel;
        val_15 = "Key_4453";
        goto label_22;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noInternetConnectionLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        val_13 = this.timeLeftLabel;
        val_15 = "Key_8529";
        label_22:
        val_14 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15);
        label_15:
        val_13.text = val_14;
    }
    public ClansSeasonTimer()
    {
    
    }

}
