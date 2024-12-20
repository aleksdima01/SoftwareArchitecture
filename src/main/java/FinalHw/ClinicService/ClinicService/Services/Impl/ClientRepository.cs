﻿using ClinicService.Models;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Impl
{
    public class ClientRepository : IClientRepository
    {
        const string connectionString = "Data Source = clinic.db;";
        public int Create(Client item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос на добавление данных
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO clients(Document, SureName, FirstName, Patronymic, Birthday) VALUES(@Document, @SureName, @FirstName, @Patronymic, @Birthday)";
                command.Parameters.AddWithValue("@Document", item.Document);
                command.Parameters.AddWithValue("@SureName", item.SurName);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
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
                command.CommandText = "DELETE FROM clients WHERE ClientId = @ClientId";
                command.Parameters.AddWithValue("@ClientId", id);
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                return command.ExecuteNonQuery();
            }
        }

        public List<Client> GetAll()
        {
            List<Client> list = new List<Client>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM clients";
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client
                    {
                        ClientId = reader.GetInt32(0),
                        Document = reader.GetString(1),
                        SurName = reader.GetString(2),
                        FirstName = reader.GetString(3),
                        Patronymic = reader.GetString(4),
                        Birthday = new DateTime(reader.GetInt64(5))
                    };
                    list.Add(client);
                }
            }
            return list;
        }

        public Client GetById(int id)
        {
            List<Client> list = new List<Client>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM clients WHERE ClientId = @ClientId";
                command.Parameters.AddWithValue("@ClientId", id);
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Client client = new Client
                    {
                        ClientId = reader.GetInt32(0),
                        Document = reader.GetString(1),
                        SurName = reader.GetString(2),
                        FirstName = reader.GetString(3),
                        Patronymic = reader.GetString(4),
                        Birthday = new DateTime(reader.GetInt64(5))
                    };
                    return client;
                }
            }
            return null;
        }

        public int Update(Client item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                //Прописываем в команду SQL-запрос на добавление данных
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE clients SET Document = @Document, SureName = @SureName, FirstName = @FirstName, Patronymic = @Patronymic, Birthday = @Birthday WHERE ClientId = @ClientId";
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Document", item.Document);
                command.Parameters.AddWithValue("@SureName", item.SurName);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
                //Подготовка команды к выполнению
                command.Prepare();
                //Выполнение команды
                return command.ExecuteNonQuery();
            }
        }
    }
}
