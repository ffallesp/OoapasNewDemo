using Serenity.Navigation;
using MyPages = OoapasNewDemo.ModuloOperacion.Pages;

[assembly: NavigationLink(1000, "Modulo Operacion", url: "~/", permission: "", icon: " fa-file-excel-o")]
[assembly: NavigationLink(int.MaxValue, "Modulo Operacion/Reportes y Solicitudes", typeof(MyPages.ReportesSolicitudesController), icon: null)]