using UnityEngine;
public class NetworkStartTableCupAnimationEventsHandler : MonoBehaviour
{
    // Fields
    private NetworkStartTableNGUIController networkStartTableNGUIController;
    private UnityEngine.AudioClip placeUpSound;
    private UnityEngine.AudioClip placeDownSound;
    
    // Methods
    public void OnCanChangeTournamentPlcaeOnCup()
    {
        this.networkStartTableNGUIController.丐丏丅不丟丒丁丗丄();
    }
    public void OnPlaceUpSpin()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.placeUpSound);
    }
    public void OnPlaceDownSpin()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.placeDownSound);
    }
    public NetworkStartTableCupAnimationEventsHandler()
    {
    
    }

}
