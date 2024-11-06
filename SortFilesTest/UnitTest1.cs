using SortFiles;
namespace SortFilesTest;

public class UnitTest1{

    [Theory]
    [InlineData("GameTitle123 2024:08:10 12:34:56", "GameTitle123")]
    [InlineData("Titanfall 2 2024-10-13 18-14-18.mp4", "Titanfall 2")]
    [InlineData("Another:Game 2023-07-05 14:33:21", "Another:Game")]
    [InlineData("Game:2022 2022/05/02 09.15.44", "Game:2022")]
    [InlineData("Complex-Game_Name 42 2022-09-12", "Complex-Game_Name 42")]
    [InlineData("SimpleGame 2025-12-31", "SimpleGame")]
    [InlineData("Unusual Game with spaces 2020:01:01", "Unusual Game with spaces")]
    [InlineData("Numbers123Game 2019/04/05", "Numbers123Game")]
    [InlineData("NoDateHere", null)]  // No date pattern in the name
    public void ExtractGameName_ShouldReturnCorrectGameName(string input, string expectedGameName)
    {
        // Act
        var result = Program.TrimName(input);

        // Assert
        Assert.Equal(expectedGameName, result);
    }
}