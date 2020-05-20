using System;

namespace _001_operaDarte {
    
    /// <summary>
    /// Classe opera d'arte astratta
    /// </summary>
    [Serializable]
    [System.Xml.Serialization.XmlInclude( typeof( Painting ) )]
    [System.Xml.Serialization.XmlInclude( typeof( Sculpture ) )]
    public abstract class Artwork {
        protected string _title;
        protected string _artist;

        /// <summary>
        /// Costruttore opera d'arte 
        /// </summary>
        protected Artwork( ) {
        }

        /// <summary>
        /// Costruttore opera d'arte
        /// </summary>
        /// <param name="title">Titolo dell'opera d'arte</param>
        /// <param name="artist">Nome dell'artista dell'opera</param>
        public Artwork( string title, string artist ) {
            _title  = title;
            _artist = artist;
        }

        
        /// <summary>
        /// Metodo chje restituisce l'ingombro quindi l'area della scultura o superficie del quadro
        /// </summary>
        /// <returns>Area della scultura o superficie del quadro</returns>
        public abstract double Obstruction( );

        /// <summary>
        /// Proprieta di titolo
        /// </summary>
        public string Title {
            get => _title;
            set => _title = value;
        }

        /// <summary>
        /// Proprieta di artista
        /// </summary>
        public string Artist {
            get => _artist;
            set => _artist = value;
        }

        /// <summary>
        /// Override del metodo equals per determinare se un'opera d'arte è uguale ad un'altra
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Bool che dice se un oggetto è uguale a quello in input</returns>
        public override bool Equals( object? obj ) {
            var other = obj as Artwork;
            return other != null && this.Equals( other );
        }

        /// <summary>
        /// Determina se un'opera d'arte è uguala ad un'altra
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Restituisce true se un'opera d'arte è uguala ad un'altra viceversa false</returns>
        protected bool Equals( Artwork other ) {
            return _title == other._title && _artist == other._artist;
        }
        
        
        /// <summary>
        /// Override del metodo ToString
        /// </summary>
        /// <returns>Restituisce una stringa con i valori della classe</returns>
        public override string ToString( ) {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}";
        }
    }
}