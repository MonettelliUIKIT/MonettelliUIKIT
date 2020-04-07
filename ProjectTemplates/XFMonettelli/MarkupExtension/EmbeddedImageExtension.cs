using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace $safeprojectname$.MarkupExtension
{

	// You exclude the 'Extension' suffix when using in Xaml markup
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

			// Do your translation lookup here, using whatever method you require
			var imageSource = ImageSource.FromResource(Source, typeof(EmbeddedImageExtension).GetTypeInfo().Assembly);

			return imageSource;
		}
	}

}
