using UnityEngine;
[Serializable]
internal class ClickerDetectorSettings
{
    // Fields
    internal bool enable;
    internal float maxRating;
    internal float warningRating;
    internal bool enablePattern;
    internal int lengthPatternButtonPress;
    internal int maxLenListButtonsPress;
    internal float weightPattern;
    internal bool enableDistance;
    internal bool enableDistanceLoop;
    internal float loopDistanceTime;
    internal float minSpeed;
    internal float minSpeedDoubleCoef;
    internal float minSpeedInvertCoef;
    internal float weightLowDistanceInMatch;
    internal float weightLowDistanceInLoop;
    internal bool enableIntensity;
    internal float timeDetectIntensityPressButtons;
    internal int minCountPressButtonsForDetect;
    internal float thresholdDetectIntensityPressButtons;
    internal float thresholdInvertDetectIntensityPressButtonst;
    internal float weightIntensityPressButtons;
    
    // Methods
    public ClickerDetectorSettings()
    {
    
    }

}
