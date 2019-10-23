
namespace OoapasNewDemo.Usuarios.Entities {
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Usuarios"), Module("Usuarios"), TableName("[dbo].[USU_Catalogo]")]
    [DisplayName("Catalogo"), InstanceName("Usuario")]
    //[ReadPermission("Administration:General")]
    //[ModifyPermission("Administration:General")]
    [ReadPermission(PermissionKeys.Catalago)]
    [ModifyPermission(PermissionKeys.Catalago)]
    public sealed class CatalagoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Usuario"), PrimaryKey]
        public Int32? Usuario
        {
            get { return Fields.Usuario[this]; }
            set { Fields.Usuario[this] = value; }
        }

        [DisplayName("Entidad"), NotNull]
        public Int16? Entidad
        {
            get { return Fields.Entidad[this]; }
            set { Fields.Entidad[this] = value; }
        }

        [DisplayName("Sub Sistema"), NotNull]
        public Int16? SubSistema
        {
            get { return Fields.SubSistema[this]; }
            set { Fields.SubSistema[this] = value; }
        }

        [DisplayName("Empleado"), Size(10), QuickSearch]
        public String Empleado
        {
            get { return Fields.Empleado[this]; }
            set { Fields.Empleado[this] = value; }
        }

        [DisplayName("Oficina")]
        public Int16? Oficina
        {
            get { return Fields.Oficina[this]; }
            set { Fields.Oficina[this] = value; }
        }

        [DisplayName("Nombre"), Size(60), NotNull]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Jefe Inmediato"), Size(60), NotNull]
        public String JefeInmediato
        {
            get { return Fields.JefeInmediato[this]; }
            set { Fields.JefeInmediato[this] = value; }
        }

        [DisplayName("Departamento"), Size(60), NotNull]
        public String Departamento
        {
            get { return Fields.Departamento[this]; }
            set { Fields.Departamento[this] = value; }
        }

        [DisplayName("Puesto"), Size(60), NotNull]
        public String Puesto
        {
            get { return Fields.Puesto[this]; }
            set { Fields.Puesto[this] = value; }
        }

        [DisplayName("Fec Nacimiento"), NotNull]
        public DateTime? FecNacimiento
        {
            get { return Fields.FecNacimiento[this]; }
            set { Fields.FecNacimiento[this] = value; }
        }

        [DisplayName("Nombre Acceso"), Size(30), NotNull]
        public String NombreAcceso
        {
            get { return Fields.NombreAcceso[this]; }
            set { Fields.NombreAcceso[this] = value; }
        }

        [DisplayName("Clave Acceso"), Size(50), NotNull]
        public String ClaveAcceso
        {
            get { return Fields.ClaveAcceso[this]; }
            set { Fields.ClaveAcceso[this] = value; }
        }

        [DisplayName("Activo"), NotNull]
        public Boolean? Activo
        {
            get { return Fields.Activo[this]; }
            set { Fields.Activo[this] = value; }
        }

        [DisplayName("Dias Cc"), Column("DiasCC"), NotNull]
        public Int16? DiasCc
        {
            get { return Fields.DiasCc[this]; }
            set { Fields.DiasCc[this] = value; }
        }

        [DisplayName("Fecha Uc"), Column("FechaUC"), NotNull]
        public DateTime? FechaUc
        {
            get { return Fields.FechaUc[this]; }
            set { Fields.FechaUc[this] = value; }
        }

        [DisplayName("Fecha Pc"), Column("FechaPC"), NotNull]
        public DateTime? FechaPc
        {
            get { return Fields.FechaPc[this]; }
            set { Fields.FechaPc[this] = value; }
        }

        [DisplayName("No Sesiones"), NotNull]
        public Int16? NoSesiones
        {
            get { return Fields.NoSesiones[this]; }
            set { Fields.NoSesiones[this] = value; }
        }

        [DisplayName("No Sesiones Act"), NotNull]
        public Int16? NoSesionesAct
        {
            get { return Fields.NoSesionesAct[this]; }
            set { Fields.NoSesionesAct[this] = value; }
        }

        [DisplayName("Inactividad Out"), NotNull]
        public Int16? InactividadOut
        {
            get { return Fields.InactividadOut[this]; }
            set { Fields.InactividadOut[this] = value; }
        }

        [DisplayName("Vigencia"), NotNull]
        public Boolean? Vigencia
        {
            get { return Fields.Vigencia[this]; }
            set { Fields.Vigencia[this] = value; }
        }

        [DisplayName("Fecha Vig")]
        public DateTime? FechaVig
        {
            get { return Fields.FechaVig[this]; }
            set { Fields.FechaVig[this] = value; }
        }

        [DisplayName("Tel Ext"), Size(30), NotNull]
        public String TelExt
        {
            get { return Fields.TelExt[this]; }
            set { Fields.TelExt[this] = value; }
        }

        [DisplayName("Obs"), Size(100)]
        public String Obs
        {
            get { return Fields.Obs[this]; }
            set { Fields.Obs[this] = value; }
        }

        [DisplayName("Quien"), NotNull]
        public Int16? Quien
        {
            get { return Fields.Quien[this]; }
            set { Fields.Quien[this] = value; }
        }

        [DisplayName("Cuando"), NotNull]
        public DateTime? Cuando
        {
            get { return Fields.Cuando[this]; }
            set { Fields.Cuando[this] = value; }
        }

        [DisplayName("Donde")]
        public Int16? Donde
        {
            get { return Fields.Donde[this]; }
            set { Fields.Donde[this] = value; }
        }

        [DisplayName("Grupo")]
        public Int16? Grupo
        {
            get { return Fields.Grupo[this]; }
            set { Fields.Grupo[this] = value; }
        }

        [DisplayName("Administrador")]
        public Int16? Administrador
        {
            get { return Fields.Administrador[this]; }
            set { Fields.Administrador[this] = value; }
        }

        [DisplayName("Perfil T Rep")]
        public Int16? PerfilTRep
        {
            get { return Fields.PerfilTRep[this]; }
            set { Fields.PerfilTRep[this] = value; }
        }

        [DisplayName("Oficina Oper"), Size(12)]
        public String OficinaOper
        {
            get { return Fields.OficinaOper[this]; }
            set { Fields.OficinaOper[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Usuario; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Empleado; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CatalagoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Usuario;
            public Int16Field Entidad;
            public Int16Field SubSistema;
            public StringField Empleado;
            public Int16Field Oficina;
            public StringField Nombre;
            public StringField JefeInmediato;
            public StringField Departamento;
            public StringField Puesto;
            public DateTimeField FecNacimiento;
            public StringField NombreAcceso;
            public StringField ClaveAcceso;
            public BooleanField Activo;
            public Int16Field DiasCc;
            public DateTimeField FechaUc;
            public DateTimeField FechaPc;
            public Int16Field NoSesiones;
            public Int16Field NoSesionesAct;
            public Int16Field InactividadOut;
            public BooleanField Vigencia;
            public DateTimeField FechaVig;
            public StringField TelExt;
            public StringField Obs;
            public Int16Field Quien;
            public DateTimeField Cuando;
            public Int16Field Donde;
            public Int16Field Grupo;
            public Int16Field Administrador;
            public Int16Field PerfilTRep;
            public StringField OficinaOper;
        }
    }
}
