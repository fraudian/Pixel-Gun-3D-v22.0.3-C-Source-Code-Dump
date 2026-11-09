using UnityEngine;
public class MapPreviewGUI : PGBehaviour
{
    // Fields
    internal SquadController.丛且丏丑丕丘丒丞且 上丂东丗丝丈业万丅;
    public UITexture mapTexture;
    public UILabel mapName;
    public UnityEngine.GameObject team;
    public UnityEngine.GameObject[] mapSizeSprites;
    public UISprite popularitySprite;
    public UnityEngine.GameObject bottomPanel;
    public UnityEngine.GameObject easyDifficulty;
    public UnityEngine.GameObject mediumDifficulty;
    public UnityEngine.GameObject hardDifficulty;
    public UnityEngine.GameObject tipPoint;
    public int myIndex;
    private int _ratingVal;
    
    // Properties
    private int 丂业丌业丂万三丛丄 { get; set; }
    
    // Methods
    private int 丏三世七东丒万丕丅()
    {
        return (int)this._ratingVal;
    }
    private void 一七与丁丏丄不世丄(int 丙业与丙丗丝不丈东)
    {
        this._ratingVal = 丙业与丙丗丝不丈东;
        UnityEngine.GameObject val_1 = this.popularitySprite.gameObject;
        if((丙业与丙丗丝不丈东 & 2147483648) == 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
            this.popularitySprite.spriteName = System.String.Format(format:  "Nb_Players_{0}", arg0:  this._ratingVal);
            return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  false);
    }
    public void OnClick()
    {
        null = null;
        SquadController.丄丘七三上丕世丞业.万专丂东与万丈与丘(丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且() {丏丈丗世丙万丆丐丅 = this.上丂东丗丝丈业万丅, 丐且丘丑与万丞丑丅 = this.上丂东丗丝丈业万丅, 与丝丒万且丘丂丟三 = ???});
        丗三丁丑丞丝东丛且(丞丁丑丏丄丏七丂不:  this);
    }
    public void UpdatePopularity()
    {
        if(this.丅与丌专丟一丝业三().activeInHierarchy == false)
        {
                return;
        }
        
        this.丒丏下丏丒不业丒东();
    }
    public void UpdateMapSize()
    {
        var val_7;
        var val_8;
        if(this.上丂东丗丝丈业万丅 != 0)
        {
                var val_4 = ((mem[this.上丂东丗丝丈业万丅 + 152]) == 0) ? 0 : (((mem[this.上丂东丗丝丈业万丅 + 152]) != 1) ? (1 + 1) : 1);
        }
        else
        {
                val_7 = 0;
        }
        
        val_8 = 0;
        goto label_6;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mapSizeSprites[0], 丏业丟一东丂东丘丛:  (UnityEngine.Object.op_Inequality(x:  this.上丂东丗丝丈业万丅, y:  0)) & ((val_7 == val_8) ? 1 : 0));
        val_8 = 1;
        label_6:
        if(val_8 < this.mapSizeSprites.Length)
        {
            goto label_12;
        }
    
    }
    private void 丒丏下丏丒不业丒东()
    {
        var val_21;
        System.Func<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>> val_23;
        var val_24;
        Rilisoft.七丕丟丏三丈一丄世 val_25;
        var val_26;
        var val_27;
        string val_28;
        var val_29;
        if(this.上丂东丗丝丈业万丅 == 0)
        {
            goto label_32;
        }
        
        val_21 = null;
        val_21 = null;
        val_23 = MapPreviewGUI.<>c.<>9__19_0;
        if(val_23 == null)
        {
                System.Func<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>> val_2 = null;
            val_23 = val_2;
            val_2 = new System.Func<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>>(object:  MapPreviewGUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世> MapPreviewGUI.<>c::与三丒丐专丈丐丝业());
            MapPreviewGUI.<>c.<>9__19_0 = val_23;
        }
        
        Rilisoft.七丞丞丅东丞专丙丝<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>> val_3 = new Rilisoft.七丞丞丅东丞专丙丝<System.Collections.Generic.HashSet<Rilisoft.七丕丟丏三丈一丄世>>(丙丂丌且丌世丒丐三:  val_2);
        val_24 = null;
        val_24 = null;
        val_25 = SquadController.丄丘七三上丕世丞业.东丏丒且丁丆丄上丐();
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_7 = 0;
        int val_19 = 0;
        val_26 = null;
        val_26 = null;
        if((MapPopularityController.下世丄丏不上丁丘丅.TryGetValue(key:  val_25, value: out  val_7)) == false)
        {
            goto label_19;
        }
        
        val_27 = val_7;
        if((val_27.TryGetValue(key:  丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丞上上三丞东丁丝世(丂丛丑东不丅丈一东:  val_25, 丞丁丑丏丄丏七丂不:  mem[this.上丂东丗丝丈业万丅 + 56]), value: out  0)) == false)
        {
            goto label_19;
        }
        
        if((public System.Boolean System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>::TryGetValue(System.Int32 key, out System.Collections.Generic.Dictionary<System.String, System.Int32> value)) == 0)
        {
            goto label_21;
        }
        
        val_28 = System.String.Format(format:  "_{0}", arg0:  业上丙丞丐丄丆丅七());
        goto label_22;
        label_19:
        val_27 = 1152921530914425440;
        if((val_3.世三丞丅丑丌丈丈一().Contains(item:  val_25)) == true)
        {
            goto label_28;
        }
        
        bool val_17 = val_3.世三丞丅丑丌丈丈一().Add(item:  val_25);
        goto label_28;
        label_21:
        val_28 = "";
        label_22:
        val_25 = 0.ToString() + val_28;
        bool val_20 = val_9.TryGetValue(key:  val_25, value: out  val_19);
        label_28:
        if((val_19 & 2147483648) != 0)
        {
            goto label_32;
        }
        
        if(val_19 < 3)
        {
            goto label_33;
        }
        
        if(((val_19 < 6) || (val_19 < 11)) || (val_19 <= 15))
        {
            goto label_42;
        }
        
        val_29 = 5;
        goto label_42;
        label_33:
        val_29 = 1;
        goto label_42;
        label_32:
        val_29 = 0;
        label_42:
        this.一七与丁丏丄不世丄(丙业与丙丗丝不丈东:  0);
    }
    public MapPreviewGUI()
    {
    
    }

}
