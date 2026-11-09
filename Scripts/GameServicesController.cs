using UnityEngine;
internal sealed class GameServicesController : MonoBehaviour
{
    // Fields
    private static GameServicesController 丝业丆丁业三丈丟东;
    
    // Properties
    internal static GameServicesController 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static GameServicesController 丑七不且上丗丁一世()
    {
        return (GameServicesController)GameServicesController.丝业丆丁业三丈丟东;
    }
    public void WaitAuthenticationAndIncrementBeginnerAchievement()
    {
        var val_10;
        Rilisoft.丝丟丄丅与业世专丈 val_1 = null;
        val_10 = val_1;
        val_1 = new Rilisoft.丝丟丄丅与业世专丈(丕丗丘丑丛与丑业丒:  "WaitAuthenticationAndIncrementBeginnerAchievement()");
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  GameServicesController.丐丅丄专丞世丙下丂());
        if(val_10 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            val_1.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_10 = ???;
    }
    private static System.Collections.IEnumerator 丐丅丄专丞世丙下丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new GameServicesController.与丞丅丘丟丄丒丁丐();
    }
    private void Awake()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  GameServicesController.丝业丆丁业三丈丟东, y:  0);
        GameServicesController.丝业丆丁业三丈丟东 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public GameServicesController()
    {
    
    }

}
