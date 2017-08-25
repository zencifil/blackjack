using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace blackjack.DataAccess {
	[Table("PlayLog")]
	public partial class PlayLog {
		public int ID { get; set; }

		[StringLength(50)]
		public string SessionID { get; set; }

		public int? Cash { get; set; }

		public bool? Win { get; set; }

		public int? PutCache { get; set; }

		public DateTime? CreatedDate { get; set; }
	}
}
