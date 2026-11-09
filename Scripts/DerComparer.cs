using UnityEngine;
private class Asn1Set.DerComparer : IComparer
{
    // Methods
    public int Compare(object x, object y)
    {
        System.Byte[] val_6;
        System.Byte[] val_7;
        var val_8;
        var val_9;
        if(x == null)
        {
            goto label_1;
        }
        
        val_6 = x;
        if(val_6 == null)
        {
            goto label_2;
        }
        
        if(y != null)
        {
            goto label_3;
        }
        
        goto label_5;
        label_2:
        label_1:
        val_6 = 0;
        if(y == null)
        {
            goto label_5;
        }
        
        label_3:
        val_7 = y;
        if(val_7 != null)
        {
            goto label_6;
        }
        
        label_5:
        val_7 = 0;
        label_6:
        if(val_6 == 0)
        {
            goto label_7;
        }
        
        label_19:
        int val_2 = System.Math.Min(val1:  28563616, val2:  28563616);
        if(val_2 == 0)
        {
            goto label_11;
        }
        
        label_15:
        var val_3 = val_6 + 0;
        var val_4 = val_7 + 0;
        if(((val_6 + 0) + 32) != ((val_7 + 0) + 32))
        {
            goto label_14;
        }
        
        if(val_2 != (0 + 1))
        {
            goto label_15;
        }
        
        label_11:
        if(28563616 <= 28563616)
        {
            goto label_16;
        }
        
        val_8 = 1;
        goto label_17;
        label_7:
        if(val_7 != 0)
        {
            goto label_19;
        }
        
        goto label_19;
        label_16:
        if(28563616 >= 28563616)
        {
            goto label_20;
        }
        
        val_8 = 0;
        val_6 = val_7;
        label_17:
        var val_7 = ((val_2.AllZeroesFrom(bs:  val_6, pos:  val_2)) != true) ? 0 : (val_8);
        return (int)val_9;
        label_14:
        var val_8 = (((val_6 + 0) + 32) >= ((val_7 + 0) + 32)) ? (-0) : 0;
        return (int)val_9;
        label_20:
        val_9 = 0;
        return (int)val_9;
    }
    private bool AllZeroesFrom(byte[] bs, int pos)
    {
        var val_2;
        label_3:
        if(pos >= bs.Length)
        {
            goto label_1;
        }
        
        int val_1 = pos + 1;
        if(bs[(long)pos] == 0)
        {
            goto label_3;
        }
        
        val_2 = 0;
        return (bool)val_2;
        label_1:
        val_2 = 1;
        return (bool)val_2;
    }
    public Asn1Set.DerComparer()
    {
    
    }

}
