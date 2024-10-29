using Syncfusion.Maui.Core.Internals;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System.Globalization;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataGrid.SelectionController = new CustomRowSelectionController(this.dataGrid);
        }
    }


    public class CustomRowSelectionController : DataGridRowSelectionController
    {
        public CustomRowSelectionController(SfDataGrid dataGrid) : base(dataGrid)
        {
        }

        protected override void ProcessKeyDown(KeyEventArgs args, bool isCtrlKeyPressed, bool isShiftKeyPressed)
        {
            if (args.Key == KeyboardKey.Down)
            {
                var downArgs = new KeyEventArgs(KeyboardKey.Down)
                {
                    Handled = false
                };
                base.ProcessKeyDown(downArgs, isCtrlKeyPressed, isShiftKeyPressed);
                base.ProcessKeyDown(downArgs, isCtrlKeyPressed, isShiftKeyPressed);
            }
            else
            {
                base.ProcessKeyDown(args, isCtrlKeyPressed, isShiftKeyPressed);
            }
        }
    }
}
