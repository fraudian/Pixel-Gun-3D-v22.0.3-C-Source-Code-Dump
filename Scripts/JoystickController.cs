using UnityEngine;
internal sealed class JoystickController : MonoBehaviour
{
    // Fields
    internal static UIJoystick 丗三丄与丂丟丌专东;
    internal static TouchPadController 丘万丏三丏丑世丐丏;
    internal static TouchPadInJoystick 世万丁丆业业丘丘丌;
    public UIJoystick _leftJoystick;
    public TouchPadController _rightJoystick;
    public TouchPadInJoystick _leftTouchPad;
    
    // Methods
    private void Awake()
    {
        null = null;
        JoystickController.丗三丄与丂丟丌专东 = this._leftJoystick;
        JoystickController.丘万丏三丏丑世丐丏 = this._rightJoystick;
        JoystickController.世万丁丆业业丘丘丌 = this._leftTouchPad;
    }
    internal static bool 下丑不丘丑丟丅七丙()
    {
        var val_4;
        LeftFireTouchButton val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = mem[JoystickController.世万丁丆业业丘丘丌 + 40];
        val_5 = JoystickController.世万丁丆业业丘丘丌.fireTouch;
        if(isPressed != false)
        {
                val_6 = 0;
        }
        else
        {
                val_7 = null;
            val_7 = null;
            val_5 = mem[JoystickController.丘万丏三丏丑世丐丏 + 160];
            val_5 = JoystickController.丘万丏三丏丑世丐丏.fireTouch;
            bool val_2 = isPressed;
            val_6 = val_2 ^ 1;
        }
        
        val_2 = val_6;
        return (bool)val_2;
    }
    public JoystickController()
    {
    
    }
    private static JoystickController()
    {
    
    }

}
