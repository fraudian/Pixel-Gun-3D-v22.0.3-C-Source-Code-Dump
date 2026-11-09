using UnityEngine;
public class AddToFriendMenuItem : ContextMenuItemBase
{
    // Fields
    private UIButton 下丒丘丅丌丏丛丗丆;
    
    // Methods
    private void Awake()
    {
        this.下丒丘丅丌丏丛丗丆 = this.GetComponent<UIButton>();
    }
    public override void Interact()
    {
        this.Interact();
        if(true == 0)
        {
                return;
        }
    
    }
    public override void UpdateSelf()
    {
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.friends")) != false)
        {
                if((丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().与丂丑丆上专业丂丑(丄丒且丙三丆丟与丏:  0)) != true)
        {
                if((FriendsController.专丁丟丛丆万丟万丆(丄丒且丙三丆丟与丏:  0)) == false)
        {
                return;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public AddToFriendMenuItem()
    {
    
    }

}
