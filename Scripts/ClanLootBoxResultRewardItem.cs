using UnityEngine;
internal sealed class ClanLootBoxResultRewardItem : PGBehaviour
{
    // Fields
    private UITextureMasked middleIcon;
    private System.Collections.Generic.List<UISprite> iconCategory;
    private System.Collections.Generic.List<UILabel> nameItem;
    private System.Collections.Generic.List<UILabel> nameCategory;
    private System.Collections.Generic.List<UILabel> count;
    private UISprite _divisionSprite;
    private UITexture rarityTexture;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        var val_14;
        var val_15;
        PGCompany.三东丏不丗世丅丌丄 val_16;
        var val_17;
        var val_18;
        var val_19;
        UnityEngine.MonoBehaviour val_20;
        PGCompany.丗丟丄丈东丝丕丄世 val_21;
        int val_22;
        ClanLootBoxResultRewardItem.丒丑万一丁丕东一丗 val_1 = new ClanLootBoxResultRewardItem.丒丑万一丁丕东一丗();
        if(val_1 != null)
        {
                val_14 = val_1;
            .丈丄不七三万丄丁不 = 丈丄不七三万丄丁不;
            mem[1152921536770712280] = this;
            val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        }
        else
        {
                mem[24] = this;
            val_14 = 40;
            mem[40] = 丈丄不七三万丄丁不;
            val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_4 = val_15.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  mem[40]);
        if(val_1 == null)
        {
            goto label_4;
        }
        
        .丞丘丞丏业且丛丏丘 = val_4;
        if(val_4 != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.middleIcon, 与万丆丛丒万丝丙丑:  val_4);
        if(val_1 == null)
        {
            goto label_8;
        }
        
        val_16 = mem[40];
        int val_5 = this.middleIcon.东丂丏三丂业万丗三(丈丄不七三万丄丁不:  val_16);
        val_17 = val_1;
        .七丌丌丏丗东丕且丅 = val_5;
        if((val_5 & 2147483648) == 0)
        {
            goto label_9;
        }
        
        goto label_13;
        label_4:
        mem[16] = val_4;
        if(mem[16] != 0)
        {
            goto label_11;
        }
        
        goto label_12;
        label_8:
        val_16 = mem[40];
        val_17 = 32;
        mem[32] = this.东丂丏三丂业万丗三(丈丄不七三万丄丁不:  val_16);
        if((mem[32] & 2147483648) != 0)
        {
            goto label_13;
        }
        
        label_9:
        val_18 = 0;
        goto label_14;
        label_24:
        UISprite val_7 = this.iconCategory.Item[0];
        if(val_18 == mem[32])
        {
                val_19 = 1;
            val_20 = val_7;
        }
        else
        {
                val_20 = val_7;
            val_19 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_20, 丏业丟一东丂东丘丛:  false);
        val_18 = 1;
        label_14:
        val_16 = public System.Int32 System.Collections.Generic.List<UISprite>::get_Count();
        if(val_18 < this.iconCategory.Count)
        {
            goto label_24;
        }
        
