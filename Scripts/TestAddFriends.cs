using UnityEngine;
internal sealed class TestAddFriends : MonoBehaviour
{
    // Methods
    private void OnClick()
    {
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_3 != null)
        {
                val_3.Add(key:  "Added Friends", value:  "Test");
        }
        else
        {
                val_3.Add(key:  "Added Friends", value:  "Test");
        }
        
        val_3.Add(key:  "Deleted Friends", value:  "Add");
        丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().丙与丗世丏丅丈丞万(丄丒且丙三丆丟与丏:  "123", 下丏丏世丈丌丕丛与:  val_3, 业丏丈世世世丞丒世:  0);
    }
    public TestAddFriends()
    {
    
    }

}
