namespace test.Tests
{
    public class AlbumDataTests
    {
        [Fact]
        public void ReadAlbumsFromFile_GivenPathToExistingTextFile_ReturnsAlbumDataListWithCorrectData()
        {
            //arrange
            string path = "Data.txt";
            List<AlbumData> expected = new List<AlbumData>()
            {
                new AlbumData() { Artist = "Artist1", Album = "\"Album1\"", SongsNumber = 2, Year = 2000, DownloadNumber = 21321 },
                new AlbumData() { Artist = "Artist2", Album = "\"Album2\"", SongsNumber = 5, Year = 2005, DownloadNumber = 231272 },
            };
            string fileContents = "";
            foreach (AlbumData albumData in expected)
            {
                fileContents += albumData.Artist + "\n" + albumData.Album + "\n" + albumData.SongsNumber.ToString() + "\n" + albumData.Year.ToString() + "\n" + albumData.DownloadNumber + "\n\n";
            }
            File.WriteAllText(path, fileContents);
            
            //act
            List<AlbumData> actual = AlbumData.ReadAlbumsFromFile(path);
            File.Delete(path);

            //assert
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equivalent(expected, actual);
        }
    }
}