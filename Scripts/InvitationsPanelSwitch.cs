using UnityEngine;
public class InvitationsPanelSwitch : MonoBehaviour
{
    // Fields
    public bool left;
    public bool Middle;
    public UnityEngine.GameObject leftPanel;
    public UnityEngine.GameObject MiddlePanel;
    public UnityEngine.GameObject rightPanel;
    public UnityEngine.GameObject[] anotherButtons;
    public UnityEngine.GameObject[] anotherChekmarks;
    public UnityEngine.GameObject chekmark;
    public UnityEngine.GameObject butt;
    public UnityEngine.GameObject[] anotherToggles;
    
    // Methods
    private void OnPress(bool 万与丘丅丟世丅丄上)
    {
        string val_5;
        bool val_1 = 万与丘丅丟世丅丄上;
        UnityEngine.Debug.Log(message:  "press " + val_1.ToString());
        UISprite val_4 = this.GetComponent<UISprite>();
        if(val_4 == null)
        {
            goto label_3;
        }
        
        if(val_1 == false)
        {
            goto label_4;
        }
        
        label_6:
        val_5 = "trans_btn_n";
        goto label_5;
        label_3:
        if(val_1 == true)
        {
            goto label_6;
        }
        
        label_4:
        val_5 = "trans_btn";
        label_5:
        val_4.spriteName = val_5;
    }
    private void OnClick()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        UnityEngine.Debug.Log(message:  "OnClick");
        if(this.left == false)
        {
            goto label_3;
        }
        
        this.leftPanel.SetActive(value:  true);
        val_7 = 0;
        goto label_6;
        label_3:
        this.leftPanel.SetActive(value:  false);
        if(this.MiddlePanel == null)
        {
            goto label_8;
        }
        
        if(this.Middle == false)
        {
            goto label_9;
        }
        
        label_36:
        val_7 = 1;
        label_6:
        this.MiddlePanel.SetActive(value:  true);
        label_38:
        this.rightPanel.SetActive(value:  false);
        this.GetComponent<UIButton>().enabled = false;
        this.butt.GetComponent<UILabel>().gameObject.SetActive(value:  false);
        this.chekmark.SetActive(value:  true);
        this.GetComponent<UISprite>().spriteName = "trans_btn_n";
        val_8 = 0;
        goto label_17;
        label_21:
        this.anotherButtons[0].SetActive(value:  true);
        val_8 = 1;
        label_17:
        if(val_8 < this.anotherButtons.Length)
        {
            goto label_21;
        }
        
        val_9 = 0;
        goto label_22;
        label_29:
        UnityEngine.GameObject val_8 = this.anotherToggles[0];
        val_8.GetComponent<UIButton>().enabled = true;
        val_8.GetComponent<UISprite>().spriteName = "trans_btn";
        val_9 = 1;
        label_22:
        if(val_9 < this.anotherToggles.Length)
        {
            goto label_29;
        }
        
        val_10 = 0;
        goto label_30;
        label_34:
        this.anotherChekmarks[0].SetActive(value:  false);
        val_10 = 1;
        label_30:
        if(val_10 < this.anotherChekmarks.Length)
        {
            goto label_34;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        return;
        label_8:
        if(this.Middle == true)
        {
            goto label_36;
        }
        
        label_9:
        this.MiddlePanel.SetActive(value:  false);
        if(this.rightPanel != null)
        {
            goto label_38;
        }
        
        goto label_38;
    }
    public InvitationsPanelSwitch()
    {
        this.left = true;
    }

}
