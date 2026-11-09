using UnityEngine;
public class StateHolder : MonoBehaviour
{
    // Fields
    private bool 丝与丆丞东丘丈东丘;
    public StateHolder.ControlGUIState[] states;
    private StateHolder.下七一丌丝丂丙七丑 丝丙丌且专丅东丞业;
    public StateHolder.下七一丌丝丂丙七丑 currentState;
    
    // Properties
    public StateHolder.下七一丌丝丂丙七丑 丏业丟一东丂东丘丛 { get; set; }
    
    // Methods
    public StateHolder.下七一丌丝丂丙七丑 get_state()
    {
        return (下七一丌丝丂丙七丑)this.丝丙丌且专丅东丞业;
    }
    public void set_state(StateHolder.下七一丌丝丂丙七丑 丙业与丙丗丝不丈东)
    {
        var val_1;
        if(this.丝丙丌且专丅东丞业 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        val_1 = 0;
        this.丝丙丌且专丅东丞业 = 丙业与丙丗丝不丈东;
        goto label_1;
        label_7:
        ControlGUIState val_1 = this.states[0];
        if(this.丝丙丌且专丅东丞业 == this.states[0x0][0].state)
        {
            goto label_5;
        }
        
        val_1 = 1;
        label_1:
        if(val_1 < this.states.Length)
        {
            goto label_7;
        }
        
        return;
        label_5:
        this.丅专下万丕丑丆丅丝(丏业丟一东丂东丘丛:  this.states[0]);
    }
    private void 丅专下万丕丑丆丅丝(StateHolder.ControlGUIState 丏业丟一东丂东丘丛)
    {
        UnityEngine.Color val_7;
        UnityEngine.Color val_8;
        bool val_9;
        var val_10;
        if((UnityEngine.Object.op_Implicit(exists:  丏业丟一东丂东丘丛.masked)) != false)
        {
                val_7 = 丏业丟一东丂东丘丛.colors[丏业丟一东丂东丘丛 + 40 + 32];
            val_8 = 丏业丟一东丂东丘丛.colors[丏业丟一东丂东丘丛 + 40 + 32];
            丏业丟一东丂东丘丛.masked.GetComponent<UIBasicSprite>().color = new UnityEngine.Color() {r = val_7, g = 丏业丟一东丂东丘丛.colors[丏业丟一东丂东丘丛 + 40 + 32], b = val_8, a = 丏业丟一东丂东丘丛.colors[丏业丟一东丂东丘丛 + 40 + 32]};
        }
        
        val_9 = 0;
        goto label_10;
        label_22:
        if((UnityEngine.Object.op_Implicit(exists:  丏业丟一东丂东丘丛.sprites[0])) != false)
        {
                var val_4 = mem[丏业丟一东丂东丘丛.colors] + 0;
            val_7 = mem[(mem[丏业丟一东丂东丘丛.colors] + 0) + 32];
            val_7 = (mem[丏业丟一东丂东丘丛.colors] + 0) + 32;
            val_8 = mem[(mem[丏业丟一东丂东丘丛.colors] + 0) + 40];
            val_8 = (mem[丏业丟一东丂东丘丛.colors] + 0) + 40;
            丏业丟一东丂东丘丛.sprites[0].color = new UnityEngine.Color() {r = val_7, g = (mem[丏业丟一东丂东丘丛.colors] + 0) + 32 + 4, b = val_8, a = (mem[丏业丟一东丂东丘丛.colors] + 0) + 40 + 4};
        }
        
        val_9 = 1;
        label_10:
        if(val_9 < 丏业丟一东丂东丘丛.sprites.Length)
        {
            goto label_22;
        }
        
        val_10 = 0;
        goto label_23;
        label_35:
        val_9 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  丏业丟一东丂东丘丛.go[val_9])) != false)
        {
                val_9 = 丏业丟一东丂东丘丛.active[val_9];
            丏业丟一东丂东丘丛.go[val_9].SetActive(value:  (val_9 == true) ? 1 : 0);
        }
        
        val_10 = 1;
        label_23:
        if(val_10 < 丏业丟一东丂东丘丛.go.Length)
        {
            goto label_35;
        }
    
    }
    public StateHolder()
    {
        this.currentState = 3;
    }

}
