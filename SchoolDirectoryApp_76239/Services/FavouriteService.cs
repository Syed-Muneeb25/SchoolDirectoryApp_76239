namespace SchoolDirectoryApp_76239.Services

public class FavouritesService {
        private readonly HashSet<int> _ids = new();

        public int Count => _ids.Count;

        public bool IsFavourite(int schoolId)  // Remembers which schools are favourites

    {
        return _ids.Contains(schoolId);
        }

        public void Toggle(int schoolId)
        {
            if (!_ids.Add(schoolId))   // Add the school if its not favourite, remove it if it is
        {
                _ids.Remove(schoolId);
            }
        }
    }

