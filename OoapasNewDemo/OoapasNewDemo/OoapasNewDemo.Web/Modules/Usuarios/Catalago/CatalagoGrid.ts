
namespace OoapasNewDemo.Usuarios {

    @Serenity.Decorators.registerClass()
    export class CatalagoGrid extends Serenity.EntityGrid<CatalagoRow, any> {
        protected getColumnsKey() { return 'Usuarios.Catalago'; }
        protected getDialogType() { return CatalagoDialog; }
        protected getIdProperty() { return CatalagoRow.idProperty; }
        protected getLocalTextPrefix() { return CatalagoRow.localTextPrefix; }
        protected getService() { return CatalagoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            let fld = CatalagoRow.Fields;
            return [
                { name: "", title: "all" },
                { name: fld.Empleado, title: "Empleado" },
                { name: fld.Nombre, title: "Nombre" },
                { name: fld.Puesto, title: "Puesto" },
                { name: fld.NombreAcceso, title: "Nombre usuario" }
            ];
        }

    }
}