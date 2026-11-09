using UnityEngine;
public class UIDrawCall : MonoBehaviour
{
    // Fields
    private static 丒丞丕丕七丁丗丟丛<UIDrawCall> 世丝丂丁一下丝一一;
    private static 丒丞丕丕七丁丗丟丛<UIDrawCall> 业一丂丗丗万丒丞下;
    public int widgetCount;
    public int depthStart;
    public int depthEnd;
    public UIPanel manager;
    public UIPanel panel;
    public UnityEngine.Texture2D clipTexture;
    public bool alwaysOnScreen;
    public 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> verts;
    public 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> norms;
    public 丒丞丕丕七丁丗丟丛<UnityEngine.Vector4> tans;
    public 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> uvs;
    public 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> cols;
    private UnityEngine.Material 七东丟不一丄丒丛世;
    private UnityEngine.Texture 万丏与丄东丒丙丆丒;
    private UnityEngine.Texture 丟万丗上世一丛丄专;
    private UnityEngine.Shader 不丑下丈丕丒丑专丏;
    private int 丙丏丆丕丂丞下丘世;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UnityEngine.Mesh 七丈丛东丗丄丟万丅;
    private UnityEngine.MeshFilter 专丈丐上丈丅丌专丙;
    private UnityEngine.MeshRenderer 丁丝一不专七丕七丘;
    private UnityEngine.Material 不丑丕一丐丑丁一丙;
    private int[] 三丑七丂丝丑万丁世;
    private bool 丝上丛丅七万丅与丟;
    private bool 丄丑丆丏万丝丏丏丈;
    private int 丘万丟丞丕不丈丌丙;
    private int 下丂丒专三丅一丏万;
    public bool isDirty;
    private bool 丏上业丛一且丝丏且;
    public UIDrawCall.丝丂丏世丌丈一与业 onRender;
    private string 东与丝丕世世与丈下;
    private System.Text.StringBuilder 专丁下七丞丂丏下丕;
    private string 一丑丆丕丈丙上丌丞;
    private const int 不丒万丕丁丅且下丌 = 10;
    private static System.Collections.Generic.List<int[]> 不丟万万丗丈丕与专;
    private static int[] 东丝丑丒丘丏丂丒丙;
    private static int[] 下丆丟丑业丁丐丑三;
    
    // Properties
    public static 丒丞丕丕七丁丗丟丛<UIDrawCall> 丝丘丑业丛万丞丌丝 { get; }
    public static 丒丞丕丕七丁丗丟丛<UIDrawCall> 丞上业世不不与不丏 { get; }
    public static 丒丞丕丕七丁丗丟丛<UIDrawCall> 上丟丌丞丁丁丟丒丕 { get; }
    public int 上不丞世丙丁丑丒且 { get; set; }
    public int 一丑不丆丛丈三丟丑 { get; set; }
    public int 上与丁不东专丟丅丟 { get; }
    public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
    public UnityEngine.Material 万丈丘丑且下丞不丞 { get; set; }
    public UnityEngine.Material 丂业丞上丒丄丅专丕 { get; }
    public UnityEngine.Texture 丒丕世丏丆丗三专丑 { get; set; }
    public UnityEngine.Texture 丒丛丐三不世丝丝专 { get; set; }
    public UnityEngine.Shader 丕丄与专丛丝丄丐下 { get; set; }
    public int 且东丟丐丈丅丆专三 { get; }
    public bool 且丞丞下丁丞上丆丆 { get; }
    
