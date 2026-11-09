using UnityEngine;
internal sealed class FortDefenceGeneratorUI : PGBehaviour
{
    // Fields
    private FortDefenceGeneratorItemUI _example;
    private WidgetLayout _exampleWidgetColumn;
    private System.Collections.Generic.List<System.Collections.Generic.List<FortDefenceGeneratorItemUI>> 下丘三专丌世丂丂丑;
    private WidgetLayout _row;
    private System.Collections.Generic.List<WidgetLayout> 上下丟丂万丗且三丅;
    
    // Methods
    internal void 丘上丐世丆丑且丞丒(System.Collections.Generic.List<System.Collections.Generic.List<FortDefenceGeneratorUI.丙且丐丐专下丘与丛>> 丐丒下丒丝丛丄丝三)
    {
        var val_3;
        FortDefenceGeneratorUI val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_31;
        var val_32;
        val_23 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._row, 丏业丟一东丂东丘丛:  true);
        List.Enumerator<T> val_1 = 丐丒下丒丝丛丄丝三.GetEnumerator();
        val_24 = 1152921504848912384;
        val_25 = 0;
        val_26 = 0;
        label_66:
        if((1139283600 & 1) == 0)
        {
            goto label_4;
        }
        
        WidgetLayout val_5 = UnityEngine.Object.Instantiate<WidgetLayout>(original:  this._exampleWidgetColumn);
        val_5.gameObject.SetActive(value:  true);
        val_5.transform.SetParent(p:  this._row.transform);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        val_5.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        this._row.AddElement(丅丆东丏丙丝丅丆丟:  val_5);
        System.Collections.Generic.List<FortDefenceGeneratorItemUI> val_11 = new System.Collections.Generic.List<FortDefenceGeneratorItemUI>();
        List.Enumerator<T> val_12 = val_3.丐丏七丌丕丗业且上().GetEnumerator();
        goto label_18;
        label_39:
        MessagePack.MessagePackReader val_13 = CreatePeekReader();
        FortDefenceGeneratorItemUI val_14 = UnityEngine.Object.Instantiate<FortDefenceGeneratorItemUI>(original:  this._example);
        null.Add(item:  val_14);
        val_14.gameObject.SetActive(value:  true);
        val_14.transform.SetParent(p:  val_5.transform);
        val_26 = val_26;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        val_14.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        if(0 != 1)
        {
                val_14.prevItem = null.Item[0];
            FortDefenceGeneratorItemUI val_21 = null.Item[0];
            val_21.nextItem = val_14;
        }
        