        label_13:
        UnityEngine.Color val_9 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  mem[16]);
        this.rarityTexture.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
        if(val_1 != null)
        {
                val_21 = mem[16];
        }
        else
        {
                val_21 = mem[16];
            val_22 = mem[32];
        }
        
        this.万丕丈丗丑丕万丏丌(丞丘丞丏业且丛丏丘:  val_21, 七丆丒与丗丌丄且丂:  val_22, 丈丄不七三万丄丁不:  mem[40]);
        this.nameItem.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void ClanLootBoxResultRewardItem.丒丑万一丁丕东一丗::丆一且世上丗上一丗(UILabel 丄三丅七丆丛与与上)));
        this.nameCategory.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void ClanLootBoxResultRewardItem.丒丑万一丁丕东一丗::一丄业丐丄丒下丏丞(UILabel 丄三丅七丆丛与与上)));
        this.count.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void ClanLootBoxResultRewardItem.丒丑万一丁丕东一丗::丙丛上丏上丘丟丛丘(UILabel 丄三丅七丆丛与与上)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
    }
    private string 丐丞丐丝下上上丐丂(int 丞世不丒下上上丝丑, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        PGCompany.三东丏不丗世丅丌丄 val_12 = 丈丄不七三万丄丁不;
        if((丞世不丒下上上丝丑 & 2147483648) != 0)
        {
                return "None";
        }
        
        if(丞世不丒下上上丝丑 > 5)
        {
                return "None";
        }
        
        var val_12 = 106033028 + (丞世不丒下上上丝丑) << 2;
        val_12 = val_12 + 106033028;
        goto (106033028 + (丞世不丒下上上丝丑) << 2 + 106033028);
    }
    internal void 万丕丈丗丑丕万丏丌(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘, int 七丆丒与丗丌丄且丂, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        Rilisoft.OfferItem val_35;
        int val_36;
        var val_37;
        一一万丒与专丙丁丛 val_38;
        val_35 = 七丆丒与丗丌丄且丂;
        if(丞丘丞丏业且丛丏丘 == null)
        {
            goto label_20;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        label_18:
        if(null == null)
        {
            goto label_3;
        }
        
        label_20:
        if((val_35 != 0) || (丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() != 1070))
        {
            goto label_27;
        }
        
        val_36 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  new Rilisoft.OfferItem(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不()).Record.与不丞丑七丘丁丂丛()).业东丅东丌上丗丑不();
        Rilisoft.OfferItem val_8 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  val_36);
        if(val_8 == null)
        {
            goto label_27;
        }
        
        this.丕上七上丒业不一世(丌丄与丕丈丌丆业丝:  val_8.业世上不专丐不东三(丏且丕丄丁丟丆丏丁:  val_8).世丝丌一且丝专丑丛());
        return;
        label_2:
        val_37 = 丞丘丞丏业且丛丏丘.丈丏专三世七丒丘丑();
        val_38 = val_37.ClanDivision;
        if(val_38 != 1)
        {
            goto label_17;
        }
        
        goto label_18;
        label_3:
        val_38 = 丞丘丞丏业且丛丏丘.丈丏专三世七丒丘丑().ClanDivision;
        if(val_38 == 1)
        {
            goto label_20;
        }
        
        label_17:
        this.丕上七上丒业不一世(丌丄与丕丈丌丆业丝:  val_38);
        return;
        label_27:
        if(((???) == 5) && ((???.不业丙丒丂丞下丆丙()) == 1300))
        {
                PGCompany.三东丏不丗世丅丌丄 val_19 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丛丈丏丅丂一不丒业(上七下丘一下三世丏:  ???);
            Rilisoft.OfferItem val_21 = null;
            val_35 = val_21;
            val_21 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  val_19.业东丅东丌上丗丑不());
            if(val_19 != null)
        {
                ???.丕上七上丒业不一世(丌丄与丕丈丌丆业丝:  val_21.业世上不专丐不东三(丏且丕丄丁丟丆丏丁:  val_21).世丝丌一且丝专丑丛());
            return;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  ??? + 112, 丏业丟一东丂东丘丛:  false);
    }
    private PGCompany.丟丁且丝丁三丏丙且 业世上不专丐不东三(Rilisoft.OfferItem 丏且丕丄丁丟丆丏丁)
    {
        var val_19;
        System.Nullable<CategoryNames> val_1 = 丏且丕丄丁丟丆丏丁.Category;
        bool val_2 = 上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_1.HasValue);
        if(丏且丕丄丁丟丆丏丁 == null)
        {
            goto label_4;
        }
        
        if(val_2 == false)
        {
            goto label_5;
        }
        
        label_10:
        val_19 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丏且丕丄丁丟丆丏丁.Id);
        int val_5 = val_19.业东丅东丌上丗丑不();
        return (PGCompany.丟丁且丝丁三丏丙且)PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆().Item[val_19.业东丅东丌上丗丑不()];
        label_4:
        if(val_2 == true)
        {
            goto label_10;
        }
        
        label_5:
        System.Nullable<CategoryNames> val_6 = 丏且丕丄丁丟丆丏丁.Category;
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_6.HasValue)) != false)
        {
                val_19 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丏且丕丄丁丟丆丏丁.Id];
            int val_11 = val_19.业东丅东丌上丗丑不();
            return (PGCompany.丟丁且丝丁三丏丙且)PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆().Item[val_19.业东丅东丌上丗丑不()];
        }
        
        val_19 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[丏且丕丄丁丟丆丏丁.Id];
        return (PGCompany.丟丁且丝丁三丏丙且)PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆().Item[val_19.业东丅东丌上丗丑不()];
    }
    private void 丕上七上丒业不一世(一一万丒与专丙丁丛 丌丄与丕丈丌丆业丝)
    {
        if(this._divisionSprite == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._divisionSprite, 万丑丞一丝丌丐丒丘:  System.String.Format(format:  "cup{0}_mini_thin", arg0:  丌丄与丕丈丌丆业丝 + 1.ToString()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._divisionSprite, 丏业丟一东丂东丘丛:  true);
    }
    private int 东丂丏三丂业万丗三(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        var val_19;
        var val_20;
        var val_21;
        if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1070)
        {
                Rilisoft.OfferItem val_3 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不());
            if(val_3 != null)
        {
                if((丆丐三丅丆丗东丑世.丞丒丒三丞且丏东丄(丞丅上丏丂且下丅与:  val_3.Id)) != false)
        {
                val_19 = 0;
            return (int)val_19;
        }
        
        }
        
        }
        
        if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() != 1010)
        {
                if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() != 1000)
        {
                if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() != 1180)
        {
            goto label_12;
        }
        
        }
        
        }
        
        val_19 = 1;
        return (int)val_19;
        label_12:
        if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1150)
        {
                return (int)val_19;
        }
        
        if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1155)
        {
                return (int)val_19;
        }
        
        if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1250)
        {
                PGCompany.三丙业丆上丏三丈丌 val_12 = new PGCompany.三丙业丆上丏三丈丌(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
            if(val_12 != null)
        {
                PlaceableItemSettings val_13 = val_12.丈丏专三世七丒丘丑();
            val_20 = null;
            val_20 = null;
            if((System.String.op_Equality(a:  val_13.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛)) != false)
        {
                return (int)val_19;
        }
        
            PlaceableItemSettings val_15 = val_12.丈丏专三世七丒丘丑();
            val_21 = null;
            val_21 = null;
            if((System.String.op_Equality(a:  val_15.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄)) != false)
        {
                return (int)val_19;
        }
        
        }
        
        }
        
        var val_18 = (丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1300) ? 5 : (!0);
        return (int)val_19;
    }
    public ClanLootBoxResultRewardItem()
    {
    
    }

}
