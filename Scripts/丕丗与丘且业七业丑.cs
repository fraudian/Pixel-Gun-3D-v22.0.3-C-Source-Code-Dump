using UnityEngine;
private sealed class Player_move_c.丕丗与丘且业七业丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丕丗与丘且业七业丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_24;
        int val_25;
        var val_26;
        PlayerScoreController val_27;
        System.Func<System.Boolean> val_28;
        var val_29;
        var val_30;
        val_24 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_55;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_4;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_24 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_25 = 1;
        this.丒上七丌业七丟与丐 = val_24;
        this.丗丏丅丕丆世丁专丟 = val_25;
        return (bool)val_25;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        bool val_24 = this.丝且与丝丒丟万丁专.丁丕丕七丙东丌且丛;
        val_24 = val_24 + 7;
        var val_25 = ~val_24;
        val_25 = val_25 & 7;
        if(val_25 != 0)
        {
            goto label_55;
        }
        
        if(((((((GameConnect.丆丕丒与丂七与下上() == true) || (GameConnect.与丈丘丈上丌丝丝丛() == true)) || (GameConnect.丙丘不世专且万丄丐() == true)) || (GameConnect.万不丒丌丙万丗东不() == true)) || (GameConnect.丁丁丗丐东丄丞一丛() == true)) || (GameConnect.且丘丄丛下丆丟万丕() == true)) || (GameConnect.一业上七丟业且业丙() == true))
        {
            goto label_33;
        }
        
        val_26 = null;
        val_26 = null;
        if(丝丈丅一丆丗丝丝丘() < 1)
        {
            goto label_33;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_36;
        }
        
        val_27 = this.丝且与丝丒丟万丁专.myScoreController;
        val_28 = this.丝且与丝丒丟万丁专.丟三丏丅世一丟丟上.且世专不丄丏七下万();
        if(val_28 == false)
        {
            goto label_39;
        }
        
        val_29 = 159;
        goto label_43;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        System.Func<System.Boolean> val_12 = null;
        val_28 = val_12;
        val_12 = new System.Func<System.Boolean>(object:  val_24, method:  System.Boolean Player_move_c::丛下丌丟丗一丆丂万());
        UnityEngine.WaitUntil val_13 = null;
        val_24 = val_13;
        val_13 = new UnityEngine.WaitUntil(predicate:  val_12);
        this.丒上七丌业七丟与丐 = val_24;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_25 = 1;
        return (bool)val_25;
        label_36:
        val_27 = this.丝且与丝丒丟万丁专.myScoreController;
        val_29 = 70;
        goto label_43;
        label_39:
        val_29 = 160;
        label_43:
        val_27.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  160, 专上丝且丂世丛丝丒:  1f);
        label_33:
        if(GameConnect.业丛丛丂一丆丕丗丟() != false)
        {
                WeaponManager val_15 = val_24.丛丒丒与丞丝丄丝丒();
            val_24.丑丛一丌专丞七丞与(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Max(a:  0, b:  val_15.myNetworkStartTable.丑丛丆三丆丄七丐万() - 1));
            WeaponManager val_19 = val_24.丛丒丒与丞丝丄丝丒();
            val_28 = val_24.丂丑丕丛万丛业丞丆();
            val_19.myNetworkStartTable.丆专世丒七丒东丕世(丙业与丙丗丝不丈东:  val_28);
            WeaponManager val_21 = val_24.丛丒丒与丞丝丄丝丒();
            val_21.myNetworkStartTable.专丅世与下丕且且丕(专丞上七七且丝七丗:  0);
        }
        
        if((val_24.丂丑丕丛万丛业丞丆() & 2147483648) == 0)
        {
                val_30 = null;
            val_30 = null;
            val_24 = val_24.丂丑丕丛万丛业丞丆();
            GameController.mode.与丄下丑丈丗三丂丘(丙业与丙丗丝不丈东:  val_24);
        }
        
        label_55:
        val_25 = 0;
        return (bool)val_25;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
