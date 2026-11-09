using UnityEngine;
public class ShaderNameCollector : PGBehaviour
{
    // Fields
    private System.Collections.Generic.Dictionary<string, string> 丑丘丟丈丟丞上上丄;
    
    // Methods
    private void Awake()
    {
        this.丙万万丁丟专业且丌();
    }
    internal void 丙万万丁丟专业且丌()
    {
        this.丑丘丟丈丟丞上上丄.Clear();
        Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  this.丅与丌专丟一丝业三(), 丌专业且丛丏丞丝且:  new System.Action<UnityEngine.Transform>(object:  this, method:  System.Void ShaderNameCollector::东且丛丆东三丏东丟(UnityEngine.Transform 丙丒七丄上与丏丙丙)));
    }
    internal string 专丝业丑丆丘业专丄(string 丟东丕丗丑丏丐丟丅)
    {
        string val_1 = 0;
        bool val_2 = this.丑丘丟丈丟丞上上丄.TryGetValue(key:  丟东丕丗丑丏丐丟丅, value: out  val_1);
        return val_1;
    }
    public ShaderNameCollector()
    {
        this.丑丘丟丈丟丞上上丄 = new System.Collections.Generic.Dictionary<System.String, System.String>();
    }
    private void 东且丛丆东三丏东丟(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_8;
        var val_9;
        string val_10;
        UnityEngine.Renderer val_1 = 丙丒七丄上与丏丙丙.GetComponent<UnityEngine.Renderer>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_9 = 0;
        goto label_6;
        label_13:
        UnityEngine.Material val_8 = val_1.materials[0];
        val_8 = this.丑丘丟丈丟丞上上丄;
        if(val_8 != null)
        {
                val_10 = val_8.name;
        }
        else
        {
                val_10 = 0.name;
        }
        
        val_8.set_Item(key:  val_10, value:  val_8.shader.name);
        val_9 = 1;
        label_6:
        if(val_9 < val_3.Length)
        {
            goto label_13;
        }
    
    }

}
