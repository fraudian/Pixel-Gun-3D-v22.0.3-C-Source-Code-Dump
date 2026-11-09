using UnityEngine;
private sealed class SeasonEndView.丗上不东丌与丕丙丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.Transform 丕专上丁丅丅丏万丌;
    public System.Action 丛丝与丂世丌丌丝丂;
    public TournamentReward 丗七丟丈三不丕一三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SeasonEndView.丗上不东丌与丕丙丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ExperienceController val_37;
        SeasonEndView val_38;
        int val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        val_37 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_38 = 1152921505086132224;
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.BannersHolder != 0)
        {
                if(CurrentBanner != 0)
        {
            goto label_33;
        }
        
        }
        
        }
        
            if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  135)) > 0)
        {
            goto label_33;
        }
        
        }
        
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                label_33:
            val_39 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_39;
            return (bool)val_39;
        }
        
            if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
            goto label_33;
        }
        
        }
        
            val_40 = null;
            val_40 = null;
            SeasonEndView.上专业丘丝丕丆丘七 = 0;
            SeasonEndView.且丆七下且丐丁与丌 = 0;
            SeasonEndView.丘丙丌丂丕丞丏丁丒 = 0;
            TournamentController.丁丟丂七与丏丛丐丄(丙业与丙丗丝不丈东:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
            TournamentController.七丅三丏三丛专丅与(丙业与丙丗丝不丈东:  0);
            if(SeasonEndView.业丄丛且丝三丗丏丅 == 0)
        {
                val_41 = null;
            val_41 = null;
            SeasonEndView.业丄丛且丝三丗丏丅 = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕(丑与丞三且丛与丟业:  "NguiWindows/LeagueStep", 七万上丐一丈丏丏专:  this.丕专上丁丅丅丏万丌.gameObject, 万世丛丄丄业丆且丅:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<SeasonEndView>();
            int val_22 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  SeasonEndView.业丄丛且丝三丗丏丅.gameObject, 不东丛三丂丌丑专丆:  this.丕专上丁丅丅丏万丌.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        else
        {
                val_42 = null;
            val_42 = null;
            if(this.丕专上丁丅丅丏万丌 != SeasonEndView.丈东丘丏与丌东东下)
        {
                val_43 = null;
            val_43 = null;
            SeasonEndView.丈东丘丏与丌东东下 = this.丕专上丁丅丅丏万丌;
            SeasonEndView.业丄丛且丝三丗丏丅.transform.parent = this.丕专上丁丅丅丏万丌;
            int val_28 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  SeasonEndView.业丄丛且丝三丗丏丅.gameObject, 不东丛三丂丌丑专丆:  this.丕专上丁丅丅丏万丌.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        
            val_44 = null;
            val_44 = null;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  SeasonEndView.业丄丛且丝三丗丏丅.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
            val_45 = null;
            val_45 = null;
            if(SeasonEndView.业丄丛且丝三丗丏丅 == null)
        {
                val_45 = null;
        }
        
            mem2[0] = this.丛丝与丂世丌丌丝丂;
            mem2[0] = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
            val_38 = SeasonEndView.业丄丛且丝三丗丏丅;
            mem2[0] = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
            val_46 = null;
            if(SeasonEndView.业丄丛且丝三丗丏丅 == null)
        {
                val_46 = null;
        }
        
            mem2[0] = 0;
            mem2[0] = this.丗七丟丈三不丕一三;
            SeasonEndView.业丄丛且丝三丗丏丅.丙丁丏丛且万下丏丂();
            SeasonEndView.且丙七丕丛专业丁丕 = 0;
            val_47 = null;
            val_47 = null;
            val_37 = ExperienceController.sharedController;
            if(val_37 != 0)
        {
                val_48 = null;
            val_48 = null;
            val_49 = null;
            val_38 = SeasonEndView.业丄丛且丝三丗丏丅;
            val_49 = null;
            bool val_36 = ExperienceController.sharedController.下一丝丗丁上世丐上();
            mem2[0] = 0;
            val_37 = ExperienceController.sharedController;
            val_37.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        val_39 = 0;
        return (bool)val_39;
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
