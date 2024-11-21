using ClinicService.Models;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Impl
{
    public class ConsultatioinRepository : IConsultationRepository
    {
        const string connectionString = "Data Source = clinic.db;";

        public int Create(Consultation item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос на добавление данных
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO consultations(ClientId, PetId, ConsultationDate, Descriptions) VALUES(@ClientId, @PetId, @ConsultationDate, @Descriptions)";
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@PetId", item.PetId);
                command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate.Ticks);
                command.Parameters.AddWithValue("@Descriptions", item.Description);
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                return command.ExecuteNonQuery();
            }
        }

        public int Delete(int id)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM consultations WHERE ConsultationsId = @ConsultationsId";
                command.Parameters.AddWithValue("@ConsultationsId", id);
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                return command.ExecuteNonQuery();
            }
        }

        public List<Consultation> GetAll()
        {
            List<Consultation> list = new List<Consultation>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM consultations";
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Consultation consultation = new Consultation
                    {
                        ConsultationId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        PetId = reader.GetInt32(2),
                        ConsultationDate = new DateTime(reader.GetInt64(3)),
                        Description = reader.GetString(4)
                    };
                    list.Add(consultation);
                }
            }
            return list;
        }

        public Consultation GetById(int id)
        {
            List<Consultation> list = new List<Consultation>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM consultations WHERE ConsultationsId = @ConsultationsId";
                command.Parameters.AddWithValue("@ConsultationsId", id);
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Consultation consultation = new Consultation
                    {
                        ConsultationId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        PetId = reader.GetInt32(2),
                        ConsultationDate = new DateTime(reader.GetInt64(3)),
                        Description = reader.GetString(4)
                    };
                    return consultation;
                }
            }
            return null;
        }

        public int Update(Consultation item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос на добавление данных
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE consultations SET ClientId = @ClientId, PetId = @PetId, ConsultationDate = @ConsultationDate, Descriptions = @Description WHERE ConsultationsId = @ConsultationsId";
                command.Parameters.AddWithValue("@ConsultationsId", item.ConsultationId);
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@PetId", item.PetId);
                command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate.Ticks);
                command.Parameters.AddWithValue("@Description", item.Description);
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                return command.ExecuteNonQuery();
            }
        }
    }
}
