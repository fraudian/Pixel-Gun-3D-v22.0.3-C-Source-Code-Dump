using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ModulesContainer
    {
        // Fields
        internal System.Collections.Generic.List<PGCompany.ModuleDataV1> Modules_v1;
        internal System.Collections.Generic.List<PGCompany.ModuleData> Modules_v2;
        internal System.Collections.Generic.List<PGCompany.不丑一丕丑业七下三> Storages;
        internal System.Collections.Generic.List<PGCompany.ModulesContainer.丘丛丝丘丐丄丑三丐> Energyes;
        internal PGCompany.丈世与丐丏且且丌下 CommonSettings;
        internal PGCompany.业丛丈丙丂且丌丑丙.GenerationPropertyes MigrateProperties;
        internal System.Collections.Generic.List<PGCompany.ModulesContainer.丛东三丄丞上丑上专> Sets;
        
        // Methods
        public ModulesContainer()
        {
            this.Modules_v1 = new System.Collections.Generic.List<PGCompany.ModuleDataV1>();
            this.Modules_v2 = new System.Collections.Generic.List<PGCompany.ModuleData>();
            this.Storages = new System.Collections.Generic.List<PGCompany.不丑一丕丑业七下三>();
            this.Energyes = new System.Collections.Generic.List<丘丛丝丘丐丄丑三丐>();
            this.CommonSettings = new PGCompany.丈世与丐丏且且丌下();
            this.MigrateProperties = new 业丛丈丙丂且丌丑丙.GenerationPropertyes();
            this.Sets = new System.Collections.Generic.List<丛东三丄丞上丑上专>();
        }
    
    }

}
