using UnityEngine;
internal class SquareFieldSelectableCell : SquareFieldPhysicsCell
{
    // Fields
    private bool 丞丈丌且东丆丅丗万;
    private UnityEngine.GameObject _triggeredMarker;
    private UnityEngine.GameObject _possibleMarker;
    private UnityEngine.GameObject _arrows;
    private UnityEngine.GameObject _radius;
    private UnityEngine.GameObject _directionArrow;
    private UnityEngine.Color canPlaceColor;
    private UnityEngine.Color cannotPlaceColor;
    private UnityEngine.Texture glossTexture;
    private string 上万世丁丗且不丄丑;
    private string 丒与丆七与丕丑东丆;
    private UnityEngine.Coroutine 丄七业丘丑丒丙上丝;
    private System.Collections.Generic.List<UnityEngine.Renderer> 七万丞且丘丅且丛丟;
    private float scrollSpeed;
    private float 丄丑三东丘丆丂丟丙;
    internal UnityEngine.Vector3 世专七丘万丌一丟丗;
    internal UnityEngine.Transform placeForTurretInfo;
    private UnityEngine.Vector3 丕丈七三上丏不一专;
    private UnityEngine.Renderer rarityColor;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_1 = this.placeForTurretInfo.localPosition;
        this.丕丈七三上丏不一专 = val_1;
        mem[1152921539199051276] = val_1.y;
        mem[1152921539199051280] = val_1.z;
    }
    internal void Update()
    {
        UnityEngine.GameObject val_11;
        UnityEngine.Color val_12;
        val_11 = this;
        if(this.丞丈丌且东丆丅丗万 == false)
        {
            goto label_15;
        }
        
        this._triggeredMarker.SetActive(value:  (W21 != 0) ? 1 : 0);
        this._possibleMarker.SetActive(value:  (W21 == 0) ? 1 : 0);
        val_12 = mem[X21 + 105];
        val_12 = X21 + 105;
        this._arrows.SetActive(value:  (val_12 != 0) ? 1 : 0);
        this._radius.SetActive(value:  true);
        this.丅业上东丆丛世万丄();
        this.丗不世与丗专丂世丅();
        if(this.七万丞且丘丅且丛丟 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_4 = this.七万丞且丘丅且丛丟.GetEnumerator();
        val_12 = this.cannotPlaceColor;
        label_11:
        if((232618696 & 1) == 0)
        {
            goto label_8;
        }
        
        0.丐丏七丌丕丗业且上().material.color = new UnityEngine.Color() {r = (1152921525724388416 != 0) ? (val_12) : this.canPlaceColor, g = (1152921525724388416 != 0) ? 1152921539199216436 : 1152921539199216420, b = (1152921525724388416 != 0) ? 1152921539199216440 : 1152921539199216424, a = (1152921525724388416 != 0) ? 1152921539199216444 : 1152921539199216428};
        goto label_11;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_15:
        this._triggeredMarker.SetActive(value:  false);
        this._possibleMarker.SetActive(value:  false);
        this._arrows.SetActive(value:  false);
        this._radius.SetActive(value:  false);
        val_11 = this._directionArrow;
        val_11.SetActive(value:  false);
    }
    private System.Collections.IEnumerator 丈丘丝一万且不丝不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SquareFieldSelectableCell.丆专丈丛万丂丄三丕();
    }
    internal void 丗丗业丆三丐丈丕万(UnityEngine.Vector3 丒丈丘业丛丁丏丙丘)
    {
        this.丈丌丝丐丆不且万不(丙业与丙丗丝不丈东:  W8 + ((丒丈丘业丛丁丏丙丘.x > 0f) ? 89 : 90));
    }
    internal void 丅业上东丆丛世万丄()
    {
        float val_2 = X20.Radius * 0.2f;
        this._radius.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 丗不世与丗专丂世丅()
    {
        if((X20 + 104) != 0)
        {
                this._arrows.SetActive(value:  false);
        }
        
        this._directionArrow.SetActive(value:  (this._arrows != 0) ? 1 : 0);
    }
    internal void 丐丌与丘丂丆丆丑丕(bool 丞丈丌且东丆丅丗万)
    {
        UnityEngine.Object val_7;
        this.丞丈丌且东丆丅丗万 = 丞丈丌且东丆丅丗万;
        val_7 = GetComponent<FortFieldObjectParams>();
        if(val_7 != 0)
        {
                this.七万丞且丘丅且丛丟 = val_2.objectRenderers;
            val_7 = X22.transform;
            val_7.localScale = new UnityEngine.Vector3() {x = val_2.scaleInFortField, y = V9.16B, z = V10.16B};
        }
        
        if(丞丈丌且东丆丅丗万 != false)
        {
                UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
            this.世专七丘万丌一丟丗 = val_6;
            mem[1152921539199882996] = val_6.y;
            mem[1152921539199883000] = val_6.z;
        }
        
        this.丅丙丙丞丑丂业与丅();
    }
    private void 丅丙丙丞丑丂业与丅()
    {
        var val_3;
        System.Collections.Generic.List<UnityEngine.Renderer> val_17;
        var val_18;
        val_17 = this;
        if(this.七万丞且丘丅且丛丟 == null)
        {
                return;
        }
        
        if(this.丞丈丌且东丆丅丗万 == false)
        {
            goto label_2;
        }
        
        List.Enumerator<T> val_1 = this.七万丞且丘丅且丛丟.GetEnumerator();
        val_18 = 1152921525724387392;
        label_10:
        if((233479264 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        val_4.material.shader = UnityEngine.Shader.Find(name:  "Custom/SpeedRunSky");
        val_4.material.renderQueue = 194;
        val_4.material.SetTexture(name:  this.上万世丁丗且不丄丑, value:  this.glossTexture);
        goto label_10;
        label_2:
        this.StopCoroutine(routine:  this.丄七业丘丑丒丙上丝);
        val_17 = this.七万丞且丘丅且丛丟;
        List.Enumerator<T> val_9 = val_17.GetEnumerator();
        val_18 = 1152921525724388416;
        label_17:
        if((233479264 & 1) == 0)
        {
            goto label_12;
        }
        
        string val_10 = val_3.丐丏七丌丕丗业且上();
        val_10.material.shader = UnityEngine.Shader.Find(name:  "Rilisoft/WallHackShader");
        val_10.material.renderQueue = 184;
        goto label_17;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_34;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_34:
        if(0 != 0)
        {
                val_17.StopCoroutine(routine:  0);
        }
        
        mem2[0] = val_17.StartCoroutine(routine:  val_17.丈丘丝一万且不丝不());
    }
    internal void 不世丏丛一三且下丛()
    {
        if(this == 0)
        {
                return;
        }
        
        this.placeForTurretInfo.parent = this.丌丟丄业且三丛丕丄();
        this.placeForTurretInfo.localPosition = new UnityEngine.Vector3() {x = this.丕丈七三上丏不一专, y = V9.16B, z = V10.16B};
    }
    internal void 丗丕下丘丁且丒丈丝(UnityEngine.Transform 专丏丕丌世一专丒且, UnityEngine.Vector3 丟丙丝业丑丁与丟丒)
    {
        this.placeForTurretInfo.parent = 专丏丕丌世一专丒且;
        this.placeForTurretInfo.localPosition = new UnityEngine.Vector3() {x = 丟丙丝业丑丁与丟丒.x, y = 丟丙丝业丑丁与丟丒.y, z = 丟丙丝业丑丁与丟丒.z};
    }
    internal override void 丌且丄七丈与丕丆不()
    {
        this.丌且丄七丈与丕丆不();
        if(true == 4)
        {
                return;
        }
        
        UnityEngine.Color val_2 = this.专且丈七丈丛丆东丈();
        this.rarityColor.materials[0].color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        if((System.String.op_Equality(a:  0, b:  "fort_trampoline")) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  7f);
        this.rarityColor.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
    }
    private UnityEngine.Color 专且丈七丈丛丆东丈()
    {
        if(X19.ItemRarity <= 5)
        {
                var val_3 = 106040048 + (val_1) << 2;
            val_3 = val_3 + 106040048;
        }
        else
        {
                UnityEngine.Color val_2 = UnityEngine.Color.clear;
            return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
    
    }
    public SquareFieldSelectableCell()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.green;
        this.canPlaceColor = val_1;
        mem[1152921539200871636] = val_1.g;
        mem[1152921539200871640] = val_1.b;
        mem[1152921539200871644] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.red;
        this.cannotPlaceColor = val_2;
        mem[1152921539200871652] = val_2.g;
        mem[1152921539200871656] = val_2.b;
        mem[1152921539200871660] = val_2.a;
        this.上万世丁丗且不丄丑 = "_MainTex3";
        this.丒与丆七与丕丑东丆 = "_Scroll";
        this.七万丞且丘丅且丛丟 = new System.Collections.Generic.List<UnityEngine.Renderer>();
        this.scrollSpeed = 0.7f;
    }

}
