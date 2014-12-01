using System;

namespace Com.Parse {

	[global::Android.Runtime.Annotation ("com.parse.ParseClassName")]
	public partial class ParseClassNameAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
