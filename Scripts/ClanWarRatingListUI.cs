using UnityEngine;
public class ClanWarRatingListUI : PGBehaviour
{
    // Fields
    private WidgetLayout ratingsLayout;
    private ClanWarRatingUI myClanRatingUI;
    private ClanWarRatingUI otherClanRatingUI;
    private ClanWarRatingUI <万上与七丘丄丝丑丑>k__BackingField;
    private readonly System.Collections.Generic.Dictionary<string, ClanWarRatingUI> 且上业丟丕一与三业;
    
    // Properties
    internal ClanWarRatingUI 丅丆丂且丘丒丒下丂 { get; set; }
    
    // Methods
    internal ClanWarRatingUI 丒丙世东丒业且且东()
    {
        return (ClanWarRatingUI)this.<万上与七丘丄丝丑丑>k__BackingField;
    }
    private void 下丐业丛丄一丂丁丐(ClanWarRatingUI 丙业与丙丗丝不丈东)
    {
        this.<万上与七丘丄丝丑丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Start()
    {
        this.世业丒万丘丆专丘丐();
        this.东丒不七丝万丌丄三();
    }
    private void OnEnable()
    {
        PGCompany.ClanWarDevSelectClanButton.下丒东丏专丏丌丙业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::丘上丐世丆丑且丞丒()));
        PGCompany.ClanWarProgressController.丝丅丐世丗丅丘丏丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::东丒不七丝万丌丄三()));
        PGCompany.ClanWarProgressController.丈丕丝东丝丟丐世万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::东丒不七丝万丌丄三()));
        this.东丒不七丝万丌丄三();
    }
    private void OnDisable()
    {
        PGCompany.ClanWarDevSelectClanButton.丐世且丂丘且丄丁东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::丘上丐世丆丑且丞丒()));
        PGCompany.ClanWarProgressController.丗万一丌丂丄上丐七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::东丒不七丝万丌丄三()));
        PGCompany.ClanWarProgressController.与丄世上丏与且业东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::东丒不七丝万丌丄三()));
    }
    private void OnDestroy()
    {
        PGCompany.ClanWarDevSelectClanButton.丐世且丂丘且丄丁东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::丘上丐世丆丑且丞丒()));
        PGCompany.ClanWarProgressController.丗万一丌丂丄上丐七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::东丒不七丝万丌丄三()));
        PGCompany.ClanWarProgressController.与丄世上丏与且业东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarRatingListUI::东丒不七丝万丌丄三()));
    }
    private void 丘上丐世丆丑且丞丒()
    {
        this.世业丒万丘丆专丘丐();
        this.东丒不七丝万丌丄三();
    }
    private void 东丒不七丝万丌丄三()
    {
        var val_7;
        var val_43;
        ClanWarRatingListUI val_44;
        var val_45;
        System.Func<System.Tuple<System.String, System.Int32>, System.Int32> val_47;
        var val_48;
        int val_49;
        ClanWarRatingUI val_50;
        var val_51;
        System.Collections.Generic.List<System.Tuple<System.String, System.Int32>> val_3 = new System.Collections.Generic.List<System.Tuple<System.String, System.Int32>>(capacity:  PGCompany.ClanWarProgressController.丆丕丝丒不丙且丐丗.三丞与不丂万丈丏丛().Count);
        List.Enumerator<T> val_5 = PGCompany.ClanWarProgressController.丆丕丝丒不丙且丐丗.三丞与不丂万丈丏丛().GetEnumerator();
        label_12:
        if((2145461456 & 1) == 0)
        {
            goto label_5;
        }
        
        string val_8 = val_7.丐丏七丌丕丗业且上();
        丞丂丘丒丟丞丑下丄 val_11 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  val_8);
        if(val_11 != null)
        {
                val_43 = (val_11 == 0) ? 0 : (val_11).业不且丟丆下丏丌丒();
        }
        else
        {
                val_43 = 0;
        }
        
        System.Tuple<System.String, System.Int32> val_14 = new System.Tuple<System.String, System.Int32>(item1:  val_8, item2:  0);
        val_3.Add(item:  null);
        goto label_12;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_44 = this;
        val_45 = null;
        val_45 = null;
        val_47 = ClanWarRatingListUI.<>c.<>9__13_0;
        if(val_47 == null)
        {
                System.Func<System.Tuple<System.String, System.Int32>, System.Int32> val_15 = null;
            val_47 = val_15;
            val_15 = new System.Func<System.Tuple<System.String, System.Int32>, System.Int32>(object:  ClanWarRatingListUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanWarRatingListUI.<>c::三丝丒丘丂丆且业与(System.Tuple<string, int> 丙丒七丄上与丏丙丙));
            ClanWarRatingListUI.<>c.<>9__13_0 = val_47;
        }
        
        List.Enumerator<T> val_18 = System.Linq.Enumerable.ToList<System.Tuple<System.String, System.Int32>>(source:  System.Linq.Enumerable.OrderByDescending<System.Tuple<System.String, System.Int32>, System.Int32>(source:  val_3, keySelector:  val_15)).GetEnumerator();
        val_48 = 1152921536816985712;
        val_49 = 1;
        goto label_29;
        label_62:
        string val_19 = val_7.丐丏七丌丕丗业且上();
        if((System.String.IsNullOrEmpty(value:  val_19.Item1)) != true)
        {
                if((mem[1152921536817091736].ContainsKey(key:  val_19.Item1)) != false)
        {
                val_50 = mem[1152921536817091736].Item[val_19.Item1];
        }
        else
        {
                if((System.String.op_Equality(a:  val_19.Item1, b:  PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛())) != false)
        {
                val_50 = UnityEngine.Object.Instantiate<ClanWarRatingUI>(original:  mem[1152921536817091712], parent:  mem[1152921536817091704].transform);
        }
        else
        {
                val_50 = UnityEngine.Object.Instantiate<ClanWarRatingUI>(original:  mem[1152921536817091720], parent:  mem[1152921536817091704].transform);
        }
        
            val_50.gameObject.SetActive(value:  true);
            mem[1152921536817091736].Add(key:  val_19.Item1, value:  val_50);
        }
        
            val_50.丗丘丌世万丅丘丟丌(上丐不丂丝业业丑丄:  2145429104, 丄丒下业一不丈丝丘:  val_19.Item1, 丈丐世下丞与丂专丏:  val_19.Item2);
            val_32.与丛丑东万业上下万 = val_49;
            val_50.东丒不七丝万丌丄三();
            val_32.丌专万丝三七丅丈一 = val_19.Item1;
            val_50.东丒不七丝万丌丄三();
            val_32.丆丞下七丛上丐世丌 = val_19.Item2;
            val_50.东丒不七丝万丌丄三();
            mem[1152921536817091704].AddElement(丅丆东丏丙丝丅丆丟:  val_50);
            if((System.String.op_Equality(a:  val_19.Item1, b:  PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛())) != false)
        {
                mem[1152921536817091728] = val_50;
        }
        
            val_48 = 1152921536816985712;
            val_49 = 2;
        }
        
        label_29:
        if((2145461424 & 1) != 0)
        {
            goto label_62;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_51 = null;
        val_51 = null;
        if((ClanWarRatingListUI.<>c.<>9__13_1) == null)
        {
            goto label_97;
        }
        
        label_103:
        mem[1152921536817091704].万万丘丙丗丈丘丙丁(业丁一且丄丂丗七丈:  ClanWarRatingListUI.<>c.<>9__13_1);
        mem[1152921536817091704].Reposition();
        return;
        label_97:
        ClanWarRatingListUI.<>c.<>9__13_1 = new System.Func<UnityEngine.GameObject, System.Int32>(object:  ClanWarRatingListUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanWarRatingListUI.<>c::一丏与丛丏三七丛丕(UnityEngine.GameObject 丄三丅七丆丛与与上));
        if(mem[1152921536817091704] != 0)
        {
            goto label_103;
        }
        
        goto label_103;
    }
    private void 世业丒万丘丆专丘丐()
    {
        this.且上业丟丕一与三业.Clear();
        this.ratingsLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
    }
    public ClanWarRatingListUI()
    {
        this.且上业丟丕一与三业 = new System.Collections.Generic.Dictionary<System.String, ClanWarRatingUI>();
    }

}
