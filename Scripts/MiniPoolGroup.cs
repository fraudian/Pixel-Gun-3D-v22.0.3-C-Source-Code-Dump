using UnityEngine;
internal sealed class MiniPoolGroup : PGBehaviour
{
    // Fields
    internal bool addExampleToThePool;
    private System.Collections.Generic.Dictionary<string, MiniPoolMonoBehaviour> 万丌下下丈丐丑业专;
    
    // Methods
    public T Get<T>(string 丛丄业丕且丗下一万)
    {
        var val_14;
        var val_15;
        UnityEngine.Object val_16;
        val_14 = __RuntimeMethodHiddenParam;
        val_15 = this;
        if((this.万丌下下丈丐丑业专.ContainsKey(key:  丛丄业丕且丗下一万)) == false)
        {
            goto label_2;
        }
        
        val_16 = this.万丌下下丈丐丑业专.Item[丛丄业丕且丗下一万];
        if(val_16 == 0)
        {
            goto label_7;
        }
        
        if(val_16 != null)
        {
            goto label_27;
        }
        
        goto label_9;
        label_2:
        val_14 = val_14 + 48;
        label_7:
        val_16 = 0;
        if(丛丄业丕且丗下一万 == 0)
        {
                return (GMHModeInfoHint)val_16;
        }
        
        this.万丌下下丈丐丑业专.Add(key:  丛丄业丕且丗下一万, value:  this.gameObject.AddComponent<MiniPoolMonoBehaviour>());
        MiniPoolMonoBehaviour val_7 = this.万丌下下丈丐丑业专.Item[丛丄业丕且丗下一万];
        UnityEngine.Transform val_8 = this.transform;
        int val_9 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        val_7.example = 丛丄业丕且丗下一万;
        MiniPoolMonoBehaviour val_10 = this.万丌下下丈丐丑业专.Item[丛丄业丕且丗下一万];
        val_10.example.gameObject.SetActive(value:  false);
        MiniPoolMonoBehaviour val_12 = this.万丌下下丈丐丑业专.Item[丛丄业丕且丗下一万];
        val_12.addExampleToThePool = this.addExampleToThePool;
        val_15 = this.万丌下下丈丐丑业专.Item[丛丄业丕且丗下一万];
        val_16 = val_15;
        if(val_16 != null)
        {
            goto label_27;
        }
        
        label_9:
        label_27:
        val_16.name = 丛丄业丕且丗下一万;
        return (GMHModeInfoHint)val_16;
    }
    public void Return(string 丛丄业丕且丗下一万, UnityEngine.MonoBehaviour 万且万且丑丗且丌丆)
    {
        if((this.万丌下下丈丐丑业专.ContainsKey(key:  丛丄业丕且丗下一万)) != false)
        {
                this.万丌下下丈丐丑业专.Item[丛丄业丕且丗下一万].Return(万且万且丑丗且丌丆:  万且万且丑丗且丌丆);
            万且万且丑丗且丌丆.transform.SetParent(p:  this.万丌下下丈丐丑业专.Item[丛丄业丕且丗下一万].transform);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "No pool to return in!");
    }
    public MiniPoolGroup()
    {
        this.万丌下下丈丐丑业专 = new System.Collections.Generic.Dictionary<System.String, MiniPoolMonoBehaviour>();
    }

}
