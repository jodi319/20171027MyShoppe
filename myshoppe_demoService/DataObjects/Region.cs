using System;
using Microsoft.Azure.Mobile.Server;

namespace myshoppe_demoService.DataObjects
{
    public class Region : EntityData
    {
		public int UserId { get; set; } = 0;

		public int WesternCape { get; set; } = 0;
		public int EasternCape { get; set; } = 0;
		public int FreeState { get; set; } = 0;
		public int Gauteng { get; set; } = 0;
		public int KwaZuluNatal { get; set; } = 0;
		public int Limpopo { get; set; } = 0;
		public int Mpumalanga { get; set; } = 0;
		public int NorthernCape { get; set; } = 0;
		public int NorthWest { get; set; } = 0;
    }
}
