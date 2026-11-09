using UnityEngine;
private sealed class GameEventExtendedEventInfoView.丁丂与丙下东丐丏丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventExtendedEventInfoView 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventExtendedEventInfoView.丁丂与丙下东丐丏丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.GameEventExtendedEventInfoView val_72;
        int val_73;
        float val_74;
        UnityEngine.Object val_75;
        var val_76;
        UnityEngine.GameObject val_77;
        var val_78;
        val_72 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_73 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_73;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.上丁专万丗丘丄七丌 == false)
        {
            goto label_4;
        }
        
        val_72 = this.丝且与丝丒丟万丁专._wrap.transform.GetChild(index:  0).gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_72, 丏业丟一东丂东丘丛:  false);
        val_73 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_73;
        return (bool)val_73;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.上丁专万丗丘丄七丌 = false;
        label_4:
        if(this.丝且与丝丒丟万丁专.不丑丆丌世丁丛与一 == null)
        {
            goto label_12;
        }
        
        丞东丑专丛丆丄丝世.不不丏专丟丆丕丛丗(丄丑三东丘丆丂丟丙:  this.丝且与丝丒丟万丁专._scroll);
        UnityEngine.Vector3 val_8 = this.丝且与丝丒丟万丁专._scroll.panel.transform.localPosition;
        val_74 = val_8.y;
        UnityEngine.Vector3 val_11 = this.丝且与丝丒丟万丁专._scroll.panel.transform.localPosition;
        this.丝且与丝丒丟万丁专._scroll.panel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector2 val_14 = this.丝且与丝丒丟万丁专._scroll.panel.clipOffset;
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  0f, y:  val_14.y);
        this.丝且与丝丒丟万丁专._scroll.panel.clipOffset = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
        System.Comparison<Rilisoft.GameEventItemContainer> val_16 = new System.Comparison<Rilisoft.GameEventItemContainer>(object:  0, method:  static System.Int32 Rilisoft.丛且世丐丆上七业丁::不丙丝下与丞业不丒(Rilisoft.GameEventItemContainer 丏丆丑丗七丄丙丝与, Rilisoft.GameEventItemContainer 丒丈丙丐丏丕丆万丗));
        if(this.丝且与丝丒丟万丁专.不丑丆丌世丁丛与一 != null)
        {
                this.丝且与丝丒丟万丁专.不丑丆丌世丁丛与一.Sort(comparison:  val_16);
            val_75 = this.丝且与丝丒丟万丁专.不丑丆丌世丁丛与一;
        }
        else
        {
                0.Sort(comparison:  val_16);
            val_75 = 0;
        }
        
        val_72.上且不七上下丆万丄(丞东丆与下丁丆七与:  val_75.Count);
        this.丝且与丝丒丟万丁专._wrap.minIndex = 0;
        this.丝且与丝丒丟万丁专._wrap.maxIndex = 0;
        if(this.丝且与丝丒丟万丁专._wrap.transform.childCount >= val_75.Count)
        {
            goto label_36;
        }
        
        goto label_37;
        label_65:
        UnityEngine.Transform val_25 = this.丝且与丝丒丟万丁专._wrap.transform.GetChild(index:  this.丝且与丝丒丟万丁专._wrap.transform.childCount - 1);
        UnityEngine.Transform val_28 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_25, parent:  this.丝且与丝丒丟万丁专._wrap.gameObject.transform);
        UnityEngine.Vector3 val_30 = val_25.transform.localPosition;
        UnityEngine.Vector3 val_32 = val_25.transform.localPosition;
        UnityEngine.Vector3 val_34 = val_25.transform.localPosition;
        float val_71 = (float)this.丝且与丝丒丟万丁专._wrap.itemSize;
        val_71 = val_30.x + val_71;
        val_28.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.one;
        val_74 = val_37.x;
        val_28.transform.localScale = new UnityEngine.Vector3() {x = val_74, y = val_37.y, z = val_37.z};
        int val_40 = this.丝且与丝丒丟万丁专._wrap.transform.childCount - 1;
        val_28.name = "item_" + val_40;
        label_37:
        if(this.丝且与丝丒丟万丁专._wrap.transform.childCount < val_75.Count)
        {
            goto label_65;
        }
        
        goto label_70;
        label_36:
        if(this.丝且与丝丒丟万丁专._wrap.transform.childCount <= val_75.Count)
        {
            goto label_70;
        }
        
        goto label_71;
        label_83:
        UnityEngine.Transform val_49 = this.丝且与丝丒丟万丁专._wrap.transform.GetChild(index:  0);
        val_49.gameObject.SetActive(value:  false);
        if(val_49 != null)
        {
                val_49.SetParent(p:  0);
        }
        else
        {
                0.SetParent(p:  0);
        }
        
        UnityEngine.Object.Destroy(obj:  val_49.gameObject);
        label_71:
        if(this.丝且与丝丒丟万丁专._wrap.transform.childCount > val_75.Count)
        {
            goto label_83;
        }
        
        label_70:
        val_76 = 0;
        goto label_84;
        label_91:
        int val_72 = this.丝且与丝丒丟万丁专._wrap.itemSize;
        val_72 = 0 + val_72;
        val_74 = 0f;
        this.丝且与丝丒丟万丁专._wrap.transform.GetChild(index:  0).localPosition = new UnityEngine.Vector3() {x = val_74, y = 0f, z = 0f};
        val_76 = 1;
        label_84:
        val_77 = this.丝且与丝丒丟万丁专._wrap.transform;
        if(val_76 < val_77.childCount)
        {
            goto label_91;
        }
        
        List.Enumerator<T> val_59 = val_75.GetEnumerator();
        goto label_93;
        label_108:
        UnityEngine.Transform val_63 = this.丝且与丝丒丟万丁专._wrap.transform.GetChild(index:  0);
        val_77 = val_63.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_77, 丏业丟一东丂东丘丛:  true);
        val_75 = val_63.GetComponent<GameEventItemGui>();
        if(val_75 != 0)
        {
                Rilisoft.GameEventItem val_67 = val_40.丐丏七丌丕丗业且上().丙业丈专万下丄丙丏();
            if(val_67 != null)
        {
                Rilisoft.GameEventItemData val_68 = val_67.Data;
        }
        
            System.Action<GameEventItemGui> val_69 = new System.Action<GameEventItemGui>(object:  val_72, method:  System.Void Rilisoft.GameEventExtendedEventInfoView::丘丙丅下丟丄丏下丆(GameEventItemGui 与与三一丞丛丒不丟));
            val_75.remove_Clicked(丙业与丙丗丝不丈东:  null);
            System.Action<GameEventItemGui> val_70 = new System.Action<GameEventItemGui>(object:  val_72, method:  System.Void Rilisoft.GameEventExtendedEventInfoView::丘丙丅下丟丄丏下丆(GameEventItemGui 与与三一丞丛丒不丟));
            val_75.add_Clicked(丙业与丙丗丝不丈东:  null);
        }
        
        label_93:
        if(((-426432656) & 1) != 0)
        {
            goto label_108;
        }
        
        val_78 = public System.Void List.Enumerator<Rilisoft.GameEventItemContainer>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝且与丝丒丟万丁专._scroll.ResetPosition();
        val_72 = this.丝且与丝丒丟万丁专._scroll;
        val_72.Restrict();
        label_12:
        val_73 = 0;
        return (bool)val_73;
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
