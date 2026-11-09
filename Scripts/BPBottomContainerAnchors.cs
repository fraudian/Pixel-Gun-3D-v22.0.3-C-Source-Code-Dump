using UnityEngine;
internal class BPBottomContainerAnchors : MonoBehaviour
{
    // Fields
    private UIWidget _widgetTarget;
    private int _leftAnchor;
    private int _rightAnchor;
    private int _bottomAnchor;
    private int _topAnchor;
    
    // Methods
    private void OnEnable()
    {
        mem2[0] = this._leftAnchor;
        mem2[0] = this._rightAnchor;
        mem2[0] = this._bottomAnchor;
        mem2[0] = this._topAnchor;
        this._widgetTarget.UpdateAnchors();
    }
    public BPBottomContainerAnchors()
    {
    
    }

}
