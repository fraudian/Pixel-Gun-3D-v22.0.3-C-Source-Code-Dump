using UnityEngine;

namespace PGCompany
{
    internal static class 专丏丐丄丛丈丄丂丂
    {
        // Methods
        internal static Rilisoft.OfferItemType 丈丏丆丛一丂丐丕丈(Rilisoft.GameEventItemType 丁世万丟不丘不且丏)
        {
            if(丁世万丟不丘不且丏 <= 800)
            {
                goto label_0;
            }
            
            if(丁世万丟不丘不且丏 <= 1200)
            {
                goto label_1;
            }
            
            if(丁世万丟不丘不且丏 <= 1400)
            {
                goto label_2;
            }
            
            if(丁世万丟不丘不且丏 != 1500)
            {
                    return (Rilisoft.OfferItemType)(丁世万丟不丘不且丏 == 1600) ? 1300 : 0;
            }
            
            return 1470;
            label_0:
            if(丁世万丟不丘不且丏 <= 300)
            {
                goto label_4;
            }
            
            if(丁世万丟不丘不且丏 <= 500)
            {
                goto label_5;
            }
            
            if(丁世万丟不丘不且丏 != 600)
            {
                    return (Rilisoft.OfferItemType)(丁世万丟不丘不且丏 == 800) ? 1070 : 0;
            }
            
            return 70;
            label_1:
            if(丁世万丟不丘不且丏 <= 1000)
            {
                goto label_7;
            }
            
            if(丁世万丟不丘不且丏 != 1100)
            {
                    return (Rilisoft.OfferItemType)(丁世万丟不丘不且丏 == 1200) ? 1160 : 0;
            }
            
            return 1150;
            label_4:
            if(丁世万丟不丘不且丏 == 100)
            {
                    return 10;
            }
            
            if(丁世万丟不丘不且丏 != 200)
            {
                    return (Rilisoft.OfferItemType)(丁世万丟不丘不且丏 == 300) ? 80 : 0;
            }
            
            return 85;
            label_2:
            if(丁世万丟不丘不且丏 != 1300)
            {
                    return (Rilisoft.OfferItemType)(丁世万丟不丘不且丏 == 1400) ? 1450 : 0;
            }
            
            return 20;
            label_5:
            if(丁世万丟不丘不且丏 != 400)
            {
                    return (Rilisoft.OfferItemType)(丁世万丟不丘不且丏 == 500) ? 1200 : 0;
            }
            
            return 83;
            label_7:
            if(丁世万丟不丘不且丏 != 900)
            {
                    return (Rilisoft.OfferItemType)(丁世万丟不丘不且丏 == 1000) ? 1080 : 0;
            }
            
            return 1060;
        }
        internal static Rilisoft.GameEventItemType 丙一业丈专世丑丟丗(Rilisoft.OfferItemType 下丗丁丒丘东丂不丑)
        {
            if((PGCompany.万丞丘与丕丞下万丌.丞丒丟丒且丑丏且业(丁丅丈丌丟世丗丗丟:  下丗丁丒丘东丂不丑)) != false)
            {
                    return 500;
            }
            
            if(下丗丁丒丘东丂不丑 <= 1060)
            {
                goto label_4;
            }
            
            if(下丗丁丒丘东丂不丑 <= 1150)
            {
                goto label_5;
            }
            
            if(下丗丁丒丘东丂不丑 <= 1300)
            {
                goto label_6;
            }
            
            if(下丗丁丒丘东丂不丑 != 1450)
            {
                goto label_7;
            }
            
            return 500;
            label_4:
            if(下丗丁丒丘东丂不丑 <= 70)
            {
                goto label_9;
            }
            
            if(下丗丁丒丘东丂不丑 <= 83)
            {
                goto label_10;
            }
            
            if(下丗丁丒丘东丂不丑 != 85)
            {
                goto label_11;
            }
            
            return 500;
            label_5:
            if(下丗丁丒丘东丂不丑 == 1070)
            {
                    return 500;
            }
            
            if(下丗丁丒丘东丂不丑 != 1080)
            {
                goto label_14;
            }
            
            return 500;
            label_9:
            if(下丗丁丒丘东丂不丑 == 10)
            {
                    return 500;
            }
            
            if(下丗丁丒丘东丂不丑 != 20)
            {
                goto label_17;
            }
            
            return 500;
            label_6:
            if(下丗丁丒丘东丂不丑 != 1160)
            {
                goto label_19;
            }
            
            return 500;
            label_10:
            if(下丗丁丒丘东丂不丑 != 80)
            {
                goto label_21;
            }
            
            return 500;
            label_14:
            var val_2 = (下丗丁丒丘东丂不丑 == 1150) ? 1100 : 0;
            return 500;
            label_17:
            var val_3 = (下丗丁丒丘东丂不丑 == 70) ? 600 : 0;
            return 500;
            label_7:
            var val_4 = (下丗丁丒丘东丂不丑 == 1470) ? 1500 : 0;
            return 500;
            label_11:
            var val_5 = (下丗丁丒丘东丂不丑 == 1060) ? 900 : 0;
            return 500;
            label_19:
            var val_6 = (下丗丁丒丘东丂不丑 == 1300) ? 1600 : 0;
            return 500;
            label_21:
            var val_7 = (下丗丁丒丘东丂不丑 == 83) ? 400 : 0;
            return 500;
        }
    
    }

}
