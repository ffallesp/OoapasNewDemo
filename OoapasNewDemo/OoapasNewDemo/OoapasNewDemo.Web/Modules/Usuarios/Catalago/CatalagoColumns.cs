
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
        [Hidden]
        public String ClaveAcceso { get; set; }
        [Hidden]
        public Boolean Activo { get; set; }
        [Hidden]
        public Int16 DiasCc { get; set; }
        [Hidden]
        public DateTime FechaUc { get; set; }
        [Hidden]
        public DateTime FechaPc { get; set; }
        [Hidden]
        public Int16 NoSesiones { get; set; }
        [Hidden]
        public Int16 NoSesionesAct { get; set; }
        [Hidden]
        public Int16 InactividadOut { get; set; }
        public Boolean Vigencia { get; set; }
        [Hidden]
        public DateTime FechaVig { get; set; }
        [Hidden]
        public String TelExt { get; set; }
        [Hidden]
        public String Obs { get; set; }
        [Hidden]
        public Int16 Quien { get; set; }
        [Hidden]
        public DateTime Cuando { get; set; }
        [Hidden]
        public Int16 Donde { get; set; }
        [Hidden]
        public Int16 Grupo { get; set; }
        [Hidden]
        public Int16 Administrador { get; set; }
        [Hidden]
        public Int16 PerfilTRep { get; set; }
        [Hidden]
        public String OficinaOper { get; set; }
    }
}