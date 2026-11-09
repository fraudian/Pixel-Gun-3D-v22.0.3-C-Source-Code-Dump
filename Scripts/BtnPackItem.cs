using UnityEngine;
public class BtnPackItem : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject activeState;
    public UnityEngine.GameObject noActiveState;
    public UnityEngine.GameObject objListSticker;
    private StickerPackScroll 丝不下下且七丁一丂;
    public 丞丗丈且丗下丆且世 typePack;
    
    // Methods
    private void Awake()
    {
        this.丝不下下且七丁一丂 = this.GetComponentInParent<StickerPackScroll>();
    }
    private void OnClick()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丝不下下且七丁一丂)) == false)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.丝不下下且七丁一丂.ShowPack(下下丏一丙不丘丌丞:  this.typePack);
    }
    public void ShowPack()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.objListSticker)) != false)
        {
                this.objListSticker.SetActive(value:  true);
            bool val_3 = UnityEngine.Object.op_Inequality(x:  this.objListSticker.GetComponent<UIGrid>(), y:  0);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.activeState)) != false)
        {
                this.activeState.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.noActiveState)) == false)
        {
                return;
        }
        
        this.noActiveState.SetActive(value:  false);
    }
    public void HidePack()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.objListSticker)) != false)
        {
                this.objListSticker.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.activeState)) != false)
        {
                this.activeState.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.noActiveState)) == false)
        {
                return;
        }
        
        this.noActiveState.SetActive(value:  true);
    }
    public BtnPackItem()
    {
    
    }

}
