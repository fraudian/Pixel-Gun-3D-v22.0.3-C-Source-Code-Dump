using UnityEngine;
internal class DamageableObjectHealthUI : MonoBehaviour
{
    // Fields
    private DamageableObject 七一丕上丄上万不不;
    private float _currentScale;
    private float 不丟丏与丘丗下丛丂;
    private UnityEngine.GameObject _frame;
    private UnityEngine.Transform _healthBar;
    private float 业上丅不丘上与丅万;
    
    // Methods
    internal void 不丒世下丝万丙丟丆(DamageableObject 丘万丗丑丘丅丆丛万)
    {
        this.七一丕上丄上万不不 = 丘万丗丑丘丅丆丛万;
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new DamageableObjectHealthUI.七一丟丕三丆丑万丐();
    }
    private System.Collections.IEnumerator 丙丟丄下万丙丗丑万()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new DamageableObjectHealthUI.且丑专一丂不世丌丅();
    }
    public DamageableObjectHealthUI()
    {
        this.业上丅不丘上与丅万 = 1f;
    }

}
