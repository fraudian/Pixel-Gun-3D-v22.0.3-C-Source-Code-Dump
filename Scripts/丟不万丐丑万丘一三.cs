using UnityEngine;
public static class 丟不万丐丑万丘一三
{
    // Methods
    public static void 世业丒万丘丆专丘丐()
    {
    
    }
    public static void 且且丂丛不下丆丙丐(string 东一丁专丐丘丝专与, string 三专三丛丒丐业丟七)
    {
        UnityEngine.Debug.Log(message:  东一丁专丐丘丝专与 + "\nCPAPI:{\"cmd\":\"Filter\" \"name\":\""("\nCPAPI:{\"cmd\":\"Filter\" \"name\":\"") + 三专三丛丒丐业丟七 + "\"}");
    }
    public static void 世丐丟丕一七丁专一(string 且丄业丞丐丄东丕丞, string 三丒万东不丄丏丏一)
    {
        string[] val_1 = new string[6];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(且丄业丞丐丄东丕丞 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(且丄业丞丐丄东丕丞 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 且丄业丞丐丄东丕丞;
        val_1[1] = " : ";
        val_1[2] = 三丒万东不丄丏丏一;
        val_1[3] = "\nCPAPI:{\"cmd\":\"Watch\" \"name\":\"";
        val_1[4] = 且丄业丞丐丄东丕丞;
        val_1[5] = "\"}";
        UnityEngine.Debug.Log(message:  +val_1);
    }
    public static void 丝一丏丞丌七丕世丕(string 丗世丘丒七丗专丕七)
    {
        UnityEngine.Debug.Log(message:  "\nCPAPI:{\"cmd\":\"Search\" \"text\":\""("\nCPAPI:{\"cmd\":\"Search\" \"text\":\"") + 丗世丘丒七丗专丕七 + "\"}");
    }

}
