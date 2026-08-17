/* [grial-metadata] id: Grial#MediaRankingViewModel.cs version: 1.0.6 */
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula;

public class MediaRankingViewModel : ObservableObject
{
    private readonly INavigation _navigation;
    private RankingData _selected;
    private bool _isShowingMovies = true;

    public MediaRankingViewModel(INavigation navigation)
    {
        _navigation = navigation;

        LoadData();
    }

    public ObservableCollection<RankingData> Movies { get; } = new ObservableCollection<RankingData>();
    
    public ObservableCollection<RankingData> TvShows { get; } = new ObservableCollection<RankingData>();
    
    public bool IsShowingMovies
    {
        get => _isShowingMovies;
        set
        {
            if (SetProperty(ref _isShowingMovies, value))
            {
                Selected = value ? Movies.FirstOrDefault() : TvShows.FirstOrDefault();
            }
        }
    }

    public RankingData Selected
    {
        get => _selected;
        set => SetProperty(ref _selected, value);
    }

    private void LoadData()
    {
        Movies.Clear();
        TvShows.Clear();

        JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");

        Selected = Movies.FirstOrDefault();
    }
}
