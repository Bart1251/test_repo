namespace test
{
    public class AlbumData
    {
        public string? Artist { get; set; }
        public string? Album { get; set; }
        public int SongsNumber { get; set; }
        public int Year { get; set; }
        public int DownloadNumber { get; set; }

        public static List<AlbumData> ReadAlbumsFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<AlbumData> albums = new List<AlbumData>();
            for (int i =0; i < lines.Length; i += 6)
            { 
                albums.Add(new AlbumData { Artist = lines[i], Album = lines[i + 1], SongsNumber = int.Parse(lines[i + 2]), Year = int.Parse(lines[i + 3]), DownloadNumber = int.Parse(lines[i + 4]) });
            }
            return albums;
        }

        public static void DisplayAlbums(List<AlbumData> albums)
        {
            foreach (AlbumData album in albums)
            {
                Console.WriteLine(album.Artist);
                Console.WriteLine(album.Album);
                Console.WriteLine(album.SongsNumber);
                Console.WriteLine(album.Year);
                Console.WriteLine(album.DownloadNumber);
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<AlbumData> albums = AlbumData.ReadAlbumsFromFile("Data.txt");
            AlbumData.DisplayAlbums(albums);
        }
    }
}
