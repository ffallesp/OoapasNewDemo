namespace OoapasNewDemo.Usuarios {
    export interface CatalagoRow {
        Usuario?: number;
        Entidad?: number;
        SubSistema?: number;
        Empleado?: string;
        Oficina?: number;
        Nombre?: string;
        JefeInmediato?: string;
        Departamento?: string;
        Puesto?: string;
        FecNacimiento?: string;
        NombreAcceso?: string;
        ClaveAcceso?: string;
        Activo?: boolean;
        DiasCc?: number;
        FechaUc?: string;
        FechaPc?: string;
        NoSesiones?: number;
        NoSesionesAct?: number;
        InactividadOut?: number;
        Vigencia?: boolean;
        FechaVig?: string;
        TelExt?: string;
        Obs?: string;
        Quien?: number;
        Cuando?: string;
        Donde?: number;
        Grupo?: number;
        Administrador?: number;
        PerfilTRep?: number;
        OficinaOper?: string;
    }

    export namespace CatalagoRow {
        export const idProperty = 'Usuario';
        export const nameProperty = 'Empleado';
        export const localTextPrefix = 'Usuarios.Catalago';

        export declare const enum Fields {
            Usuario = "Usuario",
            Entidad = "Entidad",
            SubSistema = "SubSistema",
            Empleado = "Empleado",
            Oficina = "Oficina",
            Nombre = "Nombre",
            JefeInmediato = "JefeInmediato",
            Departamento = "Departamento",
            Puesto = "Puesto",
            FecNacimiento = "FecNacimiento",
            NombreAcceso = "NombreAcceso",
            ClaveAcceso = "ClaveAcceso",
            Activo = "Activo",
            DiasCc = "DiasCc",
            FechaUc = "FechaUc",
            FechaPc = "FechaPc",
            NoSesiones = "NoSesiones",
            NoSesionesAct = "NoSesionesAct",
            InactividadOut = "InactividadOut",
            Vigencia = "Vigencia",
            FechaVig = "FechaVig",
            TelExt = "TelExt",
            Obs = "Obs",
            Quien = "Quien",
            Cuando = "Cuando",
            Donde = "Donde",
            Grupo = "Grupo",
            Administrador = "Administrador",
            PerfilTRep = "PerfilTRep",
            OficinaOper = "OficinaOper"
        }
    }
}
