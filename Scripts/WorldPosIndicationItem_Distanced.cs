using UnityEngine;
internal class WorldPosIndicationItem_Distanced : WorldPosIndicationItem
{
    // Fields
    private UILabel distanceLabel;
    private UnityEngine.Transform 丒一东丁世三万专下;
    private UnityEngine.Transform 丁丁丑与东与且三丒;
    
    // Methods
    internal override void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        this.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
        this.distanceLabel.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    internal void 下上丐丌七丁丄丝丑(UnityEngine.Transform 丑东与丅丐丅丂丞业, UnityEngine.Transform 丙七丟丏丅丘丈丁丄)
    {
        this.丒一东丁世三万专下 = 丑东与丅丐丅丂丞业;
        this.丁丁丑与东与且三丒 = 丙七丟丏丅丘丈丁丄;
    }
    private void Update()
    {
        string val_10;
        string val_11;
        val_10 = 1152921504848912384;
        if(this.丒一东丁世三万专下 != 0)
        {
                if(this.丁丁丑与东与且三丒 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.distanceLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7044");
            UnityEngine.Vector3 val_5 = this.丒一东丁世三万专下.position;
            UnityEngine.Vector3 val_6 = this.丁丁丑与东与且三丒.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_11 = System.String.Format(format:  val_10, arg0:  (int)val_7.x);
            this.distanceLabel.text = val_11;
            return;
        }
        
        }
        
        val_11 = this.distanceLabel.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
    }
    public WorldPosIndicationItem_Distanced()
    {
        mem[1152921539700151920] = 1114636288;
        mem[1152921539700151968] = 1;
        this = new UnityEngine.MonoBehaviour();
    }

}
