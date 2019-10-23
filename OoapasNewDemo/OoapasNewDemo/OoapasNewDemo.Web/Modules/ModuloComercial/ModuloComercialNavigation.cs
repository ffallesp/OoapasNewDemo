using Serenity.Navigation;
using MyPages = OoapasNewDemo.ModuloComercial.Pages;

[assembly: NavigationLink(1000, "Modulo Comercial", url: "~/", permission: "", icon: "fa-briefcase")]
[assembly: NavigationLink(int.MaxValue, "Modulo Comercial/Padron", typeof(MyPages.PadronController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Modulo Comercial/Contratos", typeof(MyPages.ContratosController), icon: null)]
