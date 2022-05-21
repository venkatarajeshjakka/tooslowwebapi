using System;
namespace MyFirstWebApi.Helpers
{
	public class QueryParameters
	{
		public QueryParameters()
		{
		}

		const int _maxSize = 100;
		private int _size = 50;

        public int Page { get; set; }

		public int Size
        {
			get
            {
				return _size;
            }

			set
            {
				_size = Math.Min(_maxSize, value);
            }
        }
    }
}

