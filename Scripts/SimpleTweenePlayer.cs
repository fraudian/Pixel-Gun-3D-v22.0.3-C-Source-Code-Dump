using UnityEngine;
public class SimpleTweenePlayer : MonoBehaviour
{
    // Fields
    public bool playOnEnable;
    public bool initialOnDisable;
    public System.Collections.Generic.List<SimpleTween> tweeners;
    
    // Methods
    private void OnEnable()
    {
        if(this.playOnEnable == false)
        {
                return;
        }
        
        this.Play();
    }
    private void OnDisable()
    {
        if(this.initialOnDisable == false)
        {
                return;
        }
        
        this.SetInitial();
    }
    public void Play()
    {
        var val_4 = this;
        if(this.tweeners == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.tweeners.GetEnumerator();
        label_7:
        if((510352280 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        mem2[0] = 0;
        val_2.专丞丆下丏丛世丁丁();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void PlayRewers()
    {
        var val_4 = this;
        if(this.tweeners == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.tweeners.GetEnumerator();
        label_7:
        if((510480648 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        mem2[0] = 1;
        val_2.专丞丆下丏丛世丁丁();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void Stop()
    {
        if(this.tweeners == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.tweeners.GetEnumerator();
        goto label_7;
        label_8:
        this = 0.丐丏七丌丕丗业且上();
        if(this != 0)
        {
                mem2[0] = 0;
            mem2[0] = 0;
            if(0 != 0)
        {
                this.StopCoroutine(routine:  0);
            mem2[0] = 0;
        }
        
        }
        
        label_7:
        if((510609048 & 1) != 0)
        {
            goto label_8;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void GetIniotial()
    {
        var val_4 = this;
        if(this.tweeners == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.tweeners.GetEnumerator();
        label_7:
        if((510737432 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((val_2 == 0) || (val_2 != null))
        {
            goto label_7;
        }
        
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void SetInitial()
    {
        var val_4 = this;
        if(this.tweeners == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.tweeners.GetEnumerator();
        label_7:
        if((510865816 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((val_2 == 0) || (val_2 != null))
        {
            goto label_7;
        }
        
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void SetFinal()
    {
        var val_4 = this;
        if(this.tweeners == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.tweeners.GetEnumerator();
        label_7:
        if((510994200 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((val_2 == 0) || (val_2 != null))
        {
            goto label_7;
        }
        
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void CollectTweeners()
    {
        this.tweeners = System.Linq.Enumerable.ToList<SimpleTween>(source:  this.GetComponents<SimpleTween>());
    }
    public SimpleTweenePlayer()
    {
        this.playOnEnable = true;
        this.initialOnDisable = true;
    }

}
