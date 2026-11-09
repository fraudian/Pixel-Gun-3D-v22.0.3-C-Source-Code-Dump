using UnityEngine;
public class FriendsInfoBoxController : MonoBehaviour
{
    // Fields
    private FriendsInfoBoxController.万不丄丈丅丕丗丐世 且丅下一丝丞下丗东;
    public UIWidget background;
    public UIWidget infoBoxContainer;
    public UILabel infoBoxLabel;
    public UIWidget processindDataBoxContainer;
    public UILabel processingDataBoxLabel;
    
    // Methods
    private void Start()
    {
        this.processingDataBoxLabel.text = 丟丏下丂七三下丗丕.不丈丂丛万丐七世丛();
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendsInfoBoxController::丞丛一丙丂世丈丅丗()));
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendsInfoBoxController::丞丛一丙丂世丈丅丗()));
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        this.processingDataBoxLabel.text = 丟丏下丂七三下丗丕.不丈丂丛万丐七世丛();
    }
    public void ShowInfoBox(string 丕丗丘丑丛与丑业丒)
    {
        this.且丅下一丝丞下丗东 = 0;
        this.gameObject.SetActive(value:  true);
        this.processindDataBoxContainer.gameObject.SetActive(value:  false);
        this.infoBoxLabel.text = 丕丗丘丑丛与丑业丒;
        this.infoBoxContainer.gameObject.SetActive(value:  true);
        this.background.gameObject.SetActive(value:  true);
    }
    public void ShowProcessingDataBox()
    {
        this.且丅下一丝丞下丗东 = 1;
        this.gameObject.SetActive(value:  true);
        this.processindDataBoxContainer.gameObject.SetActive(value:  true);
        this.infoBoxContainer.gameObject.SetActive(value:  false);
        this.background.gameObject.SetActive(value:  false);
    }
    public void Hide()
    {
        this.且丅下一丝丞下丗东 = 3;
        this.gameObject.SetActive(value:  false);
    }
    public void OnClickExitButton()
    {
        万不丄丈丅丕丗丐世 val_1 = this.且丅下一丝丞下丗东;
        val_1 = val_1 - 1;
        if(val_1 < 2)
        {
                return;
        }
        
        this.Hide();
    }
    public void SetBlockClickState()
    {
        this.且丅下一丝丞下丗东 = 2;
        this.gameObject.SetActive(value:  true);
        this.processindDataBoxContainer.gameObject.SetActive(value:  false);
        this.infoBoxContainer.gameObject.SetActive(value:  false);
        this.background.gameObject.SetActive(value:  false);
    }
    public FriendsInfoBoxController()
    {
        this.且丅下一丝丞下丗东 = 3;
    }

}
