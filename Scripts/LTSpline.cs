using UnityEngine;
[Serializable]
public class LTSpline
{
    // Fields
    public UnityEngine.Vector3[] pts;
    public bool orientToPath;
    private float[] lengthRatio;
    private float[] lengths;
    private int numSections;
    private int currPt;
    private float totalLength;
    
    // Methods
    public LTSpline(UnityEngine.Vector3[] 丑丂丈丗且东丒丌七)
    {
        var val_11;
        float val_12;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
        this.pts = val_1;
        if(丑丂丈丗且东丒丌七 != null)
        {
                System.Array.Copy(sourceArray:  丑丂丈丗且东丒丌七, destinationArray:  val_1, length:  丑丂丈丗且东丒丌七.Length);
        }
        else
        {
                System.Array.Copy(sourceArray:  丑丂丈丗且东丒丌七, destinationArray:  val_1, length:  丑丂丈丗且东丒丌七.Length);
        }
        
        int val_11 = 丑丂丈丗且东丒丌七.Length;
        val_11 = val_11 - 3;
        this.numSections = val_11;
        this.lengthRatio = new float[20];
        this.lengths = new float[20];
        this.totalLength = 0f;
        var val_14 = 0;
        do
        {
            float val_12 = 0f;
            val_12 = val_12 / 20f;
            UnityEngine.Vector3 val_4 = this.上七丕一丌专丌丕三(丙丒七丄上与丏丙丙:  val_12);
            if(val_14 >= 1)
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.lengths[val_14] = val_5.x;
        }
        
            float val_13 = this.lengths[val_14];
            val_14 = val_14 + 1;
            val_13 = this.totalLength + val_13;
            this.totalLength = val_13;
        }
        while(val_14 != 20);
        
