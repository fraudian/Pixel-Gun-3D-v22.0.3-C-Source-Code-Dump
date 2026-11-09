using UnityEngine;
public class ClanLogoOnFlag : MonoBehaviour
{
    // Fields
    public bool inRoom;
    public UnityEngine.GameObject flag;
    public UnityEngine.Renderer logo;
    private string 世丈丟丄丂万丆东丌;
    private UnityEngine.Texture2D 专丕丗丘丄三丏世丞;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        int val_29;
        string val_30;
        var val_31;
        int val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        object val_45;
        var val_46;
        var val_47;
        if(this.inRoom == false)
        {
            goto label_1;
        }
        
        val_29 = 1152921505107111936;
        val_30 = "-1";
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        val_32 = SiegeController.三三万丆下一丗万丛;
        if(val_32 == 0)
        {
                return;
        }
        
        val_33 = null;
        val_33 = null;
        if(SiegeController.三三万丆下一丗万丛.roomStatusGlobal == 6)
        {
            goto label_17;
        }
        
        val_34 = null;
        val_34 = null;
        if(SiegeController.三三万丆下一丗万丛.roomStatusGlobal == 5)
        {
            goto label_17;
        }
        
        val_35 = null;
        val_35 = null;
        if(SiegeController.三三万丆下一丗万丛.roomStatusGlobal != 7)
        {
            goto label_21;
        }
        
        label_17:
        val_32 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_36 = null;
        val_36 = null;
        if((val_32.ContainsKey(key:  GameConnect.丟不下业世与丈下三)) == false)
        {
            goto label_52;
        }
        
        val_37 = null;
        val_37 = null;
        val_32 = GameConnect.丟不下业世与丈下三;
        val_30 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_32];
        val_38 = 2;
        goto label_36;
        label_1:
        val_32 = 1152921505448005632;
        val_39 = null;
        val_39 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_40 = null;
        val_40 = null;
        this.不上与丑下丙丁丏丛(三与丕丘丌丈一丆七:  Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().世丐专丂世丄世丂丌());
        return;
        label_21:
        val_32 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_41 = null;
        val_41 = null;
        if((val_32.ContainsKey(key:  GameConnect.丁丝丕上下丗丕丞东)) != false)
        {
                val_42 = null;
            val_42 = null;
            val_32 = GameConnect.丁丝丕上下丗丕丞东;
            val_30 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_32];
        }
        
        label_52:
        val_38 = 1;
        label_36:
        if((System.String.op_Inequality(a:  val_30, b:  this.世丈丟丄丂万丆东丌)) == false)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  val_30, b:  "-1")) == false)
        {
            goto label_61;
        }
        
        val_43 = null;
        if(val_38 != 1)
        {
            goto label_65;
        }
        
        val_44 = null;
        val_45 = 1152921505066541440;
        goto label_68;
        label_61:
        this.flag.SetActive(value:  false);
        return;
        label_65:
        val_46 = null;
        val_45 = 1152921505066541448;
        label_68:
        val_47 = null;
        val_47 = null;
        val_29 = 与丂丏丛丞丞丒丟丄.下丒丗丘下且丕丟不;
        new UnityEngine.Texture2D() = new UnityEngine.Texture2D(width:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, height:  val_29, textureFormat:  5, mipChain:  false);
        bool val_28 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  System.Convert.FromBase64String(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_45]), markNonReadable:  true);
        new UnityEngine.Texture2D().filterMode = 0;
        this.不上与丑下丙丁丏丛(三与丕丘丌丈一丆七:  new UnityEngine.Texture2D());
        val_32 = this.flag;
        this.世丈丟丄丂万丆东丌 = val_30;
        val_32.SetActive(value:  true);
    }
    private void 不上与丑下丙丁丏丛(UnityEngine.Texture 三与丕丘丌丈一丆七)
    {
        this.logo.sharedMaterial.mainTexture = 三与丕丘丌丈一丆七;
    }
    public ClanLogoOnFlag()
    {
        this.世丈丟丄丂万丆东丌 = System.String.alignConst;
    }

}
