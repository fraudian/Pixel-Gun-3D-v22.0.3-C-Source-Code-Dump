using UnityEngine;
public class QuestGSItem : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject questItem;
    public UILabel questDescription;
    public bool selfUpdate;
    
    // Methods
    public void UpdateQuestInfo(丏下丒东丅丏丌一丛 丗一下三丐上丏上一)
    {
        if(this.questItem == null)
        {
            goto label_1;
        }
        
        if(丗一下三丐上丏上一 == null)
        {
            goto label_2;
        }
        
        label_6:
        this.questItem.SetActive(value:  true);
        this.questDescription.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丗一下三丐上丏上一.丄东且丘丄丑下丑东());
        return;
        label_1:
        if(丗一下三丐上丏上一 != null)
        {
            goto label_6;
        }
        
        label_2:
        this.questItem.SetActive(value:  false);
    }
    private void OnEnable()
    {
        丏下丒东丅丏丌一丛 val_4;
        if(this.selfUpdate == false)
        {
                return;
        }
        
        val_4 = 0;
        if(QuestsGSMAnager.丑七不且上丗丁一世() != 0)
        {
                QuestsGSMAnager val_3 = QuestsGSMAnager.丑七不且上丗丁一世();
            val_4 = val_3.丏且七丑丒丑三丐丕;
        }
        
        this.UpdateQuestInfo(丗一下三丐上丏上一:  val_4);
    }
    public QuestGSItem()
    {
        this.selfUpdate = true;
    }

}