        val_11 = 0;
        val_12 = 0f;
        goto label_12;
        label_21:
        int val_15 = this.lengths.Length;
        val_15 = val_15 - 1;
        float val_16 = (float)this.numSections;
        val_16 = (0f / (float)val_15) * val_16;
        this.currPt = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  val_16), b:  this.numSections - 1);
        val_12 = val_12 + (this.lengths[0] / this.totalLength);
        val_11 = 1;
        this.lengthRatio[0] = val_12;
        label_12:
        if(val_11 < this.lengths.Length)
        {
            goto label_21;
        }
    
    }
    public float 丞丁丑丏丄丏七丂不(float 丙丒七丄上与丏丙丙)
    {
        System.Single[] val_1;
        var val_2;
        float val_3;
        System.Single[] val_4;
        val_1 = this;
        val_2 = 0;
        val_3 = 1f;
        goto label_0;
        label_5:
        val_4 = 0;
        if(this.lengthRatio[val_4] >= 丙丒七丄上与丏丙丙)
        {
            goto label_3;
        }
        
        val_2 = 1;
        label_0:
        val_4 = this.lengthRatio;
        if(val_2 < this.lengthRatio.Length)
        {
            goto label_5;
        }
        
        return (float)val_3;
        label_3:
        val_1 = this.lengthRatio;
        float val_3 = val_1[val_4];
        val_3 = 丙丒七丄上与丏丙丙 - val_3;
        val_3 = this.lengthRatio[val_4] + val_3;
        return (float)val_3;
    }
    public UnityEngine.Vector3 上七丕一丌专丌丕三(float 丙丒七丄上与丏丙丙)
    {
        float val_30 = (float)this.numSections;
        val_30 = val_30 * 丙丒七丄上与丏丙丙;
        int val_3 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  val_30), b:  this.numSections - 1);
        this.currPt = val_3;
        var val_31 = 12;
        val_31 = this.pts + ((long)val_3 * val_31);
        var val_32 = 12;
        val_32 = this.pts + (((long)this.currPt + 1) * val_32);
        var val_33 = 12;
        val_33 = this.pts + (((long)this.currPt + 2) * val_33);
        float val_34 = (float)this.numSections;
        val_34 = val_34 * 丙丒七丄上与丏丙丙;
        var val_35 = 12;
        val_35 = this.pts + (((long)this.currPt + 3) * val_35);
        float val_7 = val_34 - (float)val_3;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_3) * 12) + this.pts + 32, y = ((long)(int)(val_3) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_3) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 32, y = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 32 + 4, z = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 32, y = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 36, z = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((this.currPt + 3)) * 12) + this.pts + 32, y = ((long)(int)((this.currPt + 3)) * 12) + this.pts + 36, z = ((long)(int)((this.currPt + 3)) * 12) + this.pts + 40});
        float val_36 = val_7;
        float val_14 = val_36 * val_36;
        val_36 = val_36 * val_14;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  val_36);
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(val_3) * 12) + this.pts + 32, y = ((long)(int)(val_3) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_3) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(d:  5f, a:  new UnityEngine.Vector3() {x = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 32, y = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 32 + 4, z = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  4f, a:  new UnityEngine.Vector3() {x = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 32, y = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 36, z = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((this.currPt + 3)) * 12) + this.pts + 32, y = ((long)(int)((this.currPt + 3)) * 12) + this.pts + 36, z = ((long)(int)((this.currPt + 3)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  val_14);
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_3) * 12) + this.pts + 32, y = ((long)(int)(val_3) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_3) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 32, y = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 36, z = ((long)(int)((this.currPt + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  val_7);
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 32, y = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 32 + 4, z = ((long)(int)((this.currPt + 1)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        return UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
    }
    public UnityEngine.Vector3 丅专与丒丈丗丒丘丌(float 东丞丅丕丌丑丗丞下)
    {
        return this.上七丕一丌专丌丕三(丙丒七丄上与丏丙丙:  this.丞丁丑丏丄丏七丂不(丙丒七丄上与丏丙丙:  东丞丅丕丌丑丗丞下));
    }
    public void 且丒丛与丞世丙丕丌(UnityEngine.Transform 不丂丅丁且丆东东丂, float 东丞丅丕丌丑丗丞下)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        this.且丒丛与丞世丙丕丌(不丂丅丁且丆东东丂:  不丂丅丁且丆东东丂, 东丞丅丕丌丑丗丞下:  东丞丅丕丌丑丗丞下, 万万丕丙与丕丁丄丐:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public void 且丒丛与丞世丙丕丌(UnityEngine.Transform 不丂丅丁且丆东东丂, float 东丞丅丕丌丑丗丞下, UnityEngine.Vector3 万万丕丙与丕丁丄丐)
    {
        UnityEngine.Vector3 val_2 = this.上七丕一丌专丌丕三(丙丒七丄上与丏丙丙:  this.丞丁丑丏丄丏七丂不(丙丒七丄上与丏丙丙:  东丞丅丕丌丑丗丞下));
        不丂丅丁且丆东东丂.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        float val_5 = 0.001f;
        val_5 = 东丞丅丕丌丑丗丞下 + val_5;
        if(val_5 > 1f)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.上七丕一丌专丌丕三(丙丒七丄上与丏丙丙:  this.丞丁丑丏丄丏七丂不(丙丒七丄上与丏丙丙:  val_5));
        不丂丅丁且丆东东丂.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, worldUp:  new UnityEngine.Vector3() {x = 万万丕丙与丕丁丄丐.x, y = 万万丕丙与丕丁丄丐.y, z = 万万丕丙与丕丁丄丐.z});
    }
    public void 与丏丛与世丑丈丘东(UnityEngine.Transform 不丂丅丁且丆东东丂, float 东丞丅丕丌丑丗丞下)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        this.与丏丛与世丑丈丘东(不丂丅丁且丆东东丂:  不丂丅丁且丆东东丂, 东丞丅丕丌丑丗丞下:  东丞丅丕丌丑丗丞下, 万万丕丙与丕丁丄丐:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public void 与丏丛与世丑丈丘东(UnityEngine.Transform 不丂丅丁且丆东东丂, float 东丞丅丕丌丑丗丞下, UnityEngine.Vector3 万万丕丙与丕丁丄丐)
    {
        float val_7 = 东丞丅丕丌丑丗丞下;
        UnityEngine.Vector3 val_2 = this.上七丕一丌专丌丕三(丙丒七丄上与丏丙丙:  this.丞丁丑丏丄丏七丂不(丙丒七丄上与丏丙丙:  东丞丅丕丌丑丗丞下));
        不丂丅丁且丆东东丂.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        val_7 = val_7 + 0.001f;
        if(val_7 > 1f)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.上七丕一丌专丌丕三(丙丒七丄上与丏丙丙:  this.丞丁丑丏丄丏七丂不(丙丒七丄上与丏丙丙:  val_7));
        UnityEngine.Vector3 val_6 = 不丂丅丁且丆东东丂.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        不丂丅丁且丆东东丂.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, worldUp:  new UnityEngine.Vector3() {x = 万万丕丙与丕丁丄丐.x, y = 万万丕丙与丕丁丄丐.y, z = 万万丕丙与丕丁丄丐.z});
    }
    public void 丟丘一丅丟一丘丝不(float 丙丒七丄上与丏丙丙 = -1)
    {
        if(this.lengthRatio == null)
        {
                return;
        }
        
        if(this.lengthRatio.Length == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.上七丕一丌专丌丕三(丙丒七丄上与丏丙丙:  this.丞丁丑丏丄丏七丂不(丙丒七丄上与丏丙丙:  0f));
        var val_6 = 1;
        do
        {
            float val_5 = 1f;
            val_5 = val_5 / 120f;
            UnityEngine.Vector3 val_4 = this.上七丕一丌专丌丕三(丙丒七丄上与丏丙丙:  this.丞丁丑丏丄丏七丂不(丙丒七丄上与丏丙丙:  val_5));
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, to:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_6 = val_6 + 1;
        }
        while(val_6 != 121);
    
    }
    public UnityEngine.Vector3 丐丟丕丙丅丆丕丞丅(float 丙丒七丄上与丏丙丙)
    {
        float val_3 = (this.丞丁丑丏丄丏七丂不(丙丒七丄上与丏丙丙:  丙丒七丄上与丏丙丙)) * ((float)this.pts.Length - 3);
        int val_6 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  val_3), b:  this.pts.Length - 4);
        var val_31 = 12;
        val_31 = this.pts + ((long)val_6 * val_31);
        var val_32 = 12;
        val_32 = this.pts + (((long)val_6 + 1) * val_32);
        var val_33 = 12;
        val_33 = this.pts + (((long)val_6 + 2) * val_33);
        var val_34 = 12;
        val_34 = this.pts + (((long)val_6 + 3) * val_34);
        float val_10 = val_3 - (float)val_6;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_6) * 12) + this.pts + 32, y = ((long)(int)(val_6) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_6) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_6 + 1)) * 12) + this.pts + 32, y = ((long)(int)((val_6 + 1)) * 12) + this.pts + 36, z = ((long)(int)((val_6 + 1)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_6 + 2)) * 12) + this.pts + 32, y = ((long)(int)((val_6 + 2)) * 12) + this.pts + 32 + 4, z = ((long)(int)((val_6 + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_6 + 3)) * 12) + this.pts + 32, y = ((long)(int)((val_6 + 3)) * 12) + this.pts + 36, z = ((long)(int)((val_6 + 3)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(d:  1.5f, a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  val_10 * val_10);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(val_6) * 12) + this.pts + 32, y = ((long)(int)(val_6) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_6) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  5f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_6 + 1)) * 12) + this.pts + 32, y = ((long)(int)((val_6 + 1)) * 12) + this.pts + 36, z = ((long)(int)((val_6 + 1)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(d:  4f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_6 + 2)) * 12) + this.pts + 32, y = ((long)(int)((val_6 + 2)) * 12) + this.pts + 32 + 4, z = ((long)(int)((val_6 + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_6 + 3)) * 12) + this.pts + 32, y = ((long)(int)((val_6 + 3)) * 12) + this.pts + 36, z = ((long)(int)((val_6 + 3)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  val_10);
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_6 + 2)) * 12) + this.pts + 32, y = ((long)(int)((val_6 + 2)) * 12) + this.pts + 32 + 4, z = ((long)(int)((val_6 + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = ((long)(int)(val_6) * 12) + this.pts + 32, y = ((long)(int)(val_6) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_6) * 12) + this.pts + 40});
        return UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
    }

}