        val_14.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  new 丙且丐丐专下丘与丛() {丟丒丕东丘丝下与业 = false, 丛丐丟丗丄丁业三丘 = false, 万丛丅三下丄丒万下 = new UnityEngine.Color(), 专万丙丅专且丐丏丙 = new UnityEngine.Color(), 不丑丗丒且世丟丈一 = new UnityEngine.Color(), 与世丏下东丕丝丞七 = false, 专丛丆专专世丙丙丕 = false, 专不丙丗丝丛专丑丕 = new UnityEngine.Color(), 丄丑丛业且丗与且丂 = new UnityEngine.Color(), 万不丕七东丏下三丆 = new UnityEngine.Color()}, 与世丏下东丕丝丞七:  false, 专丛丆专专世丙丙丕:  false);
        val_23 = val_23;
        val_5.AddElement(世丌丌丙丞丟下东丞:  val_14.widget);
        label_18:
        if((1139283424 & 1) != 0)
        {
            goto label_39;
        }
        
        val_27 = val_26 + 1;
        mem2[0] = 310;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_27 != 1) && ((1139282720 + ((val_26 + 1)) << 2) == 310))
        {
                var val_23 = 0;
            val_23 = val_23 ^ (val_27 >> 31);
            val_27 = val_27 + val_23;
        }
        
        mem[1152921540105881208].Add(item:  val_5);
        val_5.Reposition();
        mem[1152921540105881192].Add(item:  null);
        goto label_66;
        label_4:
        val_31 = 0;
        val_32 = val_26 + 1;
        mem2[0] = 372;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_32 == 1)
        {
            goto label_84;
        }
        
        if(( == 0) || ((1139282720 + ((val_26 + 1)) << 2) == 372))
        {
            goto label_89;
        }
        
        label_88:
        label_89:
        this._row.Reposition();
        return;
        label_84:
        if( != 0)
        {
            goto label_88;
        }
        
        goto label_89;
    }
    internal void 万丈上万上丑业丂丛(int 丛丛七丝丙丒丝业丙, int 丕与丒一丑丑丝丌世, FortDefenceGeneratorUI.丙且丐丐专下丘与丛 下丅丙一丂丗丅丝七)
    {
        WidgetLayout val_16;
        int val_17;
        System.Collections.Generic.List<System.Collections.Generic.List<FortDefenceGeneratorItemUI>> val_18;
        val_16 = 1152921540106246432;
        val_17 = 丛丛七丝丙丒丝业丙;
        val_18 = this.下丘三专丌世丂丂丑;
        if(val_18.Count <= val_17)
        {
                return;
        }
        
        val_18 = this.下丘三专丌世丂丂丑.Item[val_17];
        if(val_18.Count > 丕与丒一丑丑丝丌世)
        {
                val_17 = this.下丘三专丌世丂丂丑.Item[val_17].Item[丕与丒一丑丑丝丌世];
            val_17.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  new 丙且丐丐专下丘与丛() {丟丒丕东丘丝下与业 = false, 丛丐丟丗丄丁业三丘 = false, 万丛丅三下丄丒万下 = new UnityEngine.Color(), 专万丙丅专且丐丏丙 = new UnityEngine.Color(), 不丑丗丒且世丟丈一 = new UnityEngine.Color(), 与世丏下东丕丝丞七 = false, 专丛丆专专世丙丙丕 = false, 专不丙丗丝丛专丑丕 = new UnityEngine.Color(), 丄丑丛业且丗与且丂 = new UnityEngine.Color(), 万不丕七东丏下三丆 = new UnityEngine.Color()}, 与世丏下东丕丝丞七:  false, 专丛丆专专世丙丙丕:  false);
            return;
        }
        
        FortDefenceGeneratorItemUI val_6 = UnityEngine.Object.Instantiate<FortDefenceGeneratorItemUI>(original:  this._example);
        this.下丘三专丌世丂丂丑.Item[val_17].Add(item:  val_6);
        val_6.gameObject.SetActive(value:  true);
        val_6.transform.SetParent(p:  this.上下丟丂万丗且三丅.Item[val_17].transform);
        val_18 = val_6.transform;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        val_18.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        val_6.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  new 丙且丐丐专下丘与丛() {丟丒丕东丘丝下与业 = false, 丛丐丟丗丄丁业三丘 = false, 万丛丅三下丄丒万下 = new UnityEngine.Color(), 专万丙丅专且丐丏丙 = new UnityEngine.Color(), 不丑丗丒且世丟丈一 = new UnityEngine.Color(), 与世丏下东丕丝丞七 = false, 专丛丆专专世丙丙丕 = false, 专不丙丗丝丛专丑丕 = new UnityEngine.Color(), 丄丑丛业且丗与且丂 = new UnityEngine.Color(), 万不丕七东丏下三丆 = new UnityEngine.Color()}, 与世丏下东丕丝丞七:  false, 专丛丆专专世丙丙丕:  false);
        this.上下丟丂万丗且三丅.Item[val_17].AddElement(世丌丌丙丞丟下东丞:  val_6.widget);
        val_16 = this._row;
        val_16.Reposition();
        val_17 = this.上下丟丂万丗且三丅.Item[val_17];
        val_17.Reposition();
    }
    public FortDefenceGeneratorUI()
    {
        this.下丘三专丌世丂丂丑 = new System.Collections.Generic.List<System.Collections.Generic.List<FortDefenceGeneratorItemUI>>();
        this.上下丟丂万丗且三丅 = new System.Collections.Generic.List<WidgetLayout>();
    }

}
