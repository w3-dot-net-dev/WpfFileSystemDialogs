namespace Wpf.FileSystem.Dialogs.Converters
{
	using System;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Windows;
	using System.Windows.Data;
	using System.Windows.Interop;
	using System.Windows.Media;
	using System.Windows.Media.Imaging;

	public class DriveTypeToIcon : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			switch ((DriveType)value)
			{
				default:
					break;
			}

			Icon icon = Properties.Resources.FixedDrive;

			ImageSource imageSource = Imaging.CreateBitmapSourceFromHIcon(
				icon.Handle,
				Int32Rect.Empty,
				BitmapSizeOptions.FromEmptyOptions()
			);

			return imageSource;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new InvalidOperationException();
		}
	}
}
