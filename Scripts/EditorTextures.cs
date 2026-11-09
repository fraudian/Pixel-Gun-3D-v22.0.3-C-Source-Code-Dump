using UnityEngine;
internal sealed class EditorTextures : MonoBehaviour
{
    // Fields
    private UnityEngine.Color 专丁丙丛丐上上丆丞;
    public UITexture canvasTexture;
    private bool 丐丞丆丝丑丕丁与业;
    private UnityEngine.Vector2 东专且业下丟丛且丈;
    private bool 业三一下丈丆丘与上;
    public UITexture fonCanvas;
    public Rilisoft.ButtonHandler prevHistoryButton;
    public Rilisoft.ButtonHandler nextHistoryButton;
    private UIButton 丄丁丟丕丕世丅丕丑;
    private UIButton 丌业且七一丝丑丕丏;
    public System.Collections.ArrayList arrHistory;
    public int currentHistoryIndex;
    private bool 丑丝丝丞业丂丗上专;
    public UnityEngine.GameObject saveFrame;
    private bool 丂丙丕丗业丟丗且丙;
    
    // Methods
    private void Start()
    {
        System.EventHandler val_9;
        if(this.prevHistoryButton != 0)
        {
                System.EventHandler val_2 = null;
            val_9 = val_2;
            val_2 = new System.EventHandler(object:  this, method:  System.Void EditorTextures::丛下丕丏丝七东丝丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.prevHistoryButton.add_Clicked(丙业与丙丗丝不丈东:  val_2);
            this.丄丁丟丕丕世丅丕丑 = this.prevHistoryButton.gameObject.GetComponent<UIButton>();
        }
        
        if(this.nextHistoryButton == 0)
        {
                return;
        }
        
        System.EventHandler val_6 = null;
        val_9 = val_6;
        val_6 = new System.EventHandler(object:  this, method:  System.Void EditorTextures::业上丒丁丙丙丄丘丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        this.nextHistoryButton.add_Clicked(丙业与丙丗丝不丈东:  val_6);
        this.丌业且七一丝丑丕丏 = this.nextHistoryButton.gameObject.GetComponent<UIButton>();
    }
    public void ToggleSymmetry(bool isSymmetry)
    {
        this.丂丙丕丗业丟丗且丙 = isSymmetry;
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    public void SetStartCanvas(UnityEngine.Texture2D 丞丝丈丑丐丝丌丛丆)
    {
        float val_10;
        UnityEngine.Texture2D val_2 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  丞丝丈丑丐丝丌丛丆));
        float val_10 = (float)this.canvasTexture.isAnchoredHorizontally;
        val_10 = 400f / val_10;
        val_10 = 400f / (float)this.canvasTexture.canBeAnchored;
        if(val_10 < 0)
        {
                val_10 = val_10;
        }
        
        int val_5 = UnityEngine.Mathf.RoundToInt(f:  val_10);
        this.canvasTexture.width = this.canvasTexture.isAnchoredHorizontally * val_5;
        this.canvasTexture.height = this.canvasTexture.canBeAnchored * val_5;
        this.UpdateFonCanvas();
        this.AddCanvasTextureInHistory();
    }
    private void 丛下丕丏丝七东丝丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        int val_1 = this.currentHistoryIndex;
        val_1 = val_1 - 1;
        if()
        {
                this.currentHistoryIndex = val_1;
        }
        
        this.丒丌世下一且丒丆世();
    }
    private void 业上丒丁丙丙丄丘丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.currentHistoryIndex < (this.arrHistory - 1))
        {
                int val_2 = this.currentHistoryIndex;
            val_2 = val_2 + 1;
            this.currentHistoryIndex = val_2;
        }
        
        this.丒丌世下一且丒丆世();
    }
    private void 丒丌世下一且丒丆世()
    {
        System.Collections.ArrayList val_3 = this.arrHistory;
        if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        UnityEngine.Texture2D val_2 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_3);
        if(this.canvasTexture != null)
        {
                return;
        }
    
    }
    public void AddCanvasTextureInHistory()
    {
        UnityEngine.Texture2D val_5;
        goto label_1;
        label_5:
        label_1:
        if(this.currentHistoryIndex < (this.arrHistory - 1))
        {
            goto label_5;
        }
        
        val_5 = this.canvasTexture;
        if((val_5 != null) && (null != null))
        {
                val_5 = 0;
        }
        
        UnityEngine.Texture2D val_3 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_5);
        this.currentHistoryIndex = this.arrHistory - 1;
    }
    private void Update()
    {
        System.Collections.ArrayList val_27;
        var val_28;
        float val_30;
        float val_31;
        float val_34;
        val_27 = 1152921504848912384;
        if(this.丄丁丟丕丕世丅丕丑 != 0)
        {
                val_28 = 0;
            if(this.丌业且七一丝丑丕丏 != 0)
        {
                var val_3 = (this.currentHistoryIndex != 0) ? 1 : 0;
            val_3 = this.丄丁丟丕丕世丅丕丑 ^ val_3;
            if((val_3 & 1) != 0)
        {
                var val_4 = (this.currentHistoryIndex != 0) ? 1 : 0;
        }
        
            val_27 = this.arrHistory;
            var val_6 = (this.currentHistoryIndex < (val_27 - 1)) ? 1 : 0;
            val_6 = this.丌业且七一丝丑丕丏 ^ val_6;
            if((val_6 & 1) != 0)
        {
                val_27 = this.arrHistory;
            var val_8 = (this.currentHistoryIndex < (val_27 - 1)) ? 1 : 0;
        }
        
        }
        
        }
        
        int val_9 = UnityEngine.Input.touchCount;
        if(val_9 > 0)
        {
                UnityEngine.Touch val_10 = UnityEngine.Input.GetTouch(index:  0);
        }
        
        if(this.丐丞丆丝丑丕丁与业 != false)
        {
                if(val_9 >= 1)
        {
                if((专三三与三且一且一() == 3) || (专三三与三且一且一() == 4))
        {
            goto label_20;
        }
        
        }
        
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != false)
        {
                label_20:
            if(val_9 > 0)
        {
                val_31 = V0.16B;
        }
        else
        {
                UnityEngine.Vector3 val_14 = UnityEngine.Input.mousePosition;
            val_31 = val_14.x;
            UnityEngine.Vector3 val_15 = UnityEngine.Input.mousePosition;
        }
        
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_31, y:  val_15.y);
            if((this.丈丝丅丘丕万丝且丈(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y})) != false)
        {
                this.丟丙丐东丗丘丅世丒();
        }
        
            this.丐丞丆丝丑丕丁与业 = false;
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  -1f, y:  -1f);
            val_30 = val_18.y;
            this.东专且业下丟丛且丈 = val_18.x;
            mem[1152921525974647688] = val_30;
            this.AddCanvasTextureInHistory();
        }
        
        }
        
        if(this.业三一下丈丆丘与上 != false)
        {
                this.业三一下丈丆丘与上 = false;
            this.UpdateFonCanvas();
        }
        
        if(val_9 >= 1)
        {
                if(专三三与三且一且一() != 3)
        {
                if(专三三与三且一且一() != 4)
        {
            goto label_29;
        }
        
        }
        
        }
        
        if(this.丐丞丆丝丑丕丁与业 != true)
        {
                if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return;
        }
        
        }
        
        label_29:
        if(val_9 > 0)
        {
                val_34 = -1f;
        }
        else
        {
                UnityEngine.Vector3 val_22 = UnityEngine.Input.mousePosition;
            val_34 = val_22.x;
            UnityEngine.Vector3 val_23 = UnityEngine.Input.mousePosition;
        }
        
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  val_34, y:  val_23.y);
        val_31 = val_24.x;
        if((this.丈丝丅丘丕万丝且丈(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_31, y = val_24.y})) == false)
        {
                return;
        }
        
        this.丐丞丆丝丑丕丁与业 = true;
        UnityEngine.Vector2 val_26 = this.丛下丅丆且丞一丙丙(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_31, y = val_24.y});
        if(((-107047880) & 1) != 0)
        {
                return;
        }
        
        this.东专且业下丟丛且丈 = val_26;
        mem[1152921525974647688] = val_26.y;
        this.专三丆一丛不下一丝(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
    }
    private void 专三丆一丛不下一丝(UnityEngine.Vector2 下业丕七东丌丝下且)
    {
        float val_131;
        EditorTextures val_132;
        var val_133;
        var val_134;
        UISprite val_135;
        var val_136;
        int val_137;
        float val_138;
        int val_139;
        var val_140;
        UnityEngine.Texture2D val_141;
        UnityEngine.TextureWrapMode val_142;
        var val_143;
        float val_144;
        UnityEngine.Color val_145;
        float val_147;
        float val_148;
        float val_149;
        float val_150;
        EditorTextures val_151;
        int val_152;
        int val_153;
        var val_154;
        var val_155;
        var val_156;
        var val_157;
        UnityEngine.Color[] val_158;
        var val_159;
        UnityEngine.Color val_160;
        var val_161;
        int val_162;
        var val_163;
        int val_164;
        var val_165;
        var val_166;
        float val_167;
        var val_168;
        val_131 = 下业丕七东丌丝下且.y;
        val_132 = this;
        val_133 = 1152921504848912384;
        if(this.saveFrame != 0)
        {
                if(this.saveFrame.activeSelf == true)
        {
                return;
        }
        
        }
        
        val_134 = 1152921505296302080;
        if(SkinEditorController.丝丝丂不且丒丐丌上 != 4)
        {
            goto label_8;
        }
        
        if(SkinEditorController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_135 = mem[SkinEditorController.丄丞丁丈与业上丞丟 + 424];
        val_135 = SkinEditorController.丄丞丁丈与业上丞丟.newColor;
        val_136 = this.canvasTexture;
        val_137 = UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x);
        val_138 = val_131;
        val_139 = UnityEngine.Mathf.RoundToInt(f:  val_138);
        if(val_136 == null)
        {
            goto label_20;
        }
        
        val_140 = 1152921504848220160;
        if(null == null)
        {
            goto label_23;
        }
        
        val_136 = 0;
        goto label_23;
        label_8:
        SkinEditorController.丁世丁丄不丅丙丄丛 = true;
        val_141 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  (null == null) ? this.canvasTexture : 0);
        val_142 = 1;
        val_141.wrapMode = val_142;
        if(SkinEditorController.丝丝丂不且丒丐丌上 == 0)
        {
                val_143 = 1152921504838422528;
            val_145 = SkinEditorController.丐不三丐丅三丆且丅;
            val_142 = UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x);
            val_138 = val_145;
            val_148 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
            val_149 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
            val_150 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
            val_141.SetPixel(x:  val_142, y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = val_138, g = val_148, b = val_149, a = val_150});
            if(this.丂丙丕丗业丟丗且丙 != false)
        {
                val_138 = SkinEditorController.丐不三丐丅三丆且丅;
            val_142 = (val_141.width - 1) - (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x));
            val_141.SetPixel(x:  val_142, y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = val_138, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
            val_151 = val_132;
        }
        
        }
        
        if(SkinEditorController.丝丝丂不且丒丐丌上 == 1)
        {
                val_145 = SkinEditorController.丐不三丐丅三丆且丅;
            val_148 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
            val_149 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
            val_150 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
            val_141.SetPixel(x:  UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x), y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = val_145, g = val_148, b = val_149, a = val_150});
            if((UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x)) >= 1)
        {
                val_145 = SkinEditorController.丐不三丐丅三丆且丅;
            val_148 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
            val_149 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
            val_150 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
            val_141.SetPixel(x:  (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x)) - 1, y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = val_145, g = val_148, b = val_149, a = val_150});
        }
        
            if((UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x)) < (val_141.width - 1))
        {
                val_141.SetPixel(x:  (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x)) + 1, y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
        }
        
            if((UnityEngine.Mathf.RoundToInt(f:  val_131)) >= 1)
        {
                val_141.SetPixel(x:  UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x), y:  (UnityEngine.Mathf.RoundToInt(f:  val_131)) - 1, color:  new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
        }
        
            val_138 = val_131;
            val_142 = public System.Int32 UnityEngine.Texture::get_height();
            if((UnityEngine.Mathf.RoundToInt(f:  val_138)) < (val_141.height - 1))
        {
                val_142 = UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x);
            val_138 = SkinEditorController.丐不三丐丅三丆且丅;
            val_141.SetPixel(x:  val_142, y:  (UnityEngine.Mathf.RoundToInt(f:  val_131)) + 1, color:  new UnityEngine.Color() {r = val_138, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
        }
        
            if(this.丂丙丕丗业丟丗且丙 != false)
        {
                val_152 = (val_141.width - 1) - (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x));
            val_141.SetPixel(x:  val_152, y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
            if((UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x)) >= 1)
        {
                val_152 = val_141.width - (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x));
            val_141.SetPixel(x:  val_152, y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
        }
        
            val_151 = val_132;
            val_153 = public System.Int32 UnityEngine.Texture::get_width();
            if((UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x)) < (val_141.width - 1))
        {
                val_154 = null;
            val_154 = null;
            val_153 = (val_141.width - 2) - (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x));
            val_141.SetPixel(x:  val_153, y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
            val_151 = val_132;
        }
        
            if((UnityEngine.Mathf.RoundToInt(f:  val_131)) >= 1)
        {
                val_155 = null;
            val_155 = null;
            val_153 = (val_141.width - 1) - (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x));
            val_141.SetPixel(x:  val_153, y:  (UnityEngine.Mathf.RoundToInt(f:  val_131)) - 1, color:  new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
            val_151 = val_132;
        }
        
            val_138 = val_131;
            val_142 = public System.Int32 UnityEngine.Texture::get_height();
            if((UnityEngine.Mathf.RoundToInt(f:  val_138)) < (val_141.height - 1))
        {
                val_156 = null;
            val_156 = null;
            val_138 = SkinEditorController.丐不三丐丅三丆且丅;
            val_142 = (val_141.width - 1) - (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x));
            val_141.SetPixel(x:  val_142, y:  (UnityEngine.Mathf.RoundToInt(f:  val_131)) + 1, color:  new UnityEngine.Color() {r = val_138, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14});
            val_151 = val_132;
        }
        
        }
        
        }
        
        val_157 = null;
        val_157 = null;
        if(SkinEditorController.丝丝丂不且丒丐丌上 == 2)
        {
                val_145 = mem[1152921525974866200];
            val_144 = mem[1152921525974866204];
            val_147 = mem[1152921525974866208];
            val_142 = UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x);
            val_138 = val_145;
            val_148 = val_144;
            val_149 = val_147;
            val_150 = mem[1152921525974866212];
            val_141.SetPixel(x:  val_142, y:  UnityEngine.Mathf.RoundToInt(f:  val_131), color:  new UnityEngine.Color() {r = val_138, g = val_148, b = val_149, a = val_150});
            val_157 = null;
        }
        
        val_157 = null;
        if(SkinEditorController.丝丝丂不且丒丐丌上 != 3)
        {
            goto label_125;
        }
        
        val_151 = (UnityEngine.Mathf.RoundToInt(f:  下业丕七东丌丝下且.x)) + (val_141.width * (UnityEngine.Mathf.RoundToInt(f:  val_131)));
        val_158 = val_141.GetPixels();
        val_143 = (long)val_151;
        val_159 = null;
        val_160 = val_158[val_143];
        UnityEngine.Color val_118 = val_158[val_143];
        val_145 = val_158[val_143];
        UnityEngine.Color val_119 = val_158[val_143];
        val_159 = null;
        val_138 = val_160;
        val_148 = val_118;
        val_149 = val_145;
        val_150 = val_119;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_138, g = val_148, b = val_149, a = val_150}, rhs:  new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14})) == false)
        {
            goto label_125;
        }
        
        System.Collections.Generic.List<System.Int32> val_73 = new System.Collections.Generic.List<System.Int32>();
        val_73.Add(item:  val_151);
        goto label_160;
        label_163:
        val_148 = (float)val_141.width;
        val_138 = (float)val_73.Item[0] / val_148;
        val_151 = UnityEngine.Mathf.FloorToInt(f:  val_138);
        var val_120 = val_141.width;
        val_161 = null;
        val_161 = null;
        val_120 = val_73.Item[0] - (val_120 * val_151);
        val_158[(long)val_73.Item[0]] = SkinEditorController.丐不三丐丅三丆且丅;
        val_158[(long)val_73.Item[0]] = new UnityEngine.Color();
        val_158[(long)val_73.Item[0]] = new UnityEngine.Color();
        val_158[(long)val_73.Item[0]] = new UnityEngine.Color();
        val_73.RemoveAt(index:  0);
        val_141 = val_141;
        val_162 = mem[val_8 + 360 + 8];
        val_162 = val_8 + 360 + 8;
        val_158 = val_158;
        val_163 = 1152921505296302080;
        int val_80 = val_120 + 1;
        if(val_80 < val_141)
        {
                val_162 = mem[val_8 + 360 + 8];
            val_162 = val_8 + 360 + 8;
            UnityEngine.Texture2D val_81 = val_80 + (val_141 * val_151);
            val_143 = (long)val_81;
            if(val_81 >= val_71.Length)
        {
                val_162 = 0;
        }
        
            val_138 = val_158[val_143];
            val_148 = val_158[val_143];
            val_149 = val_158[val_143];
            val_150 = val_158[val_143];
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_138, g = val_148, b = val_149, a = val_150}, rhs:  new UnityEngine.Color() {r = val_160, g = val_118, b = val_145, a = val_119})) != false)
        {
                val_162 = val_80 + (val_141 * val_151);
            if((val_73.Contains(item:  val_162)) != true)
        {
                val_162 = val_80 + (val_141 * val_151);
            val_73.Add(item:  val_162);
        }
        
        }
        
        }
        
        int val_84 = val_120 - 1;
        if((val_84 & 2147483648) == 0)
        {
                val_162 = mem[val_8 + 360 + 8];
            val_162 = val_8 + 360 + 8;
            UnityEngine.Texture2D val_85 = val_84 + (val_141 * val_151);
            val_143 = (long)val_85;
            if(val_85 >= val_71.Length)
        {
                val_162 = 0;
        }
        
            val_138 = val_158[val_143];
            val_148 = val_158[val_143];
            val_149 = val_158[val_143];
            val_150 = val_158[val_143];
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_138, g = val_148, b = val_149, a = val_150}, rhs:  new UnityEngine.Color() {r = val_160, g = val_118, b = val_145, a = val_119})) != false)
        {
                val_162 = val_84 + (val_141 * val_151);
            if((val_73.Contains(item:  val_162)) != true)
        {
                val_162 = val_84 + (val_141 * val_151);
            val_73.Add(item:  val_162);
        }
        
        }
        
        }
        
        val_164 = mem[val_8 + 392 + 8];
        val_164 = val_8 + 392 + 8;
        int val_88 = val_151 + 1;
        if(val_88 < val_141)
        {
                val_164 = mem[val_8 + 360 + 8];
            val_164 = val_8 + 360 + 8;
            UnityEngine.Texture2D val_89 = val_120 + (val_141 * val_88);
            val_143 = (long)val_89;
            if(val_89 >= val_71.Length)
        {
                val_164 = 0;
        }
        
            val_138 = val_158[val_143];
            val_148 = val_158[val_143];
            val_149 = val_158[val_143];
            val_150 = val_158[val_143];
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_138, g = val_148, b = val_149, a = val_150}, rhs:  new UnityEngine.Color() {r = val_160, g = val_118, b = val_145, a = val_119})) != false)
        {
                val_164 = val_120 + (val_141 * val_88);
            if((val_73.Contains(item:  val_164)) != true)
        {
                val_164 = val_120 + (val_141 * val_88);
            val_73.Add(item:  val_164);
        }
        
        }
        
        }
        
        int val_92 = val_151 - 1;
        if((val_92 & 2147483648) == 0)
        {
                val_165 = mem[val_8 + 360 + 8];
            val_165 = val_8 + 360 + 8;
            UnityEngine.Texture2D val_93 = val_120 + (val_141 * val_92);
            val_143 = (long)val_93;
            if(val_93 >= val_71.Length)
        {
                val_165 = 0;
        }
        
            val_138 = val_158[val_143];
            val_148 = val_158[val_143];
            val_149 = val_158[val_143];
            val_150 = val_158[val_143];
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_138, g = val_148, b = val_149, a = val_150}, rhs:  new UnityEngine.Color() {r = val_160, g = val_118, b = val_145, a = val_119})) != false)
        {
                val_151 = val_141;
            if((val_73.Contains(item:  val_120 + (val_151 * val_92))) != true)
        {
                val_151 = val_141;
            val_73.Add(item:  val_120 + (val_151 * val_92));
        }
        
        }
        
        }
        
        label_160:
        if(val_73.Count > 0)
        {
            goto label_163;
        }
        
        val_141.SetPixels(colors:  val_158);
        label_125:
        val_141.Apply();
        mem[1152921525974866236] = 1;
        val_137 = ???;
        val_135 = ???;
        val_136 = ???;
        val_139 = ???;
        val_140 = ???;
        val_166 = ???;
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
        label_20:
        label_23:
        UnityEngine.Color val_99 = val_136.GetPixel(x:  val_137, y:  val_139);
        val_167 = val_99.r;
        val_135.color = new UnityEngine.Color() {r = val_167, g = val_99.g, b = val_99.b, a = val_99.a};
        val_168 = mem[val_166 + 184 + 48];
        val_168 = val_166 + 184 + 48;
        val_168.HandleSetColorClicked(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    private void 丟丙丐东丗丘丅世丒()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        var val_7;
        val_4 = this;
        if(this.saveFrame != 0)
        {
                val_4 = this.saveFrame;
            if(val_4.activeSelf == true)
        {
                return;
        }
        
        }
        
        val_5 = null;
        val_5 = null;
        if(SkinEditorController.丝丝丂不且丒丐丌上 != 4)
        {
                return;
        }
        
        val_4 = SkinEditorController.丄丞丁丈与业上丞丟;
        if(val_4 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        SkinEditorController.丄丞丁丈与业上丞丟.SetColorClickedUp();
    }
    private bool 丈丝丅丘丕万丝且丈(UnityEngine.Vector2 下业丕七东丌丝下且)
    {
        float val_14 = 768f;
        val_14 = (float)UnityEngine.Screen.height / val_14;
        float val_15 = (float)this.canvasTexture.width;
        float val_16 = (float)this.canvasTexture.height;
        float val_17 = (float)UnityEngine.Screen.width;
        val_15 = val_14 * val_15;
        val_16 = val_14 * val_16;
        val_17 = val_17 - val_15;
        float val_6 = val_16 + (float)UnityEngine.Screen.height;
        val_17 = val_17 * 0.5f;
        val_6 = val_6 * 0.5f;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_17, y:  val_6);
        float val_18 = (float)this.canvasTexture.width;
        float val_19 = (float)this.canvasTexture.height;
        float val_20 = (float)UnityEngine.Screen.width;
        val_18 = val_14 * val_18;
        val_19 = val_14 * val_19;
        val_20 = val_18 + val_20;
        float val_12 = (float)UnityEngine.Screen.height - val_19;
        val_20 = val_20 * 0.5f;
        val_12 = val_12 * 0.5f;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_20, y:  val_12);
        if(((下业丕七东丌丝下且.x > val_7.x) && (下业丕七东丌丝下且.x < 0)) && (下业丕七东丌丝下且.y < 0))
        {
                if(下业丕七东丌丝下且.y > val_13.y)
        {
                return false;
        }
        
        }
        
        return false;
    }
    private UnityEngine.Vector2 丛下丅丆且丞一丙丙(UnityEngine.Vector2 下业丕七东丌丝下且)
    {
        float val_13 = 768f;
        val_13 = (float)UnityEngine.Screen.height / val_13;
        float val_14 = (float)this.canvasTexture.width;
        float val_15 = (float)UnityEngine.Screen.width;
        val_14 = val_13 * val_14;
        val_15 = val_15 - val_14;
        float val_16 = (float)this.canvasTexture.width;
        val_15 = val_15 * (-0.5f);
        val_16 = val_13 * val_16;
        val_15 = 下业丕七东丌丝下且.x + val_15;
        val_15 = val_15 / val_16;
        val_15 = val_15 * (float)this.canvasTexture.isAnchoredHorizontally;
        float val_17 = (float)this.canvasTexture.height;
        float val_18 = (float)UnityEngine.Screen.height;
        val_17 = val_13 * val_17;
        val_18 = val_18 - val_17;
        float val_19 = (float)this.canvasTexture.height;
        val_18 = val_18 * (-0.5f);
        val_19 = val_13 * val_19;
        val_18 = 下业丕七东丌丝下且.y + val_18;
        val_18 = val_18 / val_19;
        val_18 = val_18 * (float)this.canvasTexture.canBeAnchored;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  (float)UnityEngine.Mathf.FloorToInt(f:  val_15), y:  (float)UnityEngine.Mathf.FloorToInt(f:  val_18));
        return new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
    }
    internal static UnityEngine.Texture2D 世丙三丌一三下丈丘(UnityEngine.Texture 业丌世丂三丙丅丗丘)
    {
        UnityEngine.Texture val_3 = 业丌世丂三丙丅丗丘;
        if((val_3 == null) || (null == null))
        {
                return (UnityEngine.Texture2D)EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_3 = 0);
        }
        
        return (UnityEngine.Texture2D)EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_3);
    }
    internal static UnityEngine.Texture2D 世丙三丌一三下丈丘(UnityEngine.Texture2D 业丌世丂三丙丅丗丘)
    {
        UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  业丌世丂三丙丅丗丘.width, height:  业丌世丂三丙丅丗丘.height, textureFormat:  4, mipChain:  false);
        UnityEngine.Color[] val_4 = 业丌世丂三丙丅丗丘.GetPixels();
        if(val_3 != null)
        {
                val_3.SetPixels(colors:  val_4);
            val_3.filterMode = 0;
        }
        else
        {
                val_3.SetPixels(colors:  val_4);
            0.filterMode = 0;
        }
        
        val_3.Apply();
        return val_3;
    }
    public void UpdateFonCanvas()
    {
        this.fonCanvas.width = this.canvasTexture.width;
        this.fonCanvas.height = this.canvasTexture.height;
        if(this.fonCanvas == null)
        {
            
        }
    
    }
    public EditorTextures()
    {
        this.专丁丙丛丐上上丆丞 = 0;
        mem[1152921525975969692] = 0;
        mem[1152921525975969700] = 0;
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  -1f, y:  -1f);
        this.东专且业下丟丛且丈 = val_1.x;
        mem[1152921525975969720] = val_1.y;
        this.arrHistory = new System.Collections.ArrayList();
    }

}
