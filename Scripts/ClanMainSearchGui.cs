using UnityEngine;
internal abstract class ClanMainSearchGui : PGBehaviour, 丂丗丅丐下下丙丒丞
{
    // Methods
    public virtual void ShowJoinRequestDialogFromSearch(ClanSearchWrapGridItem 丞东下丙万丈不丘三)
    {
    
    }
    public virtual void JoinClanFromSearch(string 丈丈丆丞丘东专万东)
    {
    
    }
    protected System.Collections.Generic.List<ClanSearchGui.丑丏丄且丁且一专三> 丄丆丗一丏丘业与丂(System.Collections.Generic.List<ClanSearchGui.丑丏丄且丁且一专三> 丗丏丟世万万丄与丁)
    {
        var val_8;
        System.Func<丑丏丄且丁且一专三, 丑丏丄且丁且一专三> val_10;
        var val_11;
        System.Func<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, System.Int32> val_13;
        var val_14;
        System.Func<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, System.Collections.Generic.IEnumerable<丑丏丄且丁且一专三>> val_16;
        val_8 = null;
        val_8 = null;
        val_10 = ClanMainSearchGui.<>c.<>9__2_0;
        if(val_10 == null)
        {
                System.Func<丑丏丄且丁且一专三, 丑丏丄且丁且一专三> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<丑丏丄且丁且一专三, 丑丏丄且丁且一专三>(object:  ClanMainSearchGui.<>c.__il2cppRuntimeField_static_fields, method:  丑丏丄且丁且一专三 ClanMainSearchGui.<>c::丅丑万三丐丅丌丆丟(ClanSearchGui.丑丏丄且丁且一专三 丅丆东丏丙丝丅丆丟));
            ClanMainSearchGui.<>c.<>9__2_0 = val_10;
        }
        
        val_11 = null;
        val_11 = null;
        val_13 = ClanMainSearchGui.<>c.<>9__2_1;
        if(val_13 == null)
        {
                System.Func<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, System.Int32> val_4 = null;
            val_13 = val_4;
            val_4 = new System.Func<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, System.Int32>(object:  ClanMainSearchGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanMainSearchGui.<>c::丈丟丕丕丕上丑三万(System.Linq.IGrouping<int, ClanSearchGui.丑丏丄且丁且一专三> 三丟东丕丄丄下下丑));
            ClanMainSearchGui.<>c.<>9__2_1 = val_13;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = ClanMainSearchGui.<>c.<>9__2_2;
        if(val_16 != null)
        {
                return System.Linq.Enumerable.ToList<丑丏丄且丁且一专三>(source:  System.Linq.Enumerable.SelectMany<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, 丑丏丄且丁且一专三>(source:  System.Linq.Enumerable.OrderBy<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, System.Int32>(source:  System.Linq.Enumerable.GroupBy<丑丏丄且丁且一专三, System.Int32, 丑丏丄且丁且一专三>(source:  丗丏丟世万万丄与丁, keySelector:  new System.Func<丑丏丄且丁且一专三, System.Int32>(object:  ClanMainSearchGui.<>c.<>9, method:  System.Int32 ClanMainSearchGui.<>c::丕丄世一丙丙且丌丁(ClanSearchGui.丑丏丄且丁且一专三 下丅丙一丂丗丅丝七)), elementSelector:  val_2), keySelector:  val_4), selector:  System.Func<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, System.Collections.Generic.IEnumerable<丑丏丄且丁且一专三>> val_6 = null));
        }
        
        val_16 = val_6;
        val_6 = new System.Func<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, System.Collections.Generic.IEnumerable<丑丏丄且丁且一专三>>(object:  ClanMainSearchGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<丑丏丄且丁且一专三> ClanMainSearchGui.<>c::丁一丅丙万丟东丕丄(System.Linq.IGrouping<int, ClanSearchGui.丑丏丄且丁且一专三> 三丟东丕丄丄下下丑));
        ClanMainSearchGui.<>c.<>9__2_2 = val_16;
        return System.Linq.Enumerable.ToList<丑丏丄且丁且一专三>(source:  System.Linq.Enumerable.SelectMany<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, 丑丏丄且丁且一专三>(source:  System.Linq.Enumerable.OrderBy<System.Linq.IGrouping<System.Int32, 丑丏丄且丁且一专三>, System.Int32>(source:  System.Linq.Enumerable.GroupBy<丑丏丄且丁且一专三, System.Int32, 丑丏丄且丁且一专三>(source:  丗丏丟世万万丄与丁, keySelector:  new System.Func<丑丏丄且丁且一专三, System.Int32>(object:  ClanMainSearchGui.<>c.<>9, method:  System.Int32 ClanMainSearchGui.<>c::丕丄世一丙丙且丌丁(ClanSearchGui.丑丏丄且丁且一专三 下丅丙一丂丗丅丝七)), elementSelector:  val_2), keySelector:  val_4), selector:  val_6));
    }
    protected ClanMainSearchGui()
    {
    
    }

}
