namespace Responsi2.Data
{
    using Npgsql;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// Repository untuk Proyek - menangani semua database operations
    /// </summary>
    public class ProyekRepository
    {
        private readonly string _connectionString;

        public ProyekRepository()
        {
            _connectionString = GetConnectionString();
        }

        /// <summary>
        /// Baca connection string dari appsettings.json
        /// </summary>
        private string GetConnectionString()
        {
            try
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

                if (!File.Exists(configPath))
                    throw new FileNotFoundException($"appsettings.json tidak ditemukan");

                string jsonContent = File.ReadAllText(configPath);
                using JsonDocument doc = JsonDocument.Parse(jsonContent);

                string? connectionString = doc.RootElement
                    .GetProperty("ConnectionStrings")
                    .GetProperty("DefaultConnection")
                    .GetString();

                if (string.IsNullOrWhiteSpace(connectionString))
                    throw new InvalidOperationException("Connection string tidak ditemukan");

                return connectionString;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error membaca connection string: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Tambah proyek baru ke database
        /// </summary>
        public async Task<int> AddProyekAsync(string namaProyek, string client, int budget)
        {
            try
            {
                using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                string query = @"
     INSERT INTO proyek (nama_proyek, client, budget)
       VALUES (@namaProyek, @client, @budget)
             RETURNING id_proyek;
   ";

                var parameters = new[]
                {
 new NpgsqlParameter("@namaProyek", namaProyek),
        new NpgsqlParameter("@client", client),
         new NpgsqlParameter("@budget", budget)
                };

                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddRange(parameters);

                var result = await command.ExecuteScalarAsync();
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error adding proyek: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Update informasi proyek
        /// </summary>
        public async Task<bool> UpdateProyekAsync(int idProyek, string namaProyek, string client, int budget)
        {
            try
            {
                using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                string query = @"
                    UPDATE proyek
       SET nama_proyek = @namaProyek,
             client = @client,
     budget = @budget
        WHERE id_proyek = @idProyek;
     ";

                var parameters = new[]
                {
      new NpgsqlParameter("@idProyek", idProyek),
      new NpgsqlParameter("@namaProyek", namaProyek),
    new NpgsqlParameter("@client", client),
      new NpgsqlParameter("@budget", budget)
         };

                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddRange(parameters);

                int result = await command.ExecuteNonQueryAsync();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error updating proyek: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Hapus proyek dari database
        /// </summary>
        public async Task<bool> DeleteProyekAsync(int idProyek)
        {
            try
            {
                using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                string query = "DELETE FROM proyek WHERE id_proyek = @idProyek;";
                var parameters = new[] { new NpgsqlParameter("@idProyek", idProyek) };

                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddRange(parameters);

                int result = await command.ExecuteNonQueryAsync();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error deleting proyek: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Dapatkan semua proyek dari database
        /// </summary>
        public async Task<List<(int IdProyek, string NamaProyek, string Client, int Budget)>> GetAllProyekAsync()
        {
            var proyeks = new List<(int IdProyek, string NamaProyek, string Client, int Budget)>();

            try
            {
                using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                string query = "SELECT id_proyek, nama_proyek, client, budget FROM proyek ORDER BY id_proyek;";

                using var command = new NpgsqlCommand(query, connection);
                using var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    int idProyek = reader.GetInt32(0);
                    string namaProyek = reader.GetString(1);
                    string client = reader.GetString(2);
                    int budget = reader.GetInt32(3);

                    proyeks.Add((idProyek, namaProyek, client, budget));
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error retrieving proyeks: {ex.Message}", ex);
            }

            return proyeks;
        }

        /// <summary>
        /// Dapatkan proyek berdasarkan ID
        /// </summary>
        public async Task<(int IdProyek, string NamaProyek, string Client, int Budget)?> GetProyekByIdAsync(int idProyek)
        {
            try
            {
                using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                string query = "SELECT id_proyek, nama_proyek, client, budget FROM proyek WHERE id_proyek = @idProyek;";
                var parameters = new[] { new NpgsqlParameter("@idProyek", idProyek) };

                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddRange(parameters);
                using var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    int id = reader.GetInt32(0);
                    string namaProyek = reader.GetString(1);
                    string client = reader.GetString(2);
                    int budget = reader.GetInt32(3);

                    return (id, namaProyek, client, budget);
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error retrieving proyek: {ex.Message}", ex);
            }

            return null;
        }

        /// <summary>
        /// Cek apakah proyek dengan ID tertentu ada
        /// </summary>
        public async Task<bool> ProyekExistsAsync(int idProyek)
        {
            try
            {
                using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) FROM proyek WHERE id_proyek = @idProyek;";
                var parameters = new[] { new NpgsqlParameter("@idProyek", idProyek) };

                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddRange(parameters);

                var result = await command.ExecuteScalarAsync();
                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error checking proyek existence: {ex.Message}", ex);
            }
        }
    }
}
