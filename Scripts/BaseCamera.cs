using UnityEngine;
public class BaseCamera : PGBehaviour
{
    // Fields
    internal UnityEngine.Transform 且与东丕专七万丕不;
    internal float 下一丗丒丘上丞丏丕;
    internal float 丞专丌一丛丘下且专;
    internal float 丛不丟丙世万三万丆;
    internal float 丌七丒世丄上丞丞丁;
    internal float 丏丛丅丛丛丙丈三丕;
    internal float 丐丒丆业丁丄三丕不;
    internal float 下丁丂丐丙万丞丂丞;
    internal bool 丝业丈不丙丄丝一一;
    internal BaseCamera.万丙专丟丆专东丟丕 东丅东专不三丆上七;
    private UnityEngine.Camera 上七世丄丌业丈丌世;
    public UnityEngine.Transform pointForShootFromZoom;
    private FirstPersonControlSharp 世丅丌丒丁丄东不上;
    internal UnityEngine.Transform 丒不世丁丌丁万丌三;
    internal float 东万丌丌与丘丝丈上;
    internal float 丆丙丆与一且万丕丈;
    internal float 业丕专三一丙不丄下;
    internal float 丑万下丟丝丕丈丁上;
    internal float 丒丏专丄丌丅丛丞专;
    
    // Properties
    public UnityEngine.Camera 与业丞东丙丕且丏丈 { get; }
    internal FirstPersonControlSharp 与丛与丙丁丒丏与不 { get; set; }
    internal float 业三丏丝且丘丆丑丂 { get; }
    internal UnityEngine.Transform 丒丌丞丕丐丁丛专东 { get; }
    internal float 专丛丈丂丛与丁丆丘 { get; }
    internal float 丅与丏三业东丑丟丁 { get; }
    
