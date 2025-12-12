namespace Responsi2.Models
{
    /// <summary>
    /// Model class untuk Proyek
    /// Mengimplementasikan Encapsulation dengan private fields dan public properties
    /// Mewarisi dari BaseEntity (Inheritance)
    /// </summary>
    public class Proyek : BaseEntity
    {
        // Private fields
        private string? _namaProyek;
      private string? _client;
  private int _budget;

   // Public properties dengan encapsulation
        public string? NamaProyek
  {
          get { return _namaProyek; }
set { _namaProyek = value; }
     }

        public string? Client
        {
            get { return _client; }
            set { _client = value; }
        }

   public int Budget
        {
       get { return _budget; }
            set { _budget = value >= 0 ? value : 0; }
    }

        // Validation method
  public bool IsValid()
        {
     return !string.IsNullOrWhiteSpace(_namaProyek) &&
       !string.IsNullOrWhiteSpace(_client) &&
     _budget > 0;
        }

   public override string ToString()
        {
  return $"{NamaProyek} - {Client}";
        }
    }
}
