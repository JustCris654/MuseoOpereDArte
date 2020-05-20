using System;

namespace _001_operaDarte {
	
	/// <summary>
	/// Classe scultura derivata dalla classe opera d'arte
	/// </summary>
	public class Sculpture : Artwork {
		private double _height;
		private double _width;
		private double _depth;

		/// <summary>
		/// Costruttore con zero parametri
		/// </summary>
		public Sculpture( ) {
		}
	
		/// <summary>
		/// Costruttore con tutti i parametri
		/// </summary>
		/// <param name="title">Titolo del quadro</param>
		/// <param name="artist">Nome dell'artista</param>
		/// <param name="width">Larghezza quadro</param>
		/// <param name="depth">Profondità della scultura</param>
		public Sculpture ( string title, string artist, double height, double width, double depth ) : base( title,
		                                                                                                    artist ) {
			_height = height;
			_width  = width;
			_depth  = depth;
		}

		/// <summary>
		/// Proprietà larghezza
		/// </summary>
		public double Height {
			get => _height;
			set => _height = value;
		}

		/// <summary>
		/// Proprieta altezza
		/// </summary>
		public double Width {
			get => _width;
			set => _width = value;
		}

		/// <summary>
		/// Proprieta profondità
		/// </summary>
		public double Depth {
			get => _depth;
			set => _depth = value;
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
		/// Ingombro della scultura
		/// </summary>
		/// <returns>Restituisce l'ingombro della scultura quindi il volume occupato</returns>
		public override double Obstruction ( ) {
			return _width * _height * _depth;
		}

		/// <summary>
		/// Override del metodo ToString
		/// </summary>
		/// <returns>Restituisce una stringa con i valori della classe</returns>
		public override string ToString( ) {
			return $"{base.ToString()}, {nameof(Height)}: {Height}, {nameof(Width)}: {Width}, {nameof(Depth)}: {Depth}";
		}
	}
}