    // Methods
    public UnityEngine.Camera get_camera()
    {
        UnityEngine.Camera val_3;
        if(this.上七世丄丌业丈丌世 == 0)
        {
                this.上七世丄丌业丈丌世 = this.GetComponent<UnityEngine.Camera>();
            return val_3;
        }
        
        val_3 = this.上七世丄丌业丈丌世;
        return val_3;
    }
    internal FirstPersonControlSharp 东丛丆丕丟东丐丄一()
    {
        return (FirstPersonControlSharp)this.世丅丌丒丁丄东不上;
    }
    internal void 丝不三万世丛世七丗(FirstPersonControlSharp 丙业与丙丗丝不丈东)
    {
        this.世丅丌丒丁丄东不上 = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        this.丕上万丌丕万丞七丐();
    }
    internal float 丘丁世业丒丙上丈丗()
    {
        UnityEngine.Camera val_1 = this.camera;
        if(val_1 != null)
        {
                return val_1.fieldOfView;
        }
        
        return val_1.fieldOfView;
    }
    internal UnityEngine.Transform 一丗与上丅东丏丙丑()
    {
        UnityEngine.Camera val_1 = this.camera;
        if(val_1 != null)
        {
                return val_1.transform;
        }
        
        return val_1.transform;
    }
    internal float 与丈丏东一丘丆丁三()
    {
        float val_1 = this.一一上与丗专丗丏丌();
        val_1 = val_1 * ((this.东丅东专不三丆上七 == 1) ? 0.2f : ((this.东丅东专不三丆上七 == 2) ? 0.8f : 1f));
        return (float)val_1;
    }
    internal float 一一上与丗专丗丏丌()
    {
        float val_9 = 与丂丏丛丞丞丒丟丄.一一上与丗专丗丏丌();
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_8;
        }
        
        }
        
        label_18:
        一三专丈世丑丆丑丐 val_5 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_8 = val_5.上丙丒一世下丘丄丄;
        val_8 = 与丂丏丛丞丞丒丟丄.丒丞丈丗丟丑丘丅与() * val_8;
        return (float)val_8;
        label_8:
        if((GameConnect.丒丗丁丙丗丄丙不丐() == false) || (PlantTheBombController.ReduceSensitiviity == false))
        {
            goto label_18;
        }
        
        val_9 = val_9 / 5f;
        goto label_18;
    }
    protected virtual void Awake()
    {
        this.丒不世丁丌丁万丌三 = this.transform;
        与丂丏丛丞丞丒丟丄.世丘与下丂不与丞下().专丒一一上丘丄东且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BaseCamera::丕上万丌丕万丞七丐()));
    }
    private void Update()
    {
        if(this.下一丗丒丘上丞丏丕 == this.camera.fieldOfView)
        {
                return;
        }
        
        UnityEngine.Camera val_3 = this.camera;
        if(this.丞专丌一丛丘下且专 <= 0f)
        {
            goto label_3;
        }
        
        if(val_3 != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        val_3.fieldOfView = UnityEngine.Mathf.Lerp(a:  this.camera.fieldOfView, b:  this.下一丗丒丘上丞丏丕, t:  this.丞专丌一丛丘下且专 * UnityEngine.Time.deltaTime);
        return;
        label_3:
        if(val_3 != null)
        {
            goto label_8;
        }
        
        goto label_9;
    }
    internal virtual void OnDestroy()
    {
        与丂丏丛丞丞丒丟丄.世丘与下丂不与丞下().不丘丄三丒丟万丅丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BaseCamera::丕上万丌丕万丞七丐()));
    }
    private void 丕上万丌丕万丞七丐()
    {
        this.丝业丈不丙丄丝一一 = 与丂丏丛丞丞丒丟丄.世丘与下丂不与丞下().世三丞丅丑丌丈丈一();
    }
    internal virtual void 一上丘丞丕丅丝丑丄(UnityEngine.Vector2 丞且丅三三东不丄且, float 丗丝业万与丆七东丁, bool 丝业丈不丙丄丝一一, bool 与丒下丅丛丏丘世丘 = False, bool 丅与万万丌一丑丟丒 = False)
    {
    
    }
    internal virtual void 丒丙且丌丆丙丞万丙(UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
    {
    
    }
    internal virtual void 丛专丙丌丝丏业丌丕(UnityEngine.Transform 丞下万上三丘上与专, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        this.camera.transform.parent = 丞下万上三丘上与专;
        this.camera.transform.localPosition = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        this.camera.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        this.camera.transform.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
    }
    internal virtual void 丏丄丕三丆一丛丞丗(float 丁丌业三东不东东丙, float 丟丞一专丕三东丗一 = 0)
    {
        this.下一丗丒丘上丞丏丕 = 丁丌业三东不东东丙;
        this.丞专丌一丛丘下且专 = 丟丞一专丕三东丗一;
    }
    internal virtual void 丝丏一丆丐丄丙七一(UnityEngine.Quaternion 七丅丗丆丒丌丑丝不)
    {
    
    }
    internal virtual void 丗丂东丌丙一丕业丙(UnityEngine.Vector2 丞且丅三三东不丄且, bool 万业丒丞丅一丂丈业 = False)
    {
    
    }
    internal virtual void 且丁不丒业丏丌丄丈()
    {
    
    }
    internal virtual void 丅专丟上丗且丈丛上(BaseCamera.万丙专丟丆专东丟丕 丘丄丌丌丆丙丅丛丆, UnityEngine.Transform 不丌丕不七丗丞万万, UnityEngine.Transform 丗丈丑丅丑丕丘丂丐)
    {
        if(丘丄丌丌丆丙丅丛丆 > 8)
        {
                return;
        }
        
        var val_5 = 106023552 + (丘丄丌丌丆丙丅丛丆) << 2;
        val_5 = val_5 + 106023552;
        goto (106023552 + (丘丄丌丌丆丙丅丛丆) << 2 + 106023552);
    }
    internal virtual void 丞与三丞丗且丟下七(UnityEngine.Transform 不丌丕不七丗丞万万, UnityEngine.Transform 丗丈丑丅丑丕丘丂丐)
    {
        this.且与东丕专七万丕不 = 不丌丕不七丗丞万万;
    }
    internal virtual void 丒一丅下丐丆丛丆丁()
    {
        this.东丅东专不三丆上七 = 1;
    }
    internal virtual void 三丐丝丕不世丘七丛()
    {
        this.东丅东专不三丆上七 = 4;
    }
    internal virtual void 世丑丅丈丙万丌丐丝()
    {
        this.东丅东专不三丆上七 = 2;
    }
    internal virtual void 下丐丕丌世丕丅丞不()
    {
        this.东丅东专不三丆上七 = 3;
    }
    internal virtual void 丁丆且丑丙丛上丛万()
    {
        this.东丅东专不三丆上七 = 0;
    }
    internal virtual void 丙丛且丙丅丂丁丆三()
    {
        this.东丅东专不三丆上七 = 5;
    }
    internal virtual void 不丈丐不丙丅丁丐下()
    {
        this.东丅东专不三丆上七 = 6;
    }
    internal virtual void 万丌丑万世专丐与丕()
    {
        this.东丅东专不三丆上七 = 7;
    }
    internal virtual void 专业丗丟丆丅丟丗专()
    {
        this.东丅东专不三丆上七 = 8;
    }
    public BaseCamera()
    {
        this.丒丏专丄丌丅丛丞专 = 10f;
        this.东万丌丌与丘丝丈上 = ;
        this.丆丙丆与一且万丕丈 = ;
        this.业丕专三一丙不丄下 = 45f;
        this.丑万下丟丝丕丈丁上 = 45f;
    }

}
