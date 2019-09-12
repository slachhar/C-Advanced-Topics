﻿namespace Generics
{
	public class Nullable<T> where T : struct
	{
		private object _value;
		public Nullable()
		{

		}
		public Nullable(T value)
		{
			_value = value;
		}

		public bool HasValue => _value != null;

		public T GetValueorDefault()
		{
			if (HasValue)
			{
				return (T) _value;
			}

			return default(T);
		}
	}
}