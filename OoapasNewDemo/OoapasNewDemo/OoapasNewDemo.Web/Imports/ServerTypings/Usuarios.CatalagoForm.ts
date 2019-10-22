namespace OoapasNewDemo.Usuarios {
    export interface CatalagoForm {
        Entidad: Serenity.IntegerEditor;
        SubSistema: Serenity.IntegerEditor;
        Empleado: Serenity.StringEditor;
        Oficina: Serenity.IntegerEditor;
        Nombre: Serenity.StringEditor;
        JefeInmediato: Serenity.StringEditor;
        Departamento: Serenity.StringEditor;
        Puesto: Serenity.StringEditor;
        FecNacimiento: Serenity.DateEditor;
        NombreAcceso: Serenity.StringEditor;
        ClaveAcceso: Serenity.StringEditor;
        Activo: Serenity.BooleanEditor;
        DiasCc: Serenity.IntegerEditor;
        FechaUc: Serenity.DateEditor;
        FechaPc: Serenity.DateEditor;
        NoSesiones: Serenity.IntegerEditor;
        NoSesionesAct: Serenity.IntegerEditor;
        InactividadOut: Serenity.IntegerEditor;
        Vigencia: Serenity.BooleanEditor;
        FechaVig: Serenity.DateEditor;
        TelExt: Serenity.StringEditor;
        Obs: Serenity.StringEditor;
        Quien: Serenity.IntegerEditor;
        Cuando: Serenity.DateEditor;
        Donde: Serenity.IntegerEditor;
        Grupo: Serenity.IntegerEditor;
        Administrador: Serenity.IntegerEditor;
        PerfilTRep: Serenity.IntegerEditor;
        OficinaOper: Serenity.StringEditor;
    }

    export class CatalagoForm extends Serenity.PrefixedContext {
        static formKey = 'Usuarios.Catalago';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CatalagoForm.init)  {
                CatalagoForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(CatalagoForm, [
                    'Entidad', w0,
                    'SubSistema', w0,
                    'Empleado', w1,
                    'Oficina', w0,
                    'Nombre', w1,
                    'JefeInmediato', w1,
                    'Departamento', w1,
                    'Puesto', w1,
                    'FecNacimiento', w2,
                    'NombreAcceso', w1,
                    'ClaveAcceso', w1,
                    'Activo', w3,
                    'DiasCc', w0,
                    'FechaUc', w2,
                    'FechaPc', w2,
                    'NoSesiones', w0,
                    'NoSesionesAct', w0,
                    'InactividadOut', w0,
                    'Vigencia', w3,
                    'FechaVig', w2,
                    'TelExt', w1,
                    'Obs', w1,
                    'Quien', w0,
                    'Cuando', w2,
                    'Donde', w0,
                    'Grupo', w0,
                    'Administrador', w0,
                    'PerfilTRep', w0,
                    'OficinaOper', w1
                ]);
            }
        }
    }
}
