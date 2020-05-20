using System;

namespace _001_operaDarte {
	public class Sculpture : Artwork {
		private double _height;
		private double _width;
		private double _depth;

		public Sculpture( ) {
		}

		public Sculpture ( string title, string artist, double height, double width, double depth ) : base( title,
		                                                                                                    artist ) {
			_height = height;
			_width  = width;
			_depth  = depth;
		}

		public double Height {
			get => _height;
			set => _height = value;
		}

		public double Width {
			get => _width;
			set => _width = value;
		}

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

		public override double Obstruction ( ) {
			return _width * _height * _depth;
		}

		public override string ToString( ) {
			return $"{base.ToString()}, {nameof(Height)}: {Height}, {nameof(Width)}: {Width}, {nameof(Depth)}: {Depth}";
		}
	}
}