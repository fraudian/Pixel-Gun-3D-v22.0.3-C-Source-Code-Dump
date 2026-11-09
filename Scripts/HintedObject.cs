using UnityEngine;
public class HintedObject : MonoBehaviour
{
    // Fields
    public int fontSize;
    public string term;
    public float timeToShowHint;
    public MenuHintObject hintObj;
    public UnityEngine.Vector3 position;
    public HintedObject.丄丒上丅丝丐丐七东 arrowPos;
    public bool showOnPress;
    public bool preview;
    private float 丙一丑丏丁一且丒业;
    private bool 丁丐不且七丂业丗丆;
    private UnityEngine.Transform 丘丞丛丝丛世世专丞;
    private bool 下丁丞丝丛一丘丐丒;
    
    // Methods
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        bool val_1 = 万东丂丒且丅丛丑丕;
        this.丁丐不且七丂业丗丆 = val_1;
        this.丙一丑丏丁一且丒业 = this.timeToShowHint;
        if(val_1 == true)
        {
                return;
        }
        
        if(this.hintObj.isActiveAndEnabled == false)
        {
                return;
        }
        
        this.CloseHint();
    }
    public void ShowHint()
    {
        UILabel val_21;
        七丐与七丌不丂丞且 val_22;
        this.下丁丞丝丛一丘丐丒 = true;
        this.hintObj.gameObject.SetActive(value:  true);
        this.hintObj.body.transform.parent = this.transform;
        this.hintObj.botRightArrow.SetActive(value:  (this.arrowPos == 0) ? 1 : 0);
        this.hintObj.botCenterArrow.SetActive(value:  (this.arrowPos == 1) ? 1 : 0);
        this.hintObj.botLeftArrow.SetActive(value:  (this.arrowPos == 2) ? 1 : 0);
        this.hintObj.leftBotArrow.SetActive(value:  (this.arrowPos == 3) ? 1 : 0);
        this.hintObj.leftCenterArrow.SetActive(value:  (this.arrowPos == 4) ? 1 : 0);
        this.hintObj.leftTopArrow.SetActive(value:  (this.arrowPos == 5) ? 1 : 0);
        this.hintObj.rightTopArrow.SetActive(value:  (this.arrowPos == 6) ? 1 : 0);
        this.hintObj.rightCenterArrow.SetActive(value:  (this.arrowPos == 7) ? 1 : 0);
        this.hintObj.rightBotArrow.SetActive(value:  (this.arrowPos == 8) ? 1 : 0);
        this.hintObj.topLeftArrow.SetActive(value:  (this.arrowPos == 9) ? 1 : 0);
        this.hintObj.topCenterArrow.SetActive(value:  (this.arrowPos == 10) ? 1 : 0);
        this.hintObj.topRightArrow.SetActive(value:  (this.arrowPos == 11) ? 1 : 0);
        this.hintObj.label.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.term);
        this.hintObj.label.fontSize = this.fontSize;
        this.hintObj.label.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.hintObj.body.transform.localPosition = new UnityEngine.Vector3() {x = this.position, y = V9.16B, z = V10.16B};
        if(UnityEngine.Application.isPlaying != false)
        {
                this.hintObj.tween.PlayForward();
        }
        
        丄丒上丅丝丐丐七东 val_21 = this.arrowPos;
        if(val_21 > 11)
        {
            goto label_50;
        }
        
        val_21 = 1 << val_21;
        if((val_21 & 3680) == 0)
        {
            goto label_46;
        }
        
        val_21 = this.hintObj.label;
        val_22 = 2;
        goto label_53;
        label_46:
        val_21 = val_21 & 144;
        if(val_21 == 0)
        {
            goto label_50;
        }
        
        val_21 = this.hintObj.label;
        val_22 = 5;
        goto label_53;
        label_50:
        val_21 = this.hintObj.label;
        val_22 = 8;
        label_53:
        val_21.pivot = val_22;
    }
    public void CloseHint()
    {
        this.下丁丞丝丛一丘丐丒 = false;
        this.hintObj.gameObject.SetActive(value:  false);
        if(UnityEngine.Application.isPlaying != false)
        {
                this.hintObj.tween.ResetToBeginning();
        }
        
        this.丙一丑丏丁一且丒业 = this.timeToShowHint;
        this.hintObj.body.transform.parent = this.hintObj.transform;
    }
    private void Update()
    {
        if((this.丁丐不且七丂业丗丆 != false) && (this.showOnPress != false))
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.丙一丑丏丁一且丒业 - val_1;
            this.丙一丑丏丁一且丒业 = val_1;
            if(val_1 < 0)
        {
                this.ShowHint();
        }
        
        }
        
        if(((this.下丁丞丝丛一丘丐丒 != false) && (this.showOnPress != false)) && (this.丁丐不且七丂业丗丆 != true))
        {
                this.CloseHint();
        }
        
        if(UnityEngine.Application.isPlaying == true)
        {
                return;
        }
        
        if(this.preview != false)
        {
                this.ShowHint();
        }
        
        if(this.下丁丞丝丛一丘丐丒 == false)
        {
                return;
        }
        
        if(this.preview != false)
        {
                return;
        }
        
        this.CloseHint();
    }
    public HintedObject()
    {
        this.fontSize = 20;
        this.timeToShowHint = 0.2f;
        this.term = "hint";
    }

}
