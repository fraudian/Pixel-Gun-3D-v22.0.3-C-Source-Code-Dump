using UnityEngine;
internal sealed class MapHint : HintPopup
{
    // Fields
    public UITextureMasked mapPreviewTexture;
    public UILabel NameMapLabel;
    public UILabel DescriptionMapLabel;
    public UILabel LevelRequiredLabel;
    
    // Methods
    private void Awake()
    {
        if(this.mapPreviewTexture == 0)
        {
                return;
        }
        
        this = this.mapPreviewTexture;
        this.mapPreviewTexture.isOfferTexture = false;
    }
    internal void 丂丄业东丛不七世世(SceneInfo 东下丌丝且七丛丘丒)
    {
        var val_3;
        var val_4;
        System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世> val_6;
        val_3 = static_value_081DACA8;
        val_3 = static_value_081DACA8;
        val_4 = null;
        val_4 = null;
        val_6 = MapHint.<>c.<>9__5_0;
        if(val_6 == null)
        {
                System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世>(object:  MapHint.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.七丕丟丏三丈一丄世 MapHint.<>c::丞丒丁三万且且丏专(MapPreviewController 丒丒丄丁且丄丆丂丌));
            MapHint.<>c.<>9__5_0 = val_6;
        }
        
        this.丂丄业东丛不七世世(东下丌丝且七丛丘丒:  东下丌丝且七丛丘丒, 业丞丟万不丄丂丘丑:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<Rilisoft.七丕丟丏三丈一丄世, MapPreviewController>(丞下万上三丘上与专:  static_value_081DACA8 + 184 + 16 + 48 + 136, 丏丅丁丛一业丈专专:  val_1));
    }
    internal void 丂丄业东丛不七世世(SceneInfo 东下丌丝且七丛丘丒, Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑)
    {
        int val_7;
        string val_8;
        var val_20;
        string val_21;
        var val_22;
        var val_23;
        int val_24;
        var val_25;
        var val_26;
        val_20 = static_value_081DACA8;
        val_20 = static_value_081DACA8;
        UnityEngine.Texture val_2 = static_value_081DACA8 + 184 + 16.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  东下丌丝且七丛丘丒.丙且上丒不下丑下丞());
        val_21 = 东下丌丝且七丛丘丒.七丛一丛专七丈丅专();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.NameMapLabel, 丕丗丘丑丛与丑业丒:  val_21);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.DescriptionMapLabel, 丕丗丘丑丛与丑业丒:  东下丌丝且七丛丘丒.丝丌七上丘丑且丞与());
        if(业丞丟万不丄丂丘丑 == 17)
        {
            goto label_10;
        }
        
        if(业丞丟万不丄丂丘丑 != 22)
        {
            goto label_11;
        }
        
        val_21 = 1152921505059028992;
        val_22 = null;
        val_22 = null;
        if((DungeonWindowUI.dungeonsInfo.ContainsKey(key:  东下丌丝且七丛丘丒.indexMap)) == false)
        {
            goto label_39;
        }
        
        val_23 = null;
        val_23 = null;
        万丗且专万丟丌丂丐 val_6 = DungeonWindowUI.dungeonsInfo.Item[东下丌丝且七丛丘丒 + 56];
        val_24 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  22, 专万丟三世业丙丈且:  东下丌丝且七丛丘丒 + 56.ToString(), 丁丏丗且上丗下与下:  false));
        if(val_24 == 2147483647)
        {
                val_24 = 丐丄丞世丂丄丛不一.东丁七丝丝东万丐下(丈丘丝一丗下丈丐不:  val_7);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.DescriptionMapLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_8));
        goto label_39;
        label_10:
        val_25 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        int val_15 = val_25.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  17);
        goto label_29;
        label_11:
        val_26 = null;
        val_26 = null;
        val_25 = SceneInfoController.丄丘七三上丕世丞业;
        label_29:
        val_24 = val_25.丝上专丂且东丏丄丌(丂丛丑东不丅丈一东:  业丞丟万不丄丂丘丑, 东下丌丝且七丛丘丒:  东下丌丝且七丛丘丒, 丁丏丗且上丗下与下:  false);
        label_39:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.LevelRequiredLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  val_24));
    }
    internal void 丂丄业东丛不七世世(PGCompany.GameModeHub.万业世丙丗丌与不丆 丞丁丑丏丄丏七丂不)
    {
        null = null;
        SceneInfo val_1 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  丞丁丑丏丄丏七丂不.丐丒且丝丛丁丕丟丅);
        if(val_1 == 0)
        {
                return;
        }
        
        this.丂丄业东丛不七世世(东下丌丝且七丛丘丒:  val_1, 业丞丟万不丄丂丘丑:  丞丁丑丏丄丏七丂不.一丗丟丛丈专丙三丌);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
    }
    public MapHint()
    {
    
    }

}
