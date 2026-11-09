using UnityEngine;
public class 且下丙业丌与丕且丑
{
    // Fields
    internal bool 丑丟业丛丐丅三下与;
    private float 不下三丒且下七丂丟;
    
    // Methods
    internal void 丞丝不丟丈丗丌东丘()
    {
        bool val_37;
        var val_38;
        var val_39;
        int val_40;
        var val_41;
        string val_42;
        var val_43;
        int val_44;
        var val_45;
        var val_46;
        var val_47;
        string val_48;
        var val_49;
        var val_50;
        int val_51;
        var val_52;
        var val_53;
        val_37 = this;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
                return;
        }
        
        float val_4 = UnityEngine.Time.time;
        if(this.不下三丒且下七丂丟 >= 0)
        {
                return;
        }
        
        float val_5 = UnityEngine.Time.time;
        val_5 = val_5 + 7f;
        this.不下三丒且下七丂丟 = val_5;
        val_38 = null;
        val_38 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丛上世丏丑世不丕三)) == false)
        {
            goto label_17;
        }
        
        val_39 = null;
        ExitGames.Client.Photon.Hashtable val_36 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_39 = null;
        object val_11 = val_36.Item[GameConnect.丛上世丏丑世不丕三];
        if(val_11 == null)
        {
            goto label_24;
        }
        
        val_36 = (null == null) ? (val_11) : 0;
        goto label_26;
        label_17:
        val_40 = System.String.alignConst;
        goto label_26;
        label_24:
        val_40 = 0;
        label_26:
        val_41 = null;
        val_41 = null;
        val_42 = GameConnect.丁丈丅丑丘丂丄丟世;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_42)) == false)
        {
            goto label_33;
        }
        
        val_43 = null;
        ExitGames.Client.Photon.Hashtable val_37 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_43 = null;
        val_42 = GameConnect.丁丈丅丑丘丂丄丟世;
        object val_17 = val_37.Item[val_42];
        if(val_17 == null)
        {
            goto label_40;
        }
        
        val_37 = (null == null) ? (val_17) : 0;
        goto label_42;
        label_33:
        val_44 = System.String.alignConst;
        goto label_42;
        label_40:
        val_44 = 0;
        label_42:
        val_37 = System.String.IsNullOrEmpty(value:  val_40);
        bool val_19 = val_37 ^ 1;
        bool val_20 = System.String.IsNullOrEmpty(value:  val_44);
        val_44 = val_20 ^ 1;
        if(val_19 != true)
        {
                if(val_44 == false)
        {
                return;
        }
        
        }
        
        val_45 = 0;
        val_46 = 0;
        val_37 = 0;
        goto label_45;
        label_69:
        与丅丕丈丘东丝世丟 val_38 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0];
        val_47 = null;
        val_47 = null;
        val_48 = GameConnect.三丌不七丛上丝丂世;
        if((val_38.丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_48)) == false)
        {
            goto label_54;
        }
        
        if((val_19 & (~val_37)) != false)
        {
                val_49 = null;
            val_49 = null;
            val_48 = GameConnect.三丌不七丛上丝丂世;
            object val_26 = val_38.丑丗三丛丛丆丟丌丆().Item[val_48];
            val_37 = val_37 | ((null == 1) ? 1 : 0);
        }
        
        if((val_44 & (~val_46)) != false)
        {
                val_50 = null;
            val_50 = null;
            object val_30 = val_38.丑丗三丛丛丆丟丌丆().Item[GameConnect.三丌不七丛上丝丂世];
            val_46 = val_46 | ((null == 2) ? 1 : 0);
        }
        
        val_51 = val_37 & val_46;
        if((val_51 & 1) != 0)
        {
            goto label_65;
        }
        
        label_54:
        val_45 = 1;
        label_45:
        与丅丕丈丘东丝世丟[] val_32 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        val_51 = val_32.Length;
        if(val_45 < val_51)
        {
            goto label_69;
        }
        
        goto label_70;
        label_65:
        val_46 = 1;
        val_37 = 1;
        label_70:
        val_42 = val_20 ^ val_46;
        bool val_33 = val_37 ^ val_37;
        if((val_42 != false) && (val_33 != false))
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_34 = new ExitGames.Client.Photon.Hashtable();
        if(val_33 != true)
        {
                val_52 = null;
            val_52 = null;
            val_34.set_Item(key:  GameConnect.丛上世丏丑世不丕三, value:  "");
        }
        
        if(val_42 != true)
        {
                val_53 = null;
            val_53 = null;
            val_34.set_Item(key:  GameConnect.丁丈丅丑丘丂丄丟世, value:  "");
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_34, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丌万丐丌丗丐万丒业()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        string val_28;
        var val_29;
        int val_1 = this.丑丆丛专丟业丏丈七();
        if(val_1 == 1)
        {
            goto label_1;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_19 = null;
        val_19 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丛上世丏丑世不丕三)) != false)
        {
                val_20 = null;
            val_20 = null;
            val_21 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_2.set_Item(key:  GameConnect.丛上世丏丑世不丕三, value:  val_21.Item[GameConnect.丛上世丏丑世不丕三]);
        }
        
        val_22 = null;
        val_22 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丁丈丅丑丘丂丄丟世)) != false)
        {
                val_23 = null;
            val_23 = null;
            val_21 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_2.set_Item(key:  GameConnect.丁丈丅丑丘丂丄丟世, value:  val_21.Item[GameConnect.丁丈丅丑丘丂丄丟世]);
        }
        
        ExitGames.Client.Photon.Hashtable val_15 = new ExitGames.Client.Photon.Hashtable();
        val_24 = null;
        if(val_1 != 1)
        {
            goto label_30;
        }
        
        val_25 = null;
        val_26 = 1152921505323884544;
        val_27 = null;
        val_28 = GameConnect.丛上世丏丑世不丕三;
        goto label_38;
        label_1:
        this.丑丟业丛丐丅三下与 = false;
        return;
        label_30:
        val_29 = null;
        val_26 = 1152921505323884544;
        val_27 = null;
        val_28 = GameConnect.丁丈丅丑丘丂丄丟世;
        label_38:
        val_15.set_Item(key:  val_28, value:  SquadController.万一丘丗三三丈丗丛);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_15, 丒不一专上专丌丈东:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆(), 丅丞丏丈且专丆不丟:  false);
    }
    internal void 且丗上丗丗上三专丑()
    {
        var val_19;
        var val_20;
        int val_21;
        var val_22;
        var val_23;
        int val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        this.丑丟业丛丐丅三下与 = true;
        val_19 = null;
        val_19 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丛上世丏丑世不丕三)) == false)
        {
            goto label_7;
        }
        
        val_20 = null;
        ExitGames.Client.Photon.Hashtable val_19 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_20 = null;
        object val_6 = val_19.Item[GameConnect.丛上世丏丑世不丕三];
        if(val_6 == null)
        {
            goto label_14;
        }
        
        val_19 = (null == null) ? (val_6) : 0;
        goto label_16;
        label_7:
        val_21 = System.String.alignConst;
        goto label_16;
        label_14:
        val_21 = 0;
        label_16:
        val_22 = null;
        val_22 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丁丈丅丑丘丂丄丟世)) == false)
        {
            goto label_23;
        }
        
        val_23 = null;
        ExitGames.Client.Photon.Hashtable val_20 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_23 = null;
        object val_12 = val_20.Item[GameConnect.丁丈丅丑丘丂丄丟世];
        if(val_12 == null)
        {
            goto label_30;
        }
        
        val_20 = (null == null) ? (val_12) : 0;
        goto label_32;
        label_23:
        val_24 = System.String.alignConst;
        goto label_32;
        label_30:
        val_24 = 0;
        label_32:
        val_25 = null;
        val_25 = null;
        if((System.String.op_Equality(a:  val_21, b:  SquadController.万一丘丗三三丈丗丛)) == true)
        {
            goto label_35;
        }
        
        val_26 = null;
        val_26 = null;
        if((System.String.op_Equality(a:  val_24, b:  SquadController.万一丘丗三三丈丗丛)) == false)
        {
            goto label_38;
        }
        
        label_35:
        val_27 = null;
        val_27 = null;
        ExitGames.Client.Photon.Hashtable val_17 = new ExitGames.Client.Photon.Hashtable();
        val_28 = null;
        val_28 = null;
        val_17.Add(key:  GameConnect.三丌不七丛上丝丂世, value:  (((System.String.op_Equality(a:  val_21, b:  SquadController.万一丘丗三三丈丗丛)) & true) != 0) ? (1 + 1) : 1);
        丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_17, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        this.丑丟业丛丐丅三下与 = false;
        return;
        label_38:
        this.丌万丐丌丗丐万丒业();
    }
    private int 丑丆丛专丟业丏丈七()
    {
        var val_27;
        var val_28;
        int val_29;
        var val_30;
        string val_31;
        var val_32;
        int val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        val_27 = null;
        val_27 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丛上世丏丑世不丕三)) == false)
        {
            goto label_7;
        }
        
        val_28 = null;
        ExitGames.Client.Photon.Hashtable val_27 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_28 = null;
        object val_6 = val_27.Item[GameConnect.丛上世丏丑世不丕三];
        if(val_6 == null)
        {
            goto label_14;
        }
        
        val_27 = (null == null) ? (val_6) : 0;
        goto label_16;
        label_7:
        val_29 = System.String.alignConst;
        goto label_16;
        label_14:
        val_29 = 0;
        label_16:
        val_30 = null;
        val_30 = null;
        val_31 = GameConnect.丁丈丅丑丘丂丄丟世;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_31)) == false)
        {
            goto label_23;
        }
        
        val_32 = null;
        ExitGames.Client.Photon.Hashtable val_28 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_32 = null;
        val_31 = GameConnect.丁丈丅丑丘丂丄丟世;
        object val_12 = val_28.Item[val_31];
        if(val_12 == null)
        {
            goto label_30;
        }
        
        val_28 = (null == null) ? (val_12) : 0;
        goto label_32;
        label_23:
        val_33 = System.String.alignConst;
        goto label_32;
        label_30:
        val_33 = 0;
        label_32:
        if((System.String.IsNullOrEmpty(value:  val_29)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  val_33)) != false)
        {
                val_34 = 2;
            return (int)val_34;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  val_33)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  val_29)) != false)
        {
                val_34 = 1;
            return (int)val_34;
        }
        
        }
        
        if(((System.String.IsNullOrEmpty(value:  val_29)) == false) || ((System.String.IsNullOrEmpty(value:  val_33)) == false))
        {
            goto label_40;
        }
        
        val_35 = 0;
        val_36 = 0;
        val_37 = 0;
        goto label_41;
        label_60:
        与丅丕丈丘东丝世丟 val_29 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0];
        val_38 = null;
        val_38 = null;
        val_31 = GameConnect.下东三丐七丐一丛业;
        if((val_29.丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_31)) != false)
        {
                val_39 = null;
            val_39 = null;
            object val_23 = val_29.丑丗三丛丛丆丟丌丆().Item[GameConnect.下东三丐七丐一丛业];
            if(null == 1)
        {
                val_37 = 1;
        }
        
        }
        
        val_35 = 1;
        label_41:
        val_29 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_35 < val_25.Length)
        {
            goto label_60;
        }
        
        var val_26 = (val_37 > ((null == 2) ? (val_36 + 1) : (val_36))) ? (1 + 1) : 1;
        return (int)val_34;
        label_40:
        val_34 = 0;
        return (int)val_34;
    }
    public 且下丙业丌与丕且丑()
    {
    
    }

}
