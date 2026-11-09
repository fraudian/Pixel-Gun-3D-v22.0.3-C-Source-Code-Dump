using UnityEngine;
[Serializable]
public class NJGAtlas.Sprite
{
    // Fields
    public int id;
    public string name;
    public UnityEngine.Rect uvs;
    public bool initialized;
    private UnityEngine.Vector2 mPos;
    private UnityEngine.Vector2 mSize;
    
    // Properties
    public UnityEngine.Vector2 position { get; }
    public UnityEngine.Vector2 size { get; }
    public float width { get; }
    public float height { get; }
    
    // Methods
    public UnityEngine.Vector2 get_position()
    {
        float val_5;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.mPos, y = V8.16B}, rhs:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y})) == false)
        {
                return new UnityEngine.Vector2() {x = this.mPos, y = V8.16B};
        }
        
        float val_3 = this.uvs.x;
        val_5 = val_3;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_5, y:  val_3);
        this.mPos = val_4.x;
        mem[1152921535379559240] = val_4.y;
        return new UnityEngine.Vector2() {x = this.mPos, y = V8.16B};
    }
    public UnityEngine.Vector2 get_size()
    {
        float val_4;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.mSize, y = V8.16B}, rhs:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y})) == false)
        {
                return new UnityEngine.Vector2() {x = this.mSize, y = V8.16B};
        }
        
        val_4 = this.mSize;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_4, y:  this.mSize);
        this.mSize = val_3.x;
        mem[1152921535379671248] = val_3.y;
        return new UnityEngine.Vector2() {x = this.mSize, y = V8.16B};
    }
    public float get_width()
    {
    
    }
    public float get_height()
    {
    
    }
    public NJGAtlas.Sprite()
    {
    
    }

}
