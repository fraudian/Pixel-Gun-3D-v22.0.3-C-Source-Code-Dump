using UnityEngine;
[Serializable]
internal sealed class TagSpecificObject
{
    // Fields
    public System.Collections.Generic.List<TagSpecificObject.Entry> enties;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(TagSystem.三与下丘七丘丌丏丄 丏万且丈丙丁丁且世)
    {
        var val_6;
        int val_7;
        val_6 = 丏万且丈丙丁丁且世;
        List.Enumerator<T> val_1 = this.enties.GetEnumerator();
        label_8:
        if((315908904 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 != null)
        {
                val_7 = val_2.m_stringLength;
        }
        else
        {
                val_7 = 11993091;
        }
        
        string val_6 = val_7;
        val_6 = (val_6.丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  val_6, 丟且丒专下丈七丗丕:  W22)) ^ ((315908904 != 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  val_6);
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 世业丒万丘丆专丘丐()
    {
        List.Enumerator<T> val_1 = this.enties.GetEnumerator();
        label_6:
        if((316041416 & 1) == 0)
        {
            goto label_2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  0.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal int 丆丞丈丏三丌不丈丟()
    {
        var val_5;
        List.Enumerator<T> val_1 = this.enties.GetEnumerator();
        val_5 = 0;
        goto label_2;
        label_5:
        val_5 = val_5 + 0.丐丏七丌丕丗业且上().activeSelf;
        label_2:
        if((316169800 & 1) != 0)
        {
            goto label_5;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)val_5;
    }
    public TagSpecificObject()
    {
        this.enties = new System.Collections.Generic.List<Entry>();
    }

}
