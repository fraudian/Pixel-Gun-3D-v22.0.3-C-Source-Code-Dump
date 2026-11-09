using UnityEngine;
private sealed class 上丑三丁丄丛丁万丑.丟不丙万丗世丁丏一
{
    // Fields
    public System.EventHandler 丑丘丐丂不丐丒丟且;
    public UnityEngine.GameObject 丛丈七丒丄业丒丈丕;
    public System.Action 丒七丒丌世丘丑丂七;
    public System.EventHandler 丌专业且丛丏丞丝且;
    public 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞;
    public string 三不三丟专丘东东丂;
    public bool 与丟丁七丟专业一丅;
    public System.Action 七丒上且丝业业下七;
    public Progress.丁丞丌与丘丝丕丈丂 丝与丙丈丑丁七且丐;
    public Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 丐丈上丂与上丂丒丏;
    public System.Action 丝丏丗丄丗与丐丌三;
    
    // Methods
    public 上丑三丁丄丛丁万丑.丟不丙万丗世丁丏一()
    {
    
    }
    internal void 丈丌丟丕丁一业业世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  this.丑丘丐丂不丐丒丟且);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        if(this.丛丈七丒丄业丒丈丕 != 0)
        {
                this.丛丈七丒丄业丒丈丕.SetActive(value:  true);
        }
        
        if(this.丒七丒丌世丘丑丂七 == null)
        {
                return;
        }
        
        this.丒七丒丌世丘丑丂七.Invoke();
    }
    internal void 七丒丟三不七丛丘丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        string val_43;
        string val_44;
        var val_45;
        var val_46;
        string val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  this.丌专业且丛丏丞丝且);
        if(this.丛丈七丒丄业丒丈丕 != 0)
        {
                this.丛丈七丒丄业丒丈丕.SetActive(value:  true);
        }
        
        if((System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  "TicketsCurrency")) == false)
        {
            goto label_9;
        }
        
        val_43 = 0;
        int val_5 = BankController.丈丐业丈丄丕丕三世();
        goto label_18;
        label_9:
        string val_8 = this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业();
        if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业())) == false)
        {
            goto label_15;
        }
        
        val_43 = Rilisoft.丛且世丐丆上七业丁.丁丂丈世丘丂丕丘东(丈上下与丌丘丅丙丒:  val_8);
        int val_10 = BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  val_43);
        goto label_18;
        label_15:
        if((System.String.op_Equality(a:  val_8, b:  "DetailsCurrency")) == false)
        {
            goto label_19;
        }
        
        val_44 = this.三不三丟专丘东东丂;
        if(this.丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世() <= (Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_44)))
        {
            goto label_23;
        }
        
        label_86:
        if(this.丝丏丗丄丗与丐丌三 != null)
        {
                this.丝丏丗丄丗与丐丌三.Invoke();
        }
        
        UnityEngine.Debug.Log(message:  "Try_ing to display bank interface...");
        if((System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  "DetailsCurrency")) == false)
        {
            goto label_28;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_31;
        }
        
        val_45 = null;
        val_45 = null;
        bool val_17 = ShopNGUIController.丏丙丅丕一丑丕丑丑.下丕三丄三丕丘东丒(丆万一不丌且东丐丐:  this.三不三丟专丘东东丂);
        return;
        label_28:
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  this.丑丘丐丂不丐丒丟且);
        val_46 = null;
        val_46 = null;
        val_47 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丏丘丟上丙与一三三;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_48 = null;
            val_48 = null;
            val_47 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丟七丁不丞东丛不丅;
        }
        
        if(this.丐丈上丂与上丂丒丏 == 89)
        {
                val_49 = null;
            val_49 = null;
            val_47 = PGCompany.Analytics.丂与丏丕一丒与丁丙.与丑丈七丌丒丈丝七;
        }
        
        if(Base_BuildingUI.instance != 0)
        {
                if(Base_BuildingUI.instance.gameObject.activeSelf != false)
        {
                val_50 = null;
            val_50 = null;
            val_47 = PGCompany.Analytics.丂与丏丕一丒与丁丙.东三且一丝不丙与丛;
        }
        
        }
        
        if(GiftBannerWindow.丛世丛与丌不丈丐丐() != false)
        {
                val_51 = null;
            val_51 = null;
            val_47 = PGCompany.Analytics.丂与丏丕一丒与丁丙.七东丐丁丏丑丑丄与;
        }
        
        if(ClanCreateGui.丑七不且上丗丁一世() != 0)
        {
                if(ClanCreateGui.丑七不且上丗丁一世().__InterfaceEnabled != false)
        {
                val_52 = null;
            val_52 = null;
            val_47 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丙丂丒丌且丝一丘专;
        }
        
        }
        
        if(Rilisoft.AbstractGameEventGui.InterfaceEnabled != false)
        {
                val_53 = null;
            val_53 = null;
            val_47 = PGCompany.Analytics.丂与丏丕一丒与丁丙.三丄东丅丁不丒丐丑;
        }
        
        val_54 = null;
        val_54 = null;
        BankView.丗一专业丘丙丟丄万 = val_47;
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), 丁丕丈丏且丕丒丞丏:  true, 世丁丙世丄一万丆三:  val_47);
        return;
        label_19:
        val_43 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘();
        label_18:
        val_44 = this.丒世丘丘上丆丝东丞;
        if((((val_43.丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业())) - val_44.丟丂丞不专丆万丒世()) & 2147483648) != 0)
        {
            goto label_86;
        }
        
        label_23:
        if(this.与丟丁七丟专业一丅 == false)
        {
            goto label_87;
        }
        
        label_114:
        if(this.七丒上且丝业业下七 != null)
        {
                this.七丒上且丝业业下七.Invoke();
        }
        
        if(0 == 0)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_87:
        if((this.七丒上且丝业业下七 == null) || (this.丝与丙丈丑丁七且丐 == 0))
        {
            goto label_94;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  this.丝与丙丈丑丁七且丐);
        if(this.与丟丁七丟专业一丅 == true)
        {
            goto label_114;
        }
        
        goto label_99;
        label_94:
        label_99:
        if((System.String.op_Equality(a:  this.丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  "DetailsCurrency")) == false)
        {
            goto label_101;
        }
        
        Rilisoft.丕七东丗丁丐丂三下.丆东上且丟丌业丗与(丒东业不丐丑丕丄丆:  this.三不三丟专丘东东丂, 丌丒丝东丌下丕丁丅:  -this.丒世丘丘上丆丝东丞.丟丂丞不专丆万丒世(), 与丘万三东一丄丄丙:  true);
        goto label_114;
        label_31:
        object[] val_41 = new object[1];
        val_41[0] = this.三不三丟专丘东东丂;
        UnityEngine.Debug.LogErrorFormat(format:  "Can not show buy details window with inactive Shop for weapon {0}", args:  val_41);
        return;
        label_101:
        bool val_42 = BankController.丈专丄丐专丗专与丙(丒世丘丘上丆丝东丞:  this.丒世丘丘上丆丝东丞, 不丐下上且万丈七丒:  true, 世丁丙世丄一万丆三:  this.丐丈上丂与上丂丒丏);
        goto label_114;
    }

}
