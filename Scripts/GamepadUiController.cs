using UnityEngine;
public class GamepadUiController : PGBehaviour
{
    // Fields
    internal static GamepadUiController 丆丕丝丒不丙且丐丗;
    internal UnityEngine.Camera RendererCamera;
    internal GamepadDisconnectIndicator DisconnectedIndicator;
    
    // Methods
    private void Awake()
    {
        GamepadUiController.丆丕丝丒不丙且丐丗 = this;
    }
    public GamepadUiController()
    {
    
    }

}