    // Methods
    public static 丒丞丕丕七丁丗丟丛<UIDrawCall> get_list()
    {
        null = null;
        return (丒丞丕丕七丁丗丟丛<UIDrawCall>)UIDrawCall.不丒万丕丁丅且下丌;
    }
    public static 丒丞丕丕七丁丗丟丛<UIDrawCall> get_activeList()
    {
        null = null;
        return (丒丞丕丕七丁丗丟丛<UIDrawCall>)UIDrawCall.不丒万丕丁丅且下丌;
    }
    public static 丒丞丕丕七丁丗丟丛<UIDrawCall> get_inactiveList()
    {
        null = null;
        return (丒丞丕丕七丁丗丟丛<UIDrawCall>)UIDrawCall.业一丂丗丗万丒丞下;
    }
    public int get_renderQueue()
    {
        return (int)this.丘万丟丞丕不丈丌丙;
    }
    public void set_renderQueue(int 丙业与丙丗丝不丈东)
    {
        if(this.丘万丟丞丕不丈丌丙 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.丘万丟丞丕不丈丌丙 = 丙业与丙丗丝不丈东;
        if(this.不丑丕一丐丑丁一丙 == 0)
        {
                return;
        }
        
        this.不丑丕一丐丑丁一丙.renderQueue = 丙业与丙丗丝不丈东;
    }
    public int get_sortingOrder()
    {
        if(this.丁丝一不专七丕七丘 == 0)
        {
                return 0;
        }
        
        if(this.丁丝一不专七丕七丘 != null)
        {
                return this.丁丝一不专七丕七丘.sortingOrder;
        }
        
        return this.丁丝一不专七丕七丘.sortingOrder;
    }
    public void set_sortingOrder(int 丙业与丙丗丝不丈东)
    {
        if(this.丁丝一不专七丕七丘 == 0)
        {
                return;
        }
        
        if(this.丁丝一不专七丕七丘.sortingOrder == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.丁丝一不专七丕七丘.sortingOrder = 丙业与丙丗丝不丈东;
    }
    public int get_finalRenderQueue()
    {
        if(this.不丑丕一丐丑丁一丙 == 0)
        {
                return (int)this.丘万丟丞丕不丈丌丙;
        }
        
        if(this.不丑丕一丐丑丁一丙 != null)
        {
                return this.不丑丕一丐丑丁一丙.renderQueue;
        }
        
        return this.不丑丕一丐丑丁一丙.renderQueue;
    }
    public UnityEngine.Transform get_cachedTransform()
    {
        UnityEngine.Transform val_3;
        if(this.丐一丗丛丕世丘东丁 == 0)
        {
                this.丐一丗丛丕世丘东丁 = this.transform;
            return val_3;
        }
        
        val_3 = this.丐一丗丛丕世丘东丁;
        return val_3;
    }
    public UnityEngine.Material get_baseMaterial()
    {
        return (UnityEngine.Material)this.七东丟不一丄丒丛世;
    }
    public void set_baseMaterial(UnityEngine.Material 丙业与丙丗丝不丈东)
    {
        if(this.七东丟不一丄丒丛世 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.七东丟不一丄丒丛世 = 丙业与丙丗丝不丈东;
        this.丝上丛丅七万丅与丟 = true;
    }
    public UnityEngine.Material get_dynamicMaterial()
    {
        return (UnityEngine.Material)this.不丑丕一丐丑丁一丙;
    }
    public UnityEngine.Texture get_mainTexture()
    {
        return (UnityEngine.Texture)this.万丏与丄东丒丙丆丒;
    }
    public void set_mainTexture(UnityEngine.Texture 丙业与丙丗丝不丈东)
    {
        this.万丏与丄东丒丙丆丒 = 丙业与丙丗丝不丈东;
        if(this.不丑丕一丐丑丁一丙 == 0)
        {
                return;
        }
        
        this.不丑丕一丐丑丁一丙.mainTexture = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Texture get_maskTexture()
    {
        return (UnityEngine.Texture)this.丟万丗上世一丛丄专;
    }
    public void set_maskTexture(UnityEngine.Texture 丙业与丙丗丝不丈东)
    {
        UnityEngine.Material val_3;
        this.丟万丗上世一丛丄专 = 丙业与丙丗丝不丈东;
        val_3 = this.不丑丕一丐丑丁一丙;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = this.不丑丕一丐丑丁一丙;
        if((val_3.HasProperty(name:  "_Mask")) == false)
        {
                return;
        }
        
        this.不丑丕一丐丑丁一丙.SetTexture(name:  "_Mask", value:  丙业与丙丗丝不丈东);
    }
    public UnityEngine.Shader get_shader()
    {
        return (UnityEngine.Shader)this.不丑下丈丕丒丑专丏;
    }
    public void set_shader(UnityEngine.Shader 丙业与丙丗丝不丈东)
    {
        if(this.不丑下丈丕丒丑专丏 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.不丑下丈丕丒丑专丏 = 丙业与丙丗丝不丈东;
        this.丝上丛丅七万丅与丟 = true;
        if(丙业与丙丗丝不丈东 == 0)
        {
                return;
        }
        
        this.东与丝丕世世与丈下 = this.不丑下丈丕丒丑专丏.name;
    }
    public int get_triangles()
    {
        int val_2;
        if(this.七丈丛东丗丄丟万丅 != 0)
        {
                val_2 = this.下丂丒专三丅一丏万;
            return (int)val_2;
        }
        
        val_2 = 0;
        return (int)val_2;
    }
    public bool get_isClipped()
    {
        return (bool)(this.丙丏丆丕丂丞下丘世 != 0) ? 1 : 0;
    }
    private void 丑丟七一丙丈丞丑东()
    {
        int val_48;
        string val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        NGUIMaterialPool val_55;
        int val_56;
        string val_57;
        string val_58;
        var val_59;
        string val_60;
        var val_61;
        UnityEngine.Shader val_62;
        string val_63;
        var val_64;
        var val_65;
        this.丏上业丛一且丝丏且 = false;
        this.丄丑丆丏万丝丏丏丈 = false;
        if(this.panel != 0)
        {
                val_48 = this.panel;
            int val_2 = val_48.clipCount;
        }
        else
        {
                val_48 = 0;
        }
        
        this.丙丏丆丕丂丞下丘世 = val_48;
        this.专丁下七丞丂丏下丕.Length = 0;
        if(this.不丑下丈丕丒丑专丏 == 0)
        {
            goto label_9;
        }
        
        val_49 = this.东与丝丕世世与丈下;
        if(val_49 == null)
        {
            goto label_18;
        }
        
        label_19:
        val_50 = val_49.Contains(value:  "Unlit/Transparent Colored");
        goto label_11;
        label_9:
        if(this.七东丟不一丄丒丛世 == 0)
        {
            goto label_14;
        }
        
        val_49 = this.七东丟不一丄丒丛世.shader.name;
        if(val_49 != null)
        {
            goto label_19;
        }
        
        goto label_18;
        label_14:
        val_49 = "Unlit/Transparent Colored";
        if(("Unlit/Transparent Colored") != null)
        {
            goto label_19;
        }
        
        label_18:
        val_50 = 0.Contains(value:  "Unlit/Transparent Colored");
        label_11:
        val_51 = Replace(oldValue:  "GUI/Text Shader", newValue:  "Unlit/Text");
        if(val_51.Length >= 3)
        {
                if(val_51 != null)
        {
                val_52 = val_51.Length;
        }
        else
        {
                val_52 = 0.Length;
        }
        
            if(((val_51.Chars[val_52 - 2]) & 65535) == ' ')
        {
                if(val_51 != null)
        {
                val_53 = val_51.Length;
        }
        else
        {
                val_53 = 0.Length;
        }
        
            char val_20 = (val_51.Chars[val_53 - 1]) - 49;
            val_20 = val_20 & 65535;
            if(val_20 <= '')
        {
                if(val_51 != null)
        {
                val_54 = val_51.Length;
        }
        else
        {
                val_54 = 0.Length;
        }
        
            val_51 = val_51.Substring(startIndex:  0, length:  val_54 - 2);
        }
        
        }
        
        }
        
        val_55 = "Hidden/";
        if((val_51.StartsWith(value:  "Hidden/")) != false)
        {
                val_51 = val_51.Substring(startIndex:  7);
        }
        
        val_56 = " (TextureClip)";
        string val_28 = val_51.Replace(oldValue:  " (SoftClip)", newValue:  "").Replace(oldValue:  " (TextureClip)", newValue:  "");
        if((this.panel == 0) || (this.panel.clipping != 1))
        {
            goto label_39;
        }
        
        this.丏上业丛一且丝丏且 = true;
        System.Text.StringBuilder val_31 = this.专丁下七丞丂丏下丕.Append(value:  "Hidden/");
        System.Text.StringBuilder val_32 = this.专丁下七丞丂丏下丕.Append(value:  val_28);
        val_57 = " (TextureClip)";
        goto label_43;
        label_39:
        val_56 = this.丙丏丆丕丂丞下丘世;
        if(this.专丁下七丞丂丏下丕 == null)
        {
            goto label_44;
        }
        
        if(val_56 == 0)
        {
            goto label_45;
        }
        
        label_64:
        System.Text.StringBuilder val_33 = this.专丁下七丞丂丏下丕.Append(value:  "Hidden/");
        System.Text.StringBuilder val_34 = this.专丁下七丞丂丏下丕.Append(value:  val_28);
        System.Text.StringBuilder val_35 = this.专丁下七丞丂丏下丕.Append(value:  " ");
        System.Text.StringBuilder val_36 = this.专丁下七丞丂丏下丕.Append(value:  this.丙丏丆丕丂丞下丘世);
        val_58 = this.专丁下七丞丂丏下丕;
        this.一丑丆丕丈丙上丌丞 = val_58;
        val_56 = 1152921505234800640;
        val_59 = null;
        val_59 = null;
        val_58 = this.一丑丆丕丈丙上丌丞;
        val_55 = NGUIMaterialPool.丄丘七三上丕世丞业;
        this.shader = val_55.丁一丏丆丟丗七丆丌(丌下上上世丏七丒丑:  val_58);
        if(this.不丑下丈丕丒丑专丏 != 0)
        {
            goto label_55;
        }
        
        this.专丁下七丞丂丏下丕.Length = 0;
        System.Text.StringBuilder val_39 = this.专丁下七丞丂丏下丕.Append(value:  val_28);
        System.Text.StringBuilder val_40 = this.专丁下七丞丂丏下丕.Append(value:  " ");
        System.Text.StringBuilder val_41 = this.专丁下七丞丂丏下丕.Append(value:  this.丙丏丆丕丂丞下丘世);
        val_60 = this.专丁下七丞丂丏下丕;
        this.一丑丆丕丈丙上丌丞 = val_60;
        val_61 = null;
        val_61 = null;
        goto label_63;
        label_44:
        if(val_56 != 0)
        {
            goto label_64;
        }
        
        label_45:
        val_57 = val_28;
        label_43:
        System.Text.StringBuilder val_42 = this.专丁下七丞丂丏下丕.Append(value:  val_57);
        val_60 = this.专丁下七丞丂丏下丕;
        this.一丑丆丕丈丙上丌丞 = val_60;
        val_61 = null;
        val_61 = null;
        label_63:
        val_60 = this.一丑丆丕丈丙上丌丞;
        this.shader = NGUIMaterialPool.丄丘七三上丕世丞业.丁一丏丆丟丗七丆丌(丌下上上世丏七丒丑:  val_60);
        label_55:
        val_62 = this.不丑下丈丕丒丑专丏;
        if(val_62 != 0)
        {
            goto label_71;
        }
        
        this.专丁下七丞丂丏下丕.Length = 0;
        System.Text.StringBuilder val_45 = this.专丁下七丞丂丏下丕.Append(value:  "Unlit/Transparent Colored");
        val_63 = this.专丁下七丞丂丏下丕;
        this.一丑丆丕丈丙上丌丞 = val_63;
        val_64 = null;
        val_64 = null;
        val_63 = this.一丑丆丕丈丙上丌丞;
        val_62 = NGUIMaterialPool.丄丘七三上丕世丞业;
        this.shader = val_62.丁一丏丆丟丗七丆丌(丌下上上世丏七丒丑:  val_63);
        goto label_78;
        label_71:
        if(val_50 == false)
        {
            goto label_84;
        }
        
        label_78:
        val_65 = null;
        val_65 = null;
        if(NGUIMaterialPool.丄丘七三上丕世丞业 != 0)
        {
                this.丂丐东三不且丘丞丕();
            return;
        }
        
        label_84:
        this.东且不丄丑丟丂丂丁();
    }
    private void 东且不丄丑丟丂丂丁()
    {
        UnityEngine.Texture val_10;
        UnityEngine.Material val_11;
        var val_12;
        val_10 = this;
        if(this.七东丟不一丄丒丛世 == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Material val_2 = new UnityEngine.Material(source:  this.七东丟不一丄丒丛世);
        this.不丑丕一丐丑丁一丙 = val_2;
        val_2.hideFlags = 60;
        val_11 = this.七东丟不一丄丒丛世;
        this.不丑丕一丐丑丁一丙.CopyPropertiesFromMaterial(mat:  val_11);
        val_12 = 0;
        goto label_7;
        label_11:
        val_11 = this.不丑丕一丐丑丁一丙;
        val_11.EnableKeyword(keyword:  this.七东丟不一丄丒丛世.shaderKeywords[0]);
        val_12 = 1;
        label_7:
        if(val_12 < val_3.Length)
        {
            goto label_11;
        }
        
        if(this.不丑下丈丕丒丑专丏 == 0)
        {
            goto label_14;
        }
        
        val_11 = this.不丑下丈丕丒丑专丏;
        this.不丑丕一丐丑丁一丙.shader = val_11;
        goto label_19;
        label_3:
        val_11 = this.不丑下丈丕丒丑专丏;
        UnityEngine.Material val_5 = new UnityEngine.Material(shader:  val_11);
        this.不丑丕一丐丑丁一丙 = val_5;
        val_5.hideFlags = 60;
        goto label_19;
        label_14:
        if(this.丙丏丆丕丂丞下丘世 != 0)
        {
                UnityEngine.Debug.LogError(message:  System.String.Format(format:  "{0} shader doesn\'t have a clipped shader version for {1} clip regions", arg0:  this.一丑丆丕丈丙上丌丞, arg1:  this.丙丏丆丕丂丞下丘世));
        }
        
        label_19:
        if(this.丟万丗上世一丛丄专 == 0)
        {
                return;
        }
        
        if(this.不丑丕一丐丑丁一丙 == 0)
        {
                return;
        }
        
        val_11 = "_Mask";
        if((this.不丑丕一丐丑丁一丙.HasProperty(name:  "_Mask")) == false)
        {
                return;
        }
        
        val_10 = this.丟万丗上世一丛丄专;
        this.不丑丕一丐丑丁一丙.SetTexture(name:  "_Mask", value:  val_10);
    }
    private void 丂丐东三不且丘丞丕()
    {
        var val_8;
        var val_9;
        UnityEngine.Material val_10;
        var val_11;
        var val_12;
        val_8 = null;
        if(this.七东丟不一丄丒丛世 == 0)
        {
            goto label_3;
        }
        
        val_9 = null;
        UnityEngine.Material val_2 = NGUIMaterialPool.丄丘七三上丕世丞业.丁丄三下七丝丐丞七(丌下上上世丏七丒丑:  this.一丑丆丕丈丙上丌丞, 丕丄与专丛丝丄丐下:  this.不丑下丈丕丒丑专丏);
        this.不丑丕一丐丑丁一丙 = val_2;
        val_2.hideFlags = 60;
        val_10 = this.七东丟不一丄丒丛世;
        this.不丑丕一丐丑丁一丙.CopyPropertiesFromMaterial(mat:  val_10);
        val_11 = 0;
        goto label_10;
        label_14:
        val_10 = this.不丑丕一丐丑丁一丙;
        val_10.EnableKeyword(keyword:  this.七东丟不一丄丒丛世.shaderKeywords[0]);
        val_11 = 1;
        label_10:
        if(val_11 < val_3.Length)
        {
            goto label_14;
        }
        
        goto label_15;
        label_3:
        val_12 = null;
        val_10 = this.一丑丆丕丈丙上丌丞;
        UnityEngine.Material val_4 = NGUIMaterialPool.丄丘七三上丕世丞业.丁丄三下七丝丐丞七(丌下上上世丏七丒丑:  val_10, 丕丄与专丛丝丄丐下:  this.不丑下丈丕丒丑专丏);
        this.不丑丕一丐丑丁一丙 = val_4;
        val_4.hideFlags = 60;
        label_15:
        if(this.丟万丗上世一丛丄专 == 0)
        {
                return;
        }
        
        if(this.不丑丕一丐丑丁一丙 == 0)
        {
                return;
        }
        
        val_10 = "_Mask";
        if((this.不丑丕一丐丑丁一丙.HasProperty(name:  "_Mask")) == false)
        {
                return;
        }
        
        this.不丑丕一丐丑丁一丙.SetTexture(name:  "_Mask", value:  this.丟万丗上世一丛丄专);
    }
    private UnityEngine.Material 丙七丒专丛不丒丂不()
    {
        var val_10;
        var val_11;
        int val_12;
        UnityEngine.Texture val_13;
        val_10 = null;
        val_10 = null;
        if((NGUIMaterialPool.丄丘七三上丕世丞业 == 0) || (this.不丑丕一丐丑丁一丙 == 0))
        {
            goto label_8;
        }
        
        val_11 = null;
        val_11 = null;
        if((NGUIMaterialPool.丄丘七三上丕世丞业.下一丟丆丅万丏丅丁(丌下上上世丏七丒丑:  this.不丑丕一丐丑丁一丙.shader.name, 丘上专不丂万业不一:  this.不丑丕一丐丑丁一丙)) == true)
        {
            goto label_14;
        }
        
        label_8:
        不丌丂丁丄一与丆丙.丟丘下万世世丐丆丅(万且万且丑丗且丌丆:  this.不丑丕一丐丑丁一丙);
        label_14:
        this.丑丟七一丙丈丞丑东();
        val_12 = this.丘万丟丞丕不丈丌丙;
        this.不丑丕一丐丑丁一丙.renderQueue = val_12;
        if(this.万丏与丄东丒丙丆丒 != 0)
        {
                val_12 = this.万丏与丄东丒丙丆丒;
            val_13 = val_12;
        }
        else
        {
                val_13 = 0;
        }
        
        this.不丑丕一丐丑丁一丙.mainTexture = val_13;
        if(this.丟万丗上世一丛丄专 != 0)
        {
                val_12 = this.丟万丗上世一丛丄专;
            this.不丑丕一丐丑丁一丙.SetTexture(name:  "_Mask", value:  val_12);
        }
        
        if(this.丁丝一不专七丕七丘 == 0)
        {
                return (UnityEngine.Material)this.不丑丕一丐丑丁一丙;
        }
        
        UnityEngine.Material[] val_9 = new UnityEngine.Material[1];
        val_12 = val_9;
        val_12[0] = this.不丑丕一丐丑丁一丙;
        this.丁丝一不专七丕七丘.sharedMaterials = val_9;
        return (UnityEngine.Material)this.不丑丕一丐丑丁一丙;
    }
    private void 七丙东丈丅丂丌丛丞()
    {
        if(this.panel == 0)
        {
                return;
        }
        
        if((this.丝上丛丅七万丅与丟 != true) && (this.不丑丕一丐丑丁一丙 != 0))
        {
                if(this.丙丏丆丕丂丞下丘世 == this.panel.clipCount)
        {
                if(((this.丏上业丛一且丝丏且 == true) ? 1 : 0) == ((this.panel.clipping == 1) ? 1 : 0))
        {
            goto label_11;
        }
        
        }
        
        }
        
        UnityEngine.Material val_7 = this.丙七丒专丛不丒丂不();
        this.丝上丛丅七万丅与丟 = false;
        return;
        label_11:
        if(this.丁丝一不专七丕七丘.sharedMaterial == this.不丑丕一丐丑丁一丙)
        {
                return;
        }
        
        UnityEngine.Material[] val_10 = new UnityEngine.Material[1];
        val_10[0] = this.不丑丕一丐丑丁一丙;
        this.丁丝一不专七丕七丘.sharedMaterials = val_10;
    }
    public void UpdateGeometry(int 专丟丘三丆丌丈下东)
    {
        System.Int32[] val_42;
        UnityEngine.MeshFilter val_43;
        var val_44;
        string val_45;
        UnityEngine.MeshRenderer val_46;
        this.widgetCount = 专丟丘三丆丌丈下东;
        if((专丟丘三丆丌丈下东 < 1) || (专丟丘三丆丌丈下东 != true))
        {
            goto label_7;
        }
        
        int val_1 = 专丟丘三丆丌丈下东 & 3;
        if((val_1 != 0) || (专丟丘三丆丌丈下东 != val_1))
        {
            goto label_7;
        }
        
        if(this.专丈丐上丈丅丌专丙 != 0)
        {
            goto label_10;
        }
        
        val_43 = this.gameObject.GetComponent<UnityEngine.MeshFilter>();
        this.专丈丐上丈丅丌专丙 = val_43;
        goto label_12;
        label_7:
        if(this.专丈丐上丈丅丌专丙.mesh != 0)
        {
                this.专丈丐上丈丅丌专丙.mesh.Clear();
        }
        
        UnityEngine.Debug.LogError(message:  "UIWidgets must fill the buffer with 4 vertices per quad. Found " + 专丟丘三丆丌丈下东);
        label_138:
        this.verts.世业丒万丘丆专丘丐();
        this.uvs.世业丒万丘丆专丘丐();
        this.cols.世业丒万丘丆专丘丐();
        this.norms.世业丒万丘丆专丘丐();
        this.tans.世业丒万丘丆专丘丐();
        return;
        label_10:
        val_43 = this.专丈丐上丈丅丌专丙;
        label_12:
        if(val_43 == 0)
        {
                this.专丈丐上丈丅丌专丙 = this.gameObject.AddComponent<UnityEngine.MeshFilter>();
        }
        
        if(1152921526364419328 <= 64999)
        {
            goto label_31;
        }
        
        this.下丂丒专三丅一丏万 = 0;
        if(this.专丈丐上丈丅丌专丙.mesh != 0)
        {
                this.专丈丐上丈丅丌专丙.mesh.Clear();
        }
        
        UnityEngine.Debug.LogError(message:  "Too many vertices on one panel: "("Too many vertices on one panel: ") + null);
        goto label_41;
        label_31:
        int val_16 = 专丟丘三丆丌丈下东 >> 1;
        val_16 = val_16 << 1;
        int val_17 = val_16 + (专丟丘三丆丌丈下东 >> 1);
        if(this.三丑七丂丝丑万丁世 != null)
        {
                var val_18 = (val_17 != this.三丑七丂丝丑万丁世.Length) ? 1 : 0;
        }
        else
        {
                val_44 = 1;
        }
        
        if(this.七丈丛东丗丄丟万丅 != 0)
        {
            goto label_46;
        }
        
        UnityEngine.Mesh val_20 = new UnityEngine.Mesh();
        this.七丈丛东丗丄丟万丅 = val_20;
        val_20.hideFlags = 52;
        if(this.七东丟不一丄丒丛世 == 0)
        {
            goto label_50;
        }
        
        val_45 = "[NGUI] " + this.七东丟不一丄丒丛世.name;
        if(this.七丈丛东丗丄丟万丅 != null)
        {
            goto label_54;
        }
        
        goto label_53;
        label_50:
        val_45 = "[NGUI] Mesh";
        if(this.七丈丛东丗丄丟万丅 != null)
        {
            goto label_54;
        }
        
        label_53:
        label_54:
        this.七丈丛东丗丄丟万丅.name = val_45;
        this.七丈丛东丗丄丟万丅.MarkDynamic();
        val_44 = 1;
        label_46:
        if(((("[NGUI] Mesh" != val_16) || ("[NGUI] Mesh" != val_16)) || ("[NGUI] Mesh" != val_16)) || ("[NGUI] Mesh" != val_16))
        {
            goto label_79;
        }
        
        if((this.panel == 0) || (this.panel.renderQueue == 0))
        {
            goto label_147;
        }
        
        if(this.七丈丛东丗丄丟万丅 != 0)
        {
            goto label_87;
        }
        
        label_79:
        label_147:
        UnityEngine.Object.__il2cppRuntimeField_cctor_finished = UnityEngine.Object.__il2cppRuntimeField_cctor_finished >> 1;
        this.下丂丒专三丅一丏万 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
        if(1 == 0)
        {
            goto label_89;
        }
        
        this.七丈丛东丗丄丟万丅.Clear();
        val_44 = 1;
        this.七丈丛东丗丄丟万丅.vertices = this.verts.东与上丗与丏下丂丘();
        this.七丈丛东丗丄丟万丅.uv = this.uvs.东与上丗与丏下丂丘();
        this.七丈丛东丗丄丟万丅.colors32 = this.cols.东与上丗与丏下丂丘();
        if(this.norms != null)
        {
                this.七丈丛东丗丄丟万丅.normals = this.norms.东与上丗与丏下丂丘();
        }
        
        if(this.tans == null)
        {
            goto label_119;
        }
        
        this.七丈丛东丗丄丟万丅.tangents = this.tans.东与上丗与丏下丂丘();
        if((val_44 & 1) != 0)
        {
            goto label_121;
        }
        
        goto label_123;
        label_89:
        int val_31 = this.七丈丛东丗丄丟万丅.vertexCount;
        this.七丈丛东丗丄丟万丅.Clear();
        val_44 = 1;
        this.七丈丛东丗丄丟万丅.vertices = this.verts;
        this.七丈丛东丗丄丟万丅.uv = this.uvs;
        this.七丈丛东丗丄丟万丅.colors32 = this.cols;
        if(this.norms != null)
        {
                this.七丈丛东丗丄丟万丅.normals = this.cols;
        }
        
        if(this.tans == null)
        {
            goto label_119;
        }
        
        this.七丈丛东丗丄丟万丅.tangents = this.cols;
        if((val_44 & 1) != 0)
        {
            goto label_121;
        }
        
        goto label_122;
        label_119:
        if(val_44 == 0)
        {
            goto label_123;
        }
        
        label_121:
        val_42 = this.tans.丐且丙丌丈丈丐专丘(丂世七丆上丁专且丛:  专丟丘三丆丌丈下东, 丒与丐丌丏上上丒一:  val_17);
        this.三丑七丂丝丑万丁世 = val_42;
        this.七丈丛东丗丄丟万丅.triangles = val_42;
        label_123:
        if(1 != 0)
        {
            goto label_125;
        }
        
        label_122:
        if(this.alwaysOnScreen == true)
        {
            goto label_126;
        }
        
        label_125:
        val_42 = this.七丈丛东丗丄丟万丅;
        val_42.RecalculateBounds();
        label_126:
        this.专丈丐上丈丅丌专丙.mesh = this.七丈丛东丗丄丟万丅;
        label_41:
        if(this.丁丝一不专七丕七丘 == 0)
        {
                val_46 = this.gameObject.GetComponent<UnityEngine.MeshRenderer>();
            this.丁丝一不专七丕七丘 = val_46;
        }
        else
        {
                val_46 = this.丁丝一不专七丕七丘;
        }
        
        if(val_46 == 0)
        {
                this.丁丝一不专七丕七丘 = this.gameObject.AddComponent<UnityEngine.MeshRenderer>();
        }
        
        this.七丙东丈丅丂丌丛丞();
        goto label_138;
        label_87:
        var val_41 = (this.七丈丛东丗丄丟万丅.vertexCount != UnityEngine.Object.__il2cppRuntimeField_cctor_finished) ? 1 : 0;
        goto label_147;
    }
    private int[] 丐且丙丌丈丈丐专丘(int 丂世七丆上丁专且丛, int 丒与丐丌丏上上丒一)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        System.Int32[] val_9;
        var val_10;
        var val_11;
        var val_12;
        val_5 = 丒与丐丌丏上上丒一;
        val_6 = null;
        val_6 = null;
        int val_1 = UIDrawCall.不丟万万丗丈丕与专.Count;
        if(val_1 >= 1)
        {
                val_7 = 0;
            do
        {
            val_8 = null;
            val_8 = null;
            val_9 = UIDrawCall.不丟万万丗丈丕与专.Item[0];
            if(val_9 != null)
        {
                if(val_2.Length == val_5)
        {
                return val_9;
        }
        
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 < val_1);
        
        }
        
        int[] val_3 = new int[0];
        val_9 = val_3;
        if(丂世七丆上丁专且丛 >= 1)
        {
                int val_14 = 0;
            do
        {
            var val_4 = 0 + 1;
            val_9[0] = val_14;
            var val_5 = 0 + 1;
            var val_6 = 0 + 2;
            val_14 = val_14 + 1;
            val_9[((long)(int)((0 + 1))) << 2] = val_14;
            val_5 = val_5 + 1;
            var val_7 = 0 + 3;
            val_14 = val_14 + 1;
            val_9[((long)(int)((0 + 2))) << 2] = val_14;
            val_5 = val_5 + 1;
            var val_8 = 0 + 4;
            val_9[((long)(int)((0 + 3))) << 2] = val_14;
            val_5 = val_5 + 1;
            val_7 = 0 + 5;
            int val_9 = val_14 + 1;
            val_9[((long)(int)((0 + 4))) << 2] = val_9;
            val_5 = (val_5 + 1) + 1;
            val_9[((long)(int)((0 + 5))) << 2] = val_9 - 3;
        }
        while((val_9 + 1) < 丂世七丆上丁专且丛);
        
        }
        
        val_10 = null;
        val_10 = null;
        if(UIDrawCall.不丟万万丗丈丕与专.Count >= 11)
        {
                val_11 = null;
            val_11 = null;
            UIDrawCall.不丟万万丗丈丕与专.RemoveAt(index:  0);
        }
        
        val_12 = null;
        val_12 = null;
        UIDrawCall.不丟万万丗丈丕与专.Add(item:  val_3);
        return val_9;
    }
    private void OnWillRenderObject()
    {
        UnityEngine.Texture2D val_33;
        UnityEngine.Material val_34;
        UIPanel val_35;
        var val_36;
        float val_37;
        float val_38;
        var val_39;
        int val_40;
        UIPanel val_41;
        float val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        val_33 = this;
        this.七丙东丈丅丂丌丛丞();
        if(this.onRender != null)
        {
                val_34 = this.不丑丕一丐丑丁一丙;
            if(val_34 == null)
        {
                val_34 = this.七东丟不一丄丒丛世;
        }
        
            this.onRender.Invoke(世丑丘丘丂专丅丆与:  val_34);
        }
        
        if(this.不丑丕一丐丑丁一丙 == 0)
        {
                return;
        }
        
        if(this.丙丏丆丕丂丞下丘世 == 0)
        {
                return;
        }
        
        if(this.丏上业丛一且丝丏且 != false)
        {
                val_35 = this.panel;
            if(this.panel == null)
        {
                val_35 = this.panel;
        }
        
            UnityEngine.Vector2 val_2 = val_35.clipSoftness;
            val_38 = val_2.y;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  1000f, y:  1000f);
            if(val_2.x > 0f)
        {
                float val_4 = S10 / val_2.x;
        }
        
            if(val_38 > 0f)
        {
                float val_5 = S11 / val_38;
        }
        
            val_39 = null;
            val_39 = null;
            val_40 = mem[UIDrawCall.东丝丑丒丘丏丂丒丙 + 32];
            val_40 = UIDrawCall.东丝丑丒丘丏丂丒丙 + 32;
            float val_32 = -this.panel.drawCallClipRange;
            float val_33 = -S12;
            float val_34 = 1f;
            val_32 = val_32 / S10;
            val_33 = val_33 / S11;
            float val_6 = val_34 / S10;
            val_34 = val_34 / S11;
            this.不丑丕一丐丑丁一丙.SetVector(nameID:  val_40, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_33 = this.clipTexture;
            this.不丑丕一丐丑丁一丙.SetTexture(name:  "_ClipTex", value:  val_33);
            return;
        }
        
        val_41 = this.panel;
        if(this.丄丑丆丏万丝丏丏丈 != false)
        {
                UnityEngine.Vector2 val_7 = val_41.clipSoftness;
            float val_35 = -this.panel.drawCallClipRange;
            float val_36 = -val_7.y;
            val_35 = val_35 / S11;
            val_36 = val_36 / S10;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_35, y:  val_36);
            float val_37 = 1f;
            val_37 = val_37 / S10;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_37 / S11, y:  val_37);
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  1000f, y:  1000f);
            this.不丑丕一丐丑丁一丙.mainTextureOffset = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            this.不丑丕一丐丑丁一丙.mainTextureScale = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
            val_33 = this.不丑丕一丐丑丁一丙;
            UnityEngine.Vector4 val_14 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = S11 / val_7.x, y = S10 / val_7.y});
            val_38 = val_14.x;
            val_37 = val_14.z;
            val_33.SetVector(name:  "_ClipSharpness", value:  new UnityEngine.Vector4() {x = val_38, y = val_14.y, z = val_37, w = val_14.w});
            return;
        }
        
        val_40 = 0;
        goto label_30;
        label_56:
        if(val_41.hasClipping == false)
        {
            goto label_32;
        }
        
        val_38 = this.panel.drawCallClipRange;
        val_44 = 0f;
        if(val_41 == this.panel)
        {
            goto label_36;
        }
        
        UnityEngine.Vector3 val_19 = this.panel.cachedTransform.position;
        UnityEngine.Vector3 val_20 = val_41.cachedTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Quaternion val_22 = this.panel.cachedTransform.rotation;
        UnityEngine.Quaternion val_24 = val_41.cachedTransform.rotation;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        val_36 = 万丗丅且丄丑世专与.且三且不与东丟七丐(一不丅与丟丌丏丟东:  val_25.y);
        val_44 = 万丗丅且丄丑世专与.且三且不与东丟七丐(一不丅与丟丌丏丟东:  val_25.z);
        val_45 = 0.001f;
        val_38 = val_38 - val_20.x;
        val_46 = val_20.y;
        val_42 = S11 - val_46;
        if((System.Math.Abs(万丗丅且丄丑世专与.且三且不与东丟七丐(一不丅与丟丌丏丟东:  val_25.x))) > val_45)
        {
            goto label_47;
        }
        
        val_45 = 0.001f;
        val_46 = System.Math.Abs(val_36);
        if(val_46 <= val_45)
        {
            goto label_50;
        }
        
        label_47:
        UnityEngine.Debug.LogWarning(message:  "Panel can only be clipped properly if X and Y rotation is left at 0", context:  this.panel);
        label_50:
        val_37 = ???;
        val_43 = ???;
        label_36:
        UnityEngine.Vector2 val_29 = val_41.clipSoftness;
        this.丌与七世下丝丘下不(丞世不丒下上上丝丑:  0, 七丛三一丗下丅丈丛:  new UnityEngine.Vector4() {x = val_38, y = val_42, z = val_37, w = val_43}, 与丝丛万丞丙丞丏丐:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y}, 一不丅与丟丌丏丟东:  val_44);
        val_40 = 1;
        label_32:
        val_41 = val_41.parentPanel;
        label_30:
        if(val_41 != 0)
        {
            goto label_56;
        }
    
    }
    private void 丌与七世下丝丘下不(int 丞世不丒下上上丝丑, UnityEngine.Vector4 七丛三一丗下丅丈丛, UnityEngine.Vector2 与丝丛万丞丙丞丏丐, float 一不丅与丟丌丏丟东)
    {
        float val_6;
        float val_7;
        int val_8;
        var val_9;
        System.Int32[] val_10;
        var val_11;
        val_6 = 一不丅与丟丌丏丟东;
        val_7 = 七丛三一丗下丅丈丛.z;
        val_8 = 丞世不丒下上上丝丑;
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  1000f, y:  1000f);
        if(与丝丛万丞丙丞丏丐.x > 0f)
        {
                float val_2 = val_7 / 与丝丛万丞丙丞丏丐.x;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = UIDrawCall.东丝丑丒丘丏丂丒丙;
        if(UIDrawCall.东丝丑丒丘丏丂丒丙.Length <= val_8)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        System.Int32[] val_4 = UIDrawCall.东丝丑丒丘丏丂丒丙 + (((long)(int)(丞世不丒下上上丝丑)) << 2);
        float val_6 = -七丛三一丗下丅丈丛.x;
        float val_7 = -七丛三一丗下丅丈丛.y;
        float val_8 = 1f;
        val_6 = val_6 / val_7;
        val_7 = val_7 / 七丛三一丗下丅丈丛.w;
        七丛三一丗下丅丈丛.z = val_8 / val_7;
        val_8 = val_8 / 七丛三一丗下丅丈丛.w;
        this.不丑丕一丐丑丁一丙.SetVector(nameID:  (UIDrawCall.东丝丑丒丘丏丂丒丙 + ((long)(int)(丞世不丒下上上丝丑)) << 2) + 32, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_10 = UIDrawCall.下丆丟丑业丁丐丑三;
        val_7 = 七丛三一丗下丅丈丛.w / 与丝丛万丞丙丞丏丐.y;
        val_6 = val_6 * (-0.01745329f);
        System.Int32[] val_5 = val_10 + (((long)(int)(丞世不丒下上上丝丑)) << 2);
        val_8 = mem[(UIDrawCall.下丆丟丑业丁丐丑三 + ((long)(int)(丞世不丒下上上丝丑)) << 2) + 32];
        val_8 = (UIDrawCall.下丆丟丑业丁丐丑三 + ((long)(int)(丞世不丒下上上丝丑)) << 2) + 32;
        this.不丑丕一丐丑丁一丙.SetVector(nameID:  val_8, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
    }
    private void Awake()
    {
        System.Int32[] val_11;
        var val_12;
        var val_13;
        val_12 = null;
        val_12 = null;
        if(UIDrawCall.东丝丑丒丘丏丂丒丙 == null)
        {
                val_11 = new int[4];
            val_11[0] = UnityEngine.Shader.PropertyToID(name:  "_ClipRange0");
            val_11[0] = UnityEngine.Shader.PropertyToID(name:  "_ClipRange1");
            val_11[1] = UnityEngine.Shader.PropertyToID(name:  "_ClipRange2");
            val_11[1] = UnityEngine.Shader.PropertyToID(name:  "_ClipRange4");
            val_12 = null;
            val_12 = null;
            UIDrawCall.东丝丑丒丘丏丂丒丙 = val_11;
        }
        
        val_12 = null;
        if(UIDrawCall.下丆丟丑业丁丐丑三 != null)
        {
                return;
        }
        
        val_11 = new int[4];
        val_11[0] = UnityEngine.Shader.PropertyToID(name:  "_ClipArgs0");
        val_11[0] = UnityEngine.Shader.PropertyToID(name:  "_ClipArgs1");
        val_11[1] = UnityEngine.Shader.PropertyToID(name:  "_ClipArgs2");
        val_11[1] = UnityEngine.Shader.PropertyToID(name:  "_ClipArgs3");
        val_13 = null;
        val_13 = null;
        UIDrawCall.下丆丟丑业丁丐丑三 = val_11;
    }
    private void OnEnable()
    {
        this.丝上丛丅七万丅与丟 = true;
    }
    private void OnDisable()
    {
        UnityEngine.Material val_8;
        var val_9;
        var val_10;
        this.panel = 0;
        this.clipTexture = 0;
        this.manager = 0;
        this.万丏与丄东丒丙丆丒 = 0;
        this.丟万丗上世一丛丄专 = 0;
        this.七东丟不一丄丒丛世 = 0;
        this.depthStart = -9223372034707292161;
        this.depthEnd = -2147483648;
        if(this.丁丝一不专七丕七丘 != 0)
        {
                this.丁丝一不专七丕七丘.sharedMaterials = new UnityEngine.Material[0];
        }
        
        val_8 = 1152921505234800640;
        val_9 = null;
        val_9 = null;
        if((NGUIMaterialPool.丄丘七三上丕世丞业 == 0) || (this.不丑丕一丐丑丁一丙 == 0))
        {
            goto label_12;
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = this.不丑丕一丐丑丁一丙;
        if((NGUIMaterialPool.丄丘七三上丕世丞业.下一丟丆丅万丏丅丁(丌下上上世丏七丒丑:  this.不丑丕一丐丑丁一丙.shader.name, 丘上专不丂万业不一:  val_8)) == true)
        {
            goto label_18;
        }
        
        label_12:
        不丌丂丁丄一与丆丙.丟丘下万世世丐丆丅(万且万且丑丗且丌丆:  this.不丑丕一丐丑丁一丙);
        label_18:
        this.不丑丕一丐丑丁一丙 = 0;
    }
    private void OnDestroy()
    {
        不丌丂丁丄一与丆丙.丟丘下万世世丐丆丅(万且万且丑丗且丌丆:  this.七丈丛东丗丄丟万丅);
        this.七丈丛东丗丄丟万丅 = 0;
    }
    public static UIDrawCall Create(UIPanel 丛丘下丗业丂一且业, UnityEngine.Material 世丑丘丘丂专丅丆与, UnityEngine.Texture 丟三丟三丅专丂丄丂, UnityEngine.Shader 丕丄与专丛丝丄丐下, UnityEngine.Texture 丆丟丞丌丝丏丒丏丑)
    {
        return UIDrawCall.东丝七业丄丑丒世七(丒丘丏上丙丟丑丕丈:  0, 丕上丛业丝七三万丐:  丛丘下丗业丂一且业, 世丑丘丘丂专丅丆与:  世丑丘丘丂专丅丆与, 丟三丟三丅专丂丄丂:  丟三丟三丅专丂丄丂, 丕丄与专丛丝丄丐下:  丕丄与专丛丝丄丐下, 丆丟丞丌丝丏丒丏丑:  丆丟丞丌丝丏丒丏丑);
    }
    private static UIDrawCall 东丝七业丄丑丒世七(string 丒丘丏上丙丟丑丕丈, UIPanel 丕上丛业丝七三万丐, UnityEngine.Material 世丑丘丘丂专丅丆与, UnityEngine.Texture 丟三丟三丅专丂丄丂, UnityEngine.Shader 丕丄与专丛丝丄丐下, UnityEngine.Texture 丆丟丞丌丝丏丒丏丑)
    {
        UIDrawCall val_1 = UIDrawCall.东丝七业丄丑丒世七(丒丘丏上丙丟丑丕丈:  丒丘丏上丙丟丑丕丈);
        val_1.gameObject.layer = 丕上丛业丝七三万丐.cachedGameObject.layer;
        if(val_1 != null)
        {
                val_1.baseMaterial = 世丑丘丘丂专丅丆与;
            val_1.mainTexture = 丟三丟三丅专丂丄丂;
            val_1.maskTexture = 丆丟丞丌丝丏丒丏丑;
        }
        else
        {
                this.baseMaterial = 世丑丘丘丂专丅丆与;
            this.mainTexture = 丟三丟三丅专丂丄丂;
            this.maskTexture = 丆丟丞丌丝丏丒丏丑;
        }
        
        val_1.shader = 丕丄与专丛丝丄丐下;
        val_1.renderQueue = 丕上丛业丝七三万丐.startingRenderQueue;
        int val_5 = 丕上丛业丝七三万丐.sortingOrder;
        if(val_1 != null)
        {
                val_1.sortingOrder = val_5;
        }
        else
        {
                this.sortingOrder = val_5;
        }
        
        val_1.manager = 丕上丛业丝七三万丐;
        return val_1;
    }
    private static UIDrawCall 东丝七业丄丑丒世七(string 丒丘丏上丙丟丑丕丈)
    {
        var val_5;
        var val_6;
        UIDrawCall val_7;
        UnityEngine.GameObject val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        if((UIDrawCall.业一丂丗丗万丒丞下 + 24) >= 1)
        {
                val_6 = null;
            val_6 = null;
            val_7 = UIDrawCall.业一丂丗丗万丒丞下.丁丆丞丛上世专丟丕();
            UIDrawCall.不丒万丕丁丅且下丌.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_7);
            if(丒丘丏上丙丟丑丕丈 != null)
        {
                val_7.name = 丒丘丏上丙丟丑丕丈;
        }
        
            val_8 = val_7.gameObject;
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
            return val_7;
        }
        
        UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  丒丘丏上丙丟丑丕丈);
        UnityEngine.Object.DontDestroyOnLoad(target:  val_3);
        val_9 = null;
        val_7 = val_3.AddComponent<UIDrawCall>();
        val_9 = null;
        val_8 = UIDrawCall.不丒万丕丁丅且下丌;
        val_8.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_7);
        return val_7;
    }
    public static void ClearAll()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        if(UIDrawCall.不丒万丕丁丅且下丌 == 0)
        {
                val_7 = null;
        }
        
