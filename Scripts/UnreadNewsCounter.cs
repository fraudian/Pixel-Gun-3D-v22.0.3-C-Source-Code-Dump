using UnityEngine;
public class UnreadNewsCounter : MonoBehaviour
{
    // Fields
    public UILabel UnreadNewsCounterLabel;
    public UnityEngine.GameObject UnreadNewsNotif;
    
    // Methods
    public void UpdateUnreadNewsCount(int 丌丒丝东丌下丕丁丅)
    {
        this.UnreadNewsNotif.SetActive(value:  (丌丒丝东丌下丕丁丅 > 0) ? 1 : 0);
        this.UnreadNewsCounterLabel.text = 丌丒丝东丌下丕丁丅.ToString();
    }
    public UnreadNewsCounter()
    {
    
    }

}
