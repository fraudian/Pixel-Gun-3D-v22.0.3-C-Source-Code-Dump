using UnityEngine;
private sealed class FriendProfileView.万丂上丂丝下丘世专
{
    // Fields
    public bool 丝三丄专丗丞丄丄丌;
    public FriendProfileView 丝且与丝丒丟万丁专;
    
    // Methods
    public FriendProfileView.万丂上丂丝下丘世专()
    {
    
    }
    internal void 丅丑丐不一丝丟万东(UnityEngine.GameObject 丄三丅七丆丛与与上)
    {
        Rilisoft.丛丅丘业丏丕下业丏.东丒万丘丆丐世丕丗(丝三丁东丈丒世丅业:  丄三丅七丆丛与与上, 下下东且万业丞丅丒:  (this.丝三丄专丗丞丄丄丌 == false) ? 1 : 0);
    }
    internal void 专丐丈东丒丙丙且七(UILabel 丐三丞七丝丅不万丛)
    {
        string val_1 = this.丝且与丝丒丟万丁专.FriendName;
        if(val_1 == null)
        {
            goto label_2;
        }
        
        label_5:
        丐三丞七丝丅不万丛.text = val_1;
        return;
        label_2:
        if(丐三丞七丝丅不万丛 != null)
        {
            goto label_5;
        }
        
        goto label_5;
    }

}
