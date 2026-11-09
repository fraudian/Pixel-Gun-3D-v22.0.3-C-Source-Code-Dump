using UnityEngine;
internal sealed class AnimationCapturedFlag : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _containerRedFlag;
    private UnityEngine.GameObject _containerBlueFlag;
    private System.Collections.Generic.List<UnityEngine.GameObject> _listRedFlagObject;
    private System.Collections.Generic.List<UnityEngine.GameObject> _listBlueFlagObject;
    private System.Collections.Generic.List<UITweener> _listTweenersOnStartCapture;
    private UnityEngine.Transform _startPosition;
    private UnityEngine.Transform _endPosition;
    private bool 丌丘丐上一丟不下与;
    private AltarePoint _altarePoint;
    private float 万丆丛丝丑世三丕一;
    private float 与七丕丟世丒丌世丟;
    private float _speed;
    
    // Methods
    private void Awake()
    {
        if(this._altarePoint == 0)
        {
                return;
        }
        
        this._altarePoint.丐专三丁丘丈丘丝丅(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void AnimationCapturedFlag::丏业七丘万丒不丄且(float 丅专与丒丈丗丒丘丌)));
    }
    private void OnDestroy()
    {
        if(this._altarePoint == 0)
        {
                return;
        }
        
        this._altarePoint.丘业下上且丗丈且丙(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void AnimationCapturedFlag::丏业七丘万丒不丄且(float 丅专与丒丈丗丒丘丌)));
    }
    private void 丏业七丘万丒不丄且(float 丅专与丒丈丗丒丘丌)
    {
        var val_3;
        System.Collections.Generic.List<UnityEngine.GameObject> val_7;
        if(this.丌丘丐上一丟不下与 != true)
        {
                this.丌丘丐上一丟不下与 = true;
            this.与上专下丛丄丙丗下();
        }
        
        List.Enumerator<T> val_1 = this._listRedFlagObject.GetEnumerator();
        label_5:
        if((1047460592 & 1) == 0)
        {
            goto label_3;
        }
        
        val_3.丐丏七丌丕丗业且上().SetActive(value:  false);
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_7 = this._listBlueFlagObject;
        List.Enumerator<T> val_5 = val_7.GetEnumerator();
        label_13:
        if((1047460592 & 1) == 0)
        {
            goto label_11;
        }
        
        val_3.丐丏七丌丕丗业且上().SetActive(value:  true);
        goto label_13;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void Update()
    {
        if(this._altarePoint == 0)
        {
                return;
        }
        
        float val_12 = this._altarePoint.CurrentCapturePoint;
        val_12 = val_12 / this._altarePoint.maxCapturePoint;
        this.万丆丛丝丑世三丕一 = val_12;
        if(this.与七丕丟世丒丌世丟 == val_12)
        {
                return;
        }
        
        float val_5 = UnityEngine.Mathf.Lerp(a:  this.与七丕丟世丒丌世丟, b:  val_12, t:  UnityEngine.Time.deltaTime * this._speed);
        this.与七丕丟世丒丌世丟 = ((this.万丆丛丝丑世三丕一 - val_5) < 0) ? this.万丆丛丝丑世三丕一 : (val_5);
        UnityEngine.Vector3 val_9 = this._startPosition.position;
        UnityEngine.Vector3 val_10 = this._endPosition.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, t:  this.与七丕丟世丒丌世丟);
        this._containerBlueFlag.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
    }
    private void 与上专下丛丄丙丗下()
    {
        List.Enumerator<T> val_1 = this._listTweenersOnStartCapture.GetEnumerator();
        label_4:
        if((1047770632 & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().enabled = true;
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public AnimationCapturedFlag()
    {
        this._listRedFlagObject = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this._listBlueFlagObject = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this._listTweenersOnStartCapture = new System.Collections.Generic.List<UITweener>();
        this._speed = 5f;
    }

}
