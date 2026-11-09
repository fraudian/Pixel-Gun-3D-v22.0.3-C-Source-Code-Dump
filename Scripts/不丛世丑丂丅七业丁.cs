using UnityEngine;
private sealed class InfoWindowController.不丛世丑丂丅七业丁 : InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    public UnityEngine.Texture 丘丛不与丌丘丏丛丙;
    public bool 丕专丑丁丐上丏专不;
    public string 丏东丙丙丈丘丐丝丄;
    public string 不三世丏丙丁与丑丒;
    
    // Methods
    public InfoWindowController.不丛世丑丂丅七业丁(AchieveBox 不丌丗丂丆业丂丏世)
    {
        val_1 = new System.Object();
        mem[1152921538054349144] = 不丌丗丂丆业丂丏世;
    }
    public override void 一丌一丞世不下丄专()
    {
        InfoWindowController val_1 = InfoWindowController.丑七不且上丗丁一世();
        val_1.achievementText.text = this.不三世丏丙丁与丑丒;
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2.achievementTextureBg.gameObject, 丏业丟一东丂东丘丛:  (this.丕专丑丁丐上丏专不 == false) ? 1 : 0);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        if(val_5.achievementTextureBg.gameObject.activeSelf != false)
        {
                InfoWindowController val_8 = InfoWindowController.丑七不且上丗丁一世();
            InfoWindowController val_9 = InfoWindowController.丑七不且上丗丁一世();
            val_9.achievementTextureBg.fixedAspect = true;
            InfoWindowController val_10 = InfoWindowController.丑七不且上丗丁一世();
            val_10.achievementSpriteIcon.spriteName = this.丏东丙丙丈丘丐丝丄;
        }
        
        InfoWindowController val_11 = InfoWindowController.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  val_11.achievementOrLikeHeader, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  this, method:  System.Void InfoWindowController.不丛世丑丂丅七业丁::下与一丆万丑七下东(UILabel 丐三丞七丝丅不万丛)));
        InfoWindowController val_13 = InfoWindowController.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13.likeSpriteIcon.gameObject, 丏业丟一东丂东丘丛:  this.丕专丑丁丐上丏专不);
        this.一丌一丞世不下丄专();
    }
    private void 下与一丆万丑七下东(UILabel 丐三丞七丝丅不万丛)
    {
        丐三丞七丝丅不万丛.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (this.丕专丑丁丐上丏专不 == true) ? "Key_3300" : "Key_2290");
    }

}
