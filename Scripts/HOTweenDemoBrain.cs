using UnityEngine;
public class HOTweenDemoBrain : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform CubeTrans1;
    public UnityEngine.Transform CubeTrans2;
    public UnityEngine.Transform CubeTrans3;
    public string SampleString;
    public float SampleFloat;
    
    // Methods
    private void Start()
    {
        Holoville.HOTween.HOTween.Init(p_permanentInstance:  true, p_renameInstanceToCountTweens:  true, p_allowOverwriteManager:  true);
        Holoville.HOTween.Tweener val_1 = Holoville.HOTween.HOTween.To(p_target:  this.CubeTrans1, p_duration:  4f, p_propName:  "position", p_endVal:  0);
        Holoville.HOTween.Tweener val_9 = Holoville.HOTween.HOTween.To(p_target:  this.CubeTrans2, p_duration:  3f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "position", p_endVal:  0, p_isRelative:  true).Prop(p_propName:  "rotation", p_endVal:  0, p_isRelative:  true).Loops(p_loops:  0, p_loopType:  1).Ease(p_easeType:  6).OnStepComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void HOTweenDemoBrain::丒世丌丛与丂东下丝())));
        Holoville.HOTween.Tweener val_14 = Holoville.HOTween.HOTween.To(p_target:  this, p_duration:  3f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "SampleString", p_endVal:  "Hello I\'m a sample tweened string").Ease(p_easeType:  0).Loops(p_loops:  0, p_loopType:  1));
        Holoville.HOTween.Tweener val_19 = Holoville.HOTween.HOTween.To(p_target:  this, p_duration:  3f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "SampleFloat", p_endVal:  27.5f).Ease(p_easeType:  0).Loops(p_loops:  0, p_loopType:  1));
        UnityEngine.Color val_22 = this.CubeTrans3.GetComponent<UnityEngine.Renderer>().material.color;
        Holoville.HOTween.Sequence val_25 = new Holoville.HOTween.Sequence(p_parms:  new Holoville.HOTween.SequenceParms().Loops(p_loops:  0, p_loopType:  1));
        float val_29 = val_25.Append(p_twMember:  Holoville.HOTween.HOTween.To(p_target:  this.CubeTrans3, p_duration:  1f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "rotation", p_endVal:  0)));
        float val_33 = val_25.Append(p_twMember:  Holoville.HOTween.HOTween.To(p_target:  this.CubeTrans3, p_duration:  1f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "position", p_endVal:  0, p_isRelative:  true)));
        Holoville.HOTween.Tweener val_36 = Holoville.HOTween.HOTween.To(p_target:  this.CubeTrans3, p_duration:  1f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "rotation", p_endVal:  0));
        if(val_25 != null)
        {
                float val_37 = val_25.Append(p_twMember:  val_36);
        }
        else
        {
                float val_38 = val_25.Append(p_twMember:  val_36);
        }
        
        float val_39 = val_25.duration;
        float val_42 = val_25.duration;
        val_42 = val_42 * 0.5f;
        Holoville.HOTween.Tweener val_45 = Holoville.HOTween.HOTween.To(p_target:  this.CubeTrans3.GetComponent<UnityEngine.Renderer>().material, p_duration:  val_42, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "color", p_endVal:  val_22));
        if(val_25 != null)
        {
                float val_47 = val_25.Insert(p_time:  val_39 * 0.5f, p_twMember:  val_45);
        }
        else
        {
                float val_49 = val_25.Insert(p_time:  val_39 * 0.5f, p_twMember:  val_45);
        }
        
        val_25.Play();
    }
    private void OnGUI()
    {
        UnityEngine.GUILayout.Label(text:  "String tween: "("String tween: ") + this.SampleString, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Label(text:  "Float tween: "("Float tween: ") + this.SampleFloat, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
    }
    private void 丒世丌丛与丂东下丝()
    {
        UnityEngine.Debug.Log(message:  "HOTween: Cube 2 Step Complete");
    }
    public HOTweenDemoBrain()
    {
    
    }

}
