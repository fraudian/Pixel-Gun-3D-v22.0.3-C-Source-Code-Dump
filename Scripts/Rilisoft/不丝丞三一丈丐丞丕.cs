using UnityEngine;

namespace Rilisoft
{
    internal sealed class 不丝丞三一丈丐丞丕 : IDisposable
    {
        // Fields
        private const int 不丆与且丄丌丙丝丄 = 1000;
        private const int 丁上丞丟丆与丂世不 = 50;
        private System.Collections.ArrayList 丆丈丒与丛世上世与;
        private bool 丄上丈丝丒七丂下东;
        private string 一丙且丛丟丈丙且与;
        
        // Methods
        public 不丝丞三一丈丐丞丕(System.Collections.ArrayList 丄丁丅丂下与丘下丟, string 七丐丞丑丑丕世丙七)
        {
            int val_2 = val_1;
            val_1 = new System.Object();
            this.丆丈丒与丛世上世与 = 丄丁丅丂下与丘下丟;
            if(val_2 == null)
            {
                    val_2 = System.String.alignConst;
            }
            
            this.一丙且丛丟丈丙且与 = val_2;
            this.业丅上七专丐丄丝下();
        }
        public void Dispose()
        {
            if(this.丄上丈丝丒七丂下东 == true)
            {
                    return;
            }
            
            this.业丅上七专丐丄丝下();
            this.丄上丈丝丒七丂下东 = true;
        }
        private void 业丅上七专丐丄丝下()
        {
            if(UnityEngine.Debug.isDebugBuild == false)
            {
                    return;
            }
            
            if(this.丆丈丒与丛世上世与 != null)
            {
                    if(this.丆丈丒与丛世上世与 <= 50)
            {
                    if(this.丆丈丒与丛世上世与 < 1001)
            {
                    return;
            }
            
            }
            
                this.丐且丞万一一且丆丄();
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  this.一丙且丛丟丈丙且与 + ": ArrayList is null."(": ArrayList is null."));
        }
        private void 丐且丞万一一且丆丄()
        {
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "{0}{1}{1}{2}", arg0:  System.String.Format(format:  "{0}: Count: {1}, Capacity: {2}", arg0:  this.一丙且丛丟丈丙且与, arg1:  this.丆丈丒与丛世上世与, arg2:  this.丆丈丒与丛世上世与), arg1:  System.Environment.NewLine, arg2:  System.Environment.StackTrace));
        }
    
    }

}
