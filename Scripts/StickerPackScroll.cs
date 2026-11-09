using UnityEngine;
public class StickerPackScroll : MonoBehaviour
{
    // Fields
    public 丞丗丈且丗下丆且世 curShowPack;
    public System.Collections.Generic.List<BtnPackItem> listButton;
    public System.Collections.Generic.List<丞丗丈且丗下丆且世> listItemData;
    public UnityEngine.GameObject parentButton;
    private UIGrid 丅丞丕丁丈丁丅三丁;
    
    // Methods
    private void Awake()
    {
        this.listButton.Clear();
        this.listButton.AddRange(collection:  this.GetComponentsInChildren<BtnPackItem>(includeInactive:  true));
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丕丅丙丆丁丟丏丐丕());
        StickersController.且业东丛东且丏丕丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void StickerPackScroll::UpdateListButton()));
    }
    private void OnDisable()
    {
        StickersController.七丝丈丗业丑丈丒东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void StickerPackScroll::UpdateListButton()));
    }
    public void UpdateListButton()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丕丅丙丆丁丟丏丐丕());
    }
    private System.Collections.IEnumerator 丕丅丙丆丁丟丏丐丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new StickerPackScroll.丈上七专不丗上业七();
    }
    public void Sort()
    {
        if(this.丅丞丕丁丈丁丅三丁 == 0)
        {
                return;
        }
        
        this.parentButton.SetActive(value:  false);
        this.parentButton.SetActive(value:  true);
        this = ???;
        goto typeof(UIGrid).__il2cppRuntimeField_1A8;
    }
    public void ShowPack(丞丗丈且丗下丆且世 下下丏一丙不丘丌丞)
    {
        var val_3;
        丞丗丈且丗下丆且世 val_4;
        val_3 = 0;
        goto label_1;
        label_9:
        BtnPackItem val_1 = this.listButton.Item[0];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        val_4 = val_1;
        if(val_1.typePack != 下下丏一丙不丘丌丞)
        {
            goto label_6;
        }
        
        val_1.ShowPack();
        goto label_5;
        label_3:
        if(4194311 != 下下丏一丙不丘丌丞)
        {
            goto label_6;
        }
        
        val_1.ShowPack();
        val_4 = 56;
        label_5:
        this.curShowPack = val_4;
        goto label_7;
        label_6:
        val_1.HidePack();
        label_7:
        val_3 = 1;
        label_1:
        if(val_3 < this.listButton.Count)
        {
            goto label_9;
        }
    
    }
    public StickerPackScroll()
    {
        this.listButton = new System.Collections.Generic.List<BtnPackItem>();
        this.listItemData = new System.Collections.Generic.List<丞丗丈且丗下丆且世>();
    }

}
