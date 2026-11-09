using UnityEngine;
internal sealed class RemotePushNotificationController : MonoBehaviour
{
    // Fields
    private static RemotePushNotificationController <不丁丄七丛不丆丁丕>k__BackingField;
    internal static bool 丛万丑七世丄万丘丛;
    private bool 业业丄丛不专与一丒;
    private bool 上专丗丁丐丅丅世丐;
    private const string 万七世上上丐丛丂且 = "RemotePushRegistration";
    
    // Properties
    internal static RemotePushNotificationController 丆丕丝丒不丙且丐丗 { get; set; }
    private string 丕丝丁世世丂一丒业 { get; }
    private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    
    // Methods
    internal static RemotePushNotificationController 丑七不且上丗丁一世()
    {
        null = null;
        return (RemotePushNotificationController)RemotePushNotificationController.万七世上上丐丛丂且;
    }
    private static void 丒且丒丗丗丟下丗丝(RemotePushNotificationController 丙业与丙丗丝不丈东)
    {
        null = null;
        RemotePushNotificationController.万七世上上丐丛丂且 = 丙业与丙丗丝不丈东;
    }
    private void 丙丒东与专丐丆万丘(string 丕丙丈下丌万与一丛)
    {
        var val_3 = null;
        if(RemotePushNotificationController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "[RemotePushNotificationController.OnRegistrationSucceeded] deviceToken: "("[RemotePushNotificationController.OnRegistrationSucceeded] deviceToken: ") + 丕丙丈下丌万与一丛);
    }
    private void 丂丐丐丘丘丙丌丅丟(string 丒丄丝不丄专丕与丕)
    {
        if(UnityEngine.Application.isEditor == true)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "RemotePushNotificationController(OnRegistrationFailed): errorMessage = "("RemotePushNotificationController(OnRegistrationFailed): errorMessage = ") + 丒丄丝不丄专丕与丕);
    }
    public void RegisterNotificationIos()
    {
        var val_6 = null;
        if(RemotePushNotificationController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[RemotePushNotificationController.RegisterNotificationIos]");
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
        {
                return;
        }
        
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.业丅丙丝丒丟丑丑丂());
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RemotePushNotificationController.丆丄业丗东且丟丌丝();
    }
    internal void 丂丟世三丞丒丈丆丅(string 丑丞东万丁丂丏万丙 = "")
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[RemotePushNotificationController.UpdateDataOnServer] callerName: "("[RemotePushNotificationController.UpdateDataOnServer] callerName: ") + 丑丞东万丁丂丏万丙);
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
        {
                PGCompany.Messaging.专丒七丌丟丘上业专.丑七不且上丗丁一世().丄不专丘三丗丛丂七();
            PGCompany.Messaging.专丒七丌丟丘上业专.丑七不且上丗丁一世().业东丝丘丛丁不丏丞();
            return;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
        {
                return;
        }
        
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.专丐丁世下丕一丑世());
    }
    private static Rilisoft.RemotePushRegistrationMemento 丝七七一世丝丙丞丏(string 且丙万丝丕丏丙专丟)
    {
        string val_2;
        string val_3;
        Rilisoft.RemotePushRegistrationMemento val_0;
        Rilisoft.RemotePushRegistrationMemento val_1 = UnityEngine.JsonUtility.FromJson<Rilisoft.RemotePushRegistrationMemento>(json:  且丙万丝丕丏丙专丟);
        val_0.version = val_2;
        val_0.registrationId = val_3;
        return val_0;
    }
    private static Rilisoft.RemotePushRegistrationMemento 万业丈丟丈世丆丗丌()
    {
        return RemotePushNotificationController.丝七七一世丝丙丞丏(且丙万丝丕丏丙专丟:  UnityEngine.PlayerPrefs.GetString(key:  "RemotePushRegistration", defaultValue:  "{}"));
    }
    private string 丘丆丞不丞丛三七丟()
    {
        return "https://secure.pixelgunserver.com/push_service";
    }
    private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
    {
        return System.Globalization.CultureInfo.InvariantCulture;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    private System.Collections.IEnumerator 业丄丟丐丘丑上不与()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RemotePushNotificationController.丕万丒世且丂万丌丂();
    }
    private System.Collections.IEnumerator 丂不丏丙丝丐丂丑丗(string 不丒三业下丑不丞业)
    {
        RemotePushNotificationController.且丒丙七三丏七丘丗 val_1 = new RemotePushNotificationController.且丒丙七三丏七丘丗();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 专丐丁世下丕一丑世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RemotePushNotificationController.丈不丄东丐东丑丈丆();
    }
    private System.Collections.IEnumerator 丐丁丂七下丄东丏一(string 丄丒且丙三丆丟与丏, System.DateTime 一丏一世丘丐丁丄丟, string 丞丞丐丝丝丏丐丛丞, int 三世东丅丁世且专不, string 不丒三业下丑不丞业, string 丑丞东万丁丂丏万丙 = "")
    {
        RemotePushNotificationController.丟万丗上世丄与七丒 val_1 = new RemotePushNotificationController.丟万丗上世丄与七丒();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .一丏一世丘丐丁丄丟 = 一丏一世丘丐丁丄丟;
            .丞丞丐丝丝丏丐丛丞 = 丞丞丐丝丝丏丐丛丞;
            .三世东丅丁世且专不 = 三世东丅丁世且专不;
            .丄丒且丙三丆丟与丏 = 丄丒且丙三丆丟与丏;
            .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
        }
        else
        {
                mem[40] = 丄丒且丙三丆丟与丏;
            mem[80] = 一丏一世丘丐丁丄丟.dateData;
            mem[64] = 丞丞丐丝丝丏丐丛丞;
            mem[72] = 三世东丅丁世且专不;
            mem[48] = 不丒三业下丑不丞业;
        }
        
        .丑丞东万丁丂丏万丙 = 丑丞东万丁丂丏万丙;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 业丅丙丝丒丟丑丑丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RemotePushNotificationController.丄丒与且丑业与且丕();
    }
    public RemotePushNotificationController()
    {
    
    }
    private static RemotePushNotificationController()
    {
    
    }

}
