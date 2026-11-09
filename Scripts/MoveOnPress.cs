using UnityEngine;
public class MoveOnPress : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform objectToMove;
    public float YOffset;
    private UnityEngine.Vector3 丅专不丛与七万七三;
    private UnityEngine.Vector3 三丘丏丌丗丞三丁丞;
    private bool 丏业丟一东丂东丘丛;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_1 = this.objectToMove.localPosition;
        this.丅专不丛与七万七三 = val_1;
        mem[1152921530947237928] = val_1.y;
        mem[1152921530947237932] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.YOffset);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.三丘丏丌丗丞三丁丞 = val_4;
        mem[1152921530947237940] = val_4.y;
        mem[1152921530947237944] = val_4.z;
    }
    private void OnPress(bool 丏业丟一东丂东丘丛)
    {
        this.丟丁丗丐业丐丈业丑(三丑丏世丂丆丕丈专:  丏业丟一东丂东丘丛);
    }
    private void 世丆丕丌丒下丆万上()
    {
        this.丟丁丗丐业丐丈业丑(三丑丏世丂丆丕丈专:  false);
    }
    private void 专丌丟下上东丞不丙()
    {
        this.丟丁丗丐业丐丈业丑(三丑丏世丂丆丕丈专:  true);
    }
    private void 丟丁丗丐业丐丈业丑(bool 三丑丏世丂丆丕丈专)
    {
        var val_1 = (this.丏业丟一东丂东丘丛 == true) ? 1 : 0;
        val_1 = val_1 ^ 三丑丏世丂丆丕丈专;
        if(val_1 == false)
        {
                return;
        }
        
        this.objectToMove.localPosition = new UnityEngine.Vector3() {x = (三丑丏世丂丆丕丈专 != true) ? this.三丘丏丌丗丞三丁丞 : this.丅专不丛与七万七三, y = (三丑丏世丂丆丕丈专 != true) ? 1152921530947694132 : 1152921530947694120, z = (三丑丏世丂丆丕丈专 != true) ? 1152921530947694136 : 1152921530947694124};
        this.丏业丟一东丂东丘丛 = 三丑丏世丂丆丕丈专;
    }
    public MoveOnPress()
    {
    
    }

}
