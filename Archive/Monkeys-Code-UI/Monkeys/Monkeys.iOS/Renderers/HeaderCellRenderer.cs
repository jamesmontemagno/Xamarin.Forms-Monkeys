using Xamarin.Forms;
using Monkeys.iOS.Renderers;
using Xamarin.Forms.Platform.iOS;
using Monkeys.Views;

[assembly:ExportCell(typeof(HeaderCell), typeof(HeaderCellRenderer))]
namespace Monkeys.iOS.Renderers
{
	public class HeaderCellRenderer: ViewCellRenderer
	{
		public override MonoTouch.UIKit.UITableViewCell GetCell(Cell item, MonoTouch.UIKit.UITableView tv)
		{
			var aspectCell = base.GetCell(item, tv);
			aspectCell.Accessory = MonoTouch.UIKit.UITableViewCellAccessory.None;
			return aspectCell;
		}
	}
}