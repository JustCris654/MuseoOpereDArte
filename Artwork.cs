using System;

namespace _001_operaDarte {
	[Serializable]
	[System.Xml.Serialization.XmlInclude(typeof(Painting))]
	[System.Xml.Serialization.XmlInclude(typeof(Sculpture))]
	public abstract class Artwork {
		protected string _title;
		protected string _artist;

		protected Artwork( ) {
		}

		public Artwork ( string title, string artist ) {
			_title = title;
			_artist = artist;
		}

		public abstract double Obstruction ( );

		public string Title {
			get => _title;
			set => _title = value;
		}

		public string Artist {
			get => _artist;
			set => _artist = value;
		}

		public override bool Equals ( object? obj ) {
			var other = obj as Artwork;
			return other != null && this.Equals( other );
		}

		protected bool Equals ( Artwork other ) {
			return _title == other._title && _artist == other._artist;
		}

		public override int GetHashCode ( ) {
			return HashCode.Combine( _title, _artist );
		}

		public override string ToString( ) {
			return $"{nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}";
		}
	}
}