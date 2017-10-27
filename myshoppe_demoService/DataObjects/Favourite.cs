using System;
using Microsoft.Azure.Mobile.Server;

namespace myshoppe_demoService.DataObjects
{
    public class Favourite : EntityData
    {
		//string id;
		//int fashionAndBeauty;
		//int sportsAndOutdoor;
		//int pets;
		//int vehicles;
		//int homeImprovement;
		//int babiesChildren;
		//int hobbiesInterests;
		//int mobilePhonesAndAccessories;
		//int homeAppliances;
		//int gaming;
		//int books;
		//int music;

		//bool done;

		//FASHION & BEAUTY,
		//    SPORTS & OUTDOOR,
		//    PETS,
		//    VEHICLES,
		//    HOME IMPROVEMENT, 
		//    BABIES/CHILDREN,
		//    HOBBIES/INTERESTS,
		//    MOBILE PHONES & ACCESSORIES,
		//    HOME APPLIANCES, 
		//    GAMING, 
		//    BOOKS, 
		//    MUSIC



		//[JsonProperty("userId")]
		//public string UserId { get; set; }

		//[JsonProperty(PropertyName = "id")]
		//public string Id { get; set; }

		//public override string ToString() =>
		//$"{nameof(Name)}: {Name} ";

		//[JsonProperty(PropertyName = "FashionAndBeauty")]
		//public int FashionAndBeauty { get; set; }

		//[JsonProperty(PropertyName = "SportsAndOutdoor")]
		//public int SportsAndOutdoor { get; set; }

		//[JsonProperty(PropertyName = "Pets")]
		//public int Pets { get; set; }

		//[JsonProperty(PropertyName = "Vehicles")]
		//public int Vehicles { get; set; }

		//[JsonProperty(PropertyName = "HomeImprovement")]
		//public int HomeImprovement { get; set; }

		//[JsonProperty(PropertyName = "BabiesChildren")]
		//public int BabiesChildren { get; set; }



		//[JsonProperty(PropertyName = "HobbiesInterests")]
		//public int HobbiesInterests { get; set; }

		//[JsonProperty(PropertyName = "MobilePhonesAndAccessories")]
		//public int MobilePhonesAndAccessories { get; set; }

		//[JsonProperty(PropertyName = "HomeAppliances")]
		//public int HomeAppliances { get; set; }

		//[JsonProperty(PropertyName = "Gaming")]
		//public int Gaming { get; set; }

		//[JsonProperty(PropertyName = "Books")]
		//public int Books { get; set; }

		//[JsonProperty(PropertyName = "Music")]
		//public int Music { get; set; }

		//[JsonProperty(PropertyName = "complete")]
		//public bool Done
		//{
		//    get { return done; }
		//    set { done = value; }
		//}

		//[Version]
		//public string Version { get; set; }
		//}










		//[JsonProperty(PropertyName = "id")]
		//public string Id { get; set; }

		public int UserId { get; set; } = 0;

		//[Microsoft.WindowsAzure.MobileServices.Version]
		//public string Version { get; set; } = string.Empty;

		public int FashionAndBeauty { get; set; } = 0;
		public int SportsAndOutdoor { get; set; } = 0;

		public int Pets { get; set; } = 0;
		public int Vehicles { get; set; } = 0;
		public int HomeImprovement { get; set; } = 0;
		public int BabiesChildren { get; set; } = 0;
		public int HobbiesInterests { get; set; } = 0;
		public int MobilePhonesAndAccessories { get; set; } = 0;
		public int HomeAppliances { get; set; } = 0;
		public int Gaming { get; set; } = 0;
		public int Books { get; set; } = 0;
		public int Music { get; set; } = 0;

    }
}
