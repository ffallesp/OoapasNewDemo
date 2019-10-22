
namespace OoapasNewDemo.Usuarios.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Usuarios.Catalago")]
    [BasedOnRow(typeof(Entities.CatalagoRow), CheckNames = true)]
    public class CatalagoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Usuario { get; set; }
        public Int16 Entidad { get; set; }
        public Int16 SubSistema { get; set; }
        [EditLink]
        public String Empleado { get; set; }
        public Int16 Oficina { get; set; }
        public String Nombre { get; set; }
        public String JefeInmediato { get; set; }
        public String Departamento { get; set; }
        public String Puesto { get; set; }
        public DateTime FecNacimiento { get; set; }
        public String NombreAcceso { get; set; }
        public String ClaveAcceso { get; set; }
        public Boolean Activo { get; set; }
        public Int16 DiasCc { get; set; }
        public DateTime FechaUc { get; set; }
        public DateTime FechaPc { get; set; }
        public Int16 NoSesiones { get; set; }
        public Int16 NoSesionesAct { get; set; }
        public Int16 InactividadOut { get; set; }
        public Boolean Vigencia { get; set; }
        public DateTime FechaVig { get; set; }
        public String TelExt { get; set; }
        public String Obs { get; set; }
        public Int16 Quien { get; set; }
        public DateTime Cuando { get; set; }
        public Int16 Donde { get; set; }
        public Int16 Grupo { get; set; }
        public Int16 Administrador { get; set; }
        public Int16 PerfilTRep { get; set; }
        public String OficinaOper { get; set; }
    }
}