using UnityEngine;

namespace PGCompany.DataObjects
{
    internal static class 丏下与丝一专丞七丌
    {
        // Methods
        internal static bool 丐丅且丗东丘上与丏(PGCompany.DataObjects.万丞丘丏丆丆丝与与.上丒上丛业丕东世七 丟丐丗万丅下丗丝万)
        {
            if(丟丐丗万丅下丗丝万 != null)
            {
                    return 丟丐丗万丅下丗丝万.enabled.GetValueOrDefault();
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "effectiveSettings");
        }
        internal static bool 丑丄丙一丑丅专丅上(PGCompany.DataObjects.万丞丘丏丆丆丝与与.上丒上丛业丕东世七 丟丐丗万丅下丗丝万, string 下一丆丏丝丄东三三)
        {
            if(丟丐丗万丅下丗丝万 != null)
            {
                    if(下一丆丏丝丄东三三 == null)
            {
                    return false;
            }
            
                if(丟丐丗万丅下丗丝万.disableDevices == null)
            {
                    return false;
            }
            
                var val_3 = 0;
                val_3 = val_3 + 1;
                return 丟丐丗万丅下丗丝万.disableDevices.Contains(item:  null);
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "effectiveSettings");
        }
        internal static System.Collections.Generic.IReadOnlyList<string> 一丏东丈上业丝丑丐(PGCompany.DataObjects.万丞丘丏丆丆丝与与.上丒上丛业丕东世七 丟丐丗万丅下丗丝万)
        {
            System.Collections.Generic.List<System.String> val_3;
            if(丟丐丗万丅下丗丝万 != null)
            {
                    val_3 = 丟丐丗万丅下丗丝万.disableDevices;
                if(val_3 != null)
            {
                    return (System.Collections.Generic.IReadOnlyList<System.String>)System.Array.Empty<System.String>();
            }
            
                return (System.Collections.Generic.IReadOnlyList<System.String>)System.Array.Empty<System.String>();
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "effectiveSettings");
        }
    
    }

}
