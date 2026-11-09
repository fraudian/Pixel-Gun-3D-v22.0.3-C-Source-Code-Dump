using UnityEngine;
internal sealed class 丈万且丗丂丝丙一东
{
    // Fields
    public string 丒丘丏上丙丟丑丕丈;
    public int 丌与三与三丆丙一丟;
    public int 丈一七上丛丗丄丘丞;
    public int 专世专丟丝丌与丘上;
    public int 万且丒下丕丝专丟上;
    public int 丅丘丈丒万世三世丕;
    public string 丆世丘丒丒丏上且丗;
    internal bool 一七不三丌专三丆一;
    internal bool 万丗不丑七丟丒丆丙;
    internal bool 专丛下不丄且丌丛丕;
    internal bool 万业丌丏丟丂丘丝且;
    public UnityEngine.Texture 丅丈丛丅丝东七丂且;
    public UnityEngine.Texture 丂丒丘丅专丗丂世丛;
    public string 与丟丅七丞且且丛丕;
    public bool 专丞专丆丄丛丞三丕;
    public double 七一一丘下丈专与且;
    public bool 丄三专丕丛丘世丆专;
    public double 丂丝丈丙丞丝三丂一;
    internal NetworkStartTable 不且上一上丐三万丛;
    public string 丛丆不丆七丅丑上丟;
    
    // Properties
    public bool 丒东三丌专丗三丂丟 { get; }
    public bool 丌且下丕下下丌万丞 { get; }
    
    // Methods
    internal 丈万且丗丂丝丙一东(NetworkStartTable 不且上一上丐三万丛)
    {
        this.专世专丟丝丌与丘上 = 1;
        this.丒丘丏上丙丟丑丕丈 = "";
        this.丆世丘丒丒丏上且丗 = "";
        this.丛丆不丆七丅丑上丟 = "";
        this.丑七下业与丕丛丅丕(不且上一上丐三万丛:  不且上一上丐三万丛);
    }
    public bool 万丌丏丘丂丈丗丅丂()
    {
        this.与丁七三万丛万丘丌();
        return (bool)this.专丞专丆丄丛丞三丕;
    }
    public bool 丟丌下三七丁与丟丑()
    {
        null = null;
        if(this.不且上一上丐三万丛 != null)
        {
                return this.不且上一上丐三万丛.Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable);
        }
        
