using System;

namespace NMaier.GetOptNet {
	/// <inheritdoc />
	/// <summary>
	///  Defines a short argument.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public sealed class ShortArgumentAttribute : Attribute {
		/// <inheritdoc />
		/// <summary>
		///  Constructor. Supply the short argument name.
		/// </summary>
		/// <param name="arg">ArgumentAttribute name</param>
		public ShortArgumentAttribute(char arg) : this(new string(arg, 1)) { }
		/// <inheritdoc />
		/// <summary>
		///  Constructor. Supply the short argument name.
		/// </summary>
		/// <param name="arg">ArgumentAttribute name</param>
		public ShortArgumentAttribute(string arg) {
			if (arg == null)
				throw new ArgumentNullException(nameof(arg));
			if (string.IsNullOrEmpty(arg.Trim()))
				throw new ArgumentException("You must specify a short argument name", nameof(arg));

			Arg = arg;
		}


		/// <summary>
		///  Returns the assigned argument name. Is always set.
		/// </summary>
		/// <returns>ArgumentAttribute name</returns>
		public string Arg { get; }
	}
}
