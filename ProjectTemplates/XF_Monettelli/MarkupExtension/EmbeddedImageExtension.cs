using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace $safeprojectname$.MarkupExtension
{
	[ContentProperty("Source")]
	public class EmbeddedImageExtension : IMarkupExtension
	{
		public string Source { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Source == null)
			{
				return null;
			}

			var imageSource = ImageSource.FromResource(Source, typeof(EmbeddedImageExtension).GetTypeInfo().Assembly);

			return imageSource;
		}
	}

}
