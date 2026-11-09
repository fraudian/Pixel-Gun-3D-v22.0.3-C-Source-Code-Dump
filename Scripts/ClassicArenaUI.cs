using UnityEngine;
public class ClassicArenaUI : MonoBehaviour
{
    // Fields
    public UILabel scoreLabel;
    public UnityEngine.GameObject[] healthHearts;
    
    // Methods
    private void Update()
    {
        var val_12;
        float val_13;
        var val_14;
        var val_15;
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(null != 0)
        {
                val_13 = 丘七业丒丐世丂丅丒();
        }
        else
        {
                val_13 = 0.丘七业丒丐世丂丅丒();
        }
        
        float val_12 = (float)this.healthHearts.Length;
        val_12 = (val_13 / 专一丟丏且丆丕丝七()) * val_12;
        val_14 = 0;
        goto label_12;
        label_17:
        this.healthHearts[0].SetActive(value:  ((UnityEngine.Mathf.CeilToInt(f:  val_12)) > val_14) ? 1 : 0);
        val_14 = 1;
        label_12:
        if(val_14 < this.healthHearts.Length)
        {
            goto label_17;
        }
        
        val_15 = null;
        val_15 = null;
        this.scoreLabel.text = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0190"), arg1:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  GameController.mode.丞丏丕丑丞丑丏丏丄()));
    }
    public ClassicArenaUI()
    {
    
    }

}
