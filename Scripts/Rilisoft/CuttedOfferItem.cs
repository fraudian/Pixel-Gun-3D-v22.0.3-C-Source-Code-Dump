using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal class CuttedOfferItem : ISerializationCallbackReceiver, IEquatable<Rilisoft.CuttedOfferItem>
    {
        // Fields
        internal Rilisoft.OfferItemType Type;
        internal string Id;
        internal int Count;
        private string _serialized;
        
        // Properties
        internal string UniqueId { get; }
        
        // Methods
        internal string get_UniqueId()
        {
            return (string)this._serialized;
        }
        internal CuttedOfferItem()
        {
        
        }
        internal CuttedOfferItem(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与, int 丌丒丝东丌下丕丁丅 = 1)
        {
            val_1 = new System.Object();
            this.Type = 丁丅丈丌丟世丗丗丟;
            this.Id = val_1;
            this.Count = 丌丒丝东丌下丕丁丅;
            this._serialized = System.String.Format(format:  "{0}:{1}:{2}", arg0:  丁丅丈丌丟世丗丗丟, arg1:  this.Id, arg2:  this.Count);
        }
        public void OnAfterDeserialize()
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._serialized)) == true)
            {
                    return;
            }
            
            Rilisoft.不丗上万丟丏不丄下 val_3 = Rilisoft.业丏丐丏丄丌丒丕世.丑七不且上丗丁一世().专一上不三丒上七丏(丞丕丒专一下丙业上:  this._serialized);
            if(val_3.丕丐一丙专丛丒丑万() == false)
            {
                    return;
            }
            
            if(val_3 != null)
            {
                    this.Type = val_3.丐丞丕丗下丟且丘丌();
                this.Id = val_3.丐丙世七丅丅丐下丙();
            }
            else
            {
                    this.Type = 0.丐丞丕丗下丟且丘丌();
                this.Id = 0.丐丙世七丅丅丐下丙();
            }
            
            this.Count = val_3.丂丁丏一丙丛业且丌();
        }
        public void OnBeforeSerialize()
        {
            this._serialized = System.String.Format(format:  "{0}:{1}:{2}", arg0:  this.Type, arg1:  this.Id, arg2:  this.Count);
        }
        internal static Rilisoft.CuttedOfferItem 东丝七业丄丑丒世七(string 丞丕丒专一下丙业上)
        {
            int val_10;
            var val_11;
            Rilisoft.OfferItemType val_12;
            string val_13;
            val_10 = Rilisoft.业丏丐丏丄丌丒丕世.丑七不且上丗丁一世().专一上不三丒上七丏(丞丕丒专一下丙业上:  丞丕丒专一下丙业上);
            val_11 = 0;
            if(val_10.丕丐一丙专丛丒丑万() == false)
            {
                    return (Rilisoft.CuttedOfferItem)val_11;
            }
            
            if(val_10 != null)
            {
                    val_12 = val_10.丐丞丕丗下丟且丘丌();
                val_13 = val_10.丐丙世七丅丅丐下丙();
            }
            else
            {
                    val_12 = 0.丐丞丕丗下丟且丘丌();
                val_13 = 0.丐丙世七丅丅丐下丙();
            }
            
            val_10 = val_10.丂丁丏一丙丛业且丌();
            Rilisoft.CuttedOfferItem val_9 = null;
            val_11 = val_9;
            val_9 = new Rilisoft.CuttedOfferItem(丁丅丈丌丟世丗丗丟:  val_12, 丞丅上丏丂且下丅与:  val_13, 丌丒丝东丌下丕丁丅:  val_10);
            return (Rilisoft.CuttedOfferItem)val_11;
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{0}:{1}:{2}", arg0:  this.Type, arg1:  this.Id, arg2:  this.Count);
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 == null)
            {
                    return false;
            }
            
            return false;
        }
        public bool Equals(Rilisoft.CuttedOfferItem 丘丛丏丘丝七世七丅)
        {
            var val_3;
            if(this.Type == 丘丛丏丘丝七世七丅.Type)
            {
                    if((System.String.op_Equality(a:  this.Id, b:  丘丛丏丘丝七世七丅.Id)) != false)
            {
                    var val_2 = (this.Count == 丘丛丏丘丝七世七丅.Count) ? 1 : 0;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
    
    }

}
