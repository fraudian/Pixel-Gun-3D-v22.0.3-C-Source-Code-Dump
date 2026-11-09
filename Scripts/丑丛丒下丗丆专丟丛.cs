using UnityEngine;
private sealed class PrivateChatController.丑丛丒下丗丆专丟丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PrivateChatController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PrivateChatController.丑丛丒下丗丆专丟丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_27;
        PrivateChatController.丑丛丒下丗丆专丟丛 val_28;
        var val_29;
        var val_30;
        var val_31;
        System.Collections.Generic.List<System.String> val_32;
        string val_33;
        string val_34;
        int val_35;
        val_28 = this;
        val_29 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_29;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丟下丞丗丂三东三下.Clear();
        val_30 = 1152921524493730496;
        val_31 = 0;
        goto label_5;
        label_19:
        string val_3 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Item[0];
        val_32 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄();
        if((val_32.ContainsKey(key:  val_3)) != false)
        {
                val_32 = this.丝且与丝丒丟万丁专.丟下丞丗丂三东三下;
            val_32.Add(item:  val_3);
        }
        
        val_31 = 1;
        label_5:
        if(val_31 < 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Count)
        {
            goto label_19;
        }
        
        if(this.丝且与丝丒丟万丁专.丏丕丅丂丑业一世丂 != true)
        {
                this.丝且与丝丒丟万丁专.friendsWrap.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this.丝且与丝丒丟万丁专, 丛丌丙世专世东丕下:  System.Void PrivateChatController::丝丁丅丈丁丁丂业丝(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
            UIDragScrollView val_12 = this.丝且与丝丒丟万丁专.friendPreviewPrefab.transform.GetComponent<UIDragScrollView>();
            val_12.scrollView = this.丝且与丝丒丟万丁专.friendsWrap.GetComponent<UIScrollView>();
            val_30 = 1152921504622075904;
            do
        {
            UnityEngine.GameObject val_15 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.丝且与丝丒丟万丁专.friendsWrap.gameObject, 丑且不丕与专丄业丙:  this.丝且与丝丒丟万丁专.friendPreviewPrefab);
            string val_16 = "FriendPreviewItem_" + 0;
            if(val_15 != null)
        {
                val_15.name = val_16;
        }
        else
        {
                0.name = val_16;
        }
        
            UIToggle val_17 = val_15.GetComponent<UIToggle>();
            val_17.group = 3;
            FriendPrevInChatItem val_18 = val_15.GetComponent<FriendPrevInChatItem>();
            val_32 = 0 + 1;
            val_18.丌丅丘丏万丟上丕万 = false;
        }
        while(val_32 != 16);
        
            this.丝且与丝丒丟万丁专.scrollFriends.ResetPosition();
            val_28 = val_28;
            this.丝且与丝丒丟万丁专.丏丕丅丂丑业一世丂 = true;
        }
        
        System.Collections.Generic.List<System.String> val_19 = new System.Collections.Generic.List<System.String>(collection:  this.丝且与丝丒丟万丁专.丟下丞丗丂三东三下);
        this.丝且与丝丒丟万丁专.专丒丏丆一不丅丁丗 = val_19;
        val_19.Sort(comparison:  new System.Comparison<System.String>(object:  this.丝且与丝丒丟万丁专, method:  System.Int32 PrivateChatController::丞东且下三不丐上世(string 三丟东丕丄丄下下丑, string 丒丒丄丁且丄丆丂丌)));
        this.丝且与丝丒丟万丁专.friendsWrap.minIndex = -this.丝且与丝丒丟万丁专.专丒丏丆一不丅丁丗.Count;
        val_33 = this.丝且与丝丒丟万丁专.friendsWrap.GetComponentsInChildren<FriendPrevInChatItem>(includeInactive:  true);
        val_27 = 0;
        goto label_42;
        label_46:
        this.丝且与丝丒丟万丁专.丞丙丞丅丘七丅不世(七丘丛下丒丅且丕且:  val_33[0]);
        val_27 = 1;
        label_42:
        if(val_27 < val_22.Length)
        {
            goto label_46;
        }
        
        val_34 = 0;
        if((System.String.IsNullOrEmpty(value:  this.丝且与丝丒丟万丁专.selectedPlayerID)) != true)
        {
                val_33 = this.丝且与丝丒丟万丁专.selectedPlayerID;
            val_34 = val_33;
            if((丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Contains(item:  val_34)) != true)
        {
                this.丝且与丝丒丟万丁专.selectedPlayerID = System.String.alignConst;
            this.丝且与丝丒丟万丁专.SetSelectedPlayer(丈丆丆丂且丝东丏丂:  System.String.alignConst, 丐世丐上丁与丌七丒:  false);
            this.丝且与丝丒丟万丁专.OnKeyboardHide();
            val_33 = this.丝且与丝丒丟万丁专.sendMessageInput;
            val_34 = 0;
            val_33.DeselectInput();
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丏丕丅丂丑业一世丂 != false)
        {
                val_33 = this.丝且与丝丒丟万丁专.friendsWrap;
            this.丝且与丝丒丟万丁专.scrollFriends.ResetPosition();
        }
        
        val_35 = 1;
        val_29 = 1;
        mem[1152921535978626280] = 0;
        goto label_58;
        label_1:
        val_35 = 0;
        label_58:
        this.丗丏丅丕丆世丁专丟 = val_35;
        return (bool)val_29;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
