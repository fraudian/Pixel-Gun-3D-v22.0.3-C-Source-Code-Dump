using UnityEngine;
public class EmailInputPanel : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject inputPanel;
    public UnityEngine.GameObject sucessPanel;
    public UnityEngine.GameObject errorPanel;
    public UnityEngine.GameObject error1800;
    public UnityEngine.GameObject error1400;
    public UnityEngine.GameObject waitPanel;
    public UIButton subsciptionButton;
    public UIInput inputEmail;
    public UILabel waiting_email;
    public UnityEngine.GameObject loadingInInputPanel;
    public UnityEngine.GameObject noteInInputPanel;
    public Rilisoft.ButtonHandler closeInputPanel;
    public Rilisoft.ButtonHandler closeWaitingPanel;
    public Rilisoft.ButtonHandler closeErrorPanel;
    public Rilisoft.ButtonHandler closeSucessPanel;
    
    // Methods
    private void Start()
    {
        this.closeInputPanel.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void EmailInputPanel::丛与丅丞丂丕七丐东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.closeWaitingPanel.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void EmailInputPanel::丂一丗下丗与万丒不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.closeErrorPanel.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void EmailInputPanel::万三东与丌丛丟丙丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.closeSucessPanel.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void EmailInputPanel::丌万不七与下业丛丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丛与丅丞丂丕七丐东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丁丒下丕丁丐下一丄();
    }
    public void SubsciptionButtonHandler()
    {
        丆与丞丈下丄丐专丛.丑七不且上丗丁一世().丆世丗业丙一丂丑丘(丛不丞丟丅丐丙丞丂:  this.inputEmail.value);
        this.loadingInInputPanel.SetActive(value:  true);
        this.noteInInputPanel.SetActive(value:  false);
    }
    public void CancelSubsciptionButtonHandler()
    {
        this.丁丒下丕丁丐下一丄();
    }
    private void 丌万不七与下业丛丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.OkSucessButtonHandler();
    }
    public void OkSucessButtonHandler()
    {
        this.sucessPanel.SetActive(value:  false);
    }
    private void 万三东与丌丛丟丙丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.OkErrorButtonHandler();
    }
    public void OkErrorButtonHandler()
    {
        this.errorPanel.SetActive(value:  false);
    }
    private void 丂一丗下丗与万丒不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.waitPanel.SetActive(value:  false);
    }
    public void OkWaitingButtonHandler()
    {
        丆与丞丈下丄丐专丛.丑七不且上丗丁一世().丆世丗业丙一丂丑丘(丛不丞丟丅丐丙丞丂:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  丆与丞丈下丄丐专丛.丕丅丌丁丆丙业丁万()));
        this.waitPanel.SetActive(value:  false);
    }
    public void ReplaceSubsciptionWaitingButtonHandler()
    {
        this.waitPanel.SetActive(value:  false);
        this.errorPanel.SetActive(value:  false);
        this.丏丈丒丕丂丏业世丄();
    }
    internal void 丏丈丒丕丂丏业世丄()
    {
        this.inputPanel.SetActive(value:  true);
        this.loadingInInputPanel.SetActive(value:  false);
        this.inputEmail.value = System.String.alignConst;
        this.inputEmail.isSelected = true;
        this.noteInInputPanel.SetActive(value:  true);
    }
    internal void 丁丒下丕丁丐下一丄()
    {
        this.inputPanel.SetActive(value:  false);
        if(this.subsciptionButton == null)
        {
            
        }
    
    }
    public EmailInputPanel()
    {
    
    }

}
