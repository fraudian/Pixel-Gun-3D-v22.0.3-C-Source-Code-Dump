using UnityEngine;
private sealed class NJGMapRenderer.东专丄丕下丆三丌丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NJGMapRenderer 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NJGMapRenderer.东专丄丕下丆三丌丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        NJG.NJGMapBase val_25;
        NJG.NJGMapBase val_26;
        NJG.NJGMapBase val_27;
        UnityEngine.Texture2D val_28;
        int val_29;
        NJG.NJGMapBase val_30;
        NJG.NJGMapBase val_31;
        NJG.NJGMapBase val_32;
        NJG.NJGMapBase val_33;
        bool val_34;
        bool val_35;
        val_25 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.七丟丑丛丗世丞与丄 != false)
        {
                val_26 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
            if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.optimize != false)
        {
                if(UnityEngine.Application.isPlaying != false)
        {
                if(this.丝且与丝丒丟万丁专.世丗下丞丟丗丙丅丁 == false)
        {
            goto label_8;
        }
        
        }
        
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.且丟丝丁与丈与专丐 == false)
        {
            goto label_37;
        }
        
        val_26 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture;
        if(val_26 == 0)
        {
                this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture = this.丝且与丝丒丟万丁专.丐丅丞丘丌三丁丁丙();
            val_26 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
            UnityEngine.Vector2 val_4 = val_26.mapSize;
            this.丝且与丝丒丟万丁专.丝丈丏丘丟业丘丏丌 = val_4;
            mem2[0] = val_4.y;
        }
        
        if(this.丝且与丝丒丟万丁专.丄丛丑丛不三一丄丛 != false)
        {
                if(UnityEngine.Application.isPlaying == true)
        {
            goto label_17;
        }
        
        }
        
        if((this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.runtimeGeneration == false) || (this.丝且与丝丒丟万丁专.且丟丝丁与丈与专丐 == false))
        {
            goto label_20;
        }
        
        NJG.NJGMapBase val_6 = NJG.NJGMapBase.instance;
        if(val_6.renderMode != 0)
        {
                UnityEngine.Vector2 val_7 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapSize;
            if(val_7.x < this.丝且与丝丒丟万丁专.丝丈丏丘丟业丘丏丌)
        {
                if(val_7.y < val_7.x)
        {
            goto label_25;
        }
        
        }
        
            this.丝且与丝丒丟万丁专.丝丈丏丘丟业丘丏丌 = val_7;
            mem2[0] = val_7.y;
            bool val_8 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture.Resize(width:  (int)val_7.x, height:  (int)val_7.y);
        }
        
        label_25:
        this.丝且与丝丒丟万丁专.丄丛丑丛不三一丄丛 = true;
        val_26 = UnityEngine.RenderTexture.active;
        UnityEngine.RenderTexture.active = this.丝且与丝丒丟万丁专.GetComponent<UnityEngine.Camera>().targetTexture;
        val_27 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        if(val_27 == null)
        {
            goto label_29;
        }
        
        val_28 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture;
        goto label_50;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丝且与丝丒丟万丁专.且丟丝丁与丈与专丐 == false) || (this.丝且与丝丒丟万丁专.七丟丑丛丗世丞与丄 == true))
        {
            goto label_37;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                this.丝且与丝丒丟万丁专.七丟丑丛丗世丞与丄 = true;
        }
        
        val_25 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不 == null)
        {
                val_25 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        }
        
        val_26 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.runtimeGeneration;
        0.SetTexture(丟三丟三丅专丂丄丂:  (val_26 == true) ? this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture : this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.userMapTexture);
        goto label_37;
        label_2:
        val_29 = 0;
        return (bool)val_29;
        label_20:
        val_26 = UnityEngine.RenderTexture.active;
        UnityEngine.RenderTexture.active = this.丝且与丝丒丟万丁专.GetComponent<UnityEngine.Camera>().targetTexture;
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.userMapTexture == 0)
        {
            goto label_43;
        }
        
        val_27 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        if(val_27 == null)
        {
            goto label_44;
        }
        
        val_28 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.userMapTexture;
        goto label_50;
        label_8:
        this.丝且与丝丒丟万丁专.世丗下丞丟丗丙丅丁 = true;
        UnityEngine.Debug.LogWarning(message:  "Can\'t Re-generate the map texture since \'optimize\' is activated");
        this.丝且与丝丒丟万丁专.且丟丝丁与丈与专丐 = false;
        label_37:
        float val_18 = UnityEngine.Time.time;
        val_29 = 0;
        val_18 = val_18 + 1f;
        this.丝且与丝丒丟万丁专.丈丈丏且丂丅东上丗 = val_18;
        return (bool)val_29;
        label_29:
        val_28 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture;
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不 == null)
        {
            goto label_49;
        }
        
        label_51:
        val_27 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        goto label_50;
        label_44:
        val_28 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.userMapTexture;
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不 != null)
        {
            goto label_51;
        }
        
        label_49:
        val_27 = 0;
        label_50:
        UnityEngine.Vector2 val_19 = val_27.mapSize;
        UnityEngine.Vector2 val_20 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapSize;
        val_28.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0, recalculateMipMaps:  (this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.generateMipmaps == true) ? 1 : 0);
        label_43:
        UnityEngine.RenderTexture.active = val_26;
        label_17:
        if(this.丝且与丝丒丟万丁专.丌丌丞丒丑七七万丈 == true)
        {
            goto label_55;
        }
        
        val_30 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        this.丝且与丝丒丟万丁专.丌丌丞丒丑七七万丈 = true;
        if(val_30 == null)
        {
            goto label_56;
        }
        
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.runtimeGeneration == false)
        {
            goto label_57;
        }
        
        label_64:
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.optimize != false)
        {
                this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture.Compress(highQuality:  true);
            this.丝且与丝丒丟万丁专.且丟丝丁与丈与专丐 = false;
        }
        
        val_31 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        if(val_31 == null)
        {
            goto label_61;
        }
        
        val_26 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture;
        val_32 = val_31;
        goto label_70;
        label_56:
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不 == null)
        {
            goto label_71;
        }
        
        val_30 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.runtimeGeneration == true)
        {
            goto label_64;
        }
        
        label_57:
        val_26 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.userMapTexture;
        val_33 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        if(this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不 != null)
        {
            goto label_65;
        }
        
        val_33 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        if(val_33 == null)
        {
            goto label_71;
        }
        
        label_65:
        val_34 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.generateMipmaps;
        val_35 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.optimize;
        if(val_26 != null)
        {
            goto label_72;
        }
        
        goto label_68;
        label_61:
        val_32 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        val_26 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.mapTexture;
        if(val_32 == null)
        {
            goto label_69;
        }
        
        val_31 = val_32;
        goto label_70;
        label_69:
        val_31 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不;
        if(val_31 == null)
        {
            goto label_71;
        }
        
        label_70:
        val_34 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.generateMipmaps;
        val_35 = this.丝且与丝丒丟万丁专.丞丁丑丏丄丏七丂不.optimize;
        if(val_26 != null)
        {
            goto label_72;
        }
        
        label_68:
        label_72:
        val_26.Apply(updateMipmaps:  (val_34 == true) ? 1 : 0, makeNoLongerReadable:  (val_35 == true) ? 1 : 0);
        label_55:
        val_29 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_29;
        label_71:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
