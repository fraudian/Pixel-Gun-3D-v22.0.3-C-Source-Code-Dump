using UnityEngine;
public class ClansMemberView : PGBehaviour
{
    // Fields
    protected string 丞丅上丏丂且下丅与;
    protected UnityEngine.GameObject parentPanel;
    
    // Properties
    public UnityEngine.GameObject 丝丘丝丛丏丐世且丏 { get; }
    
    // Methods
    public UnityEngine.GameObject get_ParentPanel()
    {
        return (UnityEngine.GameObject)this.parentPanel;
    }
    public virtual void OnClick()
    {
        null = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        this.parentPanel.SetActive(value:  false);
        FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  this.丞丅上丏丂且下丅与, 丁丅丈丌丟世丗丗丟:  1, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  this, method:  System.Void ClansMemberView::与丅三丂上世七不丐(bool 丕丁丗丘丟丆一丟丆)));
    }
    public ClansMemberView()
    {
    
    }
    private void 与丅三丂上世七不丐(bool 丕丁丗丘丟丆一丟丆)
    {
        this.parentPanel.SetActive(value:  true);
    }

}
