using UnityEngine;
public class SiegeContainerGUI : MonoBehaviour
{
    // Fields
    public UISprite progressSprite;
    public UISprite[] colorSprites;
    public UISprite[] inverseColorSprites;
    public UISprite fortBackground;
    public UIWidget lastProgress;
    public UnityEngine.GameObject backwardArrow;
    public UnityEngine.GameObject[] forwardArrows;
    public UILabel myTeamScore;
    public UILabel enemyTeamScore;
    public UnityEngine.GameObject checkpointObj;
    private UISprite[] 丌三与丐丘丅丏丒七;
    public float barWidth;
    public float progressWidth;
    private bool 丝与丆丞东丘丈东丘;
    private bool 万三万丄上东丝丛丐;
    private bool 一丕东业丘且丞东七;
    private UnityEngine.Color 丒业与丞丁丞丙世下;
    private UnityEngine.Color 丞丕丒丗业丟丑丒丐;
    public TweenColor fortHitTween;
    private UILabel _place;
    private UnityEngine.GameObject _progress;
    
    // Methods
    private void Awake()
    {
        this.checkpointObj.SetActive(value:  false);
    }
    internal void 丑丁丒上丂丛丏上东(bool 世丁万下丗专世万丅)
    {
        世丁万下丗专世万丅 = 世丁万下丗专世万丅;
        this._progress.SetActive(value:  世丁万下丗专世万丅);
    }
    public void UpdateUI(bool 一丁且丐丑专且一上, int 丕丛三丈丂丕专下东, int 七丝丁上丑万万丛丝, 一上丕丞丙一丈七丛 万丆丈丁与世丛下不)
    {
        UnityEngine.Color val_9;
        float val_10;
        float val_11;
        float val_12;
        UILabel val_13;
        if(一丁且丐丑专且一上 == false)
        {
            goto label_1;
        }
        
        if(this.万三万丄上东丝丛丐 == false)
        {
            goto label_2;
        }
        
        val_9 = this.丞丕丒丗业丟丑丒丐;
        if(this.fortBackground != null)
        {
            goto label_18;
        }
        
        goto label_19;
        label_1:
        UnityEngine.Color val_1 = UnityEngine.Color.gray;
        val_9 = val_1.r;
        val_10 = val_1.g;
        val_11 = val_1.b;
        val_12 = val_1.a;
        if(this.fortBackground != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        this.fortBackground.color = new UnityEngine.Color() {r = val_9, g = val_10, b = val_11, a = val_12};
        if(this.myTeamScore != 0)
        {
                this.myTeamScore.text = System.String.Format(format:  "{0}m", arg0:  丕丛三丈丂丕专下东);
        }
        
        val_13 = this.enemyTeamScore;
        if(val_13 != 0)
        {
                val_13 = this.enemyTeamScore;
            val_13.text = System.String.Format(format:  "{0}m", arg0:  七丝丁上丑万万丛丝);
        }
        
        bool val_6 = UnityEngine.Object.op_Inequality(x:  this._place, y:  0);
        if(val_6 != false)
        {
                val_13 = val_6.世丗与丒世丏丙丙丑();
            this._place.text = val_13;
        }
        
        this.下丄不丑丏丞丑丐丙(七一丗丈丏丌丛世上:  一丁且丐丑专且一上, 上丕丈丞丌丘丅不与:  new 一上丕丞丙一丈七丛() {丆丄丘七东世丒丐七 = 万丆丈丁与世丛下不.丆丄丘七东世丒丐七, 上丕丈丞丌丘丅不与 = 万丆丈丁与世丛下不.上丕丈丞丌丘丅不与});
        return;
        label_2:
        if(this.fortBackground != null)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    private string 世丗与丒世丏丙丙丑()
    {
        var val_6;
        WeaponManager val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_7 != 0)
        {
                val_8 = null;
            val_8 = null;
            val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_7 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            if(val_7 != 0)
        {
                val_9 = null;
            val_9 = null;
            val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_7 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            string val_5 = 业七业丅丅丝万丕丝() + 1.ToString();
            return (string)val_10;
        }
        
        }
        
        val_10 = "1";
        return (string)val_10;
    }
    public void SetTramMoveSpeed(int 三丑丏世丂丆丕丈专, bool 一丆丆丈丁丝丆丑丄)
    {
        var val_7;
        this.backwardArrow.gameObject.SetActive(value:  一丆丆丈丁丝丆丑丄);
        val_7 = 0;
        goto label_2;
        label_8:
        this.forwardArrows[0].gameObject.SetActive(value:  ((val_7 < 三丑丏世丂丆丕丈专) ? 1 : 0) & 一丆丆丈丁丝丆丑丄 ^ 1);
        val_7 = 1;
        label_2:
        if(val_7 < this.forwardArrows.Length)
        {
            goto label_8;
        }
    
    }
    public void SetCheckpointCount(int 丌丒丝东丌下丕丁丅)
    {
        UISprite[] val_10;
        bool val_11;
        UISprite[] val_12;
        if(this.一丕东业丘且丞东七 == true)
        {
                return;
        }
        
        val_11 = true;
        this.一丕东业丘且丞东七 = val_11;
        val_12 = new UISprite[0];
        this.丌三与丐丘丅丏丒七 = val_12;
        goto label_2;
        label_22:
        UnityEngine.GameObject val_7 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.checkpointObj.gameObject.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.checkpointObj.gameObject);
        UISprite val_8 = val_7.GetComponent<UISprite>();
        if(this.丌三与丐丘丅丏丒七 == null)
        {
            goto label_11;
        }
        
        if(val_8 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_8 == null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        this.丌三与丐丘丅丏丒七[(long)(long)(int)(W25)] = val_8;
        val_7.SetActive(value:  true);
        val_10 = this.丌三与丐丘丅丏丒七;
        float val_10 = this.barWidth;
        val_10 = val_10 / (float)this.丌三与丐丘丅丏丒七.Length;
        float val_11 = 1f;
        val_11 = val_10 * val_11;
        val_7.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_12 = this.丌三与丐丘丅丏丒七;
        val_11 = 2;
        label_2:
        if(1 < this.丌三与丐丘丅丏丒七.Length)
        {
            goto label_22;
        }
    
    }
    public void UpdateProgress(一上丕丞丙一丈七丛 上丕丈丞丌丘丅不与)
    {
        float val_6;
        var val_7;
        float val_8;
        float val_9;
        float val_10;
        val_6 = this.progressWidth / (float)this.丌三与丐丘丅丏丒七.Length;
        float val_6 = (float)上丕丈丞丌丘丅不与.丆丄丘七东世丒丐七;
        val_6 = val_6 * val_6;
        float val_3 = UnityEngine.Mathf.Clamp01(value:  上丕丈丞丌丘丅不与.丆丄丘七东世丒丐七 >> 32);
        val_3 = val_6 * val_3;
        val_3 = val_3 + ((float)UnityEngine.Mathf.RoundToInt(f:  val_6));
        this.progressSprite.width = UnityEngine.Mathf.RoundToInt(f:  val_3);
        val_7 = 0;
        goto label_13;
        label_17:
        UISprite val_7 = this.丌三与丐丘丅丏丒七[0];
        if(val_7 >= 上丕丈丞丌丘丅不与.丆丄丘七东世丒丐七)
        {
            goto label_8;
        }
        
        if(this.万三万丄上东丝丛丐 == false)
        {
            goto label_9;
        }
        
        val_6 = this.丒业与丞丁丞丙世下;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        goto label_15;
        label_8:
        UnityEngine.Color val_5 = UnityEngine.Color.gray;
        val_6 = val_5.r;
        val_8 = val_5.g;
        val_9 = val_5.b;
        val_10 = val_5.a;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        val_7.color = new UnityEngine.Color() {r = val_6, g = val_8, b = val_9, a = val_10};
        val_7 = 1;
        goto label_13;
        label_9:
        if(val_7 != null)
        {
            goto label_14;
        }
        
        goto label_15;
        label_13:
        if(val_7 < this.丌三与丐丘丅丏丒七.Length)
        {
            goto label_17;
        }
    
    }
    private void 下丄不丑丏丞丑丐丙(bool 七一丗丈丏丌丛世上, 一上丕丞丙一丈七丛 上丕丈丞丌丘丅不与)
    {
        float val_6 = this.progressWidth;
        val_6 = val_6 / (float)this.丌三与丐丘丅丏丒七.Length;
        float val_7 = (float)上丕丈丞丌丘丅不与.丆丄丘七东世丒丐七;
        val_7 = val_6 * val_7;
        float val_3 = UnityEngine.Mathf.Clamp01(value:  上丕丈丞丌丘丅不与.丆丄丘七东世丒丐七 >> 32);
        val_3 = val_6 * val_3;
        val_3 = val_3 + ((float)UnityEngine.Mathf.RoundToInt(f:  val_7));
        七一丗丈丏丌丛世上 = (UnityEngine.Mathf.RoundToInt(f:  val_3)) + ((七一丗丈丏丌丛世上 != true) ? 17 : 0);
        this.lastProgress.width = 七一丗丈丏丌丛世上;
    }
    public void UpdateTeam(bool 丞丌丁万不东丅丐丒)
    {
        var val_11;
        float val_12;
        float val_13;
        var val_14;
        if(this.丝与丆丞东丘丈东丘 != false)
        {
                var val_1 = (this.万三万丄上东丝丛丐 == true) ? 1 : 0;
            val_1 = val_1 ^ 丞丌丁万不东丅丐丒;
            if(val_1 == false)
        {
                return;
        }
        
        }
        
        val_11 = 0;
        this.丝与丆丞东丘丈东丘 = true;
        this.万三万丄上东丝丛丐 = 丞丌丁万不东丅丐丒;
        goto label_2;
        label_6:
        val_12 = mem[this.万三万丄上东丝丛丐 == true ? 1152921539778035716 : 1152921539778035732];
        val_12 = (this.万三万丄上东丝丛丐 == true) ? 1152921539778035716 : 1152921539778035732;
        val_13 = mem[this.万三万丄上东丝丛丐 == true ? 1152921539778035720 : 1152921539778035736];
        val_13 = (this.万三万丄上东丝丛丐 == true) ? 1152921539778035720 : 1152921539778035736;
        this.colorSprites[0].color = new UnityEngine.Color() {r = (this.万三万丄上东丝丛丐 == true) ? this.丒业与丞丁丞丙世下 : this.丞丕丒丗业丟丑丒丐, g = (this.万三万丄上东丝丛丐 == true) ? 1152921539778035712 : 1152921539778035728, b = val_12, a = val_13};
        val_11 = 1;
        label_2:
        if(val_11 < this.colorSprites.Length)
        {
            goto label_6;
        }
        
        val_14 = 0;
        goto label_7;
        label_11:
        val_12 = mem[this.万三万丄上东丝丛丐 == true ? 1152921539778035732 : 1152921539778035716];
        val_12 = (this.万三万丄上东丝丛丐 == true) ? 1152921539778035732 : 1152921539778035716;
        val_13 = mem[this.万三万丄上东丝丛丐 == true ? 1152921539778035736 : 1152921539778035720];
        val_13 = (this.万三万丄上东丝丛丐 == true) ? 1152921539778035736 : 1152921539778035720;
        this.inverseColorSprites[0].color = new UnityEngine.Color() {r = (this.万三万丄上东丝丛丐 == true) ? this.丞丕丒丗业丟丑丒丐 : this.丒业与丞丁丞丙世下, g = (this.万三万丄上东丝丛丐 == true) ? 1152921539778035728 : 1152921539778035712, b = val_12, a = val_13};
        val_14 = 1;
        label_7:
        if(val_14 < this.inverseColorSprites.Length)
        {
            goto label_11;
        }
    
    }
    public void ShowFortHit()
    {
        this.fortHitTween.PlayForward();
    }
    public SiegeContainerGUI()
    {
        this.barWidth = 258f;
        this.progressWidth = 254f;
        this.丒业与丞丁丞丙世下 = 0;
        mem[1152921539778349824] = 0;
        mem[1152921539778349832] = 0;
        this.丞丕丒丗业丟丑丒丐 = 0;
        mem[1152921539778349840] = 0;
        mem[1152921539778349848] = 0;
    }

}
