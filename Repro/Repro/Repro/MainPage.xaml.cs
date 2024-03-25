using System.Collections.ObjectModel;

namespace Repro;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        ResetItems();
    }

    public ObservableCollection<TestItem> Items { get; } = new ObservableCollection<TestItem>();

    private void ResetItems()
    {
        Items.Clear();
        Items.Add(new TestItem());
        Items.Add(new TestItem());
        Items.Add(new TestItem());
        Items.Add(new TestItem());
        Items.Add(new TestItem());
    }
}
