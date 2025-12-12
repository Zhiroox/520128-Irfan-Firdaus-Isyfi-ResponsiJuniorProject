namespace Responsi2.Services
{
    using Models;
    using Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Service class untuk menangani business logic
    /// </summary>
    public class DeveloperService
    {
        private readonly DeveloperRepository _developerRepository;
        private readonly ProyekRepository _proyekRepository;

        public DeveloperService()
        {
            _developerRepository = new DeveloperRepository();
            _proyekRepository = new ProyekRepository();
        }

        /// <summary>
        /// Menambah developer baru
        /// </summary>
        public async Task<bool> AddDeveloperAsync(int idProyek, string namaDev, string statusKontrak, string fiturSelesai, int jumlahBug)
        {
            if (idProyek <= 0 || string.IsNullOrWhiteSpace(namaDev) || string.IsNullOrWhiteSpace(statusKontrak) || string.IsNullOrWhiteSpace(fiturSelesai))
            {
                return false;
            }

            try
            {
                if (!await _proyekRepository.ProyekExistsAsync(idProyek))
                    return false;

                int result = await _developerRepository.AddDeveloperAsync(idProyek, namaDev, statusKontrak, fiturSelesai, jumlahBug);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update informasi developer
        /// </summary>
        public async Task<bool> UpdateDeveloperAsync(int idDev, int idProyek, string namaDev, string statusKontrak, string fiturSelesai, int jumlahBug)
        {
            if (idDev <= 0 || idProyek <= 0 || string.IsNullOrWhiteSpace(namaDev) || string.IsNullOrWhiteSpace(statusKontrak) || string.IsNullOrWhiteSpace(fiturSelesai))
            {
                return false;
            }

            try
            {
                if (!await _proyekRepository.ProyekExistsAsync(idProyek))
                    return false;

                return await _developerRepository.UpdateDeveloperAsync(idDev, idProyek, namaDev, statusKontrak, fiturSelesai, jumlahBug);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Hapus developer dari daftar
        /// </summary>
        public async Task<bool> DeleteDeveloperAsync(int idDev)
        {
            try
            {
                return await _developerRepository.DeleteDeveloperAsync(idDev);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Dapatkan semua developer
        /// </summary>
        public async Task<List<Developer>> GetAllDevelopersAsync()
        {
            try
            {
                var data = await _developerRepository.GetAllDevelopersAsync();
                return data.Select(d => new Developer
                {
                    Id = d.IdDev,
                    IdProyek = d.IdProyek,
                    NamaDev = d.NamaDev,
                    StatusKontrak = d.StatusKontrak,
                    FiturSelesai = d.FiturSelesai,
                    JumlahBug = d.JumlahBug
                }).ToList();
            }
            catch
            {
                return new List<Developer>();
            }
        }

        /// <summary>
        /// Dapatkan developer berdasarkan ID
        /// </summary>
        public async Task<Developer?> GetDeveloperByIdAsync(int idDev)
        {
            try
            {
                var data = await _developerRepository.GetDeveloperByIdAsync(idDev);
                if (data.HasValue)
                {
                    return new Developer
                    {
                        Id = data.Value.IdDev,
                        IdProyek = data.Value.IdProyek,
                        NamaDev = data.Value.NamaDev,
                        StatusKontrak = data.Value.StatusKontrak,
                        FiturSelesai = data.Value.FiturSelesai,
                        JumlahBug = data.Value.JumlahBug
                    };
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Dapatkan developer berdasarkan proyek
        /// </summary>
        public async Task<List<Developer>> GetDevelopersByProyekAsync(int idProyek)
        {
            try
            {
                var data = await _developerRepository.GetDevelopersByProyekAsync(idProyek);
                return data.Select(d => new Developer
                {
                    Id = d.IdDev,
                    IdProyek = d.IdProyek,
                    NamaDev = d.NamaDev,
                    StatusKontrak = d.StatusKontrak,
                    FiturSelesai = d.FiturSelesai,
                    JumlahBug = d.JumlahBug
                }).ToList();
            }
            catch
            {
                return new List<Developer>();
            }
        }

        // ==== PROYEK METHODS ====

        /// <summary>
        /// Menambah proyek baru
        /// </summary>
        public async Task<bool> AddProyekAsync(string namaProyek, string client, int budget)
        {
            if (string.IsNullOrWhiteSpace(namaProyek) || string.IsNullOrWhiteSpace(client) || budget <= 0)
            {
                return false;
            }

            try
            {
                int result = await _proyekRepository.AddProyekAsync(namaProyek, client, budget);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update informasi proyek
        /// </summary>
        public async Task<bool> UpdateProyekAsync(int idProyek, string namaProyek, string client, int budget)
        {
            if (idProyek <= 0 || string.IsNullOrWhiteSpace(namaProyek) || string.IsNullOrWhiteSpace(client) || budget <= 0)
            {
                return false;
            }

            try
            {
                return await _proyekRepository.UpdateProyekAsync(idProyek, namaProyek, client, budget);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Hapus proyek
        /// </summary>
        public async Task<bool> DeleteProyekAsync(int idProyek)
        {
            try
            {
                return await _proyekRepository.DeleteProyekAsync(idProyek);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Dapatkan semua proyek
        /// </summary>
        public async Task<List<Proyek>> GetAllProyekAsync()
        {
            try
            {
                var data = await _proyekRepository.GetAllProyekAsync();
                return data.Select(p => new Proyek
                {
                    Id = p.IdProyek,
                    NamaProyek = p.NamaProyek,
                    Client = p.Client,
                    Budget = p.Budget
                }).ToList();
            }
            catch
            {
                return new List<Proyek>();
            }
        }

        /// <summary>
        /// Dapatkan proyek berdasarkan ID
        /// </summary>
        public async Task<Proyek?> GetProyekByIdAsync(int idProyek)
        {
            try
            {
                var data = await _proyekRepository.GetProyekByIdAsync(idProyek);
                if (data.HasValue)
                {
                    return new Proyek
                    {
                        Id = data.Value.IdProyek,
                        NamaProyek = data.Value.NamaProyek,
                        Client = data.Value.Client,
                        Budget = data.Value.Budget
                    };
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
