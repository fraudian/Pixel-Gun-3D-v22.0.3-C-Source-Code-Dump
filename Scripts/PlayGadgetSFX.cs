using UnityEngine;
public class PlayGadgetSFX : MonoBehaviour
{
    // Fields
    public PlayGadgetSFX.丗世且三丈一丐丗且 ifLowDevice;
    public float time;
    public UnityEngine.AnimationCurve alphaChange;
    public UIWidget sfxSpriteContainer;
    public UnityEngine.GameObject[] particles;
    private UILabel 丟丙丛上丆丁丕三三;
    private float 丙一丑丏丁一且丒业;
    private bool 下丐丈丄丗丞丕业丆;
    private bool 丆七丌丐丑丙一丆丄;
    private bool 丛业东丌世专丒三下;
    private bool 丝丗丄上丂丟丁丑丟;
    private float 丐丗丅万上不丑一丕;
    public UnityEngine.GameObject sfx;
    
    // Properties
    public bool 丑丄业丁且丅丘且世 { get; }
    
    // Methods
    public bool get_IsPlaying()
    {
        return (bool)this.下丐丈丄丗丞丕业丆;
    }
    private void Start()
    {
        null = null;
        this.丆七丌丐丑丙一丆丄 = 东丗上丁下业一丂丂.丆丒一专且业七丟丈;
    }
    public void Play()
    {
        if((this.丆七丌丐丑丙一丆丄 != false) && (this.ifLowDevice == 2))
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.time;
        this.下丐丈丄丗丞丕业丆 = true;
        val_1 = val_1 + this.time;
        this.丙一丑丏丁一且丒业 = val_1;
        this.sfx.SetActive(value:  true);
    }
    public void Play(float 丅丁丙丁万上丂七丈)
    {
        this.time = 丅丁丙丁万上丂七丈;
        this.Play();
    }
    public void Play(bool 丗丅丞丄丏七丕丅丈)
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + this.time;
        this.丛业东丌世专丒三下 = true;
        this.丝丗丄上丂丟丁丑丟 = 丗丅丞丄丏七丕丅丈;
        this.丙一丑丏丁一且丒业 = val_1;
        this.下丐丈丄丗丞丕业丆 = true;
        this.sfx.SetActive(value:  true);
    }
    public void Stop()
    {
        this.下丐丈丄丗丞丕业丆 = false;
        this.sfx.SetActive(value:  false);
    }
    private void Update()
    {
        UnityEngine.GameObject[] val_18;
        var val_19;
        var val_20;
        UnityEngine.AnimationCurve val_21;
        float val_22;
        val_19 = this;
        if(this.下丐丈丄丗丞丕业丆 == false)
        {
                return;
        }
        
        if(this.丆七丌丐丑丙一丆丄 == false)
        {
            goto label_6;
        }
        
        this.sfxSpriteContainer.gameObject.SetActive(value:  (this.ifLowDevice != 1) ? 1 : 0);
        val_18 = this.particles;
        if(this.particles.Length == 0)
        {
            goto label_6;
        }
        
        val_20 = 0;
        goto label_7;
        label_12:
        this.particles[0].SetActive(value:  (this.ifLowDevice != 0) ? 1 : 0);
        val_20 = 1;
        label_7:
        val_18 = this.particles;
        if(val_20 < this.particles.Length)
        {
            goto label_12;
        }
        
        label_6:
        if(this.丛业东丌世专丒三下 == false)
        {
            goto label_13;
        }
        
        if(this.丝丗丄上丂丟丁丑丟 == false)
        {
            goto label_14;
        }
        
        float val_7 = UnityEngine.Mathf.Max(a:  0f, b:  (this.丙一丑丏丁一且丒业 - this.丐丗丅万上不丑一丕) - UnityEngine.Time.time);
        val_7 = val_7 / this.time;
        val_7 = 1f - val_7;
        float val_8 = this.alphaChange.Evaluate(time:  val_7);
        val_18 = ???;
        val_19 = ???;
        goto typeof(UIWidget).__il2cppRuntimeField_1A8;
        label_13:
        float val_11 = UnityEngine.Mathf.Max(a:  0f, b:  (val_19 + 64) - UnityEngine.Time.time);
        val_21 = mem[val_19 + 32];
        val_21 = val_19 + 32;
        val_11 = val_11 / (val_19 + 28);
        val_11 = 1f - val_11;
        float val_12 = val_21.Evaluate(time:  val_11);
        val_22 = mem[val_19 + 64];
        val_22 = val_19 + 64;
        float val_13 = UnityEngine.Time.time;
        if(val_22 < 0)
        {
            goto label_23;
        }
        
        return;
        label_14:
        float val_16 = UnityEngine.Mathf.Max(a:  0f, b:  this.丙一丑丏丁一且丒业 - UnityEngine.Time.time);
        val_21 = this.alphaChange;
        val_22 = val_16;
        this.丐丗丅万上不丑一丕 = val_22;
        val_16 = val_22 / this.time;
        float val_17 = val_21.Evaluate(time:  val_16);
        if(val_22 != 0f)
        {
                return;
        }
        
        this.丛业东丌世专丒三下 = false;
        label_23:
        this.Stop();
    }
    internal void 丒丁丅一下丂专万不(string 丕丗丘丑丛与丑业丒)
    {
        UILabel val_6;
        if(this.丟丙丛上丆丁丕三三 == 0)
        {
                val_6 = this.transform.GetChild(index:  0).GetComponentInChildren<UILabel>();
            this.丟丙丛上丆丁丕三三 = val_6;
        }
        else
        {
                val_6 = this.丟丙丛上丆丁丕三三;
        }
        
        if(val_6 == 0)
        {
                return;
        }
        
        this.丟丙丛上丆丁丕三三.text = 丕丗丘丑丛与丑业丒;
    }
    public PlayGadgetSFX()
    {
        this.time = 1f;
        UnityEngine.AnimationCurve val_1 = new UnityEngine.AnimationCurve();
        UnityEngine.Keyframe[] val_2 = new UnityEngine.Keyframe[3];
        val_2[0] = 0;
        val_2[0] = 0;
        val_2[1] = 0;
        val_2[1] = 0;
        val_2[2] = 0;
        val_2[2] = 0;
        if(val_1 != null)
        {
                val_1.keys = val_2;
            val_1.postWrapMode = 2;
        }
        else
        {
                val_1.keys = val_2;
            val_1.postWrapMode = 2;
        }
        
        val_1.preWrapMode = 2;
        this.alphaChange = val_1;
    }

}
