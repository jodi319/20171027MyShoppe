using System;
using Microsoft.Azure.Mobile.Server;

namespace myshoppe_demoService.DataObjects
{
    public class User : EntityData
    {
		public int Name { get; set; } = 0;
		public int Email { get; set; } = 0;
		public int CellNumber { get; set; } = 0;
		public int TelNumber { get; set; } = 0;
		public int Country { get; set; } = 0;
		public int Province { get; set; } = 0;
    }
}
