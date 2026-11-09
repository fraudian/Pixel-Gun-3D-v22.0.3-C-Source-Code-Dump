using UnityEngine;
internal class WorldPosIndicationItem_RoyaleSquad : WorldPosIndicationItem_Distanced
{
    // Fields
    private UISprite injuredSprite;
    private UISprite fillingInjuredSprite;
    
    // Methods
    internal void 丗东丕且上丏业丝世(bool 丛与丙丒丒下丌丟且)
    {
        this.injuredSprite.gameObject.SetActive(value:  丛与丙丒丒下丌丟且);
        this.fillingInjuredSprite.gameObject.SetActive(value:  丛与丙丒丒下丌丟且);
        this.fillingInjuredSprite.fillAmount = 1f;
    }
    internal void 丝与丑与丘丝专与且(float 丛丁三世世丆七不业)
    {
        this.fillingInjuredSprite.fillAmount = 丛丁三世世丆七不业;
    }
    public WorldPosIndicationItem_RoyaleSquad()
    {
    
    }

}
