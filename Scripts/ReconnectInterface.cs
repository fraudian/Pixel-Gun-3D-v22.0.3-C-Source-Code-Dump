using UnityEngine;
public class ReconnectInterface : MonoBehaviour
{
    // Fields
    public Rilisoft.ButtonHandler cancelButtonHandler;
    public UIButton buttonCancel;
    public UILabel descriptionLabel;
    public UnityEngine.GameObject matchFoundPanel;
    public UnityEngine.GameObject matchAgainPanel;
    public UITexture backgroundUITexture;
    private PenaltyConfirmDialog confirmDialog;
    private bool 丕丈下丝丕丙与丆业;
    private System.Action 丌上上专丘下七丙丈;
    private System.Action 丄丏不业丏丗丕万丐;
    
    // Methods
    public void ShowDescriptionLabel(string 丕丗丘丑丛与丑业丒)
    {
        this.descriptionLabel.gameObject.SetActive(value:  true);
        this.descriptionLabel.text = 丕丗丘丑丛与丑业丒;
    }
    public void Hide()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.backgroundUITexture.gameObject, 丏业丟一东丂东丘丛:  false);
        this.descriptionLabel.gameObject.SetActive(value:  false);
        this.buttonCancel.gameObject.SetActive(value:  false);
        this.confirmDialog.gameObject.SetActive(value:  false);
    }
    internal void 与丐丛业丟丌丑丈丞(System.Action 且丞丑丕丑丌丂丁世, System.Action 丝丈丛丐丕丟不丌丗)
    {
        if(RatingSystem.与一丅丝不丈业与丙().且与丝东一丌下丁一() != false)
        {
                this.confirmDialog.gameObject.SetActive(value:  true);
            this.confirmDialog.丑专丈丙丄专东世丒();
            this.丌上上专丘下七丙丈 = 且丞丑丕丑丌丂丁世;
            this.丄丏不业丏丗丕万丐 = 丝丈丛丐丕丟不丌丗;
            this.confirmDialog.且丕丈与丒丑丑业丝 = new System.Action(object:  this, method:  System.Void ReconnectInterface::丞一丑丆丙丑丕丐丞());
            this.confirmDialog.丆上丙丝上上业业且 = new System.Action(object:  this, method:  System.Void ReconnectInterface::丄七丌丏丛丞丕丌丂());
            this.descriptionLabel.gameObject.SetActive(value:  false);
            this.buttonCancel.gameObject.SetActive(value:  false);
            this.丕丈下丝丕丙与丆业 = ActivityIndicator.丙专三丙丌丝丏丌丅();
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
            return;
        }
        
        if(且丞丑丕丑丌丂丁世 == null)
        {
                return;
        }
        
        且丞丑丕丑丌丂丁世.Invoke();
    }
    internal void 丄七丌丏丛丞丕丌丂()
    {
        this.丝丝丝丒丟上与丟丛(丛丆丛三丕丅丝丝丝:  true);
        if(this.丄丏不业丏丗丕万丐 == null)
        {
                return;
        }
        
        this.丄丏不业丏丗丕万丐.Invoke();
    }
    internal void 丞一丑丆丙丑丕丐丞()
    {
        this.丝丝丝丒丟上与丟丛(丛丆丛三丕丅丝丝丝:  false);
        if(this.丌上上专丘下七丙丈 == null)
        {
                return;
        }
        
        this.丌上上专丘下七丙丈.Invoke();
    }
    internal bool 丒丘丑丝丛丛丁丑世()
    {
        UnityEngine.GameObject val_1 = this.confirmDialog.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    internal void 丝丝丝丒丟上与丟丛(bool 丛丆丛三丕丅丝丝丝 = True)
    {
        if(this.confirmDialog.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.confirmDialog.gameObject.SetActive(value:  false);
        this.descriptionLabel.gameObject.SetActive(value:  丛丆丛三丕丅丝丝丝);
        this.buttonCancel.gameObject.SetActive(value:  丛丆丛三丕丅丝丝丝);
        if(this.丕丈下丝丕丙与丆业 == false)
        {
                return;
        }
        
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
    }
    private void Awake()
    {
    
    }
    private void Update()
    {
    
    }
    public ReconnectInterface()
    {
    
    }

}
