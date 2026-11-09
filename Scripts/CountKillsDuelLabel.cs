using UnityEngine;
public class CountKillsDuelLabel : MonoBehaviour
{
    // Fields
    public bool enemyKills;
    private UILabel 七丐丞丑丑丕世丙七;
    
    // Methods
    private void Awake()
    {
        this.七丐丞丑丑丕世丙七 = this.GetComponent<UILabel>();
    }
    private void Update()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        int val_14;
        var val_15;
        var val_16;
        if(this.enemyKills == false)
        {
            goto label_1;
        }
        
        val_8 = null;
        val_8 = null;
        if(DuelController.丄丘七三上丕世丞业 == 0)
        {
            goto label_12;
        }
        
        val_9 = null;
        val_9 = null;
        if(DuelController.丄丘七三上丕世丞业.opponentNetworkTable == 0)
        {
            goto label_12;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = null;
        if((丑丛丆三丆丄七丐万() & 2147483648) != 0)
        {
            goto label_17;
        }
        
        val_12 = null;
        val_13 = DuelController.丄丘七三上丕世丞业.opponentNetworkTable;
        int val_4 = 丑丛丆三丆丄七丐万();
        goto label_22;
        label_12:
        val_14 = 0;
        goto label_34;
        label_1:
        val_15 = null;
        val_15 = null;
        val_13 = GameController.mode;
        label_22:
        val_14 = val_13.七丒丘丏业丟丌丄七();
        label_34:
        this.七丐丞丑丑丕世丙七.text = UnityEngine.Mathf.Max(a:  0, b:  val_14).ToString();
        return;
        label_17:
        val_16 = null;
        if(null != 0)
        {
            goto label_34;
        }
        
        goto label_34;
    }
    public CountKillsDuelLabel()
    {
    
    }

}
