using UnityEngine;
public class TrainingCompletedRewardWindowSettings : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<UILabel> armorNameLabels;
    public System.Collections.Generic.List<UILabel> exp;
    public System.Collections.Generic.List<UILabel> gems;
    public System.Collections.Generic.List<UILabel> coins;
    
    // Methods
    private void Awake()
    {
        var val_3;
        var val_13;
        System.Collections.Generic.List<UILabel> val_14;
        var val_15;
        List.Enumerator<T> val_1 = this.gems.GetEnumerator();
        label_10:
        if((1578875072 & 1) == 0)
        {
            goto label_2;
        }
        
        val_13 = null;
        val_13 = null;
        val_3.丐丏七丌丕丗业且上().text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1531"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  430461928));
        goto label_10;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_14 = this.coins;
        List.Enumerator<T> val_8 = val_14.GetEnumerator();
        label_28:
        if((1578875072 & 1) == 0)
        {
            goto label_20;
        }
        
        val_15 = null;
        val_15 = null;
        val_3.丐丏七丌丕丗业且上().text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1530"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  430461912));
        goto label_28;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public TrainingCompletedRewardWindowSettings()
    {
    
    }

}
