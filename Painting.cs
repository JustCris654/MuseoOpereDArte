using System;

namespace _001_operaDarte {
	
	/// <summary>
	/// Classe quadro derivata dalla classe opera d'arte
	/// </summary>
	public class Painting : Artwork {
		private double _width;
		private double _height;

		/// <summary>
		/// Costruttore con zero parametri
		/// </summary>
		public Painting( ) : base() {
		}

		/// <summary>
		/// Costruttore con tutti i parametri
		/// </summary>
		/// <param name="title">Titolo del quadro</param>
		/// <param name="artist">Nome dell'artista</param>
		/// <param name="width">Larghezza quadro</param>
		/// <param name="height">Altezza quadro</param>
		public Painting ( string title, string artist, double width, double height ) : base( title, artist ) {
			_width = width;
			_height = height;
		}

		/// <summary>
		/// Proprietà larghezza
		/// </summary>
		public double Width {
			get => _width;
			set => _width = value;
		}

		/// <summary>
		/// Proprieta altezza
		/// </summary>
		public double Height {
			get => _height;
			set => _height = value;
		}

		// public string Title2 {
		// 	get => _title;
		// 	set => _title = value;
		// }
		//
		// public string Artist2 {
		// 	get => _artist;
		// 	set => _artist = value;
		// }

		/// <summary>
		/// Ingombro del quadro
		/// </summary>
		/// <returns>Restituisce l'ingombro del quadro quindi la superficie occupata</returns>
		public override double Obstruction ( ) {
			return _width*_height;
		}
		
		/// <summary>
		/// Override del metodo ToString
		/// </summary>
		/// <returns>Restituisce una stringa con i valori della classe</returns>
		public override string ToString( ) {
			return $"{base.ToString()}, {nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
		}
	}
}