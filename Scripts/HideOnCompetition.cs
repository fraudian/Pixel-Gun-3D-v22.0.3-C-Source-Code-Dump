using UnityEngine;
internal sealed class HideOnCompetition : PGBehaviour
{
    // Methods
    private void OnEnable()
    {
        null = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public HideOnCompetition()
    {
    
    }

}
