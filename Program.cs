using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace _001_operaDarte {
    class Program {
        static void Main( string[] args ) {
            Artwork art1   = new Painting( "monnalisa", "kiko", 43.3f, 43.3f );
            Artwork art2   = new Painting( "monnalisa2", "kiko2", 23.3f, 53.3f );
            Artwork sculp1 = new Sculpture( "diokiko", "jobro", 34.6f, 53.23f, 56.4f );
            Artwork sculp2 = new Sculpture( "kukamatusa", "raptus", 254.3f, 53.3f, 67.7f );

            ArtworkCollection artworkCollection =
                new ArtworkCollection( "Museo", "Verona", new List<Artwork>() {art1, sculp1} );
            
            Console.WriteLine(artworkCollection.AddArtwork(art2));
            Console.WriteLine(artworkCollection.AddArtwork(sculp2));

            Console.ReadKey();
            
            Console.WriteLine(artworkCollection.AddArtwork(sculp1));
            
            Console.ReadKey();
            
            //legge il file precedentemente salvato (nell'esecuzione prima) e lo stampa
            ArtworkCollection readedFromXml = ArtworkCollection.ReadXml( "./../../../artworks.xml" );
            Console.WriteLine(readedFromXml);

            artworkCollection.SaveXml("./../../../artworks.xml");

        }
    }
}
