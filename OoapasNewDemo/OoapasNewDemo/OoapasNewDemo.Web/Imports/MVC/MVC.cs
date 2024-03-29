﻿using System;

namespace MVC
{
    public static class Views
    {
        public static class Administration
        {
            public static class Language
            {
                public const string LanguageIndex = "~/Modules/Administration/Language/LanguageIndex.cshtml";
            }

            public static class Role
            {
                public const string RoleIndex = "~/Modules/Administration/Role/RoleIndex.cshtml";
            }

            public static class Sergen
            {
                public const string SergenError = "~/Modules/Administration/Sergen/SergenError.cshtml";
                public const string SergenIndex = "~/Modules/Administration/Sergen/SergenIndex.cshtml";
            }

            public static class Translation
            {
                public const string TranslationIndex = "~/Modules/Administration/Translation/TranslationIndex.cshtml";
            }

            public static class User
            {
                public const string UserIndex = "~/Modules/Administration/User/UserIndex.cshtml";
            }

        }

        public static class Common
        {
            public static class Dashboard
            {
                public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
            }

            public static class Reporting
            {
                public const string ReportPage = "~/Modules/Common/Reporting/ReportPage.cshtml";
            }
        }

        public static class Errors
        {
            public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
            public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
        }

        public static class Membership
        {
            public static class Account
            {
                public const string AccountLogin = "~/Modules/Membership/Account/AccountLogin.cshtml";
                public const string AccountLogin_AdminLTE = "~/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml";
                public static class ChangePassword
                {
                    public const string AccountChangePassword = "~/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml";
                }

                public static class ForgotPassword
                {
                    public const string AccountForgotPassword = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml";
                    public const string AccountForgotPassword_AdminLTE = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.AdminLTE.cshtml";
                }

                public static class ResetPassword
                {
                    public const string AccountResetPassword = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.cshtml";
                    public const string AccountResetPassword_AdminLTE = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.AdminLTE.cshtml";
                    public const string AccountResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml";
                }

                public static class SignUp
                {
                    public const string AccountActivateEmail = "~/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml";
                    public const string AccountSignUp = "~/Modules/Membership/Account/SignUp/AccountSignUp.cshtml";
                    public const string AccountSignUp_AdminLTE = "~/Modules/Membership/Account/SignUp/AccountSignUp.AdminLTE.cshtml";
                }
            }

        }

        public static class ModuloComercial
        {
            public static class AnalisisGerencial
            {
                public const string AnalisisIndex = "~/Modules/ModuloComercial/AnalisisGerencial/AnalisisIndex.cshtml";
            }

            public static class Contratos
            {
                public const string ContratosIndex = "~/Modules/ModuloComercial/Contratos/ContratosIndex.cshtml";
            }

            public static class Facturacion
            {
                public const string FacturacionIndex = "~/Modules/ModuloComercial/Facturacion/FacturacionIndex.cshtml";
            }

            public static class GestionCobranza
            {
                public const string GestionIndex = "~/Modules/ModuloComercial/GestionCobranza/GestionIndex.cshtml";
            }

            public static class Hidrometria
            {
                public const string HidrometriaIndex = "~/Modules/ModuloComercial/Hidrometria/HidrometriaIndex.cshtml";
            }

            public static class Padron
            {
                public const string PadronIndex = "~/Modules/ModuloComercial/Padron/PadronIndex.cshtml";
            }

            public static class Recaudacion
            {
                public const string RecaudacionIndex = "~/Modules/ModuloComercial/Recaudacion/RecaudacionIndex.cshtml";
            }

            public static class Servicios
            {
                public const string ServiciosIndex = "~/Modules/ModuloComercial/Servicios/ServiciosIndex.cshtml";
            }

        }

        public static class ModuloOperacion
        {
            public static class Factibilidades
            {
                public const string FactibilidadesIndex = "~/Modules/ModuloOperacion/Factibilidades/FactibilidadesIndex.cshtml";
            }

            public static class OrdenesServicios
            {
                public const string OrdenesIndex = "~/Modules/ModuloOperacion/OrdenesServicios/OrdenesIndex.cshtml";
            }

            public static class ReportesSolicitudes
            {
                public const string ReportesSolicitudesIndex = "~/Modules/ModuloOperacion/ReportesSolicitudes/ReportesSolicitudesIndex.cshtml";
            }
        }

        public static class Shared
        {
            public const string _Layout = "~/Views/Shared/_Layout.cshtml";
            public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
            public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
            public const string _LayoutSlim = "~/Views/Shared/_LayoutSlim.cshtml";
            public const string _LayoutSlimHead = "~/Views/Shared/_LayoutSlimHead.cshtml";
            public const string Error = "~/Views/Shared/Error.cshtml";
            public const string LeftNavigation = "~/Views/Shared/LeftNavigation.cshtml";
        }

        public static class Usuarios
        {
            public static class Catalago
            {
                public const string CatalagoIndex = "~/Modules/Usuarios/Catalago/CatalagoIndex.cshtml";
            }

        }

    }
}
