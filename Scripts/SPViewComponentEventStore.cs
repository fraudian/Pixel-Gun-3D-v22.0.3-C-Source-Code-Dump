using UnityEngine;
internal sealed class SPViewComponentEventStore : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject state_NotPurchased;
    private UnityEngine.GameObject state_Purchased;
    private UnityEngine.GameObject componentCanGet;
    private UnityEngine.GameObject componentProgressBar;
    private PGCompany.InventoryItemView mainReward;
    private PGCompany.InventoryItemView additionalReward;
    private UILabel categoryLabel;
    private UILabel upgradeLabel;
    private UILabel descriptionLabel;
    private System.Collections.Generic.List<UnityEngine.GameObject> disableIfProgress;
    private PGCompany.东丑丆丗丏丐丟下丄 丂丅七与丘丞丟万丕;
    
    // Methods
    private void OnEnable()
    {
        this.UpdateView();
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.丂丅七与丘丞丟万丕 = 且丘丏丁丑与丙与丁;
        this.UpdateView();
    }
    public void UpdateView()
    {
        var val_13;
        System.Collections.Generic.List<UnityEngine.GameObject> val_37;
        var val_38;
        var val_39;
        UnityEngine.GameObject val_40;
        var val_41;
        string val_42;
        var val_43;
        System.Func<PGCompany.丄与丘丑业专丞七丅, System.Boolean> val_45;
        System.Func<TSource, System.Boolean> val_46;
        PGCompany.三东丏不丗世丅丌丄 val_47;
        var val_48;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_50;
        var val_51;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_53;
        var val_54;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_56;
        string val_57;
        PGCompany.三东丏不丗世丅丌丄 val_58;
        val_37 = this;
        if(this.丂丅七与丘丞丟万丕 == null)
        {
                return;
        }
        
        val_38 = 0;
        val_39 = 1152921505284374528;
        if((this.丂丅七与丘丞丟万丕.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "state.purchased")) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotPurchased, 丏业丟一东丂东丘丛:  false);
            val_40 = this.state_Purchased;
            val_41 = 1;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotPurchased, 丏业丟一东丂东丘丛:  true);
            val_40 = this.state_Purchased;
            val_41 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_40, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.additionalReward, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.upgradeLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.categoryLabel, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        val_42 = "promotion-collectable";
        if((this.丂丅七与丘丞丟万丕.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "promotion-collectable")) != false)
        {
                val_43 = null;
            val_43 = null;
            val_45 = SPViewComponentEventStore.<>c.<>9__13_0;
            if(val_45 == null)
        {
                System.Func<PGCompany.丄与丘丑业专丞七丅, System.Boolean> val_7 = null;
            val_45 = val_7;
            val_7 = new System.Func<PGCompany.丄与丘丑业专丞七丅, System.Boolean>(object:  SPViewComponentEventStore.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SPViewComponentEventStore.<>c::丞丄丑丅下丐上丆上(PGCompany.丄与丘丑业专丞七丅 三丟东丕丄丄下下丑));
            SPViewComponentEventStore.<>c.<>9__13_0 = val_45;
        }
        
            val_46 = val_45;
            if(((System.Linq.Enumerable.FirstOrDefault<PGCompany.丄与丘丑业专丞七丅>(source:  丝世丑七丂丄丅专不(), predicate:  val_7)) != null) && (val_8.ItemParams != null))
        {
                val_46 = val_8.ItemParams;
            this.mainReward.Setup(丈丄不七三万丄丁不:  val_46);
        }
        
            if(this.丂丅七与丘丞丟万丕.Count >= 1)
        {
                List.Enumerator<T> val_11 = 丝世丑七丂丄丅专不().GetEnumerator();
            if((257546160 & 1) != 0)
        {
                string val_14 = val_13.丐丏七丌丕丗业且上();
            PGCompany.丗丟丄丈东丝丕丄世 val_15 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_14.m_stringLength);
            if(val_15 != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.categoryLabel, 丕丗丘丑丛与丑业丒:  val_15);
        }
        
        }
        
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        
            int val_17 = this.丂丅七与丘丞丟万丕.丐丂业丁丑丅与且丐().From;
            PGCompany.DataObjects.IntInterval val_36 = this.丂丅七与丘丞丟万丕.丐丂业丁丑丅与且丐();
            val_47 = val_36.To;
            val_36 = ((val_17 == val_47) ? 1 : 0) & ((val_47 > 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.componentProgressBar, 丏业丟一东丂东丘丛:  ((val_17 != val_47) ? 1 : 0) | ((val_47 < 1) ? 1 : 0));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.componentCanGet, 丏业丟一东丂东丘丛:  val_36);
        }
        else
        {
                val_48 = null;
            val_48 = null;
            val_50 = SPViewComponentEventStore.<>c.<>9__13_1;
            if(val_50 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_25 = null;
            val_50 = val_25;
            val_25 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  SPViewComponentEventStore.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SPViewComponentEventStore.<>c::丑万下丒丑丏丄丝丟(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            SPViewComponentEventStore.<>c.<>9__13_1 = val_50;
        }
        
            PGCompany.三东丏不丗世丅丌丄 val_26 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.丂丅七与丘丞丟万丕, predicate:  val_25);
            val_51 = null;
            val_51 = null;
            val_53 = SPViewComponentEventStore.<>c.<>9__13_2;
            if(val_53 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_27 = null;
            val_53 = val_27;
            val_27 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  SPViewComponentEventStore.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SPViewComponentEventStore.<>c::丑丒丈且上且丟一丂(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            SPViewComponentEventStore.<>c.<>9__13_2 = val_53;
        }
        
            PGCompany.三东丏不丗世丅丌丄 val_28 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.丂丅七与丘丞丟万丕, predicate:  val_27);
            val_54 = null;
            val_54 = null;
            val_56 = SPViewComponentEventStore.<>c.<>9__13_3;
            if(val_56 == null)
        {
                val_57 = val_42;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_29 = null;
            val_56 = val_29;
            val_29 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  SPViewComponentEventStore.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SPViewComponentEventStore.<>c::上世丂丌与丐丘业业(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            val_42 = ;
            SPViewComponentEventStore.<>c.<>9__13_3 = val_56;
            val_39 = 1152921505284374528;
        }
        
            val_47 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.丂丅七与丘丞丟万丕, predicate:  val_29);
            val_58 = 0;
            if(((val_26 == null) && (val_28 == null)) && (val_47 == null))
        {
                if(this.丂丅七与丘丞丟万丕.Count == 1)
        {
                val_58 = this.丂丅七与丘丞丟万丕.Item[0];
        }
        else
        {
                val_58 = 0;
        }
        
        }
        
            this.丁业丛丑丂丙东丝丁(丌丝下丄业一丄不三:  val_26, 丅专丕三且丑丘专下:  val_28, 丈丞丝下丞丏下丁三:  val_47, 世丐丅业三丘世丆一:  val_58, 丈丙七万丂丂三丗七:  null);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  丏丟丅丑丞丅丌丘丝());
        val_37 = this.disableIfProgress;
        val_42 = (~(this.丂丅七与丘丞丟万丕.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_42))) & 1;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_37, 丏业丟一东丂东丘丛:  val_42);
    }
    private void 丁业丛丑丂丙东丝丁(PGCompany.三东丏不丗世丅丌丄 丌丝下丄业一丄不三, PGCompany.三东丏不丗世丅丌丄 丅专丕三且丑丘专下, PGCompany.三东丏不丗世丅丌丄 丈丞丝下丞丏下丁三, PGCompany.三东丏不丗世丅丌丄 世丐丅业三丘世丆一, PGCompany.MainStore.丏不丂丛不不七且下 丈丙七万丂丂三丗七)
    {
        PGCompany.丗丟丄丈东丝丕丄世 val_16;
        int val_17;
        string val_18;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.additionalReward, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.upgradeLabel, 丏业丟一东丂东丘丛:  false);
        val_16 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  丌丝下丄业一丄不三);
        if(丅专丕三且丑丘专下 == null)
        {
            goto label_4;
        }
        
        this.mainReward.Setup(丈丄不七三万丄丁不:  丅专丕三且丑丘专下);
        val_17 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丈丄不七三万丄丁不:  丅专丕三且丑丘专下).上专丗丏丛丁专丑丄().WeaponIndex;
        val_16 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  val_17);
        if(丌丝下丄业一丄不三 == null)
        {
            goto label_25;
        }
        
        val_17 = this.additionalReward;
        val_17.Setup(丈丄不七三万丄丁不:  丌丝下丄业一丄不三);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.additionalReward, 丏业丟一东丂东丘丛:  true);
        if(丈丙七万丂丂三丗七 != null)
        {
            goto label_31;
        }
        
        goto label_24;
        label_4:
        if(丌丝下丄业一丄不三 == null)
        {
            goto label_16;
        }
        
        val_17 = this.mainReward;
        val_17.Setup(丈丄不七三万丄丁不:  丌丝下丄业一丄不三);
        if(丈丙七万丂丂三丗七 != null)
        {
            goto label_31;
        }
        
        goto label_24;
        label_16:
        if(丈丞丝下丞丏下丁三 == null)
        {
            goto label_20;
        }
        
        val_16 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  丈丞丝下丞丏下丁三.业上丙丞丐丄丆丅七());
        this.mainReward.Setup(与且专丈不万东一万:  val_16);
        if(丈丙七万丂丂三丗七 != null)
        {
            goto label_31;
        }
        
        goto label_24;
        label_20:
        if(世丐丅业三丘世丆一 != null)
        {
                this.mainReward.Setup(丈丄不七三万丄丁不:  世丐丅业三丘世丆一);
            val_17 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  世丐丅业三丘世丆一);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.categoryLabel, 丕丗丘丑丛与丑业丒:  val_17);
        }
        
        label_25:
        if(丈丙七万丂丂三丗七 != null)
        {
            goto label_31;
        }
        
        label_24:
        label_31:
        val_18 = 0;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丈丙七万丂丂三丗七.上一丑下丙丛上丕丐)) != false)
        {
                val_18 = "+0";
            if((System.String.op_Inequality(a:  丈丙七万丂丂三丗七.上一丑下丙丛上丕丐, b:  val_18)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.additionalReward, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.upgradeLabel, 丕丗丘丑丛与丑业丒:  丈丙七万丂丂三丗七.上一丑下丙丛上丕丐);
            val_18 = 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.upgradeLabel, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        if(val_16 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.categoryLabel, 丕丗丘丑丛与丑业丒:  val_16);
    }
    public SPViewComponentEventStore()
    {
        val_1 = new PGBehaviour();
    }

}
