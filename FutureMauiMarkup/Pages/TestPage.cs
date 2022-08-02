namespace FutureMauiMarkup.Pages;

public partial class TestPage : BasePage<TestViewModel>
{
    #region Properties
    private enum Baris
	{
		Date,
        Line,
        Date2,
        Line2,
    };

	private enum Kolom
	{
		Kol1,
		Kol2
	}

    #endregion

    public TestPage(TestViewModel vm) : base(vm, vm.Title)
    {
        Label lblDate1 = new Label().TextCenterVertical().Text("Date"),
            lblLine1 = new Label().TextCenterVertical().Text("Line");

        Label lblDate2 = new Label()
        {
            VerticalTextAlignment = TextAlignment.Center,
        }.Text("Date 2"),
            lblLine2 = new Label()
            {
                VerticalTextAlignment = TextAlignment.Center,
            }.Text("Line 2");

        DatePicker dtpDate1 = new(),
            dtpDate2 = new();

        Entry txtLine1 = new()
        {
            Keyboard = Keyboard.Numeric,
            MaxLength = 11
        },
        txtLine2 = new()
        {
            Keyboard = Keyboard.Numeric,
            MaxLength = 11
        };

        Grid grid = new Grid
        {
            Padding = new(20),
            ColumnSpacing = 20,
            RowSpacing = 20,

            RowDefinitions = Rows.Define(Auto, Auto, Auto, Auto),
            ColumnDefinitions = Columns.Define(Stars(.30), Stars(.70)),
        };

        grid.Add(lblDate1, (int)Kolom.Kol1, (int)Baris.Date);
        grid.Add(dtpDate1, (int)Kolom.Kol2, (int)Baris.Date);

        grid.Add(lblLine1, (int)Kolom.Kol1, (int)Baris.Line);
        grid.Add(txtLine1, (int)Kolom.Kol2, (int)Baris.Line);

        grid.Add(lblDate2, (int)Kolom.Kol1, (int)Baris.Date2);
        grid.Add(dtpDate2, (int)Kolom.Kol2, (int)Baris.Date2);

        grid.Add(lblLine2, (int)Kolom.Kol1, (int)Baris.Line2);
        grid.Add(txtLine2, (int)Kolom.Kol2, (int)Baris.Line2);

        ScrollView scrollView = new()
        {
            Content = grid
        };

        Content = scrollView;
    }
}