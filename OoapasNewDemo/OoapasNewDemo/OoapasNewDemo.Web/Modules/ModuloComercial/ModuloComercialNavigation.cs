using Serenity.Navigation;
using MyPages = OoapasNewDemo.ModuloComercial.Pages;

[assembly: NavigationLink(1000, "Módulo Comercial", url: "~/", permission: "", icon: "fa-briefcase")]
[assembly: NavigationLink(int.MaxValue, "Módulo Comercial/Padrón", typeof(MyPages.PadronController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Comercial/Contratos", typeof(MyPages.ContratosController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Comercial/Hidrometría", typeof(MyPages.HidrometriaController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Comercial/Facturación", typeof(MyPages.FacturacionController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Comercial/Servicios", typeof(MyPages.ServiciosController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Comercial/Gestión Cobranza", typeof(MyPages.GestionController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Comercial/Recaudación", typeof(MyPages.RecaudacionController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Comercial/Análisis Gerencial", typeof(MyPages.AnalisisController), icon: null)]
