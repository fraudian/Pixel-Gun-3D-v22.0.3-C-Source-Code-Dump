using UnityEngine;
public class ChatAnimator : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject SendButton;
    public UIPanel StickersPanel;
    public bool isKeyboardShow;
    public bool isStickersShow;
    private bool 丗丂丐万丅丄丗万丒;
    public UIWidget ButtonSmiles;
    public UIWidget ChatInput;
    public UIWidget ChatText;
    public UnityEngine.Transform LeftContainer;
    public UnityEngine.Transform RightContainer;
    public UnityEngine.Transform Stickers;
    public int KeyBoardHeight;
    public float animTime;
    public float animTimer;
    private bool 丄一一丑业丒丛丗七;
    private UnityEngine.Vector3[] 丌丈丁业一世丘万丝;
    private const int 丑与丆一丄丒七且丁 = 76;
    
    // Properties
    private UnityEngine.Vector3[] 丅丗丟丛专三丙丒三 { get; }
    
    // Methods
    private UnityEngine.Vector3[] 丁与上三下丄丐丕丒()
    {
        UnityEngine.Vector3[] val_4;
        if(this.丄一一丑业丒丛丗七 != false)
        {
                val_4 = this.丌丈丁业一世丘万丝;
            return (UnityEngine.Vector3[])this.丌丈丁业一世丘万丝;
        }
        
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[2];
        val_4 = this;
        this.丌丈丁业一世丘万丝 = val_1;
        UnityEngine.Vector3 val_2 = this.LeftContainer.localPosition;
        val_1[0] = val_2;
        val_1[0] = val_2.y;
        val_1[1] = val_2.z;
        UnityEngine.Vector3 val_3 = this.RightContainer.localPosition;
        this.丌丈丁业一世丘万丝[1] = val_3;
        this.丌丈丁业一世丘万丝[1] = val_3.y;
        this.丌丈丁业一世丘万丝[1] = val_3.z;
        this.丄一一丑业丒丛丗七 = true;
        return (UnityEngine.Vector3[])this.丌丈丁业一世丘万丝;
    }
    public void ShowKeyboard()
    {
        bool val_20;
        if(this.isKeyboardShow == true)
        {
                return;
        }
        
        val_20 = 1152921504848912384;
        if(this.LeftContainer == 0)
        {
                return;
        }
        
        if(this.RightContainer == 0)
        {
                return;
        }
        
        UnityEngine.Vector3[] val_3 = this.丁与上三下丄丐丕丒();
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
        int val_23 = this.KeyBoardHeight;
        val_23 = val_23 - 76;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  (float)val_23);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3[0], y = val_3[0], z = val_3[1]}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        this.LeftContainer.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3[] val_7 = this.丁与上三下丄丐丕丒();
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
        int val_10 = this.KeyBoardHeight + this.ChatInput.height;
        val_10 = val_10 - 78;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  (float)val_10);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7[1], y = val_7[2], z = val_7[2]}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        this.RightContainer.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        mem2[0] = 274;
        this.ChatInput.ResetAnchors();
        this.ChatInput.UpdateAnchors();
        mem2[0] = 5;
        mem2[0] = 175;
        this.ChatText.ResetAnchors();
        this.ChatText.UpdateAnchors();
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.left;
        int val_15 = this.ChatInput.width;
        int val_16 = this.ButtonSmiles.width;
        var val_17 = (val_15 < 0) ? (val_15 + 1) : (val_15);
        val_17 = val_17 >> 1;
        val_17 = val_17 - (((val_16 < 0) ? (val_16 + 1) : (val_16)) >> 1);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  (float)val_17);
        this.ButtonSmiles.transform.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        val_20 = true;
        this.SendButton.SetActive(value:  true);
        this.isKeyboardShow = val_20;
    }
    public void HideKeyboard()
    {
        var val_12;
        if(this.isKeyboardShow == false)
        {
                return;
        }
        
        val_12 = 1152921504848912384;
        if(this.LeftContainer == 0)
        {
                return;
        }
        
        if(this.RightContainer == 0)
        {
                return;
        }
        
        UnityEngine.Vector3[] val_3 = this.丁与上三下丄丐丕丒();
        this.LeftContainer.localPosition = new UnityEngine.Vector3() {x = val_3[0], y = val_3[0], z = val_3[1]};
        UnityEngine.Vector3[] val_4 = this.丁与上三下丄丐丕丒();
        this.RightContainer.localPosition = new UnityEngine.Vector3() {x = val_4[1], y = val_4[2], z = val_4[2]};
        mem2[0] = 0;
        this.ChatInput.ResetAnchors();
        this.ChatInput.UpdateAnchors();
        mem2[0] = 174;
        mem2[0] = 6;
        this.ChatText.ResetAnchors();
        this.ChatText.UpdateAnchors();
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.right;
        val_12 = this.ChatInput.width;
        int val_8 = this.ButtonSmiles.width;
        var val_9 = (val_12 < 0) ? (val_12 + 1) : (val_12);
        val_9 = val_9 >> 1;
        val_9 = val_9 - (((val_8 < 0) ? (val_8 + 1) : (val_8)) >> 1);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  (float)val_9);
        this.ButtonSmiles.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        this.SendButton.SetActive(value:  false);
        this.isKeyboardShow = false;
    }
    private System.Collections.IEnumerator 丒丘丐丛七且东丆三()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ChatAnimator.丈不与丟七丟上丒丒();
    }
    public void ShowStickers()
    {
        if(this.isStickersShow == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = this.Stickers.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  158f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.Stickers.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.StickersPanel.SetDirty();
        this.StickersPanel.Refresh();
        this.isStickersShow = true;
    }
    public void HideStickers()
    {
        if(this.isStickersShow == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = this.Stickers.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  158f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.Stickers.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.isStickersShow = false;
    }
    public ChatAnimator()
    {
        this.KeyBoardHeight = 400;
        this.animTime = 1f;
    }

}