        return this.不且上一上丐三万丛.Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable);
    }
    internal void 丑七下业与丕丛丅丕(NetworkStartTable 不且上一上丐三万丛)
    {
        object val_39;
        var val_40;
        int val_41;
        int val_42;
        var val_43;
        int val_44;
        var val_45;
        var val_46;
        var val_47;
        System.Func<NetworkStartTable, PhotonView> val_49;
        var val_50;
        System.Func<PhotonView, 与丅丕丈丘东丝世丟> val_52;
        var val_53;
        System.Func<与丅丕丈丘东丝世丟, ExitGames.Client.Photon.Hashtable> val_55;
        var val_56;
        var val_57;
        string val_58;
        var val_59;
        bool val_60;
        bool val_61;
        val_40 = 1152921504848912384;
        if(不且上一上丐三万丛 == 0)
        {
                return;
        }
        
        this.不且上一上丐三万丛 = 不且上一上丐三万丛;
        if(不且上一上丐三万丛 == null)
        {
            goto label_4;
        }
        
        this.丒丘丏上丙丟丑丕丈 = 不且上一上丐三万丛.丂丈丐不丏万三七丐;
        if(不且上一上丐三万丛.丑丛丆三丆丄七丐万() == 1)
        {
            goto label_5;
        }
        
        label_7:
        val_41 = 不且上一上丐三万丛;
        int val_3 = val_41.丑丛丆三丆丄七丐万();
        goto label_6;
        label_4:
        this.丒丘丏上丙丟丑丕丈 = 8;
        if(0.丑丛丆三丆丄七丐万() != 1)
        {
            goto label_7;
        }
        
        label_5:
        val_41 = 不且上一上丐三万丛.不丝丛丘与丁万丟丈;
        label_6:
        this.丌与三与三丆丙一丟 = val_41;
        if(不且上一上丐三万丛 == null)
        {
            goto label_8;
        }
        
        if(不且上一上丐三万丛.丘不丄一丒丆丒丅万() == 1)
        {
            goto label_9;
        }
        
        label_11:
        val_42 = 不且上一上丐三万丛;
        int val_6 = val_42.丘不丄一丒丆丒丅万();
        goto label_10;
        label_8:
        if(0.丘不丄一丒丆丒丅万() != 1)
        {
            goto label_11;
        }
        
        label_9:
        val_42 = 不且上一上丐三万丛.且不丗丏丌丅与丆丕;
        label_10:
        this.丈一七上丛丗丄丘丞 = val_42;
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_14;
        }
        
        val_43 = null;
        val_43 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        label_18:
        var val_9 = (null == null) ? GameController.onlineMode : 0;
        this.丅丘丈丒万世三世丕 = UnityEngine.Mathf.Clamp(value:  不且上一上丐三万丛.丁丄一且丐丑丝丕丄(), min:  1, max:  onlineMode == null ? GameController.onlineMode : 0 + 536.MaxLevel);
        label_14:
        if(不且上一上丐三万丛 == null)
        {
            goto label_23;
        }
        
        if(不且上一上丐三万丛.丝丈丅一丆丗丝丝丘() == 1)
        {
            goto label_24;
        }
        
        label_26:
        val_44 = 不且上一上丐三万丛;
        int val_14 = val_44.丝丈丅一丆丗丝丝丘();
        goto label_25;
        label_23:
        if(0.丝丈丅一丆丗丝丝丘() != 1)
        {
            goto label_26;
        }
        
        label_24:
        val_44 = 不且上一上丐三万丛.丕丑丌丛丗东三七丈;
        label_25:
        this.万且丒下丕丝专丟上 = val_44;
        if(不且上一上丐三万丛 != null)
        {
                this.专世专丟丝丌与丘上 = 不且上一上丐三万丛.下东且丐丆丅丁世丟;
            this.丆世丘丒丒丏上且丗 = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
            this.一七不三丌专三丆一 = 不且上一上丐三万丛.一七不三丌专三丆一;
        }
        else
        {
                this.专世专丟丝丌与丘上 = 2;
            this.丆世丘丒丒丏上且丗 = 36;
            this.一七不三丌专三丆一 = false;
        }
        
        if(不且上一上丐三万丛.丌丑丛业丈丘世丞丕 != 0)
        {
                this.万丗不丑七丟丒丆丙 = 不且上一上丐三万丛.丌丑丛业丈丘世丞丕.丄丝丝下丟丘丄丒丈();
        }
        
        if(((this.专丛下不丄且丌丛丕 != true) && (GameConnect.丙丌丒丈东七丒上丌() != false)) && (不且上一上丐三万丛.丟东丘丏上世且上丕() != false))
        {
                val_45 = null;
            val_45 = null;
            if(GameController.onlineMode != null)
        {
                val_40 = 1152921505192681472;
            var val_21 = (null == null) ? GameController.onlineMode : 0;
        }
        
            if(0.三丘三丈上丕丆丂一() != 0)
        {
                val_46 = null;
            val_46 = null;
            if(GameController.onlineMode != null)
        {
                var val_23 = (null == null) ? GameController.onlineMode : 0;
        }
        
            if(0.三丘三丈上丕丆丂一() != 1)
        {
                this.专丛下不丄且丌丛丕 = true;
        }
        
        }
        
        }
        
        if((this.万业丌丏丟丂丘丝且 != true) && (GameConnect.丄丏丒丏上东业丒一() != false))
        {
                if(不且上一上丐三万丛.丟世一丛万一与丂丏() != true)
        {
                this.万业丌丏丟丂丘丝且 = true;
        }
        
        }
        
        this.丅丈丛丅丝东七丂且 = 不且上一上丐三万丛.丏丅业丞丁丌丈与丆;
        this.丂丒丘丅专丗丂世丛 = 不且上一上丐三万丛.丌丏丞丆丗与东丗业;
        this.与丟丅七丞且且丛丕 = 不且上一上丐三万丛.三丆丛丁丞丘丂三丞;
        val_47 = null;
        val_47 = null;
        val_49 = 丈万且丗丂丝丙一东.<>c.<>9__25_0;
        if(val_49 == null)
        {
                System.Func<NetworkStartTable, PhotonView> val_27 = null;
            val_49 = val_27;
            val_27 = new System.Func<NetworkStartTable, PhotonView>(object:  丈万且丗丂丝丙一东.<>c.__il2cppRuntimeField_static_fields, method:  PhotonView 丈万且丗丂丝丙一东.<>c::丆万丁丙丝下七三丁(NetworkStartTable 三丟东丕丄丄下下丑));
            丈万且丗丂丝丙一东.<>c.<>9__25_0 = val_49;
        }
        
        val_50 = null;
        val_50 = null;
        val_52 = 丈万且丗丂丝丙一东.<>c.<>9__25_1;
        if(val_52 == null)
        {
                System.Func<PhotonView, 与丅丕丈丘东丝世丟> val_29 = null;
            val_52 = val_29;
            val_29 = new System.Func<PhotonView, 与丅丕丈丘东丝世丟>(object:  丈万且丗丂丝丙一东.<>c.__il2cppRuntimeField_static_fields, method:  与丅丕丈丘东丝世丟 丈万且丗丂丝丙一东.<>c::丞一丙丄丌丆世丈丞(PhotonView 三丟东丕丄丄下下丑));
            丈万且丗丂丝丙一东.<>c.<>9__25_1 = val_52;
        }
        
        val_53 = null;
        val_53 = null;
        val_55 = 丈万且丗丂丝丙一东.<>c.<>9__25_2;
        if(val_55 == null)
        {
                System.Func<与丅丕丈丘东丝世丟, ExitGames.Client.Photon.Hashtable> val_31 = null;
            val_55 = val_31;
            val_31 = new System.Func<与丅丕丈丘东丝世丟, ExitGames.Client.Photon.Hashtable>(object:  丈万且丗丂丝丙一东.<>c.__il2cppRuntimeField_static_fields, method:  ExitGames.Client.Photon.Hashtable 丈万且丗丂丝丙一东.<>c::丏丐丐丌丂丟丐东不(与丅丕丈丘东丝世丟 三丟东丕丄丄下下丑));
            丈万且丗丂丝丙一东.<>c.<>9__25_2 = val_55;
        }
        
        val_39 = 丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<ExitGames.Client.Photon.Hashtable, 与丅丕丈丘东丝世丟>(丞下万上三丘上与专:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<与丅丕丈丘东丝世丟, PhotonView>(丞下万上三丘上与专:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<PhotonView, NetworkStartTable>(丞下万上三丘上与专:  不且上一上丐三万丛, 丏丅丁丛一业丈专专:  val_27), 丏丅丁丛一业丈专专:  val_29), 丏丅丁丛一业丈专专:  val_31);
        if(val_39 != null)
        {
                val_56 = null;
            val_56 = null;
            if((val_39.ContainsKey(key:  GameConnect.与丈业东丂丘丅三丙)) != false)
        {
                val_57 = null;
            val_57 = null;
            val_39 = val_39.Item[GameConnect.与丈业东丂丘丅三丙];
            string val_35 = System.Convert.ToString(value:  val_39);
        }
        else
        {
                val_58 = "";
        }
        
            this.丛丆不丆七丅丑上丟 = val_58;
        }
        
        this.与丁七三万丛万丘丌();
        if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_90;
        }
        
        }
        
        val_59 = this;
        val_60 = this.丄三专丕丛丘世丆专;
        if(val_60 == false)
        {
            goto label_91;
        }
        
        val_60 = 1;
        val_61 = 1;
        goto label_93;
        label_91:
        val_61 = 不且上一上丐三万丛.丅上与上丄且不丈东;
        goto label_93;
        label_90:
        val_59 = this;
        val_60 = this.丄三专丕丛丘世丆专;
        val_61 = false;
        label_93:
        if(val_61 == val_60)
        {
                return;
        }
        
        this.丄三专丕丛丘世丆专 = val_61;
        if(val_61 != 0)
        {
                double val_38 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        }
        
        this.丂丝丈丙丞丝三丂一 = 0;
    }
    public void 与丁七三万丛万丘丌()
    {
        if(this.不且上一上丐三万丛 != 0)
        {
            goto label_7;
        }
        
        if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_30;
        }
        
        if(this.丟丌下三七丁与丟丑() != true)
        {
                if(this.丄三专丕丛丘世丆专 == false)
        {
            goto label_30;
        }
        
        }
        
        label_7:
        if(this.不且上一上丐三万丛.与丛下丐丆丞万万下 == false)
        {
            goto label_10;
        }
        
        label_30:
        label_39:
        if(true == this.专丞专丆丄丛丞三丕)
        {
                return;
        }
        
        this.专丞专丆丄丛丞三丕 = true;
        if(true == 0)
        {
            goto label_12;
        }
        
        double val_4 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        goto label_15;
        label_10:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.不且上一上丐三万丛.丏且丞丏丞世丈丕专() == true)
        {
            goto label_30;
        }
        
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.不且上一上丐三万丛.丌丑丛业丈丘世丞丕 != 0)
        {
                if(this.不且上一上丐三万丛.丌丑丛业丈丘世丞丕.万丝一万丐且丌业丛 == true)
        {
            goto label_30;
        }
        
        }
        
        }
        
        if((GameConnect.丙丌丒丈东七丒上丌() == false) || (this.不且上一上丐三万丛 == 0))
        {
            goto label_39;
        }
        
        var val_12 = ~this.不且上一上丐三万丛.丑丈上东丗丐丆世上();
        val_12 = val_12 & 1;
        goto label_39;
        label_12:
        label_15:
        this.七一一丘下丈专与且 = 0;
    }
    internal int 一丒业三万七业丌七()
    {
        null = null;
        return UnityEngine.Mathf.Max(a:  0, b:  this.万且丒下丕丝专丟上 - (DungeonsController.丄丑且丂丘七丈下丝 * this.丈一七上丛丗丄丘丞));
    }

}
