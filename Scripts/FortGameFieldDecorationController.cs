using UnityEngine;
internal sealed class FortGameFieldDecorationController : PGBehaviour
{
    // Fields
    internal static FortGameFieldDecorationController 丄丘七三上丕世丞业;
    internal static System.Collections.Generic.List<string> 下丞丙丟丅丕丝下丘;
    private string 丒丛丗业丅业丏且丗;
    private System.Collections.Generic.List<PlaceableItemSettings> 丄丏丐丘与丘丏丄丙;
    
    // Methods
    private void Awake()
    {
        null = null;
        FortGameFieldDecorationController.丄丘七三上丕世丞业 = this;
    }
    internal void 东丘下万与万丂与丏()
    {
        var val_4;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        string val_27;
        val_23 = 1152921505066536960;
        if(GameConnect.七丕丟上且丄丂丞丕() == false)
        {
            goto label_3;
        }
        
        this.丄丏丐丘与丘丏丄丙.Clear();
        val_24 = null;
        val_24 = null;
        List.Enumerator<T> val_2 = FortGameFieldDecorationController.下丞丙丟丅丕丝下丘.GetEnumerator();
        label_14:
        if((1844021504 & 1) == 0)
        {
            goto label_8;
        }
        
        if((UnityEngine.Resources.Load<PlaceableItemSettingsSO>(path:  this.丒丛丗业丅业丏且丗 + val_4.丐丏七丌丕丗业且上())) == 0)
        {
            goto label_14;
        }
        
        this.丄丏丐丘与丘丏丄丙.Add(item:  val_7.placeableItemSettings);
        goto label_14;
        label_3:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_31;
        }
        
        val_25 = null;
        val_25 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.不丞丝与世三丙丏与)) == false)
        {
            goto label_31;
        }
        
        val_26 = null;
        ExitGames.Client.Photon.Hashtable val_22 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_26 = null;
        object val_15 = val_22.Item[GameConnect.不丞丝与世三丙丏与];
        if(val_15 == null)
        {
            goto label_31;
        }
        
        val_22 = (null == null) ? (val_15) : 0;
        goto label_32;
        label_31:
        val_27 = 0;
        label_32:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_27)) == true)
        {
                return;
        }
        
        System.Collections.Generic.List<FortFieldItemInfo> val_17 = new System.Collections.Generic.List<FortFieldItemInfo>();
        val_23 = public System.Collections.Generic.List<FortFieldItemInfo> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<FortFieldItemInfo>>(string 丞丕丒专一下丙业上);
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_27 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂.万丞丈丌万丟丐丆丘(三丅丁一东丟专丌三:  val_27);
        return;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        val_27 = 0;
        List.Enumerator<T> val_20 = val_27.GetEnumerator();
        val_23 = 1152921536515620496;
        label_61:
        if((1844021480 & 1) == 0)
        {
            goto label_59;
        }
        
        FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂.东丌丟三丞世一一丑(业世丟丐丘丐专与不:  0.丐丏七丌丕丗业且上(), 东且丄专丞丆丂业一:  false);
        goto label_61;
        label_59:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public FortGameFieldDecorationController()
    {
        this.丒丛丗业丅业丏且丗 = "Clans/";
        this.丄丏丐丘与丘丏丄丙 = new System.Collections.Generic.List<PlaceableItemSettings>();
    }
    private static FortGameFieldDecorationController()
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        if(val_1 != null)
        {
                val_1.Add(item:  "fort_mine_fort");
        }
        else
        {
                val_1.Add(item:  "fort_mine_fort");
        }
        
        val_1.Add(item:  "fort_mine_gates");
        if(val_1 != null)
        {
                val_1.Add(item:  "fort_mine_walls");
        }
        else
        {
                val_1.Add(item:  "fort_mine_walls");
        }
        
        val_1.Add(item:  "fort_mine_desert");
        if(val_1 != null)
        {
                val_1.Add(item:  "fort_mine_footpath");
        }
        else
        {
                val_1.Add(item:  "fort_mine_footpath");
        }
        
        val_1.Add(item:  "fort_mine_cloudy_day");
        val_1.Add(item:  "fort_mine_moat_water");
        FortGameFieldDecorationController.下丞丙丟丅丕丝下丘 = val_1;
    }

}
