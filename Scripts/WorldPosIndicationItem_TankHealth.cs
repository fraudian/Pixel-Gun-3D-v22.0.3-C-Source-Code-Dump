using UnityEngine;
internal sealed class WorldPosIndicationItem_TankHealth : WorldPosIndicationItem
{
    // Fields
    internal UISprite tankHP;
    private float grayBlinkDelay;
    private float colorBlinkDelay;
    private float 一丑丗且丁丟丕丛丑;
    private float 专丛七丂丐世丕丌丄;
    private bool 不丁丄业不七丌丗业;
    
    // Methods
    internal void 七丂丛丛丒丛一丟丟(UnityEngine.Color 丟且三三丅专丛丁丟, UnityEngine.Color 丑丅丛丒世万丘七丄, bool 一丞丗丘专业丘丁丝, bool 业丌专不世专丁丒丆)
    {
        float val_5;
        float val_6;
        val_5 = 丑丅丛丒世万丘七丄.a;
        val_6 = 丑丅丛丒世万丘七丄.g;
        if((一丞丗丘专业丘丁丝 != true) && (业丌专不世专丁丒丆 != true))
        {
                this.丗世七丕东且业业万(丝一专不丅一丂丄下:  new UnityEngine.Color() {r = 丟且三三丅专丛丁丟.r, g = 丟且三三丅专丛丁丟.g, b = 丟且三三丅专丛丁丟.b, a = 丟且三三丅专丛丁丟.a}, 丑丅丛丒世万丘七丄:  new UnityEngine.Color() {r = 丑丅丛丒世万丘七丄.r, g = val_6, b = 丑丅丛丒世万丘七丄.b, a = val_5});
            return;
        }
        
        if(this.不丁丄业不七丌丗业 == false)
        {
            goto label_3;
        }
        
        UnityEngine.Color val_1 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortAttack_grey");
        val_5 = val_1.r;
        val_6 = val_1.b;
        this.丗世七丕东且业业万(丝一专不丅一丂丄下:  new UnityEngine.Color() {r = 丟且三三丅专丛丁丟.r, g = 丟且三三丅专丛丁丟.g, b = 丟且三三丅专丛丁丟.b, a = 丟且三三丅专丛丁丟.a}, 丑丅丛丒世万丘七丄:  new UnityEngine.Color() {r = val_5, g = val_1.g, b = val_6, a = val_1.a});
        if((一丞丗丘专业丘丁丝 == false) || (业丌专不世专丁丒丆 == true))
        {
            goto label_9;
        }
        
        if(InGameGUIPart_FortAttack.instance != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_3:
        this.丗世七丕东且业业万(丝一专不丅一丂丄下:  new UnityEngine.Color() {r = 丟且三三丅专丛丁丟.r, g = 丟且三三丅专丛丁丟.g, b = 丟且三三丅专丛丁丟.b, a = 丟且三三丅专丛丁丟.a}, 丑丅丛丒世万丘七丄:  new UnityEngine.Color() {r = 丑丅丛丒世万丘七丄.r, g = val_6, b = 丑丅丛丒世万丘七丄.b, a = val_5});
        if((一丞丗丘专业丘丁丝 == false) || (业丌专不世专丁丒丆 == true))
        {
            goto label_9;
        }
        
        label_7:
        InGameGUIPart_FortAttack.instance.TankDestroyedBlink(丄下丐丛与世丛丄丂:  new UnityEngine.Color() {r = 丟且三三丅专丛丁丟.r, g = 丟且三三丅专丛丁丟.g, b = 丟且三三丅专丛丁丟.b, a = 丟且三三丅专丛丁丟.a});
        label_9:
        if(this.专丛七丂丐世丕丌丄 > this.一丑丗且丁丟丕丛丑)
        {
                this.不丁丄业不七丌丗业 = this.不丁丄业不七丌丗业 ^ 1;
            this.一丑丗且丁丟丕丛丑 = (this.不丁丄业不七丌丗业 == true) ? this.colorBlinkDelay : this.grayBlinkDelay;
            this.专丛七丂丐世丕丌丄 = 0f;
            return;
        }
        
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = this.专丛七丂丐世丕丌丄 + val_4;
        this.专丛七丂丐世丕丌丄 = val_4;
    }
    internal void 丄一丗丟丅世丝下丏(float 丙业与丙丗丝不丈东)
    {
        this.tankHP.fillAmount = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
    }
    private void 丗世七丕东且业业万(UnityEngine.Color 丝一专不丅一丂丄下, UnityEngine.Color 丑丅丛丒世万丘七丄)
    {
        UnityEngine.Color val_1 = this.tankHP.color;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, rhs:  new UnityEngine.Color() {r = 丝一专不丅一丂丄下.r, g = 丝一专不丅一丂丄下.g, b = 丝一专不丅一丂丄下.b, a = 丝一专不丅一丂丄下.a})) != false)
        {
                this.tankHP.color = new UnityEngine.Color() {r = 丝一专不丅一丂丄下.r, g = 丝一专不丅一丂丄下.g, b = 丝一专不丅一丂丄下.b, a = 丝一专不丅一丂丄下.a};
        }
        
        UnityEngine.Color val_3 = this.tankHP.color;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, rhs:  new UnityEngine.Color() {r = 丑丅丛丒世万丘七丄.r, g = 丑丅丛丒世万丘七丄.g, b = 丑丅丛丒世万丘七丄.b, a = 丑丅丛丒世万丘七丄.a})) != false)
        {
                this.tankHP.color = new UnityEngine.Color() {r = 丑丅丛丒世万丘七丄.r, g = 丑丅丛丒世万丘七丄.g, b = 丑丅丛丒世万丘七丄.b, a = 丑丅丛丒世万丘七丄.a};
        }
        
        UnityEngine.Color val_5 = this.tankHP.color;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a}, rhs:  new UnityEngine.Color() {r = 丑丅丛丒世万丘七丄.r, g = 丑丅丛丒世万丘七丄.g, b = 丑丅丛丒世万丘七丄.b, a = 丑丅丛丒世万丘七丄.a})) == false)
        {
                return;
        }
        
        this.color = new UnityEngine.Color() {r = 丑丅丛丒世万丘七丄.r, g = 丑丅丛丒世万丘七丄.g, b = 丑丅丛丒世万丘七丄.b, a = 丑丅丛丒世万丘七丄.a};
    }
    public WorldPosIndicationItem_TankHealth()
    {
        this.grayBlinkDelay = 0.5f;
        this.colorBlinkDelay = 0.5f;
        this.一丑丗且丁丟丕丛丑 = 0.5f;
        mem[1152921539701009648] = 1114636288;
        mem[1152921539701009696] = 1;
        this = new UnityEngine.MonoBehaviour();
    }

}
