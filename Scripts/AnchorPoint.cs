using UnityEngine;
[Serializable]
public class UIRect.AnchorPoint
{
    // Fields
    public UnityEngine.Transform target;
    public float relative;
    public int absolute;
    public UIRect rect;
    public UnityEngine.Camera targetCam;
    
    // Methods
    public UIRect.AnchorPoint()
    {
    
    }
    public UIRect.AnchorPoint(float 丄丂丙丘丄丛上丐丒)
    {
        this.relative = 丄丂丙丘丄丛上丐丒;
    }
    public void 丅专下万丕丑丆丅丝(float 丄丂丙丘丄丛上丐丒, float 业丘丕万七专丑丂一)
    {
        this.relative = 丄丂丙丘丄丛上丐丒;
        float val_2 = 0.5f;
        val_2 = 业丘丕万七专丑丂一 + val_2;
        this.absolute = UnityEngine.Mathf.FloorToInt(f:  val_2);
    }
    public void 丅专下万丕丑丆丅丝(UnityEngine.Transform 丞下万上三丘上与专, float 丄丂丙丘丄丛上丐丒, float 业丘丕万七专丑丂一)
    {
        this.target = 丞下万上三丘上与专;
        this.relative = 丄丂丙丘丄丛上丐丒;
        float val_2 = 0.5f;
        val_2 = 业丘丕万七专丑丂一 + val_2;
        this.absolute = UnityEngine.Mathf.FloorToInt(f:  val_2);
    }
    public void 丆不丁丐东丗丗丕丅(float 丌丝丟丝且上丌丅丙, float 上丂专上丝专上丂业, float 丄丒丈丈丙上丌丞丌)
    {
        this.丆不丁丐东丗丗丕丅(丆丂丕丕丆丁丞万丂:  0f, 下丌丅专丐丕万丘且:  0.5f, 丙丗三下东丛丁不丙:  1f, 丌丝丟丝且上丌丅丙:  丌丝丟丝且上丌丅丙, 上丂专上丝专上丂业:  上丂专上丝专上丂业, 丄丒丈丈丙上丌丞丌:  丄丒丈丈丙上丌丞丌);
    }
    public void 丆不丁丐东丗丗丕丅(float 丆丂丕丕丆丁丞万丂, float 下丌丅专丐丕万丘且, float 丙丗三下东丛丁不丙, float 丌丝丟丝且上丌丅丙, float 上丂专上丝专上丂业, float 丄丒丈丈丙上丌丞丌)
    {
        float val_1 = System.Math.Abs(丌丝丟丝且上丌丅丙);
        float val_2 = System.Math.Abs(上丂专上丝专上丂业);
        float val_3 = System.Math.Abs(丄丒丈丈丙上丌丞丌);
        if((val_1 < 0) && (val_1 < 0))
        {
            
        }
        else
        {
                if((val_2 < 0) && (val_2 < 0))
        {
            
        }
        
        }
        
        this.丅专下万丕丑丆丅丝(丄丂丙丘丄丛上丐丒:  丙丗三下东丛丁不丙, 业丘丕万七专丑丂一:  丄丒丈丈丙上丌丞丌);
    }
    public void 业专丈丑业且丘一万(UnityEngine.Transform 丈东丘丏与丌东东下, float 丈丑丑且业下丒丁丞)
    {
        UIRect val_7;
        AnchorPoint val_8;
        丘一丄与上世丑七丅 val_9;
        float val_11;
        if((UnityEngine.Object.op_Implicit(exists:  this.rect)) != false)
        {
                val_7 = this.rect;
            val_8 = this.rect.leftAnchor;
            if(val_8 == null)
        {
                val_8 = this.rect.leftAnchor;
        }
        
            val_9 = this.rect.updateAnchors;
            val_11 = UnityEngine.Mathf.Lerp(a:  this.rect.rightAnchor, b:  val_9, t:  this.relative);
        }
        else
        {
                val_7 = this.target;
            UnityEngine.Vector3 val_3 = val_7.position;
            val_11 = val_3.x;
            val_9 = val_3.y;
            if(丈东丘丏与丌东东下 != 0)
        {
                UnityEngine.Vector3 val_5 = 丈东丘丏与丌东东下.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_11, y = val_9, z = val_3.z});
            val_11 = val_5.x;
        }
        
        }
        
        val_5.x = 丈丑丑且业下丒丁丞 - val_11;
        val_5.x = val_5.x + 0.5f;
        this.absolute = UnityEngine.Mathf.FloorToInt(f:  val_5.x);
    }
    public void 丘世万丕专世东下丐(UnityEngine.Transform 丈东丘丏与丌东东下, float 丈丑丑且业下丒丁丞)
    {
        UIRect val_8;
        AnchorPoint val_9;
        AnchorPoint val_10;
        float val_12;
        if((UnityEngine.Object.op_Implicit(exists:  this.rect)) != false)
        {
                val_8 = this.rect;
            val_9 = this.rect.leftAnchor;
            if(val_9 <= 3)
        {
                val_9 = this.rect.leftAnchor;
        }
        
            val_10 = this.rect.topAnchor;
            val_12 = UnityEngine.Mathf.Lerp(a:  this.rect.丐一丗丛丕世丘东丁, b:  val_10, t:  this.relative);
        }
        else
        {
                val_8 = this.target;
            UnityEngine.Vector3 val_3 = val_8.position;
            val_10 = val_3.x;
            val_12 = val_3.y;
            if(丈东丘丏与丌东东下 != 0)
        {
                UnityEngine.Vector3 val_5 = 丈东丘丏与丌东东下.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_10, y = val_12, z = val_3.z});
            val_12 = val_5.y;
        }
        
        }
        
        float val_6 = 丈丑丑且业下丒丁丞 - val_12;
        val_6 = val_6 + 0.5f;
        this.absolute = UnityEngine.Mathf.FloorToInt(f:  val_6);
    }
    public UnityEngine.Vector3[] 万丆上世丁丐丂丌丈(UnityEngine.Transform 一世丛下丘东世专丈)
    {
        UnityEngine.Transform val_13;
        var val_14;
        var val_15;
        UnityEngine.Transform val_16;
        val_13 = 一世丛下丘东世专丈;
        val_14 = this;
        val_15 = 1152921504848912384;
        val_16 = this.target;
        if(val_16 == 0)
        {
                return 0;
        }
        
        if(this.rect != 0)
        {
                val_14 = ???;
            val_13 = ???;
            val_15 = ???;
        }
        else
        {
                val_16 = val_14 + 16.GetComponent<UnityEngine.Camera>();
            if(val_16 == 0)
        {
                return 0;
        }
        
            return 不丌丂丁丄一与丆丙.万丆上世丁丐丂丌丈(业丆丆东丂与万丅不:  val_14 + 16.GetComponent<UnityEngine.Camera>(), 一世丛下丘东世专丈:  val_13);
        }
    
    }

}
