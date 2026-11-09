using UnityEngine;
internal sealed class DebugSettingsChangeColor : PGBehaviour
{
    // Fields
    internal UISprite sprite;
    internal UnityEngine.Color сhromaticColor;
    internal UnityEngine.Color grayColor;
    
    // Methods
    internal void 丙丑丂丁与丗丞下七()
    {
        this.sprite.color = new UnityEngine.Color() {r = this.сhromaticColor, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    internal void 丌丞下世丛丂东丒丟()
    {
        this.sprite.color = new UnityEngine.Color() {r = this.grayColor, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    public DebugSettingsChangeColor()
    {
    
    }

}
