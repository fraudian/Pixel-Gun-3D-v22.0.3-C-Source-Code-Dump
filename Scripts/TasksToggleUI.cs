using UnityEngine;
internal sealed class TasksToggleUI : PGBehaviour
{
    // Fields
    private bool 下东丌且丝丁丐丌且;
    private UnityEngine.GameObject tasksMain;
    private UnityEngine.GameObject arrowUnfold;
    private UnityEngine.GameObject arrowFold;
    
    // Properties
    internal bool 丞丄丂丘丌一丒丙上 { get; }
    
    // Methods
    internal bool 上丘丛业与专丌丟丐()
    {
        return (bool)this.下东丌且丝丁丐丌且;
    }
    public void ChangeToggle()
    {
        this.下东丌且丝丁丐丌且 = this.下东丌且丝丁丐丌且 ^ 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tasksMain, 丏业丟一东丂东丘丛:  (this.下东丌且丝丁丐丌且 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrowUnfold, 丏业丟一东丂东丘丛:  (this.下东丌且丝丁丐丌且 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrowFold, 丏业丟一东丂东丘丛:  this.下东丌且丝丁丐丌且);
    }
    public void Show()
    {
        if(this.下东丌且丝丁丐丌且 != false)
        {
                return;
        }
        
        this.ChangeToggle();
    }
    public void Hide()
    {
        if(this.下东丌且丝丁丐丌且 == false)
        {
                return;
        }
        
        this.ChangeToggle();
    }
    public TasksToggleUI()
    {
        this.下东丌且丝丁丐丌且 = true;
    }

}
