using UnityEngine;
internal sealed class LogFileToggle : PGBehaviour
{
    // Fields
    private string 丛专丁上丗一丘三丛;
    private UILabel label;
    
    // Properties
    internal string 万丘丂丌上丁丌七丞 { get; set; }
    
    // Methods
    internal string 丌丏丅业不丗且丘业()
    {
        return (string)this.丛专丁上丗一丘三丛;
    }
    internal void 万业三丏丄丗丝上丈(string 丙业与丙丗丝不丈东)
    {
        this.丛专丁上丗一丘三丛 = 丙业与丙丗丝不丈东;
        if(this.label == 0)
        {
                return;
        }
        
        this.label.text = 丙业与丙丗丝不丈东;
    }
    public LogFileToggle()
    {
    
    }

}
