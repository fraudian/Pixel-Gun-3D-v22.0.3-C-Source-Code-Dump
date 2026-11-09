using UnityEngine;
internal sealed class TmpPrefsFilesCleaner : MonoBehaviour
{
    // Fields
    private static TmpPrefsFilesCleaner 丝业丆丁业三丈丟东;
    
    // Properties
    internal static TmpPrefsFilesCleaner 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static TmpPrefsFilesCleaner 丑七不且上丗丁一世()
    {
        var val_4;
        TmpPrefsFilesCleaner val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = TmpPrefsFilesCleaner.丝业丆丁业三丈丟东;
        if(val_5 == 0)
        {
                UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "TmpPrefsFilesCleaner");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            val_6 = null;
            val_5 = val_2.AddComponent<TmpPrefsFilesCleaner>();
            val_6 = null;
            TmpPrefsFilesCleaner.丝业丆丁业三丈丟东 = val_5;
        }
        
        val_7 = null;
        val_7 = null;
        return (TmpPrefsFilesCleaner)TmpPrefsFilesCleaner.丝业丆丁业三丈丟东;
    }
    private void Start()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(val_1 != 8)
        {
                return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.丏丛不下一丝专丕丙());
    }
    private System.Collections.IEnumerator 丏丛不下一丝专丕丙()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new TmpPrefsFilesCleaner.丝丄丈丝不丒一丌丆();
    }
    public TmpPrefsFilesCleaner()
    {
    
    }
    private static TmpPrefsFilesCleaner()
    {
    
    }

}
