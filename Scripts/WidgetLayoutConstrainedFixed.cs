using UnityEngine;
internal sealed class WidgetLayoutConstrainedFixed : PGBehaviour
{
    // Fields
    private WidgetLayout mainLayout;
    private WidgetLayout fixedLayout;
    private WidgetLayoutConstrained constrainedLyout;
    private UIWidget holderWidget;
    private UIWidget constrainedWidget;
    
    // Methods
    internal void 丁下丏丙一丗下丈七()
    {
        this.fixedLayout.Reposition();
        this.constrainedWidget.width = this.holderWidget.width - (int)this.fixedLayout.GetSize();
        this.constrainedWidget.ResetAndUpdateAnchors();
        this.constrainedLyout.Reposition();
        this.mainLayout.Reposition();
    }
    public WidgetLayoutConstrainedFixed()
    {
    
    }

}
