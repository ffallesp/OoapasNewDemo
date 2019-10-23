using Serenity.Navigation;
using MyPages = OoapasNewDemo.ModuloOperacion.Pages;

[assembly: NavigationLink(1000, "Módulo Operación", url: "~/", permission: "", icon: " fa-file-excel-o")]
[assembly: NavigationLink(int.MaxValue, "Módulo Operación/Ordenes de servicio", typeof(MyPages.OrdenesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Operación/Factibilidades", typeof(MyPages.FactibilidadesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Módulo Operación/Reportes y Solicitudes", typeof(MyPages.ReportesSolicitudesController), icon: null)]