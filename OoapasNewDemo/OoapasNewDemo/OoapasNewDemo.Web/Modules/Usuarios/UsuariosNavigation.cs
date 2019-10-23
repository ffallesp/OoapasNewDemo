using Serenity.Navigation;
using MyPages = OoapasNewDemo.Usuarios.Pages;

[assembly: NavigationLink(int.MaxValue, "Usuarios", url: "~/", permission: "", icon: "fa-users")]
[assembly: NavigationLink(int.MaxValue, "Usuarios/Catalogo", typeof(MyPages.CatalagoController), icon: null)]