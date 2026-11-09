using UnityEngine;
internal sealed class AddFrendsButtonInTableRangs : MonoBehaviour
{
    // Fields
    public int ID;
    
    // Methods
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        var val_10;
        System.Collections.Generic.List<System.String> val_11;
        var val_12;
        if(丆且上丘世下丅且丞 == true)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_3 != null)
        {
                val_3.Add(key:  "Added Friends", value:  "AddFrendsButtonInTableRangs");
        }
        else
        {
                val_3.Add(key:  "Added Friends", value:  "AddFrendsButtonInTableRangs");
        }
        
        val_3.Add(key:  "Deleted Friends", value:  "Add");
        丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().丙与丗世丏丅丈丞万(丄丒且丙三丆丟与丏:  this.ID.ToString(), 下丏丏世丈丌丕丛与:  val_3, 业丏丈世世世丞丒世:  0);
        val_10 = null;
        val_10 = null;
        val_11 = mem[FriendsController.丄丞丁丈与业上丞丟 + 176];
        val_11 = FriendsController.丄丞丁丈与业上丞丟.丝丟丄世丗且丕丈丝;
        if((Contains(item:  this.ID.ToString())) != true)
        {
                val_12 = null;
            val_12 = null;
            val_11 = mem[FriendsController.丄丞丁丈与业上丞丟 + 176];
            val_11 = FriendsController.丄丞丁丈与业上丞丟.丝丟丄世丗且丕丈丝;
            Add(item:  this.ID.ToString());
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public AddFrendsButtonInTableRangs()
    {
    
    }

}
