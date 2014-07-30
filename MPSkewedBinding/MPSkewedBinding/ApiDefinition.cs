using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace MPSkewedBinding {

	[BaseType (typeof (UICollectionViewCell))]
	public partial interface MPSkewedCell {

		[Export ("image")]
		UIImage Image { get; set; }

		[Export ("lineSpacing")]
		int LineSpacing { get; set; }

		[Export ("imageView")]
		UIImageView ImageView { get; set; }

		[Export ("textLabel")]
		UILabel TextLabel { get; set; }

		[Export ("text")]
		string Text { get; set; }

		[Export ("parallaxValue")]
		float ParallaxValue { get; set; }
	}

  [BaseType (typeof (UICollectionViewFlowLayout))]
  public partial interface MPSkewedParallaxLayout {

  }
}
