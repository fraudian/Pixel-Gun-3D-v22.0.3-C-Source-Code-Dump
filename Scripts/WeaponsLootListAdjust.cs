using UnityEngine;
internal sealed class WeaponsLootListAdjust : ButtonJoystickAdjust
{
    // Fields
    private LootButtonAdjust LootButton;
    private UnityEngine.GameObject CellPreview;
    private UISprite 丘丒业一世丝丞丞丞;
    private const int 丑丏丌与丏丐丗一万 = 314;
    private int 丄与丁且不世三丁丈;
    
    // Methods
    internal override void 丝丆且下丁三不丘世(float 与专丌丅丙上丌一丄)
    {
        float val_5 = 与专丌丅丙上丌一丄;
        WeaponsLootListAdjust.丞丂万丅不丒丘丟丗 val_1 = new WeaponsLootListAdjust.丞丂万丅不丒丘丟丗();
        if(val_1 != null)
        {
                .与专丌丅丙上丌一丄 = val_5;
        }
        else
        {
                mem[16] = val_5;
            val_5 = mem[16];
        }
        
        this.丝丆且下丁三不丘世(与专丌丅丙上丌一丄:  val_5);
        if(this.CellPreview == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.CellPreview.GetComponentsInChildren<UILabel>(includeInactive:  true), 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void WeaponsLootListAdjust.丞丂万丅不丒丘丟丗::丛丐丅丁丒世不七丛(UILabel 七丐丞丑丑丕世丙七)));
    }
    private void Update()
    {
        if(this.CellPreview == 0)
        {
                return;
        }
        
        if(this.丘丒业一世丝丞丞丞 == 0)
        {
                return;
        }
        
        if(this.丘丒业一世丝丞丞丞.width == this.丄与丁且不世三丁丈)
        {
                return;
        }
        
        int val_4 = this.丘丒业一世丝丞丞丞.width;
        this.丄与丁且不世三丁丈 = val_4;
        float val_8 = 314f;
        UnityEngine.Vector3 val_6 = this.CellPreview.transform.localScale;
        val_8 = (float)val_4 / val_8;
        this.CellPreview.transform.localScale = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_6.z};
    }
    private void OnEnable()
    {
        if(this.LootButton != null)
        {
                this.LootButton.丁上万丘与七丆下世(丙业与丙丗丝不丈东:  this);
        }
        
        this.丘丒业一世丝丞丞丞 = this.GetComponent<UISprite>();
    }
    internal bool 上丁丟丝七丘丂丌业(UnityEngine.Vector2 丞且丅三三东不丄且, float 丂丟业东丕东万与丙, float 七东丗不一丌丈丙丄)
    {
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        UnityEngine.Vector3 val_6 = this.transform.localPosition;
        float val_17 = 0.5f;
        七东丗不一丌丈丙丄 = 七东丗不一丌丈丙丄 * val_17;
        val_17 = (丂丟业东丕东万与丙 * val_17) * ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f);
        val_17 = val_4.x - val_17;
        val_6.y = val_6.y - 七东丗不一丌丈丙丄;
        UnityEngine.Transform val_9 = this.transform.parent;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_11 = val_9.TransformPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_14 = this.transform.parent.lossyScale;
        return (bool)val_9.丈丑丁与丝丞下且丌(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, 且丛上丕业丂丒与一:  1f, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, 一世丅丕丑丈丕世丈:  false);
    }
    internal bool 丞丄丞丝东丝丂丌丂(float 丙一丐丗专丙丆丒且)
    {
        丙一丐丗专丙丆丒且 = (float)this.丘丒业一世丝丞丞丞.height * 丙一丐丗专丙丆丒且;
        float val_3 = 丙一丐丗专丙丆丒且 / (float)this.丘丒业一世丝丞丞丞.width;
        float val_6 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f;
        val_6 = ((float)this.丘丒业一世丝丞丞丞.width - 丙一丐丗专丙丆丒且) * val_6;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_6, y:  (float)this.丘丒业一世丝丞丞丞.height - val_3);
        return (bool)this.上丁丟丝七丘丂丌业(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, 丂丟业东丕东万与丙:  丙一丐丗专丙丆丒且, 七东丗不一丌丈丙丄:  val_3);
    }
    protected override void 丕下丗丆丄丘丆丈万(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        this.万丛丌三丈一东丆且();
    }
    internal void 万丛丌三丈一东丆且()
    {
        if(this.LootButton == 0)
        {
                return;
        }
        
        float val_3 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f;
        UnityEngine.Vector3 val_5 = this.LootButton.transform.localPosition;
        int val_7 = this.LootButton.GetComponent<UISprite>().width;
        UISprite val_8 = this.GetComponent<UISprite>();
        float val_15 = 0.5f;
        val_3 = val_3 * (((float)-(val_7 + val_8.width)) * val_15);
        val_15 = ((float)val_7 - val_8.height) * val_15;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_3, y = val_15, z = 0f});
        this.丕下丗丆丄丘丆丈万(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
    }
    public WeaponsLootListAdjust()
    {
    
    }

}
