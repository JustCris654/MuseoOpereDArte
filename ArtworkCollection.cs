using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace _001_operaDarte {
    public class ArtworkCollection {
        private string        _name;
        private string        _location;
        private List<Artwork> _artworks;

        public ArtworkCollection( ) {
        }


        public ArtworkCollection( string name, string location, List<Artwork> artworks ) {
            _name     = name;
            _location = location;
            _artworks = artworks;
        }

        public ArtworkCollection( string name, string location ) {
            _name     = name;
            _location = location;
            _artworks = new List<Artwork>();
        }

        public string Name {
            get => _name;
            set => _name = value;
        }

        public string Location {
            get => _location;
            set => _location = value;
        }

        public List<Artwork> Artworks {
            get => _artworks;
            set => _artworks = value;
        }

        public bool AddArtwork( Artwork artwork ) {
            if ( Enumerable.Contains( _artworks, artwork ) ) return false;
            _artworks.Add( artwork );
            return true;
        } //check if this works properly

        public void SaveXml( string path ) {
            StreamWriter  streamWriter  = new StreamWriter( path );
            Type[]        artwokTypes   = new[] {typeof( Artwork ), typeof( Painting ), typeof( Sculpture )};
            XmlSerializer xmlSerializer = new XmlSerializer( typeof( ArtworkCollection ), artwokTypes );
            xmlSerializer.Serialize( streamWriter, this );
            streamWriter.Close();
        }

        public static ArtworkCollection ReadXml( string path ) {
            StreamReader      streamReader      = new StreamReader( path );
            Type[]            artwokTypes       = new[] {typeof( Artwork ), typeof( Painting ), typeof( Sculpture )};
            XmlSerializer     xmlSerializer     = new XmlSerializer( typeof( ArtworkCollection ), artwokTypes );
            ArtworkCollection artworkCollection = (ArtworkCollection) xmlSerializer.Deserialize( streamReader );
            return artworkCollection;
        }

        public override string ToString( ) {
            return _artworks.Aggregate( $"{nameof(Name)}: {Name}, {nameof(Location)}: {Location}, {nameof(Artworks)}:\n    ",
                                        ( current, artwork ) => current + ( artwork.ToString() + ";\n    " ) );
        }
    }
}