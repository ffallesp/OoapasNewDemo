
namespace OoapasNewDemo.Usuarios {

    @Serenity.Decorators.registerClass()
    export class CatalagoDialog extends Serenity.EntityDialog<CatalagoRow, any> {
        protected getFormKey() { return CatalagoForm.formKey; }
        protected getIdProperty() { return CatalagoRow.idProperty; }
        protected getLocalTextPrefix() { return CatalagoRow.localTextPrefix; }
        protected getNameProperty() { return CatalagoRow.nameProperty; }
        protected getService() { return CatalagoService.baseUrl; }

        protected form = new CatalagoForm(this.idPrefix);

    }
}