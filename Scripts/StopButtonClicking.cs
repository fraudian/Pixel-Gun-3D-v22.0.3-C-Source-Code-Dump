using UnityEngine;
public class StopButtonClicking : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        if((this.gameObject.GetComponent<UIToggle>()) == 0)
        {
                return;
        }
        
        EventDelegate val_5 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_2.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void StopButtonClicking::丁一丝丅丟丙且世与()));
    }
    private void OnDisable()
    {
        if((this.gameObject.GetComponent<UIToggle>()) == 0)
        {
                return;
        }
        
        bool val_5 = EventDelegate.Remove(丝丘丑业丛万丞丌丝:  val_2.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void StopButtonClicking::丁一丝丅丟丙且世与()));
    }
    private void 丁一丝丅丟丙且世与()
    {
        UIButton val_1 = this.GetComponent<UIButton>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.enabled = (~(this.gameObject.GetComponent<UIToggle>().value)) & 1;
    }
    public StopButtonClicking()
    {
    
    }

}
