using UnityEngine;
public class InGameGUIPart_ClassicArena : InGameGUIPartContainer
{
    // Fields
    public ClassicArenaUI mainUI;
    
    // Methods
    private void Awake()
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                null = null;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.丄丈万丛专丏丁且丁 = this;
        SetActive(value:  false);
        SetActive(value:  false);
    }
    private void Update()
    {
        if(PauseGUIController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainUI.gameObject, 丏业丟一东丂东丘丛:  (~PauseGUIController.丑七不且上丗丁一世().IsPaused) & 1);
    }
    public InGameGUIPart_ClassicArena()
    {
    
    }

}
