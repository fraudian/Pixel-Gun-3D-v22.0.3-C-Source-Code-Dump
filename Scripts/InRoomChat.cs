using UnityEngine;
public class InRoomChat : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    public UnityEngine.Rect GuiRect;
    public bool IsVisible;
    public bool AlignBottom;
    public System.Collections.Generic.List<string> messages;
    private string 丕专丘七七丝丘不丞;
    private UnityEngine.Vector2 丙不丑丈丂丒丝丛七;
    public static readonly string ChatRPC;
    
    // Methods
    public void Start()
    {
        if(this.AlignBottom == false)
        {
                return;
        }
        
        float val_2 = (float)UnityEngine.Screen.height - S0;
    }
    public void OnGUI()
    {
        string val_20;
        string val_21;
        if(this.IsVisible == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.一上下丆世丛丌丆丞() == false)
        {
                return;
        }
        
        if(UnityEngine.Event.current.type != 4)
        {
            goto label_10;
        }
        
        if(UnityEngine.Event.current.keyCode != 271)
        {
                if(UnityEngine.Event.current.keyCode != 13)
        {
            goto label_10;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.丕专丘七七丝丘不丞)) == false)
        {
            goto label_11;
        }
        
        UnityEngine.GUI.FocusControl(name:  "ChatInput");
        label_10:
        UnityEngine.GUI.SetNextControlName(name:  "");
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.GuiRect});
        UnityEngine.Vector2 val_10 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.丙不丑丈丂丒丝丛七, y = V9.16B}, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.丙不丑丈丂丒丝丛七 = val_10;
        mem[1152921535612025132] = val_10.y;
        UnityEngine.GUILayout.FlexibleSpace();
        System.Collections.Generic.List<System.String> val_20 = this.messages;
        val_20 = val_20.Count - 1;
        if((val_20 & 2147483648) == 0)
        {
                do
        {
            UnityEngine.GUILayout.Label(text:  this.messages.Item[val_20], options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            val_20 = val_20 - 1;
        }
        while((val_20 & 2147483648) == 0);
        
        }
        
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUI.SetNextControlName(name:  "ChatInput");
        this.丕专丘七七丝丘不丞 = UnityEngine.GUILayout.TextField(text:  this.丕专丘七七丝丘不丞, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_17 = new UnityEngine.GUILayoutOption[1];
        val_17[0] = UnityEngine.GUILayout.ExpandWidth(expand:  false);
        if((UnityEngine.GUILayout.Button(text:  "Send", options:  val_17)) != false)
        {
                val_20 = "";
            this.丕专丘七七丝丘不丞 = val_20;
            val_20 = "";
            UnityEngine.GUI.FocusControl(name:  val_20);
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndArea();
        return;
        label_11:
        val_21 = "";
        this.丕专丘七七丝丘不丞 = val_21;
        val_21 = "";
        UnityEngine.GUI.FocusControl(name:  val_21);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    internal void Chat(string 三丌万业上丘丛丟且, 业丘丘丘丁丂丕万东 丞丟世丅世业丝丑丆)
    {
        与丅丕丈丘东丝世丟 val_7;
        var val_8;
        val_7 = 1152921535612604800;
        if(丞丟世丅世业丝丑丆.不丟丗丏丛丕不丁丌 == null)
        {
            goto label_1;
        }
        
        val_7 = 丞丟世丅世业丝丑丆.不丟丗丏丛丕不丁丌;
        if((System.String.IsNullOrEmpty(value:  丞丟世丅世业丝丑丆.不丟丗丏丛丕不丁丌.丁下不丛下且丌专丈())) == false)
        {
            goto label_2;
        }
        
        string val_4 = "player " + 丞丟世丅世业丝丑丆.不丟丗丏丛丕不丁丌.业丐丐三丕一丗丛丁();
        goto label_5;
        label_1:
        val_8 = "anonymous";
        goto label_5;
        label_2:
        label_5:
        this.messages.Add(item:  丞丟世丅世业丝丑丆.不丟丗丏丛丕不丁丌.丁下不丛下且丌专丈() + ": "(": ") + 三丌万业上丘丛丟且);
    }
    public void AddLine(string 三丌万业上丘丛丟且)
    {
        this.messages.Add(item:  三丌万业上丘丛丟且);
    }
    public InRoomChat()
    {
        this.IsVisible = true;
        this.GuiRect = 0;
        mem[1152921535612854132] = 0;
        mem[1152921535612854140] = 0;
        this.messages = new System.Collections.Generic.List<System.String>();
        this.丕专丘七七丝丘不丞 = "";
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.丙不丑丈丂丒丝丛七 = val_2;
        mem[1152921535612854172] = val_2.y;
    }
    private static InRoomChat()
    {
        InRoomChat.ChatRPC = "Chat";
    }

}
