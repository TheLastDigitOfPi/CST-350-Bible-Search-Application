using Bible_Search_Application.Models;

namespace Bible_Search_Application.Services
{
    public interface IBibleVerseDataService
    {
        List<BibleVerse> AllVerses();
        List<BibleVerse> SearchVerses(BibleVerse verse);
    }
}
