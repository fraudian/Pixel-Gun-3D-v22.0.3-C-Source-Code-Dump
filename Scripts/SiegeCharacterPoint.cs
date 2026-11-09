using UnityEngine;
public class SiegeCharacterPoint : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject placeholder;
    public UnityEngine.GameObject label;
    public TextMeshBounds nickname;
    public TextMeshBounds clanname;
    public UnityEngine.MeshRenderer clanIcon;
    public UnityEngine.GameObject loadingInObject;
    public string pixelBookID;
    public UnityEngine.Vector3 headPoint;
    private 与丅丕丈丘东丝世丟 专丞上七七且丝七丗;
    internal NetworkStartTable table;
    public UnityEngine.GameObject chooseIndication;
    
    // Methods
    public void FillFromPlayerSettings(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_31;
        int val_76;
        System.Byte[] val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_82;
        string val_83;
        TextMeshBounds val_84;
        var val_85;
        var val_86;
        string val_87;
        var val_88;
        var val_89;
        string val_90;
        var val_91;
        var val_92;
        string val_93;
        var val_94;
        var val_95;
        UnityEngine.Texture2D val_96;
        var val_97;
        var val_99;
        string val_100;
        var val_101;
        string val_102;
        UnityEngine.Texture2D val_103;
        var val_104;
        string val_105;
        var val_106;
        var val_107;
        string val_108;
        string val_109;
        var val_110;
        var val_111;
        string val_112;
        var val_113;
        var val_114;
        var val_115;
        string val_116;
        var val_117;
        var val_118;
        val_77 = this;
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_78 = null;
            val_78 = null;
            val_76 = SiegeController.三三万丆下一丗万丛;
            if(val_76 == 0)
        {
                return;
        }
        
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_79 = null;
            val_79 = null;
            val_76 = DungeonsController.丄丘七三上丕世丞业;
            if(val_76 == 0)
        {
                return;
        }
        
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return;
        }
        
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_80 = null;
            val_80 = null;
            丆丙丆且下丐丗丁一 val_8 = SiegeController.三三万丆下一丗万丛.GetCharacterForConnectingPlayer(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        }
        else
        {
                val_82 = null;
            val_82 = null;
        }
        
        val_76 = DungeonsController.丄丘七三上丕世丞业.GetCharacterForConnectingPlayer(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        if(val_76 != null)
        {
                val_9.世丟丈丏丕万丝丆万.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_13 = this.transform.position;
            val_9.世丟丈丏丕万丝丆万.transform.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            UnityEngine.Quaternion val_16 = this.transform.rotation;
            val_9.世丟丈丏丕万丝丆万.transform.rotation = new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w};
            UnityEngine.Vector3 val_19 = this.transform.lossyScale;
            val_9.世丟丈丏丕万丝丆万.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            UnityEngine.Vector3 val_21 = val_9.世丟丈丏丕万丝丆万.丁丝一下丁不七丗一().position;
            this.headPoint = val_21;
            mem[1152921539774743172] = val_21.y;
            mem[1152921539774743176] = val_21.z;
        }
        
        this.placeholder.SetActive(value:  false);
        this.label.SetActive(value:  true);
        val_83 = 专丞上七七且丝七丗.丁下不丛下且丌专丈();
        if(val_83.Length >= 11)
        {
                val_83 = 专丞上七七且丝七丗.丁下不丛下且丌专丈().Substring(startIndex:  0, length:  10)(专丞上七七且丝七丗.丁下不丛下且丌专丈().Substring(startIndex:  0, length:  10)) + "...";
        }
        
        val_84 = this.nickname;
        val_84.Text = val_83;
        this.loadingInObject.SetActive(value:  true);
        if(this.专丞上七七且丝七丗 == 专丞上七七且丝七丗)
        {
                return;
        }
        
        this.专丞上七七且丝七丗 = 专丞上七七且丝七丗;
        val_85 = null;
        val_85 = null;
        val_84 = GameConnect.与丘三丈丆丁三丆丐;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_84)) == false)
        {
            goto label_61;
        }
        
        val_86 = null;
        val_86 = null;
        val_84 = GameConnect.与丘三丈丆丁三丆丐;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[val_84] != null) && (null != null))
        {
                val_87 = 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_87)) == false)
        {
            goto label_68;
        }
        
        label_61:
        this.clanname.gameObject.SetActive(value:  false);
        if(专丞上七七且丝七丗 != null)
        {
            goto label_198;
        }
        
        label_199:
        label_198:
        val_88 = null;
        val_88 = null;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丛一丅丅丘丁丝世丒)) == false)
        {
            goto label_75;
        }
        
        val_89 = null;
        val_89 = null;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丛一丅丅丘丁丝世丒] != null) && (null != null))
        {
                val_90 = 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_90)) == false)
        {
            goto label_82;
        }
        
        label_75:
        val_76.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  "Weapon1", 世世丛与丒丗丏东下:  "Weapon1");
        if(专丞上七七且丝七丗 != null)
        {
            goto label_160;
        }
        
        label_161:
        label_160:
        val_91 = null;
        val_91 = null;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丗丅丙丕丛丁丂丄万)) == false)
        {
            goto label_88;
        }
        
        val_92 = null;
        val_92 = null;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗丅丙丕丛丁丂丄万] != null) && (null != null))
        {
                val_93 = 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_93)) == false)
        {
            goto label_95;
        }
        
        label_88:
        val_94 = null;
        val_77 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆();
        val_94 = null;
        if((val_77.ContainsKey(key:  GameConnect.丟丛丅丟世下丗丈专)) == false)
        {
            goto label_100;
        }
        
        val_95 = null;
        val_95 = null;
        val_77 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丛丅丟世下丗丈专];
        UnityEngine.Texture2D val_48 = null;
        val_96 = val_48;
        val_48 = new UnityEngine.Texture2D(width:  64, height:  32, textureFormat:  4, mipChain:  false);
        bool val_49 = UnityEngine.ImageConversion.LoadImage(tex:  val_48, data:  val_77, markNonReadable:  true);
        val_48.filterMode = 0;
        if(val_76 != null)
        {
            goto label_179;
        }
        
        goto label_107;
        label_100:
        val_97 = null;
        val_97 = null;
        goto label_110;
        label_68:
        val_99 = null;
        val_99 = null;
        val_100 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丘三丈丆丁三丆丐];
        if((val_100 != null) && (null != null))
        {
                val_100 = 0;
        }
        
        this.clanname.gameObject.SetActive(value:  true);
        this.clanname.Text = val_100;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丕与丌丂万一三丘丂)) == false)
        {
            goto label_122;
        }
        
        val_101 = null;
        val_101 = null;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丕与丌丂万一三丘丂] != null) && (null != null))
        {
                val_102 = 0;
        }
        
        val_103 = 0;
        if((System.String.IsNullOrEmpty(value:  val_102)) == true)
        {
            goto label_141;
        }
        
        val_104 = null;
        val_104 = null;
        val_105 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丕与丌丂万一三丘丂];
        if((val_105 != null) && (null != null))
        {
                val_105 = 0;
        }
        
        val_106 = null;
        val_106 = null;
        val_103 = new UnityEngine.Texture2D();
        val_103 = new UnityEngine.Texture2D(width:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, height:  与丂丏丛丞丞丒丟丄.丕专世一专丆丞丆丗, textureFormat:  4, mipChain:  false);
        bool val_62 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  System.Convert.FromBase64String(s:  val_105), markNonReadable:  true);
        new UnityEngine.Texture2D().filterMode = 0;
        goto label_141;
        label_82:
        val_107 = null;
        val_107 = null;
        val_108 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丛一丅丅丘丁丝世丒];
        if((val_108 != null) && (null != null))
        {
                val_108 = 0;
        }
        
        val_109 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丑丞业丝世丝丑且丒];
        if((val_109 != null) && (null != null))
        {
                val_109 = 0;
        }
        
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.下东丝丈丕丌万三七)) == false)
        {
            goto label_154;
        }
        
        val_110 = null;
        val_110 = null;
        object val_70 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.下东丝丈丕丌万三七];
        if(val_76 != null)
        {
            goto label_181;
        }
        
        label_182:
        label_181:
        val_76.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  val_108, 世世丛与丒丗丏东下:  val_109, 专丙丐世与丐下不丑:  21884928);
        if(专丞上七七且丝七丗 != null)
        {
            goto label_160;
        }
        
        goto label_161;
        label_95:
        val_111 = null;
        val_111 = null;
        val_112 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗丅丙丕丛丁丂丄万];
        if((val_112 != null) && (null != null))
        {
                val_112 = 0;
        }
        
        val_113 = null;
        val_113 = null;
        val_77 = SkinsController.丞丄业丟丁上丐丑专;
        val_114 = null;
        if((val_77.Contains(item:  val_112)) == false)
        {
            goto label_171;
        }
        
        val_115 = null;
        val_77 = SkinsController.与业七丙三三万丕上;
        val_116 = val_112;
        val_117 = public UnityEngine.Texture2D System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>::get_Item(System.String key);
        goto label_175;
        label_171:
        val_118 = null;
        label_110:
        val_116 = "0";
        val_117 = public UnityEngine.Texture2D System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>::get_Item(System.String key);
        label_175:
        val_96 = SkinsController.与业七丙三三万丕上.Item[val_116];
        if(val_76 != null)
        {
            goto label_179;
        }
        
        label_107:
        label_179:
        val_76.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  val_96);
        val_31 = 0;
        val_76.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        return;
        label_154:
        if(val_76 != null)
        {
            goto label_181;
        }
        
        goto label_182;
        label_122:
        val_103 = 0;
        label_141:
        4194311.material.mainTexture = val_103;
        if(专丞上七七且丝七丗 != null)
        {
            goto label_198;
        }
        
        goto label_199;
    }
    internal void 上东与丛丞下丈专丈(NetworkStartTable 不且上一上丐三万丛)
    {
        string val_19;
        this.table = 不且上一上丐三万丛;
        if(不且上一上丐三万丛.丘业丟丆丑丑丅丌上 != null)
        {
                不且上一上丐三万丛.丘业丟丆丑丑丅丌上.世丟丈丏丕万丝丆万.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_4 = this.transform.position;
            不且上一上丐三万丛.丘业丟丆丑丑丅丌上.世丟丈丏丕万丝丆万.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_7 = this.transform.rotation;
            不且上一上丐三万丛.丘业丟丆丑丑丅丌上.世丟丈丏丕万丝丆万.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
            UnityEngine.Vector3 val_10 = this.transform.lossyScale;
            不且上一上丐三万丛.丘业丟丆丑丑丅丌上.世丟丈丏丕万丝丆万.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.pixelBookID = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
            UnityEngine.Vector3 val_12 = 不且上一上丐三万丛.丘业丟丆丑丑丅丌上.世丟丈丏丕万丝丆万.丁丝一下丁不七丗一().position;
            this.headPoint = val_12;
            mem[1152921539775293444] = val_12.y;
            mem[1152921539775293448] = val_12.z;
        }
        
        this.loadingInObject.SetActive(value:  false);
        this.placeholder.SetActive(value:  false);
        this.label.SetActive(value:  true);
        val_19 = 不且上一上丐三万丛.丂丈丐不丏万三七丐;
        if(val_19.Length >= 11)
        {
                val_19 = 不且上一上丐三万丛.丂丈丐不丏万三七丐.Substring(startIndex:  0, length:  10)(不且上一上丐三万丛.丂丈丐不丏万三七丐.Substring(startIndex:  0, length:  10)) + "...";
        }
        
        this.nickname.Text = val_19;
        bool val_16 = System.String.IsNullOrEmpty(value:  不且上一上丐三万丛.丄下丝业七丅与且丐);
        UnityEngine.GameObject val_17 = this.clanname.gameObject;
        if(val_17 == null)
        {
            goto label_28;
        }
        
        if(val_16 == false)
        {
            goto label_29;
        }
        
        label_30:
        val_17.SetActive(value:  false);
        return;
        label_28:
        if(val_16 == true)
        {
            goto label_30;
        }
        
        label_29:
        val_17.SetActive(value:  true);
        this.clanname.Text = 不且上一上丐三万丛.丐丆丒丅且丏世一与;
        this.clanIcon.material.mainTexture = 不且上一上丐三万丛.丏丅业丞丁丌丈与丆;
    }
    private void 丙一世丞丏丌丑丟丘(CharacterInterfaceV2 世丟丈丏丕万丝丆万, string 丌丝下丄业一丄不三, string 世世丛与丒丗丏东下, int 专丙丐世与丐下不丑)
    {
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丌丝下丄业一丄不三 = 丌丝下丄业一丄不三)) != false)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  世世丛与丒丗丏东下)) != false)
        {
                var val_6 = ((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丌丝下丄业一丄不三)) == 0) ? 1 : 0;
            val_6 = val_6 | (WeaponManager.丞上一丘丆三下丐丑().Contains(item:  丌丝下丄业一丄不三));
        }
        
        }
        
        世丟丈丏丕万丝丆万.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  (val_6 != true) ? 世世丛与丒丗丏东下 : (丌丝下丄业一丄不三));
        世丟丈丏丕万丝丆万.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  专丙丐世与丐下不丑));
    }
    public void SetEmpty()
    {
        this.placeholder.SetActive(value:  true);
        this.label.SetActive(value:  false);
        this.loadingInObject.SetActive(value:  false);
        this.七三万丅丒丒丂下七();
        this.专丞上七七且丝七丗 = 0;
        this.table = 0;
    }
    private void 七三万丅丒丒丂下七()
    {
        与丅丕丈丘东丝世丟 val_6;
        var val_7;
        var val_8;
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        val_6 = this;
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_7 = null;
            val_7 = null;
            val_8 = null;
            val_9 = SiegeController.三三万丆下一丗万丛;
        }
        else
        {
                val_10 = null;
            val_10 = null;
            val_8 = null;
            val_9 = DungeonsController.丄丘七三上丕世丞业;
        }
        
        if(val_9 == 0)
        {
                return;
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_15;
        }
        
        val_11 = null;
        val_11 = null;
        val_6 = this.专丞上七七且丝七丗;
        if((SiegeController.三三万丆下一丗万丛.GetCharacterForConnectingPlayerNotCreate(专丞上七七且丝七丗:  val_6)) == null)
        {
                return;
        }
        
        label_25:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_4.世丟丈丏丕万丝丆万, 丏业丟一东丂东丘丛:  false);
        return;
        label_15:
        val_12 = null;
        val_12 = null;
        val_6 = this.专丞上七七且丝七丗;
        if((DungeonsController.丄丘七三上丕世丞业.GetCharacterForConnectingPlayerNotCreate(专丞上七七且丝七丗:  val_6)) != null)
        {
            goto label_25;
        }
    
    }
    public SiegeCharacterPoint()
    {
        this.pixelBookID = System.String.alignConst;
    }

}
