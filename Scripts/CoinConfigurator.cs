using UnityEngine;
internal sealed class CoinConfigurator : MonoBehaviour
{
    // Fields
    private Rilisoft.丝一丌上丟且三一丏 bonusType;
    public bool CoinIsPresent;
    public UnityEngine.Vector3 pos;
    public UnityEngine.Transform coinCreatePoint;
    
    // Properties
    public Rilisoft.丝一丌上丟且三一丏 不丕丟丐丒且与丛下 { get; }
    
    // Methods
    public Rilisoft.丝一丌上丟且三一丏 get_BonusType()
    {
        return (Rilisoft.丝一丌上丟且三一丏)this.bonusType;
    }
    public CoinConfigurator()
    {
        this.CoinIsPresent = true;
    }

}
