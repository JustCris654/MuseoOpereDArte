using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace _001_operaDarte {
    
    /// <summary>
    /// Classe Collezione di opere d'arte che rappresenta il museo
    /// </summary>
    public class ArtworkCollection {
        private string        _name;
        private string        _location;
        private List<Artwork> _artworks;

        /// <summary>
        /// Costruttore zero parametri
        /// </summary>
        public ArtworkCollection( ) {
            _artworks = new List<Artwork>();
        }


        /// <summary>
        /// Cosruttore con tutti i parametri
        /// </summary>
        /// <param name="name">Nome museo</param>
        /// <param name="location">Nome della localita del museo</param>
        /// <param name="artworks">Lista di opere d'arte gia fatta</param>
        public ArtworkCollection( string name, string location, List<Artwork> artworks ) {
            _name     = name;
            _location = location;
            _artworks = artworks;
        }

        /// <summary>
        /// Costruttore 2 parametri nome e localita
        /// </summary>
        /// <param name="name">Nome museo</param>
        /// <param name="location">Nome della localita del museo</param>
        public ArtworkCollection( string name, string location ) {
            _name     = name;
            _location = location;
            _artworks = new List<Artwork>();
        }

        /// <summary>
        /// Proprieta nome
        /// </summary>
        public string Name {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// Proprieta loaclita
        /// </summary>
        public string Location {
            get => _location;
            set => _location = value;
        }
        
        /// <summary>
        /// Propirieta opere darte 
        /// </summary>
        public List<Artwork> Artworks {
            get => _artworks;
            set => _artworks = value;
        }

        /// <summary>
        /// Metodo per aggiungere un'opera d'arte alla lista
        /// </summary>
        /// <param name="artwork">Opera d'arte da aggiungere</param>
        /// <returns>Booleano che determina l'avvenuta aggiunta (true) o no(false) dell'opera darte</returns>
        public bool AddArtwork( Artwork artwork ) {
            if ( Enumerable.Contains( _artworks, artwork ) ) return false;
            _artworks.Add( artwork );
            return true;
        } //check if this works properly

        /// <summary>
        /// Salva i dati delle opere d'arte in un file xml
        /// </summary>
        /// <param name="path">Percorso del file su cui salvare i dati</param>
        public void SaveXml( string path ) {
            StreamWriter  streamWriter  = new StreamWriter( path );
            Type[]        artwokTypes   = new[] {typeof( Artwork ), typeof( Painting ), typeof( Sculpture )};
            XmlSerializer xmlSerializer = new XmlSerializer( typeof( ArtworkCollection ), artwokTypes );
            xmlSerializer.Serialize( streamWriter, this );
            streamWriter.Close();
        }

        /// <summary>
        /// Legge i dati da un file xml e li salva in una collezione di tipo ArtworColletion 
        /// </summary>
        /// <param name="path">Percorso del file xml</param>
        /// <returns>Collezione di dati letta dal file xml</returns>
        public static ArtworkCollection ReadXml( string path ) {
            StreamReader      streamReader      = new StreamReader( path );
            Type[]            artwokTypes       = new[] {typeof( Artwork ), typeof( Painting ), typeof( Sculpture )};
            XmlSerializer     xmlSerializer     = new XmlSerializer( typeof( ArtworkCollection ), artwokTypes );
            ArtworkCollection artworkCollection = (ArtworkCollection) xmlSerializer.Deserialize( streamReader );
            return artworkCollection;
        }

        /// <summary>
        /// Override del metodo ToString
        /// </summary>
        /// <returns>Restituisce una stringa con i valori della classe</returns>
        public override string ToString( ) {
            return _artworks.Aggregate( $"{nameof(Name)}: {Name}, {nameof(Location)}: {Location}, {nameof(Artworks)}:\n    ",
                                        ( current, artwork ) => current + ( artwork.ToString() + ";\n    " ) );
        }
    }
}