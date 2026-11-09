using UnityEngine;
public class RanksSetPlace : MonoBehaviour
{
    // Fields
    public UILabel placeLabel;
    public UnityEngine.GameObject cupGold;
    public UnityEngine.GameObject cupSilver;
    public UnityEngine.GameObject cupBronze;
    public bool isShowCups;
    
    // Methods
    public void SetPlace(int 且丒丛与丞世丙丕丌)
    {
        if((且丒丛与丞世丙丕丌 <= 3) && (this.isShowCups != false))
        {
                this.placeLabel.text = "";
            this.cupGold.SetActive(value:  (且丒丛与丞世丙丕丌 == 1) ? 1 : 0);
            this.cupSilver.SetActive(value:  (且丒丛与丞世丙丕丌 == 2) ? 1 : 0);
            this.cupBronze.SetActive(value:  (且丒丛与丞世丙丕丌 == 3) ? 1 : 0);
            return;
        }
        
        this.cupGold.SetActive(value:  false);
        this.cupSilver.SetActive(value:  false);
        this.cupBronze.SetActive(value:  false);
        this.placeLabel.text = 且丒丛与丞世丙丕丌.ToString();
    }
    public RanksSetPlace()
    {
    
    }

}
