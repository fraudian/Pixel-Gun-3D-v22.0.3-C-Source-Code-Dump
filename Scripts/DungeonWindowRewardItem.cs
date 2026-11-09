using UnityEngine;
public class DungeonWindowRewardItem : MonoBehaviour
{
    // Fields
    public UITexture rewardIcon;
    public UILabel rewardLabel;
    private PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌;
    
    // Methods
    internal void 丐丘丑丞世丝丕世丗(PGCompany.三丘丌上丁万丏丛丟 业丆丙丆丅丌丛丙丘)
    {
        this.丐下丝丘丑丟丟丗丌 = 业丆丙丆丅丌丛丙丘;
        this.rewardLabel.text = 业丆丙丆丅丌丛丙丘.七业丑不七丐业丟丂();
    }
    public DungeonWindowRewardItem()
    {
    
    }

}
