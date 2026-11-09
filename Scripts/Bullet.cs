using UnityEngine;
internal sealed class Bullet : MonoBehaviour
{
    // Fields
    private static float 丘丛丝世丄丄丑三丁;
    public float lifeS;
    public float lifeSqrS;
    public UnityEngine.TrailRenderer myRender;
    private float 三丞丁三丂丏丟丌丌;
    private float 且与丙丑丕专七丈专;
    private UnityEngine.Vector3 丒丈丘业丛丁丏丙丘;
    private bool 丛不丁丝丌丗专丂丛;
    private float 上丈东专丟业且丈丛;
    public bool isUse;
    public UnityEngine.Vector3 endPos;
    public UnityEngine.Vector3 startPos;
    public UnityEngine.LineRenderer lineReder;
    public float fadeSpeed;
    public float startAlpha;
    public float minBulletSize;
    public float maxWidthOfTracer;
    public float tracerWithMulti;
    private float 丛业上丄丏丛丞丆丕;
    public float maxBuleltSize;
    private float 且世三丏丒且业与与;
    public bool breakIt;
    private float 丞丛上与丁丒丝丙下;
    private bool 三七专万丙丙业丌丄;
    
    // Methods
    private void Start()
    {
        float val_8;
        float val_9;
        this.lineReder.enabled = false;
        UnityEngine.Color val_1 = this.lineReder.startColor;
        UnityEngine.Color val_2 = this.lineReder.startColor;
        if(this.三七专万丙丙业丌丄 != false)
        {
                PlayerCoreSettingsStorager val_3 = PlayerCoreSettingsStorager.Instance;
            val_8 = val_3.tracerStartAlpha;
        }
        else
        {
                val_8 = this.startAlpha;
        }
        
        this.lineReder.startColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Color val_4 = this.lineReder.endColor;
        UnityEngine.Color val_5 = this.lineReder.endColor;
        if(this.三七专万丙丙业丌丄 != false)
        {
                PlayerCoreSettingsStorager val_6 = PlayerCoreSettingsStorager.Instance;
            val_9 = val_6.tracerStartAlpha;
        }
        else
        {
                val_9 = this.startAlpha;
        }
        
        this.lineReder.endColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.gameObject.SetActive(value:  false);
    }
    public void StartBullet(bool 三丌丈丏上丑与丙丛 = False)
    {
        int val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        bool val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        this.gameObject.SetActive(value:  true);
        this.CancelInvoke(methodName:  "RemoveSelf");
        this.Invoke(methodName:  "RemoveSelf", time:  this.且与丙丑丕专七丈专);
        this.transform.position = new UnityEngine.Vector3() {x = this.startPos, y = V9.16B, z = V10.16B};
        this.isUse = true;
        UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[2];
        val_25 = val_3.Length;
        if(val_25 == 0)
        {
                val_25 = val_3.Length;
        }
        
        val_3[0] = this.startPos;
        val_3[0] = new UnityEngine.Vector3();
        val_3[1] = new UnityEngine.Vector3();
        val_3[1] = this.endPos;
        val_3[2] = new UnityEngine.Vector3();
        val_3[2] = new UnityEngine.Vector3();
        this.lineReder.SetPositions(positions:  val_3);
        if(this.三七专万丙丙业丌丄 == false)
        {
            goto label_7;
        }
        
        PlayerCoreSettingsStorager val_4 = PlayerCoreSettingsStorager.Instance;
        PlayerCoreSettingsStorager val_5 = PlayerCoreSettingsStorager.Instance;
        val_26 = val_4.maxWidthOfTracer * val_5.tracerWithMulti;
        goto label_12;
        label_7:
        if(丘丐丘万丌丟丞下丝.三不丌丄丟上三业丟() != true)
        {
                if(丘丐丘万丌丟丞下丝.专丄丄不丝丒丆丄丅() == false)
        {
            goto label_18;
        }
        
        }
        
        val_27 = this.tracerWithMulti;
        val_28 = this.maxWidthOfTracer + this.maxWidthOfTracer;
        goto label_19;
        label_18:
        val_28 = this.maxWidthOfTracer;
        val_27 = this.tracerWithMulti;
        label_19:
        val_26 = val_28 * val_27;
        label_12:
        this.且世三丏丒且业与与 = val_26;
        float val_26 = this.fadeSpeed;
        this.丛不丁丝丌丗专丂丛 = false;
        float val_25 = 0.5f;
        val_25 = val_26 * val_25;
        val_26 = (丘丐丘万丌丟丞下丝.三不丌丄丟上三业丟() != true) ? (val_25) : (val_26);
        this.丞丛上与丁丒丝丙下 = val_26;
        float val_9 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.startPos, y = V12.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.endPos, y = V9.16B, z = this.startPos});
        if(this.三七专万丙丙业丌丄 == false)
        {
            goto label_24;
        }
        
        PlayerCoreSettingsStorager val_10 = PlayerCoreSettingsStorager.Instance;
        float val_27 = val_10.tracerMinBulletSize;
        val_29 = this.丛业上丄丏丛丞丆丕;
        val_27 = this.maxBuleltSize - val_27;
        val_30 = val_27 / val_29;
        if(this.三七专万丙丙业丌丄 == false)
        {
            goto label_28;
        }
        
        PlayerCoreSettingsStorager val_11 = PlayerCoreSettingsStorager.Instance;
        val_29 = this.丛业上丄丏丛丞丆丕;
        val_31 = this.三七专万丙丙业丌丄;
        val_32 = val_11.maxWidthOfTracer;
        goto label_32;
        label_24:
        float val_28 = this.minBulletSize;
        val_29 = this.丛业上丄丏丛丞丆丕;
        val_28 = this.maxBuleltSize - val_28;
        val_30 = val_28 / val_29;
        label_28:
        val_31 = 0;
        val_32 = this.maxWidthOfTracer;
        label_32:
        float val_13 = val_32 - this.且世三丏丒且业与与;
        if(val_31 != 0)
        {
                PlayerCoreSettingsStorager val_14 = PlayerCoreSettingsStorager.Instance;
            val_33 = this.maxBuleltSize;
            val_34 = val_14.tracerMinBulletSize;
        }
        else
        {
                val_34 = this.minBulletSize;
            val_33 = this.maxBuleltSize;
        }
        
        val_13 = val_13 / val_29;
        val_29 = this.maxBuleltSize - (val_9 * val_30);
        float val_16 = val_9 * val_13;
        this.上丈东专丟业且丈丛 = UnityEngine.Mathf.Clamp(value:  val_29, min:  val_34, max:  val_33);
        if(this.三七专万丙丙业丌丄 != false)
        {
                PlayerCoreSettingsStorager val_17 = PlayerCoreSettingsStorager.Instance;
            val_35 = val_17.maxWidthOfTracer;
        }
        else
        {
                val_35 = this.maxWidthOfTracer;
        }
        
        val_16 = val_16 + this.且世三丏丒且业与与;
        this.lineReder.startWidth = UnityEngine.Mathf.Clamp(value:  val_16, min:  this.且世三丏丒且业与与, max:  val_35);
        if(this.三七专万丙丙业丌丄 != false)
        {
                PlayerCoreSettingsStorager val_19 = PlayerCoreSettingsStorager.Instance;
            val_36 = val_19.tracerStartAlpha;
        }
        else
        {
                val_36 = this.startAlpha;
        }
        
        var val_20 = (三丌丈丏上丑与丙丛 != true) ? 0.9f : (val_36);
        UnityEngine.Color val_21 = this.lineReder.startColor;
        UnityEngine.Color val_22 = this.lineReder.startColor;
        this.lineReder.startColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Color val_23 = this.lineReder.endColor;
        UnityEngine.Color val_24 = this.lineReder.endColor;
        this.lineReder.endColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.lineReder.enabled = true;
        if(this.breakIt == false)
        {
                return;
        }
        
        UnityEngine.Debug.Break();
    }
    private void RemoveSelf()
    {
        var val_9;
        float val_10;
        float val_11;
        val_9 = this;
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.lineReder.enabled = false;
        this.isUse = false;
        this.gameObject.SetActive(value:  false);
        UnityEngine.Color val_3 = this.lineReder.startColor;
        UnityEngine.Color val_4 = this.lineReder.startColor;
        if(this.三七专万丙丙业丌丄 != false)
        {
                PlayerCoreSettingsStorager val_5 = PlayerCoreSettingsStorager.Instance;
            val_10 = val_5.tracerStartAlpha;
        }
        else
        {
                val_10 = this.startAlpha;
        }
        
        this.lineReder.startColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Color val_6 = this.lineReder.endColor;
        UnityEngine.Color val_7 = this.lineReder.endColor;
        if(this.三七专万丙丙业丌丄 != false)
        {
                val_9 = PlayerCoreSettingsStorager.Instance;
            val_11 = val_8.tracerStartAlpha;
        }
        else
        {
                val_11 = this.startAlpha;
        }
        
        this.lineReder.endColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void Update()
    {
        float val_10;
        if(this.isUse == false)
        {
                return;
        }
        
        if(this.丛不丁丝丌丗专丂丛 != false)
        {
                this.RemoveSelf();
            return;
        }
        
        UnityEngine.Color val_1 = this.lineReder.startColor;
        if(this.三七专万丙丙业丌丄 != false)
        {
                PlayerCoreSettingsStorager val_2 = PlayerCoreSettingsStorager.Instance;
            val_10 = val_2.tracerFadeSpeed;
        }
        else
        {
                val_10 = this.丞丛上与丁丒丝丙下;
        }
        
        UnityEngine.Color val_6 = this.lineReder.startColor;
        UnityEngine.Color val_7 = this.lineReder.startColor;
        this.lineReder.startColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Color val_8 = this.lineReder.endColor;
        UnityEngine.Color val_9 = this.lineReder.endColor;
        this.lineReder.endColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if((UnityEngine.Mathf.Lerp(a:  val_1.a, b:  0f, t:  val_10 * UnityEngine.Time.deltaTime)) > 0.01f)
        {
                return;
        }
        
        this.丛不丁丝丌丗专丂丛 = true;
    }
    public Bullet()
    {
        this.lifeS = 100f;
        this.lifeSqrS = 2.295887E-41f;
        this.且与丙丑丕专七丈专 = 2f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丒丈丘业丛丁丏丙丘 = val_1;
        mem[1152921539904714116] = val_1.y;
        this.上丈东专丟业且丈丛 = 0.1f;
        mem[1152921539904714120] = val_1.z;
        this.tracerWithMulti = 1f;
        this.丛业上丄丏丛丞丆丕 = 10f;
        this.fadeSpeed = ;
        this.startAlpha = ;
        this.minBulletSize = 0.1f;
        this.maxWidthOfTracer = 0.05f;
        this.maxBuleltSize = 1f;
    }
    private static Bullet()
    {
        Bullet.丘丛丝世丄丄丑三丁 = 500f;
    }

}
