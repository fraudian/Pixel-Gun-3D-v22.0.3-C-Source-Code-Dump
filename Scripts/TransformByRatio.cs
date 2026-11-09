using UnityEngine;
internal sealed class TransformByRatio : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<TransformByRatio.RatioSettings> _settings;
    
    // Methods
    private void OnEnable()
    {
        TransformByRatio.丛与丒丞丁丛上丄丆 val_1 = new TransformByRatio.丛与丒丞丁丛上丄丆();
        .东丞丅丕丌丑丗丞下 = 丒丁三上丂丅丌丈丁.丌且专业丈丒丄东万();
        if((this._settings.Exists(match:  new System.Predicate<RatioSettings>(object:  val_1, method:  System.Boolean TransformByRatio.丛与丒丞丁丛上丄丆::丈丆丙丕丆丝三丌与(TransformByRatio.RatioSettings 三丟东丕丄丄下下丑)))) == false)
        {
                return;
        }
        
        RatioSettings val_7 = this._settings.Find(match:  new System.Predicate<RatioSettings>(object:  val_1, method:  System.Boolean TransformByRatio.丛与丒丞丁丛上丄丆::丕且丈丈专丐丞丟下(TransformByRatio.RatioSettings 三丟东丕丄丄下下丑)));
        this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = this._settings >> 32, y = 6.822503E-22f, z = 2.524357E-29f};
    }
    public TransformByRatio()
    {
        this._settings = new System.Collections.Generic.List<RatioSettings>();
    }

}
