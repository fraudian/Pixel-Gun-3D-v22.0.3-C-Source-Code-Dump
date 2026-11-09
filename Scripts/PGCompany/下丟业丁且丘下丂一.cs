using UnityEngine;

namespace PGCompany
{
    internal sealed class 下丟业丁且丘下丂一 : IDisposable
    {
        // Fields
        private static PGCompany.下丟业丁且丘下丂一 丝业丆丁业三丈丟东;
        private System.EventHandler<Rilisoft.业丗丒丞万七三丄七> 丏上不丗丐下丞与七;
        
        // Properties
        internal static PGCompany.下丟业丁且丘下丂一 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.下丟业丁且丘下丂一 丑七不且上丗丁一世()
        {
            PGCompany.下丟业丁且丘下丂一 val_2 = PGCompany.下丟业丁且丘下丂一.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            PGCompany.下丟业丁且丘下丂一 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.下丟业丁且丘下丂一();
            PGCompany.下丟业丁且丘下丂一.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        internal void 万一丝一与丏丕丌丐(System.EventHandler<Rilisoft.业丗丒丞万七三丄七> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丏上不丗丐下丞与七, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丏上不丗丐下丞与七 != 1152921553976361232);
        
        }
        internal void 上与专下丐一丕丒丕(System.EventHandler<Rilisoft.业丗丒丞万七三丄七> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丏上不丗丐下丞与七, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丏上不丗丐下丞与七 != 1152921553976497808);
        
        }
        private 下丟业丁且丘下丂一()
        {
        
        }
        internal void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.下丟业丁且丘下丂一::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
        }
        internal void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.下丟业丁且丘下丂一::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
        }
        private void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                    return;
            }
            
            if(丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌() == 100)
            {
                    return;
            }
            
            if((GameConnect.丞丗东丆下丈丒东业(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) == true)
            {
                    return;
            }
            
            1152921505243639808 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            丗丛不丁丑专专丂且 = 丗丛不丁丑专专丂且.东丐三一业与丘丂丕();
            1152921505243639808.不且业业不万丛与一(丌丕三丌丈且丞且丆:  PixelTime.丝丗专上三不丄丑丑(), 丑一丂丙丈丝丑丅丑:  丗丛不丁丑专专丂且);
            if(this.丏上不丗丐下丞与七 == null)
            {
                    return;
            }
            
            this.丏上不丗丐下丞与七.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        public void Dispose()
        {
            this.不与丞下业丑丒丙万();
        }
    
    }

}
