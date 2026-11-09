using UnityEngine;
internal sealed class FortFieldTurretPlatform : PGBehaviour
{
    // Fields
    private UnityEngine.Material 上与丐丂丌丕万上丝;
    private bool 下丄与一丁业丒业东;
    private UnityEngine.Color 丑丑丗丅专与世丈且;
    private UnityEngine.Color 且丁七丂丘一丄与丞;
    private float 丝丙一丝丈丂不丙一;
    private float maxTime;
    private bool 丄丆业世丑丗七丏丏;
    private string 丕丙一丐丄丒丄七不;
    private string 一丟丅丕丗东丂丘世;
    private UnityEngine.Color colorForWallHack;
    private float 丟且专丕丞丄丛丑丁;
    
    // Methods
    private void Awake()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "FortFieldBuild")) != false)
        {
                this.上与丐丂丌丕万上丝 = this.GetComponent<UnityEngine.MeshRenderer>().material;
            UnityEngine.Color val_6 = UnityEngine.Color.white;
            this.丑丑丗丅专与世丈且 = val_6;
            mem[1152921536502327448] = val_6.g;
            mem[1152921536502327452] = val_6.b;
            mem[1152921536502327456] = val_6.a;
            this.上与丐丂丌丕万上丝.shader = UnityEngine.Shader.Find(name:  "Rilisoft/WallHackShader");
            this.上与丐丂丌丕万上丝.renderQueue = 184;
            this.上与丐丂丌丕万上丝.SetColor(name:  this.丕丙一丐丄丒丄七不, value:  new UnityEngine.Color() {r = this.丑丑丗丅专与世丈且, g = V9.16B, b = V10.16B, a = V11.16B});
            mem[1152921536502327516] = 1051931443;
            this.上与丐丂丌丕万上丝.SetColor(name:  this.一丟丅丕丗东丂丘世, value:  new UnityEngine.Color() {r = this.colorForWallHack, g = V9.16B, b = V10.16B, a = 0.35f});
            return;
        }
        
        this.enabled = false;
    }
    internal void 丙丘与丒七丒丞丗丈(float 丟且专丕丞丄丛丑丁, float 丏七丗丅东下且与丞)
    {
        this.丟且专丕丞丄丛丑丁 = 丟且专丕丞丄丛丑丁;
        丟且专丕丞丄丛丑丁 = 丟且专丕丞丄丛丑丁 * 丏七丗丅东下且与丞;
        this.且丁七丂丘一丄与丞 = this.丑丑丗丅专与世丈且;
        mem[1152921536502480428] = ???;
        mem[1152921536502480432] = 丟且专丕丞丄丛丑丁;
        this.下丄与一丁业丒业东 = true;
    }
    internal void 丛三丑且且业丛丏丅()
    {
        this.下丄与一丁业丒业东 = false;
        this.上与丐丂丌丕万上丝.SetColor(name:  this.丕丙一丐丄丒丄七不, value:  new UnityEngine.Color() {r = this.丑丑丗丅专与世丈且, g = V9.16B, b = V10.16B, a = V11.16B});
    }
    private void Update()
    {
        float val_5;
        float val_6;
        if(this.下丄与一丁业丒业东 == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_5 = this.丟且专丕丞丄丛丑丁;
        val_1 = val_1 * val_5;
        if(this.丄丆业世丑丗七丏丏 == false)
        {
            goto label_1;
        }
        
        val_5 = this.maxTime;
        val_6 = this.丝丙一丝丈丂不丙一 + val_1;
        this.丝丙一丝丈丂不丙一 = val_6;
        if(val_6 <= val_5)
        {
            goto label_4;
        }
        
        this.丄丆业世丑丗七丏丏 = false;
        goto label_4;
        label_1:
        val_6 = this.丝丙一丝丈丂不丙一 - val_1;
        this.丝丙一丝丈丂不丙一 = val_6;
        if(val_6 <= 0f)
        {
                this.丄丆业世丑丗七丏丏 = true;
        }
        
        label_4:
        UnityEngine.Color val_2 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.且丁七丂丘一丄与丞, g = val_5}, b:  new UnityEngine.Color() {r = this.丑丑丗丅专与世丈且}, t:  val_6);
        this.上与丐丂丌丕万上丝.SetColor(name:  this.丕丙一丐丄丒丄七不, value:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
    }
    public FortFieldTurretPlatform()
    {
        this.maxTime = 1f;
        this.丄丆业世丑丗七丏丏 = true;
        this.丕丙一丐丄丒丄七不 = "_ColorRili";
        this.一丟丅丕丗东丂丘世 = "_Color2";
        UnityEngine.Color val_1 = UnityEngine.Color.cyan;
        this.colorForWallHack = val_1;
        mem[1152921536502849236] = val_1.g;
        mem[1152921536502849240] = val_1.b;
        mem[1152921536502849244] = val_1.a;
        this.丟且专丕丞丄丛丑丁 = 0.5f;
    }

}
