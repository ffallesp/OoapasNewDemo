using Serenity.Navigation;
using MyPages = OoapasNewDemo.ModuloComercial.Pages;

[assembly: NavigationLink(int.MaxValue, "ModuloComercial/Padron", typeof(MyPages.PadronController), icon: null)]

[assembly: NavigationLink(int.MaxValue, "ModuloComercial/Contratos", typeof(MyPages.ContratosController), icon: null)]
