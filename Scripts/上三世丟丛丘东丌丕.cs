using UnityEngine;
public class 上三世丟丛丘东丌丕
{
    // Fields
    public UnityEngine.Vector3[] 丑丂丈丗且东丒丌七;
    public float 丏上万丅丏一不不丕;
    public bool 丌业丞丌丛世不丞丑;
    private 丝万丒丅世丛下丌丌[] 丈三丏丌世丌丝万七;
    private float[] 丝丒丗丈丝丐下丙丒;
    
    // Methods
    public 上三世丟丛丘东丌丕()
    {
    
    }
    public 上三世丟丛丘东丌丕(UnityEngine.Vector3[] 三丝不丂丆丟专丘万)
    {
        this.三丄丞丘丘东丑丛一(三丝不丂丆丟专丘万:  三丝不丂丆丟专丘万);
    }
    public void 三丄丞丘丘东丑丛一(UnityEngine.Vector3[] 三丝不丂丆丟专丘万)
    {
        int val_8;
        var val_9;
        丝万丒丅世丛下丌丌 val_10;
        float val_11;
        var val_12;
        val_8 = 三丝不丂丆丟专丘万.Length;
        if(val_8 <= 3)
        {
                object val_1 = LeanTween.logError(丂七东不不丈一丐不:  "LeanTween - When passing values for a vector path, you must pass four or more values!");
            val_8 = 三丝不丂丆丟专丘万.Length;
        }
        
        val_8 = val_8 & 3;
        if(val_8 != 0)
        {
                object val_2 = LeanTween.logError(丂七东不不丈一丐不:  "LeanTween - When passing values for a vector path, they must be in sets of four: controlPoint1, controlPoint2, endPoint2, controlPoint2, controlPoint2...");
        }
        
        this.丑丂丈丗且东丒丌七 = 三丝不丂丆丟专丘万;
        int val_9 = 三丝不丂丆丟专丘万.Length;
        val_9 = (val_9 < 0) ? (val_9 + 3) : (val_9);
        var val_4 = val_9 >> 2;
        丝万丒丅世丛下丌丌[] val_5 = new 丝万丒丅世丛下丌丌[0];
        this.丈三丏丌世丌丝万七 = val_5;
        this.丝丒丗丈丝丐下丙丒 = new float[0];
        this.丏上万丅丏一不不丕 = 0f;
        val_9 = 3;
        val_10 = 12;
        goto label_9;
        label_28:
        val_5[2] = val_5[2] - 1;
        丝万丒丅世丛下丌丌 val_7 = new 丝万丒丅世丛下丌丌(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = mem[8781502688], y = mem[8781502692], z = mem[8781502696]}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = 5.877482E-39f, y = 2.479598E-39f, z = 1.401298E-45f}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = 0f, y = 5.142877E-39f, z = 7.006492E-45f}, 丐丆丂丒丁万丈丛丅:  new UnityEngine.Vector3() {x = 0f, y = 0.05f, z = mem[8781502692]}, 丑与三下丛丏丝丄丒:  ???);
        if(this.丈三丏丌世丌丝万七 == null)
        {
            goto label_18;
        }
        
        if(val_7 != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(val_7 == null)
        {
            goto label_22;
        }
        
        label_19:
        label_22:
        this.丈三丏丌世丌丝万七[0] = val_7;
        val_11 = this.丏上万丅丏一不不丕;
        丝万丒丅世丛下丌丌 val_10 = this.丈三丏丌世丌丝万七[0];
        float val_11 = this.丈三丏丌世丌丝万七[0x0][0].丏上万丅丏一不不丕;
        val_9 = 7;
        val_11 = val_11 + val_11;
        this.丏上万丅丏一不不丕 = val_11;
        label_9:
        if((val_9 - 3) < this.丑丂丈丗且东丒丌七.Length)
        {
            goto label_28;
        }
        
        val_12 = 0;
        goto label_29;
        label_36:
        val_10 = this.丈三丏丌世丌丝万七[0];
        val_11 = this.丈三丏丌世丌丝万七[0x0][0].丏上万丅丏一不不丕 / this.丏上万丅丏一不不丕;
        val_12 = 1;
        this.丝丒丗丈丝丐下丙丒[0] = val_11;
        label_29:
        if(val_12 < this.丈三丏丌世丌丝万七.Length)
        {
            goto label_36;
        }
    
    }
    public UnityEngine.Vector3 丅专与丒丈丗丒丘丌(float 东丞丅丕丌丑丗丞下)
    {
        var val_1;
        丝万丒丅世丛下丌丌 val_2;
        val_1 = 0;
        float val_2 = 0f;
        goto label_0;
        label_5:
        float val_1 = this.丝丒丗丈丝丐下丙丒[0];
        val_2 = val_2 + val_1;
        if(val_2 >= 东丞丅丕丌丑丗丞下)
        {
            goto label_3;
        }
        
        val_1 = 1;
        label_0:
        if(val_1 < this.丝丒丗丈丝丐下丙丒.Length)
        {
            goto label_5;
        }
        
        if(this.丝丒丗丈丝丐下丙丒 == null)
        {
            goto label_6;
        }
        
        if(this.丈三丏丌世丌丝万七 != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        int val_3 = this.丝丒丗丈丝丐下丙丒.Length;
        val_3 = val_3 - 1;
        val_2 = this.丈三丏丌世丌丝万七[(long)val_3];
        if(val_2 != null)
        {
                return this.丈三丏丌世丌丝万七[0].丅专与丒丈丗丒丘丌(丙丒七丄上与丏丙丙:  val_1 = val_1 / val_2[0]);
        }
        
        return this.丈三丏丌世丌丝万七[0].丅专与丒丈丗丒丘丌(丙丒七丄上与丏丙丙:  val_1);
        label_3:
        val_2 = this.丝丒丗丈丝丐下丙丒;
        val_1 = val_2 - this.丝丒丗丈丝丐下丙丒[0];
        val_1 = 东丞丅丕丌丑丗丞下 - val_1;
        return this.丈三丏丌世丌丝万七[0].丅专与丒丈丗丒丘丌(丙丒七丄上与丏丙丙:  val_1);
        label_6:
        if(this.丈三丏丌世丌丝万七 != null)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    public void 且丒丛与丞世丙丕丌(UnityEngine.Transform 不丂丅丁且丆东东丂, float 东丞丅丕丌丑丗丞下)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        this.且丒丛与丞世丙丕丌(不丂丅丁且丆东东丂:  不丂丅丁且丆东东丂, 东丞丅丕丌丑丗丞下:  东丞丅丕丌丑丗丞下, 万万丕丙与丕丁丄丐:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public void 且丒丛与丞世丙丕丌(UnityEngine.Transform 不丂丅丁且丆东东丂, float 东丞丅丕丌丑丗丞下, UnityEngine.Vector3 万万丕丙与丕丁丄丐)
    {
        UnityEngine.Vector3 val_1 = this.丅专与丒丈丗丒丘丌(东丞丅丕丌丑丗丞下:  东丞丅丕丌丑丗丞下);
        不丂丅丁且丆东东丂.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        float val_3 = 0.001f;
        val_3 = 东丞丅丕丌丑丗丞下 + val_3;
        if(val_3 > 1f)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.丅专与丒丈丗丒丘丌(东丞丅丕丌丑丗丞下:  val_3);
        不丂丅丁且丆东东丂.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, worldUp:  new UnityEngine.Vector3() {x = 万万丕丙与丕丁丄丐.x, y = 万万丕丙与丕丁丄丐.y, z = 万万丕丙与丕丁丄丐.z});
    }
    public void 与丏丛与世丑丈丘东(UnityEngine.Transform 不丂丅丁且丆东东丂, float 东丞丅丕丌丑丗丞下)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        this.与丏丛与世丑丈丘东(不丂丅丁且丆东东丂:  不丂丅丁且丆东东丂, 东丞丅丕丌丑丗丞下:  东丞丅丕丌丑丗丞下, 万万丕丙与丕丁丄丐:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public void 与丏丛与世丑丈丘东(UnityEngine.Transform 不丂丅丁且丆东东丂, float 东丞丅丕丌丑丗丞下, UnityEngine.Vector3 万万丕丙与丕丁丄丐)
    {
        float val_5 = 东丞丅丕丌丑丗丞下;
        UnityEngine.Vector3 val_1 = this.丅专与丒丈丗丒丘丌(东丞丅丕丌丑丗丞下:  东丞丅丕丌丑丗丞下);
        不丂丅丁且丆东东丂.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        val_5 = val_5 + 0.001f;
        if(val_5 > 1f)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.丅专与丒丈丗丒丘丌(东丞丅丕丌丑丗丞下:  val_5);
        UnityEngine.Vector3 val_4 = 不丂丅丁且丆东东丂.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        不丂丅丁且丆东东丂.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, worldUp:  new UnityEngine.Vector3() {x = 万万丕丙与丕丁丄丐.x, y = 万万丕丙与丕丁丄丐.y, z = 万万丕丙与丕丁丄丐.z});
    }

}
