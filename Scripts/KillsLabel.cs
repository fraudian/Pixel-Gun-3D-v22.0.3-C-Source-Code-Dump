using UnityEngine;
internal sealed class KillsLabel : MonoBehaviour
{
    // Fields
    private UILabel 一丙且丛丟丈丙且与;
    private InGameGUI 三专丆丙东丏不东丑;
    private System.Collections.Generic.KeyValuePair<int, string> 丗业丆与万丐上丒丌;
    
    // Methods
    private void Start()
    {
        var val_13;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_13 = null;
        val_13 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        if((((((GameConnect.丑丌丛丈丅丅与不业() != 10) && (GameConnect.丑丌丛丈丅丅与不业() != 8)) && (GameConnect.丑丌丛丈丅丅与不业() != 0)) && (GameConnect.东且三丆丑世世丘丟() != true)) && (GameConnect.且丞丁东丝丗上丈业() != true)) && (GameConnect.东丒七专丂世丝丏丗() != true))
        {
                if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_27;
        }
        
        }
        
        }
        
        if(val_1 != null)
        {
            goto label_33;
        }
        
        label_34:
        label_33:
        val_1.SetActive(value:  true);
        this.一丙且丛丟丈丙且与 = this.GetComponent<UILabel>();
        this.三专丆丙东丏不东丑 = InGameGUI.丙丞专丌丁丞与不丐;
        return;
        label_3:
        if(val_1 != null)
        {
            goto label_33;
        }
        
        goto label_34;
        label_27:
        bool val_12 = GameConnect.一业上七丟业且业丙();
        if(val_1 != null)
        {
            goto label_33;
        }
        
        goto label_34;
    }
    private void Update()
    {
        UILabel val_17;
        var val_18;
        var val_19;
        var val_20;
        val_17 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.三专丆丙东丏不东丑)) == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.一丙且丛丟丈丙且与)) == false)
        {
                return;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 8)
        {
            goto label_12;
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        label_24:
        label_44:
        this.一丙且丛丟丈丙且与.text = this.下丛上丌丗三下丑一(丌与三与三丆丙一丟:  GameController.mode.七丒丘丏业丟丌丄七());
        return;
        label_12:
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_19;
        }
        
        val_19 = null;
        val_19 = null;
        string val_10 = System.String.Format(format:  "{0}%", arg0:  this.下丛上丌丗三下丑一(丌与三与三丆丙一丟:  丏下丙丘丄专丘上三()));
        goto label_24;
        label_19:
        if(GameConnect.一业上七丟业且业丙() != false)
        {
                val_17 = this.一丙且丛丟丈丙且与;
            val_20 = null;
            val_20 = null;
            val_17.text = +丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
            return;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() == true)
        {
                return;
        }
        
        if(this.三专丆丙东丏不东丑 == 0)
        {
                return;
        }
        
        if(this.三专丆丙东丏不东丑.killsToMaxKills == null)
        {
                return;
        }
        
        string val_16 = this.三专丆丙东丏不东丑.killsToMaxKills.Invoke();
        if(this.一丙且丛丟丈丙且与 != null)
        {
            goto label_44;
        }
        
        goto label_44;
    }
    private string 下丛上丌丗三下丑一(int 丌与三与三丆丙一丟)
    {
        if(this.丗业丆与万丐上丒丌.丙东专丂世丈丏丁丂() == 丌与三与三丆丙一丟)
        {
                return (string)this.丗业丆与万丐上丒丌;
        }
        
        string val_2 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丌与三与三丆丙一丟);
        this.丗业丆与万丐上丒丌 = 0;
        mem[1152921530789186016] = 0;
        return (string)this.丗业丆与万丐上丒丌;
    }
    public KillsLabel()
    {
        this.丗业丆与万丐上丒丌 = 0;
        mem[1152921530789302112] = 0;
    }

}
