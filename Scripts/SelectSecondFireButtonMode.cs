using UnityEngine;
public class SelectSecondFireButtonMode : MonoBehaviour
{
    // Fields
    public UIToggle sniperModeButton;
    public UIToggle onModeButton;
    public UIToggle offSniperModeButton;
    
    // Methods
    private void Start()
    {
        var val_13;
        this.sniperModeButton.gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SelectSecondFireButtonMode::万业丝丒丂丏丈不下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.onModeButton.gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SelectSecondFireButtonMode::丙丝丌三业与万丙丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.offSniperModeButton.gameObject.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SelectSecondFireButtonMode::丅丒丛且丙东下专专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_13 = null;
        val_13 = null;
        this.sniperModeButton.value = (与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐 == 0) ? 1 : 0;
        this.onModeButton.value = (与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐 == 1) ? 1 : 0;
        this.offSniperModeButton.value = (与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐 == 2) ? 1 : 0;
    }
    private void 万业丝丒丂丏丈不下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐 = 0;
        UnityEngine.PlayerPrefs.SetInt(key:  "GameSecondFireButtonMode", value:  0);
        与东丕东且丑与丁丐();
    }
    private void 丙丝丌三业与万丙丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐 = 1;
        UnityEngine.PlayerPrefs.SetInt(key:  "GameSecondFireButtonMode", value:  1);
        与东丕东且丑与丁丐();
    }
    private void 丅丒丛且丙东下专专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐 = 2;
        UnityEngine.PlayerPrefs.SetInt(key:  "GameSecondFireButtonMode", value:  2);
        与东丕东且丑与丁丐();
    }
    private void 与东丕东且丑与丁丐()
    {
        var val_3 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丑下丗专丐丑丅专丑(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 下上丐丆丝丟丝丒不:  "GameSecondFireButtonMode", 丙业与丙丗丝不丈东:  与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐.ToString());
    }
    public SelectSecondFireButtonMode()
    {
    
    }

}
