using UnityEngine;
internal class SniperShotImpulse : MonoBehaviour
{
    // Fields
    private float 丞且丅三三东不丄且;
    internal float 一丗世三专三万丞丞;
    internal UnityEngine.Vector2 世与丗丏丟丂丕三万;
    internal UnityEngine.Vector2 东且丁丆丛丁丏丘且;
    internal float 丟丞一专丕三东丗一;
    private float 丙丒七丄上与丏丙丙;
    internal float 丞丅丟丌丌下丛丑丆;
    internal float 丞且且丝万丌丐上丝;
    internal float 丂三丟丂丈丐丆丗丟;
    
    // Methods
    private void Awake()
    {
        this.Reset();
    }
    internal void Reset()
    {
        this.丙丒七丄上与丏丙丙 = 2f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.东且丁丆丛丁丏丘且 = val_1;
        mem[1152921539178883116] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.世与丗丏丟丂丕三万 = val_2;
        mem[1152921539178883108] = val_2.y;
    }
    private void Update()
    {
        float val_4;
        float val_5;
        val_4 = this.丙丒七丄上与丏丙丙;
        if(val_4 > this.丂三丟丂丈丐丆丗丟)
        {
                return;
        }
        
        this.世与丗丏丟丂丕三万 = this.东且丁丆丛丁丏丘且;
        mem[1152921539178995108] = ???;
        if(val_4 > this.丞且且丝万丌丐上丝)
        {
                val_5 = this.丞且丅三三东不丄且 + W8;
            mem[1152921539178995116] = val_5;
        }
        else
        {
                float val_4 = this.丞丅丟丌丌下丛丑丆;
            float val_1 = val_4 * val_4;
            val_1 = this.一丗世三专三万丞丞 / val_1;
            val_4 = val_4 - val_4;
            val_1 = val_4 * val_1;
            val_4 = val_4 * val_1;
            val_5 = this.一丗世三专三万丞丞 - val_4;
            mem[1152921539178995116] = val_5;
            UnityEngine.Vector2 val_2 = this.丙一万不一丛且丄下();
            val_4 = this.丙丒七丄上与丏丙丙;
            this.丞且丅三三东不丄且 = val_2.y;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.丟丞一专丕三东丗一 * val_3;
        val_3 = val_4 + val_3;
        this.丙丒七丄上与丏丙丙 = val_3;
    }
    internal void 三且世三丂七丐一丟()
    {
        this.丙丒七丄上与丏丙丙 = 0f;
        this.丂三丟丂丈丐丆丗丟 = UnityEngine.Random.Range(min:  0.9f, max:  1.3f);
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.东且丁丆丛丁丏丘且 = val_2;
        mem[1152921539179107116] = val_2.y;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.世与丗丏丟丂丕三万 = val_3;
        mem[1152921539179107108] = val_3.y;
    }
    internal UnityEngine.Vector2 丙一万不一丛且丄下()
    {
        if(this.丙丒七丄上与丏丙丙 <= this.丂三丟丂丈丐丆丗丟)
        {
                return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.东且丁丆丛丁丏丘且, y = V10.16B}, b:  new UnityEngine.Vector2() {x = this.世与丗丏丟丂丕三万, y = V8.16B});
        }
        
        return UnityEngine.Vector2.zero;
    }
    public SniperShotImpulse()
    {
        this.一丗世三专三万丞丞 = 1f;
        this.丟丞一专丕三东丗一 = 1f;
        this.丞丅丟丌丌下丛丑丆 = 0.3f;
        this.丞且且丝万丌丐上丝 = 0.37f;
        this.丂三丟丂丈丐丆丗丟 = 1f;
    }

}
