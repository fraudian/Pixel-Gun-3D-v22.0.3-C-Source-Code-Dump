using UnityEngine;
internal sealed class HideOnGamemode : PGBehaviour
{
    // Fields
    public Rilisoft.七丕丟丏三丈一丄世 mode;
    
    // Methods
    private void OnEnable()
    {
        if(GameConnect.丑丌丛丈丅丅与不业() != this.mode)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public HideOnGamemode()
    {
    
    }

}
