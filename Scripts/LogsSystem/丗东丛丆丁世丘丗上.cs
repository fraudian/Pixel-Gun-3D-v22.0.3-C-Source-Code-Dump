using UnityEngine;

namespace LogsSystem
{
    public class 丗东丛丆丁世丘丗上 : 丝一丈丈丕东下上且
    {
        // Methods
        public void 丆丟丟三丗东一丆三(LogsSystem.丆丌丗万丒一三东丒 丐三七与专丘丏且丂, string 丄丙下丝丛丒七丂丘)
        {
            string val_2 = 丄丙下丝丛丒七丂丘;
            if(丐三七与专丘丏且丂 == 0)
            {
                    return;
            }
            
            val_2 = System.String.Format(format:  "{0}: {1}", arg0:  丐三七与专丘丏且丂, arg1:  val_2 = 丄丙下丝丛丒七丂丘);
            if(丐三七与专丘丏且丂 <= 2)
            {
                    UnityEngine.Debug.LogError(message:  val_2);
                return;
            }
            
            if(丐三七与专丘丏且丂 == 3)
            {
                    UnityEngine.Debug.LogWarning(message:  val_2);
                return;
            }
            
            UnityEngine.Debug.Log(message:  val_2);
        }
        public void 丗且世与丗丑下且上(System.Exception 一丌七七下丐丕上丟)
        {
            UnityEngine.Debug.LogException(exception:  一丌七七下丐丕上丟);
        }
        public 丗东丛丆丁世丘丗上()
        {
        
        }
    
    }

}
