using Xamarin.Forms;
using Monkeys.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Content;
using Monkeys.Views;

[assembly:ExportCell(typeof(AspectImageCell), typeof(AspectImageCellRenderer))]
namespace Monkeys.Droid.Renderers
{
  public class AspectImageCellRenderer: ImageCellRenderer
	{
    protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, Android.Views.ViewGroup parent, Context context)
		{
      var cell = (LinearLayout)base.GetCellCore(item, convertView, parent, context);
      var image = (ImageView)cell.GetChildAt(0);
      image.SetScaleType(ImageView.ScaleType.CenterCrop);
      return cell;
		}
  }
}