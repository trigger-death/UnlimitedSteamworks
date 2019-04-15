using System;

namespace NMaier.GetOptNet {
	/// <inheritdoc />
	/// <summary>
	///  Specifies that an argument will not take a value, but instead will count the number of occurances in the user
	///  supplied arguments.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public sealed class CountedArgumentAttribute : Attribute {
	}
}
