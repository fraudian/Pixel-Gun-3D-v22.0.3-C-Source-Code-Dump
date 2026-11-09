using UnityEngine;
internal abstract class 丟世丝丅丕丟丗七丅
{
    // Fields
    protected 丄丐世丆丛世丅上丛 与丘丂丟且万丕三丒;
    
    // Methods
    protected abstract void 且丏丈一不丈上世东(); // 0
    protected abstract void 万丅下丈丌丙下丙且(); // 0
    internal 丄丐世丆丛世丅上丛 丑丈不七丈丁与世丂()
    {
    
    }
    protected UnityEngine.Vector2 上世世丕丂丞专世丁(int 丑七丐与世丅丆丞丅, int 丛丑丒与与丑不丘丂)
    {
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  UnityEngine.Input.GetAxis(axisName:  System.String.Format(format:  "Joystick_{0}rd_axis", arg0:  丑七丐与世丅丆丞丅)), y:  UnityEngine.Input.GetAxis(axisName:  System.String.Format(format:  "Joystick_{0}rd_axis", arg0:  丛丑丒与与丑不丘丂)));
        return new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    protected float 丙丝丙丏丕丈丌丘上(int 丙七且一丒上丑丙丞)
    {
        return (float)UnityEngine.Input.GetAxis(axisName:  System.String.Format(format:  "Joystick_{0}rd_axis", arg0:  丙七且一丒上丑丙丞));
    }
    protected void 丕三丞丛与东丒且丁(ref 丄丐世丆丛世丅上丛.丅丛丐三七一且丙万 丌专丟下万丌丘万丝, int 丙上业万丑业丕万丐)
    {
        bool val_2 = UnityEngine.Input.GetButton(buttonName:  System.String.Format(format:  "Joystick_button_{0}", arg0:  丙上业万丑业丕万丐));
        bool val_3 = val_2;
        丌专丟下万丌丘万丝.丟丛丂不与丄丐专与 = (7 != 0) ? (((val_2 & true) != 0) ? (2 + 1) : 2) : (val_3);
        mem[1152921537747790004] = val_3;
    }
    protected void 丕三丞丛与东丒且丁(ref 丄丐世丆丛世丅上丛.丅丛丐三七一且丙万 丌专丟下万丌丘万丝, bool 丝三业丛丘且不丝丆)
    {
        bool val_1 = 丝三业丛丘且不丝丆;
        丌专丟下万丌丘万丝.丟丛丂不与丄丐专与 = (7 != 0) ? (((丝三业丛丘且不丝丆 & true) != 0) ? (2 + 1) : 2) : (val_1);
        mem[1152921537747926452] = val_1;
    }
    protected 丟世丝丅丕丟丗七丅()
    {
    
    }

}
