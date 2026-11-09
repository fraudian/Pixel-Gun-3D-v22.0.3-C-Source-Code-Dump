using UnityEngine;
public class 东丄且丈丈丒丙丁业
{
    // Properties
    public static string 丐下丛世下一丂丌丑 { get; }
    public static int 专东丄丁丄丌丏三一 { get; }
    
    // Methods
    public static string 丝丝三丏丈丁丏丘丗()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        return (string)val_1.m_Handle.name;
    }
    public static int 丂上丈上上丌丁上丐()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        return (int)val_1.m_Handle.buildIndex;
    }
    public 东丄且丈丈丒丙丁业()
    {
    
    }

}
