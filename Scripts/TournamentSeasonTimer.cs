using UnityEngine;
public class TournamentSeasonTimer : MonoBehaviour
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
        UILabel val_16;
        string val_17;
        if((FriendsController.丝丗专上三不丄丑丑() < 1) || (TournamentController.丌万丘丙万世丗丈丏() == false))
        {
            goto label_12;
        }
        
        var val_16 = (long)Rilisoft.Singleton<TournamentController>.Instance.丂三下丒丒丁不上东();
        val_16 = val_16 - FriendsController.丝丗专上三不丄丑丑();
        System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  (double)val_16);
        if(val_6._ticks.TotalSeconds <= 0f)
        {
            goto label_12;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noInternetConnectionLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0984")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0984")) + " " + 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_6._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)(专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_6._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        val_17 = val_16;
        goto label_22;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noInternetConnectionLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        val_16 = this.noInternetConnectionLabel;
        val_17 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453");
        label_22:
        val_16.text = val_17;
    }
    public TournamentSeasonTimer()
    {
    
    }

}
