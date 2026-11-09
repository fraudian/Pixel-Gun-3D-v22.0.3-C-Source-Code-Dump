using UnityEngine;
internal sealed class SelectableButtonColor : PGBehaviour
{
    // Fields
    private SelectableButton selectableButton;
    public UnityEngine.Color selectedColor;
    public UnityEngine.Color notSelectedColor;
    public System.Collections.Generic.List<UIWidget> colorRessivers;
    
    // Methods
    private void OnEnable()
    {
        this.selectableButton.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SelectableButtonColor::OnSelect()));
        this.OnSelect();
    }
    private void OnDisable()
    {
        this.selectableButton.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SelectableButtonColor::OnSelect()));
    }
    private void OnSelect()
    {
        var val_3 = this;
        .丄三下丞七世业专三 = this.notSelectedColor;
        mem[1152921538913099780] = ???;
        mem[1152921538913099784] = ???;
        mem[1152921538913099788] = ???;
        if(this.selectableButton.selected != false)
        {
                .丄三下丞七世业专三 = this.selectedColor;
        }
        
        this.colorRessivers.ForEach(action:  new System.Action<UIWidget>(object:  new SelectableButtonColor.丘丞上世丗丘丏丐东(), method:  System.Void SelectableButtonColor.丘丞上世丗丘丏丐东::不丑丟万丟东丗丘不(UIWidget 丐丅丆丒丌丞丝丏不)));
    }
    public SelectableButtonColor()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.yellow;
        this.selectedColor = val_1;
        mem[1152921538913196228] = val_1.g;
        mem[1152921538913196232] = val_1.b;
        mem[1152921538913196236] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.notSelectedColor = val_2;
        mem[1152921538913196244] = val_2.g;
        mem[1152921538913196248] = val_2.b;
        mem[1152921538913196252] = val_2.a;
    }

}
