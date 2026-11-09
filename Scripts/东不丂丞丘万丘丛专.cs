using UnityEngine;
private sealed class FriendsWindowController.东不丂丞丘万丘丛专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FriendsWindowController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendsWindowController.东不丂丞丘万丘丛专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        FriendsWindowController val_21;
        var val_22;
        string val_23;
        object val_24;
        string val_25;
        object val_26;
        string val_27;
        UIScrollView val_28;
        object val_29;
        val_21 = this;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_21 = this.丝且与丝丒丟万丁专;
        val_22 = null;
        val_22 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return false;
        }
        
        if(val_21 != null)
        {
                val_21.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  0, 上丗与不丑丄丞丆业:  false);
            val_21.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  1, 上丗与不丑丄丞丆业:  false);
            val_21.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  3, 上丗与不丑丄丞丆业:  false);
            val_21.上世丞丟丑业丌世丂(上丗与不丑丄丞丆业:  false);
        }
        else
        {
                0.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  0, 上丗与不丑丄丞丆业:  false);
            0.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  1, 上丗与不丑丄丞丆业:  false);
            0.不丁丙丞丄丂三丗丝(丏业丟一东丂东丘丛:  3, 上丗与不丑丄丞丆业:  false);
            0.上世丞丟丑业丌世丂(上丗与不丑丄丞丆业:  false);
        }
        
        if(this.丝且与丝丒丟万丁专.丏丕丅丂丑业一世丂 == true)
        {
            goto label_9;
        }
        
        this.丝且与丝丒丟万丁专.inviteFriendsWrap.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  val_21, 丛丌丙世专世东丕下:  System.Void FriendsWindowController::丟丙丟丕丗且七且上(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
        this.丝且与丝丒丟万丁专.friendsListWrap.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  val_21, 丛丌丙世专世东丕下:  System.Void FriendsWindowController::丝专万丐丐万丒世丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
        this.丝且与丝丒丟万丁专.findFriendsWrap.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  val_21, 丛丌丙世专世东丕下:  System.Void FriendsWindowController::丐丛丞丞丞丐丕丅七(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
        val_23 = public UIScrollView UnityEngine.Component::GetComponent<UIScrollView>();
        UIScrollView val_7 = this.丝且与丝丒丟万丁专.inviteFriendsWrap.GetComponent<UIScrollView>();
        val_6.scrollView = val_7;
        val_24 = 0;
        goto label_17;
        label_22:
        val_23 = "FriendPreviewItem_" + val_24;
        不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  val_7.gameObject, 丑且不丕与专丄业丙:  this.丝且与丝丒丟万丁专.friendPreviewPrefab).name = val_23;
        val_24 = 1;
        label_17:
        if(val_24 < 6)
        {
            goto label_22;
        }
        
        val_25 = public UIScrollView UnityEngine.Component::GetComponent<UIScrollView>();
        UIScrollView val_11 = this.丝且与丝丒丟万丁专.friendsListWrap.GetComponent<UIScrollView>();
        val_26 = 0;
        val_6.scrollView = val_11;
        goto label_25;
        label_30:
        val_25 = "FriendPreviewItem_" + val_26;
        不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  val_11.gameObject, 丑且不丕与专丄业丙:  this.丝且与丝丒丟万丁专.friendPreviewPrefab).name = val_25;
        val_26 = 1;
        label_25:
        if(val_26 < 6)
        {
            goto label_30;
        }
        
        val_27 = public UIScrollView UnityEngine.Component::GetComponent<UIScrollView>();
        val_28 = this.丝且与丝丒丟万丁专.findFriendsWrap.GetComponent<UIScrollView>();
        val_29 = 0;
        val_6.scrollView = val_28;
        goto label_33;
        label_38:
        val_28 = "FriendPreviewItem_" + val_29;
        val_27 = val_28;
        不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.丝且与丝丒丟万丁专.friendPreviewPrefab.transform.GetComponent<UIDragScrollView>().gameObject, 丑且不丕与专丄业丙:  this.丝且与丝丒丟万丁专.friendPreviewPrefab).name = val_27;
        val_29 = 1;
        label_33:
        if(val_29 < 6)
        {
            goto label_38;
        }
        
        this.丝且与丝丒丟万丁专.丏丕丅丂丑业一世丂 = true;
        label_9:
        if(this.丝且与丝丒丟万丁专.丗丒七丁丙丝丘世丅 != 2)
        {
                val_21.丕万丆丁丅丁丄世丏(上丈世丁丐丒业上世:  val_21.东三世万丌下丘丈丝(), 丏三丅世世一业专与:  val_21.与丆东不丞丒万丏且());
        }
        
        val_21.丏丌一丌丅丄丏业丐(丙业与丙丗丝不丈东:  false);
        return false;
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
