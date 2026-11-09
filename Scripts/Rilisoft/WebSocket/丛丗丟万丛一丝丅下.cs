using UnityEngine;

namespace Rilisoft.WebSocket
{
    internal sealed class 丛丗丟万丛一丝丅下 : IDisposable
    {
        // Fields
        private static System.Action<Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与> 丞七丗专与丘丕丗丛;
        private System.Collections.Generic.List<Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与> 丝世丄丟丑业专丟与;
        private float 丘丅丆业世丂丝丝丐;
        private bool 丄上丈丝丒七丂下东;
        private static float <丁丈三丛万上七三东>k__BackingField;
        
        // Properties
        internal static float 丟丒丕与丂不且丟丞 { get; set; }
        
        // Methods
        internal static void 丂东上且丂下丛不丐(System.Action<Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丞七丗专与丘丕丗丛, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 三丈丈世丌东世万专(System.Action<Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丞七丗专与丘丕丗丛, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static float 丒丑丝丙丂上丆丙世()
        {
            null = null;
            return (float)Rilisoft.WebSocket.丛丗丟万丛一丝丅下.<丁丈三丛万上七三东>k__BackingField;
        }
        internal static void 丙丌东丑丟丒丆丘丏(float 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.WebSocket.丛丗丟万丛一丝丅下.<丁丈三丛万上七三东>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private static 丛丗丟万丛一丝丅下()
        {
            Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丙丌东丑丟丒丆丘丏(丙业与丙丗丝不丈东:  120f);
        }
        internal 丛丗丟万丛一丝丅下()
        {
            this.丝世丄丟丑业专丟与 = new System.Collections.Generic.List<丙丏丈上丞上专丅与>();
            CoroutineRunner.丈与丅丆丘丟丆丆丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.WebSocket.丛丗丟万丛一丝丅下::丐东丛与与上丑丛不()));
        }
        private void 丐东丛与与上丑丛不()
        {
            this.丘丅丆业世丂丝丝丐 = UnityEngine.Time.unscaledTime;
            this.上丅丑丂一一丛世丟();
        }
        private void 上丅丑丂一一丛世丟()
        {
            var val_5;
            var val_6;
            if(this.丄上丈丝丒七丂下东 == true)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_12;
            label_16:
            丙丏丈上丞上专丅与 val_1 = this.丝世丄丟丑业专丟与.Item[0];
            if((val_1 != null) && (val_1.丒世丒东丑丙丂东三 != true))
            {
                    float val_5 = this.丘丅丆业世丂丝丝丐;
                val_5 = val_5 - val_1.三丌丄丆下丑丛七不;
                if(val_5 > val_1.丟上丛不丗丂七丙丁)
            {
                    val_1.丒世丒东丑丙丂东三 = true;
                val_6 = null;
                val_6 = null;
                if(Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丞七丗专与丘丕丗丛 != null)
            {
                    Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丞七丗专与丘丕丗丛.Invoke(obj:  val_1.专丒业丘七丞不丗丛());
            }
            
            }
            
            }
            
            val_5 = 1;
            label_12:
            if(val_5 < this.丝世丄丟丑业专丟与.Count)
            {
                goto label_16;
            }
        
        }
        private bool 丙丒上下业丄世丞丝(int 丞丅上丏丂且下丅与)
        {
            var val_4;
            var val_5;
            val_4 = 0;
            goto label_1;
            label_8:
            if(this.丝世丄丟丑业专丟与.Item[0] == null)
            {
                goto label_3;
            }
            
            丙丏丈上丞上专丅与 val_2 = this.丝世丄丟丑业专丟与.Item[0];
            if(val_2.下丄丈不与世丐业专 == 丞丅上丏丂且下丅与)
            {
                goto label_6;
            }
            
            label_3:
            val_4 = 1;
            label_1:
            if(val_4 < this.丝世丄丟丑业专丟与.Count)
            {
                goto label_8;
            }
            
            val_5 = 0;
            return (bool)val_5;
            label_6:
            val_5 = 1;
            return (bool)val_5;
        }
        internal void 丟丘三丄丁丐专丙丁(int 丞丅上丏丂且下丅与, string 丒丘丏上丙丟丑丕丈, float 丙世丙丒丑三一丝万)
        {
            int val_8;
            var val_9;
            val_8 = 丞丅上丏丂且下丅与;
            if(this.丄上丈丝丒七丂下东 == true)
            {
                    return;
            }
            
            if((this.丙丒上下业丄世丞丝(丞丅上丏丂且下丅与:  val_8)) != false)
            {
                    val_8 = System.String.Format(format:  "[{0}] Event with ID {1} already exists. Did you miss RemoveEvent()?", arg0:  丒丘丏上丙丟丑丕丈.GetType(), arg1:  val_8);
                UnityEngine.Debug.LogError(message:  val_8);
                return;
            }
            
            val_9 = 0;
            goto label_6;
            label_10:
            if(X23.Item[0] == null)
            {
                goto label_8;
            }
            
            val_9 = 1;
            label_6:
            if(val_9 < this.丝世丄丟丑业专丟与.Count)
            {
                goto label_10;
            }
            
            .下丄丈不与世丐业专 = val_8;
            .专丕与丒丗丁丘专丟 = 丒丘丏上丙丟丑丕丈;
            .三丌丄丆下丑丛七不 = this.丘丅丆业世丂丝丝丐;
            .丟上丛不丗丂七丙丁 = 丙世丙丒丑三一丝万;
            .丒世丒东丑丙丂东三 = false;
            this.丝世丄丟丑业专丟与.Add(item:  new 丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与());
            return;
            label_8:
            .下丄丈不与世丐业专 = val_8;
            .专丕与丒丗丁丘专丟 = 丒丘丏上丙丟丑丕丈;
            .三丌丄丆下丑丛七不 = this.丘丅丆业世丂丝丝丐;
            .丟上丛不丗丂七丙丁 = 丙世丙丒丑三一丝万;
            .丒世丒东丑丙丂东三 = false;
            this.丝世丄丟丑业专丟与.set_Item(index:  0, value:  new 丛丗丟万丛一丝丅下.丙丏丈上丞上专丅与());
        }
        internal void 丘丁丂丘三丒丙丈丄(int 丞丅上丏丂且下丅与)
        {
            var val_4;
            if(this.丄上丈丝丒七丂下东 == true)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_2;
            label_9:
            if(this.丝世丄丟丑业专丟与.Item[0] == null)
            {
                goto label_4;
            }
            
            丙丏丈上丞上专丅与 val_2 = this.丝世丄丟丑业专丟与.Item[0];
            if(val_2.下丄丈不与世丐业专 == 丞丅上丏丂且下丅与)
            {
                goto label_7;
            }
            
            label_4:
            val_4 = 1;
            label_2:
            if(val_4 < this.丝世丄丟丑业专丟与.Count)
            {
                goto label_9;
            }
            
            return;
            label_7:
            this.丝世丄丟丑业专丟与.set_Item(index:  0, value:  0);
        }
        public void Dispose()
        {
            if(this.丄上丈丝丒七丂下东 == true)
            {
                    return;
            }
            
            CoroutineRunner.东丁丗三丌丆丝丘丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.WebSocket.丛丗丟万丛一丝丅下::丐东丛与与上丑丛不()));
            this.丄上丈丝丒七丂下东 = true;
        }
    
    }

}
