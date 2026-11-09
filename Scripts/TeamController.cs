using UnityEngine;
internal sealed class TeamController : MonoBehaviour
{
    // Fields
    internal System.Collections.Generic.List<Player_move_c> firstTeamPlayers;
    internal System.Collections.Generic.List<Player_move_c> secondTeamPlayers;
    internal System.Collections.Generic.List<NetworkStartTable> firstTeamTables;
    internal System.Collections.Generic.List<NetworkStartTable> secondTeamTables;
    internal int 丁业一丛且万丛丕丑;
    internal int 下丏东丌丗丈专丙丄;
    internal float 丙丞丏丅丒丝丅不丒;
    internal float 业七三丛丑丗且丐丑;
    private 丒东丂万与不七丘丑 与上上丄七丘丕丗丂;
    
    // Properties
    internal System.Collections.Generic.List<NetworkStartTable> 七丁业丛世且且丙丈 { get; }
    internal System.Collections.Generic.List<NetworkStartTable> 丆丁一丅丁丈万且丌 { get; }
    internal int 不丌丝丑丅丕且一下 { get; }
    internal int 丏三丕东丁业丒丏七 { get; }
    internal int 丕丄一一下丘丑丌丕 { get; }
    internal int 丑丘丂丁丈下七一世 { get; }
    
    // Methods
    private void Awake()
    {
        丒东丂万与不七丘丑 val_2 = 与丅丄专三丂丏丐丝.下丙丗丟丂下丏不丟(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业());
        this.与上上丄七丘丕丗丂 = val_2;
        if(val_2 == null)
        {
                return;
        }
        
        this = ???;
        goto typeof(丒东丂万与不七丘丑).__il2cppRuntimeField_168;
    }
    private void OnDestroy()
    {
        if(this.与上上丄七丘丕丗丂 == null)
        {
                return;
        }
        
        goto typeof(丒东丂万与不七丘丑).__il2cppRuntimeField_178;
    }
    internal System.Collections.Generic.List<NetworkStartTable> 业不丟丞与丐三丘丒()
    {
        var val_4;
        System.Collections.Generic.List<NetworkStartTable> val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return val_5;
        }
        
        val_6 = null;
        val_6 = null;
        if(丘丑丅三丆丑丌且丝() < 1)
        {
            goto label_11;
        }
        
        val_7 = null;
        val_7 = null;
        if(丘丑丅三丆丑丌且丝() != 1)
        {
            goto label_16;
        }
        
