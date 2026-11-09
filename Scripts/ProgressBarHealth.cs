using UnityEngine;
public class ProgressBarHealth : MonoBehaviour
{
    // Fields
    public UnityEngine.Color[] barColors;
    public UnityEngine.Color[] barBackColors;
    public UnityEngine.GameObject healthBar;
    public UnityEngine.Transform healthProgress;
    public UILabel healthLabel;
    public UISprite healthSprite;
    public UIBasicSprite barSprite;
    public UIBasicSprite barBackSprite;
    private float 不丙丙且丈丅丙丄世;
    public ProgressBarHealth.且下丞丕不三业丁丒 curTypeBar;
    private float 丛丕三上世丗丂丟丞;
    private float 丆与七丈丆专七丒丙;
    public static bool ShowRealHealth;
    private System.Text.StringBuilder 专丁下七丞丂丏下丕;
    
    // Properties
    private float 万三丒与三上业丆三 { get; }
    private float 三丄丗世丌丂丗丞东 { get; }
    private float 世丞丏丏丈专丂东丁 { get; }
    
    // Methods
    private float 专一丟丏且丆丕丝七()
    {
        Player_move_c val_3 = this;
        且下丞丕不三业丁丒 val_3 = this.curTypeBar;
        val_3 = val_3 - 1;
        if(val_3 > 6)
        {
                return (float);
        }
        
        var val_4 = 106030508 + ((this.curTypeBar - 1)) << 2;
        val_4 = val_4 + 106030508;
        goto (106030508 + ((this.curTypeBar - 1)) << 2 + 106030508);
    }
    private float 三丏丟不丆丅丞不丛()
    {
        var val_12 = this;
        且下丞丕不三业丁丒 val_12 = this.curTypeBar;
        val_12 = val_12 - 1;
        if(val_12 > 6)
        {
                return 100f;
        }
        
        var val_13 = 106030536 + ((this.curTypeBar - 1)) << 2;
        val_13 = val_13 + 106030536;
        goto (106030536 + ((this.curTypeBar - 1)) << 2 + 106030536);
    }
    private float 丙丈丄世丟丟七丒三()
    {
        UnityEngine.Object val_18 = this;
        且下丞丕不三业丁丒 val_18 = this.curTypeBar;
        val_18 = val_18 - 1;
        if(val_18 > 6)
        {
                return 0f;
        }
        
        var val_19 = 106030564 + ((this.curTypeBar - 1)) << 2;
        val_19 = val_19 + 106030564;
        goto (106030564 + ((this.curTypeBar - 1)) << 2 + 106030564);
    }
    public void SetTypeBar(ProgressBarHealth.且下丞丕不三业丁丒 丂丟三丕丙丌丝丈丒)
    {
        UnityEngine.GameObject val_12;
        if(this.curTypeBar == 丂丟三丕丙丌丝丈丒)
        {
                return;
        }
        
        val_12 = this.healthBar;
        this.curTypeBar = 丂丟三丕丙丌丝丈丒;
        this.丛丕三上世丗丂丟丞 = -1f;
        this.丆与七丈丆专七丒丙 = -1f;
        if(val_12 == null)
        {
            goto label_2;
        }
        
        if(丂丟三丕丙丌丝丈丒 == 0)
        {
            goto label_3;
        }
        
        label_13:
        val_12.SetActive(value:  true);
        且下丞丕不三业丁丒 val_12 = this.curTypeBar;
        val_12 = val_12 - 1;
        if(val_12 > 6)
        {
            goto label_4;
        }
        
        var val_13 = 106030592 + ((this.curTypeBar - 1)) << 2;
        val_13 = val_13 + 106030592;
        goto (106030592 + ((this.curTypeBar - 1)) << 2 + 106030592);
        label_2:
        if(丂丟三丕丙丌丝丈丒 != 0)
        {
            goto label_13;
        }
        
        label_3:
        val_12.SetActive(value:  false);
        return;
        label_4:
        if((???) == (??? + 92))
        {
                return;
        }
        
        ???.UpdateHealthBar(丝三不七丑丏一业丑:  ???.三丏丟不丆丅丞不丛());
    }
    public void UpdateHealthBar(float 丝三不七丑丏一业丑 = -1)
    {
        float val_6 = 丝三不七丑丏一业丑;
        if(val_6 < 0)
        {
                val_6 = this.三丏丟不丆丅丞不丛();
        }
        
        if(this.丛丕三上世丗丂丟丞 == val_6)
        {
                if(this.丆与七丈丆专七丒丙 == this.专一丟丏且丆丕丝七())
        {
                return;
        }
        
        }
        
        if(this.curTypeBar == 0)
        {
                return;
        }
        
        this.丛丕三上世丗丂丟丞 = UnityEngine.Mathf.Max(a:  0f, b:  val_6);
        float val_4 = this.专一丟丏且丆丕丝七();
        this.丆与七丈丆专七丒丙 = val_4;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.healthBar, 丏业丟一东丂东丘丛:  (val_4 > 0f) ? 1 : 0);
        this.UpdateStringBuilder();
    }
    public void UpdateStringBuilder()
    {
        UnityEngine.Transform val_14;
        var val_15;
        System.Text.StringBuilder val_16;
        string val_17;
        val_14 = this;
        if(this.丆与七丈丆专七丒丙 <= 0f)
        {
                return;
        }
        
        this.专丁下七丞丂丏下丕.Length = 0;
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_6;
        }
        
        val_15 = null;
        val_15 = null;
        if(ProgressBarHealth.ShowRealHealth == false)
        {
            goto label_6;
        }
        
        System.Text.StringBuilder val_3 = this.专丁下七丞丂丏下丕.Append(value:  UnityEngine.Mathf.CeilToInt(f:  this.丛丕三上世丗丂丟丞));
        System.Text.StringBuilder val_4 = this.专丁下七丞丂丏下丕.Append(value:  "%");
        System.Text.StringBuilder val_5 = this.专丁下七丞丂丏下丕.Append(value:  " (");
        System.Text.StringBuilder val_8 = this.专丁下七丞丂丏下丕.Append(value:  UnityEngine.Mathf.CeilToInt(f:  this.丙丈丄世丟丟七丒三()));
        val_16 = this.专丁下七丞丂丏下丕;
        val_17 = ")";
        goto label_14;
        label_6:
        System.Text.StringBuilder val_10 = this.专丁下七丞丂丏下丕.Append(value:  UnityEngine.Mathf.CeilToInt(f:  this.丛丕三上世丗丂丟丞));
        val_16 = this.专丁下七丞丂丏下丕;
        val_17 = "%";
        label_14:
        System.Text.StringBuilder val_11 = val_16.Append(value:  val_17);
        this.healthLabel.text = this.专丁下七丞丂丏下丕;
        float val_13 = UnityEngine.Mathf.Clamp01(value:  this.丛丕三上世丗丂丟丞 / this.丆与七丈丆专七丒丙);
        val_14 = this.healthProgress;
        val_14.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Start()
    {
        if((((((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != false) && (GameConnect.丛专丌且丕不专丈下() != true)) && (GameConnect.丁丁丗丐东丄丞一丛() != true)) && (GameConnect.与丈丘丈上丌丝丝丛() != true)) && (GameConnect.丆丕丒与丂七与下上() != true))
        {
                if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
            goto label_20;
        }
        
        }
        
        }
        
        this.SetTypeBar(丂丟三丕丙丌丝丈丒:  0);
        label_20:
        this.UpdateHealthBar(丝三不七丑丏一业丑:  this.三丏丟不丆丅丞不丛());
    }
    private void Update()
    {
        float val_10 = this.专一丟丏且丆丕丝七();
        float val_11 = 100f;
        float val_3 = this.不丙丙且丈丅丙丄世 * val_10;
        val_10 = val_3 * UnityEngine.Time.deltaTime;
        if(this.丛丕三上世丗丂丟丞 > this.三丏丟不丆丅丞不丛())
        {
                if(this.丛丕三上世丗丂丟丞 > this.专一丟丏且丆丕丝七())
        {
                this.丛丕三上世丗丂丟丞 = this.三丏丟不丆丅丞不丛();
        }
        
        }
        
        val_11 = val_10 / val_11;
        val_3 = this.丛丕三上世丗丂丟丞 - val_11;
        this.UpdateHealthBar(丝三不七丑丏一业丑:  UnityEngine.Mathf.Clamp(value:  this.三丏丟不丆丅丞不丛(), min:  val_3, max:  val_11 + this.丛丕三上世丗丂丟丞));
    }
    public ProgressBarHealth()
    {
        this.不丙丙且丈丅丙丄世 = 150f;
        this.丛丕三上世丗丂丟丞 = -1f;
        this.丆与七丈丆专七丒丙 = -1f;
        this.专丁下七丞丂丏下丕 = new System.Text.StringBuilder(capacity:  10);
    }
    private static ProgressBarHealth()
    {
        ProgressBarHealth.ShowRealHealth = true;
    }

}
