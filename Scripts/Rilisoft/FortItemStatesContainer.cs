using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal sealed class FortItemStatesContainer : ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.FortItemState> _states;
        internal System.Collections.Generic.Dictionary<string, Rilisoft.FortItemState> States;
        
        // Methods
        public void OnAfterDeserialize()
        {
            if(this.States != null)
            {
                    this.States.Clear();
            }
            else
            {
                    this.States = new System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState>();
            }
            
            List.Enumerator<T> val_2 = this._states.GetEnumerator();
            label_9:
            if(((-657442968) & 1) == 0)
            {
                goto label_4;
            }
            
            if((this.States.ContainsKey(key:  X22)) == true)
            {
                goto label_9;
            }
            
            this.States.Add(key:  X22, value:  0.丐丏七丌丕丗业且上());
            goto label_9;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this._states.Clear();
        }
        public void OnBeforeSerialize()
        {
            var val_4 = this;
            if(this.States == null)
            {
                    return;
            }
            
            this._states.Clear();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.States.Values.GetEnumerator();
            label_7:
            if(((-657273608) & 1) == 0)
            {
                goto label_5;
            }
            
            this._states.Add(item:  0.丐丏七丌丕丗业且上());
            goto label_7;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public FortItemStatesContainer()
        {
            this._states = new System.Collections.Generic.List<Rilisoft.FortItemState>();
            this.States = new System.Collections.Generic.Dictionary<System.String, Rilisoft.FortItemState>();
        }
    
    }

}
