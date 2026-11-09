using UnityEngine;
public sealed class CameraTouchControlSchemeConfigurator : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.InputField dampingTime;
    public UnityEngine.UI.InputField firstDragClampedMax1;
    public UnityEngine.UI.InputField firstDragClampedMax2;
    public UnityEngine.UI.InputField lerpCoeff;
    public UnityEngine.UI.Toggle mouseLookAcceleration;
    public UnityEngine.UI.InputField mouseLookAccelerationThreshold;
    public UnityEngine.UI.InputField mouseLookSensitivityX;
    public UnityEngine.UI.InputField mouseLookSensitivityY;
    public UnityEngine.UI.InputField mouseLookSmoothSteps;
    public UnityEngine.UI.InputField mouseLookSmoothWeight;
    public UnityEngine.RectTransform panelCleanNGUI;
    public UnityEngine.RectTransform panelLowPassFilter;
    public UnityEngine.RectTransform panelSmoothDump;
    public UnityEngine.RectTransform panelUFPS;
    public UnityEngine.UI.InputField senseModifier;
    public UnityEngine.UI.InputField senseModifierByAxisX;
    public UnityEngine.UI.InputField senseModifierByAxisY;
    public UnityEngine.UI.InputField startMovingThreshold1;
    public UnityEngine.UI.InputField startMovingThreshold2;
    public UnityEngine.UI.Toggle toggleCleanNGUI;
    public UnityEngine.UI.Toggle toggleLowPassFilter;
    public UnityEngine.UI.Toggle toggleSmoothDump;
    public UnityEngine.UI.Toggle toggleUFPS;
    private static CameraTouchControlSchemeConfigurator <不丁丄七丛不丆丁丕>k__BackingField;
    
    // Properties
    internal static CameraTouchControlSchemeConfigurator 丆丕丝丒不丙且丐丗 { get; set; }
    
    // Methods
    internal static CameraTouchControlSchemeConfigurator 丑七不且上丗丁一世()
    {
        return (CameraTouchControlSchemeConfigurator)CameraTouchControlSchemeConfigurator.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(CameraTouchControlSchemeConfigurator 丙业与丙丗丝不丈东)
    {
        CameraTouchControlSchemeConfigurator.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public CameraTouchControlSchemeConfigurator()
    {
    
    }

}
