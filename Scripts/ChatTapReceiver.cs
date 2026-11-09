using UnityEngine;
public class ChatTapReceiver : MonoBehaviour
{
    // Fields
    private static System.Action<ChatTapReceiver> 下东丘丆丗东丑丗七;
    private static System.Action 上丗丒丘丘一丏丕丏;
    
    // Properties
    private static bool 上丄丐丕丘业三丟丙 { get; }
    
    // Methods
    internal static void 丝丘丝丏丏东丅专丂(System.Action<ChatTapReceiver> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ChatTapReceiver.下东丘丆丗东丑丗七, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丑丁世一世丝丈丒丅(System.Action<ChatTapReceiver> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ChatTapReceiver.下东丘丆丗东丑丗七, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 万丝丐万丆丒丘丁丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  ChatTapReceiver.上丗丒丘丘一丏丕丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(ChatTapReceiver.上丗丒丘丘一丏丕丏 != 1152921505047531528);
    
    }
    internal static void 丌丌上丏上丙与世丒(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  ChatTapReceiver.上丗丒丘丘一丏丕丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(ChatTapReceiver.上丗丒丘丘一丏丕丏 != 1152921505047531528);
    
    }
    private void Start()
    {
        this.丌世丆丂丐丑丁丟丕();
        与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万().专丒一一上丘丄东且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ChatTapReceiver::丌世丆丂丐丑丁丟丕()));
        if(ChatTapReceiver.下东丘丆丗东丑丗七 != null)
        {
                ChatTapReceiver.下东丘丆丗东丑丗七.Invoke(obj:  this);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  ChatTapReceiver.丝丄丘丗上丐丘丝一());
    }
    private void 丌世丆丂丐丑丁丟丕()
    {
        bool val_3 = ChatTapReceiver.丝丄丘丗上丐丘丝一();
        this.gameObject.SetActive(value:  val_3);
        if((val_3 & (~this.gameObject.activeSelf)) == false)
        {
                return;
        }
        
        if(ChatTapReceiver.下东丘丆丗东丑丗七 == null)
        {
                return;
        }
        
        ChatTapReceiver.下东丘丆丗东丑丗七.Invoke(obj:  this);
    }
    private static bool 丝丄丘丗上丐丘丝一()
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return false;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万().世三丞丅丑丌丈丈一() == false)
        {
                return false;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
                return PGCompany.丁东丌世与丕东丆上.一丘且丑丟丒丗丐丏();
        }
        
        return false;
    }
    private void OnDestroy()
    {
        与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万().不丘丄三丒丟万丅丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ChatTapReceiver::丌世丆丂丐丑丁丟丕()));
    }
    private void OnClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(ChatTapReceiver.上丗丒丘丘一丏丕丏 == null)
        {
                return;
        }
        
        ChatTapReceiver.上丗丒丘丘一丏丕丏.Invoke();
    }
    public ChatTapReceiver()
    {
    
    }

}
