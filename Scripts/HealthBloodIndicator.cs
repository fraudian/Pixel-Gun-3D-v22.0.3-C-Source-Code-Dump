using UnityEngine;
public sealed class HealthBloodIndicator : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject dmg30;
    private UnityEngine.GameObject dmg20;
    private UnityEngine.GameObject dmg10;
    private UITexture vignetteTexture;
    private UnityEngine.GameObject lowHealthLabel;
    private float vignetteAlpha;
    private bool 不丞世丆丙丗丞丒下;
    private bool 丆丑东丙丂丈业东丂;
    private float 丟丆丒下丝丌且丕丄;
    private float 丙丑丈丆丘丂丝丌丏;
    private float alphaChangeMultiplier;
    public UIPanel vignetteTextureForDamage;
    public float timeChangeMultiplierForDamage;
    public float alphaChangeMultiplierForDamage;
    public float timeBeforeChangeAlpha;
    private readonly 丑业丗三丘丟丑上丈 万丅丈丑丑丂东三丆;
    private float 丙丏丏万丛东三丘东;
    
    // Methods
    internal void 丑专东丁丞丑东丁丟()
    {
        null = null;
        float val_12 = 丘七业丒丐世丂丅丒();
        val_12 = val_12 / 专一丟丏且丆丕丝七();
        if(val_12 >= 0)
        {
                if((val_12 <= 0.3f) || (this.丙丏丏万丛东三丘东 > 0.3f))
        {
            goto label_9;
        }
        
        }
        
        this.不丞世丆丙丗丞丒下 = true;
        label_21:
        if(this.不丞世丆丙丗丞丒下 != true)
        {
                bool val_4 = (val_12 > 0.1f) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dmg10, 丏业丟一东丂东丘丛:  (val_12 <= 0.1f) ? 1 : 0);
            val_4 = val_4 & ((val_12 <= 0.2f) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dmg20, 丏业丟一东丂东丘丛:  val_4);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dmg30, 丏业丟一东丂东丘丛:  ((val_12 > 0.2f) ? 1 : 0) & ((val_12 <= 0.3f) ? 1 : 0));
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lowHealthLabel, 丏业丟一东丂东丘丛:  ((val_12 > 0f) ? 1 : 0) & ((val_12 <= 0.1f) ? 1 : 0));
        if(this.万丅丈丑丑丂东三丆 != null)
        {
                this.万丅丈丑丑丂东三丆.丑专东丁丞丑东丁丟(一丅万丈丗丐七东上:  val_12);
        }
        
        this.丙丏丏万丛东三丘东 = val_12;
        return;
        label_9:
        if(val_12 > 0.3f)
        {
            goto label_21;
        }
        
        this.丂东丌世丂世丏丝业();
        goto label_21;
    }
    private void Update()
    {
        float val_8;
        float val_9;
        var val_10;
        if(this.不丞世丆丙丗丞丒下 != false)
        {
                val_8 = this.vignetteTexture.alpha;
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.alphaChangeMultiplier * val_2;
            val_9 = val_8 - val_2;
            this.vignetteTexture.alpha = val_9;
            val_10 = public System.Single UIWidget::get_alpha();
            if(this.vignetteTexture.alpha <= 0f)
        {
                this.丂东丌世丂世丏丝业();
        }
        
        }
        
        if(this.丆丑东丙丂丈业东丂 != false)
        {
                val_8 = this.丙丑丈丆丘丂丝丌丏;
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = this.timeChangeMultiplierForDamage * val_4;
            val_9 = val_8 - val_4;
            this.丙丑丈丆丘丂丝丌丏 = val_9;
            if(val_9 < 0)
        {
                val_8 = val_9;
            float val_5 = UnityEngine.Time.deltaTime;
            val_5 = this.alphaChangeMultiplierForDamage * val_5;
            val_9 = val_8 - val_5;
        }
        
        }
        
        if(val_9 <= 0f)
        {
                if(this.vignetteTextureForDamage.gameObject.activeSelf != false)
        {
                this.丆丑东丙丂丈业东丂 = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.vignetteTextureForDamage, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        if(this.万丅丈丑丑丂东三丆 == null)
        {
                return;
        }
        
        this.万丅丈丑丑丂东三丆.上专丄丑专丑丘业丌();
    }
    private void 丂东丌世丂世丏丝业()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dmg10, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dmg20, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dmg30, 丏业丟一东丂东丘丛:  false);
        this.不丞世丆丙丗丞丒下 = false;
        this.vignetteTexture.alpha = this.vignetteAlpha;
    }
    internal void 丈上业丆东丒七专丂()
    {
        this.丆丑东丙丂丈业东丂 = true;
        this.丙丑丈丆丘丂丝丌丏 = this.丟丆丒下丝丌且丕丄;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.vignetteTextureForDamage, 丏业丟一东丂东丘丛:  true);
        if(this.vignetteTextureForDamage == null)
        {
            
        }
    
    }
    public HealthBloodIndicator()
    {
        this.vignetteAlpha = 0.7843f;
        this.丟丆丒下丝丌且丕丄 = 1f;
        this.丙丑丈丆丘丂丝丌丏 = 1f;
        this.alphaChangeMultiplier = 0.5f;
        this.timeChangeMultiplierForDamage = 2.5f;
        this.alphaChangeMultiplierForDamage = 1.5f;
        this.timeBeforeChangeAlpha = 0.7f;
        this.万丅丈丑丑丂东三丆 = new 丑业丗三丘丟丑上丈();
    }

}
