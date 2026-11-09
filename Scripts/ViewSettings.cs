using UnityEngine;
[Serializable]
internal class PixelPassView.ViewSettings
{
    // Fields
    internal 一丗不丈丒万丂下丑 aspectRatio;
    internal float pagesScrollScale;
    internal int mainViewHeight;
    internal int buttonsPosition;
    
    // Methods
    public PixelPassView.ViewSettings()
    {
        this.pagesScrollScale = 1f;
        this.mainViewHeight = 300;
        this.buttonsPosition = 460;
    }

}
