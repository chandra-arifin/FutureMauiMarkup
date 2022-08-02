using System.Diagnostics;

namespace FutureMauiMarkup.Pages;

public abstract class BasePage<TViewModel> : BasePage 
	where TViewModel : BaseViewModel
{
    protected BasePage(TViewModel viewModel, string? title = null) : base(viewModel, title)
    {
    }

    public new TViewModel BindingContext => (TViewModel)base.BindingContext;
}

public abstract class BasePage : ContentPage
{
    protected BasePage(object? viewModel = null, string? title = null)
    {
        BindingContext = viewModel;
        Padding = 12;

        SetDynamicResource(BackgroundColorProperty, "AppBackgroundColor");

        Title = string.IsNullOrWhiteSpace(title) ? (string.IsNullOrWhiteSpace(Title) ? GetType().Name : Title) : title;
    }


	protected override void OnAppearing()
	{
		base.OnAppearing();

		Debug.WriteLine($"OnAppearing: {Title}");
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();

		Debug.WriteLine($"OnDisappearing: {Title}");
	}
}