        val_5 = this.firstTeamTables;
        return val_5;
        label_11:
        val_5 = 0;
        return val_5;
        label_16:
        val_5 = this.secondTeamTables;
        return val_5;
    }
    internal System.Collections.Generic.List<NetworkStartTable> 业丅丟丄丐且丁丘丙()
    {
        var val_4;
        System.Collections.Generic.List<NetworkStartTable> val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return val_5;
        }
        
        val_6 = null;
        val_6 = null;
        if(丘丑丅三丆丑丌且丝() < 1)
        {
            goto label_11;
        }
        
        val_7 = null;
        val_7 = null;
        if(丘丑丅三丆丑丌且丝() != 1)
        {
            goto label_16;
        }
        
        val_5 = this.secondTeamTables;
        return val_5;
        label_11:
        val_5 = 0;
        return val_5;
        label_16:
        val_5 = this.firstTeamTables;
        return val_5;
    }
    internal int 丙东业一丅丒一丛一()
    {
        int val_2 = this.万丈不上丆丐七专业();
        val_2 = val_2 + this.上业丕与丘与七丐上();
        return (int)val_2;
    }
    internal int 丄丒与丈不丂业下丕()
    {
        int val_2 = this.secondTeamTables.Count;
        val_2 = val_2 + this.firstTeamTables.Count;
        return (int)val_2;
    }
    internal int 上业丕与丘与七丐上()
    {
        if(this.firstTeamPlayers != null)
        {
                return this.firstTeamPlayers.Count;
        }
        
        return this.firstTeamPlayers.Count;
    }
    internal int 万丈不上丆丐七专业()
    {
        if(this.secondTeamPlayers != null)
        {
                return this.secondTeamPlayers.Count;
        }
        
        return this.secondTeamPlayers.Count;
    }
    internal bool 业业丝丘七丗丗丈丏()
    {
        System.Collections.Generic.List<Player_move_c> val_4;
        var val_5;
        val_4 = this;
        if(this.firstTeamPlayers.Count != 0)
        {
                val_4 = this.secondTeamPlayers;
            var val_3 = (val_4.Count == 0) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 1;
        return (bool)val_5;
    }
    internal bool 丗丌丆丙丗上丁丌丁()
    {
        return false;
    }
    internal void 上丙上丈三丐丞丛专(Player_move_c 专丞上七七且丝七丗, int 下丄丁丑三丏丗丛七)
    {
        int val_7 = 下丄丁丑三丏丗丛七;
        if((val_7 == 2) && ((this.firstTeamPlayers.Contains(item:  专丞上七七且丝七丗)) != false))
        {
                bool val_2 = this.firstTeamPlayers.Remove(item:  专丞上七七且丝七丗);
        }
        
        if((val_7 != 1) || ((this.secondTeamPlayers.Contains(item:  专丞上七七且丝七丗)) == false))
        {
            goto label_7;
        }
        
        bool val_4 = this.secondTeamPlayers.Remove(item:  专丞上七七且丝七丗);
        goto label_9;
        label_7:
        if(val_7 == 2)
        {
            goto label_10;
        }
        
        if(val_7 != 1)
        {
                return;
        }
        
        label_9:
        val_7 = this.firstTeamPlayers;
        if((val_7.Contains(item:  专丞上七七且丝七丗)) != false)
        {
                return;
        }
        
        if(this.firstTeamPlayers != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        this.firstTeamPlayers.Add(item:  专丞上七七且丝七丗);
        return;
        label_10:
        if((this.secondTeamPlayers.Contains(item:  专丞上七七且丝七丗)) == true)
        {
                return;
        }
        
        if(this.secondTeamPlayers != null)
        {
            goto label_17;
        }
        
        goto label_18;
    }
    public void RemovePlayer(Player_move_c 专丞上七七且丝七丗)
    {
        if((this.firstTeamPlayers.Contains(item:  专丞上七七且丝七丗)) != false)
        {
                bool val_2 = this.firstTeamPlayers.Remove(item:  专丞上七七且丝七丗);
        }
        
        if((this.secondTeamPlayers.Contains(item:  专丞上七七且丝七丗)) == false)
        {
                return;
        }
        
        bool val_4 = this.secondTeamPlayers.Remove(item:  专丞上七七且丝七丗);
    }
    internal void 丟丞丗上丂世丄与丞()
    {
        this.丁业一丛且万丛丕丑 = 0;
        this.下丏东丌丗丈专丙丄 = 0;
        this.丙丞丏丅丒丝丅不丒 = 0f;
        this.业七三丛丑丗且丐丑 = 0f;
    }
    internal void 丗丘丞丏下丝丐丛丛()
    {
        this.丏丅丅丘上丆业丂丟();
    }
    private void 丏丅丅丘上丆业丂丟()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        System.Collections.Generic.List<NetworkStartTable> val_11;
        var val_12;
        this.firstTeamTables.Clear();
        this.secondTeamTables.Clear();
        val_7 = 0;
        goto label_3;
        label_27:
        val_8 = null;
        val_8 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() >= 1)
        {
                val_9 = null;
            val_9 = null;
            if(Item[0].丘丑丅三丆丑丌且丝() == 1)
        {
                val_10 = null;
            val_11 = this.firstTeamTables;
        }
        else
        {
                val_10 = null;
            val_11 = this.secondTeamTables;
            val_10 = null;
        }
        
            val_11.Add(item:  Item[0]);
        }
        
        val_7 = 1;
        label_3:
        val_12 = null;
        val_12 = null;
        if(val_7 < Count)
        {
            goto label_27;
        }
    
    }
    internal void 丙一丐一丂且万丆丙(int 丗丈世万东万丒丐东, int 丕丘丌丕下专丕丘丏)
    {
        this.丁业一丛且万丛丕丑 = 丗丈世万东万丒丐东;
        this.下丏东丌丗丈专丙丄 = 丕丘丌丕下专丕丘丏;
        this.丙丞丏丅丒丝丅不丒 = (float)丗丈世万东万丒丐东;
        this.业七三丛丑丗且丐丑 = (float)丕丘丌丕下专丕丘丏;
    }
    public TeamController()
    {
        this.firstTeamPlayers = new System.Collections.Generic.List<Player_move_c>();
        this.secondTeamPlayers = new System.Collections.Generic.List<Player_move_c>();
        this.firstTeamTables = new System.Collections.Generic.List<NetworkStartTable>();
        this.secondTeamTables = new System.Collections.Generic.List<NetworkStartTable>();
    }

}
