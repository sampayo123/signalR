/*
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PruebaCrud.Server.Hubs2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCrud.Server.Services
{

    public interface IDatabasesChageNotificationService
    {
        void Config();

    }

    public class SqlDependencyService : IDatabasesChageNotificationService
    {
        private readonly IConfiguration configuration;
        private readonly IHubContext<ChatHub2> chatHub;

        public SqlDependencyService(IConfiguration configuration,
            IHubContext<ChatHub2> chatHub)
        {
            this.configuration = configuration;
            this.chatHub = chatHub;

        }

        public void Config()
        {
            SuscribirseALosCambiosDeLaTablaPersonas();
        }

        private void SuscribirseALosCambiosDeLaTablaPersonas()
        {
            string connString = configuration.GetConnectionString("DefaultConnection");
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(@"SELECT nombre FROM [dbo].Personas", conn))
                {
                    cmd.Notification = null;
                    SqlDependency dependency = new SqlDependency(cmd);
                    dependency.OnChange += Personas_Cambio;
                    SqlDependency.Start(connString);
                    cmd.ExecuteReader();
                }
            }

        }

        private void Personas_Cambio(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                string mensaje = ObtenerMensajeAMostrar(e);
                chatHub.Clients.All.SendAsync("ReceiveMessage", "Admin", mensaje);
               

            }

            SuscribirseALosCambiosDeLaTablaPersonas();
        }

        private string ObtenerMensajeAMostrar(SqlNotificationEventArgs e)
        {
            switch (e.Info)
            {
                case SqlNotificationInfo.Insert:
                    return "Un dato fue agregado";
                case SqlNotificationInfo.Delete:
                    return "Un dato fue borrado";
                case SqlNotificationInfo.Update:
                    return "Un dato fue actualizado";
                default:
                    return "Un cambio desconocido ha ocurrido";
            }
        }
    }
}*/
