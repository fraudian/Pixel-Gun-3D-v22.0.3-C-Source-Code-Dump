using UnityEngine;
public class PositionHolder : MonoBehaviour
{
    // Fields
    public int state;
    public UnityEngine.GameObject[] obj;
    public PositionHolder.State[] states;
    
    // Methods
    private void 丂且不业丂专丛丆东()
    {
        var val_10;
        State val_12 = this.states[this.state];
        this.states[this.state][0].pos = new UnityEngine.Vector3[0];
        State val_13 = this.states[this.state];
        this.states[this.state][0].scale = new UnityEngine.Vector3[0];
        State val_14 = this.states[this.state];
        val_10 = 0;
        this.states[this.state][0].active = new bool[0];
        goto label_13;
        label_41:
        State val_15 = this.states[this.state];
        UnityEngine.Vector3 val_5 = this.obj[0].transform.localPosition;
        var val_6 = this.states[this.state][0].pos + (0 * 12);
        mem2[0] = val_5.x;
        mem2[0] = val_5.y;
        mem2[0] = val_5.z;
        State val_17 = this.states[this.state];
        UnityEngine.Vector3 val_8 = this.obj[0].transform.localScale;
        var val_9 = this.states[this.state][0].scale + (0 * 12);
        mem2[0] = val_8.x;
        mem2[0] = val_8.y;
        mem2[0] = val_8.z;
        State val_19 = this.states[this.state];
        val_10 = 1;
        this.states[this.state][0].active[0] = this.obj[0].activeSelf;
        label_13:
        if(val_10 < this.obj.Length)
        {
            goto label_41;
        }
    
    }
    public void LoadState()
    {
        UnityEngine.GameObject val_4;
        State[] val_5;
        var val_6;
        val_4 = this;
        if((this.state & 2147483648) != 0)
        {
            goto label_1;
        }
        
        val_5 = this.states;
        if(this.state >= this.states.Length)
        {
                return;
        }
        
        val_5 = 0;
        goto label_4;
        label_32:
        State val_7 = this.states[this.state];
        var val_2 = this.states[this.state][0].pos + (0 * 12);
        this.obj[0].transform.localPosition = new UnityEngine.Vector3() {x = (0 * 12) + this.states[this.state][0].pos + 32, y = (0 * 12) + this.states[this.state][0].pos + 32 + 4, z = (0 * 12) + this.states[this.state][0].pos + 40};
        State val_9 = this.states[this.state];
        var val_4 = this.states[this.state][0].scale + (0 * 12);
        this.obj[0].transform.localScale = new UnityEngine.Vector3() {x = (0 * 12) + this.states[this.state][0].scale + 32, y = (0 * 12) + this.states[this.state][0].scale + 32 + 4, z = (0 * 12) + this.states[this.state][0].scale + 40};
        State val_11 = this.states[this.state];
        this.obj[0].SetActive(value:  (this.states[this.state][0].active[0] == true) ? 1 : 0);
        val_5 = 1;
        label_4:
        if(val_5 < this.obj.Length)
        {
            goto label_32;
        }
        
        return;
        label_1:
        val_5 = this.obj;
        val_6 = 0;
        goto label_34;
        label_39:
        val_4 = val_5[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
        val_6 = 1;
        label_34:
        if(val_6 < this.obj.Length)
        {
            goto label_39;
        }
    
    }
    public void CorrectLoadState()
    {
        UnityEngine.GameObject val_5;
        State[] val_6;
        int val_7;
        var val_8;
        val_5 = this;
        if((this.state & 2147483648) != 0)
        {
            goto label_1;
        }
        
        val_6 = this.states;
        if(this.state >= this.states.Length)
        {
            goto label_3;
        }
        
        val_7 = this.state;
        if((val_7 & 2147483648) == 0)
        {
            goto label_4;
        }
        
        return;
        label_1:
        val_6 = this.obj;
        val_8 = 0;
        goto label_6;
        label_11:
        val_5 = val_6[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
        val_8 = 1;
        label_6:
        if(val_8 < this.obj.Length)
        {
            goto label_11;
        }
        
        return;
        label_3:
        val_7 = this.states.Length - 1;
        this.state = val_7;
        if((val_7 & 2147483648) != 0)
        {
                return;
        }
        
        label_4:
        val_6 = this.states;
        if(val_7 >= this.states.Length)
        {
                return;
        }
        
        val_6 = 0;
        goto label_17;
        label_45:
        State val_7 = this.states[this.state];
        var val_2 = this.states[this.state][0].pos + (0 * 12);
        this.obj[0].transform.localPosition = new UnityEngine.Vector3() {x = (0 * 12) + this.states[this.state][0].pos + 32, y = (0 * 12) + this.states[this.state][0].pos + 32 + 4, z = (0 * 12) + this.states[this.state][0].pos + 40};
        State val_9 = this.states[this.state];
        var val_4 = this.states[this.state][0].scale + (0 * 12);
        this.obj[0].transform.localScale = new UnityEngine.Vector3() {x = (0 * 12) + this.states[this.state][0].scale + 32, y = (0 * 12) + this.states[this.state][0].scale + 32 + 4, z = (0 * 12) + this.states[this.state][0].scale + 40};
        State val_11 = this.states[this.state];
        this.obj[0].SetActive(value:  (this.states[this.state][0].active[0] == true) ? 1 : 0);
        val_6 = 1;
        label_17:
        if(val_6 < this.obj.Length)
        {
            goto label_45;
        }
    
    }
    public void SetState(int 丏业丟一东丂东丘丛)
    {
        this.state = 丏业丟一东丂东丘丛;
        this.LoadState();
    }
    public PositionHolder()
    {
    
    }

}
