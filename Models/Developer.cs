namespace Responsi2.Models
{
    
    public class Developer : BaseEntity
    {
        // Private fields
        private int _idProyek;
        private string? _namaDev;
        private string? _statusKontrak;
        private string? _fiturSelesai;
        private int _jumlahBug;

        // Public properties dengan encapsulation
        public int IdProyek
        {
            get { return _idProyek; }
            set { _idProyek = value; }
        }

        public string? NamaDev
        {
            get { return _namaDev; }
            set { _namaDev = value; }
        }

        public string? StatusKontrak
        {
            get { return _statusKontrak; }
            set { _statusKontrak = value; }
        }

        public string? FiturSelesai
        {
            get { return _fiturSelesai; }
            set { _fiturSelesai = value; }
        }

        public int JumlahBug
        {
            get { return _jumlahBug; }
            set { _jumlahBug = value >= 0 ? value : 0; }
        }

        // Calculated property untuk quality score
        public double GetQualityScore()
        {
            if (string.IsNullOrWhiteSpace(_fiturSelesai) || !int.TryParse(_fiturSelesai, out int features))
                return 0;

            if (features == 0) return 0;
            return 100 - ((_jumlahBug / (double)features) * 100);
        }

        // Performance rating berdasarkan quality score
        public string GetPerformanceRating()
        {
            double score = GetQualityScore();
            if (score >= 85) return "Excellent";
            if (score >= 70) return "Good";
            if (score >= 55) return "Average";
            return "Needs Improvement";
        }

        // Validation method
        public bool IsValid()
        {
            return _idProyek > 0 &&
                  !string.IsNullOrWhiteSpace(_namaDev) &&
                  !string.IsNullOrWhiteSpace(_statusKontrak) &&
                  !string.IsNullOrWhiteSpace(_fiturSelesai) &&
                  _jumlahBug >= 0;
        }

        public override string ToString()
        {
            return $"{NamaDev} - {StatusKontrak}";
        }
    }
}
