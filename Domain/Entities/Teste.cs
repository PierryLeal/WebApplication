using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Domain.Enums;

namespace WebApplication.Domain.entities
{
    [Table("teste")]
    public class Teste
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [Column("birth_date")]
        public DateTime Birth_date { get; set; }
        [Column("cpf")]
        public string Cpf { get; set; } = string.Empty;
        [Column("marital_state")]
        public MaritalStatus? Marital_state { get; set; }
    }
}
