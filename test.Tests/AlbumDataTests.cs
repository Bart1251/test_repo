namespace test.Tests
{
    public class AlbumDataTests
    {
        [Fact]
        public void ReadAlbumsFromFile_GivenPathToExistingTextFile_ReturnsAlbumDataListWithCorrectData()
        {
            string path = "Data.txt";
            List<AlbumData> actual = AlbumData.ReadAlbumsFromFile(path);
            List<AlbumData> expected = new List<AlbumData>()
            {
                new AlbumData() { Artist = "Artist1", Album = "\"Album1\"", SongsNumber = 2, Year = 2000, DownloadNumber = 21321 },
                new AlbumData() { Artist = "Artist2", Album = "\"Album2\"", SongsNumber = 5, Year = 2005, DownloadNumber = 231272 },
            };
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equivalent(expected, actual);
        }
    }
}