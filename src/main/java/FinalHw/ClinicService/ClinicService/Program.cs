
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.Data.Sqlite;

namespace ClinicService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ConfigureSqlLiteConnection();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IClientRepository, ClientRepository>();
            builder.Services.AddScoped<IPetRepository, PetRepository>();
            builder.Services.AddScoped<IConsultationRepository, ConsultatioinRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(configure => { configure.EnableAnnotations(); });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static void ConfigureSqlLiteConnection()
        {
            const string connectionString = "Data Source = clinic.db;";
            SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();
            PrepareScheme(connection);
        }

        private static void PrepareScheme(SqliteConnection connection)
        {
            SqliteCommand command = connection.CreateCommand();
            //«адаем новый текст команды дл€ выполнени€
            //”дал€ем таблицу с метриками, если есть в базе данных
            command.CommandText = "DROP TABLE IF EXISTS consultations";
            command.ExecuteNonQuery();
            command.CommandText = "DROP TABLE IF EXISTS pets";
            command.ExecuteNonQuery();
            command.CommandText = "DROP TABLE IF EXISTS clients";
            command.ExecuteNonQuery();

            command.CommandText =
                @"CREATE TABLE Clients(ClientId INTEGER PRIMARY KEY,
                Document TEXT,
                SurName TEXT,
                FirstName TEXT,
                Patronymic TEXT,
                Birthday INTEGER)";
            command.ExecuteNonQuery();
            command.CommandText =
                @"CREATE TABLE Pets(PetsId INTEGER PRIMARY KEY,
                ClientId INTEGER,
                Name TEXT,
                Birthday INTEGER)";
            command.ExecuteNonQuery();
            command.CommandText =
                @"CREATE TABLE Consultations(ConsultationsId INTEGER PRIMARY KEY,
                ClientId INTEGER,
                PetId INTEGER,
                ConsultationDate INTEGER,
                Descriptions TEXT)";
            command.ExecuteNonQuery();
        }
    }
}
