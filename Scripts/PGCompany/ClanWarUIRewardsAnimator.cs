using UnityEngine;

namespace PGCompany
{
    internal class ClanWarUIRewardsAnimator : PGBehaviour
    {
        // Fields
        private System.Action 丁丁丞丌丗丑丞不丂;
        private static System.Action<上七丑业丙丒丙东丏> 丛三丞丏一丈丁丝三;
        private System.Action 丐七丘丟世丐东丛丅;
        private UnityEngine.Transform _silverRewardPoint;
        private float _emitDelay;
        private UnityEngine.Coroutine 丒丄丅丅丝丏丗且万;
        private readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<ParticleAtraktor>> 一一丄万丝丁丌世丁;
        
        // Methods
        internal void 不与东专丙东七丕世(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丁丁丞丌丗丑丞不丂, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁丁丞丌丗丑丞不丂 != 1152921554249271976);
        
        }
        internal void 上丘三东丙且三丏一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丁丁丞丌丗丑丞不丂, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁丁丞丌丗丑丞不丂 != 1152921554249408552);
        
        }
        internal static void 万丏丑丞万丟丒丗一(System.Action<上七丑业丙丒丙东丏> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.ClanWarUIRewardsAnimator.丛三丞丏一丈丁丝三, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 专不丁丌丘丁丒丟万(System.Action<上七丑业丙丒丙东丏> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.ClanWarUIRewardsAnimator.丛三丞丏一丈丁丝三, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal void 东丒丑丛丂丁上丞丟(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丐七丘丟世丐东丛丅, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐七丘丟世丐东丛丅 != 1152921554249801904);
        
        }
        internal void 世丌丘万丁七三丁上(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丐七丘丟世丐东丛丅, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐七丘丟世丐东丛丅 != 1152921554249938480);
        
        }
        private bool 丄丈世丑七与与丐业()
        {
            var val_1;
            if(this.丒丄丅丅丝丏丗且万 != null)
            {
                    this.StopCoroutine(routine:  this.丒丄丅丅丝丏丗且万);
                val_1 = 1;
                this.丒丄丅丅丝丏丗且万 = 0;
                return (bool)val_1;
            }
            
            val_1 = 0;
            return (bool)val_1;
        }
        internal void 下与丞三丅丛丄七丕(System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三)
        {
            if(this.丒丄丅丅丝丏丗且万 != null)
            {
                    this.StopCoroutine(routine:  this.丒丄丅丅丝丏丗且万);
                this.丒丄丅丅丝丏丗且万 = 0;
            }
            
            this.丒丄丅丅丝丏丗且万 = this.StartCoroutine(routine:  this.丘丙东丞丒上丛丙丙(上业丟世三与七七三:  上业丟世三与七七三));
        }
        private System.Collections.IEnumerator 丘丙东丞丒上丛丙丙(System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三)
        {
            ClanWarUIRewardsAnimator.与下万丛专丟丝且丄 val_1 = new ClanWarUIRewardsAnimator.与下万丛专丟丝且丄(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .上业丟世三与七七三 = 上业丟世三与七七三;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 且上丘丐丂丑丅世且(System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三, System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 丕丂丗丟专东丌不丞)
        {
            ClanWarUIRewardsAnimator.三与且世丛丆丄万专 val_1 = new ClanWarUIRewardsAnimator.三与且世丛丆丄万专(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .上业丟世三与七七三 = 上业丟世三与七七三;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 上业丟世三与七七三;
            }
            
            .丕丂丗丟专东丌不丞 = 丕丂丗丟专东丌不丞;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 世专丑丞丄丑与且专(System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三)
        {
            ClanWarUIRewardsAnimator.丁业世不丘丌七丗丛 val_1 = new ClanWarUIRewardsAnimator.丁业世不丘丌七丗丛(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .上业丟世三与七七三 = 上业丟世三与七七三;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丝三丘上丂丑丞丗丈(System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三, bool 且丑丞与七丂且万万)
        {
            ClanWarUIRewardsAnimator.三且且世丁丄丂丑丕 val_1 = new ClanWarUIRewardsAnimator.三且且世丁丄丂丑丕(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .上业丟世三与七七三 = 上业丟世三与七七三;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 上业丟世三与七七三;
            }
            
            .且丑丞与七丂且万万 = 且丑丞与七丂且万万;
            return (System.Collections.IEnumerator)val_1;
        }
        private ParticleAtraktor 七丒东丒上丂丘丁上(string 丞丅上丏丂且下丅与)
        {
            UnityEngine.GameObject val_17;
            ParticleAtraktor val_18;
            val_17 = this;
            if((this.一一丄万丝丁丌世丁.ContainsKey(key:  丞丅上丏丂且下丅与)) != true)
            {
                    this.一一丄万丝丁丌世丁.Add(key:  丞丅上丏丂且下丅与, value:  new System.Collections.Generic.List<ParticleAtraktor>());
            }
            
            if((System.Linq.Enumerable.Any<ParticleAtraktor>(source:  this.一一丄万丝丁丌世丁.Item[丞丅上丏丂且下丅与])) != false)
            {
                    val_18 = System.Linq.Enumerable.First<ParticleAtraktor>(source:  this.一一丄万丝丁丌世丁.Item[丞丅上丏丂且下丅与]);
                val_17 = this.一一丄万丝丁丌世丁.Item[丞丅上丏丂且下丅与];
                bool val_8 = val_17.Remove(item:  val_18);
                return (ParticleAtraktor)val_18;
            }
            
            UnityEngine.GameObject val_10 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans\\War\\Prefabs\\" + 丞丅上丏丂且下丅与);
            val_18 = 0;
            if(val_10 == 0)
            {
                    return (ParticleAtraktor)val_18;
            }
            
            val_17 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_10, 丈东丘丏与丌东东下:  this.gameObject.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            val_18 = val_17.GetComponentInChildren<ParticleAtraktor>();
            if(val_18 != 0)
            {
                    return (ParticleAtraktor)val_18;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_17);
            return (ParticleAtraktor)val_18;
        }
        private void 且业丛三丛丛丛与万(string 丞丅上丏丂且下丅与, ParticleAtraktor 丐丘业丂丙丞三不七)
        {
            if((this.一一丄万丝丁丌世丁.ContainsKey(key:  丞丅上丏丂且下丅与)) != true)
            {
                    this.一一丄万丝丁丌世丁.Add(key:  丞丅上丏丂且下丅与, value:  new System.Collections.Generic.List<ParticleAtraktor>());
            }
            
            this.一一丄万丝丁丌世丁.Item[丞丅上丏丂且下丅与].Add(item:  丐丘业丂丙丞三不七);
        }
        private void OnDisable()
        {
            if(this.丒丄丅丅丝丏丗且万 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丒丄丅丅丝丏丗且万);
            this.丒丄丅丅丝丏丗且万 = 0;
            if(this.丐七丘丟世丐东丛丅 == null)
            {
                    return;
            }
            
            this.丐七丘丟世丐东丛丅.Invoke();
        }
        private void OnDestroy()
        {
            if(this.丒丄丅丅丝丏丗且万 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丒丄丅丅丝丏丗且万);
            this.丒丄丅丅丝丏丗且万 = 0;
            if(this.丐七丘丟世丐东丛丅 == null)
            {
                    return;
            }
            
            this.丐七丘丟世丐东丛丅.Invoke();
        }
        public ClanWarUIRewardsAnimator()
        {
            this._emitDelay = 0.1f;
            this.一一丄万丝丁丌世丁 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<ParticleAtraktor>>();
        }
    
    }

}
