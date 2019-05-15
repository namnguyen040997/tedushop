using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedushop.Model.Model
{
    [Table("_MigrationHistory")]
    public class _MigrationHistory
    {
        public string MigrationId { get; set; }
        public string ContextKey { get; set; }
        public decimal Model { get; set; }
        public Byte ProductVersion { get; set; }
    }
}
