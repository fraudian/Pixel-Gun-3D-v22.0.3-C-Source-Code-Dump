using UnityEngine;
internal sealed class CopyActiveSelfState : PGBehaviour
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.GameObject> copyStateTo;
    public System.Collections.Generic.List<UnityEngine.GameObject> CopyInvertStateTo;
    public System.Collections.Generic.List<UnityEngine.GameObject> copyHierarchyStateTo;
    public System.Collections.Generic.List<UnityEngine.GameObject> CopyHierarchyInvertStateTo;
    
    // Methods
    private void OnEnable()
    {
        this.丕丕业七丙七丅丈丄();
    }
    private void OnDisable()
    {
        this.丕丕业七丙七丅丈丄();
    }
    private void 丕丕业七丙七丅丈丄()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.copyStateTo, 丏业丟一东丂东丘丛:  this.gameObject.activeSelf);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.CopyInvertStateTo, 丏业丟一东丂东丘丛:  (~this.gameObject.activeSelf) & 1);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.copyHierarchyStateTo, 丏业丟一东丂东丘丛:  this.gameObject.activeInHierarchy);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.CopyHierarchyInvertStateTo, 丏业丟一东丂东丘丛:  (~this.gameObject.activeInHierarchy) & 1);
    }
    public CopyActiveSelfState()
    {
    
    }

}
