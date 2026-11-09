using UnityEngine;
public class Blinking : MonoBehaviour
{
    // Fields
    public float halfCycle;
    private UISprite 丛东上丂东一丒丈世;
    private float 七三丗丙丏丘丘丅上;
    private UnityEngine.Color 且丌东丞万业与丏丒;
    
    // Methods
    private void Awake()
    {
        UISprite val_1 = this.GetComponent<UISprite>();
        this.丛东上丂东一丒丈世 = val_1;
        UnityEngine.Color val_2 = val_1.color;
        this.且丌东丞万业与丏丒 = val_2;
        mem[1152921525503204688] = val_2.g;
        mem[1152921525503204692] = val_2.b;
        mem[1152921525503204696] = val_2.a;
    }
    private void OnEnable()
    {
        UnityEngine.Color val_1 = this.丛东上丂东一丒丈世.color;
        this.且丌东丞万业与丏丒 = val_1;
        mem[1152921525503324880] = val_1.g;
        mem[1152921525503324884] = val_1.b;
        mem[1152921525503324888] = val_1.a;
    }
    private void Update()
    {
        UISprite val_6;
        float val_7;
        float val_8;
        val_6 = this;
        val_7 = this.七三丗丙丏丘丘丅上;
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = val_7 + val_1;
        this.七三丗丙丏丘丘丅上 = val_1;
        if(this.丛东上丂东一丒丈世 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_3 = this.丛东上丂东一丒丈世.color;
        val_7 = val_3.r;
        val_8 = this.halfCycle;
        val_8 = this.halfCycle;
        val_8 = this.halfCycle;
        float val_4 = this.七三丗丙丏丘丘丅上 / this.halfCycle;
        val_4 = val_4 * val_8;
        val_4 = this.七三丗丙丏丘丘丅上 - val_4;
        val_4 = val_4 + val_4;
        val_6 = this.丛东上丂东一丒丈世;
        val_8 = val_4 / val_8;
        val_4 = 2f - val_8;
        var val_5 = (val_8 > 1f) ? (val_4) : (val_8);
        val_6.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void OnDisable()
    {
        UnityEngine.Color val_1 = this.丛东上丂东一丒丈世.color;
        this.且丌东丞万业与丏丒 = val_1;
        mem[1152921525503581648] = val_1.g;
        mem[1152921525503581652] = val_1.b;
        mem[1152921525503581656] = val_1.a;
    }
    public Blinking()
    {
        this.halfCycle = 1f;
    }

}
