using UnityEngine;
public class HitNumberGenerator : MonoBehaviour
{
    // Fields
    private UnityEngine.TextMesh[] textStack;
    private UnityEngine.Transform[] 丆丐丏丘丂丏专业丈;
    private UnityEngine.Transform[] tweenPoints;
    private UnityEngine.Vector3[] 丁丂业丅丛丆丂万且;
    private UnityEngine.Quaternion[] 不丛丛丄丑业丛丟丐;
    private bool[] 丄世不下专七丂丘丝;
    private float[] 专丞世丅丆专丏丈丐;
    private float animTime;
    private float timeBetween;
    private float 丅世三丒丕七三丏丁;
    private UnityEngine.AnimationCurve alphaCurve;
    private UnityEngine.AnimationCurve speedCurve;
    public bool test;
    public bool test2;
    
    // Methods
    private void Awake()
    {
        this.丘上丐世丆丑且丞丒();
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_9;
        UnityEngine.Vector3[] val_10;
        var val_11;
        float val_12;
        float val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = 0;
        this.丄世不下专七丂丘丝 = new bool[0];
        goto label_2;
        label_6:
        val_10 = 0;
        val_9 = 1;
        this.丄世不下专七丂丘丝[val_10] = true;
        label_2:
        if(val_9 < this.textStack.Length)
        {
            goto label_6;
        }
        
        val_11 = 0;
        this.丁丂业丅丛丆丂万且 = new UnityEngine.Vector3[0];
        goto label_8;
        label_15:
        val_10 = this.丁丂业丅丛丆丂万且;
        UnityEngine.Vector3 val_3 = this.tweenPoints[0].localPosition;
        val_12 = val_3.x;
        val_13 = val_3.z;
        var val_4 = val_10 + (0 * 12);
        val_11 = 1;
        mem2[0] = val_12;
        mem2[0] = val_3.y;
        mem2[0] = val_13;
        label_8:
        if(val_11 < this.textStack.Length)
        {
            goto label_15;
        }
        
        val_14 = 0;
        this.不丛丛丄丑业丛丟丐 = new UnityEngine.Quaternion[0];
        goto label_17;
        label_24:
        val_10 = 0;
        UnityEngine.Quaternion val_6 = this.tweenPoints[val_10].localRotation;
        val_12 = val_6.x;
        val_13 = val_6.z;
        val_14 = 1;
        this.不丛丛丄丑业丛丟丐[val_10] = val_6;
        this.不丛丛丄丑业丛丟丐[val_10] = val_6.y;
        this.不丛丛丄丑业丛丟丐[val_10] = val_13;
        this.不丛丛丄丑业丛丟丐[val_10] = val_6.w;
        label_17:
        if(val_14 < this.textStack.Length)
        {
            goto label_24;
        }
        
        val_15 = 0;
        this.丆丐丏丘丂丏专业丈 = new UnityEngine.Transform[0];
        goto label_26;
        label_37:
        val_10 = 0;
        UnityEngine.Transform val_8 = this.textStack[val_10].transform;
        if(this.丆丐丏丘丂丏专业丈 == null)
        {
            goto label_30;
        }
        
        if(val_8 != null)
        {
            goto label_31;
        }
        
        goto label_34;
        label_30:
        if(val_8 == null)
        {
            goto label_34;
        }
        
        label_31:
        label_34:
        val_15 = 1;
        this.丆丐丏丘丂丏专业丈[val_10] = val_8;
        label_26:
        if(val_15 < this.textStack.Length)
        {
            goto label_37;
        }
        
        val_16 = 0;
        this.专丞世丅丆专丏丈丐 = new float[0];
        goto label_39;
        label_43:
        val_16 = 1;
        this.专丞世丅丆专丏丈丐[0] = 0f;
        label_39:
        if(val_16 < this.textStack.Length)
        {
            goto label_43;
        }
    
    }
    public void ShowText(int 丞丈专下丈专业三丞, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        this.textStack[(long)this.丑业丘丟丙丗丟东丆()].text = 丞丈专下丈专业三丞.ToString();
        this.textStack[(long)this.丑业丘丟丙丗丟东丆()].color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        this.textStack[(long)this.丑业丘丟丙丗丟东丆()].gameObject.SetActive(value:  true);
        this.专丞世丅丆专丏丈丐[(long)this.丑业丘丟丙丗丟东丆()] = -this.丅世三丒丕七三丏丁;
        float val_7 = this.timeBetween;
        val_7 = this.丅世三丒丕七三丏丁 + val_7;
        this.丅世三丒丕七三丏丁 = val_7;
    }
    private void 丗丝丁丛丑丂丒丝丆()
    {
        this.test = false;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.ShowText(丞丈专下丈专业三丞:  22, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
    }
    private void 专丌下丐上丗丕丄且()
    {
        this.test2 = false;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.ShowText(丞丈专下丈专业三丞:  22, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.ShowText(丞丈专下丈专业三丞:  34, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        UnityEngine.Color val_3 = UnityEngine.Color.blue;
        this.ShowText(丞丈专下丈专业三丞:  11, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        UnityEngine.Color val_4 = UnityEngine.Color.red;
        this.ShowText(丞丈专下丈专业三丞:  43, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        UnityEngine.Color val_5 = UnityEngine.Color.white;
        this.ShowText(丞丈专下丈专业三丞:  11, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
    }
    private void Update()
    {
        float val_2;
        var val_3;
        if(this.test != false)
        {
                this.丗丝丁丛丑丂丒丝丆();
        }
        
        if(this.test2 != false)
        {
                this.专丌下丐上丗丕丄且();
        }
        
        val_2 = this.丅世三丒丕七三丏丁;
        if(val_2 > 0f)
        {
                val_2 = val_2 - UnityEngine.Time.unscaledDeltaTime;
            this.丅世三丒丕七三丏丁 = val_2;
        }
        
        if(val_2 < 0)
        {
                this.丅世三丒丕七三丏丁 = 0f;
        }
        
        val_3 = 0;
        goto label_4;
        label_9:
        if(this.丄世不下专七丂丘丝[0] != true)
        {
                this.七一丈丟一世丄丝专(丁业世丅丌丛上下与:  0);
        }
        
        val_3 = 1;
        label_4:
        if(val_3 < this.textStack.Length)
        {
            goto label_9;
        }
    
    }
    private void 七一丈丟一世丄丝专(int 丁业世丅丌丛上下与)
    {
        if(this.专丞世丅丆专丏丈丐[(long)丁业世丅丌丛上下与] > this.animTime)
        {
                if(this.textStack[(long)丁业世丅丌丛上下与].gameObject.activeSelf == false)
        {
                return;
        }
        
            this.丄世不下专七丂丘丝[(long)丁业世丅丌丛上下与] = true;
            this.textStack[(long)丁业世丅丌丛上下与].gameObject.SetActive(value:  false);
            return;
        }
        
        float val_4 = UnityEngine.Time.unscaledDeltaTime;
        val_4 = this.专丞世丅丆专丏丈丐[(long)丁业世丅丌丛上下与] + val_4;
        this.专丞世丅丆专丏丈丐[(long)丁业世丅丌丛上下与] = val_4;
        float val_16 = this.专丞世丅丆专丏丈丐[(long)丁业世丅丌丛上下与];
        val_16 = val_16 / this.animTime;
        UnityEngine.Color val_5 = this.textStack[(long)丁业世丅丌丛上下与].color;
        this.textStack[(long)丁业世丅丌丛上下与].color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = this.alphaCurve.Evaluate(time:  val_16)};
        float val_7 = this.speedCurve.Evaluate(time:  val_16);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        var val_20 = 12;
        val_20 = this.丁丂业丅丛丆丂万且 + ((long)丁业世丅丌丛上下与 * val_20);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(丁业世丅丌丛上下与) * 12) + this.丁丂业丅丛丆丂万且 + 32, y = ((long)(int)(丁业世丅丌丛上下与) * 12) + this.丁丂业丅丛丆丂万且 + 32 + 4, z = ((long)(int)(丁业世丅丌丛上下与) * 12) + this.丁丂业丅丛丆丂万且 + 40}, t:  val_7);
        this.丆丐丏丘丂丏专业丈[(long)丁业世丅丌丛上下与].localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, b:  new UnityEngine.Quaternion() {x = this.不丛丛丄丑业丛丟丐[(long)丁业世丅丌丛上下与], y = this.不丛丛丄丑业丛丟丐[(long)丁业世丅丌丛上下与], z = this.不丛丛丄丑业丛丟丐[(long)丁业世丅丌丛上下与], w = this.不丛丛丄丑业丛丟丐[(long)丁业世丅丌丛上下与]}, t:  val_7);
        this.丆丐丏丘丂丏专业丈[(long)丁业世丅丌丛上下与].localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
    }
    private int 丑业丘丟丙丗丟东丆()
    {
        var val_1;
        System.Boolean[] val_2;
        val_1 = 0;
        goto label_0;
        label_5:
        val_2 = 0;
        if(this.丄世不下专七丂丘丝[val_2] == true)
        {
            goto label_3;
        }
        
        val_1 = 1;
        label_0:
        val_2 = this.丄世不下专七丂丘丝;
        if(val_1 < this.丄世不下专七丂丘丝.Length)
        {
            goto label_5;
        }
        
        return (int)val_1;
        label_3:
        this.丄世不下专七丂丘丝[val_2] = false;
        return (int)val_1;
    }
    public HitNumberGenerator()
    {
        this.animTime = 1f;
        this.timeBetween = 7.346868E-41f;
    }

}
