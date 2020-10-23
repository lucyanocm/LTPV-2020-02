using SimpleInjector;
using System;
using System.Windows.Forms;
using UNITPAC.LTPV.Aplicacao.Interfaces;
using UNITPAC.LTPV.Aplicacao.Notificacoes;
using UNITPAC.LTPV.Aplicacao.Services;
using UNITPAC.LTPV.Data.Context;
using UNITPAC.LTPV.Data.Interface;
using UNITPAC.LTPV.Data.Repositorio;

namespace UNITPAC.LTPV.Aula03
{
    public static class Program
    {
        public static Container container;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new FrmPrincipal());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<IAlunoRepository, AlunoRepository>();

            container.Register<LTPVContext>(Lifestyle.Singleton);

            container.Register<INotificador, Notificador>();
            container.Register<IAlunoService, AlunoService>();

            // Optionally verify the container.
            container.Verify();
        }
    }
}
