namespace Duasembilan.Models
{
	public class KartuRemi
	{
		//jika kita sudahnmembuat enum kita bisa memasukan KembangRemi
		//public KembangRemi Kembang { get; set; }
		//public AngkaRemi Angka { get; set; }

		

		/*public KartuRemi ( KembangRemi kembang, AngkaRemi angka)
		{
			Kembang = kembang;
			Angka = angka;
		}*/

		/*public string KartuName 
		{
			get
			{
				string angka = "";

				switch (Angka)
				{
					case AngkaRemi.As:
						angka = "A";
						break;
					case AngkaRemi.Jek:
						angka = "J";
						break;
					case AngkaRemi.Quen:
						angka = "Q";
						break;
					case AngkaRemi.King:
						angka = "K";
						break;
					default:
						angka = ((int)Angka).ToString();
						break;
				}

				string kembang = "";
				switch (Kembang)
				{
					case KembangRemi.Tempe:
						kembang = "🔶";
						break;
					case KembangRemi.Keriting:
						kembang = "♣️";
						break;
					case KembangRemi.Sekop:
						kembang = "♠️";
						break;
					case KembangRemi.lope:
						kembang = "♥️";
						break;
					default:
						kembang = ((int)Angka).ToString();
						break;
				}

				return $"{angka}{kembang}";

			}

		}*/


	}

	

}
