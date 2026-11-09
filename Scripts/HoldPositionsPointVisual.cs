using UnityEngine;
internal sealed class HoldPositionsPointVisual : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem GlowColumn;
    private UnityEngine.ParticleSystem InnerCircle;
    private UnityEngine.Material BlueGlowMaterial;
    private UnityEngine.Material RedGlowMaterial;
    private UnityEngine.Material WhiteGlowMaterial;
    private TextMeshBounds NameText;
    private UnityEngine.TextMesh NameTextOutline;
    private UnityEngine.GameObject RedCircle;
    private UnityEngine.GameObject BlueCircle;
    private UnityEngine.GameObject GrayCircle;
    private UnityEngine.GameObject RedBlueCircle;
    private UnityEngine.GameObject CircleObject;
    private UnityEngine.ParticleSystem redProgressBar;
    private UnityEngine.ParticleSystem blueProgressBar;
    private UnityEngine.GameObject[] distanceObjects;
    private UnityEngine.TextMesh distanceLabel;
    private UnityEngine.TextMesh conditionLabel;
    private string 业一丏下丄丏下丙丘;
    private string 丙世丌丌丌丝专世七;
    private string 丕丆东专东丒丆丟与;
    private string 上丆七丌世七专与丄;
    private string 丕丘丌一一万上七丂;
    private float 丂三丟丂丈丐丆丗丟;
    private const float 丄一丆与业丑丆丅丟 = 0.5;
    private const float 与丈业丛丝丒丙一丏 = 1;
    private HoldPositionsPointVisual.丗万下丞世三丙丝丝 世丈丆丐三丈丈世丑;
    private UnityEngine.Renderer 且一丈不上上丝专不;
    private float 东丝丆与丕七不一万;
    private UnityEngine.GameObject lockIcon;
    private string 下丛上丐丄丝丘丑丒;
    private bool 业一下上丂丛丂丅丆;
    private System.Collections.Generic.List<UnityEngine.Renderer> interRenderers;
    private System.Collections.Generic.List<TextMeshOutline> interOutlines;
    private System.Collections.Generic.List<UnityEngine.Material> 丁丟丘丏丗丐与上七;
    private bool 丏丙与丏丟丟一丗三;
    
    // Properties
    private bool 丏丙丘东丆东丑丟下 { get; }
    
    // Methods
    internal void 丅业上东丆丛世万丄(float 丙业与丙丗丝不丈东)
    {
        if(this.东丝丆与丕七不一万 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.东丝丆与丕七不一万 = 丙业与丙丗丝不丈东;
        this.GlowColumn.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Awake()
    {
        this.且一丈不上上丝专不 = this.GlowColumn.GetComponent<UnityEngine.Renderer>();
    }
    private bool 下丏丅下一丛丏丒丞()
    {
        丗万下丞世三丙丝丝 val_2 = this.世丈丆丐三丈丈世丑;
        val_2 = val_2 | 1;
        return (bool)(val_2 == 7) ? 1 : 0;
    }
    private void 丘业丂丙丄下丕丛下(HoldPositionsPointVisual.世丘丂丄丙与丒东东 丄专丟丁与东丕东业)
    {
        this.RedCircle.SetActive(value:  (丄专丟丁与东丕东业 == 1) ? 1 : 0);
        this.BlueCircle.SetActive(value:  (丄专丟丁与东丕东业 == 2) ? 1 : 0);
        this.GrayCircle.SetActive(value:  (丄专丟丁与东丕东业 == 0) ? 1 : 0);
        this.RedBlueCircle.SetActive(value:  (丄专丟丁与东丕东业 == 3) ? 1 : 0);
    }
    internal void 东与丂丏丐丞三丘丁(string 丙业与丙丗丝不丈东)
    {
        this.下丛上丐丄丝丘丑丒 = 丙业与丙丗丝不丈东;
    }
    private void 上不丕丌丄世丆丘丘(UnityEngine.ParticleSystem 丗丑下下上世丈丐丙, float 上丕丈丞丌丘丅不与)
    {
        float val_8 = 上丕丈丞丌丘丅不与;
        UnityEngine.ParticleSystem val_6 = this.blueProgressBar;
        val_6 = UnityEngine.Object.op_Equality(x:  丗丑下下上世丈丐丙, y:  val_6);
        this.blueProgressBar.gameObject.SetActive(value:  val_6);
        UnityEngine.ParticleSystem val_7 = this.redProgressBar;
        val_7 = UnityEngine.Object.op_Equality(x:  丗丑下下上世丈丐丙, y:  val_7);
        this.redProgressBar.gameObject.SetActive(value:  val_7);
        val_8 = 1f - val_8;
        CustomDataModule val_5 = 丗丑下下上世丈丐丙.customData;
    }
    internal void 丐专丒丁专丌丑丘丙(bool 丙东丏丕丞丁丈丈万, bool 专七世丕且丐丙丕东, bool 七丟丁下且不丟丌丏, bool 丒丌丘不世丁丑丟丂, bool 下且下丄专下丝丞丟, bool 丆丅丐三一不丕世三, float 丑丁丐一三东丟业丝, bool 上不世不七丒上不东 = False)
    {
        this.业一下上丂丛丂丅丆 = 丆丅丐三一不丕世三;
        this.上不丕丌丄世丆丘丘(丗丑下下上世丈丐丙:  (丒丌丘不世丁丑丟丂 != true) ? this.blueProgressBar : this.redProgressBar, 上丕丈丞丌丘丅不与:  丑丁丐一三东丟业丝);
        this.丘业丂丙丄下丕丛下(丄专丟丁与东丕东业:  (丆丅丐三一不丕世三 != true) ? 3 : ((丙东丏丕丞丁丈丈万 != true) ? ((丒丌丘不世丁丑丟丂 != true) ? (1 + 1) : 1) : 0));
    }
    internal void 下与三丅丂专丘业丗(bool 丒丄丂不丝丝丛丁东, bool 与丝丂丁丗丗丑丟专, bool 丙丟丘丌三丌丌世七, bool 丙丒世丂丝一丏不丆, bool 七世丕丅丛且上丛三, bool 丟下丑三丒与丘世东 = False)
    {
        var val_10;
        UnityEngine.Material val_15;
        if(丒丄丂不丝丝丛丁东 != false)
        {
                val_10 = 5;
        }
        else
        {
                if(与丝丂丁丗丗丑丟专 != false)
        {
                var val_2 = (丙丟丘丌三丌丌世七 != true) ? (3 + 1) : 3;
        }
        else
        {
                丗万下丞世三丙丝丝 val_6 = ((丙丒世丂丝一丏不丆 | (~七世丕丅丛且上丛三)) != true) ? ((丙丒世丂丝一丏不丆 != true) ? 0 : ((丟下丑三丒与丘世东 != true) ? 6 : (0 + 1))) : ((丟下丑三丒与丘世东 != true) ? 7 : 2);
        }
        
        }
        
        if(val_6 == this.世丈丆丐三丈丈世丑)
        {
                return;
        }
        
        this.世丈丆丐三丈丈世丑 = val_6;
        if(val_6 == 2)
        {
            goto label_5;
        }
        
        if(val_6 == 1)
        {
            goto label_6;
        }
        
        if(val_6 != 0)
        {
            goto label_7;
        }
        
        UnityEngine.Color val_7 = UnityEngine.Color.white;
        val_15 = this.WhiteGlowMaterial;
        goto label_9;
        label_5:
        UnityEngine.Color val_8 = UnityEngine.Color.blue;
        val_15 = this.BlueGlowMaterial;
        goto label_9;
        label_6:
        UnityEngine.Color val_9 = UnityEngine.Color.red;
        val_15 = this.RedGlowMaterial;
        label_9:
        this.丄丙且下丅丅丘丏丌(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a}, 丘上专不丂万业不一:  val_15);
        return;
        label_7:
        this.丂三丟丂丈丐丆丗丟 = 0f;
    }
    private void Update()
    {
        string val_28;
        var val_29;
        var val_30;
        if(this.世丈丆丐三丈丈世丑 > 7)
        {
            goto label_8;
        }
        
        var val_22 = 106043240 + (this.世丈丆丐三丈丈世丑) << 2;
        val_22 = val_22 + 106043240;
        goto (106043240 + (this.世丈丆丐三丈丈世丑) << 2 + 106043240);
        label_8:
        if(this.业一下上丂丛丂丅丆 != false)
        {
                val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丕丆东专东丒丆丟与);
            this.conditionLabel.text = val_28;
            this.丐东丛与与上丑丛不();
            this.下丗三世上丂世万丂();
        }
        
        val_29 = null;
        val_29 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
            goto label_21;
        }
        
        val_30 = null;
        val_30 = null;
        UnityEngine.Vector3 val_6 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.position;
        UnityEngine.Vector3 val_8 = this.transform.position;
        this.distanceLabel.text = (int)UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})((int)UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) + " m";
        int val_11 = UnityEngine.Screen.width;
        int val_12 = UnityEngine.Screen.height;
        var val_13 = (val_11 < 0) ? (val_11 + 1) : (val_11);
        val_13 = val_13 >> 1;
        var val_15 = ((val_12 < 0) ? (val_12 + 1) : (val_12)) >> 1;
        val_28 = this.NameText.transform;
        UnityEngine.Vector3 val_17 = val_28.position;
        UnityEngine.Vector3 val_18 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector2 val_19;
        val_18.x = val_18.x - 0f;
        val_18.y = val_18.y - 0f;
        val_19 = new UnityEngine.Vector2(x:  val_18.x, y:  val_18.y);
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.zero;
        float val_21 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        if(val_21 >= 0)
        {
            goto label_35;
        }
        
        val_21 = val_21 / 200f;
        if(val_21 >= 0)
        {
            goto label_37;
        }
        
        goto label_37;
        label_35:
        label_37:
        this.丘三一丆丝万世丈丐(丆丛丑世下一丐且丕:  1f);
        label_21:
        this.丅丆丐业一丈且丐丑();
    }
    private void 丅丆丐业一丈且丐丑()
    {
        string val_2 = (this.lockIcon.activeSelf != true) ? "" : this.下丛上丐丄丝丘丑丒;
        if(this.NameText != 0)
        {
                this.NameText.Text = val_2;
        }
        
        if(this.NameTextOutline == 0)
        {
                return;
        }
        
        this.NameTextOutline.text = val_2;
    }
    private void FixedUpdate()
    {
    
    }
    private void Start()
    {
        this.丁丟丘丏丗丐与上七 = new System.Collections.Generic.List<UnityEngine.Material>();
        List.Enumerator<T> val_2 = this.interRenderers.GetEnumerator();
        label_6:
        if(((-1059453368) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        UnityEngine.Material val_4 = val_3.material;
        val_3.sharedMaterial = val_4;
        this.丁丟丘丏丗丐与上七.Add(item:  val_4);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丘三一丆丝万世丈丐(float 丆丛丑世下一丐且丕)
    {
        var val_3;
        List.Enumerator<T> val_1 = this.丁丟丘丏丗丐与上七.GetEnumerator();
        label_7:
        if(((-1059292240) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        UnityEngine.Color val_5 = val_4.color;
        UnityEngine.Color val_6 = val_4.color;
        UnityEngine.Color val_7 = val_4.color;
        val_3 = 0;
        val_4.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.lockIcon.activeSelf != false)
        {
                UnityEngine.Color val_9 = this.NameText.Color;
            if(val_9.a > 0f)
        {
                丆丛丑世下一丐且丕 = 0f;
        }
        
        }
        
        UnityEngine.Color val_10 = this.NameText.OutlineColor;
        UnityEngine.Color val_11 = this.NameText.OutlineColor;
        UnityEngine.Color val_12 = this.NameText.OutlineColor;
        val_3 = 0;
        this.NameText.OutlineColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    public void SetCircleActive(bool 三丟东丕丄丄下下丑)
    {
        var val_6;
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑;
        this.CircleObject.SetActive(value:  三丟东丕丄丄下下丑);
        val_6 = 0;
        goto label_1;
        label_5:
        this.distanceObjects[0].SetActive(value:  三丟东丕丄丄下下丑);
        val_6 = 1;
        label_1:
        if(val_6 < this.distanceObjects.Length)
        {
            goto label_5;
        }
        
        this.distanceLabel.gameObject.SetActive(value:  三丟东丕丄丄下下丑);
        this.conditionLabel.gameObject.SetActive(value:  三丟东丕丄丄下下丑);
    }
    private void 丄丙且下丅丅丘丏丌(UnityEngine.Color 丑丞丈丗丄丙丟万丄, UnityEngine.Material 丘上专不丂万业不一)
    {
        this.且一丈不上上丝专不.material = 丘上专不丂万业不一;
        this.丄丙且下丅丅丘丏丌(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
    }
    public void SetLocked(bool 丐三丞七丝丅不万丛)
    {
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        丐三丞七丝丅不万丛 = 丐三丞七丝丅不万丛;
        this.lockIcon.SetActive(value:  丐三丞七丝丅不万丛);
        if(丐三丞七丝丅不万丛 == false)
        {
            goto label_1;
        }
        
        val_2 = 0f;
        val_3 = 0f;
        val_4 = 0f;
        val_5 = 0f;
        if(this.NameText != null)
        {
            goto label_4;
        }
        
        goto label_3;
        label_1:
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        val_2 = val_1.r;
        val_3 = val_1.g;
        val_4 = val_1.b;
        val_5 = val_1.a;
        if(this.NameText != null)
        {
            goto label_4;
        }
        
        label_3:
        label_4:
        this.NameText.Color = new UnityEngine.Color() {r = val_2, g = val_3, b = val_4, a = val_5};
        this.丅丆丐业一丈且丐丑();
    }
    private void 丄丙且下丅丅丘丏丌(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        var val_6;
        MainModule val_1 = this.InnerCircle.main;
        MinMaxGradient val_2 = val_1.m_ParticleSystem.startColor;
        UnityEngine.Color val_7 = val_6.targetColor;
        MinMaxGradient val_8 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = val_7.a});
    }
    private void 下丗三世上丂世万丂()
    {
        float val_11;
        UnityEngine.Material val_12;
        float val_13;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        UnityEngine.Material val_22;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        丗万下丞世三丙丝丝 val_11 = this.世丈丆丐三丈丈世丑;
        val_11 = val_1.a;
        val_11 = val_11 - 3;
        if(val_11 <= 4)
        {
                var val_12 = 106043272 + ((this.世丈丆丐三丈丈世丑 - 3)) << 2;
            val_12 = this.WhiteGlowMaterial;
            val_12 = val_12 + 106043272;
        }
        else
        {
                UnityEngine.Color val_4 = UnityEngine.Color.red;
            val_18 = val_4.r;
            val_19 = val_4.g;
            val_20 = val_4.b;
            val_21 = val_4.a;
            UnityEngine.Color val_5 = UnityEngine.Color.blue;
            val_12 = this.BlueGlowMaterial;
            val_13 = val_5.r;
            val_11 = val_5.a;
            val_22 = this.RedGlowMaterial;
            float val_7 = ((this.世丈丆丐三丈丈世丑 | 1) == 7) ? 0.5f : 1f;
            float val_8 = val_7 * 0.5f;
            if(this.丂三丟丂丈丐丆丗丟 > val_8)
        {
                val_20 = val_5.b;
            val_19 = val_5.g;
            val_18 = val_13;
            val_21 = val_11;
        }
        
            this.丄丙且下丅丅丘丏丌(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21});
            float val_13 = UnityEngine.Mathf.PingPong(t:  this.丂三丟丂丈丐丆丗丟, length:  val_8);
            val_13 = val_13 / val_7;
            this.且一丈不上上丝专不.material.Lerp(start:  mem[this.RedGlowMaterial], end:  val_12, t:  val_13);
        }
    
    }
    private void 丐东丛与与上丑丛不()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        丗万下丞世三丙丝丝 val_3 = this.世丈丆丐三丈丈世丑;
        val_1 = this.丂三丟丂丈丐丆丗丟 + val_1;
        val_3 = val_3 | 1;
        this.丂三丟丂丈丐丆丗丟 = val_1;
        if(val_1 <= ((val_3 == 7) ? 0.5f : 1f))
        {
                return;
        }
        
        this.丂三丟丂丈丐丆丗丟 = val_1;
    }
    public HoldPositionsPointVisual()
    {
        this.业一丏下丄丏下丙丘 = "Key_11664";
        this.丙世丌丌丌丝专世七 = "Key_11665";
        this.丕丆东专东丒丆丟与 = "Key_11666";
        this.上丆七丌世七专与丄 = "Key_11667";
        this.丕丘丌一一万上七丂 = "Key_11668";
        this.下丛上丐丄丝丘丑丒 = "";
    }

}
