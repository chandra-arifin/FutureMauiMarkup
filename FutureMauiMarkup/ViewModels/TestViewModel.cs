namespace FutureMauiMarkup.ViewModels;

public partial class TestViewModel : BaseViewModel
{
    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private bool isControlEnabled;

    private bool _isBusy;
    public bool IsBusy
    {
        get { return _isBusy; }
        set
        {
            SetProperty(ref _isBusy, value);
            IsControlEnabled = !_isBusy;
        }
    }

    public TestViewModel()
    {
        Title = "Test";
    }

}