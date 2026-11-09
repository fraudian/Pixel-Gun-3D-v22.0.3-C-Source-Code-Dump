using UnityEngine;

namespace PGCompany.AttributeSystem.Providers
{
    internal class 丗丏丂丟丁丑不丝丐 : 且丁丞与不三丟丌丅, IDisposable
    {
        // Fields
        private System.Action<int> 丄丙上与专丂丅丘丄;
        private readonly int 上丗业丂丑三丏上丏;
        private readonly int 与万丏业丞丌三专丌;
        private readonly PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 丆丛与丞不丒不七丆;
        
        // Methods
        public void 丟丗与丅与七上丞丑(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丙上与专丂丅丘丄, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丙上与专丂丅丘丄 != 1152921560588748432);
        
        }
        public void 三丗专上丏上丟三业(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丙上与专丂丅丘丄, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丙上与专丂丅丘丄 != 1152921560588885008);
        
        }
        internal 丗丏丂丟丁丑不丝丐(PGCompany.AttributeSystem.三丘丌不丌丞不丟丟 丂世丒下丁三丄东丆, int 丙丑七万丆万丆且丌, int 且丒丛与丞世丙丕丌)
        {
            this.与万丏业丞丌三专丌 = 且丒丛与丞世丙丕丌;
            this.丆丛与丞不丒不七丆 = 丂世丒下丁三丄东丆;
            this.上丗业丂丑三丏上丏 = 丙丑七万丆万丆且丌;
            RatingSystem.丘世一丂丝世丏丆一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AttributeSystem.Providers.丗丏丂丟丁丑不丝丐::三丆且丙丛丛丞丟丂()));
            TournamentController.七万丝世丐丅丘丁丝(丙业与丙丗丝不丈东:  new System.Action<TournamentReward>(object:  this, method:  System.Void PGCompany.AttributeSystem.Providers.丗丏丂丟丁丑不丝丐::上丘丑丏一东三丆丏(TournamentReward 万且万且丑丗且丌丆)));
        }
        public bool 丟丐下丐三一丄丞丑<T>(int 丆下丕丅丕一丝丁丛)
        {
            return UnityEngine.Object.op_Inequality(x:  RatingSystem.与一丅丝不丈业与丙(), y:  0);
        }
        public T 东且丛且业丗丑丙丗<T>(int 丆下丕丅丕一丝丁丛)
        {
            if(this.上丗业丂丑三丏上丏 > (RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏() + 1))
            {
                    return 0;
            }
            
            int val_5 = Rilisoft.Singleton<TournamentController>.Instance.下丐丕东七丞丅丙丝();
            if(val_5 >= 1)
            {
                    if(this.与万丏业丞丌三专丌 >= val_5)
            {
                goto label_7;
            }
            
            }
            
            return 0;
            label_7:
            if(((__RuntimeMethodHiddenParam + 48 + 294) & 1) != 0)
            {
                    return 0;
            }
            
            return 0;
        }
        public void 丂上丆且丘三不丟业<T>(int 丆下丕丅丕一丝丁丛, T 丙业与丙丗丝不丈东, PGCompany.AttributeSystem.丌丑业丈丅丟丙与且 专丒丌丆下丐丞丟丞)
        {
        
        }
        private void 三丆且丙丛丛丞丟丂()
        {
            this.三业三丛丅一与丙丌();
        }
        private void 上丘丑丏一东三丆丏(TournamentReward 万且万且丑丗且丌丆)
        {
            this.三业三丛丅一与丙丌();
        }
        private void 三业三丛丅一与丙丌()
        {
            if(this.丄丙上与专丂丅丘丄 == null)
            {
                    return;
            }
            
            this.丄丙上与专丂丅丘丄.Invoke(obj:  this.丆丛与丞不丒不七丆);
        }
        public void Dispose()
        {
            RatingSystem.不上丗东丞不丌丐世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.AttributeSystem.Providers.丗丏丂丟丁丑不丝丐::三丆且丙丛丛丞丟丂()));
            TournamentController.丐丁丁业且丟丄一丑(丙业与丙丗丝不丈东:  new System.Action<TournamentReward>(object:  this, method:  System.Void PGCompany.AttributeSystem.Providers.丗丏丂丟丁丑不丝丐::上丘丑丏一东三丆丏(TournamentReward 万且万且丑丗且丌丆)));
        }
    
    }

}
