using UnityEngine;
internal sealed class TestPreviewSkinController : MonoBehaviour
{
    // Fields
    public UIGrid grid;
    public UnityEngine.GameObject previewPrefab;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TestPreviewSkinController.丈丌丗丗上丕丘丁丐();
    }
    private void 丟丟丁不丙丅且七上()
    {
        var val_1;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        string val_37;
        var val_38;
        UnityEngine.Texture2D val_39;
        val_32 = 0;
        goto label_1;
        label_47:
        val_33 = null;
        val_33 = null;
        System.String[] val_2 = SkinsController.七丄丄丙丁丄丒丈不 + ((val_1) << 3);
        UnityEngine.Texture2D val_3 = SkinsController.TextureFromString(且专丒上丅丞丝丐丌:  (SkinsController.七丄丄丙丁丄丒丈不 + (val_1) << 3) + 32, 与丘东下丈东丛丂万:  64, 一丗世三专三万丞丞:  32);
        UnityEngine.Texture2D val_4 = new UnityEngine.Texture2D(width:  16, height:  32, textureFormat:  5, mipChain:  false);
        var val_32 = 0;
        do
        {
            var val_31 = 0;
            do
        {
            UnityEngine.Color val_5 = UnityEngine.Color.clear;
            val_4.SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            val_31 = val_31 + 1;
        }
        while(val_31 != 32);
        
            val_32 = val_32 + 1;
        }
        while(val_32 != 16);
        
        val_4.SetPixels(x:  4, y:  24, blockWidth:  8, blockHeight:  8, colors:  0.丕丆专丄丁一丄一丄(与万丆丛丒万丝丙丑:  val_3, 丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}));
        val_4.SetPixels(x:  4, y:  12, blockWidth:  8, blockHeight:  12, colors:  0.丕丆专丄丁一丄一丄(与万丆丛丒万丝丙丑:  val_3, 丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}));
        val_4.SetPixels(x:  0, y:  12, blockWidth:  4, blockHeight:  12, colors:  0.丕丆专丄丁一丄一丄(与万丆丛丒万丝丙丑:  val_3, 丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}));
        val_4.SetPixels(x:  12, y:  12, blockWidth:  4, blockHeight:  12, colors:  0.丕丆专丄丁一丄一丄(与万丆丛丒万丝丙丑:  val_3, 丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}));
        val_4.SetPixels(x:  4, y:  0, blockWidth:  4, blockHeight:  12, colors:  0.丕丆专丄丁一丄一丄(与万丆丛丒万丝丙丑:  val_3, 丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}));
        UnityEngine.Color[] val_11 = 0.丕丆专丄丁一丄一丄(与万丆丛丒万丝丙丑:  val_3, 丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        if(val_4 != null)
        {
                val_4.SetPixels(x:  8, y:  0, blockWidth:  4, blockHeight:  12, colors:  val_11);
            val_4.anisoLevel = 1;
            val_4.mipMapBias = -0.5f;
            val_4.Apply();
            val_4.filterMode = 0;
            val_34 = val_4;
        }
        else
        {
                val_4.SetPixels(x:  8, y:  0, blockWidth:  4, blockHeight:  12, colors:  val_11);
            0.anisoLevel = 1;
            0.mipMapBias = -0.5f;
            val_4.Apply();
            0.filterMode = 0;
            val_34 = 0;
        }
        
        val_4.Apply();
        UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.previewPrefab);
        val_12.transform.parent = this.grid.transform;
        var val_33 = val_1;
        val_33 = val_33 + (val_33 << 2);
        val_33 = val_33 << 5;
        val_12.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_12.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        SetTestSkinPreview val_17 = val_12.GetComponent<SetTestSkinPreview>();
        SetTestSkinPreview val_18 = val_12.GetComponent<SetTestSkinPreview>();
        val_18.nameLabel.text = ToString();
        SetTestSkinPreview val_20 = val_12.GetComponent<SetTestSkinPreview>();
        val_35 = null;
        val_35 = null;
        if((SkinsController.丑丝七丒丅丙东丞万.ContainsKey(key:  ToString())) == false)
        {
            goto label_36;
        }
        
        val_36 = null;
        val_36 = null;
        val_37 = SkinsController.丑丝七丒丅丙东丞万.Item[ToString()];
        if(val_20.keyLabel != null)
        {
            goto label_42;
        }
        
        goto label_41;
        label_36:
        val_37 = "";
        if(val_20.keyLabel != null)
        {
            goto label_42;
        }
        
        label_41:
        label_42:
        val_20.keyLabel.text = val_37;
        val_12.name = ToString();
        val_32 = val_1 + 1;
        label_1:
        val_38 = null;
        val_1 = val_32;
        val_38 = null;
        if(val_32 < SkinsController.七丄丄丙丁丄丒丈不.Length)
        {
            goto label_47;
        }
        
        string[] val_26 = new string[2];
        val_26[0] = "player3";
        val_26[1] = "player4";
        object val_34 = 1;
        do
        {
            UnityEngine.Object val_28 = UnityEngine.Resources.Load(path:  "MultSkins_6_3/10.6.0_Skin"("MultSkins_6_3/10.6.0_Skin") + val_34);
            if(val_28 != null)
        {
                val_28 = (null == null) ? (val_28) : 0;
        }
        else
        {
                val_39 = 0;
        }
        
            val_34 = val_34 + 1;
        }
        while(val_34 != 5);
        
        UnityEngine.Debug.Log(message:  "" + "\"" + SkinsController.StringFromTexture(三与丕丘丌丈一丆七:  val_39)(SkinsController.StringFromTexture(三与丕丘丌丈一丆七:  val_39)) + "\",\n");
    }
    private UnityEngine.Color[] 丕丆专丄丁一丄一丄(UnityEngine.Texture2D 与万丆丛丒万丝丙丑, UnityEngine.Rect 丝丆丏丕丕丕丗丛业)
    {
        float val_1 = 丝丆丏丕丕丕丗丛业.m_XMin.System.IConvertible.ToSingle(provider:  0);
        return (UnityEngine.Color[])与万丆丛丒万丝丙丑.GetPixels(x:  (int)val_1, y:  (int)val_1, blockWidth:  (int)val_1, blockHeight:  (int)val_1);
    }
    public TestPreviewSkinController()
    {
    
    }

}
