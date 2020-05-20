using System;

namespace _001_operaDarte {
	public class Painting : Artwork {
		private double _width;
		private double _height;

		public Painting( ) {
		}

		public Painting ( string title, string artist, double width, double height ) : base( title, artist ) {
			_width = width;
			_height = height;
		}

		public double Width {
			get => _width;
			set => _width = value;
		}

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

		public override double Obstruction ( ) {
			return _width*_height;
		}

		public override string ToString( ) {
			return $"{base.ToString()}, {nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
		}
	}
}