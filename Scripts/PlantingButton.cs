using UnityEngine;
internal sealed class PlantingButton : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject stateNormal;
    private UnityEngine.GameObject stateProgress;
    private UnityEngine.GameObject progressBar;
    private UISprite progressFillMain;
    private UITexture progressFillTexture;
    private UILabel percentsLabel;
    private SimpleTweenePlayer ResetPlayer;
    private Rilisoft.ButtonHandler 丆丐丘丘世万丛万丁;
    private bool 专丈万丈丈丌丛丝东;
    private float 不丂丗丛丞丐丌专丑;
    private float 丏丈丌七下丗丁丁专;
    private const float 七丘一丛东丝万且丄 = 0.2;
    private bool 下下东且万业丞丅丒;
    
    // Methods
    private void Awake()
    {
        this.丆丐丘丘世万丛万丁 = this.GetComponent<Rilisoft.ButtonHandler>();
    }
    private void 丄丙一丕业丑三世丘()
    {
        float val_1 = this.不丂丗丛丞丐丌专丑;
        val_1 = this.丏丈丌七下丗丁丁专 * val_1;
        val_1 = val_1 / 0.2f;
        this.丘丑三与丁丟丒业丅(丂丟世与丁下业不专:  true, 上丕丈丞丌丘丅不与:  val_1);
    }
    private void 丘丑三与丁丟丒业丅(bool 丂丟世与丁下业不专, float 上丕丈丞丌丘丅不与 = 0)
    {
        Rilisoft.ButtonHandler val_7;
        Rilisoft.ButtonHandler val_8;
        val_7 = this;
        bool val_1 = 丂丟世与丁下业不专 ^ 1;
        丂丟世与丁下业不专 = val_1;
        this.stateNormal.SetActive(value:  丂丟世与丁下业不专);
        bool val_2 = 丂丟世与丁下业不专;
        this.stateProgress.SetActive(value:  val_2);
        this.progressBar.SetActive(value:  val_2);
        this.progressFillMain.fillAmount = 上丕丈丞丌丘丅不与;
        this.progressFillTexture.fillAmount = 上丕丈丞丌丘丅不与;
        this.percentsLabel.text = System.String.Format(format:  "{0:P0}", arg0:  上丕丈丞丌丘丅不与);
        val_8 = this.丆丐丘丘世万丛万丁;
        if(val_8 == 0)
        {
                return;
        }
        
        val_8 = this.丆丐丘丘世万丛万丁;
        var val_5 = (this.丆丐丘丘世万丛万丁.isEnable == true) ? 1 : 0;
        val_5 = val_5 ^ 丂丟世与丁下业不专;
        if(val_5 == true)
        {
                return;
        }
        
        val_7 = this.丆丐丘丘世万丛万丁;
        val_7.丅丁丝丁丈丛丐且丑(丆丛丆丞下丅丂且丝:  val_1);
    }
    internal void 丕丕业七丙七丅丈丄(bool 丂丟世与丁下业不专, float 上丕丈丞丌丘丅不与 = 0)
    {
        if(this.专丈万丈丈丌丛丝东 != false)
        {
                float val_2 = this.不丂丗丛丞丐丌专丑;
            val_2 = this.丏丈丌七下丗丁丁专 * val_2;
            val_2 = val_2 / 0.2f;
            this.丘丑三与丁丟丒业丅(丂丟世与丁下业不专:  true, 上丕丈丞丌丘丅不与:  val_2);
            return;
        }
        
        this.丘丑三与丁丟丒业丅(丂丟世与丁下业不专:  丂丟世与丁下业不专, 上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与);
    }
    private void Update()
    {
        if(this.专丈万丈丈丌丛丝东 == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.不丂丗丛丞丐丌专丑 - val_1;
        this.不丂丗丛丞丐丌专丑 = val_1;
        if(val_1 <= 0f)
        {
            goto label_1;
        }
        
        if(this.下下东且万业丞丅丒 == false)
        {
            goto label_2;
        }
        
        return;
        label_1:
        this.专丈万丈丈丌丛丝东 = false;
        this.gameObject.SetActive(value:  (this.下下东且万业丞丅丒 == true) ? 1 : 0);
        return;
        label_2:
        val_1 = val_1 * this.丏丈丌七下丗丁丁专;
        val_1 = val_1 / 0.2f;
        this.丘丑三与丁丟丒业丅(丂丟世与丁下业不专:  true, 上丕丈丞丌丘丅不与:  val_1);
    }
    private void 三丞丏上丝一东丞丏()
    {
        this.专丈万丈丈丌丛丝东 = true;
        this.不丂丗丛丞丐丌专丑 = 0.2f;
        this.丏丈丌七下丗丁丁专 = this.progressFillMain.fillAmount;
    }
    internal void 丛丌丞下业业丞丗丂(bool 丙业与丙丗丝不丈东)
    {
        this.下下东且万业丞丅丒 = 丙业与丙丗丝不丈东;
        if(this.专丈万丈丈丌丛丝东 != false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  丙业与丙丗丝不丈东);
    }
    internal void 丈下且东丅丝上丝不()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.ResetPlayer != 0)
        {
                this.ResetPlayer.Play();
        }
        
        this.三丞丏上丝一东丞丏();
    }
    private void OnDisable()
    {
        this.专丈万丈丈丌丛丝东 = false;
    }
    public PlantingButton()
    {
    
    }

}