        val_8 = (uint)(((uint)((UIDrawCall.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        if((UIDrawCall.不丒万丕丁丅且下丌 + 24) >= 1)
        {
                var val_2 = (UIDrawCall.不丒万丕丁丅且下丌 + 24) + 1;
            do
        {
            val_9 = null;
            UIDrawCall val_4 = UIDrawCall.不丒万丕丁丅且下丌.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  val_2 - 2);
            if((UnityEngine.Object.op_Implicit(exists:  val_4)) != false)
        {
                UnityEngine.GameObject val_6 = val_4.gameObject;
            if(UnityEngine.Application.isPlaying != false)
        {
                不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                不丌丂丁丄一与丆丙.丟丘下万世世丐丆丅(万且万且丑丗且丌丆:  val_6);
        }
        
        }
        
            val_10 = null;
            val_2 = val_2 - 1;
            val_8 = (uint)(((uint)((UIDrawCall.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        }
        while(val_2 > 1);
        
        }
        
        val_10 = null;
        UIDrawCall.不丒万丕丁丅且下丌.世业丒万丘丆专丘丐();
    }
    public static void ReleaseAll()
    {
        UIDrawCall.ClearAll();
        UIDrawCall.ReleaseInactive();
    }
    public static void ReleaseInactive()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        if(UIDrawCall.业一丂丗丗万丒丞下 == null)
        {
                val_6 = null;
        }
        
        val_7 = (uint)(((uint)((UIDrawCall.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        if((UIDrawCall.业一丂丗丗万丒丞下 + 24) >= 1)
        {
                var val_1 = (UIDrawCall.业一丂丗丗万丒丞下 + 24) + 1;
            do
        {
            val_8 = null;
            UIDrawCall val_3 = UIDrawCall.业一丂丗丗万丒丞下.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  val_1 - 2);
            if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
        {
                不丌丂丁丄一与丆丙.丟丘下万世世丐丆丅(万且万且丑丗且丌丆:  val_3.gameObject);
        }
        
            val_9 = null;
            val_1 = val_1 - 1;
            val_7 = (uint)(((uint)((UIDrawCall.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        }
        while(val_1 > 1);
        
        }
        
        val_9 = null;
        UIDrawCall.业一丂丗丗万丒丞下.世业丒万丘丆专丘丐();
    }
    public static int Count(UIPanel 丛丘下丗业丂一且业)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = 0;
        val_5 = 0;
        goto label_1;
        label_11:
        val_6 = null;
        val_6 = null;
        UIDrawCall val_1 = UIDrawCall.不丒万丕丁丅且下丌.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        val_5 = val_5 + (UnityEngine.Object.op_Equality(x:  val_1.manager, y:  丛丘下丗业丂一且业));
        val_4 = 1;
        label_1:
        val_7 = null;
        val_7 = null;
        if(val_4 < (UIDrawCall.不丒万丕丁丅且下丌 + 24))
        {
            goto label_11;
        }
        
        return (int)val_5;
    }
    public static void Destroy(UIDrawCall 丘七专丆丘丛丒丗东)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        if((UnityEngine.Object.op_Implicit(exists:  丘七专丆丘丛丒丗东)) == false)
        {
                return;
        }
        
        丘七专丆丘丛丒丗东.onRender = 0;
        val_7 = null;
        if(UnityEngine.Application.isPlaying != false)
        {
                val_8 = null;
            if((UIDrawCall.不丒万丕丁丅且下丌.Remove(下丅丙一丂丗丅丝七:  丘七专丆丘丛丒丗东)) == false)
        {
                return;
        }
        
            不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  丘七专丆丘丛丒丗东.gameObject, 丏业丟一东丂东丘丛:  false);
            val_9 = null;
            val_9 = null;
            UIDrawCall.业一丂丗丗万丒丞下.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  丘七专丆丘丛丒丗东);
            return;
        }
        
        val_10 = null;
        bool val_5 = UIDrawCall.不丒万丕丁丅且下丌.Remove(下丅丙一丂丗丅丝七:  丘七专丆丘丛丒丗东);
        不丌丂丁丄一与丆丙.丟丘下万世世丐丆丅(万且万且丑丗且丌丆:  丘七专丆丘丛丒丗东.gameObject);
    }
    public UIDrawCall()
    {
        this.depthStart = -9223372034707292161;
        this.depthEnd = -2147483648;
        this.verts = new 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3>();
        this.norms = new 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3>();
        this.tans = new 丒丞丕丕七丁丗丟丛<UnityEngine.Vector4>();
        this.uvs = new 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2>();
        this.cols = new 丒丞丕丕七丁丗丟丛<UnityEngine.Color32>();
        this.丝上丛丅七万丅与丟 = true;
        this.丘万丟丞丕不丈丌丙 = 3000;
        this.专丁下七丞丂丏下丕 = new System.Text.StringBuilder(capacity:  32);
    }
    private static UIDrawCall()
    {
        UIDrawCall.不丒万丕丁丅且下丌 = new 丒丞丕丕七丁丗丟丛<UIDrawCall>();
        UIDrawCall.业一丂丗丗万丒丞下 = new 丒丞丕丕七丁丗丟丛<UIDrawCall>();
        UIDrawCall.不丟万万丗丈丕与专 = new System.Collections.Generic.List<System.Int32[]>(capacity:  10);
        UIDrawCall.东丝丑丒丘丏丂丒丙 = 0;
        UIDrawCall.下丆丟丑业丁丐丑三 = 0;
    }

}
