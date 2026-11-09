using UnityEngine;
public class TeamDuelPlayerInfo : MonoBehaviour
{
    // Fields
    public UnityEngine.MeshRenderer playerMdl;
    public UILabel nickname;
    public UILabel rating;
    public UISprite lvlSprite;
    public UnityEngine.Material playerMaterial;
    public UnityEngine.GameObject betObject;
    public UnityEngine.GameObject infoObject;
    public UnityEngine.GameObject searchObject;
    public UnityEngine.GameObject loadingInObject;
    public UnityEngine.Transform emojiPoint;
    internal NetworkStartTable owner;
    private 与丅丕丈丘东丝世丟 专丞上七七且丝七丗;
    
    // Methods
    private void Start()
    {
        UnityEngine.Material val_2 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Unlit/Texture"));
        this.playerMaterial = val_2;
        this.playerMdl.sharedMaterial = val_2;
    }
    private void Update()
    {
        var val_4;
        bool val_5;
        var val_6;
        if(this.lvlSprite == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(GameController.onlineMode.丗三不丞丈业丑丘万 != false)
        {
                val_5 = 0;
        }
        else
        {
                val_6 = null;
            val_6 = null;
            val_5 = BalanceController.丄专丕世与世丙丏丛;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lvlSprite.gameObject, 丏业丟一东丂东丘丛:  (val_5 == true) ? 1 : 0);
    }
    public void FillFromPlayerSettings(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        UnityEngine.GameObject val_31;
        InGameConnection val_32;
        var val_33;
        var val_34;
        string val_35;
        var val_36;
        var val_37;
        UnityEngine.Texture2D val_38;
        var val_39;
        UnityEngine.Material val_40;
        var val_41;
        string val_42;
        var val_43;
        var val_44;
        var val_45;
        string val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        val_31 = this;
        this.owner = 0;
        this.nickname.text = 专丞上七七且丝七丗.丁下不丛下且丌专丈();
        this.lvlSprite.spriteName = "Rank_1";
        this.infoObject.SetActive(value:  true);
        if(this.searchObject != 0)
        {
                this.searchObject.SetActive(value:  false);
        }
        
        val_32 = this.playerMdl.gameObject;
        val_32.SetActive(value:  true);
        if(this.专丞上七七且丝七丗 == 专丞上七七且丝七丗)
        {
            goto label_78;
        }
        
        this.专丞上七七且丝七丗 = 专丞上七七且丝七丗;
        val_33 = null;
        val_33 = null;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丗丅丙丕丛丁丂丄万)) == false)
        {
            goto label_16;
        }
        
        val_34 = null;
        val_34 = null;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗丅丙丕丛丁丂丄万] != null) && (null != null))
        {
                val_35 = 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_35)) == false)
        {
            goto label_23;
        }
        
        label_16:
        val_36 = null;
        val_36 = null;
        if((专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丟丛丅丟世下丗丈专)) == false)
        {
            goto label_28;
        }
        
        val_37 = null;
        val_37 = null;
        UnityEngine.Texture2D val_14 = null;
        val_38 = val_14;
        val_14 = new UnityEngine.Texture2D(width:  64, height:  32, textureFormat:  4, mipChain:  false);
        bool val_15 = UnityEngine.ImageConversion.LoadImage(tex:  val_14, data:  专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丛丅丟世下丗丈专], markNonReadable:  true);
        val_14.filterMode = 0;
        goto label_34;
        label_28:
        val_39 = null;
        val_39 = null;
        val_40 = this.playerMaterial;
        val_38 = SkinsController.与业七丙三三万丕上.Item["0"];
        if(val_40 != null)
        {
            goto label_57;
        }
        
        goto label_39;
        label_23:
        val_41 = null;
        val_41 = null;
        val_42 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗丅丙丕丛丁丂丄万];
        if((val_42 != null) && (null != null))
        {
                val_42 = 0;
        }
        
        val_43 = null;
        val_43 = null;
        val_44 = null;
        if((SkinsController.丞丄业丟丁上丐丑专.Contains(item:  val_42)) != false)
        {
                val_45 = null;
            val_46 = val_42;
            val_47 = public UnityEngine.Texture2D System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>::get_Item(System.String key);
        }
        else
        {
                val_48 = null;
            val_46 = "0";
            val_47 = public UnityEngine.Texture2D System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>::get_Item(System.String key);
        }
        
        val_38 = SkinsController.与业七丙三三万丕上.Item[val_46];
        label_34:
        val_40 = this.playerMaterial;
        if(val_40 != null)
        {
            goto label_57;
        }
        
        label_39:
        label_57:
        val_40.mainTexture = val_38;
        this.rating.gameObject.SetActive(value:  false);
        val_49 = null;
        val_49 = null;
        val_32 = GameController.丆丘丂丈世丏丟丑丏;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == false)
        {
            goto label_68;
        }
        
        val_50 = null;
        val_32 = 专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆();
        val_50 = null;
        if((val_32.ContainsKey(key:  GameConnect.丞丝丕丁丌丁丞丐世)) == false)
        {
            goto label_68;
        }
        
        this.rating.gameObject.SetActive(value:  true);
        val_51 = null;
        val_51 = null;
        val_32 = System.Convert.ToInt32(value:  专丞上七七且丝七丗.丑丗三丛丛丆丟丌丆().Item[GameConnect.丞丝丕丁丌丁丞丐世]).ToString();
        this.rating.text = val_32;
        goto label_78;
        label_68:
        this.rating.gameObject.SetActive(value:  false);
        label_78:
        if(this.loadingInObject == 0)
        {
                return;
        }
        
        val_31 = this.loadingInObject;
        val_31.SetActive(value:  true);
    }
    internal void 与万不丄丄东丁与业(NetworkStartTable 不且上一上丐三万丛)
    {
        UnityEngine.GameObject val_11;
        var val_12;
        UnityEngine.Texture val_13;
        val_11 = this;
        this.owner = 不且上一上丐三万丛;
        this.专丞上七七且丝七丗 = 0;
        this.nickname.text = 不且上一上丐三万丛.丂丈丐不丏万三七丐;
        val_12 = null;
        val_12 = null;
        this.rating.gameObject.SetActive(value:  (GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == true) ? 1 : 0);
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
        {
                this.rating.text = 不且上一上丐三万丛.丞丗丘丒一丘且万丛().ToString();
        }
        
        this.lvlSprite.spriteName = "Rank_" + 不且上一上丐三万丛.下东且丐丆丅丁世丟.ToString();
        this.infoObject.SetActive(value:  true);
        if(this.searchObject != 0)
        {
                this.searchObject.SetActive(value:  false);
        }
        
        this.playerMdl.gameObject.SetActive(value:  true);
        if(不且上一上丐三万丛.万丛丏万丟丕丒丛与 == 0)
        {
            goto label_21;
        }
        
        val_13 = 不且上一上丐三万丛.万丛丏万丟丕丒丛与;
        if(this.playerMaterial != null)
        {
            goto label_24;
        }
        
        goto label_23;
        label_21:
        val_13 = 不且上一上丐三万丛.丌丏丞丆丗与东丗业;
        if(this.playerMaterial != null)
        {
            goto label_24;
        }
        
        label_23:
        label_24:
        this.playerMaterial.mainTexture = val_13;
        if(this.loadingInObject == 0)
        {
                return;
        }
        
        val_11 = this.loadingInObject;
        val_11.SetActive(value:  false);
    }
    public void Clear()
    {
        this.owner = 0;
        this.专丞上七七且丝七丗 = 0;
        this.nickname.text = "Empty";
        this.rating.text = "";
        this.infoObject.SetActive(value:  false);
        if(this.searchObject != 0)
        {
                this.searchObject.SetActive(value:  true);
        }
        
        this.playerMdl.gameObject.SetActive(value:  false);
        if(this.loadingInObject == 0)
        {
                return;
        }
        
        this.loadingInObject.SetActive(value:  false);
    }
    public TeamDuelPlayerInfo()
    {
    
    }

}
