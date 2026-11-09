using UnityEngine;
internal sealed class TextMeshOutline : PGBehaviour
{
    // Fields
    public float pixelSize;
    public UnityEngine.Color outlineColor;
    public bool resolutionDependant;
    public int doubleResolution;
    public int renderOrderinLayer;
    private UnityEngine.TextMesh 专丘一丕专业七专丏;
    private UnityEngine.MeshRenderer 下丆丙丅丅与丏丗下;
    
    // Methods
    private void Start()
    {
        var val_14;
        int val_15;
        this.专丘一丕专业七专丏 = this.GetComponent<UnityEngine.TextMesh>();
        this.下丆丙丅丅与丏丗下 = this.GetComponent<UnityEngine.MeshRenderer>();
        var val_14 = 8;
        label_22:
        System.Type[] val_3 = new System.Type[1];
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        if(val_3 == null)
        {
            goto label_3;
        }
        
        if(val_4 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_4 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_3[0] = val_4;
        UnityEngine.GameObject val_5 = new UnityEngine.GameObject(name:  "outline", components:  val_3);
        val_5.transform.parent = this.transform;
        val_5.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.MeshRenderer val_9 = val_5.GetComponent<UnityEngine.MeshRenderer>();
        UnityEngine.Material val_11 = new UnityEngine.Material(source:  this.下丆丙丅丅与丏丗下.material);
        if(val_9 != null)
        {
                val_9.material = val_11;
            val_9.castShadows = false;
            val_14 = val_9;
        }
        else
        {
                0.material = val_11;
            0.castShadows = false;
            val_14 = 0;
        }
        
        val_14.receiveShadows = false;
        val_14.sortingLayerID = this.下丆丙丅丅与丏丗下.sortingLayerID;
        string val_13 = this.下丆丙丅丅与丏丗下.sortingLayerName;
        if(val_9 != null)
        {
                val_14.sortingLayerName = val_13;
            val_15 = this.renderOrderinLayer;
        }
        else
        {
                val_14.sortingLayerName = val_13;
            val_15 = this.renderOrderinLayer;
        }
        
        val_14.sortingOrder = val_15;
        val_14 = val_14 - 1;
        if(val_14 != 0)
        {
            goto label_22;
        }
    
    }
    private void LateUpdate()
    {
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        val_42 = null;
        val_42 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
                return;
        }
        
        val_43 = null;
        val_43 = null;
        UnityEngine.Vector3 val_3 = this.transform.position;
        UnityEngine.Vector3 val_4 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Color val_5 = this.专丘一丕专业七专丏.color;
        UnityEngine.Color val_6 = this.专丘一丕专业七专丏.color;
        mem[1152921540531264136] = val_5.a * val_6.a;
        val_44 = 0;
        goto label_12;
        label_58:
        UnityEngine.TextMesh val_10 = this.transform.GetChild(index:  0).GetComponent<UnityEngine.TextMesh>();
        if((System.String.op_Equality(a:  val_10.name, b:  "outline")) == false)
        {
            goto label_16;
        }
        
        val_10.color = new UnityEngine.Color() {r = this.outlineColor, g = V12.16B, b = V13.16B, a = V14.16B};
        val_10.text = this.专丘一丕专业七专丏.text;
        val_10.alignment = this.专丘一丕专业七专丏.alignment;
        val_10.anchor = this.专丘一丕专业七专丏.anchor;
        val_10.characterSize = this.专丘一丕专业七专丏.characterSize;
        val_10.font = this.专丘一丕专业七专丏.font;
        val_10.fontSize = this.专丘一丕专业七专丏.fontSize;
        val_10.fontStyle = this.专丘一丕专业七专丏.fontStyle;
        val_10.richText = this.专丘一丕专业七专丏.richText;
        val_10.tabSize = this.专丘一丕专业七专丏.tabSize;
        val_10.lineSpacing = this.专丘一丕专业七专丏.lineSpacing;
        val_10.offsetZ = this.专丘一丕专业七专丏.offsetZ;
        if(this.resolutionDependant == false)
        {
            goto label_40;
        }
        
        if(UnityEngine.Screen.width <= this.doubleResolution)
        {
            goto label_41;
        }
        
        val_45 = 1;
        goto label_43;
        label_40:
        val_45 = 0;
        goto label_43;
        label_41:
        int val_26 = UnityEngine.Screen.height;
        label_43:
        UnityEngine.Vector3 val_28 = val_26.丞丝七丑一专丘且丗(七丞丙丒三丕且丌丟:  0);
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  (((val_26 > this.doubleResolution) ? 1 : 0) == 0) ? this.pixelSize : (this.pixelSize + this.pixelSize));
        val_46 = null;
        val_46 = null;
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
        UnityEngine.Vector3 val_33 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        val_10.transform.position = new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
        UnityEngine.MeshRenderer val_37 = this.transform.GetChild(index:  0).GetComponent<UnityEngine.MeshRenderer>();
        val_37.sortingLayerID = this.下丆丙丅丅与丏丗下.sortingLayerID;
        val_37.sortingLayerName = this.下丆丙丅丅与丏丗下.sortingLayerName;
        label_16:
        val_44 = 1;
        label_12:
        if(val_44 < this.transform.childCount)
        {
            goto label_58;
        }
    
    }
    private UnityEngine.Vector3 丞丝七丑一专丘且丗(int 七丞丙丒三丕且丌丟)
    {
        var val_2 = (七丞丙丒三丕且丌丟 < 0) ? (七丞丙丒三丕且丌丟 + 7) : 七丞丙丒三丕且丌丟;
        val_2 = val_2 & 4294967288;
        val_2 = 七丞丙丒三丕且丌丟 - val_2;
        if(val_2 <= 7)
        {
                var val_4 = 106023176 + ((七丞丙丒三丕且丌丟 - (七丞丙丒三丕且丌丟 < 0 ? (七丞丙丒三丕且丌丟 + 7) : 七丞丙丒三丕且丌丟 & 4294967288))) << 2;
            val_4 = val_4 + 106023176;
        }
        else
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
    
    }
    public TextMeshOutline()
    {
        this.pixelSize = 1f;
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        this.outlineColor = val_1;
        mem[1152921540531615104] = val_1.g;
        mem[1152921540531615108] = val_1.b;
        mem[1152921540531615112] = val_1.a;
        this.doubleResolution = 1024;
    }

}
