using UnityEngine;
public class TestShader : MonoBehaviour
{
    // Fields
    public UnityEngine.Material matBlock;
    public UnityEngine.Material killBlock;
    public float timerToNext;
    public float timeToNext;
    public float timerToBlink;
    public float timeToBlink;
    public UnityEngine.Color[] Colors;
    public UnityEngine.Color colorNow;
    public bool add;
    private int 丒丆下丅三七丕丟丁;
    private int 丝丌且丝丛丙万丅丙;
    
    // Methods
    private void Update()
    {
        this.丏不万丛上一世丄丟();
        this.丑七丌东丏且专不丒();
    }
    private void 丏不万丛上一世丄丟()
    {
        UnityEngine.Color[] val_5;
        int val_6;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.timerToNext + val_1;
        this.timerToNext = val_1;
        if(val_1 < this.timeToNext)
        {
                val_5 = this.Colors;
            val_6 = this.丝丌且丝丛丙万丅丙;
        }
        else
        {
                val_5 = this;
            int val_2 = this.丒丆下丅三七丕丟丁 + 1;
            this.丒丆下丅三七丕丟丁 = val_2;
            this.丝丌且丝丛丙万丅丙 = this.丒丆下丅三七丕丟丁;
            val_6 = 1152921540526603496;
            if(val_2 >= this.Colors.Length)
        {
                this.丒丆下丅三七丕丟丁 = 0;
        }
        
            this.timerToNext = 0f;
        }
        
        UnityEngine.Color[] val_3 = null + ((this.丒丆下丅三七丕丟丁) << 4);
        float val_9 = this.timerToNext;
        val_9 = val_9 / this.timeToNext;
        UnityEngine.Color val_4 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = mem[(this.Colors + (this.丒丆下丅三七丕丟丁) << 4) + 32], g = mem[(this.Colors + (this.丒丆下丅三七丕丟丁) << 4) + 32 + 4], b = mem[(this.Colors + (this.丒丆下丅三七丕丟丁) << 4) + 40], a = mem[(this.Colors + (this.丒丆下丅三七丕丟丁) << 4) + 40 + 4]}, b:  new UnityEngine.Color() {r = this.Colors[this.丒丆下丅三七丕丟丁], g = this.Colors[this.丒丆下丅三七丕丟丁], b = this.Colors[this.丒丆下丅三七丕丟丁], a = this.Colors[this.丒丆下丅三七丕丟丁]}, t:  val_9);
        this.colorNow = val_4;
        mem[1152921540526603476] = val_4.g;
        mem[1152921540526603480] = val_4.b;
        mem[1152921540526603484] = val_4.a;
        this.matBlock.SetColor(name:  "_Color2", value:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
    }
    private void 丑七丌东丏且专不丒()
    {
        float val_5 = this.timeToBlink;
        if(this.timerToBlink > val_5)
        {
                this.add = false;
        }
        
        if(this.timerToBlink < 0)
        {
                this.add = true;
            float val_1 = UnityEngine.Time.deltaTime;
        }
        else
        {
                if(this.add != true)
        {
                val_5 = -UnityEngine.Time.deltaTime;
        }
        
        }
        
        float val_3 = this.timerToBlink + val_5;
        this.timerToBlink = val_3;
        val_5 = val_3 / this.timeToBlink;
        val_5 = val_5 * 0.7f;
        val_5 = val_5 + 0.3f;
        this.matBlock.SetFloat(name:  "_Shadow", value:  val_5);
        float val_4 = this.timerToBlink / this.timeToBlink;
        val_4 = val_4 * 0.7f;
        val_4 = val_4 + 0.3f;
        this.killBlock.SetFloat(name:  "_Shadow", value:  val_4);
    }
    public TestShader()
    {
        this.timeToNext = 50f;
        this.timeToBlink = 2f;
        this.丒丆下丅三七丕丟丁 = 1;
    }

}
